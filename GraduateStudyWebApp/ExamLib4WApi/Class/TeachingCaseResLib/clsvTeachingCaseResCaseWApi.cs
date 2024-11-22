
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseWApi
 表名:vTeachingCaseResCase(01120378)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:34
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
public static class clsvTeachingCaseResCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetId_TeachingCaseResCase(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strId_TeachingCaseResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_TeachingCaseResCase, 8, convTeachingCaseResCase.Id_TeachingCaseResCase);
clsCheckSql.CheckFieldForeignKey(strId_TeachingCaseResCase, 8, convTeachingCaseResCase.Id_TeachingCaseResCase);
objvTeachingCaseResCaseEN.Id_TeachingCaseResCase = strId_TeachingCaseResCase; //教学案例资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.Id_TeachingCaseResCase) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.Id_TeachingCaseResCase, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.Id_TeachingCaseResCase] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseID, convTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseID, 8, convTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseID, 8, convTeachingCaseResCase.TeachingCaseResCaseID);
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = strTeachingCaseResCaseID; //教学案例资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachingCaseResCaseID) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachingCaseResCaseID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseName, convTeachingCaseResCase.TeachingCaseResCaseName);
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, convTeachingCaseResCase.TeachingCaseResCaseName);
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = strTeachingCaseResCaseName; //教学案例资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachingCaseResCaseName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachingCaseResCaseName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseTheme(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTheme, 200, convTeachingCaseResCase.TeachingCaseResCaseTheme);
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = strTeachingCaseResCaseTheme; //教学案例资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachingCaseResCaseTheme) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachingCaseResCaseTheme, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTheme] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseText(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseText, 8000, convTeachingCaseResCase.TeachingCaseResCaseText);
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = strTeachingCaseResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachingCaseResCaseText) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachingCaseResCaseText, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseText] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseDate(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase.TeachingCaseResCaseDate);
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = strTeachingCaseResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachingCaseResCaseDate) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachingCaseResCaseDate, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseDate] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseTime(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase.TeachingCaseResCaseTime);
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = strTeachingCaseResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachingCaseResCaseTime) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachingCaseResCaseTime, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTime] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseDateIn(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase.TeachingCaseResCaseDateIn);
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = strTeachingCaseResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachingCaseResCaseDateIn) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachingCaseResCaseDateIn, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseDateIn] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseTimeIn(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase.TeachingCaseResCaseTimeIn);
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = strTeachingCaseResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachingCaseResCaseTimeIn) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachingCaseResCaseTimeIn, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN Setid_TeachingCaseResCaseType(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strid_TeachingCaseResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingCaseResCaseType, convTeachingCaseResCase.id_TeachingCaseResCaseType);
clsCheckSql.CheckFieldLen(strid_TeachingCaseResCaseType, 4, convTeachingCaseResCase.id_TeachingCaseResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_TeachingCaseResCaseType, 4, convTeachingCaseResCase.id_TeachingCaseResCaseType);
objvTeachingCaseResCaseEN.id_TeachingCaseResCaseType = strid_TeachingCaseResCaseType; //教学案例资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.id_TeachingCaseResCaseType) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.id_TeachingCaseResCaseType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.id_TeachingCaseResCaseType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseTypeName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTypeName, 30, convTeachingCaseResCase.TeachingCaseResCaseTypeName);
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = strTeachingCaseResCaseTypeName; //教学案例资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachingCaseResCaseTypeName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachingCaseResCaseTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingCaseResCase.CourseId);
objvTeachingCaseResCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CourseId) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CourseId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CourseId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseCode(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingCaseResCase.CourseCode);
objvTeachingCaseResCaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CourseCode) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CourseCode, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CourseCode] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convTeachingCaseResCase.CourseName);
objvTeachingCaseResCaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CourseName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CourseName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CourseName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetOwnerId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convTeachingCaseResCase.OwnerId);
objvTeachingCaseResCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.OwnerId) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.OwnerId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.OwnerId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN Setid_StudyLevel(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convTeachingCaseResCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convTeachingCaseResCase.id_StudyLevel);
objvTeachingCaseResCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.id_StudyLevel) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.id_StudyLevel, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.id_StudyLevel] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetStudyLevelName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convTeachingCaseResCase.StudyLevelName);
objvTeachingCaseResCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.StudyLevelName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.StudyLevelName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.StudyLevelName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN Setid_TeachingPlan(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convTeachingCaseResCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convTeachingCaseResCase.id_TeachingPlan);
objvTeachingCaseResCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.id_TeachingPlan) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN Setid_Discipline(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convTeachingCaseResCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convTeachingCaseResCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convTeachingCaseResCase.id_Discipline);
objvTeachingCaseResCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.id_Discipline) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.id_Discipline, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.id_Discipline] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetDisciplineID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convTeachingCaseResCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convTeachingCaseResCase.DisciplineID);
objvTeachingCaseResCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.DisciplineID) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.DisciplineID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.DisciplineID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetDisciplineName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convTeachingCaseResCase.DisciplineName);
objvTeachingCaseResCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.DisciplineName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.DisciplineName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.DisciplineName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN Setid_SenateGaugeVersion(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convTeachingCaseResCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convTeachingCaseResCase.id_SenateGaugeVersion);
objvTeachingCaseResCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.id_SenateGaugeVersion) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetsenateGaugeVersionID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convTeachingCaseResCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convTeachingCaseResCase.senateGaugeVersionID);
objvTeachingCaseResCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.senateGaugeVersionID) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetsenateGaugeVersionName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convTeachingCaseResCase.senateGaugeVersionName);
objvTeachingCaseResCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.senateGaugeVersionName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetsenateGaugeVersionTtlScore(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.senateGaugeVersionTtlScore) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetVersionNo(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, int intVersionNo, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.VersionNo) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.VersionNo, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.VersionNo] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN Setid_TeachSkill(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convTeachingCaseResCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convTeachingCaseResCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convTeachingCaseResCase.id_TeachSkill);
objvTeachingCaseResCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.id_TeachSkill) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.id_TeachSkill, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.id_TeachSkill] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachSkillID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachingCaseResCase.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachingCaseResCase.TeachSkillID);
objvTeachingCaseResCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachSkillID) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachSkillID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetSkillTypeName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachingCaseResCase.SkillTypeName);
objvTeachingCaseResCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.SkillTypeName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.SkillTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.SkillTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachSkillName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachingCaseResCase.TeachSkillName);
objvTeachingCaseResCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachSkillName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachSkillName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachSkillTheory(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachingCaseResCase.TeachSkillTheory);
objvTeachingCaseResCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachSkillTheory) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachSkillOperMethod(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachingCaseResCase.TeachSkillOperMethod);
objvTeachingCaseResCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.TeachSkillOperMethod) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN Setid_SkillType(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convTeachingCaseResCase.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convTeachingCaseResCase.id_SkillType);
objvTeachingCaseResCaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.id_SkillType) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.id_SkillType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.id_SkillType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetSkillTypeID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachingCaseResCase.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachingCaseResCase.SkillTypeID);
objvTeachingCaseResCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.SkillTypeID) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.SkillTypeID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.SkillTypeID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCaseLevelId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convTeachingCaseResCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convTeachingCaseResCase.CaseLevelId);
objvTeachingCaseResCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CaseLevelId) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CaseLevelId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CaseLevelId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCaseLevelName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convTeachingCaseResCase.CaseLevelName);
objvTeachingCaseResCaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CaseLevelName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CaseLevelName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CaseLevelName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetDocFile(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convTeachingCaseResCase.DocFile);
objvTeachingCaseResCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.DocFile) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.DocFile, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.DocFile] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIsNeedGeneWord(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IsNeedGeneWord) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetWordCreateDate(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convTeachingCaseResCase.WordCreateDate);
objvTeachingCaseResCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.WordCreateDate) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.WordCreateDate, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.WordCreateDate] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIsVisible(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IsVisible) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IsVisible, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IsVisible] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIsDualVideo(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IsDualVideo) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IsDualVideo, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IsDualVideo] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN Setid_XzCollege(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convTeachingCaseResCase.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convTeachingCaseResCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convTeachingCaseResCase.id_XzCollege);
objvTeachingCaseResCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.id_XzCollege) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.id_XzCollege, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.id_XzCollege] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCollegeID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachingCaseResCase.CollegeID);
objvTeachingCaseResCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CollegeID) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CollegeID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CollegeID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCollegeName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingCaseResCase.CollegeName);
objvTeachingCaseResCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CollegeName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CollegeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CollegeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCollegeNameA(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachingCaseResCase.CollegeNameA);
objvTeachingCaseResCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CollegeNameA) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CollegeNameA, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CollegeNameA] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN Setid_XzMajor(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convTeachingCaseResCase.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convTeachingCaseResCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convTeachingCaseResCase.id_XzMajor);
objvTeachingCaseResCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.id_XzMajor) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.id_XzMajor, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.id_XzMajor] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetMajorID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convTeachingCaseResCase.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convTeachingCaseResCase.MajorID);
objvTeachingCaseResCaseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.MajorID) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.MajorID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.MajorID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetMajorName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convTeachingCaseResCase.MajorName);
objvTeachingCaseResCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.MajorName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.MajorName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.MajorName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseChapterId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convTeachingCaseResCase.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convTeachingCaseResCase.CourseChapterId);
objvTeachingCaseResCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CourseChapterId) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CourseChapterId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CourseChapterId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseChapterName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convTeachingCaseResCase.CourseChapterName);
objvTeachingCaseResCaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CourseChapterName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CourseChapterName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CourseChapterName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetParentNodeID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convTeachingCaseResCase.ParentNodeID);
objvTeachingCaseResCaseEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.ParentNodeID) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.ParentNodeID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.ParentNodeID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetParentNodeName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convTeachingCaseResCase.ParentNodeName);
objvTeachingCaseResCaseEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.ParentNodeName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.ParentNodeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.ParentNodeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseChapterReferred(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convTeachingCaseResCase.CourseChapterReferred);
objvTeachingCaseResCaseEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CourseChapterReferred) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CourseChapterReferred, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CourseChapterReferred] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetParentNodeReferred(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convTeachingCaseResCase.ParentNodeReferred);
objvTeachingCaseResCaseEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.ParentNodeReferred) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.ParentNodeReferred, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.ParentNodeReferred] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetViewCount(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, int intViewCount, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.ViewCount) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.ViewCount, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.ViewCount] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIsShow(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IsShow) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IsShow, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IsShow] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetDownloadNumber(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.DownloadNumber) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.DownloadNumber, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.DownloadNumber] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetFileIntegration(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, int intFileIntegration, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.FileIntegration) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.FileIntegration, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.FileIntegration] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetLikeCount(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, long lngLikeCount, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.LikeCount) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.LikeCount, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.LikeCount] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCollectionCount(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.CollectionCount) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.CollectionCount, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.CollectionCount] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetRecommendedDegreeId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convTeachingCaseResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convTeachingCaseResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convTeachingCaseResCase.RecommendedDegreeId);
objvTeachingCaseResCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.RecommendedDegreeId) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetRecommendedDegreeName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convTeachingCaseResCase.RecommendedDegreeName);
objvTeachingCaseResCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.RecommendedDegreeName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetftpFileType(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachingCaseResCase.ftpFileType);
objvTeachingCaseResCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.ftpFileType) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.ftpFileType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.ftpFileType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetVideoUrl(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convTeachingCaseResCase.VideoUrl);
objvTeachingCaseResCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.VideoUrl) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.VideoUrl, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.VideoUrl] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetVideoPath(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convTeachingCaseResCase.VideoPath);
objvTeachingCaseResCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.VideoPath) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.VideoPath, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.VideoPath] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetResErrMsg(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convTeachingCaseResCase.ResErrMsg);
objvTeachingCaseResCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.ResErrMsg) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.ResErrMsg, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.ResErrMsg] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetUpdDate(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTeachingCaseResCase.UpdDate);
objvTeachingCaseResCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.UpdDate) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.UpdDate, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.UpdDate] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetUpdUserId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convTeachingCaseResCase.UpdUserId);
objvTeachingCaseResCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.UpdUserId) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.UpdUserId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.UpdUserId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetMemo(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingCaseResCase.Memo);
objvTeachingCaseResCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.Memo) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.Memo, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.Memo] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetOwnerNameWithId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convTeachingCaseResCase.OwnerNameWithId);
objvTeachingCaseResCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.OwnerNameWithId) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetOwnerName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convTeachingCaseResCase.OwnerName);
objvTeachingCaseResCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.OwnerName) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.OwnerName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.OwnerName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetBrowseCount4Case(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvTeachingCaseResCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.BrowseCount4Case) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIsHaveVideo(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convTeachingCaseResCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convTeachingCaseResCase.IsHaveVideo);
objvTeachingCaseResCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IsHaveVideo) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IsHaveVideo, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IsHaveVideo] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingCaseResCaseEN objvTeachingCaseResCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.Id_TeachingCaseResCase) == true)
{
string strComparisonOp_Id_TeachingCaseResCase = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.Id_TeachingCaseResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.Id_TeachingCaseResCase, objvTeachingCaseResCase_Cond.Id_TeachingCaseResCase, strComparisonOp_Id_TeachingCaseResCase);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseID) == true)
{
string strComparisonOp_TeachingCaseResCaseID = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseID, objvTeachingCaseResCase_Cond.TeachingCaseResCaseID, strComparisonOp_TeachingCaseResCaseID);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseName) == true)
{
string strComparisonOp_TeachingCaseResCaseName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseName, objvTeachingCaseResCase_Cond.TeachingCaseResCaseName, strComparisonOp_TeachingCaseResCaseName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseTheme) == true)
{
string strComparisonOp_TeachingCaseResCaseTheme = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseTheme, objvTeachingCaseResCase_Cond.TeachingCaseResCaseTheme, strComparisonOp_TeachingCaseResCaseTheme);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseText) == true)
{
string strComparisonOp_TeachingCaseResCaseText = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseText, objvTeachingCaseResCase_Cond.TeachingCaseResCaseText, strComparisonOp_TeachingCaseResCaseText);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseDate) == true)
{
string strComparisonOp_TeachingCaseResCaseDate = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseDate, objvTeachingCaseResCase_Cond.TeachingCaseResCaseDate, strComparisonOp_TeachingCaseResCaseDate);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseTime) == true)
{
string strComparisonOp_TeachingCaseResCaseTime = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseTime, objvTeachingCaseResCase_Cond.TeachingCaseResCaseTime, strComparisonOp_TeachingCaseResCaseTime);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseDateIn) == true)
{
string strComparisonOp_TeachingCaseResCaseDateIn = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseDateIn, objvTeachingCaseResCase_Cond.TeachingCaseResCaseDateIn, strComparisonOp_TeachingCaseResCaseDateIn);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseTimeIn) == true)
{
string strComparisonOp_TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseTimeIn, objvTeachingCaseResCase_Cond.TeachingCaseResCaseTimeIn, strComparisonOp_TeachingCaseResCaseTimeIn);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.id_TeachingCaseResCaseType) == true)
{
string strComparisonOp_id_TeachingCaseResCaseType = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.id_TeachingCaseResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.id_TeachingCaseResCaseType, objvTeachingCaseResCase_Cond.id_TeachingCaseResCaseType, strComparisonOp_id_TeachingCaseResCaseType);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseTypeName) == true)
{
string strComparisonOp_TeachingCaseResCaseTypeName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseTypeName, objvTeachingCaseResCase_Cond.TeachingCaseResCaseTypeName, strComparisonOp_TeachingCaseResCaseTypeName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CourseId) == true)
{
string strComparisonOp_CourseId = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseId, objvTeachingCaseResCase_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseCode, objvTeachingCaseResCase_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CourseName) == true)
{
string strComparisonOp_CourseName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseName, objvTeachingCaseResCase_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.OwnerId, objvTeachingCaseResCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.id_StudyLevel, objvTeachingCaseResCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.StudyLevelName, objvTeachingCaseResCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.id_TeachingPlan, objvTeachingCaseResCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.id_Discipline, objvTeachingCaseResCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.DisciplineID, objvTeachingCaseResCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.DisciplineName, objvTeachingCaseResCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.id_SenateGaugeVersion, objvTeachingCaseResCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.senateGaugeVersionID, objvTeachingCaseResCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.senateGaugeVersionName, objvTeachingCaseResCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.senateGaugeVersionTtlScore, objvTeachingCaseResCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.VersionNo, objvTeachingCaseResCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.id_TeachSkill, objvTeachingCaseResCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachSkillID, objvTeachingCaseResCase_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.SkillTypeName, objvTeachingCaseResCase_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachSkillName, objvTeachingCaseResCase_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachSkillTheory, objvTeachingCaseResCase_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachSkillOperMethod, objvTeachingCaseResCase_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.id_SkillType, objvTeachingCaseResCase_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.SkillTypeID, objvTeachingCaseResCase_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CaseLevelId, objvTeachingCaseResCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CaseLevelName, objvTeachingCaseResCase_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.DocFile, objvTeachingCaseResCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.IsNeedGeneWord) == true)
{
if (objvTeachingCaseResCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase.IsNeedGeneWord);
}
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.WordCreateDate, objvTeachingCaseResCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.IsVisible) == true)
{
if (objvTeachingCaseResCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase.IsVisible);
}
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.IsDualVideo) == true)
{
if (objvTeachingCaseResCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase.IsDualVideo);
}
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.id_XzCollege, objvTeachingCaseResCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CollegeID, objvTeachingCaseResCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CollegeName, objvTeachingCaseResCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CollegeNameA, objvTeachingCaseResCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.id_XzMajor, objvTeachingCaseResCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.MajorID) == true)
{
string strComparisonOp_MajorID = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.MajorID, objvTeachingCaseResCase_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.MajorName) == true)
{
string strComparisonOp_MajorName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.MajorName, objvTeachingCaseResCase_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseChapterId, objvTeachingCaseResCase_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseChapterName, objvTeachingCaseResCase_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.ParentNodeID, objvTeachingCaseResCase_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.ParentNodeName, objvTeachingCaseResCase_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseChapterReferred, objvTeachingCaseResCase_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.ParentNodeReferred, objvTeachingCaseResCase_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.ViewCount, objvTeachingCaseResCase_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.IsShow) == true)
{
if (objvTeachingCaseResCase_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase.IsShow);
}
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.DownloadNumber, objvTeachingCaseResCase_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.FileIntegration, objvTeachingCaseResCase_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.LikeCount, objvTeachingCaseResCase_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.CollectionCount, objvTeachingCaseResCase_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.RecommendedDegreeId, objvTeachingCaseResCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.RecommendedDegreeName, objvTeachingCaseResCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.ftpFileType, objvTeachingCaseResCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.VideoUrl, objvTeachingCaseResCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.VideoPath, objvTeachingCaseResCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.ResErrMsg, objvTeachingCaseResCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.UpdDate, objvTeachingCaseResCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.UpdUserId, objvTeachingCaseResCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.Memo) == true)
{
string strComparisonOp_Memo = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.Memo, objvTeachingCaseResCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.OwnerNameWithId, objvTeachingCaseResCase_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.OwnerName, objvTeachingCaseResCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.BrowseCount4Case, objvTeachingCaseResCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvTeachingCaseResCase_Cond.IsUpdated(convTeachingCaseResCase.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvTeachingCaseResCase_Cond.dicFldComparisonOp[convTeachingCaseResCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IsHaveVideo, objvTeachingCaseResCase_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学案例资源案例(vTeachingCaseResCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingCaseResCaseWApi
{
private static readonly string mstrApiControllerName = "vTeachingCaseResCaseApi";

 public clsvTeachingCaseResCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_TeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCaseEN GetObjById_TeachingCaseResCase(string strId_TeachingCaseResCase)
{
string strAction = "GetObjById_TeachingCaseResCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = null;
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
objvTeachingCaseResCaseEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCaseEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCaseEN;
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
public static clsvTeachingCaseResCaseEN GetObjById_TeachingCaseResCase_WA_Cache(string strId_TeachingCaseResCase)
{
string strAction = "GetObjById_TeachingCaseResCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = null;
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
objvTeachingCaseResCaseEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCaseEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCaseEN;
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
public static clsvTeachingCaseResCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = null;
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
objvTeachingCaseResCaseEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCaseEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCaseEN;
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
public static clsvTeachingCaseResCaseEN GetObjById_TeachingCaseResCase_Cache(string strId_TeachingCaseResCase)
{
if (string.IsNullOrEmpty(strId_TeachingCaseResCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCaseEN._CurrTabName_S);
List<clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLst_Sel =
from objvTeachingCaseResCaseEN in arrvTeachingCaseResCaseObjLst_Cache
where objvTeachingCaseResCaseEN.Id_TeachingCaseResCase == strId_TeachingCaseResCase
select objvTeachingCaseResCaseEN;
if (arrvTeachingCaseResCaseObjLst_Sel.Count() == 0)
{
   clsvTeachingCaseResCaseEN obj = clsvTeachingCaseResCaseWApi.GetObjById_TeachingCaseResCase(strId_TeachingCaseResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachingCaseResCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseEN> GetObjLstById_TeachingCaseResCaseLst(List<string> arrId_TeachingCaseResCase)
{
 List<clsvTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvTeachingCaseResCaseEN> GetObjLstById_TeachingCaseResCaseLst_Cache(List<string> arrId_TeachingCaseResCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCaseEN._CurrTabName_S);
List<clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLst_Sel =
from objvTeachingCaseResCaseEN in arrvTeachingCaseResCaseObjLst_Cache
where arrId_TeachingCaseResCase.Contains(objvTeachingCaseResCaseEN.Id_TeachingCaseResCase)
select objvTeachingCaseResCaseEN;
return arrvTeachingCaseResCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLstById_TeachingCaseResCaseLst_WA_Cache(List<string> arrId_TeachingCaseResCase)
{
 List<clsvTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvTeachingCaseResCaseENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseENT">目标对象</param>
 public static void CopyTo(clsvTeachingCaseResCaseEN objvTeachingCaseResCaseENS, clsvTeachingCaseResCaseEN objvTeachingCaseResCaseENT)
{
try
{
objvTeachingCaseResCaseENT.Id_TeachingCaseResCase = objvTeachingCaseResCaseENS.Id_TeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseENT.TeachingCaseResCaseID = objvTeachingCaseResCaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCaseENT.TeachingCaseResCaseName = objvTeachingCaseResCaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseENT.TeachingCaseResCaseTheme = objvTeachingCaseResCaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCaseENT.TeachingCaseResCaseText = objvTeachingCaseResCaseENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCaseENT.TeachingCaseResCaseDate = objvTeachingCaseResCaseENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCaseENT.TeachingCaseResCaseTime = objvTeachingCaseResCaseENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCaseENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCaseENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCaseENT.id_TeachingCaseResCaseType = objvTeachingCaseResCaseENS.id_TeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCaseENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCaseENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCaseENT.CourseId = objvTeachingCaseResCaseENS.CourseId; //课程Id
objvTeachingCaseResCaseENT.CourseCode = objvTeachingCaseResCaseENS.CourseCode; //课程代码
objvTeachingCaseResCaseENT.CourseName = objvTeachingCaseResCaseENS.CourseName; //课程名称
objvTeachingCaseResCaseENT.OwnerId = objvTeachingCaseResCaseENS.OwnerId; //拥有者Id
objvTeachingCaseResCaseENT.id_StudyLevel = objvTeachingCaseResCaseENS.id_StudyLevel; //id_StudyLevel
objvTeachingCaseResCaseENT.StudyLevelName = objvTeachingCaseResCaseENS.StudyLevelName; //学段名称
objvTeachingCaseResCaseENT.id_TeachingPlan = objvTeachingCaseResCaseENS.id_TeachingPlan; //教案流水号
objvTeachingCaseResCaseENT.id_Discipline = objvTeachingCaseResCaseENS.id_Discipline; //学科流水号
objvTeachingCaseResCaseENT.DisciplineID = objvTeachingCaseResCaseENS.DisciplineID; //学科ID
objvTeachingCaseResCaseENT.DisciplineName = objvTeachingCaseResCaseENS.DisciplineName; //学科名称
objvTeachingCaseResCaseENT.id_SenateGaugeVersion = objvTeachingCaseResCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCaseENT.senateGaugeVersionID = objvTeachingCaseResCaseENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCaseENT.senateGaugeVersionName = objvTeachingCaseResCaseENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCaseENT.senateGaugeVersionTtlScore = objvTeachingCaseResCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCaseENT.VersionNo = objvTeachingCaseResCaseENS.VersionNo; //版本号
objvTeachingCaseResCaseENT.id_TeachSkill = objvTeachingCaseResCaseENS.id_TeachSkill; //教学技能流水号
objvTeachingCaseResCaseENT.TeachSkillID = objvTeachingCaseResCaseENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCaseENT.SkillTypeName = objvTeachingCaseResCaseENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCaseENT.TeachSkillName = objvTeachingCaseResCaseENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCaseENT.TeachSkillTheory = objvTeachingCaseResCaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCaseENT.TeachSkillOperMethod = objvTeachingCaseResCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCaseENT.id_SkillType = objvTeachingCaseResCaseENS.id_SkillType; //技能类型流水号
objvTeachingCaseResCaseENT.SkillTypeID = objvTeachingCaseResCaseENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCaseENT.CaseLevelId = objvTeachingCaseResCaseENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCaseENT.CaseLevelName = objvTeachingCaseResCaseENS.CaseLevelName; //案例等级名称
objvTeachingCaseResCaseENT.DocFile = objvTeachingCaseResCaseENS.DocFile; //生成的Word文件名
objvTeachingCaseResCaseENT.IsNeedGeneWord = objvTeachingCaseResCaseENS.IsNeedGeneWord; //是否需要生成Word
objvTeachingCaseResCaseENT.WordCreateDate = objvTeachingCaseResCaseENS.WordCreateDate; //Word生成日期
objvTeachingCaseResCaseENT.IsVisible = objvTeachingCaseResCaseENS.IsVisible; //是否显示
objvTeachingCaseResCaseENT.IsDualVideo = objvTeachingCaseResCaseENS.IsDualVideo; //是否双视频
objvTeachingCaseResCaseENT.id_XzCollege = objvTeachingCaseResCaseENS.id_XzCollege; //学院流水号
objvTeachingCaseResCaseENT.CollegeID = objvTeachingCaseResCaseENS.CollegeID; //学院ID
objvTeachingCaseResCaseENT.CollegeName = objvTeachingCaseResCaseENS.CollegeName; //学院名称
objvTeachingCaseResCaseENT.CollegeNameA = objvTeachingCaseResCaseENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseENT.id_XzMajor = objvTeachingCaseResCaseENS.id_XzMajor; //专业流水号
objvTeachingCaseResCaseENT.MajorID = objvTeachingCaseResCaseENS.MajorID; //专业ID
objvTeachingCaseResCaseENT.MajorName = objvTeachingCaseResCaseENS.MajorName; //专业名称
objvTeachingCaseResCaseENT.CourseChapterId = objvTeachingCaseResCaseENS.CourseChapterId; //课程章节ID
objvTeachingCaseResCaseENT.CourseChapterName = objvTeachingCaseResCaseENS.CourseChapterName; //课程章节名称
objvTeachingCaseResCaseENT.ParentNodeID = objvTeachingCaseResCaseENS.ParentNodeID; //父节点编号
objvTeachingCaseResCaseENT.ParentNodeName = objvTeachingCaseResCaseENS.ParentNodeName; //父节点名称
objvTeachingCaseResCaseENT.CourseChapterReferred = objvTeachingCaseResCaseENS.CourseChapterReferred; //节简称
objvTeachingCaseResCaseENT.ParentNodeReferred = objvTeachingCaseResCaseENS.ParentNodeReferred; //章简称
objvTeachingCaseResCaseENT.ViewCount = objvTeachingCaseResCaseENS.ViewCount; //浏览量
objvTeachingCaseResCaseENT.IsShow = objvTeachingCaseResCaseENS.IsShow; //是否启用
objvTeachingCaseResCaseENT.DownloadNumber = objvTeachingCaseResCaseENS.DownloadNumber; //下载数目
objvTeachingCaseResCaseENT.FileIntegration = objvTeachingCaseResCaseENS.FileIntegration; //文件积分
objvTeachingCaseResCaseENT.LikeCount = objvTeachingCaseResCaseENS.LikeCount; //资源喜欢数量
objvTeachingCaseResCaseENT.CollectionCount = objvTeachingCaseResCaseENS.CollectionCount; //收藏数量
objvTeachingCaseResCaseENT.RecommendedDegreeId = objvTeachingCaseResCaseENS.RecommendedDegreeId; //推荐度Id
objvTeachingCaseResCaseENT.RecommendedDegreeName = objvTeachingCaseResCaseENS.RecommendedDegreeName; //推荐度名称
objvTeachingCaseResCaseENT.ftpFileType = objvTeachingCaseResCaseENS.ftpFileType; //ftp文件类型
objvTeachingCaseResCaseENT.VideoUrl = objvTeachingCaseResCaseENS.VideoUrl; //视频Url
objvTeachingCaseResCaseENT.VideoPath = objvTeachingCaseResCaseENS.VideoPath; //视频目录
objvTeachingCaseResCaseENT.ResErrMsg = objvTeachingCaseResCaseENS.ResErrMsg; //资源错误信息
objvTeachingCaseResCaseENT.UpdDate = objvTeachingCaseResCaseENS.UpdDate; //修改日期
objvTeachingCaseResCaseENT.UpdUserId = objvTeachingCaseResCaseENS.UpdUserId; //修改用户Id
objvTeachingCaseResCaseENT.Memo = objvTeachingCaseResCaseENS.Memo; //备注
objvTeachingCaseResCaseENT.OwnerNameWithId = objvTeachingCaseResCaseENS.OwnerNameWithId; //拥有者名称附Id
objvTeachingCaseResCaseENT.OwnerName = objvTeachingCaseResCaseENS.OwnerName; //拥有者姓名
objvTeachingCaseResCaseENT.BrowseCount4Case = objvTeachingCaseResCaseENS.BrowseCount4Case; //课例浏览次数
objvTeachingCaseResCaseENT.IsHaveVideo = objvTeachingCaseResCaseENS.IsHaveVideo; //IsHaveVideo
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
public static DataTable ToDataTable(List<clsvTeachingCaseResCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachingCaseResCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachingCaseResCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachingCaseResCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachingCaseResCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachingCaseResCaseEN.AttributeName)
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
//if (arrvTeachingCaseResCaseObjLst_Cache == null)
//{
//arrvTeachingCaseResCaseObjLst_Cache = await clsvTeachingCaseResCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachingCaseResCaseEN._CurrTabName_S);
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
public static List<clsvTeachingCaseResCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingCaseResCaseEN._CurrTabName_S);
List<clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingCaseResCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachingCaseResCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachingCaseResCase.Id_TeachingCaseResCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachingCaseResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachingCaseResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachingCaseResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachingCaseResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachingCaseResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachingCaseResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachingCaseResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachingCaseResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.id_TeachingCaseResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachingCaseResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convTeachingCaseResCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCase.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCase.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCase.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCase.IsHaveVideo, Type.GetType("System.String"));
foreach (clsvTeachingCaseResCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachingCaseResCase.Id_TeachingCaseResCase] = objInFor[convTeachingCaseResCase.Id_TeachingCaseResCase];
objDR[convTeachingCaseResCase.TeachingCaseResCaseID] = objInFor[convTeachingCaseResCase.TeachingCaseResCaseID];
objDR[convTeachingCaseResCase.TeachingCaseResCaseName] = objInFor[convTeachingCaseResCase.TeachingCaseResCaseName];
objDR[convTeachingCaseResCase.TeachingCaseResCaseTheme] = objInFor[convTeachingCaseResCase.TeachingCaseResCaseTheme];
objDR[convTeachingCaseResCase.TeachingCaseResCaseText] = objInFor[convTeachingCaseResCase.TeachingCaseResCaseText];
objDR[convTeachingCaseResCase.TeachingCaseResCaseDate] = objInFor[convTeachingCaseResCase.TeachingCaseResCaseDate];
objDR[convTeachingCaseResCase.TeachingCaseResCaseTime] = objInFor[convTeachingCaseResCase.TeachingCaseResCaseTime];
objDR[convTeachingCaseResCase.TeachingCaseResCaseDateIn] = objInFor[convTeachingCaseResCase.TeachingCaseResCaseDateIn];
objDR[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] = objInFor[convTeachingCaseResCase.TeachingCaseResCaseTimeIn];
objDR[convTeachingCaseResCase.id_TeachingCaseResCaseType] = objInFor[convTeachingCaseResCase.id_TeachingCaseResCaseType];
objDR[convTeachingCaseResCase.TeachingCaseResCaseTypeName] = objInFor[convTeachingCaseResCase.TeachingCaseResCaseTypeName];
objDR[convTeachingCaseResCase.CourseId] = objInFor[convTeachingCaseResCase.CourseId];
objDR[convTeachingCaseResCase.CourseCode] = objInFor[convTeachingCaseResCase.CourseCode];
objDR[convTeachingCaseResCase.CourseName] = objInFor[convTeachingCaseResCase.CourseName];
objDR[convTeachingCaseResCase.OwnerId] = objInFor[convTeachingCaseResCase.OwnerId];
objDR[convTeachingCaseResCase.id_StudyLevel] = objInFor[convTeachingCaseResCase.id_StudyLevel];
objDR[convTeachingCaseResCase.StudyLevelName] = objInFor[convTeachingCaseResCase.StudyLevelName];
objDR[convTeachingCaseResCase.id_TeachingPlan] = objInFor[convTeachingCaseResCase.id_TeachingPlan];
objDR[convTeachingCaseResCase.id_Discipline] = objInFor[convTeachingCaseResCase.id_Discipline];
objDR[convTeachingCaseResCase.DisciplineID] = objInFor[convTeachingCaseResCase.DisciplineID];
objDR[convTeachingCaseResCase.DisciplineName] = objInFor[convTeachingCaseResCase.DisciplineName];
objDR[convTeachingCaseResCase.id_SenateGaugeVersion] = objInFor[convTeachingCaseResCase.id_SenateGaugeVersion];
objDR[convTeachingCaseResCase.senateGaugeVersionID] = objInFor[convTeachingCaseResCase.senateGaugeVersionID];
objDR[convTeachingCaseResCase.senateGaugeVersionName] = objInFor[convTeachingCaseResCase.senateGaugeVersionName];
objDR[convTeachingCaseResCase.senateGaugeVersionTtlScore] = objInFor[convTeachingCaseResCase.senateGaugeVersionTtlScore];
objDR[convTeachingCaseResCase.VersionNo] = objInFor[convTeachingCaseResCase.VersionNo];
objDR[convTeachingCaseResCase.id_TeachSkill] = objInFor[convTeachingCaseResCase.id_TeachSkill];
objDR[convTeachingCaseResCase.TeachSkillID] = objInFor[convTeachingCaseResCase.TeachSkillID];
objDR[convTeachingCaseResCase.SkillTypeName] = objInFor[convTeachingCaseResCase.SkillTypeName];
objDR[convTeachingCaseResCase.TeachSkillName] = objInFor[convTeachingCaseResCase.TeachSkillName];
objDR[convTeachingCaseResCase.TeachSkillTheory] = objInFor[convTeachingCaseResCase.TeachSkillTheory];
objDR[convTeachingCaseResCase.TeachSkillOperMethod] = objInFor[convTeachingCaseResCase.TeachSkillOperMethod];
objDR[convTeachingCaseResCase.id_SkillType] = objInFor[convTeachingCaseResCase.id_SkillType];
objDR[convTeachingCaseResCase.SkillTypeID] = objInFor[convTeachingCaseResCase.SkillTypeID];
objDR[convTeachingCaseResCase.CaseLevelId] = objInFor[convTeachingCaseResCase.CaseLevelId];
objDR[convTeachingCaseResCase.CaseLevelName] = objInFor[convTeachingCaseResCase.CaseLevelName];
objDR[convTeachingCaseResCase.DocFile] = objInFor[convTeachingCaseResCase.DocFile];
objDR[convTeachingCaseResCase.IsNeedGeneWord] = objInFor[convTeachingCaseResCase.IsNeedGeneWord];
objDR[convTeachingCaseResCase.WordCreateDate] = objInFor[convTeachingCaseResCase.WordCreateDate];
objDR[convTeachingCaseResCase.IsVisible] = objInFor[convTeachingCaseResCase.IsVisible];
objDR[convTeachingCaseResCase.IsDualVideo] = objInFor[convTeachingCaseResCase.IsDualVideo];
objDR[convTeachingCaseResCase.id_XzCollege] = objInFor[convTeachingCaseResCase.id_XzCollege];
objDR[convTeachingCaseResCase.CollegeID] = objInFor[convTeachingCaseResCase.CollegeID];
objDR[convTeachingCaseResCase.CollegeName] = objInFor[convTeachingCaseResCase.CollegeName];
objDR[convTeachingCaseResCase.CollegeNameA] = objInFor[convTeachingCaseResCase.CollegeNameA];
objDR[convTeachingCaseResCase.id_XzMajor] = objInFor[convTeachingCaseResCase.id_XzMajor];
objDR[convTeachingCaseResCase.MajorID] = objInFor[convTeachingCaseResCase.MajorID];
objDR[convTeachingCaseResCase.MajorName] = objInFor[convTeachingCaseResCase.MajorName];
objDR[convTeachingCaseResCase.CourseChapterId] = objInFor[convTeachingCaseResCase.CourseChapterId];
objDR[convTeachingCaseResCase.CourseChapterName] = objInFor[convTeachingCaseResCase.CourseChapterName];
objDR[convTeachingCaseResCase.ParentNodeID] = objInFor[convTeachingCaseResCase.ParentNodeID];
objDR[convTeachingCaseResCase.ParentNodeName] = objInFor[convTeachingCaseResCase.ParentNodeName];
objDR[convTeachingCaseResCase.CourseChapterReferred] = objInFor[convTeachingCaseResCase.CourseChapterReferred];
objDR[convTeachingCaseResCase.ParentNodeReferred] = objInFor[convTeachingCaseResCase.ParentNodeReferred];
objDR[convTeachingCaseResCase.ViewCount] = objInFor[convTeachingCaseResCase.ViewCount];
objDR[convTeachingCaseResCase.IsShow] = objInFor[convTeachingCaseResCase.IsShow];
objDR[convTeachingCaseResCase.DownloadNumber] = objInFor[convTeachingCaseResCase.DownloadNumber];
objDR[convTeachingCaseResCase.FileIntegration] = objInFor[convTeachingCaseResCase.FileIntegration];
objDR[convTeachingCaseResCase.LikeCount] = objInFor[convTeachingCaseResCase.LikeCount];
objDR[convTeachingCaseResCase.CollectionCount] = objInFor[convTeachingCaseResCase.CollectionCount];
objDR[convTeachingCaseResCase.RecommendedDegreeId] = objInFor[convTeachingCaseResCase.RecommendedDegreeId];
objDR[convTeachingCaseResCase.RecommendedDegreeName] = objInFor[convTeachingCaseResCase.RecommendedDegreeName];
objDR[convTeachingCaseResCase.ftpFileType] = objInFor[convTeachingCaseResCase.ftpFileType];
objDR[convTeachingCaseResCase.VideoUrl] = objInFor[convTeachingCaseResCase.VideoUrl];
objDR[convTeachingCaseResCase.VideoPath] = objInFor[convTeachingCaseResCase.VideoPath];
objDR[convTeachingCaseResCase.ResErrMsg] = objInFor[convTeachingCaseResCase.ResErrMsg];
objDR[convTeachingCaseResCase.UpdDate] = objInFor[convTeachingCaseResCase.UpdDate];
objDR[convTeachingCaseResCase.UpdUserId] = objInFor[convTeachingCaseResCase.UpdUserId];
objDR[convTeachingCaseResCase.Memo] = objInFor[convTeachingCaseResCase.Memo];
objDR[convTeachingCaseResCase.OwnerNameWithId] = objInFor[convTeachingCaseResCase.OwnerNameWithId];
objDR[convTeachingCaseResCase.OwnerName] = objInFor[convTeachingCaseResCase.OwnerName];
objDR[convTeachingCaseResCase.BrowseCount4Case] = objInFor[convTeachingCaseResCase.BrowseCount4Case];
objDR[convTeachingCaseResCase.IsHaveVideo] = objInFor[convTeachingCaseResCase.IsHaveVideo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}