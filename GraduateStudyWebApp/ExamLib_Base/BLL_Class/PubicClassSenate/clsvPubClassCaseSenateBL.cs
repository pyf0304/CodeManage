
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseSenateBL
 表名:vPubClassCaseSenate(01120410)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:48
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
public static class  clsvPubClassCaseSenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseSenateEN GetObj(this K_IdPubClassCaseSenate_vPubClassCaseSenate myKey)
{
clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = clsvPubClassCaseSenateBL.vPubClassCaseSenateDA.GetObjByIdPubClassCaseSenate(myKey.Value);
return objvPubClassCaseSenateEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdPubClassCaseSenate(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, long lngIdPubClassCaseSenate, string strComparisonOp="")
	{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = lngIdPubClassCaseSenate; //公开课案例评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdPubClassCaseSenate) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdPubClassCaseSenate, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdPubClassCaseSenate] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdPubClassCase(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strIdPubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCase, convPubClassCaseSenate.IdPubClassCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, convPubClassCaseSenate.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, convPubClassCaseSenate.IdPubClassCase);
}
objvPubClassCaseSenateEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdPubClassCase) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdPubClassCase, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdPubClassCase] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, convPubClassCaseSenate.PubClassCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubClassCaseSenate.PubClassCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubClassCaseSenate.PubClassCaseID);
}
objvPubClassCaseSenateEN.PubClassCaseID = strPubClassCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseID) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseID, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseID] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPubClassCaseSenate.PubClassCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubClassCaseSenate.PubClassCaseName);
}
objvPubClassCaseSenateEN.PubClassCaseName = strPubClassCaseName; //案例课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseDateIn(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, convPubClassCaseSenate.PubClassCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, convPubClassCaseSenate.PubClassCaseDateIn);
}
objvPubClassCaseSenateEN.PubClassCaseDateIn = strPubClassCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseDateIn) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseDateIn, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseDateIn] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseTeachDate(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPubClassCaseSenate.PubClassCaseTeachDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPubClassCaseSenate.PubClassCaseTeachDate);
}
objvPubClassCaseSenateEN.PubClassCaseTeachDate = strPubClassCaseTeachDate; //案例授课日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseTeachDate) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseTeachDate, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseTeachDate] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseBG(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseBG, string strComparisonOp="")
	{
objvPubClassCaseSenateEN.PubClassCaseBG = strPubClassCaseBG; //案例背景资料
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseBG) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseBG, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseBG] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseTheme(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, convPubClassCaseSenate.PubClassCaseTheme);
}
objvPubClassCaseSenateEN.PubClassCaseTheme = strPubClassCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseTheme) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseTheme, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseTheme] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseExecutor(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubClassCaseSenate.PubClassCaseExecutor);
}
objvPubClassCaseSenateEN.PubClassCaseExecutor = strPubClassCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseExecutor) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseExecutor, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseExecutor] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetDisciplineID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convPubClassCaseSenate.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convPubClassCaseSenate.DisciplineID);
}
objvPubClassCaseSenateEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.DisciplineID) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.DisciplineID, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.DisciplineID] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetDisciplineName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPubClassCaseSenate.DisciplineName);
}
objvPubClassCaseSenateEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.DisciplineName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.DisciplineName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.DisciplineName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetStudyLevelName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPubClassCaseSenate.StudyLevelName);
}
objvPubClassCaseSenateEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.StudyLevelName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.StudyLevelName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.StudyLevelName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIsElite(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, bool bolIsElite, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsElite, convPubClassCaseSenate.IsElite);
objvPubClassCaseSenateEN.IsElite = bolIsElite; //精华标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IsElite) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IsElite, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IsElite] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetSubjectName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubjectName, convPubClassCaseSenate.SubjectName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubjectName, 200, convPubClassCaseSenate.SubjectName);
}
objvPubClassCaseSenateEN.SubjectName = strSubjectName; //课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.SubjectName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.SubjectName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.SubjectName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetResourceID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convPubClassCaseSenate.ResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convPubClassCaseSenate.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convPubClassCaseSenate.ResourceID);
}
objvPubClassCaseSenateEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.ResourceID) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.ResourceID, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.ResourceID] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetResourceTypeID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convPubClassCaseSenate.ResourceTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convPubClassCaseSenate.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convPubClassCaseSenate.ResourceTypeID);
}
objvPubClassCaseSenateEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.ResourceTypeID) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.ResourceTypeID, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.ResourceTypeID] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetResourceTypeName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convPubClassCaseSenate.ResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convPubClassCaseSenate.ResourceTypeName);
}
objvPubClassCaseSenateEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.ResourceTypeName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.ResourceTypeName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.ResourceTypeName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubCaseTypeID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeID, convPubClassCaseSenate.PubCaseTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubCaseTypeID, 4, convPubClassCaseSenate.PubCaseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubCaseTypeID, 4, convPubClassCaseSenate.PubCaseTypeID);
}
objvPubClassCaseSenateEN.PubCaseTypeID = strPubCaseTypeID; //公开课案例类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubCaseTypeID) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubCaseTypeID, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubCaseTypeID] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubCaseTypeName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeName, convPubClassCaseSenate.PubCaseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubClassCaseSenate.PubCaseTypeName);
}
objvPubClassCaseSenateEN.PubCaseTypeName = strPubCaseTypeName; //公开课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubCaseTypeName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubCaseTypeName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubCaseTypeName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateClassID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateClassID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateClassID, 4, convPubClassCaseSenate.PubClassCaseSenateClassID);
}
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = strPubClassCaseSenateClassID; //公开课案例评议类别ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseSenateClassID) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseSenateClassID, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateClassID] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateClassName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateClassName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateClassName, 50, convPubClassCaseSenate.PubClassCaseSenateClassName);
}
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = strPubClassCaseSenateClassName; //公开课案例评议类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseSenateClassName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseSenateClassName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateClassName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenator(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenator, 50, convPubClassCaseSenate.PubClassCaseSenator);
}
objvPubClassCaseSenateEN.PubClassCaseSenator = strPubClassCaseSenator; //公开课案例评议者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseSenator) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseSenator, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenator] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateTitle(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateTitle, 200, convPubClassCaseSenate.PubClassCaseSenateTitle);
}
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = strPubClassCaseSenateTitle; //公开课案例评议标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseSenateTitle) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseSenateTitle, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateTitle] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateContent(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateContent, 8000, convPubClassCaseSenate.PubClassCaseSenateContent);
}
objvPubClassCaseSenateEN.PubClassCaseSenateContent = strPubClassCaseSenateContent; //公开课案例评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseSenateContent) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseSenateContent, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateContent] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateDate(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateDate, 8, convPubClassCaseSenate.PubClassCaseSenateDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseSenateDate, 8, convPubClassCaseSenate.PubClassCaseSenateDate);
}
objvPubClassCaseSenateEN.PubClassCaseSenateDate = strPubClassCaseSenateDate; //公开课案例评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseSenateDate) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseSenateDate, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateDate] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateTime(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateTime, 6, convPubClassCaseSenate.PubClassCaseSenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseSenateTime, 6, convPubClassCaseSenate.PubClassCaseSenateTime);
}
objvPubClassCaseSenateEN.PubClassCaseSenateTime = strPubClassCaseSenateTime; //公开课案例评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.PubClassCaseSenateTime) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.PubClassCaseSenateTime, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateTime] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetSenateReadCount(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, int? intSenateReadCount, string strComparisonOp="")
	{
objvPubClassCaseSenateEN.SenateReadCount = intSenateReadCount; //评议阅读次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.SenateReadCount) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.SenateReadCount, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.SenateReadCount] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetResourceOwner(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convPubClassCaseSenate.ResourceOwner);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convPubClassCaseSenate.ResourceOwner);
}
objvPubClassCaseSenateEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.ResourceOwner) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.ResourceOwner, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.ResourceOwner] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetftpResourceOwner(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convPubClassCaseSenate.ftpResourceOwner);
}
objvPubClassCaseSenateEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.ftpResourceOwner) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.ftpResourceOwner, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.ftpResourceOwner] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileNewName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convPubClassCaseSenate.FileNewName);
}
objvPubClassCaseSenateEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileNewName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileNewName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileNewName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileOldName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convPubClassCaseSenate.FileOldName);
}
objvPubClassCaseSenateEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileOldName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileOldName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileOldName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileSize(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convPubClassCaseSenate.FileSize);
}
objvPubClassCaseSenateEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileSize) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileSize, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileSize] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileType(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convPubClassCaseSenate.FileType);
}
objvPubClassCaseSenateEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileType) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileType, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileType] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convPubClassCaseSenate.FileName);
}
objvPubClassCaseSenateEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetSaveTime(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convPubClassCaseSenate.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convPubClassCaseSenate.SaveTime);
}
objvPubClassCaseSenateEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.SaveTime) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.SaveTime, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.SaveTime] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIsVisual(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, bool bolIsVisual, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsVisual, convPubClassCaseSenate.IsVisual);
objvPubClassCaseSenateEN.IsVisual = bolIsVisual; //隐藏标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IsVisual) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IsVisual, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IsVisual] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdTeachingPlan(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convPubClassCaseSenate.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convPubClassCaseSenate.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convPubClassCaseSenate.IdTeachingPlan);
}
objvPubClassCaseSenateEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdTeachingPlan) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdTeachingPlan, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdTeachingPlan] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdFtpResource(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convPubClassCaseSenate.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convPubClassCaseSenate.IdFtpResource);
}
objvPubClassCaseSenateEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdFtpResource) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdFtpResource, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdFtpResource] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileUpDate(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convPubClassCaseSenate.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convPubClassCaseSenate.FileUpDate);
}
objvPubClassCaseSenateEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileUpDate) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileUpDate, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileUpDate] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileDirName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convPubClassCaseSenate.FileDirName);
}
objvPubClassCaseSenateEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileDirName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileDirName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileDirName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileOriginalName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convPubClassCaseSenate.FileOriginalName);
}
objvPubClassCaseSenateEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileOriginalName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileOriginalName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileOriginalName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFtpResourceID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convPubClassCaseSenate.FtpResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convPubClassCaseSenate.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convPubClassCaseSenate.FtpResourceID);
}
objvPubClassCaseSenateEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FtpResourceID) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FtpResourceID, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FtpResourceID] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileRename(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convPubClassCaseSenate.FileRename);
}
objvPubClassCaseSenateEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileRename) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileRename, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileRename] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileUpTime(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convPubClassCaseSenate.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convPubClassCaseSenate.FileUpTime);
}
objvPubClassCaseSenateEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileUpTime) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileUpTime, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileUpTime] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetSaveMode(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, bool bolSaveMode, string strComparisonOp="")
	{
objvPubClassCaseSenateEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.SaveMode) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.SaveMode, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.SaveMode] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdResourceType(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, convPubClassCaseSenate.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convPubClassCaseSenate.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convPubClassCaseSenate.IdResourceType);
}
objvPubClassCaseSenateEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdResourceType) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdResourceType, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdResourceType] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdPubCaseType(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strIdPubCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubCaseType, convPubClassCaseSenate.IdPubCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubCaseType, 4, convPubClassCaseSenate.IdPubCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubCaseType, 4, convPubClassCaseSenate.IdPubCaseType);
}
objvPubClassCaseSenateEN.IdPubCaseType = strIdPubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdPubCaseType) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdPubCaseType, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdPubCaseType] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetftpFileType(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convPubClassCaseSenate.ftpFileType);
}
objvPubClassCaseSenateEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.ftpFileType) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.ftpFileType, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.ftpFileType] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetftpFileSize(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convPubClassCaseSenate.ftpFileSize);
}
objvPubClassCaseSenateEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.ftpFileSize) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.ftpFileSize, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.ftpFileSize] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileOriginName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convPubClassCaseSenate.FileOriginName);
}
objvPubClassCaseSenateEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.FileOriginName) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.FileOriginName, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.FileOriginName] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdResource(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convPubClassCaseSenate.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convPubClassCaseSenate.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convPubClassCaseSenate.IdResource);
}
objvPubClassCaseSenateEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdResource) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdResource, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdResource] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdDiscipline(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strIdDiscipline, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convPubClassCaseSenate.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convPubClassCaseSenate.IdDiscipline);
}
objvPubClassCaseSenateEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdDiscipline) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdDiscipline, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdDiscipline] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdStudyLevel(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convPubClassCaseSenate.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convPubClassCaseSenate.IdStudyLevel);
}
objvPubClassCaseSenateEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdStudyLevel) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdStudyLevel, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdStudyLevel] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdFile(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convPubClassCaseSenate.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convPubClassCaseSenate.IdFile);
}
objvPubClassCaseSenateEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdFile) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdFile, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdFile] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIsVisible(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, bool bolIsVisible, string strComparisonOp="")
	{
objvPubClassCaseSenateEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IsVisible) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IsVisible, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IsVisible] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetSaveDate(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convPubClassCaseSenate.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convPubClassCaseSenate.SaveDate);
}
objvPubClassCaseSenateEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.SaveDate) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.SaveDate, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.SaveDate] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetIdPubClassCaseSenateClass(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strIdPubClassCaseSenateClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCaseSenateClass, convPubClassCaseSenate.IdPubClassCaseSenateClass);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCaseSenateClass, 4, convPubClassCaseSenate.IdPubClassCaseSenateClass);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCaseSenateClass, 4, convPubClassCaseSenate.IdPubClassCaseSenateClass);
}
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = strIdPubClassCaseSenateClass; //公开课案例评议类别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.IdPubClassCaseSenateClass) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.IdPubClassCaseSenateClass, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.IdPubClassCaseSenateClass] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateENS">源对象</param>
 /// <param name = "objvPubClassCaseSenateENT">目标对象</param>
 public static void CopyTo(this clsvPubClassCaseSenateEN objvPubClassCaseSenateENS, clsvPubClassCaseSenateEN objvPubClassCaseSenateENT)
{
try
{
objvPubClassCaseSenateENT.IdPubClassCaseSenate = objvPubClassCaseSenateENS.IdPubClassCaseSenate; //公开课案例评议流水号
objvPubClassCaseSenateENT.IdPubClassCase = objvPubClassCaseSenateENS.IdPubClassCase; //案例流水号
objvPubClassCaseSenateENT.PubClassCaseID = objvPubClassCaseSenateENS.PubClassCaseID; //案例ID
objvPubClassCaseSenateENT.PubClassCaseName = objvPubClassCaseSenateENS.PubClassCaseName; //案例课题名称
objvPubClassCaseSenateENT.PubClassCaseDateIn = objvPubClassCaseSenateENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseSenateENT.PubClassCaseTeachDate = objvPubClassCaseSenateENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseSenateENT.PubClassCaseBG = objvPubClassCaseSenateENS.PubClassCaseBG; //案例背景资料
objvPubClassCaseSenateENT.PubClassCaseTheme = objvPubClassCaseSenateENS.PubClassCaseTheme; //案例主题词
objvPubClassCaseSenateENT.PubClassCaseExecutor = objvPubClassCaseSenateENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseSenateENT.DisciplineID = objvPubClassCaseSenateENS.DisciplineID; //学科ID
objvPubClassCaseSenateENT.DisciplineName = objvPubClassCaseSenateENS.DisciplineName; //学科名称
objvPubClassCaseSenateENT.StudyLevelName = objvPubClassCaseSenateENS.StudyLevelName; //学段名称
objvPubClassCaseSenateENT.IsElite = objvPubClassCaseSenateENS.IsElite; //精华标志
objvPubClassCaseSenateENT.SubjectName = objvPubClassCaseSenateENS.SubjectName; //课题名称
objvPubClassCaseSenateENT.ResourceID = objvPubClassCaseSenateENS.ResourceID; //资源ID
objvPubClassCaseSenateENT.ResourceTypeID = objvPubClassCaseSenateENS.ResourceTypeID; //资源类型ID
objvPubClassCaseSenateENT.ResourceTypeName = objvPubClassCaseSenateENS.ResourceTypeName; //资源类型名称
objvPubClassCaseSenateENT.PubCaseTypeID = objvPubClassCaseSenateENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseSenateENT.PubCaseTypeName = objvPubClassCaseSenateENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseSenateENT.PubClassCaseSenateClassID = objvPubClassCaseSenateENS.PubClassCaseSenateClassID; //公开课案例评议类别ID
objvPubClassCaseSenateENT.PubClassCaseSenateClassName = objvPubClassCaseSenateENS.PubClassCaseSenateClassName; //公开课案例评议类别名称
objvPubClassCaseSenateENT.PubClassCaseSenator = objvPubClassCaseSenateENS.PubClassCaseSenator; //公开课案例评议者
objvPubClassCaseSenateENT.PubClassCaseSenateTitle = objvPubClassCaseSenateENS.PubClassCaseSenateTitle; //公开课案例评议标题
objvPubClassCaseSenateENT.PubClassCaseSenateContent = objvPubClassCaseSenateENS.PubClassCaseSenateContent; //公开课案例评议内容
objvPubClassCaseSenateENT.PubClassCaseSenateDate = objvPubClassCaseSenateENS.PubClassCaseSenateDate; //公开课案例评议日期
objvPubClassCaseSenateENT.PubClassCaseSenateTime = objvPubClassCaseSenateENS.PubClassCaseSenateTime; //公开课案例评议时间
objvPubClassCaseSenateENT.SenateReadCount = objvPubClassCaseSenateENS.SenateReadCount; //评议阅读次数
objvPubClassCaseSenateENT.ResourceOwner = objvPubClassCaseSenateENS.ResourceOwner; //上传者
objvPubClassCaseSenateENT.ftpResourceOwner = objvPubClassCaseSenateENS.ftpResourceOwner; //Ftp资源拥有者
objvPubClassCaseSenateENT.FileNewName = objvPubClassCaseSenateENS.FileNewName; //新文件名
objvPubClassCaseSenateENT.FileOldName = objvPubClassCaseSenateENS.FileOldName; //旧文件名
objvPubClassCaseSenateENT.FileSize = objvPubClassCaseSenateENS.FileSize; //文件大小
objvPubClassCaseSenateENT.FileType = objvPubClassCaseSenateENS.FileType; //文件类型
objvPubClassCaseSenateENT.FileName = objvPubClassCaseSenateENS.FileName; //文件名称
objvPubClassCaseSenateENT.SaveTime = objvPubClassCaseSenateENS.SaveTime; //创建时间
objvPubClassCaseSenateENT.IsVisual = objvPubClassCaseSenateENS.IsVisual; //隐藏标志
objvPubClassCaseSenateENT.IdTeachingPlan = objvPubClassCaseSenateENS.IdTeachingPlan; //教案流水号
objvPubClassCaseSenateENT.IdFtpResource = objvPubClassCaseSenateENS.IdFtpResource; //FTP资源流水号
objvPubClassCaseSenateENT.FileUpDate = objvPubClassCaseSenateENS.FileUpDate; //创建日期
objvPubClassCaseSenateENT.FileDirName = objvPubClassCaseSenateENS.FileDirName; //文件目录名
objvPubClassCaseSenateENT.FileOriginalName = objvPubClassCaseSenateENS.FileOriginalName; //文件原名
objvPubClassCaseSenateENT.FtpResourceID = objvPubClassCaseSenateENS.FtpResourceID; //FTP资源ID
objvPubClassCaseSenateENT.FileRename = objvPubClassCaseSenateENS.FileRename; //文件新名
objvPubClassCaseSenateENT.FileUpTime = objvPubClassCaseSenateENS.FileUpTime; //创建时间
objvPubClassCaseSenateENT.SaveMode = objvPubClassCaseSenateENS.SaveMode; //文件存放方式
objvPubClassCaseSenateENT.IdResourceType = objvPubClassCaseSenateENS.IdResourceType; //资源类型流水号
objvPubClassCaseSenateENT.IdPubCaseType = objvPubClassCaseSenateENS.IdPubCaseType; //公开课案例类型流水号
objvPubClassCaseSenateENT.ftpFileType = objvPubClassCaseSenateENS.ftpFileType; //ftp文件类型
objvPubClassCaseSenateENT.ftpFileSize = objvPubClassCaseSenateENS.ftpFileSize; //ftp文件大小
objvPubClassCaseSenateENT.FileOriginName = objvPubClassCaseSenateENS.FileOriginName; //原文件名
objvPubClassCaseSenateENT.IdResource = objvPubClassCaseSenateENS.IdResource; //资源流水号
objvPubClassCaseSenateENT.IdDiscipline = objvPubClassCaseSenateENS.IdDiscipline; //学科流水号
objvPubClassCaseSenateENT.IdStudyLevel = objvPubClassCaseSenateENS.IdStudyLevel; //id_StudyLevel
objvPubClassCaseSenateENT.IdFile = objvPubClassCaseSenateENS.IdFile; //文件流水号
objvPubClassCaseSenateENT.IsVisible = objvPubClassCaseSenateENS.IsVisible; //是否显示
objvPubClassCaseSenateENT.SaveDate = objvPubClassCaseSenateENS.SaveDate; //创建日期
objvPubClassCaseSenateENT.IdPubClassCaseSenateClass = objvPubClassCaseSenateENS.IdPubClassCaseSenateClass; //公开课案例评议类别流水号
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
 /// <param name = "objvPubClassCaseSenateENS">源对象</param>
 /// <returns>目标对象=>clsvPubClassCaseSenateEN:objvPubClassCaseSenateENT</returns>
 public static clsvPubClassCaseSenateEN CopyTo(this clsvPubClassCaseSenateEN objvPubClassCaseSenateENS)
{
try
{
 clsvPubClassCaseSenateEN objvPubClassCaseSenateENT = new clsvPubClassCaseSenateEN()
{
IdPubClassCaseSenate = objvPubClassCaseSenateENS.IdPubClassCaseSenate, //公开课案例评议流水号
IdPubClassCase = objvPubClassCaseSenateENS.IdPubClassCase, //案例流水号
PubClassCaseID = objvPubClassCaseSenateENS.PubClassCaseID, //案例ID
PubClassCaseName = objvPubClassCaseSenateENS.PubClassCaseName, //案例课题名称
PubClassCaseDateIn = objvPubClassCaseSenateENS.PubClassCaseDateIn, //案例入库日期
PubClassCaseTeachDate = objvPubClassCaseSenateENS.PubClassCaseTeachDate, //案例授课日期
PubClassCaseBG = objvPubClassCaseSenateENS.PubClassCaseBG, //案例背景资料
PubClassCaseTheme = objvPubClassCaseSenateENS.PubClassCaseTheme, //案例主题词
PubClassCaseExecutor = objvPubClassCaseSenateENS.PubClassCaseExecutor, //案例执教者
DisciplineID = objvPubClassCaseSenateENS.DisciplineID, //学科ID
DisciplineName = objvPubClassCaseSenateENS.DisciplineName, //学科名称
StudyLevelName = objvPubClassCaseSenateENS.StudyLevelName, //学段名称
IsElite = objvPubClassCaseSenateENS.IsElite, //精华标志
SubjectName = objvPubClassCaseSenateENS.SubjectName, //课题名称
ResourceID = objvPubClassCaseSenateENS.ResourceID, //资源ID
ResourceTypeID = objvPubClassCaseSenateENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvPubClassCaseSenateENS.ResourceTypeName, //资源类型名称
PubCaseTypeID = objvPubClassCaseSenateENS.PubCaseTypeID, //公开课案例类型ID
PubCaseTypeName = objvPubClassCaseSenateENS.PubCaseTypeName, //公开课案例类型名称
PubClassCaseSenateClassID = objvPubClassCaseSenateENS.PubClassCaseSenateClassID, //公开课案例评议类别ID
PubClassCaseSenateClassName = objvPubClassCaseSenateENS.PubClassCaseSenateClassName, //公开课案例评议类别名称
PubClassCaseSenator = objvPubClassCaseSenateENS.PubClassCaseSenator, //公开课案例评议者
PubClassCaseSenateTitle = objvPubClassCaseSenateENS.PubClassCaseSenateTitle, //公开课案例评议标题
PubClassCaseSenateContent = objvPubClassCaseSenateENS.PubClassCaseSenateContent, //公开课案例评议内容
PubClassCaseSenateDate = objvPubClassCaseSenateENS.PubClassCaseSenateDate, //公开课案例评议日期
PubClassCaseSenateTime = objvPubClassCaseSenateENS.PubClassCaseSenateTime, //公开课案例评议时间
SenateReadCount = objvPubClassCaseSenateENS.SenateReadCount, //评议阅读次数
ResourceOwner = objvPubClassCaseSenateENS.ResourceOwner, //上传者
ftpResourceOwner = objvPubClassCaseSenateENS.ftpResourceOwner, //Ftp资源拥有者
FileNewName = objvPubClassCaseSenateENS.FileNewName, //新文件名
FileOldName = objvPubClassCaseSenateENS.FileOldName, //旧文件名
FileSize = objvPubClassCaseSenateENS.FileSize, //文件大小
FileType = objvPubClassCaseSenateENS.FileType, //文件类型
FileName = objvPubClassCaseSenateENS.FileName, //文件名称
SaveTime = objvPubClassCaseSenateENS.SaveTime, //创建时间
IsVisual = objvPubClassCaseSenateENS.IsVisual, //隐藏标志
IdTeachingPlan = objvPubClassCaseSenateENS.IdTeachingPlan, //教案流水号
IdFtpResource = objvPubClassCaseSenateENS.IdFtpResource, //FTP资源流水号
FileUpDate = objvPubClassCaseSenateENS.FileUpDate, //创建日期
FileDirName = objvPubClassCaseSenateENS.FileDirName, //文件目录名
FileOriginalName = objvPubClassCaseSenateENS.FileOriginalName, //文件原名
FtpResourceID = objvPubClassCaseSenateENS.FtpResourceID, //FTP资源ID
FileRename = objvPubClassCaseSenateENS.FileRename, //文件新名
FileUpTime = objvPubClassCaseSenateENS.FileUpTime, //创建时间
SaveMode = objvPubClassCaseSenateENS.SaveMode, //文件存放方式
IdResourceType = objvPubClassCaseSenateENS.IdResourceType, //资源类型流水号
IdPubCaseType = objvPubClassCaseSenateENS.IdPubCaseType, //公开课案例类型流水号
ftpFileType = objvPubClassCaseSenateENS.ftpFileType, //ftp文件类型
ftpFileSize = objvPubClassCaseSenateENS.ftpFileSize, //ftp文件大小
FileOriginName = objvPubClassCaseSenateENS.FileOriginName, //原文件名
IdResource = objvPubClassCaseSenateENS.IdResource, //资源流水号
IdDiscipline = objvPubClassCaseSenateENS.IdDiscipline, //学科流水号
IdStudyLevel = objvPubClassCaseSenateENS.IdStudyLevel, //id_StudyLevel
IdFile = objvPubClassCaseSenateENS.IdFile, //文件流水号
IsVisible = objvPubClassCaseSenateENS.IsVisible, //是否显示
SaveDate = objvPubClassCaseSenateENS.SaveDate, //创建日期
IdPubClassCaseSenateClass = objvPubClassCaseSenateENS.IdPubClassCaseSenateClass, //公开课案例评议类别流水号
};
 return objvPubClassCaseSenateENT;
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
public static void CheckProperty4Condition(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN)
{
 clsvPubClassCaseSenateBL.vPubClassCaseSenateDA.CheckProperty4Condition(objvPubClassCaseSenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCaseSenateEN objvPubClassCaseSenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdPubClassCaseSenate) == true)
{
string strComparisonOpIdPubClassCaseSenate = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdPubClassCaseSenate];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseSenate.IdPubClassCaseSenate, objvPubClassCaseSenateCond.IdPubClassCaseSenate, strComparisonOpIdPubClassCaseSenate);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.IdPubClassCase, objvPubClassCaseSenateCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseID) == true)
{
string strComparisonOpPubClassCaseID = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseID, objvPubClassCaseSenateCond.PubClassCaseID, strComparisonOpPubClassCaseID);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseName) == true)
{
string strComparisonOpPubClassCaseName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseName, objvPubClassCaseSenateCond.PubClassCaseName, strComparisonOpPubClassCaseName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseDateIn) == true)
{
string strComparisonOpPubClassCaseDateIn = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseDateIn, objvPubClassCaseSenateCond.PubClassCaseDateIn, strComparisonOpPubClassCaseDateIn);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseTeachDate) == true)
{
string strComparisonOpPubClassCaseTeachDate = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseTeachDate, objvPubClassCaseSenateCond.PubClassCaseTeachDate, strComparisonOpPubClassCaseTeachDate);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseTheme) == true)
{
string strComparisonOpPubClassCaseTheme = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseTheme, objvPubClassCaseSenateCond.PubClassCaseTheme, strComparisonOpPubClassCaseTheme);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseExecutor) == true)
{
string strComparisonOpPubClassCaseExecutor = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseExecutor, objvPubClassCaseSenateCond.PubClassCaseExecutor, strComparisonOpPubClassCaseExecutor);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.DisciplineID, objvPubClassCaseSenateCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.DisciplineName, objvPubClassCaseSenateCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.StudyLevelName, objvPubClassCaseSenateCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IsElite) == true)
{
if (objvPubClassCaseSenateCond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseSenate.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseSenate.IsElite);
}
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.SubjectName) == true)
{
string strComparisonOpSubjectName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.SubjectName, objvPubClassCaseSenateCond.SubjectName, strComparisonOpSubjectName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.ResourceID) == true)
{
string strComparisonOpResourceID = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ResourceID, objvPubClassCaseSenateCond.ResourceID, strComparisonOpResourceID);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ResourceTypeID, objvPubClassCaseSenateCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ResourceTypeName, objvPubClassCaseSenateCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubCaseTypeID) == true)
{
string strComparisonOpPubCaseTypeID = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubCaseTypeID, objvPubClassCaseSenateCond.PubCaseTypeID, strComparisonOpPubCaseTypeID);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubCaseTypeName) == true)
{
string strComparisonOpPubCaseTypeName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubCaseTypeName, objvPubClassCaseSenateCond.PubCaseTypeName, strComparisonOpPubCaseTypeName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateClassID) == true)
{
string strComparisonOpPubClassCaseSenateClassID = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateClassID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateClassID, objvPubClassCaseSenateCond.PubClassCaseSenateClassID, strComparisonOpPubClassCaseSenateClassID);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateClassName) == true)
{
string strComparisonOpPubClassCaseSenateClassName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateClassName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateClassName, objvPubClassCaseSenateCond.PubClassCaseSenateClassName, strComparisonOpPubClassCaseSenateClassName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenator) == true)
{
string strComparisonOpPubClassCaseSenator = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenator, objvPubClassCaseSenateCond.PubClassCaseSenator, strComparisonOpPubClassCaseSenator);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateTitle) == true)
{
string strComparisonOpPubClassCaseSenateTitle = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateTitle, objvPubClassCaseSenateCond.PubClassCaseSenateTitle, strComparisonOpPubClassCaseSenateTitle);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateContent) == true)
{
string strComparisonOpPubClassCaseSenateContent = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateContent, objvPubClassCaseSenateCond.PubClassCaseSenateContent, strComparisonOpPubClassCaseSenateContent);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateDate) == true)
{
string strComparisonOpPubClassCaseSenateDate = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateDate, objvPubClassCaseSenateCond.PubClassCaseSenateDate, strComparisonOpPubClassCaseSenateDate);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateTime) == true)
{
string strComparisonOpPubClassCaseSenateTime = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateTime, objvPubClassCaseSenateCond.PubClassCaseSenateTime, strComparisonOpPubClassCaseSenateTime);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.SenateReadCount) == true)
{
string strComparisonOpSenateReadCount = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.SenateReadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseSenate.SenateReadCount, objvPubClassCaseSenateCond.SenateReadCount, strComparisonOpSenateReadCount);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ResourceOwner, objvPubClassCaseSenateCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ftpResourceOwner, objvPubClassCaseSenateCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileNewName) == true)
{
string strComparisonOpFileNewName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileNewName, objvPubClassCaseSenateCond.FileNewName, strComparisonOpFileNewName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileOldName) == true)
{
string strComparisonOpFileOldName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileOldName, objvPubClassCaseSenateCond.FileOldName, strComparisonOpFileOldName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileSize) == true)
{
string strComparisonOpFileSize = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileSize, objvPubClassCaseSenateCond.FileSize, strComparisonOpFileSize);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileType) == true)
{
string strComparisonOpFileType = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileType, objvPubClassCaseSenateCond.FileType, strComparisonOpFileType);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileName) == true)
{
string strComparisonOpFileName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileName, objvPubClassCaseSenateCond.FileName, strComparisonOpFileName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.SaveTime) == true)
{
string strComparisonOpSaveTime = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.SaveTime, objvPubClassCaseSenateCond.SaveTime, strComparisonOpSaveTime);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IsVisual) == true)
{
if (objvPubClassCaseSenateCond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseSenate.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseSenate.IsVisual);
}
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.IdTeachingPlan, objvPubClassCaseSenateCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.IdFtpResource, objvPubClassCaseSenateCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileUpDate, objvPubClassCaseSenateCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileDirName) == true)
{
string strComparisonOpFileDirName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileDirName, objvPubClassCaseSenateCond.FileDirName, strComparisonOpFileDirName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileOriginalName, objvPubClassCaseSenateCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FtpResourceID, objvPubClassCaseSenateCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileRename) == true)
{
string strComparisonOpFileRename = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileRename, objvPubClassCaseSenateCond.FileRename, strComparisonOpFileRename);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileUpTime, objvPubClassCaseSenateCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.SaveMode) == true)
{
if (objvPubClassCaseSenateCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseSenate.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseSenate.SaveMode);
}
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.IdResourceType, objvPubClassCaseSenateCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdPubCaseType) == true)
{
string strComparisonOpIdPubCaseType = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdPubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.IdPubCaseType, objvPubClassCaseSenateCond.IdPubCaseType, strComparisonOpIdPubCaseType);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ftpFileType, objvPubClassCaseSenateCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ftpFileSize, objvPubClassCaseSenateCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileOriginName, objvPubClassCaseSenateCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdResource) == true)
{
string strComparisonOpIdResource = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.IdResource, objvPubClassCaseSenateCond.IdResource, strComparisonOpIdResource);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.IdDiscipline, objvPubClassCaseSenateCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.IdStudyLevel, objvPubClassCaseSenateCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdFile) == true)
{
string strComparisonOpIdFile = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.IdFile, objvPubClassCaseSenateCond.IdFile, strComparisonOpIdFile);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IsVisible) == true)
{
if (objvPubClassCaseSenateCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseSenate.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseSenate.IsVisible);
}
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.SaveDate) == true)
{
string strComparisonOpSaveDate = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.SaveDate, objvPubClassCaseSenateCond.SaveDate, strComparisonOpSaveDate);
}
if (objvPubClassCaseSenateCond.IsUpdated(convPubClassCaseSenate.IdPubClassCaseSenateClass) == true)
{
string strComparisonOpIdPubClassCaseSenateClass = objvPubClassCaseSenateCond.dicFldComparisonOp[convPubClassCaseSenate.IdPubClassCaseSenateClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.IdPubClassCaseSenateClass, objvPubClassCaseSenateCond.IdPubClassCaseSenateClass, strComparisonOpIdPubClassCaseSenateClass);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPubClassCaseSenate
{
public virtual bool UpdRelaTabDate(long lngIdPubClassCaseSenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v公开课案例评议(vPubClassCaseSenate)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCaseSenateBL
{
public static RelatedActions_vPubClassCaseSenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPubClassCaseSenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPubClassCaseSenateDA vPubClassCaseSenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPubClassCaseSenateDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPubClassCaseSenateBL()
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
if (string.IsNullOrEmpty(clsvPubClassCaseSenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCaseSenateEN._ConnectString);
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
public static DataTable GetDataTable_vPubClassCaseSenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPubClassCaseSenateDA.GetDataTable_vPubClassCaseSenate(strWhereCond);
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
objDT = vPubClassCaseSenateDA.GetDataTable(strWhereCond);
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
objDT = vPubClassCaseSenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPubClassCaseSenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPubClassCaseSenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPubClassCaseSenateDA.GetDataTable_Top(objTopPara);
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
objDT = vPubClassCaseSenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPubClassCaseSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPubClassCaseSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubClassCaseSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPubClassCaseSenateEN> GetObjLstByIdPubClassCaseSenateLst(List<long> arrIdPubClassCaseSenateLst)
{
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseSenateLst);
 string strWhereCond = string.Format("IdPubClassCaseSenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPubClassCaseSenateEN> GetObjLstByIdPubClassCaseSenateLstCache(List<long> arrIdPubClassCaseSenateLst)
{
string strKey = string.Format("{0}", clsvPubClassCaseSenateEN._CurrTabName);
List<clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLst_Sel =
arrvPubClassCaseSenateObjLstCache
.Where(x => arrIdPubClassCaseSenateLst.Contains(x.IdPubClassCaseSenate));
return arrvPubClassCaseSenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseSenateEN> GetObjLst(string strWhereCond)
{
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateEN);
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
public static List<clsvPubClassCaseSenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPubClassCaseSenateEN> GetSubObjLstCache(clsvPubClassCaseSenateEN objvPubClassCaseSenateCond)
{
List<clsvPubClassCaseSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCaseSenate.AttributeName)
{
if (objvPubClassCaseSenateCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCaseSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseSenateCond[strFldName].ToString());
}
else
{
if (objvPubClassCaseSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCaseSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCaseSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseSenateCond[strFldName]));
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
public static List<clsvPubClassCaseSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateEN);
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
public static List<clsvPubClassCaseSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateEN);
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
List<clsvPubClassCaseSenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPubClassCaseSenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseSenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPubClassCaseSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
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
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateEN);
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
public static List<clsvPubClassCaseSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPubClassCaseSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPubClassCaseSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateEN);
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
public static List<clsvPubClassCaseSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseSenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPubClassCaseSenate(ref clsvPubClassCaseSenateEN objvPubClassCaseSenateEN)
{
bool bolResult = vPubClassCaseSenateDA.GetvPubClassCaseSenate(ref objvPubClassCaseSenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseSenateEN GetObjByIdPubClassCaseSenate(long lngIdPubClassCaseSenate)
{
clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = vPubClassCaseSenateDA.GetObjByIdPubClassCaseSenate(lngIdPubClassCaseSenate);
return objvPubClassCaseSenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPubClassCaseSenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = vPubClassCaseSenateDA.GetFirstObj(strWhereCond);
 return objvPubClassCaseSenateEN;
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
public static clsvPubClassCaseSenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = vPubClassCaseSenateDA.GetObjByDataRow(objRow);
 return objvPubClassCaseSenateEN;
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
public static clsvPubClassCaseSenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = vPubClassCaseSenateDA.GetObjByDataRow(objRow);
 return objvPubClassCaseSenateEN;
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
 /// <param name = "lngIdPubClassCaseSenate">所给的关键字</param>
 /// <param name = "lstvPubClassCaseSenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseSenateEN GetObjByIdPubClassCaseSenateFromList(long lngIdPubClassCaseSenate, List<clsvPubClassCaseSenateEN> lstvPubClassCaseSenateObjLst)
{
foreach (clsvPubClassCaseSenateEN objvPubClassCaseSenateEN in lstvPubClassCaseSenateObjLst)
{
if (objvPubClassCaseSenateEN.IdPubClassCaseSenate == lngIdPubClassCaseSenate)
{
return objvPubClassCaseSenateEN;
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
 long lngIdPubClassCaseSenate;
 try
 {
 lngIdPubClassCaseSenate = new clsvPubClassCaseSenateDA().GetFirstID(strWhereCond);
 return lngIdPubClassCaseSenate;
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
 arrList = vPubClassCaseSenateDA.GetID(strWhereCond);
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
bool bolIsExist = vPubClassCaseSenateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdPubClassCaseSenate)
{
//检测记录是否存在
bool bolIsExist = vPubClassCaseSenateDA.IsExist(lngIdPubClassCaseSenate);
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
 bolIsExist = clsvPubClassCaseSenateDA.IsExistTable();
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
 bolIsExist = vPubClassCaseSenateDA.IsExistTable(strTabName);
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
 /// <param name = "objvPubClassCaseSenateENS">源对象</param>
 /// <param name = "objvPubClassCaseSenateENT">目标对象</param>
 public static void CopyTo(clsvPubClassCaseSenateEN objvPubClassCaseSenateENS, clsvPubClassCaseSenateEN objvPubClassCaseSenateENT)
{
try
{
objvPubClassCaseSenateENT.IdPubClassCaseSenate = objvPubClassCaseSenateENS.IdPubClassCaseSenate; //公开课案例评议流水号
objvPubClassCaseSenateENT.IdPubClassCase = objvPubClassCaseSenateENS.IdPubClassCase; //案例流水号
objvPubClassCaseSenateENT.PubClassCaseID = objvPubClassCaseSenateENS.PubClassCaseID; //案例ID
objvPubClassCaseSenateENT.PubClassCaseName = objvPubClassCaseSenateENS.PubClassCaseName; //案例课题名称
objvPubClassCaseSenateENT.PubClassCaseDateIn = objvPubClassCaseSenateENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseSenateENT.PubClassCaseTeachDate = objvPubClassCaseSenateENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseSenateENT.PubClassCaseBG = objvPubClassCaseSenateENS.PubClassCaseBG; //案例背景资料
objvPubClassCaseSenateENT.PubClassCaseTheme = objvPubClassCaseSenateENS.PubClassCaseTheme; //案例主题词
objvPubClassCaseSenateENT.PubClassCaseExecutor = objvPubClassCaseSenateENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseSenateENT.DisciplineID = objvPubClassCaseSenateENS.DisciplineID; //学科ID
objvPubClassCaseSenateENT.DisciplineName = objvPubClassCaseSenateENS.DisciplineName; //学科名称
objvPubClassCaseSenateENT.StudyLevelName = objvPubClassCaseSenateENS.StudyLevelName; //学段名称
objvPubClassCaseSenateENT.IsElite = objvPubClassCaseSenateENS.IsElite; //精华标志
objvPubClassCaseSenateENT.SubjectName = objvPubClassCaseSenateENS.SubjectName; //课题名称
objvPubClassCaseSenateENT.ResourceID = objvPubClassCaseSenateENS.ResourceID; //资源ID
objvPubClassCaseSenateENT.ResourceTypeID = objvPubClassCaseSenateENS.ResourceTypeID; //资源类型ID
objvPubClassCaseSenateENT.ResourceTypeName = objvPubClassCaseSenateENS.ResourceTypeName; //资源类型名称
objvPubClassCaseSenateENT.PubCaseTypeID = objvPubClassCaseSenateENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseSenateENT.PubCaseTypeName = objvPubClassCaseSenateENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseSenateENT.PubClassCaseSenateClassID = objvPubClassCaseSenateENS.PubClassCaseSenateClassID; //公开课案例评议类别ID
objvPubClassCaseSenateENT.PubClassCaseSenateClassName = objvPubClassCaseSenateENS.PubClassCaseSenateClassName; //公开课案例评议类别名称
objvPubClassCaseSenateENT.PubClassCaseSenator = objvPubClassCaseSenateENS.PubClassCaseSenator; //公开课案例评议者
objvPubClassCaseSenateENT.PubClassCaseSenateTitle = objvPubClassCaseSenateENS.PubClassCaseSenateTitle; //公开课案例评议标题
objvPubClassCaseSenateENT.PubClassCaseSenateContent = objvPubClassCaseSenateENS.PubClassCaseSenateContent; //公开课案例评议内容
objvPubClassCaseSenateENT.PubClassCaseSenateDate = objvPubClassCaseSenateENS.PubClassCaseSenateDate; //公开课案例评议日期
objvPubClassCaseSenateENT.PubClassCaseSenateTime = objvPubClassCaseSenateENS.PubClassCaseSenateTime; //公开课案例评议时间
objvPubClassCaseSenateENT.SenateReadCount = objvPubClassCaseSenateENS.SenateReadCount; //评议阅读次数
objvPubClassCaseSenateENT.ResourceOwner = objvPubClassCaseSenateENS.ResourceOwner; //上传者
objvPubClassCaseSenateENT.ftpResourceOwner = objvPubClassCaseSenateENS.ftpResourceOwner; //Ftp资源拥有者
objvPubClassCaseSenateENT.FileNewName = objvPubClassCaseSenateENS.FileNewName; //新文件名
objvPubClassCaseSenateENT.FileOldName = objvPubClassCaseSenateENS.FileOldName; //旧文件名
objvPubClassCaseSenateENT.FileSize = objvPubClassCaseSenateENS.FileSize; //文件大小
objvPubClassCaseSenateENT.FileType = objvPubClassCaseSenateENS.FileType; //文件类型
objvPubClassCaseSenateENT.FileName = objvPubClassCaseSenateENS.FileName; //文件名称
objvPubClassCaseSenateENT.SaveTime = objvPubClassCaseSenateENS.SaveTime; //创建时间
objvPubClassCaseSenateENT.IsVisual = objvPubClassCaseSenateENS.IsVisual; //隐藏标志
objvPubClassCaseSenateENT.IdTeachingPlan = objvPubClassCaseSenateENS.IdTeachingPlan; //教案流水号
objvPubClassCaseSenateENT.IdFtpResource = objvPubClassCaseSenateENS.IdFtpResource; //FTP资源流水号
objvPubClassCaseSenateENT.FileUpDate = objvPubClassCaseSenateENS.FileUpDate; //创建日期
objvPubClassCaseSenateENT.FileDirName = objvPubClassCaseSenateENS.FileDirName; //文件目录名
objvPubClassCaseSenateENT.FileOriginalName = objvPubClassCaseSenateENS.FileOriginalName; //文件原名
objvPubClassCaseSenateENT.FtpResourceID = objvPubClassCaseSenateENS.FtpResourceID; //FTP资源ID
objvPubClassCaseSenateENT.FileRename = objvPubClassCaseSenateENS.FileRename; //文件新名
objvPubClassCaseSenateENT.FileUpTime = objvPubClassCaseSenateENS.FileUpTime; //创建时间
objvPubClassCaseSenateENT.SaveMode = objvPubClassCaseSenateENS.SaveMode; //文件存放方式
objvPubClassCaseSenateENT.IdResourceType = objvPubClassCaseSenateENS.IdResourceType; //资源类型流水号
objvPubClassCaseSenateENT.IdPubCaseType = objvPubClassCaseSenateENS.IdPubCaseType; //公开课案例类型流水号
objvPubClassCaseSenateENT.ftpFileType = objvPubClassCaseSenateENS.ftpFileType; //ftp文件类型
objvPubClassCaseSenateENT.ftpFileSize = objvPubClassCaseSenateENS.ftpFileSize; //ftp文件大小
objvPubClassCaseSenateENT.FileOriginName = objvPubClassCaseSenateENS.FileOriginName; //原文件名
objvPubClassCaseSenateENT.IdResource = objvPubClassCaseSenateENS.IdResource; //资源流水号
objvPubClassCaseSenateENT.IdDiscipline = objvPubClassCaseSenateENS.IdDiscipline; //学科流水号
objvPubClassCaseSenateENT.IdStudyLevel = objvPubClassCaseSenateENS.IdStudyLevel; //id_StudyLevel
objvPubClassCaseSenateENT.IdFile = objvPubClassCaseSenateENS.IdFile; //文件流水号
objvPubClassCaseSenateENT.IsVisible = objvPubClassCaseSenateENS.IsVisible; //是否显示
objvPubClassCaseSenateENT.SaveDate = objvPubClassCaseSenateENS.SaveDate; //创建日期
objvPubClassCaseSenateENT.IdPubClassCaseSenateClass = objvPubClassCaseSenateENS.IdPubClassCaseSenateClass; //公开课案例评议类别流水号
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
 /// <param name = "objvPubClassCaseSenateEN">源简化对象</param>
 public static void SetUpdFlag(clsvPubClassCaseSenateEN objvPubClassCaseSenateEN)
{
try
{
objvPubClassCaseSenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPubClassCaseSenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPubClassCaseSenate.IdPubClassCaseSenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = objvPubClassCaseSenateEN.IdPubClassCaseSenate; //公开课案例评议流水号
}
if (arrFldSet.Contains(convPubClassCaseSenate.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdPubClassCase = objvPubClassCaseSenateEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseID = objvPubClassCaseSenateEN.PubClassCaseID; //案例ID
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseName = objvPubClassCaseSenateEN.PubClassCaseName; //案例课题名称
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseDateIn = objvPubClassCaseSenateEN.PubClassCaseDateIn == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseTeachDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objvPubClassCaseSenateEN.PubClassCaseTeachDate == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseTeachDate; //案例授课日期
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseBG, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseBG = objvPubClassCaseSenateEN.PubClassCaseBG == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseBG; //案例背景资料
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseTheme = objvPubClassCaseSenateEN.PubClassCaseTheme == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseTheme; //案例主题词
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseExecutor = objvPubClassCaseSenateEN.PubClassCaseExecutor == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(convPubClassCaseSenate.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.DisciplineID = objvPubClassCaseSenateEN.DisciplineID == "[null]" ? null :  objvPubClassCaseSenateEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convPubClassCaseSenate.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.DisciplineName = objvPubClassCaseSenateEN.DisciplineName == "[null]" ? null :  objvPubClassCaseSenateEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convPubClassCaseSenate.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.StudyLevelName = objvPubClassCaseSenateEN.StudyLevelName == "[null]" ? null :  objvPubClassCaseSenateEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convPubClassCaseSenate.IsElite, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IsElite = objvPubClassCaseSenateEN.IsElite; //精华标志
}
if (arrFldSet.Contains(convPubClassCaseSenate.SubjectName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.SubjectName = objvPubClassCaseSenateEN.SubjectName; //课题名称
}
if (arrFldSet.Contains(convPubClassCaseSenate.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.ResourceID = objvPubClassCaseSenateEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convPubClassCaseSenate.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.ResourceTypeID = objvPubClassCaseSenateEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convPubClassCaseSenate.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.ResourceTypeName = objvPubClassCaseSenateEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubCaseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubCaseTypeID = objvPubClassCaseSenateEN.PubCaseTypeID; //公开课案例类型ID
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubCaseTypeName = objvPubClassCaseSenateEN.PubCaseTypeName; //公开课案例类型名称
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseSenateClassID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objvPubClassCaseSenateEN.PubClassCaseSenateClassID == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseSenateClassID; //公开课案例评议类别ID
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseSenateClassName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objvPubClassCaseSenateEN.PubClassCaseSenateClassName == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseSenateClassName; //公开课案例评议类别名称
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseSenator, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseSenator = objvPubClassCaseSenateEN.PubClassCaseSenator == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseSenator; //公开课案例评议者
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseSenateTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objvPubClassCaseSenateEN.PubClassCaseSenateTitle == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseSenateTitle; //公开课案例评议标题
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseSenateContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objvPubClassCaseSenateEN.PubClassCaseSenateContent == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseSenateContent; //公开课案例评议内容
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseSenateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objvPubClassCaseSenateEN.PubClassCaseSenateDate == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseSenateDate; //公开课案例评议日期
}
if (arrFldSet.Contains(convPubClassCaseSenate.PubClassCaseSenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objvPubClassCaseSenateEN.PubClassCaseSenateTime == "[null]" ? null :  objvPubClassCaseSenateEN.PubClassCaseSenateTime; //公开课案例评议时间
}
if (arrFldSet.Contains(convPubClassCaseSenate.SenateReadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.SenateReadCount = objvPubClassCaseSenateEN.SenateReadCount; //评议阅读次数
}
if (arrFldSet.Contains(convPubClassCaseSenate.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.ResourceOwner = objvPubClassCaseSenateEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convPubClassCaseSenate.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.ftpResourceOwner = objvPubClassCaseSenateEN.ftpResourceOwner == "[null]" ? null :  objvPubClassCaseSenateEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileNewName = objvPubClassCaseSenateEN.FileNewName == "[null]" ? null :  objvPubClassCaseSenateEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileOldName = objvPubClassCaseSenateEN.FileOldName == "[null]" ? null :  objvPubClassCaseSenateEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileSize = objvPubClassCaseSenateEN.FileSize == "[null]" ? null :  objvPubClassCaseSenateEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileType = objvPubClassCaseSenateEN.FileType == "[null]" ? null :  objvPubClassCaseSenateEN.FileType; //文件类型
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileName = objvPubClassCaseSenateEN.FileName == "[null]" ? null :  objvPubClassCaseSenateEN.FileName; //文件名称
}
if (arrFldSet.Contains(convPubClassCaseSenate.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.SaveTime = objvPubClassCaseSenateEN.SaveTime == "[null]" ? null :  objvPubClassCaseSenateEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convPubClassCaseSenate.IsVisual, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IsVisual = objvPubClassCaseSenateEN.IsVisual; //隐藏标志
}
if (arrFldSet.Contains(convPubClassCaseSenate.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdTeachingPlan = objvPubClassCaseSenateEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convPubClassCaseSenate.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdFtpResource = objvPubClassCaseSenateEN.IdFtpResource == "[null]" ? null :  objvPubClassCaseSenateEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileUpDate = objvPubClassCaseSenateEN.FileUpDate == "[null]" ? null :  objvPubClassCaseSenateEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileDirName = objvPubClassCaseSenateEN.FileDirName == "[null]" ? null :  objvPubClassCaseSenateEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileOriginalName = objvPubClassCaseSenateEN.FileOriginalName == "[null]" ? null :  objvPubClassCaseSenateEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convPubClassCaseSenate.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FtpResourceID = objvPubClassCaseSenateEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileRename = objvPubClassCaseSenateEN.FileRename == "[null]" ? null :  objvPubClassCaseSenateEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileUpTime = objvPubClassCaseSenateEN.FileUpTime == "[null]" ? null :  objvPubClassCaseSenateEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convPubClassCaseSenate.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.SaveMode = objvPubClassCaseSenateEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convPubClassCaseSenate.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdResourceType = objvPubClassCaseSenateEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convPubClassCaseSenate.IdPubCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdPubCaseType = objvPubClassCaseSenateEN.IdPubCaseType; //公开课案例类型流水号
}
if (arrFldSet.Contains(convPubClassCaseSenate.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.ftpFileType = objvPubClassCaseSenateEN.ftpFileType == "[null]" ? null :  objvPubClassCaseSenateEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convPubClassCaseSenate.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.ftpFileSize = objvPubClassCaseSenateEN.ftpFileSize == "[null]" ? null :  objvPubClassCaseSenateEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convPubClassCaseSenate.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.FileOriginName = objvPubClassCaseSenateEN.FileOriginName == "[null]" ? null :  objvPubClassCaseSenateEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convPubClassCaseSenate.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdResource = objvPubClassCaseSenateEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convPubClassCaseSenate.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdDiscipline = objvPubClassCaseSenateEN.IdDiscipline == "[null]" ? null :  objvPubClassCaseSenateEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convPubClassCaseSenate.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdStudyLevel = objvPubClassCaseSenateEN.IdStudyLevel == "[null]" ? null :  objvPubClassCaseSenateEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convPubClassCaseSenate.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdFile = objvPubClassCaseSenateEN.IdFile == "[null]" ? null :  objvPubClassCaseSenateEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convPubClassCaseSenate.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IsVisible = objvPubClassCaseSenateEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convPubClassCaseSenate.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.SaveDate = objvPubClassCaseSenateEN.SaveDate == "[null]" ? null :  objvPubClassCaseSenateEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convPubClassCaseSenate.IdPubClassCaseSenateClass, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objvPubClassCaseSenateEN.IdPubClassCaseSenateClass; //公开课案例评议类别流水号
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
 /// <param name = "objvPubClassCaseSenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPubClassCaseSenateEN objvPubClassCaseSenateEN)
{
try
{
if (objvPubClassCaseSenateEN.PubClassCaseDateIn == "[null]") objvPubClassCaseSenateEN.PubClassCaseDateIn = null; //案例入库日期
if (objvPubClassCaseSenateEN.PubClassCaseTeachDate == "[null]") objvPubClassCaseSenateEN.PubClassCaseTeachDate = null; //案例授课日期
if (objvPubClassCaseSenateEN.PubClassCaseBG == "[null]") objvPubClassCaseSenateEN.PubClassCaseBG = null; //案例背景资料
if (objvPubClassCaseSenateEN.PubClassCaseTheme == "[null]") objvPubClassCaseSenateEN.PubClassCaseTheme = null; //案例主题词
if (objvPubClassCaseSenateEN.PubClassCaseExecutor == "[null]") objvPubClassCaseSenateEN.PubClassCaseExecutor = null; //案例执教者
if (objvPubClassCaseSenateEN.DisciplineID == "[null]") objvPubClassCaseSenateEN.DisciplineID = null; //学科ID
if (objvPubClassCaseSenateEN.DisciplineName == "[null]") objvPubClassCaseSenateEN.DisciplineName = null; //学科名称
if (objvPubClassCaseSenateEN.StudyLevelName == "[null]") objvPubClassCaseSenateEN.StudyLevelName = null; //学段名称
if (objvPubClassCaseSenateEN.PubClassCaseSenateClassID == "[null]") objvPubClassCaseSenateEN.PubClassCaseSenateClassID = null; //公开课案例评议类别ID
if (objvPubClassCaseSenateEN.PubClassCaseSenateClassName == "[null]") objvPubClassCaseSenateEN.PubClassCaseSenateClassName = null; //公开课案例评议类别名称
if (objvPubClassCaseSenateEN.PubClassCaseSenator == "[null]") objvPubClassCaseSenateEN.PubClassCaseSenator = null; //公开课案例评议者
if (objvPubClassCaseSenateEN.PubClassCaseSenateTitle == "[null]") objvPubClassCaseSenateEN.PubClassCaseSenateTitle = null; //公开课案例评议标题
if (objvPubClassCaseSenateEN.PubClassCaseSenateContent == "[null]") objvPubClassCaseSenateEN.PubClassCaseSenateContent = null; //公开课案例评议内容
if (objvPubClassCaseSenateEN.PubClassCaseSenateDate == "[null]") objvPubClassCaseSenateEN.PubClassCaseSenateDate = null; //公开课案例评议日期
if (objvPubClassCaseSenateEN.PubClassCaseSenateTime == "[null]") objvPubClassCaseSenateEN.PubClassCaseSenateTime = null; //公开课案例评议时间
if (objvPubClassCaseSenateEN.ftpResourceOwner == "[null]") objvPubClassCaseSenateEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvPubClassCaseSenateEN.FileNewName == "[null]") objvPubClassCaseSenateEN.FileNewName = null; //新文件名
if (objvPubClassCaseSenateEN.FileOldName == "[null]") objvPubClassCaseSenateEN.FileOldName = null; //旧文件名
if (objvPubClassCaseSenateEN.FileSize == "[null]") objvPubClassCaseSenateEN.FileSize = null; //文件大小
if (objvPubClassCaseSenateEN.FileType == "[null]") objvPubClassCaseSenateEN.FileType = null; //文件类型
if (objvPubClassCaseSenateEN.FileName == "[null]") objvPubClassCaseSenateEN.FileName = null; //文件名称
if (objvPubClassCaseSenateEN.SaveTime == "[null]") objvPubClassCaseSenateEN.SaveTime = null; //创建时间
if (objvPubClassCaseSenateEN.IdFtpResource == "[null]") objvPubClassCaseSenateEN.IdFtpResource = null; //FTP资源流水号
if (objvPubClassCaseSenateEN.FileUpDate == "[null]") objvPubClassCaseSenateEN.FileUpDate = null; //创建日期
if (objvPubClassCaseSenateEN.FileDirName == "[null]") objvPubClassCaseSenateEN.FileDirName = null; //文件目录名
if (objvPubClassCaseSenateEN.FileOriginalName == "[null]") objvPubClassCaseSenateEN.FileOriginalName = null; //文件原名
if (objvPubClassCaseSenateEN.FileRename == "[null]") objvPubClassCaseSenateEN.FileRename = null; //文件新名
if (objvPubClassCaseSenateEN.FileUpTime == "[null]") objvPubClassCaseSenateEN.FileUpTime = null; //创建时间
if (objvPubClassCaseSenateEN.ftpFileType == "[null]") objvPubClassCaseSenateEN.ftpFileType = null; //ftp文件类型
if (objvPubClassCaseSenateEN.ftpFileSize == "[null]") objvPubClassCaseSenateEN.ftpFileSize = null; //ftp文件大小
if (objvPubClassCaseSenateEN.FileOriginName == "[null]") objvPubClassCaseSenateEN.FileOriginName = null; //原文件名
if (objvPubClassCaseSenateEN.IdDiscipline == "[null]") objvPubClassCaseSenateEN.IdDiscipline = null; //学科流水号
if (objvPubClassCaseSenateEN.IdStudyLevel == "[null]") objvPubClassCaseSenateEN.IdStudyLevel = null; //id_StudyLevel
if (objvPubClassCaseSenateEN.IdFile == "[null]") objvPubClassCaseSenateEN.IdFile = null; //文件流水号
if (objvPubClassCaseSenateEN.SaveDate == "[null]") objvPubClassCaseSenateEN.SaveDate = null; //创建日期
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
public static void CheckProperty4Condition(clsvPubClassCaseSenateEN objvPubClassCaseSenateEN)
{
 vPubClassCaseSenateDA.CheckProperty4Condition(objvPubClassCaseSenateEN);
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
if (clsPubClassCaseSenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateBL没有刷新缓存机制(clsPubClassCaseSenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateClassBL没有刷新缓存机制(clsPubClassCaseSenateClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCaseSenate");
//if (arrvPubClassCaseSenateObjLstCache == null)
//{
//arrvPubClassCaseSenateObjLstCache = vPubClassCaseSenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseSenateEN GetObjByIdPubClassCaseSenateCache(long lngIdPubClassCaseSenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPubClassCaseSenateEN._CurrTabName);
List<clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLst_Sel =
arrvPubClassCaseSenateObjLstCache
.Where(x=> x.IdPubClassCaseSenate == lngIdPubClassCaseSenate 
);
if (arrvPubClassCaseSenateObjLst_Sel.Count() == 0)
{
   clsvPubClassCaseSenateEN obj = clsvPubClassCaseSenateBL.GetObjByIdPubClassCaseSenate(lngIdPubClassCaseSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPubClassCaseSenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseSenateEN> GetAllvPubClassCaseSenateObjLstCache()
{
//获取缓存中的对象列表
List<clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLstCache = GetObjLstCache(); 
return arrvPubClassCaseSenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseSenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCaseSenateEN._CurrTabName);
List<clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCaseSenateObjLstCache;
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
string strKey = string.Format("{0}", clsvPubClassCaseSenateEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdPubClassCaseSenate)
{
if (strInFldName != convPubClassCaseSenate.IdPubClassCaseSenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPubClassCaseSenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPubClassCaseSenate.AttributeName));
throw new Exception(strMsg);
}
var objvPubClassCaseSenate = clsvPubClassCaseSenateBL.GetObjByIdPubClassCaseSenateCache(lngIdPubClassCaseSenate);
if (objvPubClassCaseSenate == null) return "";
return objvPubClassCaseSenate[strOutFldName].ToString();
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
int intRecCount = clsvPubClassCaseSenateDA.GetRecCount(strTabName);
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
int intRecCount = clsvPubClassCaseSenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPubClassCaseSenateDA.GetRecCount();
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
int intRecCount = clsvPubClassCaseSenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPubClassCaseSenateEN objvPubClassCaseSenateCond)
{
List<clsvPubClassCaseSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCaseSenate.AttributeName)
{
if (objvPubClassCaseSenateCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCaseSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseSenateCond[strFldName].ToString());
}
else
{
if (objvPubClassCaseSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCaseSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCaseSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseSenateCond[strFldName]));
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
 List<string> arrList = clsvPubClassCaseSenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPubClassCaseSenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPubClassCaseSenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}