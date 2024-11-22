
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase_BaseWApi
 表名:vCourseLearningCase_Base(01120268)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:02
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvCourseLearningCase_BaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetId_CourseLearningCase(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strId_CourseLearningCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CourseLearningCase, 8, convCourseLearningCase_Base.Id_CourseLearningCase);
clsCheckSql.CheckFieldForeignKey(strId_CourseLearningCase, 8, convCourseLearningCase_Base.Id_CourseLearningCase);
objvCourseLearningCase_BaseEN.Id_CourseLearningCase = strId_CourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.Id_CourseLearningCase) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.Id_CourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.Id_CourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, convCourseLearningCase_Base.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCase_Base.CourseLearningCaseID);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCase_Base.CourseLearningCaseID);
objvCourseLearningCase_BaseEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningCase_Base.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCase_Base.CourseLearningCaseName);
objvCourseLearningCase_BaseEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseText(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseText, 8000, convCourseLearningCase_Base.CourseLearningCaseText);
objvCourseLearningCase_BaseEN.CourseLearningCaseText = strCourseLearningCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseText) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseText, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseText] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseTheme(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningCase_Base.CourseLearningCaseTheme);
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseTheme) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseDate(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningCase_Base.CourseLearningCaseDate);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningCase_Base.CourseLearningCaseDate);
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseDate) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseTime(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningCase_Base.CourseLearningCaseTime);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningCase_Base.CourseLearningCaseTime);
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseTime) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseDateIn(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningCase_Base.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningCase_Base.CourseLearningCaseDateIn);
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseDateIn) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseTimeIn(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningCase_Base.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningCase_Base.CourseLearningCaseTimeIn);
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetId_CaseType(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convCourseLearningCase_Base.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convCourseLearningCase_Base.Id_CaseType);
objvCourseLearningCase_BaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.Id_CaseType) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.Id_CaseType, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.Id_CaseType] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCaseTypeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTypeName, 50, convCourseLearningCase_Base.CaseTypeName);
objvCourseLearningCase_BaseEN.CaseTypeName = strCaseTypeName; //案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CaseTypeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN Setid_CourseLearningCaseType(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strid_CourseLearningCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CourseLearningCaseType, convCourseLearningCase_Base.id_CourseLearningCaseType);
clsCheckSql.CheckFieldLen(strid_CourseLearningCaseType, 4, convCourseLearningCase_Base.id_CourseLearningCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseLearningCaseType, 4, convCourseLearningCase_Base.id_CourseLearningCaseType);
objvCourseLearningCase_BaseEN.id_CourseLearningCaseType = strid_CourseLearningCaseType; //课程学习案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.id_CourseLearningCaseType) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.id_CourseLearningCaseType, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.id_CourseLearningCaseType] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseLearningCaseTypeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningCase_Base.CourseLearningCaseTypeName);
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseLearningCaseTypeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetOwnerId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCourseLearningCase_Base.OwnerId);
objvCourseLearningCase_BaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.OwnerId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.OwnerId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.OwnerId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN Setid_StudyLevel(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCourseLearningCase_Base.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCourseLearningCase_Base.id_StudyLevel);
objvCourseLearningCase_BaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.id_StudyLevel) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.id_StudyLevel, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.id_StudyLevel] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetStudyLevelName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCourseLearningCase_Base.StudyLevelName);
objvCourseLearningCase_BaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.StudyLevelName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.StudyLevelName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.StudyLevelName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN Setid_TeachingPlan(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCourseLearningCase_Base.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCourseLearningCase_Base.id_TeachingPlan);
objvCourseLearningCase_BaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.id_TeachingPlan) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.id_TeachingPlan, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.id_TeachingPlan] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN Setid_Discipline(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convCourseLearningCase_Base.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCourseLearningCase_Base.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCourseLearningCase_Base.id_Discipline);
objvCourseLearningCase_BaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.id_Discipline) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.id_Discipline, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.id_Discipline] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetDisciplineID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCourseLearningCase_Base.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCourseLearningCase_Base.DisciplineID);
objvCourseLearningCase_BaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.DisciplineID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.DisciplineID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.DisciplineID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetDisciplineName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCourseLearningCase_Base.DisciplineName);
objvCourseLearningCase_BaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.DisciplineName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.DisciplineName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.DisciplineName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN Setid_SenateGaugeVersion(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCourseLearningCase_Base.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCourseLearningCase_Base.id_SenateGaugeVersion);
objvCourseLearningCase_BaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.id_SenateGaugeVersion) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetsenateGaugeVersionID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCourseLearningCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCourseLearningCase_Base.senateGaugeVersionID);
objvCourseLearningCase_BaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.senateGaugeVersionID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetsenateGaugeVersionName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCase_Base.senateGaugeVersionName);
objvCourseLearningCase_BaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.senateGaugeVersionName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.senateGaugeVersionTtlScore) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetVersionNo(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int intVersionNo, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.VersionNo) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.VersionNo, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.VersionNo] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN Setid_TeachSkill(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convCourseLearningCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCourseLearningCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCourseLearningCase_Base.id_TeachSkill);
objvCourseLearningCase_BaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.id_TeachSkill) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.id_TeachSkill, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.id_TeachSkill] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetTeachSkillID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCourseLearningCase_Base.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCourseLearningCase_Base.TeachSkillID);
objvCourseLearningCase_BaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.TeachSkillID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.TeachSkillID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetSkillTypeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCourseLearningCase_Base.SkillTypeName);
objvCourseLearningCase_BaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.SkillTypeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.SkillTypeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.SkillTypeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetTeachSkillName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCourseLearningCase_Base.TeachSkillName);
objvCourseLearningCase_BaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.TeachSkillName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.TeachSkillName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetTeachSkillTheory(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCourseLearningCase_Base.TeachSkillTheory);
objvCourseLearningCase_BaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.TeachSkillTheory) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.TeachSkillTheory, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillTheory] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetTeachSkillOperMethod(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCourseLearningCase_Base.TeachSkillOperMethod);
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.TeachSkillOperMethod) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN Setid_SkillType(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convCourseLearningCase_Base.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convCourseLearningCase_Base.id_SkillType);
objvCourseLearningCase_BaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.id_SkillType) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.id_SkillType, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.id_SkillType] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetSkillTypeID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCourseLearningCase_Base.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCourseLearningCase_Base.SkillTypeID);
objvCourseLearningCase_BaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.SkillTypeID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.SkillTypeID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.SkillTypeID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCaseLevelId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCourseLearningCase_Base.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCourseLearningCase_Base.CaseLevelId);
objvCourseLearningCase_BaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CaseLevelId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CaseLevelId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CaseLevelId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCaseLevelName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convCourseLearningCase_Base.CaseLevelName);
objvCourseLearningCase_BaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CaseLevelName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CaseLevelName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CaseLevelName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetDocFile(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCourseLearningCase_Base.DocFile);
objvCourseLearningCase_BaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.DocFile) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.DocFile, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.DocFile] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIsNeedGeneWord(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IsNeedGeneWord) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetWordCreateDate(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCourseLearningCase_Base.WordCreateDate);
objvCourseLearningCase_BaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.WordCreateDate) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.WordCreateDate, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.WordCreateDate] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIsVisible(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IsVisible) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IsVisible, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IsVisible] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIsDualVideo(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IsDualVideo) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IsDualVideo, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IsDualVideo] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN Setid_XzCollege(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCourseLearningCase_Base.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCourseLearningCase_Base.id_XzCollege);
objvCourseLearningCase_BaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.id_XzCollege) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.id_XzCollege, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.id_XzCollege] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCollegeID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningCase_Base.CollegeID);
objvCourseLearningCase_BaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CollegeID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCollegeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCase_Base.CollegeName);
objvCourseLearningCase_BaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CollegeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCollegeNameA(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningCase_Base.CollegeNameA);
objvCourseLearningCase_BaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CollegeNameA) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN Setid_XzMajor(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convCourseLearningCase_Base.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCourseLearningCase_Base.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCourseLearningCase_Base.id_XzMajor);
objvCourseLearningCase_BaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.id_XzMajor) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.id_XzMajor, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.id_XzMajor] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetMajorID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCase_Base.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCase_Base.MajorID);
objvCourseLearningCase_BaseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.MajorID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetMajorName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCase_Base.MajorName);
objvCourseLearningCase_BaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.MajorName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCourseLearningCase_Base.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCase_Base.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCase_Base.CourseId);
objvCourseLearningCase_BaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseCode(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCase_Base.CourseCode);
objvCourseLearningCase_BaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseCode) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCase_Base.CourseName);
objvCourseLearningCase_BaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseChapterId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convCourseLearningCase_Base.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCase_Base.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCase_Base.CourseChapterId);
objvCourseLearningCase_BaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseChapterId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseChapterId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseChapterName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCourseLearningCase_Base.CourseChapterName);
objvCourseLearningCase_BaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseChapterName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseChapterName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetChapterId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convCourseLearningCase_Base.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convCourseLearningCase_Base.ChapterId);
objvCourseLearningCase_BaseEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ChapterId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ChapterId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ChapterId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetParentNodeID(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCourseLearningCase_Base.ParentNodeID);
objvCourseLearningCase_BaseEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ParentNodeID) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ParentNodeID, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeID] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCourseChapterReferred(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convCourseLearningCase_Base.CourseChapterReferred);
objvCourseLearningCase_BaseEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CourseChapterReferred) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CourseChapterReferred, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterReferred] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetChapterName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convCourseLearningCase_Base.ChapterName);
objvCourseLearningCase_BaseEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ChapterName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ChapterName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ChapterName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetChapterName_Sim(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convCourseLearningCase_Base.ChapterName_Sim);
objvCourseLearningCase_BaseEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ChapterName_Sim) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ChapterName_Sim, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ChapterName_Sim] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetSectionName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convCourseLearningCase_Base.SectionName);
objvCourseLearningCase_BaseEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.SectionName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.SectionName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.SectionName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetSectionName_Sim(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convCourseLearningCase_Base.SectionName_Sim);
objvCourseLearningCase_BaseEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.SectionName_Sim) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.SectionName_Sim, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.SectionName_Sim] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetSectionId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convCourseLearningCase_Base.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convCourseLearningCase_Base.SectionId);
objvCourseLearningCase_BaseEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.SectionId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.SectionId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.SectionId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetParentNodeReferred(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convCourseLearningCase_Base.ParentNodeReferred);
objvCourseLearningCase_BaseEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ParentNodeReferred) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ParentNodeReferred, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeReferred] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetParentNodeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCourseLearningCase_Base.ParentNodeName);
objvCourseLearningCase_BaseEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ParentNodeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ParentNodeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetViewCount(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int intViewCount, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ViewCount) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ViewCount, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ViewCount] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIsShow(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IsShow) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IsShow, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IsShow] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetDownloadNumber(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.DownloadNumber) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.DownloadNumber, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.DownloadNumber] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetFileIntegration(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int intFileIntegration, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.FileIntegration) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.FileIntegration, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.FileIntegration] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetLikeCount(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, long lngLikeCount, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.LikeCount) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.LikeCount, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.LikeCount] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetCollectionCount(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.CollectionCount) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.CollectionCount, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.CollectionCount] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetRecommendedDegreeId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCourseLearningCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCourseLearningCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCourseLearningCase_Base.RecommendedDegreeId);
objvCourseLearningCase_BaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.RecommendedDegreeId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetRecommendedDegreeName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCourseLearningCase_Base.RecommendedDegreeName);
objvCourseLearningCase_BaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.RecommendedDegreeName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetftpFileType(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCourseLearningCase_Base.ftpFileType);
objvCourseLearningCase_BaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ftpFileType) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ftpFileType, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ftpFileType] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetVideoUrl(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convCourseLearningCase_Base.VideoUrl);
objvCourseLearningCase_BaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.VideoUrl) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.VideoUrl, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.VideoUrl] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetVideoPath(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convCourseLearningCase_Base.VideoPath);
objvCourseLearningCase_BaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.VideoPath) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.VideoPath, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.VideoPath] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetResErrMsg(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convCourseLearningCase_Base.ResErrMsg);
objvCourseLearningCase_BaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.ResErrMsg) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.ResErrMsg, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.ResErrMsg] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetMemo(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCase_Base.Memo);
objvCourseLearningCase_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.Memo) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.Memo, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.Memo] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetBrowseCount4Case(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.BrowseCount4Case) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetOwnerName(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCourseLearningCase_Base.OwnerName);
objvCourseLearningCase_BaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.OwnerName) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.OwnerName, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.OwnerName] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetOwnerNameWithId(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCourseLearningCase_Base.OwnerNameWithId);
objvCourseLearningCase_BaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.OwnerNameWithId) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.OwnerNameWithId, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.OwnerNameWithId] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetOrderNum(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, int intOrderNum, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.OrderNum) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.OrderNum, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.OrderNum] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase_BaseEN SetIsUse(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN, bool bolIsUse, string strComparisonOp="")
	{
objvCourseLearningCase_BaseEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase_BaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase_Base.IsUse) == false)
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp.Add(convCourseLearningCase_Base.IsUse, strComparisonOp);
}
else
{
objvCourseLearningCase_BaseEN.dicFldComparisonOp[convCourseLearningCase_Base.IsUse] = strComparisonOp;
}
}
return objvCourseLearningCase_BaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCase_BaseEN objvCourseLearningCase_Base_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.Id_CourseLearningCase) == true)
{
string strComparisonOp_Id_CourseLearningCase = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.Id_CourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.Id_CourseLearningCase, objvCourseLearningCase_Base_Cond.Id_CourseLearningCase, strComparisonOp_Id_CourseLearningCase);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseID) == true)
{
string strComparisonOp_CourseLearningCaseID = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseID, objvCourseLearningCase_Base_Cond.CourseLearningCaseID, strComparisonOp_CourseLearningCaseID);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseName, objvCourseLearningCase_Base_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseText) == true)
{
string strComparisonOp_CourseLearningCaseText = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseText, objvCourseLearningCase_Base_Cond.CourseLearningCaseText, strComparisonOp_CourseLearningCaseText);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseTheme) == true)
{
string strComparisonOp_CourseLearningCaseTheme = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseTheme, objvCourseLearningCase_Base_Cond.CourseLearningCaseTheme, strComparisonOp_CourseLearningCaseTheme);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseDate) == true)
{
string strComparisonOp_CourseLearningCaseDate = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseDate, objvCourseLearningCase_Base_Cond.CourseLearningCaseDate, strComparisonOp_CourseLearningCaseDate);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseTime) == true)
{
string strComparisonOp_CourseLearningCaseTime = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseTime, objvCourseLearningCase_Base_Cond.CourseLearningCaseTime, strComparisonOp_CourseLearningCaseTime);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseDateIn) == true)
{
string strComparisonOp_CourseLearningCaseDateIn = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseDateIn, objvCourseLearningCase_Base_Cond.CourseLearningCaseDateIn, strComparisonOp_CourseLearningCaseDateIn);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseTimeIn) == true)
{
string strComparisonOp_CourseLearningCaseTimeIn = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseTimeIn, objvCourseLearningCase_Base_Cond.CourseLearningCaseTimeIn, strComparisonOp_CourseLearningCaseTimeIn);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.Id_CaseType, objvCourseLearningCase_Base_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CaseTypeName) == true)
{
string strComparisonOp_CaseTypeName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CaseTypeName, objvCourseLearningCase_Base_Cond.CaseTypeName, strComparisonOp_CaseTypeName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.id_CourseLearningCaseType) == true)
{
string strComparisonOp_id_CourseLearningCaseType = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.id_CourseLearningCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.id_CourseLearningCaseType, objvCourseLearningCase_Base_Cond.id_CourseLearningCaseType, strComparisonOp_id_CourseLearningCaseType);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseLearningCaseTypeName) == true)
{
string strComparisonOp_CourseLearningCaseTypeName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseLearningCaseTypeName, objvCourseLearningCase_Base_Cond.CourseLearningCaseTypeName, strComparisonOp_CourseLearningCaseTypeName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.OwnerId, objvCourseLearningCase_Base_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.id_StudyLevel, objvCourseLearningCase_Base_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.StudyLevelName, objvCourseLearningCase_Base_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.id_TeachingPlan, objvCourseLearningCase_Base_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.id_Discipline, objvCourseLearningCase_Base_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.DisciplineID, objvCourseLearningCase_Base_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.DisciplineName, objvCourseLearningCase_Base_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.id_SenateGaugeVersion, objvCourseLearningCase_Base_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.senateGaugeVersionID, objvCourseLearningCase_Base_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.senateGaugeVersionName, objvCourseLearningCase_Base_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.senateGaugeVersionTtlScore, objvCourseLearningCase_Base_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.VersionNo, objvCourseLearningCase_Base_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.id_TeachSkill, objvCourseLearningCase_Base_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.TeachSkillID, objvCourseLearningCase_Base_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.SkillTypeName, objvCourseLearningCase_Base_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.TeachSkillName, objvCourseLearningCase_Base_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.TeachSkillTheory, objvCourseLearningCase_Base_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.TeachSkillOperMethod, objvCourseLearningCase_Base_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.id_SkillType, objvCourseLearningCase_Base_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.SkillTypeID, objvCourseLearningCase_Base_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CaseLevelId, objvCourseLearningCase_Base_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CaseLevelName, objvCourseLearningCase_Base_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.DocFile) == true)
{
string strComparisonOp_DocFile = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.DocFile, objvCourseLearningCase_Base_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.IsNeedGeneWord) == true)
{
if (objvCourseLearningCase_Base_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Base.IsNeedGeneWord);
}
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.WordCreateDate, objvCourseLearningCase_Base_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.IsVisible) == true)
{
if (objvCourseLearningCase_Base_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Base.IsVisible);
}
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.IsDualVideo) == true)
{
if (objvCourseLearningCase_Base_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Base.IsDualVideo);
}
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.id_XzCollege, objvCourseLearningCase_Base_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CollegeID, objvCourseLearningCase_Base_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CollegeName, objvCourseLearningCase_Base_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CollegeNameA, objvCourseLearningCase_Base_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.id_XzMajor, objvCourseLearningCase_Base_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.MajorID) == true)
{
string strComparisonOp_MajorID = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.MajorID, objvCourseLearningCase_Base_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.MajorName) == true)
{
string strComparisonOp_MajorName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.MajorName, objvCourseLearningCase_Base_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseId) == true)
{
string strComparisonOp_CourseId = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseId, objvCourseLearningCase_Base_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseCode, objvCourseLearningCase_Base_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseName) == true)
{
string strComparisonOp_CourseName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseName, objvCourseLearningCase_Base_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseChapterId, objvCourseLearningCase_Base_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseChapterName, objvCourseLearningCase_Base_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ChapterId, objvCourseLearningCase_Base_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ParentNodeID, objvCourseLearningCase_Base_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.CourseChapterReferred, objvCourseLearningCase_Base_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ChapterName, objvCourseLearningCase_Base_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ChapterName_Sim, objvCourseLearningCase_Base_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.SectionName) == true)
{
string strComparisonOp_SectionName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.SectionName, objvCourseLearningCase_Base_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.SectionName_Sim, objvCourseLearningCase_Base_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.SectionId) == true)
{
string strComparisonOp_SectionId = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.SectionId, objvCourseLearningCase_Base_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ParentNodeReferred, objvCourseLearningCase_Base_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ParentNodeName, objvCourseLearningCase_Base_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.ViewCount, objvCourseLearningCase_Base_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.IsShow) == true)
{
if (objvCourseLearningCase_Base_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Base.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Base.IsShow);
}
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.DownloadNumber, objvCourseLearningCase_Base_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.FileIntegration, objvCourseLearningCase_Base_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.LikeCount, objvCourseLearningCase_Base_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.CollectionCount, objvCourseLearningCase_Base_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.RecommendedDegreeId, objvCourseLearningCase_Base_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.RecommendedDegreeName, objvCourseLearningCase_Base_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ftpFileType, objvCourseLearningCase_Base_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.VideoUrl, objvCourseLearningCase_Base_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.VideoPath, objvCourseLearningCase_Base_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.ResErrMsg, objvCourseLearningCase_Base_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.Memo) == true)
{
string strComparisonOp_Memo = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.Memo, objvCourseLearningCase_Base_Cond.Memo, strComparisonOp_Memo);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.BrowseCount4Case, objvCourseLearningCase_Base_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.OwnerName, objvCourseLearningCase_Base_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase_Base.OwnerNameWithId, objvCourseLearningCase_Base_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvCourseLearningCase_Base_Cond.dicFldComparisonOp[convCourseLearningCase_Base.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase_Base.OrderNum, objvCourseLearningCase_Base_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvCourseLearningCase_Base_Cond.IsUpdated(convCourseLearningCase_Base.IsUse) == true)
{
if (objvCourseLearningCase_Base_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase_Base.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase_Base.IsUse);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习案例_Base(vCourseLearningCase_Base)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCase_BaseWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningCase_BaseApi";

 public clsvCourseLearningCase_BaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_Id_CourseLearningCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程学习案例_Base]...","0");
