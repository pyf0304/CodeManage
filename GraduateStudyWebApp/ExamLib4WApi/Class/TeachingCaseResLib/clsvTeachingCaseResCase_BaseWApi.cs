
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCase_BaseWApi
 表名:vTeachingCaseResCase_Base(01120515)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:28
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源
 模块英文名:TeachingCaseResLib
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
public static class clsvTeachingCaseResCase_BaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetId_TeachingCaseResCase(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strId_TeachingCaseResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_TeachingCaseResCase, 8, convTeachingCaseResCase_Base.Id_TeachingCaseResCase);
clsCheckSql.CheckFieldForeignKey(strId_TeachingCaseResCase, 8, convTeachingCaseResCase_Base.Id_TeachingCaseResCase);
objvTeachingCaseResCase_BaseEN.Id_TeachingCaseResCase = strId_TeachingCaseResCase; //教学案例资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.Id_TeachingCaseResCase) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.Id_TeachingCaseResCase, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.Id_TeachingCaseResCase] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseID, convTeachingCaseResCase_Base.TeachingCaseResCaseID);
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseID, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseID);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseID, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseID);
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = strTeachingCaseResCaseID; //教学案例资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachingCaseResCaseID) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseName, convTeachingCaseResCase_Base.TeachingCaseResCaseName);
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, convTeachingCaseResCase_Base.TeachingCaseResCaseName);
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = strTeachingCaseResCaseName; //教学案例资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachingCaseResCaseName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseTheme(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTheme, 200, convTeachingCaseResCase_Base.TeachingCaseResCaseTheme);
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = strTeachingCaseResCaseTheme; //教学案例资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachingCaseResCaseTheme) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseTheme, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseText(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseText, 8000, convTeachingCaseResCase_Base.TeachingCaseResCaseText);
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = strTeachingCaseResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachingCaseResCaseText) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseText, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseText] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseDate(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseDate);
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = strTeachingCaseResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachingCaseResCaseDate) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseDate, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseTime(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase_Base.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase_Base.TeachingCaseResCaseTime);
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = strTeachingCaseResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachingCaseResCaseTime) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseTime, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseDateIn(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn);
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = strTeachingCaseResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseTimeIn(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn);
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = strTeachingCaseResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN Setid_TeachingCaseResCaseType(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strid_TeachingCaseResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingCaseResCaseType, convTeachingCaseResCase_Base.id_TeachingCaseResCaseType);
clsCheckSql.CheckFieldLen(strid_TeachingCaseResCaseType, 4, convTeachingCaseResCase_Base.id_TeachingCaseResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_TeachingCaseResCaseType, 4, convTeachingCaseResCase_Base.id_TeachingCaseResCaseType);
objvTeachingCaseResCase_BaseEN.id_TeachingCaseResCaseType = strid_TeachingCaseResCaseType; //教学案例资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.id_TeachingCaseResCaseType) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.id_TeachingCaseResCaseType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.id_TeachingCaseResCaseType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseTypeName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTypeName, 30, convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName);
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = strTeachingCaseResCaseTypeName; //教学案例资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convTeachingCaseResCase_Base.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingCaseResCase_Base.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingCaseResCase_Base.CourseId);
objvTeachingCaseResCase_BaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CourseId) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CourseId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseCode(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingCaseResCase_Base.CourseCode);
objvTeachingCaseResCase_BaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CourseCode) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CourseCode, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseCode] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convTeachingCaseResCase_Base.CourseName);
objvTeachingCaseResCase_BaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CourseName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CourseName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetOwnerId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convTeachingCaseResCase_Base.OwnerId);
objvTeachingCaseResCase_BaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.OwnerId) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.OwnerId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.OwnerId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN Setid_StudyLevel(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convTeachingCaseResCase_Base.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convTeachingCaseResCase_Base.id_StudyLevel);
objvTeachingCaseResCase_BaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.id_StudyLevel) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.id_StudyLevel, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.id_StudyLevel] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetStudyLevelName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convTeachingCaseResCase_Base.StudyLevelName);
objvTeachingCaseResCase_BaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.StudyLevelName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.StudyLevelName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.StudyLevelName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN Setid_TeachingPlan(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convTeachingCaseResCase_Base.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convTeachingCaseResCase_Base.id_TeachingPlan);
objvTeachingCaseResCase_BaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.id_TeachingPlan) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.id_TeachingPlan, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.id_TeachingPlan] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN Setid_Discipline(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convTeachingCaseResCase_Base.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convTeachingCaseResCase_Base.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convTeachingCaseResCase_Base.id_Discipline);
objvTeachingCaseResCase_BaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.id_Discipline) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.id_Discipline, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.id_Discipline] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetDisciplineID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convTeachingCaseResCase_Base.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convTeachingCaseResCase_Base.DisciplineID);
objvTeachingCaseResCase_BaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.DisciplineID) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.DisciplineID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.DisciplineID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetDisciplineName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convTeachingCaseResCase_Base.DisciplineName);
objvTeachingCaseResCase_BaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.DisciplineName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.DisciplineName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.DisciplineName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN Setid_SenateGaugeVersion(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convTeachingCaseResCase_Base.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convTeachingCaseResCase_Base.id_SenateGaugeVersion);
objvTeachingCaseResCase_BaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.id_SenateGaugeVersion) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetsenateGaugeVersionID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convTeachingCaseResCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convTeachingCaseResCase_Base.senateGaugeVersionID);
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.senateGaugeVersionID) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.senateGaugeVersionID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.senateGaugeVersionID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetsenateGaugeVersionName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convTeachingCaseResCase_Base.senateGaugeVersionName);
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.senateGaugeVersionName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.senateGaugeVersionName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.senateGaugeVersionName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.senateGaugeVersionTtlScore) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetVersionNo(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, int intVersionNo, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.VersionNo) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.VersionNo, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.VersionNo] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN Setid_TeachSkill(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convTeachingCaseResCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convTeachingCaseResCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convTeachingCaseResCase_Base.id_TeachSkill);
objvTeachingCaseResCase_BaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.id_TeachSkill) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.id_TeachSkill, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.id_TeachSkill] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachSkillID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachingCaseResCase_Base.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachingCaseResCase_Base.TeachSkillID);
objvTeachingCaseResCase_BaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachSkillID) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachSkillID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetSkillTypeName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachingCaseResCase_Base.SkillTypeName);
objvTeachingCaseResCase_BaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.SkillTypeName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.SkillTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.SkillTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachSkillName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachingCaseResCase_Base.TeachSkillName);
objvTeachingCaseResCase_BaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachSkillName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachSkillName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachSkillTheory(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachingCaseResCase_Base.TeachSkillTheory);
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachSkillTheory) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachSkillTheory, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillTheory] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachSkillOperMethod(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachingCaseResCase_Base.TeachSkillOperMethod);
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.TeachSkillOperMethod) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN Setid_SkillType(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convTeachingCaseResCase_Base.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convTeachingCaseResCase_Base.id_SkillType);
objvTeachingCaseResCase_BaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.id_SkillType) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.id_SkillType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.id_SkillType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetSkillTypeID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachingCaseResCase_Base.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachingCaseResCase_Base.SkillTypeID);
objvTeachingCaseResCase_BaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.SkillTypeID) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.SkillTypeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.SkillTypeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCaseLevelId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convTeachingCaseResCase_Base.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convTeachingCaseResCase_Base.CaseLevelId);
objvTeachingCaseResCase_BaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CaseLevelId) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CaseLevelId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CaseLevelId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCaseLevelName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convTeachingCaseResCase_Base.CaseLevelName);
objvTeachingCaseResCase_BaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CaseLevelName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CaseLevelName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CaseLevelName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetDocFile(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convTeachingCaseResCase_Base.DocFile);
objvTeachingCaseResCase_BaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.DocFile) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.DocFile, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.DocFile] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIsNeedGeneWord(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IsNeedGeneWord) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IsNeedGeneWord, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IsNeedGeneWord] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetWordCreateDate(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convTeachingCaseResCase_Base.WordCreateDate);
objvTeachingCaseResCase_BaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.WordCreateDate) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.WordCreateDate, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.WordCreateDate] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIsVisible(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IsVisible) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IsVisible, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IsVisible] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIsDualVideo(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IsDualVideo) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IsDualVideo, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IsDualVideo] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN Setid_XzCollege(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convTeachingCaseResCase_Base.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convTeachingCaseResCase_Base.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convTeachingCaseResCase_Base.id_XzCollege);
objvTeachingCaseResCase_BaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.id_XzCollege) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.id_XzCollege, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.id_XzCollege] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCollegeID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachingCaseResCase_Base.CollegeID);
objvTeachingCaseResCase_BaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CollegeID) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CollegeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CollegeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCollegeName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingCaseResCase_Base.CollegeName);
objvTeachingCaseResCase_BaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CollegeName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CollegeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CollegeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCollegeNameA(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachingCaseResCase_Base.CollegeNameA);
objvTeachingCaseResCase_BaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CollegeNameA) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CollegeNameA, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CollegeNameA] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN Setid_XzMajor(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convTeachingCaseResCase_Base.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convTeachingCaseResCase_Base.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convTeachingCaseResCase_Base.id_XzMajor);
objvTeachingCaseResCase_BaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.id_XzMajor) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.id_XzMajor, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.id_XzMajor] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetMajorID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convTeachingCaseResCase_Base.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convTeachingCaseResCase_Base.MajorID);
objvTeachingCaseResCase_BaseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.MajorID) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.MajorID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.MajorID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetMajorName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convTeachingCaseResCase_Base.MajorName);
objvTeachingCaseResCase_BaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.MajorName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.MajorName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.MajorName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseChapterId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convTeachingCaseResCase_Base.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convTeachingCaseResCase_Base.CourseChapterId);
objvTeachingCaseResCase_BaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CourseChapterId) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CourseChapterId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseChapterId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseChapterName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convTeachingCaseResCase_Base.CourseChapterName);
objvTeachingCaseResCase_BaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CourseChapterName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CourseChapterName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseChapterName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetParentNodeID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convTeachingCaseResCase_Base.ParentNodeID);
objvTeachingCaseResCase_BaseEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.ParentNodeID) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.ParentNodeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.ParentNodeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetParentNodeName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convTeachingCaseResCase_Base.ParentNodeName);
objvTeachingCaseResCase_BaseEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.ParentNodeName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.ParentNodeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.ParentNodeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseChapterReferred(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convTeachingCaseResCase_Base.CourseChapterReferred);
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CourseChapterReferred) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CourseChapterReferred, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseChapterReferred] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetParentNodeReferred(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convTeachingCaseResCase_Base.ParentNodeReferred);
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.ParentNodeReferred) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.ParentNodeReferred, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.ParentNodeReferred] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetViewCount(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, int intViewCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.ViewCount) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.ViewCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.ViewCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIsShow(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IsShow) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IsShow, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IsShow] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetDownloadNumber(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.DownloadNumber) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.DownloadNumber, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.DownloadNumber] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetFileIntegration(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, int intFileIntegration, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.FileIntegration) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.FileIntegration, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.FileIntegration] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetLikeCount(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, long lngLikeCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.LikeCount) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.LikeCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.LikeCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCollectionCount(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CollectionCount) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CollectionCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CollectionCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetRecommendedDegreeId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convTeachingCaseResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convTeachingCaseResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convTeachingCaseResCase_Base.RecommendedDegreeId);
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.RecommendedDegreeId) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.RecommendedDegreeId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.RecommendedDegreeId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetRecommendedDegreeName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convTeachingCaseResCase_Base.RecommendedDegreeName);
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.RecommendedDegreeName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.RecommendedDegreeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.RecommendedDegreeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetftpFileType(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachingCaseResCase_Base.ftpFileType);
objvTeachingCaseResCase_BaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.ftpFileType) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.ftpFileType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.ftpFileType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetVideoUrl(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convTeachingCaseResCase_Base.VideoUrl);
objvTeachingCaseResCase_BaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.VideoUrl) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.VideoUrl, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.VideoUrl] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetVideoPath(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convTeachingCaseResCase_Base.VideoPath);
objvTeachingCaseResCase_BaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.VideoPath) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.VideoPath, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.VideoPath] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetResErrMsg(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convTeachingCaseResCase_Base.ResErrMsg);
objvTeachingCaseResCase_BaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.ResErrMsg) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.ResErrMsg, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.ResErrMsg] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetMemo(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingCaseResCase_Base.Memo);
objvTeachingCaseResCase_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.Memo) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.Memo, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.Memo] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetOwnerName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convTeachingCaseResCase_Base.OwnerName);
objvTeachingCaseResCase_BaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.OwnerName) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.OwnerName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.OwnerName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetOwnerNameWithId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convTeachingCaseResCase_Base.OwnerNameWithId);
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.OwnerNameWithId) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.OwnerNameWithId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.OwnerNameWithId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetBrowseCount4Case(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.BrowseCount4Case) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.BrowseCount4Case, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.BrowseCount4Case] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_Base_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.Id_TeachingCaseResCase) == true)
{
string strComparisonOp_Id_TeachingCaseResCase = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.Id_TeachingCaseResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.Id_TeachingCaseResCase, objvTeachingCaseResCase_Base_Cond.Id_TeachingCaseResCase, strComparisonOp_Id_TeachingCaseResCase);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseID) == true)
{
string strComparisonOp_TeachingCaseResCaseID = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseID, objvTeachingCaseResCase_Base_Cond.TeachingCaseResCaseID, strComparisonOp_TeachingCaseResCaseID);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseName) == true)
{
string strComparisonOp_TeachingCaseResCaseName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseName, objvTeachingCaseResCase_Base_Cond.TeachingCaseResCaseName, strComparisonOp_TeachingCaseResCaseName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseTheme) == true)
{
string strComparisonOp_TeachingCaseResCaseTheme = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseTheme, objvTeachingCaseResCase_Base_Cond.TeachingCaseResCaseTheme, strComparisonOp_TeachingCaseResCaseTheme);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseText) == true)
{
string strComparisonOp_TeachingCaseResCaseText = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseText, objvTeachingCaseResCase_Base_Cond.TeachingCaseResCaseText, strComparisonOp_TeachingCaseResCaseText);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseDate) == true)
{
string strComparisonOp_TeachingCaseResCaseDate = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseDate, objvTeachingCaseResCase_Base_Cond.TeachingCaseResCaseDate, strComparisonOp_TeachingCaseResCaseDate);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseTime) == true)
{
string strComparisonOp_TeachingCaseResCaseTime = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseTime, objvTeachingCaseResCase_Base_Cond.TeachingCaseResCaseTime, strComparisonOp_TeachingCaseResCaseTime);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn) == true)
{
string strComparisonOp_TeachingCaseResCaseDateIn = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn, objvTeachingCaseResCase_Base_Cond.TeachingCaseResCaseDateIn, strComparisonOp_TeachingCaseResCaseDateIn);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn) == true)
{
string strComparisonOp_TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn, objvTeachingCaseResCase_Base_Cond.TeachingCaseResCaseTimeIn, strComparisonOp_TeachingCaseResCaseTimeIn);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.id_TeachingCaseResCaseType) == true)
{
string strComparisonOp_id_TeachingCaseResCaseType = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.id_TeachingCaseResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.id_TeachingCaseResCaseType, objvTeachingCaseResCase_Base_Cond.id_TeachingCaseResCaseType, strComparisonOp_id_TeachingCaseResCaseType);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName) == true)
{
string strComparisonOp_TeachingCaseResCaseTypeName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName, objvTeachingCaseResCase_Base_Cond.TeachingCaseResCaseTypeName, strComparisonOp_TeachingCaseResCaseTypeName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CourseId) == true)
{
string strComparisonOp_CourseId = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseId, objvTeachingCaseResCase_Base_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseCode, objvTeachingCaseResCase_Base_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CourseName) == true)
{
string strComparisonOp_CourseName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseName, objvTeachingCaseResCase_Base_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.OwnerId, objvTeachingCaseResCase_Base_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.id_StudyLevel, objvTeachingCaseResCase_Base_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.StudyLevelName, objvTeachingCaseResCase_Base_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.id_TeachingPlan, objvTeachingCaseResCase_Base_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.id_Discipline, objvTeachingCaseResCase_Base_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.DisciplineID, objvTeachingCaseResCase_Base_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.DisciplineName, objvTeachingCaseResCase_Base_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.id_SenateGaugeVersion, objvTeachingCaseResCase_Base_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.senateGaugeVersionID, objvTeachingCaseResCase_Base_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.senateGaugeVersionName, objvTeachingCaseResCase_Base_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.senateGaugeVersionTtlScore, objvTeachingCaseResCase_Base_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.VersionNo, objvTeachingCaseResCase_Base_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.id_TeachSkill, objvTeachingCaseResCase_Base_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachSkillID, objvTeachingCaseResCase_Base_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.SkillTypeName, objvTeachingCaseResCase_Base_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachSkillName, objvTeachingCaseResCase_Base_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachSkillTheory, objvTeachingCaseResCase_Base_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachSkillOperMethod, objvTeachingCaseResCase_Base_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.id_SkillType, objvTeachingCaseResCase_Base_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.SkillTypeID, objvTeachingCaseResCase_Base_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CaseLevelId, objvTeachingCaseResCase_Base_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CaseLevelName, objvTeachingCaseResCase_Base_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.DocFile) == true)
{
string strComparisonOp_DocFile = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.DocFile, objvTeachingCaseResCase_Base_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.IsNeedGeneWord) == true)
{
if (objvTeachingCaseResCase_Base_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Base.IsNeedGeneWord);
}
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.WordCreateDate, objvTeachingCaseResCase_Base_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.IsVisible) == true)
{
if (objvTeachingCaseResCase_Base_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Base.IsVisible);
}
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.IsDualVideo) == true)
{
if (objvTeachingCaseResCase_Base_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Base.IsDualVideo);
}
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.id_XzCollege, objvTeachingCaseResCase_Base_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CollegeID, objvTeachingCaseResCase_Base_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CollegeName, objvTeachingCaseResCase_Base_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CollegeNameA, objvTeachingCaseResCase_Base_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.id_XzMajor, objvTeachingCaseResCase_Base_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.MajorID) == true)
{
string strComparisonOp_MajorID = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.MajorID, objvTeachingCaseResCase_Base_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.MajorName) == true)
{
string strComparisonOp_MajorName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.MajorName, objvTeachingCaseResCase_Base_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseChapterId, objvTeachingCaseResCase_Base_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseChapterName, objvTeachingCaseResCase_Base_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.ParentNodeID, objvTeachingCaseResCase_Base_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.ParentNodeName, objvTeachingCaseResCase_Base_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseChapterReferred, objvTeachingCaseResCase_Base_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.ParentNodeReferred, objvTeachingCaseResCase_Base_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.ViewCount, objvTeachingCaseResCase_Base_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.IsShow) == true)
{
if (objvTeachingCaseResCase_Base_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Base.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Base.IsShow);
}
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.DownloadNumber, objvTeachingCaseResCase_Base_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.FileIntegration, objvTeachingCaseResCase_Base_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.LikeCount, objvTeachingCaseResCase_Base_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.CollectionCount, objvTeachingCaseResCase_Base_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.RecommendedDegreeId, objvTeachingCaseResCase_Base_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.RecommendedDegreeName, objvTeachingCaseResCase_Base_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.ftpFileType, objvTeachingCaseResCase_Base_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.VideoUrl, objvTeachingCaseResCase_Base_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.VideoPath, objvTeachingCaseResCase_Base_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.ResErrMsg, objvTeachingCaseResCase_Base_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.Memo) == true)
{
string strComparisonOp_Memo = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.Memo, objvTeachingCaseResCase_Base_Cond.Memo, strComparisonOp_Memo);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.OwnerName, objvTeachingCaseResCase_Base_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.OwnerNameWithId, objvTeachingCaseResCase_Base_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvTeachingCaseResCase_Base_Cond.IsUpdated(convTeachingCaseResCase_Base.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvTeachingCaseResCase_Base_Cond.dicFldComparisonOp[convTeachingCaseResCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.BrowseCount4Case, objvTeachingCaseResCase_Base_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学案例资源案例_Base(vTeachingCaseResCase_Base)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingCaseResCase_BaseWApi
{
private static readonly string mstrApiControllerName = "vTeachingCaseResCase_BaseApi";

 public clsvTeachingCaseResCase_BaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_Id_TeachingCaseResCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教学案例资源案例_Base]...","0");
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="Id_TeachingCaseResCase";
objDDL.DataTextField="TeachingCaseResCaseName";
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
public static void BindCbo_Id_TeachingCaseResCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convTeachingCaseResCase_Base.Id_TeachingCaseResCase); 
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = clsvTeachingCaseResCase_BaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN()
{
Id_TeachingCaseResCase = "0",
TeachingCaseResCaseName = "选[v教学案例资源案例_Base]..."
};
arrObjLst.Insert(0, objvTeachingCaseResCase_BaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convTeachingCaseResCase_Base.Id_TeachingCaseResCase;
objComboBox.DisplayMember = convTeachingCaseResCase_Base.TeachingCaseResCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_TeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCase_BaseEN GetObjById_TeachingCaseResCase(string strId_TeachingCaseResCase)
{
string strAction = "GetObjById_TeachingCaseResCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_TeachingCaseResCase"] = strId_TeachingCaseResCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingCaseResCase_BaseEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCase_BaseEN;
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
 /// <param name = "strId_TeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCase_BaseEN GetObjById_TeachingCaseResCase_WA_Cache(string strId_TeachingCaseResCase)
{
string strAction = "GetObjById_TeachingCaseResCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_TeachingCaseResCase"] = strId_TeachingCaseResCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingCaseResCase_BaseEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCase_BaseEN;
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
public static clsvTeachingCaseResCase_BaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = null;
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
objvTeachingCaseResCase_BaseEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCase_BaseEN;
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
 /// <param name = "strId_TeachingCaseResCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCase_BaseEN GetObjById_TeachingCaseResCase_Cache(string strId_TeachingCaseResCase)
{
if (string.IsNullOrEmpty(strId_TeachingCaseResCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCase_BaseEN._CurrTabName_S);
List<clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Sel =
from objvTeachingCaseResCase_BaseEN in arrvTeachingCaseResCase_BaseObjLst_Cache
where objvTeachingCaseResCase_BaseEN.Id_TeachingCaseResCase == strId_TeachingCaseResCase
select objvTeachingCaseResCase_BaseEN;
if (arrvTeachingCaseResCase_BaseObjLst_Sel.Count() == 0)
{
   clsvTeachingCaseResCase_BaseEN obj = clsvTeachingCaseResCase_BaseWApi.GetObjById_TeachingCaseResCase(strId_TeachingCaseResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachingCaseResCase_BaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_TeachingCaseResCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeachingCaseResCaseNameById_TeachingCaseResCase_Cache(string strId_TeachingCaseResCase)
{
if (string.IsNullOrEmpty(strId_TeachingCaseResCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCase_BaseEN._CurrTabName_S);
List<clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Sel1 =
from objvTeachingCaseResCase_BaseEN in arrvTeachingCaseResCase_BaseObjLst_Cache
where objvTeachingCaseResCase_BaseEN.Id_TeachingCaseResCase == strId_TeachingCaseResCase
select objvTeachingCaseResCase_BaseEN;
List <clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Sel = new List<clsvTeachingCaseResCase_BaseEN>();
foreach (clsvTeachingCaseResCase_BaseEN obj in arrvTeachingCaseResCase_BaseObjLst_Sel1)
{
arrvTeachingCaseResCase_BaseObjLst_Sel.Add(obj);
}
if (arrvTeachingCaseResCase_BaseObjLst_Sel.Count > 0)
{
return arrvTeachingCaseResCase_BaseObjLst_Sel[0].TeachingCaseResCaseName;
}
string strErrMsgForGetObjById = string.Format("在vTeachingCaseResCase_Base对象缓存列表中,找不到记录[Id_TeachingCaseResCase = {0}](函数:{1})", strId_TeachingCaseResCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvTeachingCaseResCase_BaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_TeachingCaseResCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameById_TeachingCaseResCase_Cache(string strId_TeachingCaseResCase)
{
if (string.IsNullOrEmpty(strId_TeachingCaseResCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCase_BaseEN._CurrTabName_S);
List<clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Sel1 =
from objvTeachingCaseResCase_BaseEN in arrvTeachingCaseResCase_BaseObjLst_Cache
where objvTeachingCaseResCase_BaseEN.Id_TeachingCaseResCase == strId_TeachingCaseResCase
select objvTeachingCaseResCase_BaseEN;
List <clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Sel = new List<clsvTeachingCaseResCase_BaseEN>();
foreach (clsvTeachingCaseResCase_BaseEN obj in arrvTeachingCaseResCase_BaseObjLst_Sel1)
{
arrvTeachingCaseResCase_BaseObjLst_Sel.Add(obj);
}
if (arrvTeachingCaseResCase_BaseObjLst_Sel.Count > 0)
{
return arrvTeachingCaseResCase_BaseObjLst_Sel[0].TeachingCaseResCaseName;
}
string strErrMsgForGetObjById = string.Format("在vTeachingCaseResCase_Base对象缓存列表中,找不到记录的相关名称[Id_TeachingCaseResCase = {0}](函数:{1})", strId_TeachingCaseResCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvTeachingCaseResCase_BaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachingCaseResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstById_TeachingCaseResCaseLst(List<string> arrId_TeachingCaseResCase)
{
 List<clsvTeachingCaseResCase_BaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachingCaseResCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachingCaseResCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_TeachingCaseResCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachingCaseResCase_BaseEN> GetObjLstById_TeachingCaseResCaseLst_Cache(List<string> arrId_TeachingCaseResCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCase_BaseEN._CurrTabName_S);
List<clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Sel =
from objvTeachingCaseResCase_BaseEN in arrvTeachingCaseResCase_BaseObjLst_Cache
where arrId_TeachingCaseResCase.Contains(objvTeachingCaseResCase_BaseEN.Id_TeachingCaseResCase)
select objvTeachingCaseResCase_BaseEN;
return arrvTeachingCaseResCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstById_TeachingCaseResCaseLst_WA_Cache(List<string> arrId_TeachingCaseResCase)
{
 List<clsvTeachingCaseResCase_BaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachingCaseResCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachingCaseResCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachingCaseResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachingCaseResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachingCaseResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachingCaseResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_TeachingCaseResCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_TeachingCaseResCase"] = strId_TeachingCaseResCase
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
 /// <param name = "objvTeachingCaseResCase_BaseENS">源对象</param>
 /// <param name = "objvTeachingCaseResCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseENS, clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseENT)
{
try
{
objvTeachingCaseResCase_BaseENT.Id_TeachingCaseResCase = objvTeachingCaseResCase_BaseENS.Id_TeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseID = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseName = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTheme = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseText = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseDate = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTime = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCase_BaseENT.id_TeachingCaseResCaseType = objvTeachingCaseResCase_BaseENS.id_TeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseENT.CourseId = objvTeachingCaseResCase_BaseENS.CourseId; //课程Id
objvTeachingCaseResCase_BaseENT.CourseCode = objvTeachingCaseResCase_BaseENS.CourseCode; //课程代码
objvTeachingCaseResCase_BaseENT.CourseName = objvTeachingCaseResCase_BaseENS.CourseName; //课程名称
objvTeachingCaseResCase_BaseENT.OwnerId = objvTeachingCaseResCase_BaseENS.OwnerId; //拥有者Id
objvTeachingCaseResCase_BaseENT.id_StudyLevel = objvTeachingCaseResCase_BaseENS.id_StudyLevel; //id_StudyLevel
objvTeachingCaseResCase_BaseENT.StudyLevelName = objvTeachingCaseResCase_BaseENS.StudyLevelName; //学段名称
objvTeachingCaseResCase_BaseENT.id_TeachingPlan = objvTeachingCaseResCase_BaseENS.id_TeachingPlan; //教案流水号
objvTeachingCaseResCase_BaseENT.id_Discipline = objvTeachingCaseResCase_BaseENS.id_Discipline; //学科流水号
objvTeachingCaseResCase_BaseENT.DisciplineID = objvTeachingCaseResCase_BaseENS.DisciplineID; //学科ID
objvTeachingCaseResCase_BaseENT.DisciplineName = objvTeachingCaseResCase_BaseENS.DisciplineName; //学科名称
objvTeachingCaseResCase_BaseENT.id_SenateGaugeVersion = objvTeachingCaseResCase_BaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCase_BaseENT.senateGaugeVersionID = objvTeachingCaseResCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCase_BaseENT.senateGaugeVersionName = objvTeachingCaseResCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCase_BaseENT.senateGaugeVersionTtlScore = objvTeachingCaseResCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCase_BaseENT.VersionNo = objvTeachingCaseResCase_BaseENS.VersionNo; //版本号
objvTeachingCaseResCase_BaseENT.id_TeachSkill = objvTeachingCaseResCase_BaseENS.id_TeachSkill; //教学技能流水号
objvTeachingCaseResCase_BaseENT.TeachSkillID = objvTeachingCaseResCase_BaseENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCase_BaseENT.SkillTypeName = objvTeachingCaseResCase_BaseENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCase_BaseENT.TeachSkillName = objvTeachingCaseResCase_BaseENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCase_BaseENT.TeachSkillTheory = objvTeachingCaseResCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCase_BaseENT.TeachSkillOperMethod = objvTeachingCaseResCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCase_BaseENT.id_SkillType = objvTeachingCaseResCase_BaseENS.id_SkillType; //技能类型流水号
objvTeachingCaseResCase_BaseENT.SkillTypeID = objvTeachingCaseResCase_BaseENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCase_BaseENT.CaseLevelId = objvTeachingCaseResCase_BaseENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCase_BaseENT.CaseLevelName = objvTeachingCaseResCase_BaseENS.CaseLevelName; //案例等级名称
objvTeachingCaseResCase_BaseENT.DocFile = objvTeachingCaseResCase_BaseENS.DocFile; //生成的Word文件名
objvTeachingCaseResCase_BaseENT.IsNeedGeneWord = objvTeachingCaseResCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvTeachingCaseResCase_BaseENT.WordCreateDate = objvTeachingCaseResCase_BaseENS.WordCreateDate; //Word生成日期
objvTeachingCaseResCase_BaseENT.IsVisible = objvTeachingCaseResCase_BaseENS.IsVisible; //是否显示
objvTeachingCaseResCase_BaseENT.IsDualVideo = objvTeachingCaseResCase_BaseENS.IsDualVideo; //是否双视频
objvTeachingCaseResCase_BaseENT.id_XzCollege = objvTeachingCaseResCase_BaseENS.id_XzCollege; //学院流水号
objvTeachingCaseResCase_BaseENT.CollegeID = objvTeachingCaseResCase_BaseENS.CollegeID; //学院ID
objvTeachingCaseResCase_BaseENT.CollegeName = objvTeachingCaseResCase_BaseENS.CollegeName; //学院名称
objvTeachingCaseResCase_BaseENT.CollegeNameA = objvTeachingCaseResCase_BaseENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCase_BaseENT.id_XzMajor = objvTeachingCaseResCase_BaseENS.id_XzMajor; //专业流水号
objvTeachingCaseResCase_BaseENT.MajorID = objvTeachingCaseResCase_BaseENS.MajorID; //专业ID
objvTeachingCaseResCase_BaseENT.MajorName = objvTeachingCaseResCase_BaseENS.MajorName; //专业名称
objvTeachingCaseResCase_BaseENT.CourseChapterId = objvTeachingCaseResCase_BaseENS.CourseChapterId; //课程章节ID
objvTeachingCaseResCase_BaseENT.CourseChapterName = objvTeachingCaseResCase_BaseENS.CourseChapterName; //课程章节名称
objvTeachingCaseResCase_BaseENT.ParentNodeID = objvTeachingCaseResCase_BaseENS.ParentNodeID; //父节点编号
objvTeachingCaseResCase_BaseENT.ParentNodeName = objvTeachingCaseResCase_BaseENS.ParentNodeName; //父节点名称
objvTeachingCaseResCase_BaseENT.CourseChapterReferred = objvTeachingCaseResCase_BaseENS.CourseChapterReferred; //节简称
objvTeachingCaseResCase_BaseENT.ParentNodeReferred = objvTeachingCaseResCase_BaseENS.ParentNodeReferred; //章简称
objvTeachingCaseResCase_BaseENT.ViewCount = objvTeachingCaseResCase_BaseENS.ViewCount; //浏览量
objvTeachingCaseResCase_BaseENT.IsShow = objvTeachingCaseResCase_BaseENS.IsShow; //是否启用
objvTeachingCaseResCase_BaseENT.DownloadNumber = objvTeachingCaseResCase_BaseENS.DownloadNumber; //下载数目
objvTeachingCaseResCase_BaseENT.FileIntegration = objvTeachingCaseResCase_BaseENS.FileIntegration; //文件积分
objvTeachingCaseResCase_BaseENT.LikeCount = objvTeachingCaseResCase_BaseENS.LikeCount; //资源喜欢数量
objvTeachingCaseResCase_BaseENT.CollectionCount = objvTeachingCaseResCase_BaseENS.CollectionCount; //收藏数量
objvTeachingCaseResCase_BaseENT.RecommendedDegreeId = objvTeachingCaseResCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvTeachingCaseResCase_BaseENT.RecommendedDegreeName = objvTeachingCaseResCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvTeachingCaseResCase_BaseENT.ftpFileType = objvTeachingCaseResCase_BaseENS.ftpFileType; //ftp文件类型
objvTeachingCaseResCase_BaseENT.VideoUrl = objvTeachingCaseResCase_BaseENS.VideoUrl; //视频Url
objvTeachingCaseResCase_BaseENT.VideoPath = objvTeachingCaseResCase_BaseENS.VideoPath; //视频目录
objvTeachingCaseResCase_BaseENT.ResErrMsg = objvTeachingCaseResCase_BaseENS.ResErrMsg; //资源错误信息
objvTeachingCaseResCase_BaseENT.Memo = objvTeachingCaseResCase_BaseENS.Memo; //备注
objvTeachingCaseResCase_BaseENT.OwnerName = objvTeachingCaseResCase_BaseENS.OwnerName; //拥有者姓名
objvTeachingCaseResCase_BaseENT.OwnerNameWithId = objvTeachingCaseResCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvTeachingCaseResCase_BaseENT.BrowseCount4Case = objvTeachingCaseResCase_BaseENS.BrowseCount4Case; //课例浏览次数
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
public static DataTable ToDataTable(List<clsvTeachingCaseResCase_BaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachingCaseResCase_BaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachingCaseResCase_BaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachingCaseResCase_BaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachingCaseResCase_BaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachingCaseResCase_BaseEN.AttributeName)
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
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseWApi没有刷新缓存机制(clsTeachingCaseResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseTypeWApi没有刷新缓存机制(clsTeachingCaseResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_TeachingCaseResCase");
//if (arrvTeachingCaseResCase_BaseObjLst_Cache == null)
//{
//arrvTeachingCaseResCase_BaseObjLst_Cache = await clsvTeachingCaseResCase_BaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachingCaseResCase_BaseEN._CurrTabName_S);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingCaseResCase_BaseEN._CurrTabName_S);
List<clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingCaseResCase_BaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachingCaseResCase_BaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachingCaseResCase_Base.Id_TeachingCaseResCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.id_TeachingCaseResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convTeachingCaseResCase_Base.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Base.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase_Base.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase_Base.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase_Base.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Base.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase_Base.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Base.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase_Base.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCase_Base.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCase_Base.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase_Base.BrowseCount4Case, Type.GetType("System.Int32"));
foreach (clsvTeachingCaseResCase_BaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachingCaseResCase_Base.Id_TeachingCaseResCase] = objInFor[convTeachingCaseResCase_Base.Id_TeachingCaseResCase];
objDR[convTeachingCaseResCase_Base.TeachingCaseResCaseID] = objInFor[convTeachingCaseResCase_Base.TeachingCaseResCaseID];
objDR[convTeachingCaseResCase_Base.TeachingCaseResCaseName] = objInFor[convTeachingCaseResCase_Base.TeachingCaseResCaseName];
objDR[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] = objInFor[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme];
objDR[convTeachingCaseResCase_Base.TeachingCaseResCaseText] = objInFor[convTeachingCaseResCase_Base.TeachingCaseResCaseText];
objDR[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] = objInFor[convTeachingCaseResCase_Base.TeachingCaseResCaseDate];
objDR[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] = objInFor[convTeachingCaseResCase_Base.TeachingCaseResCaseTime];
objDR[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] = objInFor[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn];
objDR[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] = objInFor[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn];
objDR[convTeachingCaseResCase_Base.id_TeachingCaseResCaseType] = objInFor[convTeachingCaseResCase_Base.id_TeachingCaseResCaseType];
objDR[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] = objInFor[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName];
objDR[convTeachingCaseResCase_Base.CourseId] = objInFor[convTeachingCaseResCase_Base.CourseId];
objDR[convTeachingCaseResCase_Base.CourseCode] = objInFor[convTeachingCaseResCase_Base.CourseCode];
objDR[convTeachingCaseResCase_Base.CourseName] = objInFor[convTeachingCaseResCase_Base.CourseName];
objDR[convTeachingCaseResCase_Base.OwnerId] = objInFor[convTeachingCaseResCase_Base.OwnerId];
objDR[convTeachingCaseResCase_Base.id_StudyLevel] = objInFor[convTeachingCaseResCase_Base.id_StudyLevel];
objDR[convTeachingCaseResCase_Base.StudyLevelName] = objInFor[convTeachingCaseResCase_Base.StudyLevelName];
objDR[convTeachingCaseResCase_Base.id_TeachingPlan] = objInFor[convTeachingCaseResCase_Base.id_TeachingPlan];
objDR[convTeachingCaseResCase_Base.id_Discipline] = objInFor[convTeachingCaseResCase_Base.id_Discipline];
objDR[convTeachingCaseResCase_Base.DisciplineID] = objInFor[convTeachingCaseResCase_Base.DisciplineID];
objDR[convTeachingCaseResCase_Base.DisciplineName] = objInFor[convTeachingCaseResCase_Base.DisciplineName];
objDR[convTeachingCaseResCase_Base.id_SenateGaugeVersion] = objInFor[convTeachingCaseResCase_Base.id_SenateGaugeVersion];
objDR[convTeachingCaseResCase_Base.senateGaugeVersionID] = objInFor[convTeachingCaseResCase_Base.senateGaugeVersionID];
objDR[convTeachingCaseResCase_Base.senateGaugeVersionName] = objInFor[convTeachingCaseResCase_Base.senateGaugeVersionName];
objDR[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] = objInFor[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore];
objDR[convTeachingCaseResCase_Base.VersionNo] = objInFor[convTeachingCaseResCase_Base.VersionNo];
objDR[convTeachingCaseResCase_Base.id_TeachSkill] = objInFor[convTeachingCaseResCase_Base.id_TeachSkill];
objDR[convTeachingCaseResCase_Base.TeachSkillID] = objInFor[convTeachingCaseResCase_Base.TeachSkillID];
objDR[convTeachingCaseResCase_Base.SkillTypeName] = objInFor[convTeachingCaseResCase_Base.SkillTypeName];
objDR[convTeachingCaseResCase_Base.TeachSkillName] = objInFor[convTeachingCaseResCase_Base.TeachSkillName];
objDR[convTeachingCaseResCase_Base.TeachSkillTheory] = objInFor[convTeachingCaseResCase_Base.TeachSkillTheory];
objDR[convTeachingCaseResCase_Base.TeachSkillOperMethod] = objInFor[convTeachingCaseResCase_Base.TeachSkillOperMethod];
objDR[convTeachingCaseResCase_Base.id_SkillType] = objInFor[convTeachingCaseResCase_Base.id_SkillType];
objDR[convTeachingCaseResCase_Base.SkillTypeID] = objInFor[convTeachingCaseResCase_Base.SkillTypeID];
objDR[convTeachingCaseResCase_Base.CaseLevelId] = objInFor[convTeachingCaseResCase_Base.CaseLevelId];
objDR[convTeachingCaseResCase_Base.CaseLevelName] = objInFor[convTeachingCaseResCase_Base.CaseLevelName];
objDR[convTeachingCaseResCase_Base.DocFile] = objInFor[convTeachingCaseResCase_Base.DocFile];
objDR[convTeachingCaseResCase_Base.IsNeedGeneWord] = objInFor[convTeachingCaseResCase_Base.IsNeedGeneWord];
objDR[convTeachingCaseResCase_Base.WordCreateDate] = objInFor[convTeachingCaseResCase_Base.WordCreateDate];
objDR[convTeachingCaseResCase_Base.IsVisible] = objInFor[convTeachingCaseResCase_Base.IsVisible];
objDR[convTeachingCaseResCase_Base.IsDualVideo] = objInFor[convTeachingCaseResCase_Base.IsDualVideo];
objDR[convTeachingCaseResCase_Base.id_XzCollege] = objInFor[convTeachingCaseResCase_Base.id_XzCollege];
objDR[convTeachingCaseResCase_Base.CollegeID] = objInFor[convTeachingCaseResCase_Base.CollegeID];
objDR[convTeachingCaseResCase_Base.CollegeName] = objInFor[convTeachingCaseResCase_Base.CollegeName];
objDR[convTeachingCaseResCase_Base.CollegeNameA] = objInFor[convTeachingCaseResCase_Base.CollegeNameA];
objDR[convTeachingCaseResCase_Base.id_XzMajor] = objInFor[convTeachingCaseResCase_Base.id_XzMajor];
objDR[convTeachingCaseResCase_Base.MajorID] = objInFor[convTeachingCaseResCase_Base.MajorID];
objDR[convTeachingCaseResCase_Base.MajorName] = objInFor[convTeachingCaseResCase_Base.MajorName];
objDR[convTeachingCaseResCase_Base.CourseChapterId] = objInFor[convTeachingCaseResCase_Base.CourseChapterId];
objDR[convTeachingCaseResCase_Base.CourseChapterName] = objInFor[convTeachingCaseResCase_Base.CourseChapterName];
objDR[convTeachingCaseResCase_Base.ParentNodeID] = objInFor[convTeachingCaseResCase_Base.ParentNodeID];
objDR[convTeachingCaseResCase_Base.ParentNodeName] = objInFor[convTeachingCaseResCase_Base.ParentNodeName];
objDR[convTeachingCaseResCase_Base.CourseChapterReferred] = objInFor[convTeachingCaseResCase_Base.CourseChapterReferred];
objDR[convTeachingCaseResCase_Base.ParentNodeReferred] = objInFor[convTeachingCaseResCase_Base.ParentNodeReferred];
objDR[convTeachingCaseResCase_Base.ViewCount] = objInFor[convTeachingCaseResCase_Base.ViewCount];
objDR[convTeachingCaseResCase_Base.IsShow] = objInFor[convTeachingCaseResCase_Base.IsShow];
objDR[convTeachingCaseResCase_Base.DownloadNumber] = objInFor[convTeachingCaseResCase_Base.DownloadNumber];
objDR[convTeachingCaseResCase_Base.FileIntegration] = objInFor[convTeachingCaseResCase_Base.FileIntegration];
objDR[convTeachingCaseResCase_Base.LikeCount] = objInFor[convTeachingCaseResCase_Base.LikeCount];
objDR[convTeachingCaseResCase_Base.CollectionCount] = objInFor[convTeachingCaseResCase_Base.CollectionCount];
objDR[convTeachingCaseResCase_Base.RecommendedDegreeId] = objInFor[convTeachingCaseResCase_Base.RecommendedDegreeId];
objDR[convTeachingCaseResCase_Base.RecommendedDegreeName] = objInFor[convTeachingCaseResCase_Base.RecommendedDegreeName];
objDR[convTeachingCaseResCase_Base.ftpFileType] = objInFor[convTeachingCaseResCase_Base.ftpFileType];
objDR[convTeachingCaseResCase_Base.VideoUrl] = objInFor[convTeachingCaseResCase_Base.VideoUrl];
objDR[convTeachingCaseResCase_Base.VideoPath] = objInFor[convTeachingCaseResCase_Base.VideoPath];
objDR[convTeachingCaseResCase_Base.ResErrMsg] = objInFor[convTeachingCaseResCase_Base.ResErrMsg];
objDR[convTeachingCaseResCase_Base.Memo] = objInFor[convTeachingCaseResCase_Base.Memo];
objDR[convTeachingCaseResCase_Base.OwnerName] = objInFor[convTeachingCaseResCase_Base.OwnerName];
objDR[convTeachingCaseResCase_Base.OwnerNameWithId] = objInFor[convTeachingCaseResCase_Base.OwnerNameWithId];
objDR[convTeachingCaseResCase_Base.BrowseCount4Case] = objInFor[convTeachingCaseResCase_Base.BrowseCount4Case];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}