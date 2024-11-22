
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCase_BaseWApi
 表名:vCoursewareResCase_Base(01120496)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:08
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
public static class clsvCoursewareResCase_BaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetId_CoursewareResCase(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strId_CoursewareResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CoursewareResCase, 8, convCoursewareResCase_Base.Id_CoursewareResCase);
clsCheckSql.CheckFieldForeignKey(strId_CoursewareResCase, 8, convCoursewareResCase_Base.Id_CoursewareResCase);
objvCoursewareResCase_BaseEN.Id_CoursewareResCase = strId_CoursewareResCase; //课件资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.Id_CoursewareResCase) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.Id_CoursewareResCase, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.Id_CoursewareResCase] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCoursewareResCaseID(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCoursewareResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareResCaseID, convCoursewareResCase_Base.CoursewareResCaseID);
clsCheckSql.CheckFieldLen(strCoursewareResCaseID, 8, convCoursewareResCase_Base.CoursewareResCaseID);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseID, 8, convCoursewareResCase_Base.CoursewareResCaseID);
objvCoursewareResCase_BaseEN.CoursewareResCaseID = strCoursewareResCaseID; //课件资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CoursewareResCaseID) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CoursewareResCaseID, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseID] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCoursewareResCaseName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCoursewareResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareResCaseName, convCoursewareResCase_Base.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(strCoursewareResCaseName, 100, convCoursewareResCase_Base.CoursewareResCaseName);
objvCoursewareResCase_BaseEN.CoursewareResCaseName = strCoursewareResCaseName; //课件资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CoursewareResCaseName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CoursewareResCaseName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCoursewareResCaseTheme(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCoursewareResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTheme, 200, convCoursewareResCase_Base.CoursewareResCaseTheme);
objvCoursewareResCase_BaseEN.CoursewareResCaseTheme = strCoursewareResCaseTheme; //课件资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CoursewareResCaseTheme) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CoursewareResCaseTheme, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseTheme] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCoursewareResCaseText(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCoursewareResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseText, 8000, convCoursewareResCase_Base.CoursewareResCaseText);
objvCoursewareResCase_BaseEN.CoursewareResCaseText = strCoursewareResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CoursewareResCaseText) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CoursewareResCaseText, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseText] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN Setid_CoursewareResCaseType(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strid_CoursewareResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CoursewareResCaseType, convCoursewareResCase_Base.id_CoursewareResCaseType);
clsCheckSql.CheckFieldLen(strid_CoursewareResCaseType, 4, convCoursewareResCase_Base.id_CoursewareResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareResCaseType, 4, convCoursewareResCase_Base.id_CoursewareResCaseType);
objvCoursewareResCase_BaseEN.id_CoursewareResCaseType = strid_CoursewareResCaseType; //课件资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.id_CoursewareResCaseType) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.id_CoursewareResCaseType, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.id_CoursewareResCaseType] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCoursewareResCaseTypeName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCoursewareResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTypeName, 30, convCoursewareResCase_Base.CoursewareResCaseTypeName);
objvCoursewareResCase_BaseEN.CoursewareResCaseTypeName = strCoursewareResCaseTypeName; //课件资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CoursewareResCaseTypeName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CoursewareResCaseTypeName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseTypeName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCoursewareResCaseDate(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCoursewareResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseDate, 8, convCoursewareResCase_Base.CoursewareResCaseDate);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseDate, 8, convCoursewareResCase_Base.CoursewareResCaseDate);
objvCoursewareResCase_BaseEN.CoursewareResCaseDate = strCoursewareResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CoursewareResCaseDate) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CoursewareResCaseDate, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseDate] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCoursewareResCaseTime(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCoursewareResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTime, 6, convCoursewareResCase_Base.CoursewareResCaseTime);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTime, 6, convCoursewareResCase_Base.CoursewareResCaseTime);
objvCoursewareResCase_BaseEN.CoursewareResCaseTime = strCoursewareResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CoursewareResCaseTime) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CoursewareResCaseTime, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseTime] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCoursewareResCaseDateIn(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCoursewareResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseDateIn, 8, convCoursewareResCase_Base.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseDateIn, 8, convCoursewareResCase_Base.CoursewareResCaseDateIn);
objvCoursewareResCase_BaseEN.CoursewareResCaseDateIn = strCoursewareResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CoursewareResCaseDateIn) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CoursewareResCaseDateIn, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseDateIn] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCoursewareResCaseTimeIn(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCoursewareResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTimeIn, 6, convCoursewareResCase_Base.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTimeIn, 6, convCoursewareResCase_Base.CoursewareResCaseTimeIn);
objvCoursewareResCase_BaseEN.CoursewareResCaseTimeIn = strCoursewareResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CoursewareResCaseTimeIn) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CoursewareResCaseTimeIn, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseTimeIn] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetOwnerId(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCoursewareResCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCoursewareResCase_Base.OwnerId);
objvCoursewareResCase_BaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.OwnerId) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.OwnerId, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.OwnerId] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN Setid_StudyLevel(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCoursewareResCase_Base.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCoursewareResCase_Base.id_StudyLevel);
objvCoursewareResCase_BaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.id_StudyLevel) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.id_StudyLevel, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.id_StudyLevel] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetStudyLevelName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCoursewareResCase_Base.StudyLevelName);
objvCoursewareResCase_BaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.StudyLevelName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.StudyLevelName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.StudyLevelName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN Setid_TeachingPlan(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCoursewareResCase_Base.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCoursewareResCase_Base.id_TeachingPlan);
objvCoursewareResCase_BaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.id_TeachingPlan) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.id_TeachingPlan, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.id_TeachingPlan] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN Setid_Discipline(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convCoursewareResCase_Base.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCoursewareResCase_Base.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCoursewareResCase_Base.id_Discipline);
objvCoursewareResCase_BaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.id_Discipline) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.id_Discipline, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.id_Discipline] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetDisciplineID(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCoursewareResCase_Base.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCoursewareResCase_Base.DisciplineID);
objvCoursewareResCase_BaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.DisciplineID) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.DisciplineID, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.DisciplineID] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetDisciplineName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCoursewareResCase_Base.DisciplineName);
objvCoursewareResCase_BaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.DisciplineName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.DisciplineName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.DisciplineName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN Setid_SenateGaugeVersion(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCoursewareResCase_Base.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCoursewareResCase_Base.id_SenateGaugeVersion);
objvCoursewareResCase_BaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.id_SenateGaugeVersion) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetsenateGaugeVersionID(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCoursewareResCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCoursewareResCase_Base.senateGaugeVersionID);
objvCoursewareResCase_BaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.senateGaugeVersionID) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetsenateGaugeVersionName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCoursewareResCase_Base.senateGaugeVersionName);
objvCoursewareResCase_BaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.senateGaugeVersionName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.senateGaugeVersionTtlScore) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetVersionNo(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, int intVersionNo, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.VersionNo) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.VersionNo, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.VersionNo] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN Setid_TeachSkill(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convCoursewareResCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCoursewareResCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCoursewareResCase_Base.id_TeachSkill);
objvCoursewareResCase_BaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.id_TeachSkill) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.id_TeachSkill, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.id_TeachSkill] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetTeachSkillID(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCoursewareResCase_Base.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCoursewareResCase_Base.TeachSkillID);
objvCoursewareResCase_BaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.TeachSkillID) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.TeachSkillID, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.TeachSkillID] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetSkillTypeName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCoursewareResCase_Base.SkillTypeName);
objvCoursewareResCase_BaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.SkillTypeName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.SkillTypeName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.SkillTypeName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetTeachSkillName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCoursewareResCase_Base.TeachSkillName);
objvCoursewareResCase_BaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.TeachSkillName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.TeachSkillName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.TeachSkillName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetTeachSkillTheory(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCoursewareResCase_Base.TeachSkillTheory);
objvCoursewareResCase_BaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.TeachSkillTheory) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.TeachSkillTheory, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.TeachSkillTheory] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetTeachSkillOperMethod(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCoursewareResCase_Base.TeachSkillOperMethod);
objvCoursewareResCase_BaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.TeachSkillOperMethod) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN Setid_SkillType(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convCoursewareResCase_Base.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convCoursewareResCase_Base.id_SkillType);
objvCoursewareResCase_BaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.id_SkillType) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.id_SkillType, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.id_SkillType] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetSkillTypeID(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCoursewareResCase_Base.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCoursewareResCase_Base.SkillTypeID);
objvCoursewareResCase_BaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.SkillTypeID) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.SkillTypeID, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.SkillTypeID] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCaseLevelId(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCoursewareResCase_Base.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCoursewareResCase_Base.CaseLevelId);
objvCoursewareResCase_BaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CaseLevelId) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CaseLevelId, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CaseLevelId] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCaseLevelName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convCoursewareResCase_Base.CaseLevelName);
objvCoursewareResCase_BaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CaseLevelName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CaseLevelName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CaseLevelName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetDocFile(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCoursewareResCase_Base.DocFile);
objvCoursewareResCase_BaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.DocFile) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.DocFile, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.DocFile] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetIsNeedGeneWord(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.IsNeedGeneWord) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetWordCreateDate(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCoursewareResCase_Base.WordCreateDate);
objvCoursewareResCase_BaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.WordCreateDate) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.WordCreateDate, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.WordCreateDate] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetIsVisible(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.IsVisible) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.IsVisible, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.IsVisible] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetIsDualVideo(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.IsDualVideo) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.IsDualVideo, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.IsDualVideo] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN Setid_XzCollege(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convCoursewareResCase_Base.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCoursewareResCase_Base.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCoursewareResCase_Base.id_XzCollege);
objvCoursewareResCase_BaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.id_XzCollege) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.id_XzCollege, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.id_XzCollege] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCollegeID(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCoursewareResCase_Base.CollegeID);
objvCoursewareResCase_BaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CollegeID) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CollegeID, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CollegeID] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCollegeName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCoursewareResCase_Base.CollegeName);
objvCoursewareResCase_BaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CollegeName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CollegeName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CollegeName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCollegeNameA(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCoursewareResCase_Base.CollegeNameA);
objvCoursewareResCase_BaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CollegeNameA) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CollegeNameA, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CollegeNameA] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN Setid_XzMajor(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convCoursewareResCase_Base.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCoursewareResCase_Base.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCoursewareResCase_Base.id_XzMajor);
objvCoursewareResCase_BaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.id_XzMajor) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.id_XzMajor, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.id_XzMajor] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetMajorID(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCoursewareResCase_Base.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCoursewareResCase_Base.MajorID);
objvCoursewareResCase_BaseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.MajorID) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.MajorID, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.MajorID] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetMajorName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCoursewareResCase_Base.MajorName);
objvCoursewareResCase_BaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.MajorName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.MajorName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.MajorName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCourseChapterId(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCoursewareResCase_Base.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCoursewareResCase_Base.CourseChapterId);
objvCoursewareResCase_BaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CourseChapterId) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CourseChapterId, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CourseChapterId] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCourseChapterName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCoursewareResCase_Base.CourseChapterName);
objvCoursewareResCase_BaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CourseChapterName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CourseChapterName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CourseChapterName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetParentNodeID(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCoursewareResCase_Base.ParentNodeID);
objvCoursewareResCase_BaseEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.ParentNodeID) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.ParentNodeID, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.ParentNodeID] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetParentNodeName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCoursewareResCase_Base.ParentNodeName);
objvCoursewareResCase_BaseEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.ParentNodeName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.ParentNodeName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.ParentNodeName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetViewCount(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, int intViewCount, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.ViewCount) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.ViewCount, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.ViewCount] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetIsShow(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.IsShow) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.IsShow, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.IsShow] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetDownloadNumber(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.DownloadNumber) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.DownloadNumber, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.DownloadNumber] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetFileIntegration(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, int intFileIntegration, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.FileIntegration) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.FileIntegration, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.FileIntegration] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetLikeCount(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, long lngLikeCount, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.LikeCount) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.LikeCount, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.LikeCount] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCollectionCount(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CollectionCount) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CollectionCount, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CollectionCount] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetRecommendedDegreeId(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCoursewareResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCoursewareResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCoursewareResCase_Base.RecommendedDegreeId);
objvCoursewareResCase_BaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.RecommendedDegreeId) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetRecommendedDegreeName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCoursewareResCase_Base.RecommendedDegreeName);
objvCoursewareResCase_BaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.RecommendedDegreeName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetftpFileType(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCoursewareResCase_Base.ftpFileType);
objvCoursewareResCase_BaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.ftpFileType) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.ftpFileType, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.ftpFileType] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCourseId(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCoursewareResCase_Base.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convCoursewareResCase_Base.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCoursewareResCase_Base.CourseId);
objvCoursewareResCase_BaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CourseId) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CourseId, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CourseId] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCourseCode(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCoursewareResCase_Base.CourseCode);
objvCoursewareResCase_BaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CourseCode) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CourseCode, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CourseCode] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetCourseName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCoursewareResCase_Base.CourseName);
objvCoursewareResCase_BaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.CourseName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.CourseName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.CourseName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetVideoUrl(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convCoursewareResCase_Base.VideoUrl);
objvCoursewareResCase_BaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.VideoUrl) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.VideoUrl, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.VideoUrl] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetVideoPath(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convCoursewareResCase_Base.VideoPath);
objvCoursewareResCase_BaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.VideoPath) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.VideoPath, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.VideoPath] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetResErrMsg(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convCoursewareResCase_Base.ResErrMsg);
objvCoursewareResCase_BaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.ResErrMsg) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.ResErrMsg, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.ResErrMsg] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetMemo(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCoursewareResCase_Base.Memo);
objvCoursewareResCase_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.Memo) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.Memo, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.Memo] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetOwnerName(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCoursewareResCase_Base.OwnerName);
objvCoursewareResCase_BaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.OwnerName) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.OwnerName, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.OwnerName] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetOwnerNameWithId(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCoursewareResCase_Base.OwnerNameWithId);
objvCoursewareResCase_BaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.OwnerNameWithId) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.OwnerNameWithId, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.OwnerNameWithId] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_BaseEN SetBrowseCount4Case(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCoursewareResCase_BaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_BaseEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Base.BrowseCount4Case) == false)
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp.Add(convCoursewareResCase_Base.BrowseCount4Case, strComparisonOp);
}
else
{
objvCoursewareResCase_BaseEN.dicFldComparisonOp[convCoursewareResCase_Base.BrowseCount4Case] = strComparisonOp;
}
}
return objvCoursewareResCase_BaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCoursewareResCase_BaseEN objvCoursewareResCase_Base_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.Id_CoursewareResCase) == true)
{
string strComparisonOp_Id_CoursewareResCase = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.Id_CoursewareResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.Id_CoursewareResCase, objvCoursewareResCase_Base_Cond.Id_CoursewareResCase, strComparisonOp_Id_CoursewareResCase);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CoursewareResCaseID) == true)
{
string strComparisonOp_CoursewareResCaseID = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CoursewareResCaseID, objvCoursewareResCase_Base_Cond.CoursewareResCaseID, strComparisonOp_CoursewareResCaseID);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CoursewareResCaseName) == true)
{
string strComparisonOp_CoursewareResCaseName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CoursewareResCaseName, objvCoursewareResCase_Base_Cond.CoursewareResCaseName, strComparisonOp_CoursewareResCaseName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CoursewareResCaseTheme) == true)
{
string strComparisonOp_CoursewareResCaseTheme = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CoursewareResCaseTheme, objvCoursewareResCase_Base_Cond.CoursewareResCaseTheme, strComparisonOp_CoursewareResCaseTheme);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CoursewareResCaseText) == true)
{
string strComparisonOp_CoursewareResCaseText = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CoursewareResCaseText, objvCoursewareResCase_Base_Cond.CoursewareResCaseText, strComparisonOp_CoursewareResCaseText);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.id_CoursewareResCaseType) == true)
{
string strComparisonOp_id_CoursewareResCaseType = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.id_CoursewareResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.id_CoursewareResCaseType, objvCoursewareResCase_Base_Cond.id_CoursewareResCaseType, strComparisonOp_id_CoursewareResCaseType);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CoursewareResCaseTypeName) == true)
{
string strComparisonOp_CoursewareResCaseTypeName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CoursewareResCaseTypeName, objvCoursewareResCase_Base_Cond.CoursewareResCaseTypeName, strComparisonOp_CoursewareResCaseTypeName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CoursewareResCaseDate) == true)
{
string strComparisonOp_CoursewareResCaseDate = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CoursewareResCaseDate, objvCoursewareResCase_Base_Cond.CoursewareResCaseDate, strComparisonOp_CoursewareResCaseDate);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CoursewareResCaseTime) == true)
{
string strComparisonOp_CoursewareResCaseTime = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CoursewareResCaseTime, objvCoursewareResCase_Base_Cond.CoursewareResCaseTime, strComparisonOp_CoursewareResCaseTime);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CoursewareResCaseDateIn) == true)
{
string strComparisonOp_CoursewareResCaseDateIn = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CoursewareResCaseDateIn, objvCoursewareResCase_Base_Cond.CoursewareResCaseDateIn, strComparisonOp_CoursewareResCaseDateIn);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CoursewareResCaseTimeIn) == true)
{
string strComparisonOp_CoursewareResCaseTimeIn = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CoursewareResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CoursewareResCaseTimeIn, objvCoursewareResCase_Base_Cond.CoursewareResCaseTimeIn, strComparisonOp_CoursewareResCaseTimeIn);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.OwnerId, objvCoursewareResCase_Base_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.id_StudyLevel, objvCoursewareResCase_Base_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.StudyLevelName, objvCoursewareResCase_Base_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.id_TeachingPlan, objvCoursewareResCase_Base_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.id_Discipline, objvCoursewareResCase_Base_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.DisciplineID, objvCoursewareResCase_Base_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.DisciplineName, objvCoursewareResCase_Base_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.id_SenateGaugeVersion, objvCoursewareResCase_Base_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.senateGaugeVersionID, objvCoursewareResCase_Base_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.senateGaugeVersionName, objvCoursewareResCase_Base_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Base.senateGaugeVersionTtlScore, objvCoursewareResCase_Base_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Base.VersionNo, objvCoursewareResCase_Base_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.id_TeachSkill, objvCoursewareResCase_Base_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.TeachSkillID, objvCoursewareResCase_Base_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.SkillTypeName, objvCoursewareResCase_Base_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.TeachSkillName, objvCoursewareResCase_Base_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.TeachSkillTheory, objvCoursewareResCase_Base_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.TeachSkillOperMethod, objvCoursewareResCase_Base_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.id_SkillType, objvCoursewareResCase_Base_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.SkillTypeID, objvCoursewareResCase_Base_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CaseLevelId, objvCoursewareResCase_Base_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CaseLevelName, objvCoursewareResCase_Base_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.DocFile) == true)
{
string strComparisonOp_DocFile = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.DocFile, objvCoursewareResCase_Base_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.IsNeedGeneWord) == true)
{
if (objvCoursewareResCase_Base_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase_Base.IsNeedGeneWord);
}
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.WordCreateDate, objvCoursewareResCase_Base_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.IsVisible) == true)
{
if (objvCoursewareResCase_Base_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase_Base.IsVisible);
}
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.IsDualVideo) == true)
{
if (objvCoursewareResCase_Base_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase_Base.IsDualVideo);
}
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.id_XzCollege, objvCoursewareResCase_Base_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CollegeID, objvCoursewareResCase_Base_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CollegeName, objvCoursewareResCase_Base_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CollegeNameA, objvCoursewareResCase_Base_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.id_XzMajor, objvCoursewareResCase_Base_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.MajorID) == true)
{
string strComparisonOp_MajorID = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.MajorID, objvCoursewareResCase_Base_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.MajorName) == true)
{
string strComparisonOp_MajorName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.MajorName, objvCoursewareResCase_Base_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CourseChapterId, objvCoursewareResCase_Base_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CourseChapterName, objvCoursewareResCase_Base_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.ParentNodeID, objvCoursewareResCase_Base_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.ParentNodeName, objvCoursewareResCase_Base_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Base.ViewCount, objvCoursewareResCase_Base_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.IsShow) == true)
{
if (objvCoursewareResCase_Base_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase_Base.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase_Base.IsShow);
}
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Base.DownloadNumber, objvCoursewareResCase_Base_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Base.FileIntegration, objvCoursewareResCase_Base_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Base.LikeCount, objvCoursewareResCase_Base_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Base.CollectionCount, objvCoursewareResCase_Base_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.RecommendedDegreeId, objvCoursewareResCase_Base_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.RecommendedDegreeName, objvCoursewareResCase_Base_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.ftpFileType, objvCoursewareResCase_Base_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CourseId) == true)
{
string strComparisonOp_CourseId = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CourseId, objvCoursewareResCase_Base_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CourseCode, objvCoursewareResCase_Base_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.CourseName) == true)
{
string strComparisonOp_CourseName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.CourseName, objvCoursewareResCase_Base_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.VideoUrl, objvCoursewareResCase_Base_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.VideoPath, objvCoursewareResCase_Base_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.ResErrMsg, objvCoursewareResCase_Base_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.Memo) == true)
{
string strComparisonOp_Memo = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.Memo, objvCoursewareResCase_Base_Cond.Memo, strComparisonOp_Memo);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.OwnerName, objvCoursewareResCase_Base_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Base.OwnerNameWithId, objvCoursewareResCase_Base_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCoursewareResCase_Base_Cond.IsUpdated(convCoursewareResCase_Base.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCoursewareResCase_Base_Cond.dicFldComparisonOp[convCoursewareResCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Base.BrowseCount4Case, objvCoursewareResCase_Base_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课件资源案例_Base(vCoursewareResCase_Base)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareResCase_BaseWApi
{
private static readonly string mstrApiControllerName = "vCoursewareResCase_BaseApi";

 public clsvCoursewareResCase_BaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CoursewareResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareResCase_BaseEN GetObjById_CoursewareResCase(string strId_CoursewareResCase)
{
string strAction = "GetObjById_CoursewareResCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN = null;
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
objvCoursewareResCase_BaseEN = JsonConvert.DeserializeObject<clsvCoursewareResCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCase_BaseEN;
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
public static clsvCoursewareResCase_BaseEN GetObjById_CoursewareResCase_WA_Cache(string strId_CoursewareResCase)
{
string strAction = "GetObjById_CoursewareResCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN = null;
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
objvCoursewareResCase_BaseEN = JsonConvert.DeserializeObject<clsvCoursewareResCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCase_BaseEN;
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
public static clsvCoursewareResCase_BaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN = null;
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
objvCoursewareResCase_BaseEN = JsonConvert.DeserializeObject<clsvCoursewareResCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCase_BaseEN;
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
public static clsvCoursewareResCase_BaseEN GetObjById_CoursewareResCase_Cache(string strId_CoursewareResCase)
{
if (string.IsNullOrEmpty(strId_CoursewareResCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareResCase_BaseEN._CurrTabName_S);
List<clsvCoursewareResCase_BaseEN> arrvCoursewareResCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareResCase_BaseEN> arrvCoursewareResCase_BaseObjLst_Sel =
from objvCoursewareResCase_BaseEN in arrvCoursewareResCase_BaseObjLst_Cache
where objvCoursewareResCase_BaseEN.Id_CoursewareResCase == strId_CoursewareResCase
select objvCoursewareResCase_BaseEN;
if (arrvCoursewareResCase_BaseObjLst_Sel.Count() == 0)
{
   clsvCoursewareResCase_BaseEN obj = clsvCoursewareResCase_BaseWApi.GetObjById_CoursewareResCase(strId_CoursewareResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCoursewareResCase_BaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareResCase_BaseEN> GetObjLst(string strWhereCond)
{
 List<clsvCoursewareResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCase_BaseEN> GetObjLstById_CoursewareResCaseLst(List<string> arrId_CoursewareResCase)
{
 List<clsvCoursewareResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCoursewareResCase_BaseEN> GetObjLstById_CoursewareResCaseLst_Cache(List<string> arrId_CoursewareResCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareResCase_BaseEN._CurrTabName_S);
List<clsvCoursewareResCase_BaseEN> arrvCoursewareResCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareResCase_BaseEN> arrvCoursewareResCase_BaseObjLst_Sel =
from objvCoursewareResCase_BaseEN in arrvCoursewareResCase_BaseObjLst_Cache
where arrId_CoursewareResCase.Contains(objvCoursewareResCase_BaseEN.Id_CoursewareResCase)
select objvCoursewareResCase_BaseEN;
return arrvCoursewareResCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareResCase_BaseEN> GetObjLstById_CoursewareResCaseLst_WA_Cache(List<string> arrId_CoursewareResCase)
{
 List<clsvCoursewareResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCoursewareResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCase_BaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCoursewareResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCoursewareResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCase_BaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCoursewareResCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCoursewareResCase_BaseENS">源对象</param>
 /// <param name = "objvCoursewareResCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseENS, clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseENT)
{
try
{
objvCoursewareResCase_BaseENT.Id_CoursewareResCase = objvCoursewareResCase_BaseENS.Id_CoursewareResCase; //课件资源案例流水号
objvCoursewareResCase_BaseENT.CoursewareResCaseID = objvCoursewareResCase_BaseENS.CoursewareResCaseID; //课件资源案例ID
objvCoursewareResCase_BaseENT.CoursewareResCaseName = objvCoursewareResCase_BaseENS.CoursewareResCaseName; //课件资源案例名称
objvCoursewareResCase_BaseENT.CoursewareResCaseTheme = objvCoursewareResCase_BaseENS.CoursewareResCaseTheme; //课件资源案例主题词
objvCoursewareResCase_BaseENT.CoursewareResCaseText = objvCoursewareResCase_BaseENS.CoursewareResCaseText; //案例文本内容
objvCoursewareResCase_BaseENT.id_CoursewareResCaseType = objvCoursewareResCase_BaseENS.id_CoursewareResCaseType; //课件资源类型流水号
objvCoursewareResCase_BaseENT.CoursewareResCaseTypeName = objvCoursewareResCase_BaseENS.CoursewareResCaseTypeName; //课件资源案例类型名称
objvCoursewareResCase_BaseENT.CoursewareResCaseDate = objvCoursewareResCase_BaseENS.CoursewareResCaseDate; //视频资源日期
objvCoursewareResCase_BaseENT.CoursewareResCaseTime = objvCoursewareResCase_BaseENS.CoursewareResCaseTime; //视频资源时间
objvCoursewareResCase_BaseENT.CoursewareResCaseDateIn = objvCoursewareResCase_BaseENS.CoursewareResCaseDateIn; //案例入库日期
objvCoursewareResCase_BaseENT.CoursewareResCaseTimeIn = objvCoursewareResCase_BaseENS.CoursewareResCaseTimeIn; //案例入库时间
objvCoursewareResCase_BaseENT.OwnerId = objvCoursewareResCase_BaseENS.OwnerId; //拥有者Id
objvCoursewareResCase_BaseENT.id_StudyLevel = objvCoursewareResCase_BaseENS.id_StudyLevel; //id_StudyLevel
objvCoursewareResCase_BaseENT.StudyLevelName = objvCoursewareResCase_BaseENS.StudyLevelName; //学段名称
objvCoursewareResCase_BaseENT.id_TeachingPlan = objvCoursewareResCase_BaseENS.id_TeachingPlan; //教案流水号
objvCoursewareResCase_BaseENT.id_Discipline = objvCoursewareResCase_BaseENS.id_Discipline; //学科流水号
objvCoursewareResCase_BaseENT.DisciplineID = objvCoursewareResCase_BaseENS.DisciplineID; //学科ID
objvCoursewareResCase_BaseENT.DisciplineName = objvCoursewareResCase_BaseENS.DisciplineName; //学科名称
objvCoursewareResCase_BaseENT.id_SenateGaugeVersion = objvCoursewareResCase_BaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvCoursewareResCase_BaseENT.senateGaugeVersionID = objvCoursewareResCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareResCase_BaseENT.senateGaugeVersionName = objvCoursewareResCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareResCase_BaseENT.senateGaugeVersionTtlScore = objvCoursewareResCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareResCase_BaseENT.VersionNo = objvCoursewareResCase_BaseENS.VersionNo; //版本号
objvCoursewareResCase_BaseENT.id_TeachSkill = objvCoursewareResCase_BaseENS.id_TeachSkill; //教学技能流水号
objvCoursewareResCase_BaseENT.TeachSkillID = objvCoursewareResCase_BaseENS.TeachSkillID; //教学技能ID
objvCoursewareResCase_BaseENT.SkillTypeName = objvCoursewareResCase_BaseENS.SkillTypeName; //技能类型名称
objvCoursewareResCase_BaseENT.TeachSkillName = objvCoursewareResCase_BaseENS.TeachSkillName; //教学技能名称
objvCoursewareResCase_BaseENT.TeachSkillTheory = objvCoursewareResCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareResCase_BaseENT.TeachSkillOperMethod = objvCoursewareResCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareResCase_BaseENT.id_SkillType = objvCoursewareResCase_BaseENS.id_SkillType; //技能类型流水号
objvCoursewareResCase_BaseENT.SkillTypeID = objvCoursewareResCase_BaseENS.SkillTypeID; //技能类型ID
objvCoursewareResCase_BaseENT.CaseLevelId = objvCoursewareResCase_BaseENS.CaseLevelId; //课例等级Id
objvCoursewareResCase_BaseENT.CaseLevelName = objvCoursewareResCase_BaseENS.CaseLevelName; //案例等级名称
objvCoursewareResCase_BaseENT.DocFile = objvCoursewareResCase_BaseENS.DocFile; //生成的Word文件名
objvCoursewareResCase_BaseENT.IsNeedGeneWord = objvCoursewareResCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvCoursewareResCase_BaseENT.WordCreateDate = objvCoursewareResCase_BaseENS.WordCreateDate; //Word生成日期
objvCoursewareResCase_BaseENT.IsVisible = objvCoursewareResCase_BaseENS.IsVisible; //是否显示
objvCoursewareResCase_BaseENT.IsDualVideo = objvCoursewareResCase_BaseENS.IsDualVideo; //是否双视频
objvCoursewareResCase_BaseENT.id_XzCollege = objvCoursewareResCase_BaseENS.id_XzCollege; //学院流水号
objvCoursewareResCase_BaseENT.CollegeID = objvCoursewareResCase_BaseENS.CollegeID; //学院ID
objvCoursewareResCase_BaseENT.CollegeName = objvCoursewareResCase_BaseENS.CollegeName; //学院名称
objvCoursewareResCase_BaseENT.CollegeNameA = objvCoursewareResCase_BaseENS.CollegeNameA; //学院名称简写
objvCoursewareResCase_BaseENT.id_XzMajor = objvCoursewareResCase_BaseENS.id_XzMajor; //专业流水号
objvCoursewareResCase_BaseENT.MajorID = objvCoursewareResCase_BaseENS.MajorID; //专业ID
objvCoursewareResCase_BaseENT.MajorName = objvCoursewareResCase_BaseENS.MajorName; //专业名称
objvCoursewareResCase_BaseENT.CourseChapterId = objvCoursewareResCase_BaseENS.CourseChapterId; //课程章节ID
objvCoursewareResCase_BaseENT.CourseChapterName = objvCoursewareResCase_BaseENS.CourseChapterName; //课程章节名称
objvCoursewareResCase_BaseENT.ParentNodeID = objvCoursewareResCase_BaseENS.ParentNodeID; //父节点编号
objvCoursewareResCase_BaseENT.ParentNodeName = objvCoursewareResCase_BaseENS.ParentNodeName; //父节点名称
objvCoursewareResCase_BaseENT.ViewCount = objvCoursewareResCase_BaseENS.ViewCount; //浏览量
objvCoursewareResCase_BaseENT.IsShow = objvCoursewareResCase_BaseENS.IsShow; //是否启用
objvCoursewareResCase_BaseENT.DownloadNumber = objvCoursewareResCase_BaseENS.DownloadNumber; //下载数目
objvCoursewareResCase_BaseENT.FileIntegration = objvCoursewareResCase_BaseENS.FileIntegration; //文件积分
objvCoursewareResCase_BaseENT.LikeCount = objvCoursewareResCase_BaseENS.LikeCount; //资源喜欢数量
objvCoursewareResCase_BaseENT.CollectionCount = objvCoursewareResCase_BaseENS.CollectionCount; //收藏数量
objvCoursewareResCase_BaseENT.RecommendedDegreeId = objvCoursewareResCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvCoursewareResCase_BaseENT.RecommendedDegreeName = objvCoursewareResCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvCoursewareResCase_BaseENT.ftpFileType = objvCoursewareResCase_BaseENS.ftpFileType; //ftp文件类型
objvCoursewareResCase_BaseENT.CourseId = objvCoursewareResCase_BaseENS.CourseId; //课程Id
objvCoursewareResCase_BaseENT.CourseCode = objvCoursewareResCase_BaseENS.CourseCode; //课程代码
objvCoursewareResCase_BaseENT.CourseName = objvCoursewareResCase_BaseENS.CourseName; //课程名称
objvCoursewareResCase_BaseENT.VideoUrl = objvCoursewareResCase_BaseENS.VideoUrl; //视频Url
objvCoursewareResCase_BaseENT.VideoPath = objvCoursewareResCase_BaseENS.VideoPath; //视频目录
objvCoursewareResCase_BaseENT.ResErrMsg = objvCoursewareResCase_BaseENS.ResErrMsg; //资源错误信息
objvCoursewareResCase_BaseENT.Memo = objvCoursewareResCase_BaseENS.Memo; //备注
objvCoursewareResCase_BaseENT.OwnerName = objvCoursewareResCase_BaseENS.OwnerName; //拥有者姓名
objvCoursewareResCase_BaseENT.OwnerNameWithId = objvCoursewareResCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareResCase_BaseENT.BrowseCount4Case = objvCoursewareResCase_BaseENS.BrowseCount4Case; //课例浏览次数
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
public static DataTable ToDataTable(List<clsvCoursewareResCase_BaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCoursewareResCase_BaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCoursewareResCase_BaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCoursewareResCase_BaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCoursewareResCase_BaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCoursewareResCase_BaseEN.AttributeName)
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
//if (arrvCoursewareResCase_BaseObjLst_Cache == null)
//{
//arrvCoursewareResCase_BaseObjLst_Cache = await clsvCoursewareResCase_BaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCoursewareResCase_BaseEN._CurrTabName_S);
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
public static List<clsvCoursewareResCase_BaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCoursewareResCase_BaseEN._CurrTabName_S);
List<clsvCoursewareResCase_BaseEN> arrvCoursewareResCase_BaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCoursewareResCase_BaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCoursewareResCase_BaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCoursewareResCase_Base.Id_CoursewareResCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CoursewareResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CoursewareResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CoursewareResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CoursewareResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.id_CoursewareResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CoursewareResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CoursewareResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CoursewareResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CoursewareResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CoursewareResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCoursewareResCase_Base.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Base.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase_Base.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase_Base.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase_Base.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Base.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase_Base.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Base.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Base.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCase_Base.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCase_Base.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Base.BrowseCount4Case, Type.GetType("System.Int32"));
foreach (clsvCoursewareResCase_BaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCoursewareResCase_Base.Id_CoursewareResCase] = objInFor[convCoursewareResCase_Base.Id_CoursewareResCase];
objDR[convCoursewareResCase_Base.CoursewareResCaseID] = objInFor[convCoursewareResCase_Base.CoursewareResCaseID];
objDR[convCoursewareResCase_Base.CoursewareResCaseName] = objInFor[convCoursewareResCase_Base.CoursewareResCaseName];
objDR[convCoursewareResCase_Base.CoursewareResCaseTheme] = objInFor[convCoursewareResCase_Base.CoursewareResCaseTheme];
objDR[convCoursewareResCase_Base.CoursewareResCaseText] = objInFor[convCoursewareResCase_Base.CoursewareResCaseText];
objDR[convCoursewareResCase_Base.id_CoursewareResCaseType] = objInFor[convCoursewareResCase_Base.id_CoursewareResCaseType];
objDR[convCoursewareResCase_Base.CoursewareResCaseTypeName] = objInFor[convCoursewareResCase_Base.CoursewareResCaseTypeName];
objDR[convCoursewareResCase_Base.CoursewareResCaseDate] = objInFor[convCoursewareResCase_Base.CoursewareResCaseDate];
objDR[convCoursewareResCase_Base.CoursewareResCaseTime] = objInFor[convCoursewareResCase_Base.CoursewareResCaseTime];
objDR[convCoursewareResCase_Base.CoursewareResCaseDateIn] = objInFor[convCoursewareResCase_Base.CoursewareResCaseDateIn];
objDR[convCoursewareResCase_Base.CoursewareResCaseTimeIn] = objInFor[convCoursewareResCase_Base.CoursewareResCaseTimeIn];
objDR[convCoursewareResCase_Base.OwnerId] = objInFor[convCoursewareResCase_Base.OwnerId];
objDR[convCoursewareResCase_Base.id_StudyLevel] = objInFor[convCoursewareResCase_Base.id_StudyLevel];
objDR[convCoursewareResCase_Base.StudyLevelName] = objInFor[convCoursewareResCase_Base.StudyLevelName];
objDR[convCoursewareResCase_Base.id_TeachingPlan] = objInFor[convCoursewareResCase_Base.id_TeachingPlan];
objDR[convCoursewareResCase_Base.id_Discipline] = objInFor[convCoursewareResCase_Base.id_Discipline];
objDR[convCoursewareResCase_Base.DisciplineID] = objInFor[convCoursewareResCase_Base.DisciplineID];
objDR[convCoursewareResCase_Base.DisciplineName] = objInFor[convCoursewareResCase_Base.DisciplineName];
objDR[convCoursewareResCase_Base.id_SenateGaugeVersion] = objInFor[convCoursewareResCase_Base.id_SenateGaugeVersion];
objDR[convCoursewareResCase_Base.senateGaugeVersionID] = objInFor[convCoursewareResCase_Base.senateGaugeVersionID];
objDR[convCoursewareResCase_Base.senateGaugeVersionName] = objInFor[convCoursewareResCase_Base.senateGaugeVersionName];
objDR[convCoursewareResCase_Base.senateGaugeVersionTtlScore] = objInFor[convCoursewareResCase_Base.senateGaugeVersionTtlScore];
objDR[convCoursewareResCase_Base.VersionNo] = objInFor[convCoursewareResCase_Base.VersionNo];
objDR[convCoursewareResCase_Base.id_TeachSkill] = objInFor[convCoursewareResCase_Base.id_TeachSkill];
objDR[convCoursewareResCase_Base.TeachSkillID] = objInFor[convCoursewareResCase_Base.TeachSkillID];
objDR[convCoursewareResCase_Base.SkillTypeName] = objInFor[convCoursewareResCase_Base.SkillTypeName];
objDR[convCoursewareResCase_Base.TeachSkillName] = objInFor[convCoursewareResCase_Base.TeachSkillName];
objDR[convCoursewareResCase_Base.TeachSkillTheory] = objInFor[convCoursewareResCase_Base.TeachSkillTheory];
objDR[convCoursewareResCase_Base.TeachSkillOperMethod] = objInFor[convCoursewareResCase_Base.TeachSkillOperMethod];
objDR[convCoursewareResCase_Base.id_SkillType] = objInFor[convCoursewareResCase_Base.id_SkillType];
objDR[convCoursewareResCase_Base.SkillTypeID] = objInFor[convCoursewareResCase_Base.SkillTypeID];
objDR[convCoursewareResCase_Base.CaseLevelId] = objInFor[convCoursewareResCase_Base.CaseLevelId];
objDR[convCoursewareResCase_Base.CaseLevelName] = objInFor[convCoursewareResCase_Base.CaseLevelName];
objDR[convCoursewareResCase_Base.DocFile] = objInFor[convCoursewareResCase_Base.DocFile];
objDR[convCoursewareResCase_Base.IsNeedGeneWord] = objInFor[convCoursewareResCase_Base.IsNeedGeneWord];
objDR[convCoursewareResCase_Base.WordCreateDate] = objInFor[convCoursewareResCase_Base.WordCreateDate];
objDR[convCoursewareResCase_Base.IsVisible] = objInFor[convCoursewareResCase_Base.IsVisible];
objDR[convCoursewareResCase_Base.IsDualVideo] = objInFor[convCoursewareResCase_Base.IsDualVideo];
objDR[convCoursewareResCase_Base.id_XzCollege] = objInFor[convCoursewareResCase_Base.id_XzCollege];
objDR[convCoursewareResCase_Base.CollegeID] = objInFor[convCoursewareResCase_Base.CollegeID];
objDR[convCoursewareResCase_Base.CollegeName] = objInFor[convCoursewareResCase_Base.CollegeName];
objDR[convCoursewareResCase_Base.CollegeNameA] = objInFor[convCoursewareResCase_Base.CollegeNameA];
objDR[convCoursewareResCase_Base.id_XzMajor] = objInFor[convCoursewareResCase_Base.id_XzMajor];
objDR[convCoursewareResCase_Base.MajorID] = objInFor[convCoursewareResCase_Base.MajorID];
objDR[convCoursewareResCase_Base.MajorName] = objInFor[convCoursewareResCase_Base.MajorName];
objDR[convCoursewareResCase_Base.CourseChapterId] = objInFor[convCoursewareResCase_Base.CourseChapterId];
objDR[convCoursewareResCase_Base.CourseChapterName] = objInFor[convCoursewareResCase_Base.CourseChapterName];
objDR[convCoursewareResCase_Base.ParentNodeID] = objInFor[convCoursewareResCase_Base.ParentNodeID];
objDR[convCoursewareResCase_Base.ParentNodeName] = objInFor[convCoursewareResCase_Base.ParentNodeName];
objDR[convCoursewareResCase_Base.ViewCount] = objInFor[convCoursewareResCase_Base.ViewCount];
objDR[convCoursewareResCase_Base.IsShow] = objInFor[convCoursewareResCase_Base.IsShow];
objDR[convCoursewareResCase_Base.DownloadNumber] = objInFor[convCoursewareResCase_Base.DownloadNumber];
objDR[convCoursewareResCase_Base.FileIntegration] = objInFor[convCoursewareResCase_Base.FileIntegration];
objDR[convCoursewareResCase_Base.LikeCount] = objInFor[convCoursewareResCase_Base.LikeCount];
objDR[convCoursewareResCase_Base.CollectionCount] = objInFor[convCoursewareResCase_Base.CollectionCount];
objDR[convCoursewareResCase_Base.RecommendedDegreeId] = objInFor[convCoursewareResCase_Base.RecommendedDegreeId];
objDR[convCoursewareResCase_Base.RecommendedDegreeName] = objInFor[convCoursewareResCase_Base.RecommendedDegreeName];
objDR[convCoursewareResCase_Base.ftpFileType] = objInFor[convCoursewareResCase_Base.ftpFileType];
objDR[convCoursewareResCase_Base.CourseId] = objInFor[convCoursewareResCase_Base.CourseId];
objDR[convCoursewareResCase_Base.CourseCode] = objInFor[convCoursewareResCase_Base.CourseCode];
objDR[convCoursewareResCase_Base.CourseName] = objInFor[convCoursewareResCase_Base.CourseName];
objDR[convCoursewareResCase_Base.VideoUrl] = objInFor[convCoursewareResCase_Base.VideoUrl];
objDR[convCoursewareResCase_Base.VideoPath] = objInFor[convCoursewareResCase_Base.VideoPath];
objDR[convCoursewareResCase_Base.ResErrMsg] = objInFor[convCoursewareResCase_Base.ResErrMsg];
objDR[convCoursewareResCase_Base.Memo] = objInFor[convCoursewareResCase_Base.Memo];
objDR[convCoursewareResCase_Base.OwnerName] = objInFor[convCoursewareResCase_Base.OwnerName];
objDR[convCoursewareResCase_Base.OwnerNameWithId] = objInFor[convCoursewareResCase_Base.OwnerNameWithId];
objDR[convCoursewareResCase_Base.BrowseCount4Case] = objInFor[convCoursewareResCase_Base.BrowseCount4Case];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}