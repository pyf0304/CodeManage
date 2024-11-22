
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCase_BaseWApi
 表名:vClsRmTeachingCase_Base(01120488)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:38
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
public static class clsvClsRmTeachingCase_BaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetId_ClsRmTeachingCase(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strId_ClsRmTeachingCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_ClsRmTeachingCase, 8, convClsRmTeachingCase_Base.Id_ClsRmTeachingCase);
clsCheckSql.CheckFieldForeignKey(strId_ClsRmTeachingCase, 8, convClsRmTeachingCase_Base.Id_ClsRmTeachingCase);
objvClsRmTeachingCase_BaseEN.Id_ClsRmTeachingCase = strId_ClsRmTeachingCase; //课堂教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.Id_ClsRmTeachingCase) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.Id_ClsRmTeachingCase, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.Id_ClsRmTeachingCase] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsRmTeachingCaseID, convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseID, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseID, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = strClsRmTeachingCaseID; //课堂教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.ClsRmTeachingCaseID) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsRmTeachingCaseName, convClsRmTeachingCase_Base.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseName, 100, convClsRmTeachingCase_Base.ClsRmTeachingCaseName);
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = strClsRmTeachingCaseName; //课堂教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.ClsRmTeachingCaseName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseTheme(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTheme, 200, convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme);
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = strClsRmTeachingCaseTheme; //课堂教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_ClsRmTeachingCaseType(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_ClsRmTeachingCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ClsRmTeachingCaseType, convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType);
clsCheckSql.CheckFieldLen(strid_ClsRmTeachingCaseType, 4, convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType);
clsCheckSql.CheckFieldForeignKey(strid_ClsRmTeachingCaseType, 4, convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType);
objvClsRmTeachingCase_BaseEN.id_ClsRmTeachingCaseType = strid_ClsRmTeachingCaseType; //课堂案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseTypeName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTypeName, 30, convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName);
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = strClsRmTeachingCaseTypeName; //课堂案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseText(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseText, 8000, convClsRmTeachingCase_Base.ClsRmTeachingCaseText);
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = strClsRmTeachingCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.ClsRmTeachingCaseText) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseText, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseDate(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDate, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDate, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseDate);
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = strClsRmTeachingCaseDate; //课堂教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.ClsRmTeachingCaseDate) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseDate, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseTime(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTime, 6, convClsRmTeachingCase_Base.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTime, 6, convClsRmTeachingCase_Base.ClsRmTeachingCaseTime);
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = strClsRmTeachingCaseTime; //课堂教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.ClsRmTeachingCaseTime) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseTime, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseDateIn(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn);
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = strClsRmTeachingCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseTimeIn(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn);
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = strClsRmTeachingCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_StudyLevel(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convClsRmTeachingCase_Base.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convClsRmTeachingCase_Base.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convClsRmTeachingCase_Base.id_StudyLevel);
objvClsRmTeachingCase_BaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_StudyLevel) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_StudyLevel, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_StudyLevel] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetStudyLevelName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convClsRmTeachingCase_Base.StudyLevelName);
objvClsRmTeachingCase_BaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.StudyLevelName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.StudyLevelName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.StudyLevelName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_TeachingPlan(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convClsRmTeachingCase_Base.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convClsRmTeachingCase_Base.id_TeachingPlan);
objvClsRmTeachingCase_BaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_TeachingPlan) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_TeachingPlan, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_TeachingPlan] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetId_CaseType(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convClsRmTeachingCase_Base.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convClsRmTeachingCase_Base.Id_CaseType);
objvClsRmTeachingCase_BaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.Id_CaseType) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.Id_CaseType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.Id_CaseType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_Discipline(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convClsRmTeachingCase_Base.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convClsRmTeachingCase_Base.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convClsRmTeachingCase_Base.id_Discipline);
objvClsRmTeachingCase_BaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_Discipline) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_Discipline, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_Discipline] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetDisciplineID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convClsRmTeachingCase_Base.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convClsRmTeachingCase_Base.DisciplineID);
objvClsRmTeachingCase_BaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.DisciplineID) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.DisciplineID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.DisciplineID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_School_Ps(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_School_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School_Ps, 4, convClsRmTeachingCase_Base.id_School_Ps);
clsCheckSql.CheckFieldForeignKey(strid_School_Ps, 4, convClsRmTeachingCase_Base.id_School_Ps);
objvClsRmTeachingCase_BaseEN.id_School_Ps = strid_School_Ps; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_School_Ps) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_School_Ps, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_School_Ps] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetSchoolId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convClsRmTeachingCase_Base.SchoolId);
objvClsRmTeachingCase_BaseEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.SchoolId) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.SchoolId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.SchoolId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetSchoolName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convClsRmTeachingCase_Base.SchoolName);
objvClsRmTeachingCase_BaseEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.SchoolName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.SchoolName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.SchoolName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_Discipline_Ps(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_Discipline_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline_Ps, 4, convClsRmTeachingCase_Base.id_Discipline_Ps);
clsCheckSql.CheckFieldForeignKey(strid_Discipline_Ps, 4, convClsRmTeachingCase_Base.id_Discipline_Ps);
objvClsRmTeachingCase_BaseEN.id_Discipline_Ps = strid_Discipline_Ps; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_Discipline_Ps) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_Discipline_Ps, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_Discipline_Ps] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetDisciplineName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convClsRmTeachingCase_Base.DisciplineName);
objvClsRmTeachingCase_BaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.DisciplineName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.DisciplineName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.DisciplineName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_GradeBase(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convClsRmTeachingCase_Base.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convClsRmTeachingCase_Base.id_GradeBase);
objvClsRmTeachingCase_BaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_GradeBase) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_GradeBase, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_GradeBase] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_SenateGaugeVersion(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convClsRmTeachingCase_Base.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convClsRmTeachingCase_Base.id_SenateGaugeVersion);
objvClsRmTeachingCase_BaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_SenateGaugeVersion) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetsenateGaugeVersionID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convClsRmTeachingCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convClsRmTeachingCase_Base.senateGaugeVersionID);
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.senateGaugeVersionID) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.senateGaugeVersionID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.senateGaugeVersionID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetsenateGaugeVersionName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convClsRmTeachingCase_Base.senateGaugeVersionName);
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.senateGaugeVersionName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.senateGaugeVersionName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.senateGaugeVersionName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.senateGaugeVersionTtlScore) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetVersionNo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, int intVersionNo, string strComparisonOp="")
	{
objvClsRmTeachingCase_BaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.VersionNo) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.VersionNo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.VersionNo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_TeachSkill(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convClsRmTeachingCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convClsRmTeachingCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convClsRmTeachingCase_Base.id_TeachSkill);
objvClsRmTeachingCase_BaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_TeachSkill) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_TeachSkill, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_TeachSkill] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetTeachSkillID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convClsRmTeachingCase_Base.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convClsRmTeachingCase_Base.TeachSkillID);
objvClsRmTeachingCase_BaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.TeachSkillID) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.TeachSkillID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetSkillTypeName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convClsRmTeachingCase_Base.SkillTypeName);
objvClsRmTeachingCase_BaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.SkillTypeName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.SkillTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.SkillTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetTeachSkillName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convClsRmTeachingCase_Base.TeachSkillName);
objvClsRmTeachingCase_BaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.TeachSkillName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.TeachSkillName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetTeachSkillTheory(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convClsRmTeachingCase_Base.TeachSkillTheory);
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.TeachSkillTheory) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.TeachSkillTheory, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillTheory] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetTeachSkillOperMethod(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convClsRmTeachingCase_Base.TeachSkillOperMethod);
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.TeachSkillOperMethod) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_SkillType(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convClsRmTeachingCase_Base.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convClsRmTeachingCase_Base.id_SkillType);
objvClsRmTeachingCase_BaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_SkillType) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_SkillType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_SkillType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetSkillTypeID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convClsRmTeachingCase_Base.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convClsRmTeachingCase_Base.SkillTypeID);
objvClsRmTeachingCase_BaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.SkillTypeID) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.SkillTypeID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.SkillTypeID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCaseLevelId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convClsRmTeachingCase_Base.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convClsRmTeachingCase_Base.CaseLevelId);
objvClsRmTeachingCase_BaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.CaseLevelId) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.CaseLevelId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.CaseLevelId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCaseLevelName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convClsRmTeachingCase_Base.CaseLevelName);
objvClsRmTeachingCase_BaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.CaseLevelName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.CaseLevelName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.CaseLevelName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetDocFile(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convClsRmTeachingCase_Base.DocFile);
objvClsRmTeachingCase_BaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.DocFile) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.DocFile, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.DocFile] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIsNeedGeneWord(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IsNeedGeneWord) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IsNeedGeneWord, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IsNeedGeneWord] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetWordCreateDate(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convClsRmTeachingCase_Base.WordCreateDate);
objvClsRmTeachingCase_BaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.WordCreateDate) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.WordCreateDate, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.WordCreateDate] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIsVisible(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvClsRmTeachingCase_BaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IsVisible) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IsVisible, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IsVisible] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetOwnerId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convClsRmTeachingCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convClsRmTeachingCase_Base.OwnerId);
objvClsRmTeachingCase_BaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.OwnerId) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.OwnerId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.OwnerId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_StudentInfo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convClsRmTeachingCase_Base.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convClsRmTeachingCase_Base.id_StudentInfo);
objvClsRmTeachingCase_BaseEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_StudentInfo) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_StudentInfo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_StudentInfo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetStuName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convClsRmTeachingCase_Base.StuName);
objvClsRmTeachingCase_BaseEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.StuName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.StuName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.StuName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetStuID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convClsRmTeachingCase_Base.StuID);
objvClsRmTeachingCase_BaseEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.StuID) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.StuID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.StuID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetPoliticsName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convClsRmTeachingCase_Base.PoliticsName);
objvClsRmTeachingCase_BaseEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.PoliticsName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.PoliticsName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.PoliticsName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetSexDesc(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convClsRmTeachingCase_Base.SexDesc);
objvClsRmTeachingCase_BaseEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.SexDesc) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.SexDesc, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.SexDesc] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetEthnicName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convClsRmTeachingCase_Base.EthnicName);
objvClsRmTeachingCase_BaseEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.EthnicName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.EthnicName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.EthnicName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetUniZoneDesc(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convClsRmTeachingCase_Base.UniZoneDesc);
objvClsRmTeachingCase_BaseEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.UniZoneDesc) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.UniZoneDesc, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.UniZoneDesc] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetStuTypeDesc(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convClsRmTeachingCase_Base.StuTypeDesc);
objvClsRmTeachingCase_BaseEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.StuTypeDesc) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.StuTypeDesc, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.StuTypeDesc] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_XzCollege(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convClsRmTeachingCase_Base.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convClsRmTeachingCase_Base.id_XzCollege);
objvClsRmTeachingCase_BaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_XzCollege) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_XzCollege, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_XzCollege] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCollegeID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convClsRmTeachingCase_Base.CollegeID);
objvClsRmTeachingCase_BaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.CollegeID) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.CollegeID, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.CollegeID] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCollegeName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convClsRmTeachingCase_Base.CollegeName);
objvClsRmTeachingCase_BaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.CollegeName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.CollegeName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.CollegeName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCollegeNameA(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convClsRmTeachingCase_Base.CollegeNameA);
objvClsRmTeachingCase_BaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.CollegeNameA) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.CollegeNameA, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.CollegeNameA] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_XzMajor(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convClsRmTeachingCase_Base.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convClsRmTeachingCase_Base.id_XzMajor);
objvClsRmTeachingCase_BaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_XzMajor) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_XzMajor, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_XzMajor] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetMajorName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convClsRmTeachingCase_Base.MajorName);
objvClsRmTeachingCase_BaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.MajorName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.MajorName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.MajorName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetGradeBaseName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convClsRmTeachingCase_Base.GradeBaseName);
objvClsRmTeachingCase_BaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.GradeBaseName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.GradeBaseName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.GradeBaseName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_AdminCls(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convClsRmTeachingCase_Base.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convClsRmTeachingCase_Base.id_AdminCls);
objvClsRmTeachingCase_BaseEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_AdminCls) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_AdminCls, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_AdminCls] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetAdminClsId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convClsRmTeachingCase_Base.AdminClsId);
objvClsRmTeachingCase_BaseEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.AdminClsId) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.AdminClsId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.AdminClsId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetAdminClsName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convClsRmTeachingCase_Base.AdminClsName);
objvClsRmTeachingCase_BaseEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.AdminClsName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.AdminClsName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.AdminClsName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetBirthday(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convClsRmTeachingCase_Base.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convClsRmTeachingCase_Base.Birthday);
objvClsRmTeachingCase_BaseEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.Birthday) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.Birthday, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.Birthday] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetNativePlace(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convClsRmTeachingCase_Base.NativePlace);
objvClsRmTeachingCase_BaseEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.NativePlace) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.NativePlace, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.NativePlace] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetDuty(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convClsRmTeachingCase_Base.Duty);
objvClsRmTeachingCase_BaseEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.Duty) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.Duty, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.Duty] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIDCardNo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convClsRmTeachingCase_Base.IDCardNo);
objvClsRmTeachingCase_BaseEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IDCardNo) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IDCardNo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IDCardNo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetStuCardNo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convClsRmTeachingCase_Base.StuCardNo);
objvClsRmTeachingCase_BaseEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.StuCardNo) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.StuCardNo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.StuCardNo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetLiveAddress(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convClsRmTeachingCase_Base.LiveAddress);
objvClsRmTeachingCase_BaseEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.LiveAddress) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.LiveAddress, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.LiveAddress] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetHomePhone(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convClsRmTeachingCase_Base.HomePhone);
objvClsRmTeachingCase_BaseEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.HomePhone) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.HomePhone, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.HomePhone] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetEnrollmentDate(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convClsRmTeachingCase_Base.EnrollmentDate);
objvClsRmTeachingCase_BaseEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.EnrollmentDate) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.EnrollmentDate, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.EnrollmentDate] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetPostCode(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convClsRmTeachingCase_Base.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convClsRmTeachingCase_Base.PostCode);
objvClsRmTeachingCase_BaseEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.PostCode) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.PostCode, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.PostCode] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetUserKindId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convClsRmTeachingCase_Base.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convClsRmTeachingCase_Base.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convClsRmTeachingCase_Base.UserKindId);
objvClsRmTeachingCase_BaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.UserKindId) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.UserKindId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.UserKindId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetUserKindName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convClsRmTeachingCase_Base.UserKindName);
objvClsRmTeachingCase_BaseEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.UserKindName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.UserKindName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.UserKindName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetUserTypeId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convClsRmTeachingCase_Base.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convClsRmTeachingCase_Base.UserTypeId);
objvClsRmTeachingCase_BaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.UserTypeId) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.UserTypeId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.UserTypeId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIsDualVideo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvClsRmTeachingCase_BaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IsDualVideo) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IsDualVideo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IsDualVideo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetRecommendedDegreeId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convClsRmTeachingCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convClsRmTeachingCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convClsRmTeachingCase_Base.RecommendedDegreeId);
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.RecommendedDegreeId) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.RecommendedDegreeId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.RecommendedDegreeId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetRecommendedDegreeName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convClsRmTeachingCase_Base.RecommendedDegreeName);
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.RecommendedDegreeName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.RecommendedDegreeName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.RecommendedDegreeName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetMemo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClsRmTeachingCase_Base.Memo);
objvClsRmTeachingCase_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.Memo) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.Memo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.Memo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetDisciplineName_ps(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strDisciplineName_ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName_ps, 50, convClsRmTeachingCase_Base.DisciplineName_ps);
objvClsRmTeachingCase_BaseEN.DisciplineName_ps = strDisciplineName_ps; //学科
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.DisciplineName_ps) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.DisciplineName_ps, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.DisciplineName_ps] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetGradeName_ps(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strGradeName_ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeName_ps, 50, convClsRmTeachingCase_Base.GradeName_ps);
objvClsRmTeachingCase_BaseEN.GradeName_ps = strGradeName_ps; //年级
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.GradeName_ps) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.GradeName_ps, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.GradeName_ps] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN Setid_Grade_ps(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strid_Grade_ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Grade_ps, 4, convClsRmTeachingCase_Base.id_Grade_ps);
clsCheckSql.CheckFieldForeignKey(strid_Grade_ps, 4, convClsRmTeachingCase_Base.id_Grade_ps);
objvClsRmTeachingCase_BaseEN.id_Grade_ps = strid_Grade_ps; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.id_Grade_ps) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.id_Grade_ps, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.id_Grade_ps] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetOwnerName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convClsRmTeachingCase_Base.OwnerName);
objvClsRmTeachingCase_BaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.OwnerName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.OwnerName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.OwnerName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetOwnerNameWithId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convClsRmTeachingCase_Base.OwnerNameWithId);
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.OwnerNameWithId) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.OwnerNameWithId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.OwnerNameWithId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetBrowseCount4Case(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.BrowseCount4Case) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.BrowseCount4Case, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.BrowseCount4Case] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCaseTypeName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTypeName, 50, convClsRmTeachingCase_Base.CaseTypeName);
objvClsRmTeachingCase_BaseEN.CaseTypeName = strCaseTypeName; //案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.CaseTypeName) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.CaseTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.CaseTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetftpFileType(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convClsRmTeachingCase_Base.ftpFileType);
objvClsRmTeachingCase_BaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.ftpFileType) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.ftpFileType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.ftpFileType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIsUse(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, bool bolIsUse, string strComparisonOp="")
	{
objvClsRmTeachingCase_BaseEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IsUse) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IsUse, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IsUse] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_Base_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.Id_ClsRmTeachingCase) == true)
{
string strComparisonOp_Id_ClsRmTeachingCase = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.Id_ClsRmTeachingCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.Id_ClsRmTeachingCase, objvClsRmTeachingCase_Base_Cond.Id_ClsRmTeachingCase, strComparisonOp_Id_ClsRmTeachingCase);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseID) == true)
{
string strComparisonOp_ClsRmTeachingCaseID = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseID, objvClsRmTeachingCase_Base_Cond.ClsRmTeachingCaseID, strComparisonOp_ClsRmTeachingCaseID);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseName) == true)
{
string strComparisonOp_ClsRmTeachingCaseName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseName, objvClsRmTeachingCase_Base_Cond.ClsRmTeachingCaseName, strComparisonOp_ClsRmTeachingCaseName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme) == true)
{
string strComparisonOp_ClsRmTeachingCaseTheme = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme, objvClsRmTeachingCase_Base_Cond.ClsRmTeachingCaseTheme, strComparisonOp_ClsRmTeachingCaseTheme);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType) == true)
{
string strComparisonOp_id_ClsRmTeachingCaseType = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType, objvClsRmTeachingCase_Base_Cond.id_ClsRmTeachingCaseType, strComparisonOp_id_ClsRmTeachingCaseType);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName) == true)
{
string strComparisonOp_ClsRmTeachingCaseTypeName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName, objvClsRmTeachingCase_Base_Cond.ClsRmTeachingCaseTypeName, strComparisonOp_ClsRmTeachingCaseTypeName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseText) == true)
{
string strComparisonOp_ClsRmTeachingCaseText = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseText, objvClsRmTeachingCase_Base_Cond.ClsRmTeachingCaseText, strComparisonOp_ClsRmTeachingCaseText);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseDate) == true)
{
string strComparisonOp_ClsRmTeachingCaseDate = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseDate, objvClsRmTeachingCase_Base_Cond.ClsRmTeachingCaseDate, strComparisonOp_ClsRmTeachingCaseDate);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseTime) == true)
{
string strComparisonOp_ClsRmTeachingCaseTime = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseTime, objvClsRmTeachingCase_Base_Cond.ClsRmTeachingCaseTime, strComparisonOp_ClsRmTeachingCaseTime);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn) == true)
{
string strComparisonOp_ClsRmTeachingCaseDateIn = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn, objvClsRmTeachingCase_Base_Cond.ClsRmTeachingCaseDateIn, strComparisonOp_ClsRmTeachingCaseDateIn);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn) == true)
{
string strComparisonOp_ClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn, objvClsRmTeachingCase_Base_Cond.ClsRmTeachingCaseTimeIn, strComparisonOp_ClsRmTeachingCaseTimeIn);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_StudyLevel, objvClsRmTeachingCase_Base_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.StudyLevelName, objvClsRmTeachingCase_Base_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_TeachingPlan, objvClsRmTeachingCase_Base_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.Id_CaseType, objvClsRmTeachingCase_Base_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_Discipline, objvClsRmTeachingCase_Base_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.DisciplineID, objvClsRmTeachingCase_Base_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_School_Ps) == true)
{
string strComparisonOp_id_School_Ps = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_School_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_School_Ps, objvClsRmTeachingCase_Base_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.SchoolId, objvClsRmTeachingCase_Base_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.SchoolName, objvClsRmTeachingCase_Base_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_Discipline_Ps) == true)
{
string strComparisonOp_id_Discipline_Ps = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_Discipline_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_Discipline_Ps, objvClsRmTeachingCase_Base_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.DisciplineName, objvClsRmTeachingCase_Base_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_GradeBase, objvClsRmTeachingCase_Base_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_SenateGaugeVersion, objvClsRmTeachingCase_Base_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.senateGaugeVersionID, objvClsRmTeachingCase_Base_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.senateGaugeVersionName, objvClsRmTeachingCase_Base_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Base.senateGaugeVersionTtlScore, objvClsRmTeachingCase_Base_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Base.VersionNo, objvClsRmTeachingCase_Base_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_TeachSkill, objvClsRmTeachingCase_Base_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.TeachSkillID, objvClsRmTeachingCase_Base_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.SkillTypeName, objvClsRmTeachingCase_Base_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.TeachSkillName, objvClsRmTeachingCase_Base_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.TeachSkillTheory, objvClsRmTeachingCase_Base_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.TeachSkillOperMethod, objvClsRmTeachingCase_Base_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_SkillType, objvClsRmTeachingCase_Base_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.SkillTypeID, objvClsRmTeachingCase_Base_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CaseLevelId, objvClsRmTeachingCase_Base_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CaseLevelName, objvClsRmTeachingCase_Base_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.DocFile) == true)
{
string strComparisonOp_DocFile = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.DocFile, objvClsRmTeachingCase_Base_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.IsNeedGeneWord) == true)
{
if (objvClsRmTeachingCase_Base_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Base.IsNeedGeneWord);
}
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.WordCreateDate, objvClsRmTeachingCase_Base_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.IsVisible) == true)
{
if (objvClsRmTeachingCase_Base_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Base.IsVisible);
}
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.OwnerId, objvClsRmTeachingCase_Base_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_StudentInfo, objvClsRmTeachingCase_Base_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.StuName) == true)
{
string strComparisonOp_StuName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.StuName, objvClsRmTeachingCase_Base_Cond.StuName, strComparisonOp_StuName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.StuID) == true)
{
string strComparisonOp_StuID = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.StuID, objvClsRmTeachingCase_Base_Cond.StuID, strComparisonOp_StuID);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.PoliticsName, objvClsRmTeachingCase_Base_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.SexDesc, objvClsRmTeachingCase_Base_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.EthnicName, objvClsRmTeachingCase_Base_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.UniZoneDesc, objvClsRmTeachingCase_Base_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.StuTypeDesc, objvClsRmTeachingCase_Base_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_XzCollege, objvClsRmTeachingCase_Base_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CollegeID, objvClsRmTeachingCase_Base_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CollegeName, objvClsRmTeachingCase_Base_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CollegeNameA, objvClsRmTeachingCase_Base_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_XzMajor, objvClsRmTeachingCase_Base_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.MajorName) == true)
{
string strComparisonOp_MajorName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.MajorName, objvClsRmTeachingCase_Base_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.GradeBaseName, objvClsRmTeachingCase_Base_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_AdminCls, objvClsRmTeachingCase_Base_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.AdminClsId, objvClsRmTeachingCase_Base_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.AdminClsName, objvClsRmTeachingCase_Base_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.Birthday) == true)
{
string strComparisonOp_Birthday = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.Birthday, objvClsRmTeachingCase_Base_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.NativePlace, objvClsRmTeachingCase_Base_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.Duty) == true)
{
string strComparisonOp_Duty = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.Duty, objvClsRmTeachingCase_Base_Cond.Duty, strComparisonOp_Duty);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IDCardNo, objvClsRmTeachingCase_Base_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.StuCardNo, objvClsRmTeachingCase_Base_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.LiveAddress, objvClsRmTeachingCase_Base_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.HomePhone, objvClsRmTeachingCase_Base_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.EnrollmentDate, objvClsRmTeachingCase_Base_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.PostCode) == true)
{
string strComparisonOp_PostCode = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.PostCode, objvClsRmTeachingCase_Base_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.UserKindId, objvClsRmTeachingCase_Base_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.UserKindName, objvClsRmTeachingCase_Base_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.UserTypeId, objvClsRmTeachingCase_Base_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.IsDualVideo) == true)
{
if (objvClsRmTeachingCase_Base_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Base.IsDualVideo);
}
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.RecommendedDegreeId, objvClsRmTeachingCase_Base_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.RecommendedDegreeName, objvClsRmTeachingCase_Base_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.Memo) == true)
{
string strComparisonOp_Memo = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.Memo, objvClsRmTeachingCase_Base_Cond.Memo, strComparisonOp_Memo);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.DisciplineName_ps) == true)
{
string strComparisonOp_DisciplineName_ps = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.DisciplineName_ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.DisciplineName_ps, objvClsRmTeachingCase_Base_Cond.DisciplineName_ps, strComparisonOp_DisciplineName_ps);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.GradeName_ps) == true)
{
string strComparisonOp_GradeName_ps = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.GradeName_ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.GradeName_ps, objvClsRmTeachingCase_Base_Cond.GradeName_ps, strComparisonOp_GradeName_ps);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.id_Grade_ps) == true)
{
string strComparisonOp_id_Grade_ps = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.id_Grade_ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.id_Grade_ps, objvClsRmTeachingCase_Base_Cond.id_Grade_ps, strComparisonOp_id_Grade_ps);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.OwnerName, objvClsRmTeachingCase_Base_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.OwnerNameWithId, objvClsRmTeachingCase_Base_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Base.BrowseCount4Case, objvClsRmTeachingCase_Base_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.CaseTypeName) == true)
{
string strComparisonOp_CaseTypeName = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.CaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CaseTypeName, objvClsRmTeachingCase_Base_Cond.CaseTypeName, strComparisonOp_CaseTypeName);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvClsRmTeachingCase_Base_Cond.dicFldComparisonOp[convClsRmTeachingCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ftpFileType, objvClsRmTeachingCase_Base_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvClsRmTeachingCase_Base_Cond.IsUpdated(convClsRmTeachingCase_Base.IsUse) == true)
{
if (objvClsRmTeachingCase_Base_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Base.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Base.IsUse);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课堂教学案例_Base(vClsRmTeachingCase_Base)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvClsRmTeachingCase_BaseWApi
{
private static readonly string mstrApiControllerName = "vClsRmTeachingCase_BaseApi";

 public clsvClsRmTeachingCase_BaseWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课堂教学案例_Base]...","0");
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convClsRmTeachingCase_Base.Id_ClsRmTeachingCase); 
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = clsvClsRmTeachingCase_BaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN()
{
Id_ClsRmTeachingCase = "0",
ClsRmTeachingCaseName = "选[v课堂教学案例_Base]..."
};
arrObjLst.Insert(0, objvClsRmTeachingCase_BaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convClsRmTeachingCase_Base.Id_ClsRmTeachingCase;
objComboBox.DisplayMember = convClsRmTeachingCase_Base.ClsRmTeachingCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_ClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClsRmTeachingCase_BaseEN GetObjById_ClsRmTeachingCase(string strId_ClsRmTeachingCase)
{
string strAction = "GetObjById_ClsRmTeachingCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = null;
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
objvClsRmTeachingCase_BaseEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCase_BaseEN;
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
public static clsvClsRmTeachingCase_BaseEN GetObjById_ClsRmTeachingCase_WA_Cache(string strId_ClsRmTeachingCase)
{
string strAction = "GetObjById_ClsRmTeachingCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = null;
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
objvClsRmTeachingCase_BaseEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCase_BaseEN;
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
public static clsvClsRmTeachingCase_BaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = null;
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
objvClsRmTeachingCase_BaseEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCase_BaseEN;
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
public static clsvClsRmTeachingCase_BaseEN GetObjById_ClsRmTeachingCase_Cache(string strId_ClsRmTeachingCase)
{
if (string.IsNullOrEmpty(strId_ClsRmTeachingCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvClsRmTeachingCase_BaseEN._CurrTabName_S);
List<clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Sel =
from objvClsRmTeachingCase_BaseEN in arrvClsRmTeachingCase_BaseObjLst_Cache
where objvClsRmTeachingCase_BaseEN.Id_ClsRmTeachingCase == strId_ClsRmTeachingCase
select objvClsRmTeachingCase_BaseEN;
if (arrvClsRmTeachingCase_BaseObjLst_Sel.Count() == 0)
{
   clsvClsRmTeachingCase_BaseEN obj = clsvClsRmTeachingCase_BaseWApi.GetObjById_ClsRmTeachingCase(strId_ClsRmTeachingCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvClsRmTeachingCase_BaseObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsvClsRmTeachingCase_BaseEN._CurrTabName_S);
List<clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Sel1 =
from objvClsRmTeachingCase_BaseEN in arrvClsRmTeachingCase_BaseObjLst_Cache
where objvClsRmTeachingCase_BaseEN.Id_ClsRmTeachingCase == strId_ClsRmTeachingCase
select objvClsRmTeachingCase_BaseEN;
List <clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Sel = new List<clsvClsRmTeachingCase_BaseEN>();
foreach (clsvClsRmTeachingCase_BaseEN obj in arrvClsRmTeachingCase_BaseObjLst_Sel1)
{
arrvClsRmTeachingCase_BaseObjLst_Sel.Add(obj);
}
if (arrvClsRmTeachingCase_BaseObjLst_Sel.Count > 0)
{
return arrvClsRmTeachingCase_BaseObjLst_Sel[0].ClsRmTeachingCaseName;
}
string strErrMsgForGetObjById = string.Format("在vClsRmTeachingCase_Base对象缓存列表中,找不到记录[Id_ClsRmTeachingCase = {0}](函数:{1})", strId_ClsRmTeachingCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvClsRmTeachingCase_BaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsvClsRmTeachingCase_BaseEN._CurrTabName_S);
List<clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Sel1 =
from objvClsRmTeachingCase_BaseEN in arrvClsRmTeachingCase_BaseObjLst_Cache
where objvClsRmTeachingCase_BaseEN.Id_ClsRmTeachingCase == strId_ClsRmTeachingCase
select objvClsRmTeachingCase_BaseEN;
List <clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Sel = new List<clsvClsRmTeachingCase_BaseEN>();
foreach (clsvClsRmTeachingCase_BaseEN obj in arrvClsRmTeachingCase_BaseObjLst_Sel1)
{
arrvClsRmTeachingCase_BaseObjLst_Sel.Add(obj);
}
if (arrvClsRmTeachingCase_BaseObjLst_Sel.Count > 0)
{
return arrvClsRmTeachingCase_BaseObjLst_Sel[0].ClsRmTeachingCaseName;
}
string strErrMsgForGetObjById = string.Format("在vClsRmTeachingCase_Base对象缓存列表中,找不到记录的相关名称[Id_ClsRmTeachingCase = {0}](函数:{1})", strId_ClsRmTeachingCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvClsRmTeachingCase_BaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLst(string strWhereCond)
{
 List<clsvClsRmTeachingCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstById_ClsRmTeachingCaseLst(List<string> arrId_ClsRmTeachingCase)
{
 List<clsvClsRmTeachingCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvClsRmTeachingCase_BaseEN> GetObjLstById_ClsRmTeachingCaseLst_Cache(List<string> arrId_ClsRmTeachingCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClsRmTeachingCase_BaseEN._CurrTabName_S);
List<clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Sel =
from objvClsRmTeachingCase_BaseEN in arrvClsRmTeachingCase_BaseObjLst_Cache
where arrId_ClsRmTeachingCase.Contains(objvClsRmTeachingCase_BaseEN.Id_ClsRmTeachingCase)
select objvClsRmTeachingCase_BaseEN;
return arrvClsRmTeachingCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstById_ClsRmTeachingCaseLst_WA_Cache(List<string> arrId_ClsRmTeachingCase)
{
 List<clsvClsRmTeachingCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvClsRmTeachingCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvClsRmTeachingCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvClsRmTeachingCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvClsRmTeachingCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvClsRmTeachingCase_BaseENS">源对象</param>
 /// <param name = "objvClsRmTeachingCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENS, clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENT)
{
try
{
objvClsRmTeachingCase_BaseENT.Id_ClsRmTeachingCase = objvClsRmTeachingCase_BaseENS.Id_ClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseID = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseName = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCase_BaseENT.id_ClsRmTeachingCaseType = objvClsRmTeachingCase_BaseENS.id_ClsRmTeachingCaseType; //课堂案例类型流水号
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseText = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseText; //案例文本内容
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseDate = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTime = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCase_BaseENT.id_StudyLevel = objvClsRmTeachingCase_BaseENS.id_StudyLevel; //id_StudyLevel
objvClsRmTeachingCase_BaseENT.StudyLevelName = objvClsRmTeachingCase_BaseENS.StudyLevelName; //学段名称
objvClsRmTeachingCase_BaseENT.id_TeachingPlan = objvClsRmTeachingCase_BaseENS.id_TeachingPlan; //教案流水号
objvClsRmTeachingCase_BaseENT.Id_CaseType = objvClsRmTeachingCase_BaseENS.Id_CaseType; //案例类型流水号
objvClsRmTeachingCase_BaseENT.id_Discipline = objvClsRmTeachingCase_BaseENS.id_Discipline; //学科流水号
objvClsRmTeachingCase_BaseENT.DisciplineID = objvClsRmTeachingCase_BaseENS.DisciplineID; //学科ID
objvClsRmTeachingCase_BaseENT.id_School_Ps = objvClsRmTeachingCase_BaseENS.id_School_Ps; //学校流水号
objvClsRmTeachingCase_BaseENT.SchoolId = objvClsRmTeachingCase_BaseENS.SchoolId; //学校编号
objvClsRmTeachingCase_BaseENT.SchoolName = objvClsRmTeachingCase_BaseENS.SchoolName; //学校名称
objvClsRmTeachingCase_BaseENT.id_Discipline_Ps = objvClsRmTeachingCase_BaseENS.id_Discipline_Ps; //学科流水号
objvClsRmTeachingCase_BaseENT.DisciplineName = objvClsRmTeachingCase_BaseENS.DisciplineName; //学科名称
objvClsRmTeachingCase_BaseENT.id_GradeBase = objvClsRmTeachingCase_BaseENS.id_GradeBase; //年级流水号
objvClsRmTeachingCase_BaseENT.id_SenateGaugeVersion = objvClsRmTeachingCase_BaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvClsRmTeachingCase_BaseENT.senateGaugeVersionID = objvClsRmTeachingCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCase_BaseENT.senateGaugeVersionName = objvClsRmTeachingCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCase_BaseENT.senateGaugeVersionTtlScore = objvClsRmTeachingCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCase_BaseENT.VersionNo = objvClsRmTeachingCase_BaseENS.VersionNo; //版本号
objvClsRmTeachingCase_BaseENT.id_TeachSkill = objvClsRmTeachingCase_BaseENS.id_TeachSkill; //教学技能流水号
objvClsRmTeachingCase_BaseENT.TeachSkillID = objvClsRmTeachingCase_BaseENS.TeachSkillID; //教学技能ID
objvClsRmTeachingCase_BaseENT.SkillTypeName = objvClsRmTeachingCase_BaseENS.SkillTypeName; //技能类型名称
objvClsRmTeachingCase_BaseENT.TeachSkillName = objvClsRmTeachingCase_BaseENS.TeachSkillName; //教学技能名称
objvClsRmTeachingCase_BaseENT.TeachSkillTheory = objvClsRmTeachingCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvClsRmTeachingCase_BaseENT.TeachSkillOperMethod = objvClsRmTeachingCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvClsRmTeachingCase_BaseENT.id_SkillType = objvClsRmTeachingCase_BaseENS.id_SkillType; //技能类型流水号
objvClsRmTeachingCase_BaseENT.SkillTypeID = objvClsRmTeachingCase_BaseENS.SkillTypeID; //技能类型ID
objvClsRmTeachingCase_BaseENT.CaseLevelId = objvClsRmTeachingCase_BaseENS.CaseLevelId; //课例等级Id
objvClsRmTeachingCase_BaseENT.CaseLevelName = objvClsRmTeachingCase_BaseENS.CaseLevelName; //案例等级名称
objvClsRmTeachingCase_BaseENT.DocFile = objvClsRmTeachingCase_BaseENS.DocFile; //生成的Word文件名
objvClsRmTeachingCase_BaseENT.IsNeedGeneWord = objvClsRmTeachingCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvClsRmTeachingCase_BaseENT.WordCreateDate = objvClsRmTeachingCase_BaseENS.WordCreateDate; //Word生成日期
objvClsRmTeachingCase_BaseENT.IsVisible = objvClsRmTeachingCase_BaseENS.IsVisible; //是否显示
objvClsRmTeachingCase_BaseENT.OwnerId = objvClsRmTeachingCase_BaseENS.OwnerId; //拥有者Id
objvClsRmTeachingCase_BaseENT.id_StudentInfo = objvClsRmTeachingCase_BaseENS.id_StudentInfo; //学生流水号
objvClsRmTeachingCase_BaseENT.StuName = objvClsRmTeachingCase_BaseENS.StuName; //姓名
objvClsRmTeachingCase_BaseENT.StuID = objvClsRmTeachingCase_BaseENS.StuID; //学号
objvClsRmTeachingCase_BaseENT.PoliticsName = objvClsRmTeachingCase_BaseENS.PoliticsName; //政治面貌
objvClsRmTeachingCase_BaseENT.SexDesc = objvClsRmTeachingCase_BaseENS.SexDesc; //性别名称
objvClsRmTeachingCase_BaseENT.EthnicName = objvClsRmTeachingCase_BaseENS.EthnicName; //民族名称
objvClsRmTeachingCase_BaseENT.UniZoneDesc = objvClsRmTeachingCase_BaseENS.UniZoneDesc; //校区名称
objvClsRmTeachingCase_BaseENT.StuTypeDesc = objvClsRmTeachingCase_BaseENS.StuTypeDesc; //学生类别名称
objvClsRmTeachingCase_BaseENT.id_XzCollege = objvClsRmTeachingCase_BaseENS.id_XzCollege; //学院流水号
objvClsRmTeachingCase_BaseENT.CollegeID = objvClsRmTeachingCase_BaseENS.CollegeID; //学院ID
objvClsRmTeachingCase_BaseENT.CollegeName = objvClsRmTeachingCase_BaseENS.CollegeName; //学院名称
objvClsRmTeachingCase_BaseENT.CollegeNameA = objvClsRmTeachingCase_BaseENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCase_BaseENT.id_XzMajor = objvClsRmTeachingCase_BaseENS.id_XzMajor; //专业流水号
objvClsRmTeachingCase_BaseENT.MajorName = objvClsRmTeachingCase_BaseENS.MajorName; //专业名称
objvClsRmTeachingCase_BaseENT.GradeBaseName = objvClsRmTeachingCase_BaseENS.GradeBaseName; //年级名称
objvClsRmTeachingCase_BaseENT.id_AdminCls = objvClsRmTeachingCase_BaseENS.id_AdminCls; //行政班流水号
objvClsRmTeachingCase_BaseENT.AdminClsId = objvClsRmTeachingCase_BaseENS.AdminClsId; //行政班代号
objvClsRmTeachingCase_BaseENT.AdminClsName = objvClsRmTeachingCase_BaseENS.AdminClsName; //行政班名称
objvClsRmTeachingCase_BaseENT.Birthday = objvClsRmTeachingCase_BaseENS.Birthday; //出生日期
objvClsRmTeachingCase_BaseENT.NativePlace = objvClsRmTeachingCase_BaseENS.NativePlace; //籍贯
objvClsRmTeachingCase_BaseENT.Duty = objvClsRmTeachingCase_BaseENS.Duty; //职位
objvClsRmTeachingCase_BaseENT.IDCardNo = objvClsRmTeachingCase_BaseENS.IDCardNo; //身份证号
objvClsRmTeachingCase_BaseENT.StuCardNo = objvClsRmTeachingCase_BaseENS.StuCardNo; //学生证号
objvClsRmTeachingCase_BaseENT.LiveAddress = objvClsRmTeachingCase_BaseENS.LiveAddress; //居住地址
objvClsRmTeachingCase_BaseENT.HomePhone = objvClsRmTeachingCase_BaseENS.HomePhone; //住宅电话
objvClsRmTeachingCase_BaseENT.EnrollmentDate = objvClsRmTeachingCase_BaseENS.EnrollmentDate; //入校日期
objvClsRmTeachingCase_BaseENT.PostCode = objvClsRmTeachingCase_BaseENS.PostCode; //邮编
objvClsRmTeachingCase_BaseENT.UserKindId = objvClsRmTeachingCase_BaseENS.UserKindId; //用户类别Id
objvClsRmTeachingCase_BaseENT.UserKindName = objvClsRmTeachingCase_BaseENS.UserKindName; //用户类别名
objvClsRmTeachingCase_BaseENT.UserTypeId = objvClsRmTeachingCase_BaseENS.UserTypeId; //用户类型Id
objvClsRmTeachingCase_BaseENT.IsDualVideo = objvClsRmTeachingCase_BaseENS.IsDualVideo; //是否双视频
objvClsRmTeachingCase_BaseENT.RecommendedDegreeId = objvClsRmTeachingCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvClsRmTeachingCase_BaseENT.RecommendedDegreeName = objvClsRmTeachingCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvClsRmTeachingCase_BaseENT.Memo = objvClsRmTeachingCase_BaseENS.Memo; //备注
objvClsRmTeachingCase_BaseENT.DisciplineName_ps = objvClsRmTeachingCase_BaseENS.DisciplineName_ps; //学科
objvClsRmTeachingCase_BaseENT.GradeName_ps = objvClsRmTeachingCase_BaseENS.GradeName_ps; //年级
objvClsRmTeachingCase_BaseENT.id_Grade_ps = objvClsRmTeachingCase_BaseENS.id_Grade_ps; //年级流水号
objvClsRmTeachingCase_BaseENT.OwnerName = objvClsRmTeachingCase_BaseENS.OwnerName; //拥有者姓名
objvClsRmTeachingCase_BaseENT.OwnerNameWithId = objvClsRmTeachingCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvClsRmTeachingCase_BaseENT.BrowseCount4Case = objvClsRmTeachingCase_BaseENS.BrowseCount4Case; //课例浏览次数
objvClsRmTeachingCase_BaseENT.CaseTypeName = objvClsRmTeachingCase_BaseENS.CaseTypeName; //案例类型名称
objvClsRmTeachingCase_BaseENT.ftpFileType = objvClsRmTeachingCase_BaseENS.ftpFileType; //ftp文件类型
objvClsRmTeachingCase_BaseENT.IsUse = objvClsRmTeachingCase_BaseENS.IsUse; //是否使用
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
public static DataTable ToDataTable(List<clsvClsRmTeachingCase_BaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvClsRmTeachingCase_BaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvClsRmTeachingCase_BaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvClsRmTeachingCase_BaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvClsRmTeachingCase_BaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvClsRmTeachingCase_BaseEN.AttributeName)
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
//if (arrvClsRmTeachingCase_BaseObjLst_Cache == null)
//{
//arrvClsRmTeachingCase_BaseObjLst_Cache = await clsvClsRmTeachingCase_BaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvClsRmTeachingCase_BaseEN._CurrTabName_S);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvClsRmTeachingCase_BaseEN._CurrTabName_S);
List<clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClsRmTeachingCase_BaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvClsRmTeachingCase_BaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convClsRmTeachingCase_Base.Id_ClsRmTeachingCase, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_School_Ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_Discipline_Ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convClsRmTeachingCase_Base.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase_Base.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase_Base.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCase_Base.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.DisciplineName_ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.GradeName_ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.id_Grade_ps, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convClsRmTeachingCase_Base.CaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCase_Base.IsUse, Type.GetType("System.Boolean"));
foreach (clsvClsRmTeachingCase_BaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convClsRmTeachingCase_Base.Id_ClsRmTeachingCase] = objInFor[convClsRmTeachingCase_Base.Id_ClsRmTeachingCase];
objDR[convClsRmTeachingCase_Base.ClsRmTeachingCaseID] = objInFor[convClsRmTeachingCase_Base.ClsRmTeachingCaseID];
objDR[convClsRmTeachingCase_Base.ClsRmTeachingCaseName] = objInFor[convClsRmTeachingCase_Base.ClsRmTeachingCaseName];
objDR[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] = objInFor[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme];
objDR[convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType] = objInFor[convClsRmTeachingCase_Base.id_ClsRmTeachingCaseType];
objDR[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] = objInFor[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName];
objDR[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] = objInFor[convClsRmTeachingCase_Base.ClsRmTeachingCaseText];
objDR[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] = objInFor[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate];
objDR[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] = objInFor[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime];
objDR[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] = objInFor[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn];
objDR[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] = objInFor[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn];
objDR[convClsRmTeachingCase_Base.id_StudyLevel] = objInFor[convClsRmTeachingCase_Base.id_StudyLevel];
objDR[convClsRmTeachingCase_Base.StudyLevelName] = objInFor[convClsRmTeachingCase_Base.StudyLevelName];
objDR[convClsRmTeachingCase_Base.id_TeachingPlan] = objInFor[convClsRmTeachingCase_Base.id_TeachingPlan];
objDR[convClsRmTeachingCase_Base.Id_CaseType] = objInFor[convClsRmTeachingCase_Base.Id_CaseType];
objDR[convClsRmTeachingCase_Base.id_Discipline] = objInFor[convClsRmTeachingCase_Base.id_Discipline];
objDR[convClsRmTeachingCase_Base.DisciplineID] = objInFor[convClsRmTeachingCase_Base.DisciplineID];
objDR[convClsRmTeachingCase_Base.id_School_Ps] = objInFor[convClsRmTeachingCase_Base.id_School_Ps];
objDR[convClsRmTeachingCase_Base.SchoolId] = objInFor[convClsRmTeachingCase_Base.SchoolId];
objDR[convClsRmTeachingCase_Base.SchoolName] = objInFor[convClsRmTeachingCase_Base.SchoolName];
objDR[convClsRmTeachingCase_Base.id_Discipline_Ps] = objInFor[convClsRmTeachingCase_Base.id_Discipline_Ps];
objDR[convClsRmTeachingCase_Base.DisciplineName] = objInFor[convClsRmTeachingCase_Base.DisciplineName];
objDR[convClsRmTeachingCase_Base.id_GradeBase] = objInFor[convClsRmTeachingCase_Base.id_GradeBase];
objDR[convClsRmTeachingCase_Base.id_SenateGaugeVersion] = objInFor[convClsRmTeachingCase_Base.id_SenateGaugeVersion];
objDR[convClsRmTeachingCase_Base.senateGaugeVersionID] = objInFor[convClsRmTeachingCase_Base.senateGaugeVersionID];
objDR[convClsRmTeachingCase_Base.senateGaugeVersionName] = objInFor[convClsRmTeachingCase_Base.senateGaugeVersionName];
objDR[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] = objInFor[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore];
objDR[convClsRmTeachingCase_Base.VersionNo] = objInFor[convClsRmTeachingCase_Base.VersionNo];
objDR[convClsRmTeachingCase_Base.id_TeachSkill] = objInFor[convClsRmTeachingCase_Base.id_TeachSkill];
objDR[convClsRmTeachingCase_Base.TeachSkillID] = objInFor[convClsRmTeachingCase_Base.TeachSkillID];
objDR[convClsRmTeachingCase_Base.SkillTypeName] = objInFor[convClsRmTeachingCase_Base.SkillTypeName];
objDR[convClsRmTeachingCase_Base.TeachSkillName] = objInFor[convClsRmTeachingCase_Base.TeachSkillName];
objDR[convClsRmTeachingCase_Base.TeachSkillTheory] = objInFor[convClsRmTeachingCase_Base.TeachSkillTheory];
objDR[convClsRmTeachingCase_Base.TeachSkillOperMethod] = objInFor[convClsRmTeachingCase_Base.TeachSkillOperMethod];
objDR[convClsRmTeachingCase_Base.id_SkillType] = objInFor[convClsRmTeachingCase_Base.id_SkillType];
objDR[convClsRmTeachingCase_Base.SkillTypeID] = objInFor[convClsRmTeachingCase_Base.SkillTypeID];
objDR[convClsRmTeachingCase_Base.CaseLevelId] = objInFor[convClsRmTeachingCase_Base.CaseLevelId];
objDR[convClsRmTeachingCase_Base.CaseLevelName] = objInFor[convClsRmTeachingCase_Base.CaseLevelName];
objDR[convClsRmTeachingCase_Base.DocFile] = objInFor[convClsRmTeachingCase_Base.DocFile];
objDR[convClsRmTeachingCase_Base.IsNeedGeneWord] = objInFor[convClsRmTeachingCase_Base.IsNeedGeneWord];
objDR[convClsRmTeachingCase_Base.WordCreateDate] = objInFor[convClsRmTeachingCase_Base.WordCreateDate];
objDR[convClsRmTeachingCase_Base.IsVisible] = objInFor[convClsRmTeachingCase_Base.IsVisible];
objDR[convClsRmTeachingCase_Base.OwnerId] = objInFor[convClsRmTeachingCase_Base.OwnerId];
objDR[convClsRmTeachingCase_Base.id_StudentInfo] = objInFor[convClsRmTeachingCase_Base.id_StudentInfo];
objDR[convClsRmTeachingCase_Base.StuName] = objInFor[convClsRmTeachingCase_Base.StuName];
objDR[convClsRmTeachingCase_Base.StuID] = objInFor[convClsRmTeachingCase_Base.StuID];
objDR[convClsRmTeachingCase_Base.PoliticsName] = objInFor[convClsRmTeachingCase_Base.PoliticsName];
objDR[convClsRmTeachingCase_Base.SexDesc] = objInFor[convClsRmTeachingCase_Base.SexDesc];
objDR[convClsRmTeachingCase_Base.EthnicName] = objInFor[convClsRmTeachingCase_Base.EthnicName];
objDR[convClsRmTeachingCase_Base.UniZoneDesc] = objInFor[convClsRmTeachingCase_Base.UniZoneDesc];
objDR[convClsRmTeachingCase_Base.StuTypeDesc] = objInFor[convClsRmTeachingCase_Base.StuTypeDesc];
objDR[convClsRmTeachingCase_Base.id_XzCollege] = objInFor[convClsRmTeachingCase_Base.id_XzCollege];
objDR[convClsRmTeachingCase_Base.CollegeID] = objInFor[convClsRmTeachingCase_Base.CollegeID];
objDR[convClsRmTeachingCase_Base.CollegeName] = objInFor[convClsRmTeachingCase_Base.CollegeName];
objDR[convClsRmTeachingCase_Base.CollegeNameA] = objInFor[convClsRmTeachingCase_Base.CollegeNameA];
objDR[convClsRmTeachingCase_Base.id_XzMajor] = objInFor[convClsRmTeachingCase_Base.id_XzMajor];
objDR[convClsRmTeachingCase_Base.MajorName] = objInFor[convClsRmTeachingCase_Base.MajorName];
objDR[convClsRmTeachingCase_Base.GradeBaseName] = objInFor[convClsRmTeachingCase_Base.GradeBaseName];
objDR[convClsRmTeachingCase_Base.id_AdminCls] = objInFor[convClsRmTeachingCase_Base.id_AdminCls];
objDR[convClsRmTeachingCase_Base.AdminClsId] = objInFor[convClsRmTeachingCase_Base.AdminClsId];
objDR[convClsRmTeachingCase_Base.AdminClsName] = objInFor[convClsRmTeachingCase_Base.AdminClsName];
objDR[convClsRmTeachingCase_Base.Birthday] = objInFor[convClsRmTeachingCase_Base.Birthday];
objDR[convClsRmTeachingCase_Base.NativePlace] = objInFor[convClsRmTeachingCase_Base.NativePlace];
objDR[convClsRmTeachingCase_Base.Duty] = objInFor[convClsRmTeachingCase_Base.Duty];
objDR[convClsRmTeachingCase_Base.IDCardNo] = objInFor[convClsRmTeachingCase_Base.IDCardNo];
objDR[convClsRmTeachingCase_Base.StuCardNo] = objInFor[convClsRmTeachingCase_Base.StuCardNo];
objDR[convClsRmTeachingCase_Base.LiveAddress] = objInFor[convClsRmTeachingCase_Base.LiveAddress];
objDR[convClsRmTeachingCase_Base.HomePhone] = objInFor[convClsRmTeachingCase_Base.HomePhone];
objDR[convClsRmTeachingCase_Base.EnrollmentDate] = objInFor[convClsRmTeachingCase_Base.EnrollmentDate];
objDR[convClsRmTeachingCase_Base.PostCode] = objInFor[convClsRmTeachingCase_Base.PostCode];
objDR[convClsRmTeachingCase_Base.UserKindId] = objInFor[convClsRmTeachingCase_Base.UserKindId];
objDR[convClsRmTeachingCase_Base.UserKindName] = objInFor[convClsRmTeachingCase_Base.UserKindName];
objDR[convClsRmTeachingCase_Base.UserTypeId] = objInFor[convClsRmTeachingCase_Base.UserTypeId];
objDR[convClsRmTeachingCase_Base.IsDualVideo] = objInFor[convClsRmTeachingCase_Base.IsDualVideo];
objDR[convClsRmTeachingCase_Base.RecommendedDegreeId] = objInFor[convClsRmTeachingCase_Base.RecommendedDegreeId];
objDR[convClsRmTeachingCase_Base.RecommendedDegreeName] = objInFor[convClsRmTeachingCase_Base.RecommendedDegreeName];
objDR[convClsRmTeachingCase_Base.Memo] = objInFor[convClsRmTeachingCase_Base.Memo];
objDR[convClsRmTeachingCase_Base.DisciplineName_ps] = objInFor[convClsRmTeachingCase_Base.DisciplineName_ps];
objDR[convClsRmTeachingCase_Base.GradeName_ps] = objInFor[convClsRmTeachingCase_Base.GradeName_ps];
objDR[convClsRmTeachingCase_Base.id_Grade_ps] = objInFor[convClsRmTeachingCase_Base.id_Grade_ps];
objDR[convClsRmTeachingCase_Base.OwnerName] = objInFor[convClsRmTeachingCase_Base.OwnerName];
objDR[convClsRmTeachingCase_Base.OwnerNameWithId] = objInFor[convClsRmTeachingCase_Base.OwnerNameWithId];
objDR[convClsRmTeachingCase_Base.BrowseCount4Case] = objInFor[convClsRmTeachingCase_Base.BrowseCount4Case];
objDR[convClsRmTeachingCase_Base.CaseTypeName] = objInFor[convClsRmTeachingCase_Base.CaseTypeName];
objDR[convClsRmTeachingCase_Base.ftpFileType] = objInFor[convClsRmTeachingCase_Base.ftpFileType];
objDR[convClsRmTeachingCase_Base.IsUse] = objInFor[convClsRmTeachingCase_Base.IsUse];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}