
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCoursewareResCaseWApi
 表名:CoursewareResCase(01120418)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:16
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
public static class clsCoursewareResCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetId_CoursewareResCase(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strId_CoursewareResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CoursewareResCase, 8, conCoursewareResCase.Id_CoursewareResCase);
clsCheckSql.CheckFieldForeignKey(strId_CoursewareResCase, 8, conCoursewareResCase.Id_CoursewareResCase);
objCoursewareResCaseEN.Id_CoursewareResCase = strId_CoursewareResCase; //课件资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.Id_CoursewareResCase) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.Id_CoursewareResCase, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.Id_CoursewareResCase] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCoursewareResCaseID(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCoursewareResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareResCaseID, conCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckFieldLen(strCoursewareResCaseID, 8, conCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseID, 8, conCoursewareResCase.CoursewareResCaseID);
objCoursewareResCaseEN.CoursewareResCaseID = strCoursewareResCaseID; //课件资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CoursewareResCaseID) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CoursewareResCaseID, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseID] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCoursewareResCaseName(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCoursewareResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareResCaseName, conCoursewareResCase.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(strCoursewareResCaseName, 100, conCoursewareResCase.CoursewareResCaseName);
objCoursewareResCaseEN.CoursewareResCaseName = strCoursewareResCaseName; //课件资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CoursewareResCaseName) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CoursewareResCaseName, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseName] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCoursewareResCaseTheme(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCoursewareResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTheme, 200, conCoursewareResCase.CoursewareResCaseTheme);
objCoursewareResCaseEN.CoursewareResCaseTheme = strCoursewareResCaseTheme; //课件资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CoursewareResCaseTheme) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CoursewareResCaseTheme, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseTheme] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCoursewareResCaseText(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCoursewareResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseText, 8000, conCoursewareResCase.CoursewareResCaseText);
objCoursewareResCaseEN.CoursewareResCaseText = strCoursewareResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CoursewareResCaseText) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CoursewareResCaseText, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseText] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN Setid_CoursewareResCaseType(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strid_CoursewareResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CoursewareResCaseType, conCoursewareResCase.id_CoursewareResCaseType);
clsCheckSql.CheckFieldLen(strid_CoursewareResCaseType, 4, conCoursewareResCase.id_CoursewareResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareResCaseType, 4, conCoursewareResCase.id_CoursewareResCaseType);
objCoursewareResCaseEN.id_CoursewareResCaseType = strid_CoursewareResCaseType; //课件资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.id_CoursewareResCaseType) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.id_CoursewareResCaseType, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.id_CoursewareResCaseType] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCoursewareResCaseDate(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCoursewareResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseDate, 8, conCoursewareResCase.CoursewareResCaseDate);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseDate, 8, conCoursewareResCase.CoursewareResCaseDate);
objCoursewareResCaseEN.CoursewareResCaseDate = strCoursewareResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CoursewareResCaseDate) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CoursewareResCaseDate, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseDate] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCoursewareResCaseTime(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCoursewareResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTime, 6, conCoursewareResCase.CoursewareResCaseTime);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTime, 6, conCoursewareResCase.CoursewareResCaseTime);
objCoursewareResCaseEN.CoursewareResCaseTime = strCoursewareResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CoursewareResCaseTime) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CoursewareResCaseTime, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseTime] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCoursewareResCaseDateIn(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCoursewareResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseDateIn, 8, conCoursewareResCase.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseDateIn, 8, conCoursewareResCase.CoursewareResCaseDateIn);
objCoursewareResCaseEN.CoursewareResCaseDateIn = strCoursewareResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CoursewareResCaseDateIn) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CoursewareResCaseDateIn, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseDateIn] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCoursewareResCaseTimeIn(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCoursewareResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTimeIn, 6, conCoursewareResCase.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTimeIn, 6, conCoursewareResCase.CoursewareResCaseTimeIn);
objCoursewareResCaseEN.CoursewareResCaseTimeIn = strCoursewareResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CoursewareResCaseTimeIn) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CoursewareResCaseTimeIn, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseTimeIn] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetOwnerId(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conCoursewareResCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCoursewareResCase.OwnerId);
objCoursewareResCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.OwnerId) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.OwnerId, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.OwnerId] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN Setid_StudyLevel(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conCoursewareResCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conCoursewareResCase.id_StudyLevel);
objCoursewareResCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.id_StudyLevel) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.id_StudyLevel, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.id_StudyLevel] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN Setid_TeachingPlan(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conCoursewareResCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conCoursewareResCase.id_TeachingPlan);
objCoursewareResCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.id_TeachingPlan) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.id_TeachingPlan, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.id_TeachingPlan] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN Setid_Discipline(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conCoursewareResCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conCoursewareResCase.id_Discipline);
objCoursewareResCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.id_Discipline) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.id_Discipline, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.id_Discipline] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetBrowseCount(this clsCoursewareResCaseEN objCoursewareResCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objCoursewareResCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.BrowseCount) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.BrowseCount, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.BrowseCount] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN Setid_SenateGaugeVersion(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conCoursewareResCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conCoursewareResCase.id_SenateGaugeVersion);
objCoursewareResCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.id_SenateGaugeVersion) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN Setid_TeachSkill(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conCoursewareResCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conCoursewareResCase.id_TeachSkill);
objCoursewareResCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.id_TeachSkill) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.id_TeachSkill, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.id_TeachSkill] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCaseLevelId(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conCoursewareResCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conCoursewareResCase.CaseLevelId);
objCoursewareResCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CaseLevelId) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CaseLevelId, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CaseLevelId] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetDocFile(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conCoursewareResCase.DocFile);
objCoursewareResCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.DocFile) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.DocFile, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.DocFile] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetIsNeedGeneWord(this clsCoursewareResCaseEN objCoursewareResCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objCoursewareResCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.IsNeedGeneWord) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetWordCreateDate(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conCoursewareResCase.WordCreateDate);
objCoursewareResCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.WordCreateDate) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.WordCreateDate, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.WordCreateDate] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetIsVisible(this clsCoursewareResCaseEN objCoursewareResCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objCoursewareResCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.IsVisible) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.IsVisible, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.IsVisible] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetIsDualVideo(this clsCoursewareResCaseEN objCoursewareResCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objCoursewareResCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.IsDualVideo) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.IsDualVideo, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.IsDualVideo] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN Setid_XzCollege(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, conCoursewareResCase.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conCoursewareResCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conCoursewareResCase.id_XzCollege);
objCoursewareResCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.id_XzCollege) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.id_XzCollege, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.id_XzCollege] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN Setid_XzMajor(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, conCoursewareResCase.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conCoursewareResCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conCoursewareResCase.id_XzMajor);
objCoursewareResCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.id_XzMajor) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.id_XzMajor, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.id_XzMajor] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCourseChapterId(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conCoursewareResCase.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conCoursewareResCase.CourseChapterId);
objCoursewareResCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CourseChapterId) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CourseChapterId, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CourseChapterId] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetViewCount(this clsCoursewareResCaseEN objCoursewareResCaseEN, int intViewCount, string strComparisonOp="")
	{
objCoursewareResCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.ViewCount) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.ViewCount, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.ViewCount] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetIsShow(this clsCoursewareResCaseEN objCoursewareResCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objCoursewareResCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.IsShow) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.IsShow, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.IsShow] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetDownloadNumber(this clsCoursewareResCaseEN objCoursewareResCaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objCoursewareResCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.DownloadNumber) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.DownloadNumber, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.DownloadNumber] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetFileIntegration(this clsCoursewareResCaseEN objCoursewareResCaseEN, int intFileIntegration, string strComparisonOp="")
	{
objCoursewareResCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.FileIntegration) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.FileIntegration, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.FileIntegration] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetLikeCount(this clsCoursewareResCaseEN objCoursewareResCaseEN, long lngLikeCount, string strComparisonOp="")
	{
objCoursewareResCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.LikeCount) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.LikeCount, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.LikeCount] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCollectionCount(this clsCoursewareResCaseEN objCoursewareResCaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objCoursewareResCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CollectionCount) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CollectionCount, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CollectionCount] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetRecommendedDegreeId(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conCoursewareResCase.RecommendedDegreeId);
objCoursewareResCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.RecommendedDegreeId) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetftpFileType(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conCoursewareResCase.ftpFileType);
objCoursewareResCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.ftpFileType) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.ftpFileType, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.ftpFileType] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetCourseId(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conCoursewareResCase.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conCoursewareResCase.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCoursewareResCase.CourseId);
objCoursewareResCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.CourseId) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.CourseId, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.CourseId] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetVideoUrl(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conCoursewareResCase.VideoUrl);
objCoursewareResCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.VideoUrl) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.VideoUrl, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.VideoUrl] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetVideoPath(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conCoursewareResCase.VideoPath);
objCoursewareResCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.VideoPath) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.VideoPath, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.VideoPath] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetResErrMsg(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conCoursewareResCase.ResErrMsg);
objCoursewareResCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.ResErrMsg) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.ResErrMsg, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.ResErrMsg] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetUpdDate(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCoursewareResCase.UpdDate);
objCoursewareResCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.UpdDate) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.UpdDate, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.UpdDate] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetUpdUserId(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCoursewareResCase.UpdUserId);
objCoursewareResCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.UpdUserId) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.UpdUserId, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.UpdUserId] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseEN SetMemo(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCoursewareResCase.Memo);
objCoursewareResCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareResCase.Memo) == false)
{
objCoursewareResCaseEN.dicFldComparisonOp.Add(conCoursewareResCase.Memo, strComparisonOp);
}
else
{
objCoursewareResCaseEN.dicFldComparisonOp[conCoursewareResCase.Memo] = strComparisonOp;
}
}
return objCoursewareResCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCoursewareResCaseEN objCoursewareResCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.Id_CoursewareResCase) == true)
{
string strComparisonOp_Id_CoursewareResCase = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.Id_CoursewareResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.Id_CoursewareResCase, objCoursewareResCase_Cond.Id_CoursewareResCase, strComparisonOp_Id_CoursewareResCase);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CoursewareResCaseID) == true)
{
string strComparisonOp_CoursewareResCaseID = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CoursewareResCaseID, objCoursewareResCase_Cond.CoursewareResCaseID, strComparisonOp_CoursewareResCaseID);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CoursewareResCaseName) == true)
{
string strComparisonOp_CoursewareResCaseName = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CoursewareResCaseName, objCoursewareResCase_Cond.CoursewareResCaseName, strComparisonOp_CoursewareResCaseName);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CoursewareResCaseTheme) == true)
{
string strComparisonOp_CoursewareResCaseTheme = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CoursewareResCaseTheme, objCoursewareResCase_Cond.CoursewareResCaseTheme, strComparisonOp_CoursewareResCaseTheme);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CoursewareResCaseText) == true)
{
string strComparisonOp_CoursewareResCaseText = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CoursewareResCaseText, objCoursewareResCase_Cond.CoursewareResCaseText, strComparisonOp_CoursewareResCaseText);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.id_CoursewareResCaseType) == true)
{
string strComparisonOp_id_CoursewareResCaseType = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.id_CoursewareResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.id_CoursewareResCaseType, objCoursewareResCase_Cond.id_CoursewareResCaseType, strComparisonOp_id_CoursewareResCaseType);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CoursewareResCaseDate) == true)
{
string strComparisonOp_CoursewareResCaseDate = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CoursewareResCaseDate, objCoursewareResCase_Cond.CoursewareResCaseDate, strComparisonOp_CoursewareResCaseDate);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CoursewareResCaseTime) == true)
{
string strComparisonOp_CoursewareResCaseTime = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CoursewareResCaseTime, objCoursewareResCase_Cond.CoursewareResCaseTime, strComparisonOp_CoursewareResCaseTime);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CoursewareResCaseDateIn) == true)
{
string strComparisonOp_CoursewareResCaseDateIn = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CoursewareResCaseDateIn, objCoursewareResCase_Cond.CoursewareResCaseDateIn, strComparisonOp_CoursewareResCaseDateIn);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CoursewareResCaseTimeIn) == true)
{
string strComparisonOp_CoursewareResCaseTimeIn = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CoursewareResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CoursewareResCaseTimeIn, objCoursewareResCase_Cond.CoursewareResCaseTimeIn, strComparisonOp_CoursewareResCaseTimeIn);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.OwnerId, objCoursewareResCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.id_StudyLevel, objCoursewareResCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.id_TeachingPlan, objCoursewareResCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.id_Discipline, objCoursewareResCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCoursewareResCase.BrowseCount, objCoursewareResCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.id_SenateGaugeVersion, objCoursewareResCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.id_TeachSkill, objCoursewareResCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CaseLevelId, objCoursewareResCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.DocFile) == true)
{
string strComparisonOp_DocFile = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.DocFile, objCoursewareResCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.IsNeedGeneWord) == true)
{
if (objCoursewareResCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCoursewareResCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCoursewareResCase.IsNeedGeneWord);
}
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.WordCreateDate, objCoursewareResCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.IsVisible) == true)
{
if (objCoursewareResCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCoursewareResCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCoursewareResCase.IsVisible);
}
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.IsDualVideo) == true)
{
if (objCoursewareResCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCoursewareResCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCoursewareResCase.IsDualVideo);
}
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.id_XzCollege, objCoursewareResCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.id_XzMajor, objCoursewareResCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CourseChapterId, objCoursewareResCase_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.ViewCount) == true)
{
string strComparisonOp_ViewCount = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCoursewareResCase.ViewCount, objCoursewareResCase_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.IsShow) == true)
{
if (objCoursewareResCase_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCoursewareResCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCoursewareResCase.IsShow);
}
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conCoursewareResCase.DownloadNumber, objCoursewareResCase_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", conCoursewareResCase.FileIntegration, objCoursewareResCase_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.LikeCount) == true)
{
string strComparisonOp_LikeCount = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCoursewareResCase.LikeCount, objCoursewareResCase_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCoursewareResCase.CollectionCount, objCoursewareResCase_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.RecommendedDegreeId, objCoursewareResCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.ftpFileType, objCoursewareResCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.CourseId) == true)
{
string strComparisonOp_CourseId = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.CourseId, objCoursewareResCase_Cond.CourseId, strComparisonOp_CourseId);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.VideoUrl, objCoursewareResCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.VideoPath, objCoursewareResCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.ResErrMsg, objCoursewareResCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.UpdDate, objCoursewareResCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.UpdUserId, objCoursewareResCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objCoursewareResCase_Cond.IsUpdated(conCoursewareResCase.Memo) == true)
{
string strComparisonOp_Memo = objCoursewareResCase_Cond.dicFldComparisonOp[conCoursewareResCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCase.Memo, objCoursewareResCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCoursewareResCaseEN objCoursewareResCaseEN)
{
 if (string.IsNullOrEmpty(objCoursewareResCaseEN.Id_CoursewareResCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCoursewareResCaseEN.sf_UpdFldSetStr = objCoursewareResCaseEN.getsf_UpdFldSetStr();
clsCoursewareResCaseWApi.CheckPropertyNew(objCoursewareResCaseEN); 
bool bolResult = clsCoursewareResCaseWApi.UpdateRecord(objCoursewareResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCoursewareResCaseEN objCoursewareResCaseEN)
{
 if (string.IsNullOrEmpty(objCoursewareResCaseEN.Id_CoursewareResCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCoursewareResCaseWApi.IsExist(objCoursewareResCaseEN.Id_CoursewareResCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objCoursewareResCaseEN.Id_CoursewareResCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsCoursewareResCaseWApi.CheckPropertyNew(objCoursewareResCaseEN); 
bool bolResult = clsCoursewareResCaseWApi.AddNewRecord(objCoursewareResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseWApi.ReFreshCache();
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
 /// <param name = "objCoursewareResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCoursewareResCaseEN objCoursewareResCaseEN)
{
try
{
clsCoursewareResCaseWApi.CheckPropertyNew(objCoursewareResCaseEN); 
string strId_CoursewareResCase = clsCoursewareResCaseWApi.AddNewRecordWithMaxId(objCoursewareResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseWApi.ReFreshCache();
return strId_CoursewareResCase;
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
 /// <param name = "objCoursewareResCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCoursewareResCaseEN objCoursewareResCaseEN, string strWhereCond)
{
try
{
clsCoursewareResCaseWApi.CheckPropertyNew(objCoursewareResCaseEN); 
bool bolResult = clsCoursewareResCaseWApi.UpdateWithCondition(objCoursewareResCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseWApi.ReFreshCache();
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
 /// 课件资源案例(CoursewareResCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCoursewareResCaseWApi
{
private static readonly string mstrApiControllerName = "CoursewareResCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCoursewareResCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_Id_CoursewareResCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课件资源案例]...","0");
List<clsCoursewareResCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="Id_CoursewareResCase";
objDDL.DataTextField="CoursewareResCaseName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_Id_CoursewareResCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCoursewareResCase.Id_CoursewareResCase); 
List<clsCoursewareResCaseEN> arrObjLst = clsCoursewareResCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCoursewareResCaseEN objCoursewareResCaseEN = new clsCoursewareResCaseEN()
{
Id_CoursewareResCase = "0",
CoursewareResCaseName = "选[课件资源案例]..."
};
arrObjLst.Insert(0, objCoursewareResCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCoursewareResCase.Id_CoursewareResCase;
objComboBox.DisplayMember = conCoursewareResCase.CoursewareResCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
if (!Object.Equals(null, objCoursewareResCaseEN.Id_CoursewareResCase) && GetStrLen(objCoursewareResCaseEN.Id_CoursewareResCase) > 8)
{
 throw new Exception("字段[课件资源案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CoursewareResCaseID) && GetStrLen(objCoursewareResCaseEN.CoursewareResCaseID) > 8)
{
 throw new Exception("字段[课件资源案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CoursewareResCaseName) && GetStrLen(objCoursewareResCaseEN.CoursewareResCaseName) > 100)
{
 throw new Exception("字段[课件资源案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CoursewareResCaseTheme) && GetStrLen(objCoursewareResCaseEN.CoursewareResCaseTheme) > 200)
{
 throw new Exception("字段[课件资源案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CoursewareResCaseText) && GetStrLen(objCoursewareResCaseEN.CoursewareResCaseText) > 8000)
{
 throw new Exception("字段[案例文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.id_CoursewareResCaseType) && GetStrLen(objCoursewareResCaseEN.id_CoursewareResCaseType) > 4)
{
 throw new Exception("字段[课件资源类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CoursewareResCaseDate) && GetStrLen(objCoursewareResCaseEN.CoursewareResCaseDate) > 8)
{
 throw new Exception("字段[视频资源日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CoursewareResCaseTime) && GetStrLen(objCoursewareResCaseEN.CoursewareResCaseTime) > 6)
{
 throw new Exception("字段[视频资源时间]的长度不能超过6!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CoursewareResCaseDateIn) && GetStrLen(objCoursewareResCaseEN.CoursewareResCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CoursewareResCaseTimeIn) && GetStrLen(objCoursewareResCaseEN.CoursewareResCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.OwnerId) && GetStrLen(objCoursewareResCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.id_StudyLevel) && GetStrLen(objCoursewareResCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.id_TeachingPlan) && GetStrLen(objCoursewareResCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.id_Discipline) && GetStrLen(objCoursewareResCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.id_SenateGaugeVersion) && GetStrLen(objCoursewareResCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.id_TeachSkill) && GetStrLen(objCoursewareResCaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CaseLevelId) && GetStrLen(objCoursewareResCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.DocFile) && GetStrLen(objCoursewareResCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.WordCreateDate) && GetStrLen(objCoursewareResCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.id_XzCollege) && GetStrLen(objCoursewareResCaseEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.id_XzMajor) && GetStrLen(objCoursewareResCaseEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CourseChapterId) && GetStrLen(objCoursewareResCaseEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.RecommendedDegreeId) && GetStrLen(objCoursewareResCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.ftpFileType) && GetStrLen(objCoursewareResCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.CourseId) && GetStrLen(objCoursewareResCaseEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.VideoUrl) && GetStrLen(objCoursewareResCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.VideoPath) && GetStrLen(objCoursewareResCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.ResErrMsg) && GetStrLen(objCoursewareResCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.UpdDate) && GetStrLen(objCoursewareResCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.UpdUserId) && GetStrLen(objCoursewareResCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCoursewareResCaseEN.Memo) && GetStrLen(objCoursewareResCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCoursewareResCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CoursewareResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsCoursewareResCaseEN GetObjById_CoursewareResCase(string strId_CoursewareResCase)
{
string strAction = "GetObjById_CoursewareResCase";
string strErrMsg = string.Empty;
string strResult = "";
clsCoursewareResCaseEN objCoursewareResCaseEN = null;
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
objCoursewareResCaseEN = JsonConvert.DeserializeObject<clsCoursewareResCaseEN>((string)jobjReturn["ReturnObj"]);
return objCoursewareResCaseEN;
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
public static clsCoursewareResCaseEN GetObjById_CoursewareResCase_WA_Cache(string strId_CoursewareResCase)
{
string strAction = "GetObjById_CoursewareResCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCoursewareResCaseEN objCoursewareResCaseEN = null;
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
objCoursewareResCaseEN = JsonConvert.DeserializeObject<clsCoursewareResCaseEN>((string)jobjReturn["ReturnObj"]);
return objCoursewareResCaseEN;
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
public static clsCoursewareResCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCoursewareResCaseEN objCoursewareResCaseEN = null;
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
objCoursewareResCaseEN = JsonConvert.DeserializeObject<clsCoursewareResCaseEN>((string)jobjReturn["ReturnObj"]);
return objCoursewareResCaseEN;
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
public static clsCoursewareResCaseEN GetObjById_CoursewareResCase_Cache(string strId_CoursewareResCase)
{
if (string.IsNullOrEmpty(strId_CoursewareResCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareResCaseEN._CurrTabName_S);
List<clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Sel =
from objCoursewareResCaseEN in arrCoursewareResCaseObjLst_Cache
where objCoursewareResCaseEN.Id_CoursewareResCase == strId_CoursewareResCase
select objCoursewareResCaseEN;
if (arrCoursewareResCaseObjLst_Sel.Count() == 0)
{
   clsCoursewareResCaseEN obj = clsCoursewareResCaseWApi.GetObjById_CoursewareResCase(strId_CoursewareResCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCoursewareResCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_CoursewareResCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCoursewareResCaseNameById_CoursewareResCase_Cache(string strId_CoursewareResCase)
{
if (string.IsNullOrEmpty(strId_CoursewareResCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareResCaseEN._CurrTabName_S);
List<clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Sel1 =
from objCoursewareResCaseEN in arrCoursewareResCaseObjLst_Cache
where objCoursewareResCaseEN.Id_CoursewareResCase == strId_CoursewareResCase
select objCoursewareResCaseEN;
List <clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Sel = new List<clsCoursewareResCaseEN>();
foreach (clsCoursewareResCaseEN obj in arrCoursewareResCaseObjLst_Sel1)
{
arrCoursewareResCaseObjLst_Sel.Add(obj);
}
if (arrCoursewareResCaseObjLst_Sel.Count > 0)
{
return arrCoursewareResCaseObjLst_Sel[0].CoursewareResCaseName;
}
string strErrMsgForGetObjById = string.Format("在CoursewareResCase对象缓存列表中,找不到记录[Id_CoursewareResCase = {0}](函数:{1})", strId_CoursewareResCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCoursewareResCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_CoursewareResCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameById_CoursewareResCase_Cache(string strId_CoursewareResCase)
{
if (string.IsNullOrEmpty(strId_CoursewareResCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareResCaseEN._CurrTabName_S);
List<clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Sel1 =
from objCoursewareResCaseEN in arrCoursewareResCaseObjLst_Cache
where objCoursewareResCaseEN.Id_CoursewareResCase == strId_CoursewareResCase
select objCoursewareResCaseEN;
List <clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Sel = new List<clsCoursewareResCaseEN>();
foreach (clsCoursewareResCaseEN obj in arrCoursewareResCaseObjLst_Sel1)
{
arrCoursewareResCaseObjLst_Sel.Add(obj);
}
if (arrCoursewareResCaseObjLst_Sel.Count > 0)
{
return arrCoursewareResCaseObjLst_Sel[0].CoursewareResCaseName;
}
string strErrMsgForGetObjById = string.Format("在CoursewareResCase对象缓存列表中,找不到记录的相关名称[Id_CoursewareResCase = {0}](函数:{1})", strId_CoursewareResCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCoursewareResCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCoursewareResCaseEN> GetObjLst(string strWhereCond)
{
 List<clsCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareResCaseEN> GetObjLstById_CoursewareResCaseLst(List<string> arrId_CoursewareResCase)
{
 List<clsCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsCoursewareResCaseEN> GetObjLstById_CoursewareResCaseLst_Cache(List<string> arrId_CoursewareResCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareResCaseEN._CurrTabName_S);
List<clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Sel =
from objCoursewareResCaseEN in arrCoursewareResCaseObjLst_Cache
where arrId_CoursewareResCase.Contains(objCoursewareResCaseEN.Id_CoursewareResCase)
select objCoursewareResCaseEN;
return arrCoursewareResCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCoursewareResCaseEN> GetObjLstById_CoursewareResCaseLst_WA_Cache(List<string> arrId_CoursewareResCase)
{
 List<clsCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareResCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareResCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareResCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareResCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCoursewareResCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strId_CoursewareResCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCoursewareResCaseEN objCoursewareResCaseEN = clsCoursewareResCaseWApi.GetObjById_CoursewareResCase(strId_CoursewareResCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_CoursewareResCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCoursewareResCaseWApi.ReFreshCache();
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
public static int DelCoursewareResCases(List<string> arrId_CoursewareResCase)
{
string strAction = "DelCoursewareResCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CoursewareResCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCoursewareResCaseWApi.ReFreshCache();
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
public static int DelCoursewareResCasesByCond(string strWhereCond)
{
string strAction = "DelCoursewareResCasesByCond";
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
public static bool AddNewRecord(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareResCaseEN>(objCoursewareResCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareResCaseEN>(objCoursewareResCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseWApi.ReFreshCache();
var strId_CoursewareResCase = (string)jobjReturn["ReturnStr"];
return strId_CoursewareResCase;
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
public static bool UpdateRecord(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
if (string.IsNullOrEmpty(objCoursewareResCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCoursewareResCaseEN.Id_CoursewareResCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareResCaseEN>(objCoursewareResCaseEN);
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
 /// <param name = "objCoursewareResCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCoursewareResCaseEN objCoursewareResCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCoursewareResCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCoursewareResCaseEN.Id_CoursewareResCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCoursewareResCaseEN.Id_CoursewareResCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareResCaseEN>(objCoursewareResCaseEN);
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
 /// <param name = "objCoursewareResCaseENS">源对象</param>
 /// <param name = "objCoursewareResCaseENT">目标对象</param>
 public static void CopyTo(clsCoursewareResCaseEN objCoursewareResCaseENS, clsCoursewareResCaseEN objCoursewareResCaseENT)
{
try
{
objCoursewareResCaseENT.Id_CoursewareResCase = objCoursewareResCaseENS.Id_CoursewareResCase; //课件资源案例流水号
objCoursewareResCaseENT.CoursewareResCaseID = objCoursewareResCaseENS.CoursewareResCaseID; //课件资源案例ID
objCoursewareResCaseENT.CoursewareResCaseName = objCoursewareResCaseENS.CoursewareResCaseName; //课件资源案例名称
objCoursewareResCaseENT.CoursewareResCaseTheme = objCoursewareResCaseENS.CoursewareResCaseTheme; //课件资源案例主题词
objCoursewareResCaseENT.CoursewareResCaseText = objCoursewareResCaseENS.CoursewareResCaseText; //案例文本内容
objCoursewareResCaseENT.id_CoursewareResCaseType = objCoursewareResCaseENS.id_CoursewareResCaseType; //课件资源类型流水号
objCoursewareResCaseENT.CoursewareResCaseDate = objCoursewareResCaseENS.CoursewareResCaseDate; //视频资源日期
objCoursewareResCaseENT.CoursewareResCaseTime = objCoursewareResCaseENS.CoursewareResCaseTime; //视频资源时间
objCoursewareResCaseENT.CoursewareResCaseDateIn = objCoursewareResCaseENS.CoursewareResCaseDateIn; //案例入库日期
objCoursewareResCaseENT.CoursewareResCaseTimeIn = objCoursewareResCaseENS.CoursewareResCaseTimeIn; //案例入库时间
objCoursewareResCaseENT.OwnerId = objCoursewareResCaseENS.OwnerId; //拥有者Id
objCoursewareResCaseENT.id_StudyLevel = objCoursewareResCaseENS.id_StudyLevel; //id_StudyLevel
objCoursewareResCaseENT.id_TeachingPlan = objCoursewareResCaseENS.id_TeachingPlan; //教案流水号
objCoursewareResCaseENT.id_Discipline = objCoursewareResCaseENS.id_Discipline; //学科流水号
objCoursewareResCaseENT.BrowseCount = objCoursewareResCaseENS.BrowseCount; //浏览次数
objCoursewareResCaseENT.id_SenateGaugeVersion = objCoursewareResCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objCoursewareResCaseENT.id_TeachSkill = objCoursewareResCaseENS.id_TeachSkill; //教学技能流水号
objCoursewareResCaseENT.CaseLevelId = objCoursewareResCaseENS.CaseLevelId; //课例等级Id
objCoursewareResCaseENT.DocFile = objCoursewareResCaseENS.DocFile; //生成的Word文件名
objCoursewareResCaseENT.IsNeedGeneWord = objCoursewareResCaseENS.IsNeedGeneWord; //是否需要生成Word
objCoursewareResCaseENT.WordCreateDate = objCoursewareResCaseENS.WordCreateDate; //Word生成日期
objCoursewareResCaseENT.IsVisible = objCoursewareResCaseENS.IsVisible; //是否显示
objCoursewareResCaseENT.IsDualVideo = objCoursewareResCaseENS.IsDualVideo; //是否双视频
objCoursewareResCaseENT.id_XzCollege = objCoursewareResCaseENS.id_XzCollege; //学院流水号
objCoursewareResCaseENT.id_XzMajor = objCoursewareResCaseENS.id_XzMajor; //专业流水号
objCoursewareResCaseENT.CourseChapterId = objCoursewareResCaseENS.CourseChapterId; //课程章节ID
objCoursewareResCaseENT.ViewCount = objCoursewareResCaseENS.ViewCount; //浏览量
objCoursewareResCaseENT.IsShow = objCoursewareResCaseENS.IsShow; //是否启用
objCoursewareResCaseENT.DownloadNumber = objCoursewareResCaseENS.DownloadNumber; //下载数目
objCoursewareResCaseENT.FileIntegration = objCoursewareResCaseENS.FileIntegration; //文件积分
objCoursewareResCaseENT.LikeCount = objCoursewareResCaseENS.LikeCount; //资源喜欢数量
objCoursewareResCaseENT.CollectionCount = objCoursewareResCaseENS.CollectionCount; //收藏数量
objCoursewareResCaseENT.RecommendedDegreeId = objCoursewareResCaseENS.RecommendedDegreeId; //推荐度Id
objCoursewareResCaseENT.ftpFileType = objCoursewareResCaseENS.ftpFileType; //ftp文件类型
objCoursewareResCaseENT.CourseId = objCoursewareResCaseENS.CourseId; //课程Id
objCoursewareResCaseENT.VideoUrl = objCoursewareResCaseENS.VideoUrl; //视频Url
objCoursewareResCaseENT.VideoPath = objCoursewareResCaseENS.VideoPath; //视频目录
objCoursewareResCaseENT.ResErrMsg = objCoursewareResCaseENS.ResErrMsg; //资源错误信息
objCoursewareResCaseENT.UpdDate = objCoursewareResCaseENS.UpdDate; //修改日期
objCoursewareResCaseENT.UpdUserId = objCoursewareResCaseENS.UpdUserId; //修改用户Id
objCoursewareResCaseENT.Memo = objCoursewareResCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCoursewareResCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCoursewareResCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCoursewareResCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCoursewareResCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCoursewareResCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCoursewareResCaseEN.AttributeName)
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
if (clsCoursewareResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareResCaseWApi没有刷新缓存机制(clsCoursewareResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_CoursewareResCase");
//if (arrCoursewareResCaseObjLst_Cache == null)
//{
//arrCoursewareResCaseObjLst_Cache = await clsCoursewareResCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCoursewareResCaseEN._CurrTabName_S);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCoursewareResCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCoursewareResCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCoursewareResCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCoursewareResCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCoursewareResCaseEN._CurrTabName_S);
List<clsCoursewareResCaseEN> arrCoursewareResCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCoursewareResCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCoursewareResCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCoursewareResCase.Id_CoursewareResCase, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CoursewareResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CoursewareResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CoursewareResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CoursewareResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.id_CoursewareResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CoursewareResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CoursewareResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CoursewareResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CoursewareResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCoursewareResCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCoursewareResCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCoursewareResCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCoursewareResCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCoursewareResCase.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCoursewareResCase.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(conCoursewareResCase.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(conCoursewareResCase.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conCoursewareResCase.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conCoursewareResCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCase.Memo, Type.GetType("System.String"));
foreach (clsCoursewareResCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCoursewareResCase.Id_CoursewareResCase] = objInFor[conCoursewareResCase.Id_CoursewareResCase];
objDR[conCoursewareResCase.CoursewareResCaseID] = objInFor[conCoursewareResCase.CoursewareResCaseID];
objDR[conCoursewareResCase.CoursewareResCaseName] = objInFor[conCoursewareResCase.CoursewareResCaseName];
objDR[conCoursewareResCase.CoursewareResCaseTheme] = objInFor[conCoursewareResCase.CoursewareResCaseTheme];
objDR[conCoursewareResCase.CoursewareResCaseText] = objInFor[conCoursewareResCase.CoursewareResCaseText];
objDR[conCoursewareResCase.id_CoursewareResCaseType] = objInFor[conCoursewareResCase.id_CoursewareResCaseType];
objDR[conCoursewareResCase.CoursewareResCaseDate] = objInFor[conCoursewareResCase.CoursewareResCaseDate];
objDR[conCoursewareResCase.CoursewareResCaseTime] = objInFor[conCoursewareResCase.CoursewareResCaseTime];
objDR[conCoursewareResCase.CoursewareResCaseDateIn] = objInFor[conCoursewareResCase.CoursewareResCaseDateIn];
objDR[conCoursewareResCase.CoursewareResCaseTimeIn] = objInFor[conCoursewareResCase.CoursewareResCaseTimeIn];
objDR[conCoursewareResCase.OwnerId] = objInFor[conCoursewareResCase.OwnerId];
objDR[conCoursewareResCase.id_StudyLevel] = objInFor[conCoursewareResCase.id_StudyLevel];
objDR[conCoursewareResCase.id_TeachingPlan] = objInFor[conCoursewareResCase.id_TeachingPlan];
objDR[conCoursewareResCase.id_Discipline] = objInFor[conCoursewareResCase.id_Discipline];
objDR[conCoursewareResCase.BrowseCount] = objInFor[conCoursewareResCase.BrowseCount];
objDR[conCoursewareResCase.id_SenateGaugeVersion] = objInFor[conCoursewareResCase.id_SenateGaugeVersion];
objDR[conCoursewareResCase.id_TeachSkill] = objInFor[conCoursewareResCase.id_TeachSkill];
objDR[conCoursewareResCase.CaseLevelId] = objInFor[conCoursewareResCase.CaseLevelId];
objDR[conCoursewareResCase.DocFile] = objInFor[conCoursewareResCase.DocFile];
objDR[conCoursewareResCase.IsNeedGeneWord] = objInFor[conCoursewareResCase.IsNeedGeneWord];
objDR[conCoursewareResCase.WordCreateDate] = objInFor[conCoursewareResCase.WordCreateDate];
objDR[conCoursewareResCase.IsVisible] = objInFor[conCoursewareResCase.IsVisible];
objDR[conCoursewareResCase.IsDualVideo] = objInFor[conCoursewareResCase.IsDualVideo];
objDR[conCoursewareResCase.id_XzCollege] = objInFor[conCoursewareResCase.id_XzCollege];
objDR[conCoursewareResCase.id_XzMajor] = objInFor[conCoursewareResCase.id_XzMajor];
objDR[conCoursewareResCase.CourseChapterId] = objInFor[conCoursewareResCase.CourseChapterId];
objDR[conCoursewareResCase.ViewCount] = objInFor[conCoursewareResCase.ViewCount];
objDR[conCoursewareResCase.IsShow] = objInFor[conCoursewareResCase.IsShow];
objDR[conCoursewareResCase.DownloadNumber] = objInFor[conCoursewareResCase.DownloadNumber];
objDR[conCoursewareResCase.FileIntegration] = objInFor[conCoursewareResCase.FileIntegration];
objDR[conCoursewareResCase.LikeCount] = objInFor[conCoursewareResCase.LikeCount];
objDR[conCoursewareResCase.CollectionCount] = objInFor[conCoursewareResCase.CollectionCount];
objDR[conCoursewareResCase.RecommendedDegreeId] = objInFor[conCoursewareResCase.RecommendedDegreeId];
objDR[conCoursewareResCase.ftpFileType] = objInFor[conCoursewareResCase.ftpFileType];
objDR[conCoursewareResCase.CourseId] = objInFor[conCoursewareResCase.CourseId];
objDR[conCoursewareResCase.VideoUrl] = objInFor[conCoursewareResCase.VideoUrl];
objDR[conCoursewareResCase.VideoPath] = objInFor[conCoursewareResCase.VideoPath];
objDR[conCoursewareResCase.ResErrMsg] = objInFor[conCoursewareResCase.ResErrMsg];
objDR[conCoursewareResCase.UpdDate] = objInFor[conCoursewareResCase.UpdDate];
objDR[conCoursewareResCase.UpdUserId] = objInFor[conCoursewareResCase.UpdUserId];
objDR[conCoursewareResCase.Memo] = objInFor[conCoursewareResCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 课件资源案例(CoursewareResCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CoursewareResCase : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clsCoursewareResCaseWApi.ReFreshThisCache();
}
}

}