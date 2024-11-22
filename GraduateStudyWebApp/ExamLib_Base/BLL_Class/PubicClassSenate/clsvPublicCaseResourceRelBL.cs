
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPublicCaseResourceRelBL
 表名:vPublicCaseResourceRel(01120406)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:54
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
public static class  clsvPublicCaseResourceRelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPublicCaseResourceRelEN GetObj(this K_IdPubClassCaseResourceRel_vPublicCaseResourceRel myKey)
{
clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = clsvPublicCaseResourceRelBL.vPublicCaseResourceRelDA.GetObjByIdPubClassCaseResourceRel(myKey.Value);
return objvPublicCaseResourceRelEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIdPubClassCaseResourceRel(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, long lngIdPubClassCaseResourceRel, string strComparisonOp="")
	{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = lngIdPubClassCaseResourceRel; //案例与资源关系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IdPubClassCaseResourceRel) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IdPubClassCaseResourceRel, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IdPubClassCaseResourceRel] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIdPubClassCase(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strIdPubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCase, convPublicCaseResourceRel.IdPubClassCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, convPublicCaseResourceRel.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, convPublicCaseResourceRel.IdPubClassCase);
}
objvPublicCaseResourceRelEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IdPubClassCase) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IdPubClassCase, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IdPubClassCase] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPublicCaseResourceRel.PubClassCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPublicCaseResourceRel.PubClassCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseExecutor(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPublicCaseResourceRel.PubClassCaseExecutor);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseTheme(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, convPublicCaseResourceRel.PubClassCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseTeachDate(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPublicCaseResourceRel.PubClassCaseTeachDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPublicCaseResourceRel.PubClassCaseTeachDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseDateIn(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, convPublicCaseResourceRel.PubClassCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, convPublicCaseResourceRel.PubClassCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIdDiscipline(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convPublicCaseResourceRel.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convPublicCaseResourceRel.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convPublicCaseResourceRel.IdDiscipline);
}
objvPublicCaseResourceRelEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IdDiscipline) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IdDiscipline, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IdDiscipline] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetDisciplineID(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convPublicCaseResourceRel.DisciplineID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convPublicCaseResourceRel.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convPublicCaseResourceRel.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetDisciplineName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convPublicCaseResourceRel.DisciplineName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPublicCaseResourceRel.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIdTeachingPlan(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convPublicCaseResourceRel.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convPublicCaseResourceRel.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convPublicCaseResourceRel.IdTeachingPlan);
}
objvPublicCaseResourceRelEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IdTeachingPlan) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IdTeachingPlan, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IdTeachingPlan] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetSubjectName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubjectName, convPublicCaseResourceRel.SubjectName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubjectName, 200, convPublicCaseResourceRel.SubjectName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingPlanAuthor(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingPlanAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanAuthor, 50, convPublicCaseResourceRel.TeachingPlanAuthor);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingObject(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingObject, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingObject, 5000, convPublicCaseResourceRel.TeachingObject);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingEmphases(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingEmphases, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingEmphases, 5000, convPublicCaseResourceRel.TeachingEmphases);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingDifficulty(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingDifficulty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingDifficulty, 5000, convPublicCaseResourceRel.TeachingDifficulty);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingTool(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingTool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingTool, 5000, convPublicCaseResourceRel.TeachingTool);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingProcess(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingProcess, 8000, convPublicCaseResourceRel.TeachingProcess);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetTeachingPlanType(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strTeachingPlanType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanType, 1, convPublicCaseResourceRel.TeachingPlanType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingPlanType, 1, convPublicCaseResourceRel.TeachingPlanType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubClassCaseTimeIn(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubClassCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTimeIn, 6, convPublicCaseResourceRel.PubClassCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTimeIn, 6, convPublicCaseResourceRel.PubClassCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetPubCaseTypeName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strPubCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPublicCaseResourceRel.PubCaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIdStudyLevel(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convPublicCaseResourceRel.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convPublicCaseResourceRel.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convPublicCaseResourceRel.IdStudyLevel);
}
objvPublicCaseResourceRelEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IdStudyLevel) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IdStudyLevel, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IdStudyLevel] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetStudyLevelName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convPublicCaseResourceRel.StudyLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPublicCaseResourceRel.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIntroduction(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strIntroduction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIntroduction, 4000, convPublicCaseResourceRel.Introduction);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetRecommendedDegreeId(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convPublicCaseResourceRel.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convPublicCaseResourceRel.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetRecommendedDegreeName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convPublicCaseResourceRel.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIdResource(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convPublicCaseResourceRel.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convPublicCaseResourceRel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convPublicCaseResourceRel.IdResource);
}
objvPublicCaseResourceRelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IdResource) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IdResource, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IdResource] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetResourceID(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convPublicCaseResourceRel.ResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convPublicCaseResourceRel.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convPublicCaseResourceRel.ResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetResourceName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convPublicCaseResourceRel.ResourceName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIdFtpResource(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convPublicCaseResourceRel.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convPublicCaseResourceRel.IdFtpResource);
}
objvPublicCaseResourceRelEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IdFtpResource) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IdFtpResource, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IdFtpResource] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIdFile(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convPublicCaseResourceRel.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convPublicCaseResourceRel.IdFile);
}
objvPublicCaseResourceRelEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IdFile) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IdFile, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IdFile] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convPublicCaseResourceRel.FileName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileType(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convPublicCaseResourceRel.FileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetSaveDate(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convPublicCaseResourceRel.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convPublicCaseResourceRel.SaveDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileSize(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convPublicCaseResourceRel.FileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetSaveTime(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convPublicCaseResourceRel.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convPublicCaseResourceRel.SaveTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFtpResourceID(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convPublicCaseResourceRel.FtpResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convPublicCaseResourceRel.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convPublicCaseResourceRel.FtpResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileOriginalName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convPublicCaseResourceRel.FileOriginalName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileDirName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convPublicCaseResourceRel.FileDirName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileRename(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convPublicCaseResourceRel.FileRename);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileUpDate(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convPublicCaseResourceRel.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convPublicCaseResourceRel.FileUpDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileUpTime(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convPublicCaseResourceRel.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convPublicCaseResourceRel.FileUpTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIdResourceType(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, convPublicCaseResourceRel.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convPublicCaseResourceRel.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convPublicCaseResourceRel.IdResourceType);
}
objvPublicCaseResourceRelEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPublicCaseResourceRelEN.dicFldComparisonOp.ContainsKey(convPublicCaseResourceRel.IdResourceType) == false)
{
objvPublicCaseResourceRelEN.dicFldComparisonOp.Add(convPublicCaseResourceRel.IdResourceType, strComparisonOp);
}
else
{
objvPublicCaseResourceRelEN.dicFldComparisonOp[convPublicCaseResourceRel.IdResourceType] = strComparisonOp;
}
}
return objvPublicCaseResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetResourceTypeID(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convPublicCaseResourceRel.ResourceTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convPublicCaseResourceRel.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convPublicCaseResourceRel.ResourceTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetResourceTypeName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convPublicCaseResourceRel.ResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convPublicCaseResourceRel.ResourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetResourceOwner(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convPublicCaseResourceRel.ResourceOwner);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convPublicCaseResourceRel.ResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetftpFileType(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convPublicCaseResourceRel.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetftpFileSize(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convPublicCaseResourceRel.ftpFileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetftpResourceOwner(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convPublicCaseResourceRel.ftpResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileOriginName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convPublicCaseResourceRel.FileOriginName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileNewName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convPublicCaseResourceRel.FileNewName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetFileOldName(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convPublicCaseResourceRel.FileOldName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetIndexNO(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, int? intIndexNO, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetMemo(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPublicCaseResourceRel.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPublicCaseResourceRelEN SetBrowseCount(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN, int? intBrowseCount, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelENS">源对象</param>
 /// <param name = "objvPublicCaseResourceRelENT">目标对象</param>
 public static void CopyTo(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelENS, clsvPublicCaseResourceRelEN objvPublicCaseResourceRelENT)
{
try
{
objvPublicCaseResourceRelENT.IdPubClassCaseResourceRel = objvPublicCaseResourceRelENS.IdPubClassCaseResourceRel; //案例与资源关系表流水号
objvPublicCaseResourceRelENT.IdPubClassCase = objvPublicCaseResourceRelENS.IdPubClassCase; //案例流水号
objvPublicCaseResourceRelENT.PubClassCaseName = objvPublicCaseResourceRelENS.PubClassCaseName; //案例课题名称
objvPublicCaseResourceRelENT.PubClassCaseExecutor = objvPublicCaseResourceRelENS.PubClassCaseExecutor; //案例执教者
objvPublicCaseResourceRelENT.PubClassCaseTheme = objvPublicCaseResourceRelENS.PubClassCaseTheme; //案例主题词
objvPublicCaseResourceRelENT.PubClassCaseBG = objvPublicCaseResourceRelENS.PubClassCaseBG; //案例背景资料
objvPublicCaseResourceRelENT.PubClassCaseTeachDate = objvPublicCaseResourceRelENS.PubClassCaseTeachDate; //案例授课日期
objvPublicCaseResourceRelENT.PubClassCaseDateIn = objvPublicCaseResourceRelENS.PubClassCaseDateIn; //案例入库日期
objvPublicCaseResourceRelENT.IdDiscipline = objvPublicCaseResourceRelENS.IdDiscipline; //学科流水号
objvPublicCaseResourceRelENT.DisciplineID = objvPublicCaseResourceRelENS.DisciplineID; //学科ID
objvPublicCaseResourceRelENT.DisciplineName = objvPublicCaseResourceRelENS.DisciplineName; //学科名称
objvPublicCaseResourceRelENT.IdTeachingPlan = objvPublicCaseResourceRelENS.IdTeachingPlan; //教案流水号
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
objvPublicCaseResourceRelENT.IdStudyLevel = objvPublicCaseResourceRelENS.IdStudyLevel; //id_StudyLevel
objvPublicCaseResourceRelENT.StudyLevelName = objvPublicCaseResourceRelENS.StudyLevelName; //学段名称
objvPublicCaseResourceRelENT.Introduction = objvPublicCaseResourceRelENS.Introduction; //简要介绍
objvPublicCaseResourceRelENT.CaseIsVisible = objvPublicCaseResourceRelENS.CaseIsVisible; //CaseIsVisible
objvPublicCaseResourceRelENT.IsDualVideo = objvPublicCaseResourceRelENS.IsDualVideo; //是否双视频
objvPublicCaseResourceRelENT.RecommendedDegreeId = objvPublicCaseResourceRelENS.RecommendedDegreeId; //推荐度Id
objvPublicCaseResourceRelENT.RecommendedDegreeName = objvPublicCaseResourceRelENS.RecommendedDegreeName; //推荐度名称
objvPublicCaseResourceRelENT.IdResource = objvPublicCaseResourceRelENS.IdResource; //资源流水号
objvPublicCaseResourceRelENT.ResourceID = objvPublicCaseResourceRelENS.ResourceID; //资源ID
objvPublicCaseResourceRelENT.ResourceName = objvPublicCaseResourceRelENS.ResourceName; //资源名称
objvPublicCaseResourceRelENT.IdFtpResource = objvPublicCaseResourceRelENS.IdFtpResource; //FTP资源流水号
objvPublicCaseResourceRelENT.IdFile = objvPublicCaseResourceRelENS.IdFile; //文件流水号
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
objvPublicCaseResourceRelENT.IdResourceType = objvPublicCaseResourceRelENS.IdResourceType; //资源类型流水号
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
 /// <param name = "objvPublicCaseResourceRelENS">源对象</param>
 /// <returns>目标对象=>clsvPublicCaseResourceRelEN:objvPublicCaseResourceRelENT</returns>
 public static clsvPublicCaseResourceRelEN CopyTo(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelENS)
{
try
{
 clsvPublicCaseResourceRelEN objvPublicCaseResourceRelENT = new clsvPublicCaseResourceRelEN()
{
IdPubClassCaseResourceRel = objvPublicCaseResourceRelENS.IdPubClassCaseResourceRel, //案例与资源关系表流水号
IdPubClassCase = objvPublicCaseResourceRelENS.IdPubClassCase, //案例流水号
PubClassCaseName = objvPublicCaseResourceRelENS.PubClassCaseName, //案例课题名称
PubClassCaseExecutor = objvPublicCaseResourceRelENS.PubClassCaseExecutor, //案例执教者
PubClassCaseTheme = objvPublicCaseResourceRelENS.PubClassCaseTheme, //案例主题词
PubClassCaseBG = objvPublicCaseResourceRelENS.PubClassCaseBG, //案例背景资料
PubClassCaseTeachDate = objvPublicCaseResourceRelENS.PubClassCaseTeachDate, //案例授课日期
PubClassCaseDateIn = objvPublicCaseResourceRelENS.PubClassCaseDateIn, //案例入库日期
IdDiscipline = objvPublicCaseResourceRelENS.IdDiscipline, //学科流水号
DisciplineID = objvPublicCaseResourceRelENS.DisciplineID, //学科ID
DisciplineName = objvPublicCaseResourceRelENS.DisciplineName, //学科名称
IdTeachingPlan = objvPublicCaseResourceRelENS.IdTeachingPlan, //教案流水号
SubjectName = objvPublicCaseResourceRelENS.SubjectName, //课题名称
TeachingPlanAuthor = objvPublicCaseResourceRelENS.TeachingPlanAuthor, //教案撰写人
TeachingObject = objvPublicCaseResourceRelENS.TeachingObject, //教学目标
TeachingEmphases = objvPublicCaseResourceRelENS.TeachingEmphases, //教学重点
TeachingDifficulty = objvPublicCaseResourceRelENS.TeachingDifficulty, //教学难点
TeachingTool = objvPublicCaseResourceRelENS.TeachingTool, //教学用具
TeachingProcess = objvPublicCaseResourceRelENS.TeachingProcess, //教学过程
TeachingPlanType = objvPublicCaseResourceRelENS.TeachingPlanType, //教案类型
SimplePlanContent = objvPublicCaseResourceRelENS.SimplePlanContent, //简案内容
PubClassCaseTimeIn = objvPublicCaseResourceRelENS.PubClassCaseTimeIn, //案例入库时间
PubCaseTypeName = objvPublicCaseResourceRelENS.PubCaseTypeName, //公开课案例类型名称
IdStudyLevel = objvPublicCaseResourceRelENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvPublicCaseResourceRelENS.StudyLevelName, //学段名称
Introduction = objvPublicCaseResourceRelENS.Introduction, //简要介绍
CaseIsVisible = objvPublicCaseResourceRelENS.CaseIsVisible, //CaseIsVisible
IsDualVideo = objvPublicCaseResourceRelENS.IsDualVideo, //是否双视频
RecommendedDegreeId = objvPublicCaseResourceRelENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvPublicCaseResourceRelENS.RecommendedDegreeName, //推荐度名称
IdResource = objvPublicCaseResourceRelENS.IdResource, //资源流水号
ResourceID = objvPublicCaseResourceRelENS.ResourceID, //资源ID
ResourceName = objvPublicCaseResourceRelENS.ResourceName, //资源名称
IdFtpResource = objvPublicCaseResourceRelENS.IdFtpResource, //FTP资源流水号
IdFile = objvPublicCaseResourceRelENS.IdFile, //文件流水号
FileName = objvPublicCaseResourceRelENS.FileName, //文件名称
FileType = objvPublicCaseResourceRelENS.FileType, //文件类型
SaveDate = objvPublicCaseResourceRelENS.SaveDate, //创建日期
FileSize = objvPublicCaseResourceRelENS.FileSize, //文件大小
SaveTime = objvPublicCaseResourceRelENS.SaveTime, //创建时间
FtpResourceID = objvPublicCaseResourceRelENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvPublicCaseResourceRelENS.FileOriginalName, //文件原名
FileDirName = objvPublicCaseResourceRelENS.FileDirName, //文件目录名
FileRename = objvPublicCaseResourceRelENS.FileRename, //文件新名
FileUpDate = objvPublicCaseResourceRelENS.FileUpDate, //创建日期
FileUpTime = objvPublicCaseResourceRelENS.FileUpTime, //创建时间
SaveMode = objvPublicCaseResourceRelENS.SaveMode, //文件存放方式
IdResourceType = objvPublicCaseResourceRelENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvPublicCaseResourceRelENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvPublicCaseResourceRelENS.ResourceTypeName, //资源类型名称
ResourceOwner = objvPublicCaseResourceRelENS.ResourceOwner, //上传者
ftpFileType = objvPublicCaseResourceRelENS.ftpFileType, //ftp文件类型
ftpFileSize = objvPublicCaseResourceRelENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvPublicCaseResourceRelENS.ftpResourceOwner, //Ftp资源拥有者
FileOriginName = objvPublicCaseResourceRelENS.FileOriginName, //原文件名
IsExistFile = objvPublicCaseResourceRelENS.IsExistFile, //是否存在文件
FileNewName = objvPublicCaseResourceRelENS.FileNewName, //新文件名
FileOldName = objvPublicCaseResourceRelENS.FileOldName, //旧文件名
IsMain = objvPublicCaseResourceRelENS.IsMain, //是否主资源
IndexNO = objvPublicCaseResourceRelENS.IndexNO, //序号
Memo = objvPublicCaseResourceRelENS.Memo, //备注
IsVisible = objvPublicCaseResourceRelENS.IsVisible, //是否显示
BrowseCount = objvPublicCaseResourceRelENS.BrowseCount, //浏览次数
};
 return objvPublicCaseResourceRelENT;
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
public static void CheckProperty4Condition(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN)
{
 clsvPublicCaseResourceRelBL.vPublicCaseResourceRelDA.CheckProperty4Condition(objvPublicCaseResourceRelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPublicCaseResourceRelEN objvPublicCaseResourceRelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IdPubClassCaseResourceRel) == true)
{
string strComparisonOpIdPubClassCaseResourceRel = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.IdPubClassCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convPublicCaseResourceRel.IdPubClassCaseResourceRel, objvPublicCaseResourceRelCond.IdPubClassCaseResourceRel, strComparisonOpIdPubClassCaseResourceRel);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.IdPubClassCase, objvPublicCaseResourceRelCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.PubClassCaseName) == true)
{
string strComparisonOpPubClassCaseName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseName, objvPublicCaseResourceRelCond.PubClassCaseName, strComparisonOpPubClassCaseName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.PubClassCaseExecutor) == true)
{
string strComparisonOpPubClassCaseExecutor = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseExecutor, objvPublicCaseResourceRelCond.PubClassCaseExecutor, strComparisonOpPubClassCaseExecutor);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.PubClassCaseTheme) == true)
{
string strComparisonOpPubClassCaseTheme = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseTheme, objvPublicCaseResourceRelCond.PubClassCaseTheme, strComparisonOpPubClassCaseTheme);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.PubClassCaseTeachDate) == true)
{
string strComparisonOpPubClassCaseTeachDate = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseTeachDate, objvPublicCaseResourceRelCond.PubClassCaseTeachDate, strComparisonOpPubClassCaseTeachDate);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.PubClassCaseDateIn) == true)
{
string strComparisonOpPubClassCaseDateIn = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseDateIn, objvPublicCaseResourceRelCond.PubClassCaseDateIn, strComparisonOpPubClassCaseDateIn);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.IdDiscipline, objvPublicCaseResourceRelCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.DisciplineID, objvPublicCaseResourceRelCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.DisciplineName, objvPublicCaseResourceRelCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.IdTeachingPlan, objvPublicCaseResourceRelCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.SubjectName) == true)
{
string strComparisonOpSubjectName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.SubjectName, objvPublicCaseResourceRelCond.SubjectName, strComparisonOpSubjectName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.TeachingPlanAuthor) == true)
{
string strComparisonOpTeachingPlanAuthor = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingPlanAuthor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingPlanAuthor, objvPublicCaseResourceRelCond.TeachingPlanAuthor, strComparisonOpTeachingPlanAuthor);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.TeachingObject) == true)
{
string strComparisonOpTeachingObject = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingObject];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingObject, objvPublicCaseResourceRelCond.TeachingObject, strComparisonOpTeachingObject);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.TeachingEmphases) == true)
{
string strComparisonOpTeachingEmphases = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingEmphases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingEmphases, objvPublicCaseResourceRelCond.TeachingEmphases, strComparisonOpTeachingEmphases);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.TeachingDifficulty) == true)
{
string strComparisonOpTeachingDifficulty = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingDifficulty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingDifficulty, objvPublicCaseResourceRelCond.TeachingDifficulty, strComparisonOpTeachingDifficulty);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.TeachingTool) == true)
{
string strComparisonOpTeachingTool = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingTool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingTool, objvPublicCaseResourceRelCond.TeachingTool, strComparisonOpTeachingTool);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.TeachingProcess) == true)
{
string strComparisonOpTeachingProcess = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingProcess, objvPublicCaseResourceRelCond.TeachingProcess, strComparisonOpTeachingProcess);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.TeachingPlanType) == true)
{
string strComparisonOpTeachingPlanType = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.TeachingPlanType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.TeachingPlanType, objvPublicCaseResourceRelCond.TeachingPlanType, strComparisonOpTeachingPlanType);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.PubClassCaseTimeIn) == true)
{
string strComparisonOpPubClassCaseTimeIn = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.PubClassCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubClassCaseTimeIn, objvPublicCaseResourceRelCond.PubClassCaseTimeIn, strComparisonOpPubClassCaseTimeIn);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.PubCaseTypeName) == true)
{
string strComparisonOpPubCaseTypeName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.PubCaseTypeName, objvPublicCaseResourceRelCond.PubCaseTypeName, strComparisonOpPubCaseTypeName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.IdStudyLevel, objvPublicCaseResourceRelCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.StudyLevelName, objvPublicCaseResourceRelCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.Introduction) == true)
{
string strComparisonOpIntroduction = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.Introduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.Introduction, objvPublicCaseResourceRelCond.Introduction, strComparisonOpIntroduction);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.CaseIsVisible) == true)
{
if (objvPublicCaseResourceRelCond.CaseIsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.CaseIsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.CaseIsVisible);
}
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IsDualVideo) == true)
{
if (objvPublicCaseResourceRelCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.IsDualVideo);
}
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.RecommendedDegreeId, objvPublicCaseResourceRelCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.RecommendedDegreeName, objvPublicCaseResourceRelCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IdResource) == true)
{
string strComparisonOpIdResource = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.IdResource, objvPublicCaseResourceRelCond.IdResource, strComparisonOpIdResource);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.ResourceID) == true)
{
string strComparisonOpResourceID = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ResourceID, objvPublicCaseResourceRelCond.ResourceID, strComparisonOpResourceID);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.ResourceName) == true)
{
string strComparisonOpResourceName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ResourceName, objvPublicCaseResourceRelCond.ResourceName, strComparisonOpResourceName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.IdFtpResource, objvPublicCaseResourceRelCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IdFile) == true)
{
string strComparisonOpIdFile = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.IdFile, objvPublicCaseResourceRelCond.IdFile, strComparisonOpIdFile);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileName) == true)
{
string strComparisonOpFileName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileName, objvPublicCaseResourceRelCond.FileName, strComparisonOpFileName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileType) == true)
{
string strComparisonOpFileType = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileType, objvPublicCaseResourceRelCond.FileType, strComparisonOpFileType);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.SaveDate) == true)
{
string strComparisonOpSaveDate = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.SaveDate, objvPublicCaseResourceRelCond.SaveDate, strComparisonOpSaveDate);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileSize) == true)
{
string strComparisonOpFileSize = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileSize, objvPublicCaseResourceRelCond.FileSize, strComparisonOpFileSize);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.SaveTime) == true)
{
string strComparisonOpSaveTime = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.SaveTime, objvPublicCaseResourceRelCond.SaveTime, strComparisonOpSaveTime);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FtpResourceID, objvPublicCaseResourceRelCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileOriginalName, objvPublicCaseResourceRelCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileDirName) == true)
{
string strComparisonOpFileDirName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileDirName, objvPublicCaseResourceRelCond.FileDirName, strComparisonOpFileDirName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileRename) == true)
{
string strComparisonOpFileRename = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileRename, objvPublicCaseResourceRelCond.FileRename, strComparisonOpFileRename);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileUpDate, objvPublicCaseResourceRelCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileUpTime, objvPublicCaseResourceRelCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.SaveMode) == true)
{
if (objvPublicCaseResourceRelCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.SaveMode);
}
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.IdResourceType, objvPublicCaseResourceRelCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ResourceTypeID, objvPublicCaseResourceRelCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ResourceTypeName, objvPublicCaseResourceRelCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ResourceOwner, objvPublicCaseResourceRelCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ftpFileType, objvPublicCaseResourceRelCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ftpFileSize, objvPublicCaseResourceRelCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.ftpResourceOwner, objvPublicCaseResourceRelCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileOriginName, objvPublicCaseResourceRelCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IsExistFile) == true)
{
if (objvPublicCaseResourceRelCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.IsExistFile);
}
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileNewName) == true)
{
string strComparisonOpFileNewName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileNewName, objvPublicCaseResourceRelCond.FileNewName, strComparisonOpFileNewName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.FileOldName) == true)
{
string strComparisonOpFileOldName = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.FileOldName, objvPublicCaseResourceRelCond.FileOldName, strComparisonOpFileOldName);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IsMain) == true)
{
if (objvPublicCaseResourceRelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.IsMain);
}
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IndexNO) == true)
{
string strComparisonOpIndexNO = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convPublicCaseResourceRel.IndexNO, objvPublicCaseResourceRelCond.IndexNO, strComparisonOpIndexNO);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.Memo) == true)
{
string strComparisonOpMemo = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPublicCaseResourceRel.Memo, objvPublicCaseResourceRelCond.Memo, strComparisonOpMemo);
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.IsVisible) == true)
{
if (objvPublicCaseResourceRelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPublicCaseResourceRel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPublicCaseResourceRel.IsVisible);
}
}
if (objvPublicCaseResourceRelCond.IsUpdated(convPublicCaseResourceRel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvPublicCaseResourceRelCond.dicFldComparisonOp[convPublicCaseResourceRel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPublicCaseResourceRel.BrowseCount, objvPublicCaseResourceRelCond.BrowseCount, strComparisonOpBrowseCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPublicCaseResourceRel
{
public virtual bool UpdRelaTabDate(long lngIdPubClassCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPublicCaseResourceRel(vPublicCaseResourceRel)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPublicCaseResourceRelBL
{
public static RelatedActions_vPublicCaseResourceRel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPublicCaseResourceRelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPublicCaseResourceRelDA vPublicCaseResourceRelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPublicCaseResourceRelDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPublicCaseResourceRelBL()
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
if (string.IsNullOrEmpty(clsvPublicCaseResourceRelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPublicCaseResourceRelEN._ConnectString);
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
public static DataTable GetDataTable_vPublicCaseResourceRel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPublicCaseResourceRelDA.GetDataTable_vPublicCaseResourceRel(strWhereCond);
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
objDT = vPublicCaseResourceRelDA.GetDataTable(strWhereCond);
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
objDT = vPublicCaseResourceRelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPublicCaseResourceRelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPublicCaseResourceRelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPublicCaseResourceRelDA.GetDataTable_Top(objTopPara);
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
objDT = vPublicCaseResourceRelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPublicCaseResourceRelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPublicCaseResourceRelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubClassCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPublicCaseResourceRelEN> GetObjLstByIdPubClassCaseResourceRelLst(List<long> arrIdPubClassCaseResourceRelLst)
{
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseResourceRelLst);
 string strWhereCond = string.Format("IdPubClassCaseResourceRel in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPublicCaseResourceRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPublicCaseResourceRelEN> GetObjLstByIdPubClassCaseResourceRelLstCache(List<long> arrIdPubClassCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsvPublicCaseResourceRelEN._CurrTabName);
List<clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLstCache = GetObjLstCache();
IEnumerable <clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLst_Sel =
arrvPublicCaseResourceRelObjLstCache
.Where(x => arrIdPubClassCaseResourceRelLst.Contains(x.IdPubClassCaseResourceRel));
return arrvPublicCaseResourceRelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPublicCaseResourceRelEN> GetObjLst(string strWhereCond)
{
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPublicCaseResourceRelEN);
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
public static List<clsvPublicCaseResourceRelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPublicCaseResourceRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPublicCaseResourceRelEN> GetSubObjLstCache(clsvPublicCaseResourceRelEN objvPublicCaseResourceRelCond)
{
List<clsvPublicCaseResourceRelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPublicCaseResourceRelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPublicCaseResourceRel.AttributeName)
{
if (objvPublicCaseResourceRelCond.IsUpdated(strFldName) == false) continue;
if (objvPublicCaseResourceRelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPublicCaseResourceRelCond[strFldName].ToString());
}
else
{
if (objvPublicCaseResourceRelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPublicCaseResourceRelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPublicCaseResourceRelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPublicCaseResourceRelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPublicCaseResourceRelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPublicCaseResourceRelCond[strFldName]));
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
public static List<clsvPublicCaseResourceRelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPublicCaseResourceRelEN);
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
public static List<clsvPublicCaseResourceRelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPublicCaseResourceRelEN);
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
List<clsvPublicCaseResourceRelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPublicCaseResourceRelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPublicCaseResourceRelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPublicCaseResourceRelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
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
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPublicCaseResourceRelEN);
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
public static List<clsvPublicCaseResourceRelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPublicCaseResourceRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPublicCaseResourceRelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPublicCaseResourceRelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPublicCaseResourceRelEN);
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
public static List<clsvPublicCaseResourceRelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPublicCaseResourceRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPublicCaseResourceRelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPublicCaseResourceRelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPublicCaseResourceRel(ref clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN)
{
bool bolResult = vPublicCaseResourceRelDA.GetvPublicCaseResourceRel(ref objvPublicCaseResourceRelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPublicCaseResourceRelEN GetObjByIdPubClassCaseResourceRel(long lngIdPubClassCaseResourceRel)
{
clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = vPublicCaseResourceRelDA.GetObjByIdPubClassCaseResourceRel(lngIdPubClassCaseResourceRel);
return objvPublicCaseResourceRelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPublicCaseResourceRelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = vPublicCaseResourceRelDA.GetFirstObj(strWhereCond);
 return objvPublicCaseResourceRelEN;
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
public static clsvPublicCaseResourceRelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = vPublicCaseResourceRelDA.GetObjByDataRow(objRow);
 return objvPublicCaseResourceRelEN;
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
public static clsvPublicCaseResourceRelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = vPublicCaseResourceRelDA.GetObjByDataRow(objRow);
 return objvPublicCaseResourceRelEN;
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
 /// <param name = "lngIdPubClassCaseResourceRel">所给的关键字</param>
 /// <param name = "lstvPublicCaseResourceRelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPublicCaseResourceRelEN GetObjByIdPubClassCaseResourceRelFromList(long lngIdPubClassCaseResourceRel, List<clsvPublicCaseResourceRelEN> lstvPublicCaseResourceRelObjLst)
{
foreach (clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN in lstvPublicCaseResourceRelObjLst)
{
if (objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel == lngIdPubClassCaseResourceRel)
{
return objvPublicCaseResourceRelEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngIdPubClassCaseResourceRel;
 try
 {
 lngIdPubClassCaseResourceRel = new clsvPublicCaseResourceRelDA().GetFirstID(strWhereCond);
 return lngIdPubClassCaseResourceRel;
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
 arrList = vPublicCaseResourceRelDA.GetID(strWhereCond);
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
bool bolIsExist = vPublicCaseResourceRelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdPubClassCaseResourceRel)
{
//检测记录是否存在
bool bolIsExist = vPublicCaseResourceRelDA.IsExist(lngIdPubClassCaseResourceRel);
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
 bolIsExist = clsvPublicCaseResourceRelDA.IsExistTable();
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
 bolIsExist = vPublicCaseResourceRelDA.IsExistTable(strTabName);
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
 /// <param name = "objvPublicCaseResourceRelENS">源对象</param>
 /// <param name = "objvPublicCaseResourceRelENT">目标对象</param>
 public static void CopyTo(clsvPublicCaseResourceRelEN objvPublicCaseResourceRelENS, clsvPublicCaseResourceRelEN objvPublicCaseResourceRelENT)
{
try
{
objvPublicCaseResourceRelENT.IdPubClassCaseResourceRel = objvPublicCaseResourceRelENS.IdPubClassCaseResourceRel; //案例与资源关系表流水号
objvPublicCaseResourceRelENT.IdPubClassCase = objvPublicCaseResourceRelENS.IdPubClassCase; //案例流水号
objvPublicCaseResourceRelENT.PubClassCaseName = objvPublicCaseResourceRelENS.PubClassCaseName; //案例课题名称
objvPublicCaseResourceRelENT.PubClassCaseExecutor = objvPublicCaseResourceRelENS.PubClassCaseExecutor; //案例执教者
objvPublicCaseResourceRelENT.PubClassCaseTheme = objvPublicCaseResourceRelENS.PubClassCaseTheme; //案例主题词
objvPublicCaseResourceRelENT.PubClassCaseBG = objvPublicCaseResourceRelENS.PubClassCaseBG; //案例背景资料
objvPublicCaseResourceRelENT.PubClassCaseTeachDate = objvPublicCaseResourceRelENS.PubClassCaseTeachDate; //案例授课日期
objvPublicCaseResourceRelENT.PubClassCaseDateIn = objvPublicCaseResourceRelENS.PubClassCaseDateIn; //案例入库日期
objvPublicCaseResourceRelENT.IdDiscipline = objvPublicCaseResourceRelENS.IdDiscipline; //学科流水号
objvPublicCaseResourceRelENT.DisciplineID = objvPublicCaseResourceRelENS.DisciplineID; //学科ID
objvPublicCaseResourceRelENT.DisciplineName = objvPublicCaseResourceRelENS.DisciplineName; //学科名称
objvPublicCaseResourceRelENT.IdTeachingPlan = objvPublicCaseResourceRelENS.IdTeachingPlan; //教案流水号
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
objvPublicCaseResourceRelENT.IdStudyLevel = objvPublicCaseResourceRelENS.IdStudyLevel; //id_StudyLevel
objvPublicCaseResourceRelENT.StudyLevelName = objvPublicCaseResourceRelENS.StudyLevelName; //学段名称
objvPublicCaseResourceRelENT.Introduction = objvPublicCaseResourceRelENS.Introduction; //简要介绍
objvPublicCaseResourceRelENT.CaseIsVisible = objvPublicCaseResourceRelENS.CaseIsVisible; //CaseIsVisible
objvPublicCaseResourceRelENT.IsDualVideo = objvPublicCaseResourceRelENS.IsDualVideo; //是否双视频
objvPublicCaseResourceRelENT.RecommendedDegreeId = objvPublicCaseResourceRelENS.RecommendedDegreeId; //推荐度Id
objvPublicCaseResourceRelENT.RecommendedDegreeName = objvPublicCaseResourceRelENS.RecommendedDegreeName; //推荐度名称
objvPublicCaseResourceRelENT.IdResource = objvPublicCaseResourceRelENS.IdResource; //资源流水号
objvPublicCaseResourceRelENT.ResourceID = objvPublicCaseResourceRelENS.ResourceID; //资源ID
objvPublicCaseResourceRelENT.ResourceName = objvPublicCaseResourceRelENS.ResourceName; //资源名称
objvPublicCaseResourceRelENT.IdFtpResource = objvPublicCaseResourceRelENS.IdFtpResource; //FTP资源流水号
objvPublicCaseResourceRelENT.IdFile = objvPublicCaseResourceRelENS.IdFile; //文件流水号
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
objvPublicCaseResourceRelENT.IdResourceType = objvPublicCaseResourceRelENS.IdResourceType; //资源类型流水号
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
 /// <param name = "objvPublicCaseResourceRelEN">源简化对象</param>
 public static void SetUpdFlag(clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN)
{
try
{
objvPublicCaseResourceRelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPublicCaseResourceRelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPublicCaseResourceRel.IdPubClassCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel; //案例与资源关系表流水号
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IdPubClassCase = objvPublicCaseResourceRelEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(convPublicCaseResourceRel.PubClassCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.PubClassCaseName = objvPublicCaseResourceRelEN.PubClassCaseName; //案例课题名称
}
if (arrFldSet.Contains(convPublicCaseResourceRel.PubClassCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objvPublicCaseResourceRelEN.PubClassCaseExecutor == "[null]" ? null :  objvPublicCaseResourceRelEN.PubClassCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(convPublicCaseResourceRel.PubClassCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.PubClassCaseTheme = objvPublicCaseResourceRelEN.PubClassCaseTheme == "[null]" ? null :  objvPublicCaseResourceRelEN.PubClassCaseTheme; //案例主题词
}
if (arrFldSet.Contains(convPublicCaseResourceRel.PubClassCaseBG, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.PubClassCaseBG = objvPublicCaseResourceRelEN.PubClassCaseBG == "[null]" ? null :  objvPublicCaseResourceRelEN.PubClassCaseBG; //案例背景资料
}
if (arrFldSet.Contains(convPublicCaseResourceRel.PubClassCaseTeachDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objvPublicCaseResourceRelEN.PubClassCaseTeachDate == "[null]" ? null :  objvPublicCaseResourceRelEN.PubClassCaseTeachDate; //案例授课日期
}
if (arrFldSet.Contains(convPublicCaseResourceRel.PubClassCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objvPublicCaseResourceRelEN.PubClassCaseDateIn == "[null]" ? null :  objvPublicCaseResourceRelEN.PubClassCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IdDiscipline = objvPublicCaseResourceRelEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convPublicCaseResourceRel.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.DisciplineID = objvPublicCaseResourceRelEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convPublicCaseResourceRel.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.DisciplineName = objvPublicCaseResourceRelEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IdTeachingPlan = objvPublicCaseResourceRelEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convPublicCaseResourceRel.SubjectName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.SubjectName = objvPublicCaseResourceRelEN.SubjectName; //课题名称
}
if (arrFldSet.Contains(convPublicCaseResourceRel.TeachingPlanAuthor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objvPublicCaseResourceRelEN.TeachingPlanAuthor == "[null]" ? null :  objvPublicCaseResourceRelEN.TeachingPlanAuthor; //教案撰写人
}
if (arrFldSet.Contains(convPublicCaseResourceRel.TeachingObject, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.TeachingObject = objvPublicCaseResourceRelEN.TeachingObject == "[null]" ? null :  objvPublicCaseResourceRelEN.TeachingObject; //教学目标
}
if (arrFldSet.Contains(convPublicCaseResourceRel.TeachingEmphases, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.TeachingEmphases = objvPublicCaseResourceRelEN.TeachingEmphases == "[null]" ? null :  objvPublicCaseResourceRelEN.TeachingEmphases; //教学重点
}
if (arrFldSet.Contains(convPublicCaseResourceRel.TeachingDifficulty, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.TeachingDifficulty = objvPublicCaseResourceRelEN.TeachingDifficulty == "[null]" ? null :  objvPublicCaseResourceRelEN.TeachingDifficulty; //教学难点
}
if (arrFldSet.Contains(convPublicCaseResourceRel.TeachingTool, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.TeachingTool = objvPublicCaseResourceRelEN.TeachingTool == "[null]" ? null :  objvPublicCaseResourceRelEN.TeachingTool; //教学用具
}
if (arrFldSet.Contains(convPublicCaseResourceRel.TeachingProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.TeachingProcess = objvPublicCaseResourceRelEN.TeachingProcess == "[null]" ? null :  objvPublicCaseResourceRelEN.TeachingProcess; //教学过程
}
if (arrFldSet.Contains(convPublicCaseResourceRel.TeachingPlanType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.TeachingPlanType = objvPublicCaseResourceRelEN.TeachingPlanType == "[null]" ? null :  objvPublicCaseResourceRelEN.TeachingPlanType; //教案类型
}
if (arrFldSet.Contains(convPublicCaseResourceRel.SimplePlanContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.SimplePlanContent = objvPublicCaseResourceRelEN.SimplePlanContent == "[null]" ? null :  objvPublicCaseResourceRelEN.SimplePlanContent; //简案内容
}
if (arrFldSet.Contains(convPublicCaseResourceRel.PubClassCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objvPublicCaseResourceRelEN.PubClassCaseTimeIn == "[null]" ? null :  objvPublicCaseResourceRelEN.PubClassCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convPublicCaseResourceRel.PubCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.PubCaseTypeName = objvPublicCaseResourceRelEN.PubCaseTypeName == "[null]" ? null :  objvPublicCaseResourceRelEN.PubCaseTypeName; //公开课案例类型名称
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IdStudyLevel = objvPublicCaseResourceRelEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convPublicCaseResourceRel.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.StudyLevelName = objvPublicCaseResourceRelEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convPublicCaseResourceRel.Introduction, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.Introduction = objvPublicCaseResourceRelEN.Introduction == "[null]" ? null :  objvPublicCaseResourceRelEN.Introduction; //简要介绍
}
if (arrFldSet.Contains(convPublicCaseResourceRel.CaseIsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.CaseIsVisible = objvPublicCaseResourceRelEN.CaseIsVisible; //CaseIsVisible
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IsDualVideo = objvPublicCaseResourceRelEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convPublicCaseResourceRel.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.RecommendedDegreeId = objvPublicCaseResourceRelEN.RecommendedDegreeId == "[null]" ? null :  objvPublicCaseResourceRelEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convPublicCaseResourceRel.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.RecommendedDegreeName = objvPublicCaseResourceRelEN.RecommendedDegreeName == "[null]" ? null :  objvPublicCaseResourceRelEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IdResource = objvPublicCaseResourceRelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convPublicCaseResourceRel.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.ResourceID = objvPublicCaseResourceRelEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convPublicCaseResourceRel.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.ResourceName = objvPublicCaseResourceRelEN.ResourceName == "[null]" ? null :  objvPublicCaseResourceRelEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IdFtpResource = objvPublicCaseResourceRelEN.IdFtpResource == "[null]" ? null :  objvPublicCaseResourceRelEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IdFile = objvPublicCaseResourceRelEN.IdFile == "[null]" ? null :  objvPublicCaseResourceRelEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileName = objvPublicCaseResourceRelEN.FileName == "[null]" ? null :  objvPublicCaseResourceRelEN.FileName; //文件名称
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileType = objvPublicCaseResourceRelEN.FileType == "[null]" ? null :  objvPublicCaseResourceRelEN.FileType; //文件类型
}
if (arrFldSet.Contains(convPublicCaseResourceRel.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.SaveDate = objvPublicCaseResourceRelEN.SaveDate == "[null]" ? null :  objvPublicCaseResourceRelEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileSize = objvPublicCaseResourceRelEN.FileSize == "[null]" ? null :  objvPublicCaseResourceRelEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convPublicCaseResourceRel.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.SaveTime = objvPublicCaseResourceRelEN.SaveTime == "[null]" ? null :  objvPublicCaseResourceRelEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FtpResourceID = objvPublicCaseResourceRelEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileOriginalName = objvPublicCaseResourceRelEN.FileOriginalName == "[null]" ? null :  objvPublicCaseResourceRelEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileDirName = objvPublicCaseResourceRelEN.FileDirName == "[null]" ? null :  objvPublicCaseResourceRelEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileRename = objvPublicCaseResourceRelEN.FileRename == "[null]" ? null :  objvPublicCaseResourceRelEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileUpDate = objvPublicCaseResourceRelEN.FileUpDate == "[null]" ? null :  objvPublicCaseResourceRelEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileUpTime = objvPublicCaseResourceRelEN.FileUpTime == "[null]" ? null :  objvPublicCaseResourceRelEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convPublicCaseResourceRel.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.SaveMode = objvPublicCaseResourceRelEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IdResourceType = objvPublicCaseResourceRelEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convPublicCaseResourceRel.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.ResourceTypeID = objvPublicCaseResourceRelEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convPublicCaseResourceRel.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.ResourceTypeName = objvPublicCaseResourceRelEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convPublicCaseResourceRel.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.ResourceOwner = objvPublicCaseResourceRelEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convPublicCaseResourceRel.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.ftpFileType = objvPublicCaseResourceRelEN.ftpFileType == "[null]" ? null :  objvPublicCaseResourceRelEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convPublicCaseResourceRel.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.ftpFileSize = objvPublicCaseResourceRelEN.ftpFileSize == "[null]" ? null :  objvPublicCaseResourceRelEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convPublicCaseResourceRel.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.ftpResourceOwner = objvPublicCaseResourceRelEN.ftpResourceOwner == "[null]" ? null :  objvPublicCaseResourceRelEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileOriginName = objvPublicCaseResourceRelEN.FileOriginName == "[null]" ? null :  objvPublicCaseResourceRelEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IsExistFile = objvPublicCaseResourceRelEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileNewName = objvPublicCaseResourceRelEN.FileNewName == "[null]" ? null :  objvPublicCaseResourceRelEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convPublicCaseResourceRel.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.FileOldName = objvPublicCaseResourceRelEN.FileOldName == "[null]" ? null :  objvPublicCaseResourceRelEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IsMain = objvPublicCaseResourceRelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IndexNO = objvPublicCaseResourceRelEN.IndexNO; //序号
}
if (arrFldSet.Contains(convPublicCaseResourceRel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.Memo = objvPublicCaseResourceRelEN.Memo == "[null]" ? null :  objvPublicCaseResourceRelEN.Memo; //备注
}
if (arrFldSet.Contains(convPublicCaseResourceRel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.IsVisible = objvPublicCaseResourceRelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convPublicCaseResourceRel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPublicCaseResourceRelEN.BrowseCount = objvPublicCaseResourceRelEN.BrowseCount; //浏览次数
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
 /// <param name = "objvPublicCaseResourceRelEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN)
{
try
{
if (objvPublicCaseResourceRelEN.PubClassCaseExecutor == "[null]") objvPublicCaseResourceRelEN.PubClassCaseExecutor = null; //案例执教者
if (objvPublicCaseResourceRelEN.PubClassCaseTheme == "[null]") objvPublicCaseResourceRelEN.PubClassCaseTheme = null; //案例主题词
if (objvPublicCaseResourceRelEN.PubClassCaseBG == "[null]") objvPublicCaseResourceRelEN.PubClassCaseBG = null; //案例背景资料
if (objvPublicCaseResourceRelEN.PubClassCaseTeachDate == "[null]") objvPublicCaseResourceRelEN.PubClassCaseTeachDate = null; //案例授课日期
if (objvPublicCaseResourceRelEN.PubClassCaseDateIn == "[null]") objvPublicCaseResourceRelEN.PubClassCaseDateIn = null; //案例入库日期
if (objvPublicCaseResourceRelEN.TeachingPlanAuthor == "[null]") objvPublicCaseResourceRelEN.TeachingPlanAuthor = null; //教案撰写人
if (objvPublicCaseResourceRelEN.TeachingObject == "[null]") objvPublicCaseResourceRelEN.TeachingObject = null; //教学目标
if (objvPublicCaseResourceRelEN.TeachingEmphases == "[null]") objvPublicCaseResourceRelEN.TeachingEmphases = null; //教学重点
if (objvPublicCaseResourceRelEN.TeachingDifficulty == "[null]") objvPublicCaseResourceRelEN.TeachingDifficulty = null; //教学难点
if (objvPublicCaseResourceRelEN.TeachingTool == "[null]") objvPublicCaseResourceRelEN.TeachingTool = null; //教学用具
if (objvPublicCaseResourceRelEN.TeachingProcess == "[null]") objvPublicCaseResourceRelEN.TeachingProcess = null; //教学过程
if (objvPublicCaseResourceRelEN.TeachingPlanType == "[null]") objvPublicCaseResourceRelEN.TeachingPlanType = null; //教案类型
if (objvPublicCaseResourceRelEN.SimplePlanContent == "[null]") objvPublicCaseResourceRelEN.SimplePlanContent = null; //简案内容
if (objvPublicCaseResourceRelEN.PubClassCaseTimeIn == "[null]") objvPublicCaseResourceRelEN.PubClassCaseTimeIn = null; //案例入库时间
if (objvPublicCaseResourceRelEN.PubCaseTypeName == "[null]") objvPublicCaseResourceRelEN.PubCaseTypeName = null; //公开课案例类型名称
if (objvPublicCaseResourceRelEN.Introduction == "[null]") objvPublicCaseResourceRelEN.Introduction = null; //简要介绍
if (objvPublicCaseResourceRelEN.RecommendedDegreeId == "[null]") objvPublicCaseResourceRelEN.RecommendedDegreeId = null; //推荐度Id
if (objvPublicCaseResourceRelEN.RecommendedDegreeName == "[null]") objvPublicCaseResourceRelEN.RecommendedDegreeName = null; //推荐度名称
if (objvPublicCaseResourceRelEN.ResourceName == "[null]") objvPublicCaseResourceRelEN.ResourceName = null; //资源名称
if (objvPublicCaseResourceRelEN.IdFtpResource == "[null]") objvPublicCaseResourceRelEN.IdFtpResource = null; //FTP资源流水号
if (objvPublicCaseResourceRelEN.IdFile == "[null]") objvPublicCaseResourceRelEN.IdFile = null; //文件流水号
if (objvPublicCaseResourceRelEN.FileName == "[null]") objvPublicCaseResourceRelEN.FileName = null; //文件名称
if (objvPublicCaseResourceRelEN.FileType == "[null]") objvPublicCaseResourceRelEN.FileType = null; //文件类型
if (objvPublicCaseResourceRelEN.SaveDate == "[null]") objvPublicCaseResourceRelEN.SaveDate = null; //创建日期
if (objvPublicCaseResourceRelEN.FileSize == "[null]") objvPublicCaseResourceRelEN.FileSize = null; //文件大小
if (objvPublicCaseResourceRelEN.SaveTime == "[null]") objvPublicCaseResourceRelEN.SaveTime = null; //创建时间
if (objvPublicCaseResourceRelEN.FileOriginalName == "[null]") objvPublicCaseResourceRelEN.FileOriginalName = null; //文件原名
if (objvPublicCaseResourceRelEN.FileDirName == "[null]") objvPublicCaseResourceRelEN.FileDirName = null; //文件目录名
if (objvPublicCaseResourceRelEN.FileRename == "[null]") objvPublicCaseResourceRelEN.FileRename = null; //文件新名
if (objvPublicCaseResourceRelEN.FileUpDate == "[null]") objvPublicCaseResourceRelEN.FileUpDate = null; //创建日期
if (objvPublicCaseResourceRelEN.FileUpTime == "[null]") objvPublicCaseResourceRelEN.FileUpTime = null; //创建时间
if (objvPublicCaseResourceRelEN.ftpFileType == "[null]") objvPublicCaseResourceRelEN.ftpFileType = null; //ftp文件类型
if (objvPublicCaseResourceRelEN.ftpFileSize == "[null]") objvPublicCaseResourceRelEN.ftpFileSize = null; //ftp文件大小
if (objvPublicCaseResourceRelEN.ftpResourceOwner == "[null]") objvPublicCaseResourceRelEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvPublicCaseResourceRelEN.FileOriginName == "[null]") objvPublicCaseResourceRelEN.FileOriginName = null; //原文件名
if (objvPublicCaseResourceRelEN.FileNewName == "[null]") objvPublicCaseResourceRelEN.FileNewName = null; //新文件名
if (objvPublicCaseResourceRelEN.FileOldName == "[null]") objvPublicCaseResourceRelEN.FileOldName = null; //旧文件名
if (objvPublicCaseResourceRelEN.Memo == "[null]") objvPublicCaseResourceRelEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN)
{
 vPublicCaseResourceRelDA.CheckProperty4Condition(objvPublicCaseResourceRelEN);
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
if (clsPubClassCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCase_Resource_RelBL没有刷新缓存机制(clsPubClassCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceBL没有刷新缓存机制(clsResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCaseResourceRel");
//if (arrvPublicCaseResourceRelObjLstCache == null)
//{
//arrvPublicCaseResourceRelObjLstCache = vPublicCaseResourceRelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPublicCaseResourceRelEN GetObjByIdPubClassCaseResourceRelCache(long lngIdPubClassCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPublicCaseResourceRelEN._CurrTabName);
List<clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLstCache = GetObjLstCache();
IEnumerable <clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLst_Sel =
arrvPublicCaseResourceRelObjLstCache
.Where(x=> x.IdPubClassCaseResourceRel == lngIdPubClassCaseResourceRel 
);
if (arrvPublicCaseResourceRelObjLst_Sel.Count() == 0)
{
   clsvPublicCaseResourceRelEN obj = clsvPublicCaseResourceRelBL.GetObjByIdPubClassCaseResourceRel(lngIdPubClassCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPublicCaseResourceRelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPublicCaseResourceRelEN> GetAllvPublicCaseResourceRelObjLstCache()
{
//获取缓存中的对象列表
List<clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLstCache = GetObjLstCache(); 
return arrvPublicCaseResourceRelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPublicCaseResourceRelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPublicCaseResourceRelEN._CurrTabName);
List<clsvPublicCaseResourceRelEN> arrvPublicCaseResourceRelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPublicCaseResourceRelObjLstCache;
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
string strKey = string.Format("{0}", clsvPublicCaseResourceRelEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdPubClassCaseResourceRel)
{
if (strInFldName != convPublicCaseResourceRel.IdPubClassCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPublicCaseResourceRel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPublicCaseResourceRel.AttributeName));
throw new Exception(strMsg);
}
var objvPublicCaseResourceRel = clsvPublicCaseResourceRelBL.GetObjByIdPubClassCaseResourceRelCache(lngIdPubClassCaseResourceRel);
if (objvPublicCaseResourceRel == null) return "";
return objvPublicCaseResourceRel[strOutFldName].ToString();
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
int intRecCount = clsvPublicCaseResourceRelDA.GetRecCount(strTabName);
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
int intRecCount = clsvPublicCaseResourceRelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPublicCaseResourceRelDA.GetRecCount();
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
int intRecCount = clsvPublicCaseResourceRelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPublicCaseResourceRelEN objvPublicCaseResourceRelCond)
{
List<clsvPublicCaseResourceRelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPublicCaseResourceRelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPublicCaseResourceRel.AttributeName)
{
if (objvPublicCaseResourceRelCond.IsUpdated(strFldName) == false) continue;
if (objvPublicCaseResourceRelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPublicCaseResourceRelCond[strFldName].ToString());
}
else
{
if (objvPublicCaseResourceRelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPublicCaseResourceRelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPublicCaseResourceRelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPublicCaseResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPublicCaseResourceRelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPublicCaseResourceRelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPublicCaseResourceRelCond[strFldName]));
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
 List<string> arrList = clsvPublicCaseResourceRelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPublicCaseResourceRelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPublicCaseResourceRelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}