List<clsvCourseLearningCase_BaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="Id_CourseLearningCase";
objDDL.DataTextField="CourseLearningCaseName";
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
public static void BindCbo_Id_CourseLearningCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCourseLearningCase_Base.Id_CourseLearningCase); 
List<clsvCourseLearningCase_BaseEN> arrObjLst = clsvCourseLearningCase_BaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN()
{
Id_CourseLearningCase = "0",
CourseLearningCaseName = "选[v课程学习案例_Base]..."
};
arrObjLst.Insert(0, objvCourseLearningCase_BaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCourseLearningCase_Base.Id_CourseLearningCase;
objComboBox.DisplayMember = convCourseLearningCase_Base.CourseLearningCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase_BaseEN GetObjById_CourseLearningCase(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningCase_BaseEN = JsonConvert.DeserializeObject<clsvCourseLearningCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase_BaseEN;
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
 /// <param name = "strId_CourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase_BaseEN GetObjById_CourseLearningCase_WA_Cache(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningCase_BaseEN = JsonConvert.DeserializeObject<clsvCourseLearningCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase_BaseEN;
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
public static clsvCourseLearningCase_BaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = null;
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
objvCourseLearningCase_BaseEN = JsonConvert.DeserializeObject<clsvCourseLearningCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase_BaseEN;
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
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCase_BaseEN GetObjById_CourseLearningCase_Cache(string strId_CourseLearningCase)
{
if (string.IsNullOrEmpty(strId_CourseLearningCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCase_BaseEN._CurrTabName_S);
List<clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Sel =
from objvCourseLearningCase_BaseEN in arrvCourseLearningCase_BaseObjLst_Cache
where objvCourseLearningCase_BaseEN.Id_CourseLearningCase == strId_CourseLearningCase
select objvCourseLearningCase_BaseEN;
if (arrvCourseLearningCase_BaseObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCase_BaseEN obj = clsvCourseLearningCase_BaseWApi.GetObjById_CourseLearningCase(strId_CourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningCase_BaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseLearningCaseNameById_CourseLearningCase_Cache(string strId_CourseLearningCase)
{
if (string.IsNullOrEmpty(strId_CourseLearningCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCase_BaseEN._CurrTabName_S);
List<clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Sel1 =
from objvCourseLearningCase_BaseEN in arrvCourseLearningCase_BaseObjLst_Cache
where objvCourseLearningCase_BaseEN.Id_CourseLearningCase == strId_CourseLearningCase
select objvCourseLearningCase_BaseEN;
List <clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Sel = new List<clsvCourseLearningCase_BaseEN>();
foreach (clsvCourseLearningCase_BaseEN obj in arrvCourseLearningCase_BaseObjLst_Sel1)
{
arrvCourseLearningCase_BaseObjLst_Sel.Add(obj);
}
if (arrvCourseLearningCase_BaseObjLst_Sel.Count > 0)
{
return arrvCourseLearningCase_BaseObjLst_Sel[0].CourseLearningCaseName;
}
string strErrMsgForGetObjById = string.Format("在vCourseLearningCase_Base对象缓存列表中,找不到记录[Id_CourseLearningCase = {0}](函数:{1})", strId_CourseLearningCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCourseLearningCase_BaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameById_CourseLearningCase_Cache(string strId_CourseLearningCase)
{
if (string.IsNullOrEmpty(strId_CourseLearningCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCase_BaseEN._CurrTabName_S);
List<clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Sel1 =
from objvCourseLearningCase_BaseEN in arrvCourseLearningCase_BaseObjLst_Cache
where objvCourseLearningCase_BaseEN.Id_CourseLearningCase == strId_CourseLearningCase
select objvCourseLearningCase_BaseEN;
List <clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Sel = new List<clsvCourseLearningCase_BaseEN>();
foreach (clsvCourseLearningCase_BaseEN obj in arrvCourseLearningCase_BaseObjLst_Sel1)
{
arrvCourseLearningCase_BaseObjLst_Sel.Add(obj);
}
if (arrvCourseLearningCase_BaseObjLst_Sel.Count > 0)
{
return arrvCourseLearningCase_BaseObjLst_Sel[0].CourseLearningCaseName;
}
string strErrMsgForGetObjById = string.Format("在vCourseLearningCase_Base对象缓存列表中,找不到记录的相关名称[Id_CourseLearningCase = {0}](函数:{1})", strId_CourseLearningCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCourseLearningCase_BaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase_BaseEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLstById_CourseLearningCaseLst(List<string> arrId_CourseLearningCase)
{
 List<clsvCourseLearningCase_BaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CourseLearningCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseLearningCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCourseLearningCase_BaseEN> GetObjLstById_CourseLearningCaseLst_Cache(List<string> arrId_CourseLearningCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCase_BaseEN._CurrTabName_S);
List<clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Sel =
from objvCourseLearningCase_BaseEN in arrvCourseLearningCase_BaseObjLst_Cache
where arrId_CourseLearningCase.Contains(objvCourseLearningCase_BaseEN.Id_CourseLearningCase)
select objvCourseLearningCase_BaseEN;
return arrvCourseLearningCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase_BaseEN> GetObjLstById_CourseLearningCaseLst_WA_Cache(List<string> arrId_CourseLearningCase)
{
 List<clsvCourseLearningCase_BaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CourseLearningCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseLearningCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_CourseLearningCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
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
 /// <param name = "objvCourseLearningCase_BaseENS">源对象</param>
 /// <param name = "objvCourseLearningCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseENS, clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseENT)
{
try
{
objvCourseLearningCase_BaseENT.Id_CourseLearningCase = objvCourseLearningCase_BaseENS.Id_CourseLearningCase; //课程学习案例流水号
objvCourseLearningCase_BaseENT.CourseLearningCaseID = objvCourseLearningCase_BaseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase_BaseENT.CourseLearningCaseName = objvCourseLearningCase_BaseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase_BaseENT.CourseLearningCaseText = objvCourseLearningCase_BaseENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCase_BaseENT.CourseLearningCaseTheme = objvCourseLearningCase_BaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCase_BaseENT.CourseLearningCaseDate = objvCourseLearningCase_BaseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCase_BaseENT.CourseLearningCaseTime = objvCourseLearningCase_BaseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCase_BaseENT.CourseLearningCaseDateIn = objvCourseLearningCase_BaseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCase_BaseENT.CourseLearningCaseTimeIn = objvCourseLearningCase_BaseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCase_BaseENT.Id_CaseType = objvCourseLearningCase_BaseENS.Id_CaseType; //案例类型流水号
objvCourseLearningCase_BaseENT.CaseTypeName = objvCourseLearningCase_BaseENS.CaseTypeName; //案例类型名称
objvCourseLearningCase_BaseENT.id_CourseLearningCaseType = objvCourseLearningCase_BaseENS.id_CourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCase_BaseENT.CourseLearningCaseTypeName = objvCourseLearningCase_BaseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCase_BaseENT.OwnerId = objvCourseLearningCase_BaseENS.OwnerId; //拥有者Id
objvCourseLearningCase_BaseENT.id_StudyLevel = objvCourseLearningCase_BaseENS.id_StudyLevel; //id_StudyLevel
objvCourseLearningCase_BaseENT.StudyLevelName = objvCourseLearningCase_BaseENS.StudyLevelName; //学段名称
objvCourseLearningCase_BaseENT.id_TeachingPlan = objvCourseLearningCase_BaseENS.id_TeachingPlan; //教案流水号
objvCourseLearningCase_BaseENT.id_Discipline = objvCourseLearningCase_BaseENS.id_Discipline; //学科流水号
objvCourseLearningCase_BaseENT.DisciplineID = objvCourseLearningCase_BaseENS.DisciplineID; //学科ID
objvCourseLearningCase_BaseENT.DisciplineName = objvCourseLearningCase_BaseENS.DisciplineName; //学科名称
objvCourseLearningCase_BaseENT.id_SenateGaugeVersion = objvCourseLearningCase_BaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCase_BaseENT.senateGaugeVersionID = objvCourseLearningCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCase_BaseENT.senateGaugeVersionName = objvCourseLearningCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCase_BaseENT.senateGaugeVersionTtlScore = objvCourseLearningCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCase_BaseENT.VersionNo = objvCourseLearningCase_BaseENS.VersionNo; //版本号
objvCourseLearningCase_BaseENT.id_TeachSkill = objvCourseLearningCase_BaseENS.id_TeachSkill; //教学技能流水号
objvCourseLearningCase_BaseENT.TeachSkillID = objvCourseLearningCase_BaseENS.TeachSkillID; //教学技能ID
objvCourseLearningCase_BaseENT.SkillTypeName = objvCourseLearningCase_BaseENS.SkillTypeName; //技能类型名称
objvCourseLearningCase_BaseENT.TeachSkillName = objvCourseLearningCase_BaseENS.TeachSkillName; //教学技能名称
objvCourseLearningCase_BaseENT.TeachSkillTheory = objvCourseLearningCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCase_BaseENT.TeachSkillOperMethod = objvCourseLearningCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCase_BaseENT.id_SkillType = objvCourseLearningCase_BaseENS.id_SkillType; //技能类型流水号
objvCourseLearningCase_BaseENT.SkillTypeID = objvCourseLearningCase_BaseENS.SkillTypeID; //技能类型ID
objvCourseLearningCase_BaseENT.CaseLevelId = objvCourseLearningCase_BaseENS.CaseLevelId; //课例等级Id
objvCourseLearningCase_BaseENT.CaseLevelName = objvCourseLearningCase_BaseENS.CaseLevelName; //案例等级名称
objvCourseLearningCase_BaseENT.DocFile = objvCourseLearningCase_BaseENS.DocFile; //生成的Word文件名
objvCourseLearningCase_BaseENT.IsNeedGeneWord = objvCourseLearningCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCase_BaseENT.WordCreateDate = objvCourseLearningCase_BaseENS.WordCreateDate; //Word生成日期
objvCourseLearningCase_BaseENT.IsVisible = objvCourseLearningCase_BaseENS.IsVisible; //是否显示
objvCourseLearningCase_BaseENT.IsDualVideo = objvCourseLearningCase_BaseENS.IsDualVideo; //是否双视频
objvCourseLearningCase_BaseENT.id_XzCollege = objvCourseLearningCase_BaseENS.id_XzCollege; //学院流水号
objvCourseLearningCase_BaseENT.CollegeID = objvCourseLearningCase_BaseENS.CollegeID; //学院ID
objvCourseLearningCase_BaseENT.CollegeName = objvCourseLearningCase_BaseENS.CollegeName; //学院名称
objvCourseLearningCase_BaseENT.CollegeNameA = objvCourseLearningCase_BaseENS.CollegeNameA; //学院名称简写
objvCourseLearningCase_BaseENT.id_XzMajor = objvCourseLearningCase_BaseENS.id_XzMajor; //专业流水号
objvCourseLearningCase_BaseENT.MajorID = objvCourseLearningCase_BaseENS.MajorID; //专业ID
objvCourseLearningCase_BaseENT.MajorName = objvCourseLearningCase_BaseENS.MajorName; //专业名称
objvCourseLearningCase_BaseENT.CourseId = objvCourseLearningCase_BaseENS.CourseId; //课程Id
objvCourseLearningCase_BaseENT.CourseCode = objvCourseLearningCase_BaseENS.CourseCode; //课程代码
objvCourseLearningCase_BaseENT.CourseName = objvCourseLearningCase_BaseENS.CourseName; //课程名称
objvCourseLearningCase_BaseENT.CourseChapterId = objvCourseLearningCase_BaseENS.CourseChapterId; //课程章节ID
objvCourseLearningCase_BaseENT.CourseChapterName = objvCourseLearningCase_BaseENS.CourseChapterName; //课程章节名称
objvCourseLearningCase_BaseENT.ChapterId = objvCourseLearningCase_BaseENS.ChapterId; //章Id
objvCourseLearningCase_BaseENT.ParentNodeID = objvCourseLearningCase_BaseENS.ParentNodeID; //父节点编号
objvCourseLearningCase_BaseENT.CourseChapterReferred = objvCourseLearningCase_BaseENS.CourseChapterReferred; //节简称
objvCourseLearningCase_BaseENT.ChapterName = objvCourseLearningCase_BaseENS.ChapterName; //章名
objvCourseLearningCase_BaseENT.ChapterName_Sim = objvCourseLearningCase_BaseENS.ChapterName_Sim; //章名简称
objvCourseLearningCase_BaseENT.SectionName = objvCourseLearningCase_BaseENS.SectionName; //节名
objvCourseLearningCase_BaseENT.SectionName_Sim = objvCourseLearningCase_BaseENS.SectionName_Sim; //节名简称
objvCourseLearningCase_BaseENT.SectionId = objvCourseLearningCase_BaseENS.SectionId; //节Id
objvCourseLearningCase_BaseENT.ParentNodeReferred = objvCourseLearningCase_BaseENS.ParentNodeReferred; //章简称
objvCourseLearningCase_BaseENT.ParentNodeName = objvCourseLearningCase_BaseENS.ParentNodeName; //父节点名称
objvCourseLearningCase_BaseENT.ViewCount = objvCourseLearningCase_BaseENS.ViewCount; //浏览量
objvCourseLearningCase_BaseENT.IsShow = objvCourseLearningCase_BaseENS.IsShow; //是否启用
objvCourseLearningCase_BaseENT.DownloadNumber = objvCourseLearningCase_BaseENS.DownloadNumber; //下载数目
objvCourseLearningCase_BaseENT.FileIntegration = objvCourseLearningCase_BaseENS.FileIntegration; //文件积分
objvCourseLearningCase_BaseENT.LikeCount = objvCourseLearningCase_BaseENS.LikeCount; //资源喜欢数量
objvCourseLearningCase_BaseENT.CollectionCount = objvCourseLearningCase_BaseENS.CollectionCount; //收藏数量
objvCourseLearningCase_BaseENT.RecommendedDegreeId = objvCourseLearningCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase_BaseENT.RecommendedDegreeName = objvCourseLearningCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCase_BaseENT.ftpFileType = objvCourseLearningCase_BaseENS.ftpFileType; //ftp文件类型
objvCourseLearningCase_BaseENT.VideoUrl = objvCourseLearningCase_BaseENS.VideoUrl; //视频Url
objvCourseLearningCase_BaseENT.VideoPath = objvCourseLearningCase_BaseENS.VideoPath; //视频目录
objvCourseLearningCase_BaseENT.ResErrMsg = objvCourseLearningCase_BaseENS.ResErrMsg; //资源错误信息
objvCourseLearningCase_BaseENT.Memo = objvCourseLearningCase_BaseENS.Memo; //备注
objvCourseLearningCase_BaseENT.BrowseCount4Case = objvCourseLearningCase_BaseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCase_BaseENT.OwnerName = objvCourseLearningCase_BaseENS.OwnerName; //拥有者姓名
objvCourseLearningCase_BaseENT.OwnerNameWithId = objvCourseLearningCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCase_BaseENT.OrderNum = objvCourseLearningCase_BaseENS.OrderNum; //序号
objvCourseLearningCase_BaseENT.IsUse = objvCourseLearningCase_BaseENS.IsUse; //是否使用
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
public static DataTable ToDataTable(List<clsvCourseLearningCase_BaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningCase_BaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningCase_BaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningCase_BaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningCase_BaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningCase_BaseEN.AttributeName)
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseWApi没有刷新缓存机制(clsCourseLearningCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseTypeWApi没有刷新缓存机制(clsCourseLearningCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeWApi没有刷新缓存机制(clsCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_CourseLearningCase");
//if (arrvCourseLearningCase_BaseObjLst_Cache == null)
//{
//arrvCourseLearningCase_BaseObjLst_Cache = await clsvCourseLearningCase_BaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCourseLearningCase_BaseEN._CurrTabName_S);
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
public static List<clsvCourseLearningCase_BaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCase_BaseEN._CurrTabName_S);
List<clsvCourseLearningCase_BaseEN> arrvCourseLearningCase_BaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCase_BaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningCase_BaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningCase_Base.Id_CourseLearningCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseLearningCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseLearningCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseLearningCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseLearningCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseLearningCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseLearningCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseLearningCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.id_CourseLearningCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseLearningCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCourseLearningCase_Base.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Base.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase_Base.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase_Base.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase_Base.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Base.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase_Base.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Base.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Base.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCase_Base.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCase_Base.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Base.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase_Base.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase_Base.IsUse, Type.GetType("System.Boolean"));
foreach (clsvCourseLearningCase_BaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningCase_Base.Id_CourseLearningCase] = objInFor[convCourseLearningCase_Base.Id_CourseLearningCase];
objDR[convCourseLearningCase_Base.CourseLearningCaseID] = objInFor[convCourseLearningCase_Base.CourseLearningCaseID];
objDR[convCourseLearningCase_Base.CourseLearningCaseName] = objInFor[convCourseLearningCase_Base.CourseLearningCaseName];
objDR[convCourseLearningCase_Base.CourseLearningCaseText] = objInFor[convCourseLearningCase_Base.CourseLearningCaseText];
objDR[convCourseLearningCase_Base.CourseLearningCaseTheme] = objInFor[convCourseLearningCase_Base.CourseLearningCaseTheme];
objDR[convCourseLearningCase_Base.CourseLearningCaseDate] = objInFor[convCourseLearningCase_Base.CourseLearningCaseDate];
objDR[convCourseLearningCase_Base.CourseLearningCaseTime] = objInFor[convCourseLearningCase_Base.CourseLearningCaseTime];
objDR[convCourseLearningCase_Base.CourseLearningCaseDateIn] = objInFor[convCourseLearningCase_Base.CourseLearningCaseDateIn];
objDR[convCourseLearningCase_Base.CourseLearningCaseTimeIn] = objInFor[convCourseLearningCase_Base.CourseLearningCaseTimeIn];
objDR[convCourseLearningCase_Base.Id_CaseType] = objInFor[convCourseLearningCase_Base.Id_CaseType];
objDR[convCourseLearningCase_Base.CaseTypeName] = objInFor[convCourseLearningCase_Base.CaseTypeName];
objDR[convCourseLearningCase_Base.id_CourseLearningCaseType] = objInFor[convCourseLearningCase_Base.id_CourseLearningCaseType];
objDR[convCourseLearningCase_Base.CourseLearningCaseTypeName] = objInFor[convCourseLearningCase_Base.CourseLearningCaseTypeName];
objDR[convCourseLearningCase_Base.OwnerId] = objInFor[convCourseLearningCase_Base.OwnerId];
objDR[convCourseLearningCase_Base.id_StudyLevel] = objInFor[convCourseLearningCase_Base.id_StudyLevel];
objDR[convCourseLearningCase_Base.StudyLevelName] = objInFor[convCourseLearningCase_Base.StudyLevelName];
objDR[convCourseLearningCase_Base.id_TeachingPlan] = objInFor[convCourseLearningCase_Base.id_TeachingPlan];
objDR[convCourseLearningCase_Base.id_Discipline] = objInFor[convCourseLearningCase_Base.id_Discipline];
objDR[convCourseLearningCase_Base.DisciplineID] = objInFor[convCourseLearningCase_Base.DisciplineID];
objDR[convCourseLearningCase_Base.DisciplineName] = objInFor[convCourseLearningCase_Base.DisciplineName];
objDR[convCourseLearningCase_Base.id_SenateGaugeVersion] = objInFor[convCourseLearningCase_Base.id_SenateGaugeVersion];
objDR[convCourseLearningCase_Base.senateGaugeVersionID] = objInFor[convCourseLearningCase_Base.senateGaugeVersionID];
objDR[convCourseLearningCase_Base.senateGaugeVersionName] = objInFor[convCourseLearningCase_Base.senateGaugeVersionName];
objDR[convCourseLearningCase_Base.senateGaugeVersionTtlScore] = objInFor[convCourseLearningCase_Base.senateGaugeVersionTtlScore];
objDR[convCourseLearningCase_Base.VersionNo] = objInFor[convCourseLearningCase_Base.VersionNo];
objDR[convCourseLearningCase_Base.id_TeachSkill] = objInFor[convCourseLearningCase_Base.id_TeachSkill];
objDR[convCourseLearningCase_Base.TeachSkillID] = objInFor[convCourseLearningCase_Base.TeachSkillID];
objDR[convCourseLearningCase_Base.SkillTypeName] = objInFor[convCourseLearningCase_Base.SkillTypeName];
objDR[convCourseLearningCase_Base.TeachSkillName] = objInFor[convCourseLearningCase_Base.TeachSkillName];
objDR[convCourseLearningCase_Base.TeachSkillTheory] = objInFor[convCourseLearningCase_Base.TeachSkillTheory];
objDR[convCourseLearningCase_Base.TeachSkillOperMethod] = objInFor[convCourseLearningCase_Base.TeachSkillOperMethod];
objDR[convCourseLearningCase_Base.id_SkillType] = objInFor[convCourseLearningCase_Base.id_SkillType];
objDR[convCourseLearningCase_Base.SkillTypeID] = objInFor[convCourseLearningCase_Base.SkillTypeID];
objDR[convCourseLearningCase_Base.CaseLevelId] = objInFor[convCourseLearningCase_Base.CaseLevelId];
objDR[convCourseLearningCase_Base.CaseLevelName] = objInFor[convCourseLearningCase_Base.CaseLevelName];
objDR[convCourseLearningCase_Base.DocFile] = objInFor[convCourseLearningCase_Base.DocFile];
objDR[convCourseLearningCase_Base.IsNeedGeneWord] = objInFor[convCourseLearningCase_Base.IsNeedGeneWord];
objDR[convCourseLearningCase_Base.WordCreateDate] = objInFor[convCourseLearningCase_Base.WordCreateDate];
objDR[convCourseLearningCase_Base.IsVisible] = objInFor[convCourseLearningCase_Base.IsVisible];
objDR[convCourseLearningCase_Base.IsDualVideo] = objInFor[convCourseLearningCase_Base.IsDualVideo];
objDR[convCourseLearningCase_Base.id_XzCollege] = objInFor[convCourseLearningCase_Base.id_XzCollege];
objDR[convCourseLearningCase_Base.CollegeID] = objInFor[convCourseLearningCase_Base.CollegeID];
objDR[convCourseLearningCase_Base.CollegeName] = objInFor[convCourseLearningCase_Base.CollegeName];
objDR[convCourseLearningCase_Base.CollegeNameA] = objInFor[convCourseLearningCase_Base.CollegeNameA];
objDR[convCourseLearningCase_Base.id_XzMajor] = objInFor[convCourseLearningCase_Base.id_XzMajor];
objDR[convCourseLearningCase_Base.MajorID] = objInFor[convCourseLearningCase_Base.MajorID];
objDR[convCourseLearningCase_Base.MajorName] = objInFor[convCourseLearningCase_Base.MajorName];
objDR[convCourseLearningCase_Base.CourseId] = objInFor[convCourseLearningCase_Base.CourseId];
objDR[convCourseLearningCase_Base.CourseCode] = objInFor[convCourseLearningCase_Base.CourseCode];
objDR[convCourseLearningCase_Base.CourseName] = objInFor[convCourseLearningCase_Base.CourseName];
objDR[convCourseLearningCase_Base.CourseChapterId] = objInFor[convCourseLearningCase_Base.CourseChapterId];
objDR[convCourseLearningCase_Base.CourseChapterName] = objInFor[convCourseLearningCase_Base.CourseChapterName];
objDR[convCourseLearningCase_Base.ChapterId] = objInFor[convCourseLearningCase_Base.ChapterId];
objDR[convCourseLearningCase_Base.ParentNodeID] = objInFor[convCourseLearningCase_Base.ParentNodeID];
objDR[convCourseLearningCase_Base.CourseChapterReferred] = objInFor[convCourseLearningCase_Base.CourseChapterReferred];
objDR[convCourseLearningCase_Base.ChapterName] = objInFor[convCourseLearningCase_Base.ChapterName];
objDR[convCourseLearningCase_Base.ChapterName_Sim] = objInFor[convCourseLearningCase_Base.ChapterName_Sim];
objDR[convCourseLearningCase_Base.SectionName] = objInFor[convCourseLearningCase_Base.SectionName];
objDR[convCourseLearningCase_Base.SectionName_Sim] = objInFor[convCourseLearningCase_Base.SectionName_Sim];
objDR[convCourseLearningCase_Base.SectionId] = objInFor[convCourseLearningCase_Base.SectionId];
objDR[convCourseLearningCase_Base.ParentNodeReferred] = objInFor[convCourseLearningCase_Base.ParentNodeReferred];
objDR[convCourseLearningCase_Base.ParentNodeName] = objInFor[convCourseLearningCase_Base.ParentNodeName];
objDR[convCourseLearningCase_Base.ViewCount] = objInFor[convCourseLearningCase_Base.ViewCount];
objDR[convCourseLearningCase_Base.IsShow] = objInFor[convCourseLearningCase_Base.IsShow];
objDR[convCourseLearningCase_Base.DownloadNumber] = objInFor[convCourseLearningCase_Base.DownloadNumber];
objDR[convCourseLearningCase_Base.FileIntegration] = objInFor[convCourseLearningCase_Base.FileIntegration];
objDR[convCourseLearningCase_Base.LikeCount] = objInFor[convCourseLearningCase_Base.LikeCount];
objDR[convCourseLearningCase_Base.CollectionCount] = objInFor[convCourseLearningCase_Base.CollectionCount];
objDR[convCourseLearningCase_Base.RecommendedDegreeId] = objInFor[convCourseLearningCase_Base.RecommendedDegreeId];
objDR[convCourseLearningCase_Base.RecommendedDegreeName] = objInFor[convCourseLearningCase_Base.RecommendedDegreeName];
objDR[convCourseLearningCase_Base.ftpFileType] = objInFor[convCourseLearningCase_Base.ftpFileType];
objDR[convCourseLearningCase_Base.VideoUrl] = objInFor[convCourseLearningCase_Base.VideoUrl];
objDR[convCourseLearningCase_Base.VideoPath] = objInFor[convCourseLearningCase_Base.VideoPath];
objDR[convCourseLearningCase_Base.ResErrMsg] = objInFor[convCourseLearningCase_Base.ResErrMsg];
objDR[convCourseLearningCase_Base.Memo] = objInFor[convCourseLearningCase_Base.Memo];
objDR[convCourseLearningCase_Base.BrowseCount4Case] = objInFor[convCourseLearningCase_Base.BrowseCount4Case];
objDR[convCourseLearningCase_Base.OwnerName] = objInFor[convCourseLearningCase_Base.OwnerName];
objDR[convCourseLearningCase_Base.OwnerNameWithId] = objInFor[convCourseLearningCase_Base.OwnerNameWithId];
objDR[convCourseLearningCase_Base.OrderNum] = objInFor[convCourseLearningCase_Base.OrderNum];
objDR[convCourseLearningCase_Base.IsUse] = objInFor[convCourseLearningCase_Base.IsUse];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}