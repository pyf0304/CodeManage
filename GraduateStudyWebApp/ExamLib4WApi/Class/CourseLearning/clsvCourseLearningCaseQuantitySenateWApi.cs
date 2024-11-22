
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseQuantitySenateWApi
 表名:vCourseLearningCaseQuantitySenate(01120455)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:22
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvCourseLearningCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetId_CourseLearningCase(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strId_CourseLearningCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CourseLearningCase, 8, convCourseLearningCaseQuantitySenate.Id_CourseLearningCase);
clsCheckSql.CheckFieldForeignKey(strId_CourseLearningCase, 8, convCourseLearningCaseQuantitySenate.Id_CourseLearningCase);
objvCourseLearningCaseQuantitySenateEN.Id_CourseLearningCase = strId_CourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.Id_CourseLearningCase) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.Id_CourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.Id_CourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseID(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseID);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCaseQuantitySenate.CourseLearningCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseTheme(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseDate(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseDate);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseTime(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningCaseQuantitySenate.CourseLearningCaseTime);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningCaseQuantitySenate.CourseLearningCaseTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseDateIn(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseTimeIn(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseLearningCaseTypeName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetOwnerId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCourseLearningCaseQuantitySenate.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetOwnerName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCourseLearningCaseQuantitySenate.OwnerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetOwnerNameWithId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCourseLearningCaseQuantitySenate.OwnerNameWithId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserNameWithUserId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convCourseLearningCaseQuantitySenate.UserNameWithUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN Setid_XzCollege(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCourseLearningCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCourseLearningCaseQuantitySenate.id_XzCollege);
objvCourseLearningCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.id_XzCollege) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCollegeID(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningCaseQuantitySenate.CollegeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCollegeName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCaseQuantitySenate.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN Setid_XzMajor(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCourseLearningCaseQuantitySenate.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCourseLearningCaseQuantitySenate.id_XzMajor);
objvCourseLearningCaseQuantitySenateEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.id_XzMajor) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.id_XzMajor, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_XzMajor] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetMajorID(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCaseQuantitySenate.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCaseQuantitySenate.MajorID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetMajorName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCaseQuantitySenate.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCaseQuantitySenate.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCaseQuantitySenate.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseCode(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCaseQuantitySenate.CourseCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCourseName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCaseQuantitySenate.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetViewCount(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, int intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetDownloadNumber(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, int intDownloadNumber, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetFileIntegration(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, int intFileIntegration, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetLikeCount(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, long lngLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCollectionCount(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, long lngCollectionCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetCollegeNameA(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningCaseQuantitySenate.CollegeNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetFuncModuleId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCourseLearningCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningCaseQuantitySenate.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetFuncModuleName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningCaseQuantitySenate.FuncModuleName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN Setid_MicroteachCase(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convCourseLearningCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCourseLearningCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCourseLearningCaseQuantitySenate.id_MicroteachCase);
objvCourseLearningCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.id_MicroteachCase) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN Setid_AppraiseType(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convCourseLearningCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convCourseLearningCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convCourseLearningCaseQuantitySenate.id_AppraiseType);
objvCourseLearningCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.id_AppraiseType) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetAppraiseTypeName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convCourseLearningCaseQuantitySenate.AppraiseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateTheme(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convCourseLearningCaseQuantitySenate.SenateTheme);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateContent(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convCourseLearningCaseQuantitySenate.SenateContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateDate(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convCourseLearningCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convCourseLearningCaseQuantitySenate.SenateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateTime(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convCourseLearningCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convCourseLearningCaseQuantitySenate.SenateTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetSenateIp(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, convCourseLearningCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(strSenateIp, 50, convCourseLearningCaseQuantitySenate.SenateIp);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetBrowseCount(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion);
objvCourseLearningCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCourseLearningCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCourseLearningCaseQuantitySenate.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCaseQuantitySenate.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCourseLearningCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convCourseLearningCaseQuantitySenate.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convCourseLearningCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convCourseLearningCaseQuantitySenate.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserKindId(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convCourseLearningCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convCourseLearningCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convCourseLearningCaseQuantitySenate.UserKindId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserKindName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convCourseLearningCaseQuantitySenate.UserKindName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUpdUser(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCourseLearningCaseQuantitySenate.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUpdUserName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convCourseLearningCaseQuantitySenate.UpdUserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetMemo(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCaseQuantitySenate.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateEN SetUserTypeName(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convCourseLearningCaseQuantitySenate.UserTypeName);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.Id_CourseLearningCase) == true)
{
string strComparisonOp_Id_CourseLearningCase = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.Id_CourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.Id_CourseLearningCase, objvCourseLearningCaseQuantitySenate_Cond.Id_CourseLearningCase, strComparisonOp_Id_CourseLearningCase);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseID) == true)
{
string strComparisonOp_CourseLearningCaseID = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseID, objvCourseLearningCaseQuantitySenate_Cond.CourseLearningCaseID, strComparisonOp_CourseLearningCaseID);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseName, objvCourseLearningCaseQuantitySenate_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme) == true)
{
string strComparisonOp_CourseLearningCaseTheme = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme, objvCourseLearningCaseQuantitySenate_Cond.CourseLearningCaseTheme, strComparisonOp_CourseLearningCaseTheme);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseDate) == true)
{
string strComparisonOp_CourseLearningCaseDate = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseDate, objvCourseLearningCaseQuantitySenate_Cond.CourseLearningCaseDate, strComparisonOp_CourseLearningCaseDate);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseTime) == true)
{
string strComparisonOp_CourseLearningCaseTime = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseTime, objvCourseLearningCaseQuantitySenate_Cond.CourseLearningCaseTime, strComparisonOp_CourseLearningCaseTime);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn) == true)
{
string strComparisonOp_CourseLearningCaseDateIn = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn, objvCourseLearningCaseQuantitySenate_Cond.CourseLearningCaseDateIn, strComparisonOp_CourseLearningCaseDateIn);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn) == true)
{
string strComparisonOp_CourseLearningCaseTimeIn = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn, objvCourseLearningCaseQuantitySenate_Cond.CourseLearningCaseTimeIn, strComparisonOp_CourseLearningCaseTimeIn);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName) == true)
{
string strComparisonOp_CourseLearningCaseTypeName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName, objvCourseLearningCaseQuantitySenate_Cond.CourseLearningCaseTypeName, strComparisonOp_CourseLearningCaseTypeName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.OwnerId, objvCourseLearningCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.OwnerName, objvCourseLearningCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.OwnerNameWithId, objvCourseLearningCaseQuantitySenate_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserNameWithUserId, objvCourseLearningCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.IsDualVideo) == true)
{
if (objvCourseLearningCaseQuantitySenate_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseQuantitySenate.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseQuantitySenate.IsDualVideo);
}
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.id_XzCollege, objvCourseLearningCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CollegeID, objvCourseLearningCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CollegeName, objvCourseLearningCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.id_XzMajor, objvCourseLearningCaseQuantitySenate_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.MajorID) == true)
{
string strComparisonOp_MajorID = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.MajorID, objvCourseLearningCaseQuantitySenate_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.MajorName) == true)
{
string strComparisonOp_MajorName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.MajorName, objvCourseLearningCaseQuantitySenate_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseId) == true)
{
string strComparisonOp_CourseId = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseId, objvCourseLearningCaseQuantitySenate_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseCode, objvCourseLearningCaseQuantitySenate_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CourseName) == true)
{
string strComparisonOp_CourseName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CourseName, objvCourseLearningCaseQuantitySenate_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.ViewCount, objvCourseLearningCaseQuantitySenate_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.IsShow) == true)
{
if (objvCourseLearningCaseQuantitySenate_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseQuantitySenate.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseQuantitySenate.IsShow);
}
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.DownloadNumber, objvCourseLearningCaseQuantitySenate_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.FileIntegration, objvCourseLearningCaseQuantitySenate_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.LikeCount, objvCourseLearningCaseQuantitySenate_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.CollectionCount, objvCourseLearningCaseQuantitySenate_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.CollegeNameA, objvCourseLearningCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.id_microteachCaseQuantitySenate, objvCourseLearningCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.FuncModuleId, objvCourseLearningCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.FuncModuleName, objvCourseLearningCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.id_MicroteachCase, objvCourseLearningCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.id_AppraiseType, objvCourseLearningCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.AppraiseTypeName, objvCourseLearningCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.SenateTheme, objvCourseLearningCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.SenateContent, objvCourseLearningCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.SenateTotalScore, objvCourseLearningCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.SenateDate, objvCourseLearningCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.SenateTime, objvCourseLearningCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.SenateIp, objvCourseLearningCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.BrowseCount, objvCourseLearningCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion, objvCourseLearningCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.senateGaugeVersionID, objvCourseLearningCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.senateGaugeVersionName, objvCourseLearningCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore, objvCourseLearningCaseQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserId, objvCourseLearningCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserName, objvCourseLearningCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserKindId, objvCourseLearningCaseQuantitySenate_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserKindName, objvCourseLearningCaseQuantitySenate_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UpdUser, objvCourseLearningCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UpdUserName, objvCourseLearningCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.Memo) == true)
{
string strComparisonOp_Memo = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.Memo, objvCourseLearningCaseQuantitySenate_Cond.Memo, strComparisonOp_Memo);
}
if (objvCourseLearningCaseQuantitySenate_Cond.IsUpdated(convCourseLearningCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvCourseLearningCaseQuantitySenate_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenate.UserTypeName, objvCourseLearningCaseQuantitySenate_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习案例资源量化评议(vCourseLearningCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningCaseQuantitySenateApi";

 public clsvCourseLearningCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseQuantitySenateEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseQuantitySenateEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvCourseLearningCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = null;
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
objvCourseLearningCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseQuantitySenateEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateEN._CurrTabName_S);
List<clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLst_Sel =
from objvCourseLearningCaseQuantitySenateEN in arrvCourseLearningCaseQuantitySenateObjLst_Cache
where objvCourseLearningCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvCourseLearningCaseQuantitySenateEN;
if (arrvCourseLearningCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCaseQuantitySenateEN obj = clsvCourseLearningCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_microteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCourseLearningCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateEN._CurrTabName_S);
List<clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLst_Sel =
from objvCourseLearningCaseQuantitySenateEN in arrvCourseLearningCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvCourseLearningCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvCourseLearningCaseQuantitySenateEN;
return arrvCourseLearningCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_microteachCaseQuantitySenate)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
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
 /// <param name = "objvCourseLearningCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvCourseLearningCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateENS, clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateENT)
{
try
{
objvCourseLearningCaseQuantitySenateENT.Id_CourseLearningCase = objvCourseLearningCaseQuantitySenateENS.Id_CourseLearningCase; //课程学习案例流水号
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
objvCourseLearningCaseQuantitySenateENT.id_XzCollege = objvCourseLearningCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvCourseLearningCaseQuantitySenateENT.CollegeID = objvCourseLearningCaseQuantitySenateENS.CollegeID; //学院ID
objvCourseLearningCaseQuantitySenateENT.CollegeName = objvCourseLearningCaseQuantitySenateENS.CollegeName; //学院名称
objvCourseLearningCaseQuantitySenateENT.id_XzMajor = objvCourseLearningCaseQuantitySenateENS.id_XzMajor; //专业流水号
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
objvCourseLearningCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvCourseLearningCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvCourseLearningCaseQuantitySenateENT.FuncModuleId = objvCourseLearningCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseQuantitySenateENT.FuncModuleName = objvCourseLearningCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseQuantitySenateENT.id_MicroteachCase = objvCourseLearningCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvCourseLearningCaseQuantitySenateENT.id_AppraiseType = objvCourseLearningCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvCourseLearningCaseQuantitySenateENT.AppraiseTypeName = objvCourseLearningCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvCourseLearningCaseQuantitySenateENT.SenateTheme = objvCourseLearningCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvCourseLearningCaseQuantitySenateENT.SenateContent = objvCourseLearningCaseQuantitySenateENS.SenateContent; //评价内容
objvCourseLearningCaseQuantitySenateENT.SenateTotalScore = objvCourseLearningCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvCourseLearningCaseQuantitySenateENT.SenateDate = objvCourseLearningCaseQuantitySenateENS.SenateDate; //评价日期
objvCourseLearningCaseQuantitySenateENT.SenateTime = objvCourseLearningCaseQuantitySenateENS.SenateTime; //评价时间
objvCourseLearningCaseQuantitySenateENT.SenateIp = objvCourseLearningCaseQuantitySenateENS.SenateIp; //评议Ip
objvCourseLearningCaseQuantitySenateENT.BrowseCount = objvCourseLearningCaseQuantitySenateENS.BrowseCount; //浏览次数
objvCourseLearningCaseQuantitySenateENT.id_SenateGaugeVersion = objvCourseLearningCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
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
public static DataTable ToDataTable(List<clsvCourseLearningCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningCaseQuantitySenateEN.AttributeName)
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
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseWApi没有刷新缓存机制(clsCourseLearningCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseTypeWApi没有刷新缓存机制(clsCourseLearningCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvCourseLearningCaseQuantitySenateObjLst_Cache == null)
//{
//arrvCourseLearningCaseQuantitySenateObjLst_Cache = await clsvCourseLearningCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvCourseLearningCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateEN._CurrTabName_S);
List<clsvCourseLearningCaseQuantitySenateEN> arrvCourseLearningCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.Id_CourseLearningCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenate.UserTypeName, Type.GetType("System.String"));
foreach (clsvCourseLearningCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningCaseQuantitySenate.Id_CourseLearningCase] = objInFor[convCourseLearningCaseQuantitySenate.Id_CourseLearningCase];
objDR[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] = objInFor[convCourseLearningCaseQuantitySenate.CourseLearningCaseID];
objDR[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] = objInFor[convCourseLearningCaseQuantitySenate.CourseLearningCaseName];
objDR[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] = objInFor[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme];
objDR[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] = objInFor[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate];
objDR[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] = objInFor[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime];
objDR[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] = objInFor[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn];
objDR[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] = objInFor[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn];
objDR[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] = objInFor[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName];
objDR[convCourseLearningCaseQuantitySenate.OwnerId] = objInFor[convCourseLearningCaseQuantitySenate.OwnerId];
objDR[convCourseLearningCaseQuantitySenate.OwnerName] = objInFor[convCourseLearningCaseQuantitySenate.OwnerName];
objDR[convCourseLearningCaseQuantitySenate.OwnerNameWithId] = objInFor[convCourseLearningCaseQuantitySenate.OwnerNameWithId];
objDR[convCourseLearningCaseQuantitySenate.UserNameWithUserId] = objInFor[convCourseLearningCaseQuantitySenate.UserNameWithUserId];
objDR[convCourseLearningCaseQuantitySenate.IsDualVideo] = objInFor[convCourseLearningCaseQuantitySenate.IsDualVideo];
objDR[convCourseLearningCaseQuantitySenate.id_XzCollege] = objInFor[convCourseLearningCaseQuantitySenate.id_XzCollege];
objDR[convCourseLearningCaseQuantitySenate.CollegeID] = objInFor[convCourseLearningCaseQuantitySenate.CollegeID];
objDR[convCourseLearningCaseQuantitySenate.CollegeName] = objInFor[convCourseLearningCaseQuantitySenate.CollegeName];
objDR[convCourseLearningCaseQuantitySenate.id_XzMajor] = objInFor[convCourseLearningCaseQuantitySenate.id_XzMajor];
objDR[convCourseLearningCaseQuantitySenate.MajorID] = objInFor[convCourseLearningCaseQuantitySenate.MajorID];
objDR[convCourseLearningCaseQuantitySenate.MajorName] = objInFor[convCourseLearningCaseQuantitySenate.MajorName];
objDR[convCourseLearningCaseQuantitySenate.CourseId] = objInFor[convCourseLearningCaseQuantitySenate.CourseId];
objDR[convCourseLearningCaseQuantitySenate.CourseCode] = objInFor[convCourseLearningCaseQuantitySenate.CourseCode];
objDR[convCourseLearningCaseQuantitySenate.CourseName] = objInFor[convCourseLearningCaseQuantitySenate.CourseName];
objDR[convCourseLearningCaseQuantitySenate.ViewCount] = objInFor[convCourseLearningCaseQuantitySenate.ViewCount];
objDR[convCourseLearningCaseQuantitySenate.IsShow] = objInFor[convCourseLearningCaseQuantitySenate.IsShow];
objDR[convCourseLearningCaseQuantitySenate.DownloadNumber] = objInFor[convCourseLearningCaseQuantitySenate.DownloadNumber];
objDR[convCourseLearningCaseQuantitySenate.FileIntegration] = objInFor[convCourseLearningCaseQuantitySenate.FileIntegration];
objDR[convCourseLearningCaseQuantitySenate.LikeCount] = objInFor[convCourseLearningCaseQuantitySenate.LikeCount];
objDR[convCourseLearningCaseQuantitySenate.CollectionCount] = objInFor[convCourseLearningCaseQuantitySenate.CollectionCount];
objDR[convCourseLearningCaseQuantitySenate.CollegeNameA] = objInFor[convCourseLearningCaseQuantitySenate.CollegeNameA];
objDR[convCourseLearningCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convCourseLearningCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convCourseLearningCaseQuantitySenate.FuncModuleId] = objInFor[convCourseLearningCaseQuantitySenate.FuncModuleId];
objDR[convCourseLearningCaseQuantitySenate.FuncModuleName] = objInFor[convCourseLearningCaseQuantitySenate.FuncModuleName];
objDR[convCourseLearningCaseQuantitySenate.id_MicroteachCase] = objInFor[convCourseLearningCaseQuantitySenate.id_MicroteachCase];
objDR[convCourseLearningCaseQuantitySenate.id_AppraiseType] = objInFor[convCourseLearningCaseQuantitySenate.id_AppraiseType];
objDR[convCourseLearningCaseQuantitySenate.AppraiseTypeName] = objInFor[convCourseLearningCaseQuantitySenate.AppraiseTypeName];
objDR[convCourseLearningCaseQuantitySenate.SenateTheme] = objInFor[convCourseLearningCaseQuantitySenate.SenateTheme];
objDR[convCourseLearningCaseQuantitySenate.SenateContent] = objInFor[convCourseLearningCaseQuantitySenate.SenateContent];
objDR[convCourseLearningCaseQuantitySenate.SenateTotalScore] = objInFor[convCourseLearningCaseQuantitySenate.SenateTotalScore];
objDR[convCourseLearningCaseQuantitySenate.SenateDate] = objInFor[convCourseLearningCaseQuantitySenate.SenateDate];
objDR[convCourseLearningCaseQuantitySenate.SenateTime] = objInFor[convCourseLearningCaseQuantitySenate.SenateTime];
objDR[convCourseLearningCaseQuantitySenate.SenateIp] = objInFor[convCourseLearningCaseQuantitySenate.SenateIp];
objDR[convCourseLearningCaseQuantitySenate.BrowseCount] = objInFor[convCourseLearningCaseQuantitySenate.BrowseCount];
objDR[convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convCourseLearningCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] = objInFor[convCourseLearningCaseQuantitySenate.senateGaugeVersionID];
objDR[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] = objInFor[convCourseLearningCaseQuantitySenate.senateGaugeVersionName];
objDR[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore];
objDR[convCourseLearningCaseQuantitySenate.UserId] = objInFor[convCourseLearningCaseQuantitySenate.UserId];
objDR[convCourseLearningCaseQuantitySenate.UserName] = objInFor[convCourseLearningCaseQuantitySenate.UserName];
objDR[convCourseLearningCaseQuantitySenate.UserKindId] = objInFor[convCourseLearningCaseQuantitySenate.UserKindId];
objDR[convCourseLearningCaseQuantitySenate.UserKindName] = objInFor[convCourseLearningCaseQuantitySenate.UserKindName];
objDR[convCourseLearningCaseQuantitySenate.UpdUser] = objInFor[convCourseLearningCaseQuantitySenate.UpdUser];
objDR[convCourseLearningCaseQuantitySenate.UpdUserName] = objInFor[convCourseLearningCaseQuantitySenate.UpdUserName];
objDR[convCourseLearningCaseQuantitySenate.Memo] = objInFor[convCourseLearningCaseQuantitySenate.Memo];
objDR[convCourseLearningCaseQuantitySenate.UserTypeName] = objInFor[convCourseLearningCaseQuantitySenate.UserTypeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}