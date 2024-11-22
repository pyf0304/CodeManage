
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClsRmTeachingCaseWApi
 表名:ClsRmTeachingCase(01120381)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:52
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学
 模块英文名:ClsRmTeaching
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
public static class clsClsRmTeachingCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetId_ClsRmTeachingCase(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strId_ClsRmTeachingCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_ClsRmTeachingCase, 8, conClsRmTeachingCase.Id_ClsRmTeachingCase);
clsCheckSql.CheckFieldForeignKey(strId_ClsRmTeachingCase, 8, conClsRmTeachingCase.Id_ClsRmTeachingCase);
objClsRmTeachingCaseEN.Id_ClsRmTeachingCase = strId_ClsRmTeachingCase; //课堂教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.Id_ClsRmTeachingCase) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.Id_ClsRmTeachingCase, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.Id_ClsRmTeachingCase] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetClsRmTeachingCaseID(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strClsRmTeachingCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsRmTeachingCaseID, conClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseID, 8, conClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseID, 8, conClsRmTeachingCase.ClsRmTeachingCaseID);
objClsRmTeachingCaseEN.ClsRmTeachingCaseID = strClsRmTeachingCaseID; //课堂教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.ClsRmTeachingCaseID) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.ClsRmTeachingCaseID, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseID] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetClsRmTeachingCaseName(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strClsRmTeachingCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsRmTeachingCaseName, conClsRmTeachingCase.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseName, 100, conClsRmTeachingCase.ClsRmTeachingCaseName);
objClsRmTeachingCaseEN.ClsRmTeachingCaseName = strClsRmTeachingCaseName; //课堂教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.ClsRmTeachingCaseName) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.ClsRmTeachingCaseName, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseName] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetClsRmTeachingCaseTheme(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strClsRmTeachingCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTheme, 200, conClsRmTeachingCase.ClsRmTeachingCaseTheme);
objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = strClsRmTeachingCaseTheme; //课堂教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.ClsRmTeachingCaseTheme) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.ClsRmTeachingCaseTheme, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseTheme] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN Setid_ClsRmTeachingCaseType(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strid_ClsRmTeachingCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ClsRmTeachingCaseType, conClsRmTeachingCase.id_ClsRmTeachingCaseType);
clsCheckSql.CheckFieldLen(strid_ClsRmTeachingCaseType, 4, conClsRmTeachingCase.id_ClsRmTeachingCaseType);
clsCheckSql.CheckFieldForeignKey(strid_ClsRmTeachingCaseType, 4, conClsRmTeachingCase.id_ClsRmTeachingCaseType);
objClsRmTeachingCaseEN.id_ClsRmTeachingCaseType = strid_ClsRmTeachingCaseType; //课堂案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.id_ClsRmTeachingCaseType) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.id_ClsRmTeachingCaseType, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.id_ClsRmTeachingCaseType] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetClsRmTeachingCaseText(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strClsRmTeachingCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseText, 8000, conClsRmTeachingCase.ClsRmTeachingCaseText);
objClsRmTeachingCaseEN.ClsRmTeachingCaseText = strClsRmTeachingCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.ClsRmTeachingCaseText) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.ClsRmTeachingCaseText, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseText] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetClsRmTeachingCaseDate(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strClsRmTeachingCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDate, 8, conClsRmTeachingCase.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDate, 8, conClsRmTeachingCase.ClsRmTeachingCaseDate);
objClsRmTeachingCaseEN.ClsRmTeachingCaseDate = strClsRmTeachingCaseDate; //课堂教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.ClsRmTeachingCaseDate) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.ClsRmTeachingCaseDate, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseDate] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetClsRmTeachingCaseTime(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strClsRmTeachingCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTime, 6, conClsRmTeachingCase.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTime, 6, conClsRmTeachingCase.ClsRmTeachingCaseTime);
objClsRmTeachingCaseEN.ClsRmTeachingCaseTime = strClsRmTeachingCaseTime; //课堂教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.ClsRmTeachingCaseTime) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.ClsRmTeachingCaseTime, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseTime] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetClsRmTeachingCaseDateIn(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strClsRmTeachingCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDateIn, 8, conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDateIn, 8, conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = strClsRmTeachingCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.ClsRmTeachingCaseDateIn) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.ClsRmTeachingCaseDateIn, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetClsRmTeachingCaseTimeIn(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strClsRmTeachingCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTimeIn, 6, conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTimeIn, 6, conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = strClsRmTeachingCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN Setid_StudyLevel(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conClsRmTeachingCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conClsRmTeachingCase.id_StudyLevel);
objClsRmTeachingCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.id_StudyLevel) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.id_StudyLevel, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.id_StudyLevel] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN Setid_TeachingPlan(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conClsRmTeachingCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conClsRmTeachingCase.id_TeachingPlan);
objClsRmTeachingCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.id_TeachingPlan) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.id_TeachingPlan, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.id_TeachingPlan] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetId_CaseType(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, conClsRmTeachingCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, conClsRmTeachingCase.Id_CaseType);
objClsRmTeachingCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.Id_CaseType) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.Id_CaseType, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.Id_CaseType] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN Setid_Discipline(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, conClsRmTeachingCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conClsRmTeachingCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conClsRmTeachingCase.id_Discipline);
objClsRmTeachingCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.id_Discipline) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.id_Discipline, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.id_Discipline] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN Setid_School_Ps(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strid_School_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School_Ps, 4, conClsRmTeachingCase.id_School_Ps);
clsCheckSql.CheckFieldForeignKey(strid_School_Ps, 4, conClsRmTeachingCase.id_School_Ps);
objClsRmTeachingCaseEN.id_School_Ps = strid_School_Ps; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.id_School_Ps) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.id_School_Ps, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.id_School_Ps] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN Setid_Discipline_Ps(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strid_Discipline_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline_Ps, 4, conClsRmTeachingCase.id_Discipline_Ps);
clsCheckSql.CheckFieldForeignKey(strid_Discipline_Ps, 4, conClsRmTeachingCase.id_Discipline_Ps);
objClsRmTeachingCaseEN.id_Discipline_Ps = strid_Discipline_Ps; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.id_Discipline_Ps) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.id_Discipline_Ps, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.id_Discipline_Ps] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN Setid_GradeBase(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, conClsRmTeachingCase.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, conClsRmTeachingCase.id_GradeBase);
objClsRmTeachingCaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.id_GradeBase) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.id_GradeBase, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.id_GradeBase] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetBrowseCount(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objClsRmTeachingCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.BrowseCount) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.BrowseCount, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.BrowseCount] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN Setid_SenateGaugeVersion(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conClsRmTeachingCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conClsRmTeachingCase.id_SenateGaugeVersion);
objClsRmTeachingCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.id_SenateGaugeVersion) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN Setid_TeachSkill(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, conClsRmTeachingCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conClsRmTeachingCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conClsRmTeachingCase.id_TeachSkill);
objClsRmTeachingCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.id_TeachSkill) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.id_TeachSkill, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.id_TeachSkill] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetCaseLevelId(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conClsRmTeachingCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conClsRmTeachingCase.CaseLevelId);
objClsRmTeachingCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.CaseLevelId) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.CaseLevelId, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.CaseLevelId] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetDocFile(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conClsRmTeachingCase.DocFile);
objClsRmTeachingCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.DocFile) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.DocFile, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.DocFile] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetIsNeedGeneWord(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objClsRmTeachingCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.IsNeedGeneWord) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetWordCreateDate(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conClsRmTeachingCase.WordCreateDate);
objClsRmTeachingCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.WordCreateDate) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.WordCreateDate, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.WordCreateDate] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetIsVisible(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objClsRmTeachingCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.IsVisible) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.IsVisible, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.IsVisible] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetOwnerId(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conClsRmTeachingCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conClsRmTeachingCase.OwnerId);
objClsRmTeachingCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.OwnerId) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.OwnerId, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.OwnerId] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetUserKindId(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, conClsRmTeachingCase.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, conClsRmTeachingCase.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, conClsRmTeachingCase.UserKindId);
objClsRmTeachingCaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.UserKindId) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.UserKindId, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.UserKindId] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetUserTypeId(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conClsRmTeachingCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conClsRmTeachingCase.UserTypeId);
objClsRmTeachingCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.UserTypeId) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.UserTypeId, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.UserTypeId] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetIsDualVideo(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objClsRmTeachingCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.IsDualVideo) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.IsDualVideo, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.IsDualVideo] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetRecommendedDegreeId(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conClsRmTeachingCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conClsRmTeachingCase.RecommendedDegreeId);
objClsRmTeachingCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.RecommendedDegreeId) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetftpFileType(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conClsRmTeachingCase.ftpFileType);
objClsRmTeachingCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.ftpFileType) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.ftpFileType, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.ftpFileType] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetVideoUrl(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conClsRmTeachingCase.VideoUrl);
objClsRmTeachingCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.VideoUrl) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.VideoUrl, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.VideoUrl] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetVideoPath(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conClsRmTeachingCase.VideoPath);
objClsRmTeachingCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.VideoPath) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.VideoPath, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.VideoPath] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetResErrMsg(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conClsRmTeachingCase.ResErrMsg);
objClsRmTeachingCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.ResErrMsg) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.ResErrMsg, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.ResErrMsg] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetUpdDate(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conClsRmTeachingCase.UpdDate);
objClsRmTeachingCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.UpdDate) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.UpdDate, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.UpdDate] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetUpdUserId(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conClsRmTeachingCase.UpdUserId);
objClsRmTeachingCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.UpdUserId) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.UpdUserId, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.UpdUserId] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClsRmTeachingCaseEN SetMemo(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conClsRmTeachingCase.Memo);
objClsRmTeachingCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(conClsRmTeachingCase.Memo) == false)
{
objClsRmTeachingCaseEN.dicFldComparisonOp.Add(conClsRmTeachingCase.Memo, strComparisonOp);
}
else
{
objClsRmTeachingCaseEN.dicFldComparisonOp[conClsRmTeachingCase.Memo] = strComparisonOp;
}
}
return objClsRmTeachingCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsClsRmTeachingCaseEN objClsRmTeachingCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.Id_ClsRmTeachingCase) == true)
{
string strComparisonOp_Id_ClsRmTeachingCase = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.Id_ClsRmTeachingCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.Id_ClsRmTeachingCase, objClsRmTeachingCase_Cond.Id_ClsRmTeachingCase, strComparisonOp_Id_ClsRmTeachingCase);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseID) == true)
{
string strComparisonOp_ClsRmTeachingCaseID = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.ClsRmTeachingCaseID, objClsRmTeachingCase_Cond.ClsRmTeachingCaseID, strComparisonOp_ClsRmTeachingCaseID);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseName) == true)
{
string strComparisonOp_ClsRmTeachingCaseName = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.ClsRmTeachingCaseName, objClsRmTeachingCase_Cond.ClsRmTeachingCaseName, strComparisonOp_ClsRmTeachingCaseName);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTheme) == true)
{
string strComparisonOp_ClsRmTeachingCaseTheme = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.ClsRmTeachingCaseTheme, objClsRmTeachingCase_Cond.ClsRmTeachingCaseTheme, strComparisonOp_ClsRmTeachingCaseTheme);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.id_ClsRmTeachingCaseType) == true)
{
string strComparisonOp_id_ClsRmTeachingCaseType = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.id_ClsRmTeachingCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.id_ClsRmTeachingCaseType, objClsRmTeachingCase_Cond.id_ClsRmTeachingCaseType, strComparisonOp_id_ClsRmTeachingCaseType);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseText) == true)
{
string strComparisonOp_ClsRmTeachingCaseText = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.ClsRmTeachingCaseText, objClsRmTeachingCase_Cond.ClsRmTeachingCaseText, strComparisonOp_ClsRmTeachingCaseText);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDate) == true)
{
string strComparisonOp_ClsRmTeachingCaseDate = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.ClsRmTeachingCaseDate, objClsRmTeachingCase_Cond.ClsRmTeachingCaseDate, strComparisonOp_ClsRmTeachingCaseDate);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTime) == true)
{
string strComparisonOp_ClsRmTeachingCaseTime = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.ClsRmTeachingCaseTime, objClsRmTeachingCase_Cond.ClsRmTeachingCaseTime, strComparisonOp_ClsRmTeachingCaseTime);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDateIn) == true)
{
string strComparisonOp_ClsRmTeachingCaseDateIn = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.ClsRmTeachingCaseDateIn, objClsRmTeachingCase_Cond.ClsRmTeachingCaseDateIn, strComparisonOp_ClsRmTeachingCaseDateIn);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn) == true)
{
string strComparisonOp_ClsRmTeachingCaseTimeIn = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.ClsRmTeachingCaseTimeIn, objClsRmTeachingCase_Cond.ClsRmTeachingCaseTimeIn, strComparisonOp_ClsRmTeachingCaseTimeIn);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.id_StudyLevel, objClsRmTeachingCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.id_TeachingPlan, objClsRmTeachingCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.Id_CaseType, objClsRmTeachingCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.id_Discipline, objClsRmTeachingCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.id_School_Ps) == true)
{
string strComparisonOp_id_School_Ps = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.id_School_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.id_School_Ps, objClsRmTeachingCase_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.id_Discipline_Ps) == true)
{
string strComparisonOp_id_Discipline_Ps = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.id_Discipline_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.id_Discipline_Ps, objClsRmTeachingCase_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.id_GradeBase, objClsRmTeachingCase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conClsRmTeachingCase.BrowseCount, objClsRmTeachingCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.id_SenateGaugeVersion, objClsRmTeachingCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.id_TeachSkill, objClsRmTeachingCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.CaseLevelId, objClsRmTeachingCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.DocFile) == true)
{
string strComparisonOp_DocFile = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.DocFile, objClsRmTeachingCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.IsNeedGeneWord) == true)
{
if (objClsRmTeachingCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conClsRmTeachingCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conClsRmTeachingCase.IsNeedGeneWord);
}
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.WordCreateDate, objClsRmTeachingCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.IsVisible) == true)
{
if (objClsRmTeachingCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conClsRmTeachingCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conClsRmTeachingCase.IsVisible);
}
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.OwnerId, objClsRmTeachingCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.UserKindId) == true)
{
string strComparisonOp_UserKindId = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.UserKindId, objClsRmTeachingCase_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.UserTypeId, objClsRmTeachingCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.IsDualVideo) == true)
{
if (objClsRmTeachingCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conClsRmTeachingCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conClsRmTeachingCase.IsDualVideo);
}
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.RecommendedDegreeId, objClsRmTeachingCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.ftpFileType, objClsRmTeachingCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.VideoUrl, objClsRmTeachingCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.VideoPath, objClsRmTeachingCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.ResErrMsg, objClsRmTeachingCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.UpdDate, objClsRmTeachingCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.UpdUserId, objClsRmTeachingCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objClsRmTeachingCase_Cond.IsUpdated(conClsRmTeachingCase.Memo) == true)
{
string strComparisonOp_Memo = objClsRmTeachingCase_Cond.dicFldComparisonOp[conClsRmTeachingCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClsRmTeachingCase.Memo, objClsRmTeachingCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
 if (string.IsNullOrEmpty(objClsRmTeachingCaseEN.Id_ClsRmTeachingCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objClsRmTeachingCaseEN.sf_UpdFldSetStr = objClsRmTeachingCaseEN.getsf_UpdFldSetStr();
clsClsRmTeachingCaseWApi.CheckPropertyNew(objClsRmTeachingCaseEN); 
bool bolResult = clsClsRmTeachingCaseWApi.UpdateRecord(objClsRmTeachingCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClsRmTeachingCaseWApi.ReFreshCache();
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
 /// <param name = "objClsRmTeachingCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
 if (string.IsNullOrEmpty(objClsRmTeachingCaseEN.Id_ClsRmTeachingCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsClsRmTeachingCaseWApi.IsExist(objClsRmTeachingCaseEN.Id_ClsRmTeachingCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objClsRmTeachingCaseEN.Id_ClsRmTeachingCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsClsRmTeachingCaseWApi.CheckPropertyNew(objClsRmTeachingCaseEN); 
bool bolResult = clsClsRmTeachingCaseWApi.AddNewRecord(objClsRmTeachingCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClsRmTeachingCaseWApi.ReFreshCache();
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
 /// <param name = "objClsRmTeachingCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
try
{
clsClsRmTeachingCaseWApi.CheckPropertyNew(objClsRmTeachingCaseEN); 
string strId_ClsRmTeachingCase = clsClsRmTeachingCaseWApi.AddNewRecordWithMaxId(objClsRmTeachingCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClsRmTeachingCaseWApi.ReFreshCache();
return strId_ClsRmTeachingCase;
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
 /// <param name = "objClsRmTeachingCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strWhereCond)
{
try
{
clsClsRmTeachingCaseWApi.CheckPropertyNew(objClsRmTeachingCaseEN); 
bool bolResult = clsClsRmTeachingCaseWApi.UpdateWithCondition(objClsRmTeachingCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClsRmTeachingCaseWApi.ReFreshCache();
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
 /// 课堂教学案例(ClsRmTeachingCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsClsRmTeachingCaseWApi
{
private static readonly string mstrApiControllerName = "ClsRmTeachingCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsClsRmTeachingCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_Id_ClsRmTeachingCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课堂教学案例]...","0");
List<clsClsRmTeachingCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="Id_ClsRmTeachingCase";
objDDL.DataTextField="ClsRmTeachingCaseName";
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
public static void BindCbo_Id_ClsRmTeachingCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conClsRmTeachingCase.Id_ClsRmTeachingCase); 
List<clsClsRmTeachingCaseEN> arrObjLst = clsClsRmTeachingCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = new clsClsRmTeachingCaseEN()
{
Id_ClsRmTeachingCase = "0",
ClsRmTeachingCaseName = "选[课堂教学案例]..."
};
arrObjLst.Insert(0, objClsRmTeachingCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conClsRmTeachingCase.Id_ClsRmTeachingCase;
objComboBox.DisplayMember = conClsRmTeachingCase.ClsRmTeachingCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
if (!Object.Equals(null, objClsRmTeachingCaseEN.Id_ClsRmTeachingCase) && GetStrLen(objClsRmTeachingCaseEN.Id_ClsRmTeachingCase) > 8)
{
 throw new Exception("字段[课堂教学案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.ClsRmTeachingCaseID) && GetStrLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseID) > 8)
{
 throw new Exception("字段[课堂教学案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.ClsRmTeachingCaseName) && GetStrLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseName) > 100)
{
 throw new Exception("字段[课堂教学案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme) && GetStrLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme) > 200)
{
 throw new Exception("字段[课堂教学案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.id_ClsRmTeachingCaseType) && GetStrLen(objClsRmTeachingCaseEN.id_ClsRmTeachingCaseType) > 4)
{
 throw new Exception("字段[课堂案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.ClsRmTeachingCaseText) && GetStrLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseText) > 8000)
{
 throw new Exception("字段[案例文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.ClsRmTeachingCaseDate) && GetStrLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseDate) > 8)
{
 throw new Exception("字段[课堂教学日期]的长度不能超过8!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.ClsRmTeachingCaseTime) && GetStrLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTime) > 6)
{
 throw new Exception("字段[课堂教学时间]的长度不能超过6!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn) && GetStrLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn) && GetStrLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.id_StudyLevel) && GetStrLen(objClsRmTeachingCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.id_TeachingPlan) && GetStrLen(objClsRmTeachingCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.Id_CaseType) && GetStrLen(objClsRmTeachingCaseEN.Id_CaseType) > 4)
{
 throw new Exception("字段[案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.id_Discipline) && GetStrLen(objClsRmTeachingCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.id_School_Ps) && GetStrLen(objClsRmTeachingCaseEN.id_School_Ps) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.id_Discipline_Ps) && GetStrLen(objClsRmTeachingCaseEN.id_Discipline_Ps) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.id_GradeBase) && GetStrLen(objClsRmTeachingCaseEN.id_GradeBase) > 4)
{
 throw new Exception("字段[年级流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.id_SenateGaugeVersion) && GetStrLen(objClsRmTeachingCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.id_TeachSkill) && GetStrLen(objClsRmTeachingCaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.CaseLevelId) && GetStrLen(objClsRmTeachingCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.DocFile) && GetStrLen(objClsRmTeachingCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.WordCreateDate) && GetStrLen(objClsRmTeachingCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.OwnerId) && GetStrLen(objClsRmTeachingCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.UserKindId) && GetStrLen(objClsRmTeachingCaseEN.UserKindId) > 2)
{
 throw new Exception("字段[用户类别Id]的长度不能超过2!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.UserTypeId) && GetStrLen(objClsRmTeachingCaseEN.UserTypeId) > 2)
{
 throw new Exception("字段[用户类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.RecommendedDegreeId) && GetStrLen(objClsRmTeachingCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.ftpFileType) && GetStrLen(objClsRmTeachingCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.VideoUrl) && GetStrLen(objClsRmTeachingCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.VideoPath) && GetStrLen(objClsRmTeachingCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.ResErrMsg) && GetStrLen(objClsRmTeachingCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.UpdDate) && GetStrLen(objClsRmTeachingCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.UpdUserId) && GetStrLen(objClsRmTeachingCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objClsRmTeachingCaseEN.Memo) && GetStrLen(objClsRmTeachingCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objClsRmTeachingCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_ClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsClsRmTeachingCaseEN GetObjById_ClsRmTeachingCase(string strId_ClsRmTeachingCase)
{
string strAction = "GetObjById_ClsRmTeachingCase";
string strErrMsg = string.Empty;
string strResult = "";
clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ClsRmTeachingCase"] = strId_ClsRmTeachingCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objClsRmTeachingCaseEN = JsonConvert.DeserializeObject<clsClsRmTeachingCaseEN>((string)jobjReturn["ReturnObj"]);
return objClsRmTeachingCaseEN;
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
 /// <param name = "strId_ClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsClsRmTeachingCaseEN GetObjById_ClsRmTeachingCase_WA_Cache(string strId_ClsRmTeachingCase)
{
string strAction = "GetObjById_ClsRmTeachingCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ClsRmTeachingCase"] = strId_ClsRmTeachingCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objClsRmTeachingCaseEN = JsonConvert.DeserializeObject<clsClsRmTeachingCaseEN>((string)jobjReturn["ReturnObj"]);
return objClsRmTeachingCaseEN;
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
public static clsClsRmTeachingCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = null;
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
objClsRmTeachingCaseEN = JsonConvert.DeserializeObject<clsClsRmTeachingCaseEN>((string)jobjReturn["ReturnObj"]);
return objClsRmTeachingCaseEN;
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
 /// <param name = "strId_ClsRmTeachingCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsClsRmTeachingCaseEN GetObjById_ClsRmTeachingCase_Cache(string strId_ClsRmTeachingCase)
{
if (string.IsNullOrEmpty(strId_ClsRmTeachingCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsClsRmTeachingCaseEN._CurrTabName_S);
List<clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Sel =
from objClsRmTeachingCaseEN in arrClsRmTeachingCaseObjLst_Cache
where objClsRmTeachingCaseEN.Id_ClsRmTeachingCase == strId_ClsRmTeachingCase
select objClsRmTeachingCaseEN;
if (arrClsRmTeachingCaseObjLst_Sel.Count() == 0)
{
   clsClsRmTeachingCaseEN obj = clsClsRmTeachingCaseWApi.GetObjById_ClsRmTeachingCase(strId_ClsRmTeachingCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrClsRmTeachingCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_ClsRmTeachingCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetClsRmTeachingCaseNameById_ClsRmTeachingCase_Cache(string strId_ClsRmTeachingCase)
{
if (string.IsNullOrEmpty(strId_ClsRmTeachingCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsClsRmTeachingCaseEN._CurrTabName_S);
List<clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Sel1 =
from objClsRmTeachingCaseEN in arrClsRmTeachingCaseObjLst_Cache
where objClsRmTeachingCaseEN.Id_ClsRmTeachingCase == strId_ClsRmTeachingCase
select objClsRmTeachingCaseEN;
List <clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Sel = new List<clsClsRmTeachingCaseEN>();
foreach (clsClsRmTeachingCaseEN obj in arrClsRmTeachingCaseObjLst_Sel1)
{
arrClsRmTeachingCaseObjLst_Sel.Add(obj);
}
if (arrClsRmTeachingCaseObjLst_Sel.Count > 0)
{
return arrClsRmTeachingCaseObjLst_Sel[0].ClsRmTeachingCaseName;
}
string strErrMsgForGetObjById = string.Format("在ClsRmTeachingCase对象缓存列表中,找不到记录[Id_ClsRmTeachingCase = {0}](函数:{1})", strId_ClsRmTeachingCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsClsRmTeachingCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_ClsRmTeachingCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameById_ClsRmTeachingCase_Cache(string strId_ClsRmTeachingCase)
{
if (string.IsNullOrEmpty(strId_ClsRmTeachingCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsClsRmTeachingCaseEN._CurrTabName_S);
List<clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Sel1 =
from objClsRmTeachingCaseEN in arrClsRmTeachingCaseObjLst_Cache
where objClsRmTeachingCaseEN.Id_ClsRmTeachingCase == strId_ClsRmTeachingCase
select objClsRmTeachingCaseEN;
List <clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Sel = new List<clsClsRmTeachingCaseEN>();
foreach (clsClsRmTeachingCaseEN obj in arrClsRmTeachingCaseObjLst_Sel1)
{
arrClsRmTeachingCaseObjLst_Sel.Add(obj);
}
if (arrClsRmTeachingCaseObjLst_Sel.Count > 0)
{
return arrClsRmTeachingCaseObjLst_Sel[0].ClsRmTeachingCaseName;
}
string strErrMsgForGetObjById = string.Format("在ClsRmTeachingCase对象缓存列表中,找不到记录的相关名称[Id_ClsRmTeachingCase = {0}](函数:{1})", strId_ClsRmTeachingCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsClsRmTeachingCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsClsRmTeachingCaseEN> GetObjLst(string strWhereCond)
{
 List<clsClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClsRmTeachingCaseEN> GetObjLstById_ClsRmTeachingCaseLst(List<string> arrId_ClsRmTeachingCase)
{
 List<clsClsRmTeachingCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_ClsRmTeachingCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ClsRmTeachingCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_ClsRmTeachingCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsClsRmTeachingCaseEN> GetObjLstById_ClsRmTeachingCaseLst_Cache(List<string> arrId_ClsRmTeachingCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsClsRmTeachingCaseEN._CurrTabName_S);
List<clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Sel =
from objClsRmTeachingCaseEN in arrClsRmTeachingCaseObjLst_Cache
where arrId_ClsRmTeachingCase.Contains(objClsRmTeachingCaseEN.Id_ClsRmTeachingCase)
select objClsRmTeachingCaseEN;
return arrClsRmTeachingCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsClsRmTeachingCaseEN> GetObjLstById_ClsRmTeachingCaseLst_WA_Cache(List<string> arrId_ClsRmTeachingCase)
{
 List<clsClsRmTeachingCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_ClsRmTeachingCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ClsRmTeachingCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClsRmTeachingCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClsRmTeachingCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClsRmTeachingCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClsRmTeachingCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strId_ClsRmTeachingCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = clsClsRmTeachingCaseWApi.GetObjById_ClsRmTeachingCase(strId_ClsRmTeachingCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_ClsRmTeachingCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsClsRmTeachingCaseWApi.ReFreshCache();
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
public static int DelClsRmTeachingCases(List<string> arrId_ClsRmTeachingCase)
{
string strAction = "DelClsRmTeachingCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ClsRmTeachingCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsClsRmTeachingCaseWApi.ReFreshCache();
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
public static int DelClsRmTeachingCasesByCond(string strWhereCond)
{
string strAction = "DelClsRmTeachingCasesByCond";
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
public static bool AddNewRecord(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClsRmTeachingCaseEN>(objClsRmTeachingCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClsRmTeachingCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClsRmTeachingCaseEN>(objClsRmTeachingCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClsRmTeachingCaseWApi.ReFreshCache();
var strId_ClsRmTeachingCase = (string)jobjReturn["ReturnStr"];
return strId_ClsRmTeachingCase;
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
public static bool UpdateRecord(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
if (string.IsNullOrEmpty(objClsRmTeachingCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objClsRmTeachingCaseEN.Id_ClsRmTeachingCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClsRmTeachingCaseEN>(objClsRmTeachingCaseEN);
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
 /// <param name = "objClsRmTeachingCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objClsRmTeachingCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objClsRmTeachingCaseEN.Id_ClsRmTeachingCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objClsRmTeachingCaseEN.Id_ClsRmTeachingCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClsRmTeachingCaseEN>(objClsRmTeachingCaseEN);
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
public static bool IsExist(string strId_ClsRmTeachingCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ClsRmTeachingCase"] = strId_ClsRmTeachingCase
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
 /// <param name = "objClsRmTeachingCaseENS">源对象</param>
 /// <param name = "objClsRmTeachingCaseENT">目标对象</param>
 public static void CopyTo(clsClsRmTeachingCaseEN objClsRmTeachingCaseENS, clsClsRmTeachingCaseEN objClsRmTeachingCaseENT)
{
try
{
objClsRmTeachingCaseENT.Id_ClsRmTeachingCase = objClsRmTeachingCaseENS.Id_ClsRmTeachingCase; //课堂教学案例流水号
objClsRmTeachingCaseENT.ClsRmTeachingCaseID = objClsRmTeachingCaseENS.ClsRmTeachingCaseID; //课堂教学案例ID
objClsRmTeachingCaseENT.ClsRmTeachingCaseName = objClsRmTeachingCaseENS.ClsRmTeachingCaseName; //课堂教学案例名称
objClsRmTeachingCaseENT.ClsRmTeachingCaseTheme = objClsRmTeachingCaseENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objClsRmTeachingCaseENT.id_ClsRmTeachingCaseType = objClsRmTeachingCaseENS.id_ClsRmTeachingCaseType; //课堂案例类型流水号
objClsRmTeachingCaseENT.ClsRmTeachingCaseText = objClsRmTeachingCaseENS.ClsRmTeachingCaseText; //案例文本内容
objClsRmTeachingCaseENT.ClsRmTeachingCaseDate = objClsRmTeachingCaseENS.ClsRmTeachingCaseDate; //课堂教学日期
objClsRmTeachingCaseENT.ClsRmTeachingCaseTime = objClsRmTeachingCaseENS.ClsRmTeachingCaseTime; //课堂教学时间
objClsRmTeachingCaseENT.ClsRmTeachingCaseDateIn = objClsRmTeachingCaseENS.ClsRmTeachingCaseDateIn; //案例入库日期
objClsRmTeachingCaseENT.ClsRmTeachingCaseTimeIn = objClsRmTeachingCaseENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objClsRmTeachingCaseENT.id_StudyLevel = objClsRmTeachingCaseENS.id_StudyLevel; //id_StudyLevel
objClsRmTeachingCaseENT.id_TeachingPlan = objClsRmTeachingCaseENS.id_TeachingPlan; //教案流水号
objClsRmTeachingCaseENT.Id_CaseType = objClsRmTeachingCaseENS.Id_CaseType; //案例类型流水号
objClsRmTeachingCaseENT.id_Discipline = objClsRmTeachingCaseENS.id_Discipline; //学科流水号
objClsRmTeachingCaseENT.id_School_Ps = objClsRmTeachingCaseENS.id_School_Ps; //学校流水号
objClsRmTeachingCaseENT.id_Discipline_Ps = objClsRmTeachingCaseENS.id_Discipline_Ps; //学科流水号
objClsRmTeachingCaseENT.id_GradeBase = objClsRmTeachingCaseENS.id_GradeBase; //年级流水号
objClsRmTeachingCaseENT.BrowseCount = objClsRmTeachingCaseENS.BrowseCount; //浏览次数
objClsRmTeachingCaseENT.id_SenateGaugeVersion = objClsRmTeachingCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objClsRmTeachingCaseENT.id_TeachSkill = objClsRmTeachingCaseENS.id_TeachSkill; //教学技能流水号
objClsRmTeachingCaseENT.CaseLevelId = objClsRmTeachingCaseENS.CaseLevelId; //课例等级Id
objClsRmTeachingCaseENT.DocFile = objClsRmTeachingCaseENS.DocFile; //生成的Word文件名
objClsRmTeachingCaseENT.IsNeedGeneWord = objClsRmTeachingCaseENS.IsNeedGeneWord; //是否需要生成Word
objClsRmTeachingCaseENT.WordCreateDate = objClsRmTeachingCaseENS.WordCreateDate; //Word生成日期
objClsRmTeachingCaseENT.IsVisible = objClsRmTeachingCaseENS.IsVisible; //是否显示
objClsRmTeachingCaseENT.OwnerId = objClsRmTeachingCaseENS.OwnerId; //拥有者Id
objClsRmTeachingCaseENT.UserKindId = objClsRmTeachingCaseENS.UserKindId; //用户类别Id
objClsRmTeachingCaseENT.UserTypeId = objClsRmTeachingCaseENS.UserTypeId; //用户类型Id
objClsRmTeachingCaseENT.IsDualVideo = objClsRmTeachingCaseENS.IsDualVideo; //是否双视频
objClsRmTeachingCaseENT.RecommendedDegreeId = objClsRmTeachingCaseENS.RecommendedDegreeId; //推荐度Id
objClsRmTeachingCaseENT.ftpFileType = objClsRmTeachingCaseENS.ftpFileType; //ftp文件类型
objClsRmTeachingCaseENT.VideoUrl = objClsRmTeachingCaseENS.VideoUrl; //视频Url
objClsRmTeachingCaseENT.VideoPath = objClsRmTeachingCaseENS.VideoPath; //视频目录
objClsRmTeachingCaseENT.ResErrMsg = objClsRmTeachingCaseENS.ResErrMsg; //资源错误信息
objClsRmTeachingCaseENT.UpdDate = objClsRmTeachingCaseENS.UpdDate; //修改日期
objClsRmTeachingCaseENT.UpdUserId = objClsRmTeachingCaseENS.UpdUserId; //修改用户Id
objClsRmTeachingCaseENT.Memo = objClsRmTeachingCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsClsRmTeachingCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsClsRmTeachingCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsClsRmTeachingCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsClsRmTeachingCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsClsRmTeachingCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsClsRmTeachingCaseEN.AttributeName)
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
if (clsClsRmTeachingCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClsRmTeachingCaseWApi没有刷新缓存机制(clsClsRmTeachingCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_ClsRmTeachingCase");
//if (arrClsRmTeachingCaseObjLst_Cache == null)
//{
//arrClsRmTeachingCaseObjLst_Cache = await clsClsRmTeachingCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsClsRmTeachingCaseEN._CurrTabName_S);
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
if (clsClsRmTeachingCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsClsRmTeachingCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsClsRmTeachingCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsClsRmTeachingCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsClsRmTeachingCaseEN._CurrTabName_S);
List<clsClsRmTeachingCaseEN> arrClsRmTeachingCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrClsRmTeachingCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsClsRmTeachingCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conClsRmTeachingCase.Id_ClsRmTeachingCase, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.ClsRmTeachingCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.ClsRmTeachingCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.ClsRmTeachingCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.id_ClsRmTeachingCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.ClsRmTeachingCaseText, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.ClsRmTeachingCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.ClsRmTeachingCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.ClsRmTeachingCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.id_School_Ps, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.id_Discipline_Ps, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conClsRmTeachingCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conClsRmTeachingCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conClsRmTeachingCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conClsRmTeachingCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conClsRmTeachingCase.Memo, Type.GetType("System.String"));
foreach (clsClsRmTeachingCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conClsRmTeachingCase.Id_ClsRmTeachingCase] = objInFor[conClsRmTeachingCase.Id_ClsRmTeachingCase];
objDR[conClsRmTeachingCase.ClsRmTeachingCaseID] = objInFor[conClsRmTeachingCase.ClsRmTeachingCaseID];
objDR[conClsRmTeachingCase.ClsRmTeachingCaseName] = objInFor[conClsRmTeachingCase.ClsRmTeachingCaseName];
objDR[conClsRmTeachingCase.ClsRmTeachingCaseTheme] = objInFor[conClsRmTeachingCase.ClsRmTeachingCaseTheme];
objDR[conClsRmTeachingCase.id_ClsRmTeachingCaseType] = objInFor[conClsRmTeachingCase.id_ClsRmTeachingCaseType];
objDR[conClsRmTeachingCase.ClsRmTeachingCaseText] = objInFor[conClsRmTeachingCase.ClsRmTeachingCaseText];
objDR[conClsRmTeachingCase.ClsRmTeachingCaseDate] = objInFor[conClsRmTeachingCase.ClsRmTeachingCaseDate];
objDR[conClsRmTeachingCase.ClsRmTeachingCaseTime] = objInFor[conClsRmTeachingCase.ClsRmTeachingCaseTime];
objDR[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] = objInFor[conClsRmTeachingCase.ClsRmTeachingCaseDateIn];
objDR[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] = objInFor[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn];
objDR[conClsRmTeachingCase.id_StudyLevel] = objInFor[conClsRmTeachingCase.id_StudyLevel];
objDR[conClsRmTeachingCase.id_TeachingPlan] = objInFor[conClsRmTeachingCase.id_TeachingPlan];
objDR[conClsRmTeachingCase.Id_CaseType] = objInFor[conClsRmTeachingCase.Id_CaseType];
objDR[conClsRmTeachingCase.id_Discipline] = objInFor[conClsRmTeachingCase.id_Discipline];
objDR[conClsRmTeachingCase.id_School_Ps] = objInFor[conClsRmTeachingCase.id_School_Ps];
objDR[conClsRmTeachingCase.id_Discipline_Ps] = objInFor[conClsRmTeachingCase.id_Discipline_Ps];
objDR[conClsRmTeachingCase.id_GradeBase] = objInFor[conClsRmTeachingCase.id_GradeBase];
objDR[conClsRmTeachingCase.BrowseCount] = objInFor[conClsRmTeachingCase.BrowseCount];
objDR[conClsRmTeachingCase.id_SenateGaugeVersion] = objInFor[conClsRmTeachingCase.id_SenateGaugeVersion];
objDR[conClsRmTeachingCase.id_TeachSkill] = objInFor[conClsRmTeachingCase.id_TeachSkill];
objDR[conClsRmTeachingCase.CaseLevelId] = objInFor[conClsRmTeachingCase.CaseLevelId];
objDR[conClsRmTeachingCase.DocFile] = objInFor[conClsRmTeachingCase.DocFile];
objDR[conClsRmTeachingCase.IsNeedGeneWord] = objInFor[conClsRmTeachingCase.IsNeedGeneWord];
objDR[conClsRmTeachingCase.WordCreateDate] = objInFor[conClsRmTeachingCase.WordCreateDate];
objDR[conClsRmTeachingCase.IsVisible] = objInFor[conClsRmTeachingCase.IsVisible];
objDR[conClsRmTeachingCase.OwnerId] = objInFor[conClsRmTeachingCase.OwnerId];
objDR[conClsRmTeachingCase.UserKindId] = objInFor[conClsRmTeachingCase.UserKindId];
objDR[conClsRmTeachingCase.UserTypeId] = objInFor[conClsRmTeachingCase.UserTypeId];
objDR[conClsRmTeachingCase.IsDualVideo] = objInFor[conClsRmTeachingCase.IsDualVideo];
objDR[conClsRmTeachingCase.RecommendedDegreeId] = objInFor[conClsRmTeachingCase.RecommendedDegreeId];
objDR[conClsRmTeachingCase.ftpFileType] = objInFor[conClsRmTeachingCase.ftpFileType];
objDR[conClsRmTeachingCase.VideoUrl] = objInFor[conClsRmTeachingCase.VideoUrl];
objDR[conClsRmTeachingCase.VideoPath] = objInFor[conClsRmTeachingCase.VideoPath];
objDR[conClsRmTeachingCase.ResErrMsg] = objInFor[conClsRmTeachingCase.ResErrMsg];
objDR[conClsRmTeachingCase.UpdDate] = objInFor[conClsRmTeachingCase.UpdDate];
objDR[conClsRmTeachingCase.UpdUserId] = objInFor[conClsRmTeachingCase.UpdUserId];
objDR[conClsRmTeachingCase.Memo] = objInFor[conClsRmTeachingCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 课堂教学案例(ClsRmTeachingCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4ClsRmTeachingCase : clsCommFun4BL
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
clsClsRmTeachingCaseWApi.ReFreshThisCache();
}
}

}