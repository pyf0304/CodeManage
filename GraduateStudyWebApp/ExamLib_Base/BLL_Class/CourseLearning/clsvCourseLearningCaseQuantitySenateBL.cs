
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseQuantitySenateBL
 表名:vCourseLearningCaseQuantitySenate(01120455)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsvCourseLearningCaseQuantitySenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseQuantitySenateEN GetObj(this K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenate myKey)
{
clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = clsvCourseLearningCaseQuantitySenateBL.vCourseLearningCaseQuantitySenateDA.GetObjByIdmicroteachCaseQuantitySenate(myKey.Value);
return objvCourseLearningCaseQuantitySenateEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetIdCourseLearningCase(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strIdCourseLearningCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCase, 8, convCourseLearningCaseQuantitySenate.IdCourseLearningCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCase, 8, convCourseLearningCaseQuantitySenate.IdCourseLearningCase);
}
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = strIdCourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.IdCourseLearningCase) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.IdCourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseID(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseID);
}
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseLearningCaseID) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCaseQuantitySenate.CourseLearningCaseName);
}
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseLearningCaseName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseTheme(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme);
}
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseDate(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseDate);
}
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseLearningCaseDate) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseTime(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningCaseQuantitySenate.CourseLearningCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningCaseQuantitySenate.CourseLearningCaseTime);
}
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseLearningCaseTime) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseDateIn(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn);
}
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseTimeIn(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn);
}
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseTypeName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName);
}
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetOwnerId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCourseLearningCaseQuantitySenate.OwnerId);
}
objvCourseLearningCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.OwnerId) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetOwnerName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCourseLearningCaseQuantitySenate.OwnerName);
}
objvCourseLearningCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.OwnerName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetOwnerNameWithId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCourseLearningCaseQuantitySenate.OwnerNameWithId);
}
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.OwnerNameWithId) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.OwnerNameWithId, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.OwnerNameWithId] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserNameWithUserId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convCourseLearningCaseQuantitySenate.UserNameWithUserId);
}
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.UserNameWithUserId) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetIsDualVideo(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.IsDualVideo) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.IsDualVideo, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IsDualVideo] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetIdXzCollege(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCourseLearningCaseQuantitySenate.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCourseLearningCaseQuantitySenate.IdXzCollege);
}
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.IdXzCollege) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.IdXzCollege, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdXzCollege] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCollegeID(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningCaseQuantitySenate.CollegeID);
}
objvCourseLearningCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CollegeID) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCollegeName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCaseQuantitySenate.CollegeName);
}
objvCourseLearningCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CollegeName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetIdXzMajor(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convCourseLearningCaseQuantitySenate.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convCourseLearningCaseQuantitySenate.IdXzMajor);
}
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.IdXzMajor) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.IdXzMajor, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdXzMajor] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetMajorID(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCaseQuantitySenate.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCaseQuantitySenate.MajorID);
}
objvCourseLearningCaseQuantitySenateEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.MajorID) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetMajorName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCaseQuantitySenate.MajorName);
}
objvCourseLearningCaseQuantitySenateEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.MajorName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCaseQuantitySenate.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCaseQuantitySenate.CourseId);
}
objvCourseLearningCaseQuantitySenateEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseId) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseCode(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCaseQuantitySenate.CourseCode);
}
objvCourseLearningCaseQuantitySenateEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseCode) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCaseQuantitySenate.CourseName);
}
objvCourseLearningCaseQuantitySenateEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CourseName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetViewCount(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, int? intViewCount, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.ViewCount) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.ViewCount, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.ViewCount] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetIsShow(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, bool bolIsShow, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.IsShow) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.IsShow, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IsShow] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetDownloadNumber(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.DownloadNumber) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.DownloadNumber, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.DownloadNumber] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetFileIntegration(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, int? intFileIntegration, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.FileIntegration) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.FileIntegration, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.FileIntegration] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetLikeCount(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, long? lngLikeCount, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.LikeCount) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.LikeCount, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.LikeCount] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCollectionCount(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CollectionCount) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CollectionCount, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollectionCount] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCollegeNameA(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningCaseQuantitySenate.CollegeNameA);
}
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.CollegeNameA) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetIdmicroteachCaseQuantitySenate(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, long lngIdmicroteachCaseQuantitySenate, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetFuncModuleId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCourseLearningCaseQuantitySenate.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningCaseQuantitySenate.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningCaseQuantitySenate.FuncModuleId);
}
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.FuncModuleId) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetFuncModuleName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningCaseQuantitySenate.FuncModuleName);
}
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.FuncModuleName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetIdMicroteachCase(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convCourseLearningCaseQuantitySenate.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convCourseLearningCaseQuantitySenate.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convCourseLearningCaseQuantitySenate.IdMicroteachCase);
}
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.IdMicroteachCase) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.IdMicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdMicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetIdAppraiseType(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, convCourseLearningCaseQuantitySenate.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convCourseLearningCaseQuantitySenate.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convCourseLearningCaseQuantitySenate.IdAppraiseType);
}
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.IdAppraiseType) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.IdAppraiseType, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdAppraiseType] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetAppraiseTypeName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convCourseLearningCaseQuantitySenate.AppraiseTypeName);
}
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.AppraiseTypeName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateTheme(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convCourseLearningCaseQuantitySenate.SenateTheme);
}
objvCourseLearningCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.SenateTheme) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateContent(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convCourseLearningCaseQuantitySenate.SenateContent);
}
objvCourseLearningCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.SenateContent) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateTotalScore(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convCourseLearningCaseQuantitySenate.SenateTotalScore);
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.SenateTotalScore) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateDate(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convCourseLearningCaseQuantitySenate.SenateDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convCourseLearningCaseQuantitySenate.SenateDate);
}
objvCourseLearningCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.SenateDate) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateTime(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convCourseLearningCaseQuantitySenate.SenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convCourseLearningCaseQuantitySenate.SenateTime);
}
objvCourseLearningCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.SenateTime) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateIp(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, convCourseLearningCaseQuantitySenate.SenateIp);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convCourseLearningCaseQuantitySenate.SenateIp);
}
objvCourseLearningCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.SenateIp) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetBrowseCount(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, int? intBrowseCount, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.BrowseCount) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetIdSenateGaugeVersion(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion);
}
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCourseLearningCaseQuantitySenate.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCourseLearningCaseQuantitySenate.senateGaugeVersionID);
}
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCaseQuantitySenate.senateGaugeVersionName);
}
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCourseLearningCaseQuantitySenate.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convCourseLearningCaseQuantitySenate.UserId);
}
objvCourseLearningCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.UserId) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convCourseLearningCaseQuantitySenate.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convCourseLearningCaseQuantitySenate.UserName);
}
objvCourseLearningCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.UserName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserKindId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convCourseLearningCaseQuantitySenate.UserKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convCourseLearningCaseQuantitySenate.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convCourseLearningCaseQuantitySenate.UserKindId);
}
objvCourseLearningCaseQuantitySenateEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.UserKindId) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.UserKindId, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserKindId] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserKindName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convCourseLearningCaseQuantitySenate.UserKindName);
}
objvCourseLearningCaseQuantitySenateEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.UserKindName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.UserKindName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserKindName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUpdUser(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCourseLearningCaseQuantitySenate.UpdUser);
}
objvCourseLearningCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.UpdUser) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUpdUserName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convCourseLearningCaseQuantitySenate.UpdUserName);
}
objvCourseLearningCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.UpdUserName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetMemo(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCaseQuantitySenate.Memo);
}
objvCourseLearningCaseQuantitySenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.Memo) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.Memo, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.Memo] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserTypeName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convCourseLearningCaseQuantitySenate.UserTypeName);
}
objvCourseLearningCaseQuantitySenateEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.UserTypeName) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.UserTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvCourseLearningCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateENS, clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateENT)
{
try
{
objvCourseLearningCaseQuantitySenateENT.IdCourseLearningCase = objvCourseLearningCaseQuantitySenateENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseID = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseName = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTheme = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseDate = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTime = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseDateIn = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTimeIn = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTypeName = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateENT.OwnerId = objvCourseLearningCaseQuantitySenateENS.OwnerId; //拥有者Id
objvCourseLearningCaseQuantitySenateENT.OwnerName = objvCourseLearningCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvCourseLearningCaseQuantitySenateENT.OwnerNameWithId = objvCourseLearningCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCaseQuantitySenateENT.UserNameWithUserId = objvCourseLearningCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvCourseLearningCaseQuantitySenateENT.IsDualVideo = objvCourseLearningCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvCourseLearningCaseQuantitySenateENT.IdXzCollege = objvCourseLearningCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvCourseLearningCaseQuantitySenateENT.CollegeID = objvCourseLearningCaseQuantitySenateENS.CollegeID; //学院ID
objvCourseLearningCaseQuantitySenateENT.CollegeName = objvCourseLearningCaseQuantitySenateENS.CollegeName; //学院名称
objvCourseLearningCaseQuantitySenateENT.IdXzMajor = objvCourseLearningCaseQuantitySenateENS.IdXzMajor; //专业流水号
objvCourseLearningCaseQuantitySenateENT.MajorID = objvCourseLearningCaseQuantitySenateENS.MajorID; //专业ID
objvCourseLearningCaseQuantitySenateENT.MajorName = objvCourseLearningCaseQuantitySenateENS.MajorName; //专业名称
objvCourseLearningCaseQuantitySenateENT.CourseId = objvCourseLearningCaseQuantitySenateENS.CourseId; //课程Id
objvCourseLearningCaseQuantitySenateENT.CourseCode = objvCourseLearningCaseQuantitySenateENS.CourseCode; //课程代码
objvCourseLearningCaseQuantitySenateENT.CourseName = objvCourseLearningCaseQuantitySenateENS.CourseName; //课程名称
objvCourseLearningCaseQuantitySenateENT.ViewCount = objvCourseLearningCaseQuantitySenateENS.ViewCount; //浏览量
objvCourseLearningCaseQuantitySenateENT.IsShow = objvCourseLearningCaseQuantitySenateENS.IsShow; //是否启用
objvCourseLearningCaseQuantitySenateENT.DownloadNumber = objvCourseLearningCaseQuantitySenateENS.DownloadNumber; //下载数目
objvCourseLearningCaseQuantitySenateENT.FileIntegration = objvCourseLearningCaseQuantitySenateENS.FileIntegration; //文件积分
objvCourseLearningCaseQuantitySenateENT.LikeCount = objvCourseLearningCaseQuantitySenateENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseQuantitySenateENT.CollectionCount = objvCourseLearningCaseQuantitySenateENS.CollectionCount; //收藏数量
objvCourseLearningCaseQuantitySenateENT.CollegeNameA = objvCourseLearningCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvCourseLearningCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvCourseLearningCaseQuantitySenateENT.FuncModuleId = objvCourseLearningCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseQuantitySenateENT.FuncModuleName = objvCourseLearningCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseQuantitySenateENT.IdMicroteachCase = objvCourseLearningCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningCaseQuantitySenateENT.IdAppraiseType = objvCourseLearningCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvCourseLearningCaseQuantitySenateENT.AppraiseTypeName = objvCourseLearningCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvCourseLearningCaseQuantitySenateENT.SenateTheme = objvCourseLearningCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvCourseLearningCaseQuantitySenateENT.SenateContent = objvCourseLearningCaseQuantitySenateENS.SenateContent; //评价内容
objvCourseLearningCaseQuantitySenateENT.SenateTotalScore = objvCourseLearningCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvCourseLearningCaseQuantitySenateENT.SenateDate = objvCourseLearningCaseQuantitySenateENS.SenateDate; //评价日期
objvCourseLearningCaseQuantitySenateENT.SenateTime = objvCourseLearningCaseQuantitySenateENS.SenateTime; //评价时间
objvCourseLearningCaseQuantitySenateENT.SenateIp = objvCourseLearningCaseQuantitySenateENS.SenateIp; //评议Ip
objvCourseLearningCaseQuantitySenateENT.BrowseCount = objvCourseLearningCaseQuantitySenateENS.BrowseCount; //浏览次数
objvCourseLearningCaseQuantitySenateENT.IdSenateGaugeVersion = objvCourseLearningCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseQuantitySenateENT.senateGaugeVersionID = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseQuantitySenateENT.senateGaugeVersionName = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseQuantitySenateENT.UserId = objvCourseLearningCaseQuantitySenateENS.UserId; //用户ID
objvCourseLearningCaseQuantitySenateENT.UserName = objvCourseLearningCaseQuantitySenateENS.UserName; //用户名
objvCourseLearningCaseQuantitySenateENT.UserKindId = objvCourseLearningCaseQuantitySenateENS.UserKindId; //用户类别Id
objvCourseLearningCaseQuantitySenateENT.UserKindName = objvCourseLearningCaseQuantitySenateENS.UserKindName; //用户类别名
objvCourseLearningCaseQuantitySenateENT.UpdUser = objvCourseLearningCaseQuantitySenateENS.UpdUser; //修改人
objvCourseLearningCaseQuantitySenateENT.UpdUserName = objvCourseLearningCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvCourseLearningCaseQuantitySenateENT.Memo = objvCourseLearningCaseQuantitySenateENS.Memo; //备注
objvCourseLearningCaseQuantitySenateENT.UserTypeName = objvCourseLearningCaseQuantitySenateENS.UserTypeName; //用户类型名称
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
 /// <param name = "objvCourseLearningCaseQuantitySenateENS">源对象</param>
 /// <returns>目标对象=>clsvCourseLearningCaseQuantitySenateEN:objvCourseLearningCaseQuantitySenateENT</returns>
 public static clsvCourseLearningCaseQuantitySenateEN CopyTo(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateENS)
{
try
{
 clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateENT = new clsvCourseLearningCaseQuantitySenateEN()
{
IdCourseLearningCase = objvCourseLearningCaseQuantitySenateENS.IdCourseLearningCase, //课程学习案例流水号
CourseLearningCaseID = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseID, //课程学习案例ID
CourseLearningCaseName = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseName, //课程学习案例名称
CourseLearningCaseTheme = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTheme, //课程学习案例主题词
CourseLearningCaseDate = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseDate, //课程学习日期
CourseLearningCaseTime = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTime, //课程学习时间
CourseLearningCaseDateIn = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseDateIn, //案例入库日期
CourseLearningCaseTimeIn = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTimeIn, //案例入库时间
CourseLearningCaseTypeName = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTypeName, //课程学习案例类型名称
OwnerId = objvCourseLearningCaseQuantitySenateENS.OwnerId, //拥有者Id
OwnerName = objvCourseLearningCaseQuantitySenateENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvCourseLearningCaseQuantitySenateENS.OwnerNameWithId, //拥有者名称附Id
UserNameWithUserId = objvCourseLearningCaseQuantitySenateENS.UserNameWithUserId, //UserNameWithUserId
IsDualVideo = objvCourseLearningCaseQuantitySenateENS.IsDualVideo, //是否双视频
IdXzCollege = objvCourseLearningCaseQuantitySenateENS.IdXzCollege, //学院流水号
CollegeID = objvCourseLearningCaseQuantitySenateENS.CollegeID, //学院ID
CollegeName = objvCourseLearningCaseQuantitySenateENS.CollegeName, //学院名称
IdXzMajor = objvCourseLearningCaseQuantitySenateENS.IdXzMajor, //专业流水号
MajorID = objvCourseLearningCaseQuantitySenateENS.MajorID, //专业ID
MajorName = objvCourseLearningCaseQuantitySenateENS.MajorName, //专业名称
CourseId = objvCourseLearningCaseQuantitySenateENS.CourseId, //课程Id
CourseCode = objvCourseLearningCaseQuantitySenateENS.CourseCode, //课程代码
CourseName = objvCourseLearningCaseQuantitySenateENS.CourseName, //课程名称
ViewCount = objvCourseLearningCaseQuantitySenateENS.ViewCount, //浏览量
IsShow = objvCourseLearningCaseQuantitySenateENS.IsShow, //是否启用
DownloadNumber = objvCourseLearningCaseQuantitySenateENS.DownloadNumber, //下载数目
FileIntegration = objvCourseLearningCaseQuantitySenateENS.FileIntegration, //文件积分
LikeCount = objvCourseLearningCaseQuantitySenateENS.LikeCount, //资源喜欢数量
CollectionCount = objvCourseLearningCaseQuantitySenateENS.CollectionCount, //收藏数量
CollegeNameA = objvCourseLearningCaseQuantitySenateENS.CollegeNameA, //学院名称简写
IdmicroteachCaseQuantitySenate = objvCourseLearningCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate, //微格量化评价流水号
FuncModuleId = objvCourseLearningCaseQuantitySenateENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCourseLearningCaseQuantitySenateENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvCourseLearningCaseQuantitySenateENS.IdMicroteachCase, //微格教学案例流水号
IdAppraiseType = objvCourseLearningCaseQuantitySenateENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvCourseLearningCaseQuantitySenateENS.AppraiseTypeName, //评议类型名称
SenateTheme = objvCourseLearningCaseQuantitySenateENS.SenateTheme, //量化评价主题
SenateContent = objvCourseLearningCaseQuantitySenateENS.SenateContent, //评价内容
SenateTotalScore = objvCourseLearningCaseQuantitySenateENS.SenateTotalScore, //评价分数
SenateDate = objvCourseLearningCaseQuantitySenateENS.SenateDate, //评价日期
SenateTime = objvCourseLearningCaseQuantitySenateENS.SenateTime, //评价时间
SenateIp = objvCourseLearningCaseQuantitySenateENS.SenateIp, //评议Ip
BrowseCount = objvCourseLearningCaseQuantitySenateENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objvCourseLearningCaseQuantitySenateENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionTtlScore, //评价量表版本总分
UserId = objvCourseLearningCaseQuantitySenateENS.UserId, //用户ID
UserName = objvCourseLearningCaseQuantitySenateENS.UserName, //用户名
UserKindId = objvCourseLearningCaseQuantitySenateENS.UserKindId, //用户类别Id
UserKindName = objvCourseLearningCaseQuantitySenateENS.UserKindName, //用户类别名
UpdUser = objvCourseLearningCaseQuantitySenateENS.UpdUser, //修改人
UpdUserName = objvCourseLearningCaseQuantitySenateENS.UpdUserName, //UpdUserName
Memo = objvCourseLearningCaseQuantitySenateENS.Memo, //备注
UserTypeName = objvCourseLearningCaseQuantitySenateENS.UserTypeName, //用户类型名称
};
 return objvCourseLearningCaseQuantitySenateENT;
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
public static void CheckProperty4Condition(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN)
{
 clsvCourseLearningCaseQuantitySenateBL.vCourseLearningCaseQuantitySenateDA.CheckProperty4Condition(objvCourseLearningCaseQuantitySenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.IdCourseLearningCase) == true)
{
string strComparisonOpIdCourseLearningCase = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdCourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.IdCourseLearningCase, objvCourseLearningCaseQuantitySenateCond.IdCourseLearningCase, strComparisonOpIdCourseLearningCase);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseID) == true)
{
string strComparisonOpCourseLearningCaseID = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseID, objvCourseLearningCaseQuantitySenateCond.CourseLearningCaseID, strComparisonOpCourseLearningCaseID);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseName, objvCourseLearningCaseQuantitySenateCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme) == true)
{
string strComparisonOpCourseLearningCaseTheme = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme, objvCourseLearningCaseQuantitySenateCond.CourseLearningCaseTheme, strComparisonOpCourseLearningCaseTheme);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseDate) == true)
{
string strComparisonOpCourseLearningCaseDate = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseDate, objvCourseLearningCaseQuantitySenateCond.CourseLearningCaseDate, strComparisonOpCourseLearningCaseDate);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseTime) == true)
{
string strComparisonOpCourseLearningCaseTime = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseTime, objvCourseLearningCaseQuantitySenateCond.CourseLearningCaseTime, strComparisonOpCourseLearningCaseTime);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn) == true)
{
string strComparisonOpCourseLearningCaseDateIn = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn, objvCourseLearningCaseQuantitySenateCond.CourseLearningCaseDateIn, strComparisonOpCourseLearningCaseDateIn);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn) == true)
{
string strComparisonOpCourseLearningCaseTimeIn = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn, objvCourseLearningCaseQuantitySenateCond.CourseLearningCaseTimeIn, strComparisonOpCourseLearningCaseTimeIn);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName) == true)
{
string strComparisonOpCourseLearningCaseTypeName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName, objvCourseLearningCaseQuantitySenateCond.CourseLearningCaseTypeName, strComparisonOpCourseLearningCaseTypeName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOpOwnerId = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.OwnerId, objvCourseLearningCaseQuantitySenateCond.OwnerId, strComparisonOpOwnerId);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOpOwnerName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.OwnerName, objvCourseLearningCaseQuantitySenateCond.OwnerName, strComparisonOpOwnerName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.OwnerNameWithId, objvCourseLearningCaseQuantitySenateCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOpUserNameWithUserId = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserNameWithUserId, objvCourseLearningCaseQuantitySenateCond.UserNameWithUserId, strComparisonOpUserNameWithUserId);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.IsDualVideo) == true)
{
if (objvCourseLearningCaseQuantitySenateCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseQuantitySenate.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseQuantitySenate.IsDualVideo);
}
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.IdXzCollege, objvCourseLearningCaseQuantitySenateCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOpCollegeID = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CollegeID, objvCourseLearningCaseQuantitySenateCond.CollegeID, strComparisonOpCollegeID);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CollegeName, objvCourseLearningCaseQuantitySenateCond.CollegeName, strComparisonOpCollegeName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.IdXzMajor, objvCourseLearningCaseQuantitySenateCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.MajorID) == true)
{
string strComparisonOpMajorID = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.MajorID, objvCourseLearningCaseQuantitySenateCond.MajorID, strComparisonOpMajorID);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.MajorName) == true)
{
string strComparisonOpMajorName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.MajorName, objvCourseLearningCaseQuantitySenateCond.MajorName, strComparisonOpMajorName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseId) == true)
{
string strComparisonOpCourseId = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseId, objvCourseLearningCaseQuantitySenateCond.CourseId, strComparisonOpCourseId);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseCode, objvCourseLearningCaseQuantitySenateCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseName) == true)
{
string strComparisonOpCourseName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseName, objvCourseLearningCaseQuantitySenateCond.CourseName, strComparisonOpCourseName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.ViewCount) == true)
{
string strComparisonOpViewCount = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.ViewCount, objvCourseLearningCaseQuantitySenateCond.ViewCount, strComparisonOpViewCount);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.IsShow) == true)
{
if (objvCourseLearningCaseQuantitySenateCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseQuantitySenate.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseQuantitySenate.IsShow);
}
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.DownloadNumber, objvCourseLearningCaseQuantitySenateCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.FileIntegration, objvCourseLearningCaseQuantitySenateCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.LikeCount) == true)
{
string strComparisonOpLikeCount = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.LikeCount, objvCourseLearningCaseQuantitySenateCond.LikeCount, strComparisonOpLikeCount);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.CollectionCount, objvCourseLearningCaseQuantitySenateCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CollegeNameA, objvCourseLearningCaseQuantitySenateCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate) == true)
{
string strComparisonOpIdmicroteachCaseQuantitySenate = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate, objvCourseLearningCaseQuantitySenateCond.IdmicroteachCaseQuantitySenate, strComparisonOpIdmicroteachCaseQuantitySenate);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.FuncModuleId, objvCourseLearningCaseQuantitySenateCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.FuncModuleName, objvCourseLearningCaseQuantitySenateCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.IdMicroteachCase, objvCourseLearningCaseQuantitySenateCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.IdAppraiseType, objvCourseLearningCaseQuantitySenateCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.AppraiseTypeName, objvCourseLearningCaseQuantitySenateCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOpSenateTheme = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.SenateTheme, objvCourseLearningCaseQuantitySenateCond.SenateTheme, strComparisonOpSenateTheme);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOpSenateContent = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.SenateContent, objvCourseLearningCaseQuantitySenateCond.SenateContent, strComparisonOpSenateContent);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOpSenateTotalScore = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.SenateTotalScore, objvCourseLearningCaseQuantitySenateCond.SenateTotalScore, strComparisonOpSenateTotalScore);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOpSenateDate = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.SenateDate, objvCourseLearningCaseQuantitySenateCond.SenateDate, strComparisonOpSenateDate);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOpSenateTime = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.SenateTime, objvCourseLearningCaseQuantitySenateCond.SenateTime, strComparisonOpSenateTime);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOpSenateIp = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.SenateIp, objvCourseLearningCaseQuantitySenateCond.SenateIp, strComparisonOpSenateIp);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.BrowseCount, objvCourseLearningCaseQuantitySenateCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion, objvCourseLearningCaseQuantitySenateCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.senateGaugeVersionID, objvCourseLearningCaseQuantitySenateCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.senateGaugeVersionName, objvCourseLearningCaseQuantitySenateCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore, objvCourseLearningCaseQuantitySenateCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.UserId) == true)
{
string strComparisonOpUserId = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserId, objvCourseLearningCaseQuantitySenateCond.UserId, strComparisonOpUserId);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.UserName) == true)
{
string strComparisonOpUserName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserName, objvCourseLearningCaseQuantitySenateCond.UserName, strComparisonOpUserName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOpUserKindId = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserKindId, objvCourseLearningCaseQuantitySenateCond.UserKindId, strComparisonOpUserKindId);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOpUserKindName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserKindName, objvCourseLearningCaseQuantitySenateCond.UserKindName, strComparisonOpUserKindName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UpdUser, objvCourseLearningCaseQuantitySenateCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOpUpdUserName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UpdUserName, objvCourseLearningCaseQuantitySenateCond.UpdUserName, strComparisonOpUpdUserName);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.Memo) == true)
{
string strComparisonOpMemo = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.Memo, objvCourseLearningCaseQuantitySenateCond.Memo, strComparisonOpMemo);
}
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(convCourseLearningCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserTypeName, objvCourseLearningCaseQuantitySenateCond.UserTypeName, strComparisonOpUserTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCourseLearningCaseQuantitySenate
{
public virtual bool UpdRelaTabDate(long lngIdmicroteachCaseQuantitySenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程学习案例资源量化评议(vCourseLearningCaseQuantitySenate)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCaseQuantitySenateBL
{
public static RelatedActions_vCourseLearningCaseQuantitySenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCourseLearningCaseQuantitySenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCourseLearningCaseQuantitySenateDA vCourseLearningCaseQuantitySenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCourseLearningCaseQuantitySenateDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCourseLearningCaseQuantitySenateBL()
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
if (string.IsNullOrEmpty(clsvCourseLearningCaseQuantitySenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseQuantitySenateEN._ConnectString);
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
public static DataTable GetDataTable_vCourseLearningCaseQuantitySenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCourseLearningCaseQuantitySenateDA.GetDataTable_vCourseLearningCaseQuantitySenate(strWhereCond);
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
objDT = vCourseLearningCaseQuantitySenateDA.GetDataTable(strWhereCond);
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
objDT = vCourseLearningCaseQuantitySenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCourseLearningCaseQuantitySenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCourseLearningCaseQuantitySenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCourseLearningCaseQuantitySenateDA.GetDataTable_Top(objTopPara);
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
objDT = vCourseLearningCaseQuantitySenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCourseLearningCaseQuantitySenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCourseLearningCaseQuantitySenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdmicroteachCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByIdmicroteachCaseQuantitySenateLst(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdmicroteachCaseQuantitySenateLst);
 string strWhereCond = string.Format("IdmicroteachCaseQuantitySenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdmicroteachCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByIdmicroteachCaseQuantitySenateLstCache(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateEN._CurrTabName);
List<clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLst_Sel =
arrvCourseLearningCaseQuantitySenateObjLstCache
.Where(x => arrIdmicroteachCaseQuantitySenateLst.Contains(x.IdmicroteachCaseQuantitySenate));
return arrvCourseLearningCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCourseLearningCaseQuantitySenateEN> GetSubObjLstCache(clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateCond)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseQuantitySenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCaseQuantitySenate.AttributeName)
{
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseQuantitySenateCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseQuantitySenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCaseQuantitySenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseQuantitySenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseQuantitySenateCond[strFldName]));
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
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
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
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
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCourseLearningCaseQuantitySenate(ref clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN)
{
bool bolResult = vCourseLearningCaseQuantitySenateDA.GetvCourseLearningCaseQuantitySenate(ref objvCourseLearningCaseQuantitySenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = vCourseLearningCaseQuantitySenateDA.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
return objvCourseLearningCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCourseLearningCaseQuantitySenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = vCourseLearningCaseQuantitySenateDA.GetFirstObj(strWhereCond);
 return objvCourseLearningCaseQuantitySenateEN;
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
public static clsvCourseLearningCaseQuantitySenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = vCourseLearningCaseQuantitySenateDA.GetObjByDataRow(objRow);
 return objvCourseLearningCaseQuantitySenateEN;
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
public static clsvCourseLearningCaseQuantitySenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = vCourseLearningCaseQuantitySenateDA.GetObjByDataRow(objRow);
 return objvCourseLearningCaseQuantitySenateEN;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">所给的关键字</param>
 /// <param name = "lstvCourseLearningCaseQuantitySenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenateFromList(long lngIdmicroteachCaseQuantitySenate, List<clsvCourseLearningCaseQuantitySenateEN> lstvCourseLearningCaseQuantitySenateObjLst)
{
foreach (clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN in lstvCourseLearningCaseQuantitySenateObjLst)
{
if (objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate)
{
return objvCourseLearningCaseQuantitySenateEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngIdmicroteachCaseQuantitySenate;
 try
 {
 lngIdmicroteachCaseQuantitySenate = new clsvCourseLearningCaseQuantitySenateDA().GetFirstID(strWhereCond);
 return lngIdmicroteachCaseQuantitySenate;
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
 arrList = vCourseLearningCaseQuantitySenateDA.GetID(strWhereCond);
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
bool bolIsExist = vCourseLearningCaseQuantitySenateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
//检测记录是否存在
bool bolIsExist = vCourseLearningCaseQuantitySenateDA.IsExist(lngIdmicroteachCaseQuantitySenate);
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
 bolIsExist = clsvCourseLearningCaseQuantitySenateDA.IsExistTable();
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
 bolIsExist = vCourseLearningCaseQuantitySenateDA.IsExistTable(strTabName);
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
 /// <param name = "objvCourseLearningCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvCourseLearningCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateENS, clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateENT)
{
try
{
objvCourseLearningCaseQuantitySenateENT.IdCourseLearningCase = objvCourseLearningCaseQuantitySenateENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseID = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseName = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTheme = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseDate = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTime = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseDateIn = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTimeIn = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTypeName = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateENT.OwnerId = objvCourseLearningCaseQuantitySenateENS.OwnerId; //拥有者Id
objvCourseLearningCaseQuantitySenateENT.OwnerName = objvCourseLearningCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvCourseLearningCaseQuantitySenateENT.OwnerNameWithId = objvCourseLearningCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCaseQuantitySenateENT.UserNameWithUserId = objvCourseLearningCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvCourseLearningCaseQuantitySenateENT.IsDualVideo = objvCourseLearningCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvCourseLearningCaseQuantitySenateENT.IdXzCollege = objvCourseLearningCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvCourseLearningCaseQuantitySenateENT.CollegeID = objvCourseLearningCaseQuantitySenateENS.CollegeID; //学院ID
objvCourseLearningCaseQuantitySenateENT.CollegeName = objvCourseLearningCaseQuantitySenateENS.CollegeName; //学院名称
objvCourseLearningCaseQuantitySenateENT.IdXzMajor = objvCourseLearningCaseQuantitySenateENS.IdXzMajor; //专业流水号
objvCourseLearningCaseQuantitySenateENT.MajorID = objvCourseLearningCaseQuantitySenateENS.MajorID; //专业ID
objvCourseLearningCaseQuantitySenateENT.MajorName = objvCourseLearningCaseQuantitySenateENS.MajorName; //专业名称
objvCourseLearningCaseQuantitySenateENT.CourseId = objvCourseLearningCaseQuantitySenateENS.CourseId; //课程Id
objvCourseLearningCaseQuantitySenateENT.CourseCode = objvCourseLearningCaseQuantitySenateENS.CourseCode; //课程代码
objvCourseLearningCaseQuantitySenateENT.CourseName = objvCourseLearningCaseQuantitySenateENS.CourseName; //课程名称
objvCourseLearningCaseQuantitySenateENT.ViewCount = objvCourseLearningCaseQuantitySenateENS.ViewCount; //浏览量
objvCourseLearningCaseQuantitySenateENT.IsShow = objvCourseLearningCaseQuantitySenateENS.IsShow; //是否启用
objvCourseLearningCaseQuantitySenateENT.DownloadNumber = objvCourseLearningCaseQuantitySenateENS.DownloadNumber; //下载数目
objvCourseLearningCaseQuantitySenateENT.FileIntegration = objvCourseLearningCaseQuantitySenateENS.FileIntegration; //文件积分
objvCourseLearningCaseQuantitySenateENT.LikeCount = objvCourseLearningCaseQuantitySenateENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseQuantitySenateENT.CollectionCount = objvCourseLearningCaseQuantitySenateENS.CollectionCount; //收藏数量
objvCourseLearningCaseQuantitySenateENT.CollegeNameA = objvCourseLearningCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvCourseLearningCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvCourseLearningCaseQuantitySenateENT.FuncModuleId = objvCourseLearningCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseQuantitySenateENT.FuncModuleName = objvCourseLearningCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseQuantitySenateENT.IdMicroteachCase = objvCourseLearningCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningCaseQuantitySenateENT.IdAppraiseType = objvCourseLearningCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvCourseLearningCaseQuantitySenateENT.AppraiseTypeName = objvCourseLearningCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvCourseLearningCaseQuantitySenateENT.SenateTheme = objvCourseLearningCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvCourseLearningCaseQuantitySenateENT.SenateContent = objvCourseLearningCaseQuantitySenateENS.SenateContent; //评价内容
objvCourseLearningCaseQuantitySenateENT.SenateTotalScore = objvCourseLearningCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvCourseLearningCaseQuantitySenateENT.SenateDate = objvCourseLearningCaseQuantitySenateENS.SenateDate; //评价日期
objvCourseLearningCaseQuantitySenateENT.SenateTime = objvCourseLearningCaseQuantitySenateENS.SenateTime; //评价时间
objvCourseLearningCaseQuantitySenateENT.SenateIp = objvCourseLearningCaseQuantitySenateENS.SenateIp; //评议Ip
objvCourseLearningCaseQuantitySenateENT.BrowseCount = objvCourseLearningCaseQuantitySenateENS.BrowseCount; //浏览次数
objvCourseLearningCaseQuantitySenateENT.IdSenateGaugeVersion = objvCourseLearningCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseQuantitySenateENT.senateGaugeVersionID = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseQuantitySenateENT.senateGaugeVersionName = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseQuantitySenateENT.UserId = objvCourseLearningCaseQuantitySenateENS.UserId; //用户ID
objvCourseLearningCaseQuantitySenateENT.UserName = objvCourseLearningCaseQuantitySenateENS.UserName; //用户名
objvCourseLearningCaseQuantitySenateENT.UserKindId = objvCourseLearningCaseQuantitySenateENS.UserKindId; //用户类别Id
objvCourseLearningCaseQuantitySenateENT.UserKindName = objvCourseLearningCaseQuantitySenateENS.UserKindName; //用户类别名
objvCourseLearningCaseQuantitySenateENT.UpdUser = objvCourseLearningCaseQuantitySenateENS.UpdUser; //修改人
objvCourseLearningCaseQuantitySenateENT.UpdUserName = objvCourseLearningCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvCourseLearningCaseQuantitySenateENT.Memo = objvCourseLearningCaseQuantitySenateENS.Memo; //备注
objvCourseLearningCaseQuantitySenateENT.UserTypeName = objvCourseLearningCaseQuantitySenateENS.UserTypeName; //用户类型名称
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
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">源简化对象</param>
 public static void SetUpdFlag(clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN)
{
try
{
objvCourseLearningCaseQuantitySenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCourseLearningCaseQuantitySenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.IdCourseLearningCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase; //课程学习案例流水号
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseLearningCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID; //课程学习案例ID
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme; //课程学习案例主题词
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseLearningCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate; //课程学习日期
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseLearningCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime; //课程学习时间
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName; //课程学习案例类型名称
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.OwnerId = objvCourseLearningCaseQuantitySenateEN.OwnerId == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.OwnerName = objvCourseLearningCaseQuantitySenateEN.OwnerName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.UserNameWithUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId; //UserNameWithUserId
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = objvCourseLearningCaseQuantitySenateEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objvCourseLearningCaseQuantitySenateEN.IdXzCollege == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CollegeID = objvCourseLearningCaseQuantitySenateEN.CollegeID == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CollegeName = objvCourseLearningCaseQuantitySenateEN.CollegeName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objvCourseLearningCaseQuantitySenateEN.IdXzMajor == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.MajorID = objvCourseLearningCaseQuantitySenateEN.MajorID == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.MajorName = objvCourseLearningCaseQuantitySenateEN.MajorName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseId = objvCourseLearningCaseQuantitySenateEN.CourseId == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseCode = objvCourseLearningCaseQuantitySenateEN.CourseCode == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CourseName = objvCourseLearningCaseQuantitySenateEN.CourseName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.ViewCount = objvCourseLearningCaseQuantitySenateEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.IsShow = objvCourseLearningCaseQuantitySenateEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objvCourseLearningCaseQuantitySenateEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objvCourseLearningCaseQuantitySenateEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.LikeCount = objvCourseLearningCaseQuantitySenateEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objvCourseLearningCaseQuantitySenateEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objvCourseLearningCaseQuantitySenateEN.CollegeNameA == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objvCourseLearningCaseQuantitySenateEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objvCourseLearningCaseQuantitySenateEN.FuncModuleName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objvCourseLearningCaseQuantitySenateEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.SenateTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objvCourseLearningCaseQuantitySenateEN.SenateTheme == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.SenateTheme; //量化评价主题
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.SenateContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.SenateContent = objvCourseLearningCaseQuantitySenateEN.SenateContent == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.SenateContent; //评价内容
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.SenateTotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = objvCourseLearningCaseQuantitySenateEN.SenateTotalScore; //评价分数
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.SenateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.SenateDate = objvCourseLearningCaseQuantitySenateEN.SenateDate == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.SenateDate; //评价日期
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.SenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.SenateTime = objvCourseLearningCaseQuantitySenateEN.SenateTime == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.SenateTime; //评价时间
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.SenateIp, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.SenateIp = objvCourseLearningCaseQuantitySenateEN.SenateIp; //评议Ip
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objvCourseLearningCaseQuantitySenateEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.UserId = objvCourseLearningCaseQuantitySenateEN.UserId; //用户ID
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.UserName = objvCourseLearningCaseQuantitySenateEN.UserName; //用户名
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.UserKindId = objvCourseLearningCaseQuantitySenateEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.UserKindName = objvCourseLearningCaseQuantitySenateEN.UserKindName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.UpdUser = objvCourseLearningCaseQuantitySenateEN.UpdUser == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.UpdUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objvCourseLearningCaseQuantitySenateEN.UpdUserName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.UpdUserName; //UpdUserName
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.Memo = objvCourseLearningCaseQuantitySenateEN.Memo == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.Memo; //备注
}
if (arrFldSet.Contains(convCourseLearningCaseQuantitySenate.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objvCourseLearningCaseQuantitySenateEN.UserTypeName == "[null]" ? null :  objvCourseLearningCaseQuantitySenateEN.UserTypeName; //用户类型名称
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
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN)
{
try
{
if (objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase == "[null]") objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = null; //课程学习案例流水号
if (objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = null; //课程学习案例ID
if (objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = null; //课程学习案例名称
if (objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = null; //课程学习案例主题词
if (objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = null; //课程学习日期
if (objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = null; //课程学习时间
if (objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = null; //案例入库日期
if (objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = null; //案例入库时间
if (objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = null; //课程学习案例类型名称
if (objvCourseLearningCaseQuantitySenateEN.OwnerId == "[null]") objvCourseLearningCaseQuantitySenateEN.OwnerId = null; //拥有者Id
if (objvCourseLearningCaseQuantitySenateEN.OwnerName == "[null]") objvCourseLearningCaseQuantitySenateEN.OwnerName = null; //拥有者姓名
if (objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId == "[null]") objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId == "[null]") objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = null; //UserNameWithUserId
if (objvCourseLearningCaseQuantitySenateEN.IdXzCollege == "[null]") objvCourseLearningCaseQuantitySenateEN.IdXzCollege = null; //学院流水号
if (objvCourseLearningCaseQuantitySenateEN.CollegeID == "[null]") objvCourseLearningCaseQuantitySenateEN.CollegeID = null; //学院ID
if (objvCourseLearningCaseQuantitySenateEN.CollegeName == "[null]") objvCourseLearningCaseQuantitySenateEN.CollegeName = null; //学院名称
if (objvCourseLearningCaseQuantitySenateEN.IdXzMajor == "[null]") objvCourseLearningCaseQuantitySenateEN.IdXzMajor = null; //专业流水号
if (objvCourseLearningCaseQuantitySenateEN.MajorID == "[null]") objvCourseLearningCaseQuantitySenateEN.MajorID = null; //专业ID
if (objvCourseLearningCaseQuantitySenateEN.MajorName == "[null]") objvCourseLearningCaseQuantitySenateEN.MajorName = null; //专业名称
if (objvCourseLearningCaseQuantitySenateEN.CourseId == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseId = null; //课程Id
if (objvCourseLearningCaseQuantitySenateEN.CourseCode == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseCode = null; //课程代码
if (objvCourseLearningCaseQuantitySenateEN.CourseName == "[null]") objvCourseLearningCaseQuantitySenateEN.CourseName = null; //课程名称
if (objvCourseLearningCaseQuantitySenateEN.CollegeNameA == "[null]") objvCourseLearningCaseQuantitySenateEN.CollegeNameA = null; //学院名称简写
if (objvCourseLearningCaseQuantitySenateEN.FuncModuleName == "[null]") objvCourseLearningCaseQuantitySenateEN.FuncModuleName = null; //功能模块名称
if (objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName == "[null]") objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = null; //评议类型名称
if (objvCourseLearningCaseQuantitySenateEN.SenateTheme == "[null]") objvCourseLearningCaseQuantitySenateEN.SenateTheme = null; //量化评价主题
if (objvCourseLearningCaseQuantitySenateEN.SenateContent == "[null]") objvCourseLearningCaseQuantitySenateEN.SenateContent = null; //评价内容
if (objvCourseLearningCaseQuantitySenateEN.SenateDate == "[null]") objvCourseLearningCaseQuantitySenateEN.SenateDate = null; //评价日期
if (objvCourseLearningCaseQuantitySenateEN.SenateTime == "[null]") objvCourseLearningCaseQuantitySenateEN.SenateTime = null; //评价时间
if (objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID == "[null]") objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName == "[null]") objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvCourseLearningCaseQuantitySenateEN.UserKindName == "[null]") objvCourseLearningCaseQuantitySenateEN.UserKindName = null; //用户类别名
if (objvCourseLearningCaseQuantitySenateEN.UpdUser == "[null]") objvCourseLearningCaseQuantitySenateEN.UpdUser = null; //修改人
if (objvCourseLearningCaseQuantitySenateEN.UpdUserName == "[null]") objvCourseLearningCaseQuantitySenateEN.UpdUserName = null; //UpdUserName
if (objvCourseLearningCaseQuantitySenateEN.Memo == "[null]") objvCourseLearningCaseQuantitySenateEN.Memo = null; //备注
if (objvCourseLearningCaseQuantitySenateEN.UserTypeName == "[null]") objvCourseLearningCaseQuantitySenateEN.UserTypeName = null; //用户类型名称
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
public static void CheckProperty4Condition(clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN)
{
 vCourseLearningCaseQuantitySenateDA.CheckProperty4Condition(objvCourseLearningCaseQuantitySenateEN);
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
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindBL没有刷新缓存机制(clsUserKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateBL没有刷新缓存机制(clsMicroteachCaseQuantitySenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseBL没有刷新缓存机制(clsCourseLearningCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseTypeBL没有刷新缓存机制(clsCourseLearningCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdmicroteachCaseQuantitySenate");
//if (arrvCourseLearningCaseQuantitySenateObjLstCache == null)
//{
//arrvCourseLearningCaseQuantitySenateObjLstCache = vCourseLearningCaseQuantitySenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenateCache(long lngIdmicroteachCaseQuantitySenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateEN._CurrTabName);
List<clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLst_Sel =
arrvCourseLearningCaseQuantitySenateObjLstCache
.Where(x=> x.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate 
);
if (arrvCourseLearningCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCaseQuantitySenateEN obj = clsvCourseLearningCaseQuantitySenateBL.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCourseLearningCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateEN> GetAllvCourseLearningCaseQuantitySenateObjLstCache()
{
//获取缓存中的对象列表
List<clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLstCache = GetObjLstCache(); 
return arrvCourseLearningCaseQuantitySenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateEN._CurrTabName);
List<clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCaseQuantitySenateObjLstCache;
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
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdmicroteachCaseQuantitySenate)
{
if (strInFldName != convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCourseLearningCaseQuantitySenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCourseLearningCaseQuantitySenate.AttributeName));
throw new Exception(strMsg);
}
var objvCourseLearningCaseQuantitySenate = clsvCourseLearningCaseQuantitySenateBL.GetObjByIdmicroteachCaseQuantitySenateCache(lngIdmicroteachCaseQuantitySenate);
if (objvCourseLearningCaseQuantitySenate == null) return "";
return objvCourseLearningCaseQuantitySenate[strOutFldName].ToString();
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
int intRecCount = clsvCourseLearningCaseQuantitySenateDA.GetRecCount(strTabName);
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
int intRecCount = clsvCourseLearningCaseQuantitySenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCourseLearningCaseQuantitySenateDA.GetRecCount();
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
int intRecCount = clsvCourseLearningCaseQuantitySenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateCond)
{
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseQuantitySenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCaseQuantitySenate.AttributeName)
{
if (objvCourseLearningCaseQuantitySenateCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseQuantitySenateCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCaseQuantitySenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseQuantitySenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCaseQuantitySenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseQuantitySenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseQuantitySenateCond[strFldName]));
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
 List<string> arrList = clsvCourseLearningCaseQuantitySenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCaseQuantitySenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCaseQuantitySenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}