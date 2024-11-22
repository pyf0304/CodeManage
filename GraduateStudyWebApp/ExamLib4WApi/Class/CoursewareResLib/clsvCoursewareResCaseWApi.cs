
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCaseWApi
 表名:vCoursewareResCase(01120419)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:35
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库
 模块英文名:CoursewareResLib
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
public static class clsvCoursewareResCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetId_CoursewareResCase(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strId_CoursewareResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CoursewareResCase, 8, convCoursewareResCase.Id_CoursewareResCase);
clsCheckSql.CheckFieldForeignKey(strId_CoursewareResCase, 8, convCoursewareResCase.Id_CoursewareResCase);
objvCoursewareResCaseEN.Id_CoursewareResCase = strId_CoursewareResCase; //课件资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.Id_CoursewareResCase) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.Id_CoursewareResCase, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.Id_CoursewareResCase] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCoursewareResCaseID(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCoursewareResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareResCaseID, convCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckFieldLen(strCoursewareResCaseID, 8, convCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseID, 8, convCoursewareResCase.CoursewareResCaseID);
objvCoursewareResCaseEN.CoursewareResCaseID = strCoursewareResCaseID; //课件资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CoursewareResCaseID) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CoursewareResCaseID, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseID] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCoursewareResCaseName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCoursewareResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareResCaseName, convCoursewareResCase.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(strCoursewareResCaseName, 100, convCoursewareResCase.CoursewareResCaseName);
objvCoursewareResCaseEN.CoursewareResCaseName = strCoursewareResCaseName; //课件资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CoursewareResCaseName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CoursewareResCaseName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCoursewareResCaseTheme(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCoursewareResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTheme, 200, convCoursewareResCase.CoursewareResCaseTheme);
objvCoursewareResCaseEN.CoursewareResCaseTheme = strCoursewareResCaseTheme; //课件资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CoursewareResCaseTheme) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CoursewareResCaseTheme, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseTheme] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCoursewareResCaseText(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCoursewareResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseText, 8000, convCoursewareResCase.CoursewareResCaseText);
objvCoursewareResCaseEN.CoursewareResCaseText = strCoursewareResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CoursewareResCaseText) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CoursewareResCaseText, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseText] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN Setid_CoursewareResCaseType(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strid_CoursewareResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CoursewareResCaseType, convCoursewareResCase.id_CoursewareResCaseType);
clsCheckSql.CheckFieldLen(strid_CoursewareResCaseType, 4, convCoursewareResCase.id_CoursewareResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareResCaseType, 4, convCoursewareResCase.id_CoursewareResCaseType);
objvCoursewareResCaseEN.id_CoursewareResCaseType = strid_CoursewareResCaseType; //课件资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.id_CoursewareResCaseType) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.id_CoursewareResCaseType, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.id_CoursewareResCaseType] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCoursewareResCaseTypeName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCoursewareResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTypeName, 30, convCoursewareResCase.CoursewareResCaseTypeName);
objvCoursewareResCaseEN.CoursewareResCaseTypeName = strCoursewareResCaseTypeName; //课件资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CoursewareResCaseTypeName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CoursewareResCaseTypeName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseTypeName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCoursewareResCaseDate(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCoursewareResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseDate, 8, convCoursewareResCase.CoursewareResCaseDate);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseDate, 8, convCoursewareResCase.CoursewareResCaseDate);
objvCoursewareResCaseEN.CoursewareResCaseDate = strCoursewareResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CoursewareResCaseDate) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CoursewareResCaseDate, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseDate] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCoursewareResCaseTime(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCoursewareResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTime, 6, convCoursewareResCase.CoursewareResCaseTime);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTime, 6, convCoursewareResCase.CoursewareResCaseTime);
objvCoursewareResCaseEN.CoursewareResCaseTime = strCoursewareResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CoursewareResCaseTime) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CoursewareResCaseTime, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseTime] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCoursewareResCaseDateIn(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCoursewareResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseDateIn, 8, convCoursewareResCase.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseDateIn, 8, convCoursewareResCase.CoursewareResCaseDateIn);
objvCoursewareResCaseEN.CoursewareResCaseDateIn = strCoursewareResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CoursewareResCaseDateIn) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CoursewareResCaseDateIn, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseDateIn] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCoursewareResCaseTimeIn(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCoursewareResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTimeIn, 6, convCoursewareResCase.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTimeIn, 6, convCoursewareResCase.CoursewareResCaseTimeIn);
objvCoursewareResCaseEN.CoursewareResCaseTimeIn = strCoursewareResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CoursewareResCaseTimeIn) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CoursewareResCaseTimeIn, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseTimeIn] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetOwnerId(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCoursewareResCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCoursewareResCase.OwnerId);
objvCoursewareResCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.OwnerId) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.OwnerId, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.OwnerId] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN Setid_StudyLevel(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCoursewareResCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCoursewareResCase.id_StudyLevel);
objvCoursewareResCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.id_StudyLevel) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.id_StudyLevel, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.id_StudyLevel] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetStudyLevelName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCoursewareResCase.StudyLevelName);
objvCoursewareResCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.StudyLevelName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.StudyLevelName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.StudyLevelName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN Setid_TeachingPlan(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCoursewareResCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCoursewareResCase.id_TeachingPlan);
objvCoursewareResCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.id_TeachingPlan) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN Setid_Discipline(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convCoursewareResCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCoursewareResCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCoursewareResCase.id_Discipline);
objvCoursewareResCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.id_Discipline) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.id_Discipline, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.id_Discipline] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetDisciplineID(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCoursewareResCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCoursewareResCase.DisciplineID);
objvCoursewareResCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.DisciplineID) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.DisciplineID, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.DisciplineID] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetDisciplineName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCoursewareResCase.DisciplineName);
objvCoursewareResCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.DisciplineName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.DisciplineName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.DisciplineName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN Setid_SenateGaugeVersion(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCoursewareResCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCoursewareResCase.id_SenateGaugeVersion);
objvCoursewareResCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.id_SenateGaugeVersion) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetsenateGaugeVersionID(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCoursewareResCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCoursewareResCase.senateGaugeVersionID);
objvCoursewareResCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.senateGaugeVersionID) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetsenateGaugeVersionName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCoursewareResCase.senateGaugeVersionName);
objvCoursewareResCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.senateGaugeVersionName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetsenateGaugeVersionTtlScore(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCoursewareResCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.senateGaugeVersionTtlScore) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetVersionNo(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, int intVersionNo, string strComparisonOp="")
	{
objvCoursewareResCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.VersionNo) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.VersionNo, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.VersionNo] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN Setid_TeachSkill(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convCoursewareResCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCoursewareResCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCoursewareResCase.id_TeachSkill);
objvCoursewareResCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.id_TeachSkill) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.id_TeachSkill, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.id_TeachSkill] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetTeachSkillID(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCoursewareResCase.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCoursewareResCase.TeachSkillID);
objvCoursewareResCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.TeachSkillID) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.TeachSkillID, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.TeachSkillID] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetSkillTypeName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCoursewareResCase.SkillTypeName);
objvCoursewareResCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.SkillTypeName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.SkillTypeName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.SkillTypeName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetTeachSkillName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCoursewareResCase.TeachSkillName);
objvCoursewareResCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.TeachSkillName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.TeachSkillName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.TeachSkillName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetTeachSkillTheory(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCoursewareResCase.TeachSkillTheory);
objvCoursewareResCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.TeachSkillTheory) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetTeachSkillOperMethod(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCoursewareResCase.TeachSkillOperMethod);
objvCoursewareResCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.TeachSkillOperMethod) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN Setid_SkillType(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convCoursewareResCase.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convCoursewareResCase.id_SkillType);
objvCoursewareResCaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.id_SkillType) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.id_SkillType, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.id_SkillType] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetSkillTypeID(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCoursewareResCase.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCoursewareResCase.SkillTypeID);
objvCoursewareResCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.SkillTypeID) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.SkillTypeID, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.SkillTypeID] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCaseLevelId(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCoursewareResCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCoursewareResCase.CaseLevelId);
objvCoursewareResCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CaseLevelId) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CaseLevelId, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CaseLevelId] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCaseLevelName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convCoursewareResCase.CaseLevelName);
objvCoursewareResCaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CaseLevelName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CaseLevelName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CaseLevelName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetDocFile(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCoursewareResCase.DocFile);
objvCoursewareResCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.DocFile) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.DocFile, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.DocFile] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetIsNeedGeneWord(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCoursewareResCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.IsNeedGeneWord) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetWordCreateDate(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCoursewareResCase.WordCreateDate);
objvCoursewareResCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.WordCreateDate) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.WordCreateDate, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.WordCreateDate] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetIsVisible(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCoursewareResCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.IsVisible) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.IsVisible, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.IsVisible] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetIsDualVideo(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCoursewareResCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.IsDualVideo) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.IsDualVideo, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.IsDualVideo] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN Setid_XzCollege(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convCoursewareResCase.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCoursewareResCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCoursewareResCase.id_XzCollege);
objvCoursewareResCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.id_XzCollege) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.id_XzCollege, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.id_XzCollege] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCollegeID(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCoursewareResCase.CollegeID);
objvCoursewareResCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CollegeID) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CollegeID, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CollegeID] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCollegeName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCoursewareResCase.CollegeName);
objvCoursewareResCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CollegeName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CollegeName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CollegeName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCollegeNameA(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCoursewareResCase.CollegeNameA);
objvCoursewareResCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CollegeNameA) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CollegeNameA, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CollegeNameA] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN Setid_XzMajor(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convCoursewareResCase.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCoursewareResCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCoursewareResCase.id_XzMajor);
objvCoursewareResCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.id_XzMajor) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.id_XzMajor, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.id_XzMajor] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetMajorID(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCoursewareResCase.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCoursewareResCase.MajorID);
objvCoursewareResCaseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.MajorID) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.MajorID, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.MajorID] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetMajorName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCoursewareResCase.MajorName);
objvCoursewareResCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.MajorName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.MajorName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.MajorName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCourseChapterId(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCoursewareResCase.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCoursewareResCase.CourseChapterId);
objvCoursewareResCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CourseChapterId) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CourseChapterId, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CourseChapterId] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCourseChapterName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCoursewareResCase.CourseChapterName);
objvCoursewareResCaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CourseChapterName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CourseChapterName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CourseChapterName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetParentNodeID(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCoursewareResCase.ParentNodeID);
objvCoursewareResCaseEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.ParentNodeID) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.ParentNodeID, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.ParentNodeID] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetParentNodeName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCoursewareResCase.ParentNodeName);
objvCoursewareResCaseEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.ParentNodeName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.ParentNodeName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.ParentNodeName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetViewCount(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, int intViewCount, string strComparisonOp="")
	{
objvCoursewareResCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.ViewCount) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.ViewCount, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.ViewCount] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetIsShow(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvCoursewareResCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.IsShow) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.IsShow, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.IsShow] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetDownloadNumber(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objvCoursewareResCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.DownloadNumber) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.DownloadNumber, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.DownloadNumber] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetFileIntegration(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, int intFileIntegration, string strComparisonOp="")
	{
objvCoursewareResCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.FileIntegration) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.FileIntegration, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.FileIntegration] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetLikeCount(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, long lngLikeCount, string strComparisonOp="")
	{
objvCoursewareResCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.LikeCount) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.LikeCount, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.LikeCount] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCollectionCount(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objvCoursewareResCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CollectionCount) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CollectionCount, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CollectionCount] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetRecommendedDegreeId(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCoursewareResCase.RecommendedDegreeId);
objvCoursewareResCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.RecommendedDegreeId) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetRecommendedDegreeName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCoursewareResCase.RecommendedDegreeName);
objvCoursewareResCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.RecommendedDegreeName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetftpFileType(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCoursewareResCase.ftpFileType);
objvCoursewareResCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.ftpFileType) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.ftpFileType, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.ftpFileType] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCourseId(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCoursewareResCase.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convCoursewareResCase.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCoursewareResCase.CourseId);
objvCoursewareResCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CourseId) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CourseId, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CourseId] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCourseCode(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCoursewareResCase.CourseCode);
objvCoursewareResCaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CourseCode) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CourseCode, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CourseCode] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetCourseName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCoursewareResCase.CourseName);
objvCoursewareResCaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.CourseName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.CourseName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.CourseName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetVideoUrl(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convCoursewareResCase.VideoUrl);
objvCoursewareResCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.VideoUrl) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.VideoUrl, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.VideoUrl] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetVideoPath(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convCoursewareResCase.VideoPath);
objvCoursewareResCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.VideoPath) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.VideoPath, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.VideoPath] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetResErrMsg(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convCoursewareResCase.ResErrMsg);
objvCoursewareResCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.ResErrMsg) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.ResErrMsg, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.ResErrMsg] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetUpdDate(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCoursewareResCase.UpdDate);
objvCoursewareResCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.UpdDate) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.UpdDate, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.UpdDate] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetUpdUserId(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCoursewareResCase.UpdUserId);
objvCoursewareResCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.UpdUserId) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.UpdUserId, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.UpdUserId] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetMemo(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCoursewareResCase.Memo);
objvCoursewareResCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.Memo) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.Memo, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.Memo] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetOwnerNameWithId(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCoursewareResCase.OwnerNameWithId);
objvCoursewareResCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.OwnerNameWithId) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetOwnerName(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCoursewareResCase.OwnerName);
objvCoursewareResCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.OwnerName) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.OwnerName, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.OwnerName] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetBrowseCount4Case(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCoursewareResCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.BrowseCount4Case) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseEN SetIsHaveVideo(this clsvCoursewareResCaseEN objvCoursewareResCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convCoursewareResCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convCoursewareResCase.IsHaveVideo);
objvCoursewareResCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase.IsHaveVideo) == false)
{
objvCoursewareResCaseEN.dicFldComparisonOp.Add(convCoursewareResCase.IsHaveVideo, strComparisonOp);
}
else
{
objvCoursewareResCaseEN.dicFldComparisonOp[convCoursewareResCase.IsHaveVideo] = strComparisonOp;
}
}
return objvCoursewareResCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCoursewareResCaseEN objvCoursewareResCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.Id_CoursewareResCase) == true)
{
string strComparisonOp_Id_CoursewareResCase = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.Id_CoursewareResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.Id_CoursewareResCase, objvCoursewareResCase_Cond.Id_CoursewareResCase, strComparisonOp_Id_CoursewareResCase);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CoursewareResCaseID) == true)
{
string strComparisonOp_CoursewareResCaseID = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CoursewareResCaseID, objvCoursewareResCase_Cond.CoursewareResCaseID, strComparisonOp_CoursewareResCaseID);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CoursewareResCaseName) == true)
{
string strComparisonOp_CoursewareResCaseName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CoursewareResCaseName, objvCoursewareResCase_Cond.CoursewareResCaseName, strComparisonOp_CoursewareResCaseName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CoursewareResCaseTheme) == true)
{
string strComparisonOp_CoursewareResCaseTheme = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CoursewareResCaseTheme, objvCoursewareResCase_Cond.CoursewareResCaseTheme, strComparisonOp_CoursewareResCaseTheme);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CoursewareResCaseText) == true)
{
string strComparisonOp_CoursewareResCaseText = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CoursewareResCaseText, objvCoursewareResCase_Cond.CoursewareResCaseText, strComparisonOp_CoursewareResCaseText);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.id_CoursewareResCaseType) == true)
{
string strComparisonOp_id_CoursewareResCaseType = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.id_CoursewareResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.id_CoursewareResCaseType, objvCoursewareResCase_Cond.id_CoursewareResCaseType, strComparisonOp_id_CoursewareResCaseType);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CoursewareResCaseTypeName) == true)
{
string strComparisonOp_CoursewareResCaseTypeName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CoursewareResCaseTypeName, objvCoursewareResCase_Cond.CoursewareResCaseTypeName, strComparisonOp_CoursewareResCaseTypeName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CoursewareResCaseDate) == true)
{
string strComparisonOp_CoursewareResCaseDate = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CoursewareResCaseDate, objvCoursewareResCase_Cond.CoursewareResCaseDate, strComparisonOp_CoursewareResCaseDate);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CoursewareResCaseTime) == true)
{
string strComparisonOp_CoursewareResCaseTime = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CoursewareResCaseTime, objvCoursewareResCase_Cond.CoursewareResCaseTime, strComparisonOp_CoursewareResCaseTime);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CoursewareResCaseDateIn) == true)
{
string strComparisonOp_CoursewareResCaseDateIn = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CoursewareResCaseDateIn, objvCoursewareResCase_Cond.CoursewareResCaseDateIn, strComparisonOp_CoursewareResCaseDateIn);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CoursewareResCaseTimeIn) == true)
{
string strComparisonOp_CoursewareResCaseTimeIn = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CoursewareResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CoursewareResCaseTimeIn, objvCoursewareResCase_Cond.CoursewareResCaseTimeIn, strComparisonOp_CoursewareResCaseTimeIn);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.OwnerId, objvCoursewareResCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.id_StudyLevel, objvCoursewareResCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.StudyLevelName, objvCoursewareResCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.id_TeachingPlan, objvCoursewareResCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.id_Discipline, objvCoursewareResCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.DisciplineID, objvCoursewareResCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.DisciplineName, objvCoursewareResCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.id_SenateGaugeVersion, objvCoursewareResCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.senateGaugeVersionID, objvCoursewareResCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.senateGaugeVersionName, objvCoursewareResCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase.senateGaugeVersionTtlScore, objvCoursewareResCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase.VersionNo, objvCoursewareResCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.id_TeachSkill, objvCoursewareResCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.TeachSkillID, objvCoursewareResCase_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.SkillTypeName, objvCoursewareResCase_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.TeachSkillName, objvCoursewareResCase_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.TeachSkillTheory, objvCoursewareResCase_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.TeachSkillOperMethod, objvCoursewareResCase_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.id_SkillType, objvCoursewareResCase_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.SkillTypeID, objvCoursewareResCase_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CaseLevelId, objvCoursewareResCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CaseLevelName, objvCoursewareResCase_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.DocFile, objvCoursewareResCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.IsNeedGeneWord) == true)
{
if (objvCoursewareResCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase.IsNeedGeneWord);
}
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.WordCreateDate, objvCoursewareResCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.IsVisible) == true)
{
if (objvCoursewareResCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase.IsVisible);
}
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.IsDualVideo) == true)
{
if (objvCoursewareResCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase.IsDualVideo);
}
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.id_XzCollege, objvCoursewareResCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CollegeID, objvCoursewareResCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CollegeName, objvCoursewareResCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CollegeNameA, objvCoursewareResCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.id_XzMajor, objvCoursewareResCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.MajorID) == true)
{
string strComparisonOp_MajorID = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.MajorID, objvCoursewareResCase_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.MajorName) == true)
{
string strComparisonOp_MajorName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.MajorName, objvCoursewareResCase_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CourseChapterId, objvCoursewareResCase_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CourseChapterName, objvCoursewareResCase_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.ParentNodeID, objvCoursewareResCase_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.ParentNodeName, objvCoursewareResCase_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase.ViewCount, objvCoursewareResCase_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.IsShow) == true)
{
if (objvCoursewareResCase_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase.IsShow);
}
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase.DownloadNumber, objvCoursewareResCase_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase.FileIntegration, objvCoursewareResCase_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase.LikeCount, objvCoursewareResCase_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase.CollectionCount, objvCoursewareResCase_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.RecommendedDegreeId, objvCoursewareResCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.RecommendedDegreeName, objvCoursewareResCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.ftpFileType, objvCoursewareResCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CourseId) == true)
{
string strComparisonOp_CourseId = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CourseId, objvCoursewareResCase_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CourseCode, objvCoursewareResCase_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.CourseName) == true)
{
string strComparisonOp_CourseName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.CourseName, objvCoursewareResCase_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.VideoUrl, objvCoursewareResCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.VideoPath, objvCoursewareResCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.ResErrMsg, objvCoursewareResCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.UpdDate, objvCoursewareResCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.UpdUserId, objvCoursewareResCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.Memo) == true)
{
string strComparisonOp_Memo = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.Memo, objvCoursewareResCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.OwnerNameWithId, objvCoursewareResCase_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.OwnerName, objvCoursewareResCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase.BrowseCount4Case, objvCoursewareResCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvCoursewareResCase_Cond.IsUpdated(convCoursewareResCase.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvCoursewareResCase_Cond.dicFldComparisonOp[convCoursewareResCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase.IsHaveVideo, objvCoursewareResCase_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课件资源案例(vCoursewareResCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareResCaseWApi
{
private static readonly string mstrApiControllerName = "vCoursewareResCaseApi";

 public clsvCoursewareResCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CoursewareResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareResCaseEN GetObjById_CoursewareResCase(string strId_CoursewareResCase)
{
string strAction = "GetObjById_CoursewareResCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCaseEN objvCoursewareResCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CoursewareResCase"] = strId_CoursewareResCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCoursewareResCaseEN = JsonConvert.DeserializeObject<clsvCoursewareResCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCaseEN;
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
 /// <param name = "strId_CoursewareResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareResCaseEN GetObjById_CoursewareResCase_WA_Cache(string strId_CoursewareResCase)
{
string strAction = "GetObjById_CoursewareResCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCaseEN objvCoursewareResCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CoursewareResCase"] = strId_CoursewareResCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCoursewareResCaseEN = JsonConvert.DeserializeObject<clsvCoursewareResCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCaseEN;
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
public static clsvCoursewareResCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCaseEN objvCoursewareResCaseEN = null;
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
objvCoursewareResCaseEN = JsonConvert.DeserializeObject<clsvCoursewareResCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCaseEN;
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
 /// <param name = "strId_CoursewareResCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCoursewareResCaseEN GetObjById_CoursewareResCase_Cache(string strId_CoursewareResCase)
{
if (string.IsNullOrEmpty(strId_CoursewareResCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareResCaseEN._CurrTabName_S);
List<clsvCoursewareResCaseEN> arrvCoursewareResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareResCaseEN> arrvCoursewareResCaseObjLst_Sel =
from objvCoursewareResCaseEN in arrvCoursewareResCaseObjLst_Cache
where objvCoursewareResCaseEN.Id_CoursewareResCase == strId_CoursewareResCase
select objvCoursewareResCaseEN;
if (arrvCoursewareResCaseObjLst_Sel.Count() == 0)
{
   clsvCoursewareResCaseEN obj = clsvCoursewareResCaseWApi.GetObjById_CoursewareResCase(strId_CoursewareResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCoursewareResCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareResCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseEN> GetObjLstById_CoursewareResCaseLst(List<string> arrId_CoursewareResCase)
{
 List<clsvCoursewareResCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CoursewareResCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CoursewareResCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_CoursewareResCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCoursewareResCaseEN> GetObjLstById_CoursewareResCaseLst_Cache(List<string> arrId_CoursewareResCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareResCaseEN._CurrTabName_S);
List<clsvCoursewareResCaseEN> arrvCoursewareResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareResCaseEN> arrvCoursewareResCaseObjLst_Sel =
from objvCoursewareResCaseEN in arrvCoursewareResCaseObjLst_Cache
where arrId_CoursewareResCase.Contains(objvCoursewareResCaseEN.Id_CoursewareResCase)
select objvCoursewareResCaseEN;
return arrvCoursewareResCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareResCaseEN> GetObjLstById_CoursewareResCaseLst_WA_Cache(List<string> arrId_CoursewareResCase)
{
 List<clsvCoursewareResCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CoursewareResCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CoursewareResCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_CoursewareResCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CoursewareResCase"] = strId_CoursewareResCase
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
 /// <param name = "objvCoursewareResCaseENS">源对象</param>
 /// <param name = "objvCoursewareResCaseENT">目标对象</param>
 public static void CopyTo(clsvCoursewareResCaseEN objvCoursewareResCaseENS, clsvCoursewareResCaseEN objvCoursewareResCaseENT)
{
try
{
objvCoursewareResCaseENT.Id_CoursewareResCase = objvCoursewareResCaseENS.Id_CoursewareResCase; //课件资源案例流水号
objvCoursewareResCaseENT.CoursewareResCaseID = objvCoursewareResCaseENS.CoursewareResCaseID; //课件资源案例ID
objvCoursewareResCaseENT.CoursewareResCaseName = objvCoursewareResCaseENS.CoursewareResCaseName; //课件资源案例名称
objvCoursewareResCaseENT.CoursewareResCaseTheme = objvCoursewareResCaseENS.CoursewareResCaseTheme; //课件资源案例主题词
objvCoursewareResCaseENT.CoursewareResCaseText = objvCoursewareResCaseENS.CoursewareResCaseText; //案例文本内容
objvCoursewareResCaseENT.id_CoursewareResCaseType = objvCoursewareResCaseENS.id_CoursewareResCaseType; //课件资源类型流水号
objvCoursewareResCaseENT.CoursewareResCaseTypeName = objvCoursewareResCaseENS.CoursewareResCaseTypeName; //课件资源案例类型名称
objvCoursewareResCaseENT.CoursewareResCaseDate = objvCoursewareResCaseENS.CoursewareResCaseDate; //视频资源日期
objvCoursewareResCaseENT.CoursewareResCaseTime = objvCoursewareResCaseENS.CoursewareResCaseTime; //视频资源时间
objvCoursewareResCaseENT.CoursewareResCaseDateIn = objvCoursewareResCaseENS.CoursewareResCaseDateIn; //案例入库日期
objvCoursewareResCaseENT.CoursewareResCaseTimeIn = objvCoursewareResCaseENS.CoursewareResCaseTimeIn; //案例入库时间
objvCoursewareResCaseENT.OwnerId = objvCoursewareResCaseENS.OwnerId; //拥有者Id
objvCoursewareResCaseENT.id_StudyLevel = objvCoursewareResCaseENS.id_StudyLevel; //id_StudyLevel
objvCoursewareResCaseENT.StudyLevelName = objvCoursewareResCaseENS.StudyLevelName; //学段名称
objvCoursewareResCaseENT.id_TeachingPlan = objvCoursewareResCaseENS.id_TeachingPlan; //教案流水号
objvCoursewareResCaseENT.id_Discipline = objvCoursewareResCaseENS.id_Discipline; //学科流水号
objvCoursewareResCaseENT.DisciplineID = objvCoursewareResCaseENS.DisciplineID; //学科ID
objvCoursewareResCaseENT.DisciplineName = objvCoursewareResCaseENS.DisciplineName; //学科名称
objvCoursewareResCaseENT.id_SenateGaugeVersion = objvCoursewareResCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvCoursewareResCaseENT.senateGaugeVersionID = objvCoursewareResCaseENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareResCaseENT.senateGaugeVersionName = objvCoursewareResCaseENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareResCaseENT.senateGaugeVersionTtlScore = objvCoursewareResCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareResCaseENT.VersionNo = objvCoursewareResCaseENS.VersionNo; //版本号
objvCoursewareResCaseENT.id_TeachSkill = objvCoursewareResCaseENS.id_TeachSkill; //教学技能流水号
objvCoursewareResCaseENT.TeachSkillID = objvCoursewareResCaseENS.TeachSkillID; //教学技能ID
objvCoursewareResCaseENT.SkillTypeName = objvCoursewareResCaseENS.SkillTypeName; //技能类型名称
objvCoursewareResCaseENT.TeachSkillName = objvCoursewareResCaseENS.TeachSkillName; //教学技能名称
objvCoursewareResCaseENT.TeachSkillTheory = objvCoursewareResCaseENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareResCaseENT.TeachSkillOperMethod = objvCoursewareResCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareResCaseENT.id_SkillType = objvCoursewareResCaseENS.id_SkillType; //技能类型流水号
objvCoursewareResCaseENT.SkillTypeID = objvCoursewareResCaseENS.SkillTypeID; //技能类型ID
objvCoursewareResCaseENT.CaseLevelId = objvCoursewareResCaseENS.CaseLevelId; //课例等级Id
objvCoursewareResCaseENT.CaseLevelName = objvCoursewareResCaseENS.CaseLevelName; //案例等级名称
objvCoursewareResCaseENT.DocFile = objvCoursewareResCaseENS.DocFile; //生成的Word文件名
objvCoursewareResCaseENT.IsNeedGeneWord = objvCoursewareResCaseENS.IsNeedGeneWord; //是否需要生成Word
objvCoursewareResCaseENT.WordCreateDate = objvCoursewareResCaseENS.WordCreateDate; //Word生成日期
objvCoursewareResCaseENT.IsVisible = objvCoursewareResCaseENS.IsVisible; //是否显示
objvCoursewareResCaseENT.IsDualVideo = objvCoursewareResCaseENS.IsDualVideo; //是否双视频
objvCoursewareResCaseENT.id_XzCollege = objvCoursewareResCaseENS.id_XzCollege; //学院流水号
objvCoursewareResCaseENT.CollegeID = objvCoursewareResCaseENS.CollegeID; //学院ID
objvCoursewareResCaseENT.CollegeName = objvCoursewareResCaseENS.CollegeName; //学院名称
objvCoursewareResCaseENT.CollegeNameA = objvCoursewareResCaseENS.CollegeNameA; //学院名称简写
objvCoursewareResCaseENT.id_XzMajor = objvCoursewareResCaseENS.id_XzMajor; //专业流水号
objvCoursewareResCaseENT.MajorID = objvCoursewareResCaseENS.MajorID; //专业ID
objvCoursewareResCaseENT.MajorName = objvCoursewareResCaseENS.MajorName; //专业名称
objvCoursewareResCaseENT.CourseChapterId = objvCoursewareResCaseENS.CourseChapterId; //课程章节ID
objvCoursewareResCaseENT.CourseChapterName = objvCoursewareResCaseENS.CourseChapterName; //课程章节名称
objvCoursewareResCaseENT.ParentNodeID = objvCoursewareResCaseENS.ParentNodeID; //父节点编号
objvCoursewareResCaseENT.ParentNodeName = objvCoursewareResCaseENS.ParentNodeName; //父节点名称
objvCoursewareResCaseENT.ViewCount = objvCoursewareResCaseENS.ViewCount; //浏览量
objvCoursewareResCaseENT.IsShow = objvCoursewareResCaseENS.IsShow; //是否启用
objvCoursewareResCaseENT.DownloadNumber = objvCoursewareResCaseENS.DownloadNumber; //下载数目
objvCoursewareResCaseENT.FileIntegration = objvCoursewareResCaseENS.FileIntegration; //文件积分
objvCoursewareResCaseENT.LikeCount = objvCoursewareResCaseENS.LikeCount; //资源喜欢数量
objvCoursewareResCaseENT.CollectionCount = objvCoursewareResCaseENS.CollectionCount; //收藏数量
objvCoursewareResCaseENT.RecommendedDegreeId = objvCoursewareResCaseENS.RecommendedDegreeId; //推荐度Id
objvCoursewareResCaseENT.RecommendedDegreeName = objvCoursewareResCaseENS.RecommendedDegreeName; //推荐度名称
objvCoursewareResCaseENT.ftpFileType = objvCoursewareResCaseENS.ftpFileType; //ftp文件类型
objvCoursewareResCaseENT.CourseId = objvCoursewareResCaseENS.CourseId; //课程Id
objvCoursewareResCaseENT.CourseCode = objvCoursewareResCaseENS.CourseCode; //课程代码
objvCoursewareResCaseENT.CourseName = objvCoursewareResCaseENS.CourseName; //课程名称
objvCoursewareResCaseENT.VideoUrl = objvCoursewareResCaseENS.VideoUrl; //视频Url
objvCoursewareResCaseENT.VideoPath = objvCoursewareResCaseENS.VideoPath; //视频目录
objvCoursewareResCaseENT.ResErrMsg = objvCoursewareResCaseENS.ResErrMsg; //资源错误信息
objvCoursewareResCaseENT.UpdDate = objvCoursewareResCaseENS.UpdDate; //修改日期
objvCoursewareResCaseENT.UpdUserId = objvCoursewareResCaseENS.UpdUserId; //修改用户Id
objvCoursewareResCaseENT.Memo = objvCoursewareResCaseENS.Memo; //备注
objvCoursewareResCaseENT.OwnerNameWithId = objvCoursewareResCaseENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareResCaseENT.OwnerName = objvCoursewareResCaseENS.OwnerName; //拥有者姓名
objvCoursewareResCaseENT.BrowseCount4Case = objvCoursewareResCaseENS.BrowseCount4Case; //课例浏览次数
objvCoursewareResCaseENT.IsHaveVideo = objvCoursewareResCaseENS.IsHaveVideo; //IsHaveVideo
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
public static DataTable ToDataTable(List<clsvCoursewareResCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCoursewareResCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCoursewareResCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCoursewareResCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCoursewareResCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCoursewareResCaseEN.AttributeName)
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
if (clsCoursewareResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareResCaseWApi没有刷新缓存机制(clsCoursewareResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareResCaseTypeWApi没有刷新缓存机制(clsCoursewareResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_CoursewareResCase");
//if (arrvCoursewareResCaseObjLst_Cache == null)
//{
//arrvCoursewareResCaseObjLst_Cache = await clsvCoursewareResCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCoursewareResCaseEN._CurrTabName_S);
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
public static List<clsvCoursewareResCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCoursewareResCaseEN._CurrTabName_S);
List<clsvCoursewareResCaseEN> arrvCoursewareResCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCoursewareResCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCoursewareResCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCoursewareResCase.Id_CoursewareResCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CoursewareResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CoursewareResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CoursewareResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CoursewareResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.id_CoursewareResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CoursewareResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CoursewareResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CoursewareResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CoursewareResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CoursewareResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCoursewareResCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCase.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase.IsHaveVideo, Type.GetType("System.String"));
foreach (clsvCoursewareResCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCoursewareResCase.Id_CoursewareResCase] = objInFor[convCoursewareResCase.Id_CoursewareResCase];
objDR[convCoursewareResCase.CoursewareResCaseID] = objInFor[convCoursewareResCase.CoursewareResCaseID];
objDR[convCoursewareResCase.CoursewareResCaseName] = objInFor[convCoursewareResCase.CoursewareResCaseName];
objDR[convCoursewareResCase.CoursewareResCaseTheme] = objInFor[convCoursewareResCase.CoursewareResCaseTheme];
objDR[convCoursewareResCase.CoursewareResCaseText] = objInFor[convCoursewareResCase.CoursewareResCaseText];
objDR[convCoursewareResCase.id_CoursewareResCaseType] = objInFor[convCoursewareResCase.id_CoursewareResCaseType];
objDR[convCoursewareResCase.CoursewareResCaseTypeName] = objInFor[convCoursewareResCase.CoursewareResCaseTypeName];
objDR[convCoursewareResCase.CoursewareResCaseDate] = objInFor[convCoursewareResCase.CoursewareResCaseDate];
objDR[convCoursewareResCase.CoursewareResCaseTime] = objInFor[convCoursewareResCase.CoursewareResCaseTime];
objDR[convCoursewareResCase.CoursewareResCaseDateIn] = objInFor[convCoursewareResCase.CoursewareResCaseDateIn];
objDR[convCoursewareResCase.CoursewareResCaseTimeIn] = objInFor[convCoursewareResCase.CoursewareResCaseTimeIn];
objDR[convCoursewareResCase.OwnerId] = objInFor[convCoursewareResCase.OwnerId];
objDR[convCoursewareResCase.id_StudyLevel] = objInFor[convCoursewareResCase.id_StudyLevel];
objDR[convCoursewareResCase.StudyLevelName] = objInFor[convCoursewareResCase.StudyLevelName];
objDR[convCoursewareResCase.id_TeachingPlan] = objInFor[convCoursewareResCase.id_TeachingPlan];
objDR[convCoursewareResCase.id_Discipline] = objInFor[convCoursewareResCase.id_Discipline];
objDR[convCoursewareResCase.DisciplineID] = objInFor[convCoursewareResCase.DisciplineID];
objDR[convCoursewareResCase.DisciplineName] = objInFor[convCoursewareResCase.DisciplineName];
objDR[convCoursewareResCase.id_SenateGaugeVersion] = objInFor[convCoursewareResCase.id_SenateGaugeVersion];
objDR[convCoursewareResCase.senateGaugeVersionID] = objInFor[convCoursewareResCase.senateGaugeVersionID];
objDR[convCoursewareResCase.senateGaugeVersionName] = objInFor[convCoursewareResCase.senateGaugeVersionName];
objDR[convCoursewareResCase.senateGaugeVersionTtlScore] = objInFor[convCoursewareResCase.senateGaugeVersionTtlScore];
objDR[convCoursewareResCase.VersionNo] = objInFor[convCoursewareResCase.VersionNo];
objDR[convCoursewareResCase.id_TeachSkill] = objInFor[convCoursewareResCase.id_TeachSkill];
objDR[convCoursewareResCase.TeachSkillID] = objInFor[convCoursewareResCase.TeachSkillID];
objDR[convCoursewareResCase.SkillTypeName] = objInFor[convCoursewareResCase.SkillTypeName];
objDR[convCoursewareResCase.TeachSkillName] = objInFor[convCoursewareResCase.TeachSkillName];
objDR[convCoursewareResCase.TeachSkillTheory] = objInFor[convCoursewareResCase.TeachSkillTheory];
objDR[convCoursewareResCase.TeachSkillOperMethod] = objInFor[convCoursewareResCase.TeachSkillOperMethod];
objDR[convCoursewareResCase.id_SkillType] = objInFor[convCoursewareResCase.id_SkillType];
objDR[convCoursewareResCase.SkillTypeID] = objInFor[convCoursewareResCase.SkillTypeID];
objDR[convCoursewareResCase.CaseLevelId] = objInFor[convCoursewareResCase.CaseLevelId];
objDR[convCoursewareResCase.CaseLevelName] = objInFor[convCoursewareResCase.CaseLevelName];
objDR[convCoursewareResCase.DocFile] = objInFor[convCoursewareResCase.DocFile];
objDR[convCoursewareResCase.IsNeedGeneWord] = objInFor[convCoursewareResCase.IsNeedGeneWord];
objDR[convCoursewareResCase.WordCreateDate] = objInFor[convCoursewareResCase.WordCreateDate];
objDR[convCoursewareResCase.IsVisible] = objInFor[convCoursewareResCase.IsVisible];
objDR[convCoursewareResCase.IsDualVideo] = objInFor[convCoursewareResCase.IsDualVideo];
objDR[convCoursewareResCase.id_XzCollege] = objInFor[convCoursewareResCase.id_XzCollege];
objDR[convCoursewareResCase.CollegeID] = objInFor[convCoursewareResCase.CollegeID];
objDR[convCoursewareResCase.CollegeName] = objInFor[convCoursewareResCase.CollegeName];
objDR[convCoursewareResCase.CollegeNameA] = objInFor[convCoursewareResCase.CollegeNameA];
objDR[convCoursewareResCase.id_XzMajor] = objInFor[convCoursewareResCase.id_XzMajor];
objDR[convCoursewareResCase.MajorID] = objInFor[convCoursewareResCase.MajorID];
objDR[convCoursewareResCase.MajorName] = objInFor[convCoursewareResCase.MajorName];
objDR[convCoursewareResCase.CourseChapterId] = objInFor[convCoursewareResCase.CourseChapterId];
objDR[convCoursewareResCase.CourseChapterName] = objInFor[convCoursewareResCase.CourseChapterName];
objDR[convCoursewareResCase.ParentNodeID] = objInFor[convCoursewareResCase.ParentNodeID];
objDR[convCoursewareResCase.ParentNodeName] = objInFor[convCoursewareResCase.ParentNodeName];
objDR[convCoursewareResCase.ViewCount] = objInFor[convCoursewareResCase.ViewCount];
objDR[convCoursewareResCase.IsShow] = objInFor[convCoursewareResCase.IsShow];
objDR[convCoursewareResCase.DownloadNumber] = objInFor[convCoursewareResCase.DownloadNumber];
objDR[convCoursewareResCase.FileIntegration] = objInFor[convCoursewareResCase.FileIntegration];
objDR[convCoursewareResCase.LikeCount] = objInFor[convCoursewareResCase.LikeCount];
objDR[convCoursewareResCase.CollectionCount] = objInFor[convCoursewareResCase.CollectionCount];
objDR[convCoursewareResCase.RecommendedDegreeId] = objInFor[convCoursewareResCase.RecommendedDegreeId];
objDR[convCoursewareResCase.RecommendedDegreeName] = objInFor[convCoursewareResCase.RecommendedDegreeName];
objDR[convCoursewareResCase.ftpFileType] = objInFor[convCoursewareResCase.ftpFileType];
objDR[convCoursewareResCase.CourseId] = objInFor[convCoursewareResCase.CourseId];
objDR[convCoursewareResCase.CourseCode] = objInFor[convCoursewareResCase.CourseCode];
objDR[convCoursewareResCase.CourseName] = objInFor[convCoursewareResCase.CourseName];
objDR[convCoursewareResCase.VideoUrl] = objInFor[convCoursewareResCase.VideoUrl];
objDR[convCoursewareResCase.VideoPath] = objInFor[convCoursewareResCase.VideoPath];
objDR[convCoursewareResCase.ResErrMsg] = objInFor[convCoursewareResCase.ResErrMsg];
objDR[convCoursewareResCase.UpdDate] = objInFor[convCoursewareResCase.UpdDate];
objDR[convCoursewareResCase.UpdUserId] = objInFor[convCoursewareResCase.UpdUserId];
objDR[convCoursewareResCase.Memo] = objInFor[convCoursewareResCase.Memo];
objDR[convCoursewareResCase.OwnerNameWithId] = objInFor[convCoursewareResCase.OwnerNameWithId];
objDR[convCoursewareResCase.OwnerName] = objInFor[convCoursewareResCase.OwnerName];
objDR[convCoursewareResCase.BrowseCount4Case] = objInFor[convCoursewareResCase.BrowseCount4Case];
objDR[convCoursewareResCase.IsHaveVideo] = objInFor[convCoursewareResCase.IsHaveVideo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}