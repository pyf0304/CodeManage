
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCase_BaseBL
 表名:vTeachingCaseResCase_Base(01120515)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:04:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvTeachingCaseResCase_BaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCase_BaseEN GetObj(this K_IdTeachingCaseResCase_vTeachingCaseResCase_Base myKey)
{
clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = clsvTeachingCaseResCase_BaseBL.vTeachingCaseResCase_BaseDA.GetObjByIdTeachingCaseResCase(myKey.Value);
return objvTeachingCaseResCase_BaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIdTeachingCaseResCase(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strIdTeachingCaseResCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingCaseResCase, 8, convTeachingCaseResCase_Base.IdTeachingCaseResCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingCaseResCase, 8, convTeachingCaseResCase_Base.IdTeachingCaseResCase);
}
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = strIdTeachingCaseResCase; //教学案例资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IdTeachingCaseResCase) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IdTeachingCaseResCase, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IdTeachingCaseResCase] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseID, convTeachingCaseResCase_Base.TeachingCaseResCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseID, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseID, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseName, convTeachingCaseResCase_Base.TeachingCaseResCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, convTeachingCaseResCase_Base.TeachingCaseResCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseTheme(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTheme, 200, convTeachingCaseResCase_Base.TeachingCaseResCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseText(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseText, 8000, convTeachingCaseResCase_Base.TeachingCaseResCaseText);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseDate(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseTime(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase_Base.TeachingCaseResCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase_Base.TeachingCaseResCaseTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseDateIn(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseTimeIn(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIdTeachingCaseResCaseType(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strIdTeachingCaseResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingCaseResCaseType, convTeachingCaseResCase_Base.IdTeachingCaseResCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingCaseResCaseType, 4, convTeachingCaseResCase_Base.IdTeachingCaseResCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingCaseResCaseType, 4, convTeachingCaseResCase_Base.IdTeachingCaseResCaseType);
}
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = strIdTeachingCaseResCaseType; //教学案例资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IdTeachingCaseResCaseType) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IdTeachingCaseResCaseType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachingCaseResCaseTypeName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachingCaseResCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTypeName, 30, convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convTeachingCaseResCase_Base.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingCaseResCase_Base.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingCaseResCase_Base.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseCode(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingCaseResCase_Base.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convTeachingCaseResCase_Base.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetOwnerId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convTeachingCaseResCase_Base.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIdStudyLevel(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convTeachingCaseResCase_Base.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convTeachingCaseResCase_Base.IdStudyLevel);
}
objvTeachingCaseResCase_BaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IdStudyLevel) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IdStudyLevel, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IdStudyLevel] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetStudyLevelName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convTeachingCaseResCase_Base.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIdTeachingPlan(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convTeachingCaseResCase_Base.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convTeachingCaseResCase_Base.IdTeachingPlan);
}
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IdTeachingPlan) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IdTeachingPlan, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IdTeachingPlan] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIdDiscipline(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convTeachingCaseResCase_Base.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convTeachingCaseResCase_Base.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convTeachingCaseResCase_Base.IdDiscipline);
}
objvTeachingCaseResCase_BaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IdDiscipline) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IdDiscipline, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IdDiscipline] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetDisciplineID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convTeachingCaseResCase_Base.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convTeachingCaseResCase_Base.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetDisciplineName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convTeachingCaseResCase_Base.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIdSenateGaugeVersion(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convTeachingCaseResCase_Base.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convTeachingCaseResCase_Base.IdSenateGaugeVersion);
}
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IdSenateGaugeVersion) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetsenateGaugeVersionID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convTeachingCaseResCase_Base.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convTeachingCaseResCase_Base.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetsenateGaugeVersionName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convTeachingCaseResCase_Base.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetVersionNo(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, int? intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIdTeachSkill(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convTeachingCaseResCase_Base.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convTeachingCaseResCase_Base.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convTeachingCaseResCase_Base.IdTeachSkill);
}
objvTeachingCaseResCase_BaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IdTeachSkill) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IdTeachSkill, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IdTeachSkill] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachSkillID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachingCaseResCase_Base.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachingCaseResCase_Base.TeachSkillID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetSkillTypeName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachingCaseResCase_Base.SkillTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachSkillName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachingCaseResCase_Base.TeachSkillName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachSkillTheory(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachingCaseResCase_Base.TeachSkillTheory);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetTeachSkillOperMethod(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachingCaseResCase_Base.TeachSkillOperMethod);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIdSkillType(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convTeachingCaseResCase_Base.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convTeachingCaseResCase_Base.IdSkillType);
}
objvTeachingCaseResCase_BaseEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IdSkillType) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IdSkillType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IdSkillType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetSkillTypeID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachingCaseResCase_Base.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachingCaseResCase_Base.SkillTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCaseLevelId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convTeachingCaseResCase_Base.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convTeachingCaseResCase_Base.CaseLevelId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCaseLevelName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convTeachingCaseResCase_Base.CaseLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetDocFile(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convTeachingCaseResCase_Base.DocFile);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetWordCreateDate(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convTeachingCaseResCase_Base.WordCreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIdXzCollege(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, convTeachingCaseResCase_Base.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convTeachingCaseResCase_Base.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convTeachingCaseResCase_Base.IdXzCollege);
}
objvTeachingCaseResCase_BaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IdXzCollege) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IdXzCollege, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IdXzCollege] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCollegeId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convTeachingCaseResCase_Base.CollegeId);
}
objvTeachingCaseResCase_BaseEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.CollegeId) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.CollegeId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.CollegeId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCollegeName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingCaseResCase_Base.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCollegeNameA(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachingCaseResCase_Base.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetIdXzMajor(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convTeachingCaseResCase_Base.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convTeachingCaseResCase_Base.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convTeachingCaseResCase_Base.IdXzMajor);
}
objvTeachingCaseResCase_BaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.IdXzMajor) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.IdXzMajor, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.IdXzMajor] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetMajorID(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convTeachingCaseResCase_Base.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convTeachingCaseResCase_Base.MajorID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetMajorName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convTeachingCaseResCase_Base.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseChapterId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convTeachingCaseResCase_Base.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convTeachingCaseResCase_Base.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseChapterName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convTeachingCaseResCase_Base.CourseChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetParentNodeId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convTeachingCaseResCase_Base.ParentNodeId);
}
objvTeachingCaseResCase_BaseEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Base.ParentNodeId) == false)
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Base.ParentNodeId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_BaseEN.dicFldComparisonOp[convTeachingCaseResCase_Base.ParentNodeId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetParentNodeName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convTeachingCaseResCase_Base.ParentNodeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCourseChapterReferred(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convTeachingCaseResCase_Base.CourseChapterReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetParentNodeReferred(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convTeachingCaseResCase_Base.ParentNodeReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetViewCount(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, int? intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetDownloadNumber(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, int? intDownloadNumber, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetFileIntegration(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, int? intFileIntegration, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetLikeCount(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, long? lngLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetCollectionCount(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, long? lngCollectionCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetRecommendedDegreeId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convTeachingCaseResCase_Base.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convTeachingCaseResCase_Base.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convTeachingCaseResCase_Base.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetRecommendedDegreeName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convTeachingCaseResCase_Base.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetftpFileType(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachingCaseResCase_Base.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetVideoUrl(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convTeachingCaseResCase_Base.VideoUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetVideoPath(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convTeachingCaseResCase_Base.VideoPath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetResErrMsg(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convTeachingCaseResCase_Base.ResErrMsg);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetMemo(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingCaseResCase_Base.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetOwnerName(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convTeachingCaseResCase_Base.OwnerName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetOwnerNameWithId(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convTeachingCaseResCase_Base.OwnerNameWithId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_BaseEN SetBrowseCount4Case(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseENS">源对象</param>
 /// <param name = "objvTeachingCaseResCase_BaseENT">目标对象</param>
 public static void CopyTo(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseENS, clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseENT)
{
try
{
objvTeachingCaseResCase_BaseENT.IdTeachingCaseResCase = objvTeachingCaseResCase_BaseENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseID = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseName = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTheme = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseText = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseDate = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTime = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCase_BaseENT.IdTeachingCaseResCaseType = objvTeachingCaseResCase_BaseENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseENT.CourseId = objvTeachingCaseResCase_BaseENS.CourseId; //课程Id
objvTeachingCaseResCase_BaseENT.CourseCode = objvTeachingCaseResCase_BaseENS.CourseCode; //课程代码
objvTeachingCaseResCase_BaseENT.CourseName = objvTeachingCaseResCase_BaseENS.CourseName; //课程名称
objvTeachingCaseResCase_BaseENT.OwnerId = objvTeachingCaseResCase_BaseENS.OwnerId; //拥有者Id
objvTeachingCaseResCase_BaseENT.IdStudyLevel = objvTeachingCaseResCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvTeachingCaseResCase_BaseENT.StudyLevelName = objvTeachingCaseResCase_BaseENS.StudyLevelName; //学段名称
objvTeachingCaseResCase_BaseENT.IdTeachingPlan = objvTeachingCaseResCase_BaseENS.IdTeachingPlan; //教案流水号
objvTeachingCaseResCase_BaseENT.IdDiscipline = objvTeachingCaseResCase_BaseENS.IdDiscipline; //学科流水号
objvTeachingCaseResCase_BaseENT.DisciplineID = objvTeachingCaseResCase_BaseENS.DisciplineID; //学科ID
objvTeachingCaseResCase_BaseENT.DisciplineName = objvTeachingCaseResCase_BaseENS.DisciplineName; //学科名称
objvTeachingCaseResCase_BaseENT.IdSenateGaugeVersion = objvTeachingCaseResCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCase_BaseENT.senateGaugeVersionID = objvTeachingCaseResCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCase_BaseENT.senateGaugeVersionName = objvTeachingCaseResCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCase_BaseENT.senateGaugeVersionTtlScore = objvTeachingCaseResCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCase_BaseENT.VersionNo = objvTeachingCaseResCase_BaseENS.VersionNo; //版本号
objvTeachingCaseResCase_BaseENT.IdTeachSkill = objvTeachingCaseResCase_BaseENS.IdTeachSkill; //教学技能流水号
objvTeachingCaseResCase_BaseENT.TeachSkillID = objvTeachingCaseResCase_BaseENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCase_BaseENT.SkillTypeName = objvTeachingCaseResCase_BaseENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCase_BaseENT.TeachSkillName = objvTeachingCaseResCase_BaseENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCase_BaseENT.TeachSkillTheory = objvTeachingCaseResCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCase_BaseENT.TeachSkillOperMethod = objvTeachingCaseResCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCase_BaseENT.IdSkillType = objvTeachingCaseResCase_BaseENS.IdSkillType; //技能类型流水号
objvTeachingCaseResCase_BaseENT.SkillTypeID = objvTeachingCaseResCase_BaseENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCase_BaseENT.CaseLevelId = objvTeachingCaseResCase_BaseENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCase_BaseENT.CaseLevelName = objvTeachingCaseResCase_BaseENS.CaseLevelName; //案例等级名称
objvTeachingCaseResCase_BaseENT.DocFile = objvTeachingCaseResCase_BaseENS.DocFile; //生成的Word文件名
objvTeachingCaseResCase_BaseENT.IsNeedGeneWord = objvTeachingCaseResCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvTeachingCaseResCase_BaseENT.WordCreateDate = objvTeachingCaseResCase_BaseENS.WordCreateDate; //Word生成日期
objvTeachingCaseResCase_BaseENT.IsVisible = objvTeachingCaseResCase_BaseENS.IsVisible; //是否显示
objvTeachingCaseResCase_BaseENT.IsDualVideo = objvTeachingCaseResCase_BaseENS.IsDualVideo; //是否双视频
objvTeachingCaseResCase_BaseENT.IdXzCollege = objvTeachingCaseResCase_BaseENS.IdXzCollege; //学院流水号
objvTeachingCaseResCase_BaseENT.CollegeId = objvTeachingCaseResCase_BaseENS.CollegeId; //学院ID
objvTeachingCaseResCase_BaseENT.CollegeName = objvTeachingCaseResCase_BaseENS.CollegeName; //学院名称
objvTeachingCaseResCase_BaseENT.CollegeNameA = objvTeachingCaseResCase_BaseENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCase_BaseENT.IdXzMajor = objvTeachingCaseResCase_BaseENS.IdXzMajor; //专业流水号
objvTeachingCaseResCase_BaseENT.MajorID = objvTeachingCaseResCase_BaseENS.MajorID; //专业ID
objvTeachingCaseResCase_BaseENT.MajorName = objvTeachingCaseResCase_BaseENS.MajorName; //专业名称
objvTeachingCaseResCase_BaseENT.CourseChapterId = objvTeachingCaseResCase_BaseENS.CourseChapterId; //课程章节ID
objvTeachingCaseResCase_BaseENT.CourseChapterName = objvTeachingCaseResCase_BaseENS.CourseChapterName; //课程章节名称
objvTeachingCaseResCase_BaseENT.ParentNodeId = objvTeachingCaseResCase_BaseENS.ParentNodeId; //父节点编号
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
 /// <param name = "objvTeachingCaseResCase_BaseENS">源对象</param>
 /// <returns>目标对象=>clsvTeachingCaseResCase_BaseEN:objvTeachingCaseResCase_BaseENT</returns>
 public static clsvTeachingCaseResCase_BaseEN CopyTo(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseENS)
{
try
{
 clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseENT = new clsvTeachingCaseResCase_BaseEN()
{
IdTeachingCaseResCase = objvTeachingCaseResCase_BaseENS.IdTeachingCaseResCase, //教学案例资源案例流水号
TeachingCaseResCaseID = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseID, //教学案例资源案例ID
TeachingCaseResCaseName = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseName, //教学案例资源案例名称
TeachingCaseResCaseTheme = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTheme, //教学案例资源案例主题词
TeachingCaseResCaseText = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseText, //案例文本内容
TeachingCaseResCaseDate = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseDate, //视频资源日期
TeachingCaseResCaseTime = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTime, //视频资源时间
TeachingCaseResCaseDateIn = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseDateIn, //案例入库日期
TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTimeIn, //案例入库时间
IdTeachingCaseResCaseType = objvTeachingCaseResCase_BaseENS.IdTeachingCaseResCaseType, //教学案例资源类型流水号
TeachingCaseResCaseTypeName = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTypeName, //教学案例资源案例类型名称
CourseId = objvTeachingCaseResCase_BaseENS.CourseId, //课程Id
CourseCode = objvTeachingCaseResCase_BaseENS.CourseCode, //课程代码
CourseName = objvTeachingCaseResCase_BaseENS.CourseName, //课程名称
OwnerId = objvTeachingCaseResCase_BaseENS.OwnerId, //拥有者Id
IdStudyLevel = objvTeachingCaseResCase_BaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvTeachingCaseResCase_BaseENS.StudyLevelName, //学段名称
IdTeachingPlan = objvTeachingCaseResCase_BaseENS.IdTeachingPlan, //教案流水号
IdDiscipline = objvTeachingCaseResCase_BaseENS.IdDiscipline, //学科流水号
DisciplineID = objvTeachingCaseResCase_BaseENS.DisciplineID, //学科ID
DisciplineName = objvTeachingCaseResCase_BaseENS.DisciplineName, //学科名称
IdSenateGaugeVersion = objvTeachingCaseResCase_BaseENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvTeachingCaseResCase_BaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvTeachingCaseResCase_BaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvTeachingCaseResCase_BaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvTeachingCaseResCase_BaseENS.VersionNo, //版本号
IdTeachSkill = objvTeachingCaseResCase_BaseENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvTeachingCaseResCase_BaseENS.TeachSkillID, //教学技能ID
SkillTypeName = objvTeachingCaseResCase_BaseENS.SkillTypeName, //技能类型名称
TeachSkillName = objvTeachingCaseResCase_BaseENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvTeachingCaseResCase_BaseENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvTeachingCaseResCase_BaseENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvTeachingCaseResCase_BaseENS.IdSkillType, //技能类型流水号
SkillTypeID = objvTeachingCaseResCase_BaseENS.SkillTypeID, //技能类型ID
CaseLevelId = objvTeachingCaseResCase_BaseENS.CaseLevelId, //课例等级Id
CaseLevelName = objvTeachingCaseResCase_BaseENS.CaseLevelName, //案例等级名称
DocFile = objvTeachingCaseResCase_BaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvTeachingCaseResCase_BaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvTeachingCaseResCase_BaseENS.WordCreateDate, //Word生成日期
IsVisible = objvTeachingCaseResCase_BaseENS.IsVisible, //是否显示
IsDualVideo = objvTeachingCaseResCase_BaseENS.IsDualVideo, //是否双视频
IdXzCollege = objvTeachingCaseResCase_BaseENS.IdXzCollege, //学院流水号
CollegeId = objvTeachingCaseResCase_BaseENS.CollegeId, //学院ID
CollegeName = objvTeachingCaseResCase_BaseENS.CollegeName, //学院名称
CollegeNameA = objvTeachingCaseResCase_BaseENS.CollegeNameA, //学院名称简写
IdXzMajor = objvTeachingCaseResCase_BaseENS.IdXzMajor, //专业流水号
MajorID = objvTeachingCaseResCase_BaseENS.MajorID, //专业ID
MajorName = objvTeachingCaseResCase_BaseENS.MajorName, //专业名称
CourseChapterId = objvTeachingCaseResCase_BaseENS.CourseChapterId, //课程章节ID
CourseChapterName = objvTeachingCaseResCase_BaseENS.CourseChapterName, //课程章节名称
ParentNodeId = objvTeachingCaseResCase_BaseENS.ParentNodeId, //父节点编号
ParentNodeName = objvTeachingCaseResCase_BaseENS.ParentNodeName, //父节点名称
CourseChapterReferred = objvTeachingCaseResCase_BaseENS.CourseChapterReferred, //节简称
ParentNodeReferred = objvTeachingCaseResCase_BaseENS.ParentNodeReferred, //章简称
ViewCount = objvTeachingCaseResCase_BaseENS.ViewCount, //浏览量
IsShow = objvTeachingCaseResCase_BaseENS.IsShow, //是否启用
DownloadNumber = objvTeachingCaseResCase_BaseENS.DownloadNumber, //下载数目
FileIntegration = objvTeachingCaseResCase_BaseENS.FileIntegration, //文件积分
LikeCount = objvTeachingCaseResCase_BaseENS.LikeCount, //资源喜欢数量
CollectionCount = objvTeachingCaseResCase_BaseENS.CollectionCount, //收藏数量
RecommendedDegreeId = objvTeachingCaseResCase_BaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvTeachingCaseResCase_BaseENS.RecommendedDegreeName, //推荐度名称
ftpFileType = objvTeachingCaseResCase_BaseENS.ftpFileType, //ftp文件类型
VideoUrl = objvTeachingCaseResCase_BaseENS.VideoUrl, //视频Url
VideoPath = objvTeachingCaseResCase_BaseENS.VideoPath, //视频目录
ResErrMsg = objvTeachingCaseResCase_BaseENS.ResErrMsg, //资源错误信息
Memo = objvTeachingCaseResCase_BaseENS.Memo, //备注
OwnerName = objvTeachingCaseResCase_BaseENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvTeachingCaseResCase_BaseENS.OwnerNameWithId, //拥有者名称附Id
BrowseCount4Case = objvTeachingCaseResCase_BaseENS.BrowseCount4Case, //课例浏览次数
};
 return objvTeachingCaseResCase_BaseENT;
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
public static void CheckProperty4Condition(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN)
{
 clsvTeachingCaseResCase_BaseBL.vTeachingCaseResCase_BaseDA.CheckProperty4Condition(objvTeachingCaseResCase_BaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IdTeachingCaseResCase) == true)
{
string strComparisonOpIdTeachingCaseResCase = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.IdTeachingCaseResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.IdTeachingCaseResCase, objvTeachingCaseResCase_BaseCond.IdTeachingCaseResCase, strComparisonOpIdTeachingCaseResCase);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseID) == true)
{
string strComparisonOpTeachingCaseResCaseID = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseID, objvTeachingCaseResCase_BaseCond.TeachingCaseResCaseID, strComparisonOpTeachingCaseResCaseID);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseName) == true)
{
string strComparisonOpTeachingCaseResCaseName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseName, objvTeachingCaseResCase_BaseCond.TeachingCaseResCaseName, strComparisonOpTeachingCaseResCaseName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseTheme) == true)
{
string strComparisonOpTeachingCaseResCaseTheme = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseTheme, objvTeachingCaseResCase_BaseCond.TeachingCaseResCaseTheme, strComparisonOpTeachingCaseResCaseTheme);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseText) == true)
{
string strComparisonOpTeachingCaseResCaseText = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseText, objvTeachingCaseResCase_BaseCond.TeachingCaseResCaseText, strComparisonOpTeachingCaseResCaseText);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseDate) == true)
{
string strComparisonOpTeachingCaseResCaseDate = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseDate, objvTeachingCaseResCase_BaseCond.TeachingCaseResCaseDate, strComparisonOpTeachingCaseResCaseDate);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseTime) == true)
{
string strComparisonOpTeachingCaseResCaseTime = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseTime, objvTeachingCaseResCase_BaseCond.TeachingCaseResCaseTime, strComparisonOpTeachingCaseResCaseTime);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn) == true)
{
string strComparisonOpTeachingCaseResCaseDateIn = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn, objvTeachingCaseResCase_BaseCond.TeachingCaseResCaseDateIn, strComparisonOpTeachingCaseResCaseDateIn);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn) == true)
{
string strComparisonOpTeachingCaseResCaseTimeIn = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn, objvTeachingCaseResCase_BaseCond.TeachingCaseResCaseTimeIn, strComparisonOpTeachingCaseResCaseTimeIn);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IdTeachingCaseResCaseType) == true)
{
string strComparisonOpIdTeachingCaseResCaseType = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.IdTeachingCaseResCaseType, objvTeachingCaseResCase_BaseCond.IdTeachingCaseResCaseType, strComparisonOpIdTeachingCaseResCaseType);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName) == true)
{
string strComparisonOpTeachingCaseResCaseTypeName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName, objvTeachingCaseResCase_BaseCond.TeachingCaseResCaseTypeName, strComparisonOpTeachingCaseResCaseTypeName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CourseId) == true)
{
string strComparisonOpCourseId = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseId, objvTeachingCaseResCase_BaseCond.CourseId, strComparisonOpCourseId);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CourseCode) == true)
{
string strComparisonOpCourseCode = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseCode, objvTeachingCaseResCase_BaseCond.CourseCode, strComparisonOpCourseCode);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CourseName) == true)
{
string strComparisonOpCourseName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseName, objvTeachingCaseResCase_BaseCond.CourseName, strComparisonOpCourseName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.OwnerId) == true)
{
string strComparisonOpOwnerId = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.OwnerId, objvTeachingCaseResCase_BaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.IdStudyLevel, objvTeachingCaseResCase_BaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.StudyLevelName, objvTeachingCaseResCase_BaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.IdTeachingPlan, objvTeachingCaseResCase_BaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.IdDiscipline, objvTeachingCaseResCase_BaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.DisciplineID, objvTeachingCaseResCase_BaseCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.DisciplineName, objvTeachingCaseResCase_BaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.IdSenateGaugeVersion, objvTeachingCaseResCase_BaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.senateGaugeVersionID, objvTeachingCaseResCase_BaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.senateGaugeVersionName, objvTeachingCaseResCase_BaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.senateGaugeVersionTtlScore, objvTeachingCaseResCase_BaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.VersionNo) == true)
{
string strComparisonOpVersionNo = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.VersionNo, objvTeachingCaseResCase_BaseCond.VersionNo, strComparisonOpVersionNo);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.IdTeachSkill, objvTeachingCaseResCase_BaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachSkillID, objvTeachingCaseResCase_BaseCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.SkillTypeName, objvTeachingCaseResCase_BaseCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachSkillName, objvTeachingCaseResCase_BaseCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachSkillTheory, objvTeachingCaseResCase_BaseCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.TeachSkillOperMethod, objvTeachingCaseResCase_BaseCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.IdSkillType, objvTeachingCaseResCase_BaseCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.SkillTypeID, objvTeachingCaseResCase_BaseCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CaseLevelId, objvTeachingCaseResCase_BaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CaseLevelName, objvTeachingCaseResCase_BaseCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.DocFile) == true)
{
string strComparisonOpDocFile = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.DocFile, objvTeachingCaseResCase_BaseCond.DocFile, strComparisonOpDocFile);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IsNeedGeneWord) == true)
{
if (objvTeachingCaseResCase_BaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Base.IsNeedGeneWord);
}
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.WordCreateDate, objvTeachingCaseResCase_BaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IsVisible) == true)
{
if (objvTeachingCaseResCase_BaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Base.IsVisible);
}
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IsDualVideo) == true)
{
if (objvTeachingCaseResCase_BaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Base.IsDualVideo);
}
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.IdXzCollege, objvTeachingCaseResCase_BaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CollegeId) == true)
{
string strComparisonOpCollegeId = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CollegeId, objvTeachingCaseResCase_BaseCond.CollegeId, strComparisonOpCollegeId);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CollegeName) == true)
{
string strComparisonOpCollegeName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CollegeName, objvTeachingCaseResCase_BaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CollegeNameA, objvTeachingCaseResCase_BaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.IdXzMajor, objvTeachingCaseResCase_BaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.MajorID) == true)
{
string strComparisonOpMajorID = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.MajorID, objvTeachingCaseResCase_BaseCond.MajorID, strComparisonOpMajorID);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.MajorName) == true)
{
string strComparisonOpMajorName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.MajorName, objvTeachingCaseResCase_BaseCond.MajorName, strComparisonOpMajorName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseChapterId, objvTeachingCaseResCase_BaseCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseChapterName, objvTeachingCaseResCase_BaseCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.ParentNodeId, objvTeachingCaseResCase_BaseCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.ParentNodeName, objvTeachingCaseResCase_BaseCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.CourseChapterReferred, objvTeachingCaseResCase_BaseCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.ParentNodeReferred, objvTeachingCaseResCase_BaseCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.ViewCount) == true)
{
string strComparisonOpViewCount = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.ViewCount, objvTeachingCaseResCase_BaseCond.ViewCount, strComparisonOpViewCount);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.IsShow) == true)
{
if (objvTeachingCaseResCase_BaseCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Base.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Base.IsShow);
}
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.DownloadNumber, objvTeachingCaseResCase_BaseCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.FileIntegration, objvTeachingCaseResCase_BaseCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.LikeCount) == true)
{
string strComparisonOpLikeCount = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.LikeCount, objvTeachingCaseResCase_BaseCond.LikeCount, strComparisonOpLikeCount);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.CollectionCount, objvTeachingCaseResCase_BaseCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.RecommendedDegreeId, objvTeachingCaseResCase_BaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.RecommendedDegreeName, objvTeachingCaseResCase_BaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.ftpFileType, objvTeachingCaseResCase_BaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.VideoUrl, objvTeachingCaseResCase_BaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.VideoPath) == true)
{
string strComparisonOpVideoPath = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.VideoPath, objvTeachingCaseResCase_BaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.ResErrMsg, objvTeachingCaseResCase_BaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.Memo) == true)
{
string strComparisonOpMemo = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.Memo, objvTeachingCaseResCase_BaseCond.Memo, strComparisonOpMemo);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.OwnerName) == true)
{
string strComparisonOpOwnerName = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.OwnerName, objvTeachingCaseResCase_BaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Base.OwnerNameWithId, objvTeachingCaseResCase_BaseCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvTeachingCaseResCase_BaseCond.IsUpdated(convTeachingCaseResCase_Base.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[convTeachingCaseResCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Base.BrowseCount4Case, objvTeachingCaseResCase_BaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachingCaseResCase_Base
{
public virtual bool UpdRelaTabDate(string strIdTeachingCaseResCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教学案例资源案例_Base(vTeachingCaseResCase_Base)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingCaseResCase_BaseBL
{
public static RelatedActions_vTeachingCaseResCase_Base relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachingCaseResCase_BaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachingCaseResCase_BaseDA vTeachingCaseResCase_BaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachingCaseResCase_BaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachingCaseResCase_BaseBL()
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
if (string.IsNullOrEmpty(clsvTeachingCaseResCase_BaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCase_BaseEN._ConnectString);
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
public static DataTable GetDataTable_vTeachingCaseResCase_Base(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCase_BaseDA.GetDataTable_vTeachingCaseResCase_Base(strWhereCond);
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
objDT = vTeachingCaseResCase_BaseDA.GetDataTable(strWhereCond);
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
objDT = vTeachingCaseResCase_BaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeachingCaseResCase_BaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeachingCaseResCase_BaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeachingCaseResCase_BaseDA.GetDataTable_Top(objTopPara);
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
objDT = vTeachingCaseResCase_BaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeachingCaseResCase_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeachingCaseResCase_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstByIdTeachingCaseResCaseLst(List<string> arrIdTeachingCaseResCaseLst)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
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
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachingCaseResCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachingCaseResCase_BaseEN> GetObjLstByIdTeachingCaseResCaseLstCache(List<string> arrIdTeachingCaseResCaseLst)
{
string strKey = string.Format("{0}", clsvTeachingCaseResCase_BaseEN._CurrTabName);
List<clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Sel =
arrvTeachingCaseResCase_BaseObjLstCache
.Where(x => arrIdTeachingCaseResCaseLst.Contains(x.IdTeachingCaseResCase));
return arrvTeachingCaseResCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLst(string strWhereCond)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachingCaseResCase_BaseEN> GetSubObjLstCache(clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseCond)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCase_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingCaseResCase_Base.AttributeName)
{
if (objvTeachingCaseResCase_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingCaseResCase_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCase_BaseCond[strFldName].ToString());
}
else
{
if (objvTeachingCaseResCase_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCase_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingCaseResCase_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCase_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCase_BaseCond[strFldName]));
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
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
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeachingCaseResCase_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
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
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
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
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachingCaseResCase_Base(ref clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN)
{
bool bolResult = vTeachingCaseResCase_BaseDA.GetvTeachingCaseResCase_Base(ref objvTeachingCaseResCase_BaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCase_BaseEN GetObjByIdTeachingCaseResCase(string strIdTeachingCaseResCase)
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
clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = vTeachingCaseResCase_BaseDA.GetObjByIdTeachingCaseResCase(strIdTeachingCaseResCase);
return objvTeachingCaseResCase_BaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachingCaseResCase_BaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = vTeachingCaseResCase_BaseDA.GetFirstObj(strWhereCond);
 return objvTeachingCaseResCase_BaseEN;
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
public static clsvTeachingCaseResCase_BaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = vTeachingCaseResCase_BaseDA.GetObjByDataRow(objRow);
 return objvTeachingCaseResCase_BaseEN;
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
public static clsvTeachingCaseResCase_BaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = vTeachingCaseResCase_BaseDA.GetObjByDataRow(objRow);
 return objvTeachingCaseResCase_BaseEN;
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
 /// <param name = "lstvTeachingCaseResCase_BaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCase_BaseEN GetObjByIdTeachingCaseResCaseFromList(string strIdTeachingCaseResCase, List<clsvTeachingCaseResCase_BaseEN> lstvTeachingCaseResCase_BaseObjLst)
{
foreach (clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN in lstvTeachingCaseResCase_BaseObjLst)
{
if (objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase == strIdTeachingCaseResCase)
{
return objvTeachingCaseResCase_BaseEN;
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
 strIdTeachingCaseResCase = new clsvTeachingCaseResCase_BaseDA().GetFirstID(strWhereCond);
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
 arrList = vTeachingCaseResCase_BaseDA.GetID(strWhereCond);
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
bool bolIsExist = vTeachingCaseResCase_BaseDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vTeachingCaseResCase_BaseDA.IsExist(strIdTeachingCaseResCase);
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
 bolIsExist = clsvTeachingCaseResCase_BaseDA.IsExistTable();
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
 bolIsExist = vTeachingCaseResCase_BaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeachingCaseResCase_BaseENS">源对象</param>
 /// <param name = "objvTeachingCaseResCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseENS, clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseENT)
{
try
{
objvTeachingCaseResCase_BaseENT.IdTeachingCaseResCase = objvTeachingCaseResCase_BaseENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseID = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseName = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTheme = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseText = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseDate = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTime = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCase_BaseENT.IdTeachingCaseResCaseType = objvTeachingCaseResCase_BaseENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseENT.CourseId = objvTeachingCaseResCase_BaseENS.CourseId; //课程Id
objvTeachingCaseResCase_BaseENT.CourseCode = objvTeachingCaseResCase_BaseENS.CourseCode; //课程代码
objvTeachingCaseResCase_BaseENT.CourseName = objvTeachingCaseResCase_BaseENS.CourseName; //课程名称
objvTeachingCaseResCase_BaseENT.OwnerId = objvTeachingCaseResCase_BaseENS.OwnerId; //拥有者Id
objvTeachingCaseResCase_BaseENT.IdStudyLevel = objvTeachingCaseResCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvTeachingCaseResCase_BaseENT.StudyLevelName = objvTeachingCaseResCase_BaseENS.StudyLevelName; //学段名称
objvTeachingCaseResCase_BaseENT.IdTeachingPlan = objvTeachingCaseResCase_BaseENS.IdTeachingPlan; //教案流水号
objvTeachingCaseResCase_BaseENT.IdDiscipline = objvTeachingCaseResCase_BaseENS.IdDiscipline; //学科流水号
objvTeachingCaseResCase_BaseENT.DisciplineID = objvTeachingCaseResCase_BaseENS.DisciplineID; //学科ID
objvTeachingCaseResCase_BaseENT.DisciplineName = objvTeachingCaseResCase_BaseENS.DisciplineName; //学科名称
objvTeachingCaseResCase_BaseENT.IdSenateGaugeVersion = objvTeachingCaseResCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCase_BaseENT.senateGaugeVersionID = objvTeachingCaseResCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCase_BaseENT.senateGaugeVersionName = objvTeachingCaseResCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCase_BaseENT.senateGaugeVersionTtlScore = objvTeachingCaseResCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCase_BaseENT.VersionNo = objvTeachingCaseResCase_BaseENS.VersionNo; //版本号
objvTeachingCaseResCase_BaseENT.IdTeachSkill = objvTeachingCaseResCase_BaseENS.IdTeachSkill; //教学技能流水号
objvTeachingCaseResCase_BaseENT.TeachSkillID = objvTeachingCaseResCase_BaseENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCase_BaseENT.SkillTypeName = objvTeachingCaseResCase_BaseENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCase_BaseENT.TeachSkillName = objvTeachingCaseResCase_BaseENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCase_BaseENT.TeachSkillTheory = objvTeachingCaseResCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCase_BaseENT.TeachSkillOperMethod = objvTeachingCaseResCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCase_BaseENT.IdSkillType = objvTeachingCaseResCase_BaseENS.IdSkillType; //技能类型流水号
objvTeachingCaseResCase_BaseENT.SkillTypeID = objvTeachingCaseResCase_BaseENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCase_BaseENT.CaseLevelId = objvTeachingCaseResCase_BaseENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCase_BaseENT.CaseLevelName = objvTeachingCaseResCase_BaseENS.CaseLevelName; //案例等级名称
objvTeachingCaseResCase_BaseENT.DocFile = objvTeachingCaseResCase_BaseENS.DocFile; //生成的Word文件名
objvTeachingCaseResCase_BaseENT.IsNeedGeneWord = objvTeachingCaseResCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvTeachingCaseResCase_BaseENT.WordCreateDate = objvTeachingCaseResCase_BaseENS.WordCreateDate; //Word生成日期
objvTeachingCaseResCase_BaseENT.IsVisible = objvTeachingCaseResCase_BaseENS.IsVisible; //是否显示
objvTeachingCaseResCase_BaseENT.IsDualVideo = objvTeachingCaseResCase_BaseENS.IsDualVideo; //是否双视频
objvTeachingCaseResCase_BaseENT.IdXzCollege = objvTeachingCaseResCase_BaseENS.IdXzCollege; //学院流水号
objvTeachingCaseResCase_BaseENT.CollegeId = objvTeachingCaseResCase_BaseENS.CollegeId; //学院ID
objvTeachingCaseResCase_BaseENT.CollegeName = objvTeachingCaseResCase_BaseENS.CollegeName; //学院名称
objvTeachingCaseResCase_BaseENT.CollegeNameA = objvTeachingCaseResCase_BaseENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCase_BaseENT.IdXzMajor = objvTeachingCaseResCase_BaseENS.IdXzMajor; //专业流水号
objvTeachingCaseResCase_BaseENT.MajorID = objvTeachingCaseResCase_BaseENS.MajorID; //专业ID
objvTeachingCaseResCase_BaseENT.MajorName = objvTeachingCaseResCase_BaseENS.MajorName; //专业名称
objvTeachingCaseResCase_BaseENT.CourseChapterId = objvTeachingCaseResCase_BaseENS.CourseChapterId; //课程章节ID
objvTeachingCaseResCase_BaseENT.CourseChapterName = objvTeachingCaseResCase_BaseENS.CourseChapterName; //课程章节名称
objvTeachingCaseResCase_BaseENT.ParentNodeId = objvTeachingCaseResCase_BaseENS.ParentNodeId; //父节点编号
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
 /// <param name = "objvTeachingCaseResCase_BaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN)
{
try
{
objvTeachingCaseResCase_BaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachingCaseResCase_BaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IdTeachingCaseResCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase; //教学案例资源案例流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachingCaseResCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID; //教学案例资源案例ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachingCaseResCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName; //教学案例资源案例名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachingCaseResCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme; //教学案例资源案例主题词
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachingCaseResCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText; //案例文本内容
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachingCaseResCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate; //视频资源日期
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachingCaseResCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime; //视频资源时间
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IdTeachingCaseResCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType; //教学案例资源类型流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CourseId = objvTeachingCaseResCase_BaseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CourseCode = objvTeachingCaseResCase_BaseEN.CourseCode == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CourseName = objvTeachingCaseResCase_BaseEN.CourseName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.OwnerId = objvTeachingCaseResCase_BaseEN.OwnerId == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objvTeachingCaseResCase_BaseEN.IdStudyLevel == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.StudyLevelName = objvTeachingCaseResCase_BaseEN.StudyLevelName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objvTeachingCaseResCase_BaseEN.IdTeachingPlan == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IdDiscipline = objvTeachingCaseResCase_BaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.DisciplineID = objvTeachingCaseResCase_BaseEN.DisciplineID == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.DisciplineName = objvTeachingCaseResCase_BaseEN.DisciplineName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objvTeachingCaseResCase_BaseEN.senateGaugeVersionID == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objvTeachingCaseResCase_BaseEN.senateGaugeVersionName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.VersionNo = objvTeachingCaseResCase_BaseEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objvTeachingCaseResCase_BaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachSkillID = objvTeachingCaseResCase_BaseEN.TeachSkillID == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.SkillTypeName = objvTeachingCaseResCase_BaseEN.SkillTypeName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachSkillName = objvTeachingCaseResCase_BaseEN.TeachSkillName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objvTeachingCaseResCase_BaseEN.TeachSkillTheory == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IdSkillType = objvTeachingCaseResCase_BaseEN.IdSkillType == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.SkillTypeID = objvTeachingCaseResCase_BaseEN.SkillTypeID == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CaseLevelId = objvTeachingCaseResCase_BaseEN.CaseLevelId == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CaseLevelName = objvTeachingCaseResCase_BaseEN.CaseLevelName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.DocFile = objvTeachingCaseResCase_BaseEN.DocFile == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = objvTeachingCaseResCase_BaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.WordCreateDate = objvTeachingCaseResCase_BaseEN.WordCreateDate == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IsVisible = objvTeachingCaseResCase_BaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IsDualVideo = objvTeachingCaseResCase_BaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IdXzCollege = objvTeachingCaseResCase_BaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CollegeId = objvTeachingCaseResCase_BaseEN.CollegeId == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CollegeName = objvTeachingCaseResCase_BaseEN.CollegeName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CollegeNameA = objvTeachingCaseResCase_BaseEN.CollegeNameA == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IdXzMajor = objvTeachingCaseResCase_BaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.MajorID = objvTeachingCaseResCase_BaseEN.MajorID == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.MajorName = objvTeachingCaseResCase_BaseEN.MajorName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CourseChapterId = objvTeachingCaseResCase_BaseEN.CourseChapterId == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CourseChapterName = objvTeachingCaseResCase_BaseEN.CourseChapterName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.ParentNodeId = objvTeachingCaseResCase_BaseEN.ParentNodeId == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.ParentNodeName = objvTeachingCaseResCase_BaseEN.ParentNodeName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objvTeachingCaseResCase_BaseEN.CourseChapterReferred == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objvTeachingCaseResCase_BaseEN.ParentNodeReferred == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.ViewCount = objvTeachingCaseResCase_BaseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.IsShow = objvTeachingCaseResCase_BaseEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.DownloadNumber = objvTeachingCaseResCase_BaseEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.FileIntegration = objvTeachingCaseResCase_BaseEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.LikeCount = objvTeachingCaseResCase_BaseEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.CollectionCount = objvTeachingCaseResCase_BaseEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objvTeachingCaseResCase_BaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objvTeachingCaseResCase_BaseEN.RecommendedDegreeName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.ftpFileType = objvTeachingCaseResCase_BaseEN.ftpFileType == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.VideoUrl = objvTeachingCaseResCase_BaseEN.VideoUrl == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.VideoPath = objvTeachingCaseResCase_BaseEN.VideoPath == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.ResErrMsg = objvTeachingCaseResCase_BaseEN.ResErrMsg == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.Memo = objvTeachingCaseResCase_BaseEN.Memo == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.Memo; //备注
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.OwnerName = objvTeachingCaseResCase_BaseEN.OwnerName == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objvTeachingCaseResCase_BaseEN.OwnerNameWithId == "[null]" ? null :  objvTeachingCaseResCase_BaseEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Base.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objvTeachingCaseResCase_BaseEN.BrowseCount4Case; //课例浏览次数
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
 /// <param name = "objvTeachingCaseResCase_BaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN)
{
try
{
if (objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme == "[null]") objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = null; //教学案例资源案例主题词
if (objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText == "[null]") objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = null; //案例文本内容
if (objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate == "[null]") objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = null; //视频资源日期
if (objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime == "[null]") objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = null; //视频资源时间
if (objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn == "[null]") objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = null; //案例入库日期
if (objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn == "[null]") objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = null; //案例入库时间
if (objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName == "[null]") objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = null; //教学案例资源案例类型名称
if (objvTeachingCaseResCase_BaseEN.CourseCode == "[null]") objvTeachingCaseResCase_BaseEN.CourseCode = null; //课程代码
if (objvTeachingCaseResCase_BaseEN.CourseName == "[null]") objvTeachingCaseResCase_BaseEN.CourseName = null; //课程名称
if (objvTeachingCaseResCase_BaseEN.OwnerId == "[null]") objvTeachingCaseResCase_BaseEN.OwnerId = null; //拥有者Id
if (objvTeachingCaseResCase_BaseEN.IdStudyLevel == "[null]") objvTeachingCaseResCase_BaseEN.IdStudyLevel = null; //id_StudyLevel
if (objvTeachingCaseResCase_BaseEN.StudyLevelName == "[null]") objvTeachingCaseResCase_BaseEN.StudyLevelName = null; //学段名称
if (objvTeachingCaseResCase_BaseEN.IdTeachingPlan == "[null]") objvTeachingCaseResCase_BaseEN.IdTeachingPlan = null; //教案流水号
if (objvTeachingCaseResCase_BaseEN.DisciplineID == "[null]") objvTeachingCaseResCase_BaseEN.DisciplineID = null; //学科ID
if (objvTeachingCaseResCase_BaseEN.DisciplineName == "[null]") objvTeachingCaseResCase_BaseEN.DisciplineName = null; //学科名称
if (objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion == "[null]") objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvTeachingCaseResCase_BaseEN.senateGaugeVersionID == "[null]") objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvTeachingCaseResCase_BaseEN.senateGaugeVersionName == "[null]") objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvTeachingCaseResCase_BaseEN.TeachSkillID == "[null]") objvTeachingCaseResCase_BaseEN.TeachSkillID = null; //教学技能ID
if (objvTeachingCaseResCase_BaseEN.SkillTypeName == "[null]") objvTeachingCaseResCase_BaseEN.SkillTypeName = null; //技能类型名称
if (objvTeachingCaseResCase_BaseEN.TeachSkillName == "[null]") objvTeachingCaseResCase_BaseEN.TeachSkillName = null; //教学技能名称
if (objvTeachingCaseResCase_BaseEN.TeachSkillTheory == "[null]") objvTeachingCaseResCase_BaseEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod == "[null]") objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvTeachingCaseResCase_BaseEN.IdSkillType == "[null]") objvTeachingCaseResCase_BaseEN.IdSkillType = null; //技能类型流水号
if (objvTeachingCaseResCase_BaseEN.SkillTypeID == "[null]") objvTeachingCaseResCase_BaseEN.SkillTypeID = null; //技能类型ID
if (objvTeachingCaseResCase_BaseEN.CaseLevelId == "[null]") objvTeachingCaseResCase_BaseEN.CaseLevelId = null; //课例等级Id
if (objvTeachingCaseResCase_BaseEN.CaseLevelName == "[null]") objvTeachingCaseResCase_BaseEN.CaseLevelName = null; //案例等级名称
if (objvTeachingCaseResCase_BaseEN.DocFile == "[null]") objvTeachingCaseResCase_BaseEN.DocFile = null; //生成的Word文件名
if (objvTeachingCaseResCase_BaseEN.WordCreateDate == "[null]") objvTeachingCaseResCase_BaseEN.WordCreateDate = null; //Word生成日期
if (objvTeachingCaseResCase_BaseEN.CollegeId == "[null]") objvTeachingCaseResCase_BaseEN.CollegeId = null; //学院ID
if (objvTeachingCaseResCase_BaseEN.CollegeName == "[null]") objvTeachingCaseResCase_BaseEN.CollegeName = null; //学院名称
if (objvTeachingCaseResCase_BaseEN.CollegeNameA == "[null]") objvTeachingCaseResCase_BaseEN.CollegeNameA = null; //学院名称简写
if (objvTeachingCaseResCase_BaseEN.MajorID == "[null]") objvTeachingCaseResCase_BaseEN.MajorID = null; //专业ID
if (objvTeachingCaseResCase_BaseEN.MajorName == "[null]") objvTeachingCaseResCase_BaseEN.MajorName = null; //专业名称
if (objvTeachingCaseResCase_BaseEN.CourseChapterId == "[null]") objvTeachingCaseResCase_BaseEN.CourseChapterId = null; //课程章节ID
if (objvTeachingCaseResCase_BaseEN.CourseChapterName == "[null]") objvTeachingCaseResCase_BaseEN.CourseChapterName = null; //课程章节名称
if (objvTeachingCaseResCase_BaseEN.ParentNodeId == "[null]") objvTeachingCaseResCase_BaseEN.ParentNodeId = null; //父节点编号
if (objvTeachingCaseResCase_BaseEN.ParentNodeName == "[null]") objvTeachingCaseResCase_BaseEN.ParentNodeName = null; //父节点名称
if (objvTeachingCaseResCase_BaseEN.CourseChapterReferred == "[null]") objvTeachingCaseResCase_BaseEN.CourseChapterReferred = null; //节简称
if (objvTeachingCaseResCase_BaseEN.ParentNodeReferred == "[null]") objvTeachingCaseResCase_BaseEN.ParentNodeReferred = null; //章简称
if (objvTeachingCaseResCase_BaseEN.RecommendedDegreeName == "[null]") objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvTeachingCaseResCase_BaseEN.ftpFileType == "[null]") objvTeachingCaseResCase_BaseEN.ftpFileType = null; //ftp文件类型
if (objvTeachingCaseResCase_BaseEN.VideoUrl == "[null]") objvTeachingCaseResCase_BaseEN.VideoUrl = null; //视频Url
if (objvTeachingCaseResCase_BaseEN.VideoPath == "[null]") objvTeachingCaseResCase_BaseEN.VideoPath = null; //视频目录
if (objvTeachingCaseResCase_BaseEN.ResErrMsg == "[null]") objvTeachingCaseResCase_BaseEN.ResErrMsg = null; //资源错误信息
if (objvTeachingCaseResCase_BaseEN.Memo == "[null]") objvTeachingCaseResCase_BaseEN.Memo = null; //备注
if (objvTeachingCaseResCase_BaseEN.OwnerName == "[null]") objvTeachingCaseResCase_BaseEN.OwnerName = null; //拥有者姓名
if (objvTeachingCaseResCase_BaseEN.OwnerNameWithId == "[null]") objvTeachingCaseResCase_BaseEN.OwnerNameWithId = null; //拥有者名称附Id
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
public static void CheckProperty4Condition(clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN)
{
 vTeachingCaseResCase_BaseDA.CheckProperty4Condition(objvTeachingCaseResCase_BaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdTeachingCaseResCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convTeachingCaseResCase_Base.IdTeachingCaseResCase); 
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = clsvTeachingCaseResCase_BaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN()
{
IdTeachingCaseResCase = "0",
TeachingCaseResCaseName = "选[v教学案例资源案例_Base]..."
};
arrObjLst.Insert(0, objvTeachingCaseResCase_BaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convTeachingCaseResCase_Base.IdTeachingCaseResCase;
objComboBox.DisplayMember = convTeachingCaseResCase_Base.TeachingCaseResCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdTeachingCaseResCase(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教学案例资源案例_Base]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convTeachingCaseResCase_Base.IdTeachingCaseResCase); 
IEnumerable<clsvTeachingCaseResCase_BaseEN> arrObjLst = clsvTeachingCaseResCase_BaseBL.GetObjLst(strCondition);
objDDL.DataValueField = convTeachingCaseResCase_Base.IdTeachingCaseResCase;
objDDL.DataTextField = convTeachingCaseResCase_Base.TeachingCaseResCaseName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdTeachingCaseResCaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教学案例资源案例_Base]...","0");
List<clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst = GetAllvTeachingCaseResCase_BaseObjLstCache(); 
objDDL.DataValueField = convTeachingCaseResCase_Base.IdTeachingCaseResCase;
objDDL.DataTextField = convTeachingCaseResCase_Base.TeachingCaseResCaseName;
objDDL.DataSource = arrvTeachingCaseResCase_BaseObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
//if (arrvTeachingCaseResCase_BaseObjLstCache == null)
//{
//arrvTeachingCaseResCase_BaseObjLstCache = vTeachingCaseResCase_BaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCase_BaseEN GetObjByIdTeachingCaseResCaseCache(string strIdTeachingCaseResCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeachingCaseResCase_BaseEN._CurrTabName);
List<clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLst_Sel =
arrvTeachingCaseResCase_BaseObjLstCache
.Where(x=> x.IdTeachingCaseResCase == strIdTeachingCaseResCase 
);
if (arrvTeachingCaseResCase_BaseObjLst_Sel.Count() == 0)
{
   clsvTeachingCaseResCase_BaseEN obj = clsvTeachingCaseResCase_BaseBL.GetObjByIdTeachingCaseResCase(strIdTeachingCaseResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeachingCaseResCase_BaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeachingCaseResCaseNameByIdTeachingCaseResCaseCache(string strIdTeachingCaseResCase)
{
if (string.IsNullOrEmpty(strIdTeachingCaseResCase) == true) return "";
//获取缓存中的对象列表
clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_Base = GetObjByIdTeachingCaseResCaseCache(strIdTeachingCaseResCase);
if (objvTeachingCaseResCase_Base == null) return "";
return objvTeachingCaseResCase_Base.TeachingCaseResCaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdTeachingCaseResCaseCache(string strIdTeachingCaseResCase)
{
if (string.IsNullOrEmpty(strIdTeachingCaseResCase) == true) return "";
//获取缓存中的对象列表
clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_Base = GetObjByIdTeachingCaseResCaseCache(strIdTeachingCaseResCase);
if (objvTeachingCaseResCase_Base == null) return "";
return objvTeachingCaseResCase_Base.TeachingCaseResCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingCaseResCase_BaseEN> GetAllvTeachingCaseResCase_BaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLstCache = GetObjLstCache(); 
return arrvTeachingCaseResCase_BaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingCaseResCase_BaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingCaseResCase_BaseEN._CurrTabName);
List<clsvTeachingCaseResCase_BaseEN> arrvTeachingCaseResCase_BaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingCaseResCase_BaseObjLstCache;
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
string strKey = string.Format("{0}", clsvTeachingCaseResCase_BaseEN._CurrTabName);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdTeachingCaseResCase)
{
if (strInFldName != convTeachingCaseResCase_Base.IdTeachingCaseResCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachingCaseResCase_Base.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachingCaseResCase_Base.AttributeName));
throw new Exception(strMsg);
}
var objvTeachingCaseResCase_Base = clsvTeachingCaseResCase_BaseBL.GetObjByIdTeachingCaseResCaseCache(strIdTeachingCaseResCase);
if (objvTeachingCaseResCase_Base == null) return "";
return objvTeachingCaseResCase_Base[strOutFldName].ToString();
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
int intRecCount = clsvTeachingCaseResCase_BaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeachingCaseResCase_BaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachingCaseResCase_BaseDA.GetRecCount();
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
int intRecCount = clsvTeachingCaseResCase_BaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseCond)
{
List<clsvTeachingCaseResCase_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCase_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingCaseResCase_Base.AttributeName)
{
if (objvTeachingCaseResCase_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingCaseResCase_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCase_BaseCond[strFldName].ToString());
}
else
{
if (objvTeachingCaseResCase_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingCaseResCase_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCase_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingCaseResCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingCaseResCase_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCase_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCase_BaseCond[strFldName]));
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
 List<string> arrList = clsvTeachingCaseResCase_BaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeachingCaseResCase_BaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeachingCaseResCase_BaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}