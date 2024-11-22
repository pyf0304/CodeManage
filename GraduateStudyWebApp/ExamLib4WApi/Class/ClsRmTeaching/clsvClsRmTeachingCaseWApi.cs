
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCaseWApi
 表名:vClsRmTeachingCase(01120382)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:32
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
public static class clsvClsRmTeachingCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetId_ClsRmTeachingCase(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strId_ClsRmTeachingCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_ClsRmTeachingCase, 8, convClsRmTeachingCase.Id_ClsRmTeachingCase);
clsCheckSql.CheckFieldForeignKey(strId_ClsRmTeachingCase, 8, convClsRmTeachingCase.Id_ClsRmTeachingCase);
objvClsRmTeachingCaseEN.Id_ClsRmTeachingCase = strId_ClsRmTeachingCase; //课堂教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.Id_ClsRmTeachingCase) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.Id_ClsRmTeachingCase, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.Id_ClsRmTeachingCase] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsRmTeachingCaseID, convClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseID, 8, convClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseID, 8, convClsRmTeachingCase.ClsRmTeachingCaseID);
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = strClsRmTeachingCaseID; //课堂教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.ClsRmTeachingCaseID) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.ClsRmTeachingCaseID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsRmTeachingCaseName, convClsRmTeachingCase.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseName, 100, convClsRmTeachingCase.ClsRmTeachingCaseName);
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = strClsRmTeachingCaseName; //课堂教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.ClsRmTeachingCaseName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.ClsRmTeachingCaseName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseTheme(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTheme, 200, convClsRmTeachingCase.ClsRmTeachingCaseTheme);
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = strClsRmTeachingCaseTheme; //课堂教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.ClsRmTeachingCaseTheme) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.ClsRmTeachingCaseTheme, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTheme] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_ClsRmTeachingCaseType(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_ClsRmTeachingCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ClsRmTeachingCaseType, convClsRmTeachingCase.id_ClsRmTeachingCaseType);
clsCheckSql.CheckFieldLen(strid_ClsRmTeachingCaseType, 4, convClsRmTeachingCase.id_ClsRmTeachingCaseType);
clsCheckSql.CheckFieldForeignKey(strid_ClsRmTeachingCaseType, 4, convClsRmTeachingCase.id_ClsRmTeachingCaseType);
objvClsRmTeachingCaseEN.id_ClsRmTeachingCaseType = strid_ClsRmTeachingCaseType; //课堂案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_ClsRmTeachingCaseType) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_ClsRmTeachingCaseType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_ClsRmTeachingCaseType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseTypeName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTypeName, 30, convClsRmTeachingCase.ClsRmTeachingCaseTypeName);
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = strClsRmTeachingCaseTypeName; //课堂案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.ClsRmTeachingCaseTypeName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.ClsRmTeachingCaseTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseText(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseText, 8000, convClsRmTeachingCase.ClsRmTeachingCaseText);
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = strClsRmTeachingCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.ClsRmTeachingCaseText) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.ClsRmTeachingCaseText, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseText] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseDate(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDate, 8, convClsRmTeachingCase.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDate, 8, convClsRmTeachingCase.ClsRmTeachingCaseDate);
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = strClsRmTeachingCaseDate; //课堂教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.ClsRmTeachingCaseDate) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.ClsRmTeachingCaseDate, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseDate] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseTime(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTime, 6, convClsRmTeachingCase.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTime, 6, convClsRmTeachingCase.ClsRmTeachingCaseTime);
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = strClsRmTeachingCaseTime; //课堂教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.ClsRmTeachingCaseTime) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.ClsRmTeachingCaseTime, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTime] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseDateIn(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase.ClsRmTeachingCaseDateIn);
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = strClsRmTeachingCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.ClsRmTeachingCaseDateIn) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.ClsRmTeachingCaseDateIn, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseTimeIn(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = strClsRmTeachingCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.ClsRmTeachingCaseTimeIn) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.ClsRmTeachingCaseTimeIn, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_StudyLevel(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convClsRmTeachingCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convClsRmTeachingCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convClsRmTeachingCase.id_StudyLevel);
objvClsRmTeachingCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_StudyLevel) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_StudyLevel, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_StudyLevel] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetStudyLevelName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convClsRmTeachingCase.StudyLevelName);
objvClsRmTeachingCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.StudyLevelName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.StudyLevelName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.StudyLevelName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_TeachingPlan(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convClsRmTeachingCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convClsRmTeachingCase.id_TeachingPlan);
objvClsRmTeachingCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_TeachingPlan) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetId_CaseType(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convClsRmTeachingCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convClsRmTeachingCase.Id_CaseType);
objvClsRmTeachingCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.Id_CaseType) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.Id_CaseType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.Id_CaseType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_Discipline(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convClsRmTeachingCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convClsRmTeachingCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convClsRmTeachingCase.id_Discipline);
objvClsRmTeachingCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_Discipline) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_Discipline, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_Discipline] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetDisciplineID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convClsRmTeachingCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convClsRmTeachingCase.DisciplineID);
objvClsRmTeachingCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.DisciplineID) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.DisciplineID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.DisciplineID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_School_Ps(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_School_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School_Ps, 4, convClsRmTeachingCase.id_School_Ps);
clsCheckSql.CheckFieldForeignKey(strid_School_Ps, 4, convClsRmTeachingCase.id_School_Ps);
objvClsRmTeachingCaseEN.id_School_Ps = strid_School_Ps; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_School_Ps) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_School_Ps, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_School_Ps] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetSchoolId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convClsRmTeachingCase.SchoolId);
objvClsRmTeachingCaseEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.SchoolId) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.SchoolId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.SchoolId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetSchoolName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convClsRmTeachingCase.SchoolName);
objvClsRmTeachingCaseEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.SchoolName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.SchoolName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.SchoolName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_Discipline_Ps(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_Discipline_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline_Ps, 4, convClsRmTeachingCase.id_Discipline_Ps);
clsCheckSql.CheckFieldForeignKey(strid_Discipline_Ps, 4, convClsRmTeachingCase.id_Discipline_Ps);
objvClsRmTeachingCaseEN.id_Discipline_Ps = strid_Discipline_Ps; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_Discipline_Ps) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_Discipline_Ps, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_Discipline_Ps] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetDisciplineName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convClsRmTeachingCase.DisciplineName);
objvClsRmTeachingCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.DisciplineName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.DisciplineName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.DisciplineName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_GradeBase(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convClsRmTeachingCase.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convClsRmTeachingCase.id_GradeBase);
objvClsRmTeachingCaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_GradeBase) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_GradeBase, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_GradeBase] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_SenateGaugeVersion(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convClsRmTeachingCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convClsRmTeachingCase.id_SenateGaugeVersion);
objvClsRmTeachingCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_SenateGaugeVersion) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetsenateGaugeVersionID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convClsRmTeachingCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convClsRmTeachingCase.senateGaugeVersionID);
objvClsRmTeachingCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.senateGaugeVersionID) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetsenateGaugeVersionName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convClsRmTeachingCase.senateGaugeVersionName);
objvClsRmTeachingCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.senateGaugeVersionName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetsenateGaugeVersionTtlScore(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.senateGaugeVersionTtlScore) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetVersionNo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, int intVersionNo, string strComparisonOp="")
	{
objvClsRmTeachingCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.VersionNo) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.VersionNo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.VersionNo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_TeachSkill(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convClsRmTeachingCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convClsRmTeachingCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convClsRmTeachingCase.id_TeachSkill);
objvClsRmTeachingCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_TeachSkill) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_TeachSkill, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_TeachSkill] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetTeachSkillID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convClsRmTeachingCase.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convClsRmTeachingCase.TeachSkillID);
objvClsRmTeachingCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.TeachSkillID) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.TeachSkillID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetSkillTypeName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convClsRmTeachingCase.SkillTypeName);
objvClsRmTeachingCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.SkillTypeName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.SkillTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.SkillTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetTeachSkillName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convClsRmTeachingCase.TeachSkillName);
objvClsRmTeachingCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.TeachSkillName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.TeachSkillName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetTeachSkillTheory(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convClsRmTeachingCase.TeachSkillTheory);
objvClsRmTeachingCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.TeachSkillTheory) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetTeachSkillOperMethod(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convClsRmTeachingCase.TeachSkillOperMethod);
objvClsRmTeachingCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.TeachSkillOperMethod) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_SkillType(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convClsRmTeachingCase.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convClsRmTeachingCase.id_SkillType);
objvClsRmTeachingCaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_SkillType) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_SkillType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_SkillType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetSkillTypeID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convClsRmTeachingCase.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convClsRmTeachingCase.SkillTypeID);
objvClsRmTeachingCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.SkillTypeID) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.SkillTypeID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.SkillTypeID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetCaseLevelId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convClsRmTeachingCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convClsRmTeachingCase.CaseLevelId);
objvClsRmTeachingCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.CaseLevelId) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.CaseLevelId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.CaseLevelId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetCaseLevelName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convClsRmTeachingCase.CaseLevelName);
objvClsRmTeachingCaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.CaseLevelName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.CaseLevelName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.CaseLevelName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetDocFile(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convClsRmTeachingCase.DocFile);
objvClsRmTeachingCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.DocFile) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.DocFile, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.DocFile] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIsNeedGeneWord(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvClsRmTeachingCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IsNeedGeneWord) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetWordCreateDate(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convClsRmTeachingCase.WordCreateDate);
objvClsRmTeachingCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.WordCreateDate) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.WordCreateDate, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.WordCreateDate] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIsVisible(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvClsRmTeachingCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IsVisible) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IsVisible, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IsVisible] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetOwnerId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convClsRmTeachingCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convClsRmTeachingCase.OwnerId);
objvClsRmTeachingCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.OwnerId) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.OwnerId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.OwnerId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_StudentInfo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convClsRmTeachingCase.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convClsRmTeachingCase.id_StudentInfo);
objvClsRmTeachingCaseEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_StudentInfo) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_StudentInfo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_StudentInfo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetStuName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convClsRmTeachingCase.StuName);
objvClsRmTeachingCaseEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.StuName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.StuName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.StuName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetStuID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convClsRmTeachingCase.StuID);
objvClsRmTeachingCaseEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.StuID) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.StuID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.StuID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetPoliticsName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convClsRmTeachingCase.PoliticsName);
objvClsRmTeachingCaseEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.PoliticsName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.PoliticsName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.PoliticsName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetSexDesc(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convClsRmTeachingCase.SexDesc);
objvClsRmTeachingCaseEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.SexDesc) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.SexDesc, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.SexDesc] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetEthnicName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convClsRmTeachingCase.EthnicName);
objvClsRmTeachingCaseEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.EthnicName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.EthnicName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.EthnicName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetUniZoneDesc(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convClsRmTeachingCase.UniZoneDesc);
objvClsRmTeachingCaseEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.UniZoneDesc) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.UniZoneDesc, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.UniZoneDesc] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetStuTypeDesc(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convClsRmTeachingCase.StuTypeDesc);
objvClsRmTeachingCaseEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.StuTypeDesc) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.StuTypeDesc, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.StuTypeDesc] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_XzCollege(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convClsRmTeachingCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convClsRmTeachingCase.id_XzCollege);
objvClsRmTeachingCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_XzCollege) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_XzCollege, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_XzCollege] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetCollegeID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convClsRmTeachingCase.CollegeID);
objvClsRmTeachingCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.CollegeID) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.CollegeID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.CollegeID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetCollegeName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convClsRmTeachingCase.CollegeName);
objvClsRmTeachingCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.CollegeName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.CollegeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.CollegeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetCollegeNameA(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convClsRmTeachingCase.CollegeNameA);
objvClsRmTeachingCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.CollegeNameA) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.CollegeNameA, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.CollegeNameA] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_XzMajor(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convClsRmTeachingCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convClsRmTeachingCase.id_XzMajor);
objvClsRmTeachingCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_XzMajor) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_XzMajor, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_XzMajor] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetMajorName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convClsRmTeachingCase.MajorName);
objvClsRmTeachingCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.MajorName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.MajorName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.MajorName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetGradeBaseName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convClsRmTeachingCase.GradeBaseName);
objvClsRmTeachingCaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.GradeBaseName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.GradeBaseName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.GradeBaseName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_AdminCls(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convClsRmTeachingCase.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convClsRmTeachingCase.id_AdminCls);
objvClsRmTeachingCaseEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_AdminCls) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_AdminCls, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_AdminCls] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetAdminClsId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convClsRmTeachingCase.AdminClsId);
objvClsRmTeachingCaseEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.AdminClsId) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.AdminClsId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.AdminClsId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetAdminClsName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convClsRmTeachingCase.AdminClsName);
objvClsRmTeachingCaseEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.AdminClsName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.AdminClsName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.AdminClsName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetBirthday(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convClsRmTeachingCase.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convClsRmTeachingCase.Birthday);
objvClsRmTeachingCaseEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.Birthday) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.Birthday, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.Birthday] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetNativePlace(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convClsRmTeachingCase.NativePlace);
objvClsRmTeachingCaseEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.NativePlace) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.NativePlace, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.NativePlace] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetDuty(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convClsRmTeachingCase.Duty);
objvClsRmTeachingCaseEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.Duty) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.Duty, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.Duty] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIDCardNo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convClsRmTeachingCase.IDCardNo);
objvClsRmTeachingCaseEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IDCardNo) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IDCardNo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IDCardNo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetStuCardNo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convClsRmTeachingCase.StuCardNo);
objvClsRmTeachingCaseEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.StuCardNo) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.StuCardNo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.StuCardNo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetLiveAddress(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convClsRmTeachingCase.LiveAddress);
objvClsRmTeachingCaseEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.LiveAddress) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.LiveAddress, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.LiveAddress] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetHomePhone(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convClsRmTeachingCase.HomePhone);
objvClsRmTeachingCaseEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.HomePhone) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.HomePhone, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.HomePhone] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetEnrollmentDate(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convClsRmTeachingCase.EnrollmentDate);
objvClsRmTeachingCaseEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.EnrollmentDate) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.EnrollmentDate, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.EnrollmentDate] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetPostCode(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convClsRmTeachingCase.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convClsRmTeachingCase.PostCode);
objvClsRmTeachingCaseEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.PostCode) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.PostCode, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.PostCode] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetUserKindId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convClsRmTeachingCase.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convClsRmTeachingCase.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convClsRmTeachingCase.UserKindId);
objvClsRmTeachingCaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.UserKindId) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.UserKindId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.UserKindId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetUserKindName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convClsRmTeachingCase.UserKindName);
objvClsRmTeachingCaseEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.UserKindName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.UserKindName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.UserKindName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetUserTypeId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convClsRmTeachingCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convClsRmTeachingCase.UserTypeId);
objvClsRmTeachingCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.UserTypeId) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.UserTypeId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.UserTypeId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetUserTypeName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convClsRmTeachingCase.UserTypeName);
objvClsRmTeachingCaseEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.UserTypeName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.UserTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.UserTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIsDualVideo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvClsRmTeachingCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IsDualVideo) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IsDualVideo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IsDualVideo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetRecommendedDegreeId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convClsRmTeachingCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convClsRmTeachingCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convClsRmTeachingCase.RecommendedDegreeId);
objvClsRmTeachingCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.RecommendedDegreeId) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetRecommendedDegreeName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convClsRmTeachingCase.RecommendedDegreeName);
objvClsRmTeachingCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.RecommendedDegreeName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetMemo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClsRmTeachingCase.Memo);
objvClsRmTeachingCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.Memo) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.Memo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.Memo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetDisciplineName_ps(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strDisciplineName_ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName_ps, 50, convClsRmTeachingCase.DisciplineName_ps);
objvClsRmTeachingCaseEN.DisciplineName_ps = strDisciplineName_ps; //学科
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.DisciplineName_ps) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.DisciplineName_ps, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.DisciplineName_ps] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetGradeName_ps(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strGradeName_ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeName_ps, 50, convClsRmTeachingCase.GradeName_ps);
objvClsRmTeachingCaseEN.GradeName_ps = strGradeName_ps; //年级
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.GradeName_ps) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.GradeName_ps, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.GradeName_ps] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN Setid_Grade_ps(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strid_Grade_ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Grade_ps, 4, convClsRmTeachingCase.id_Grade_ps);
clsCheckSql.CheckFieldForeignKey(strid_Grade_ps, 4, convClsRmTeachingCase.id_Grade_ps);
objvClsRmTeachingCaseEN.id_Grade_ps = strid_Grade_ps; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.id_Grade_ps) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.id_Grade_ps, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.id_Grade_ps] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetOwnerName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convClsRmTeachingCase.OwnerName);
objvClsRmTeachingCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.OwnerName) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.OwnerName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.OwnerName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetOwnerNameWithId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convClsRmTeachingCase.OwnerNameWithId);
objvClsRmTeachingCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.OwnerNameWithId) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetBrowseCount4Case(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvClsRmTeachingCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.BrowseCount4Case) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIsHaveVideo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convClsRmTeachingCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convClsRmTeachingCase.IsHaveVideo);
objvClsRmTeachingCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IsHaveVideo) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IsHaveVideo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IsHaveVideo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetftpFileType(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convClsRmTeachingCase.ftpFileType);
objvClsRmTeachingCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.ftpFileType) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.ftpFileType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.ftpFileType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClsRmTeachingCaseEN objvClsRmTeachingCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.Id_ClsRmTeachingCase) == true)
{
string strComparisonOp_Id_ClsRmTeachingCase = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.Id_ClsRmTeachingCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.Id_ClsRmTeachingCase, objvClsRmTeachingCase_Cond.Id_ClsRmTeachingCase, strComparisonOp_Id_ClsRmTeachingCase);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseID) == true)
{
string strComparisonOp_ClsRmTeachingCaseID = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseID, objvClsRmTeachingCase_Cond.ClsRmTeachingCaseID, strComparisonOp_ClsRmTeachingCaseID);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseName) == true)
{
string strComparisonOp_ClsRmTeachingCaseName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseName, objvClsRmTeachingCase_Cond.ClsRmTeachingCaseName, strComparisonOp_ClsRmTeachingCaseName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseTheme) == true)
{
string strComparisonOp_ClsRmTeachingCaseTheme = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseTheme, objvClsRmTeachingCase_Cond.ClsRmTeachingCaseTheme, strComparisonOp_ClsRmTeachingCaseTheme);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_ClsRmTeachingCaseType) == true)
{
string strComparisonOp_id_ClsRmTeachingCaseType = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_ClsRmTeachingCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_ClsRmTeachingCaseType, objvClsRmTeachingCase_Cond.id_ClsRmTeachingCaseType, strComparisonOp_id_ClsRmTeachingCaseType);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseTypeName) == true)
{
string strComparisonOp_ClsRmTeachingCaseTypeName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseTypeName, objvClsRmTeachingCase_Cond.ClsRmTeachingCaseTypeName, strComparisonOp_ClsRmTeachingCaseTypeName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseText) == true)
{
string strComparisonOp_ClsRmTeachingCaseText = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseText, objvClsRmTeachingCase_Cond.ClsRmTeachingCaseText, strComparisonOp_ClsRmTeachingCaseText);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseDate) == true)
{
string strComparisonOp_ClsRmTeachingCaseDate = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseDate, objvClsRmTeachingCase_Cond.ClsRmTeachingCaseDate, strComparisonOp_ClsRmTeachingCaseDate);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseTime) == true)
{
string strComparisonOp_ClsRmTeachingCaseTime = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseTime, objvClsRmTeachingCase_Cond.ClsRmTeachingCaseTime, strComparisonOp_ClsRmTeachingCaseTime);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseDateIn) == true)
{
string strComparisonOp_ClsRmTeachingCaseDateIn = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseDateIn, objvClsRmTeachingCase_Cond.ClsRmTeachingCaseDateIn, strComparisonOp_ClsRmTeachingCaseDateIn);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseTimeIn) == true)
{
string strComparisonOp_ClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseTimeIn, objvClsRmTeachingCase_Cond.ClsRmTeachingCaseTimeIn, strComparisonOp_ClsRmTeachingCaseTimeIn);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_StudyLevel, objvClsRmTeachingCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.StudyLevelName, objvClsRmTeachingCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_TeachingPlan, objvClsRmTeachingCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.Id_CaseType, objvClsRmTeachingCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_Discipline, objvClsRmTeachingCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.DisciplineID, objvClsRmTeachingCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_School_Ps) == true)
{
string strComparisonOp_id_School_Ps = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_School_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_School_Ps, objvClsRmTeachingCase_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.SchoolId, objvClsRmTeachingCase_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.SchoolName, objvClsRmTeachingCase_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_Discipline_Ps) == true)
{
string strComparisonOp_id_Discipline_Ps = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_Discipline_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_Discipline_Ps, objvClsRmTeachingCase_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.DisciplineName, objvClsRmTeachingCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_GradeBase, objvClsRmTeachingCase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_SenateGaugeVersion, objvClsRmTeachingCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.senateGaugeVersionID, objvClsRmTeachingCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.senateGaugeVersionName, objvClsRmTeachingCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase.senateGaugeVersionTtlScore, objvClsRmTeachingCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase.VersionNo, objvClsRmTeachingCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_TeachSkill, objvClsRmTeachingCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.TeachSkillID, objvClsRmTeachingCase_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.SkillTypeName, objvClsRmTeachingCase_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.TeachSkillName, objvClsRmTeachingCase_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.TeachSkillTheory, objvClsRmTeachingCase_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.TeachSkillOperMethod, objvClsRmTeachingCase_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_SkillType, objvClsRmTeachingCase_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.SkillTypeID, objvClsRmTeachingCase_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.CaseLevelId, objvClsRmTeachingCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.CaseLevelName, objvClsRmTeachingCase_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.DocFile, objvClsRmTeachingCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.IsNeedGeneWord) == true)
{
if (objvClsRmTeachingCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase.IsNeedGeneWord);
}
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.WordCreateDate, objvClsRmTeachingCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.IsVisible) == true)
{
if (objvClsRmTeachingCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase.IsVisible);
}
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.OwnerId, objvClsRmTeachingCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_StudentInfo, objvClsRmTeachingCase_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.StuName) == true)
{
string strComparisonOp_StuName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.StuName, objvClsRmTeachingCase_Cond.StuName, strComparisonOp_StuName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.StuID) == true)
{
string strComparisonOp_StuID = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.StuID, objvClsRmTeachingCase_Cond.StuID, strComparisonOp_StuID);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.PoliticsName, objvClsRmTeachingCase_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.SexDesc, objvClsRmTeachingCase_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.EthnicName, objvClsRmTeachingCase_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.UniZoneDesc, objvClsRmTeachingCase_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.StuTypeDesc, objvClsRmTeachingCase_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_XzCollege, objvClsRmTeachingCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.CollegeID, objvClsRmTeachingCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.CollegeName, objvClsRmTeachingCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.CollegeNameA, objvClsRmTeachingCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_XzMajor, objvClsRmTeachingCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.MajorName) == true)
{
string strComparisonOp_MajorName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.MajorName, objvClsRmTeachingCase_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.GradeBaseName, objvClsRmTeachingCase_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_AdminCls, objvClsRmTeachingCase_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.AdminClsId, objvClsRmTeachingCase_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.AdminClsName, objvClsRmTeachingCase_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.Birthday) == true)
{
string strComparisonOp_Birthday = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.Birthday, objvClsRmTeachingCase_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.NativePlace, objvClsRmTeachingCase_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.Duty) == true)
{
string strComparisonOp_Duty = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.Duty, objvClsRmTeachingCase_Cond.Duty, strComparisonOp_Duty);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IDCardNo, objvClsRmTeachingCase_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.StuCardNo, objvClsRmTeachingCase_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.LiveAddress, objvClsRmTeachingCase_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.HomePhone, objvClsRmTeachingCase_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.EnrollmentDate, objvClsRmTeachingCase_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.PostCode) == true)
{
string strComparisonOp_PostCode = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.PostCode, objvClsRmTeachingCase_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.UserKindId, objvClsRmTeachingCase_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.UserKindName, objvClsRmTeachingCase_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.UserTypeId, objvClsRmTeachingCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.UserTypeName, objvClsRmTeachingCase_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.IsDualVideo) == true)
{
if (objvClsRmTeachingCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase.IsDualVideo);
}
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.RecommendedDegreeId, objvClsRmTeachingCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.RecommendedDegreeName, objvClsRmTeachingCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.Memo) == true)
{
string strComparisonOp_Memo = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.Memo, objvClsRmTeachingCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.DisciplineName_ps) == true)
{
string strComparisonOp_DisciplineName_ps = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.DisciplineName_ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.DisciplineName_ps, objvClsRmTeachingCase_Cond.DisciplineName_ps, strComparisonOp_DisciplineName_ps);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.GradeName_ps) == true)
{
string strComparisonOp_GradeName_ps = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.GradeName_ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.GradeName_ps, objvClsRmTeachingCase_Cond.GradeName_ps, strComparisonOp_GradeName_ps);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.id_Grade_ps) == true)
{
string strComparisonOp_id_Grade_ps = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.id_Grade_ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.id_Grade_ps, objvClsRmTeachingCase_Cond.id_Grade_ps, strComparisonOp_id_Grade_ps);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.OwnerName, objvClsRmTeachingCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.OwnerNameWithId, objvClsRmTeachingCase_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase.BrowseCount4Case, objvClsRmTeachingCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IsHaveVideo, objvClsRmTeachingCase_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
if (objvClsRmTeachingCase_Cond.IsUpdated(convClsRmTeachingCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvClsRmTeachingCase_Cond.dicFldComparisonOp[convClsRmTeachingCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ftpFileType, objvClsRmTeachingCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课堂教学案例(vClsRmTeachingCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvClsRmTeachingCaseWApi
{
private static readonly string mstrApiControllerName = "vClsRmTeachingCaseApi";

 public clsvClsRmTeachingCaseWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课堂教学案例]...","0");
List<clsvClsRmTeachingCaseEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convClsRmTeachingCase.Id_ClsRmTeachingCase); 
List<clsvClsRmTeachingCaseEN> arrObjLst = clsvClsRmTeachingCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN()
{
Id_ClsRmTeachingCase = "0",
ClsRmTeachingCaseName = "选[v课堂教学案例]..."
};
arrObjLst.Insert(0, objvClsRmTeachingCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convClsRmTeachingCase.Id_ClsRmTeachingCase;
objComboBox.DisplayMember = convClsRmTeachingCase.ClsRmTeachingCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_ClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClsRmTeachingCaseEN GetObjById_ClsRmTeachingCase(string strId_ClsRmTeachingCase)
{
string strAction = "GetObjById_ClsRmTeachingCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = null;
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
objvClsRmTeachingCaseEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCaseEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCaseEN;
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
public static clsvClsRmTeachingCaseEN GetObjById_ClsRmTeachingCase_WA_Cache(string strId_ClsRmTeachingCase)
{
string strAction = "GetObjById_ClsRmTeachingCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = null;
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
objvClsRmTeachingCaseEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCaseEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCaseEN;
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
public static clsvClsRmTeachingCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = null;
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
objvClsRmTeachingCaseEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCaseEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCaseEN;
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
public static clsvClsRmTeachingCaseEN GetObjById_ClsRmTeachingCase_Cache(string strId_ClsRmTeachingCase)
{
if (string.IsNullOrEmpty(strId_ClsRmTeachingCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvClsRmTeachingCaseEN._CurrTabName_S);
List<clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Sel =
from objvClsRmTeachingCaseEN in arrvClsRmTeachingCaseObjLst_Cache
where objvClsRmTeachingCaseEN.Id_ClsRmTeachingCase == strId_ClsRmTeachingCase
select objvClsRmTeachingCaseEN;
if (arrvClsRmTeachingCaseObjLst_Sel.Count() == 0)
{
   clsvClsRmTeachingCaseEN obj = clsvClsRmTeachingCaseWApi.GetObjById_ClsRmTeachingCase(strId_ClsRmTeachingCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvClsRmTeachingCaseObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsvClsRmTeachingCaseEN._CurrTabName_S);
List<clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Sel1 =
from objvClsRmTeachingCaseEN in arrvClsRmTeachingCaseObjLst_Cache
where objvClsRmTeachingCaseEN.Id_ClsRmTeachingCase == strId_ClsRmTeachingCase
select objvClsRmTeachingCaseEN;
List <clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Sel = new List<clsvClsRmTeachingCaseEN>();
foreach (clsvClsRmTeachingCaseEN obj in arrvClsRmTeachingCaseObjLst_Sel1)
{
arrvClsRmTeachingCaseObjLst_Sel.Add(obj);
}
if (arrvClsRmTeachingCaseObjLst_Sel.Count > 0)
{
return arrvClsRmTeachingCaseObjLst_Sel[0].ClsRmTeachingCaseName;
}
string strErrMsgForGetObjById = string.Format("在vClsRmTeachingCase对象缓存列表中,找不到记录[Id_ClsRmTeachingCase = {0}](函数:{1})", strId_ClsRmTeachingCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvClsRmTeachingCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsvClsRmTeachingCaseEN._CurrTabName_S);
List<clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Sel1 =
from objvClsRmTeachingCaseEN in arrvClsRmTeachingCaseObjLst_Cache
where objvClsRmTeachingCaseEN.Id_ClsRmTeachingCase == strId_ClsRmTeachingCase
select objvClsRmTeachingCaseEN;
List <clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Sel = new List<clsvClsRmTeachingCaseEN>();
foreach (clsvClsRmTeachingCaseEN obj in arrvClsRmTeachingCaseObjLst_Sel1)
{
arrvClsRmTeachingCaseObjLst_Sel.Add(obj);
}
if (arrvClsRmTeachingCaseObjLst_Sel.Count > 0)
{
return arrvClsRmTeachingCaseObjLst_Sel[0].ClsRmTeachingCaseName;
}
string strErrMsgForGetObjById = string.Format("在vClsRmTeachingCase对象缓存列表中,找不到记录的相关名称[Id_ClsRmTeachingCase = {0}](函数:{1})", strId_ClsRmTeachingCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvClsRmTeachingCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseEN> GetObjLstById_ClsRmTeachingCaseLst(List<string> arrId_ClsRmTeachingCase)
{
 List<clsvClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvClsRmTeachingCaseEN> GetObjLstById_ClsRmTeachingCaseLst_Cache(List<string> arrId_ClsRmTeachingCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClsRmTeachingCaseEN._CurrTabName_S);
List<clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Sel =
from objvClsRmTeachingCaseEN in arrvClsRmTeachingCaseObjLst_Cache
where arrId_ClsRmTeachingCase.Contains(objvClsRmTeachingCaseEN.Id_ClsRmTeachingCase)
select objvClsRmTeachingCaseEN;
return arrvClsRmTeachingCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCaseEN> GetObjLstById_ClsRmTeachingCaseLst_WA_Cache(List<string> arrId_ClsRmTeachingCase)
{
 List<clsvClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvClsRmTeachingCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseENS">源对象</param>
 /// <param name = "objvClsRmTeachingCaseENT">目标对象</param>
 public static void CopyTo(clsvClsRmTeachingCaseEN objvClsRmTeachingCaseENS, clsvClsRmTeachingCaseEN objvClsRmTeachingCaseENT)
{
try
{
objvClsRmTeachingCaseENT.Id_ClsRmTeachingCase = objvClsRmTeachingCaseENS.Id_ClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCaseENT.ClsRmTeachingCaseID = objvClsRmTeachingCaseENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCaseENT.ClsRmTeachingCaseName = objvClsRmTeachingCaseENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCaseENT.id_ClsRmTeachingCaseType = objvClsRmTeachingCaseENS.id_ClsRmTeachingCaseType; //课堂案例类型流水号
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCaseENT.ClsRmTeachingCaseText = objvClsRmTeachingCaseENS.ClsRmTeachingCaseText; //案例文本内容
objvClsRmTeachingCaseENT.ClsRmTeachingCaseDate = objvClsRmTeachingCaseENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTime = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCaseENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCaseENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCaseENT.id_StudyLevel = objvClsRmTeachingCaseENS.id_StudyLevel; //id_StudyLevel
objvClsRmTeachingCaseENT.StudyLevelName = objvClsRmTeachingCaseENS.StudyLevelName; //学段名称
objvClsRmTeachingCaseENT.id_TeachingPlan = objvClsRmTeachingCaseENS.id_TeachingPlan; //教案流水号
objvClsRmTeachingCaseENT.Id_CaseType = objvClsRmTeachingCaseENS.Id_CaseType; //案例类型流水号
objvClsRmTeachingCaseENT.id_Discipline = objvClsRmTeachingCaseENS.id_Discipline; //学科流水号
objvClsRmTeachingCaseENT.DisciplineID = objvClsRmTeachingCaseENS.DisciplineID; //学科ID
objvClsRmTeachingCaseENT.id_School_Ps = objvClsRmTeachingCaseENS.id_School_Ps; //学校流水号
objvClsRmTeachingCaseENT.SchoolId = objvClsRmTeachingCaseENS.SchoolId; //学校编号
objvClsRmTeachingCaseENT.SchoolName = objvClsRmTeachingCaseENS.SchoolName; //学校名称
objvClsRmTeachingCaseENT.id_Discipline_Ps = objvClsRmTeachingCaseENS.id_Discipline_Ps; //学科流水号
objvClsRmTeachingCaseENT.DisciplineName = objvClsRmTeachingCaseENS.DisciplineName; //学科名称
objvClsRmTeachingCaseENT.id_GradeBase = objvClsRmTeachingCaseENS.id_GradeBase; //年级流水号
objvClsRmTeachingCaseENT.id_SenateGaugeVersion = objvClsRmTeachingCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvClsRmTeachingCaseENT.senateGaugeVersionID = objvClsRmTeachingCaseENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCaseENT.senateGaugeVersionName = objvClsRmTeachingCaseENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCaseENT.senateGaugeVersionTtlScore = objvClsRmTeachingCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCaseENT.VersionNo = objvClsRmTeachingCaseENS.VersionNo; //版本号
objvClsRmTeachingCaseENT.id_TeachSkill = objvClsRmTeachingCaseENS.id_TeachSkill; //教学技能流水号
objvClsRmTeachingCaseENT.TeachSkillID = objvClsRmTeachingCaseENS.TeachSkillID; //教学技能ID
objvClsRmTeachingCaseENT.SkillTypeName = objvClsRmTeachingCaseENS.SkillTypeName; //技能类型名称
objvClsRmTeachingCaseENT.TeachSkillName = objvClsRmTeachingCaseENS.TeachSkillName; //教学技能名称
objvClsRmTeachingCaseENT.TeachSkillTheory = objvClsRmTeachingCaseENS.TeachSkillTheory; //教学技能理论阐述
objvClsRmTeachingCaseENT.TeachSkillOperMethod = objvClsRmTeachingCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvClsRmTeachingCaseENT.id_SkillType = objvClsRmTeachingCaseENS.id_SkillType; //技能类型流水号
objvClsRmTeachingCaseENT.SkillTypeID = objvClsRmTeachingCaseENS.SkillTypeID; //技能类型ID
objvClsRmTeachingCaseENT.CaseLevelId = objvClsRmTeachingCaseENS.CaseLevelId; //课例等级Id
objvClsRmTeachingCaseENT.CaseLevelName = objvClsRmTeachingCaseENS.CaseLevelName; //案例等级名称
objvClsRmTeachingCaseENT.DocFile = objvClsRmTeachingCaseENS.DocFile; //生成的Word文件名
objvClsRmTeachingCaseENT.IsNeedGeneWord = objvClsRmTeachingCaseENS.IsNeedGeneWord; //是否需要生成Word
objvClsRmTeachingCaseENT.WordCreateDate = objvClsRmTeachingCaseENS.WordCreateDate; //Word生成日期
objvClsRmTeachingCaseENT.IsVisible = objvClsRmTeachingCaseENS.IsVisible; //是否显示
objvClsRmTeachingCaseENT.OwnerId = objvClsRmTeachingCaseENS.OwnerId; //拥有者Id
objvClsRmTeachingCaseENT.id_StudentInfo = objvClsRmTeachingCaseENS.id_StudentInfo; //学生流水号
objvClsRmTeachingCaseENT.StuName = objvClsRmTeachingCaseENS.StuName; //姓名
objvClsRmTeachingCaseENT.StuID = objvClsRmTeachingCaseENS.StuID; //学号
objvClsRmTeachingCaseENT.PoliticsName = objvClsRmTeachingCaseENS.PoliticsName; //政治面貌
objvClsRmTeachingCaseENT.SexDesc = objvClsRmTeachingCaseENS.SexDesc; //性别名称
objvClsRmTeachingCaseENT.EthnicName = objvClsRmTeachingCaseENS.EthnicName; //民族名称
objvClsRmTeachingCaseENT.UniZoneDesc = objvClsRmTeachingCaseENS.UniZoneDesc; //校区名称
objvClsRmTeachingCaseENT.StuTypeDesc = objvClsRmTeachingCaseENS.StuTypeDesc; //学生类别名称
objvClsRmTeachingCaseENT.id_XzCollege = objvClsRmTeachingCaseENS.id_XzCollege; //学院流水号
objvClsRmTeachingCaseENT.CollegeID = objvClsRmTeachingCaseENS.CollegeID; //学院ID
objvClsRmTeachingCaseENT.CollegeName = objvClsRmTeachingCaseENS.CollegeName; //学院名称
objvClsRmTeachingCaseENT.CollegeNameA = objvClsRmTeachingCaseENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCaseENT.id_XzMajor = objvClsRmTeachingCaseENS.id_XzMajor; //专业流水号
objvClsRmTeachingCaseENT.MajorName = objvClsRmTeachingCaseENS.MajorName; //专业名称
objvClsRmTeachingCaseENT.GradeBaseName = objvClsRmTeachingCaseENS.GradeBaseName; //年级名称
objvClsRmTeachingCaseENT.id_AdminCls = objvClsRmTeachingCaseENS.id_AdminCls; //行政班流水号
objvClsRmTeachingCaseENT.AdminClsId = objvClsRmTeachingCaseENS.AdminClsId; //行政班代号
objvClsRmTeachingCaseENT.AdminClsName = objvClsRmTeachingCaseENS.AdminClsName; //行政班名称
objvClsRmTeachingCaseENT.Birthday = objvClsRmTeachingCaseENS.Birthday; //出生日期
objvClsRmTeachingCaseENT.NativePlace = objvClsRmTeachingCaseENS.NativePlace; //籍贯
objvClsRmTeachingCaseENT.Duty = objvClsRmTeachingCaseENS.Duty; //职位
objvClsRmTeachingCaseENT.IDCardNo = objvClsRmTeachingCaseENS.IDCardNo; //身份证号
objvClsRmTeachingCaseENT.StuCardNo = objvClsRmTeachingCaseENS.StuCardNo; //学生证号
objvClsRmTeachingCaseENT.LiveAddress = objvClsRmTeachingCaseENS.LiveAddress; //居住地址
objvClsRmTeachingCaseENT.HomePhone = objvClsRmTeachingCaseENS.HomePhone; //住宅电话
objvClsRmTeachingCaseENT.EnrollmentDate = objvClsRmTeachingCaseENS.EnrollmentDate; //入校日期
objvClsRmTeachingCaseENT.PostCode = objvClsRmTeachingCaseENS.PostCode; //邮编
objvClsRmTeachingCaseENT.UserKindId = objvClsRmTeachingCaseENS.UserKindId; //用户类别Id
objvClsRmTeachingCaseENT.UserKindName = objvClsRmTeachingCaseENS.UserKindName; //用户类别名
objvClsRmTeachingCaseENT.UserTypeId = objvClsRmTeachingCaseENS.UserTypeId; //用户类型Id
objvClsRmTeachingCaseENT.UserTypeName = objvClsRmTeachingCaseENS.UserTypeName; //用户类型名称
objvClsRmTeachingCaseENT.IsDualVideo = objvClsRmTeachingCaseENS.IsDualVideo; //是否双视频
objvClsRmTeachingCaseENT.RecommendedDegreeId = objvClsRmTeachingCaseENS.RecommendedDegreeId; //推荐度Id
objvClsRmTeachingCaseENT.RecommendedDegreeName = objvClsRmTeachingCaseENS.RecommendedDegreeName; //推荐度名称
objvClsRmTeachingCaseENT.Memo = objvClsRmTeachingCaseENS.Memo; //备注
objvClsRmTeachingCaseENT.DisciplineName_ps = objvClsRmTeachingCaseENS.DisciplineName_ps; //学科
objvClsRmTeachingCaseENT.GradeName_ps = objvClsRmTeachingCaseENS.GradeName_ps; //年级
objvClsRmTeachingCaseENT.id_Grade_ps = objvClsRmTeachingCaseENS.id_Grade_ps; //年级流水号
objvClsRmTeachingCaseENT.OwnerName = objvClsRmTeachingCaseENS.OwnerName; //拥有者姓名
objvClsRmTeachingCaseENT.OwnerNameWithId = objvClsRmTeachingCaseENS.OwnerNameWithId; //拥有者名称附Id
objvClsRmTeachingCaseENT.BrowseCount4Case = objvClsRmTeachingCaseENS.BrowseCount4Case; //课例浏览次数
objvClsRmTeachingCaseENT.IsHaveVideo = objvClsRmTeachingCaseENS.IsHaveVideo; //IsHaveVideo
objvClsRmTeachingCaseENT.ftpFileType = objvClsRmTeachingCaseENS.ftpFileType; //ftp文件类型
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
public static DataTable ToDataTable(List<clsvClsRmTeachingCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvClsRmTeachingCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvClsRmTeachingCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvClsRmTeachingCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvClsRmTeachingCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvClsRmTeachingCaseEN.AttributeName)
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
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGrade_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGrade_psWApi没有刷新缓存机制(clsXzGrade_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClsRmTeachingCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClsRmTeachingCaseWApi没有刷新缓存机制(clsClsRmTeachingCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClsRmTeachingCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClsRmTeachingCaseTypeWApi没有刷新缓存机制(clsClsRmTeachingCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_ClsRmTeachingCase");
//if (arrvClsRmTeachingCaseObjLst_Cache == null)
//{
//arrvClsRmTeachingCaseObjLst_Cache = await clsvClsRmTeachingCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvClsRmTeachingCaseEN._CurrTabName_S);
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
public static List<clsvClsRmTeachingCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvClsRmTeachingCaseEN._CurrTabName_S);
List<clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClsRmTeachingCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvClsRmTeachingCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convClsRmTeachingCase.Id_ClsRmTeachingCase, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.ClsRmTeachingCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.ClsRmTeachingCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.ClsRmTeachingCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_ClsRmTeachingCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.ClsRmTeachingCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.ClsRmTeachingCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.ClsRmTeachingCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.ClsRmTeachingCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.ClsRmTeachingCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.ClsRmTeachingCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_School_Ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_Discipline_Ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convClsRmTeachingCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convClsRmTeachingCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.DisciplineName_ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.GradeName_ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.id_Grade_ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convClsRmTeachingCase.IsHaveVideo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase.ftpFileType, Type.GetType("System.String"));
foreach (clsvClsRmTeachingCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convClsRmTeachingCase.Id_ClsRmTeachingCase] = objInFor[convClsRmTeachingCase.Id_ClsRmTeachingCase];
objDR[convClsRmTeachingCase.ClsRmTeachingCaseID] = objInFor[convClsRmTeachingCase.ClsRmTeachingCaseID];
objDR[convClsRmTeachingCase.ClsRmTeachingCaseName] = objInFor[convClsRmTeachingCase.ClsRmTeachingCaseName];
objDR[convClsRmTeachingCase.ClsRmTeachingCaseTheme] = objInFor[convClsRmTeachingCase.ClsRmTeachingCaseTheme];
objDR[convClsRmTeachingCase.id_ClsRmTeachingCaseType] = objInFor[convClsRmTeachingCase.id_ClsRmTeachingCaseType];
objDR[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] = objInFor[convClsRmTeachingCase.ClsRmTeachingCaseTypeName];
objDR[convClsRmTeachingCase.ClsRmTeachingCaseText] = objInFor[convClsRmTeachingCase.ClsRmTeachingCaseText];
objDR[convClsRmTeachingCase.ClsRmTeachingCaseDate] = objInFor[convClsRmTeachingCase.ClsRmTeachingCaseDate];
objDR[convClsRmTeachingCase.ClsRmTeachingCaseTime] = objInFor[convClsRmTeachingCase.ClsRmTeachingCaseTime];
objDR[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] = objInFor[convClsRmTeachingCase.ClsRmTeachingCaseDateIn];
objDR[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] = objInFor[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn];
objDR[convClsRmTeachingCase.id_StudyLevel] = objInFor[convClsRmTeachingCase.id_StudyLevel];
objDR[convClsRmTeachingCase.StudyLevelName] = objInFor[convClsRmTeachingCase.StudyLevelName];
objDR[convClsRmTeachingCase.id_TeachingPlan] = objInFor[convClsRmTeachingCase.id_TeachingPlan];
objDR[convClsRmTeachingCase.Id_CaseType] = objInFor[convClsRmTeachingCase.Id_CaseType];
objDR[convClsRmTeachingCase.id_Discipline] = objInFor[convClsRmTeachingCase.id_Discipline];
objDR[convClsRmTeachingCase.DisciplineID] = objInFor[convClsRmTeachingCase.DisciplineID];
objDR[convClsRmTeachingCase.id_School_Ps] = objInFor[convClsRmTeachingCase.id_School_Ps];
objDR[convClsRmTeachingCase.SchoolId] = objInFor[convClsRmTeachingCase.SchoolId];
objDR[convClsRmTeachingCase.SchoolName] = objInFor[convClsRmTeachingCase.SchoolName];
objDR[convClsRmTeachingCase.id_Discipline_Ps] = objInFor[convClsRmTeachingCase.id_Discipline_Ps];
objDR[convClsRmTeachingCase.DisciplineName] = objInFor[convClsRmTeachingCase.DisciplineName];
objDR[convClsRmTeachingCase.id_GradeBase] = objInFor[convClsRmTeachingCase.id_GradeBase];
objDR[convClsRmTeachingCase.id_SenateGaugeVersion] = objInFor[convClsRmTeachingCase.id_SenateGaugeVersion];
objDR[convClsRmTeachingCase.senateGaugeVersionID] = objInFor[convClsRmTeachingCase.senateGaugeVersionID];
objDR[convClsRmTeachingCase.senateGaugeVersionName] = objInFor[convClsRmTeachingCase.senateGaugeVersionName];
objDR[convClsRmTeachingCase.senateGaugeVersionTtlScore] = objInFor[convClsRmTeachingCase.senateGaugeVersionTtlScore];
objDR[convClsRmTeachingCase.VersionNo] = objInFor[convClsRmTeachingCase.VersionNo];
objDR[convClsRmTeachingCase.id_TeachSkill] = objInFor[convClsRmTeachingCase.id_TeachSkill];
objDR[convClsRmTeachingCase.TeachSkillID] = objInFor[convClsRmTeachingCase.TeachSkillID];
objDR[convClsRmTeachingCase.SkillTypeName] = objInFor[convClsRmTeachingCase.SkillTypeName];
objDR[convClsRmTeachingCase.TeachSkillName] = objInFor[convClsRmTeachingCase.TeachSkillName];
objDR[convClsRmTeachingCase.TeachSkillTheory] = objInFor[convClsRmTeachingCase.TeachSkillTheory];
objDR[convClsRmTeachingCase.TeachSkillOperMethod] = objInFor[convClsRmTeachingCase.TeachSkillOperMethod];
objDR[convClsRmTeachingCase.id_SkillType] = objInFor[convClsRmTeachingCase.id_SkillType];
objDR[convClsRmTeachingCase.SkillTypeID] = objInFor[convClsRmTeachingCase.SkillTypeID];
objDR[convClsRmTeachingCase.CaseLevelId] = objInFor[convClsRmTeachingCase.CaseLevelId];
objDR[convClsRmTeachingCase.CaseLevelName] = objInFor[convClsRmTeachingCase.CaseLevelName];
objDR[convClsRmTeachingCase.DocFile] = objInFor[convClsRmTeachingCase.DocFile];
objDR[convClsRmTeachingCase.IsNeedGeneWord] = objInFor[convClsRmTeachingCase.IsNeedGeneWord];
objDR[convClsRmTeachingCase.WordCreateDate] = objInFor[convClsRmTeachingCase.WordCreateDate];
objDR[convClsRmTeachingCase.IsVisible] = objInFor[convClsRmTeachingCase.IsVisible];
objDR[convClsRmTeachingCase.OwnerId] = objInFor[convClsRmTeachingCase.OwnerId];
objDR[convClsRmTeachingCase.id_StudentInfo] = objInFor[convClsRmTeachingCase.id_StudentInfo];
objDR[convClsRmTeachingCase.StuName] = objInFor[convClsRmTeachingCase.StuName];
objDR[convClsRmTeachingCase.StuID] = objInFor[convClsRmTeachingCase.StuID];
objDR[convClsRmTeachingCase.PoliticsName] = objInFor[convClsRmTeachingCase.PoliticsName];
objDR[convClsRmTeachingCase.SexDesc] = objInFor[convClsRmTeachingCase.SexDesc];
objDR[convClsRmTeachingCase.EthnicName] = objInFor[convClsRmTeachingCase.EthnicName];
objDR[convClsRmTeachingCase.UniZoneDesc] = objInFor[convClsRmTeachingCase.UniZoneDesc];
objDR[convClsRmTeachingCase.StuTypeDesc] = objInFor[convClsRmTeachingCase.StuTypeDesc];
objDR[convClsRmTeachingCase.id_XzCollege] = objInFor[convClsRmTeachingCase.id_XzCollege];
objDR[convClsRmTeachingCase.CollegeID] = objInFor[convClsRmTeachingCase.CollegeID];
objDR[convClsRmTeachingCase.CollegeName] = objInFor[convClsRmTeachingCase.CollegeName];
objDR[convClsRmTeachingCase.CollegeNameA] = objInFor[convClsRmTeachingCase.CollegeNameA];
objDR[convClsRmTeachingCase.id_XzMajor] = objInFor[convClsRmTeachingCase.id_XzMajor];
objDR[convClsRmTeachingCase.MajorName] = objInFor[convClsRmTeachingCase.MajorName];
objDR[convClsRmTeachingCase.GradeBaseName] = objInFor[convClsRmTeachingCase.GradeBaseName];
objDR[convClsRmTeachingCase.id_AdminCls] = objInFor[convClsRmTeachingCase.id_AdminCls];
objDR[convClsRmTeachingCase.AdminClsId] = objInFor[convClsRmTeachingCase.AdminClsId];
objDR[convClsRmTeachingCase.AdminClsName] = objInFor[convClsRmTeachingCase.AdminClsName];
objDR[convClsRmTeachingCase.Birthday] = objInFor[convClsRmTeachingCase.Birthday];
objDR[convClsRmTeachingCase.NativePlace] = objInFor[convClsRmTeachingCase.NativePlace];
objDR[convClsRmTeachingCase.Duty] = objInFor[convClsRmTeachingCase.Duty];
objDR[convClsRmTeachingCase.IDCardNo] = objInFor[convClsRmTeachingCase.IDCardNo];
objDR[convClsRmTeachingCase.StuCardNo] = objInFor[convClsRmTeachingCase.StuCardNo];
objDR[convClsRmTeachingCase.LiveAddress] = objInFor[convClsRmTeachingCase.LiveAddress];
objDR[convClsRmTeachingCase.HomePhone] = objInFor[convClsRmTeachingCase.HomePhone];
objDR[convClsRmTeachingCase.EnrollmentDate] = objInFor[convClsRmTeachingCase.EnrollmentDate];
objDR[convClsRmTeachingCase.PostCode] = objInFor[convClsRmTeachingCase.PostCode];
objDR[convClsRmTeachingCase.UserKindId] = objInFor[convClsRmTeachingCase.UserKindId];
objDR[convClsRmTeachingCase.UserKindName] = objInFor[convClsRmTeachingCase.UserKindName];
objDR[convClsRmTeachingCase.UserTypeId] = objInFor[convClsRmTeachingCase.UserTypeId];
objDR[convClsRmTeachingCase.UserTypeName] = objInFor[convClsRmTeachingCase.UserTypeName];
objDR[convClsRmTeachingCase.IsDualVideo] = objInFor[convClsRmTeachingCase.IsDualVideo];
objDR[convClsRmTeachingCase.RecommendedDegreeId] = objInFor[convClsRmTeachingCase.RecommendedDegreeId];
objDR[convClsRmTeachingCase.RecommendedDegreeName] = objInFor[convClsRmTeachingCase.RecommendedDegreeName];
objDR[convClsRmTeachingCase.Memo] = objInFor[convClsRmTeachingCase.Memo];
objDR[convClsRmTeachingCase.DisciplineName_ps] = objInFor[convClsRmTeachingCase.DisciplineName_ps];
objDR[convClsRmTeachingCase.GradeName_ps] = objInFor[convClsRmTeachingCase.GradeName_ps];
objDR[convClsRmTeachingCase.id_Grade_ps] = objInFor[convClsRmTeachingCase.id_Grade_ps];
objDR[convClsRmTeachingCase.OwnerName] = objInFor[convClsRmTeachingCase.OwnerName];
objDR[convClsRmTeachingCase.OwnerNameWithId] = objInFor[convClsRmTeachingCase.OwnerNameWithId];
objDR[convClsRmTeachingCase.BrowseCount4Case] = objInFor[convClsRmTeachingCase.BrowseCount4Case];
objDR[convClsRmTeachingCase.IsHaveVideo] = objInFor[convClsRmTeachingCase.IsHaveVideo];
objDR[convClsRmTeachingCase.ftpFileType] = objInFor[convClsRmTeachingCase.ftpFileType];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}