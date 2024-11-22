
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseWApi
 表名:vCourseLearningCase(01120267)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:32
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
public static class clsvCourseLearningCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetId_CourseLearningCase(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strId_CourseLearningCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CourseLearningCase, 8, convCourseLearningCase.Id_CourseLearningCase);
clsCheckSql.CheckFieldForeignKey(strId_CourseLearningCase, 8, convCourseLearningCase.Id_CourseLearningCase);
objvCourseLearningCaseEN.Id_CourseLearningCase = strId_CourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.Id_CourseLearningCase) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.Id_CourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.Id_CourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, convCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCase.CourseLearningCaseID);
objvCourseLearningCaseEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningCase.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCase.CourseLearningCaseName);
objvCourseLearningCaseEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseText(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseText, 8000, convCourseLearningCase.CourseLearningCaseText);
objvCourseLearningCaseEN.CourseLearningCaseText = strCourseLearningCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseText) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseText, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseText] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseTheme(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningCase.CourseLearningCaseTheme);
objvCourseLearningCaseEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseTheme) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseDate(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningCase.CourseLearningCaseDate);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningCase.CourseLearningCaseDate);
objvCourseLearningCaseEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseDate) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseTime(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningCase.CourseLearningCaseTime);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningCase.CourseLearningCaseTime);
objvCourseLearningCaseEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseTime) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseDateIn(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningCase.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningCase.CourseLearningCaseDateIn);
objvCourseLearningCaseEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseDateIn) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseTimeIn(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningCase.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningCase.CourseLearningCaseTimeIn);
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetId_CaseType(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convCourseLearningCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convCourseLearningCase.Id_CaseType);
objvCourseLearningCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.Id_CaseType) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.Id_CaseType, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.Id_CaseType] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCaseTypeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTypeName, 50, convCourseLearningCase.CaseTypeName);
objvCourseLearningCaseEN.CaseTypeName = strCaseTypeName; //案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CaseTypeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN Setid_CourseLearningCaseType(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strid_CourseLearningCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CourseLearningCaseType, convCourseLearningCase.id_CourseLearningCaseType);
clsCheckSql.CheckFieldLen(strid_CourseLearningCaseType, 4, convCourseLearningCase.id_CourseLearningCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseLearningCaseType, 4, convCourseLearningCase.id_CourseLearningCaseType);
objvCourseLearningCaseEN.id_CourseLearningCaseType = strid_CourseLearningCaseType; //课程学习案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.id_CourseLearningCaseType) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.id_CourseLearningCaseType, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.id_CourseLearningCaseType] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseLearningCaseTypeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningCase.CourseLearningCaseTypeName);
objvCourseLearningCaseEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseLearningCaseTypeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetOwnerId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCourseLearningCase.OwnerId);
objvCourseLearningCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.OwnerId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.OwnerId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.OwnerId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN Setid_StudyLevel(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCourseLearningCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCourseLearningCase.id_StudyLevel);
objvCourseLearningCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.id_StudyLevel) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.id_StudyLevel, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.id_StudyLevel] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetStudyLevelName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCourseLearningCase.StudyLevelName);
objvCourseLearningCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.StudyLevelName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.StudyLevelName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.StudyLevelName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN Setid_TeachingPlan(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCourseLearningCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCourseLearningCase.id_TeachingPlan);
objvCourseLearningCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.id_TeachingPlan) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN Setid_Discipline(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convCourseLearningCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCourseLearningCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCourseLearningCase.id_Discipline);
objvCourseLearningCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.id_Discipline) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.id_Discipline, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.id_Discipline] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetDisciplineID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCourseLearningCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCourseLearningCase.DisciplineID);
objvCourseLearningCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.DisciplineID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.DisciplineID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.DisciplineID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetDisciplineName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCourseLearningCase.DisciplineName);
objvCourseLearningCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.DisciplineName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.DisciplineName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.DisciplineName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN Setid_SenateGaugeVersion(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCourseLearningCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCourseLearningCase.id_SenateGaugeVersion);
objvCourseLearningCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.id_SenateGaugeVersion) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetsenateGaugeVersionID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCourseLearningCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCourseLearningCase.senateGaugeVersionID);
objvCourseLearningCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.senateGaugeVersionID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetsenateGaugeVersionName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCase.senateGaugeVersionName);
objvCourseLearningCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.senateGaugeVersionName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetsenateGaugeVersionTtlScore(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.senateGaugeVersionTtlScore) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsUse(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, bool bolIsUse, string strComparisonOp="")
	{
objvCourseLearningCaseEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsUse) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsUse, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsUse] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetVersionNo(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int intVersionNo, string strComparisonOp="")
	{
objvCourseLearningCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.VersionNo) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.VersionNo, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.VersionNo] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN Setid_TeachSkill(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convCourseLearningCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCourseLearningCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCourseLearningCase.id_TeachSkill);
objvCourseLearningCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.id_TeachSkill) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.id_TeachSkill, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.id_TeachSkill] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetTeachSkillID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCourseLearningCase.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCourseLearningCase.TeachSkillID);
objvCourseLearningCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.TeachSkillID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.TeachSkillID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.TeachSkillID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetSkillTypeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCourseLearningCase.SkillTypeName);
objvCourseLearningCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.SkillTypeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.SkillTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.SkillTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetTeachSkillName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCourseLearningCase.TeachSkillName);
objvCourseLearningCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.TeachSkillName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.TeachSkillName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.TeachSkillName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetTeachSkillTheory(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCourseLearningCase.TeachSkillTheory);
objvCourseLearningCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.TeachSkillTheory) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetTeachSkillOperMethod(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCourseLearningCase.TeachSkillOperMethod);
objvCourseLearningCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.TeachSkillOperMethod) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN Setid_SkillType(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convCourseLearningCase.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convCourseLearningCase.id_SkillType);
objvCourseLearningCaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.id_SkillType) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.id_SkillType, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.id_SkillType] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetSkillTypeID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCourseLearningCase.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCourseLearningCase.SkillTypeID);
objvCourseLearningCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.SkillTypeID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.SkillTypeID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.SkillTypeID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCaseLevelId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCourseLearningCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCourseLearningCase.CaseLevelId);
objvCourseLearningCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CaseLevelId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CaseLevelId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CaseLevelId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCaseLevelName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convCourseLearningCase.CaseLevelName);
objvCourseLearningCaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CaseLevelName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CaseLevelName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CaseLevelName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetDocFile(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCourseLearningCase.DocFile);
objvCourseLearningCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.DocFile) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.DocFile, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.DocFile] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsNeedGeneWord(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCourseLearningCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsNeedGeneWord) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetWordCreateDate(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCourseLearningCase.WordCreateDate);
objvCourseLearningCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.WordCreateDate) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.WordCreateDate, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.WordCreateDate] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsVisible(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCourseLearningCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsVisible) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsVisible, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsVisible] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsDualVideo(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCourseLearningCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsDualVideo) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsDualVideo, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsDualVideo] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN Setid_XzCollege(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCourseLearningCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCourseLearningCase.id_XzCollege);
objvCourseLearningCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.id_XzCollege) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.id_XzCollege, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.id_XzCollege] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCollegeID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningCase.CollegeID);
objvCourseLearningCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CollegeID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCollegeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCase.CollegeName);
objvCourseLearningCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CollegeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCollegeNameA(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningCase.CollegeNameA);
objvCourseLearningCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CollegeNameA) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN Setid_XzMajor(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convCourseLearningCase.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCourseLearningCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCourseLearningCase.id_XzMajor);
objvCourseLearningCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.id_XzMajor) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.id_XzMajor, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.id_XzMajor] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetMajorID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCase.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCase.MajorID);
objvCourseLearningCaseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.MajorID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetMajorName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCase.MajorName);
objvCourseLearningCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.MajorName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCourseLearningCase.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCase.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCase.CourseId);
objvCourseLearningCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseCode(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCase.CourseCode);
objvCourseLearningCaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseCode) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCase.CourseName);
objvCourseLearningCaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseChapterId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convCourseLearningCase.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCase.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCase.CourseChapterId);
objvCourseLearningCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseChapterId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseChapterId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseChapterId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseChapterName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCourseLearningCase.CourseChapterName);
objvCourseLearningCaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseChapterName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseChapterName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseChapterName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetChapterId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convCourseLearningCase.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convCourseLearningCase.ChapterId);
objvCourseLearningCaseEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ChapterId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ChapterId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ChapterId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetSectionId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convCourseLearningCase.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convCourseLearningCase.SectionId);
objvCourseLearningCaseEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.SectionId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.SectionId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.SectionId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetChapterName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convCourseLearningCase.ChapterName);
objvCourseLearningCaseEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ChapterName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ChapterName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ChapterName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetSectionName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convCourseLearningCase.SectionName);
objvCourseLearningCaseEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.SectionName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.SectionName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.SectionName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetChapterName_Sim(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convCourseLearningCase.ChapterName_Sim);
objvCourseLearningCaseEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ChapterName_Sim) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ChapterName_Sim, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ChapterName_Sim] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetSectionName_Sim(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convCourseLearningCase.SectionName_Sim);
objvCourseLearningCaseEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.SectionName_Sim) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.SectionName_Sim, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.SectionName_Sim] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetParentNodeID(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCourseLearningCase.ParentNodeID);
objvCourseLearningCaseEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ParentNodeID) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ParentNodeID, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ParentNodeID] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCourseChapterReferred(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convCourseLearningCase.CourseChapterReferred);
objvCourseLearningCaseEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CourseChapterReferred) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CourseChapterReferred, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CourseChapterReferred] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetParentNodeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCourseLearningCase.ParentNodeName);
objvCourseLearningCaseEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ParentNodeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ParentNodeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ParentNodeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetParentNodeReferred(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convCourseLearningCase.ParentNodeReferred);
objvCourseLearningCaseEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ParentNodeReferred) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ParentNodeReferred, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ParentNodeReferred] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetViewCount(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int intViewCount, string strComparisonOp="")
	{
objvCourseLearningCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ViewCount) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ViewCount, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ViewCount] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsShow(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvCourseLearningCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsShow) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsShow, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsShow] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetDownloadNumber(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objvCourseLearningCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.DownloadNumber) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.DownloadNumber, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.DownloadNumber] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetFileIntegration(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int intFileIntegration, string strComparisonOp="")
	{
objvCourseLearningCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.FileIntegration) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.FileIntegration, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.FileIntegration] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetLikeCount(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, long lngLikeCount, string strComparisonOp="")
	{
objvCourseLearningCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.LikeCount) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.LikeCount, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.LikeCount] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetCollectionCount(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objvCourseLearningCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.CollectionCount) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.CollectionCount, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.CollectionCount] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetRecommendedDegreeId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCourseLearningCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCourseLearningCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCourseLearningCase.RecommendedDegreeId);
objvCourseLearningCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.RecommendedDegreeId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetRecommendedDegreeName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCourseLearningCase.RecommendedDegreeName);
objvCourseLearningCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.RecommendedDegreeName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetftpFileType(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCourseLearningCase.ftpFileType);
objvCourseLearningCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ftpFileType) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ftpFileType, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ftpFileType] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetVideoUrl(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convCourseLearningCase.VideoUrl);
objvCourseLearningCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.VideoUrl) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.VideoUrl, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.VideoUrl] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetVideoPath(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convCourseLearningCase.VideoPath);
objvCourseLearningCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.VideoPath) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.VideoPath, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.VideoPath] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetImageUrl(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 50, convCourseLearningCase.ImageUrl);
objvCourseLearningCaseEN.ImageUrl = strImageUrl; //ImageUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ImageUrl) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ImageUrl, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ImageUrl] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetResErrMsg(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convCourseLearningCase.ResErrMsg);
objvCourseLearningCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.ResErrMsg) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.ResErrMsg, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.ResErrMsg] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetOrderNum(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int intOrderNum, string strComparisonOp="")
	{
objvCourseLearningCaseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.OrderNum) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.OrderNum, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.OrderNum] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetUpdDate(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCourseLearningCase.UpdDate);
objvCourseLearningCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.UpdDate) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.UpdDate, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.UpdDate] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetUpdUserId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCourseLearningCase.UpdUserId);
objvCourseLearningCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.UpdUserId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.UpdUserId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.UpdUserId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetMemo(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCase.Memo);
objvCourseLearningCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.Memo) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.Memo, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.Memo] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetIsHaveVideo(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convCourseLearningCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convCourseLearningCase.IsHaveVideo);
objvCourseLearningCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.IsHaveVideo) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.IsHaveVideo, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.IsHaveVideo] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetBrowseCount4Case(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.BrowseCount4Case) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetOwnerName(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCourseLearningCase.OwnerName);
objvCourseLearningCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.OwnerName) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.OwnerName, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.OwnerName] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseEN SetOwnerNameWithId(this clsvCourseLearningCaseEN objvCourseLearningCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCourseLearningCase.OwnerNameWithId);
objvCourseLearningCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase.OwnerNameWithId) == false)
{
objvCourseLearningCaseEN.dicFldComparisonOp.Add(convCourseLearningCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvCourseLearningCaseEN.dicFldComparisonOp[convCourseLearningCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvCourseLearningCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCaseEN objvCourseLearningCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.Id_CourseLearningCase) == true)
{
string strComparisonOp_Id_CourseLearningCase = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.Id_CourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.Id_CourseLearningCase, objvCourseLearningCase_Cond.Id_CourseLearningCase, strComparisonOp_Id_CourseLearningCase);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseLearningCaseID) == true)
{
string strComparisonOp_CourseLearningCaseID = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseID, objvCourseLearningCase_Cond.CourseLearningCaseID, strComparisonOp_CourseLearningCaseID);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseName, objvCourseLearningCase_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseLearningCaseText) == true)
{
string strComparisonOp_CourseLearningCaseText = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseText, objvCourseLearningCase_Cond.CourseLearningCaseText, strComparisonOp_CourseLearningCaseText);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseLearningCaseTheme) == true)
{
string strComparisonOp_CourseLearningCaseTheme = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseTheme, objvCourseLearningCase_Cond.CourseLearningCaseTheme, strComparisonOp_CourseLearningCaseTheme);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseLearningCaseDate) == true)
{
string strComparisonOp_CourseLearningCaseDate = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseDate, objvCourseLearningCase_Cond.CourseLearningCaseDate, strComparisonOp_CourseLearningCaseDate);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseLearningCaseTime) == true)
{
string strComparisonOp_CourseLearningCaseTime = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseTime, objvCourseLearningCase_Cond.CourseLearningCaseTime, strComparisonOp_CourseLearningCaseTime);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseLearningCaseDateIn) == true)
{
string strComparisonOp_CourseLearningCaseDateIn = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseDateIn, objvCourseLearningCase_Cond.CourseLearningCaseDateIn, strComparisonOp_CourseLearningCaseDateIn);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseLearningCaseTimeIn) == true)
{
string strComparisonOp_CourseLearningCaseTimeIn = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseTimeIn, objvCourseLearningCase_Cond.CourseLearningCaseTimeIn, strComparisonOp_CourseLearningCaseTimeIn);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.Id_CaseType, objvCourseLearningCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CaseTypeName) == true)
{
string strComparisonOp_CaseTypeName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CaseTypeName, objvCourseLearningCase_Cond.CaseTypeName, strComparisonOp_CaseTypeName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.id_CourseLearningCaseType) == true)
{
string strComparisonOp_id_CourseLearningCaseType = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.id_CourseLearningCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.id_CourseLearningCaseType, objvCourseLearningCase_Cond.id_CourseLearningCaseType, strComparisonOp_id_CourseLearningCaseType);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseLearningCaseTypeName) == true)
{
string strComparisonOp_CourseLearningCaseTypeName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseLearningCaseTypeName, objvCourseLearningCase_Cond.CourseLearningCaseTypeName, strComparisonOp_CourseLearningCaseTypeName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.OwnerId, objvCourseLearningCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.id_StudyLevel, objvCourseLearningCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.StudyLevelName, objvCourseLearningCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.id_TeachingPlan, objvCourseLearningCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.id_Discipline, objvCourseLearningCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.DisciplineID, objvCourseLearningCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.DisciplineName, objvCourseLearningCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.id_SenateGaugeVersion, objvCourseLearningCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.senateGaugeVersionID, objvCourseLearningCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.senateGaugeVersionName, objvCourseLearningCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.senateGaugeVersionTtlScore, objvCourseLearningCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.IsUse) == true)
{
if (objvCourseLearningCase_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase.IsUse);
}
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.VersionNo, objvCourseLearningCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.id_TeachSkill, objvCourseLearningCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.TeachSkillID, objvCourseLearningCase_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.SkillTypeName, objvCourseLearningCase_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.TeachSkillName, objvCourseLearningCase_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.TeachSkillTheory, objvCourseLearningCase_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.TeachSkillOperMethod, objvCourseLearningCase_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.id_SkillType, objvCourseLearningCase_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.SkillTypeID, objvCourseLearningCase_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CaseLevelId, objvCourseLearningCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CaseLevelName, objvCourseLearningCase_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.DocFile, objvCourseLearningCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.IsNeedGeneWord) == true)
{
if (objvCourseLearningCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase.IsNeedGeneWord);
}
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.WordCreateDate, objvCourseLearningCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.IsVisible) == true)
{
if (objvCourseLearningCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase.IsVisible);
}
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.IsDualVideo) == true)
{
if (objvCourseLearningCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase.IsDualVideo);
}
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.id_XzCollege, objvCourseLearningCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CollegeID, objvCourseLearningCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CollegeName, objvCourseLearningCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CollegeNameA, objvCourseLearningCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.id_XzMajor, objvCourseLearningCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.MajorID) == true)
{
string strComparisonOp_MajorID = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.MajorID, objvCourseLearningCase_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.MajorName) == true)
{
string strComparisonOp_MajorName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.MajorName, objvCourseLearningCase_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseId) == true)
{
string strComparisonOp_CourseId = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseId, objvCourseLearningCase_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseCode, objvCourseLearningCase_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseName) == true)
{
string strComparisonOp_CourseName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseName, objvCourseLearningCase_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseChapterId, objvCourseLearningCase_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseChapterName, objvCourseLearningCase_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ChapterId, objvCourseLearningCase_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.SectionId) == true)
{
string strComparisonOp_SectionId = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.SectionId, objvCourseLearningCase_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ChapterName, objvCourseLearningCase_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.SectionName) == true)
{
string strComparisonOp_SectionName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.SectionName, objvCourseLearningCase_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ChapterName_Sim, objvCourseLearningCase_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.SectionName_Sim, objvCourseLearningCase_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ParentNodeID, objvCourseLearningCase_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.CourseChapterReferred, objvCourseLearningCase_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ParentNodeName, objvCourseLearningCase_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ParentNodeReferred, objvCourseLearningCase_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.ViewCount, objvCourseLearningCase_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.IsShow) == true)
{
if (objvCourseLearningCase_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase.IsShow);
}
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.DownloadNumber, objvCourseLearningCase_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.FileIntegration, objvCourseLearningCase_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.LikeCount, objvCourseLearningCase_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.CollectionCount, objvCourseLearningCase_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.RecommendedDegreeId, objvCourseLearningCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.RecommendedDegreeName, objvCourseLearningCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ftpFileType, objvCourseLearningCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.VideoUrl, objvCourseLearningCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.VideoPath, objvCourseLearningCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.ImageUrl) == true)
{
string strComparisonOp_ImageUrl = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ImageUrl, objvCourseLearningCase_Cond.ImageUrl, strComparisonOp_ImageUrl);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.ResErrMsg, objvCourseLearningCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.OrderNum, objvCourseLearningCase_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.UpdDate, objvCourseLearningCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.UpdUserId, objvCourseLearningCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.Memo) == true)
{
string strComparisonOp_Memo = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.Memo, objvCourseLearningCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.IsHaveVideo, objvCourseLearningCase_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase.BrowseCount4Case, objvCourseLearningCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.OwnerName, objvCourseLearningCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCourseLearningCase_Cond.IsUpdated(convCourseLearningCase.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCourseLearningCase_Cond.dicFldComparisonOp[convCourseLearningCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase.OwnerNameWithId, objvCourseLearningCase_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习案例(vCourseLearningCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCaseWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningCaseApi";

 public clsvCourseLearningCaseWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程学习案例]...","0");
List<clsvCourseLearningCaseEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convCourseLearningCase.Id_CourseLearningCase); 
List<clsvCourseLearningCaseEN> arrObjLst = clsvCourseLearningCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN()
{
Id_CourseLearningCase = "0",
CourseLearningCaseName = "选[v课程学习案例]..."
};
arrObjLst.Insert(0, objvCourseLearningCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCourseLearningCase.Id_CourseLearningCase;
objComboBox.DisplayMember = convCourseLearningCase.CourseLearningCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseEN GetObjById_CourseLearningCase(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseEN objvCourseLearningCaseEN = null;
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
objvCourseLearningCaseEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseEN;
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
public static clsvCourseLearningCaseEN GetObjById_CourseLearningCase_WA_Cache(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseEN objvCourseLearningCaseEN = null;
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
objvCourseLearningCaseEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseEN;
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
public static clsvCourseLearningCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseEN objvCourseLearningCaseEN = null;
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
objvCourseLearningCaseEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseEN;
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
public static clsvCourseLearningCaseEN GetObjById_CourseLearningCase_Cache(string strId_CourseLearningCase)
{
if (string.IsNullOrEmpty(strId_CourseLearningCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCaseEN._CurrTabName_S);
List<clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Sel =
from objvCourseLearningCaseEN in arrvCourseLearningCaseObjLst_Cache
where objvCourseLearningCaseEN.Id_CourseLearningCase == strId_CourseLearningCase
select objvCourseLearningCaseEN;
if (arrvCourseLearningCaseObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCaseEN obj = clsvCourseLearningCaseWApi.GetObjById_CourseLearningCase(strId_CourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningCaseObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsvCourseLearningCaseEN._CurrTabName_S);
List<clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Sel1 =
from objvCourseLearningCaseEN in arrvCourseLearningCaseObjLst_Cache
where objvCourseLearningCaseEN.Id_CourseLearningCase == strId_CourseLearningCase
select objvCourseLearningCaseEN;
List <clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Sel = new List<clsvCourseLearningCaseEN>();
foreach (clsvCourseLearningCaseEN obj in arrvCourseLearningCaseObjLst_Sel1)
{
arrvCourseLearningCaseObjLst_Sel.Add(obj);
}
if (arrvCourseLearningCaseObjLst_Sel.Count > 0)
{
return arrvCourseLearningCaseObjLst_Sel[0].CourseLearningCaseName;
}
string strErrMsgForGetObjById = string.Format("在vCourseLearningCase对象缓存列表中,找不到记录[Id_CourseLearningCase = {0}](函数:{1})", strId_CourseLearningCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCourseLearningCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsvCourseLearningCaseEN._CurrTabName_S);
List<clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Sel1 =
from objvCourseLearningCaseEN in arrvCourseLearningCaseObjLst_Cache
where objvCourseLearningCaseEN.Id_CourseLearningCase == strId_CourseLearningCase
select objvCourseLearningCaseEN;
List <clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Sel = new List<clsvCourseLearningCaseEN>();
foreach (clsvCourseLearningCaseEN obj in arrvCourseLearningCaseObjLst_Sel1)
{
arrvCourseLearningCaseObjLst_Sel.Add(obj);
}
if (arrvCourseLearningCaseObjLst_Sel.Count > 0)
{
return arrvCourseLearningCaseObjLst_Sel[0].CourseLearningCaseName;
}
string strErrMsgForGetObjById = string.Format("在vCourseLearningCase对象缓存列表中,找不到记录的相关名称[Id_CourseLearningCase = {0}](函数:{1})", strId_CourseLearningCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCourseLearningCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseEN> GetObjLstById_CourseLearningCaseLst(List<string> arrId_CourseLearningCase)
{
 List<clsvCourseLearningCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCourseLearningCaseEN> GetObjLstById_CourseLearningCaseLst_Cache(List<string> arrId_CourseLearningCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCaseEN._CurrTabName_S);
List<clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Sel =
from objvCourseLearningCaseEN in arrvCourseLearningCaseObjLst_Cache
where arrId_CourseLearningCase.Contains(objvCourseLearningCaseEN.Id_CourseLearningCase)
select objvCourseLearningCaseEN;
return arrvCourseLearningCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseEN> GetObjLstById_CourseLearningCaseLst_WA_Cache(List<string> arrId_CourseLearningCase)
{
 List<clsvCourseLearningCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCourseLearningCaseENS">源对象</param>
 /// <param name = "objvCourseLearningCaseENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCaseEN objvCourseLearningCaseENS, clsvCourseLearningCaseEN objvCourseLearningCaseENT)
{
try
{
objvCourseLearningCaseENT.Id_CourseLearningCase = objvCourseLearningCaseENS.Id_CourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseENT.CourseLearningCaseID = objvCourseLearningCaseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseENT.CourseLearningCaseName = objvCourseLearningCaseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseENT.CourseLearningCaseText = objvCourseLearningCaseENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCaseENT.CourseLearningCaseTheme = objvCourseLearningCaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseENT.CourseLearningCaseDate = objvCourseLearningCaseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseENT.CourseLearningCaseTime = objvCourseLearningCaseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseENT.CourseLearningCaseDateIn = objvCourseLearningCaseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseENT.CourseLearningCaseTimeIn = objvCourseLearningCaseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseENT.Id_CaseType = objvCourseLearningCaseENS.Id_CaseType; //案例类型流水号
objvCourseLearningCaseENT.CaseTypeName = objvCourseLearningCaseENS.CaseTypeName; //案例类型名称
objvCourseLearningCaseENT.id_CourseLearningCaseType = objvCourseLearningCaseENS.id_CourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCaseENT.CourseLearningCaseTypeName = objvCourseLearningCaseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseENT.OwnerId = objvCourseLearningCaseENS.OwnerId; //拥有者Id
objvCourseLearningCaseENT.id_StudyLevel = objvCourseLearningCaseENS.id_StudyLevel; //id_StudyLevel
objvCourseLearningCaseENT.StudyLevelName = objvCourseLearningCaseENS.StudyLevelName; //学段名称
objvCourseLearningCaseENT.id_TeachingPlan = objvCourseLearningCaseENS.id_TeachingPlan; //教案流水号
objvCourseLearningCaseENT.id_Discipline = objvCourseLearningCaseENS.id_Discipline; //学科流水号
objvCourseLearningCaseENT.DisciplineID = objvCourseLearningCaseENS.DisciplineID; //学科ID
objvCourseLearningCaseENT.DisciplineName = objvCourseLearningCaseENS.DisciplineName; //学科名称
objvCourseLearningCaseENT.id_SenateGaugeVersion = objvCourseLearningCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseENT.senateGaugeVersionID = objvCourseLearningCaseENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseENT.senateGaugeVersionName = objvCourseLearningCaseENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseENT.senateGaugeVersionTtlScore = objvCourseLearningCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseENT.IsUse = objvCourseLearningCaseENS.IsUse; //是否使用
objvCourseLearningCaseENT.VersionNo = objvCourseLearningCaseENS.VersionNo; //版本号
objvCourseLearningCaseENT.id_TeachSkill = objvCourseLearningCaseENS.id_TeachSkill; //教学技能流水号
objvCourseLearningCaseENT.TeachSkillID = objvCourseLearningCaseENS.TeachSkillID; //教学技能ID
objvCourseLearningCaseENT.SkillTypeName = objvCourseLearningCaseENS.SkillTypeName; //技能类型名称
objvCourseLearningCaseENT.TeachSkillName = objvCourseLearningCaseENS.TeachSkillName; //教学技能名称
objvCourseLearningCaseENT.TeachSkillTheory = objvCourseLearningCaseENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCaseENT.TeachSkillOperMethod = objvCourseLearningCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCaseENT.id_SkillType = objvCourseLearningCaseENS.id_SkillType; //技能类型流水号
objvCourseLearningCaseENT.SkillTypeID = objvCourseLearningCaseENS.SkillTypeID; //技能类型ID
objvCourseLearningCaseENT.CaseLevelId = objvCourseLearningCaseENS.CaseLevelId; //课例等级Id
objvCourseLearningCaseENT.CaseLevelName = objvCourseLearningCaseENS.CaseLevelName; //案例等级名称
objvCourseLearningCaseENT.DocFile = objvCourseLearningCaseENS.DocFile; //生成的Word文件名
objvCourseLearningCaseENT.IsNeedGeneWord = objvCourseLearningCaseENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCaseENT.WordCreateDate = objvCourseLearningCaseENS.WordCreateDate; //Word生成日期
objvCourseLearningCaseENT.IsVisible = objvCourseLearningCaseENS.IsVisible; //是否显示
objvCourseLearningCaseENT.IsDualVideo = objvCourseLearningCaseENS.IsDualVideo; //是否双视频
objvCourseLearningCaseENT.id_XzCollege = objvCourseLearningCaseENS.id_XzCollege; //学院流水号
objvCourseLearningCaseENT.CollegeID = objvCourseLearningCaseENS.CollegeID; //学院ID
objvCourseLearningCaseENT.CollegeName = objvCourseLearningCaseENS.CollegeName; //学院名称
objvCourseLearningCaseENT.CollegeNameA = objvCourseLearningCaseENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseENT.id_XzMajor = objvCourseLearningCaseENS.id_XzMajor; //专业流水号
objvCourseLearningCaseENT.MajorID = objvCourseLearningCaseENS.MajorID; //专业ID
objvCourseLearningCaseENT.MajorName = objvCourseLearningCaseENS.MajorName; //专业名称
objvCourseLearningCaseENT.CourseId = objvCourseLearningCaseENS.CourseId; //课程Id
objvCourseLearningCaseENT.CourseCode = objvCourseLearningCaseENS.CourseCode; //课程代码
objvCourseLearningCaseENT.CourseName = objvCourseLearningCaseENS.CourseName; //课程名称
objvCourseLearningCaseENT.CourseChapterId = objvCourseLearningCaseENS.CourseChapterId; //课程章节ID
objvCourseLearningCaseENT.CourseChapterName = objvCourseLearningCaseENS.CourseChapterName; //课程章节名称
objvCourseLearningCaseENT.ChapterId = objvCourseLearningCaseENS.ChapterId; //章Id
objvCourseLearningCaseENT.SectionId = objvCourseLearningCaseENS.SectionId; //节Id
objvCourseLearningCaseENT.ChapterName = objvCourseLearningCaseENS.ChapterName; //章名
objvCourseLearningCaseENT.SectionName = objvCourseLearningCaseENS.SectionName; //节名
objvCourseLearningCaseENT.ChapterName_Sim = objvCourseLearningCaseENS.ChapterName_Sim; //章名简称
objvCourseLearningCaseENT.SectionName_Sim = objvCourseLearningCaseENS.SectionName_Sim; //节名简称
objvCourseLearningCaseENT.ParentNodeID = objvCourseLearningCaseENS.ParentNodeID; //父节点编号
objvCourseLearningCaseENT.CourseChapterReferred = objvCourseLearningCaseENS.CourseChapterReferred; //节简称
objvCourseLearningCaseENT.ParentNodeName = objvCourseLearningCaseENS.ParentNodeName; //父节点名称
objvCourseLearningCaseENT.ParentNodeReferred = objvCourseLearningCaseENS.ParentNodeReferred; //章简称
objvCourseLearningCaseENT.ViewCount = objvCourseLearningCaseENS.ViewCount; //浏览量
objvCourseLearningCaseENT.IsShow = objvCourseLearningCaseENS.IsShow; //是否启用
objvCourseLearningCaseENT.DownloadNumber = objvCourseLearningCaseENS.DownloadNumber; //下载数目
objvCourseLearningCaseENT.FileIntegration = objvCourseLearningCaseENS.FileIntegration; //文件积分
objvCourseLearningCaseENT.LikeCount = objvCourseLearningCaseENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseENT.CollectionCount = objvCourseLearningCaseENS.CollectionCount; //收藏数量
objvCourseLearningCaseENT.RecommendedDegreeId = objvCourseLearningCaseENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCaseENT.RecommendedDegreeName = objvCourseLearningCaseENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCaseENT.ftpFileType = objvCourseLearningCaseENS.ftpFileType; //ftp文件类型
objvCourseLearningCaseENT.VideoUrl = objvCourseLearningCaseENS.VideoUrl; //视频Url
objvCourseLearningCaseENT.VideoPath = objvCourseLearningCaseENS.VideoPath; //视频目录
objvCourseLearningCaseENT.ImageUrl = objvCourseLearningCaseENS.ImageUrl; //ImageUrl
objvCourseLearningCaseENT.ResErrMsg = objvCourseLearningCaseENS.ResErrMsg; //资源错误信息
objvCourseLearningCaseENT.OrderNum = objvCourseLearningCaseENS.OrderNum; //序号
objvCourseLearningCaseENT.UpdDate = objvCourseLearningCaseENS.UpdDate; //修改日期
objvCourseLearningCaseENT.UpdUserId = objvCourseLearningCaseENS.UpdUserId; //修改用户Id
objvCourseLearningCaseENT.Memo = objvCourseLearningCaseENS.Memo; //备注
objvCourseLearningCaseENT.IsHaveVideo = objvCourseLearningCaseENS.IsHaveVideo; //IsHaveVideo
objvCourseLearningCaseENT.BrowseCount4Case = objvCourseLearningCaseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCaseENT.OwnerName = objvCourseLearningCaseENS.OwnerName; //拥有者姓名
objvCourseLearningCaseENT.OwnerNameWithId = objvCourseLearningCaseENS.OwnerNameWithId; //拥有者名称附Id
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
public static DataTable ToDataTable(List<clsvCourseLearningCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningCaseEN.AttributeName)
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
//if (arrvCourseLearningCaseObjLst_Cache == null)
//{
//arrvCourseLearningCaseObjLst_Cache = await clsvCourseLearningCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCourseLearningCaseEN._CurrTabName_S);
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
public static List<clsvCourseLearningCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCaseEN._CurrTabName_S);
List<clsvCourseLearningCaseEN> arrvCourseLearningCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningCase.Id_CourseLearningCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseLearningCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseLearningCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseLearningCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseLearningCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseLearningCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseLearningCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseLearningCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.id_CourseLearningCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseLearningCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCourseLearningCase.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCase.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.ImageUrl, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.IsHaveVideo, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase.OwnerNameWithId, Type.GetType("System.String"));
foreach (clsvCourseLearningCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningCase.Id_CourseLearningCase] = objInFor[convCourseLearningCase.Id_CourseLearningCase];
objDR[convCourseLearningCase.CourseLearningCaseID] = objInFor[convCourseLearningCase.CourseLearningCaseID];
objDR[convCourseLearningCase.CourseLearningCaseName] = objInFor[convCourseLearningCase.CourseLearningCaseName];
objDR[convCourseLearningCase.CourseLearningCaseText] = objInFor[convCourseLearningCase.CourseLearningCaseText];
objDR[convCourseLearningCase.CourseLearningCaseTheme] = objInFor[convCourseLearningCase.CourseLearningCaseTheme];
objDR[convCourseLearningCase.CourseLearningCaseDate] = objInFor[convCourseLearningCase.CourseLearningCaseDate];
objDR[convCourseLearningCase.CourseLearningCaseTime] = objInFor[convCourseLearningCase.CourseLearningCaseTime];
objDR[convCourseLearningCase.CourseLearningCaseDateIn] = objInFor[convCourseLearningCase.CourseLearningCaseDateIn];
objDR[convCourseLearningCase.CourseLearningCaseTimeIn] = objInFor[convCourseLearningCase.CourseLearningCaseTimeIn];
objDR[convCourseLearningCase.Id_CaseType] = objInFor[convCourseLearningCase.Id_CaseType];
objDR[convCourseLearningCase.CaseTypeName] = objInFor[convCourseLearningCase.CaseTypeName];
objDR[convCourseLearningCase.id_CourseLearningCaseType] = objInFor[convCourseLearningCase.id_CourseLearningCaseType];
objDR[convCourseLearningCase.CourseLearningCaseTypeName] = objInFor[convCourseLearningCase.CourseLearningCaseTypeName];
objDR[convCourseLearningCase.OwnerId] = objInFor[convCourseLearningCase.OwnerId];
objDR[convCourseLearningCase.id_StudyLevel] = objInFor[convCourseLearningCase.id_StudyLevel];
objDR[convCourseLearningCase.StudyLevelName] = objInFor[convCourseLearningCase.StudyLevelName];
objDR[convCourseLearningCase.id_TeachingPlan] = objInFor[convCourseLearningCase.id_TeachingPlan];
objDR[convCourseLearningCase.id_Discipline] = objInFor[convCourseLearningCase.id_Discipline];
objDR[convCourseLearningCase.DisciplineID] = objInFor[convCourseLearningCase.DisciplineID];
objDR[convCourseLearningCase.DisciplineName] = objInFor[convCourseLearningCase.DisciplineName];
objDR[convCourseLearningCase.id_SenateGaugeVersion] = objInFor[convCourseLearningCase.id_SenateGaugeVersion];
objDR[convCourseLearningCase.senateGaugeVersionID] = objInFor[convCourseLearningCase.senateGaugeVersionID];
objDR[convCourseLearningCase.senateGaugeVersionName] = objInFor[convCourseLearningCase.senateGaugeVersionName];
objDR[convCourseLearningCase.senateGaugeVersionTtlScore] = objInFor[convCourseLearningCase.senateGaugeVersionTtlScore];
objDR[convCourseLearningCase.IsUse] = objInFor[convCourseLearningCase.IsUse];
objDR[convCourseLearningCase.VersionNo] = objInFor[convCourseLearningCase.VersionNo];
objDR[convCourseLearningCase.id_TeachSkill] = objInFor[convCourseLearningCase.id_TeachSkill];
objDR[convCourseLearningCase.TeachSkillID] = objInFor[convCourseLearningCase.TeachSkillID];
objDR[convCourseLearningCase.SkillTypeName] = objInFor[convCourseLearningCase.SkillTypeName];
objDR[convCourseLearningCase.TeachSkillName] = objInFor[convCourseLearningCase.TeachSkillName];
objDR[convCourseLearningCase.TeachSkillTheory] = objInFor[convCourseLearningCase.TeachSkillTheory];
objDR[convCourseLearningCase.TeachSkillOperMethod] = objInFor[convCourseLearningCase.TeachSkillOperMethod];
objDR[convCourseLearningCase.id_SkillType] = objInFor[convCourseLearningCase.id_SkillType];
objDR[convCourseLearningCase.SkillTypeID] = objInFor[convCourseLearningCase.SkillTypeID];
objDR[convCourseLearningCase.CaseLevelId] = objInFor[convCourseLearningCase.CaseLevelId];
objDR[convCourseLearningCase.CaseLevelName] = objInFor[convCourseLearningCase.CaseLevelName];
objDR[convCourseLearningCase.DocFile] = objInFor[convCourseLearningCase.DocFile];
objDR[convCourseLearningCase.IsNeedGeneWord] = objInFor[convCourseLearningCase.IsNeedGeneWord];
objDR[convCourseLearningCase.WordCreateDate] = objInFor[convCourseLearningCase.WordCreateDate];
objDR[convCourseLearningCase.IsVisible] = objInFor[convCourseLearningCase.IsVisible];
objDR[convCourseLearningCase.IsDualVideo] = objInFor[convCourseLearningCase.IsDualVideo];
objDR[convCourseLearningCase.id_XzCollege] = objInFor[convCourseLearningCase.id_XzCollege];
objDR[convCourseLearningCase.CollegeID] = objInFor[convCourseLearningCase.CollegeID];
objDR[convCourseLearningCase.CollegeName] = objInFor[convCourseLearningCase.CollegeName];
objDR[convCourseLearningCase.CollegeNameA] = objInFor[convCourseLearningCase.CollegeNameA];
objDR[convCourseLearningCase.id_XzMajor] = objInFor[convCourseLearningCase.id_XzMajor];
objDR[convCourseLearningCase.MajorID] = objInFor[convCourseLearningCase.MajorID];
objDR[convCourseLearningCase.MajorName] = objInFor[convCourseLearningCase.MajorName];
objDR[convCourseLearningCase.CourseId] = objInFor[convCourseLearningCase.CourseId];
objDR[convCourseLearningCase.CourseCode] = objInFor[convCourseLearningCase.CourseCode];
objDR[convCourseLearningCase.CourseName] = objInFor[convCourseLearningCase.CourseName];
objDR[convCourseLearningCase.CourseChapterId] = objInFor[convCourseLearningCase.CourseChapterId];
objDR[convCourseLearningCase.CourseChapterName] = objInFor[convCourseLearningCase.CourseChapterName];
objDR[convCourseLearningCase.ChapterId] = objInFor[convCourseLearningCase.ChapterId];
objDR[convCourseLearningCase.SectionId] = objInFor[convCourseLearningCase.SectionId];
objDR[convCourseLearningCase.ChapterName] = objInFor[convCourseLearningCase.ChapterName];
objDR[convCourseLearningCase.SectionName] = objInFor[convCourseLearningCase.SectionName];
objDR[convCourseLearningCase.ChapterName_Sim] = objInFor[convCourseLearningCase.ChapterName_Sim];
objDR[convCourseLearningCase.SectionName_Sim] = objInFor[convCourseLearningCase.SectionName_Sim];
objDR[convCourseLearningCase.ParentNodeID] = objInFor[convCourseLearningCase.ParentNodeID];
objDR[convCourseLearningCase.CourseChapterReferred] = objInFor[convCourseLearningCase.CourseChapterReferred];
objDR[convCourseLearningCase.ParentNodeName] = objInFor[convCourseLearningCase.ParentNodeName];
objDR[convCourseLearningCase.ParentNodeReferred] = objInFor[convCourseLearningCase.ParentNodeReferred];
objDR[convCourseLearningCase.ViewCount] = objInFor[convCourseLearningCase.ViewCount];
objDR[convCourseLearningCase.IsShow] = objInFor[convCourseLearningCase.IsShow];
objDR[convCourseLearningCase.DownloadNumber] = objInFor[convCourseLearningCase.DownloadNumber];
objDR[convCourseLearningCase.FileIntegration] = objInFor[convCourseLearningCase.FileIntegration];
objDR[convCourseLearningCase.LikeCount] = objInFor[convCourseLearningCase.LikeCount];
objDR[convCourseLearningCase.CollectionCount] = objInFor[convCourseLearningCase.CollectionCount];
objDR[convCourseLearningCase.RecommendedDegreeId] = objInFor[convCourseLearningCase.RecommendedDegreeId];
objDR[convCourseLearningCase.RecommendedDegreeName] = objInFor[convCourseLearningCase.RecommendedDegreeName];
objDR[convCourseLearningCase.ftpFileType] = objInFor[convCourseLearningCase.ftpFileType];
objDR[convCourseLearningCase.VideoUrl] = objInFor[convCourseLearningCase.VideoUrl];
objDR[convCourseLearningCase.VideoPath] = objInFor[convCourseLearningCase.VideoPath];
objDR[convCourseLearningCase.ImageUrl] = objInFor[convCourseLearningCase.ImageUrl];
objDR[convCourseLearningCase.ResErrMsg] = objInFor[convCourseLearningCase.ResErrMsg];
objDR[convCourseLearningCase.OrderNum] = objInFor[convCourseLearningCase.OrderNum];
objDR[convCourseLearningCase.UpdDate] = objInFor[convCourseLearningCase.UpdDate];
objDR[convCourseLearningCase.UpdUserId] = objInFor[convCourseLearningCase.UpdUserId];
objDR[convCourseLearningCase.Memo] = objInFor[convCourseLearningCase.Memo];
objDR[convCourseLearningCase.IsHaveVideo] = objInFor[convCourseLearningCase.IsHaveVideo];
objDR[convCourseLearningCase.BrowseCount4Case] = objInFor[convCourseLearningCase.BrowseCount4Case];
objDR[convCourseLearningCase.OwnerName] = objInFor[convCourseLearningCase.OwnerName];
objDR[convCourseLearningCase.OwnerNameWithId] = objInFor[convCourseLearningCase.OwnerNameWithId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}