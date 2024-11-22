
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseBL
 表名:vTeachingCaseResCase(01120378)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源(TeachingCaseResLib)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvTeachingCaseResCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCaseEN GetObj(this K_IdTeachingCaseResCase_vTeachingCaseResCase myKey)
{
clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = clsvTeachingCaseResCaseBL.vTeachingCaseResCaseDA.GetObjByIdTeachingCaseResCase(myKey.Value);
return objvTeachingCaseResCaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIdTeachingCaseResCase(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIdTeachingCaseResCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingCaseResCase, 8, convTeachingCaseResCase.IdTeachingCaseResCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingCaseResCase, 8, convTeachingCaseResCase.IdTeachingCaseResCase);
}
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = strIdTeachingCaseResCase; //教学案例资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IdTeachingCaseResCase) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IdTeachingCaseResCase, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IdTeachingCaseResCase] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseID, convTeachingCaseResCase.TeachingCaseResCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseID, 8, convTeachingCaseResCase.TeachingCaseResCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseID, 8, convTeachingCaseResCase.TeachingCaseResCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseName, convTeachingCaseResCase.TeachingCaseResCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, convTeachingCaseResCase.TeachingCaseResCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseTheme(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTheme, 200, convTeachingCaseResCase.TeachingCaseResCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseText(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseText, 8000, convTeachingCaseResCase.TeachingCaseResCaseText);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseDate(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase.TeachingCaseResCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase.TeachingCaseResCaseDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseTime(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase.TeachingCaseResCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase.TeachingCaseResCaseTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseDateIn(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase.TeachingCaseResCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase.TeachingCaseResCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseTimeIn(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase.TeachingCaseResCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase.TeachingCaseResCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIdTeachingCaseResCaseType(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIdTeachingCaseResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingCaseResCaseType, convTeachingCaseResCase.IdTeachingCaseResCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingCaseResCaseType, 4, convTeachingCaseResCase.IdTeachingCaseResCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingCaseResCaseType, 4, convTeachingCaseResCase.IdTeachingCaseResCaseType);
}
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = strIdTeachingCaseResCaseType; //教学案例资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IdTeachingCaseResCaseType) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IdTeachingCaseResCaseType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IdTeachingCaseResCaseType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachingCaseResCaseTypeName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachingCaseResCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTypeName, 30, convTeachingCaseResCase.TeachingCaseResCaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convTeachingCaseResCase.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingCaseResCase.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingCaseResCase.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseCode(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingCaseResCase.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convTeachingCaseResCase.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetOwnerId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convTeachingCaseResCase.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIdStudyLevel(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convTeachingCaseResCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convTeachingCaseResCase.IdStudyLevel);
}
objvTeachingCaseResCaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IdStudyLevel) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IdStudyLevel, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IdStudyLevel] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetStudyLevelName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convTeachingCaseResCase.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIdTeachingPlan(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convTeachingCaseResCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convTeachingCaseResCase.IdTeachingPlan);
}
objvTeachingCaseResCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IdTeachingPlan) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IdTeachingPlan, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IdTeachingPlan] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIdDiscipline(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convTeachingCaseResCase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convTeachingCaseResCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convTeachingCaseResCase.IdDiscipline);
}
objvTeachingCaseResCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IdDiscipline) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IdDiscipline, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IdDiscipline] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetDisciplineID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convTeachingCaseResCase.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convTeachingCaseResCase.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetDisciplineName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convTeachingCaseResCase.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIdSenateGaugeVersion(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convTeachingCaseResCase.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convTeachingCaseResCase.IdSenateGaugeVersion);
}
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IdSenateGaugeVersion) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetsenateGaugeVersionID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convTeachingCaseResCase.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convTeachingCaseResCase.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetsenateGaugeVersionName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convTeachingCaseResCase.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetsenateGaugeVersionTtlScore(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetVersionNo(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, int? intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIdTeachSkill(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convTeachingCaseResCase.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convTeachingCaseResCase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convTeachingCaseResCase.IdTeachSkill);
}
objvTeachingCaseResCaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IdTeachSkill) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IdTeachSkill, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IdTeachSkill] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachSkillID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachingCaseResCase.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachingCaseResCase.TeachSkillID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetSkillTypeName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachingCaseResCase.SkillTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachSkillName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachingCaseResCase.TeachSkillName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachSkillTheory(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachingCaseResCase.TeachSkillTheory);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetTeachSkillOperMethod(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachingCaseResCase.TeachSkillOperMethod);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIdSkillType(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convTeachingCaseResCase.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convTeachingCaseResCase.IdSkillType);
}
objvTeachingCaseResCaseEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IdSkillType) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IdSkillType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IdSkillType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetSkillTypeID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachingCaseResCase.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachingCaseResCase.SkillTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCaseLevelId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convTeachingCaseResCase.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convTeachingCaseResCase.CaseLevelId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCaseLevelName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convTeachingCaseResCase.CaseLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetDocFile(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convTeachingCaseResCase.DocFile);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetWordCreateDate(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convTeachingCaseResCase.WordCreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIdXzCollege(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, convTeachingCaseResCase.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convTeachingCaseResCase.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convTeachingCaseResCase.IdXzCollege);
}
objvTeachingCaseResCaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IdXzCollege) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IdXzCollege, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IdXzCollege] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCollegeID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachingCaseResCase.CollegeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCollegeName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingCaseResCase.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCollegeNameA(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachingCaseResCase.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIdXzMajor(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convTeachingCaseResCase.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convTeachingCaseResCase.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convTeachingCaseResCase.IdXzMajor);
}
objvTeachingCaseResCaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase.IdXzMajor) == false)
{
objvTeachingCaseResCaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase.IdXzMajor, strComparisonOp);
}
else
{
objvTeachingCaseResCaseEN.dicFldComparisonOp[convTeachingCaseResCase.IdXzMajor] = strComparisonOp;
}
}
return objvTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetMajorID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convTeachingCaseResCase.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convTeachingCaseResCase.MajorID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetMajorName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convTeachingCaseResCase.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseChapterId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convTeachingCaseResCase.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convTeachingCaseResCase.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseChapterName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convTeachingCaseResCase.CourseChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetParentNodeID(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strParentNodeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convTeachingCaseResCase.ParentNodeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetParentNodeName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convTeachingCaseResCase.ParentNodeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCourseChapterReferred(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convTeachingCaseResCase.CourseChapterReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetParentNodeReferred(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convTeachingCaseResCase.ParentNodeReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetViewCount(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, int? intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetDownloadNumber(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, int? intDownloadNumber, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetFileIntegration(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, int? intFileIntegration, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetLikeCount(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, long? lngLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetCollectionCount(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, long? lngCollectionCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetRecommendedDegreeId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convTeachingCaseResCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convTeachingCaseResCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convTeachingCaseResCase.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetRecommendedDegreeName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convTeachingCaseResCase.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetftpFileType(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachingCaseResCase.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetVideoUrl(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convTeachingCaseResCase.VideoUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetVideoPath(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convTeachingCaseResCase.VideoPath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetResErrMsg(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convTeachingCaseResCase.ResErrMsg);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetUpdDate(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTeachingCaseResCase.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetUpdUserId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convTeachingCaseResCase.UpdUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetMemo(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingCaseResCase.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetOwnerNameWithId(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convTeachingCaseResCase.OwnerNameWithId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetOwnerName(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convTeachingCaseResCase.OwnerName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetBrowseCount4Case(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseEN SetIsHaveVideo(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convTeachingCaseResCase.IsHaveVideo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convTeachingCaseResCase.IsHaveVideo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseENT">目标对象</param>
 public static void CopyTo(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseENS, clsvTeachingCaseResCaseEN objvTeachingCaseResCaseENT)
{
try
{
objvTeachingCaseResCaseENT.IdTeachingCaseResCase = objvTeachingCaseResCaseENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseENT.TeachingCaseResCaseID = objvTeachingCaseResCaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCaseENT.TeachingCaseResCaseName = objvTeachingCaseResCaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseENT.TeachingCaseResCaseTheme = objvTeachingCaseResCaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCaseENT.TeachingCaseResCaseText = objvTeachingCaseResCaseENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCaseENT.TeachingCaseResCaseDate = objvTeachingCaseResCaseENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCaseENT.TeachingCaseResCaseTime = objvTeachingCaseResCaseENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCaseENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCaseENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCaseENT.IdTeachingCaseResCaseType = objvTeachingCaseResCaseENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCaseENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCaseENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCaseENT.CourseId = objvTeachingCaseResCaseENS.CourseId; //课程Id
objvTeachingCaseResCaseENT.CourseCode = objvTeachingCaseResCaseENS.CourseCode; //课程代码
objvTeachingCaseResCaseENT.CourseName = objvTeachingCaseResCaseENS.CourseName; //课程名称
objvTeachingCaseResCaseENT.OwnerId = objvTeachingCaseResCaseENS.OwnerId; //拥有者Id
objvTeachingCaseResCaseENT.IdStudyLevel = objvTeachingCaseResCaseENS.IdStudyLevel; //id_StudyLevel
objvTeachingCaseResCaseENT.StudyLevelName = objvTeachingCaseResCaseENS.StudyLevelName; //学段名称
objvTeachingCaseResCaseENT.IdTeachingPlan = objvTeachingCaseResCaseENS.IdTeachingPlan; //教案流水号
objvTeachingCaseResCaseENT.IdDiscipline = objvTeachingCaseResCaseENS.IdDiscipline; //学科流水号
objvTeachingCaseResCaseENT.DisciplineID = objvTeachingCaseResCaseENS.DisciplineID; //学科ID
objvTeachingCaseResCaseENT.DisciplineName = objvTeachingCaseResCaseENS.DisciplineName; //学科名称
objvTeachingCaseResCaseENT.IdSenateGaugeVersion = objvTeachingCaseResCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCaseENT.senateGaugeVersionID = objvTeachingCaseResCaseENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCaseENT.senateGaugeVersionName = objvTeachingCaseResCaseENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCaseENT.senateGaugeVersionTtlScore = objvTeachingCaseResCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCaseENT.VersionNo = objvTeachingCaseResCaseENS.VersionNo; //版本号
objvTeachingCaseResCaseENT.IdTeachSkill = objvTeachingCaseResCaseENS.IdTeachSkill; //教学技能流水号
objvTeachingCaseResCaseENT.TeachSkillID = objvTeachingCaseResCaseENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCaseENT.SkillTypeName = objvTeachingCaseResCaseENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCaseENT.TeachSkillName = objvTeachingCaseResCaseENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCaseENT.TeachSkillTheory = objvTeachingCaseResCaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCaseENT.TeachSkillOperMethod = objvTeachingCaseResCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCaseENT.IdSkillType = objvTeachingCaseResCaseENS.IdSkillType; //技能类型流水号
objvTeachingCaseResCaseENT.SkillTypeID = objvTeachingCaseResCaseENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCaseENT.CaseLevelId = objvTeachingCaseResCaseENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCaseENT.CaseLevelName = objvTeachingCaseResCaseENS.CaseLevelName; //案例等级名称
objvTeachingCaseResCaseENT.DocFile = objvTeachingCaseResCaseENS.DocFile; //生成的Word文件名
objvTeachingCaseResCaseENT.IsNeedGeneWord = objvTeachingCaseResCaseENS.IsNeedGeneWord; //是否需要生成Word
objvTeachingCaseResCaseENT.WordCreateDate = objvTeachingCaseResCaseENS.WordCreateDate; //Word生成日期
objvTeachingCaseResCaseENT.IsVisible = objvTeachingCaseResCaseENS.IsVisible; //是否显示
objvTeachingCaseResCaseENT.IsDualVideo = objvTeachingCaseResCaseENS.IsDualVideo; //是否双视频
objvTeachingCaseResCaseENT.IdXzCollege = objvTeachingCaseResCaseENS.IdXzCollege; //学院流水号
objvTeachingCaseResCaseENT.CollegeID = objvTeachingCaseResCaseENS.CollegeID; //学院ID
objvTeachingCaseResCaseENT.CollegeName = objvTeachingCaseResCaseENS.CollegeName; //学院名称
objvTeachingCaseResCaseENT.CollegeNameA = objvTeachingCaseResCaseENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseENT.IdXzMajor = objvTeachingCaseResCaseENS.IdXzMajor; //专业流水号
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
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseENS">源对象</param>
 /// <returns>目标对象=>clsvTeachingCaseResCaseEN:objvTeachingCaseResCaseENT</returns>
 public static clsvTeachingCaseResCaseEN CopyTo(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseENS)
{
try
{
 clsvTeachingCaseResCaseEN objvTeachingCaseResCaseENT = new clsvTeachingCaseResCaseEN()
{
IdTeachingCaseResCase = objvTeachingCaseResCaseENS.IdTeachingCaseResCase, //教学案例资源案例流水号
TeachingCaseResCaseID = objvTeachingCaseResCaseENS.TeachingCaseResCaseID, //教学案例资源案例ID
TeachingCaseResCaseName = objvTeachingCaseResCaseENS.TeachingCaseResCaseName, //教学案例资源案例名称
TeachingCaseResCaseTheme = objvTeachingCaseResCaseENS.TeachingCaseResCaseTheme, //教学案例资源案例主题词
TeachingCaseResCaseText = objvTeachingCaseResCaseENS.TeachingCaseResCaseText, //案例文本内容
TeachingCaseResCaseDate = objvTeachingCaseResCaseENS.TeachingCaseResCaseDate, //视频资源日期
TeachingCaseResCaseTime = objvTeachingCaseResCaseENS.TeachingCaseResCaseTime, //视频资源时间
TeachingCaseResCaseDateIn = objvTeachingCaseResCaseENS.TeachingCaseResCaseDateIn, //案例入库日期
TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseENS.TeachingCaseResCaseTimeIn, //案例入库时间
IdTeachingCaseResCaseType = objvTeachingCaseResCaseENS.IdTeachingCaseResCaseType, //教学案例资源类型流水号
TeachingCaseResCaseTypeName = objvTeachingCaseResCaseENS.TeachingCaseResCaseTypeName, //教学案例资源案例类型名称
CourseId = objvTeachingCaseResCaseENS.CourseId, //课程Id
CourseCode = objvTeachingCaseResCaseENS.CourseCode, //课程代码
CourseName = objvTeachingCaseResCaseENS.CourseName, //课程名称
OwnerId = objvTeachingCaseResCaseENS.OwnerId, //拥有者Id
IdStudyLevel = objvTeachingCaseResCaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvTeachingCaseResCaseENS.StudyLevelName, //学段名称
IdTeachingPlan = objvTeachingCaseResCaseENS.IdTeachingPlan, //教案流水号
IdDiscipline = objvTeachingCaseResCaseENS.IdDiscipline, //学科流水号
DisciplineID = objvTeachingCaseResCaseENS.DisciplineID, //学科ID
DisciplineName = objvTeachingCaseResCaseENS.DisciplineName, //学科名称
IdSenateGaugeVersion = objvTeachingCaseResCaseENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvTeachingCaseResCaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvTeachingCaseResCaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvTeachingCaseResCaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvTeachingCaseResCaseENS.VersionNo, //版本号
IdTeachSkill = objvTeachingCaseResCaseENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvTeachingCaseResCaseENS.TeachSkillID, //教学技能ID
SkillTypeName = objvTeachingCaseResCaseENS.SkillTypeName, //技能类型名称
TeachSkillName = objvTeachingCaseResCaseENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvTeachingCaseResCaseENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvTeachingCaseResCaseENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvTeachingCaseResCaseENS.IdSkillType, //技能类型流水号
SkillTypeID = objvTeachingCaseResCaseENS.SkillTypeID, //技能类型ID
CaseLevelId = objvTeachingCaseResCaseENS.CaseLevelId, //课例等级Id
CaseLevelName = objvTeachingCaseResCaseENS.CaseLevelName, //案例等级名称
DocFile = objvTeachingCaseResCaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvTeachingCaseResCaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvTeachingCaseResCaseENS.WordCreateDate, //Word生成日期
IsVisible = objvTeachingCaseResCaseENS.IsVisible, //是否显示
IsDualVideo = objvTeachingCaseResCaseENS.IsDualVideo, //是否双视频
IdXzCollege = objvTeachingCaseResCaseENS.IdXzCollege, //学院流水号
CollegeID = objvTeachingCaseResCaseENS.CollegeID, //学院ID
CollegeName = objvTeachingCaseResCaseENS.CollegeName, //学院名称
CollegeNameA = objvTeachingCaseResCaseENS.CollegeNameA, //学院名称简写
IdXzMajor = objvTeachingCaseResCaseENS.IdXzMajor, //专业流水号
MajorID = objvTeachingCaseResCaseENS.MajorID, //专业ID
MajorName = objvTeachingCaseResCaseENS.MajorName, //专业名称
CourseChapterId = objvTeachingCaseResCaseENS.CourseChapterId, //课程章节ID
CourseChapterName = objvTeachingCaseResCaseENS.CourseChapterName, //课程章节名称
ParentNodeID = objvTeachingCaseResCaseENS.ParentNodeID, //父节点编号
ParentNodeName = objvTeachingCaseResCaseENS.ParentNodeName, //父节点名称
CourseChapterReferred = objvTeachingCaseResCaseENS.CourseChapterReferred, //节简称
ParentNodeReferred = objvTeachingCaseResCaseENS.ParentNodeReferred, //章简称
ViewCount = objvTeachingCaseResCaseENS.ViewCount, //浏览量
IsShow = objvTeachingCaseResCaseENS.IsShow, //是否启用
DownloadNumber = objvTeachingCaseResCaseENS.DownloadNumber, //下载数目
FileIntegration = objvTeachingCaseResCaseENS.FileIntegration, //文件积分
LikeCount = objvTeachingCaseResCaseENS.LikeCount, //资源喜欢数量
CollectionCount = objvTeachingCaseResCaseENS.CollectionCount, //收藏数量
RecommendedDegreeId = objvTeachingCaseResCaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvTeachingCaseResCaseENS.RecommendedDegreeName, //推荐度名称
ftpFileType = objvTeachingCaseResCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objvTeachingCaseResCaseENS.VideoUrl, //视频Url
VideoPath = objvTeachingCaseResCaseENS.VideoPath, //视频目录
ResErrMsg = objvTeachingCaseResCaseENS.ResErrMsg, //资源错误信息
UpdDate = objvTeachingCaseResCaseENS.UpdDate, //修改日期
UpdUserId = objvTeachingCaseResCaseENS.UpdUserId, //修改用户Id
Memo = objvTeachingCaseResCaseENS.Memo, //备注
OwnerNameWithId = objvTeachingCaseResCaseENS.OwnerNameWithId, //拥有者名称附Id
OwnerName = objvTeachingCaseResCaseENS.OwnerName, //拥有者姓名
BrowseCount4Case = objvTeachingCaseResCaseENS.BrowseCount4Case, //课例浏览次数
IsHaveVideo = objvTeachingCaseResCaseENS.IsHaveVideo, //IsHaveVideo
};
 return objvTeachingCaseResCaseENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN)
{
 clsvTeachingCaseResCaseBL.vTeachingCaseResCaseDA.CheckProperty4Condition(objvTeachingCaseResCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingCaseResCaseEN objvTeachingCaseResCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IdTeachingCaseResCase) == true)
{
string strComparisonOpIdTeachingCaseResCase = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IdTeachingCaseResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IdTeachingCaseResCase, objvTeachingCaseResCaseCond.IdTeachingCaseResCase, strComparisonOpIdTeachingCaseResCase);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseID) == true)
{
string strComparisonOpTeachingCaseResCaseID = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseID, objvTeachingCaseResCaseCond.TeachingCaseResCaseID, strComparisonOpTeachingCaseResCaseID);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseName) == true)
{
string strComparisonOpTeachingCaseResCaseName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseName, objvTeachingCaseResCaseCond.TeachingCaseResCaseName, strComparisonOpTeachingCaseResCaseName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseTheme) == true)
{
string strComparisonOpTeachingCaseResCaseTheme = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseTheme, objvTeachingCaseResCaseCond.TeachingCaseResCaseTheme, strComparisonOpTeachingCaseResCaseTheme);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseText) == true)
{
string strComparisonOpTeachingCaseResCaseText = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseText, objvTeachingCaseResCaseCond.TeachingCaseResCaseText, strComparisonOpTeachingCaseResCaseText);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseDate) == true)
{
string strComparisonOpTeachingCaseResCaseDate = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseDate, objvTeachingCaseResCaseCond.TeachingCaseResCaseDate, strComparisonOpTeachingCaseResCaseDate);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseTime) == true)
{
string strComparisonOpTeachingCaseResCaseTime = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseTime, objvTeachingCaseResCaseCond.TeachingCaseResCaseTime, strComparisonOpTeachingCaseResCaseTime);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseDateIn) == true)
{
string strComparisonOpTeachingCaseResCaseDateIn = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseDateIn, objvTeachingCaseResCaseCond.TeachingCaseResCaseDateIn, strComparisonOpTeachingCaseResCaseDateIn);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseTimeIn) == true)
{
string strComparisonOpTeachingCaseResCaseTimeIn = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseTimeIn, objvTeachingCaseResCaseCond.TeachingCaseResCaseTimeIn, strComparisonOpTeachingCaseResCaseTimeIn);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IdTeachingCaseResCaseType) == true)
{
string strComparisonOpIdTeachingCaseResCaseType = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IdTeachingCaseResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IdTeachingCaseResCaseType, objvTeachingCaseResCaseCond.IdTeachingCaseResCaseType, strComparisonOpIdTeachingCaseResCaseType);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachingCaseResCaseTypeName) == true)
{
string strComparisonOpTeachingCaseResCaseTypeName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachingCaseResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachingCaseResCaseTypeName, objvTeachingCaseResCaseCond.TeachingCaseResCaseTypeName, strComparisonOpTeachingCaseResCaseTypeName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CourseId) == true)
{
string strComparisonOpCourseId = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseId, objvTeachingCaseResCaseCond.CourseId, strComparisonOpCourseId);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CourseCode) == true)
{
string strComparisonOpCourseCode = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseCode, objvTeachingCaseResCaseCond.CourseCode, strComparisonOpCourseCode);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CourseName) == true)
{
string strComparisonOpCourseName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseName, objvTeachingCaseResCaseCond.CourseName, strComparisonOpCourseName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.OwnerId) == true)
{
string strComparisonOpOwnerId = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.OwnerId, objvTeachingCaseResCaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IdStudyLevel, objvTeachingCaseResCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.StudyLevelName, objvTeachingCaseResCaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IdTeachingPlan, objvTeachingCaseResCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IdDiscipline, objvTeachingCaseResCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.DisciplineID, objvTeachingCaseResCaseCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.DisciplineName, objvTeachingCaseResCaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IdSenateGaugeVersion, objvTeachingCaseResCaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.senateGaugeVersionID, objvTeachingCaseResCaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.senateGaugeVersionName, objvTeachingCaseResCaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.senateGaugeVersionTtlScore, objvTeachingCaseResCaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.VersionNo) == true)
{
string strComparisonOpVersionNo = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.VersionNo, objvTeachingCaseResCaseCond.VersionNo, strComparisonOpVersionNo);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IdTeachSkill, objvTeachingCaseResCaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachSkillID, objvTeachingCaseResCaseCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.SkillTypeName, objvTeachingCaseResCaseCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachSkillName, objvTeachingCaseResCaseCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachSkillTheory, objvTeachingCaseResCaseCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.TeachSkillOperMethod, objvTeachingCaseResCaseCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IdSkillType, objvTeachingCaseResCaseCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.SkillTypeID, objvTeachingCaseResCaseCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CaseLevelId, objvTeachingCaseResCaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CaseLevelName, objvTeachingCaseResCaseCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.DocFile) == true)
{
string strComparisonOpDocFile = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.DocFile, objvTeachingCaseResCaseCond.DocFile, strComparisonOpDocFile);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IsNeedGeneWord) == true)
{
if (objvTeachingCaseResCaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase.IsNeedGeneWord);
}
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.WordCreateDate, objvTeachingCaseResCaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IsVisible) == true)
{
if (objvTeachingCaseResCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase.IsVisible);
}
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IsDualVideo) == true)
{
if (objvTeachingCaseResCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase.IsDualVideo);
}
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IdXzCollege, objvTeachingCaseResCaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CollegeID) == true)
{
string strComparisonOpCollegeID = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CollegeID, objvTeachingCaseResCaseCond.CollegeID, strComparisonOpCollegeID);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CollegeName) == true)
{
string strComparisonOpCollegeName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CollegeName, objvTeachingCaseResCaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CollegeNameA, objvTeachingCaseResCaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IdXzMajor, objvTeachingCaseResCaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.MajorID) == true)
{
string strComparisonOpMajorID = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.MajorID, objvTeachingCaseResCaseCond.MajorID, strComparisonOpMajorID);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.MajorName) == true)
{
string strComparisonOpMajorName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.MajorName, objvTeachingCaseResCaseCond.MajorName, strComparisonOpMajorName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseChapterId, objvTeachingCaseResCaseCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseChapterName, objvTeachingCaseResCaseCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.ParentNodeID) == true)
{
string strComparisonOpParentNodeID = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.ParentNodeID, objvTeachingCaseResCaseCond.ParentNodeID, strComparisonOpParentNodeID);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.ParentNodeName, objvTeachingCaseResCaseCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.CourseChapterReferred, objvTeachingCaseResCaseCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.ParentNodeReferred, objvTeachingCaseResCaseCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.ViewCount) == true)
{
string strComparisonOpViewCount = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.ViewCount, objvTeachingCaseResCaseCond.ViewCount, strComparisonOpViewCount);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IsShow) == true)
{
if (objvTeachingCaseResCaseCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase.IsShow);
}
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.DownloadNumber, objvTeachingCaseResCaseCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.FileIntegration, objvTeachingCaseResCaseCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.LikeCount) == true)
{
string strComparisonOpLikeCount = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.LikeCount, objvTeachingCaseResCaseCond.LikeCount, strComparisonOpLikeCount);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.CollectionCount, objvTeachingCaseResCaseCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.RecommendedDegreeId, objvTeachingCaseResCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.RecommendedDegreeName, objvTeachingCaseResCaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.ftpFileType, objvTeachingCaseResCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.VideoUrl, objvTeachingCaseResCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.VideoPath, objvTeachingCaseResCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.ResErrMsg, objvTeachingCaseResCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.UpdDate) == true)
{
string strComparisonOpUpdDate = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.UpdDate, objvTeachingCaseResCaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.UpdUserId, objvTeachingCaseResCaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.Memo) == true)
{
string strComparisonOpMemo = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.Memo, objvTeachingCaseResCaseCond.Memo, strComparisonOpMemo);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.OwnerNameWithId, objvTeachingCaseResCaseCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.OwnerName) == true)
{
string strComparisonOpOwnerName = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.OwnerName, objvTeachingCaseResCaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase.BrowseCount4Case, objvTeachingCaseResCaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvTeachingCaseResCaseCond.IsUpdated(convTeachingCaseResCase.IsHaveVideo) == true)
{
string strComparisonOpIsHaveVideo = objvTeachingCaseResCaseCond.dicFldComparisonOp[convTeachingCaseResCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase.IsHaveVideo, objvTeachingCaseResCaseCond.IsHaveVideo, strComparisonOpIsHaveVideo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachingCaseResCase
{
public virtual bool UpdRelaTabDate(string strIdTeachingCaseResCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教学案例资源案例(vTeachingCaseResCase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingCaseResCaseBL
{
public static RelatedActions_vTeachingCaseResCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachingCaseResCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachingCaseResCaseDA vTeachingCaseResCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachingCaseResCaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachingCaseResCaseBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvTeachingCaseResCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCaseEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vTeachingCaseResCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseDA.GetDataTable_vTeachingCaseResCase(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrIdTeachingCaseResCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLstByIdTeachingCaseResCaseLst(List<string> arrIdTeachingCaseResCaseLst)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeachingCaseResCaseLst, true);
 string strWhereCond = string.Format("IdTeachingCaseResCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachingCaseResCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachingCaseResCaseEN> GetObjLstByIdTeachingCaseResCaseLstCache(List<string> arrIdTeachingCaseResCaseLst)
{
string strKey = string.Format("{0}", clsvTeachingCaseResCaseEN._CurrTabName);
List<clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLst_Sel =
arrvTeachingCaseResCaseObjLstCache
.Where(x => arrIdTeachingCaseResCaseLst.Contains(x.IdTeachingCaseResCase));
return arrvTeachingCaseResCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLst(string strWhereCond)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachingCaseResCaseEN> GetSubObjLstCache(clsvTeachingCaseResCaseEN objvTeachingCaseResCaseCond)
{
List<clsvTeachingCaseResCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingCaseResCase.AttributeName)
{
if (objvTeachingCaseResCaseCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingCaseResCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseCond[strFldName].ToString());
}
else
{
if (objvTeachingCaseResCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingCaseResCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingCaseResCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachingCaseResCase(ref clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN)
{
bool bolResult = vTeachingCaseResCaseDA.GetvTeachingCaseResCase(ref objvTeachingCaseResCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCaseEN GetObjByIdTeachingCaseResCase(string strIdTeachingCaseResCase)
{
if (strIdTeachingCaseResCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdTeachingCaseResCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdTeachingCaseResCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdTeachingCaseResCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = vTeachingCaseResCaseDA.GetObjByIdTeachingCaseResCase(strIdTeachingCaseResCase);
return objvTeachingCaseResCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachingCaseResCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = vTeachingCaseResCaseDA.GetFirstObj(strWhereCond);
 return objvTeachingCaseResCaseEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvTeachingCaseResCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = vTeachingCaseResCaseDA.GetObjByDataRow(objRow);
 return objvTeachingCaseResCaseEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvTeachingCaseResCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = vTeachingCaseResCaseDA.GetObjByDataRow(objRow);
 return objvTeachingCaseResCaseEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">所给的关键字</param>
 /// <param name = "lstvTeachingCaseResCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCaseEN GetObjByIdTeachingCaseResCaseFromList(string strIdTeachingCaseResCase, List<clsvTeachingCaseResCaseEN> lstvTeachingCaseResCaseObjLst)
{
foreach (clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN in lstvTeachingCaseResCaseObjLst)
{
if (objvTeachingCaseResCaseEN.IdTeachingCaseResCase == strIdTeachingCaseResCase)
{
return objvTeachingCaseResCaseEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdTeachingCaseResCase;
 try
 {
 strIdTeachingCaseResCase = new clsvTeachingCaseResCaseDA().GetFirstID(strWhereCond);
 return strIdTeachingCaseResCase;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vTeachingCaseResCaseDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vTeachingCaseResCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdTeachingCaseResCase)
{
if (string.IsNullOrEmpty(strIdTeachingCaseResCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdTeachingCaseResCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vTeachingCaseResCaseDA.IsExist(strIdTeachingCaseResCase);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvTeachingCaseResCaseDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vTeachingCaseResCaseDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseENT">目标对象</param>
 public static void CopyTo(clsvTeachingCaseResCaseEN objvTeachingCaseResCaseENS, clsvTeachingCaseResCaseEN objvTeachingCaseResCaseENT)
{
try
{
objvTeachingCaseResCaseENT.IdTeachingCaseResCase = objvTeachingCaseResCaseENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseENT.TeachingCaseResCaseID = objvTeachingCaseResCaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCaseENT.TeachingCaseResCaseName = objvTeachingCaseResCaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseENT.TeachingCaseResCaseTheme = objvTeachingCaseResCaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCaseENT.TeachingCaseResCaseText = objvTeachingCaseResCaseENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCaseENT.TeachingCaseResCaseDate = objvTeachingCaseResCaseENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCaseENT.TeachingCaseResCaseTime = objvTeachingCaseResCaseENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCaseENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCaseENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCaseENT.IdTeachingCaseResCaseType = objvTeachingCaseResCaseENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCaseENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCaseENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCaseENT.CourseId = objvTeachingCaseResCaseENS.CourseId; //课程Id
objvTeachingCaseResCaseENT.CourseCode = objvTeachingCaseResCaseENS.CourseCode; //课程代码
objvTeachingCaseResCaseENT.CourseName = objvTeachingCaseResCaseENS.CourseName; //课程名称
objvTeachingCaseResCaseENT.OwnerId = objvTeachingCaseResCaseENS.OwnerId; //拥有者Id
objvTeachingCaseResCaseENT.IdStudyLevel = objvTeachingCaseResCaseENS.IdStudyLevel; //id_StudyLevel
objvTeachingCaseResCaseENT.StudyLevelName = objvTeachingCaseResCaseENS.StudyLevelName; //学段名称
objvTeachingCaseResCaseENT.IdTeachingPlan = objvTeachingCaseResCaseENS.IdTeachingPlan; //教案流水号
objvTeachingCaseResCaseENT.IdDiscipline = objvTeachingCaseResCaseENS.IdDiscipline; //学科流水号
objvTeachingCaseResCaseENT.DisciplineID = objvTeachingCaseResCaseENS.DisciplineID; //学科ID
objvTeachingCaseResCaseENT.DisciplineName = objvTeachingCaseResCaseENS.DisciplineName; //学科名称
objvTeachingCaseResCaseENT.IdSenateGaugeVersion = objvTeachingCaseResCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCaseENT.senateGaugeVersionID = objvTeachingCaseResCaseENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCaseENT.senateGaugeVersionName = objvTeachingCaseResCaseENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCaseENT.senateGaugeVersionTtlScore = objvTeachingCaseResCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCaseENT.VersionNo = objvTeachingCaseResCaseENS.VersionNo; //版本号
objvTeachingCaseResCaseENT.IdTeachSkill = objvTeachingCaseResCaseENS.IdTeachSkill; //教学技能流水号
objvTeachingCaseResCaseENT.TeachSkillID = objvTeachingCaseResCaseENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCaseENT.SkillTypeName = objvTeachingCaseResCaseENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCaseENT.TeachSkillName = objvTeachingCaseResCaseENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCaseENT.TeachSkillTheory = objvTeachingCaseResCaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCaseENT.TeachSkillOperMethod = objvTeachingCaseResCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCaseENT.IdSkillType = objvTeachingCaseResCaseENS.IdSkillType; //技能类型流水号
objvTeachingCaseResCaseENT.SkillTypeID = objvTeachingCaseResCaseENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCaseENT.CaseLevelId = objvTeachingCaseResCaseENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCaseENT.CaseLevelName = objvTeachingCaseResCaseENS.CaseLevelName; //案例等级名称
objvTeachingCaseResCaseENT.DocFile = objvTeachingCaseResCaseENS.DocFile; //生成的Word文件名
objvTeachingCaseResCaseENT.IsNeedGeneWord = objvTeachingCaseResCaseENS.IsNeedGeneWord; //是否需要生成Word
objvTeachingCaseResCaseENT.WordCreateDate = objvTeachingCaseResCaseENS.WordCreateDate; //Word生成日期
objvTeachingCaseResCaseENT.IsVisible = objvTeachingCaseResCaseENS.IsVisible; //是否显示
objvTeachingCaseResCaseENT.IsDualVideo = objvTeachingCaseResCaseENS.IsDualVideo; //是否双视频
objvTeachingCaseResCaseENT.IdXzCollege = objvTeachingCaseResCaseENS.IdXzCollege; //学院流水号
objvTeachingCaseResCaseENT.CollegeID = objvTeachingCaseResCaseENS.CollegeID; //学院ID
objvTeachingCaseResCaseENT.CollegeName = objvTeachingCaseResCaseENS.CollegeName; //学院名称
objvTeachingCaseResCaseENT.CollegeNameA = objvTeachingCaseResCaseENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseENT.IdXzMajor = objvTeachingCaseResCaseENS.IdXzMajor; //专业流水号
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
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN)
{
try
{
objvTeachingCaseResCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachingCaseResCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachingCaseResCase.IdTeachingCaseResCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objvTeachingCaseResCaseEN.IdTeachingCaseResCase; //教学案例资源案例流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachingCaseResCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objvTeachingCaseResCaseEN.TeachingCaseResCaseID; //教学案例资源案例ID
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachingCaseResCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objvTeachingCaseResCaseEN.TeachingCaseResCaseName; //教学案例资源案例名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachingCaseResCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme; //教学案例资源案例主题词
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachingCaseResCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objvTeachingCaseResCaseEN.TeachingCaseResCaseText == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachingCaseResCaseText; //案例文本内容
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachingCaseResCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objvTeachingCaseResCaseEN.TeachingCaseResCaseDate == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachingCaseResCaseDate; //视频资源日期
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachingCaseResCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objvTeachingCaseResCaseEN.TeachingCaseResCaseTime == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachingCaseResCaseTime; //视频资源时间
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachingCaseResCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachingCaseResCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convTeachingCaseResCase.IdTeachingCaseResCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType; //教学案例资源类型流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachingCaseResCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CourseId = objvTeachingCaseResCaseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convTeachingCaseResCase.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CourseCode = objvTeachingCaseResCaseEN.CourseCode == "[null]" ? null :  objvTeachingCaseResCaseEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convTeachingCaseResCase.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CourseName = objvTeachingCaseResCaseEN.CourseName == "[null]" ? null :  objvTeachingCaseResCaseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.OwnerId = objvTeachingCaseResCaseEN.OwnerId == "[null]" ? null :  objvTeachingCaseResCaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convTeachingCaseResCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IdStudyLevel = objvTeachingCaseResCaseEN.IdStudyLevel == "[null]" ? null :  objvTeachingCaseResCaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convTeachingCaseResCase.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.StudyLevelName = objvTeachingCaseResCaseEN.StudyLevelName == "[null]" ? null :  objvTeachingCaseResCaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IdTeachingPlan = objvTeachingCaseResCaseEN.IdTeachingPlan == "[null]" ? null :  objvTeachingCaseResCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IdDiscipline = objvTeachingCaseResCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.DisciplineID = objvTeachingCaseResCaseEN.DisciplineID == "[null]" ? null :  objvTeachingCaseResCaseEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convTeachingCaseResCase.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.DisciplineName = objvTeachingCaseResCaseEN.DisciplineName == "[null]" ? null :  objvTeachingCaseResCaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objvTeachingCaseResCaseEN.IdSenateGaugeVersion == "[null]" ? null :  objvTeachingCaseResCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.senateGaugeVersionID = objvTeachingCaseResCaseEN.senateGaugeVersionID == "[null]" ? null :  objvTeachingCaseResCaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convTeachingCaseResCase.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.senateGaugeVersionName = objvTeachingCaseResCaseEN.senateGaugeVersionName == "[null]" ? null :  objvTeachingCaseResCaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convTeachingCaseResCase.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.VersionNo = objvTeachingCaseResCaseEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convTeachingCaseResCase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IdTeachSkill = objvTeachingCaseResCaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachSkillID = objvTeachingCaseResCaseEN.TeachSkillID == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convTeachingCaseResCase.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.SkillTypeName = objvTeachingCaseResCaseEN.SkillTypeName == "[null]" ? null :  objvTeachingCaseResCaseEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachSkillName = objvTeachingCaseResCaseEN.TeachSkillName == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachSkillTheory = objvTeachingCaseResCaseEN.TeachSkillTheory == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convTeachingCaseResCase.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objvTeachingCaseResCaseEN.TeachSkillOperMethod == "[null]" ? null :  objvTeachingCaseResCaseEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convTeachingCaseResCase.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IdSkillType = objvTeachingCaseResCaseEN.IdSkillType == "[null]" ? null :  objvTeachingCaseResCaseEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.SkillTypeID = objvTeachingCaseResCaseEN.SkillTypeID == "[null]" ? null :  objvTeachingCaseResCaseEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convTeachingCaseResCase.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CaseLevelId = objvTeachingCaseResCaseEN.CaseLevelId == "[null]" ? null :  objvTeachingCaseResCaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convTeachingCaseResCase.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CaseLevelName = objvTeachingCaseResCaseEN.CaseLevelName == "[null]" ? null :  objvTeachingCaseResCaseEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.DocFile = objvTeachingCaseResCaseEN.DocFile == "[null]" ? null :  objvTeachingCaseResCaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convTeachingCaseResCase.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IsNeedGeneWord = objvTeachingCaseResCaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convTeachingCaseResCase.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.WordCreateDate = objvTeachingCaseResCaseEN.WordCreateDate == "[null]" ? null :  objvTeachingCaseResCaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convTeachingCaseResCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IsVisible = objvTeachingCaseResCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convTeachingCaseResCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IsDualVideo = objvTeachingCaseResCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convTeachingCaseResCase.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IdXzCollege = objvTeachingCaseResCaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CollegeID = objvTeachingCaseResCaseEN.CollegeID == "[null]" ? null :  objvTeachingCaseResCaseEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convTeachingCaseResCase.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CollegeName = objvTeachingCaseResCaseEN.CollegeName == "[null]" ? null :  objvTeachingCaseResCaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CollegeNameA = objvTeachingCaseResCaseEN.CollegeNameA == "[null]" ? null :  objvTeachingCaseResCaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convTeachingCaseResCase.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IdXzMajor = objvTeachingCaseResCaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.MajorID = objvTeachingCaseResCaseEN.MajorID == "[null]" ? null :  objvTeachingCaseResCaseEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convTeachingCaseResCase.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.MajorName = objvTeachingCaseResCaseEN.MajorName == "[null]" ? null :  objvTeachingCaseResCaseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CourseChapterId = objvTeachingCaseResCaseEN.CourseChapterId == "[null]" ? null :  objvTeachingCaseResCaseEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convTeachingCaseResCase.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CourseChapterName = objvTeachingCaseResCaseEN.CourseChapterName == "[null]" ? null :  objvTeachingCaseResCaseEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.ParentNodeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.ParentNodeID = objvTeachingCaseResCaseEN.ParentNodeID == "[null]" ? null :  objvTeachingCaseResCaseEN.ParentNodeID; //父节点编号
}
if (arrFldSet.Contains(convTeachingCaseResCase.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.ParentNodeName = objvTeachingCaseResCaseEN.ParentNodeName == "[null]" ? null :  objvTeachingCaseResCaseEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CourseChapterReferred = objvTeachingCaseResCaseEN.CourseChapterReferred == "[null]" ? null :  objvTeachingCaseResCaseEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convTeachingCaseResCase.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.ParentNodeReferred = objvTeachingCaseResCaseEN.ParentNodeReferred == "[null]" ? null :  objvTeachingCaseResCaseEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convTeachingCaseResCase.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.ViewCount = objvTeachingCaseResCaseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convTeachingCaseResCase.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IsShow = objvTeachingCaseResCaseEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convTeachingCaseResCase.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.DownloadNumber = objvTeachingCaseResCaseEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convTeachingCaseResCase.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.FileIntegration = objvTeachingCaseResCaseEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convTeachingCaseResCase.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.LikeCount = objvTeachingCaseResCaseEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convTeachingCaseResCase.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.CollectionCount = objvTeachingCaseResCaseEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convTeachingCaseResCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.RecommendedDegreeId = objvTeachingCaseResCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convTeachingCaseResCase.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.RecommendedDegreeName = objvTeachingCaseResCaseEN.RecommendedDegreeName == "[null]" ? null :  objvTeachingCaseResCaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convTeachingCaseResCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.ftpFileType = objvTeachingCaseResCaseEN.ftpFileType == "[null]" ? null :  objvTeachingCaseResCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convTeachingCaseResCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.VideoUrl = objvTeachingCaseResCaseEN.VideoUrl == "[null]" ? null :  objvTeachingCaseResCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convTeachingCaseResCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.VideoPath = objvTeachingCaseResCaseEN.VideoPath == "[null]" ? null :  objvTeachingCaseResCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convTeachingCaseResCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.ResErrMsg = objvTeachingCaseResCaseEN.ResErrMsg == "[null]" ? null :  objvTeachingCaseResCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convTeachingCaseResCase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.UpdDate = objvTeachingCaseResCaseEN.UpdDate == "[null]" ? null :  objvTeachingCaseResCaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convTeachingCaseResCase.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.UpdUserId = objvTeachingCaseResCaseEN.UpdUserId == "[null]" ? null :  objvTeachingCaseResCaseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convTeachingCaseResCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.Memo = objvTeachingCaseResCaseEN.Memo == "[null]" ? null :  objvTeachingCaseResCaseEN.Memo; //备注
}
if (arrFldSet.Contains(convTeachingCaseResCase.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.OwnerNameWithId = objvTeachingCaseResCaseEN.OwnerNameWithId == "[null]" ? null :  objvTeachingCaseResCaseEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convTeachingCaseResCase.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.OwnerName = objvTeachingCaseResCaseEN.OwnerName == "[null]" ? null :  objvTeachingCaseResCaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convTeachingCaseResCase.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.BrowseCount4Case = objvTeachingCaseResCaseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convTeachingCaseResCase.IsHaveVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseEN.IsHaveVideo = objvTeachingCaseResCaseEN.IsHaveVideo; //IsHaveVideo
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN)
{
try
{
if (objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme == "[null]") objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = null; //教学案例资源案例主题词
if (objvTeachingCaseResCaseEN.TeachingCaseResCaseText == "[null]") objvTeachingCaseResCaseEN.TeachingCaseResCaseText = null; //案例文本内容
if (objvTeachingCaseResCaseEN.TeachingCaseResCaseDate == "[null]") objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = null; //视频资源日期
if (objvTeachingCaseResCaseEN.TeachingCaseResCaseTime == "[null]") objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = null; //视频资源时间
if (objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn == "[null]") objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = null; //案例入库日期
if (objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn == "[null]") objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = null; //案例入库时间
if (objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName == "[null]") objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = null; //教学案例资源案例类型名称
if (objvTeachingCaseResCaseEN.CourseCode == "[null]") objvTeachingCaseResCaseEN.CourseCode = null; //课程代码
if (objvTeachingCaseResCaseEN.CourseName == "[null]") objvTeachingCaseResCaseEN.CourseName = null; //课程名称
if (objvTeachingCaseResCaseEN.OwnerId == "[null]") objvTeachingCaseResCaseEN.OwnerId = null; //拥有者Id
if (objvTeachingCaseResCaseEN.IdStudyLevel == "[null]") objvTeachingCaseResCaseEN.IdStudyLevel = null; //id_StudyLevel
if (objvTeachingCaseResCaseEN.StudyLevelName == "[null]") objvTeachingCaseResCaseEN.StudyLevelName = null; //学段名称
if (objvTeachingCaseResCaseEN.IdTeachingPlan == "[null]") objvTeachingCaseResCaseEN.IdTeachingPlan = null; //教案流水号
if (objvTeachingCaseResCaseEN.DisciplineID == "[null]") objvTeachingCaseResCaseEN.DisciplineID = null; //学科ID
if (objvTeachingCaseResCaseEN.DisciplineName == "[null]") objvTeachingCaseResCaseEN.DisciplineName = null; //学科名称
if (objvTeachingCaseResCaseEN.IdSenateGaugeVersion == "[null]") objvTeachingCaseResCaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvTeachingCaseResCaseEN.senateGaugeVersionID == "[null]") objvTeachingCaseResCaseEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvTeachingCaseResCaseEN.senateGaugeVersionName == "[null]") objvTeachingCaseResCaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvTeachingCaseResCaseEN.TeachSkillID == "[null]") objvTeachingCaseResCaseEN.TeachSkillID = null; //教学技能ID
if (objvTeachingCaseResCaseEN.SkillTypeName == "[null]") objvTeachingCaseResCaseEN.SkillTypeName = null; //技能类型名称
if (objvTeachingCaseResCaseEN.TeachSkillName == "[null]") objvTeachingCaseResCaseEN.TeachSkillName = null; //教学技能名称
if (objvTeachingCaseResCaseEN.TeachSkillTheory == "[null]") objvTeachingCaseResCaseEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvTeachingCaseResCaseEN.TeachSkillOperMethod == "[null]") objvTeachingCaseResCaseEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvTeachingCaseResCaseEN.IdSkillType == "[null]") objvTeachingCaseResCaseEN.IdSkillType = null; //技能类型流水号
if (objvTeachingCaseResCaseEN.SkillTypeID == "[null]") objvTeachingCaseResCaseEN.SkillTypeID = null; //技能类型ID
if (objvTeachingCaseResCaseEN.CaseLevelId == "[null]") objvTeachingCaseResCaseEN.CaseLevelId = null; //课例等级Id
if (objvTeachingCaseResCaseEN.CaseLevelName == "[null]") objvTeachingCaseResCaseEN.CaseLevelName = null; //案例等级名称
if (objvTeachingCaseResCaseEN.DocFile == "[null]") objvTeachingCaseResCaseEN.DocFile = null; //生成的Word文件名
if (objvTeachingCaseResCaseEN.WordCreateDate == "[null]") objvTeachingCaseResCaseEN.WordCreateDate = null; //Word生成日期
if (objvTeachingCaseResCaseEN.CollegeID == "[null]") objvTeachingCaseResCaseEN.CollegeID = null; //学院ID
if (objvTeachingCaseResCaseEN.CollegeName == "[null]") objvTeachingCaseResCaseEN.CollegeName = null; //学院名称
if (objvTeachingCaseResCaseEN.CollegeNameA == "[null]") objvTeachingCaseResCaseEN.CollegeNameA = null; //学院名称简写
if (objvTeachingCaseResCaseEN.MajorID == "[null]") objvTeachingCaseResCaseEN.MajorID = null; //专业ID
if (objvTeachingCaseResCaseEN.MajorName == "[null]") objvTeachingCaseResCaseEN.MajorName = null; //专业名称
if (objvTeachingCaseResCaseEN.CourseChapterId == "[null]") objvTeachingCaseResCaseEN.CourseChapterId = null; //课程章节ID
if (objvTeachingCaseResCaseEN.CourseChapterName == "[null]") objvTeachingCaseResCaseEN.CourseChapterName = null; //课程章节名称
if (objvTeachingCaseResCaseEN.ParentNodeID == "[null]") objvTeachingCaseResCaseEN.ParentNodeID = null; //父节点编号
if (objvTeachingCaseResCaseEN.ParentNodeName == "[null]") objvTeachingCaseResCaseEN.ParentNodeName = null; //父节点名称
if (objvTeachingCaseResCaseEN.CourseChapterReferred == "[null]") objvTeachingCaseResCaseEN.CourseChapterReferred = null; //节简称
if (objvTeachingCaseResCaseEN.ParentNodeReferred == "[null]") objvTeachingCaseResCaseEN.ParentNodeReferred = null; //章简称
if (objvTeachingCaseResCaseEN.RecommendedDegreeName == "[null]") objvTeachingCaseResCaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvTeachingCaseResCaseEN.ftpFileType == "[null]") objvTeachingCaseResCaseEN.ftpFileType = null; //ftp文件类型
if (objvTeachingCaseResCaseEN.VideoUrl == "[null]") objvTeachingCaseResCaseEN.VideoUrl = null; //视频Url
if (objvTeachingCaseResCaseEN.VideoPath == "[null]") objvTeachingCaseResCaseEN.VideoPath = null; //视频目录
if (objvTeachingCaseResCaseEN.ResErrMsg == "[null]") objvTeachingCaseResCaseEN.ResErrMsg = null; //资源错误信息
if (objvTeachingCaseResCaseEN.UpdDate == "[null]") objvTeachingCaseResCaseEN.UpdDate = null; //修改日期
if (objvTeachingCaseResCaseEN.UpdUserId == "[null]") objvTeachingCaseResCaseEN.UpdUserId = null; //修改用户Id
if (objvTeachingCaseResCaseEN.Memo == "[null]") objvTeachingCaseResCaseEN.Memo = null; //备注
if (objvTeachingCaseResCaseEN.OwnerNameWithId == "[null]") objvTeachingCaseResCaseEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvTeachingCaseResCaseEN.OwnerName == "[null]") objvTeachingCaseResCaseEN.OwnerName = null; //拥有者姓名
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN)
{
 vTeachingCaseResCaseDA.CheckProperty4Condition(objvTeachingCaseResCaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelBL没有刷新缓存机制(clsCaseLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseBL没有刷新缓存机制(clsTeachingCaseResCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseTypeBL没有刷新缓存机制(clsTeachingCaseResCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeBL没有刷新缓存机制(clsXzDegreeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeBL没有刷新缓存机制(clsXzMajorTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeBL没有刷新缓存机制(clsXzMajorShoolTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillBL没有刷新缓存机制(clsTeachSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeachingCaseResCase");
//if (arrvTeachingCaseResCaseObjLstCache == null)
//{
//arrvTeachingCaseResCaseObjLstCache = vTeachingCaseResCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCaseEN GetObjByIdTeachingCaseResCaseCache(string strIdTeachingCaseResCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeachingCaseResCaseEN._CurrTabName);
List<clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLst_Sel =
arrvTeachingCaseResCaseObjLstCache
.Where(x=> x.IdTeachingCaseResCase == strIdTeachingCaseResCase 
);
if (arrvTeachingCaseResCaseObjLst_Sel.Count() == 0)
{
   clsvTeachingCaseResCaseEN obj = clsvTeachingCaseResCaseBL.GetObjByIdTeachingCaseResCase(strIdTeachingCaseResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeachingCaseResCaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetAllvTeachingCaseResCaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLstCache = GetObjLstCache(); 
return arrvTeachingCaseResCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingCaseResCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingCaseResCaseEN._CurrTabName);
List<clsvTeachingCaseResCaseEN> arrvTeachingCaseResCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingCaseResCaseObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvTeachingCaseResCaseEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdTeachingCaseResCase)
{
if (strInFldName != convTeachingCaseResCase.IdTeachingCaseResCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachingCaseResCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachingCaseResCase.AttributeName));
throw new Exception(strMsg);
}
var objvTeachingCaseResCase = clsvTeachingCaseResCaseBL.GetObjByIdTeachingCaseResCaseCache(strIdTeachingCaseResCase);
if (objvTeachingCaseResCase == null) return "";
return objvTeachingCaseResCase[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvTeachingCaseResCaseDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvTeachingCaseResCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachingCaseResCaseDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvTeachingCaseResCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachingCaseResCaseEN objvTeachingCaseResCaseCond)
{
List<clsvTeachingCaseResCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingCaseResCase.AttributeName)
{
if (objvTeachingCaseResCaseCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingCaseResCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseCond[strFldName].ToString());
}
else
{
if (objvTeachingCaseResCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingCaseResCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingCaseResCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvTeachingCaseResCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vTeachingCaseResCaseDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vTeachingCaseResCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}