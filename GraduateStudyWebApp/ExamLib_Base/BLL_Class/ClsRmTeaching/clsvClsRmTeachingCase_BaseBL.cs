
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCase_BaseBL
 表名:vClsRmTeachingCase_Base(01120488)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:58
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
public static class  clsvClsRmTeachingCase_BaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClsRmTeachingCase_BaseEN GetObj(this K_IdClsRmTeachingCase_vClsRmTeachingCase_Base myKey)
{
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = clsvClsRmTeachingCase_BaseBL.vClsRmTeachingCase_BaseDA.GetObjByIdClsRmTeachingCase(myKey.Value);
return objvClsRmTeachingCase_BaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdClsRmTeachingCase(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdClsRmTeachingCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdClsRmTeachingCase, 8, convClsRmTeachingCase_Base.IdClsRmTeachingCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdClsRmTeachingCase, 8, convClsRmTeachingCase_Base.IdClsRmTeachingCase);
}
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = strIdClsRmTeachingCase; //课堂教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdClsRmTeachingCase) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdClsRmTeachingCase, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdClsRmTeachingCase] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsRmTeachingCaseID, convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseID, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseID, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsRmTeachingCaseName, convClsRmTeachingCase_Base.ClsRmTeachingCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseName, 100, convClsRmTeachingCase_Base.ClsRmTeachingCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseTheme(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTheme, 200, convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdClsRmTeachingCaseType(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdClsRmTeachingCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdClsRmTeachingCaseType, convClsRmTeachingCase_Base.IdClsRmTeachingCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdClsRmTeachingCaseType, 4, convClsRmTeachingCase_Base.IdClsRmTeachingCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdClsRmTeachingCaseType, 4, convClsRmTeachingCase_Base.IdClsRmTeachingCaseType);
}
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = strIdClsRmTeachingCaseType; //课堂案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdClsRmTeachingCaseType) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdClsRmTeachingCaseType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseTypeName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTypeName, 30, convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseText(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseText, 8000, convClsRmTeachingCase_Base.ClsRmTeachingCaseText);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseDate(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDate, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDate, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseTime(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTime, 6, convClsRmTeachingCase_Base.ClsRmTeachingCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTime, 6, convClsRmTeachingCase_Base.ClsRmTeachingCaseTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseDateIn(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetClsRmTeachingCaseTimeIn(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strClsRmTeachingCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdStudyLevel(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convClsRmTeachingCase_Base.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convClsRmTeachingCase_Base.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convClsRmTeachingCase_Base.IdStudyLevel);
}
objvClsRmTeachingCase_BaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdStudyLevel) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdStudyLevel, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdStudyLevel] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetStudyLevelName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convClsRmTeachingCase_Base.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdTeachingPlan(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convClsRmTeachingCase_Base.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convClsRmTeachingCase_Base.IdTeachingPlan);
}
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdTeachingPlan) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdTeachingPlan, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdTeachingPlan] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdCaseType(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convClsRmTeachingCase_Base.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convClsRmTeachingCase_Base.IdCaseType);
}
objvClsRmTeachingCase_BaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdCaseType) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdCaseType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdCaseType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdDiscipline(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convClsRmTeachingCase_Base.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convClsRmTeachingCase_Base.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convClsRmTeachingCase_Base.IdDiscipline);
}
objvClsRmTeachingCase_BaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdDiscipline) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdDiscipline, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdDiscipline] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetDisciplineID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convClsRmTeachingCase_Base.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convClsRmTeachingCase_Base.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdSchoolPs(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdSchoolPs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchoolPs, 4, convClsRmTeachingCase_Base.IdSchoolPs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchoolPs, 4, convClsRmTeachingCase_Base.IdSchoolPs);
}
objvClsRmTeachingCase_BaseEN.IdSchoolPs = strIdSchoolPs; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdSchoolPs) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdSchoolPs, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdSchoolPs] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetSchoolId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strSchoolId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convClsRmTeachingCase_Base.SchoolId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetSchoolName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strSchoolName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convClsRmTeachingCase_Base.SchoolName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdDisciplinePs(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdDisciplinePs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDisciplinePs, 4, convClsRmTeachingCase_Base.IdDisciplinePs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDisciplinePs, 4, convClsRmTeachingCase_Base.IdDisciplinePs);
}
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = strIdDisciplinePs; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdDisciplinePs) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdDisciplinePs, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdDisciplinePs] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetDisciplineName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convClsRmTeachingCase_Base.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdGradeBase(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convClsRmTeachingCase_Base.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convClsRmTeachingCase_Base.IdGradeBase);
}
objvClsRmTeachingCase_BaseEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdGradeBase) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdGradeBase, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdGradeBase] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdSenateGaugeVersion(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convClsRmTeachingCase_Base.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convClsRmTeachingCase_Base.IdSenateGaugeVersion);
}
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdSenateGaugeVersion) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetsenateGaugeVersionID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convClsRmTeachingCase_Base.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convClsRmTeachingCase_Base.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetsenateGaugeVersionName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convClsRmTeachingCase_Base.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetVersionNo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, int? intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdTeachSkill(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convClsRmTeachingCase_Base.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convClsRmTeachingCase_Base.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convClsRmTeachingCase_Base.IdTeachSkill);
}
objvClsRmTeachingCase_BaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdTeachSkill) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdTeachSkill, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdTeachSkill] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetTeachSkillID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convClsRmTeachingCase_Base.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convClsRmTeachingCase_Base.TeachSkillID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetSkillTypeName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convClsRmTeachingCase_Base.SkillTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetTeachSkillName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convClsRmTeachingCase_Base.TeachSkillName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetTeachSkillTheory(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convClsRmTeachingCase_Base.TeachSkillTheory);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetTeachSkillOperMethod(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convClsRmTeachingCase_Base.TeachSkillOperMethod);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdSkillType(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convClsRmTeachingCase_Base.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convClsRmTeachingCase_Base.IdSkillType);
}
objvClsRmTeachingCase_BaseEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdSkillType) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdSkillType, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdSkillType] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetSkillTypeID(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convClsRmTeachingCase_Base.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convClsRmTeachingCase_Base.SkillTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCaseLevelId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convClsRmTeachingCase_Base.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convClsRmTeachingCase_Base.CaseLevelId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCaseLevelName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convClsRmTeachingCase_Base.CaseLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetDocFile(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convClsRmTeachingCase_Base.DocFile);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetWordCreateDate(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convClsRmTeachingCase_Base.WordCreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetOwnerId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convClsRmTeachingCase_Base.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convClsRmTeachingCase_Base.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdStudentInfo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdStudentInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convClsRmTeachingCase_Base.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convClsRmTeachingCase_Base.IdStudentInfo);
}
objvClsRmTeachingCase_BaseEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdStudentInfo) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdStudentInfo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdStudentInfo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetStuName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convClsRmTeachingCase_Base.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetStuId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strStuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuId, 20, convClsRmTeachingCase_Base.StuId);
}
objvClsRmTeachingCase_BaseEN.StuId = strStuId; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.StuId) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.StuId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.StuId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetPoliticsName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strPoliticsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convClsRmTeachingCase_Base.PoliticsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetSexDesc(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convClsRmTeachingCase_Base.SexDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetEthnicName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strEthnicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convClsRmTeachingCase_Base.EthnicName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetUniZoneDesc(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strUniZoneDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convClsRmTeachingCase_Base.UniZoneDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetStuTypeDesc(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convClsRmTeachingCase_Base.StuTypeDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdXzCollege(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convClsRmTeachingCase_Base.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convClsRmTeachingCase_Base.IdXzCollege);
}
objvClsRmTeachingCase_BaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdXzCollege) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdXzCollege, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdXzCollege] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCollegeId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convClsRmTeachingCase_Base.CollegeId);
}
objvClsRmTeachingCase_BaseEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.CollegeId) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.CollegeId, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.CollegeId] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCollegeName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convClsRmTeachingCase_Base.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCollegeNameA(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convClsRmTeachingCase_Base.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdXzMajor(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convClsRmTeachingCase_Base.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convClsRmTeachingCase_Base.IdXzMajor);
}
objvClsRmTeachingCase_BaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdXzMajor) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdXzMajor, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdXzMajor] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetMajorName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convClsRmTeachingCase_Base.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetGradeBaseName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convClsRmTeachingCase_Base.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdAdminCls(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, convClsRmTeachingCase_Base.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, convClsRmTeachingCase_Base.IdAdminCls);
}
objvClsRmTeachingCase_BaseEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdAdminCls) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdAdminCls, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdAdminCls] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetAdminClsId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strAdminClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convClsRmTeachingCase_Base.AdminClsId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetAdminClsName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strAdminClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convClsRmTeachingCase_Base.AdminClsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetBirthday(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, convClsRmTeachingCase_Base.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convClsRmTeachingCase_Base.Birthday);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetNativePlace(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strNativePlace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convClsRmTeachingCase_Base.NativePlace);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetDuty(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strDuty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDuty, 30, convClsRmTeachingCase_Base.Duty);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdCardNo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCardNo, 20, convClsRmTeachingCase_Base.IdCardNo);
}
objvClsRmTeachingCase_BaseEN.IdCardNo = strIdCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdCardNo) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdCardNo, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdCardNo] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetStuCardNo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strStuCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convClsRmTeachingCase_Base.StuCardNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetLiveAddress(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strLiveAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convClsRmTeachingCase_Base.LiveAddress);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetHomePhone(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strHomePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convClsRmTeachingCase_Base.HomePhone);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetEnrollmentDate(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convClsRmTeachingCase_Base.EnrollmentDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetPostCode(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strPostCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPostCode, 6, convClsRmTeachingCase_Base.PostCode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convClsRmTeachingCase_Base.PostCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetUserKindId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convClsRmTeachingCase_Base.UserKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convClsRmTeachingCase_Base.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convClsRmTeachingCase_Base.UserKindId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetUserKindName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convClsRmTeachingCase_Base.UserKindName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetUserTypeId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convClsRmTeachingCase_Base.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convClsRmTeachingCase_Base.UserTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetRecommendedDegreeId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convClsRmTeachingCase_Base.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convClsRmTeachingCase_Base.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convClsRmTeachingCase_Base.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetRecommendedDegreeName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convClsRmTeachingCase_Base.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetMemo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClsRmTeachingCase_Base.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetDisciplineNamePs(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strDisciplineNamePs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineNamePs, 50, convClsRmTeachingCase_Base.DisciplineNamePs);
}
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = strDisciplineNamePs; //学科
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.DisciplineNamePs) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.DisciplineNamePs, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.DisciplineNamePs] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetGradeNamePs(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strGradeNamePs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeNamePs, 50, convClsRmTeachingCase_Base.GradeNamePs);
}
objvClsRmTeachingCase_BaseEN.GradeNamePs = strGradeNamePs; //年级
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.GradeNamePs) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.GradeNamePs, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.GradeNamePs] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetIdGradePs(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strIdGradePs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradePs, 4, convClsRmTeachingCase_Base.IdGradePs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradePs, 4, convClsRmTeachingCase_Base.IdGradePs);
}
objvClsRmTeachingCase_BaseEN.IdGradePs = strIdGradePs; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCase_Base.IdGradePs) == false)
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp.Add(convClsRmTeachingCase_Base.IdGradePs, strComparisonOp);
}
else
{
objvClsRmTeachingCase_BaseEN.dicFldComparisonOp[convClsRmTeachingCase_Base.IdGradePs] = strComparisonOp;
}
}
return objvClsRmTeachingCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetOwnerName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convClsRmTeachingCase_Base.OwnerName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetOwnerNameWithId(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convClsRmTeachingCase_Base.OwnerNameWithId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetBrowseCount4Case(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetCaseTypeName(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTypeName, 50, convClsRmTeachingCase_Base.CaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClsRmTeachingCase_BaseEN SetftpFileType(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convClsRmTeachingCase_Base.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseENS">源对象</param>
 /// <param name = "objvClsRmTeachingCase_BaseENT">目标对象</param>
 public static void CopyTo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENS, clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENT)
{
try
{
objvClsRmTeachingCase_BaseENT.IdClsRmTeachingCase = objvClsRmTeachingCase_BaseENS.IdClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseID = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseName = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCase_BaseENT.IdClsRmTeachingCaseType = objvClsRmTeachingCase_BaseENS.IdClsRmTeachingCaseType; //课堂案例类型流水号
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseText = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseText; //案例文本内容
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseDate = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTime = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCase_BaseENT.IdStudyLevel = objvClsRmTeachingCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvClsRmTeachingCase_BaseENT.StudyLevelName = objvClsRmTeachingCase_BaseENS.StudyLevelName; //学段名称
objvClsRmTeachingCase_BaseENT.IdTeachingPlan = objvClsRmTeachingCase_BaseENS.IdTeachingPlan; //教案流水号
objvClsRmTeachingCase_BaseENT.IdCaseType = objvClsRmTeachingCase_BaseENS.IdCaseType; //案例类型流水号
objvClsRmTeachingCase_BaseENT.IdDiscipline = objvClsRmTeachingCase_BaseENS.IdDiscipline; //学科流水号
objvClsRmTeachingCase_BaseENT.DisciplineID = objvClsRmTeachingCase_BaseENS.DisciplineID; //学科ID
objvClsRmTeachingCase_BaseENT.IdSchoolPs = objvClsRmTeachingCase_BaseENS.IdSchoolPs; //学校流水号
objvClsRmTeachingCase_BaseENT.SchoolId = objvClsRmTeachingCase_BaseENS.SchoolId; //学校编号
objvClsRmTeachingCase_BaseENT.SchoolName = objvClsRmTeachingCase_BaseENS.SchoolName; //学校名称
objvClsRmTeachingCase_BaseENT.IdDisciplinePs = objvClsRmTeachingCase_BaseENS.IdDisciplinePs; //学科流水号
objvClsRmTeachingCase_BaseENT.DisciplineName = objvClsRmTeachingCase_BaseENS.DisciplineName; //学科名称
objvClsRmTeachingCase_BaseENT.IdGradeBase = objvClsRmTeachingCase_BaseENS.IdGradeBase; //年级流水号
objvClsRmTeachingCase_BaseENT.IdSenateGaugeVersion = objvClsRmTeachingCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvClsRmTeachingCase_BaseENT.senateGaugeVersionID = objvClsRmTeachingCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCase_BaseENT.senateGaugeVersionName = objvClsRmTeachingCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCase_BaseENT.senateGaugeVersionTtlScore = objvClsRmTeachingCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCase_BaseENT.VersionNo = objvClsRmTeachingCase_BaseENS.VersionNo; //版本号
objvClsRmTeachingCase_BaseENT.IdTeachSkill = objvClsRmTeachingCase_BaseENS.IdTeachSkill; //教学技能流水号
objvClsRmTeachingCase_BaseENT.TeachSkillID = objvClsRmTeachingCase_BaseENS.TeachSkillID; //教学技能ID
objvClsRmTeachingCase_BaseENT.SkillTypeName = objvClsRmTeachingCase_BaseENS.SkillTypeName; //技能类型名称
objvClsRmTeachingCase_BaseENT.TeachSkillName = objvClsRmTeachingCase_BaseENS.TeachSkillName; //教学技能名称
objvClsRmTeachingCase_BaseENT.TeachSkillTheory = objvClsRmTeachingCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvClsRmTeachingCase_BaseENT.TeachSkillOperMethod = objvClsRmTeachingCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvClsRmTeachingCase_BaseENT.IdSkillType = objvClsRmTeachingCase_BaseENS.IdSkillType; //技能类型流水号
objvClsRmTeachingCase_BaseENT.SkillTypeID = objvClsRmTeachingCase_BaseENS.SkillTypeID; //技能类型ID
objvClsRmTeachingCase_BaseENT.CaseLevelId = objvClsRmTeachingCase_BaseENS.CaseLevelId; //课例等级Id
objvClsRmTeachingCase_BaseENT.CaseLevelName = objvClsRmTeachingCase_BaseENS.CaseLevelName; //案例等级名称
objvClsRmTeachingCase_BaseENT.DocFile = objvClsRmTeachingCase_BaseENS.DocFile; //生成的Word文件名
objvClsRmTeachingCase_BaseENT.IsNeedGeneWord = objvClsRmTeachingCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvClsRmTeachingCase_BaseENT.WordCreateDate = objvClsRmTeachingCase_BaseENS.WordCreateDate; //Word生成日期
objvClsRmTeachingCase_BaseENT.IsVisible = objvClsRmTeachingCase_BaseENS.IsVisible; //是否显示
objvClsRmTeachingCase_BaseENT.OwnerId = objvClsRmTeachingCase_BaseENS.OwnerId; //拥有者Id
objvClsRmTeachingCase_BaseENT.IdStudentInfo = objvClsRmTeachingCase_BaseENS.IdStudentInfo; //学生流水号
objvClsRmTeachingCase_BaseENT.StuName = objvClsRmTeachingCase_BaseENS.StuName; //姓名
objvClsRmTeachingCase_BaseENT.StuId = objvClsRmTeachingCase_BaseENS.StuId; //学号
objvClsRmTeachingCase_BaseENT.PoliticsName = objvClsRmTeachingCase_BaseENS.PoliticsName; //政治面貌
objvClsRmTeachingCase_BaseENT.SexDesc = objvClsRmTeachingCase_BaseENS.SexDesc; //性别名称
objvClsRmTeachingCase_BaseENT.EthnicName = objvClsRmTeachingCase_BaseENS.EthnicName; //民族名称
objvClsRmTeachingCase_BaseENT.UniZoneDesc = objvClsRmTeachingCase_BaseENS.UniZoneDesc; //校区名称
objvClsRmTeachingCase_BaseENT.StuTypeDesc = objvClsRmTeachingCase_BaseENS.StuTypeDesc; //学生类别名称
objvClsRmTeachingCase_BaseENT.IdXzCollege = objvClsRmTeachingCase_BaseENS.IdXzCollege; //学院流水号
objvClsRmTeachingCase_BaseENT.CollegeId = objvClsRmTeachingCase_BaseENS.CollegeId; //学院ID
objvClsRmTeachingCase_BaseENT.CollegeName = objvClsRmTeachingCase_BaseENS.CollegeName; //学院名称
objvClsRmTeachingCase_BaseENT.CollegeNameA = objvClsRmTeachingCase_BaseENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCase_BaseENT.IdXzMajor = objvClsRmTeachingCase_BaseENS.IdXzMajor; //专业流水号
objvClsRmTeachingCase_BaseENT.MajorName = objvClsRmTeachingCase_BaseENS.MajorName; //专业名称
objvClsRmTeachingCase_BaseENT.GradeBaseName = objvClsRmTeachingCase_BaseENS.GradeBaseName; //年级名称
objvClsRmTeachingCase_BaseENT.IdAdminCls = objvClsRmTeachingCase_BaseENS.IdAdminCls; //行政班流水号
objvClsRmTeachingCase_BaseENT.AdminClsId = objvClsRmTeachingCase_BaseENS.AdminClsId; //行政班代号
objvClsRmTeachingCase_BaseENT.AdminClsName = objvClsRmTeachingCase_BaseENS.AdminClsName; //行政班名称
objvClsRmTeachingCase_BaseENT.Birthday = objvClsRmTeachingCase_BaseENS.Birthday; //出生日期
objvClsRmTeachingCase_BaseENT.NativePlace = objvClsRmTeachingCase_BaseENS.NativePlace; //籍贯
objvClsRmTeachingCase_BaseENT.Duty = objvClsRmTeachingCase_BaseENS.Duty; //职位
objvClsRmTeachingCase_BaseENT.IdCardNo = objvClsRmTeachingCase_BaseENS.IdCardNo; //身份证号
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
objvClsRmTeachingCase_BaseENT.DisciplineNamePs = objvClsRmTeachingCase_BaseENS.DisciplineNamePs; //学科
objvClsRmTeachingCase_BaseENT.GradeNamePs = objvClsRmTeachingCase_BaseENS.GradeNamePs; //年级
objvClsRmTeachingCase_BaseENT.IdGradePs = objvClsRmTeachingCase_BaseENS.IdGradePs; //年级流水号
objvClsRmTeachingCase_BaseENT.OwnerName = objvClsRmTeachingCase_BaseENS.OwnerName; //拥有者姓名
objvClsRmTeachingCase_BaseENT.OwnerNameWithId = objvClsRmTeachingCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvClsRmTeachingCase_BaseENT.BrowseCount4Case = objvClsRmTeachingCase_BaseENS.BrowseCount4Case; //课例浏览次数
objvClsRmTeachingCase_BaseENT.CaseTypeName = objvClsRmTeachingCase_BaseENS.CaseTypeName; //案例类型名称
objvClsRmTeachingCase_BaseENT.ftpFileType = objvClsRmTeachingCase_BaseENS.ftpFileType; //ftp文件类型
objvClsRmTeachingCase_BaseENT.IsUse = objvClsRmTeachingCase_BaseENS.IsUse; //是否使用
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
 /// <param name = "objvClsRmTeachingCase_BaseENS">源对象</param>
 /// <returns>目标对象=>clsvClsRmTeachingCase_BaseEN:objvClsRmTeachingCase_BaseENT</returns>
 public static clsvClsRmTeachingCase_BaseEN CopyTo(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENS)
{
try
{
 clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENT = new clsvClsRmTeachingCase_BaseEN()
{
IdClsRmTeachingCase = objvClsRmTeachingCase_BaseENS.IdClsRmTeachingCase, //课堂教学案例流水号
ClsRmTeachingCaseID = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseID, //课堂教学案例ID
ClsRmTeachingCaseName = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseName, //课堂教学案例名称
ClsRmTeachingCaseTheme = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTheme, //课堂教学案例主题词
IdClsRmTeachingCaseType = objvClsRmTeachingCase_BaseENS.IdClsRmTeachingCaseType, //课堂案例类型流水号
ClsRmTeachingCaseTypeName = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTypeName, //课堂案例类型名称
ClsRmTeachingCaseText = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseText, //案例文本内容
ClsRmTeachingCaseDate = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseDate, //课堂教学日期
ClsRmTeachingCaseTime = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTime, //课堂教学时间
ClsRmTeachingCaseDateIn = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseDateIn, //案例入库日期
ClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTimeIn, //案例入库时间
IdStudyLevel = objvClsRmTeachingCase_BaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvClsRmTeachingCase_BaseENS.StudyLevelName, //学段名称
IdTeachingPlan = objvClsRmTeachingCase_BaseENS.IdTeachingPlan, //教案流水号
IdCaseType = objvClsRmTeachingCase_BaseENS.IdCaseType, //案例类型流水号
IdDiscipline = objvClsRmTeachingCase_BaseENS.IdDiscipline, //学科流水号
DisciplineID = objvClsRmTeachingCase_BaseENS.DisciplineID, //学科ID
IdSchoolPs = objvClsRmTeachingCase_BaseENS.IdSchoolPs, //学校流水号
SchoolId = objvClsRmTeachingCase_BaseENS.SchoolId, //学校编号
SchoolName = objvClsRmTeachingCase_BaseENS.SchoolName, //学校名称
IdDisciplinePs = objvClsRmTeachingCase_BaseENS.IdDisciplinePs, //学科流水号
DisciplineName = objvClsRmTeachingCase_BaseENS.DisciplineName, //学科名称
IdGradeBase = objvClsRmTeachingCase_BaseENS.IdGradeBase, //年级流水号
IdSenateGaugeVersion = objvClsRmTeachingCase_BaseENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvClsRmTeachingCase_BaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvClsRmTeachingCase_BaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvClsRmTeachingCase_BaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvClsRmTeachingCase_BaseENS.VersionNo, //版本号
IdTeachSkill = objvClsRmTeachingCase_BaseENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvClsRmTeachingCase_BaseENS.TeachSkillID, //教学技能ID
SkillTypeName = objvClsRmTeachingCase_BaseENS.SkillTypeName, //技能类型名称
TeachSkillName = objvClsRmTeachingCase_BaseENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvClsRmTeachingCase_BaseENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvClsRmTeachingCase_BaseENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvClsRmTeachingCase_BaseENS.IdSkillType, //技能类型流水号
SkillTypeID = objvClsRmTeachingCase_BaseENS.SkillTypeID, //技能类型ID
CaseLevelId = objvClsRmTeachingCase_BaseENS.CaseLevelId, //课例等级Id
CaseLevelName = objvClsRmTeachingCase_BaseENS.CaseLevelName, //案例等级名称
DocFile = objvClsRmTeachingCase_BaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvClsRmTeachingCase_BaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvClsRmTeachingCase_BaseENS.WordCreateDate, //Word生成日期
IsVisible = objvClsRmTeachingCase_BaseENS.IsVisible, //是否显示
OwnerId = objvClsRmTeachingCase_BaseENS.OwnerId, //拥有者Id
IdStudentInfo = objvClsRmTeachingCase_BaseENS.IdStudentInfo, //学生流水号
StuName = objvClsRmTeachingCase_BaseENS.StuName, //姓名
StuId = objvClsRmTeachingCase_BaseENS.StuId, //学号
PoliticsName = objvClsRmTeachingCase_BaseENS.PoliticsName, //政治面貌
SexDesc = objvClsRmTeachingCase_BaseENS.SexDesc, //性别名称
EthnicName = objvClsRmTeachingCase_BaseENS.EthnicName, //民族名称
UniZoneDesc = objvClsRmTeachingCase_BaseENS.UniZoneDesc, //校区名称
StuTypeDesc = objvClsRmTeachingCase_BaseENS.StuTypeDesc, //学生类别名称
IdXzCollege = objvClsRmTeachingCase_BaseENS.IdXzCollege, //学院流水号
CollegeId = objvClsRmTeachingCase_BaseENS.CollegeId, //学院ID
CollegeName = objvClsRmTeachingCase_BaseENS.CollegeName, //学院名称
CollegeNameA = objvClsRmTeachingCase_BaseENS.CollegeNameA, //学院名称简写
IdXzMajor = objvClsRmTeachingCase_BaseENS.IdXzMajor, //专业流水号
MajorName = objvClsRmTeachingCase_BaseENS.MajorName, //专业名称
GradeBaseName = objvClsRmTeachingCase_BaseENS.GradeBaseName, //年级名称
IdAdminCls = objvClsRmTeachingCase_BaseENS.IdAdminCls, //行政班流水号
AdminClsId = objvClsRmTeachingCase_BaseENS.AdminClsId, //行政班代号
AdminClsName = objvClsRmTeachingCase_BaseENS.AdminClsName, //行政班名称
Birthday = objvClsRmTeachingCase_BaseENS.Birthday, //出生日期
NativePlace = objvClsRmTeachingCase_BaseENS.NativePlace, //籍贯
Duty = objvClsRmTeachingCase_BaseENS.Duty, //职位
IdCardNo = objvClsRmTeachingCase_BaseENS.IdCardNo, //身份证号
StuCardNo = objvClsRmTeachingCase_BaseENS.StuCardNo, //学生证号
LiveAddress = objvClsRmTeachingCase_BaseENS.LiveAddress, //居住地址
HomePhone = objvClsRmTeachingCase_BaseENS.HomePhone, //住宅电话
EnrollmentDate = objvClsRmTeachingCase_BaseENS.EnrollmentDate, //入校日期
PostCode = objvClsRmTeachingCase_BaseENS.PostCode, //邮编
UserKindId = objvClsRmTeachingCase_BaseENS.UserKindId, //用户类别Id
UserKindName = objvClsRmTeachingCase_BaseENS.UserKindName, //用户类别名
UserTypeId = objvClsRmTeachingCase_BaseENS.UserTypeId, //用户类型Id
IsDualVideo = objvClsRmTeachingCase_BaseENS.IsDualVideo, //是否双视频
RecommendedDegreeId = objvClsRmTeachingCase_BaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvClsRmTeachingCase_BaseENS.RecommendedDegreeName, //推荐度名称
Memo = objvClsRmTeachingCase_BaseENS.Memo, //备注
DisciplineNamePs = objvClsRmTeachingCase_BaseENS.DisciplineNamePs, //学科
GradeNamePs = objvClsRmTeachingCase_BaseENS.GradeNamePs, //年级
IdGradePs = objvClsRmTeachingCase_BaseENS.IdGradePs, //年级流水号
OwnerName = objvClsRmTeachingCase_BaseENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvClsRmTeachingCase_BaseENS.OwnerNameWithId, //拥有者名称附Id
BrowseCount4Case = objvClsRmTeachingCase_BaseENS.BrowseCount4Case, //课例浏览次数
CaseTypeName = objvClsRmTeachingCase_BaseENS.CaseTypeName, //案例类型名称
ftpFileType = objvClsRmTeachingCase_BaseENS.ftpFileType, //ftp文件类型
IsUse = objvClsRmTeachingCase_BaseENS.IsUse, //是否使用
};
 return objvClsRmTeachingCase_BaseENT;
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
public static void CheckProperty4Condition(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN)
{
 clsvClsRmTeachingCase_BaseBL.vClsRmTeachingCase_BaseDA.CheckProperty4Condition(objvClsRmTeachingCase_BaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdClsRmTeachingCase) == true)
{
string strComparisonOpIdClsRmTeachingCase = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdClsRmTeachingCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdClsRmTeachingCase, objvClsRmTeachingCase_BaseCond.IdClsRmTeachingCase, strComparisonOpIdClsRmTeachingCase);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseID) == true)
{
string strComparisonOpClsRmTeachingCaseID = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseID, objvClsRmTeachingCase_BaseCond.ClsRmTeachingCaseID, strComparisonOpClsRmTeachingCaseID);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseName) == true)
{
string strComparisonOpClsRmTeachingCaseName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseName, objvClsRmTeachingCase_BaseCond.ClsRmTeachingCaseName, strComparisonOpClsRmTeachingCaseName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme) == true)
{
string strComparisonOpClsRmTeachingCaseTheme = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme, objvClsRmTeachingCase_BaseCond.ClsRmTeachingCaseTheme, strComparisonOpClsRmTeachingCaseTheme);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdClsRmTeachingCaseType) == true)
{
string strComparisonOpIdClsRmTeachingCaseType = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdClsRmTeachingCaseType, objvClsRmTeachingCase_BaseCond.IdClsRmTeachingCaseType, strComparisonOpIdClsRmTeachingCaseType);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName) == true)
{
string strComparisonOpClsRmTeachingCaseTypeName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName, objvClsRmTeachingCase_BaseCond.ClsRmTeachingCaseTypeName, strComparisonOpClsRmTeachingCaseTypeName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseText) == true)
{
string strComparisonOpClsRmTeachingCaseText = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseText, objvClsRmTeachingCase_BaseCond.ClsRmTeachingCaseText, strComparisonOpClsRmTeachingCaseText);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseDate) == true)
{
string strComparisonOpClsRmTeachingCaseDate = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseDate, objvClsRmTeachingCase_BaseCond.ClsRmTeachingCaseDate, strComparisonOpClsRmTeachingCaseDate);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseTime) == true)
{
string strComparisonOpClsRmTeachingCaseTime = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseTime, objvClsRmTeachingCase_BaseCond.ClsRmTeachingCaseTime, strComparisonOpClsRmTeachingCaseTime);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn) == true)
{
string strComparisonOpClsRmTeachingCaseDateIn = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn, objvClsRmTeachingCase_BaseCond.ClsRmTeachingCaseDateIn, strComparisonOpClsRmTeachingCaseDateIn);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn) == true)
{
string strComparisonOpClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn, objvClsRmTeachingCase_BaseCond.ClsRmTeachingCaseTimeIn, strComparisonOpClsRmTeachingCaseTimeIn);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdStudyLevel, objvClsRmTeachingCase_BaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.StudyLevelName, objvClsRmTeachingCase_BaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdTeachingPlan, objvClsRmTeachingCase_BaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdCaseType, objvClsRmTeachingCase_BaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdDiscipline, objvClsRmTeachingCase_BaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.DisciplineID, objvClsRmTeachingCase_BaseCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdSchoolPs) == true)
{
string strComparisonOpIdSchoolPs = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdSchoolPs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdSchoolPs, objvClsRmTeachingCase_BaseCond.IdSchoolPs, strComparisonOpIdSchoolPs);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.SchoolId) == true)
{
string strComparisonOpSchoolId = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.SchoolId, objvClsRmTeachingCase_BaseCond.SchoolId, strComparisonOpSchoolId);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.SchoolName) == true)
{
string strComparisonOpSchoolName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.SchoolName, objvClsRmTeachingCase_BaseCond.SchoolName, strComparisonOpSchoolName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdDisciplinePs) == true)
{
string strComparisonOpIdDisciplinePs = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdDisciplinePs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdDisciplinePs, objvClsRmTeachingCase_BaseCond.IdDisciplinePs, strComparisonOpIdDisciplinePs);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.DisciplineName, objvClsRmTeachingCase_BaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdGradeBase, objvClsRmTeachingCase_BaseCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdSenateGaugeVersion, objvClsRmTeachingCase_BaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.senateGaugeVersionID, objvClsRmTeachingCase_BaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.senateGaugeVersionName, objvClsRmTeachingCase_BaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Base.senateGaugeVersionTtlScore, objvClsRmTeachingCase_BaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.VersionNo) == true)
{
string strComparisonOpVersionNo = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Base.VersionNo, objvClsRmTeachingCase_BaseCond.VersionNo, strComparisonOpVersionNo);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdTeachSkill, objvClsRmTeachingCase_BaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.TeachSkillID, objvClsRmTeachingCase_BaseCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.SkillTypeName, objvClsRmTeachingCase_BaseCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.TeachSkillName, objvClsRmTeachingCase_BaseCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.TeachSkillTheory, objvClsRmTeachingCase_BaseCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.TeachSkillOperMethod, objvClsRmTeachingCase_BaseCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdSkillType, objvClsRmTeachingCase_BaseCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.SkillTypeID, objvClsRmTeachingCase_BaseCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CaseLevelId, objvClsRmTeachingCase_BaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CaseLevelName, objvClsRmTeachingCase_BaseCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.DocFile) == true)
{
string strComparisonOpDocFile = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.DocFile, objvClsRmTeachingCase_BaseCond.DocFile, strComparisonOpDocFile);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IsNeedGeneWord) == true)
{
if (objvClsRmTeachingCase_BaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Base.IsNeedGeneWord);
}
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.WordCreateDate, objvClsRmTeachingCase_BaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IsVisible) == true)
{
if (objvClsRmTeachingCase_BaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Base.IsVisible);
}
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.OwnerId) == true)
{
string strComparisonOpOwnerId = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.OwnerId, objvClsRmTeachingCase_BaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdStudentInfo, objvClsRmTeachingCase_BaseCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.StuName) == true)
{
string strComparisonOpStuName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.StuName, objvClsRmTeachingCase_BaseCond.StuName, strComparisonOpStuName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.StuId) == true)
{
string strComparisonOpStuId = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.StuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.StuId, objvClsRmTeachingCase_BaseCond.StuId, strComparisonOpStuId);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.PoliticsName) == true)
{
string strComparisonOpPoliticsName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.PoliticsName, objvClsRmTeachingCase_BaseCond.PoliticsName, strComparisonOpPoliticsName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.SexDesc) == true)
{
string strComparisonOpSexDesc = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.SexDesc, objvClsRmTeachingCase_BaseCond.SexDesc, strComparisonOpSexDesc);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.EthnicName) == true)
{
string strComparisonOpEthnicName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.EthnicName, objvClsRmTeachingCase_BaseCond.EthnicName, strComparisonOpEthnicName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.UniZoneDesc, objvClsRmTeachingCase_BaseCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.StuTypeDesc) == true)
{
string strComparisonOpStuTypeDesc = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.StuTypeDesc, objvClsRmTeachingCase_BaseCond.StuTypeDesc, strComparisonOpStuTypeDesc);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdXzCollege, objvClsRmTeachingCase_BaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.CollegeId) == true)
{
string strComparisonOpCollegeId = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CollegeId, objvClsRmTeachingCase_BaseCond.CollegeId, strComparisonOpCollegeId);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.CollegeName) == true)
{
string strComparisonOpCollegeName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CollegeName, objvClsRmTeachingCase_BaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CollegeNameA, objvClsRmTeachingCase_BaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdXzMajor, objvClsRmTeachingCase_BaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.MajorName) == true)
{
string strComparisonOpMajorName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.MajorName, objvClsRmTeachingCase_BaseCond.MajorName, strComparisonOpMajorName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.GradeBaseName, objvClsRmTeachingCase_BaseCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdAdminCls, objvClsRmTeachingCase_BaseCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.AdminClsId) == true)
{
string strComparisonOpAdminClsId = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.AdminClsId, objvClsRmTeachingCase_BaseCond.AdminClsId, strComparisonOpAdminClsId);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.AdminClsName) == true)
{
string strComparisonOpAdminClsName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.AdminClsName, objvClsRmTeachingCase_BaseCond.AdminClsName, strComparisonOpAdminClsName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.Birthday) == true)
{
string strComparisonOpBirthday = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.Birthday, objvClsRmTeachingCase_BaseCond.Birthday, strComparisonOpBirthday);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.NativePlace) == true)
{
string strComparisonOpNativePlace = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.NativePlace, objvClsRmTeachingCase_BaseCond.NativePlace, strComparisonOpNativePlace);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.Duty) == true)
{
string strComparisonOpDuty = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.Duty, objvClsRmTeachingCase_BaseCond.Duty, strComparisonOpDuty);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdCardNo) == true)
{
string strComparisonOpIdCardNo = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdCardNo, objvClsRmTeachingCase_BaseCond.IdCardNo, strComparisonOpIdCardNo);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.StuCardNo) == true)
{
string strComparisonOpStuCardNo = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.StuCardNo, objvClsRmTeachingCase_BaseCond.StuCardNo, strComparisonOpStuCardNo);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.LiveAddress) == true)
{
string strComparisonOpLiveAddress = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.LiveAddress, objvClsRmTeachingCase_BaseCond.LiveAddress, strComparisonOpLiveAddress);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.HomePhone) == true)
{
string strComparisonOpHomePhone = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.HomePhone, objvClsRmTeachingCase_BaseCond.HomePhone, strComparisonOpHomePhone);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.EnrollmentDate) == true)
{
string strComparisonOpEnrollmentDate = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.EnrollmentDate, objvClsRmTeachingCase_BaseCond.EnrollmentDate, strComparisonOpEnrollmentDate);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.PostCode) == true)
{
string strComparisonOpPostCode = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.PostCode, objvClsRmTeachingCase_BaseCond.PostCode, strComparisonOpPostCode);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.UserKindId) == true)
{
string strComparisonOpUserKindId = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.UserKindId, objvClsRmTeachingCase_BaseCond.UserKindId, strComparisonOpUserKindId);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.UserKindName) == true)
{
string strComparisonOpUserKindName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.UserKindName, objvClsRmTeachingCase_BaseCond.UserKindName, strComparisonOpUserKindName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.UserTypeId, objvClsRmTeachingCase_BaseCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IsDualVideo) == true)
{
if (objvClsRmTeachingCase_BaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCase_Base.IsDualVideo);
}
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.RecommendedDegreeId, objvClsRmTeachingCase_BaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.RecommendedDegreeName, objvClsRmTeachingCase_BaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.Memo) == true)
{
string strComparisonOpMemo = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.Memo, objvClsRmTeachingCase_BaseCond.Memo, strComparisonOpMemo);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.DisciplineNamePs) == true)
{
string strComparisonOpDisciplineNamePs = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.DisciplineNamePs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.DisciplineNamePs, objvClsRmTeachingCase_BaseCond.DisciplineNamePs, strComparisonOpDisciplineNamePs);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.GradeNamePs) == true)
{
string strComparisonOpGradeNamePs = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.GradeNamePs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.GradeNamePs, objvClsRmTeachingCase_BaseCond.GradeNamePs, strComparisonOpGradeNamePs);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IdGradePs) == true)
{
string strComparisonOpIdGradePs = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.IdGradePs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.IdGradePs, objvClsRmTeachingCase_BaseCond.IdGradePs, strComparisonOpIdGradePs);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.OwnerName) == true)
{
string strComparisonOpOwnerName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.OwnerName, objvClsRmTeachingCase_BaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.OwnerNameWithId, objvClsRmTeachingCase_BaseCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCase_Base.BrowseCount4Case, objvClsRmTeachingCase_BaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.CaseTypeName) == true)
{
string strComparisonOpCaseTypeName = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.CaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.CaseTypeName, objvClsRmTeachingCase_BaseCond.CaseTypeName, strComparisonOpCaseTypeName);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[convClsRmTeachingCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCase_Base.ftpFileType, objvClsRmTeachingCase_BaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvClsRmTeachingCase_BaseCond.IsUpdated(convClsRmTeachingCase_Base.IsUse) == true)
{
if (objvClsRmTeachingCase_BaseCond.IsUse == true)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vClsRmTeachingCase_Base
{
public virtual bool UpdRelaTabDate(string strIdClsRmTeachingCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课堂教学案例_Base(vClsRmTeachingCase_Base)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvClsRmTeachingCase_BaseBL
{
public static RelatedActions_vClsRmTeachingCase_Base relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvClsRmTeachingCase_BaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvClsRmTeachingCase_BaseDA vClsRmTeachingCase_BaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvClsRmTeachingCase_BaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvClsRmTeachingCase_BaseBL()
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
if (string.IsNullOrEmpty(clsvClsRmTeachingCase_BaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClsRmTeachingCase_BaseEN._ConnectString);
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
public static DataTable GetDataTable_vClsRmTeachingCase_Base(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vClsRmTeachingCase_BaseDA.GetDataTable_vClsRmTeachingCase_Base(strWhereCond);
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
objDT = vClsRmTeachingCase_BaseDA.GetDataTable(strWhereCond);
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
objDT = vClsRmTeachingCase_BaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vClsRmTeachingCase_BaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vClsRmTeachingCase_BaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vClsRmTeachingCase_BaseDA.GetDataTable_Top(objTopPara);
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
objDT = vClsRmTeachingCase_BaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vClsRmTeachingCase_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vClsRmTeachingCase_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstByIdClsRmTeachingCaseLst(List<string> arrIdClsRmTeachingCaseLst)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
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
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdClsRmTeachingCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvClsRmTeachingCase_BaseEN> GetObjLstByIdClsRmTeachingCaseLstCache(List<string> arrIdClsRmTeachingCaseLst)
{
string strKey = string.Format("{0}", clsvClsRmTeachingCase_BaseEN._CurrTabName);
List<clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Sel =
arrvClsRmTeachingCase_BaseObjLstCache
.Where(x => arrIdClsRmTeachingCaseLst.Contains(x.IdClsRmTeachingCase));
return arrvClsRmTeachingCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLst(string strWhereCond)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvClsRmTeachingCase_BaseEN> GetSubObjLstCache(clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseCond)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvClsRmTeachingCase_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convClsRmTeachingCase_Base.AttributeName)
{
if (objvClsRmTeachingCase_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvClsRmTeachingCase_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClsRmTeachingCase_BaseCond[strFldName].ToString());
}
else
{
if (objvClsRmTeachingCase_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClsRmTeachingCase_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvClsRmTeachingCase_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvClsRmTeachingCase_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvClsRmTeachingCase_BaseCond[strFldName]));
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
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
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvClsRmTeachingCase_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
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
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
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
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvClsRmTeachingCase_Base(ref clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN)
{
bool bolResult = vClsRmTeachingCase_BaseDA.GetvClsRmTeachingCase_Base(ref objvClsRmTeachingCase_BaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClsRmTeachingCase_BaseEN GetObjByIdClsRmTeachingCase(string strIdClsRmTeachingCase)
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
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = vClsRmTeachingCase_BaseDA.GetObjByIdClsRmTeachingCase(strIdClsRmTeachingCase);
return objvClsRmTeachingCase_BaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvClsRmTeachingCase_BaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = vClsRmTeachingCase_BaseDA.GetFirstObj(strWhereCond);
 return objvClsRmTeachingCase_BaseEN;
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
public static clsvClsRmTeachingCase_BaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = vClsRmTeachingCase_BaseDA.GetObjByDataRow(objRow);
 return objvClsRmTeachingCase_BaseEN;
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
public static clsvClsRmTeachingCase_BaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = vClsRmTeachingCase_BaseDA.GetObjByDataRow(objRow);
 return objvClsRmTeachingCase_BaseEN;
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
 /// <param name = "lstvClsRmTeachingCase_BaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClsRmTeachingCase_BaseEN GetObjByIdClsRmTeachingCaseFromList(string strIdClsRmTeachingCase, List<clsvClsRmTeachingCase_BaseEN> lstvClsRmTeachingCase_BaseObjLst)
{
foreach (clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN in lstvClsRmTeachingCase_BaseObjLst)
{
if (objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase == strIdClsRmTeachingCase)
{
return objvClsRmTeachingCase_BaseEN;
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
 strIdClsRmTeachingCase = new clsvClsRmTeachingCase_BaseDA().GetFirstID(strWhereCond);
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
 arrList = vClsRmTeachingCase_BaseDA.GetID(strWhereCond);
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
bool bolIsExist = vClsRmTeachingCase_BaseDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vClsRmTeachingCase_BaseDA.IsExist(strIdClsRmTeachingCase);
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
 bolIsExist = clsvClsRmTeachingCase_BaseDA.IsExistTable();
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
 bolIsExist = vClsRmTeachingCase_BaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvClsRmTeachingCase_BaseENS">源对象</param>
 /// <param name = "objvClsRmTeachingCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENS, clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENT)
{
try
{
objvClsRmTeachingCase_BaseENT.IdClsRmTeachingCase = objvClsRmTeachingCase_BaseENS.IdClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseID = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseName = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCase_BaseENT.IdClsRmTeachingCaseType = objvClsRmTeachingCase_BaseENS.IdClsRmTeachingCaseType; //课堂案例类型流水号
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseText = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseText; //案例文本内容
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseDate = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTime = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCase_BaseENT.IdStudyLevel = objvClsRmTeachingCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvClsRmTeachingCase_BaseENT.StudyLevelName = objvClsRmTeachingCase_BaseENS.StudyLevelName; //学段名称
objvClsRmTeachingCase_BaseENT.IdTeachingPlan = objvClsRmTeachingCase_BaseENS.IdTeachingPlan; //教案流水号
objvClsRmTeachingCase_BaseENT.IdCaseType = objvClsRmTeachingCase_BaseENS.IdCaseType; //案例类型流水号
objvClsRmTeachingCase_BaseENT.IdDiscipline = objvClsRmTeachingCase_BaseENS.IdDiscipline; //学科流水号
objvClsRmTeachingCase_BaseENT.DisciplineID = objvClsRmTeachingCase_BaseENS.DisciplineID; //学科ID
objvClsRmTeachingCase_BaseENT.IdSchoolPs = objvClsRmTeachingCase_BaseENS.IdSchoolPs; //学校流水号
objvClsRmTeachingCase_BaseENT.SchoolId = objvClsRmTeachingCase_BaseENS.SchoolId; //学校编号
objvClsRmTeachingCase_BaseENT.SchoolName = objvClsRmTeachingCase_BaseENS.SchoolName; //学校名称
objvClsRmTeachingCase_BaseENT.IdDisciplinePs = objvClsRmTeachingCase_BaseENS.IdDisciplinePs; //学科流水号
objvClsRmTeachingCase_BaseENT.DisciplineName = objvClsRmTeachingCase_BaseENS.DisciplineName; //学科名称
objvClsRmTeachingCase_BaseENT.IdGradeBase = objvClsRmTeachingCase_BaseENS.IdGradeBase; //年级流水号
objvClsRmTeachingCase_BaseENT.IdSenateGaugeVersion = objvClsRmTeachingCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvClsRmTeachingCase_BaseENT.senateGaugeVersionID = objvClsRmTeachingCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCase_BaseENT.senateGaugeVersionName = objvClsRmTeachingCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCase_BaseENT.senateGaugeVersionTtlScore = objvClsRmTeachingCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCase_BaseENT.VersionNo = objvClsRmTeachingCase_BaseENS.VersionNo; //版本号
objvClsRmTeachingCase_BaseENT.IdTeachSkill = objvClsRmTeachingCase_BaseENS.IdTeachSkill; //教学技能流水号
objvClsRmTeachingCase_BaseENT.TeachSkillID = objvClsRmTeachingCase_BaseENS.TeachSkillID; //教学技能ID
objvClsRmTeachingCase_BaseENT.SkillTypeName = objvClsRmTeachingCase_BaseENS.SkillTypeName; //技能类型名称
objvClsRmTeachingCase_BaseENT.TeachSkillName = objvClsRmTeachingCase_BaseENS.TeachSkillName; //教学技能名称
objvClsRmTeachingCase_BaseENT.TeachSkillTheory = objvClsRmTeachingCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvClsRmTeachingCase_BaseENT.TeachSkillOperMethod = objvClsRmTeachingCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvClsRmTeachingCase_BaseENT.IdSkillType = objvClsRmTeachingCase_BaseENS.IdSkillType; //技能类型流水号
objvClsRmTeachingCase_BaseENT.SkillTypeID = objvClsRmTeachingCase_BaseENS.SkillTypeID; //技能类型ID
objvClsRmTeachingCase_BaseENT.CaseLevelId = objvClsRmTeachingCase_BaseENS.CaseLevelId; //课例等级Id
objvClsRmTeachingCase_BaseENT.CaseLevelName = objvClsRmTeachingCase_BaseENS.CaseLevelName; //案例等级名称
objvClsRmTeachingCase_BaseENT.DocFile = objvClsRmTeachingCase_BaseENS.DocFile; //生成的Word文件名
objvClsRmTeachingCase_BaseENT.IsNeedGeneWord = objvClsRmTeachingCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvClsRmTeachingCase_BaseENT.WordCreateDate = objvClsRmTeachingCase_BaseENS.WordCreateDate; //Word生成日期
objvClsRmTeachingCase_BaseENT.IsVisible = objvClsRmTeachingCase_BaseENS.IsVisible; //是否显示
objvClsRmTeachingCase_BaseENT.OwnerId = objvClsRmTeachingCase_BaseENS.OwnerId; //拥有者Id
objvClsRmTeachingCase_BaseENT.IdStudentInfo = objvClsRmTeachingCase_BaseENS.IdStudentInfo; //学生流水号
objvClsRmTeachingCase_BaseENT.StuName = objvClsRmTeachingCase_BaseENS.StuName; //姓名
objvClsRmTeachingCase_BaseENT.StuId = objvClsRmTeachingCase_BaseENS.StuId; //学号
objvClsRmTeachingCase_BaseENT.PoliticsName = objvClsRmTeachingCase_BaseENS.PoliticsName; //政治面貌
objvClsRmTeachingCase_BaseENT.SexDesc = objvClsRmTeachingCase_BaseENS.SexDesc; //性别名称
objvClsRmTeachingCase_BaseENT.EthnicName = objvClsRmTeachingCase_BaseENS.EthnicName; //民族名称
objvClsRmTeachingCase_BaseENT.UniZoneDesc = objvClsRmTeachingCase_BaseENS.UniZoneDesc; //校区名称
objvClsRmTeachingCase_BaseENT.StuTypeDesc = objvClsRmTeachingCase_BaseENS.StuTypeDesc; //学生类别名称
objvClsRmTeachingCase_BaseENT.IdXzCollege = objvClsRmTeachingCase_BaseENS.IdXzCollege; //学院流水号
objvClsRmTeachingCase_BaseENT.CollegeId = objvClsRmTeachingCase_BaseENS.CollegeId; //学院ID
objvClsRmTeachingCase_BaseENT.CollegeName = objvClsRmTeachingCase_BaseENS.CollegeName; //学院名称
objvClsRmTeachingCase_BaseENT.CollegeNameA = objvClsRmTeachingCase_BaseENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCase_BaseENT.IdXzMajor = objvClsRmTeachingCase_BaseENS.IdXzMajor; //专业流水号
objvClsRmTeachingCase_BaseENT.MajorName = objvClsRmTeachingCase_BaseENS.MajorName; //专业名称
objvClsRmTeachingCase_BaseENT.GradeBaseName = objvClsRmTeachingCase_BaseENS.GradeBaseName; //年级名称
objvClsRmTeachingCase_BaseENT.IdAdminCls = objvClsRmTeachingCase_BaseENS.IdAdminCls; //行政班流水号
objvClsRmTeachingCase_BaseENT.AdminClsId = objvClsRmTeachingCase_BaseENS.AdminClsId; //行政班代号
objvClsRmTeachingCase_BaseENT.AdminClsName = objvClsRmTeachingCase_BaseENS.AdminClsName; //行政班名称
objvClsRmTeachingCase_BaseENT.Birthday = objvClsRmTeachingCase_BaseENS.Birthday; //出生日期
objvClsRmTeachingCase_BaseENT.NativePlace = objvClsRmTeachingCase_BaseENS.NativePlace; //籍贯
objvClsRmTeachingCase_BaseENT.Duty = objvClsRmTeachingCase_BaseENS.Duty; //职位
objvClsRmTeachingCase_BaseENT.IdCardNo = objvClsRmTeachingCase_BaseENS.IdCardNo; //身份证号
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
objvClsRmTeachingCase_BaseENT.DisciplineNamePs = objvClsRmTeachingCase_BaseENS.DisciplineNamePs; //学科
objvClsRmTeachingCase_BaseENT.GradeNamePs = objvClsRmTeachingCase_BaseENS.GradeNamePs; //年级
objvClsRmTeachingCase_BaseENT.IdGradePs = objvClsRmTeachingCase_BaseENS.IdGradePs; //年级流水号
objvClsRmTeachingCase_BaseENT.OwnerName = objvClsRmTeachingCase_BaseENS.OwnerName; //拥有者姓名
objvClsRmTeachingCase_BaseENT.OwnerNameWithId = objvClsRmTeachingCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvClsRmTeachingCase_BaseENT.BrowseCount4Case = objvClsRmTeachingCase_BaseENS.BrowseCount4Case; //课例浏览次数
objvClsRmTeachingCase_BaseENT.CaseTypeName = objvClsRmTeachingCase_BaseENS.CaseTypeName; //案例类型名称
objvClsRmTeachingCase_BaseENT.ftpFileType = objvClsRmTeachingCase_BaseENS.ftpFileType; //ftp文件类型
objvClsRmTeachingCase_BaseENT.IsUse = objvClsRmTeachingCase_BaseENS.IsUse; //是否使用
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
 /// <param name = "objvClsRmTeachingCase_BaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN)
{
try
{
objvClsRmTeachingCase_BaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvClsRmTeachingCase_BaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdClsRmTeachingCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase; //课堂教学案例流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.ClsRmTeachingCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID; //课堂教学案例ID
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.ClsRmTeachingCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName; //课堂教学案例名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme; //课堂教学案例主题词
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdClsRmTeachingCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType; //课堂案例类型流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName; //课堂案例类型名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.ClsRmTeachingCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText; //案例文本内容
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.ClsRmTeachingCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate; //课堂教学日期
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.ClsRmTeachingCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime; //课堂教学时间
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objvClsRmTeachingCase_BaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.StudyLevelName = objvClsRmTeachingCase_BaseEN.StudyLevelName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objvClsRmTeachingCase_BaseEN.IdTeachingPlan == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdCaseType = objvClsRmTeachingCase_BaseEN.IdCaseType == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdDiscipline = objvClsRmTeachingCase_BaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.DisciplineID = objvClsRmTeachingCase_BaseEN.DisciplineID == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdSchoolPs, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objvClsRmTeachingCase_BaseEN.IdSchoolPs == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdSchoolPs; //学校流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.SchoolId = objvClsRmTeachingCase_BaseEN.SchoolId == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.SchoolName = objvClsRmTeachingCase_BaseEN.SchoolName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdDisciplinePs, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objvClsRmTeachingCase_BaseEN.IdDisciplinePs == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdDisciplinePs; //学科流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.DisciplineName = objvClsRmTeachingCase_BaseEN.DisciplineName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdGradeBase = objvClsRmTeachingCase_BaseEN.IdGradeBase == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objvClsRmTeachingCase_BaseEN.senateGaugeVersionID == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objvClsRmTeachingCase_BaseEN.senateGaugeVersionName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.VersionNo = objvClsRmTeachingCase_BaseEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objvClsRmTeachingCase_BaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.TeachSkillID = objvClsRmTeachingCase_BaseEN.TeachSkillID == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.SkillTypeName = objvClsRmTeachingCase_BaseEN.SkillTypeName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.TeachSkillName = objvClsRmTeachingCase_BaseEN.TeachSkillName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objvClsRmTeachingCase_BaseEN.TeachSkillTheory == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdSkillType = objvClsRmTeachingCase_BaseEN.IdSkillType == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.SkillTypeID = objvClsRmTeachingCase_BaseEN.SkillTypeID == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.CaseLevelId = objvClsRmTeachingCase_BaseEN.CaseLevelId == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.CaseLevelName = objvClsRmTeachingCase_BaseEN.CaseLevelName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.DocFile = objvClsRmTeachingCase_BaseEN.DocFile == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = objvClsRmTeachingCase_BaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.WordCreateDate = objvClsRmTeachingCase_BaseEN.WordCreateDate == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IsVisible = objvClsRmTeachingCase_BaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.OwnerId = objvClsRmTeachingCase_BaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objvClsRmTeachingCase_BaseEN.IdStudentInfo == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.StuName = objvClsRmTeachingCase_BaseEN.StuName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.StuName; //姓名
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.StuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.StuId = objvClsRmTeachingCase_BaseEN.StuId == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.StuId; //学号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.PoliticsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.PoliticsName = objvClsRmTeachingCase_BaseEN.PoliticsName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.PoliticsName; //政治面貌
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.SexDesc = objvClsRmTeachingCase_BaseEN.SexDesc == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.EthnicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.EthnicName = objvClsRmTeachingCase_BaseEN.EthnicName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.EthnicName; //民族名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objvClsRmTeachingCase_BaseEN.UniZoneDesc == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.StuTypeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objvClsRmTeachingCase_BaseEN.StuTypeDesc == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.StuTypeDesc; //学生类别名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdXzCollege = objvClsRmTeachingCase_BaseEN.IdXzCollege == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.CollegeId = objvClsRmTeachingCase_BaseEN.CollegeId == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.CollegeName = objvClsRmTeachingCase_BaseEN.CollegeName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.CollegeNameA = objvClsRmTeachingCase_BaseEN.CollegeNameA == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdXzMajor = objvClsRmTeachingCase_BaseEN.IdXzMajor == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.MajorName = objvClsRmTeachingCase_BaseEN.MajorName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.GradeBaseName = objvClsRmTeachingCase_BaseEN.GradeBaseName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdAdminCls = objvClsRmTeachingCase_BaseEN.IdAdminCls == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.AdminClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.AdminClsId = objvClsRmTeachingCase_BaseEN.AdminClsId == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.AdminClsId; //行政班代号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.AdminClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.AdminClsName = objvClsRmTeachingCase_BaseEN.AdminClsName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.AdminClsName; //行政班名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.Birthday = objvClsRmTeachingCase_BaseEN.Birthday == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.Birthday; //出生日期
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.NativePlace, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.NativePlace = objvClsRmTeachingCase_BaseEN.NativePlace == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.NativePlace; //籍贯
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.Duty, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.Duty = objvClsRmTeachingCase_BaseEN.Duty == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.Duty; //职位
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdCardNo = objvClsRmTeachingCase_BaseEN.IdCardNo == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdCardNo; //身份证号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.StuCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.StuCardNo = objvClsRmTeachingCase_BaseEN.StuCardNo == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.StuCardNo; //学生证号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.LiveAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.LiveAddress = objvClsRmTeachingCase_BaseEN.LiveAddress == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.LiveAddress; //居住地址
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.HomePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.HomePhone = objvClsRmTeachingCase_BaseEN.HomePhone == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.HomePhone; //住宅电话
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.EnrollmentDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objvClsRmTeachingCase_BaseEN.EnrollmentDate == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.EnrollmentDate; //入校日期
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.PostCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.PostCode = objvClsRmTeachingCase_BaseEN.PostCode == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.PostCode; //邮编
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.UserKindId = objvClsRmTeachingCase_BaseEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.UserKindName = objvClsRmTeachingCase_BaseEN.UserKindName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.UserTypeId = objvClsRmTeachingCase_BaseEN.UserTypeId == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IsDualVideo = objvClsRmTeachingCase_BaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objvClsRmTeachingCase_BaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objvClsRmTeachingCase_BaseEN.RecommendedDegreeName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.Memo = objvClsRmTeachingCase_BaseEN.Memo == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.Memo; //备注
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.DisciplineNamePs, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objvClsRmTeachingCase_BaseEN.DisciplineNamePs == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.DisciplineNamePs; //学科
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.GradeNamePs, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.GradeNamePs = objvClsRmTeachingCase_BaseEN.GradeNamePs == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.GradeNamePs; //年级
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IdGradePs, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IdGradePs = objvClsRmTeachingCase_BaseEN.IdGradePs == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.IdGradePs; //年级流水号
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.OwnerName = objvClsRmTeachingCase_BaseEN.OwnerName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objvClsRmTeachingCase_BaseEN.OwnerNameWithId == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objvClsRmTeachingCase_BaseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.CaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.CaseTypeName = objvClsRmTeachingCase_BaseEN.CaseTypeName == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.CaseTypeName; //案例类型名称
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.ftpFileType = objvClsRmTeachingCase_BaseEN.ftpFileType == "[null]" ? null :  objvClsRmTeachingCase_BaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convClsRmTeachingCase_Base.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvClsRmTeachingCase_BaseEN.IsUse = objvClsRmTeachingCase_BaseEN.IsUse; //是否使用
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
 /// <param name = "objvClsRmTeachingCase_BaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN)
{
try
{
if (objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme == "[null]") objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = null; //课堂教学案例主题词
if (objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName == "[null]") objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = null; //课堂案例类型名称
if (objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText == "[null]") objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = null; //案例文本内容
if (objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate == "[null]") objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = null; //课堂教学日期
if (objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime == "[null]") objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = null; //课堂教学时间
if (objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn == "[null]") objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = null; //案例入库日期
if (objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn == "[null]") objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = null; //案例入库时间
if (objvClsRmTeachingCase_BaseEN.StudyLevelName == "[null]") objvClsRmTeachingCase_BaseEN.StudyLevelName = null; //学段名称
if (objvClsRmTeachingCase_BaseEN.IdTeachingPlan == "[null]") objvClsRmTeachingCase_BaseEN.IdTeachingPlan = null; //教案流水号
if (objvClsRmTeachingCase_BaseEN.IdCaseType == "[null]") objvClsRmTeachingCase_BaseEN.IdCaseType = null; //案例类型流水号
if (objvClsRmTeachingCase_BaseEN.DisciplineID == "[null]") objvClsRmTeachingCase_BaseEN.DisciplineID = null; //学科ID
if (objvClsRmTeachingCase_BaseEN.IdSchoolPs == "[null]") objvClsRmTeachingCase_BaseEN.IdSchoolPs = null; //学校流水号
if (objvClsRmTeachingCase_BaseEN.SchoolId == "[null]") objvClsRmTeachingCase_BaseEN.SchoolId = null; //学校编号
if (objvClsRmTeachingCase_BaseEN.SchoolName == "[null]") objvClsRmTeachingCase_BaseEN.SchoolName = null; //学校名称
if (objvClsRmTeachingCase_BaseEN.IdDisciplinePs == "[null]") objvClsRmTeachingCase_BaseEN.IdDisciplinePs = null; //学科流水号
if (objvClsRmTeachingCase_BaseEN.DisciplineName == "[null]") objvClsRmTeachingCase_BaseEN.DisciplineName = null; //学科名称
if (objvClsRmTeachingCase_BaseEN.IdGradeBase == "[null]") objvClsRmTeachingCase_BaseEN.IdGradeBase = null; //年级流水号
if (objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion == "[null]") objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvClsRmTeachingCase_BaseEN.senateGaugeVersionID == "[null]") objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvClsRmTeachingCase_BaseEN.senateGaugeVersionName == "[null]") objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvClsRmTeachingCase_BaseEN.TeachSkillID == "[null]") objvClsRmTeachingCase_BaseEN.TeachSkillID = null; //教学技能ID
if (objvClsRmTeachingCase_BaseEN.SkillTypeName == "[null]") objvClsRmTeachingCase_BaseEN.SkillTypeName = null; //技能类型名称
if (objvClsRmTeachingCase_BaseEN.TeachSkillName == "[null]") objvClsRmTeachingCase_BaseEN.TeachSkillName = null; //教学技能名称
if (objvClsRmTeachingCase_BaseEN.TeachSkillTheory == "[null]") objvClsRmTeachingCase_BaseEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod == "[null]") objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvClsRmTeachingCase_BaseEN.IdSkillType == "[null]") objvClsRmTeachingCase_BaseEN.IdSkillType = null; //技能类型流水号
if (objvClsRmTeachingCase_BaseEN.SkillTypeID == "[null]") objvClsRmTeachingCase_BaseEN.SkillTypeID = null; //技能类型ID
if (objvClsRmTeachingCase_BaseEN.CaseLevelId == "[null]") objvClsRmTeachingCase_BaseEN.CaseLevelId = null; //课例等级Id
if (objvClsRmTeachingCase_BaseEN.CaseLevelName == "[null]") objvClsRmTeachingCase_BaseEN.CaseLevelName = null; //案例等级名称
if (objvClsRmTeachingCase_BaseEN.DocFile == "[null]") objvClsRmTeachingCase_BaseEN.DocFile = null; //生成的Word文件名
if (objvClsRmTeachingCase_BaseEN.WordCreateDate == "[null]") objvClsRmTeachingCase_BaseEN.WordCreateDate = null; //Word生成日期
if (objvClsRmTeachingCase_BaseEN.IdStudentInfo == "[null]") objvClsRmTeachingCase_BaseEN.IdStudentInfo = null; //学生流水号
if (objvClsRmTeachingCase_BaseEN.StuName == "[null]") objvClsRmTeachingCase_BaseEN.StuName = null; //姓名
if (objvClsRmTeachingCase_BaseEN.StuId == "[null]") objvClsRmTeachingCase_BaseEN.StuId = null; //学号
if (objvClsRmTeachingCase_BaseEN.PoliticsName == "[null]") objvClsRmTeachingCase_BaseEN.PoliticsName = null; //政治面貌
if (objvClsRmTeachingCase_BaseEN.SexDesc == "[null]") objvClsRmTeachingCase_BaseEN.SexDesc = null; //性别名称
if (objvClsRmTeachingCase_BaseEN.EthnicName == "[null]") objvClsRmTeachingCase_BaseEN.EthnicName = null; //民族名称
if (objvClsRmTeachingCase_BaseEN.UniZoneDesc == "[null]") objvClsRmTeachingCase_BaseEN.UniZoneDesc = null; //校区名称
if (objvClsRmTeachingCase_BaseEN.StuTypeDesc == "[null]") objvClsRmTeachingCase_BaseEN.StuTypeDesc = null; //学生类别名称
if (objvClsRmTeachingCase_BaseEN.IdXzCollege == "[null]") objvClsRmTeachingCase_BaseEN.IdXzCollege = null; //学院流水号
if (objvClsRmTeachingCase_BaseEN.CollegeId == "[null]") objvClsRmTeachingCase_BaseEN.CollegeId = null; //学院ID
if (objvClsRmTeachingCase_BaseEN.CollegeName == "[null]") objvClsRmTeachingCase_BaseEN.CollegeName = null; //学院名称
if (objvClsRmTeachingCase_BaseEN.CollegeNameA == "[null]") objvClsRmTeachingCase_BaseEN.CollegeNameA = null; //学院名称简写
if (objvClsRmTeachingCase_BaseEN.IdXzMajor == "[null]") objvClsRmTeachingCase_BaseEN.IdXzMajor = null; //专业流水号
if (objvClsRmTeachingCase_BaseEN.MajorName == "[null]") objvClsRmTeachingCase_BaseEN.MajorName = null; //专业名称
if (objvClsRmTeachingCase_BaseEN.GradeBaseName == "[null]") objvClsRmTeachingCase_BaseEN.GradeBaseName = null; //年级名称
if (objvClsRmTeachingCase_BaseEN.IdAdminCls == "[null]") objvClsRmTeachingCase_BaseEN.IdAdminCls = null; //行政班流水号
if (objvClsRmTeachingCase_BaseEN.AdminClsId == "[null]") objvClsRmTeachingCase_BaseEN.AdminClsId = null; //行政班代号
if (objvClsRmTeachingCase_BaseEN.AdminClsName == "[null]") objvClsRmTeachingCase_BaseEN.AdminClsName = null; //行政班名称
if (objvClsRmTeachingCase_BaseEN.Birthday == "[null]") objvClsRmTeachingCase_BaseEN.Birthday = null; //出生日期
if (objvClsRmTeachingCase_BaseEN.NativePlace == "[null]") objvClsRmTeachingCase_BaseEN.NativePlace = null; //籍贯
if (objvClsRmTeachingCase_BaseEN.Duty == "[null]") objvClsRmTeachingCase_BaseEN.Duty = null; //职位
if (objvClsRmTeachingCase_BaseEN.IdCardNo == "[null]") objvClsRmTeachingCase_BaseEN.IdCardNo = null; //身份证号
if (objvClsRmTeachingCase_BaseEN.StuCardNo == "[null]") objvClsRmTeachingCase_BaseEN.StuCardNo = null; //学生证号
if (objvClsRmTeachingCase_BaseEN.LiveAddress == "[null]") objvClsRmTeachingCase_BaseEN.LiveAddress = null; //居住地址
if (objvClsRmTeachingCase_BaseEN.HomePhone == "[null]") objvClsRmTeachingCase_BaseEN.HomePhone = null; //住宅电话
if (objvClsRmTeachingCase_BaseEN.EnrollmentDate == "[null]") objvClsRmTeachingCase_BaseEN.EnrollmentDate = null; //入校日期
if (objvClsRmTeachingCase_BaseEN.PostCode == "[null]") objvClsRmTeachingCase_BaseEN.PostCode = null; //邮编
if (objvClsRmTeachingCase_BaseEN.UserKindName == "[null]") objvClsRmTeachingCase_BaseEN.UserKindName = null; //用户类别名
if (objvClsRmTeachingCase_BaseEN.UserTypeId == "[null]") objvClsRmTeachingCase_BaseEN.UserTypeId = null; //用户类型Id
if (objvClsRmTeachingCase_BaseEN.RecommendedDegreeName == "[null]") objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvClsRmTeachingCase_BaseEN.Memo == "[null]") objvClsRmTeachingCase_BaseEN.Memo = null; //备注
if (objvClsRmTeachingCase_BaseEN.DisciplineNamePs == "[null]") objvClsRmTeachingCase_BaseEN.DisciplineNamePs = null; //学科
if (objvClsRmTeachingCase_BaseEN.GradeNamePs == "[null]") objvClsRmTeachingCase_BaseEN.GradeNamePs = null; //年级
if (objvClsRmTeachingCase_BaseEN.IdGradePs == "[null]") objvClsRmTeachingCase_BaseEN.IdGradePs = null; //年级流水号
if (objvClsRmTeachingCase_BaseEN.OwnerName == "[null]") objvClsRmTeachingCase_BaseEN.OwnerName = null; //拥有者姓名
if (objvClsRmTeachingCase_BaseEN.OwnerNameWithId == "[null]") objvClsRmTeachingCase_BaseEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvClsRmTeachingCase_BaseEN.CaseTypeName == "[null]") objvClsRmTeachingCase_BaseEN.CaseTypeName = null; //案例类型名称
if (objvClsRmTeachingCase_BaseEN.ftpFileType == "[null]") objvClsRmTeachingCase_BaseEN.ftpFileType = null; //ftp文件类型
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
public static void CheckProperty4Condition(clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN)
{
 vClsRmTeachingCase_BaseDA.CheckProperty4Condition(objvClsRmTeachingCase_BaseEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convClsRmTeachingCase_Base.IdClsRmTeachingCase); 
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = clsvClsRmTeachingCase_BaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN()
{
IdClsRmTeachingCase = "0",
ClsRmTeachingCaseName = "选[v课堂教学案例_Base]..."
};
arrObjLst.Insert(0, objvClsRmTeachingCase_BaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convClsRmTeachingCase_Base.IdClsRmTeachingCase;
objComboBox.DisplayMember = convClsRmTeachingCase_Base.ClsRmTeachingCaseName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课堂教学案例_Base]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convClsRmTeachingCase_Base.IdClsRmTeachingCase); 
IEnumerable<clsvClsRmTeachingCase_BaseEN> arrObjLst = clsvClsRmTeachingCase_BaseBL.GetObjLst(strCondition);
objDDL.DataValueField = convClsRmTeachingCase_Base.IdClsRmTeachingCase;
objDDL.DataTextField = convClsRmTeachingCase_Base.ClsRmTeachingCaseName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课堂教学案例_Base]...","0");
List<clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst = GetAllvClsRmTeachingCase_BaseObjLstCache(); 
objDDL.DataValueField = convClsRmTeachingCase_Base.IdClsRmTeachingCase;
objDDL.DataTextField = convClsRmTeachingCase_Base.ClsRmTeachingCaseName;
objDDL.DataSource = arrvClsRmTeachingCase_BaseObjLst;
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
if (clsCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeBL没有刷新缓存机制(clsCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvClsRmTeachingCase_BaseObjLstCache == null)
//{
//arrvClsRmTeachingCase_BaseObjLstCache = vClsRmTeachingCase_BaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClsRmTeachingCase_BaseEN GetObjByIdClsRmTeachingCaseCache(string strIdClsRmTeachingCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvClsRmTeachingCase_BaseEN._CurrTabName);
List<clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLst_Sel =
arrvClsRmTeachingCase_BaseObjLstCache
.Where(x=> x.IdClsRmTeachingCase == strIdClsRmTeachingCase 
);
if (arrvClsRmTeachingCase_BaseObjLst_Sel.Count() == 0)
{
   clsvClsRmTeachingCase_BaseEN obj = clsvClsRmTeachingCase_BaseBL.GetObjByIdClsRmTeachingCase(strIdClsRmTeachingCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvClsRmTeachingCase_BaseObjLst_Sel.First();
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
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_Base = GetObjByIdClsRmTeachingCaseCache(strIdClsRmTeachingCase);
if (objvClsRmTeachingCase_Base == null) return "";
return objvClsRmTeachingCase_Base.ClsRmTeachingCaseName;
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
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_Base = GetObjByIdClsRmTeachingCaseCache(strIdClsRmTeachingCase);
if (objvClsRmTeachingCase_Base == null) return "";
return objvClsRmTeachingCase_Base.ClsRmTeachingCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvClsRmTeachingCase_BaseEN> GetAllvClsRmTeachingCase_BaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLstCache = GetObjLstCache(); 
return arrvClsRmTeachingCase_BaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvClsRmTeachingCase_BaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvClsRmTeachingCase_BaseEN._CurrTabName);
List<clsvClsRmTeachingCase_BaseEN> arrvClsRmTeachingCase_BaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClsRmTeachingCase_BaseObjLstCache;
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
string strKey = string.Format("{0}", clsvClsRmTeachingCase_BaseEN._CurrTabName);
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
if (strInFldName != convClsRmTeachingCase_Base.IdClsRmTeachingCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convClsRmTeachingCase_Base.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convClsRmTeachingCase_Base.AttributeName));
throw new Exception(strMsg);
}
var objvClsRmTeachingCase_Base = clsvClsRmTeachingCase_BaseBL.GetObjByIdClsRmTeachingCaseCache(strIdClsRmTeachingCase);
if (objvClsRmTeachingCase_Base == null) return "";
return objvClsRmTeachingCase_Base[strOutFldName].ToString();
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
int intRecCount = clsvClsRmTeachingCase_BaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvClsRmTeachingCase_BaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvClsRmTeachingCase_BaseDA.GetRecCount();
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
int intRecCount = clsvClsRmTeachingCase_BaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseCond)
{
List<clsvClsRmTeachingCase_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvClsRmTeachingCase_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convClsRmTeachingCase_Base.AttributeName)
{
if (objvClsRmTeachingCase_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvClsRmTeachingCase_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClsRmTeachingCase_BaseCond[strFldName].ToString());
}
else
{
if (objvClsRmTeachingCase_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvClsRmTeachingCase_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClsRmTeachingCase_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvClsRmTeachingCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvClsRmTeachingCase_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvClsRmTeachingCase_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvClsRmTeachingCase_BaseCond[strFldName]));
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
 List<string> arrList = clsvClsRmTeachingCase_BaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vClsRmTeachingCase_BaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vClsRmTeachingCase_BaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}