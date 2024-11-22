
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCaseWApi
 表名:vEduMSTRGiftedClsCase(01120380)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:37:51
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评
 模块英文名:EduMSTRGiftedCls
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
public static class clsvEduMSTRGiftedClsCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_EduMSTRGiftedClsCase(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_EduMSTRGiftedClsCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase);
clsCheckSql.CheckFieldForeignKey(strid_EduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase);
objvEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase = strid_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduMSTRGiftedClsCaseID, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = strEduMSTRGiftedClsCaseID; //教育硕士优课案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduMSTRGiftedClsCaseName, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = strEduMSTRGiftedClsCaseName; //教育硕士优课案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTheme(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTheme, 200, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = strEduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseDate(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = strEduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTime(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = strEduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseDateIn(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = strEduMSTRGiftedClsCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_StudyLevel(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convEduMSTRGiftedClsCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convEduMSTRGiftedClsCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convEduMSTRGiftedClsCase.id_StudyLevel);
objvEduMSTRGiftedClsCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_StudyLevel) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_StudyLevel, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_StudyLevel] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetStudyLevelName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convEduMSTRGiftedClsCase.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convEduMSTRGiftedClsCase.StudyLevelName);
objvEduMSTRGiftedClsCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.StudyLevelName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.StudyLevelName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.StudyLevelName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_TeachingPlan(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convEduMSTRGiftedClsCase.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convEduMSTRGiftedClsCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convEduMSTRGiftedClsCase.id_TeachingPlan);
objvEduMSTRGiftedClsCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_TeachingPlan) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTimeIn(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = strEduMSTRGiftedClsCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_EduMSTRGiftedClsCaseType(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_EduMSTRGiftedClsCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType);
clsCheckSql.CheckFieldForeignKey(strid_EduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType);
objvEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCaseType = strid_EduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTypeID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTypeID, 4, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTypeID, 4, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID);
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = strEduMSTRGiftedClsCaseTypeID; //教育硕士优课案例类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTypeName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTypeName, 50, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName);
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = strEduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetId_CaseType(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_CaseType, convEduMSTRGiftedClsCase.Id_CaseType);
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convEduMSTRGiftedClsCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convEduMSTRGiftedClsCase.Id_CaseType);
objvEduMSTRGiftedClsCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.Id_CaseType) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.Id_CaseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.Id_CaseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_Discipline(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convEduMSTRGiftedClsCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convEduMSTRGiftedClsCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convEduMSTRGiftedClsCase.id_Discipline);
objvEduMSTRGiftedClsCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_Discipline) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_Discipline, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_Discipline] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetDisciplineID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convEduMSTRGiftedClsCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convEduMSTRGiftedClsCase.DisciplineID);
objvEduMSTRGiftedClsCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.DisciplineID) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.DisciplineID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.DisciplineID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetDisciplineName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convEduMSTRGiftedClsCase.DisciplineName);
objvEduMSTRGiftedClsCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.DisciplineName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.DisciplineName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.DisciplineName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_SenateGaugeVersion(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convEduMSTRGiftedClsCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convEduMSTRGiftedClsCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convEduMSTRGiftedClsCase.id_SenateGaugeVersion);
objvEduMSTRGiftedClsCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_SenateGaugeVersion) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetsenateGaugeVersionID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convEduMSTRGiftedClsCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCase.senateGaugeVersionID);
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.senateGaugeVersionID) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetsenateGaugeVersionName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convEduMSTRGiftedClsCase.senateGaugeVersionName);
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.senateGaugeVersionName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetsenateGaugeVersionTtlScore(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore);
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetVersionNo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, int intVersionNo, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.VersionNo) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.VersionNo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.VersionNo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_TeachSkill(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convEduMSTRGiftedClsCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convEduMSTRGiftedClsCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convEduMSTRGiftedClsCase.id_TeachSkill);
objvEduMSTRGiftedClsCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_TeachSkill) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_TeachSkill, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_TeachSkill] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetTeachSkillID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convEduMSTRGiftedClsCase.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convEduMSTRGiftedClsCase.TeachSkillID);
objvEduMSTRGiftedClsCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.TeachSkillID) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.TeachSkillID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetSkillTypeName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convEduMSTRGiftedClsCase.SkillTypeName);
objvEduMSTRGiftedClsCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.SkillTypeName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.SkillTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.SkillTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetTeachSkillName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convEduMSTRGiftedClsCase.TeachSkillName);
objvEduMSTRGiftedClsCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.TeachSkillName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.TeachSkillName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetTeachSkillTheory(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convEduMSTRGiftedClsCase.TeachSkillTheory);
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.TeachSkillTheory) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetTeachSkillOperMethod(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convEduMSTRGiftedClsCase.TeachSkillOperMethod);
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.TeachSkillOperMethod) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_SkillType(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convEduMSTRGiftedClsCase.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convEduMSTRGiftedClsCase.id_SkillType);
objvEduMSTRGiftedClsCaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_SkillType) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_SkillType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_SkillType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetSkillTypeID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convEduMSTRGiftedClsCase.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convEduMSTRGiftedClsCase.SkillTypeID);
objvEduMSTRGiftedClsCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.SkillTypeID) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.SkillTypeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.SkillTypeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetCaseLevelId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convEduMSTRGiftedClsCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convEduMSTRGiftedClsCase.CaseLevelId);
objvEduMSTRGiftedClsCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.CaseLevelId) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.CaseLevelId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.CaseLevelId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetCaseLevelName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convEduMSTRGiftedClsCase.CaseLevelName);
objvEduMSTRGiftedClsCaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.CaseLevelName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.CaseLevelName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.CaseLevelName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetDocFile(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convEduMSTRGiftedClsCase.DocFile);
objvEduMSTRGiftedClsCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.DocFile) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.DocFile, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.DocFile] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIsNeedGeneWord(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IsNeedGeneWord) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetWordCreateDate(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convEduMSTRGiftedClsCase.WordCreateDate);
objvEduMSTRGiftedClsCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.WordCreateDate) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.WordCreateDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.WordCreateDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIsVisible(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IsVisible) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IsVisible, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IsVisible] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseText(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseText, 8000, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = strEduMSTRGiftedClsCaseText; //教育硕士优课案例文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetOwnerId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convEduMSTRGiftedClsCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convEduMSTRGiftedClsCase.OwnerId);
objvEduMSTRGiftedClsCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.OwnerId) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.OwnerId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.OwnerId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_StudentInfo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convEduMSTRGiftedClsCase.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convEduMSTRGiftedClsCase.id_StudentInfo);
objvEduMSTRGiftedClsCaseEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_StudentInfo) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_StudentInfo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_StudentInfo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetStuName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convEduMSTRGiftedClsCase.StuName);
clsCheckSql.CheckFieldLen(strStuName, 50, convEduMSTRGiftedClsCase.StuName);
objvEduMSTRGiftedClsCaseEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.StuName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.StuName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetStuID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convEduMSTRGiftedClsCase.StuID);
objvEduMSTRGiftedClsCaseEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.StuID) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.StuID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetPoliticsName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convEduMSTRGiftedClsCase.PoliticsName);
objvEduMSTRGiftedClsCaseEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.PoliticsName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.PoliticsName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.PoliticsName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetSexDesc(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convEduMSTRGiftedClsCase.SexDesc);
objvEduMSTRGiftedClsCaseEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.SexDesc) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.SexDesc, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.SexDesc] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEthnicName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convEduMSTRGiftedClsCase.EthnicName);
objvEduMSTRGiftedClsCaseEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EthnicName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EthnicName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EthnicName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetUniZoneDesc(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convEduMSTRGiftedClsCase.UniZoneDesc);
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.UniZoneDesc) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.UniZoneDesc, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.UniZoneDesc] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetStuTypeDesc(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convEduMSTRGiftedClsCase.StuTypeDesc);
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.StuTypeDesc) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.StuTypeDesc, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuTypeDesc] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_XzCollege(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convEduMSTRGiftedClsCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convEduMSTRGiftedClsCase.id_XzCollege);
objvEduMSTRGiftedClsCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_XzCollege) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_XzCollege, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_XzCollege] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetCollegeID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convEduMSTRGiftedClsCase.CollegeID);
objvEduMSTRGiftedClsCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.CollegeID) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.CollegeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.CollegeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetCollegeName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convEduMSTRGiftedClsCase.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convEduMSTRGiftedClsCase.CollegeName);
objvEduMSTRGiftedClsCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.CollegeName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.CollegeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.CollegeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetCollegeNameA(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convEduMSTRGiftedClsCase.CollegeNameA);
objvEduMSTRGiftedClsCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.CollegeNameA) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.CollegeNameA, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.CollegeNameA] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_XzMajor(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convEduMSTRGiftedClsCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convEduMSTRGiftedClsCase.id_XzMajor);
objvEduMSTRGiftedClsCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_XzMajor) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_XzMajor, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_XzMajor] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetMajorName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convEduMSTRGiftedClsCase.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convEduMSTRGiftedClsCase.MajorName);
objvEduMSTRGiftedClsCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.MajorName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.MajorName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.MajorName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_GradeBase(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_GradeBase, convEduMSTRGiftedClsCase.id_GradeBase);
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convEduMSTRGiftedClsCase.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convEduMSTRGiftedClsCase.id_GradeBase);
objvEduMSTRGiftedClsCaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_GradeBase) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_GradeBase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_GradeBase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetGradeBaseName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convEduMSTRGiftedClsCase.GradeBaseName);
objvEduMSTRGiftedClsCaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.GradeBaseName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.GradeBaseName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.GradeBaseName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN Setid_AdminCls(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convEduMSTRGiftedClsCase.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convEduMSTRGiftedClsCase.id_AdminCls);
objvEduMSTRGiftedClsCaseEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.id_AdminCls) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.id_AdminCls, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_AdminCls] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetAdminClsId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convEduMSTRGiftedClsCase.AdminClsId);
objvEduMSTRGiftedClsCaseEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.AdminClsId) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.AdminClsId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.AdminClsId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetAdminClsName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convEduMSTRGiftedClsCase.AdminClsName);
objvEduMSTRGiftedClsCaseEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.AdminClsName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.AdminClsName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.AdminClsName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetBirthday(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convEduMSTRGiftedClsCase.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convEduMSTRGiftedClsCase.Birthday);
objvEduMSTRGiftedClsCaseEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.Birthday) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.Birthday, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.Birthday] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetNativePlace(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convEduMSTRGiftedClsCase.NativePlace);
objvEduMSTRGiftedClsCaseEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.NativePlace) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.NativePlace, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.NativePlace] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetDuty(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convEduMSTRGiftedClsCase.Duty);
objvEduMSTRGiftedClsCaseEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.Duty) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.Duty, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.Duty] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIDCardNo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convEduMSTRGiftedClsCase.IDCardNo);
objvEduMSTRGiftedClsCaseEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IDCardNo) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IDCardNo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IDCardNo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetStuCardNo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convEduMSTRGiftedClsCase.StuCardNo);
objvEduMSTRGiftedClsCaseEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.StuCardNo) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.StuCardNo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuCardNo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetLiveAddress(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convEduMSTRGiftedClsCase.LiveAddress);
objvEduMSTRGiftedClsCaseEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.LiveAddress) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.LiveAddress, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.LiveAddress] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetHomePhone(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convEduMSTRGiftedClsCase.HomePhone);
objvEduMSTRGiftedClsCaseEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.HomePhone) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.HomePhone, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.HomePhone] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEnrollmentDate(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convEduMSTRGiftedClsCase.EnrollmentDate);
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.EnrollmentDate) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.EnrollmentDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.EnrollmentDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetPostCode(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convEduMSTRGiftedClsCase.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convEduMSTRGiftedClsCase.PostCode);
objvEduMSTRGiftedClsCaseEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.PostCode) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.PostCode, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.PostCode] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIsDualVideo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convEduMSTRGiftedClsCase.IsDualVideo);
objvEduMSTRGiftedClsCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IsDualVideo) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IsDualVideo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IsDualVideo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetUserKindId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convEduMSTRGiftedClsCase.UserKindId);
objvEduMSTRGiftedClsCaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.UserKindId) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.UserKindId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserKindId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetUserKindName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convEduMSTRGiftedClsCase.UserKindName);
objvEduMSTRGiftedClsCaseEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.UserKindName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.UserKindName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserKindName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetUserTypeId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convEduMSTRGiftedClsCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convEduMSTRGiftedClsCase.UserTypeId);
objvEduMSTRGiftedClsCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.UserTypeId) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.UserTypeId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserTypeId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetUserTypeName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convEduMSTRGiftedClsCase.UserTypeName);
objvEduMSTRGiftedClsCaseEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.UserTypeName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.UserTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetRecommendedDegreeId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convEduMSTRGiftedClsCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convEduMSTRGiftedClsCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convEduMSTRGiftedClsCase.RecommendedDegreeId);
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.RecommendedDegreeId) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetRecommendedDegreeName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convEduMSTRGiftedClsCase.RecommendedDegreeName);
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.RecommendedDegreeName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetftpFileType(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convEduMSTRGiftedClsCase.ftpFileType);
objvEduMSTRGiftedClsCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.ftpFileType) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.ftpFileType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.ftpFileType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetVideoUrl(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convEduMSTRGiftedClsCase.VideoUrl);
objvEduMSTRGiftedClsCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.VideoUrl) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.VideoUrl, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.VideoUrl] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetVideoPath(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convEduMSTRGiftedClsCase.VideoPath);
objvEduMSTRGiftedClsCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.VideoPath) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.VideoPath, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.VideoPath] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetResErrMsg(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convEduMSTRGiftedClsCase.ResErrMsg);
objvEduMSTRGiftedClsCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.ResErrMsg) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.ResErrMsg, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.ResErrMsg] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetResourceNum(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, int intResourceNum, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseEN.ResourceNum = intResourceNum; //资源数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.ResourceNum) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.ResourceNum, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.ResourceNum] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetMemo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convEduMSTRGiftedClsCase.Memo);
objvEduMSTRGiftedClsCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.Memo) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.Memo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.Memo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetBrowseCount4Case(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.BrowseCount4Case) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetOwnerName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convEduMSTRGiftedClsCase.OwnerName);
objvEduMSTRGiftedClsCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.OwnerName) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.OwnerName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.OwnerName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetOwnerNameWithId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convEduMSTRGiftedClsCase.OwnerNameWithId);
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.OwnerNameWithId) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIsHaveVideo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convEduMSTRGiftedClsCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convEduMSTRGiftedClsCase.IsHaveVideo);
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IsHaveVideo) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IsHaveVideo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IsHaveVideo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase) == true)
{
string strComparisonOp_id_EduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase, objvEduMSTRGiftedClsCase_Cond.id_EduMSTRGiftedClsCase, strComparisonOp_id_EduMSTRGiftedClsCase);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID, objvEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseID, strComparisonOp_EduMSTRGiftedClsCaseID);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName, objvEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseName, strComparisonOp_EduMSTRGiftedClsCaseName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme, objvEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseTheme, strComparisonOp_EduMSTRGiftedClsCaseTheme);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate, objvEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseDate, strComparisonOp_EduMSTRGiftedClsCaseDate);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime, objvEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseTime, strComparisonOp_EduMSTRGiftedClsCaseTime);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn, objvEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseDateIn, strComparisonOp_EduMSTRGiftedClsCaseDateIn);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_StudyLevel, objvEduMSTRGiftedClsCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.StudyLevelName, objvEduMSTRGiftedClsCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_TeachingPlan, objvEduMSTRGiftedClsCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn, objvEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseTimeIn, strComparisonOp_EduMSTRGiftedClsCaseTimeIn);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType) == true)
{
string strComparisonOp_id_EduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType, objvEduMSTRGiftedClsCase_Cond.id_EduMSTRGiftedClsCaseType, strComparisonOp_id_EduMSTRGiftedClsCaseType);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTypeID = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID, objvEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseTypeID, strComparisonOp_EduMSTRGiftedClsCaseTypeID);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName, objvEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseTypeName, strComparisonOp_EduMSTRGiftedClsCaseTypeName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.Id_CaseType, objvEduMSTRGiftedClsCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_Discipline, objvEduMSTRGiftedClsCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.DisciplineID, objvEduMSTRGiftedClsCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.DisciplineName, objvEduMSTRGiftedClsCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_SenateGaugeVersion, objvEduMSTRGiftedClsCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.senateGaugeVersionID, objvEduMSTRGiftedClsCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.senateGaugeVersionName, objvEduMSTRGiftedClsCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore, objvEduMSTRGiftedClsCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase.VersionNo, objvEduMSTRGiftedClsCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_TeachSkill, objvEduMSTRGiftedClsCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.TeachSkillID, objvEduMSTRGiftedClsCase_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.SkillTypeName, objvEduMSTRGiftedClsCase_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.TeachSkillName, objvEduMSTRGiftedClsCase_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.TeachSkillTheory, objvEduMSTRGiftedClsCase_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.TeachSkillOperMethod, objvEduMSTRGiftedClsCase_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_SkillType, objvEduMSTRGiftedClsCase_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.SkillTypeID, objvEduMSTRGiftedClsCase_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.CaseLevelId, objvEduMSTRGiftedClsCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.CaseLevelName, objvEduMSTRGiftedClsCase_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.DocFile, objvEduMSTRGiftedClsCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.IsNeedGeneWord) == true)
{
if (objvEduMSTRGiftedClsCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase.IsNeedGeneWord);
}
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.WordCreateDate, objvEduMSTRGiftedClsCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.IsVisible) == true)
{
if (objvEduMSTRGiftedClsCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase.IsVisible);
}
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText, objvEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseText, strComparisonOp_EduMSTRGiftedClsCaseText);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.OwnerId, objvEduMSTRGiftedClsCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_StudentInfo, objvEduMSTRGiftedClsCase_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.StuName) == true)
{
string strComparisonOp_StuName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.StuName, objvEduMSTRGiftedClsCase_Cond.StuName, strComparisonOp_StuName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.StuID) == true)
{
string strComparisonOp_StuID = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.StuID, objvEduMSTRGiftedClsCase_Cond.StuID, strComparisonOp_StuID);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.PoliticsName, objvEduMSTRGiftedClsCase_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.SexDesc, objvEduMSTRGiftedClsCase_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EthnicName, objvEduMSTRGiftedClsCase_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.UniZoneDesc, objvEduMSTRGiftedClsCase_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.StuTypeDesc, objvEduMSTRGiftedClsCase_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_XzCollege, objvEduMSTRGiftedClsCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.CollegeID, objvEduMSTRGiftedClsCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.CollegeName, objvEduMSTRGiftedClsCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.CollegeNameA, objvEduMSTRGiftedClsCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_XzMajor, objvEduMSTRGiftedClsCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.MajorName) == true)
{
string strComparisonOp_MajorName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.MajorName, objvEduMSTRGiftedClsCase_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_GradeBase, objvEduMSTRGiftedClsCase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.GradeBaseName, objvEduMSTRGiftedClsCase_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.id_AdminCls, objvEduMSTRGiftedClsCase_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.AdminClsId, objvEduMSTRGiftedClsCase_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.AdminClsName, objvEduMSTRGiftedClsCase_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.Birthday) == true)
{
string strComparisonOp_Birthday = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.Birthday, objvEduMSTRGiftedClsCase_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.NativePlace, objvEduMSTRGiftedClsCase_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.Duty) == true)
{
string strComparisonOp_Duty = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.Duty, objvEduMSTRGiftedClsCase_Cond.Duty, strComparisonOp_Duty);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IDCardNo, objvEduMSTRGiftedClsCase_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.StuCardNo, objvEduMSTRGiftedClsCase_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.LiveAddress, objvEduMSTRGiftedClsCase_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.HomePhone, objvEduMSTRGiftedClsCase_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EnrollmentDate, objvEduMSTRGiftedClsCase_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.PostCode) == true)
{
string strComparisonOp_PostCode = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.PostCode, objvEduMSTRGiftedClsCase_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.IsDualVideo) == true)
{
if (objvEduMSTRGiftedClsCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase.IsDualVideo);
}
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.UserKindId, objvEduMSTRGiftedClsCase_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.UserKindName, objvEduMSTRGiftedClsCase_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.UserTypeId, objvEduMSTRGiftedClsCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.UserTypeName, objvEduMSTRGiftedClsCase_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.RecommendedDegreeId, objvEduMSTRGiftedClsCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.RecommendedDegreeName, objvEduMSTRGiftedClsCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.ftpFileType, objvEduMSTRGiftedClsCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.VideoUrl, objvEduMSTRGiftedClsCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.VideoPath, objvEduMSTRGiftedClsCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.ResErrMsg, objvEduMSTRGiftedClsCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.ResourceNum) == true)
{
string strComparisonOp_ResourceNum = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.ResourceNum];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase.ResourceNum, objvEduMSTRGiftedClsCase_Cond.ResourceNum, strComparisonOp_ResourceNum);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.Memo) == true)
{
string strComparisonOp_Memo = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.Memo, objvEduMSTRGiftedClsCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase.BrowseCount4Case, objvEduMSTRGiftedClsCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.OwnerName, objvEduMSTRGiftedClsCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.OwnerNameWithId, objvEduMSTRGiftedClsCase_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvEduMSTRGiftedClsCase_Cond.IsUpdated(convEduMSTRGiftedClsCase.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IsHaveVideo, objvEduMSTRGiftedClsCase_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教育硕士优课案例(vEduMSTRGiftedClsCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvEduMSTRGiftedClsCaseWApi
{
private static readonly string mstrApiControllerName = "vEduMSTRGiftedClsCaseApi";

 public clsvEduMSTRGiftedClsCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_EduMSTRGiftedClsCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教育硕士优课案例]...","0");
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_EduMSTRGiftedClsCase";
objDDL.DataTextField="EduMSTRGiftedClsCaseName";
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
public static void BindCbo_id_EduMSTRGiftedClsCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase); 
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = clsvEduMSTRGiftedClsCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN()
{
id_EduMSTRGiftedClsCase = "0",
EduMSTRGiftedClsCaseName = "选[v教育硕士优课案例]..."
};
arrObjLst.Insert(0, objvEduMSTRGiftedClsCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase;
objComboBox.DisplayMember = convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_EduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCaseEN GetObjByid_EduMSTRGiftedClsCase(string strid_EduMSTRGiftedClsCase)
{
string strAction = "GetObjByid_EduMSTRGiftedClsCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduMSTRGiftedClsCase"] = strid_EduMSTRGiftedClsCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvEduMSTRGiftedClsCaseEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCaseEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCaseEN;
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
 /// <param name = "strid_EduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCaseEN GetObjByid_EduMSTRGiftedClsCase_WA_Cache(string strid_EduMSTRGiftedClsCase)
{
string strAction = "GetObjByid_EduMSTRGiftedClsCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduMSTRGiftedClsCase"] = strid_EduMSTRGiftedClsCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvEduMSTRGiftedClsCaseEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCaseEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCaseEN;
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
public static clsvEduMSTRGiftedClsCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = null;
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
objvEduMSTRGiftedClsCaseEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCaseEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCaseEN;
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
 /// <param name = "strid_EduMSTRGiftedClsCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvEduMSTRGiftedClsCaseEN GetObjByid_EduMSTRGiftedClsCase_Cache(string strid_EduMSTRGiftedClsCase)
{
if (string.IsNullOrEmpty(strid_EduMSTRGiftedClsCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Sel =
from objvEduMSTRGiftedClsCaseEN in arrvEduMSTRGiftedClsCaseObjLst_Cache
where objvEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase == strid_EduMSTRGiftedClsCase
select objvEduMSTRGiftedClsCaseEN;
if (arrvEduMSTRGiftedClsCaseObjLst_Sel.Count() == 0)
{
   clsvEduMSTRGiftedClsCaseEN obj = clsvEduMSTRGiftedClsCaseWApi.GetObjByid_EduMSTRGiftedClsCase(strid_EduMSTRGiftedClsCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvEduMSTRGiftedClsCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_EduMSTRGiftedClsCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEduMSTRGiftedClsCaseNameByid_EduMSTRGiftedClsCase_Cache(string strid_EduMSTRGiftedClsCase)
{
if (string.IsNullOrEmpty(strid_EduMSTRGiftedClsCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Sel1 =
from objvEduMSTRGiftedClsCaseEN in arrvEduMSTRGiftedClsCaseObjLst_Cache
where objvEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase == strid_EduMSTRGiftedClsCase
select objvEduMSTRGiftedClsCaseEN;
List <clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Sel = new List<clsvEduMSTRGiftedClsCaseEN>();
foreach (clsvEduMSTRGiftedClsCaseEN obj in arrvEduMSTRGiftedClsCaseObjLst_Sel1)
{
arrvEduMSTRGiftedClsCaseObjLst_Sel.Add(obj);
}
if (arrvEduMSTRGiftedClsCaseObjLst_Sel.Count > 0)
{
return arrvEduMSTRGiftedClsCaseObjLst_Sel[0].EduMSTRGiftedClsCaseName;
}
string strErrMsgForGetObjById = string.Format("在vEduMSTRGiftedClsCase对象缓存列表中,找不到记录[id_EduMSTRGiftedClsCase = {0}](函数:{1})", strid_EduMSTRGiftedClsCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvEduMSTRGiftedClsCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_EduMSTRGiftedClsCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_EduMSTRGiftedClsCase_Cache(string strid_EduMSTRGiftedClsCase)
{
if (string.IsNullOrEmpty(strid_EduMSTRGiftedClsCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Sel1 =
from objvEduMSTRGiftedClsCaseEN in arrvEduMSTRGiftedClsCaseObjLst_Cache
where objvEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase == strid_EduMSTRGiftedClsCase
select objvEduMSTRGiftedClsCaseEN;
List <clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Sel = new List<clsvEduMSTRGiftedClsCaseEN>();
foreach (clsvEduMSTRGiftedClsCaseEN obj in arrvEduMSTRGiftedClsCaseObjLst_Sel1)
{
arrvEduMSTRGiftedClsCaseObjLst_Sel.Add(obj);
}
if (arrvEduMSTRGiftedClsCaseObjLst_Sel.Count > 0)
{
return arrvEduMSTRGiftedClsCaseObjLst_Sel[0].EduMSTRGiftedClsCaseName;
}
string strErrMsgForGetObjById = string.Format("在vEduMSTRGiftedClsCase对象缓存列表中,找不到记录的相关名称[id_EduMSTRGiftedClsCase = {0}](函数:{1})", strid_EduMSTRGiftedClsCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvEduMSTRGiftedClsCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstById_EduMSTRGiftedClsCaseLst(List<string> arrId_EduMSTRGiftedClsCase)
{
 List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduMSTRGiftedClsCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduMSTRGiftedClsCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_EduMSTRGiftedClsCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvEduMSTRGiftedClsCaseEN> GetObjLstById_EduMSTRGiftedClsCaseLst_Cache(List<string> arrId_EduMSTRGiftedClsCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Sel =
from objvEduMSTRGiftedClsCaseEN in arrvEduMSTRGiftedClsCaseObjLst_Cache
where arrId_EduMSTRGiftedClsCase.Contains(objvEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase)
select objvEduMSTRGiftedClsCaseEN;
return arrvEduMSTRGiftedClsCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstById_EduMSTRGiftedClsCaseLst_WA_Cache(List<string> arrId_EduMSTRGiftedClsCase)
{
 List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduMSTRGiftedClsCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduMSTRGiftedClsCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_EduMSTRGiftedClsCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduMSTRGiftedClsCase"] = strid_EduMSTRGiftedClsCase
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
 /// <param name = "objvEduMSTRGiftedClsCaseENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCaseENT">目标对象</param>
 public static void CopyTo(clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseENS, clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseENT)
{
try
{
objvEduMSTRGiftedClsCaseENT.id_EduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseENS.id_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objvEduMSTRGiftedClsCaseENT.id_StudyLevel = objvEduMSTRGiftedClsCaseENS.id_StudyLevel; //id_StudyLevel
objvEduMSTRGiftedClsCaseENT.StudyLevelName = objvEduMSTRGiftedClsCaseENS.StudyLevelName; //学段名称
objvEduMSTRGiftedClsCaseENT.id_TeachingPlan = objvEduMSTRGiftedClsCaseENS.id_TeachingPlan; //教案流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objvEduMSTRGiftedClsCaseENT.id_EduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCaseENS.id_EduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTypeID = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTypeID; //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseENT.Id_CaseType = objvEduMSTRGiftedClsCaseENS.Id_CaseType; //案例类型流水号
objvEduMSTRGiftedClsCaseENT.id_Discipline = objvEduMSTRGiftedClsCaseENS.id_Discipline; //学科流水号
objvEduMSTRGiftedClsCaseENT.DisciplineID = objvEduMSTRGiftedClsCaseENS.DisciplineID; //学科ID
objvEduMSTRGiftedClsCaseENT.DisciplineName = objvEduMSTRGiftedClsCaseENS.DisciplineName; //学科名称
objvEduMSTRGiftedClsCaseENT.id_SenateGaugeVersion = objvEduMSTRGiftedClsCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionID = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionName = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCaseENT.VersionNo = objvEduMSTRGiftedClsCaseENS.VersionNo; //版本号
objvEduMSTRGiftedClsCaseENT.id_TeachSkill = objvEduMSTRGiftedClsCaseENS.id_TeachSkill; //教学技能流水号
objvEduMSTRGiftedClsCaseENT.TeachSkillID = objvEduMSTRGiftedClsCaseENS.TeachSkillID; //教学技能ID
objvEduMSTRGiftedClsCaseENT.SkillTypeName = objvEduMSTRGiftedClsCaseENS.SkillTypeName; //技能类型名称
objvEduMSTRGiftedClsCaseENT.TeachSkillName = objvEduMSTRGiftedClsCaseENS.TeachSkillName; //教学技能名称
objvEduMSTRGiftedClsCaseENT.TeachSkillTheory = objvEduMSTRGiftedClsCaseENS.TeachSkillTheory; //教学技能理论阐述
objvEduMSTRGiftedClsCaseENT.TeachSkillOperMethod = objvEduMSTRGiftedClsCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvEduMSTRGiftedClsCaseENT.id_SkillType = objvEduMSTRGiftedClsCaseENS.id_SkillType; //技能类型流水号
objvEduMSTRGiftedClsCaseENT.SkillTypeID = objvEduMSTRGiftedClsCaseENS.SkillTypeID; //技能类型ID
objvEduMSTRGiftedClsCaseENT.CaseLevelId = objvEduMSTRGiftedClsCaseENS.CaseLevelId; //课例等级Id
objvEduMSTRGiftedClsCaseENT.CaseLevelName = objvEduMSTRGiftedClsCaseENS.CaseLevelName; //案例等级名称
objvEduMSTRGiftedClsCaseENT.DocFile = objvEduMSTRGiftedClsCaseENS.DocFile; //生成的Word文件名
objvEduMSTRGiftedClsCaseENT.IsNeedGeneWord = objvEduMSTRGiftedClsCaseENS.IsNeedGeneWord; //是否需要生成Word
objvEduMSTRGiftedClsCaseENT.WordCreateDate = objvEduMSTRGiftedClsCaseENS.WordCreateDate; //Word生成日期
objvEduMSTRGiftedClsCaseENT.IsVisible = objvEduMSTRGiftedClsCaseENS.IsVisible; //是否显示
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseENT.OwnerId = objvEduMSTRGiftedClsCaseENS.OwnerId; //拥有者Id
objvEduMSTRGiftedClsCaseENT.id_StudentInfo = objvEduMSTRGiftedClsCaseENS.id_StudentInfo; //学生流水号
objvEduMSTRGiftedClsCaseENT.StuName = objvEduMSTRGiftedClsCaseENS.StuName; //姓名
objvEduMSTRGiftedClsCaseENT.StuID = objvEduMSTRGiftedClsCaseENS.StuID; //学号
objvEduMSTRGiftedClsCaseENT.PoliticsName = objvEduMSTRGiftedClsCaseENS.PoliticsName; //政治面貌
objvEduMSTRGiftedClsCaseENT.SexDesc = objvEduMSTRGiftedClsCaseENS.SexDesc; //性别名称
objvEduMSTRGiftedClsCaseENT.EthnicName = objvEduMSTRGiftedClsCaseENS.EthnicName; //民族名称
objvEduMSTRGiftedClsCaseENT.UniZoneDesc = objvEduMSTRGiftedClsCaseENS.UniZoneDesc; //校区名称
objvEduMSTRGiftedClsCaseENT.StuTypeDesc = objvEduMSTRGiftedClsCaseENS.StuTypeDesc; //学生类别名称
objvEduMSTRGiftedClsCaseENT.id_XzCollege = objvEduMSTRGiftedClsCaseENS.id_XzCollege; //学院流水号
objvEduMSTRGiftedClsCaseENT.CollegeID = objvEduMSTRGiftedClsCaseENS.CollegeID; //学院ID
objvEduMSTRGiftedClsCaseENT.CollegeName = objvEduMSTRGiftedClsCaseENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCaseENT.CollegeNameA = objvEduMSTRGiftedClsCaseENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCaseENT.id_XzMajor = objvEduMSTRGiftedClsCaseENS.id_XzMajor; //专业流水号
objvEduMSTRGiftedClsCaseENT.MajorName = objvEduMSTRGiftedClsCaseENS.MajorName; //专业名称
objvEduMSTRGiftedClsCaseENT.id_GradeBase = objvEduMSTRGiftedClsCaseENS.id_GradeBase; //年级流水号
objvEduMSTRGiftedClsCaseENT.GradeBaseName = objvEduMSTRGiftedClsCaseENS.GradeBaseName; //年级名称
objvEduMSTRGiftedClsCaseENT.id_AdminCls = objvEduMSTRGiftedClsCaseENS.id_AdminCls; //行政班流水号
objvEduMSTRGiftedClsCaseENT.AdminClsId = objvEduMSTRGiftedClsCaseENS.AdminClsId; //行政班代号
objvEduMSTRGiftedClsCaseENT.AdminClsName = objvEduMSTRGiftedClsCaseENS.AdminClsName; //行政班名称
objvEduMSTRGiftedClsCaseENT.Birthday = objvEduMSTRGiftedClsCaseENS.Birthday; //出生日期
objvEduMSTRGiftedClsCaseENT.NativePlace = objvEduMSTRGiftedClsCaseENS.NativePlace; //籍贯
objvEduMSTRGiftedClsCaseENT.Duty = objvEduMSTRGiftedClsCaseENS.Duty; //职位
objvEduMSTRGiftedClsCaseENT.IDCardNo = objvEduMSTRGiftedClsCaseENS.IDCardNo; //身份证号
objvEduMSTRGiftedClsCaseENT.StuCardNo = objvEduMSTRGiftedClsCaseENS.StuCardNo; //学生证号
objvEduMSTRGiftedClsCaseENT.LiveAddress = objvEduMSTRGiftedClsCaseENS.LiveAddress; //居住地址
objvEduMSTRGiftedClsCaseENT.HomePhone = objvEduMSTRGiftedClsCaseENS.HomePhone; //住宅电话
objvEduMSTRGiftedClsCaseENT.EnrollmentDate = objvEduMSTRGiftedClsCaseENS.EnrollmentDate; //入校日期
objvEduMSTRGiftedClsCaseENT.PostCode = objvEduMSTRGiftedClsCaseENS.PostCode; //邮编
objvEduMSTRGiftedClsCaseENT.IsDualVideo = objvEduMSTRGiftedClsCaseENS.IsDualVideo; //是否双视频
objvEduMSTRGiftedClsCaseENT.UserKindId = objvEduMSTRGiftedClsCaseENS.UserKindId; //用户类别Id
objvEduMSTRGiftedClsCaseENT.UserKindName = objvEduMSTRGiftedClsCaseENS.UserKindName; //用户类别名
objvEduMSTRGiftedClsCaseENT.UserTypeId = objvEduMSTRGiftedClsCaseENS.UserTypeId; //用户类型Id
objvEduMSTRGiftedClsCaseENT.UserTypeName = objvEduMSTRGiftedClsCaseENS.UserTypeName; //用户类型名称
objvEduMSTRGiftedClsCaseENT.RecommendedDegreeId = objvEduMSTRGiftedClsCaseENS.RecommendedDegreeId; //推荐度Id
objvEduMSTRGiftedClsCaseENT.RecommendedDegreeName = objvEduMSTRGiftedClsCaseENS.RecommendedDegreeName; //推荐度名称
objvEduMSTRGiftedClsCaseENT.ftpFileType = objvEduMSTRGiftedClsCaseENS.ftpFileType; //ftp文件类型
objvEduMSTRGiftedClsCaseENT.VideoUrl = objvEduMSTRGiftedClsCaseENS.VideoUrl; //视频Url
objvEduMSTRGiftedClsCaseENT.VideoPath = objvEduMSTRGiftedClsCaseENS.VideoPath; //视频目录
objvEduMSTRGiftedClsCaseENT.ResErrMsg = objvEduMSTRGiftedClsCaseENS.ResErrMsg; //资源错误信息
objvEduMSTRGiftedClsCaseENT.ResourceNum = objvEduMSTRGiftedClsCaseENS.ResourceNum; //资源数
objvEduMSTRGiftedClsCaseENT.Memo = objvEduMSTRGiftedClsCaseENS.Memo; //备注
objvEduMSTRGiftedClsCaseENT.BrowseCount4Case = objvEduMSTRGiftedClsCaseENS.BrowseCount4Case; //课例浏览次数
objvEduMSTRGiftedClsCaseENT.OwnerName = objvEduMSTRGiftedClsCaseENS.OwnerName; //拥有者姓名
objvEduMSTRGiftedClsCaseENT.OwnerNameWithId = objvEduMSTRGiftedClsCaseENS.OwnerNameWithId; //拥有者名称附Id
objvEduMSTRGiftedClsCaseENT.IsHaveVideo = objvEduMSTRGiftedClsCaseENS.IsHaveVideo; //IsHaveVideo
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
public static DataTable ToDataTable(List<clsvEduMSTRGiftedClsCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvEduMSTRGiftedClsCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvEduMSTRGiftedClsCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvEduMSTRGiftedClsCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvEduMSTRGiftedClsCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvEduMSTRGiftedClsCaseEN.AttributeName)
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
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsEduMSTRGiftedClsCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsEduMSTRGiftedClsCaseWApi没有刷新缓存机制(clsEduMSTRGiftedClsCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsEduMSTRGiftedClsCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsEduMSTRGiftedClsCaseTypeWApi没有刷新缓存机制(clsEduMSTRGiftedClsCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_EduMSTRGiftedClsCase");
//if (arrvEduMSTRGiftedClsCaseObjLst_Cache == null)
//{
//arrvEduMSTRGiftedClsCaseObjLst_Cache = await clsvEduMSTRGiftedClsCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseEN._CurrTabName_S);
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvEduMSTRGiftedClsCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvEduMSTRGiftedClsCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.ResourceNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase.IsHaveVideo, Type.GetType("System.String"));
foreach (clsvEduMSTRGiftedClsCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase] = objInFor[convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase];
objDR[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID] = objInFor[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID];
objDR[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName] = objInFor[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName];
objDR[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] = objInFor[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme];
objDR[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] = objInFor[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate];
objDR[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] = objInFor[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime];
objDR[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] = objInFor[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn];
objDR[convEduMSTRGiftedClsCase.id_StudyLevel] = objInFor[convEduMSTRGiftedClsCase.id_StudyLevel];
objDR[convEduMSTRGiftedClsCase.StudyLevelName] = objInFor[convEduMSTRGiftedClsCase.StudyLevelName];
objDR[convEduMSTRGiftedClsCase.id_TeachingPlan] = objInFor[convEduMSTRGiftedClsCase.id_TeachingPlan];
objDR[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] = objInFor[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn];
objDR[convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType] = objInFor[convEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType];
objDR[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] = objInFor[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID];
objDR[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] = objInFor[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName];
objDR[convEduMSTRGiftedClsCase.Id_CaseType] = objInFor[convEduMSTRGiftedClsCase.Id_CaseType];
objDR[convEduMSTRGiftedClsCase.id_Discipline] = objInFor[convEduMSTRGiftedClsCase.id_Discipline];
objDR[convEduMSTRGiftedClsCase.DisciplineID] = objInFor[convEduMSTRGiftedClsCase.DisciplineID];
objDR[convEduMSTRGiftedClsCase.DisciplineName] = objInFor[convEduMSTRGiftedClsCase.DisciplineName];
objDR[convEduMSTRGiftedClsCase.id_SenateGaugeVersion] = objInFor[convEduMSTRGiftedClsCase.id_SenateGaugeVersion];
objDR[convEduMSTRGiftedClsCase.senateGaugeVersionID] = objInFor[convEduMSTRGiftedClsCase.senateGaugeVersionID];
objDR[convEduMSTRGiftedClsCase.senateGaugeVersionName] = objInFor[convEduMSTRGiftedClsCase.senateGaugeVersionName];
objDR[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore] = objInFor[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore];
objDR[convEduMSTRGiftedClsCase.VersionNo] = objInFor[convEduMSTRGiftedClsCase.VersionNo];
objDR[convEduMSTRGiftedClsCase.id_TeachSkill] = objInFor[convEduMSTRGiftedClsCase.id_TeachSkill];
objDR[convEduMSTRGiftedClsCase.TeachSkillID] = objInFor[convEduMSTRGiftedClsCase.TeachSkillID];
objDR[convEduMSTRGiftedClsCase.SkillTypeName] = objInFor[convEduMSTRGiftedClsCase.SkillTypeName];
objDR[convEduMSTRGiftedClsCase.TeachSkillName] = objInFor[convEduMSTRGiftedClsCase.TeachSkillName];
objDR[convEduMSTRGiftedClsCase.TeachSkillTheory] = objInFor[convEduMSTRGiftedClsCase.TeachSkillTheory];
objDR[convEduMSTRGiftedClsCase.TeachSkillOperMethod] = objInFor[convEduMSTRGiftedClsCase.TeachSkillOperMethod];
objDR[convEduMSTRGiftedClsCase.id_SkillType] = objInFor[convEduMSTRGiftedClsCase.id_SkillType];
objDR[convEduMSTRGiftedClsCase.SkillTypeID] = objInFor[convEduMSTRGiftedClsCase.SkillTypeID];
objDR[convEduMSTRGiftedClsCase.CaseLevelId] = objInFor[convEduMSTRGiftedClsCase.CaseLevelId];
objDR[convEduMSTRGiftedClsCase.CaseLevelName] = objInFor[convEduMSTRGiftedClsCase.CaseLevelName];
objDR[convEduMSTRGiftedClsCase.DocFile] = objInFor[convEduMSTRGiftedClsCase.DocFile];
objDR[convEduMSTRGiftedClsCase.IsNeedGeneWord] = objInFor[convEduMSTRGiftedClsCase.IsNeedGeneWord];
objDR[convEduMSTRGiftedClsCase.WordCreateDate] = objInFor[convEduMSTRGiftedClsCase.WordCreateDate];
objDR[convEduMSTRGiftedClsCase.IsVisible] = objInFor[convEduMSTRGiftedClsCase.IsVisible];
objDR[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] = objInFor[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText];
objDR[convEduMSTRGiftedClsCase.OwnerId] = objInFor[convEduMSTRGiftedClsCase.OwnerId];
objDR[convEduMSTRGiftedClsCase.id_StudentInfo] = objInFor[convEduMSTRGiftedClsCase.id_StudentInfo];
objDR[convEduMSTRGiftedClsCase.StuName] = objInFor[convEduMSTRGiftedClsCase.StuName];
objDR[convEduMSTRGiftedClsCase.StuID] = objInFor[convEduMSTRGiftedClsCase.StuID];
objDR[convEduMSTRGiftedClsCase.PoliticsName] = objInFor[convEduMSTRGiftedClsCase.PoliticsName];
objDR[convEduMSTRGiftedClsCase.SexDesc] = objInFor[convEduMSTRGiftedClsCase.SexDesc];
objDR[convEduMSTRGiftedClsCase.EthnicName] = objInFor[convEduMSTRGiftedClsCase.EthnicName];
objDR[convEduMSTRGiftedClsCase.UniZoneDesc] = objInFor[convEduMSTRGiftedClsCase.UniZoneDesc];
objDR[convEduMSTRGiftedClsCase.StuTypeDesc] = objInFor[convEduMSTRGiftedClsCase.StuTypeDesc];
objDR[convEduMSTRGiftedClsCase.id_XzCollege] = objInFor[convEduMSTRGiftedClsCase.id_XzCollege];
objDR[convEduMSTRGiftedClsCase.CollegeID] = objInFor[convEduMSTRGiftedClsCase.CollegeID];
objDR[convEduMSTRGiftedClsCase.CollegeName] = objInFor[convEduMSTRGiftedClsCase.CollegeName];
objDR[convEduMSTRGiftedClsCase.CollegeNameA] = objInFor[convEduMSTRGiftedClsCase.CollegeNameA];
objDR[convEduMSTRGiftedClsCase.id_XzMajor] = objInFor[convEduMSTRGiftedClsCase.id_XzMajor];
objDR[convEduMSTRGiftedClsCase.MajorName] = objInFor[convEduMSTRGiftedClsCase.MajorName];
objDR[convEduMSTRGiftedClsCase.id_GradeBase] = objInFor[convEduMSTRGiftedClsCase.id_GradeBase];
objDR[convEduMSTRGiftedClsCase.GradeBaseName] = objInFor[convEduMSTRGiftedClsCase.GradeBaseName];
objDR[convEduMSTRGiftedClsCase.id_AdminCls] = objInFor[convEduMSTRGiftedClsCase.id_AdminCls];
objDR[convEduMSTRGiftedClsCase.AdminClsId] = objInFor[convEduMSTRGiftedClsCase.AdminClsId];
objDR[convEduMSTRGiftedClsCase.AdminClsName] = objInFor[convEduMSTRGiftedClsCase.AdminClsName];
objDR[convEduMSTRGiftedClsCase.Birthday] = objInFor[convEduMSTRGiftedClsCase.Birthday];
objDR[convEduMSTRGiftedClsCase.NativePlace] = objInFor[convEduMSTRGiftedClsCase.NativePlace];
objDR[convEduMSTRGiftedClsCase.Duty] = objInFor[convEduMSTRGiftedClsCase.Duty];
objDR[convEduMSTRGiftedClsCase.IDCardNo] = objInFor[convEduMSTRGiftedClsCase.IDCardNo];
objDR[convEduMSTRGiftedClsCase.StuCardNo] = objInFor[convEduMSTRGiftedClsCase.StuCardNo];
objDR[convEduMSTRGiftedClsCase.LiveAddress] = objInFor[convEduMSTRGiftedClsCase.LiveAddress];
objDR[convEduMSTRGiftedClsCase.HomePhone] = objInFor[convEduMSTRGiftedClsCase.HomePhone];
objDR[convEduMSTRGiftedClsCase.EnrollmentDate] = objInFor[convEduMSTRGiftedClsCase.EnrollmentDate];
objDR[convEduMSTRGiftedClsCase.PostCode] = objInFor[convEduMSTRGiftedClsCase.PostCode];
objDR[convEduMSTRGiftedClsCase.IsDualVideo] = objInFor[convEduMSTRGiftedClsCase.IsDualVideo];
objDR[convEduMSTRGiftedClsCase.UserKindId] = objInFor[convEduMSTRGiftedClsCase.UserKindId];
objDR[convEduMSTRGiftedClsCase.UserKindName] = objInFor[convEduMSTRGiftedClsCase.UserKindName];
objDR[convEduMSTRGiftedClsCase.UserTypeId] = objInFor[convEduMSTRGiftedClsCase.UserTypeId];
objDR[convEduMSTRGiftedClsCase.UserTypeName] = objInFor[convEduMSTRGiftedClsCase.UserTypeName];
objDR[convEduMSTRGiftedClsCase.RecommendedDegreeId] = objInFor[convEduMSTRGiftedClsCase.RecommendedDegreeId];
objDR[convEduMSTRGiftedClsCase.RecommendedDegreeName] = objInFor[convEduMSTRGiftedClsCase.RecommendedDegreeName];
objDR[convEduMSTRGiftedClsCase.ftpFileType] = objInFor[convEduMSTRGiftedClsCase.ftpFileType];
objDR[convEduMSTRGiftedClsCase.VideoUrl] = objInFor[convEduMSTRGiftedClsCase.VideoUrl];
objDR[convEduMSTRGiftedClsCase.VideoPath] = objInFor[convEduMSTRGiftedClsCase.VideoPath];
objDR[convEduMSTRGiftedClsCase.ResErrMsg] = objInFor[convEduMSTRGiftedClsCase.ResErrMsg];
objDR[convEduMSTRGiftedClsCase.ResourceNum] = objInFor[convEduMSTRGiftedClsCase.ResourceNum];
objDR[convEduMSTRGiftedClsCase.Memo] = objInFor[convEduMSTRGiftedClsCase.Memo];
objDR[convEduMSTRGiftedClsCase.BrowseCount4Case] = objInFor[convEduMSTRGiftedClsCase.BrowseCount4Case];
objDR[convEduMSTRGiftedClsCase.OwnerName] = objInFor[convEduMSTRGiftedClsCase.OwnerName];
objDR[convEduMSTRGiftedClsCase.OwnerNameWithId] = objInFor[convEduMSTRGiftedClsCase.OwnerNameWithId];
objDR[convEduMSTRGiftedClsCase.IsHaveVideo] = objInFor[convEduMSTRGiftedClsCase.IsHaveVideo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}