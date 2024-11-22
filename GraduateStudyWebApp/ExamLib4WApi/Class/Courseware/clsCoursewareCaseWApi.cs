
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCoursewareCaseWApi
 表名:CoursewareCase(01120416)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:52
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件
 模块英文名:Courseware
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
public static class clsCoursewareCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetId_CoursewareCase(this clsCoursewareCaseEN objCoursewareCaseEN, string strId_CoursewareCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CoursewareCase, 8, conCoursewareCase.Id_CoursewareCase);
clsCheckSql.CheckFieldForeignKey(strId_CoursewareCase, 8, conCoursewareCase.Id_CoursewareCase);
objCoursewareCaseEN.Id_CoursewareCase = strId_CoursewareCase; //课件教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.Id_CoursewareCase) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.Id_CoursewareCase, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.Id_CoursewareCase] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetCoursewareCaseID(this clsCoursewareCaseEN objCoursewareCaseEN, string strCoursewareCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareCaseID, conCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckFieldLen(strCoursewareCaseID, 8, conCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseID, 8, conCoursewareCase.CoursewareCaseID);
objCoursewareCaseEN.CoursewareCaseID = strCoursewareCaseID; //课件教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.CoursewareCaseID) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.CoursewareCaseID, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.CoursewareCaseID] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetCoursewareCaseName(this clsCoursewareCaseEN objCoursewareCaseEN, string strCoursewareCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareCaseName, conCoursewareCase.CoursewareCaseName);
clsCheckSql.CheckFieldLen(strCoursewareCaseName, 100, conCoursewareCase.CoursewareCaseName);
objCoursewareCaseEN.CoursewareCaseName = strCoursewareCaseName; //课件教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.CoursewareCaseName) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.CoursewareCaseName, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.CoursewareCaseName] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetCoursewareCaseTheme(this clsCoursewareCaseEN objCoursewareCaseEN, string strCoursewareCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTheme, 200, conCoursewareCase.CoursewareCaseTheme);
objCoursewareCaseEN.CoursewareCaseTheme = strCoursewareCaseTheme; //课件教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.CoursewareCaseTheme) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.CoursewareCaseTheme, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.CoursewareCaseTheme] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN Setid_CoursewareCaseType(this clsCoursewareCaseEN objCoursewareCaseEN, string strid_CoursewareCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CoursewareCaseType, conCoursewareCase.id_CoursewareCaseType);
clsCheckSql.CheckFieldLen(strid_CoursewareCaseType, 4, conCoursewareCase.id_CoursewareCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareCaseType, 4, conCoursewareCase.id_CoursewareCaseType);
objCoursewareCaseEN.id_CoursewareCaseType = strid_CoursewareCaseType; //课件案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.id_CoursewareCaseType) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.id_CoursewareCaseType, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.id_CoursewareCaseType] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetCoursewareCaseText(this clsCoursewareCaseEN objCoursewareCaseEN, string strCoursewareCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseText, 8000, conCoursewareCase.CoursewareCaseText);
objCoursewareCaseEN.CoursewareCaseText = strCoursewareCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.CoursewareCaseText) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.CoursewareCaseText, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.CoursewareCaseText] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetCoursewareCaseDate(this clsCoursewareCaseEN objCoursewareCaseEN, string strCoursewareCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseDate, 8, conCoursewareCase.CoursewareCaseDate);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseDate, 8, conCoursewareCase.CoursewareCaseDate);
objCoursewareCaseEN.CoursewareCaseDate = strCoursewareCaseDate; //课件教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.CoursewareCaseDate) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.CoursewareCaseDate, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.CoursewareCaseDate] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetCoursewareCaseTime(this clsCoursewareCaseEN objCoursewareCaseEN, string strCoursewareCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTime, 6, conCoursewareCase.CoursewareCaseTime);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseTime, 6, conCoursewareCase.CoursewareCaseTime);
objCoursewareCaseEN.CoursewareCaseTime = strCoursewareCaseTime; //课件教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.CoursewareCaseTime) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.CoursewareCaseTime, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.CoursewareCaseTime] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetCoursewareCaseDateIn(this clsCoursewareCaseEN objCoursewareCaseEN, string strCoursewareCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseDateIn, 8, conCoursewareCase.CoursewareCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseDateIn, 8, conCoursewareCase.CoursewareCaseDateIn);
objCoursewareCaseEN.CoursewareCaseDateIn = strCoursewareCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.CoursewareCaseDateIn) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.CoursewareCaseDateIn, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.CoursewareCaseDateIn] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetCoursewareCaseTimeIn(this clsCoursewareCaseEN objCoursewareCaseEN, string strCoursewareCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTimeIn, 6, conCoursewareCase.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseTimeIn, 6, conCoursewareCase.CoursewareCaseTimeIn);
objCoursewareCaseEN.CoursewareCaseTimeIn = strCoursewareCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.CoursewareCaseTimeIn) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.CoursewareCaseTimeIn, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.CoursewareCaseTimeIn] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN Setid_StudyLevel(this clsCoursewareCaseEN objCoursewareCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, conCoursewareCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conCoursewareCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conCoursewareCase.id_StudyLevel);
objCoursewareCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.id_StudyLevel) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.id_StudyLevel, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.id_StudyLevel] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN Setid_TeachingPlan(this clsCoursewareCaseEN objCoursewareCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conCoursewareCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conCoursewareCase.id_TeachingPlan);
objCoursewareCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.id_TeachingPlan) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.id_TeachingPlan, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.id_TeachingPlan] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetId_CaseType(this clsCoursewareCaseEN objCoursewareCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, conCoursewareCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, conCoursewareCase.Id_CaseType);
objCoursewareCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.Id_CaseType) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.Id_CaseType, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.Id_CaseType] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN Setid_Discipline(this clsCoursewareCaseEN objCoursewareCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, conCoursewareCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conCoursewareCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conCoursewareCase.id_Discipline);
objCoursewareCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.id_Discipline) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.id_Discipline, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.id_Discipline] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetBrowseCount(this clsCoursewareCaseEN objCoursewareCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objCoursewareCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.BrowseCount) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.BrowseCount, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.BrowseCount] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN Setid_SenateGaugeVersion(this clsCoursewareCaseEN objCoursewareCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conCoursewareCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conCoursewareCase.id_SenateGaugeVersion);
objCoursewareCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.id_SenateGaugeVersion) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN Setid_TeachSkill(this clsCoursewareCaseEN objCoursewareCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, conCoursewareCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conCoursewareCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conCoursewareCase.id_TeachSkill);
objCoursewareCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.id_TeachSkill) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.id_TeachSkill, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.id_TeachSkill] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetCaseLevelId(this clsCoursewareCaseEN objCoursewareCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conCoursewareCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conCoursewareCase.CaseLevelId);
objCoursewareCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.CaseLevelId) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.CaseLevelId, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.CaseLevelId] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetDocFile(this clsCoursewareCaseEN objCoursewareCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conCoursewareCase.DocFile);
objCoursewareCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.DocFile) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.DocFile, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.DocFile] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetIsNeedGeneWord(this clsCoursewareCaseEN objCoursewareCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objCoursewareCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.IsNeedGeneWord) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetWordCreateDate(this clsCoursewareCaseEN objCoursewareCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conCoursewareCase.WordCreateDate);
objCoursewareCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.WordCreateDate) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.WordCreateDate, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.WordCreateDate] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetIsVisible(this clsCoursewareCaseEN objCoursewareCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objCoursewareCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.IsVisible) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.IsVisible, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.IsVisible] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetOwnerId(this clsCoursewareCaseEN objCoursewareCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conCoursewareCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCoursewareCase.OwnerId);
objCoursewareCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.OwnerId) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.OwnerId, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.OwnerId] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetUserKindId(this clsCoursewareCaseEN objCoursewareCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, conCoursewareCase.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, conCoursewareCase.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, conCoursewareCase.UserKindId);
objCoursewareCaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.UserKindId) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.UserKindId, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.UserKindId] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetUserTypeId(this clsCoursewareCaseEN objCoursewareCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conCoursewareCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conCoursewareCase.UserTypeId);
objCoursewareCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.UserTypeId) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.UserTypeId, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.UserTypeId] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetIsDualVideo(this clsCoursewareCaseEN objCoursewareCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objCoursewareCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.IsDualVideo) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.IsDualVideo, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.IsDualVideo] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetRecommendedDegreeId(this clsCoursewareCaseEN objCoursewareCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conCoursewareCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conCoursewareCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conCoursewareCase.RecommendedDegreeId);
objCoursewareCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.RecommendedDegreeId) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetftpFileType(this clsCoursewareCaseEN objCoursewareCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conCoursewareCase.ftpFileType);
objCoursewareCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.ftpFileType) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.ftpFileType, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.ftpFileType] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetVideoUrl(this clsCoursewareCaseEN objCoursewareCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conCoursewareCase.VideoUrl);
objCoursewareCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.VideoUrl) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.VideoUrl, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.VideoUrl] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetVideoPath(this clsCoursewareCaseEN objCoursewareCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conCoursewareCase.VideoPath);
objCoursewareCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.VideoPath) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.VideoPath, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.VideoPath] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetResErrMsg(this clsCoursewareCaseEN objCoursewareCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conCoursewareCase.ResErrMsg);
objCoursewareCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.ResErrMsg) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.ResErrMsg, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.ResErrMsg] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetUpdDate(this clsCoursewareCaseEN objCoursewareCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCoursewareCase.UpdDate);
objCoursewareCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.UpdDate) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.UpdDate, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.UpdDate] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetUpdUserId(this clsCoursewareCaseEN objCoursewareCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCoursewareCase.UpdUserId);
objCoursewareCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.UpdUserId) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.UpdUserId, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.UpdUserId] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareCaseEN SetMemo(this clsCoursewareCaseEN objCoursewareCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCoursewareCase.Memo);
objCoursewareCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareCaseEN.dicFldComparisonOp.ContainsKey(conCoursewareCase.Memo) == false)
{
objCoursewareCaseEN.dicFldComparisonOp.Add(conCoursewareCase.Memo, strComparisonOp);
}
else
{
objCoursewareCaseEN.dicFldComparisonOp[conCoursewareCase.Memo] = strComparisonOp;
}
}
return objCoursewareCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCoursewareCaseEN objCoursewareCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.Id_CoursewareCase) == true)
{
string strComparisonOp_Id_CoursewareCase = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.Id_CoursewareCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.Id_CoursewareCase, objCoursewareCase_Cond.Id_CoursewareCase, strComparisonOp_Id_CoursewareCase);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.CoursewareCaseID) == true)
{
string strComparisonOp_CoursewareCaseID = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.CoursewareCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.CoursewareCaseID, objCoursewareCase_Cond.CoursewareCaseID, strComparisonOp_CoursewareCaseID);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.CoursewareCaseName) == true)
{
string strComparisonOp_CoursewareCaseName = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.CoursewareCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.CoursewareCaseName, objCoursewareCase_Cond.CoursewareCaseName, strComparisonOp_CoursewareCaseName);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.CoursewareCaseTheme) == true)
{
string strComparisonOp_CoursewareCaseTheme = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.CoursewareCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.CoursewareCaseTheme, objCoursewareCase_Cond.CoursewareCaseTheme, strComparisonOp_CoursewareCaseTheme);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.id_CoursewareCaseType) == true)
{
string strComparisonOp_id_CoursewareCaseType = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.id_CoursewareCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.id_CoursewareCaseType, objCoursewareCase_Cond.id_CoursewareCaseType, strComparisonOp_id_CoursewareCaseType);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.CoursewareCaseText) == true)
{
string strComparisonOp_CoursewareCaseText = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.CoursewareCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.CoursewareCaseText, objCoursewareCase_Cond.CoursewareCaseText, strComparisonOp_CoursewareCaseText);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.CoursewareCaseDate) == true)
{
string strComparisonOp_CoursewareCaseDate = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.CoursewareCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.CoursewareCaseDate, objCoursewareCase_Cond.CoursewareCaseDate, strComparisonOp_CoursewareCaseDate);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.CoursewareCaseTime) == true)
{
string strComparisonOp_CoursewareCaseTime = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.CoursewareCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.CoursewareCaseTime, objCoursewareCase_Cond.CoursewareCaseTime, strComparisonOp_CoursewareCaseTime);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.CoursewareCaseDateIn) == true)
{
string strComparisonOp_CoursewareCaseDateIn = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.CoursewareCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.CoursewareCaseDateIn, objCoursewareCase_Cond.CoursewareCaseDateIn, strComparisonOp_CoursewareCaseDateIn);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.CoursewareCaseTimeIn) == true)
{
string strComparisonOp_CoursewareCaseTimeIn = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.CoursewareCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.CoursewareCaseTimeIn, objCoursewareCase_Cond.CoursewareCaseTimeIn, strComparisonOp_CoursewareCaseTimeIn);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.id_StudyLevel, objCoursewareCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.id_TeachingPlan, objCoursewareCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.Id_CaseType, objCoursewareCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.id_Discipline, objCoursewareCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCoursewareCase.BrowseCount, objCoursewareCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.id_SenateGaugeVersion, objCoursewareCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.id_TeachSkill, objCoursewareCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.CaseLevelId, objCoursewareCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.DocFile) == true)
{
string strComparisonOp_DocFile = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.DocFile, objCoursewareCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.IsNeedGeneWord) == true)
{
if (objCoursewareCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCoursewareCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCoursewareCase.IsNeedGeneWord);
}
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.WordCreateDate, objCoursewareCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.IsVisible) == true)
{
if (objCoursewareCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCoursewareCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCoursewareCase.IsVisible);
}
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.OwnerId, objCoursewareCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.UserKindId) == true)
{
string strComparisonOp_UserKindId = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.UserKindId, objCoursewareCase_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.UserTypeId, objCoursewareCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.IsDualVideo) == true)
{
if (objCoursewareCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCoursewareCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCoursewareCase.IsDualVideo);
}
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.RecommendedDegreeId, objCoursewareCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.ftpFileType, objCoursewareCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.VideoUrl, objCoursewareCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.VideoPath, objCoursewareCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.ResErrMsg, objCoursewareCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.UpdDate, objCoursewareCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.UpdUserId, objCoursewareCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objCoursewareCase_Cond.IsUpdated(conCoursewareCase.Memo) == true)
{
string strComparisonOp_Memo = objCoursewareCase_Cond.dicFldComparisonOp[conCoursewareCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareCase.Memo, objCoursewareCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCoursewareCaseEN objCoursewareCaseEN)
{
 if (string.IsNullOrEmpty(objCoursewareCaseEN.Id_CoursewareCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCoursewareCaseEN.sf_UpdFldSetStr = objCoursewareCaseEN.getsf_UpdFldSetStr();
clsCoursewareCaseWApi.CheckPropertyNew(objCoursewareCaseEN); 
bool bolResult = clsCoursewareCaseWApi.UpdateRecord(objCoursewareCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareCaseWApi.ReFreshCache();
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
 /// <param name = "objCoursewareCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCoursewareCaseEN objCoursewareCaseEN)
{
 if (string.IsNullOrEmpty(objCoursewareCaseEN.Id_CoursewareCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCoursewareCaseWApi.IsExist(objCoursewareCaseEN.Id_CoursewareCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objCoursewareCaseEN.Id_CoursewareCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsCoursewareCaseWApi.CheckPropertyNew(objCoursewareCaseEN); 
bool bolResult = clsCoursewareCaseWApi.AddNewRecord(objCoursewareCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareCaseWApi.ReFreshCache();
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
 /// <param name = "objCoursewareCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCoursewareCaseEN objCoursewareCaseEN)
{
try
{
clsCoursewareCaseWApi.CheckPropertyNew(objCoursewareCaseEN); 
string strId_CoursewareCase = clsCoursewareCaseWApi.AddNewRecordWithMaxId(objCoursewareCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareCaseWApi.ReFreshCache();
return strId_CoursewareCase;
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
 /// <param name = "objCoursewareCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCoursewareCaseEN objCoursewareCaseEN, string strWhereCond)
{
try
{
clsCoursewareCaseWApi.CheckPropertyNew(objCoursewareCaseEN); 
bool bolResult = clsCoursewareCaseWApi.UpdateWithCondition(objCoursewareCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareCaseWApi.ReFreshCache();
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
 /// 课件教学案例(CoursewareCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCoursewareCaseWApi
{
private static readonly string mstrApiControllerName = "CoursewareCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCoursewareCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_Id_CoursewareCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课件教学案例]...","0");
List<clsCoursewareCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="Id_CoursewareCase";
objDDL.DataTextField="CoursewareCaseName";
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
public static void BindCbo_Id_CoursewareCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCoursewareCase.Id_CoursewareCase); 
List<clsCoursewareCaseEN> arrObjLst = clsCoursewareCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCoursewareCaseEN objCoursewareCaseEN = new clsCoursewareCaseEN()
{
Id_CoursewareCase = "0",
CoursewareCaseName = "选[课件教学案例]..."
};
arrObjLst.Insert(0, objCoursewareCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCoursewareCase.Id_CoursewareCase;
objComboBox.DisplayMember = conCoursewareCase.CoursewareCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCoursewareCaseEN objCoursewareCaseEN)
{
if (!Object.Equals(null, objCoursewareCaseEN.Id_CoursewareCase) && GetStrLen(objCoursewareCaseEN.Id_CoursewareCase) > 8)
{
 throw new Exception("字段[课件教学案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareCaseEN.CoursewareCaseID) && GetStrLen(objCoursewareCaseEN.CoursewareCaseID) > 8)
{
 throw new Exception("字段[课件教学案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareCaseEN.CoursewareCaseName) && GetStrLen(objCoursewareCaseEN.CoursewareCaseName) > 100)
{
 throw new Exception("字段[课件教学案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCoursewareCaseEN.CoursewareCaseTheme) && GetStrLen(objCoursewareCaseEN.CoursewareCaseTheme) > 200)
{
 throw new Exception("字段[课件教学案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objCoursewareCaseEN.id_CoursewareCaseType) && GetStrLen(objCoursewareCaseEN.id_CoursewareCaseType) > 4)
{
 throw new Exception("字段[课件案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareCaseEN.CoursewareCaseText) && GetStrLen(objCoursewareCaseEN.CoursewareCaseText) > 8000)
{
 throw new Exception("字段[案例文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objCoursewareCaseEN.CoursewareCaseDate) && GetStrLen(objCoursewareCaseEN.CoursewareCaseDate) > 8)
{
 throw new Exception("字段[课件教学日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareCaseEN.CoursewareCaseTime) && GetStrLen(objCoursewareCaseEN.CoursewareCaseTime) > 6)
{
 throw new Exception("字段[课件教学时间]的长度不能超过6!");
}
if (!Object.Equals(null, objCoursewareCaseEN.CoursewareCaseDateIn) && GetStrLen(objCoursewareCaseEN.CoursewareCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareCaseEN.CoursewareCaseTimeIn) && GetStrLen(objCoursewareCaseEN.CoursewareCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objCoursewareCaseEN.id_StudyLevel) && GetStrLen(objCoursewareCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareCaseEN.id_TeachingPlan) && GetStrLen(objCoursewareCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareCaseEN.Id_CaseType) && GetStrLen(objCoursewareCaseEN.Id_CaseType) > 4)
{
 throw new Exception("字段[案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareCaseEN.id_Discipline) && GetStrLen(objCoursewareCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareCaseEN.id_SenateGaugeVersion) && GetStrLen(objCoursewareCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareCaseEN.id_TeachSkill) && GetStrLen(objCoursewareCaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCoursewareCaseEN.CaseLevelId) && GetStrLen(objCoursewareCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCoursewareCaseEN.DocFile) && GetStrLen(objCoursewareCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objCoursewareCaseEN.WordCreateDate) && GetStrLen(objCoursewareCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objCoursewareCaseEN.OwnerId) && GetStrLen(objCoursewareCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCoursewareCaseEN.UserKindId) && GetStrLen(objCoursewareCaseEN.UserKindId) > 2)
{
 throw new Exception("字段[用户类别Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCoursewareCaseEN.UserTypeId) && GetStrLen(objCoursewareCaseEN.UserTypeId) > 2)
{
 throw new Exception("字段[用户类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCoursewareCaseEN.RecommendedDegreeId) && GetStrLen(objCoursewareCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCoursewareCaseEN.ftpFileType) && GetStrLen(objCoursewareCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objCoursewareCaseEN.VideoUrl) && GetStrLen(objCoursewareCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objCoursewareCaseEN.VideoPath) && GetStrLen(objCoursewareCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objCoursewareCaseEN.ResErrMsg) && GetStrLen(objCoursewareCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objCoursewareCaseEN.UpdDate) && GetStrLen(objCoursewareCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCoursewareCaseEN.UpdUserId) && GetStrLen(objCoursewareCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCoursewareCaseEN.Memo) && GetStrLen(objCoursewareCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCoursewareCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CoursewareCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsCoursewareCaseEN GetObjById_CoursewareCase(string strId_CoursewareCase)
{
string strAction = "GetObjById_CoursewareCase";
string strErrMsg = string.Empty;
string strResult = "";
clsCoursewareCaseEN objCoursewareCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CoursewareCase"] = strId_CoursewareCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCoursewareCaseEN = JsonConvert.DeserializeObject<clsCoursewareCaseEN>((string)jobjReturn["ReturnObj"]);
return objCoursewareCaseEN;
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
 /// <param name = "strId_CoursewareCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsCoursewareCaseEN GetObjById_CoursewareCase_WA_Cache(string strId_CoursewareCase)
{
string strAction = "GetObjById_CoursewareCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCoursewareCaseEN objCoursewareCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CoursewareCase"] = strId_CoursewareCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCoursewareCaseEN = JsonConvert.DeserializeObject<clsCoursewareCaseEN>((string)jobjReturn["ReturnObj"]);
return objCoursewareCaseEN;
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
public static clsCoursewareCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCoursewareCaseEN objCoursewareCaseEN = null;
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
objCoursewareCaseEN = JsonConvert.DeserializeObject<clsCoursewareCaseEN>((string)jobjReturn["ReturnObj"]);
return objCoursewareCaseEN;
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
 /// <param name = "strId_CoursewareCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCoursewareCaseEN GetObjById_CoursewareCase_Cache(string strId_CoursewareCase)
{
if (string.IsNullOrEmpty(strId_CoursewareCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareCaseEN._CurrTabName_S);
List<clsCoursewareCaseEN> arrCoursewareCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareCaseEN> arrCoursewareCaseObjLst_Sel =
from objCoursewareCaseEN in arrCoursewareCaseObjLst_Cache
where objCoursewareCaseEN.Id_CoursewareCase == strId_CoursewareCase
select objCoursewareCaseEN;
if (arrCoursewareCaseObjLst_Sel.Count() == 0)
{
   clsCoursewareCaseEN obj = clsCoursewareCaseWApi.GetObjById_CoursewareCase(strId_CoursewareCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCoursewareCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_CoursewareCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCoursewareCaseNameById_CoursewareCase_Cache(string strId_CoursewareCase)
{
if (string.IsNullOrEmpty(strId_CoursewareCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareCaseEN._CurrTabName_S);
List<clsCoursewareCaseEN> arrCoursewareCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareCaseEN> arrCoursewareCaseObjLst_Sel1 =
from objCoursewareCaseEN in arrCoursewareCaseObjLst_Cache
where objCoursewareCaseEN.Id_CoursewareCase == strId_CoursewareCase
select objCoursewareCaseEN;
List <clsCoursewareCaseEN> arrCoursewareCaseObjLst_Sel = new List<clsCoursewareCaseEN>();
foreach (clsCoursewareCaseEN obj in arrCoursewareCaseObjLst_Sel1)
{
arrCoursewareCaseObjLst_Sel.Add(obj);
}
if (arrCoursewareCaseObjLst_Sel.Count > 0)
{
return arrCoursewareCaseObjLst_Sel[0].CoursewareCaseName;
}
string strErrMsgForGetObjById = string.Format("在CoursewareCase对象缓存列表中,找不到记录[Id_CoursewareCase = {0}](函数:{1})", strId_CoursewareCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCoursewareCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_CoursewareCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameById_CoursewareCase_Cache(string strId_CoursewareCase)
{
if (string.IsNullOrEmpty(strId_CoursewareCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareCaseEN._CurrTabName_S);
List<clsCoursewareCaseEN> arrCoursewareCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareCaseEN> arrCoursewareCaseObjLst_Sel1 =
from objCoursewareCaseEN in arrCoursewareCaseObjLst_Cache
where objCoursewareCaseEN.Id_CoursewareCase == strId_CoursewareCase
select objCoursewareCaseEN;
List <clsCoursewareCaseEN> arrCoursewareCaseObjLst_Sel = new List<clsCoursewareCaseEN>();
foreach (clsCoursewareCaseEN obj in arrCoursewareCaseObjLst_Sel1)
{
arrCoursewareCaseObjLst_Sel.Add(obj);
}
if (arrCoursewareCaseObjLst_Sel.Count > 0)
{
return arrCoursewareCaseObjLst_Sel[0].CoursewareCaseName;
}
string strErrMsgForGetObjById = string.Format("在CoursewareCase对象缓存列表中,找不到记录的相关名称[Id_CoursewareCase = {0}](函数:{1})", strId_CoursewareCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCoursewareCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCoursewareCaseEN> GetObjLst(string strWhereCond)
{
 List<clsCoursewareCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareCaseEN> GetObjLstById_CoursewareCaseLst(List<string> arrId_CoursewareCase)
{
 List<clsCoursewareCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CoursewareCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CoursewareCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_CoursewareCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCoursewareCaseEN> GetObjLstById_CoursewareCaseLst_Cache(List<string> arrId_CoursewareCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareCaseEN._CurrTabName_S);
List<clsCoursewareCaseEN> arrCoursewareCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareCaseEN> arrCoursewareCaseObjLst_Sel =
from objCoursewareCaseEN in arrCoursewareCaseObjLst_Cache
where arrId_CoursewareCase.Contains(objCoursewareCaseEN.Id_CoursewareCase)
select objCoursewareCaseEN;
return arrCoursewareCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCoursewareCaseEN> GetObjLstById_CoursewareCaseLst_WA_Cache(List<string> arrId_CoursewareCase)
{
 List<clsCoursewareCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CoursewareCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CoursewareCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCoursewareCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCoursewareCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCoursewareCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCoursewareCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strId_CoursewareCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCoursewareCaseEN objCoursewareCaseEN = clsCoursewareCaseWApi.GetObjById_CoursewareCase(strId_CoursewareCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_CoursewareCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCoursewareCaseWApi.ReFreshCache();
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
public static int DelCoursewareCases(List<string> arrId_CoursewareCase)
{
string strAction = "DelCoursewareCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CoursewareCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCoursewareCaseWApi.ReFreshCache();
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
public static int DelCoursewareCasesByCond(string strWhereCond)
{
string strAction = "DelCoursewareCasesByCond";
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
public static bool AddNewRecord(clsCoursewareCaseEN objCoursewareCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareCaseEN>(objCoursewareCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsCoursewareCaseEN objCoursewareCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareCaseEN>(objCoursewareCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareCaseWApi.ReFreshCache();
var strId_CoursewareCase = (string)jobjReturn["ReturnStr"];
return strId_CoursewareCase;
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
public static bool UpdateRecord(clsCoursewareCaseEN objCoursewareCaseEN)
{
if (string.IsNullOrEmpty(objCoursewareCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCoursewareCaseEN.Id_CoursewareCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareCaseEN>(objCoursewareCaseEN);
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
 /// <param name = "objCoursewareCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCoursewareCaseEN objCoursewareCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCoursewareCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCoursewareCaseEN.Id_CoursewareCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCoursewareCaseEN.Id_CoursewareCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareCaseEN>(objCoursewareCaseEN);
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
public static bool IsExist(string strId_CoursewareCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CoursewareCase"] = strId_CoursewareCase
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
 /// <param name = "objCoursewareCaseENS">源对象</param>
 /// <param name = "objCoursewareCaseENT">目标对象</param>
 public static void CopyTo(clsCoursewareCaseEN objCoursewareCaseENS, clsCoursewareCaseEN objCoursewareCaseENT)
{
try
{
objCoursewareCaseENT.Id_CoursewareCase = objCoursewareCaseENS.Id_CoursewareCase; //课件教学案例流水号
objCoursewareCaseENT.CoursewareCaseID = objCoursewareCaseENS.CoursewareCaseID; //课件教学案例ID
objCoursewareCaseENT.CoursewareCaseName = objCoursewareCaseENS.CoursewareCaseName; //课件教学案例名称
objCoursewareCaseENT.CoursewareCaseTheme = objCoursewareCaseENS.CoursewareCaseTheme; //课件教学案例主题词
objCoursewareCaseENT.id_CoursewareCaseType = objCoursewareCaseENS.id_CoursewareCaseType; //课件案例类型流水号
objCoursewareCaseENT.CoursewareCaseText = objCoursewareCaseENS.CoursewareCaseText; //案例文本内容
objCoursewareCaseENT.CoursewareCaseDate = objCoursewareCaseENS.CoursewareCaseDate; //课件教学日期
objCoursewareCaseENT.CoursewareCaseTime = objCoursewareCaseENS.CoursewareCaseTime; //课件教学时间
objCoursewareCaseENT.CoursewareCaseDateIn = objCoursewareCaseENS.CoursewareCaseDateIn; //案例入库日期
objCoursewareCaseENT.CoursewareCaseTimeIn = objCoursewareCaseENS.CoursewareCaseTimeIn; //案例入库时间
objCoursewareCaseENT.id_StudyLevel = objCoursewareCaseENS.id_StudyLevel; //id_StudyLevel
objCoursewareCaseENT.id_TeachingPlan = objCoursewareCaseENS.id_TeachingPlan; //教案流水号
objCoursewareCaseENT.Id_CaseType = objCoursewareCaseENS.Id_CaseType; //案例类型流水号
objCoursewareCaseENT.id_Discipline = objCoursewareCaseENS.id_Discipline; //学科流水号
objCoursewareCaseENT.BrowseCount = objCoursewareCaseENS.BrowseCount; //浏览次数
objCoursewareCaseENT.id_SenateGaugeVersion = objCoursewareCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objCoursewareCaseENT.id_TeachSkill = objCoursewareCaseENS.id_TeachSkill; //教学技能流水号
objCoursewareCaseENT.CaseLevelId = objCoursewareCaseENS.CaseLevelId; //课例等级Id
objCoursewareCaseENT.DocFile = objCoursewareCaseENS.DocFile; //生成的Word文件名
objCoursewareCaseENT.IsNeedGeneWord = objCoursewareCaseENS.IsNeedGeneWord; //是否需要生成Word
objCoursewareCaseENT.WordCreateDate = objCoursewareCaseENS.WordCreateDate; //Word生成日期
objCoursewareCaseENT.IsVisible = objCoursewareCaseENS.IsVisible; //是否显示
objCoursewareCaseENT.OwnerId = objCoursewareCaseENS.OwnerId; //拥有者Id
objCoursewareCaseENT.UserKindId = objCoursewareCaseENS.UserKindId; //用户类别Id
objCoursewareCaseENT.UserTypeId = objCoursewareCaseENS.UserTypeId; //用户类型Id
objCoursewareCaseENT.IsDualVideo = objCoursewareCaseENS.IsDualVideo; //是否双视频
objCoursewareCaseENT.RecommendedDegreeId = objCoursewareCaseENS.RecommendedDegreeId; //推荐度Id
objCoursewareCaseENT.ftpFileType = objCoursewareCaseENS.ftpFileType; //ftp文件类型
objCoursewareCaseENT.VideoUrl = objCoursewareCaseENS.VideoUrl; //视频Url
objCoursewareCaseENT.VideoPath = objCoursewareCaseENS.VideoPath; //视频目录
objCoursewareCaseENT.ResErrMsg = objCoursewareCaseENS.ResErrMsg; //资源错误信息
objCoursewareCaseENT.UpdDate = objCoursewareCaseENS.UpdDate; //修改日期
objCoursewareCaseENT.UpdUserId = objCoursewareCaseENS.UpdUserId; //修改用户Id
objCoursewareCaseENT.Memo = objCoursewareCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCoursewareCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCoursewareCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCoursewareCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCoursewareCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCoursewareCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCoursewareCaseEN.AttributeName)
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
if (clsCoursewareCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareCaseWApi没有刷新缓存机制(clsCoursewareCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_CoursewareCase");
//if (arrCoursewareCaseObjLst_Cache == null)
//{
//arrCoursewareCaseObjLst_Cache = await clsCoursewareCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCoursewareCaseEN._CurrTabName_S);
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
if (clsCoursewareCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCoursewareCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCoursewareCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCoursewareCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCoursewareCaseEN._CurrTabName_S);
List<clsCoursewareCaseEN> arrCoursewareCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCoursewareCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCoursewareCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCoursewareCase.Id_CoursewareCase, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.CoursewareCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.CoursewareCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.CoursewareCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.id_CoursewareCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.CoursewareCaseText, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.CoursewareCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.CoursewareCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.CoursewareCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.CoursewareCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCoursewareCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCoursewareCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCoursewareCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCoursewareCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareCase.Memo, Type.GetType("System.String"));
foreach (clsCoursewareCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCoursewareCase.Id_CoursewareCase] = objInFor[conCoursewareCase.Id_CoursewareCase];
objDR[conCoursewareCase.CoursewareCaseID] = objInFor[conCoursewareCase.CoursewareCaseID];
objDR[conCoursewareCase.CoursewareCaseName] = objInFor[conCoursewareCase.CoursewareCaseName];
objDR[conCoursewareCase.CoursewareCaseTheme] = objInFor[conCoursewareCase.CoursewareCaseTheme];
objDR[conCoursewareCase.id_CoursewareCaseType] = objInFor[conCoursewareCase.id_CoursewareCaseType];
objDR[conCoursewareCase.CoursewareCaseText] = objInFor[conCoursewareCase.CoursewareCaseText];
objDR[conCoursewareCase.CoursewareCaseDate] = objInFor[conCoursewareCase.CoursewareCaseDate];
objDR[conCoursewareCase.CoursewareCaseTime] = objInFor[conCoursewareCase.CoursewareCaseTime];
objDR[conCoursewareCase.CoursewareCaseDateIn] = objInFor[conCoursewareCase.CoursewareCaseDateIn];
objDR[conCoursewareCase.CoursewareCaseTimeIn] = objInFor[conCoursewareCase.CoursewareCaseTimeIn];
objDR[conCoursewareCase.id_StudyLevel] = objInFor[conCoursewareCase.id_StudyLevel];
objDR[conCoursewareCase.id_TeachingPlan] = objInFor[conCoursewareCase.id_TeachingPlan];
objDR[conCoursewareCase.Id_CaseType] = objInFor[conCoursewareCase.Id_CaseType];
objDR[conCoursewareCase.id_Discipline] = objInFor[conCoursewareCase.id_Discipline];
objDR[conCoursewareCase.BrowseCount] = objInFor[conCoursewareCase.BrowseCount];
objDR[conCoursewareCase.id_SenateGaugeVersion] = objInFor[conCoursewareCase.id_SenateGaugeVersion];
objDR[conCoursewareCase.id_TeachSkill] = objInFor[conCoursewareCase.id_TeachSkill];
objDR[conCoursewareCase.CaseLevelId] = objInFor[conCoursewareCase.CaseLevelId];
objDR[conCoursewareCase.DocFile] = objInFor[conCoursewareCase.DocFile];
objDR[conCoursewareCase.IsNeedGeneWord] = objInFor[conCoursewareCase.IsNeedGeneWord];
objDR[conCoursewareCase.WordCreateDate] = objInFor[conCoursewareCase.WordCreateDate];
objDR[conCoursewareCase.IsVisible] = objInFor[conCoursewareCase.IsVisible];
objDR[conCoursewareCase.OwnerId] = objInFor[conCoursewareCase.OwnerId];
objDR[conCoursewareCase.UserKindId] = objInFor[conCoursewareCase.UserKindId];
objDR[conCoursewareCase.UserTypeId] = objInFor[conCoursewareCase.UserTypeId];
objDR[conCoursewareCase.IsDualVideo] = objInFor[conCoursewareCase.IsDualVideo];
objDR[conCoursewareCase.RecommendedDegreeId] = objInFor[conCoursewareCase.RecommendedDegreeId];
objDR[conCoursewareCase.ftpFileType] = objInFor[conCoursewareCase.ftpFileType];
objDR[conCoursewareCase.VideoUrl] = objInFor[conCoursewareCase.VideoUrl];
objDR[conCoursewareCase.VideoPath] = objInFor[conCoursewareCase.VideoPath];
objDR[conCoursewareCase.ResErrMsg] = objInFor[conCoursewareCase.ResErrMsg];
objDR[conCoursewareCase.UpdDate] = objInFor[conCoursewareCase.UpdDate];
objDR[conCoursewareCase.UpdUserId] = objInFor[conCoursewareCase.UpdUserId];
objDR[conCoursewareCase.Memo] = objInFor[conCoursewareCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 课件教学案例(CoursewareCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CoursewareCase : clsCommFun4BL
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
clsCoursewareCaseWApi.ReFreshThisCache();
}
}

}