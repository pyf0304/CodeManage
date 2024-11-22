
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsYoungTAppraisedCaseWApi
 表名:YoungTAppraisedCase(01120463)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:58
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优
 模块英文名:YoungTeachersAppraised
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
public static class clsYoungTAppraisedCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN Setid_YoungTAppraisedCase(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strid_YoungTAppraisedCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_YoungTAppraisedCase, 8, conYoungTAppraisedCase.id_YoungTAppraisedCase);
clsCheckSql.CheckFieldForeignKey(strid_YoungTAppraisedCase, 8, conYoungTAppraisedCase.id_YoungTAppraisedCase);
objYoungTAppraisedCaseEN.id_YoungTAppraisedCase = strid_YoungTAppraisedCase; //青教评优案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.id_YoungTAppraisedCase) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.id_YoungTAppraisedCase, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.id_YoungTAppraisedCase] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetYoungTAppraisedCaseID(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strYoungTAppraisedCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseID, conYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseID, 8, conYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseID, 8, conYoungTAppraisedCase.YoungTAppraisedCaseID);
objYoungTAppraisedCaseEN.YoungTAppraisedCaseID = strYoungTAppraisedCaseID; //青教评优案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.YoungTAppraisedCaseID) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.YoungTAppraisedCaseID, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseID] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetYoungTAppraisedCaseName(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strYoungTAppraisedCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseName, conYoungTAppraisedCase.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseName, 100, conYoungTAppraisedCase.YoungTAppraisedCaseName);
objYoungTAppraisedCaseEN.YoungTAppraisedCaseName = strYoungTAppraisedCaseName; //青教评优案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.YoungTAppraisedCaseName) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.YoungTAppraisedCaseName, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseName] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetYoungTAppraisedCaseText(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strYoungTAppraisedCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseText, 8000, conYoungTAppraisedCase.YoungTAppraisedCaseText);
objYoungTAppraisedCaseEN.YoungTAppraisedCaseText = strYoungTAppraisedCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.YoungTAppraisedCaseText) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.YoungTAppraisedCaseText, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseText] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetYoungTAppraisedCaseDate(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strYoungTAppraisedCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseDate, 8, conYoungTAppraisedCase.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseDate, 8, conYoungTAppraisedCase.YoungTAppraisedCaseDate);
objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = strYoungTAppraisedCaseDate; //青教评优教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.YoungTAppraisedCaseDate) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDate, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseDate] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetYoungTAppraisedCaseTime(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strYoungTAppraisedCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTime, 6, conYoungTAppraisedCase.YoungTAppraisedCaseTime);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseTime, 6, conYoungTAppraisedCase.YoungTAppraisedCaseTime);
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = strYoungTAppraisedCaseTime; //青教评优教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.YoungTAppraisedCaseTime) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTime, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseTime] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetYoungTAppraisedCaseTheme(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strYoungTAppraisedCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTheme, 200, conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = strYoungTAppraisedCaseTheme; //青教评优案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.YoungTAppraisedCaseTheme) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTheme, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetYoungTAppraisedCaseDateIn(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strYoungTAppraisedCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseDateIn, 8, conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseDateIn, 8, conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = strYoungTAppraisedCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetYoungTAppraisedCaseTimeIn(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strYoungTAppraisedCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTimeIn, 6, conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseTimeIn, 6, conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = strYoungTAppraisedCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN Setid_StudyLevel(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, conYoungTAppraisedCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conYoungTAppraisedCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conYoungTAppraisedCase.id_StudyLevel);
objYoungTAppraisedCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.id_StudyLevel) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.id_StudyLevel, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.id_StudyLevel] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN Setid_TeachingPlan(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conYoungTAppraisedCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conYoungTAppraisedCase.id_TeachingPlan);
objYoungTAppraisedCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.id_TeachingPlan) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.id_TeachingPlan, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.id_TeachingPlan] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetId_CaseType(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, conYoungTAppraisedCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, conYoungTAppraisedCase.Id_CaseType);
objYoungTAppraisedCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.Id_CaseType) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.Id_CaseType, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.Id_CaseType] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN Setid_Discipline(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, conYoungTAppraisedCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conYoungTAppraisedCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conYoungTAppraisedCase.id_Discipline);
objYoungTAppraisedCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.id_Discipline) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.id_Discipline, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.id_Discipline] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetBrowseCount(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objYoungTAppraisedCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.BrowseCount) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.BrowseCount, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.BrowseCount] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN Setid_SenateGaugeVersion(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conYoungTAppraisedCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conYoungTAppraisedCase.id_SenateGaugeVersion);
objYoungTAppraisedCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.id_SenateGaugeVersion) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN Setid_TeachSkill(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, conYoungTAppraisedCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conYoungTAppraisedCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conYoungTAppraisedCase.id_TeachSkill);
objYoungTAppraisedCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.id_TeachSkill) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.id_TeachSkill, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.id_TeachSkill] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetCaseLevelId(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conYoungTAppraisedCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conYoungTAppraisedCase.CaseLevelId);
objYoungTAppraisedCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.CaseLevelId) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.CaseLevelId, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.CaseLevelId] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetDocFile(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conYoungTAppraisedCase.DocFile);
objYoungTAppraisedCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.DocFile) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.DocFile, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.DocFile] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetIsNeedGeneWord(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objYoungTAppraisedCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.IsNeedGeneWord) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetWordCreateDate(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conYoungTAppraisedCase.WordCreateDate);
objYoungTAppraisedCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.WordCreateDate) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.WordCreateDate, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.WordCreateDate] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetIsVisible(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objYoungTAppraisedCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.IsVisible) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.IsVisible, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.IsVisible] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetOwnerId(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conYoungTAppraisedCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conYoungTAppraisedCase.OwnerId);
objYoungTAppraisedCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.OwnerId) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.OwnerId, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.OwnerId] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetIsDualVideo(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, conYoungTAppraisedCase.IsDualVideo);
objYoungTAppraisedCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.IsDualVideo) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.IsDualVideo, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.IsDualVideo] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN Setid_YoungTAppraisedCaseType(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strid_YoungTAppraisedCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_YoungTAppraisedCaseType, 4, conYoungTAppraisedCase.id_YoungTAppraisedCaseType);
clsCheckSql.CheckFieldForeignKey(strid_YoungTAppraisedCaseType, 4, conYoungTAppraisedCase.id_YoungTAppraisedCaseType);
objYoungTAppraisedCaseEN.id_YoungTAppraisedCaseType = strid_YoungTAppraisedCaseType; //青教案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.id_YoungTAppraisedCaseType) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.id_YoungTAppraisedCaseType, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.id_YoungTAppraisedCaseType] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetUserTypeId(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conYoungTAppraisedCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conYoungTAppraisedCase.UserTypeId);
objYoungTAppraisedCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.UserTypeId) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.UserTypeId, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.UserTypeId] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetRecommendedDegreeId(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conYoungTAppraisedCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conYoungTAppraisedCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conYoungTAppraisedCase.RecommendedDegreeId);
objYoungTAppraisedCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.RecommendedDegreeId) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetftpFileType(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conYoungTAppraisedCase.ftpFileType);
objYoungTAppraisedCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.ftpFileType) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.ftpFileType, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.ftpFileType] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetVideoUrl(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conYoungTAppraisedCase.VideoUrl);
objYoungTAppraisedCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.VideoUrl) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.VideoUrl, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.VideoUrl] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetVideoPath(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conYoungTAppraisedCase.VideoPath);
objYoungTAppraisedCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.VideoPath) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.VideoPath, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.VideoPath] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetResErrMsg(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conYoungTAppraisedCase.ResErrMsg);
objYoungTAppraisedCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.ResErrMsg) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.ResErrMsg, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.ResErrMsg] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetUpdUserId(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conYoungTAppraisedCase.UpdUserId);
objYoungTAppraisedCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.UpdUserId) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.UpdUserId, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.UpdUserId] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetUpdDate(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conYoungTAppraisedCase.UpdDate);
objYoungTAppraisedCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.UpdDate) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.UpdDate, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.UpdDate] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsYoungTAppraisedCaseEN SetMemo(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conYoungTAppraisedCase.Memo);
objYoungTAppraisedCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(conYoungTAppraisedCase.Memo) == false)
{
objYoungTAppraisedCaseEN.dicFldComparisonOp.Add(conYoungTAppraisedCase.Memo, strComparisonOp);
}
else
{
objYoungTAppraisedCaseEN.dicFldComparisonOp[conYoungTAppraisedCase.Memo] = strComparisonOp;
}
}
return objYoungTAppraisedCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsYoungTAppraisedCaseEN objYoungTAppraisedCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.id_YoungTAppraisedCase) == true)
{
string strComparisonOp_id_YoungTAppraisedCase = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.id_YoungTAppraisedCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.id_YoungTAppraisedCase, objYoungTAppraisedCase_Cond.id_YoungTAppraisedCase, strComparisonOp_id_YoungTAppraisedCase);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseID) == true)
{
string strComparisonOp_YoungTAppraisedCaseID = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.YoungTAppraisedCaseID, objYoungTAppraisedCase_Cond.YoungTAppraisedCaseID, strComparisonOp_YoungTAppraisedCaseID);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseName) == true)
{
string strComparisonOp_YoungTAppraisedCaseName = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.YoungTAppraisedCaseName, objYoungTAppraisedCase_Cond.YoungTAppraisedCaseName, strComparisonOp_YoungTAppraisedCaseName);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseText) == true)
{
string strComparisonOp_YoungTAppraisedCaseText = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.YoungTAppraisedCaseText, objYoungTAppraisedCase_Cond.YoungTAppraisedCaseText, strComparisonOp_YoungTAppraisedCaseText);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDate) == true)
{
string strComparisonOp_YoungTAppraisedCaseDate = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.YoungTAppraisedCaseDate, objYoungTAppraisedCase_Cond.YoungTAppraisedCaseDate, strComparisonOp_YoungTAppraisedCaseDate);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTime) == true)
{
string strComparisonOp_YoungTAppraisedCaseTime = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.YoungTAppraisedCaseTime, objYoungTAppraisedCase_Cond.YoungTAppraisedCaseTime, strComparisonOp_YoungTAppraisedCaseTime);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTheme) == true)
{
string strComparisonOp_YoungTAppraisedCaseTheme = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.YoungTAppraisedCaseTheme, objYoungTAppraisedCase_Cond.YoungTAppraisedCaseTheme, strComparisonOp_YoungTAppraisedCaseTheme);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn) == true)
{
string strComparisonOp_YoungTAppraisedCaseDateIn = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.YoungTAppraisedCaseDateIn, objYoungTAppraisedCase_Cond.YoungTAppraisedCaseDateIn, strComparisonOp_YoungTAppraisedCaseDateIn);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn) == true)
{
string strComparisonOp_YoungTAppraisedCaseTimeIn = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn, objYoungTAppraisedCase_Cond.YoungTAppraisedCaseTimeIn, strComparisonOp_YoungTAppraisedCaseTimeIn);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.id_StudyLevel, objYoungTAppraisedCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.id_TeachingPlan, objYoungTAppraisedCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.Id_CaseType, objYoungTAppraisedCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.id_Discipline, objYoungTAppraisedCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conYoungTAppraisedCase.BrowseCount, objYoungTAppraisedCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.id_SenateGaugeVersion, objYoungTAppraisedCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.id_TeachSkill, objYoungTAppraisedCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.CaseLevelId, objYoungTAppraisedCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.DocFile) == true)
{
string strComparisonOp_DocFile = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.DocFile, objYoungTAppraisedCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.IsNeedGeneWord) == true)
{
if (objYoungTAppraisedCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conYoungTAppraisedCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conYoungTAppraisedCase.IsNeedGeneWord);
}
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.WordCreateDate, objYoungTAppraisedCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.IsVisible) == true)
{
if (objYoungTAppraisedCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conYoungTAppraisedCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conYoungTAppraisedCase.IsVisible);
}
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.OwnerId, objYoungTAppraisedCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.IsDualVideo) == true)
{
if (objYoungTAppraisedCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conYoungTAppraisedCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conYoungTAppraisedCase.IsDualVideo);
}
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.id_YoungTAppraisedCaseType) == true)
{
string strComparisonOp_id_YoungTAppraisedCaseType = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.id_YoungTAppraisedCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.id_YoungTAppraisedCaseType, objYoungTAppraisedCase_Cond.id_YoungTAppraisedCaseType, strComparisonOp_id_YoungTAppraisedCaseType);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.UserTypeId, objYoungTAppraisedCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.RecommendedDegreeId, objYoungTAppraisedCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.ftpFileType, objYoungTAppraisedCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.VideoUrl, objYoungTAppraisedCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.VideoPath, objYoungTAppraisedCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.ResErrMsg, objYoungTAppraisedCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.UpdUserId, objYoungTAppraisedCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.UpdDate, objYoungTAppraisedCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objYoungTAppraisedCase_Cond.IsUpdated(conYoungTAppraisedCase.Memo) == true)
{
string strComparisonOp_Memo = objYoungTAppraisedCase_Cond.dicFldComparisonOp[conYoungTAppraisedCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conYoungTAppraisedCase.Memo, objYoungTAppraisedCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
 if (string.IsNullOrEmpty(objYoungTAppraisedCaseEN.id_YoungTAppraisedCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objYoungTAppraisedCaseEN.sf_UpdFldSetStr = objYoungTAppraisedCaseEN.getsf_UpdFldSetStr();
clsYoungTAppraisedCaseWApi.CheckPropertyNew(objYoungTAppraisedCaseEN); 
bool bolResult = clsYoungTAppraisedCaseWApi.UpdateRecord(objYoungTAppraisedCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsYoungTAppraisedCaseWApi.ReFreshCache();
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
 /// <param name = "objYoungTAppraisedCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
 if (string.IsNullOrEmpty(objYoungTAppraisedCaseEN.id_YoungTAppraisedCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsYoungTAppraisedCaseWApi.IsExist(objYoungTAppraisedCaseEN.id_YoungTAppraisedCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objYoungTAppraisedCaseEN.id_YoungTAppraisedCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsYoungTAppraisedCaseWApi.CheckPropertyNew(objYoungTAppraisedCaseEN); 
bool bolResult = clsYoungTAppraisedCaseWApi.AddNewRecord(objYoungTAppraisedCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsYoungTAppraisedCaseWApi.ReFreshCache();
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
 /// <param name = "objYoungTAppraisedCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
try
{
clsYoungTAppraisedCaseWApi.CheckPropertyNew(objYoungTAppraisedCaseEN); 
string strid_YoungTAppraisedCase = clsYoungTAppraisedCaseWApi.AddNewRecordWithMaxId(objYoungTAppraisedCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsYoungTAppraisedCaseWApi.ReFreshCache();
return strid_YoungTAppraisedCase;
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
 /// <param name = "objYoungTAppraisedCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strWhereCond)
{
try
{
clsYoungTAppraisedCaseWApi.CheckPropertyNew(objYoungTAppraisedCaseEN); 
bool bolResult = clsYoungTAppraisedCaseWApi.UpdateWithCondition(objYoungTAppraisedCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsYoungTAppraisedCaseWApi.ReFreshCache();
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
 /// 青教评优案例(YoungTAppraisedCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsYoungTAppraisedCaseWApi
{
private static readonly string mstrApiControllerName = "YoungTAppraisedCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsYoungTAppraisedCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_YoungTAppraisedCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[青教评优案例]...","0");
List<clsYoungTAppraisedCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_YoungTAppraisedCase";
objDDL.DataTextField="YoungTAppraisedCaseName";
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
public static void BindCbo_id_YoungTAppraisedCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conYoungTAppraisedCase.id_YoungTAppraisedCase); 
List<clsYoungTAppraisedCaseEN> arrObjLst = clsYoungTAppraisedCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = new clsYoungTAppraisedCaseEN()
{
id_YoungTAppraisedCase = "0",
YoungTAppraisedCaseName = "选[青教评优案例]..."
};
arrObjLst.Insert(0, objYoungTAppraisedCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conYoungTAppraisedCase.id_YoungTAppraisedCase;
objComboBox.DisplayMember = conYoungTAppraisedCase.YoungTAppraisedCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
if (!Object.Equals(null, objYoungTAppraisedCaseEN.id_YoungTAppraisedCase) && GetStrLen(objYoungTAppraisedCaseEN.id_YoungTAppraisedCase) > 8)
{
 throw new Exception("字段[青教评优案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.YoungTAppraisedCaseID) && GetStrLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseID) > 8)
{
 throw new Exception("字段[青教评优案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.YoungTAppraisedCaseName) && GetStrLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseName) > 100)
{
 throw new Exception("字段[青教评优案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.YoungTAppraisedCaseText) && GetStrLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseText) > 8000)
{
 throw new Exception("字段[案例文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate) && GetStrLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate) > 8)
{
 throw new Exception("字段[青教评优教学日期]的长度不能超过8!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime) && GetStrLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime) > 6)
{
 throw new Exception("字段[青教评优教学时间]的长度不能超过6!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme) && GetStrLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme) > 200)
{
 throw new Exception("字段[青教评优案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn) && GetStrLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn) && GetStrLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.id_StudyLevel) && GetStrLen(objYoungTAppraisedCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.id_TeachingPlan) && GetStrLen(objYoungTAppraisedCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.Id_CaseType) && GetStrLen(objYoungTAppraisedCaseEN.Id_CaseType) > 4)
{
 throw new Exception("字段[案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.id_Discipline) && GetStrLen(objYoungTAppraisedCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.id_SenateGaugeVersion) && GetStrLen(objYoungTAppraisedCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.id_TeachSkill) && GetStrLen(objYoungTAppraisedCaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.CaseLevelId) && GetStrLen(objYoungTAppraisedCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.DocFile) && GetStrLen(objYoungTAppraisedCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.WordCreateDate) && GetStrLen(objYoungTAppraisedCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.OwnerId) && GetStrLen(objYoungTAppraisedCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.id_YoungTAppraisedCaseType) && GetStrLen(objYoungTAppraisedCaseEN.id_YoungTAppraisedCaseType) > 4)
{
 throw new Exception("字段[青教案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.UserTypeId) && GetStrLen(objYoungTAppraisedCaseEN.UserTypeId) > 2)
{
 throw new Exception("字段[用户类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.RecommendedDegreeId) && GetStrLen(objYoungTAppraisedCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.ftpFileType) && GetStrLen(objYoungTAppraisedCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.VideoUrl) && GetStrLen(objYoungTAppraisedCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.VideoPath) && GetStrLen(objYoungTAppraisedCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.ResErrMsg) && GetStrLen(objYoungTAppraisedCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.UpdUserId) && GetStrLen(objYoungTAppraisedCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.UpdDate) && GetStrLen(objYoungTAppraisedCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objYoungTAppraisedCaseEN.Memo) && GetStrLen(objYoungTAppraisedCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objYoungTAppraisedCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_YoungTAppraisedCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsYoungTAppraisedCaseEN GetObjByid_YoungTAppraisedCase(string strid_YoungTAppraisedCase)
{
string strAction = "GetObjByid_YoungTAppraisedCase";
string strErrMsg = string.Empty;
string strResult = "";
clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_YoungTAppraisedCase"] = strid_YoungTAppraisedCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objYoungTAppraisedCaseEN = JsonConvert.DeserializeObject<clsYoungTAppraisedCaseEN>((string)jobjReturn["ReturnObj"]);
return objYoungTAppraisedCaseEN;
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
 /// <param name = "strid_YoungTAppraisedCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsYoungTAppraisedCaseEN GetObjByid_YoungTAppraisedCase_WA_Cache(string strid_YoungTAppraisedCase)
{
string strAction = "GetObjByid_YoungTAppraisedCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_YoungTAppraisedCase"] = strid_YoungTAppraisedCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objYoungTAppraisedCaseEN = JsonConvert.DeserializeObject<clsYoungTAppraisedCaseEN>((string)jobjReturn["ReturnObj"]);
return objYoungTAppraisedCaseEN;
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
public static clsYoungTAppraisedCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = null;
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
objYoungTAppraisedCaseEN = JsonConvert.DeserializeObject<clsYoungTAppraisedCaseEN>((string)jobjReturn["ReturnObj"]);
return objYoungTAppraisedCaseEN;
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
 /// <param name = "strid_YoungTAppraisedCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsYoungTAppraisedCaseEN GetObjByid_YoungTAppraisedCase_Cache(string strid_YoungTAppraisedCase)
{
if (string.IsNullOrEmpty(strid_YoungTAppraisedCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsYoungTAppraisedCaseEN._CurrTabName_S);
List<clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Sel =
from objYoungTAppraisedCaseEN in arrYoungTAppraisedCaseObjLst_Cache
where objYoungTAppraisedCaseEN.id_YoungTAppraisedCase == strid_YoungTAppraisedCase
select objYoungTAppraisedCaseEN;
if (arrYoungTAppraisedCaseObjLst_Sel.Count() == 0)
{
   clsYoungTAppraisedCaseEN obj = clsYoungTAppraisedCaseWApi.GetObjByid_YoungTAppraisedCase(strid_YoungTAppraisedCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrYoungTAppraisedCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_YoungTAppraisedCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetYoungTAppraisedCaseNameByid_YoungTAppraisedCase_Cache(string strid_YoungTAppraisedCase)
{
if (string.IsNullOrEmpty(strid_YoungTAppraisedCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsYoungTAppraisedCaseEN._CurrTabName_S);
List<clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Sel1 =
from objYoungTAppraisedCaseEN in arrYoungTAppraisedCaseObjLst_Cache
where objYoungTAppraisedCaseEN.id_YoungTAppraisedCase == strid_YoungTAppraisedCase
select objYoungTAppraisedCaseEN;
List <clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Sel = new List<clsYoungTAppraisedCaseEN>();
foreach (clsYoungTAppraisedCaseEN obj in arrYoungTAppraisedCaseObjLst_Sel1)
{
arrYoungTAppraisedCaseObjLst_Sel.Add(obj);
}
if (arrYoungTAppraisedCaseObjLst_Sel.Count > 0)
{
return arrYoungTAppraisedCaseObjLst_Sel[0].YoungTAppraisedCaseName;
}
string strErrMsgForGetObjById = string.Format("在YoungTAppraisedCase对象缓存列表中,找不到记录[id_YoungTAppraisedCase = {0}](函数:{1})", strid_YoungTAppraisedCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsYoungTAppraisedCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_YoungTAppraisedCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_YoungTAppraisedCase_Cache(string strid_YoungTAppraisedCase)
{
if (string.IsNullOrEmpty(strid_YoungTAppraisedCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsYoungTAppraisedCaseEN._CurrTabName_S);
List<clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Sel1 =
from objYoungTAppraisedCaseEN in arrYoungTAppraisedCaseObjLst_Cache
where objYoungTAppraisedCaseEN.id_YoungTAppraisedCase == strid_YoungTAppraisedCase
select objYoungTAppraisedCaseEN;
List <clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Sel = new List<clsYoungTAppraisedCaseEN>();
foreach (clsYoungTAppraisedCaseEN obj in arrYoungTAppraisedCaseObjLst_Sel1)
{
arrYoungTAppraisedCaseObjLst_Sel.Add(obj);
}
if (arrYoungTAppraisedCaseObjLst_Sel.Count > 0)
{
return arrYoungTAppraisedCaseObjLst_Sel[0].YoungTAppraisedCaseName;
}
string strErrMsgForGetObjById = string.Format("在YoungTAppraisedCase对象缓存列表中,找不到记录的相关名称[id_YoungTAppraisedCase = {0}](函数:{1})", strid_YoungTAppraisedCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsYoungTAppraisedCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsYoungTAppraisedCaseEN> GetObjLst(string strWhereCond)
{
 List<clsYoungTAppraisedCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsYoungTAppraisedCaseEN> GetObjLstById_YoungTAppraisedCaseLst(List<string> arrId_YoungTAppraisedCase)
{
 List<clsYoungTAppraisedCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_YoungTAppraisedCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_YoungTAppraisedCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_YoungTAppraisedCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsYoungTAppraisedCaseEN> GetObjLstById_YoungTAppraisedCaseLst_Cache(List<string> arrId_YoungTAppraisedCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsYoungTAppraisedCaseEN._CurrTabName_S);
List<clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Sel =
from objYoungTAppraisedCaseEN in arrYoungTAppraisedCaseObjLst_Cache
where arrId_YoungTAppraisedCase.Contains(objYoungTAppraisedCaseEN.id_YoungTAppraisedCase)
select objYoungTAppraisedCaseEN;
return arrYoungTAppraisedCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsYoungTAppraisedCaseEN> GetObjLstById_YoungTAppraisedCaseLst_WA_Cache(List<string> arrId_YoungTAppraisedCase)
{
 List<clsYoungTAppraisedCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_YoungTAppraisedCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_YoungTAppraisedCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsYoungTAppraisedCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsYoungTAppraisedCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsYoungTAppraisedCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsYoungTAppraisedCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsYoungTAppraisedCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsYoungTAppraisedCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsYoungTAppraisedCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsYoungTAppraisedCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_YoungTAppraisedCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = clsYoungTAppraisedCaseWApi.GetObjByid_YoungTAppraisedCase(strid_YoungTAppraisedCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_YoungTAppraisedCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsYoungTAppraisedCaseWApi.ReFreshCache();
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
public static int DelYoungTAppraisedCases(List<string> arrid_YoungTAppraisedCase)
{
string strAction = "DelYoungTAppraisedCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_YoungTAppraisedCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsYoungTAppraisedCaseWApi.ReFreshCache();
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
public static int DelYoungTAppraisedCasesByCond(string strWhereCond)
{
string strAction = "DelYoungTAppraisedCasesByCond";
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
public static bool AddNewRecord(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsYoungTAppraisedCaseEN>(objYoungTAppraisedCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsYoungTAppraisedCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsYoungTAppraisedCaseEN>(objYoungTAppraisedCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsYoungTAppraisedCaseWApi.ReFreshCache();
var strid_YoungTAppraisedCase = (string)jobjReturn["ReturnStr"];
return strid_YoungTAppraisedCase;
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
public static bool UpdateRecord(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
if (string.IsNullOrEmpty(objYoungTAppraisedCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objYoungTAppraisedCaseEN.id_YoungTAppraisedCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsYoungTAppraisedCaseEN>(objYoungTAppraisedCaseEN);
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
 /// <param name = "objYoungTAppraisedCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objYoungTAppraisedCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objYoungTAppraisedCaseEN.id_YoungTAppraisedCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objYoungTAppraisedCaseEN.id_YoungTAppraisedCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsYoungTAppraisedCaseEN>(objYoungTAppraisedCaseEN);
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
public static bool IsExist(string strid_YoungTAppraisedCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_YoungTAppraisedCase"] = strid_YoungTAppraisedCase
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
 /// <param name = "objYoungTAppraisedCaseENS">源对象</param>
 /// <param name = "objYoungTAppraisedCaseENT">目标对象</param>
 public static void CopyTo(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseENS, clsYoungTAppraisedCaseEN objYoungTAppraisedCaseENT)
{
try
{
objYoungTAppraisedCaseENT.id_YoungTAppraisedCase = objYoungTAppraisedCaseENS.id_YoungTAppraisedCase; //青教评优案例流水号
objYoungTAppraisedCaseENT.YoungTAppraisedCaseID = objYoungTAppraisedCaseENS.YoungTAppraisedCaseID; //青教评优案例ID
objYoungTAppraisedCaseENT.YoungTAppraisedCaseName = objYoungTAppraisedCaseENS.YoungTAppraisedCaseName; //青教评优案例名称
objYoungTAppraisedCaseENT.YoungTAppraisedCaseText = objYoungTAppraisedCaseENS.YoungTAppraisedCaseText; //案例文本内容
objYoungTAppraisedCaseENT.YoungTAppraisedCaseDate = objYoungTAppraisedCaseENS.YoungTAppraisedCaseDate; //青教评优教学日期
objYoungTAppraisedCaseENT.YoungTAppraisedCaseTime = objYoungTAppraisedCaseENS.YoungTAppraisedCaseTime; //青教评优教学时间
objYoungTAppraisedCaseENT.YoungTAppraisedCaseTheme = objYoungTAppraisedCaseENS.YoungTAppraisedCaseTheme; //青教评优案例主题词
objYoungTAppraisedCaseENT.YoungTAppraisedCaseDateIn = objYoungTAppraisedCaseENS.YoungTAppraisedCaseDateIn; //案例入库日期
objYoungTAppraisedCaseENT.YoungTAppraisedCaseTimeIn = objYoungTAppraisedCaseENS.YoungTAppraisedCaseTimeIn; //案例入库时间
objYoungTAppraisedCaseENT.id_StudyLevel = objYoungTAppraisedCaseENS.id_StudyLevel; //id_StudyLevel
objYoungTAppraisedCaseENT.id_TeachingPlan = objYoungTAppraisedCaseENS.id_TeachingPlan; //教案流水号
objYoungTAppraisedCaseENT.Id_CaseType = objYoungTAppraisedCaseENS.Id_CaseType; //案例类型流水号
objYoungTAppraisedCaseENT.id_Discipline = objYoungTAppraisedCaseENS.id_Discipline; //学科流水号
objYoungTAppraisedCaseENT.BrowseCount = objYoungTAppraisedCaseENS.BrowseCount; //浏览次数
objYoungTAppraisedCaseENT.id_SenateGaugeVersion = objYoungTAppraisedCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objYoungTAppraisedCaseENT.id_TeachSkill = objYoungTAppraisedCaseENS.id_TeachSkill; //教学技能流水号
objYoungTAppraisedCaseENT.CaseLevelId = objYoungTAppraisedCaseENS.CaseLevelId; //课例等级Id
objYoungTAppraisedCaseENT.DocFile = objYoungTAppraisedCaseENS.DocFile; //生成的Word文件名
objYoungTAppraisedCaseENT.IsNeedGeneWord = objYoungTAppraisedCaseENS.IsNeedGeneWord; //是否需要生成Word
objYoungTAppraisedCaseENT.WordCreateDate = objYoungTAppraisedCaseENS.WordCreateDate; //Word生成日期
objYoungTAppraisedCaseENT.IsVisible = objYoungTAppraisedCaseENS.IsVisible; //是否显示
objYoungTAppraisedCaseENT.OwnerId = objYoungTAppraisedCaseENS.OwnerId; //拥有者Id
objYoungTAppraisedCaseENT.IsDualVideo = objYoungTAppraisedCaseENS.IsDualVideo; //是否双视频
objYoungTAppraisedCaseENT.id_YoungTAppraisedCaseType = objYoungTAppraisedCaseENS.id_YoungTAppraisedCaseType; //青教案例类型流水号
objYoungTAppraisedCaseENT.UserTypeId = objYoungTAppraisedCaseENS.UserTypeId; //用户类型Id
objYoungTAppraisedCaseENT.RecommendedDegreeId = objYoungTAppraisedCaseENS.RecommendedDegreeId; //推荐度Id
objYoungTAppraisedCaseENT.ftpFileType = objYoungTAppraisedCaseENS.ftpFileType; //ftp文件类型
objYoungTAppraisedCaseENT.VideoUrl = objYoungTAppraisedCaseENS.VideoUrl; //视频Url
objYoungTAppraisedCaseENT.VideoPath = objYoungTAppraisedCaseENS.VideoPath; //视频目录
objYoungTAppraisedCaseENT.ResErrMsg = objYoungTAppraisedCaseENS.ResErrMsg; //资源错误信息
objYoungTAppraisedCaseENT.UpdUserId = objYoungTAppraisedCaseENS.UpdUserId; //修改用户Id
objYoungTAppraisedCaseENT.UpdDate = objYoungTAppraisedCaseENS.UpdDate; //修改日期
objYoungTAppraisedCaseENT.Memo = objYoungTAppraisedCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsYoungTAppraisedCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsYoungTAppraisedCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsYoungTAppraisedCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsYoungTAppraisedCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsYoungTAppraisedCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsYoungTAppraisedCaseEN.AttributeName)
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
if (clsYoungTAppraisedCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsYoungTAppraisedCaseWApi没有刷新缓存机制(clsYoungTAppraisedCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_YoungTAppraisedCase");
//if (arrYoungTAppraisedCaseObjLst_Cache == null)
//{
//arrYoungTAppraisedCaseObjLst_Cache = await clsYoungTAppraisedCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsYoungTAppraisedCaseEN._CurrTabName_S);
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
if (clsYoungTAppraisedCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsYoungTAppraisedCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsYoungTAppraisedCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsYoungTAppraisedCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsYoungTAppraisedCaseEN._CurrTabName_S);
List<clsYoungTAppraisedCaseEN> arrYoungTAppraisedCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrYoungTAppraisedCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsYoungTAppraisedCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conYoungTAppraisedCase.id_YoungTAppraisedCase, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.YoungTAppraisedCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.YoungTAppraisedCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.YoungTAppraisedCaseText, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conYoungTAppraisedCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conYoungTAppraisedCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conYoungTAppraisedCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conYoungTAppraisedCase.id_YoungTAppraisedCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conYoungTAppraisedCase.Memo, Type.GetType("System.String"));
foreach (clsYoungTAppraisedCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conYoungTAppraisedCase.id_YoungTAppraisedCase] = objInFor[conYoungTAppraisedCase.id_YoungTAppraisedCase];
objDR[conYoungTAppraisedCase.YoungTAppraisedCaseID] = objInFor[conYoungTAppraisedCase.YoungTAppraisedCaseID];
objDR[conYoungTAppraisedCase.YoungTAppraisedCaseName] = objInFor[conYoungTAppraisedCase.YoungTAppraisedCaseName];
objDR[conYoungTAppraisedCase.YoungTAppraisedCaseText] = objInFor[conYoungTAppraisedCase.YoungTAppraisedCaseText];
objDR[conYoungTAppraisedCase.YoungTAppraisedCaseDate] = objInFor[conYoungTAppraisedCase.YoungTAppraisedCaseDate];
objDR[conYoungTAppraisedCase.YoungTAppraisedCaseTime] = objInFor[conYoungTAppraisedCase.YoungTAppraisedCaseTime];
objDR[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] = objInFor[conYoungTAppraisedCase.YoungTAppraisedCaseTheme];
objDR[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] = objInFor[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn];
objDR[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] = objInFor[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn];
objDR[conYoungTAppraisedCase.id_StudyLevel] = objInFor[conYoungTAppraisedCase.id_StudyLevel];
objDR[conYoungTAppraisedCase.id_TeachingPlan] = objInFor[conYoungTAppraisedCase.id_TeachingPlan];
objDR[conYoungTAppraisedCase.Id_CaseType] = objInFor[conYoungTAppraisedCase.Id_CaseType];
objDR[conYoungTAppraisedCase.id_Discipline] = objInFor[conYoungTAppraisedCase.id_Discipline];
objDR[conYoungTAppraisedCase.BrowseCount] = objInFor[conYoungTAppraisedCase.BrowseCount];
objDR[conYoungTAppraisedCase.id_SenateGaugeVersion] = objInFor[conYoungTAppraisedCase.id_SenateGaugeVersion];
objDR[conYoungTAppraisedCase.id_TeachSkill] = objInFor[conYoungTAppraisedCase.id_TeachSkill];
objDR[conYoungTAppraisedCase.CaseLevelId] = objInFor[conYoungTAppraisedCase.CaseLevelId];
objDR[conYoungTAppraisedCase.DocFile] = objInFor[conYoungTAppraisedCase.DocFile];
objDR[conYoungTAppraisedCase.IsNeedGeneWord] = objInFor[conYoungTAppraisedCase.IsNeedGeneWord];
objDR[conYoungTAppraisedCase.WordCreateDate] = objInFor[conYoungTAppraisedCase.WordCreateDate];
objDR[conYoungTAppraisedCase.IsVisible] = objInFor[conYoungTAppraisedCase.IsVisible];
objDR[conYoungTAppraisedCase.OwnerId] = objInFor[conYoungTAppraisedCase.OwnerId];
objDR[conYoungTAppraisedCase.IsDualVideo] = objInFor[conYoungTAppraisedCase.IsDualVideo];
objDR[conYoungTAppraisedCase.id_YoungTAppraisedCaseType] = objInFor[conYoungTAppraisedCase.id_YoungTAppraisedCaseType];
objDR[conYoungTAppraisedCase.UserTypeId] = objInFor[conYoungTAppraisedCase.UserTypeId];
objDR[conYoungTAppraisedCase.RecommendedDegreeId] = objInFor[conYoungTAppraisedCase.RecommendedDegreeId];
objDR[conYoungTAppraisedCase.ftpFileType] = objInFor[conYoungTAppraisedCase.ftpFileType];
objDR[conYoungTAppraisedCase.VideoUrl] = objInFor[conYoungTAppraisedCase.VideoUrl];
objDR[conYoungTAppraisedCase.VideoPath] = objInFor[conYoungTAppraisedCase.VideoPath];
objDR[conYoungTAppraisedCase.ResErrMsg] = objInFor[conYoungTAppraisedCase.ResErrMsg];
objDR[conYoungTAppraisedCase.UpdUserId] = objInFor[conYoungTAppraisedCase.UpdUserId];
objDR[conYoungTAppraisedCase.UpdDate] = objInFor[conYoungTAppraisedCase.UpdDate];
objDR[conYoungTAppraisedCase.Memo] = objInFor[conYoungTAppraisedCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 青教评优案例(YoungTAppraisedCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4YoungTAppraisedCase : clsCommFun4BL
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
clsYoungTAppraisedCaseWApi.ReFreshThisCache();
}
}

}