
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCase_SimWApi
 表名:vYoungTAppraisedCase_Sim(01120521)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:51
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
public static class clsvYoungTAppraisedCase_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN Setid_YoungTAppraisedCase(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strid_YoungTAppraisedCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_YoungTAppraisedCase, 8, convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase);
clsCheckSql.CheckFieldForeignKey(strid_YoungTAppraisedCase, 8, convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase);
objvYoungTAppraisedCase_SimEN.id_YoungTAppraisedCase = strid_YoungTAppraisedCase; //青教评优案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetYoungTAppraisedCaseID(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strYoungTAppraisedCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseID, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseID, 8, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseID, 8, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID);
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseID = strYoungTAppraisedCaseID; //青教评优案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetYoungTAppraisedCaseName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strYoungTAppraisedCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseName, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseName, 100, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName);
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseName = strYoungTAppraisedCaseName; //青教评优案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetYoungTAppraisedCaseText(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strYoungTAppraisedCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseText, 8000, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText);
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseText = strYoungTAppraisedCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetYoungTAppraisedCaseDate(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strYoungTAppraisedCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseDate, 8, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseDate, 8, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate);
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDate = strYoungTAppraisedCaseDate; //青教评优教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetYoungTAppraisedCaseTime(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strYoungTAppraisedCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTime, 6, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseTime, 6, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime);
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTime = strYoungTAppraisedCaseTime; //青教评优教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetYoungTAppraisedCaseTheme(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strYoungTAppraisedCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTheme, 200, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme);
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTheme = strYoungTAppraisedCaseTheme; //青教评优案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetYoungTAppraisedCaseDateIn(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strYoungTAppraisedCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseDateIn, 8, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseDateIn, 8, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn);
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDateIn = strYoungTAppraisedCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetYoungTAppraisedCaseTimeIn(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strYoungTAppraisedCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTimeIn, 6, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseTimeIn, 6, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn);
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTimeIn = strYoungTAppraisedCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN Setid_StudyLevel(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convYoungTAppraisedCase_Sim.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convYoungTAppraisedCase_Sim.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convYoungTAppraisedCase_Sim.id_StudyLevel);
objvYoungTAppraisedCase_SimEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.id_StudyLevel) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.id_StudyLevel, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_StudyLevel] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetStudyLevelName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convYoungTAppraisedCase_Sim.StudyLevelName);
objvYoungTAppraisedCase_SimEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.StudyLevelName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.StudyLevelName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.StudyLevelName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN Setid_TeachingPlan(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convYoungTAppraisedCase_Sim.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convYoungTAppraisedCase_Sim.id_TeachingPlan);
objvYoungTAppraisedCase_SimEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.id_TeachingPlan) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.id_TeachingPlan, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_TeachingPlan] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetId_CaseType(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convYoungTAppraisedCase_Sim.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convYoungTAppraisedCase_Sim.Id_CaseType);
objvYoungTAppraisedCase_SimEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.Id_CaseType) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.Id_CaseType, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.Id_CaseType] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN Setid_Discipline(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convYoungTAppraisedCase_Sim.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convYoungTAppraisedCase_Sim.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convYoungTAppraisedCase_Sim.id_Discipline);
objvYoungTAppraisedCase_SimEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.id_Discipline) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.id_Discipline, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_Discipline] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetDisciplineID(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convYoungTAppraisedCase_Sim.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convYoungTAppraisedCase_Sim.DisciplineID);
objvYoungTAppraisedCase_SimEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.DisciplineID) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.DisciplineID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.DisciplineID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetDisciplineName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convYoungTAppraisedCase_Sim.DisciplineName);
objvYoungTAppraisedCase_SimEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.DisciplineName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.DisciplineName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.DisciplineName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetBrowseCount(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, int intBrowseCount, string strComparisonOp="")
	{
objvYoungTAppraisedCase_SimEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.BrowseCount) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.BrowseCount, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.BrowseCount] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN Setid_SenateGaugeVersion(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convYoungTAppraisedCase_Sim.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convYoungTAppraisedCase_Sim.id_SenateGaugeVersion);
objvYoungTAppraisedCase_SimEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.id_SenateGaugeVersion) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetsenateGaugeVersionID(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convYoungTAppraisedCase_Sim.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convYoungTAppraisedCase_Sim.senateGaugeVersionID);
objvYoungTAppraisedCase_SimEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.senateGaugeVersionID) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.senateGaugeVersionID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.senateGaugeVersionID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetsenateGaugeVersionName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convYoungTAppraisedCase_Sim.senateGaugeVersionName);
objvYoungTAppraisedCase_SimEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.senateGaugeVersionName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.senateGaugeVersionName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.senateGaugeVersionName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetsenateGaugeVersionTtlScore(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvYoungTAppraisedCase_SimEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetVersionNo(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, int intVersionNo, string strComparisonOp="")
	{
objvYoungTAppraisedCase_SimEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.VersionNo) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.VersionNo, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.VersionNo] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN Setid_TeachSkill(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convYoungTAppraisedCase_Sim.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convYoungTAppraisedCase_Sim.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convYoungTAppraisedCase_Sim.id_TeachSkill);
objvYoungTAppraisedCase_SimEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.id_TeachSkill) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.id_TeachSkill, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_TeachSkill] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetTeachSkillID(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convYoungTAppraisedCase_Sim.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convYoungTAppraisedCase_Sim.TeachSkillID);
objvYoungTAppraisedCase_SimEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.TeachSkillID) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.TeachSkillID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeachSkillID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetSkillTypeName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convYoungTAppraisedCase_Sim.SkillTypeName);
objvYoungTAppraisedCase_SimEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.SkillTypeName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.SkillTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.SkillTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetTeachSkillName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convYoungTAppraisedCase_Sim.TeachSkillName);
objvYoungTAppraisedCase_SimEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.TeachSkillName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.TeachSkillName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeachSkillName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetTeachSkillTheory(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convYoungTAppraisedCase_Sim.TeachSkillTheory);
objvYoungTAppraisedCase_SimEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.TeachSkillTheory) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.TeachSkillTheory, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeachSkillTheory] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetTeachSkillOperMethod(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convYoungTAppraisedCase_Sim.TeachSkillOperMethod);
objvYoungTAppraisedCase_SimEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.TeachSkillOperMethod) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN Setid_SkillType(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convYoungTAppraisedCase_Sim.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convYoungTAppraisedCase_Sim.id_SkillType);
objvYoungTAppraisedCase_SimEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.id_SkillType) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.id_SkillType, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_SkillType] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetSkillTypeID(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convYoungTAppraisedCase_Sim.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convYoungTAppraisedCase_Sim.SkillTypeID);
objvYoungTAppraisedCase_SimEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.SkillTypeID) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.SkillTypeID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.SkillTypeID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetCaseLevelId(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convYoungTAppraisedCase_Sim.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convYoungTAppraisedCase_Sim.CaseLevelId);
objvYoungTAppraisedCase_SimEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.CaseLevelId) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.CaseLevelId, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.CaseLevelId] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetDocFile(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convYoungTAppraisedCase_Sim.DocFile);
objvYoungTAppraisedCase_SimEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.DocFile) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.DocFile, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.DocFile] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetIsNeedGeneWord(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvYoungTAppraisedCase_SimEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.IsNeedGeneWord) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.IsNeedGeneWord, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.IsNeedGeneWord] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetWordCreateDate(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convYoungTAppraisedCase_Sim.WordCreateDate);
objvYoungTAppraisedCase_SimEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.WordCreateDate) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.WordCreateDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.WordCreateDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetIsVisible(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, bool bolIsVisible, string strComparisonOp="")
	{
objvYoungTAppraisedCase_SimEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.IsVisible) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.IsVisible, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.IsVisible] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetOwnerId(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convYoungTAppraisedCase_Sim.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convYoungTAppraisedCase_Sim.OwnerId);
objvYoungTAppraisedCase_SimEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.OwnerId) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.OwnerId, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.OwnerId] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetTeacherID(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convYoungTAppraisedCase_Sim.TeacherID);
objvYoungTAppraisedCase_SimEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.TeacherID) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.TeacherID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeacherID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetTeacherName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convYoungTAppraisedCase_Sim.TeacherName);
objvYoungTAppraisedCase_SimEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.TeacherName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.TeacherName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeacherName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN Setid_XzCollege(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convYoungTAppraisedCase_Sim.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convYoungTAppraisedCase_Sim.id_XzCollege);
objvYoungTAppraisedCase_SimEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.id_XzCollege) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.id_XzCollege, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_XzCollege] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetCollegeName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convYoungTAppraisedCase_Sim.CollegeName);
objvYoungTAppraisedCase_SimEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.CollegeName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.CollegeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.CollegeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetEntryDate(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strEntryDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryDate, 8, convYoungTAppraisedCase_Sim.EntryDate);
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, convYoungTAppraisedCase_Sim.EntryDate);
objvYoungTAppraisedCase_SimEN.EntryDate = strEntryDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.EntryDate) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.EntryDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.EntryDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetCollegeID(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convYoungTAppraisedCase_Sim.CollegeID);
objvYoungTAppraisedCase_SimEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.CollegeID) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.CollegeID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.CollegeID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetEntryYear(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strEntryYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryYear, 8, convYoungTAppraisedCase_Sim.EntryYear);
objvYoungTAppraisedCase_SimEN.EntryYear = strEntryYear; //EntryYear
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.EntryYear) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.EntryYear, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.EntryYear] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetCollegeNameA(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convYoungTAppraisedCase_Sim.CollegeNameA);
objvYoungTAppraisedCase_SimEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.CollegeNameA) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.CollegeNameA, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.CollegeNameA] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetIsDualVideo(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convYoungTAppraisedCase_Sim.IsDualVideo);
objvYoungTAppraisedCase_SimEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.IsDualVideo) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.IsDualVideo, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.IsDualVideo] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN Setid_YoungTAppraisedCaseType(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strid_YoungTAppraisedCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_YoungTAppraisedCaseType, 4, convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType);
clsCheckSql.CheckFieldForeignKey(strid_YoungTAppraisedCaseType, 4, convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType);
objvYoungTAppraisedCase_SimEN.id_YoungTAppraisedCaseType = strid_YoungTAppraisedCaseType; //青教案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetYoungTAppraisedCaseTypeName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strYoungTAppraisedCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTypeName, 50, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName);
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTypeName = strYoungTAppraisedCaseTypeName; //青教案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetUserTypeId(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convYoungTAppraisedCase_Sim.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convYoungTAppraisedCase_Sim.UserTypeId);
objvYoungTAppraisedCase_SimEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.UserTypeId) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.UserTypeId, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.UserTypeId] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetUserTypeName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convYoungTAppraisedCase_Sim.UserTypeName);
objvYoungTAppraisedCase_SimEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.UserTypeName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.UserTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.UserTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetRecommendedDegreeId(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convYoungTAppraisedCase_Sim.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convYoungTAppraisedCase_Sim.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convYoungTAppraisedCase_Sim.RecommendedDegreeId);
objvYoungTAppraisedCase_SimEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.RecommendedDegreeId) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.RecommendedDegreeId, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.RecommendedDegreeId] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetRecommendedDegreeName(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convYoungTAppraisedCase_Sim.RecommendedDegreeName);
objvYoungTAppraisedCase_SimEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.RecommendedDegreeName) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.RecommendedDegreeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.RecommendedDegreeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetMemo(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convYoungTAppraisedCase_Sim.Memo);
objvYoungTAppraisedCase_SimEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.Memo) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.Memo, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.Memo] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_SimEN SetIsUse(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN, bool bolIsUse, string strComparisonOp="")
	{
objvYoungTAppraisedCase_SimEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Sim.IsUse) == false)
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Sim.IsUse, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_SimEN.dicFldComparisonOp[convYoungTAppraisedCase_Sim.IsUse] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_Sim_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase) == true)
{
string strComparisonOp_id_YoungTAppraisedCase = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase, objvYoungTAppraisedCase_Sim_Cond.id_YoungTAppraisedCase, strComparisonOp_id_YoungTAppraisedCase);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID) == true)
{
string strComparisonOp_YoungTAppraisedCaseID = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID, objvYoungTAppraisedCase_Sim_Cond.YoungTAppraisedCaseID, strComparisonOp_YoungTAppraisedCaseID);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName) == true)
{
string strComparisonOp_YoungTAppraisedCaseName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName, objvYoungTAppraisedCase_Sim_Cond.YoungTAppraisedCaseName, strComparisonOp_YoungTAppraisedCaseName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText) == true)
{
string strComparisonOp_YoungTAppraisedCaseText = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText, objvYoungTAppraisedCase_Sim_Cond.YoungTAppraisedCaseText, strComparisonOp_YoungTAppraisedCaseText);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate) == true)
{
string strComparisonOp_YoungTAppraisedCaseDate = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate, objvYoungTAppraisedCase_Sim_Cond.YoungTAppraisedCaseDate, strComparisonOp_YoungTAppraisedCaseDate);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime) == true)
{
string strComparisonOp_YoungTAppraisedCaseTime = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime, objvYoungTAppraisedCase_Sim_Cond.YoungTAppraisedCaseTime, strComparisonOp_YoungTAppraisedCaseTime);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme) == true)
{
string strComparisonOp_YoungTAppraisedCaseTheme = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme, objvYoungTAppraisedCase_Sim_Cond.YoungTAppraisedCaseTheme, strComparisonOp_YoungTAppraisedCaseTheme);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn) == true)
{
string strComparisonOp_YoungTAppraisedCaseDateIn = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn, objvYoungTAppraisedCase_Sim_Cond.YoungTAppraisedCaseDateIn, strComparisonOp_YoungTAppraisedCaseDateIn);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn) == true)
{
string strComparisonOp_YoungTAppraisedCaseTimeIn = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn, objvYoungTAppraisedCase_Sim_Cond.YoungTAppraisedCaseTimeIn, strComparisonOp_YoungTAppraisedCaseTimeIn);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.id_StudyLevel, objvYoungTAppraisedCase_Sim_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.StudyLevelName, objvYoungTAppraisedCase_Sim_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.id_TeachingPlan, objvYoungTAppraisedCase_Sim_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.Id_CaseType, objvYoungTAppraisedCase_Sim_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.id_Discipline, objvYoungTAppraisedCase_Sim_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.DisciplineID, objvYoungTAppraisedCase_Sim_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.DisciplineName, objvYoungTAppraisedCase_Sim_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase_Sim.BrowseCount, objvYoungTAppraisedCase_Sim_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.id_SenateGaugeVersion, objvYoungTAppraisedCase_Sim_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.senateGaugeVersionID, objvYoungTAppraisedCase_Sim_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.senateGaugeVersionName, objvYoungTAppraisedCase_Sim_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore, objvYoungTAppraisedCase_Sim_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase_Sim.VersionNo, objvYoungTAppraisedCase_Sim_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.id_TeachSkill, objvYoungTAppraisedCase_Sim_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.TeachSkillID, objvYoungTAppraisedCase_Sim_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.SkillTypeName, objvYoungTAppraisedCase_Sim_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.TeachSkillName, objvYoungTAppraisedCase_Sim_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.TeachSkillTheory, objvYoungTAppraisedCase_Sim_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.TeachSkillOperMethod, objvYoungTAppraisedCase_Sim_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.id_SkillType, objvYoungTAppraisedCase_Sim_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.SkillTypeID, objvYoungTAppraisedCase_Sim_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.CaseLevelId, objvYoungTAppraisedCase_Sim_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.DocFile) == true)
{
string strComparisonOp_DocFile = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.DocFile, objvYoungTAppraisedCase_Sim_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.IsNeedGeneWord) == true)
{
if (objvYoungTAppraisedCase_Sim_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase_Sim.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase_Sim.IsNeedGeneWord);
}
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.WordCreateDate, objvYoungTAppraisedCase_Sim_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.IsVisible) == true)
{
if (objvYoungTAppraisedCase_Sim_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase_Sim.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase_Sim.IsVisible);
}
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.OwnerId, objvYoungTAppraisedCase_Sim_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.TeacherID, objvYoungTAppraisedCase_Sim_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.TeacherName, objvYoungTAppraisedCase_Sim_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.id_XzCollege, objvYoungTAppraisedCase_Sim_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.CollegeName, objvYoungTAppraisedCase_Sim_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.EntryDate) == true)
{
string strComparisonOp_EntryDate = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.EntryDate, objvYoungTAppraisedCase_Sim_Cond.EntryDate, strComparisonOp_EntryDate);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.CollegeID, objvYoungTAppraisedCase_Sim_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.EntryYear) == true)
{
string strComparisonOp_EntryYear = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.EntryYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.EntryYear, objvYoungTAppraisedCase_Sim_Cond.EntryYear, strComparisonOp_EntryYear);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.CollegeNameA, objvYoungTAppraisedCase_Sim_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.IsDualVideo) == true)
{
if (objvYoungTAppraisedCase_Sim_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase_Sim.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase_Sim.IsDualVideo);
}
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType) == true)
{
string strComparisonOp_id_YoungTAppraisedCaseType = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType, objvYoungTAppraisedCase_Sim_Cond.id_YoungTAppraisedCaseType, strComparisonOp_id_YoungTAppraisedCaseType);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName) == true)
{
string strComparisonOp_YoungTAppraisedCaseTypeName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName, objvYoungTAppraisedCase_Sim_Cond.YoungTAppraisedCaseTypeName, strComparisonOp_YoungTAppraisedCaseTypeName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.UserTypeId, objvYoungTAppraisedCase_Sim_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.UserTypeName, objvYoungTAppraisedCase_Sim_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.RecommendedDegreeId, objvYoungTAppraisedCase_Sim_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.RecommendedDegreeName, objvYoungTAppraisedCase_Sim_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.Memo) == true)
{
string strComparisonOp_Memo = objvYoungTAppraisedCase_Sim_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Sim.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Sim.Memo, objvYoungTAppraisedCase_Sim_Cond.Memo, strComparisonOp_Memo);
}
if (objvYoungTAppraisedCase_Sim_Cond.IsUpdated(convYoungTAppraisedCase_Sim.IsUse) == true)
{
if (objvYoungTAppraisedCase_Sim_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase_Sim.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase_Sim.IsUse);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// vYoungTAppraisedCase_Sim(vYoungTAppraisedCase_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvYoungTAppraisedCase_SimWApi
{
private static readonly string mstrApiControllerName = "vYoungTAppraisedCase_SimApi";

 public clsvYoungTAppraisedCase_SimWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_YoungTAppraisedCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvYoungTAppraisedCase_SimEN GetObjByid_YoungTAppraisedCase(string strid_YoungTAppraisedCase)
{
string strAction = "GetObjByid_YoungTAppraisedCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN = null;
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
objvYoungTAppraisedCase_SimEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCase_SimEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCase_SimEN;
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
public static clsvYoungTAppraisedCase_SimEN GetObjByid_YoungTAppraisedCase_WA_Cache(string strid_YoungTAppraisedCase)
{
string strAction = "GetObjByid_YoungTAppraisedCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN = null;
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
objvYoungTAppraisedCase_SimEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCase_SimEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCase_SimEN;
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
public static clsvYoungTAppraisedCase_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN = null;
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
objvYoungTAppraisedCase_SimEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCase_SimEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCase_SimEN;
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
public static clsvYoungTAppraisedCase_SimEN GetObjByid_YoungTAppraisedCase_Cache(string strid_YoungTAppraisedCase)
{
if (string.IsNullOrEmpty(strid_YoungTAppraisedCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvYoungTAppraisedCase_SimEN._CurrTabName_S);
List<clsvYoungTAppraisedCase_SimEN> arrvYoungTAppraisedCase_SimObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvYoungTAppraisedCase_SimEN> arrvYoungTAppraisedCase_SimObjLst_Sel =
from objvYoungTAppraisedCase_SimEN in arrvYoungTAppraisedCase_SimObjLst_Cache
where objvYoungTAppraisedCase_SimEN.id_YoungTAppraisedCase == strid_YoungTAppraisedCase
select objvYoungTAppraisedCase_SimEN;
if (arrvYoungTAppraisedCase_SimObjLst_Sel.Count() == 0)
{
   clsvYoungTAppraisedCase_SimEN obj = clsvYoungTAppraisedCase_SimWApi.GetObjByid_YoungTAppraisedCase(strid_YoungTAppraisedCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvYoungTAppraisedCase_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvYoungTAppraisedCase_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvYoungTAppraisedCase_SimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_SimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCase_SimEN> GetObjLstById_YoungTAppraisedCaseLst(List<string> arrId_YoungTAppraisedCase)
{
 List<clsvYoungTAppraisedCase_SimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_SimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvYoungTAppraisedCase_SimEN> GetObjLstById_YoungTAppraisedCaseLst_Cache(List<string> arrId_YoungTAppraisedCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvYoungTAppraisedCase_SimEN._CurrTabName_S);
List<clsvYoungTAppraisedCase_SimEN> arrvYoungTAppraisedCase_SimObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvYoungTAppraisedCase_SimEN> arrvYoungTAppraisedCase_SimObjLst_Sel =
from objvYoungTAppraisedCase_SimEN in arrvYoungTAppraisedCase_SimObjLst_Cache
where arrId_YoungTAppraisedCase.Contains(objvYoungTAppraisedCase_SimEN.id_YoungTAppraisedCase)
select objvYoungTAppraisedCase_SimEN;
return arrvYoungTAppraisedCase_SimObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvYoungTAppraisedCase_SimEN> GetObjLstById_YoungTAppraisedCaseLst_WA_Cache(List<string> arrId_YoungTAppraisedCase)
{
 List<clsvYoungTAppraisedCase_SimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_SimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCase_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvYoungTAppraisedCase_SimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_SimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCase_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvYoungTAppraisedCase_SimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_SimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCase_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvYoungTAppraisedCase_SimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_SimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCase_SimEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvYoungTAppraisedCase_SimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_SimEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimENS">源对象</param>
 /// <param name = "objvYoungTAppraisedCase_SimENT">目标对象</param>
 public static void CopyTo(clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimENS, clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimENT)
{
try
{
objvYoungTAppraisedCase_SimENT.id_YoungTAppraisedCase = objvYoungTAppraisedCase_SimENS.id_YoungTAppraisedCase; //青教评优案例流水号
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseID = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseID; //青教评优案例ID
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseName = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseName; //青教评优案例名称
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseText = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseText; //案例文本内容
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseDate = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseDate; //青教评优教学日期
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseTime = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseTime; //青教评优教学时间
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseTheme = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseTheme; //青教评优案例主题词
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseDateIn = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseDateIn; //案例入库日期
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseTimeIn = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseTimeIn; //案例入库时间
objvYoungTAppraisedCase_SimENT.id_StudyLevel = objvYoungTAppraisedCase_SimENS.id_StudyLevel; //id_StudyLevel
objvYoungTAppraisedCase_SimENT.StudyLevelName = objvYoungTAppraisedCase_SimENS.StudyLevelName; //学段名称
objvYoungTAppraisedCase_SimENT.id_TeachingPlan = objvYoungTAppraisedCase_SimENS.id_TeachingPlan; //教案流水号
objvYoungTAppraisedCase_SimENT.Id_CaseType = objvYoungTAppraisedCase_SimENS.Id_CaseType; //案例类型流水号
objvYoungTAppraisedCase_SimENT.id_Discipline = objvYoungTAppraisedCase_SimENS.id_Discipline; //学科流水号
objvYoungTAppraisedCase_SimENT.DisciplineID = objvYoungTAppraisedCase_SimENS.DisciplineID; //学科ID
objvYoungTAppraisedCase_SimENT.DisciplineName = objvYoungTAppraisedCase_SimENS.DisciplineName; //学科名称
objvYoungTAppraisedCase_SimENT.BrowseCount = objvYoungTAppraisedCase_SimENS.BrowseCount; //浏览次数
objvYoungTAppraisedCase_SimENT.id_SenateGaugeVersion = objvYoungTAppraisedCase_SimENS.id_SenateGaugeVersion; //评价量表版本流水号
objvYoungTAppraisedCase_SimENT.senateGaugeVersionID = objvYoungTAppraisedCase_SimENS.senateGaugeVersionID; //评价量表版本ID
objvYoungTAppraisedCase_SimENT.senateGaugeVersionName = objvYoungTAppraisedCase_SimENS.senateGaugeVersionName; //评价量表版本名称
objvYoungTAppraisedCase_SimENT.senateGaugeVersionTtlScore = objvYoungTAppraisedCase_SimENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvYoungTAppraisedCase_SimENT.VersionNo = objvYoungTAppraisedCase_SimENS.VersionNo; //版本号
objvYoungTAppraisedCase_SimENT.id_TeachSkill = objvYoungTAppraisedCase_SimENS.id_TeachSkill; //教学技能流水号
objvYoungTAppraisedCase_SimENT.TeachSkillID = objvYoungTAppraisedCase_SimENS.TeachSkillID; //教学技能ID
objvYoungTAppraisedCase_SimENT.SkillTypeName = objvYoungTAppraisedCase_SimENS.SkillTypeName; //技能类型名称
objvYoungTAppraisedCase_SimENT.TeachSkillName = objvYoungTAppraisedCase_SimENS.TeachSkillName; //教学技能名称
objvYoungTAppraisedCase_SimENT.TeachSkillTheory = objvYoungTAppraisedCase_SimENS.TeachSkillTheory; //教学技能理论阐述
objvYoungTAppraisedCase_SimENT.TeachSkillOperMethod = objvYoungTAppraisedCase_SimENS.TeachSkillOperMethod; //教学技能实践操作方法
objvYoungTAppraisedCase_SimENT.id_SkillType = objvYoungTAppraisedCase_SimENS.id_SkillType; //技能类型流水号
objvYoungTAppraisedCase_SimENT.SkillTypeID = objvYoungTAppraisedCase_SimENS.SkillTypeID; //技能类型ID
objvYoungTAppraisedCase_SimENT.CaseLevelId = objvYoungTAppraisedCase_SimENS.CaseLevelId; //课例等级Id
objvYoungTAppraisedCase_SimENT.DocFile = objvYoungTAppraisedCase_SimENS.DocFile; //生成的Word文件名
objvYoungTAppraisedCase_SimENT.IsNeedGeneWord = objvYoungTAppraisedCase_SimENS.IsNeedGeneWord; //是否需要生成Word
objvYoungTAppraisedCase_SimENT.WordCreateDate = objvYoungTAppraisedCase_SimENS.WordCreateDate; //Word生成日期
objvYoungTAppraisedCase_SimENT.IsVisible = objvYoungTAppraisedCase_SimENS.IsVisible; //是否显示
objvYoungTAppraisedCase_SimENT.OwnerId = objvYoungTAppraisedCase_SimENS.OwnerId; //拥有者Id
objvYoungTAppraisedCase_SimENT.TeacherID = objvYoungTAppraisedCase_SimENS.TeacherID; //教师工号
objvYoungTAppraisedCase_SimENT.TeacherName = objvYoungTAppraisedCase_SimENS.TeacherName; //教师姓名
objvYoungTAppraisedCase_SimENT.id_XzCollege = objvYoungTAppraisedCase_SimENS.id_XzCollege; //学院流水号
objvYoungTAppraisedCase_SimENT.CollegeName = objvYoungTAppraisedCase_SimENS.CollegeName; //学院名称
objvYoungTAppraisedCase_SimENT.EntryDate = objvYoungTAppraisedCase_SimENS.EntryDate; //进校日期
objvYoungTAppraisedCase_SimENT.CollegeID = objvYoungTAppraisedCase_SimENS.CollegeID; //学院ID
objvYoungTAppraisedCase_SimENT.EntryYear = objvYoungTAppraisedCase_SimENS.EntryYear; //EntryYear
objvYoungTAppraisedCase_SimENT.CollegeNameA = objvYoungTAppraisedCase_SimENS.CollegeNameA; //学院名称简写
objvYoungTAppraisedCase_SimENT.IsDualVideo = objvYoungTAppraisedCase_SimENS.IsDualVideo; //是否双视频
objvYoungTAppraisedCase_SimENT.id_YoungTAppraisedCaseType = objvYoungTAppraisedCase_SimENS.id_YoungTAppraisedCaseType; //青教案例类型流水号
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseTypeName = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseTypeName; //青教案例类型名称
objvYoungTAppraisedCase_SimENT.UserTypeId = objvYoungTAppraisedCase_SimENS.UserTypeId; //用户类型Id
objvYoungTAppraisedCase_SimENT.UserTypeName = objvYoungTAppraisedCase_SimENS.UserTypeName; //用户类型名称
objvYoungTAppraisedCase_SimENT.RecommendedDegreeId = objvYoungTAppraisedCase_SimENS.RecommendedDegreeId; //推荐度Id
objvYoungTAppraisedCase_SimENT.RecommendedDegreeName = objvYoungTAppraisedCase_SimENS.RecommendedDegreeName; //推荐度名称
objvYoungTAppraisedCase_SimENT.Memo = objvYoungTAppraisedCase_SimENS.Memo; //备注
objvYoungTAppraisedCase_SimENT.IsUse = objvYoungTAppraisedCase_SimENS.IsUse; //是否使用
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
public static DataTable ToDataTable(List<clsvYoungTAppraisedCase_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvYoungTAppraisedCase_SimEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvYoungTAppraisedCase_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvYoungTAppraisedCase_SimEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvYoungTAppraisedCase_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvYoungTAppraisedCase_SimEN.AttributeName)
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
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsYoungTAppraisedCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsYoungTAppraisedCaseWApi没有刷新缓存机制(clsYoungTAppraisedCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsYoungTAppraisedCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsYoungTAppraisedCaseTypeWApi没有刷新缓存机制(clsYoungTAppraisedCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeWApi没有刷新缓存机制(clsRsStaffTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeWApi没有刷新缓存机制(clsRsProfGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeWApi没有刷新缓存机制(clsRsDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceWApi没有刷新缓存机制(clsRsProvinceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionWApi没有刷新缓存机制(clsRsReligionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifWApi没有刷新缓存机制(clsRsQualifWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeWApi没有刷新缓存机制(clsRsAdminGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_YoungTAppraisedCase");
//if (arrvYoungTAppraisedCase_SimObjLst_Cache == null)
//{
//arrvYoungTAppraisedCase_SimObjLst_Cache = await clsvYoungTAppraisedCase_SimWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvYoungTAppraisedCase_SimEN._CurrTabName_S);
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
public static List<clsvYoungTAppraisedCase_SimEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvYoungTAppraisedCase_SimEN._CurrTabName_S);
List<clsvYoungTAppraisedCase_SimEN> arrvYoungTAppraisedCase_SimObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvYoungTAppraisedCase_SimObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvYoungTAppraisedCase_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.EntryDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.EntryYear, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Sim.IsUse, Type.GetType("System.Boolean"));
foreach (clsvYoungTAppraisedCase_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase] = objInFor[convYoungTAppraisedCase_Sim.id_YoungTAppraisedCase];
objDR[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID] = objInFor[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID];
objDR[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName] = objInFor[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName];
objDR[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText] = objInFor[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText];
objDR[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate] = objInFor[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate];
objDR[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime] = objInFor[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime];
objDR[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme] = objInFor[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme];
objDR[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn] = objInFor[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn];
objDR[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn] = objInFor[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn];
objDR[convYoungTAppraisedCase_Sim.id_StudyLevel] = objInFor[convYoungTAppraisedCase_Sim.id_StudyLevel];
objDR[convYoungTAppraisedCase_Sim.StudyLevelName] = objInFor[convYoungTAppraisedCase_Sim.StudyLevelName];
objDR[convYoungTAppraisedCase_Sim.id_TeachingPlan] = objInFor[convYoungTAppraisedCase_Sim.id_TeachingPlan];
objDR[convYoungTAppraisedCase_Sim.Id_CaseType] = objInFor[convYoungTAppraisedCase_Sim.Id_CaseType];
objDR[convYoungTAppraisedCase_Sim.id_Discipline] = objInFor[convYoungTAppraisedCase_Sim.id_Discipline];
objDR[convYoungTAppraisedCase_Sim.DisciplineID] = objInFor[convYoungTAppraisedCase_Sim.DisciplineID];
objDR[convYoungTAppraisedCase_Sim.DisciplineName] = objInFor[convYoungTAppraisedCase_Sim.DisciplineName];
objDR[convYoungTAppraisedCase_Sim.BrowseCount] = objInFor[convYoungTAppraisedCase_Sim.BrowseCount];
objDR[convYoungTAppraisedCase_Sim.id_SenateGaugeVersion] = objInFor[convYoungTAppraisedCase_Sim.id_SenateGaugeVersion];
objDR[convYoungTAppraisedCase_Sim.senateGaugeVersionID] = objInFor[convYoungTAppraisedCase_Sim.senateGaugeVersionID];
objDR[convYoungTAppraisedCase_Sim.senateGaugeVersionName] = objInFor[convYoungTAppraisedCase_Sim.senateGaugeVersionName];
objDR[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore] = objInFor[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore];
objDR[convYoungTAppraisedCase_Sim.VersionNo] = objInFor[convYoungTAppraisedCase_Sim.VersionNo];
objDR[convYoungTAppraisedCase_Sim.id_TeachSkill] = objInFor[convYoungTAppraisedCase_Sim.id_TeachSkill];
objDR[convYoungTAppraisedCase_Sim.TeachSkillID] = objInFor[convYoungTAppraisedCase_Sim.TeachSkillID];
objDR[convYoungTAppraisedCase_Sim.SkillTypeName] = objInFor[convYoungTAppraisedCase_Sim.SkillTypeName];
objDR[convYoungTAppraisedCase_Sim.TeachSkillName] = objInFor[convYoungTAppraisedCase_Sim.TeachSkillName];
objDR[convYoungTAppraisedCase_Sim.TeachSkillTheory] = objInFor[convYoungTAppraisedCase_Sim.TeachSkillTheory];
objDR[convYoungTAppraisedCase_Sim.TeachSkillOperMethod] = objInFor[convYoungTAppraisedCase_Sim.TeachSkillOperMethod];
objDR[convYoungTAppraisedCase_Sim.id_SkillType] = objInFor[convYoungTAppraisedCase_Sim.id_SkillType];
objDR[convYoungTAppraisedCase_Sim.SkillTypeID] = objInFor[convYoungTAppraisedCase_Sim.SkillTypeID];
objDR[convYoungTAppraisedCase_Sim.CaseLevelId] = objInFor[convYoungTAppraisedCase_Sim.CaseLevelId];
objDR[convYoungTAppraisedCase_Sim.DocFile] = objInFor[convYoungTAppraisedCase_Sim.DocFile];
objDR[convYoungTAppraisedCase_Sim.IsNeedGeneWord] = objInFor[convYoungTAppraisedCase_Sim.IsNeedGeneWord];
objDR[convYoungTAppraisedCase_Sim.WordCreateDate] = objInFor[convYoungTAppraisedCase_Sim.WordCreateDate];
objDR[convYoungTAppraisedCase_Sim.IsVisible] = objInFor[convYoungTAppraisedCase_Sim.IsVisible];
objDR[convYoungTAppraisedCase_Sim.OwnerId] = objInFor[convYoungTAppraisedCase_Sim.OwnerId];
objDR[convYoungTAppraisedCase_Sim.TeacherID] = objInFor[convYoungTAppraisedCase_Sim.TeacherID];
objDR[convYoungTAppraisedCase_Sim.TeacherName] = objInFor[convYoungTAppraisedCase_Sim.TeacherName];
objDR[convYoungTAppraisedCase_Sim.id_XzCollege] = objInFor[convYoungTAppraisedCase_Sim.id_XzCollege];
objDR[convYoungTAppraisedCase_Sim.CollegeName] = objInFor[convYoungTAppraisedCase_Sim.CollegeName];
objDR[convYoungTAppraisedCase_Sim.EntryDate] = objInFor[convYoungTAppraisedCase_Sim.EntryDate];
objDR[convYoungTAppraisedCase_Sim.CollegeID] = objInFor[convYoungTAppraisedCase_Sim.CollegeID];
objDR[convYoungTAppraisedCase_Sim.EntryYear] = objInFor[convYoungTAppraisedCase_Sim.EntryYear];
objDR[convYoungTAppraisedCase_Sim.CollegeNameA] = objInFor[convYoungTAppraisedCase_Sim.CollegeNameA];
objDR[convYoungTAppraisedCase_Sim.IsDualVideo] = objInFor[convYoungTAppraisedCase_Sim.IsDualVideo];
objDR[convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType] = objInFor[convYoungTAppraisedCase_Sim.id_YoungTAppraisedCaseType];
objDR[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName] = objInFor[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName];
objDR[convYoungTAppraisedCase_Sim.UserTypeId] = objInFor[convYoungTAppraisedCase_Sim.UserTypeId];
objDR[convYoungTAppraisedCase_Sim.UserTypeName] = objInFor[convYoungTAppraisedCase_Sim.UserTypeName];
objDR[convYoungTAppraisedCase_Sim.RecommendedDegreeId] = objInFor[convYoungTAppraisedCase_Sim.RecommendedDegreeId];
objDR[convYoungTAppraisedCase_Sim.RecommendedDegreeName] = objInFor[convYoungTAppraisedCase_Sim.RecommendedDegreeName];
objDR[convYoungTAppraisedCase_Sim.Memo] = objInFor[convYoungTAppraisedCase_Sim.Memo];
objDR[convYoungTAppraisedCase_Sim.IsUse] = objInFor[convYoungTAppraisedCase_Sim.IsUse];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}