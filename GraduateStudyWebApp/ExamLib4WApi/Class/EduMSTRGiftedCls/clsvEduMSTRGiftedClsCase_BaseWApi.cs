
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCase_BaseWApi
 表名:vEduMSTRGiftedClsCase_Base(01120498)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:17
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
public static class clsvEduMSTRGiftedClsCase_BaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_EduMSTRGiftedClsCase(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_EduMSTRGiftedClsCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase);
clsCheckSql.CheckFieldForeignKey(strid_EduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase);
objvEduMSTRGiftedClsCase_BaseEN.id_EduMSTRGiftedClsCase = strid_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduMSTRGiftedClsCaseID, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = strEduMSTRGiftedClsCaseID; //教育硕士优课案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduMSTRGiftedClsCaseName, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName);
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = strEduMSTRGiftedClsCaseName; //教育硕士优课案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseTheme(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTheme, 200, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme);
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = strEduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseDate(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate);
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = strEduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseTime(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime);
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = strEduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseDateIn(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn);
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = strEduMSTRGiftedClsCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_StudyLevel(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convEduMSTRGiftedClsCase_Base.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convEduMSTRGiftedClsCase_Base.id_StudyLevel);
objvEduMSTRGiftedClsCase_BaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_StudyLevel) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_StudyLevel, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_StudyLevel] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStudyLevelName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convEduMSTRGiftedClsCase_Base.StudyLevelName);
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.StudyLevelName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.StudyLevelName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StudyLevelName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_TeachingPlan(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convEduMSTRGiftedClsCase_Base.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convEduMSTRGiftedClsCase_Base.id_TeachingPlan);
objvEduMSTRGiftedClsCase_BaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_TeachingPlan) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_TeachingPlan, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_TeachingPlan] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseTimeIn(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn);
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = strEduMSTRGiftedClsCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_EduMSTRGiftedClsCaseType(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_EduMSTRGiftedClsCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType);
clsCheckSql.CheckFieldForeignKey(strid_EduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType);
objvEduMSTRGiftedClsCase_BaseEN.id_EduMSTRGiftedClsCaseType = strid_EduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseTypeName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTypeName, 50, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName);
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = strEduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetId_CaseType(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convEduMSTRGiftedClsCase_Base.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convEduMSTRGiftedClsCase_Base.Id_CaseType);
objvEduMSTRGiftedClsCase_BaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.Id_CaseType) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.Id_CaseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.Id_CaseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_Discipline(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convEduMSTRGiftedClsCase_Base.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convEduMSTRGiftedClsCase_Base.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convEduMSTRGiftedClsCase_Base.id_Discipline);
objvEduMSTRGiftedClsCase_BaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_Discipline) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_Discipline, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_Discipline] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetDisciplineID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convEduMSTRGiftedClsCase_Base.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convEduMSTRGiftedClsCase_Base.DisciplineID);
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.DisciplineID) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.DisciplineID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.DisciplineID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetDisciplineName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convEduMSTRGiftedClsCase_Base.DisciplineName);
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.DisciplineName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.DisciplineName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.DisciplineName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_SenateGaugeVersion(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion);
objvEduMSTRGiftedClsCase_BaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetsenateGaugeVersionID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCase_Base.senateGaugeVersionID);
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.senateGaugeVersionID) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.senateGaugeVersionID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetsenateGaugeVersionName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convEduMSTRGiftedClsCase_Base.senateGaugeVersionName);
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.senateGaugeVersionName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.senateGaugeVersionName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetVersionNo(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, int intVersionNo, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.VersionNo) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.VersionNo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.VersionNo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_TeachSkill(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convEduMSTRGiftedClsCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convEduMSTRGiftedClsCase_Base.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convEduMSTRGiftedClsCase_Base.id_TeachSkill);
objvEduMSTRGiftedClsCase_BaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_TeachSkill) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_TeachSkill, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_TeachSkill] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetTeachSkillID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convEduMSTRGiftedClsCase_Base.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convEduMSTRGiftedClsCase_Base.TeachSkillID);
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.TeachSkillID) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.TeachSkillID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetSkillTypeName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convEduMSTRGiftedClsCase_Base.SkillTypeName);
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.SkillTypeName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.SkillTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.SkillTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetTeachSkillName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convEduMSTRGiftedClsCase_Base.TeachSkillName);
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.TeachSkillName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.TeachSkillName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetTeachSkillTheory(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convEduMSTRGiftedClsCase_Base.TeachSkillTheory);
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.TeachSkillTheory) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.TeachSkillTheory, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetTeachSkillOperMethod(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod);
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_SkillType(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convEduMSTRGiftedClsCase_Base.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convEduMSTRGiftedClsCase_Base.id_SkillType);
objvEduMSTRGiftedClsCase_BaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_SkillType) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_SkillType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_SkillType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetSkillTypeID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convEduMSTRGiftedClsCase_Base.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convEduMSTRGiftedClsCase_Base.SkillTypeID);
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.SkillTypeID) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.SkillTypeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.SkillTypeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetCaseLevelId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convEduMSTRGiftedClsCase_Base.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convEduMSTRGiftedClsCase_Base.CaseLevelId);
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.CaseLevelId) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.CaseLevelId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CaseLevelId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetCaseLevelName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convEduMSTRGiftedClsCase_Base.CaseLevelName);
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.CaseLevelName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.CaseLevelName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CaseLevelName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetDocFile(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convEduMSTRGiftedClsCase_Base.DocFile);
objvEduMSTRGiftedClsCase_BaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.DocFile) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.DocFile, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.DocFile] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIsNeedGeneWord(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IsNeedGeneWord) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IsNeedGeneWord, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetWordCreateDate(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convEduMSTRGiftedClsCase_Base.WordCreateDate);
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.WordCreateDate) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.WordCreateDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.WordCreateDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIsVisible(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IsVisible) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IsVisible, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IsVisible] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseText(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseText, 8000, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText);
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = strEduMSTRGiftedClsCaseText; //教育硕士优课案例文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetOwnerId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convEduMSTRGiftedClsCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convEduMSTRGiftedClsCase_Base.OwnerId);
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.OwnerId) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.OwnerId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.OwnerId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStuName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convEduMSTRGiftedClsCase_Base.StuName);
objvEduMSTRGiftedClsCase_BaseEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.StuName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.StuName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStuID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convEduMSTRGiftedClsCase_Base.StuID);
objvEduMSTRGiftedClsCase_BaseEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.StuID) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.StuID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetSexDesc(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convEduMSTRGiftedClsCase_Base.SexDesc);
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.SexDesc) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.SexDesc, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.SexDesc] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStuTypeID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStuTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeID, 4, convEduMSTRGiftedClsCase_Base.StuTypeID);
clsCheckSql.CheckFieldForeignKey(strStuTypeID, 4, convEduMSTRGiftedClsCase_Base.StuTypeID);
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = strStuTypeID; //学生类别ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.StuTypeID) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.StuTypeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuTypeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStuTypeDesc(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convEduMSTRGiftedClsCase_Base.StuTypeDesc);
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.StuTypeDesc) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.StuTypeDesc, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuTypeDesc] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_XzCollege(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convEduMSTRGiftedClsCase_Base.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convEduMSTRGiftedClsCase_Base.id_XzCollege);
objvEduMSTRGiftedClsCase_BaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_XzCollege) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_XzCollege, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_XzCollege] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetCollegeID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convEduMSTRGiftedClsCase_Base.CollegeID);
objvEduMSTRGiftedClsCase_BaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.CollegeID) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.CollegeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CollegeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetCollegeName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convEduMSTRGiftedClsCase_Base.CollegeName);
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.CollegeName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.CollegeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CollegeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetCollegeNameA(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convEduMSTRGiftedClsCase_Base.CollegeNameA);
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.CollegeNameA) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.CollegeNameA, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CollegeNameA] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_XzMajor(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convEduMSTRGiftedClsCase_Base.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convEduMSTRGiftedClsCase_Base.id_XzMajor);
objvEduMSTRGiftedClsCase_BaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_XzMajor) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_XzMajor, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_XzMajor] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetMajorName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convEduMSTRGiftedClsCase_Base.MajorName);
objvEduMSTRGiftedClsCase_BaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.MajorName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.MajorName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.MajorName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN Setid_GradeBase(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convEduMSTRGiftedClsCase_Base.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convEduMSTRGiftedClsCase_Base.id_GradeBase);
objvEduMSTRGiftedClsCase_BaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.id_GradeBase) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.id_GradeBase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_GradeBase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetGradeBaseName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convEduMSTRGiftedClsCase_Base.GradeBaseName);
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.GradeBaseName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.GradeBaseName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.GradeBaseName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStuCardNo(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convEduMSTRGiftedClsCase_Base.StuCardNo);
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.StuCardNo) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.StuCardNo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuCardNo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEnrollmentDate(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convEduMSTRGiftedClsCase_Base.EnrollmentDate);
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.EnrollmentDate) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.EnrollmentDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EnrollmentDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIsDualVideo(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IsDualVideo) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IsDualVideo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IsDualVideo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetUserTypeId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convEduMSTRGiftedClsCase_Base.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convEduMSTRGiftedClsCase_Base.UserTypeId);
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.UserTypeId) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.UserTypeId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.UserTypeId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetRecommendedDegreeId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.RecommendedDegreeId) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.RecommendedDegreeId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetRecommendedDegreeName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convEduMSTRGiftedClsCase_Base.RecommendedDegreeName);
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.RecommendedDegreeName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.RecommendedDegreeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetftpFileType(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convEduMSTRGiftedClsCase_Base.ftpFileType);
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.ftpFileType) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.ftpFileType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.ftpFileType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetVideoUrl(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convEduMSTRGiftedClsCase_Base.VideoUrl);
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.VideoUrl) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.VideoUrl, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.VideoUrl] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetVideoPath(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convEduMSTRGiftedClsCase_Base.VideoPath);
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.VideoPath) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.VideoPath, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.VideoPath] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetResErrMsg(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convEduMSTRGiftedClsCase_Base.ResErrMsg);
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.ResErrMsg) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.ResErrMsg, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.ResErrMsg] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetResourceNum(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, int intResourceNum, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = intResourceNum; //资源数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.ResourceNum) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.ResourceNum, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.ResourceNum] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetMemo(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convEduMSTRGiftedClsCase_Base.Memo);
objvEduMSTRGiftedClsCase_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.Memo) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.Memo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.Memo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetBrowseCount4Case(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.BrowseCount4Case) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.BrowseCount4Case, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetOwnerName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convEduMSTRGiftedClsCase_Base.OwnerName);
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.OwnerName) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.OwnerName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.OwnerName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetOwnerNameWithId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convEduMSTRGiftedClsCase_Base.OwnerNameWithId);
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.OwnerNameWithId) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.OwnerNameWithId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_Base_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase) == true)
{
string strComparisonOp_id_EduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase, objvEduMSTRGiftedClsCase_Base_Cond.id_EduMSTRGiftedClsCase, strComparisonOp_id_EduMSTRGiftedClsCase);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID, objvEduMSTRGiftedClsCase_Base_Cond.EduMSTRGiftedClsCaseID, strComparisonOp_EduMSTRGiftedClsCaseID);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName, objvEduMSTRGiftedClsCase_Base_Cond.EduMSTRGiftedClsCaseName, strComparisonOp_EduMSTRGiftedClsCaseName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme, objvEduMSTRGiftedClsCase_Base_Cond.EduMSTRGiftedClsCaseTheme, strComparisonOp_EduMSTRGiftedClsCaseTheme);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate, objvEduMSTRGiftedClsCase_Base_Cond.EduMSTRGiftedClsCaseDate, strComparisonOp_EduMSTRGiftedClsCaseDate);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime, objvEduMSTRGiftedClsCase_Base_Cond.EduMSTRGiftedClsCaseTime, strComparisonOp_EduMSTRGiftedClsCaseTime);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn, objvEduMSTRGiftedClsCase_Base_Cond.EduMSTRGiftedClsCaseDateIn, strComparisonOp_EduMSTRGiftedClsCaseDateIn);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_StudyLevel, objvEduMSTRGiftedClsCase_Base_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StudyLevelName, objvEduMSTRGiftedClsCase_Base_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_TeachingPlan, objvEduMSTRGiftedClsCase_Base_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn, objvEduMSTRGiftedClsCase_Base_Cond.EduMSTRGiftedClsCaseTimeIn, strComparisonOp_EduMSTRGiftedClsCaseTimeIn);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType) == true)
{
string strComparisonOp_id_EduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType, objvEduMSTRGiftedClsCase_Base_Cond.id_EduMSTRGiftedClsCaseType, strComparisonOp_id_EduMSTRGiftedClsCaseType);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName, objvEduMSTRGiftedClsCase_Base_Cond.EduMSTRGiftedClsCaseTypeName, strComparisonOp_EduMSTRGiftedClsCaseTypeName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.Id_CaseType, objvEduMSTRGiftedClsCase_Base_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_Discipline, objvEduMSTRGiftedClsCase_Base_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.DisciplineID, objvEduMSTRGiftedClsCase_Base_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.DisciplineName, objvEduMSTRGiftedClsCase_Base_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion, objvEduMSTRGiftedClsCase_Base_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.senateGaugeVersionID, objvEduMSTRGiftedClsCase_Base_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.senateGaugeVersionName, objvEduMSTRGiftedClsCase_Base_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore, objvEduMSTRGiftedClsCase_Base_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Base.VersionNo, objvEduMSTRGiftedClsCase_Base_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_TeachSkill, objvEduMSTRGiftedClsCase_Base_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.TeachSkillID, objvEduMSTRGiftedClsCase_Base_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.SkillTypeName, objvEduMSTRGiftedClsCase_Base_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.TeachSkillName, objvEduMSTRGiftedClsCase_Base_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.TeachSkillTheory, objvEduMSTRGiftedClsCase_Base_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod, objvEduMSTRGiftedClsCase_Base_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_SkillType, objvEduMSTRGiftedClsCase_Base_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.SkillTypeID, objvEduMSTRGiftedClsCase_Base_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.CaseLevelId, objvEduMSTRGiftedClsCase_Base_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.CaseLevelName, objvEduMSTRGiftedClsCase_Base_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.DocFile) == true)
{
string strComparisonOp_DocFile = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.DocFile, objvEduMSTRGiftedClsCase_Base_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.IsNeedGeneWord) == true)
{
if (objvEduMSTRGiftedClsCase_Base_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Base.IsNeedGeneWord);
}
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.WordCreateDate, objvEduMSTRGiftedClsCase_Base_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.IsVisible) == true)
{
if (objvEduMSTRGiftedClsCase_Base_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Base.IsVisible);
}
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText, objvEduMSTRGiftedClsCase_Base_Cond.EduMSTRGiftedClsCaseText, strComparisonOp_EduMSTRGiftedClsCaseText);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.OwnerId, objvEduMSTRGiftedClsCase_Base_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.StuName) == true)
{
string strComparisonOp_StuName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StuName, objvEduMSTRGiftedClsCase_Base_Cond.StuName, strComparisonOp_StuName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.StuID) == true)
{
string strComparisonOp_StuID = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StuID, objvEduMSTRGiftedClsCase_Base_Cond.StuID, strComparisonOp_StuID);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.SexDesc, objvEduMSTRGiftedClsCase_Base_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.StuTypeID) == true)
{
string strComparisonOp_StuTypeID = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StuTypeID, objvEduMSTRGiftedClsCase_Base_Cond.StuTypeID, strComparisonOp_StuTypeID);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StuTypeDesc, objvEduMSTRGiftedClsCase_Base_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_XzCollege, objvEduMSTRGiftedClsCase_Base_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.CollegeID, objvEduMSTRGiftedClsCase_Base_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.CollegeName, objvEduMSTRGiftedClsCase_Base_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.CollegeNameA, objvEduMSTRGiftedClsCase_Base_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_XzMajor, objvEduMSTRGiftedClsCase_Base_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.MajorName) == true)
{
string strComparisonOp_MajorName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.MajorName, objvEduMSTRGiftedClsCase_Base_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.id_GradeBase, objvEduMSTRGiftedClsCase_Base_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.GradeBaseName, objvEduMSTRGiftedClsCase_Base_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StuCardNo, objvEduMSTRGiftedClsCase_Base_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EnrollmentDate, objvEduMSTRGiftedClsCase_Base_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.IsDualVideo) == true)
{
if (objvEduMSTRGiftedClsCase_Base_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Base.IsDualVideo);
}
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.UserTypeId, objvEduMSTRGiftedClsCase_Base_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.RecommendedDegreeId, objvEduMSTRGiftedClsCase_Base_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.RecommendedDegreeName, objvEduMSTRGiftedClsCase_Base_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.ftpFileType, objvEduMSTRGiftedClsCase_Base_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.VideoUrl, objvEduMSTRGiftedClsCase_Base_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.VideoPath, objvEduMSTRGiftedClsCase_Base_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.ResErrMsg, objvEduMSTRGiftedClsCase_Base_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.ResourceNum) == true)
{
string strComparisonOp_ResourceNum = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.ResourceNum];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Base.ResourceNum, objvEduMSTRGiftedClsCase_Base_Cond.ResourceNum, strComparisonOp_ResourceNum);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.Memo) == true)
{
string strComparisonOp_Memo = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.Memo, objvEduMSTRGiftedClsCase_Base_Cond.Memo, strComparisonOp_Memo);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Base.BrowseCount4Case, objvEduMSTRGiftedClsCase_Base_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.OwnerName, objvEduMSTRGiftedClsCase_Base_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvEduMSTRGiftedClsCase_Base_Cond.IsUpdated(convEduMSTRGiftedClsCase_Base.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvEduMSTRGiftedClsCase_Base_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.OwnerNameWithId, objvEduMSTRGiftedClsCase_Base_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教育硕士优课案例_Base(vEduMSTRGiftedClsCase_Base)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvEduMSTRGiftedClsCase_BaseWApi
{
private static readonly string mstrApiControllerName = "vEduMSTRGiftedClsCase_BaseApi";

 public clsvEduMSTRGiftedClsCase_BaseWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教育硕士优课案例_Base]...","0");
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase); 
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = clsvEduMSTRGiftedClsCase_BaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN()
{
id_EduMSTRGiftedClsCase = "0",
EduMSTRGiftedClsCaseName = "选[v教育硕士优课案例_Base]..."
};
arrObjLst.Insert(0, objvEduMSTRGiftedClsCase_BaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase;
objComboBox.DisplayMember = convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_EduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN GetObjByid_EduMSTRGiftedClsCase(string strid_EduMSTRGiftedClsCase)
{
string strAction = "GetObjByid_EduMSTRGiftedClsCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = null;
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
objvEduMSTRGiftedClsCase_BaseEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCase_BaseEN;
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
public static clsvEduMSTRGiftedClsCase_BaseEN GetObjByid_EduMSTRGiftedClsCase_WA_Cache(string strid_EduMSTRGiftedClsCase)
{
string strAction = "GetObjByid_EduMSTRGiftedClsCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = null;
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
objvEduMSTRGiftedClsCase_BaseEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCase_BaseEN;
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
public static clsvEduMSTRGiftedClsCase_BaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = null;
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
objvEduMSTRGiftedClsCase_BaseEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCase_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCase_BaseEN;
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
public static clsvEduMSTRGiftedClsCase_BaseEN GetObjByid_EduMSTRGiftedClsCase_Cache(string strid_EduMSTRGiftedClsCase)
{
if (string.IsNullOrEmpty(strid_EduMSTRGiftedClsCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Sel =
from objvEduMSTRGiftedClsCase_BaseEN in arrvEduMSTRGiftedClsCase_BaseObjLst_Cache
where objvEduMSTRGiftedClsCase_BaseEN.id_EduMSTRGiftedClsCase == strid_EduMSTRGiftedClsCase
select objvEduMSTRGiftedClsCase_BaseEN;
if (arrvEduMSTRGiftedClsCase_BaseObjLst_Sel.Count() == 0)
{
   clsvEduMSTRGiftedClsCase_BaseEN obj = clsvEduMSTRGiftedClsCase_BaseWApi.GetObjByid_EduMSTRGiftedClsCase(strid_EduMSTRGiftedClsCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvEduMSTRGiftedClsCase_BaseObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Sel1 =
from objvEduMSTRGiftedClsCase_BaseEN in arrvEduMSTRGiftedClsCase_BaseObjLst_Cache
where objvEduMSTRGiftedClsCase_BaseEN.id_EduMSTRGiftedClsCase == strid_EduMSTRGiftedClsCase
select objvEduMSTRGiftedClsCase_BaseEN;
List <clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Sel = new List<clsvEduMSTRGiftedClsCase_BaseEN>();
foreach (clsvEduMSTRGiftedClsCase_BaseEN obj in arrvEduMSTRGiftedClsCase_BaseObjLst_Sel1)
{
arrvEduMSTRGiftedClsCase_BaseObjLst_Sel.Add(obj);
}
if (arrvEduMSTRGiftedClsCase_BaseObjLst_Sel.Count > 0)
{
return arrvEduMSTRGiftedClsCase_BaseObjLst_Sel[0].EduMSTRGiftedClsCaseName;
}
string strErrMsgForGetObjById = string.Format("在vEduMSTRGiftedClsCase_Base对象缓存列表中,找不到记录[id_EduMSTRGiftedClsCase = {0}](函数:{1})", strid_EduMSTRGiftedClsCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvEduMSTRGiftedClsCase_BaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Sel1 =
from objvEduMSTRGiftedClsCase_BaseEN in arrvEduMSTRGiftedClsCase_BaseObjLst_Cache
where objvEduMSTRGiftedClsCase_BaseEN.id_EduMSTRGiftedClsCase == strid_EduMSTRGiftedClsCase
select objvEduMSTRGiftedClsCase_BaseEN;
List <clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Sel = new List<clsvEduMSTRGiftedClsCase_BaseEN>();
foreach (clsvEduMSTRGiftedClsCase_BaseEN obj in arrvEduMSTRGiftedClsCase_BaseObjLst_Sel1)
{
arrvEduMSTRGiftedClsCase_BaseObjLst_Sel.Add(obj);
}
if (arrvEduMSTRGiftedClsCase_BaseObjLst_Sel.Count > 0)
{
return arrvEduMSTRGiftedClsCase_BaseObjLst_Sel[0].EduMSTRGiftedClsCaseName;
}
string strErrMsgForGetObjById = string.Format("在vEduMSTRGiftedClsCase_Base对象缓存列表中,找不到记录的相关名称[id_EduMSTRGiftedClsCase = {0}](函数:{1})", strid_EduMSTRGiftedClsCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvEduMSTRGiftedClsCase_BaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLst(string strWhereCond)
{
 List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstById_EduMSTRGiftedClsCaseLst(List<string> arrId_EduMSTRGiftedClsCase)
{
 List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstById_EduMSTRGiftedClsCaseLst_Cache(List<string> arrId_EduMSTRGiftedClsCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Sel =
from objvEduMSTRGiftedClsCase_BaseEN in arrvEduMSTRGiftedClsCase_BaseObjLst_Cache
where arrId_EduMSTRGiftedClsCase.Contains(objvEduMSTRGiftedClsCase_BaseEN.id_EduMSTRGiftedClsCase)
select objvEduMSTRGiftedClsCase_BaseEN;
return arrvEduMSTRGiftedClsCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstById_EduMSTRGiftedClsCaseLst_WA_Cache(List<string> arrId_EduMSTRGiftedClsCase)
{
 List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvEduMSTRGiftedClsCase_BaseENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseENS, clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseENT)
{
try
{
objvEduMSTRGiftedClsCase_BaseENT.id_EduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_BaseENS.id_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objvEduMSTRGiftedClsCase_BaseENT.id_StudyLevel = objvEduMSTRGiftedClsCase_BaseENS.id_StudyLevel; //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseENT.StudyLevelName = objvEduMSTRGiftedClsCase_BaseENS.StudyLevelName; //学段名称
objvEduMSTRGiftedClsCase_BaseENT.id_TeachingPlan = objvEduMSTRGiftedClsCase_BaseENS.id_TeachingPlan; //教案流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objvEduMSTRGiftedClsCase_BaseENT.id_EduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_BaseENS.id_EduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseENT.Id_CaseType = objvEduMSTRGiftedClsCase_BaseENS.Id_CaseType; //案例类型流水号
objvEduMSTRGiftedClsCase_BaseENT.id_Discipline = objvEduMSTRGiftedClsCase_BaseENS.id_Discipline; //学科流水号
objvEduMSTRGiftedClsCase_BaseENT.DisciplineID = objvEduMSTRGiftedClsCase_BaseENS.DisciplineID; //学科ID
objvEduMSTRGiftedClsCase_BaseENT.DisciplineName = objvEduMSTRGiftedClsCase_BaseENS.DisciplineName; //学科名称
objvEduMSTRGiftedClsCase_BaseENT.id_SenateGaugeVersion = objvEduMSTRGiftedClsCase_BaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionID = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionName = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseENT.VersionNo = objvEduMSTRGiftedClsCase_BaseENS.VersionNo; //版本号
objvEduMSTRGiftedClsCase_BaseENT.id_TeachSkill = objvEduMSTRGiftedClsCase_BaseENS.id_TeachSkill; //教学技能流水号
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillID = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillID; //教学技能ID
objvEduMSTRGiftedClsCase_BaseENT.SkillTypeName = objvEduMSTRGiftedClsCase_BaseENS.SkillTypeName; //技能类型名称
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillName = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillName; //教学技能名称
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillTheory = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillOperMethod = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseENT.id_SkillType = objvEduMSTRGiftedClsCase_BaseENS.id_SkillType; //技能类型流水号
objvEduMSTRGiftedClsCase_BaseENT.SkillTypeID = objvEduMSTRGiftedClsCase_BaseENS.SkillTypeID; //技能类型ID
objvEduMSTRGiftedClsCase_BaseENT.CaseLevelId = objvEduMSTRGiftedClsCase_BaseENS.CaseLevelId; //课例等级Id
objvEduMSTRGiftedClsCase_BaseENT.CaseLevelName = objvEduMSTRGiftedClsCase_BaseENS.CaseLevelName; //案例等级名称
objvEduMSTRGiftedClsCase_BaseENT.DocFile = objvEduMSTRGiftedClsCase_BaseENS.DocFile; //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseENT.IsNeedGeneWord = objvEduMSTRGiftedClsCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseENT.WordCreateDate = objvEduMSTRGiftedClsCase_BaseENS.WordCreateDate; //Word生成日期
objvEduMSTRGiftedClsCase_BaseENT.IsVisible = objvEduMSTRGiftedClsCase_BaseENS.IsVisible; //是否显示
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseENT.OwnerId = objvEduMSTRGiftedClsCase_BaseENS.OwnerId; //拥有者Id
objvEduMSTRGiftedClsCase_BaseENT.StuName = objvEduMSTRGiftedClsCase_BaseENS.StuName; //姓名
objvEduMSTRGiftedClsCase_BaseENT.StuID = objvEduMSTRGiftedClsCase_BaseENS.StuID; //学号
objvEduMSTRGiftedClsCase_BaseENT.SexDesc = objvEduMSTRGiftedClsCase_BaseENS.SexDesc; //性别名称
objvEduMSTRGiftedClsCase_BaseENT.StuTypeID = objvEduMSTRGiftedClsCase_BaseENS.StuTypeID; //学生类别ID
objvEduMSTRGiftedClsCase_BaseENT.StuTypeDesc = objvEduMSTRGiftedClsCase_BaseENS.StuTypeDesc; //学生类别名称
objvEduMSTRGiftedClsCase_BaseENT.id_XzCollege = objvEduMSTRGiftedClsCase_BaseENS.id_XzCollege; //学院流水号
objvEduMSTRGiftedClsCase_BaseENT.CollegeID = objvEduMSTRGiftedClsCase_BaseENS.CollegeID; //学院ID
objvEduMSTRGiftedClsCase_BaseENT.CollegeName = objvEduMSTRGiftedClsCase_BaseENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCase_BaseENT.CollegeNameA = objvEduMSTRGiftedClsCase_BaseENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCase_BaseENT.id_XzMajor = objvEduMSTRGiftedClsCase_BaseENS.id_XzMajor; //专业流水号
objvEduMSTRGiftedClsCase_BaseENT.MajorName = objvEduMSTRGiftedClsCase_BaseENS.MajorName; //专业名称
objvEduMSTRGiftedClsCase_BaseENT.id_GradeBase = objvEduMSTRGiftedClsCase_BaseENS.id_GradeBase; //年级流水号
objvEduMSTRGiftedClsCase_BaseENT.GradeBaseName = objvEduMSTRGiftedClsCase_BaseENS.GradeBaseName; //年级名称
objvEduMSTRGiftedClsCase_BaseENT.StuCardNo = objvEduMSTRGiftedClsCase_BaseENS.StuCardNo; //学生证号
objvEduMSTRGiftedClsCase_BaseENT.EnrollmentDate = objvEduMSTRGiftedClsCase_BaseENS.EnrollmentDate; //入校日期
objvEduMSTRGiftedClsCase_BaseENT.IsDualVideo = objvEduMSTRGiftedClsCase_BaseENS.IsDualVideo; //是否双视频
objvEduMSTRGiftedClsCase_BaseENT.UserTypeId = objvEduMSTRGiftedClsCase_BaseENS.UserTypeId; //用户类型Id
objvEduMSTRGiftedClsCase_BaseENT.RecommendedDegreeId = objvEduMSTRGiftedClsCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvEduMSTRGiftedClsCase_BaseENT.RecommendedDegreeName = objvEduMSTRGiftedClsCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvEduMSTRGiftedClsCase_BaseENT.ftpFileType = objvEduMSTRGiftedClsCase_BaseENS.ftpFileType; //ftp文件类型
objvEduMSTRGiftedClsCase_BaseENT.VideoUrl = objvEduMSTRGiftedClsCase_BaseENS.VideoUrl; //视频Url
objvEduMSTRGiftedClsCase_BaseENT.VideoPath = objvEduMSTRGiftedClsCase_BaseENS.VideoPath; //视频目录
objvEduMSTRGiftedClsCase_BaseENT.ResErrMsg = objvEduMSTRGiftedClsCase_BaseENS.ResErrMsg; //资源错误信息
objvEduMSTRGiftedClsCase_BaseENT.ResourceNum = objvEduMSTRGiftedClsCase_BaseENS.ResourceNum; //资源数
objvEduMSTRGiftedClsCase_BaseENT.Memo = objvEduMSTRGiftedClsCase_BaseENS.Memo; //备注
objvEduMSTRGiftedClsCase_BaseENT.BrowseCount4Case = objvEduMSTRGiftedClsCase_BaseENS.BrowseCount4Case; //课例浏览次数
objvEduMSTRGiftedClsCase_BaseENT.OwnerName = objvEduMSTRGiftedClsCase_BaseENS.OwnerName; //拥有者姓名
objvEduMSTRGiftedClsCase_BaseENT.OwnerNameWithId = objvEduMSTRGiftedClsCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
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
public static DataTable ToDataTable(List<clsvEduMSTRGiftedClsCase_BaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvEduMSTRGiftedClsCase_BaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvEduMSTRGiftedClsCase_BaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvEduMSTRGiftedClsCase_BaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvEduMSTRGiftedClsCase_BaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvEduMSTRGiftedClsCase_BaseEN.AttributeName)
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
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvEduMSTRGiftedClsCase_BaseObjLst_Cache == null)
//{
//arrvEduMSTRGiftedClsCase_BaseObjLst_Cache = await clsvEduMSTRGiftedClsCase_BaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName_S);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvEduMSTRGiftedClsCase_BaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.StuTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.ResourceNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Base.OwnerNameWithId, Type.GetType("System.String"));
foreach (clsvEduMSTRGiftedClsCase_BaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase] = objInFor[convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCase];
objDR[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID] = objInFor[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID];
objDR[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName] = objInFor[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName];
objDR[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] = objInFor[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme];
objDR[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] = objInFor[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate];
objDR[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] = objInFor[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime];
objDR[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] = objInFor[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn];
objDR[convEduMSTRGiftedClsCase_Base.id_StudyLevel] = objInFor[convEduMSTRGiftedClsCase_Base.id_StudyLevel];
objDR[convEduMSTRGiftedClsCase_Base.StudyLevelName] = objInFor[convEduMSTRGiftedClsCase_Base.StudyLevelName];
objDR[convEduMSTRGiftedClsCase_Base.id_TeachingPlan] = objInFor[convEduMSTRGiftedClsCase_Base.id_TeachingPlan];
objDR[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] = objInFor[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn];
objDR[convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType] = objInFor[convEduMSTRGiftedClsCase_Base.id_EduMSTRGiftedClsCaseType];
objDR[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] = objInFor[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName];
objDR[convEduMSTRGiftedClsCase_Base.Id_CaseType] = objInFor[convEduMSTRGiftedClsCase_Base.Id_CaseType];
objDR[convEduMSTRGiftedClsCase_Base.id_Discipline] = objInFor[convEduMSTRGiftedClsCase_Base.id_Discipline];
objDR[convEduMSTRGiftedClsCase_Base.DisciplineID] = objInFor[convEduMSTRGiftedClsCase_Base.DisciplineID];
objDR[convEduMSTRGiftedClsCase_Base.DisciplineName] = objInFor[convEduMSTRGiftedClsCase_Base.DisciplineName];
objDR[convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion] = objInFor[convEduMSTRGiftedClsCase_Base.id_SenateGaugeVersion];
objDR[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] = objInFor[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID];
objDR[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] = objInFor[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName];
objDR[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] = objInFor[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore];
objDR[convEduMSTRGiftedClsCase_Base.VersionNo] = objInFor[convEduMSTRGiftedClsCase_Base.VersionNo];
objDR[convEduMSTRGiftedClsCase_Base.id_TeachSkill] = objInFor[convEduMSTRGiftedClsCase_Base.id_TeachSkill];
objDR[convEduMSTRGiftedClsCase_Base.TeachSkillID] = objInFor[convEduMSTRGiftedClsCase_Base.TeachSkillID];
objDR[convEduMSTRGiftedClsCase_Base.SkillTypeName] = objInFor[convEduMSTRGiftedClsCase_Base.SkillTypeName];
objDR[convEduMSTRGiftedClsCase_Base.TeachSkillName] = objInFor[convEduMSTRGiftedClsCase_Base.TeachSkillName];
objDR[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] = objInFor[convEduMSTRGiftedClsCase_Base.TeachSkillTheory];
objDR[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] = objInFor[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod];
objDR[convEduMSTRGiftedClsCase_Base.id_SkillType] = objInFor[convEduMSTRGiftedClsCase_Base.id_SkillType];
objDR[convEduMSTRGiftedClsCase_Base.SkillTypeID] = objInFor[convEduMSTRGiftedClsCase_Base.SkillTypeID];
objDR[convEduMSTRGiftedClsCase_Base.CaseLevelId] = objInFor[convEduMSTRGiftedClsCase_Base.CaseLevelId];
objDR[convEduMSTRGiftedClsCase_Base.CaseLevelName] = objInFor[convEduMSTRGiftedClsCase_Base.CaseLevelName];
objDR[convEduMSTRGiftedClsCase_Base.DocFile] = objInFor[convEduMSTRGiftedClsCase_Base.DocFile];
objDR[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord] = objInFor[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord];
objDR[convEduMSTRGiftedClsCase_Base.WordCreateDate] = objInFor[convEduMSTRGiftedClsCase_Base.WordCreateDate];
objDR[convEduMSTRGiftedClsCase_Base.IsVisible] = objInFor[convEduMSTRGiftedClsCase_Base.IsVisible];
objDR[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] = objInFor[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText];
objDR[convEduMSTRGiftedClsCase_Base.OwnerId] = objInFor[convEduMSTRGiftedClsCase_Base.OwnerId];
objDR[convEduMSTRGiftedClsCase_Base.StuName] = objInFor[convEduMSTRGiftedClsCase_Base.StuName];
objDR[convEduMSTRGiftedClsCase_Base.StuID] = objInFor[convEduMSTRGiftedClsCase_Base.StuID];
objDR[convEduMSTRGiftedClsCase_Base.SexDesc] = objInFor[convEduMSTRGiftedClsCase_Base.SexDesc];
objDR[convEduMSTRGiftedClsCase_Base.StuTypeID] = objInFor[convEduMSTRGiftedClsCase_Base.StuTypeID];
objDR[convEduMSTRGiftedClsCase_Base.StuTypeDesc] = objInFor[convEduMSTRGiftedClsCase_Base.StuTypeDesc];
objDR[convEduMSTRGiftedClsCase_Base.id_XzCollege] = objInFor[convEduMSTRGiftedClsCase_Base.id_XzCollege];
objDR[convEduMSTRGiftedClsCase_Base.CollegeID] = objInFor[convEduMSTRGiftedClsCase_Base.CollegeID];
objDR[convEduMSTRGiftedClsCase_Base.CollegeName] = objInFor[convEduMSTRGiftedClsCase_Base.CollegeName];
objDR[convEduMSTRGiftedClsCase_Base.CollegeNameA] = objInFor[convEduMSTRGiftedClsCase_Base.CollegeNameA];
objDR[convEduMSTRGiftedClsCase_Base.id_XzMajor] = objInFor[convEduMSTRGiftedClsCase_Base.id_XzMajor];
objDR[convEduMSTRGiftedClsCase_Base.MajorName] = objInFor[convEduMSTRGiftedClsCase_Base.MajorName];
objDR[convEduMSTRGiftedClsCase_Base.id_GradeBase] = objInFor[convEduMSTRGiftedClsCase_Base.id_GradeBase];
objDR[convEduMSTRGiftedClsCase_Base.GradeBaseName] = objInFor[convEduMSTRGiftedClsCase_Base.GradeBaseName];
objDR[convEduMSTRGiftedClsCase_Base.StuCardNo] = objInFor[convEduMSTRGiftedClsCase_Base.StuCardNo];
objDR[convEduMSTRGiftedClsCase_Base.EnrollmentDate] = objInFor[convEduMSTRGiftedClsCase_Base.EnrollmentDate];
objDR[convEduMSTRGiftedClsCase_Base.IsDualVideo] = objInFor[convEduMSTRGiftedClsCase_Base.IsDualVideo];
objDR[convEduMSTRGiftedClsCase_Base.UserTypeId] = objInFor[convEduMSTRGiftedClsCase_Base.UserTypeId];
objDR[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId] = objInFor[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId];
objDR[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] = objInFor[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName];
objDR[convEduMSTRGiftedClsCase_Base.ftpFileType] = objInFor[convEduMSTRGiftedClsCase_Base.ftpFileType];
objDR[convEduMSTRGiftedClsCase_Base.VideoUrl] = objInFor[convEduMSTRGiftedClsCase_Base.VideoUrl];
objDR[convEduMSTRGiftedClsCase_Base.VideoPath] = objInFor[convEduMSTRGiftedClsCase_Base.VideoPath];
objDR[convEduMSTRGiftedClsCase_Base.ResErrMsg] = objInFor[convEduMSTRGiftedClsCase_Base.ResErrMsg];
objDR[convEduMSTRGiftedClsCase_Base.ResourceNum] = objInFor[convEduMSTRGiftedClsCase_Base.ResourceNum];
objDR[convEduMSTRGiftedClsCase_Base.Memo] = objInFor[convEduMSTRGiftedClsCase_Base.Memo];
objDR[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] = objInFor[convEduMSTRGiftedClsCase_Base.BrowseCount4Case];
objDR[convEduMSTRGiftedClsCase_Base.OwnerName] = objInFor[convEduMSTRGiftedClsCase_Base.OwnerName];
objDR[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] = objInFor[convEduMSTRGiftedClsCase_Base.OwnerNameWithId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}