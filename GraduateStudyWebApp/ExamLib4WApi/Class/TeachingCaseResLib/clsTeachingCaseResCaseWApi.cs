
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingCaseResCaseWApi
 表名:TeachingCaseResCase(01120377)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:30
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
public static class clsTeachingCaseResCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetId_TeachingCaseResCase(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strId_TeachingCaseResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_TeachingCaseResCase, 8, conTeachingCaseResCase.Id_TeachingCaseResCase);
clsCheckSql.CheckFieldForeignKey(strId_TeachingCaseResCase, 8, conTeachingCaseResCase.Id_TeachingCaseResCase);
objTeachingCaseResCaseEN.Id_TeachingCaseResCase = strId_TeachingCaseResCase; //教学案例资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.Id_TeachingCaseResCase) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.Id_TeachingCaseResCase, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.Id_TeachingCaseResCase] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseID(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseID, conTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseID, 8, conTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseID, 8, conTeachingCaseResCase.TeachingCaseResCaseID);
objTeachingCaseResCaseEN.TeachingCaseResCaseID = strTeachingCaseResCaseID; //教学案例资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseID) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseID, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseID] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseName(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseName, conTeachingCaseResCase.TeachingCaseResCaseName);
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, conTeachingCaseResCase.TeachingCaseResCaseName);
objTeachingCaseResCaseEN.TeachingCaseResCaseName = strTeachingCaseResCaseName; //教学案例资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseName) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseName, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseName] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseTheme(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTheme, 200, conTeachingCaseResCase.TeachingCaseResCaseTheme);
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = strTeachingCaseResCaseTheme; //教学案例资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseTheme) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseTheme, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTheme] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseText(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseText, 8000, conTeachingCaseResCase.TeachingCaseResCaseText);
objTeachingCaseResCaseEN.TeachingCaseResCaseText = strTeachingCaseResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseText) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseText, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseText] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseDate(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDate, 8, conTeachingCaseResCase.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDate, 8, conTeachingCaseResCase.TeachingCaseResCaseDate);
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = strTeachingCaseResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseDate) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseDate, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseDate] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseTime(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTime, 6, conTeachingCaseResCase.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTime, 6, conTeachingCaseResCase.TeachingCaseResCaseTime);
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = strTeachingCaseResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseTime) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseTime, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTime] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseDateIn(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDateIn, 8, conTeachingCaseResCase.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDateIn, 8, conTeachingCaseResCase.TeachingCaseResCaseDateIn);
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = strTeachingCaseResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseDateIn) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseDateIn, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseDateIn] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseTimeIn(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTimeIn, 6, conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTimeIn, 6, conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = strTeachingCaseResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseTimeIn) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseTimeIn, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetId_CaseType(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_CaseType, conTeachingCaseResCase.Id_CaseType);
clsCheckSql.CheckFieldLen(strId_CaseType, 4, conTeachingCaseResCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, conTeachingCaseResCase.Id_CaseType);
objTeachingCaseResCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.Id_CaseType) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.Id_CaseType, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.Id_CaseType] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN Setid_TeachingCaseResCaseType(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strid_TeachingCaseResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingCaseResCaseType, conTeachingCaseResCase.id_TeachingCaseResCaseType);
clsCheckSql.CheckFieldLen(strid_TeachingCaseResCaseType, 4, conTeachingCaseResCase.id_TeachingCaseResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_TeachingCaseResCaseType, 4, conTeachingCaseResCase.id_TeachingCaseResCaseType);
objTeachingCaseResCaseEN.id_TeachingCaseResCaseType = strid_TeachingCaseResCaseType; //教学案例资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.id_TeachingCaseResCaseType) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.id_TeachingCaseResCaseType, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.id_TeachingCaseResCaseType] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetCourseId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conTeachingCaseResCase.CourseId);
objTeachingCaseResCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.CourseId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.CourseId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.CourseId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetOwnerId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conTeachingCaseResCase.OwnerId);
objTeachingCaseResCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.OwnerId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.OwnerId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.OwnerId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN Setid_StudyLevel(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conTeachingCaseResCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conTeachingCaseResCase.id_StudyLevel);
objTeachingCaseResCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.id_StudyLevel) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.id_StudyLevel, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.id_StudyLevel] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN Setid_TeachingPlan(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conTeachingCaseResCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conTeachingCaseResCase.id_TeachingPlan);
objTeachingCaseResCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.id_TeachingPlan) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.id_TeachingPlan, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.id_TeachingPlan] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN Setid_Discipline(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conTeachingCaseResCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conTeachingCaseResCase.id_Discipline);
objTeachingCaseResCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.id_Discipline) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.id_Discipline, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.id_Discipline] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetBrowseCount(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.BrowseCount) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.BrowseCount, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.BrowseCount] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN Setid_SenateGaugeVersion(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conTeachingCaseResCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conTeachingCaseResCase.id_SenateGaugeVersion);
objTeachingCaseResCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.id_SenateGaugeVersion) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN Setid_TeachSkill(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conTeachingCaseResCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conTeachingCaseResCase.id_TeachSkill);
objTeachingCaseResCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.id_TeachSkill) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.id_TeachSkill, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.id_TeachSkill] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetCaseLevelId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conTeachingCaseResCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conTeachingCaseResCase.CaseLevelId);
objTeachingCaseResCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.CaseLevelId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.CaseLevelId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.CaseLevelId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetDocFile(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conTeachingCaseResCase.DocFile);
objTeachingCaseResCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.DocFile) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.DocFile, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.DocFile] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIsNeedGeneWord(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IsNeedGeneWord) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetWordCreateDate(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conTeachingCaseResCase.WordCreateDate);
objTeachingCaseResCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.WordCreateDate) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.WordCreateDate, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.WordCreateDate] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIsVisible(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IsVisible) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IsVisible, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IsVisible] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIsDualVideo(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IsDualVideo) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IsDualVideo, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IsDualVideo] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN Setid_XzCollege(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, conTeachingCaseResCase.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conTeachingCaseResCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conTeachingCaseResCase.id_XzCollege);
objTeachingCaseResCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.id_XzCollege) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.id_XzCollege, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.id_XzCollege] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN Setid_XzMajor(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conTeachingCaseResCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conTeachingCaseResCase.id_XzMajor);
objTeachingCaseResCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.id_XzMajor) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.id_XzMajor, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.id_XzMajor] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetCourseChapterId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conTeachingCaseResCase.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conTeachingCaseResCase.CourseChapterId);
objTeachingCaseResCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.CourseChapterId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.CourseChapterId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.CourseChapterId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetViewCount(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, int intViewCount, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.ViewCount) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.ViewCount, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.ViewCount] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIsShow(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IsShow) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IsShow, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IsShow] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetDownloadNumber(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.DownloadNumber) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.DownloadNumber, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.DownloadNumber] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetFileIntegration(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, int intFileIntegration, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.FileIntegration) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.FileIntegration, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.FileIntegration] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetLikeCount(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, long lngLikeCount, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.LikeCount) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.LikeCount, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.LikeCount] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetCollectionCount(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.CollectionCount) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.CollectionCount, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.CollectionCount] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetRecommendedDegreeId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conTeachingCaseResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conTeachingCaseResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conTeachingCaseResCase.RecommendedDegreeId);
objTeachingCaseResCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.RecommendedDegreeId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetftpFileType(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conTeachingCaseResCase.ftpFileType);
objTeachingCaseResCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.ftpFileType) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.ftpFileType, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.ftpFileType] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetVideoUrl(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conTeachingCaseResCase.VideoUrl);
objTeachingCaseResCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.VideoUrl) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.VideoUrl, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.VideoUrl] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetVideoPath(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conTeachingCaseResCase.VideoPath);
objTeachingCaseResCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.VideoPath) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.VideoPath, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.VideoPath] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetResErrMsg(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conTeachingCaseResCase.ResErrMsg);
objTeachingCaseResCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.ResErrMsg) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.ResErrMsg, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.ResErrMsg] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetUpdDate(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTeachingCaseResCase.UpdDate);
objTeachingCaseResCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.UpdDate) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.UpdDate, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.UpdDate] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetUpdUserId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conTeachingCaseResCase.UpdUserId);
objTeachingCaseResCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.UpdUserId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.UpdUserId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.UpdUserId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetMemo(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeachingCaseResCase.Memo);
objTeachingCaseResCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.Memo) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.Memo, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.Memo] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeachingCaseResCaseEN objTeachingCaseResCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.Id_TeachingCaseResCase) == true)
{
string strComparisonOp_Id_TeachingCaseResCase = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.Id_TeachingCaseResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.Id_TeachingCaseResCase, objTeachingCaseResCase_Cond.Id_TeachingCaseResCase, strComparisonOp_Id_TeachingCaseResCase);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseID) == true)
{
string strComparisonOp_TeachingCaseResCaseID = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseID, objTeachingCaseResCase_Cond.TeachingCaseResCaseID, strComparisonOp_TeachingCaseResCaseID);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseName) == true)
{
string strComparisonOp_TeachingCaseResCaseName = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseName, objTeachingCaseResCase_Cond.TeachingCaseResCaseName, strComparisonOp_TeachingCaseResCaseName);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTheme) == true)
{
string strComparisonOp_TeachingCaseResCaseTheme = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseTheme, objTeachingCaseResCase_Cond.TeachingCaseResCaseTheme, strComparisonOp_TeachingCaseResCaseTheme);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseText) == true)
{
string strComparisonOp_TeachingCaseResCaseText = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseText, objTeachingCaseResCase_Cond.TeachingCaseResCaseText, strComparisonOp_TeachingCaseResCaseText);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDate) == true)
{
string strComparisonOp_TeachingCaseResCaseDate = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseDate, objTeachingCaseResCase_Cond.TeachingCaseResCaseDate, strComparisonOp_TeachingCaseResCaseDate);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTime) == true)
{
string strComparisonOp_TeachingCaseResCaseTime = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseTime, objTeachingCaseResCase_Cond.TeachingCaseResCaseTime, strComparisonOp_TeachingCaseResCaseTime);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDateIn) == true)
{
string strComparisonOp_TeachingCaseResCaseDateIn = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseDateIn, objTeachingCaseResCase_Cond.TeachingCaseResCaseDateIn, strComparisonOp_TeachingCaseResCaseDateIn);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTimeIn) == true)
{
string strComparisonOp_TeachingCaseResCaseTimeIn = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseTimeIn, objTeachingCaseResCase_Cond.TeachingCaseResCaseTimeIn, strComparisonOp_TeachingCaseResCaseTimeIn);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.Id_CaseType, objTeachingCaseResCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.id_TeachingCaseResCaseType) == true)
{
string strComparisonOp_id_TeachingCaseResCaseType = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.id_TeachingCaseResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.id_TeachingCaseResCaseType, objTeachingCaseResCase_Cond.id_TeachingCaseResCaseType, strComparisonOp_id_TeachingCaseResCaseType);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.CourseId) == true)
{
string strComparisonOp_CourseId = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.CourseId, objTeachingCaseResCase_Cond.CourseId, strComparisonOp_CourseId);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.OwnerId, objTeachingCaseResCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.id_StudyLevel, objTeachingCaseResCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.id_TeachingPlan, objTeachingCaseResCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.id_Discipline, objTeachingCaseResCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.BrowseCount, objTeachingCaseResCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.id_SenateGaugeVersion, objTeachingCaseResCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.id_TeachSkill, objTeachingCaseResCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.CaseLevelId, objTeachingCaseResCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.DocFile) == true)
{
string strComparisonOp_DocFile = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.DocFile, objTeachingCaseResCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.IsNeedGeneWord) == true)
{
if (objTeachingCaseResCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachingCaseResCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachingCaseResCase.IsNeedGeneWord);
}
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.WordCreateDate, objTeachingCaseResCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.IsVisible) == true)
{
if (objTeachingCaseResCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachingCaseResCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachingCaseResCase.IsVisible);
}
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.IsDualVideo) == true)
{
if (objTeachingCaseResCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachingCaseResCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachingCaseResCase.IsDualVideo);
}
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.id_XzCollege, objTeachingCaseResCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.id_XzMajor, objTeachingCaseResCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.CourseChapterId, objTeachingCaseResCase_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.ViewCount) == true)
{
string strComparisonOp_ViewCount = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.ViewCount, objTeachingCaseResCase_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.IsShow) == true)
{
if (objTeachingCaseResCase_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachingCaseResCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachingCaseResCase.IsShow);
}
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.DownloadNumber, objTeachingCaseResCase_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.FileIntegration, objTeachingCaseResCase_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.LikeCount) == true)
{
string strComparisonOp_LikeCount = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.LikeCount, objTeachingCaseResCase_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.CollectionCount, objTeachingCaseResCase_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.RecommendedDegreeId, objTeachingCaseResCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.ftpFileType, objTeachingCaseResCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.VideoUrl, objTeachingCaseResCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.VideoPath, objTeachingCaseResCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.ResErrMsg, objTeachingCaseResCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.UpdDate, objTeachingCaseResCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.UpdUserId, objTeachingCaseResCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objTeachingCaseResCase_Cond.IsUpdated(conTeachingCaseResCase.Memo) == true)
{
string strComparisonOp_Memo = objTeachingCaseResCase_Cond.dicFldComparisonOp[conTeachingCaseResCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.Memo, objTeachingCaseResCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.Id_TeachingCaseResCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTeachingCaseResCaseEN.sf_UpdFldSetStr = objTeachingCaseResCaseEN.getsf_UpdFldSetStr();
clsTeachingCaseResCaseWApi.CheckPropertyNew(objTeachingCaseResCaseEN); 
bool bolResult = clsTeachingCaseResCaseWApi.UpdateRecord(objTeachingCaseResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseWApi.ReFreshCache(objTeachingCaseResCaseEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--TeachingCaseResCase(教学案例资源案例), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_TeachingCaseResCaseID(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTeachingCaseResCaseEN == null) return "";
if (objTeachingCaseResCaseEN.Id_TeachingCaseResCase == null || objTeachingCaseResCaseEN.Id_TeachingCaseResCase == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeachingCaseResCaseID = '{0}'", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_TeachingCaseResCase !=  '{0}'", objTeachingCaseResCaseEN.Id_TeachingCaseResCase);
 sbCondition.AppendFormat(" and TeachingCaseResCaseID = '{0}'", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
try
{
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.Id_TeachingCaseResCase) == true || clsTeachingCaseResCaseWApi.IsExist(objTeachingCaseResCaseEN.Id_TeachingCaseResCase) == true)
 {
     objTeachingCaseResCaseEN.Id_TeachingCaseResCase = clsTeachingCaseResCaseWApi.GetMaxStrId();
 }
clsTeachingCaseResCaseWApi.CheckPropertyNew(objTeachingCaseResCaseEN); 
bool bolResult = clsTeachingCaseResCaseWApi.AddNewRecord(objTeachingCaseResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseWApi.ReFreshCache(objTeachingCaseResCaseEN.CourseId);
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
try
{
clsTeachingCaseResCaseWApi.CheckPropertyNew(objTeachingCaseResCaseEN); 
string strId_TeachingCaseResCase = clsTeachingCaseResCaseWApi.AddNewRecordWithMaxId(objTeachingCaseResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseWApi.ReFreshCache(objTeachingCaseResCaseEN.CourseId);
return strId_TeachingCaseResCase;
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
 /// <param name = "objTeachingCaseResCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strWhereCond)
{
try
{
clsTeachingCaseResCaseWApi.CheckPropertyNew(objTeachingCaseResCaseEN); 
bool bolResult = clsTeachingCaseResCaseWApi.UpdateWithCondition(objTeachingCaseResCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseWApi.ReFreshCache(objTeachingCaseResCaseEN.CourseId);
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
 /// 教学案例资源案例(TeachingCaseResCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTeachingCaseResCaseWApi
{
private static readonly string mstrApiControllerName = "TeachingCaseResCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsTeachingCaseResCaseWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
if (!Object.Equals(null, objTeachingCaseResCaseEN.Id_TeachingCaseResCase) && GetStrLen(objTeachingCaseResCaseEN.Id_TeachingCaseResCase) > 8)
{
 throw new Exception("字段[教学案例资源案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.TeachingCaseResCaseID) && GetStrLen(objTeachingCaseResCaseEN.TeachingCaseResCaseID) > 8)
{
 throw new Exception("字段[教学案例资源案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.TeachingCaseResCaseName) && GetStrLen(objTeachingCaseResCaseEN.TeachingCaseResCaseName) > 100)
{
 throw new Exception("字段[教学案例资源案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.TeachingCaseResCaseTheme) && GetStrLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTheme) > 200)
{
 throw new Exception("字段[教学案例资源案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.TeachingCaseResCaseText) && GetStrLen(objTeachingCaseResCaseEN.TeachingCaseResCaseText) > 8000)
{
 throw new Exception("字段[案例文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.TeachingCaseResCaseDate) && GetStrLen(objTeachingCaseResCaseEN.TeachingCaseResCaseDate) > 8)
{
 throw new Exception("字段[视频资源日期]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.TeachingCaseResCaseTime) && GetStrLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTime) > 6)
{
 throw new Exception("字段[视频资源时间]的长度不能超过6!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn) && GetStrLen(objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn) && GetStrLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.Id_CaseType) && GetStrLen(objTeachingCaseResCaseEN.Id_CaseType) > 4)
{
 throw new Exception("字段[案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.id_TeachingCaseResCaseType) && GetStrLen(objTeachingCaseResCaseEN.id_TeachingCaseResCaseType) > 4)
{
 throw new Exception("字段[教学案例资源类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.CourseId) && GetStrLen(objTeachingCaseResCaseEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.OwnerId) && GetStrLen(objTeachingCaseResCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.id_StudyLevel) && GetStrLen(objTeachingCaseResCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.id_TeachingPlan) && GetStrLen(objTeachingCaseResCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.id_Discipline) && GetStrLen(objTeachingCaseResCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.id_SenateGaugeVersion) && GetStrLen(objTeachingCaseResCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.id_TeachSkill) && GetStrLen(objTeachingCaseResCaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.CaseLevelId) && GetStrLen(objTeachingCaseResCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.DocFile) && GetStrLen(objTeachingCaseResCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.WordCreateDate) && GetStrLen(objTeachingCaseResCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.id_XzCollege) && GetStrLen(objTeachingCaseResCaseEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.id_XzMajor) && GetStrLen(objTeachingCaseResCaseEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.CourseChapterId) && GetStrLen(objTeachingCaseResCaseEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.RecommendedDegreeId) && GetStrLen(objTeachingCaseResCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.ftpFileType) && GetStrLen(objTeachingCaseResCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.VideoUrl) && GetStrLen(objTeachingCaseResCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.VideoPath) && GetStrLen(objTeachingCaseResCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.ResErrMsg) && GetStrLen(objTeachingCaseResCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.UpdDate) && GetStrLen(objTeachingCaseResCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.UpdUserId) && GetStrLen(objTeachingCaseResCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingCaseResCaseEN.Memo) && GetStrLen(objTeachingCaseResCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objTeachingCaseResCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_TeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingCaseResCaseEN GetObjById_TeachingCaseResCase(string strId_TeachingCaseResCase)
{
string strAction = "GetObjById_TeachingCaseResCase";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = null;
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
objTeachingCaseResCaseEN = JsonConvert.DeserializeObject<clsTeachingCaseResCaseEN>((string)jobjReturn["ReturnObj"]);
return objTeachingCaseResCaseEN;
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
public static clsTeachingCaseResCaseEN GetObjById_TeachingCaseResCase_WA_Cache(string strId_TeachingCaseResCase, string strCourseId)
{
string strAction = "GetObjById_TeachingCaseResCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_TeachingCaseResCase"] = strId_TeachingCaseResCase,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objTeachingCaseResCaseEN = JsonConvert.DeserializeObject<clsTeachingCaseResCaseEN>((string)jobjReturn["ReturnObj"]);
return objTeachingCaseResCaseEN;
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
public static clsTeachingCaseResCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = null;
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
objTeachingCaseResCaseEN = JsonConvert.DeserializeObject<clsTeachingCaseResCaseEN>((string)jobjReturn["ReturnObj"]);
return objTeachingCaseResCaseEN;
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
public static clsTeachingCaseResCaseEN GetObjById_TeachingCaseResCase_Cache(string strId_TeachingCaseResCase, string strCourseId)
{
if (string.IsNullOrEmpty(strId_TeachingCaseResCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTeachingCaseResCaseEN._CurrTabName_S, strCourseId);
List<clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLst_Sel =
from objTeachingCaseResCaseEN in arrTeachingCaseResCaseObjLst_Cache
where objTeachingCaseResCaseEN.Id_TeachingCaseResCase == strId_TeachingCaseResCase
select objTeachingCaseResCaseEN;
if (arrTeachingCaseResCaseObjLst_Sel.Count() == 0)
{
   clsTeachingCaseResCaseEN obj = clsTeachingCaseResCaseWApi.GetObjById_TeachingCaseResCase(strId_TeachingCaseResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTeachingCaseResCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingCaseResCaseEN> GetObjLst(string strWhereCond)
{
 List<clsTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingCaseResCaseEN> GetObjLstById_TeachingCaseResCaseLst(List<string> arrId_TeachingCaseResCase)
{
 List<clsTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsTeachingCaseResCaseEN> GetObjLstById_TeachingCaseResCaseLst_Cache(List<string> arrId_TeachingCaseResCase, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTeachingCaseResCaseEN._CurrTabName_S, strCourseId);
List<clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLst_Sel =
from objTeachingCaseResCaseEN in arrTeachingCaseResCaseObjLst_Cache
where arrId_TeachingCaseResCase.Contains(objTeachingCaseResCaseEN.Id_TeachingCaseResCase)
select objTeachingCaseResCaseEN;
return arrTeachingCaseResCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingCaseResCaseEN> GetObjLstById_TeachingCaseResCaseLst_WA_Cache(List<string> arrId_TeachingCaseResCase, string strCourseId)
{
 List<clsTeachingCaseResCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachingCaseResCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachingCaseResCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingCaseResCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingCaseResCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingCaseResCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingCaseResCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsTeachingCaseResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingCaseResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strId_TeachingCaseResCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = clsTeachingCaseResCaseWApi.GetObjById_TeachingCaseResCase(strId_TeachingCaseResCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_TeachingCaseResCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeachingCaseResCaseWApi.ReFreshCache(objTeachingCaseResCaseEN.CourseId);
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
public static int DelTeachingCaseResCases(List<string> arrId_TeachingCaseResCase)
{
string strAction = "DelTeachingCaseResCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachingCaseResCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = clsTeachingCaseResCaseWApi.GetObjById_TeachingCaseResCase(arrId_TeachingCaseResCase[0]);
clsTeachingCaseResCaseWApi.ReFreshCache(objTeachingCaseResCaseEN.CourseId);
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
public static int DelTeachingCaseResCasesByCond(string strWhereCond)
{
string strAction = "DelTeachingCaseResCasesByCond";
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
public static bool AddNewRecord(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingCaseResCaseEN>(objTeachingCaseResCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseWApi.ReFreshCache(objTeachingCaseResCaseEN.CourseId);
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
public static string AddNewRecordWithMaxId(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingCaseResCaseEN>(objTeachingCaseResCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseWApi.ReFreshCache(objTeachingCaseResCaseEN.CourseId);
var strId_TeachingCaseResCase = (string)jobjReturn["ReturnStr"];
return strId_TeachingCaseResCase;
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
public static bool UpdateRecord(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingCaseResCaseEN.Id_TeachingCaseResCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingCaseResCaseEN>(objTeachingCaseResCaseEN);
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
 /// <param name = "objTeachingCaseResCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingCaseResCaseEN.Id_TeachingCaseResCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingCaseResCaseEN.Id_TeachingCaseResCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingCaseResCaseEN>(objTeachingCaseResCaseEN);
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
 /// <param name = "objTeachingCaseResCaseENS">源对象</param>
 /// <param name = "objTeachingCaseResCaseENT">目标对象</param>
 public static void CopyTo(clsTeachingCaseResCaseEN objTeachingCaseResCaseENS, clsTeachingCaseResCaseEN objTeachingCaseResCaseENT)
{
try
{
objTeachingCaseResCaseENT.Id_TeachingCaseResCase = objTeachingCaseResCaseENS.Id_TeachingCaseResCase; //教学案例资源案例流水号
objTeachingCaseResCaseENT.TeachingCaseResCaseID = objTeachingCaseResCaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objTeachingCaseResCaseENT.TeachingCaseResCaseName = objTeachingCaseResCaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objTeachingCaseResCaseENT.TeachingCaseResCaseTheme = objTeachingCaseResCaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objTeachingCaseResCaseENT.TeachingCaseResCaseText = objTeachingCaseResCaseENS.TeachingCaseResCaseText; //案例文本内容
objTeachingCaseResCaseENT.TeachingCaseResCaseDate = objTeachingCaseResCaseENS.TeachingCaseResCaseDate; //视频资源日期
objTeachingCaseResCaseENT.TeachingCaseResCaseTime = objTeachingCaseResCaseENS.TeachingCaseResCaseTime; //视频资源时间
objTeachingCaseResCaseENT.TeachingCaseResCaseDateIn = objTeachingCaseResCaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objTeachingCaseResCaseENT.TeachingCaseResCaseTimeIn = objTeachingCaseResCaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objTeachingCaseResCaseENT.Id_CaseType = objTeachingCaseResCaseENS.Id_CaseType; //案例类型流水号
objTeachingCaseResCaseENT.id_TeachingCaseResCaseType = objTeachingCaseResCaseENS.id_TeachingCaseResCaseType; //教学案例资源类型流水号
objTeachingCaseResCaseENT.CourseId = objTeachingCaseResCaseENS.CourseId; //课程Id
objTeachingCaseResCaseENT.OwnerId = objTeachingCaseResCaseENS.OwnerId; //拥有者Id
objTeachingCaseResCaseENT.id_StudyLevel = objTeachingCaseResCaseENS.id_StudyLevel; //id_StudyLevel
objTeachingCaseResCaseENT.id_TeachingPlan = objTeachingCaseResCaseENS.id_TeachingPlan; //教案流水号
objTeachingCaseResCaseENT.id_Discipline = objTeachingCaseResCaseENS.id_Discipline; //学科流水号
objTeachingCaseResCaseENT.BrowseCount = objTeachingCaseResCaseENS.BrowseCount; //浏览次数
objTeachingCaseResCaseENT.id_SenateGaugeVersion = objTeachingCaseResCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objTeachingCaseResCaseENT.id_TeachSkill = objTeachingCaseResCaseENS.id_TeachSkill; //教学技能流水号
objTeachingCaseResCaseENT.CaseLevelId = objTeachingCaseResCaseENS.CaseLevelId; //课例等级Id
objTeachingCaseResCaseENT.DocFile = objTeachingCaseResCaseENS.DocFile; //生成的Word文件名
objTeachingCaseResCaseENT.IsNeedGeneWord = objTeachingCaseResCaseENS.IsNeedGeneWord; //是否需要生成Word
objTeachingCaseResCaseENT.WordCreateDate = objTeachingCaseResCaseENS.WordCreateDate; //Word生成日期
objTeachingCaseResCaseENT.IsVisible = objTeachingCaseResCaseENS.IsVisible; //是否显示
objTeachingCaseResCaseENT.IsDualVideo = objTeachingCaseResCaseENS.IsDualVideo; //是否双视频
objTeachingCaseResCaseENT.id_XzCollege = objTeachingCaseResCaseENS.id_XzCollege; //学院流水号
objTeachingCaseResCaseENT.id_XzMajor = objTeachingCaseResCaseENS.id_XzMajor; //专业流水号
objTeachingCaseResCaseENT.CourseChapterId = objTeachingCaseResCaseENS.CourseChapterId; //课程章节ID
objTeachingCaseResCaseENT.ViewCount = objTeachingCaseResCaseENS.ViewCount; //浏览量
objTeachingCaseResCaseENT.IsShow = objTeachingCaseResCaseENS.IsShow; //是否启用
objTeachingCaseResCaseENT.DownloadNumber = objTeachingCaseResCaseENS.DownloadNumber; //下载数目
objTeachingCaseResCaseENT.FileIntegration = objTeachingCaseResCaseENS.FileIntegration; //文件积分
objTeachingCaseResCaseENT.LikeCount = objTeachingCaseResCaseENS.LikeCount; //资源喜欢数量
objTeachingCaseResCaseENT.CollectionCount = objTeachingCaseResCaseENS.CollectionCount; //收藏数量
objTeachingCaseResCaseENT.RecommendedDegreeId = objTeachingCaseResCaseENS.RecommendedDegreeId; //推荐度Id
objTeachingCaseResCaseENT.ftpFileType = objTeachingCaseResCaseENS.ftpFileType; //ftp文件类型
objTeachingCaseResCaseENT.VideoUrl = objTeachingCaseResCaseENS.VideoUrl; //视频Url
objTeachingCaseResCaseENT.VideoPath = objTeachingCaseResCaseENS.VideoPath; //视频目录
objTeachingCaseResCaseENT.ResErrMsg = objTeachingCaseResCaseENS.ResErrMsg; //资源错误信息
objTeachingCaseResCaseENT.UpdDate = objTeachingCaseResCaseENS.UpdDate; //修改日期
objTeachingCaseResCaseENT.UpdUserId = objTeachingCaseResCaseENS.UpdUserId; //修改用户Id
objTeachingCaseResCaseENT.Memo = objTeachingCaseResCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsTeachingCaseResCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTeachingCaseResCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTeachingCaseResCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTeachingCaseResCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTeachingCaseResCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTeachingCaseResCaseEN.AttributeName)
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
if (clsTeachingCaseResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseWApi没有刷新缓存机制(clsTeachingCaseResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_TeachingCaseResCase");
//if (arrTeachingCaseResCaseObjLst_Cache == null)
//{
//arrTeachingCaseResCaseObjLst_Cache = await clsTeachingCaseResCaseWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsTeachingCaseResCaseEN._CurrTabName_S, strCourseId);
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
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsTeachingCaseResCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsTeachingCaseResCaseEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clsTeachingCaseResCaseWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachingCaseResCaseEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsTeachingCaseResCaseEN._CurrTabName_S, strCourseId);
List<clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrTeachingCaseResCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTeachingCaseResCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTeachingCaseResCase.Id_TeachingCaseResCase, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.TeachingCaseResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.TeachingCaseResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.TeachingCaseResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.TeachingCaseResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.TeachingCaseResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.TeachingCaseResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.TeachingCaseResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.TeachingCaseResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.id_TeachingCaseResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conTeachingCaseResCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeachingCaseResCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeachingCaseResCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeachingCaseResCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conTeachingCaseResCase.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeachingCaseResCase.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(conTeachingCaseResCase.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(conTeachingCaseResCase.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conTeachingCaseResCase.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conTeachingCaseResCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingCaseResCase.Memo, Type.GetType("System.String"));
foreach (clsTeachingCaseResCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTeachingCaseResCase.Id_TeachingCaseResCase] = objInFor[conTeachingCaseResCase.Id_TeachingCaseResCase];
objDR[conTeachingCaseResCase.TeachingCaseResCaseID] = objInFor[conTeachingCaseResCase.TeachingCaseResCaseID];
objDR[conTeachingCaseResCase.TeachingCaseResCaseName] = objInFor[conTeachingCaseResCase.TeachingCaseResCaseName];
objDR[conTeachingCaseResCase.TeachingCaseResCaseTheme] = objInFor[conTeachingCaseResCase.TeachingCaseResCaseTheme];
objDR[conTeachingCaseResCase.TeachingCaseResCaseText] = objInFor[conTeachingCaseResCase.TeachingCaseResCaseText];
objDR[conTeachingCaseResCase.TeachingCaseResCaseDate] = objInFor[conTeachingCaseResCase.TeachingCaseResCaseDate];
objDR[conTeachingCaseResCase.TeachingCaseResCaseTime] = objInFor[conTeachingCaseResCase.TeachingCaseResCaseTime];
objDR[conTeachingCaseResCase.TeachingCaseResCaseDateIn] = objInFor[conTeachingCaseResCase.TeachingCaseResCaseDateIn];
objDR[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] = objInFor[conTeachingCaseResCase.TeachingCaseResCaseTimeIn];
objDR[conTeachingCaseResCase.Id_CaseType] = objInFor[conTeachingCaseResCase.Id_CaseType];
objDR[conTeachingCaseResCase.id_TeachingCaseResCaseType] = objInFor[conTeachingCaseResCase.id_TeachingCaseResCaseType];
objDR[conTeachingCaseResCase.CourseId] = objInFor[conTeachingCaseResCase.CourseId];
objDR[conTeachingCaseResCase.OwnerId] = objInFor[conTeachingCaseResCase.OwnerId];
objDR[conTeachingCaseResCase.id_StudyLevel] = objInFor[conTeachingCaseResCase.id_StudyLevel];
objDR[conTeachingCaseResCase.id_TeachingPlan] = objInFor[conTeachingCaseResCase.id_TeachingPlan];
objDR[conTeachingCaseResCase.id_Discipline] = objInFor[conTeachingCaseResCase.id_Discipline];
objDR[conTeachingCaseResCase.BrowseCount] = objInFor[conTeachingCaseResCase.BrowseCount];
objDR[conTeachingCaseResCase.id_SenateGaugeVersion] = objInFor[conTeachingCaseResCase.id_SenateGaugeVersion];
objDR[conTeachingCaseResCase.id_TeachSkill] = objInFor[conTeachingCaseResCase.id_TeachSkill];
objDR[conTeachingCaseResCase.CaseLevelId] = objInFor[conTeachingCaseResCase.CaseLevelId];
objDR[conTeachingCaseResCase.DocFile] = objInFor[conTeachingCaseResCase.DocFile];
objDR[conTeachingCaseResCase.IsNeedGeneWord] = objInFor[conTeachingCaseResCase.IsNeedGeneWord];
objDR[conTeachingCaseResCase.WordCreateDate] = objInFor[conTeachingCaseResCase.WordCreateDate];
objDR[conTeachingCaseResCase.IsVisible] = objInFor[conTeachingCaseResCase.IsVisible];
objDR[conTeachingCaseResCase.IsDualVideo] = objInFor[conTeachingCaseResCase.IsDualVideo];
objDR[conTeachingCaseResCase.id_XzCollege] = objInFor[conTeachingCaseResCase.id_XzCollege];
objDR[conTeachingCaseResCase.id_XzMajor] = objInFor[conTeachingCaseResCase.id_XzMajor];
objDR[conTeachingCaseResCase.CourseChapterId] = objInFor[conTeachingCaseResCase.CourseChapterId];
objDR[conTeachingCaseResCase.ViewCount] = objInFor[conTeachingCaseResCase.ViewCount];
objDR[conTeachingCaseResCase.IsShow] = objInFor[conTeachingCaseResCase.IsShow];
objDR[conTeachingCaseResCase.DownloadNumber] = objInFor[conTeachingCaseResCase.DownloadNumber];
objDR[conTeachingCaseResCase.FileIntegration] = objInFor[conTeachingCaseResCase.FileIntegration];
objDR[conTeachingCaseResCase.LikeCount] = objInFor[conTeachingCaseResCase.LikeCount];
objDR[conTeachingCaseResCase.CollectionCount] = objInFor[conTeachingCaseResCase.CollectionCount];
objDR[conTeachingCaseResCase.RecommendedDegreeId] = objInFor[conTeachingCaseResCase.RecommendedDegreeId];
objDR[conTeachingCaseResCase.ftpFileType] = objInFor[conTeachingCaseResCase.ftpFileType];
objDR[conTeachingCaseResCase.VideoUrl] = objInFor[conTeachingCaseResCase.VideoUrl];
objDR[conTeachingCaseResCase.VideoPath] = objInFor[conTeachingCaseResCase.VideoPath];
objDR[conTeachingCaseResCase.ResErrMsg] = objInFor[conTeachingCaseResCase.ResErrMsg];
objDR[conTeachingCaseResCase.UpdDate] = objInFor[conTeachingCaseResCase.UpdDate];
objDR[conTeachingCaseResCase.UpdUserId] = objInFor[conTeachingCaseResCase.UpdUserId];
objDR[conTeachingCaseResCase.Memo] = objInFor[conTeachingCaseResCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 教学案例资源案例(TeachingCaseResCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4TeachingCaseResCase : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsTeachingCaseResCaseWApi.ReFreshThisCache(strCourseId);
}
}

}