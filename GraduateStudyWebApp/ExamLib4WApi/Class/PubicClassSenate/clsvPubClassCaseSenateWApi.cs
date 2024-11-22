
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseSenateWApi
 表名:vPubClassCaseSenate(01120410)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:21
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
public static class clsvPubClassCaseSenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_PubClassCaseSenate(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, long lngid_PubClassCaseSenate, string strComparisonOp="")
	{
objvPubClassCaseSenateEN.id_PubClassCaseSenate = lngid_PubClassCaseSenate; //公开课案例评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_PubClassCaseSenate) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_PubClassCaseSenate, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_PubClassCaseSenate] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_PubClassCase(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCase, convPubClassCaseSenate.id_PubClassCase);
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, convPubClassCaseSenate.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, convPubClassCaseSenate.id_PubClassCase);
objvPubClassCaseSenateEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_PubClassCase) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_PubClassCase, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_PubClassCase] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, convPubClassCaseSenate.PubClassCaseID);
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubClassCaseSenate.PubClassCaseID);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubClassCaseSenate.PubClassCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPubClassCaseSenate.PubClassCaseName);
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubClassCaseSenate.PubClassCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseDateIn(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, convPubClassCaseSenate.PubClassCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, convPubClassCaseSenate.PubClassCaseDateIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseTeachDate(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPubClassCaseSenate.PubClassCaseTeachDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPubClassCaseSenate.PubClassCaseTeachDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseTheme(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, convPubClassCaseSenate.PubClassCaseTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseExecutor(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubClassCaseSenate.PubClassCaseExecutor);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetDisciplineID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convPubClassCaseSenate.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convPubClassCaseSenate.DisciplineID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetDisciplineName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPubClassCaseSenate.DisciplineName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetStudyLevelName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPubClassCaseSenate.StudyLevelName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetSubjectName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubjectName, convPubClassCaseSenate.SubjectName);
clsCheckSql.CheckFieldLen(strSubjectName, 200, convPubClassCaseSenate.SubjectName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetResourceID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convPubClassCaseSenate.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convPubClassCaseSenate.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convPubClassCaseSenate.ResourceID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetResourceTypeID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convPubClassCaseSenate.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convPubClassCaseSenate.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convPubClassCaseSenate.ResourceTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetResourceTypeName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convPubClassCaseSenate.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convPubClassCaseSenate.ResourceTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubCaseTypeID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeID, convPubClassCaseSenate.PubCaseTypeID);
clsCheckSql.CheckFieldLen(strPubCaseTypeID, 4, convPubClassCaseSenate.PubCaseTypeID);
clsCheckSql.CheckFieldForeignKey(strPubCaseTypeID, 4, convPubClassCaseSenate.PubCaseTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubCaseTypeName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeName, convPubClassCaseSenate.PubCaseTypeName);
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubClassCaseSenate.PubCaseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateClassID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateClassID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateClassID, 4, convPubClassCaseSenate.PubClassCaseSenateClassID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateClassName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateClassName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateClassName, 50, convPubClassCaseSenate.PubClassCaseSenateClassName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenator(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenator, 50, convPubClassCaseSenate.PubClassCaseSenator);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateTitle(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateTitle, 200, convPubClassCaseSenate.PubClassCaseSenateTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateContent(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateContent, 8000, convPubClassCaseSenate.PubClassCaseSenateContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateDate(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateDate, 8, convPubClassCaseSenate.PubClassCaseSenateDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseSenateDate, 8, convPubClassCaseSenate.PubClassCaseSenateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetPubClassCaseSenateTime(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strPubClassCaseSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateTime, 6, convPubClassCaseSenate.PubClassCaseSenateTime);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseSenateTime, 6, convPubClassCaseSenate.PubClassCaseSenateTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetSenateReadCount(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, int intSenateReadCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetResourceOwner(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convPubClassCaseSenate.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convPubClassCaseSenate.ResourceOwner);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetftpResourceOwner(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convPubClassCaseSenate.ftpResourceOwner);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileNewName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convPubClassCaseSenate.FileNewName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileOldName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convPubClassCaseSenate.FileOldName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileSize(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convPubClassCaseSenate.FileSize);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileType(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convPubClassCaseSenate.FileType);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convPubClassCaseSenate.FileName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetSaveTime(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convPubClassCaseSenate.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convPubClassCaseSenate.SaveTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_TeachingPlan(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convPubClassCaseSenate.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convPubClassCaseSenate.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convPubClassCaseSenate.id_TeachingPlan);
objvPubClassCaseSenateEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_TeachingPlan) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_TeachingPlan, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_TeachingPlan] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_FtpResource(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convPubClassCaseSenate.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convPubClassCaseSenate.id_FtpResource);
objvPubClassCaseSenateEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_FtpResource) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_FtpResource, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_FtpResource] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileUpDate(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convPubClassCaseSenate.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convPubClassCaseSenate.FileUpDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileDirName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convPubClassCaseSenate.FileDirName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileOriginalName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convPubClassCaseSenate.FileOriginalName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFtpResourceID(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convPubClassCaseSenate.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convPubClassCaseSenate.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convPubClassCaseSenate.FtpResourceID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileRename(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convPubClassCaseSenate.FileRename);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileUpTime(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convPubClassCaseSenate.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convPubClassCaseSenate.FileUpTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_ResourceType(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convPubClassCaseSenate.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convPubClassCaseSenate.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convPubClassCaseSenate.id_ResourceType);
objvPubClassCaseSenateEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_ResourceType) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_ResourceType, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_ResourceType] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_PubCaseType(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strid_PubCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubCaseType, convPubClassCaseSenate.id_PubCaseType);
clsCheckSql.CheckFieldLen(strid_PubCaseType, 4, convPubClassCaseSenate.id_PubCaseType);
clsCheckSql.CheckFieldForeignKey(strid_PubCaseType, 4, convPubClassCaseSenate.id_PubCaseType);
objvPubClassCaseSenateEN.id_PubCaseType = strid_PubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_PubCaseType) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_PubCaseType, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_PubCaseType] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetftpFileType(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convPubClassCaseSenate.ftpFileType);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetftpFileSize(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convPubClassCaseSenate.ftpFileSize);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetFileOriginName(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convPubClassCaseSenate.FileOriginName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_Resource(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convPubClassCaseSenate.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convPubClassCaseSenate.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convPubClassCaseSenate.id_Resource);
objvPubClassCaseSenateEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_Resource) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_Resource, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_Resource] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_Discipline(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convPubClassCaseSenate.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convPubClassCaseSenate.id_Discipline);
objvPubClassCaseSenateEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_Discipline) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_Discipline, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_Discipline] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_StudyLevel(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convPubClassCaseSenate.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convPubClassCaseSenate.id_StudyLevel);
objvPubClassCaseSenateEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_StudyLevel) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_StudyLevel, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_StudyLevel] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_File(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convPubClassCaseSenate.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convPubClassCaseSenate.id_File);
objvPubClassCaseSenateEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_File) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_File, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_File] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN SetSaveDate(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convPubClassCaseSenate.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convPubClassCaseSenate.SaveDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateEN Setid_PubClassCaseSenateClass(this clsvPubClassCaseSenateEN objvPubClassCaseSenateEN, string strid_PubClassCaseSenateClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCaseSenateClass, convPubClassCaseSenate.id_PubClassCaseSenateClass);
clsCheckSql.CheckFieldLen(strid_PubClassCaseSenateClass, 4, convPubClassCaseSenate.id_PubClassCaseSenateClass);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCaseSenateClass, 4, convPubClassCaseSenate.id_PubClassCaseSenateClass);
objvPubClassCaseSenateEN.id_PubClassCaseSenateClass = strid_PubClassCaseSenateClass; //公开课案例评议类别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenate.id_PubClassCaseSenateClass) == false)
{
objvPubClassCaseSenateEN.dicFldComparisonOp.Add(convPubClassCaseSenate.id_PubClassCaseSenateClass, strComparisonOp);
}
else
{
objvPubClassCaseSenateEN.dicFldComparisonOp[convPubClassCaseSenate.id_PubClassCaseSenateClass] = strComparisonOp;
}
}
return objvPubClassCaseSenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCaseSenateEN objvPubClassCaseSenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_PubClassCaseSenate) == true)
{
string strComparisonOp_id_PubClassCaseSenate = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_PubClassCaseSenate];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseSenate.id_PubClassCaseSenate, objvPubClassCaseSenate_Cond.id_PubClassCaseSenate, strComparisonOp_id_PubClassCaseSenate);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.id_PubClassCase, objvPubClassCaseSenate_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseID) == true)
{
string strComparisonOp_PubClassCaseID = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseID, objvPubClassCaseSenate_Cond.PubClassCaseID, strComparisonOp_PubClassCaseID);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseName) == true)
{
string strComparisonOp_PubClassCaseName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseName, objvPubClassCaseSenate_Cond.PubClassCaseName, strComparisonOp_PubClassCaseName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseDateIn) == true)
{
string strComparisonOp_PubClassCaseDateIn = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseDateIn, objvPubClassCaseSenate_Cond.PubClassCaseDateIn, strComparisonOp_PubClassCaseDateIn);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseTeachDate) == true)
{
string strComparisonOp_PubClassCaseTeachDate = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseTeachDate, objvPubClassCaseSenate_Cond.PubClassCaseTeachDate, strComparisonOp_PubClassCaseTeachDate);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseTheme) == true)
{
string strComparisonOp_PubClassCaseTheme = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseTheme, objvPubClassCaseSenate_Cond.PubClassCaseTheme, strComparisonOp_PubClassCaseTheme);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseExecutor) == true)
{
string strComparisonOp_PubClassCaseExecutor = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseExecutor, objvPubClassCaseSenate_Cond.PubClassCaseExecutor, strComparisonOp_PubClassCaseExecutor);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.DisciplineID, objvPubClassCaseSenate_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.DisciplineName, objvPubClassCaseSenate_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.StudyLevelName, objvPubClassCaseSenate_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.IsElite) == true)
{
if (objvPubClassCaseSenate_Cond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseSenate.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseSenate.IsElite);
}
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.SubjectName) == true)
{
string strComparisonOp_SubjectName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.SubjectName, objvPubClassCaseSenate_Cond.SubjectName, strComparisonOp_SubjectName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ResourceID, objvPubClassCaseSenate_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ResourceTypeID, objvPubClassCaseSenate_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ResourceTypeName, objvPubClassCaseSenate_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubCaseTypeID) == true)
{
string strComparisonOp_PubCaseTypeID = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubCaseTypeID, objvPubClassCaseSenate_Cond.PubCaseTypeID, strComparisonOp_PubCaseTypeID);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubCaseTypeName) == true)
{
string strComparisonOp_PubCaseTypeName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubCaseTypeName, objvPubClassCaseSenate_Cond.PubCaseTypeName, strComparisonOp_PubCaseTypeName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateClassID) == true)
{
string strComparisonOp_PubClassCaseSenateClassID = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateClassID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateClassID, objvPubClassCaseSenate_Cond.PubClassCaseSenateClassID, strComparisonOp_PubClassCaseSenateClassID);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateClassName) == true)
{
string strComparisonOp_PubClassCaseSenateClassName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateClassName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateClassName, objvPubClassCaseSenate_Cond.PubClassCaseSenateClassName, strComparisonOp_PubClassCaseSenateClassName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenator) == true)
{
string strComparisonOp_PubClassCaseSenator = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenator];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenator, objvPubClassCaseSenate_Cond.PubClassCaseSenator, strComparisonOp_PubClassCaseSenator);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateTitle) == true)
{
string strComparisonOp_PubClassCaseSenateTitle = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateTitle, objvPubClassCaseSenate_Cond.PubClassCaseSenateTitle, strComparisonOp_PubClassCaseSenateTitle);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateContent) == true)
{
string strComparisonOp_PubClassCaseSenateContent = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateContent, objvPubClassCaseSenate_Cond.PubClassCaseSenateContent, strComparisonOp_PubClassCaseSenateContent);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateDate) == true)
{
string strComparisonOp_PubClassCaseSenateDate = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateDate, objvPubClassCaseSenate_Cond.PubClassCaseSenateDate, strComparisonOp_PubClassCaseSenateDate);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.PubClassCaseSenateTime) == true)
{
string strComparisonOp_PubClassCaseSenateTime = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.PubClassCaseSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.PubClassCaseSenateTime, objvPubClassCaseSenate_Cond.PubClassCaseSenateTime, strComparisonOp_PubClassCaseSenateTime);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.SenateReadCount) == true)
{
string strComparisonOp_SenateReadCount = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.SenateReadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseSenate.SenateReadCount, objvPubClassCaseSenate_Cond.SenateReadCount, strComparisonOp_SenateReadCount);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ResourceOwner, objvPubClassCaseSenate_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ftpResourceOwner, objvPubClassCaseSenate_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileNewName, objvPubClassCaseSenate_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileOldName, objvPubClassCaseSenate_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileSize) == true)
{
string strComparisonOp_FileSize = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileSize, objvPubClassCaseSenate_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileType) == true)
{
string strComparisonOp_FileType = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileType, objvPubClassCaseSenate_Cond.FileType, strComparisonOp_FileType);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileName) == true)
{
string strComparisonOp_FileName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileName, objvPubClassCaseSenate_Cond.FileName, strComparisonOp_FileName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.SaveTime, objvPubClassCaseSenate_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.IsVisual) == true)
{
if (objvPubClassCaseSenate_Cond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseSenate.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseSenate.IsVisual);
}
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.id_TeachingPlan, objvPubClassCaseSenate_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.id_FtpResource, objvPubClassCaseSenate_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileUpDate, objvPubClassCaseSenate_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileDirName, objvPubClassCaseSenate_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileOriginalName, objvPubClassCaseSenate_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FtpResourceID, objvPubClassCaseSenate_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileRename) == true)
{
string strComparisonOp_FileRename = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileRename, objvPubClassCaseSenate_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileUpTime, objvPubClassCaseSenate_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.SaveMode) == true)
{
if (objvPubClassCaseSenate_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseSenate.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseSenate.SaveMode);
}
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.id_ResourceType, objvPubClassCaseSenate_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_PubCaseType) == true)
{
string strComparisonOp_id_PubCaseType = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_PubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.id_PubCaseType, objvPubClassCaseSenate_Cond.id_PubCaseType, strComparisonOp_id_PubCaseType);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ftpFileType, objvPubClassCaseSenate_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.ftpFileSize, objvPubClassCaseSenate_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.FileOriginName, objvPubClassCaseSenate_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.id_Resource, objvPubClassCaseSenate_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.id_Discipline, objvPubClassCaseSenate_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.id_StudyLevel, objvPubClassCaseSenate_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_File) == true)
{
string strComparisonOp_id_File = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.id_File, objvPubClassCaseSenate_Cond.id_File, strComparisonOp_id_File);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.IsVisible) == true)
{
if (objvPubClassCaseSenate_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseSenate.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseSenate.IsVisible);
}
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.SaveDate, objvPubClassCaseSenate_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvPubClassCaseSenate_Cond.IsUpdated(convPubClassCaseSenate.id_PubClassCaseSenateClass) == true)
{
string strComparisonOp_id_PubClassCaseSenateClass = objvPubClassCaseSenate_Cond.dicFldComparisonOp[convPubClassCaseSenate.id_PubClassCaseSenateClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenate.id_PubClassCaseSenateClass, objvPubClassCaseSenate_Cond.id_PubClassCaseSenateClass, strComparisonOp_id_PubClassCaseSenateClass);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v公开课案例评议(vPubClassCaseSenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCaseSenateWApi
{
private static readonly string mstrApiControllerName = "vPubClassCaseSenateApi";

 public clsvPubClassCaseSenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_PubClassCaseSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseSenateEN GetObjByid_PubClassCaseSenate(long lngid_PubClassCaseSenate)
{
string strAction = "GetObjByid_PubClassCaseSenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseSenate"] = lngid_PubClassCaseSenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubClassCaseSenateEN = JsonConvert.DeserializeObject<clsvPubClassCaseSenateEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseSenateEN;
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
 /// <param name = "lngid_PubClassCaseSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseSenateEN GetObjByid_PubClassCaseSenate_WA_Cache(long lngid_PubClassCaseSenate)
{
string strAction = "GetObjByid_PubClassCaseSenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseSenate"] = lngid_PubClassCaseSenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubClassCaseSenateEN = JsonConvert.DeserializeObject<clsvPubClassCaseSenateEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseSenateEN;
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
public static clsvPubClassCaseSenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = null;
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
objvPubClassCaseSenateEN = JsonConvert.DeserializeObject<clsvPubClassCaseSenateEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseSenateEN;
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
 /// <param name = "lngid_PubClassCaseSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseSenateEN GetObjByid_PubClassCaseSenate_Cache(long lngid_PubClassCaseSenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseSenateEN._CurrTabName_S);
List<clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLst_Sel =
from objvPubClassCaseSenateEN in arrvPubClassCaseSenateObjLst_Cache
where objvPubClassCaseSenateEN.id_PubClassCaseSenate == lngid_PubClassCaseSenate
select objvPubClassCaseSenateEN;
if (arrvPubClassCaseSenateObjLst_Sel.Count() == 0)
{
   clsvPubClassCaseSenateEN obj = clsvPubClassCaseSenateWApi.GetObjByid_PubClassCaseSenate(lngid_PubClassCaseSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPubClassCaseSenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseSenateEN> GetObjLst(string strWhereCond)
{
 List<clsvPubClassCaseSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseSenateEN> GetObjLstById_PubClassCaseSenateLst(List<long> arrId_PubClassCaseSenate)
{
 List<clsvPubClassCaseSenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseSenateLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCaseSenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_PubClassCaseSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPubClassCaseSenateEN> GetObjLstById_PubClassCaseSenateLst_Cache(List<long> arrId_PubClassCaseSenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseSenateEN._CurrTabName_S);
List<clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLst_Sel =
from objvPubClassCaseSenateEN in arrvPubClassCaseSenateObjLst_Cache
where arrId_PubClassCaseSenate.Contains(objvPubClassCaseSenateEN.id_PubClassCaseSenate)
select objvPubClassCaseSenateEN;
return arrvPubClassCaseSenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseSenateEN> GetObjLstById_PubClassCaseSenateLst_WA_Cache(List<long> arrId_PubClassCaseSenate)
{
 List<clsvPubClassCaseSenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseSenateLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCaseSenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseSenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPubClassCaseSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseSenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPubClassCaseSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPubClassCaseSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseSenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPubClassCaseSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_PubClassCaseSenate)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseSenate"] = lngid_PubClassCaseSenate.ToString()
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
 /// <param name = "objvPubClassCaseSenateENS">源对象</param>
 /// <param name = "objvPubClassCaseSenateENT">目标对象</param>
 public static void CopyTo(clsvPubClassCaseSenateEN objvPubClassCaseSenateENS, clsvPubClassCaseSenateEN objvPubClassCaseSenateENT)
{
try
{
objvPubClassCaseSenateENT.id_PubClassCaseSenate = objvPubClassCaseSenateENS.id_PubClassCaseSenate; //公开课案例评议流水号
objvPubClassCaseSenateENT.id_PubClassCase = objvPubClassCaseSenateENS.id_PubClassCase; //案例流水号
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
objvPubClassCaseSenateENT.id_TeachingPlan = objvPubClassCaseSenateENS.id_TeachingPlan; //教案流水号
objvPubClassCaseSenateENT.id_FtpResource = objvPubClassCaseSenateENS.id_FtpResource; //FTP资源流水号
objvPubClassCaseSenateENT.FileUpDate = objvPubClassCaseSenateENS.FileUpDate; //创建日期
objvPubClassCaseSenateENT.FileDirName = objvPubClassCaseSenateENS.FileDirName; //文件目录名
objvPubClassCaseSenateENT.FileOriginalName = objvPubClassCaseSenateENS.FileOriginalName; //文件原名
objvPubClassCaseSenateENT.FtpResourceID = objvPubClassCaseSenateENS.FtpResourceID; //FTP资源ID
objvPubClassCaseSenateENT.FileRename = objvPubClassCaseSenateENS.FileRename; //文件新名
objvPubClassCaseSenateENT.FileUpTime = objvPubClassCaseSenateENS.FileUpTime; //创建时间
objvPubClassCaseSenateENT.SaveMode = objvPubClassCaseSenateENS.SaveMode; //文件存放方式
objvPubClassCaseSenateENT.id_ResourceType = objvPubClassCaseSenateENS.id_ResourceType; //资源类型流水号
objvPubClassCaseSenateENT.id_PubCaseType = objvPubClassCaseSenateENS.id_PubCaseType; //公开课案例类型流水号
objvPubClassCaseSenateENT.ftpFileType = objvPubClassCaseSenateENS.ftpFileType; //ftp文件类型
objvPubClassCaseSenateENT.ftpFileSize = objvPubClassCaseSenateENS.ftpFileSize; //ftp文件大小
objvPubClassCaseSenateENT.FileOriginName = objvPubClassCaseSenateENS.FileOriginName; //原文件名
objvPubClassCaseSenateENT.id_Resource = objvPubClassCaseSenateENS.id_Resource; //资源流水号
objvPubClassCaseSenateENT.id_Discipline = objvPubClassCaseSenateENS.id_Discipline; //学科流水号
objvPubClassCaseSenateENT.id_StudyLevel = objvPubClassCaseSenateENS.id_StudyLevel; //id_StudyLevel
objvPubClassCaseSenateENT.id_File = objvPubClassCaseSenateENS.id_File; //文件流水号
objvPubClassCaseSenateENT.IsVisible = objvPubClassCaseSenateENS.IsVisible; //是否显示
objvPubClassCaseSenateENT.SaveDate = objvPubClassCaseSenateENS.SaveDate; //创建日期
objvPubClassCaseSenateENT.id_PubClassCaseSenateClass = objvPubClassCaseSenateENS.id_PubClassCaseSenateClass; //公开课案例评议类别流水号
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
public static DataTable ToDataTable(List<clsvPubClassCaseSenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPubClassCaseSenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPubClassCaseSenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPubClassCaseSenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPubClassCaseSenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPubClassCaseSenateEN.AttributeName)
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
if (clsPubClassCaseSenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateWApi没有刷新缓存机制(clsPubClassCaseSenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateClassWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateClassWApi没有刷新缓存机制(clsPubClassCaseSenateClassWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_PubClassCaseSenate");
//if (arrvPubClassCaseSenateObjLst_Cache == null)
//{
//arrvPubClassCaseSenateObjLst_Cache = await clsvPubClassCaseSenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPubClassCaseSenateEN._CurrTabName_S);
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
public static List<clsvPubClassCaseSenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCaseSenateEN._CurrTabName_S);
List<clsvPubClassCaseSenateEN> arrvPubClassCaseSenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCaseSenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPubClassCaseSenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPubClassCaseSenate.id_PubClassCaseSenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convPubClassCaseSenate.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseTeachDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseBG, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.IsElite, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCaseSenate.SubjectName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubCaseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseSenateClassID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseSenateClassName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseSenator, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseSenateTitle, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseSenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseSenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.PubClassCaseSenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.SenateReadCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPubClassCaseSenate.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.IsVisual, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCaseSenate.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCaseSenate.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.id_PubCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCaseSenate.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenate.id_PubClassCaseSenateClass, Type.GetType("System.String"));
foreach (clsvPubClassCaseSenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPubClassCaseSenate.id_PubClassCaseSenate] = objInFor[convPubClassCaseSenate.id_PubClassCaseSenate];
objDR[convPubClassCaseSenate.id_PubClassCase] = objInFor[convPubClassCaseSenate.id_PubClassCase];
objDR[convPubClassCaseSenate.PubClassCaseID] = objInFor[convPubClassCaseSenate.PubClassCaseID];
objDR[convPubClassCaseSenate.PubClassCaseName] = objInFor[convPubClassCaseSenate.PubClassCaseName];
objDR[convPubClassCaseSenate.PubClassCaseDateIn] = objInFor[convPubClassCaseSenate.PubClassCaseDateIn];
objDR[convPubClassCaseSenate.PubClassCaseTeachDate] = objInFor[convPubClassCaseSenate.PubClassCaseTeachDate];
objDR[convPubClassCaseSenate.PubClassCaseBG] = objInFor[convPubClassCaseSenate.PubClassCaseBG];
objDR[convPubClassCaseSenate.PubClassCaseTheme] = objInFor[convPubClassCaseSenate.PubClassCaseTheme];
objDR[convPubClassCaseSenate.PubClassCaseExecutor] = objInFor[convPubClassCaseSenate.PubClassCaseExecutor];
objDR[convPubClassCaseSenate.DisciplineID] = objInFor[convPubClassCaseSenate.DisciplineID];
objDR[convPubClassCaseSenate.DisciplineName] = objInFor[convPubClassCaseSenate.DisciplineName];
objDR[convPubClassCaseSenate.StudyLevelName] = objInFor[convPubClassCaseSenate.StudyLevelName];
objDR[convPubClassCaseSenate.IsElite] = objInFor[convPubClassCaseSenate.IsElite];
objDR[convPubClassCaseSenate.SubjectName] = objInFor[convPubClassCaseSenate.SubjectName];
objDR[convPubClassCaseSenate.ResourceID] = objInFor[convPubClassCaseSenate.ResourceID];
objDR[convPubClassCaseSenate.ResourceTypeID] = objInFor[convPubClassCaseSenate.ResourceTypeID];
objDR[convPubClassCaseSenate.ResourceTypeName] = objInFor[convPubClassCaseSenate.ResourceTypeName];
objDR[convPubClassCaseSenate.PubCaseTypeID] = objInFor[convPubClassCaseSenate.PubCaseTypeID];
objDR[convPubClassCaseSenate.PubCaseTypeName] = objInFor[convPubClassCaseSenate.PubCaseTypeName];
objDR[convPubClassCaseSenate.PubClassCaseSenateClassID] = objInFor[convPubClassCaseSenate.PubClassCaseSenateClassID];
objDR[convPubClassCaseSenate.PubClassCaseSenateClassName] = objInFor[convPubClassCaseSenate.PubClassCaseSenateClassName];
objDR[convPubClassCaseSenate.PubClassCaseSenator] = objInFor[convPubClassCaseSenate.PubClassCaseSenator];
objDR[convPubClassCaseSenate.PubClassCaseSenateTitle] = objInFor[convPubClassCaseSenate.PubClassCaseSenateTitle];
objDR[convPubClassCaseSenate.PubClassCaseSenateContent] = objInFor[convPubClassCaseSenate.PubClassCaseSenateContent];
objDR[convPubClassCaseSenate.PubClassCaseSenateDate] = objInFor[convPubClassCaseSenate.PubClassCaseSenateDate];
objDR[convPubClassCaseSenate.PubClassCaseSenateTime] = objInFor[convPubClassCaseSenate.PubClassCaseSenateTime];
objDR[convPubClassCaseSenate.SenateReadCount] = objInFor[convPubClassCaseSenate.SenateReadCount];
objDR[convPubClassCaseSenate.ResourceOwner] = objInFor[convPubClassCaseSenate.ResourceOwner];
objDR[convPubClassCaseSenate.ftpResourceOwner] = objInFor[convPubClassCaseSenate.ftpResourceOwner];
objDR[convPubClassCaseSenate.FileNewName] = objInFor[convPubClassCaseSenate.FileNewName];
objDR[convPubClassCaseSenate.FileOldName] = objInFor[convPubClassCaseSenate.FileOldName];
objDR[convPubClassCaseSenate.FileSize] = objInFor[convPubClassCaseSenate.FileSize];
objDR[convPubClassCaseSenate.FileType] = objInFor[convPubClassCaseSenate.FileType];
objDR[convPubClassCaseSenate.FileName] = objInFor[convPubClassCaseSenate.FileName];
objDR[convPubClassCaseSenate.SaveTime] = objInFor[convPubClassCaseSenate.SaveTime];
objDR[convPubClassCaseSenate.IsVisual] = objInFor[convPubClassCaseSenate.IsVisual];
objDR[convPubClassCaseSenate.id_TeachingPlan] = objInFor[convPubClassCaseSenate.id_TeachingPlan];
objDR[convPubClassCaseSenate.id_FtpResource] = objInFor[convPubClassCaseSenate.id_FtpResource];
objDR[convPubClassCaseSenate.FileUpDate] = objInFor[convPubClassCaseSenate.FileUpDate];
objDR[convPubClassCaseSenate.FileDirName] = objInFor[convPubClassCaseSenate.FileDirName];
objDR[convPubClassCaseSenate.FileOriginalName] = objInFor[convPubClassCaseSenate.FileOriginalName];
objDR[convPubClassCaseSenate.FtpResourceID] = objInFor[convPubClassCaseSenate.FtpResourceID];
objDR[convPubClassCaseSenate.FileRename] = objInFor[convPubClassCaseSenate.FileRename];
objDR[convPubClassCaseSenate.FileUpTime] = objInFor[convPubClassCaseSenate.FileUpTime];
objDR[convPubClassCaseSenate.SaveMode] = objInFor[convPubClassCaseSenate.SaveMode];
objDR[convPubClassCaseSenate.id_ResourceType] = objInFor[convPubClassCaseSenate.id_ResourceType];
objDR[convPubClassCaseSenate.id_PubCaseType] = objInFor[convPubClassCaseSenate.id_PubCaseType];
objDR[convPubClassCaseSenate.ftpFileType] = objInFor[convPubClassCaseSenate.ftpFileType];
objDR[convPubClassCaseSenate.ftpFileSize] = objInFor[convPubClassCaseSenate.ftpFileSize];
objDR[convPubClassCaseSenate.FileOriginName] = objInFor[convPubClassCaseSenate.FileOriginName];
objDR[convPubClassCaseSenate.id_Resource] = objInFor[convPubClassCaseSenate.id_Resource];
objDR[convPubClassCaseSenate.id_Discipline] = objInFor[convPubClassCaseSenate.id_Discipline];
objDR[convPubClassCaseSenate.id_StudyLevel] = objInFor[convPubClassCaseSenate.id_StudyLevel];
objDR[convPubClassCaseSenate.id_File] = objInFor[convPubClassCaseSenate.id_File];
objDR[convPubClassCaseSenate.IsVisible] = objInFor[convPubClassCaseSenate.IsVisible];
objDR[convPubClassCaseSenate.SaveDate] = objInFor[convPubClassCaseSenate.SaveDate];
objDR[convPubClassCaseSenate.id_PubClassCaseSenateClass] = objInFor[convPubClassCaseSenate.id_PubClassCaseSenateClass];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}