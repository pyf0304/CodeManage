
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCaseQuantitySenateWApi
 表名:vClsRmTeachingCaseQuantitySenate(01120456)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:47
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
public static class clsvClsRmTeachingCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetId_ClsRmTeachingCase(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strId_ClsRmTeachingCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_ClsRmTeachingCase, 8, convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase);
clsCheckSql.CheckFieldForeignKey(strId_ClsRmTeachingCase, 8, convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase);
objvClsRmTeachingCaseQuantitySenateEN.Id_ClsRmTeachingCase = strId_ClsRmTeachingCase; //课堂教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetClsRmTeachingCaseID(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strClsRmTeachingCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseID, 8, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseID, 8, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID);
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseID = strClsRmTeachingCaseID; //课堂教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetClsRmTeachingCaseName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strClsRmTeachingCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseName, 100, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName);
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseName = strClsRmTeachingCaseName; //课堂教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetClsRmTeachingCaseTheme(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strClsRmTeachingCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTheme, 200, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme);
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTheme = strClsRmTeachingCaseTheme; //课堂教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetClsRmTeachingCaseTypeName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strClsRmTeachingCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTypeName, 30, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName);
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTypeName = strClsRmTeachingCaseTypeName; //课堂案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetClsRmTeachingCaseDate(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strClsRmTeachingCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDate, 8, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDate, 8, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate);
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDate = strClsRmTeachingCaseDate; //课堂教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetClsRmTeachingCaseTime(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strClsRmTeachingCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTime, 6, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTime, 6, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime);
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTime = strClsRmTeachingCaseTime; //课堂教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetClsRmTeachingCaseDateIn(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strClsRmTeachingCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseDateIn, 8, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn);
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDateIn = strClsRmTeachingCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetClsRmTeachingCaseTimeIn(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strClsRmTeachingCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn);
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTimeIn = strClsRmTeachingCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetUserNameWithUserId(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convClsRmTeachingCaseQuantitySenate.UserNameWithUserId);
objvClsRmTeachingCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.UserNameWithUserId) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetOwnerId(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convClsRmTeachingCaseQuantitySenate.OwnerId);
objvClsRmTeachingCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.OwnerId) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetOwnerName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convClsRmTeachingCaseQuantitySenate.OwnerName);
objvClsRmTeachingCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.OwnerName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN Setid_XzCollege(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convClsRmTeachingCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convClsRmTeachingCaseQuantitySenate.id_XzCollege);
objvClsRmTeachingCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.id_XzCollege) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetCollegeName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convClsRmTeachingCaseQuantitySenate.CollegeName);
objvClsRmTeachingCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.CollegeName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetOwnerNameWithId(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convClsRmTeachingCaseQuantitySenate.OwnerNameWithId);
objvClsRmTeachingCaseQuantitySenateEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.OwnerNameWithId) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.OwnerNameWithId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetCollegeID(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convClsRmTeachingCaseQuantitySenate.CollegeID);
objvClsRmTeachingCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.CollegeID) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetCollegeNameA(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convClsRmTeachingCaseQuantitySenate.CollegeNameA);
objvClsRmTeachingCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.CollegeNameA) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetUserTypeId(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convClsRmTeachingCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convClsRmTeachingCaseQuantitySenate.UserTypeId);
objvClsRmTeachingCaseQuantitySenateEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.UserTypeId) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.UserTypeId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserTypeId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetIsDualVideo(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvClsRmTeachingCaseQuantitySenateEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.IsDualVideo) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.IsDualVideo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.IsDualVideo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvClsRmTeachingCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetFuncModuleId(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convClsRmTeachingCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convClsRmTeachingCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convClsRmTeachingCaseQuantitySenate.FuncModuleId);
objvClsRmTeachingCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.FuncModuleId) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetFuncModuleName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convClsRmTeachingCaseQuantitySenate.FuncModuleName);
objvClsRmTeachingCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.FuncModuleName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN Setid_MicroteachCase(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convClsRmTeachingCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convClsRmTeachingCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convClsRmTeachingCaseQuantitySenate.id_MicroteachCase);
objvClsRmTeachingCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.id_MicroteachCase) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN Setid_AppraiseType(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convClsRmTeachingCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convClsRmTeachingCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convClsRmTeachingCaseQuantitySenate.id_AppraiseType);
objvClsRmTeachingCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.id_AppraiseType) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetAppraiseTypeName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convClsRmTeachingCaseQuantitySenate.AppraiseTypeName);
objvClsRmTeachingCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.AppraiseTypeName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetSenateTheme(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convClsRmTeachingCaseQuantitySenate.SenateTheme);
objvClsRmTeachingCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.SenateTheme) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetSenateContent(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convClsRmTeachingCaseQuantitySenate.SenateContent);
objvClsRmTeachingCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.SenateContent) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetSenateTotalScore(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convClsRmTeachingCaseQuantitySenate.SenateTotalScore);
objvClsRmTeachingCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.SenateTotalScore) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetSenateDate(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convClsRmTeachingCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convClsRmTeachingCaseQuantitySenate.SenateDate);
objvClsRmTeachingCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.SenateDate) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetSenateTime(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convClsRmTeachingCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convClsRmTeachingCaseQuantitySenate.SenateTime);
objvClsRmTeachingCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.SenateTime) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetSenateIp(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, convClsRmTeachingCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(strSenateIp, 50, convClsRmTeachingCaseQuantitySenate.SenateIp);
objvClsRmTeachingCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.SenateIp) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetBrowseCount(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
	{
objvClsRmTeachingCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.BrowseCount) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion);
objvClsRmTeachingCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID);
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName);
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetUserId(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convClsRmTeachingCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convClsRmTeachingCaseQuantitySenate.UserId);
objvClsRmTeachingCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.UserId) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetUserName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convClsRmTeachingCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convClsRmTeachingCaseQuantitySenate.UserName);
objvClsRmTeachingCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.UserName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetUserKindId(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convClsRmTeachingCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convClsRmTeachingCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convClsRmTeachingCaseQuantitySenate.UserKindId);
objvClsRmTeachingCaseQuantitySenateEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.UserKindId) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.UserKindId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserKindId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetUserKindName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convClsRmTeachingCaseQuantitySenate.UserKindName);
objvClsRmTeachingCaseQuantitySenateEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.UserKindName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.UserKindName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserKindName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetUpdUser(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convClsRmTeachingCaseQuantitySenate.UpdUser);
objvClsRmTeachingCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.UpdUser) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetUpdUserName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convClsRmTeachingCaseQuantitySenate.UpdUserName);
objvClsRmTeachingCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.UpdUserName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetMemo(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClsRmTeachingCaseQuantitySenate.Memo);
objvClsRmTeachingCaseQuantitySenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.Memo) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.Memo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.Memo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN SetUserTypeName(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convClsRmTeachingCaseQuantitySenate.UserTypeName);
objvClsRmTeachingCaseQuantitySenateEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseQuantitySenate.UserTypeName) == false)
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp.Add(convClsRmTeachingCaseQuantitySenate.UserTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseQuantitySenateEN.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseQuantitySenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase) == true)
{
string strComparisonOp_Id_ClsRmTeachingCase = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase, objvClsRmTeachingCaseQuantitySenate_Cond.Id_ClsRmTeachingCase, strComparisonOp_Id_ClsRmTeachingCase);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID) == true)
{
string strComparisonOp_ClsRmTeachingCaseID = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID, objvClsRmTeachingCaseQuantitySenate_Cond.ClsRmTeachingCaseID, strComparisonOp_ClsRmTeachingCaseID);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName) == true)
{
string strComparisonOp_ClsRmTeachingCaseName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName, objvClsRmTeachingCaseQuantitySenate_Cond.ClsRmTeachingCaseName, strComparisonOp_ClsRmTeachingCaseName);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme) == true)
{
string strComparisonOp_ClsRmTeachingCaseTheme = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme, objvClsRmTeachingCaseQuantitySenate_Cond.ClsRmTeachingCaseTheme, strComparisonOp_ClsRmTeachingCaseTheme);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName) == true)
{
string strComparisonOp_ClsRmTeachingCaseTypeName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName, objvClsRmTeachingCaseQuantitySenate_Cond.ClsRmTeachingCaseTypeName, strComparisonOp_ClsRmTeachingCaseTypeName);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate) == true)
{
string strComparisonOp_ClsRmTeachingCaseDate = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate, objvClsRmTeachingCaseQuantitySenate_Cond.ClsRmTeachingCaseDate, strComparisonOp_ClsRmTeachingCaseDate);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime) == true)
{
string strComparisonOp_ClsRmTeachingCaseTime = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime, objvClsRmTeachingCaseQuantitySenate_Cond.ClsRmTeachingCaseTime, strComparisonOp_ClsRmTeachingCaseTime);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn) == true)
{
string strComparisonOp_ClsRmTeachingCaseDateIn = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn, objvClsRmTeachingCaseQuantitySenate_Cond.ClsRmTeachingCaseDateIn, strComparisonOp_ClsRmTeachingCaseDateIn);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn) == true)
{
string strComparisonOp_ClsRmTeachingCaseTimeIn = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn, objvClsRmTeachingCaseQuantitySenate_Cond.ClsRmTeachingCaseTimeIn, strComparisonOp_ClsRmTeachingCaseTimeIn);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.UserNameWithUserId, objvClsRmTeachingCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.OwnerId, objvClsRmTeachingCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.OwnerName, objvClsRmTeachingCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.id_XzCollege, objvClsRmTeachingCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.CollegeName, objvClsRmTeachingCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.OwnerNameWithId, objvClsRmTeachingCaseQuantitySenate_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.CollegeID, objvClsRmTeachingCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.CollegeNameA, objvClsRmTeachingCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.UserTypeId, objvClsRmTeachingCaseQuantitySenate_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.IsDualVideo) == true)
{
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCaseQuantitySenate.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCaseQuantitySenate.IsDualVideo);
}
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCaseQuantitySenate.id_microteachCaseQuantitySenate, objvClsRmTeachingCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.FuncModuleId, objvClsRmTeachingCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.FuncModuleName, objvClsRmTeachingCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.id_MicroteachCase, objvClsRmTeachingCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.id_AppraiseType, objvClsRmTeachingCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.AppraiseTypeName, objvClsRmTeachingCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.SenateTheme, objvClsRmTeachingCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.SenateContent, objvClsRmTeachingCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCaseQuantitySenate.SenateTotalScore, objvClsRmTeachingCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.SenateDate, objvClsRmTeachingCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.SenateTime, objvClsRmTeachingCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.SenateIp, objvClsRmTeachingCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCaseQuantitySenate.BrowseCount, objvClsRmTeachingCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion, objvClsRmTeachingCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID, objvClsRmTeachingCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName, objvClsRmTeachingCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore, objvClsRmTeachingCaseQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.UserId, objvClsRmTeachingCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.UserName, objvClsRmTeachingCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.UserKindId, objvClsRmTeachingCaseQuantitySenate_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.UserKindName, objvClsRmTeachingCaseQuantitySenate_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.UpdUser, objvClsRmTeachingCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.UpdUserName, objvClsRmTeachingCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.Memo) == true)
{
string strComparisonOp_Memo = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.Memo, objvClsRmTeachingCaseQuantitySenate_Cond.Memo, strComparisonOp_Memo);
}
if (objvClsRmTeachingCaseQuantitySenate_Cond.IsUpdated(convClsRmTeachingCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvClsRmTeachingCaseQuantitySenate_Cond.dicFldComparisonOp[convClsRmTeachingCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseQuantitySenate.UserTypeName, objvClsRmTeachingCaseQuantitySenate_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课堂教学量化评议(vClsRmTeachingCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvClsRmTeachingCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vClsRmTeachingCaseQuantitySenateApi";

 public clsvClsRmTeachingCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClsRmTeachingCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN = null;
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
objvClsRmTeachingCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCaseQuantitySenateEN;
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
public static clsvClsRmTeachingCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN = null;
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
objvClsRmTeachingCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCaseQuantitySenateEN;
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
public static clsvClsRmTeachingCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN = null;
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
objvClsRmTeachingCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCaseQuantitySenateEN;
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
public static clsvClsRmTeachingCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClsRmTeachingCaseQuantitySenateEN._CurrTabName_S);
List<clsvClsRmTeachingCaseQuantitySenateEN> arrvClsRmTeachingCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCaseQuantitySenateEN> arrvClsRmTeachingCaseQuantitySenateObjLst_Sel =
from objvClsRmTeachingCaseQuantitySenateEN in arrvClsRmTeachingCaseQuantitySenateObjLst_Cache
where objvClsRmTeachingCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvClsRmTeachingCaseQuantitySenateEN;
if (arrvClsRmTeachingCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvClsRmTeachingCaseQuantitySenateEN obj = clsvClsRmTeachingCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvClsRmTeachingCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvClsRmTeachingCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvClsRmTeachingCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvClsRmTeachingCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClsRmTeachingCaseQuantitySenateEN._CurrTabName_S);
List<clsvClsRmTeachingCaseQuantitySenateEN> arrvClsRmTeachingCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCaseQuantitySenateEN> arrvClsRmTeachingCaseQuantitySenateObjLst_Sel =
from objvClsRmTeachingCaseQuantitySenateEN in arrvClsRmTeachingCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvClsRmTeachingCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvClsRmTeachingCaseQuantitySenateEN;
return arrvClsRmTeachingCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvClsRmTeachingCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvClsRmTeachingCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvClsRmTeachingCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvClsRmTeachingCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvClsRmTeachingCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvClsRmTeachingCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateENS, clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateENT)
{
try
{
objvClsRmTeachingCaseQuantitySenateENT.Id_ClsRmTeachingCase = objvClsRmTeachingCaseQuantitySenateENS.Id_ClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseID = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseName = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseDate = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseTime = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCaseQuantitySenateENT.UserNameWithUserId = objvClsRmTeachingCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvClsRmTeachingCaseQuantitySenateENT.OwnerId = objvClsRmTeachingCaseQuantitySenateENS.OwnerId; //拥有者Id
objvClsRmTeachingCaseQuantitySenateENT.OwnerName = objvClsRmTeachingCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvClsRmTeachingCaseQuantitySenateENT.id_XzCollege = objvClsRmTeachingCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvClsRmTeachingCaseQuantitySenateENT.CollegeName = objvClsRmTeachingCaseQuantitySenateENS.CollegeName; //学院名称
objvClsRmTeachingCaseQuantitySenateENT.OwnerNameWithId = objvClsRmTeachingCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvClsRmTeachingCaseQuantitySenateENT.CollegeID = objvClsRmTeachingCaseQuantitySenateENS.CollegeID; //学院ID
objvClsRmTeachingCaseQuantitySenateENT.CollegeNameA = objvClsRmTeachingCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCaseQuantitySenateENT.UserTypeId = objvClsRmTeachingCaseQuantitySenateENS.UserTypeId; //用户类型Id
objvClsRmTeachingCaseQuantitySenateENT.IsDualVideo = objvClsRmTeachingCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvClsRmTeachingCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvClsRmTeachingCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvClsRmTeachingCaseQuantitySenateENT.FuncModuleId = objvClsRmTeachingCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvClsRmTeachingCaseQuantitySenateENT.FuncModuleName = objvClsRmTeachingCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvClsRmTeachingCaseQuantitySenateENT.id_MicroteachCase = objvClsRmTeachingCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvClsRmTeachingCaseQuantitySenateENT.id_AppraiseType = objvClsRmTeachingCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvClsRmTeachingCaseQuantitySenateENT.AppraiseTypeName = objvClsRmTeachingCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvClsRmTeachingCaseQuantitySenateENT.SenateTheme = objvClsRmTeachingCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvClsRmTeachingCaseQuantitySenateENT.SenateContent = objvClsRmTeachingCaseQuantitySenateENS.SenateContent; //评价内容
objvClsRmTeachingCaseQuantitySenateENT.SenateTotalScore = objvClsRmTeachingCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvClsRmTeachingCaseQuantitySenateENT.SenateDate = objvClsRmTeachingCaseQuantitySenateENS.SenateDate; //评价日期
objvClsRmTeachingCaseQuantitySenateENT.SenateTime = objvClsRmTeachingCaseQuantitySenateENS.SenateTime; //评价时间
objvClsRmTeachingCaseQuantitySenateENT.SenateIp = objvClsRmTeachingCaseQuantitySenateENS.SenateIp; //评议Ip
objvClsRmTeachingCaseQuantitySenateENT.BrowseCount = objvClsRmTeachingCaseQuantitySenateENS.BrowseCount; //浏览次数
objvClsRmTeachingCaseQuantitySenateENT.id_SenateGaugeVersion = objvClsRmTeachingCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
objvClsRmTeachingCaseQuantitySenateENT.senateGaugeVersionID = objvClsRmTeachingCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCaseQuantitySenateENT.senateGaugeVersionName = objvClsRmTeachingCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvClsRmTeachingCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCaseQuantitySenateENT.UserId = objvClsRmTeachingCaseQuantitySenateENS.UserId; //用户ID
objvClsRmTeachingCaseQuantitySenateENT.UserName = objvClsRmTeachingCaseQuantitySenateENS.UserName; //用户名
objvClsRmTeachingCaseQuantitySenateENT.UserKindId = objvClsRmTeachingCaseQuantitySenateENS.UserKindId; //用户类别Id
objvClsRmTeachingCaseQuantitySenateENT.UserKindName = objvClsRmTeachingCaseQuantitySenateENS.UserKindName; //用户类别名
objvClsRmTeachingCaseQuantitySenateENT.UpdUser = objvClsRmTeachingCaseQuantitySenateENS.UpdUser; //修改人
objvClsRmTeachingCaseQuantitySenateENT.UpdUserName = objvClsRmTeachingCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvClsRmTeachingCaseQuantitySenateENT.Memo = objvClsRmTeachingCaseQuantitySenateENS.Memo; //备注
objvClsRmTeachingCaseQuantitySenateENT.UserTypeName = objvClsRmTeachingCaseQuantitySenateENS.UserTypeName; //用户类型名称
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
public static DataTable ToDataTable(List<clsvClsRmTeachingCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvClsRmTeachingCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvClsRmTeachingCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvClsRmTeachingCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvClsRmTeachingCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvClsRmTeachingCaseQuantitySenateEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvClsRmTeachingCaseQuantitySenateObjLst_Cache == null)
//{
//arrvClsRmTeachingCaseQuantitySenateObjLst_Cache = await clsvClsRmTeachingCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvClsRmTeachingCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvClsRmTeachingCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvClsRmTeachingCaseQuantitySenateEN._CurrTabName_S);
List<clsvClsRmTeachingCaseQuantitySenateEN> arrvClsRmTeachingCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClsRmTeachingCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvClsRmTeachingCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseQuantitySenate.UserTypeName, Type.GetType("System.String"));
foreach (clsvClsRmTeachingCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase] = objInFor[convClsRmTeachingCaseQuantitySenate.Id_ClsRmTeachingCase];
objDR[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID] = objInFor[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID];
objDR[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName] = objInFor[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName];
objDR[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme] = objInFor[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme];
objDR[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName] = objInFor[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName];
objDR[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate] = objInFor[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate];
objDR[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime] = objInFor[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime];
objDR[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn] = objInFor[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn];
objDR[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn] = objInFor[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn];
objDR[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId] = objInFor[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId];
objDR[convClsRmTeachingCaseQuantitySenate.OwnerId] = objInFor[convClsRmTeachingCaseQuantitySenate.OwnerId];
objDR[convClsRmTeachingCaseQuantitySenate.OwnerName] = objInFor[convClsRmTeachingCaseQuantitySenate.OwnerName];
objDR[convClsRmTeachingCaseQuantitySenate.id_XzCollege] = objInFor[convClsRmTeachingCaseQuantitySenate.id_XzCollege];
objDR[convClsRmTeachingCaseQuantitySenate.CollegeName] = objInFor[convClsRmTeachingCaseQuantitySenate.CollegeName];
objDR[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId] = objInFor[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId];
objDR[convClsRmTeachingCaseQuantitySenate.CollegeID] = objInFor[convClsRmTeachingCaseQuantitySenate.CollegeID];
objDR[convClsRmTeachingCaseQuantitySenate.CollegeNameA] = objInFor[convClsRmTeachingCaseQuantitySenate.CollegeNameA];
objDR[convClsRmTeachingCaseQuantitySenate.UserTypeId] = objInFor[convClsRmTeachingCaseQuantitySenate.UserTypeId];
objDR[convClsRmTeachingCaseQuantitySenate.IsDualVideo] = objInFor[convClsRmTeachingCaseQuantitySenate.IsDualVideo];
objDR[convClsRmTeachingCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convClsRmTeachingCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convClsRmTeachingCaseQuantitySenate.FuncModuleId] = objInFor[convClsRmTeachingCaseQuantitySenate.FuncModuleId];
objDR[convClsRmTeachingCaseQuantitySenate.FuncModuleName] = objInFor[convClsRmTeachingCaseQuantitySenate.FuncModuleName];
objDR[convClsRmTeachingCaseQuantitySenate.id_MicroteachCase] = objInFor[convClsRmTeachingCaseQuantitySenate.id_MicroteachCase];
objDR[convClsRmTeachingCaseQuantitySenate.id_AppraiseType] = objInFor[convClsRmTeachingCaseQuantitySenate.id_AppraiseType];
objDR[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName] = objInFor[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName];
objDR[convClsRmTeachingCaseQuantitySenate.SenateTheme] = objInFor[convClsRmTeachingCaseQuantitySenate.SenateTheme];
objDR[convClsRmTeachingCaseQuantitySenate.SenateContent] = objInFor[convClsRmTeachingCaseQuantitySenate.SenateContent];
objDR[convClsRmTeachingCaseQuantitySenate.SenateTotalScore] = objInFor[convClsRmTeachingCaseQuantitySenate.SenateTotalScore];
objDR[convClsRmTeachingCaseQuantitySenate.SenateDate] = objInFor[convClsRmTeachingCaseQuantitySenate.SenateDate];
objDR[convClsRmTeachingCaseQuantitySenate.SenateTime] = objInFor[convClsRmTeachingCaseQuantitySenate.SenateTime];
objDR[convClsRmTeachingCaseQuantitySenate.SenateIp] = objInFor[convClsRmTeachingCaseQuantitySenate.SenateIp];
objDR[convClsRmTeachingCaseQuantitySenate.BrowseCount] = objInFor[convClsRmTeachingCaseQuantitySenate.BrowseCount];
objDR[convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convClsRmTeachingCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID] = objInFor[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID];
objDR[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName] = objInFor[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName];
objDR[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore];
objDR[convClsRmTeachingCaseQuantitySenate.UserId] = objInFor[convClsRmTeachingCaseQuantitySenate.UserId];
objDR[convClsRmTeachingCaseQuantitySenate.UserName] = objInFor[convClsRmTeachingCaseQuantitySenate.UserName];
objDR[convClsRmTeachingCaseQuantitySenate.UserKindId] = objInFor[convClsRmTeachingCaseQuantitySenate.UserKindId];
objDR[convClsRmTeachingCaseQuantitySenate.UserKindName] = objInFor[convClsRmTeachingCaseQuantitySenate.UserKindName];
objDR[convClsRmTeachingCaseQuantitySenate.UpdUser] = objInFor[convClsRmTeachingCaseQuantitySenate.UpdUser];
objDR[convClsRmTeachingCaseQuantitySenate.UpdUserName] = objInFor[convClsRmTeachingCaseQuantitySenate.UpdUserName];
objDR[convClsRmTeachingCaseQuantitySenate.Memo] = objInFor[convClsRmTeachingCaseQuantitySenate.Memo];
objDR[convClsRmTeachingCaseQuantitySenate.UserTypeName] = objInFor[convClsRmTeachingCaseQuantitySenate.UserTypeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}