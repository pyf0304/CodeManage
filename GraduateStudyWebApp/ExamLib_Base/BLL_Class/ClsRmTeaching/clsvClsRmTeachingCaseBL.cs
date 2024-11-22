
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCaseBL
 表名:vClsRmTeachingCase(01120382)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
public static class  clsvClsRmTeachingCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClsRmTeachingCaseEN GetObj(this K_IdClsRmTeachingCase_vClsRmTeachingCase myKey)
{
clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = clsvClsRmTeachingCaseBL.vClsRmTeachingCaseDA.GetObjByIdClsRmTeachingCase(myKey.Value);
return objvClsRmTeachingCaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdClsRmTeachingCase(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdClsRmTeachingCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdClsRmTeachingCase, 8, convClsRmTeachingCase.IdClsRmTeachingCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdClsRmTeachingCase, 8, convClsRmTeachingCase.IdClsRmTeachingCase);
}
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = strIdClsRmTeachingCase; //课堂教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdClsRmTeachingCase) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdClsRmTeachingCase, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdClsRmTeachingCase] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsRmTeachingCaseID, convClsRmTeachingCase.ClsRmTeachingCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseID, 8, convClsRmTeachingCase.ClsRmTeachingCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseID, 8, convClsRmTeachingCase.ClsRmTeachingCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsRmTeachingCaseName, convClsRmTeachingCase.ClsRmTeachingCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseName, 100, convClsRmTeachingCase.ClsRmTeachingCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseTheme(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTheme, 200, convClsRmTeachingCase.ClsRmTeachingCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdClsRmTeachingCaseType(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdClsRmTeachingCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdClsRmTeachingCaseType, convClsRmTeachingCase.IdClsRmTeachingCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdClsRmTeachingCaseType, 4, convClsRmTeachingCase.IdClsRmTeachingCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdClsRmTeachingCaseType, 4, convClsRmTeachingCase.IdClsRmTeachingCaseType);
}
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = strIdClsRmTeachingCaseType; //课堂案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdClsRmTeachingCaseType) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdClsRmTeachingCaseType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdClsRmTeachingCaseType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseTypeName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTypeName, 30, convClsRmTeachingCase.ClsRmTeachingCaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseText(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseText, 8000, convClsRmTeachingCase.ClsRmTeachingCaseText);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseDate(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDate, 8, convClsRmTeachingCase.ClsRmTeachingCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDate, 8, convClsRmTeachingCase.ClsRmTeachingCaseDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseTime(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTime, 6, convClsRmTeachingCase.ClsRmTeachingCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTime, 6, convClsRmTeachingCase.ClsRmTeachingCaseTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseDateIn(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase.ClsRmTeachingCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase.ClsRmTeachingCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetClsRmTeachingCaseTimeIn(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strClsRmTeachingCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdStudyLevel(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convClsRmTeachingCase.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convClsRmTeachingCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convClsRmTeachingCase.IdStudyLevel);
}
objvClsRmTeachingCaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdStudyLevel) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdStudyLevel, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdStudyLevel] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetStudyLevelName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convClsRmTeachingCase.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdTeachingPlan(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convClsRmTeachingCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convClsRmTeachingCase.IdTeachingPlan);
}
objvClsRmTeachingCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdTeachingPlan) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdTeachingPlan, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdTeachingPlan] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdCaseType(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convClsRmTeachingCase.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convClsRmTeachingCase.IdCaseType);
}
objvClsRmTeachingCaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdCaseType) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdCaseType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdCaseType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdDiscipline(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convClsRmTeachingCase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convClsRmTeachingCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convClsRmTeachingCase.IdDiscipline);
}
objvClsRmTeachingCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdDiscipline) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdDiscipline, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdDiscipline] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetDisciplineID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convClsRmTeachingCase.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convClsRmTeachingCase.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdSchoolPs(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdSchoolPs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchoolPs, 4, convClsRmTeachingCase.IdSchoolPs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchoolPs, 4, convClsRmTeachingCase.IdSchoolPs);
}
objvClsRmTeachingCaseEN.IdSchoolPs = strIdSchoolPs; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdSchoolPs) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdSchoolPs, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdSchoolPs] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetSchoolId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strSchoolId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convClsRmTeachingCase.SchoolId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetSchoolName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strSchoolName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convClsRmTeachingCase.SchoolName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdDisciplinePs(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdDisciplinePs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDisciplinePs, 4, convClsRmTeachingCase.IdDisciplinePs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDisciplinePs, 4, convClsRmTeachingCase.IdDisciplinePs);
}
objvClsRmTeachingCaseEN.IdDisciplinePs = strIdDisciplinePs; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdDisciplinePs) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdDisciplinePs, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdDisciplinePs] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetDisciplineName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convClsRmTeachingCase.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdGradeBase(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convClsRmTeachingCase.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convClsRmTeachingCase.IdGradeBase);
}
objvClsRmTeachingCaseEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdGradeBase) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdGradeBase, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdGradeBase] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdSenateGaugeVersion(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convClsRmTeachingCase.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convClsRmTeachingCase.IdSenateGaugeVersion);
}
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdSenateGaugeVersion) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetsenateGaugeVersionID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convClsRmTeachingCase.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convClsRmTeachingCase.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetsenateGaugeVersionName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convClsRmTeachingCase.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetsenateGaugeVersionTtlScore(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetVersionNo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, int? intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdTeachSkill(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convClsRmTeachingCase.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convClsRmTeachingCase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convClsRmTeachingCase.IdTeachSkill);
}
objvClsRmTeachingCaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdTeachSkill) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdTeachSkill, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdTeachSkill] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetTeachSkillID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convClsRmTeachingCase.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convClsRmTeachingCase.TeachSkillID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetSkillTypeName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convClsRmTeachingCase.SkillTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetTeachSkillName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convClsRmTeachingCase.TeachSkillName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetTeachSkillTheory(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convClsRmTeachingCase.TeachSkillTheory);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetTeachSkillOperMethod(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convClsRmTeachingCase.TeachSkillOperMethod);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdSkillType(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convClsRmTeachingCase.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convClsRmTeachingCase.IdSkillType);
}
objvClsRmTeachingCaseEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdSkillType) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdSkillType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdSkillType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetSkillTypeID(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convClsRmTeachingCase.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convClsRmTeachingCase.SkillTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetCaseLevelId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convClsRmTeachingCase.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convClsRmTeachingCase.CaseLevelId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetCaseLevelName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convClsRmTeachingCase.CaseLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetDocFile(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convClsRmTeachingCase.DocFile);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetWordCreateDate(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convClsRmTeachingCase.WordCreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetOwnerId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convClsRmTeachingCase.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convClsRmTeachingCase.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdStudentInfo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdStudentInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convClsRmTeachingCase.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convClsRmTeachingCase.IdStudentInfo);
}
objvClsRmTeachingCaseEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdStudentInfo) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdStudentInfo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdStudentInfo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetStuName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convClsRmTeachingCase.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetStuId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strStuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuId, 20, convClsRmTeachingCase.StuId);
}
objvClsRmTeachingCaseEN.StuId = strStuId; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.StuId) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.StuId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.StuId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetPoliticsName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strPoliticsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convClsRmTeachingCase.PoliticsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetSexDesc(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convClsRmTeachingCase.SexDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetEthnicName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strEthnicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convClsRmTeachingCase.EthnicName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetUniZoneDesc(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strUniZoneDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convClsRmTeachingCase.UniZoneDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetStuTypeDesc(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convClsRmTeachingCase.StuTypeDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdXzCollege(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convClsRmTeachingCase.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convClsRmTeachingCase.IdXzCollege);
}
objvClsRmTeachingCaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdXzCollege) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdXzCollege, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdXzCollege] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetCollegeId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convClsRmTeachingCase.CollegeId);
}
objvClsRmTeachingCaseEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.CollegeId) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.CollegeId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.CollegeId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetCollegeName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convClsRmTeachingCase.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetCollegeNameA(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convClsRmTeachingCase.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdXzMajor(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convClsRmTeachingCase.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convClsRmTeachingCase.IdXzMajor);
}
objvClsRmTeachingCaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdXzMajor) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdXzMajor, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdXzMajor] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetMajorName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convClsRmTeachingCase.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetGradeBaseName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convClsRmTeachingCase.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdAdminCls(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, convClsRmTeachingCase.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, convClsRmTeachingCase.IdAdminCls);
}
objvClsRmTeachingCaseEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdAdminCls) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdAdminCls, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdAdminCls] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetAdminClsId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strAdminClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convClsRmTeachingCase.AdminClsId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetAdminClsName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strAdminClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convClsRmTeachingCase.AdminClsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetBirthday(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, convClsRmTeachingCase.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convClsRmTeachingCase.Birthday);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetNativePlace(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strNativePlace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convClsRmTeachingCase.NativePlace);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetDuty(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strDuty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDuty, 30, convClsRmTeachingCase.Duty);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdCardNo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCardNo, 20, convClsRmTeachingCase.IdCardNo);
}
objvClsRmTeachingCaseEN.IdCardNo = strIdCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdCardNo) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdCardNo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdCardNo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetStuCardNo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strStuCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convClsRmTeachingCase.StuCardNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetLiveAddress(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strLiveAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convClsRmTeachingCase.LiveAddress);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetHomePhone(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strHomePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convClsRmTeachingCase.HomePhone);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetEnrollmentDate(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convClsRmTeachingCase.EnrollmentDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetPostCode(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strPostCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPostCode, 6, convClsRmTeachingCase.PostCode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convClsRmTeachingCase.PostCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetUserKindId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convClsRmTeachingCase.UserKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convClsRmTeachingCase.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convClsRmTeachingCase.UserKindId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetUserKindName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convClsRmTeachingCase.UserKindName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetUserTypeId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convClsRmTeachingCase.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convClsRmTeachingCase.UserTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetUserTypeName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convClsRmTeachingCase.UserTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetRecommendedDegreeId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convClsRmTeachingCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convClsRmTeachingCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convClsRmTeachingCase.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetRecommendedDegreeName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convClsRmTeachingCase.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetMemo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClsRmTeachingCase.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetDisciplineNamePs(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strDisciplineNamePs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineNamePs, 50, convClsRmTeachingCase.DisciplineNamePs);
}
objvClsRmTeachingCaseEN.DisciplineNamePs = strDisciplineNamePs; //学科
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.DisciplineNamePs) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.DisciplineNamePs, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.DisciplineNamePs] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetGradeNamePs(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strGradeNamePs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeNamePs, 50, convClsRmTeachingCase.GradeNamePs);
}
objvClsRmTeachingCaseEN.GradeNamePs = strGradeNamePs; //年级
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.GradeNamePs) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.GradeNamePs, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.GradeNamePs] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIdGradePs(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIdGradePs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradePs, 4, convClsRmTeachingCase.IdGradePs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradePs, 4, convClsRmTeachingCase.IdGradePs);
}
objvClsRmTeachingCaseEN.IdGradePs = strIdGradePs; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase.IdGradePs) == false)
{
objvClsRmTeachingCaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase.IdGradePs, strComparisonOp);
}
else
{
objvClsRmTeachingCaseEN.dicFldComparisonOp[convClsRmTeachingCase.IdGradePs] = strComparisonOp;
}
}
return objvClsRmTeachingCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetOwnerName(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convClsRmTeachingCase.OwnerName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetOwnerNameWithId(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convClsRmTeachingCase.OwnerNameWithId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetBrowseCount4Case(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetIsHaveVideo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convClsRmTeachingCase.IsHaveVideo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convClsRmTeachingCase.IsHaveVideo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCaseEN SetftpFileType(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convClsRmTeachingCase.ftpFileType);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseENS">源对象</param>
 /// <param name = "objvClsRmTeachingCaseENT">目标对象</param>
 public static void CopyTo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseENS, clsvClsRmTeachingCaseEN objvClsRmTeachingCaseENT)
{
try
{
objvClsRmTeachingCaseENT.IdClsRmTeachingCase = objvClsRmTeachingCaseENS.IdClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCaseENT.ClsRmTeachingCaseID = objvClsRmTeachingCaseENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCaseENT.ClsRmTeachingCaseName = objvClsRmTeachingCaseENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCaseENT.IdClsRmTeachingCaseType = objvClsRmTeachingCaseENS.IdClsRmTeachingCaseType; //课堂案例类型流水号
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCaseENT.ClsRmTeachingCaseText = objvClsRmTeachingCaseENS.ClsRmTeachingCaseText; //案例文本内容
objvClsRmTeachingCaseENT.ClsRmTeachingCaseDate = objvClsRmTeachingCaseENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTime = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCaseENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCaseENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCaseENT.IdStudyLevel = objvClsRmTeachingCaseENS.IdStudyLevel; //id_StudyLevel
objvClsRmTeachingCaseENT.StudyLevelName = objvClsRmTeachingCaseENS.StudyLevelName; //学段名称
objvClsRmTeachingCaseENT.IdTeachingPlan = objvClsRmTeachingCaseENS.IdTeachingPlan; //教案流水号
objvClsRmTeachingCaseENT.IdCaseType = objvClsRmTeachingCaseENS.IdCaseType; //案例类型流水号
objvClsRmTeachingCaseENT.IdDiscipline = objvClsRmTeachingCaseENS.IdDiscipline; //学科流水号
objvClsRmTeachingCaseENT.DisciplineID = objvClsRmTeachingCaseENS.DisciplineID; //学科ID
objvClsRmTeachingCaseENT.IdSchoolPs = objvClsRmTeachingCaseENS.IdSchoolPs; //学校流水号
objvClsRmTeachingCaseENT.SchoolId = objvClsRmTeachingCaseENS.SchoolId; //学校编号
objvClsRmTeachingCaseENT.SchoolName = objvClsRmTeachingCaseENS.SchoolName; //学校名称
objvClsRmTeachingCaseENT.IdDisciplinePs = objvClsRmTeachingCaseENS.IdDisciplinePs; //学科流水号
objvClsRmTeachingCaseENT.DisciplineName = objvClsRmTeachingCaseENS.DisciplineName; //学科名称
objvClsRmTeachingCaseENT.IdGradeBase = objvClsRmTeachingCaseENS.IdGradeBase; //年级流水号
objvClsRmTeachingCaseENT.IdSenateGaugeVersion = objvClsRmTeachingCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvClsRmTeachingCaseENT.senateGaugeVersionID = objvClsRmTeachingCaseENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCaseENT.senateGaugeVersionName = objvClsRmTeachingCaseENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCaseENT.senateGaugeVersionTtlScore = objvClsRmTeachingCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCaseENT.VersionNo = objvClsRmTeachingCaseENS.VersionNo; //版本号
objvClsRmTeachingCaseENT.IdTeachSkill = objvClsRmTeachingCaseENS.IdTeachSkill; //教学技能流水号
objvClsRmTeachingCaseENT.TeachSkillID = objvClsRmTeachingCaseENS.TeachSkillID; //教学技能ID
objvClsRmTeachingCaseENT.SkillTypeName = objvClsRmTeachingCaseENS.SkillTypeName; //技能类型名称
objvClsRmTeachingCaseENT.TeachSkillName = objvClsRmTeachingCaseENS.TeachSkillName; //教学技能名称
objvClsRmTeachingCaseENT.TeachSkillTheory = objvClsRmTeachingCaseENS.TeachSkillTheory; //教学技能理论阐述
objvClsRmTeachingCaseENT.TeachSkillOperMethod = objvClsRmTeachingCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvClsRmTeachingCaseENT.IdSkillType = objvClsRmTeachingCaseENS.IdSkillType; //技能类型流水号
objvClsRmTeachingCaseENT.SkillTypeID = objvClsRmTeachingCaseENS.SkillTypeID; //技能类型ID
objvClsRmTeachingCaseENT.CaseLevelId = objvClsRmTeachingCaseENS.CaseLevelId; //课例等级Id
objvClsRmTeachingCaseENT.CaseLevelName = objvClsRmTeachingCaseENS.CaseLevelName; //案例等级名称
objvClsRmTeachingCaseENT.DocFile = objvClsRmTeachingCaseENS.DocFile; //生成的Word文件名
objvClsRmTeachingCaseENT.IsNeedGeneWord = objvClsRmTeachingCaseENS.IsNeedGeneWord; //是否需要生成Word
objvClsRmTeachingCaseENT.WordCreateDate = objvClsRmTeachingCaseENS.WordCreateDate; //Word生成日期
objvClsRmTeachingCaseENT.IsVisible = objvClsRmTeachingCaseENS.IsVisible; //是否显示
objvClsRmTeachingCaseENT.OwnerId = objvClsRmTeachingCaseENS.OwnerId; //拥有者Id
objvClsRmTeachingCaseENT.IdStudentInfo = objvClsRmTeachingCaseENS.IdStudentInfo; //学生流水号
objvClsRmTeachingCaseENT.StuName = objvClsRmTeachingCaseENS.StuName; //姓名
objvClsRmTeachingCaseENT.StuId = objvClsRmTeachingCaseENS.StuId; //学号
objvClsRmTeachingCaseENT.PoliticsName = objvClsRmTeachingCaseENS.PoliticsName; //政治面貌
objvClsRmTeachingCaseENT.SexDesc = objvClsRmTeachingCaseENS.SexDesc; //性别名称
objvClsRmTeachingCaseENT.EthnicName = objvClsRmTeachingCaseENS.EthnicName; //民族名称
objvClsRmTeachingCaseENT.UniZoneDesc = objvClsRmTeachingCaseENS.UniZoneDesc; //校区名称
objvClsRmTeachingCaseENT.StuTypeDesc = objvClsRmTeachingCaseENS.StuTypeDesc; //学生类别名称
objvClsRmTeachingCaseENT.IdXzCollege = objvClsRmTeachingCaseENS.IdXzCollege; //学院流水号
objvClsRmTeachingCaseENT.CollegeId = objvClsRmTeachingCaseENS.CollegeId; //学院ID
objvClsRmTeachingCaseENT.CollegeName = objvClsRmTeachingCaseENS.CollegeName; //学院名称
objvClsRmTeachingCaseENT.CollegeNameA = objvClsRmTeachingCaseENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCaseENT.IdXzMajor = objvClsRmTeachingCaseENS.IdXzMajor; //专业流水号
objvClsRmTeachingCaseENT.MajorName = objvClsRmTeachingCaseENS.MajorName; //专业名称
objvClsRmTeachingCaseENT.GradeBaseName = objvClsRmTeachingCaseENS.GradeBaseName; //年级名称
objvClsRmTeachingCaseENT.IdAdminCls = objvClsRmTeachingCaseENS.IdAdminCls; //行政班流水号
objvClsRmTeachingCaseENT.AdminClsId = objvClsRmTeachingCaseENS.AdminClsId; //行政班代号
objvClsRmTeachingCaseENT.AdminClsName = objvClsRmTeachingCaseENS.AdminClsName; //行政班名称
objvClsRmTeachingCaseENT.Birthday = objvClsRmTeachingCaseENS.Birthday; //出生日期
objvClsRmTeachingCaseENT.NativePlace = objvClsRmTeachingCaseENS.NativePlace; //籍贯
objvClsRmTeachingCaseENT.Duty = objvClsRmTeachingCaseENS.Duty; //职位
objvClsRmTeachingCaseENT.IdCardNo = objvClsRmTeachingCaseENS.IdCardNo; //身份证号
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
objvClsRmTeachingCaseENT.DisciplineNamePs = objvClsRmTeachingCaseENS.DisciplineNamePs; //学科
objvClsRmTeachingCaseENT.GradeNamePs = objvClsRmTeachingCaseENS.GradeNamePs; //年级
objvClsRmTeachingCaseENT.IdGradePs = objvClsRmTeachingCaseENS.IdGradePs; //年级流水号
objvClsRmTeachingCaseENT.OwnerName = objvClsRmTeachingCaseENS.OwnerName; //拥有者姓名
objvClsRmTeachingCaseENT.OwnerNameWithId = objvClsRmTeachingCaseENS.OwnerNameWithId; //拥有者名称附Id
objvClsRmTeachingCaseENT.BrowseCount4Case = objvClsRmTeachingCaseENS.BrowseCount4Case; //课例浏览次数
objvClsRmTeachingCaseENT.IsHaveVideo = objvClsRmTeachingCaseENS.IsHaveVideo; //IsHaveVideo
objvClsRmTeachingCaseENT.ftpFileType = objvClsRmTeachingCaseENS.ftpFileType; //ftp文件类型
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
 /// <param name = "objvClsRmTeachingCaseENS">源对象</param>
 /// <returns>目标对象=>clsvClsRmTeachingCaseEN:objvClsRmTeachingCaseENT</returns>
 public static clsvClsRmTeachingCaseEN CopyTo(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseENS)
{
try
{
 clsvClsRmTeachingCaseEN objvClsRmTeachingCaseENT = new clsvClsRmTeachingCaseEN()
{
IdClsRmTeachingCase = objvClsRmTeachingCaseENS.IdClsRmTeachingCase, //课堂教学案例流水号
ClsRmTeachingCaseID = objvClsRmTeachingCaseENS.ClsRmTeachingCaseID, //课堂教学案例ID
ClsRmTeachingCaseName = objvClsRmTeachingCaseENS.ClsRmTeachingCaseName, //课堂教学案例名称
ClsRmTeachingCaseTheme = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTheme, //课堂教学案例主题词
IdClsRmTeachingCaseType = objvClsRmTeachingCaseENS.IdClsRmTeachingCaseType, //课堂案例类型流水号
ClsRmTeachingCaseTypeName = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTypeName, //课堂案例类型名称
ClsRmTeachingCaseText = objvClsRmTeachingCaseENS.ClsRmTeachingCaseText, //案例文本内容
ClsRmTeachingCaseDate = objvClsRmTeachingCaseENS.ClsRmTeachingCaseDate, //课堂教学日期
ClsRmTeachingCaseTime = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTime, //课堂教学时间
ClsRmTeachingCaseDateIn = objvClsRmTeachingCaseENS.ClsRmTeachingCaseDateIn, //案例入库日期
ClsRmTeachingCaseTimeIn = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTimeIn, //案例入库时间
IdStudyLevel = objvClsRmTeachingCaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvClsRmTeachingCaseENS.StudyLevelName, //学段名称
IdTeachingPlan = objvClsRmTeachingCaseENS.IdTeachingPlan, //教案流水号
IdCaseType = objvClsRmTeachingCaseENS.IdCaseType, //案例类型流水号
IdDiscipline = objvClsRmTeachingCaseENS.IdDiscipline, //学科流水号
DisciplineID = objvClsRmTeachingCaseENS.DisciplineID, //学科ID
IdSchoolPs = objvClsRmTeachingCaseENS.IdSchoolPs, //学校流水号
SchoolId = objvClsRmTeachingCaseENS.SchoolId, //学校编号
SchoolName = objvClsRmTeachingCaseENS.SchoolName, //学校名称
IdDisciplinePs = objvClsRmTeachingCaseENS.IdDisciplinePs, //学科流水号
DisciplineName = objvClsRmTeachingCaseENS.DisciplineName, //学科名称
IdGradeBase = objvClsRmTeachingCaseENS.IdGradeBase, //年级流水号
IdSenateGaugeVersion = objvClsRmTeachingCaseENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvClsRmTeachingCaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvClsRmTeachingCaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvClsRmTeachingCaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvClsRmTeachingCaseENS.VersionNo, //版本号
IdTeachSkill = objvClsRmTeachingCaseENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvClsRmTeachingCaseENS.TeachSkillID, //教学技能ID
SkillTypeName = objvClsRmTeachingCaseENS.SkillTypeName, //技能类型名称
TeachSkillName = objvClsRmTeachingCaseENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvClsRmTeachingCaseENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvClsRmTeachingCaseENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvClsRmTeachingCaseENS.IdSkillType, //技能类型流水号
SkillTypeID = objvClsRmTeachingCaseENS.SkillTypeID, //技能类型ID
CaseLevelId = objvClsRmTeachingCaseENS.CaseLevelId, //课例等级Id
CaseLevelName = objvClsRmTeachingCaseENS.CaseLevelName, //案例等级名称
DocFile = objvClsRmTeachingCaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvClsRmTeachingCaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvClsRmTeachingCaseENS.WordCreateDate, //Word生成日期
IsVisible = objvClsRmTeachingCaseENS.IsVisible, //是否显示
OwnerId = objvClsRmTeachingCaseENS.OwnerId, //拥有者Id
IdStudentInfo = objvClsRmTeachingCaseENS.IdStudentInfo, //学生流水号
StuName = objvClsRmTeachingCaseENS.StuName, //姓名
StuId = objvClsRmTeachingCaseENS.StuId, //学号
PoliticsName = objvClsRmTeachingCaseENS.PoliticsName, //政治面貌
SexDesc = objvClsRmTeachingCaseENS.SexDesc, //性别名称
EthnicName = objvClsRmTeachingCaseENS.EthnicName, //民族名称
UniZoneDesc = objvClsRmTeachingCaseENS.UniZoneDesc, //校区名称
StuTypeDesc = objvClsRmTeachingCaseENS.StuTypeDesc, //学生类别名称
IdXzCollege = objvClsRmTeachingCaseENS.IdXzCollege, //学院流水号
CollegeId = objvClsRmTeachingCaseENS.CollegeId, //学院ID
CollegeName = objvClsRmTeachingCaseENS.CollegeName, //学院名称
CollegeNameA = objvClsRmTeachingCaseENS.CollegeNameA, //学院名称简写
IdXzMajor = objvClsRmTeachingCaseENS.IdXzMajor, //专业流水号
MajorName = objvClsRmTeachingCaseENS.MajorName, //专业名称
GradeBaseName = objvClsRmTeachingCaseENS.GradeBaseName, //年级名称
IdAdminCls = objvClsRmTeachingCaseENS.IdAdminCls, //行政班流水号
AdminClsId = objvClsRmTeachingCaseENS.AdminClsId, //行政班代号
AdminClsName = objvClsRmTeachingCaseENS.AdminClsName, //行政班名称
Birthday = objvClsRmTeachingCaseENS.Birthday, //出生日期
NativePlace = objvClsRmTeachingCaseENS.NativePlace, //籍贯
Duty = objvClsRmTeachingCaseENS.Duty, //职位
IdCardNo = objvClsRmTeachingCaseENS.IdCardNo, //身份证号
StuCardNo = objvClsRmTeachingCaseENS.StuCardNo, //学生证号
LiveAddress = objvClsRmTeachingCaseENS.LiveAddress, //居住地址
HomePhone = objvClsRmTeachingCaseENS.HomePhone, //住宅电话
EnrollmentDate = objvClsRmTeachingCaseENS.EnrollmentDate, //入校日期
PostCode = objvClsRmTeachingCaseENS.PostCode, //邮编
UserKindId = objvClsRmTeachingCaseENS.UserKindId, //用户类别Id
UserKindName = objvClsRmTeachingCaseENS.UserKindName, //用户类别名
UserTypeId = objvClsRmTeachingCaseENS.UserTypeId, //用户类型Id
UserTypeName = objvClsRmTeachingCaseENS.UserTypeName, //用户类型名称
IsDualVideo = objvClsRmTeachingCaseENS.IsDualVideo, //是否双视频
RecommendedDegreeId = objvClsRmTeachingCaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvClsRmTeachingCaseENS.RecommendedDegreeName, //推荐度名称
Memo = objvClsRmTeachingCaseENS.Memo, //备注
DisciplineNamePs = objvClsRmTeachingCaseENS.DisciplineNamePs, //学科
GradeNamePs = objvClsRmTeachingCaseENS.GradeNamePs, //年级
IdGradePs = objvClsRmTeachingCaseENS.IdGradePs, //年级流水号
OwnerName = objvClsRmTeachingCaseENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvClsRmTeachingCaseENS.OwnerNameWithId, //拥有者名称附Id
BrowseCount4Case = objvClsRmTeachingCaseENS.BrowseCount4Case, //课例浏览次数
IsHaveVideo = objvClsRmTeachingCaseENS.IsHaveVideo, //IsHaveVideo
ftpFileType = objvClsRmTeachingCaseENS.ftpFileType, //ftp文件类型
};
 return objvClsRmTeachingCaseENT;
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
public static void CheckProperty4Condition(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN)
{
 clsvClsRmTeachingCaseBL.vClsRmTeachingCaseDA.CheckProperty4Condition(objvClsRmTeachingCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClsRmTeachingCaseEN objvClsRmTeachingCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdClsRmTeachingCase) == true)
{
string strComparisonOpIdClsRmTeachingCase = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdClsRmTeachingCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdClsRmTeachingCase, objvClsRmTeachingCaseCond.IdClsRmTeachingCase, strComparisonOpIdClsRmTeachingCase);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseID) == true)
{
string strComparisonOpClsRmTeachingCaseID = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseID, objvClsRmTeachingCaseCond.ClsRmTeachingCaseID, strComparisonOpClsRmTeachingCaseID);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseName) == true)
{
string strComparisonOpClsRmTeachingCaseName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseName, objvClsRmTeachingCaseCond.ClsRmTeachingCaseName, strComparisonOpClsRmTeachingCaseName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseTheme) == true)
{
string strComparisonOpClsRmTeachingCaseTheme = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseTheme, objvClsRmTeachingCaseCond.ClsRmTeachingCaseTheme, strComparisonOpClsRmTeachingCaseTheme);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdClsRmTeachingCaseType) == true)
{
string strComparisonOpIdClsRmTeachingCaseType = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdClsRmTeachingCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdClsRmTeachingCaseType, objvClsRmTeachingCaseCond.IdClsRmTeachingCaseType, strComparisonOpIdClsRmTeachingCaseType);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseTypeName) == true)
{
string strComparisonOpClsRmTeachingCaseTypeName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseTypeName, objvClsRmTeachingCaseCond.ClsRmTeachingCaseTypeName, strComparisonOpClsRmTeachingCaseTypeName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseText) == true)
{
string strComparisonOpClsRmTeachingCaseText = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseText, objvClsRmTeachingCaseCond.ClsRmTeachingCaseText, strComparisonOpClsRmTeachingCaseText);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseDate) == true)
{
string strComparisonOpClsRmTeachingCaseDate = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseDate, objvClsRmTeachingCaseCond.ClsRmTeachingCaseDate, strComparisonOpClsRmTeachingCaseDate);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseTime) == true)
{
string strComparisonOpClsRmTeachingCaseTime = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseTime, objvClsRmTeachingCaseCond.ClsRmTeachingCaseTime, strComparisonOpClsRmTeachingCaseTime);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseDateIn) == true)
{
string strComparisonOpClsRmTeachingCaseDateIn = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseDateIn, objvClsRmTeachingCaseCond.ClsRmTeachingCaseDateIn, strComparisonOpClsRmTeachingCaseDateIn);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.ClsRmTeachingCaseTimeIn) == true)
{
string strComparisonOpClsRmTeachingCaseTimeIn = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ClsRmTeachingCaseTimeIn, objvClsRmTeachingCaseCond.ClsRmTeachingCaseTimeIn, strComparisonOpClsRmTeachingCaseTimeIn);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdStudyLevel, objvClsRmTeachingCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.StudyLevelName, objvClsRmTeachingCaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdTeachingPlan, objvClsRmTeachingCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdCaseType, objvClsRmTeachingCaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdDiscipline, objvClsRmTeachingCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.DisciplineID, objvClsRmTeachingCaseCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdSchoolPs) == true)
{
string strComparisonOpIdSchoolPs = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdSchoolPs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdSchoolPs, objvClsRmTeachingCaseCond.IdSchoolPs, strComparisonOpIdSchoolPs);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.SchoolId) == true)
{
string strComparisonOpSchoolId = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.SchoolId, objvClsRmTeachingCaseCond.SchoolId, strComparisonOpSchoolId);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.SchoolName) == true)
{
string strComparisonOpSchoolName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.SchoolName, objvClsRmTeachingCaseCond.SchoolName, strComparisonOpSchoolName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdDisciplinePs) == true)
{
string strComparisonOpIdDisciplinePs = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdDisciplinePs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdDisciplinePs, objvClsRmTeachingCaseCond.IdDisciplinePs, strComparisonOpIdDisciplinePs);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.DisciplineName, objvClsRmTeachingCaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdGradeBase, objvClsRmTeachingCaseCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdSenateGaugeVersion, objvClsRmTeachingCaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.senateGaugeVersionID, objvClsRmTeachingCaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.senateGaugeVersionName, objvClsRmTeachingCaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase.senateGaugeVersionTtlScore, objvClsRmTeachingCaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.VersionNo) == true)
{
string strComparisonOpVersionNo = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase.VersionNo, objvClsRmTeachingCaseCond.VersionNo, strComparisonOpVersionNo);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdTeachSkill, objvClsRmTeachingCaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.TeachSkillID, objvClsRmTeachingCaseCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.SkillTypeName, objvClsRmTeachingCaseCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.TeachSkillName, objvClsRmTeachingCaseCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.TeachSkillTheory, objvClsRmTeachingCaseCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.TeachSkillOperMethod, objvClsRmTeachingCaseCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdSkillType, objvClsRmTeachingCaseCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.SkillTypeID, objvClsRmTeachingCaseCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.CaseLevelId, objvClsRmTeachingCaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.CaseLevelName, objvClsRmTeachingCaseCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.DocFile) == true)
{
string strComparisonOpDocFile = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.DocFile, objvClsRmTeachingCaseCond.DocFile, strComparisonOpDocFile);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IsNeedGeneWord) == true)
{
if (objvClsRmTeachingCaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase.IsNeedGeneWord);
}
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.WordCreateDate, objvClsRmTeachingCaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IsVisible) == true)
{
if (objvClsRmTeachingCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase.IsVisible);
}
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.OwnerId) == true)
{
string strComparisonOpOwnerId = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.OwnerId, objvClsRmTeachingCaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdStudentInfo, objvClsRmTeachingCaseCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.StuName) == true)
{
string strComparisonOpStuName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.StuName, objvClsRmTeachingCaseCond.StuName, strComparisonOpStuName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.StuId) == true)
{
string strComparisonOpStuId = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.StuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.StuId, objvClsRmTeachingCaseCond.StuId, strComparisonOpStuId);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.PoliticsName) == true)
{
string strComparisonOpPoliticsName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.PoliticsName, objvClsRmTeachingCaseCond.PoliticsName, strComparisonOpPoliticsName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.SexDesc) == true)
{
string strComparisonOpSexDesc = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.SexDesc, objvClsRmTeachingCaseCond.SexDesc, strComparisonOpSexDesc);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.EthnicName) == true)
{
string strComparisonOpEthnicName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.EthnicName, objvClsRmTeachingCaseCond.EthnicName, strComparisonOpEthnicName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.UniZoneDesc, objvClsRmTeachingCaseCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.StuTypeDesc) == true)
{
string strComparisonOpStuTypeDesc = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.StuTypeDesc, objvClsRmTeachingCaseCond.StuTypeDesc, strComparisonOpStuTypeDesc);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdXzCollege, objvClsRmTeachingCaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.CollegeId) == true)
{
string strComparisonOpCollegeId = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.CollegeId, objvClsRmTeachingCaseCond.CollegeId, strComparisonOpCollegeId);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.CollegeName) == true)
{
string strComparisonOpCollegeName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.CollegeName, objvClsRmTeachingCaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.CollegeNameA, objvClsRmTeachingCaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdXzMajor, objvClsRmTeachingCaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.MajorName) == true)
{
string strComparisonOpMajorName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.MajorName, objvClsRmTeachingCaseCond.MajorName, strComparisonOpMajorName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.GradeBaseName, objvClsRmTeachingCaseCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdAdminCls, objvClsRmTeachingCaseCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.AdminClsId) == true)
{
string strComparisonOpAdminClsId = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.AdminClsId, objvClsRmTeachingCaseCond.AdminClsId, strComparisonOpAdminClsId);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.AdminClsName) == true)
{
string strComparisonOpAdminClsName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.AdminClsName, objvClsRmTeachingCaseCond.AdminClsName, strComparisonOpAdminClsName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.Birthday) == true)
{
string strComparisonOpBirthday = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.Birthday, objvClsRmTeachingCaseCond.Birthday, strComparisonOpBirthday);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.NativePlace) == true)
{
string strComparisonOpNativePlace = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.NativePlace, objvClsRmTeachingCaseCond.NativePlace, strComparisonOpNativePlace);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.Duty) == true)
{
string strComparisonOpDuty = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.Duty, objvClsRmTeachingCaseCond.Duty, strComparisonOpDuty);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdCardNo) == true)
{
string strComparisonOpIdCardNo = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdCardNo, objvClsRmTeachingCaseCond.IdCardNo, strComparisonOpIdCardNo);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.StuCardNo) == true)
{
string strComparisonOpStuCardNo = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.StuCardNo, objvClsRmTeachingCaseCond.StuCardNo, strComparisonOpStuCardNo);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.LiveAddress) == true)
{
string strComparisonOpLiveAddress = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.LiveAddress, objvClsRmTeachingCaseCond.LiveAddress, strComparisonOpLiveAddress);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.HomePhone) == true)
{
string strComparisonOpHomePhone = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.HomePhone, objvClsRmTeachingCaseCond.HomePhone, strComparisonOpHomePhone);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.EnrollmentDate) == true)
{
string strComparisonOpEnrollmentDate = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.EnrollmentDate, objvClsRmTeachingCaseCond.EnrollmentDate, strComparisonOpEnrollmentDate);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.PostCode) == true)
{
string strComparisonOpPostCode = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.PostCode, objvClsRmTeachingCaseCond.PostCode, strComparisonOpPostCode);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.UserKindId) == true)
{
string strComparisonOpUserKindId = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.UserKindId, objvClsRmTeachingCaseCond.UserKindId, strComparisonOpUserKindId);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.UserKindName) == true)
{
string strComparisonOpUserKindName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.UserKindName, objvClsRmTeachingCaseCond.UserKindName, strComparisonOpUserKindName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.UserTypeId, objvClsRmTeachingCaseCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.UserTypeName, objvClsRmTeachingCaseCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IsDualVideo) == true)
{
if (objvClsRmTeachingCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase.IsDualVideo);
}
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.RecommendedDegreeId, objvClsRmTeachingCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.RecommendedDegreeName, objvClsRmTeachingCaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.Memo) == true)
{
string strComparisonOpMemo = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.Memo, objvClsRmTeachingCaseCond.Memo, strComparisonOpMemo);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.DisciplineNamePs) == true)
{
string strComparisonOpDisciplineNamePs = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.DisciplineNamePs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.DisciplineNamePs, objvClsRmTeachingCaseCond.DisciplineNamePs, strComparisonOpDisciplineNamePs);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.GradeNamePs) == true)
{
string strComparisonOpGradeNamePs = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.GradeNamePs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.GradeNamePs, objvClsRmTeachingCaseCond.GradeNamePs, strComparisonOpGradeNamePs);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IdGradePs) == true)
{
string strComparisonOpIdGradePs = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IdGradePs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IdGradePs, objvClsRmTeachingCaseCond.IdGradePs, strComparisonOpIdGradePs);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.OwnerName) == true)
{
string strComparisonOpOwnerName = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.OwnerName, objvClsRmTeachingCaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.OwnerNameWithId, objvClsRmTeachingCaseCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase.BrowseCount4Case, objvClsRmTeachingCaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.IsHaveVideo) == true)
{
string strComparisonOpIsHaveVideo = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.IsHaveVideo, objvClsRmTeachingCaseCond.IsHaveVideo, strComparisonOpIsHaveVideo);
}
if (objvClsRmTeachingCaseCond.IsUpdated(convClsRmTeachingCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvClsRmTeachingCaseCond.dicFldComparisonOp[convClsRmTeachingCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase.ftpFileType, objvClsRmTeachingCaseCond.ftpFileType, strComparisonOpftpFileType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vClsRmTeachingCase
{
public virtual bool UpdRelaTabDate(string strIdClsRmTeachingCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课堂教学案例(vClsRmTeachingCase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvClsRmTeachingCaseBL
{
public static RelatedActions_vClsRmTeachingCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvClsRmTeachingCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvClsRmTeachingCaseDA vClsRmTeachingCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvClsRmTeachingCaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvClsRmTeachingCaseBL()
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
if (string.IsNullOrEmpty(clsvClsRmTeachingCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClsRmTeachingCaseEN._ConnectString);
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
public static DataTable GetDataTable_vClsRmTeachingCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vClsRmTeachingCaseDA.GetDataTable_vClsRmTeachingCase(strWhereCond);
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
objDT = vClsRmTeachingCaseDA.GetDataTable(strWhereCond);
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
objDT = vClsRmTeachingCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vClsRmTeachingCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vClsRmTeachingCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vClsRmTeachingCaseDA.GetDataTable_Top(objTopPara);
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
objDT = vClsRmTeachingCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vClsRmTeachingCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vClsRmTeachingCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdClsRmTeachingCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvClsRmTeachingCaseEN> GetObjLstByIdClsRmTeachingCaseLst(List<string> arrIdClsRmTeachingCaseLst)
{
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdClsRmTeachingCaseLst, true);
 string strWhereCond = string.Format("IdClsRmTeachingCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdClsRmTeachingCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvClsRmTeachingCaseEN> GetObjLstByIdClsRmTeachingCaseLstCache(List<string> arrIdClsRmTeachingCaseLst)
{
string strKey = string.Format("{0}", clsvClsRmTeachingCaseEN._CurrTabName);
List<clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Sel =
arrvClsRmTeachingCaseObjLstCache
.Where(x => arrIdClsRmTeachingCaseLst.Contains(x.IdClsRmTeachingCase));
return arrvClsRmTeachingCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCaseEN> GetObjLst(string strWhereCond)
{
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCaseEN);
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
public static List<clsvClsRmTeachingCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvClsRmTeachingCaseEN> GetSubObjLstCache(clsvClsRmTeachingCaseEN objvClsRmTeachingCaseCond)
{
List<clsvClsRmTeachingCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvClsRmTeachingCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convClsRmTeachingCase.AttributeName)
{
if (objvClsRmTeachingCaseCond.IsUpdated(strFldName) == false) continue;
if (objvClsRmTeachingCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClsRmTeachingCaseCond[strFldName].ToString());
}
else
{
if (objvClsRmTeachingCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvClsRmTeachingCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClsRmTeachingCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvClsRmTeachingCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvClsRmTeachingCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvClsRmTeachingCaseCond[strFldName]));
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
public static List<clsvClsRmTeachingCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCaseEN);
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
public static List<clsvClsRmTeachingCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCaseEN);
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
List<clsvClsRmTeachingCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvClsRmTeachingCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvClsRmTeachingCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
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
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCaseEN);
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
public static List<clsvClsRmTeachingCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvClsRmTeachingCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvClsRmTeachingCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCaseEN);
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
public static List<clsvClsRmTeachingCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvClsRmTeachingCase(ref clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN)
{
bool bolResult = vClsRmTeachingCaseDA.GetvClsRmTeachingCase(ref objvClsRmTeachingCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClsRmTeachingCaseEN GetObjByIdClsRmTeachingCase(string strIdClsRmTeachingCase)
{
if (strIdClsRmTeachingCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdClsRmTeachingCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdClsRmTeachingCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdClsRmTeachingCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = vClsRmTeachingCaseDA.GetObjByIdClsRmTeachingCase(strIdClsRmTeachingCase);
return objvClsRmTeachingCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvClsRmTeachingCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = vClsRmTeachingCaseDA.GetFirstObj(strWhereCond);
 return objvClsRmTeachingCaseEN;
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
public static clsvClsRmTeachingCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = vClsRmTeachingCaseDA.GetObjByDataRow(objRow);
 return objvClsRmTeachingCaseEN;
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
public static clsvClsRmTeachingCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = vClsRmTeachingCaseDA.GetObjByDataRow(objRow);
 return objvClsRmTeachingCaseEN;
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
 /// <param name = "strIdClsRmTeachingCase">所给的关键字</param>
 /// <param name = "lstvClsRmTeachingCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClsRmTeachingCaseEN GetObjByIdClsRmTeachingCaseFromList(string strIdClsRmTeachingCase, List<clsvClsRmTeachingCaseEN> lstvClsRmTeachingCaseObjLst)
{
foreach (clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN in lstvClsRmTeachingCaseObjLst)
{
if (objvClsRmTeachingCaseEN.IdClsRmTeachingCase == strIdClsRmTeachingCase)
{
return objvClsRmTeachingCaseEN;
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
 string strIdClsRmTeachingCase;
 try
 {
 strIdClsRmTeachingCase = new clsvClsRmTeachingCaseDA().GetFirstID(strWhereCond);
 return strIdClsRmTeachingCase;
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
 arrList = vClsRmTeachingCaseDA.GetID(strWhereCond);
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
bool bolIsExist = vClsRmTeachingCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdClsRmTeachingCase)
{
if (string.IsNullOrEmpty(strIdClsRmTeachingCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdClsRmTeachingCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vClsRmTeachingCaseDA.IsExist(strIdClsRmTeachingCase);
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
 bolIsExist = clsvClsRmTeachingCaseDA.IsExistTable();
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
 bolIsExist = vClsRmTeachingCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvClsRmTeachingCaseENS">源对象</param>
 /// <param name = "objvClsRmTeachingCaseENT">目标对象</param>
 public static void CopyTo(clsvClsRmTeachingCaseEN objvClsRmTeachingCaseENS, clsvClsRmTeachingCaseEN objvClsRmTeachingCaseENT)
{
try
{
objvClsRmTeachingCaseENT.IdClsRmTeachingCase = objvClsRmTeachingCaseENS.IdClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCaseENT.ClsRmTeachingCaseID = objvClsRmTeachingCaseENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCaseENT.ClsRmTeachingCaseName = objvClsRmTeachingCaseENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCaseENT.IdClsRmTeachingCaseType = objvClsRmTeachingCaseENS.IdClsRmTeachingCaseType; //课堂案例类型流水号
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCaseENT.ClsRmTeachingCaseText = objvClsRmTeachingCaseENS.ClsRmTeachingCaseText; //案例文本内容
objvClsRmTeachingCaseENT.ClsRmTeachingCaseDate = objvClsRmTeachingCaseENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTime = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCaseENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCaseENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCaseENT.IdStudyLevel = objvClsRmTeachingCaseENS.IdStudyLevel; //id_StudyLevel
objvClsRmTeachingCaseENT.StudyLevelName = objvClsRmTeachingCaseENS.StudyLevelName; //学段名称
objvClsRmTeachingCaseENT.IdTeachingPlan = objvClsRmTeachingCaseENS.IdTeachingPlan; //教案流水号
objvClsRmTeachingCaseENT.IdCaseType = objvClsRmTeachingCaseENS.IdCaseType; //案例类型流水号
objvClsRmTeachingCaseENT.IdDiscipline = objvClsRmTeachingCaseENS.IdDiscipline; //学科流水号
objvClsRmTeachingCaseENT.DisciplineID = objvClsRmTeachingCaseENS.DisciplineID; //学科ID
objvClsRmTeachingCaseENT.IdSchoolPs = objvClsRmTeachingCaseENS.IdSchoolPs; //学校流水号
objvClsRmTeachingCaseENT.SchoolId = objvClsRmTeachingCaseENS.SchoolId; //学校编号
objvClsRmTeachingCaseENT.SchoolName = objvClsRmTeachingCaseENS.SchoolName; //学校名称
objvClsRmTeachingCaseENT.IdDisciplinePs = objvClsRmTeachingCaseENS.IdDisciplinePs; //学科流水号
objvClsRmTeachingCaseENT.DisciplineName = objvClsRmTeachingCaseENS.DisciplineName; //学科名称
objvClsRmTeachingCaseENT.IdGradeBase = objvClsRmTeachingCaseENS.IdGradeBase; //年级流水号
objvClsRmTeachingCaseENT.IdSenateGaugeVersion = objvClsRmTeachingCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvClsRmTeachingCaseENT.senateGaugeVersionID = objvClsRmTeachingCaseENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCaseENT.senateGaugeVersionName = objvClsRmTeachingCaseENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCaseENT.senateGaugeVersionTtlScore = objvClsRmTeachingCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCaseENT.VersionNo = objvClsRmTeachingCaseENS.VersionNo; //版本号
objvClsRmTeachingCaseENT.IdTeachSkill = objvClsRmTeachingCaseENS.IdTeachSkill; //教学技能流水号
objvClsRmTeachingCaseENT.TeachSkillID = objvClsRmTeachingCaseENS.TeachSkillID; //教学技能ID
objvClsRmTeachingCaseENT.SkillTypeName = objvClsRmTeachingCaseENS.SkillTypeName; //技能类型名称
objvClsRmTeachingCaseENT.TeachSkillName = objvClsRmTeachingCaseENS.TeachSkillName; //教学技能名称
objvClsRmTeachingCaseENT.TeachSkillTheory = objvClsRmTeachingCaseENS.TeachSkillTheory; //教学技能理论阐述
objvClsRmTeachingCaseENT.TeachSkillOperMethod = objvClsRmTeachingCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvClsRmTeachingCaseENT.IdSkillType = objvClsRmTeachingCaseENS.IdSkillType; //技能类型流水号
objvClsRmTeachingCaseENT.SkillTypeID = objvClsRmTeachingCaseENS.SkillTypeID; //技能类型ID
objvClsRmTeachingCaseENT.CaseLevelId = objvClsRmTeachingCaseENS.CaseLevelId; //课例等级Id
objvClsRmTeachingCaseENT.CaseLevelName = objvClsRmTeachingCaseENS.CaseLevelName; //案例等级名称
objvClsRmTeachingCaseENT.DocFile = objvClsRmTeachingCaseENS.DocFile; //生成的Word文件名
objvClsRmTeachingCaseENT.IsNeedGeneWord = objvClsRmTeachingCaseENS.IsNeedGeneWord; //是否需要生成Word
objvClsRmTeachingCaseENT.WordCreateDate = objvClsRmTeachingCaseENS.WordCreateDate; //Word生成日期
objvClsRmTeachingCaseENT.IsVisible = objvClsRmTeachingCaseENS.IsVisible; //是否显示
objvClsRmTeachingCaseENT.OwnerId = objvClsRmTeachingCaseENS.OwnerId; //拥有者Id
objvClsRmTeachingCaseENT.IdStudentInfo = objvClsRmTeachingCaseENS.IdStudentInfo; //学生流水号
objvClsRmTeachingCaseENT.StuName = objvClsRmTeachingCaseENS.StuName; //姓名
objvClsRmTeachingCaseENT.StuId = objvClsRmTeachingCaseENS.StuId; //学号
objvClsRmTeachingCaseENT.PoliticsName = objvClsRmTeachingCaseENS.PoliticsName; //政治面貌
objvClsRmTeachingCaseENT.SexDesc = objvClsRmTeachingCaseENS.SexDesc; //性别名称
objvClsRmTeachingCaseENT.EthnicName = objvClsRmTeachingCaseENS.EthnicName; //民族名称
objvClsRmTeachingCaseENT.UniZoneDesc = objvClsRmTeachingCaseENS.UniZoneDesc; //校区名称
objvClsRmTeachingCaseENT.StuTypeDesc = objvClsRmTeachingCaseENS.StuTypeDesc; //学生类别名称
objvClsRmTeachingCaseENT.IdXzCollege = objvClsRmTeachingCaseENS.IdXzCollege; //学院流水号
objvClsRmTeachingCaseENT.CollegeId = objvClsRmTeachingCaseENS.CollegeId; //学院ID
objvClsRmTeachingCaseENT.CollegeName = objvClsRmTeachingCaseENS.CollegeName; //学院名称
objvClsRmTeachingCaseENT.CollegeNameA = objvClsRmTeachingCaseENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCaseENT.IdXzMajor = objvClsRmTeachingCaseENS.IdXzMajor; //专业流水号
objvClsRmTeachingCaseENT.MajorName = objvClsRmTeachingCaseENS.MajorName; //专业名称
objvClsRmTeachingCaseENT.GradeBaseName = objvClsRmTeachingCaseENS.GradeBaseName; //年级名称
objvClsRmTeachingCaseENT.IdAdminCls = objvClsRmTeachingCaseENS.IdAdminCls; //行政班流水号
objvClsRmTeachingCaseENT.AdminClsId = objvClsRmTeachingCaseENS.AdminClsId; //行政班代号
objvClsRmTeachingCaseENT.AdminClsName = objvClsRmTeachingCaseENS.AdminClsName; //行政班名称
objvClsRmTeachingCaseENT.Birthday = objvClsRmTeachingCaseENS.Birthday; //出生日期
objvClsRmTeachingCaseENT.NativePlace = objvClsRmTeachingCaseENS.NativePlace; //籍贯
objvClsRmTeachingCaseENT.Duty = objvClsRmTeachingCaseENS.Duty; //职位
objvClsRmTeachingCaseENT.IdCardNo = objvClsRmTeachingCaseENS.IdCardNo; //身份证号
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
objvClsRmTeachingCaseENT.DisciplineNamePs = objvClsRmTeachingCaseENS.DisciplineNamePs; //学科
objvClsRmTeachingCaseENT.GradeNamePs = objvClsRmTeachingCaseENS.GradeNamePs; //年级
objvClsRmTeachingCaseENT.IdGradePs = objvClsRmTeachingCaseENS.IdGradePs; //年级流水号
objvClsRmTeachingCaseENT.OwnerName = objvClsRmTeachingCaseENS.OwnerName; //拥有者姓名
objvClsRmTeachingCaseENT.OwnerNameWithId = objvClsRmTeachingCaseENS.OwnerNameWithId; //拥有者名称附Id
objvClsRmTeachingCaseENT.BrowseCount4Case = objvClsRmTeachingCaseENS.BrowseCount4Case; //课例浏览次数
objvClsRmTeachingCaseENT.IsHaveVideo = objvClsRmTeachingCaseENS.IsHaveVideo; //IsHaveVideo
objvClsRmTeachingCaseENT.ftpFileType = objvClsRmTeachingCaseENS.ftpFileType; //ftp文件类型
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
 /// <param name = "objvClsRmTeachingCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN)
{
try
{
objvClsRmTeachingCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvClsRmTeachingCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convClsRmTeachingCase.IdClsRmTeachingCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objvClsRmTeachingCaseEN.IdClsRmTeachingCase; //课堂教学案例流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.ClsRmTeachingCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objvClsRmTeachingCaseEN.ClsRmTeachingCaseID; //课堂教学案例ID
}
if (arrFldSet.Contains(convClsRmTeachingCase.ClsRmTeachingCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objvClsRmTeachingCaseEN.ClsRmTeachingCaseName; //课堂教学案例名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.ClsRmTeachingCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme == "[null]" ? null :  objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme; //课堂教学案例主题词
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdClsRmTeachingCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType; //课堂案例类型流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.ClsRmTeachingCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName == "[null]" ? null :  objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName; //课堂案例类型名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.ClsRmTeachingCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objvClsRmTeachingCaseEN.ClsRmTeachingCaseText == "[null]" ? null :  objvClsRmTeachingCaseEN.ClsRmTeachingCaseText; //案例文本内容
}
if (arrFldSet.Contains(convClsRmTeachingCase.ClsRmTeachingCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate == "[null]" ? null :  objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate; //课堂教学日期
}
if (arrFldSet.Contains(convClsRmTeachingCase.ClsRmTeachingCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime == "[null]" ? null :  objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime; //课堂教学时间
}
if (arrFldSet.Contains(convClsRmTeachingCase.ClsRmTeachingCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn == "[null]" ? null :  objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convClsRmTeachingCase.ClsRmTeachingCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn == "[null]" ? null :  objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdStudyLevel = objvClsRmTeachingCaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convClsRmTeachingCase.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.StudyLevelName = objvClsRmTeachingCaseEN.StudyLevelName == "[null]" ? null :  objvClsRmTeachingCaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdTeachingPlan = objvClsRmTeachingCaseEN.IdTeachingPlan == "[null]" ? null :  objvClsRmTeachingCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdCaseType = objvClsRmTeachingCaseEN.IdCaseType == "[null]" ? null :  objvClsRmTeachingCaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdDiscipline = objvClsRmTeachingCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.DisciplineID = objvClsRmTeachingCaseEN.DisciplineID == "[null]" ? null :  objvClsRmTeachingCaseEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdSchoolPs, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdSchoolPs = objvClsRmTeachingCaseEN.IdSchoolPs == "[null]" ? null :  objvClsRmTeachingCaseEN.IdSchoolPs; //学校流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.SchoolId = objvClsRmTeachingCaseEN.SchoolId == "[null]" ? null :  objvClsRmTeachingCaseEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convClsRmTeachingCase.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.SchoolName = objvClsRmTeachingCaseEN.SchoolName == "[null]" ? null :  objvClsRmTeachingCaseEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdDisciplinePs, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdDisciplinePs = objvClsRmTeachingCaseEN.IdDisciplinePs == "[null]" ? null :  objvClsRmTeachingCaseEN.IdDisciplinePs; //学科流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.DisciplineName = objvClsRmTeachingCaseEN.DisciplineName == "[null]" ? null :  objvClsRmTeachingCaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdGradeBase = objvClsRmTeachingCaseEN.IdGradeBase == "[null]" ? null :  objvClsRmTeachingCaseEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objvClsRmTeachingCaseEN.IdSenateGaugeVersion == "[null]" ? null :  objvClsRmTeachingCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.senateGaugeVersionID = objvClsRmTeachingCaseEN.senateGaugeVersionID == "[null]" ? null :  objvClsRmTeachingCaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convClsRmTeachingCase.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.senateGaugeVersionName = objvClsRmTeachingCaseEN.senateGaugeVersionName == "[null]" ? null :  objvClsRmTeachingCaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convClsRmTeachingCase.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.VersionNo = objvClsRmTeachingCaseEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdTeachSkill = objvClsRmTeachingCaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.TeachSkillID = objvClsRmTeachingCaseEN.TeachSkillID == "[null]" ? null :  objvClsRmTeachingCaseEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convClsRmTeachingCase.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.SkillTypeName = objvClsRmTeachingCaseEN.SkillTypeName == "[null]" ? null :  objvClsRmTeachingCaseEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.TeachSkillName = objvClsRmTeachingCaseEN.TeachSkillName == "[null]" ? null :  objvClsRmTeachingCaseEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.TeachSkillTheory = objvClsRmTeachingCaseEN.TeachSkillTheory == "[null]" ? null :  objvClsRmTeachingCaseEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convClsRmTeachingCase.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objvClsRmTeachingCaseEN.TeachSkillOperMethod == "[null]" ? null :  objvClsRmTeachingCaseEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdSkillType = objvClsRmTeachingCaseEN.IdSkillType == "[null]" ? null :  objvClsRmTeachingCaseEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.SkillTypeID = objvClsRmTeachingCaseEN.SkillTypeID == "[null]" ? null :  objvClsRmTeachingCaseEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convClsRmTeachingCase.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.CaseLevelId = objvClsRmTeachingCaseEN.CaseLevelId == "[null]" ? null :  objvClsRmTeachingCaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convClsRmTeachingCase.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.CaseLevelName = objvClsRmTeachingCaseEN.CaseLevelName == "[null]" ? null :  objvClsRmTeachingCaseEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.DocFile = objvClsRmTeachingCaseEN.DocFile == "[null]" ? null :  objvClsRmTeachingCaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convClsRmTeachingCase.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IsNeedGeneWord = objvClsRmTeachingCaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convClsRmTeachingCase.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.WordCreateDate = objvClsRmTeachingCaseEN.WordCreateDate == "[null]" ? null :  objvClsRmTeachingCaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convClsRmTeachingCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IsVisible = objvClsRmTeachingCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convClsRmTeachingCase.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.OwnerId = objvClsRmTeachingCaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdStudentInfo = objvClsRmTeachingCaseEN.IdStudentInfo == "[null]" ? null :  objvClsRmTeachingCaseEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.StuName = objvClsRmTeachingCaseEN.StuName == "[null]" ? null :  objvClsRmTeachingCaseEN.StuName; //姓名
}
if (arrFldSet.Contains(convClsRmTeachingCase.StuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.StuId = objvClsRmTeachingCaseEN.StuId == "[null]" ? null :  objvClsRmTeachingCaseEN.StuId; //学号
}
if (arrFldSet.Contains(convClsRmTeachingCase.PoliticsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.PoliticsName = objvClsRmTeachingCaseEN.PoliticsName == "[null]" ? null :  objvClsRmTeachingCaseEN.PoliticsName; //政治面貌
}
if (arrFldSet.Contains(convClsRmTeachingCase.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.SexDesc = objvClsRmTeachingCaseEN.SexDesc == "[null]" ? null :  objvClsRmTeachingCaseEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.EthnicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.EthnicName = objvClsRmTeachingCaseEN.EthnicName == "[null]" ? null :  objvClsRmTeachingCaseEN.EthnicName; //民族名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.UniZoneDesc = objvClsRmTeachingCaseEN.UniZoneDesc == "[null]" ? null :  objvClsRmTeachingCaseEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.StuTypeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.StuTypeDesc = objvClsRmTeachingCaseEN.StuTypeDesc == "[null]" ? null :  objvClsRmTeachingCaseEN.StuTypeDesc; //学生类别名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdXzCollege = objvClsRmTeachingCaseEN.IdXzCollege == "[null]" ? null :  objvClsRmTeachingCaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.CollegeId = objvClsRmTeachingCaseEN.CollegeId == "[null]" ? null :  objvClsRmTeachingCaseEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convClsRmTeachingCase.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.CollegeName = objvClsRmTeachingCaseEN.CollegeName == "[null]" ? null :  objvClsRmTeachingCaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.CollegeNameA = objvClsRmTeachingCaseEN.CollegeNameA == "[null]" ? null :  objvClsRmTeachingCaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdXzMajor = objvClsRmTeachingCaseEN.IdXzMajor == "[null]" ? null :  objvClsRmTeachingCaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.MajorName = objvClsRmTeachingCaseEN.MajorName == "[null]" ? null :  objvClsRmTeachingCaseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.GradeBaseName = objvClsRmTeachingCaseEN.GradeBaseName == "[null]" ? null :  objvClsRmTeachingCaseEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdAdminCls = objvClsRmTeachingCaseEN.IdAdminCls == "[null]" ? null :  objvClsRmTeachingCaseEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.AdminClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.AdminClsId = objvClsRmTeachingCaseEN.AdminClsId == "[null]" ? null :  objvClsRmTeachingCaseEN.AdminClsId; //行政班代号
}
if (arrFldSet.Contains(convClsRmTeachingCase.AdminClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.AdminClsName = objvClsRmTeachingCaseEN.AdminClsName == "[null]" ? null :  objvClsRmTeachingCaseEN.AdminClsName; //行政班名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.Birthday = objvClsRmTeachingCaseEN.Birthday == "[null]" ? null :  objvClsRmTeachingCaseEN.Birthday; //出生日期
}
if (arrFldSet.Contains(convClsRmTeachingCase.NativePlace, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.NativePlace = objvClsRmTeachingCaseEN.NativePlace == "[null]" ? null :  objvClsRmTeachingCaseEN.NativePlace; //籍贯
}
if (arrFldSet.Contains(convClsRmTeachingCase.Duty, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.Duty = objvClsRmTeachingCaseEN.Duty == "[null]" ? null :  objvClsRmTeachingCaseEN.Duty; //职位
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdCardNo = objvClsRmTeachingCaseEN.IdCardNo == "[null]" ? null :  objvClsRmTeachingCaseEN.IdCardNo; //身份证号
}
if (arrFldSet.Contains(convClsRmTeachingCase.StuCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.StuCardNo = objvClsRmTeachingCaseEN.StuCardNo == "[null]" ? null :  objvClsRmTeachingCaseEN.StuCardNo; //学生证号
}
if (arrFldSet.Contains(convClsRmTeachingCase.LiveAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.LiveAddress = objvClsRmTeachingCaseEN.LiveAddress == "[null]" ? null :  objvClsRmTeachingCaseEN.LiveAddress; //居住地址
}
if (arrFldSet.Contains(convClsRmTeachingCase.HomePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.HomePhone = objvClsRmTeachingCaseEN.HomePhone == "[null]" ? null :  objvClsRmTeachingCaseEN.HomePhone; //住宅电话
}
if (arrFldSet.Contains(convClsRmTeachingCase.EnrollmentDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.EnrollmentDate = objvClsRmTeachingCaseEN.EnrollmentDate == "[null]" ? null :  objvClsRmTeachingCaseEN.EnrollmentDate; //入校日期
}
if (arrFldSet.Contains(convClsRmTeachingCase.PostCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.PostCode = objvClsRmTeachingCaseEN.PostCode == "[null]" ? null :  objvClsRmTeachingCaseEN.PostCode; //邮编
}
if (arrFldSet.Contains(convClsRmTeachingCase.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.UserKindId = objvClsRmTeachingCaseEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convClsRmTeachingCase.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.UserKindName = objvClsRmTeachingCaseEN.UserKindName == "[null]" ? null :  objvClsRmTeachingCaseEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convClsRmTeachingCase.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.UserTypeId = objvClsRmTeachingCaseEN.UserTypeId == "[null]" ? null :  objvClsRmTeachingCaseEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convClsRmTeachingCase.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.UserTypeName = objvClsRmTeachingCaseEN.UserTypeName == "[null]" ? null :  objvClsRmTeachingCaseEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IsDualVideo = objvClsRmTeachingCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convClsRmTeachingCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.RecommendedDegreeId = objvClsRmTeachingCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convClsRmTeachingCase.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.RecommendedDegreeName = objvClsRmTeachingCaseEN.RecommendedDegreeName == "[null]" ? null :  objvClsRmTeachingCaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convClsRmTeachingCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.Memo = objvClsRmTeachingCaseEN.Memo == "[null]" ? null :  objvClsRmTeachingCaseEN.Memo; //备注
}
if (arrFldSet.Contains(convClsRmTeachingCase.DisciplineNamePs, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.DisciplineNamePs = objvClsRmTeachingCaseEN.DisciplineNamePs == "[null]" ? null :  objvClsRmTeachingCaseEN.DisciplineNamePs; //学科
}
if (arrFldSet.Contains(convClsRmTeachingCase.GradeNamePs, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.GradeNamePs = objvClsRmTeachingCaseEN.GradeNamePs == "[null]" ? null :  objvClsRmTeachingCaseEN.GradeNamePs; //年级
}
if (arrFldSet.Contains(convClsRmTeachingCase.IdGradePs, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IdGradePs = objvClsRmTeachingCaseEN.IdGradePs == "[null]" ? null :  objvClsRmTeachingCaseEN.IdGradePs; //年级流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.OwnerName = objvClsRmTeachingCaseEN.OwnerName == "[null]" ? null :  objvClsRmTeachingCaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convClsRmTeachingCase.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.OwnerNameWithId = objvClsRmTeachingCaseEN.OwnerNameWithId == "[null]" ? null :  objvClsRmTeachingCaseEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convClsRmTeachingCase.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.BrowseCount4Case = objvClsRmTeachingCaseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convClsRmTeachingCase.IsHaveVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.IsHaveVideo = objvClsRmTeachingCaseEN.IsHaveVideo; //IsHaveVideo
}
if (arrFldSet.Contains(convClsRmTeachingCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCaseEN.ftpFileType = objvClsRmTeachingCaseEN.ftpFileType == "[null]" ? null :  objvClsRmTeachingCaseEN.ftpFileType; //ftp文件类型
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
 /// <param name = "objvClsRmTeachingCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN)
{
try
{
if (objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme == "[null]") objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = null; //课堂教学案例主题词
if (objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName == "[null]") objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = null; //课堂案例类型名称
if (objvClsRmTeachingCaseEN.ClsRmTeachingCaseText == "[null]") objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = null; //案例文本内容
if (objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate == "[null]") objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = null; //课堂教学日期
if (objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime == "[null]") objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = null; //课堂教学时间
if (objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn == "[null]") objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = null; //案例入库日期
if (objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn == "[null]") objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = null; //案例入库时间
if (objvClsRmTeachingCaseEN.StudyLevelName == "[null]") objvClsRmTeachingCaseEN.StudyLevelName = null; //学段名称
if (objvClsRmTeachingCaseEN.IdTeachingPlan == "[null]") objvClsRmTeachingCaseEN.IdTeachingPlan = null; //教案流水号
if (objvClsRmTeachingCaseEN.IdCaseType == "[null]") objvClsRmTeachingCaseEN.IdCaseType = null; //案例类型流水号
if (objvClsRmTeachingCaseEN.DisciplineID == "[null]") objvClsRmTeachingCaseEN.DisciplineID = null; //学科ID
if (objvClsRmTeachingCaseEN.IdSchoolPs == "[null]") objvClsRmTeachingCaseEN.IdSchoolPs = null; //学校流水号
if (objvClsRmTeachingCaseEN.SchoolId == "[null]") objvClsRmTeachingCaseEN.SchoolId = null; //学校编号
if (objvClsRmTeachingCaseEN.SchoolName == "[null]") objvClsRmTeachingCaseEN.SchoolName = null; //学校名称
if (objvClsRmTeachingCaseEN.IdDisciplinePs == "[null]") objvClsRmTeachingCaseEN.IdDisciplinePs = null; //学科流水号
if (objvClsRmTeachingCaseEN.DisciplineName == "[null]") objvClsRmTeachingCaseEN.DisciplineName = null; //学科名称
if (objvClsRmTeachingCaseEN.IdGradeBase == "[null]") objvClsRmTeachingCaseEN.IdGradeBase = null; //年级流水号
if (objvClsRmTeachingCaseEN.IdSenateGaugeVersion == "[null]") objvClsRmTeachingCaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvClsRmTeachingCaseEN.senateGaugeVersionID == "[null]") objvClsRmTeachingCaseEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvClsRmTeachingCaseEN.senateGaugeVersionName == "[null]") objvClsRmTeachingCaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvClsRmTeachingCaseEN.TeachSkillID == "[null]") objvClsRmTeachingCaseEN.TeachSkillID = null; //教学技能ID
if (objvClsRmTeachingCaseEN.SkillTypeName == "[null]") objvClsRmTeachingCaseEN.SkillTypeName = null; //技能类型名称
if (objvClsRmTeachingCaseEN.TeachSkillName == "[null]") objvClsRmTeachingCaseEN.TeachSkillName = null; //教学技能名称
if (objvClsRmTeachingCaseEN.TeachSkillTheory == "[null]") objvClsRmTeachingCaseEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvClsRmTeachingCaseEN.TeachSkillOperMethod == "[null]") objvClsRmTeachingCaseEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvClsRmTeachingCaseEN.IdSkillType == "[null]") objvClsRmTeachingCaseEN.IdSkillType = null; //技能类型流水号
if (objvClsRmTeachingCaseEN.SkillTypeID == "[null]") objvClsRmTeachingCaseEN.SkillTypeID = null; //技能类型ID
if (objvClsRmTeachingCaseEN.CaseLevelId == "[null]") objvClsRmTeachingCaseEN.CaseLevelId = null; //课例等级Id
if (objvClsRmTeachingCaseEN.CaseLevelName == "[null]") objvClsRmTeachingCaseEN.CaseLevelName = null; //案例等级名称
if (objvClsRmTeachingCaseEN.DocFile == "[null]") objvClsRmTeachingCaseEN.DocFile = null; //生成的Word文件名
if (objvClsRmTeachingCaseEN.WordCreateDate == "[null]") objvClsRmTeachingCaseEN.WordCreateDate = null; //Word生成日期
if (objvClsRmTeachingCaseEN.IdStudentInfo == "[null]") objvClsRmTeachingCaseEN.IdStudentInfo = null; //学生流水号
if (objvClsRmTeachingCaseEN.StuName == "[null]") objvClsRmTeachingCaseEN.StuName = null; //姓名
if (objvClsRmTeachingCaseEN.StuId == "[null]") objvClsRmTeachingCaseEN.StuId = null; //学号
if (objvClsRmTeachingCaseEN.PoliticsName == "[null]") objvClsRmTeachingCaseEN.PoliticsName = null; //政治面貌
if (objvClsRmTeachingCaseEN.SexDesc == "[null]") objvClsRmTeachingCaseEN.SexDesc = null; //性别名称
if (objvClsRmTeachingCaseEN.EthnicName == "[null]") objvClsRmTeachingCaseEN.EthnicName = null; //民族名称
if (objvClsRmTeachingCaseEN.UniZoneDesc == "[null]") objvClsRmTeachingCaseEN.UniZoneDesc = null; //校区名称
if (objvClsRmTeachingCaseEN.StuTypeDesc == "[null]") objvClsRmTeachingCaseEN.StuTypeDesc = null; //学生类别名称
if (objvClsRmTeachingCaseEN.IdXzCollege == "[null]") objvClsRmTeachingCaseEN.IdXzCollege = null; //学院流水号
if (objvClsRmTeachingCaseEN.CollegeId == "[null]") objvClsRmTeachingCaseEN.CollegeId = null; //学院ID
if (objvClsRmTeachingCaseEN.CollegeName == "[null]") objvClsRmTeachingCaseEN.CollegeName = null; //学院名称
if (objvClsRmTeachingCaseEN.CollegeNameA == "[null]") objvClsRmTeachingCaseEN.CollegeNameA = null; //学院名称简写
if (objvClsRmTeachingCaseEN.IdXzMajor == "[null]") objvClsRmTeachingCaseEN.IdXzMajor = null; //专业流水号
if (objvClsRmTeachingCaseEN.MajorName == "[null]") objvClsRmTeachingCaseEN.MajorName = null; //专业名称
if (objvClsRmTeachingCaseEN.GradeBaseName == "[null]") objvClsRmTeachingCaseEN.GradeBaseName = null; //年级名称
if (objvClsRmTeachingCaseEN.IdAdminCls == "[null]") objvClsRmTeachingCaseEN.IdAdminCls = null; //行政班流水号
if (objvClsRmTeachingCaseEN.AdminClsId == "[null]") objvClsRmTeachingCaseEN.AdminClsId = null; //行政班代号
if (objvClsRmTeachingCaseEN.AdminClsName == "[null]") objvClsRmTeachingCaseEN.AdminClsName = null; //行政班名称
if (objvClsRmTeachingCaseEN.Birthday == "[null]") objvClsRmTeachingCaseEN.Birthday = null; //出生日期
if (objvClsRmTeachingCaseEN.NativePlace == "[null]") objvClsRmTeachingCaseEN.NativePlace = null; //籍贯
if (objvClsRmTeachingCaseEN.Duty == "[null]") objvClsRmTeachingCaseEN.Duty = null; //职位
if (objvClsRmTeachingCaseEN.IdCardNo == "[null]") objvClsRmTeachingCaseEN.IdCardNo = null; //身份证号
if (objvClsRmTeachingCaseEN.StuCardNo == "[null]") objvClsRmTeachingCaseEN.StuCardNo = null; //学生证号
if (objvClsRmTeachingCaseEN.LiveAddress == "[null]") objvClsRmTeachingCaseEN.LiveAddress = null; //居住地址
if (objvClsRmTeachingCaseEN.HomePhone == "[null]") objvClsRmTeachingCaseEN.HomePhone = null; //住宅电话
if (objvClsRmTeachingCaseEN.EnrollmentDate == "[null]") objvClsRmTeachingCaseEN.EnrollmentDate = null; //入校日期
if (objvClsRmTeachingCaseEN.PostCode == "[null]") objvClsRmTeachingCaseEN.PostCode = null; //邮编
if (objvClsRmTeachingCaseEN.UserKindName == "[null]") objvClsRmTeachingCaseEN.UserKindName = null; //用户类别名
if (objvClsRmTeachingCaseEN.UserTypeId == "[null]") objvClsRmTeachingCaseEN.UserTypeId = null; //用户类型Id
if (objvClsRmTeachingCaseEN.UserTypeName == "[null]") objvClsRmTeachingCaseEN.UserTypeName = null; //用户类型名称
if (objvClsRmTeachingCaseEN.RecommendedDegreeName == "[null]") objvClsRmTeachingCaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvClsRmTeachingCaseEN.Memo == "[null]") objvClsRmTeachingCaseEN.Memo = null; //备注
if (objvClsRmTeachingCaseEN.DisciplineNamePs == "[null]") objvClsRmTeachingCaseEN.DisciplineNamePs = null; //学科
if (objvClsRmTeachingCaseEN.GradeNamePs == "[null]") objvClsRmTeachingCaseEN.GradeNamePs = null; //年级
if (objvClsRmTeachingCaseEN.IdGradePs == "[null]") objvClsRmTeachingCaseEN.IdGradePs = null; //年级流水号
if (objvClsRmTeachingCaseEN.OwnerName == "[null]") objvClsRmTeachingCaseEN.OwnerName = null; //拥有者姓名
if (objvClsRmTeachingCaseEN.OwnerNameWithId == "[null]") objvClsRmTeachingCaseEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvClsRmTeachingCaseEN.ftpFileType == "[null]") objvClsRmTeachingCaseEN.ftpFileType = null; //ftp文件类型
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
public static void CheckProperty4Condition(clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN)
{
 vClsRmTeachingCaseDA.CheckProperty4Condition(objvClsRmTeachingCaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdClsRmTeachingCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convClsRmTeachingCase.IdClsRmTeachingCase); 
List<clsvClsRmTeachingCaseEN> arrObjLst = clsvClsRmTeachingCaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN()
{
IdClsRmTeachingCase = "0",
ClsRmTeachingCaseName = "选[v课堂教学案例]..."
};
arrObjLst.Insert(0, objvClsRmTeachingCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convClsRmTeachingCase.IdClsRmTeachingCase;
objComboBox.DisplayMember = convClsRmTeachingCase.ClsRmTeachingCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdClsRmTeachingCase(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课堂教学案例]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convClsRmTeachingCase.IdClsRmTeachingCase); 
IEnumerable<clsvClsRmTeachingCaseEN> arrObjLst = clsvClsRmTeachingCaseBL.GetObjLst(strCondition);
objDDL.DataValueField = convClsRmTeachingCase.IdClsRmTeachingCase;
objDDL.DataTextField = convClsRmTeachingCase.ClsRmTeachingCaseName;
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
public static void BindDdl_IdClsRmTeachingCaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课堂教学案例]...","0");
List<clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst = GetAllvClsRmTeachingCaseObjLstCache(); 
objDDL.DataValueField = convClsRmTeachingCase.IdClsRmTeachingCase;
objDDL.DataTextField = convClsRmTeachingCase.ClsRmTeachingCaseName;
objDDL.DataSource = arrvClsRmTeachingCaseObjLst;
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
if (clsDiscipline_psBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psBL没有刷新缓存机制(clsDiscipline_psBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsBL没有刷新缓存机制(clsXzSchool_PsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindBL没有刷新缓存机制(clsUserKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGrade_psBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGrade_psBL没有刷新缓存机制(clsXzGrade_psBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClsRmTeachingCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClsRmTeachingCaseBL没有刷新缓存机制(clsClsRmTeachingCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClsRmTeachingCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClsRmTeachingCaseTypeBL没有刷新缓存机制(clsClsRmTeachingCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdClsRmTeachingCase");
//if (arrvClsRmTeachingCaseObjLstCache == null)
//{
//arrvClsRmTeachingCaseObjLstCache = vClsRmTeachingCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClsRmTeachingCaseEN GetObjByIdClsRmTeachingCaseCache(string strIdClsRmTeachingCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvClsRmTeachingCaseEN._CurrTabName);
List<clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLst_Sel =
arrvClsRmTeachingCaseObjLstCache
.Where(x=> x.IdClsRmTeachingCase == strIdClsRmTeachingCase 
);
if (arrvClsRmTeachingCaseObjLst_Sel.Count() == 0)
{
   clsvClsRmTeachingCaseEN obj = clsvClsRmTeachingCaseBL.GetObjByIdClsRmTeachingCase(strIdClsRmTeachingCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvClsRmTeachingCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetClsRmTeachingCaseNameByIdClsRmTeachingCaseCache(string strIdClsRmTeachingCase)
{
if (string.IsNullOrEmpty(strIdClsRmTeachingCase) == true) return "";
//获取缓存中的对象列表
clsvClsRmTeachingCaseEN objvClsRmTeachingCase = GetObjByIdClsRmTeachingCaseCache(strIdClsRmTeachingCase);
if (objvClsRmTeachingCase == null) return "";
return objvClsRmTeachingCase.ClsRmTeachingCaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdClsRmTeachingCaseCache(string strIdClsRmTeachingCase)
{
if (string.IsNullOrEmpty(strIdClsRmTeachingCase) == true) return "";
//获取缓存中的对象列表
clsvClsRmTeachingCaseEN objvClsRmTeachingCase = GetObjByIdClsRmTeachingCaseCache(strIdClsRmTeachingCase);
if (objvClsRmTeachingCase == null) return "";
return objvClsRmTeachingCase.ClsRmTeachingCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvClsRmTeachingCaseEN> GetAllvClsRmTeachingCaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLstCache = GetObjLstCache(); 
return arrvClsRmTeachingCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvClsRmTeachingCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvClsRmTeachingCaseEN._CurrTabName);
List<clsvClsRmTeachingCaseEN> arrvClsRmTeachingCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClsRmTeachingCaseObjLstCache;
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
string strKey = string.Format("{0}", clsvClsRmTeachingCaseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdClsRmTeachingCase)
{
if (strInFldName != convClsRmTeachingCase.IdClsRmTeachingCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convClsRmTeachingCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convClsRmTeachingCase.AttributeName));
throw new Exception(strMsg);
}
var objvClsRmTeachingCase = clsvClsRmTeachingCaseBL.GetObjByIdClsRmTeachingCaseCache(strIdClsRmTeachingCase);
if (objvClsRmTeachingCase == null) return "";
return objvClsRmTeachingCase[strOutFldName].ToString();
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
int intRecCount = clsvClsRmTeachingCaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvClsRmTeachingCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvClsRmTeachingCaseDA.GetRecCount();
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
int intRecCount = clsvClsRmTeachingCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvClsRmTeachingCaseEN objvClsRmTeachingCaseCond)
{
List<clsvClsRmTeachingCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvClsRmTeachingCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convClsRmTeachingCase.AttributeName)
{
if (objvClsRmTeachingCaseCond.IsUpdated(strFldName) == false) continue;
if (objvClsRmTeachingCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClsRmTeachingCaseCond[strFldName].ToString());
}
else
{
if (objvClsRmTeachingCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvClsRmTeachingCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClsRmTeachingCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvClsRmTeachingCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvClsRmTeachingCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvClsRmTeachingCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvClsRmTeachingCaseCond[strFldName]));
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
 List<string> arrList = clsvClsRmTeachingCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vClsRmTeachingCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vClsRmTeachingCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}