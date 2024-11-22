
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEduMSTRGiftedClsCaseWApi
 表名:EduMSTRGiftedClsCase(01120379)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:26
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
public static class clsEduMSTRGiftedClsCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN Setid_EduMSTRGiftedClsCase(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strid_EduMSTRGiftedClsCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduMSTRGiftedClsCase, 8, conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase);
clsCheckSql.CheckFieldForeignKey(strid_EduMSTRGiftedClsCase, 8, conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase);
objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase = strid_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseID(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduMSTRGiftedClsCaseID, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseID, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseID, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = strEduMSTRGiftedClsCaseID; //教育硕士优课案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseName(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduMSTRGiftedClsCaseName, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseName, 100, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = strEduMSTRGiftedClsCaseName; //教育硕士优课案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTheme(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTheme, 200, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = strEduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseDate(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDate, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDate, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = strEduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTime(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTime, 6, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTime, 6, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = strEduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseDateIn(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDateIn, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDateIn, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = strEduMSTRGiftedClsCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN Setid_StudyLevel(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, conEduMSTRGiftedClsCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conEduMSTRGiftedClsCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conEduMSTRGiftedClsCase.id_StudyLevel);
objEduMSTRGiftedClsCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.id_StudyLevel) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.id_StudyLevel, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_StudyLevel] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN Setid_TeachingPlan(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conEduMSTRGiftedClsCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conEduMSTRGiftedClsCase.id_TeachingPlan);
objEduMSTRGiftedClsCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.id_TeachingPlan) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.id_TeachingPlan, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_TeachingPlan] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTimeIn(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTimeIn, 6, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTimeIn, 6, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = strEduMSTRGiftedClsCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN Setid_EduMSTRGiftedClsCaseType(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strid_EduMSTRGiftedClsCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduMSTRGiftedClsCaseType, 4, conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType);
clsCheckSql.CheckFieldForeignKey(strid_EduMSTRGiftedClsCaseType, 4, conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType);
objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCaseType = strid_EduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetId_CaseType(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, conEduMSTRGiftedClsCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, conEduMSTRGiftedClsCase.Id_CaseType);
objEduMSTRGiftedClsCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.Id_CaseType) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.Id_CaseType, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.Id_CaseType] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN Setid_Discipline(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, conEduMSTRGiftedClsCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conEduMSTRGiftedClsCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conEduMSTRGiftedClsCase.id_Discipline);
objEduMSTRGiftedClsCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.id_Discipline) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.id_Discipline, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_Discipline] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetBrowseCount(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objEduMSTRGiftedClsCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.BrowseCount) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.BrowseCount, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.BrowseCount] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN Setid_SenateGaugeVersion(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conEduMSTRGiftedClsCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conEduMSTRGiftedClsCase.id_SenateGaugeVersion);
objEduMSTRGiftedClsCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.id_SenateGaugeVersion) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN Setid_TeachSkill(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, conEduMSTRGiftedClsCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conEduMSTRGiftedClsCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conEduMSTRGiftedClsCase.id_TeachSkill);
objEduMSTRGiftedClsCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.id_TeachSkill) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.id_TeachSkill, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_TeachSkill] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetCaseLevelId(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conEduMSTRGiftedClsCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conEduMSTRGiftedClsCase.CaseLevelId);
objEduMSTRGiftedClsCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.CaseLevelId) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.CaseLevelId, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.CaseLevelId] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetDocFile(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conEduMSTRGiftedClsCase.DocFile);
objEduMSTRGiftedClsCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.DocFile) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.DocFile, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.DocFile] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetIsNeedGeneWord(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objEduMSTRGiftedClsCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.IsNeedGeneWord) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetWordCreateDate(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conEduMSTRGiftedClsCase.WordCreateDate);
objEduMSTRGiftedClsCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.WordCreateDate) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.WordCreateDate, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.WordCreateDate] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetIsVisible(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objEduMSTRGiftedClsCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.IsVisible) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.IsVisible, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.IsVisible] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseText(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseText, 8000, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = strEduMSTRGiftedClsCaseText; //教育硕士优课案例文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetOwnerId(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conEduMSTRGiftedClsCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conEduMSTRGiftedClsCase.OwnerId);
objEduMSTRGiftedClsCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.OwnerId) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.OwnerId, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.OwnerId] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetIsDualVideo(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objEduMSTRGiftedClsCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.IsDualVideo) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.IsDualVideo, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.IsDualVideo] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetUserKindId(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, conEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, conEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, conEduMSTRGiftedClsCase.UserKindId);
objEduMSTRGiftedClsCaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.UserKindId) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.UserKindId, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.UserKindId] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetUserTypeId(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conEduMSTRGiftedClsCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conEduMSTRGiftedClsCase.UserTypeId);
objEduMSTRGiftedClsCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.UserTypeId) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.UserTypeId, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.UserTypeId] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetRecommendedDegreeId(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conEduMSTRGiftedClsCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conEduMSTRGiftedClsCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conEduMSTRGiftedClsCase.RecommendedDegreeId);
objEduMSTRGiftedClsCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.RecommendedDegreeId) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetftpFileType(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conEduMSTRGiftedClsCase.ftpFileType);
objEduMSTRGiftedClsCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.ftpFileType) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.ftpFileType, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.ftpFileType] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetVideoUrl(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conEduMSTRGiftedClsCase.VideoUrl);
objEduMSTRGiftedClsCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.VideoUrl) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.VideoUrl, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.VideoUrl] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetVideoPath(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conEduMSTRGiftedClsCase.VideoPath);
objEduMSTRGiftedClsCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.VideoPath) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.VideoPath, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.VideoPath] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetResErrMsg(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conEduMSTRGiftedClsCase.ResErrMsg);
objEduMSTRGiftedClsCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.ResErrMsg) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.ResErrMsg, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.ResErrMsg] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetResourceNum(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, int intResourceNum, string strComparisonOp="")
	{
objEduMSTRGiftedClsCaseEN.ResourceNum = intResourceNum; //资源数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.ResourceNum) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.ResourceNum, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.ResourceNum] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetUpdDate(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conEduMSTRGiftedClsCase.UpdDate);
objEduMSTRGiftedClsCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.UpdDate) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.UpdDate, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.UpdDate] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetUpdUserId(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conEduMSTRGiftedClsCase.UpdUserId);
objEduMSTRGiftedClsCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.UpdUserId) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.UpdUserId, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.UpdUserId] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEduMSTRGiftedClsCaseEN SetMemo(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conEduMSTRGiftedClsCase.Memo);
objEduMSTRGiftedClsCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(conEduMSTRGiftedClsCase.Memo) == false)
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(conEduMSTRGiftedClsCase.Memo, strComparisonOp);
}
else
{
objEduMSTRGiftedClsCaseEN.dicFldComparisonOp[conEduMSTRGiftedClsCase.Memo] = strComparisonOp;
}
}
return objEduMSTRGiftedClsCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase) == true)
{
string strComparisonOp_id_EduMSTRGiftedClsCase = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase, objEduMSTRGiftedClsCase_Cond.id_EduMSTRGiftedClsCase, strComparisonOp_id_EduMSTRGiftedClsCase);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID, objEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseID, strComparisonOp_EduMSTRGiftedClsCaseID);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName, objEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseName, strComparisonOp_EduMSTRGiftedClsCaseName);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme, objEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseTheme, strComparisonOp_EduMSTRGiftedClsCaseTheme);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate, objEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseDate, strComparisonOp_EduMSTRGiftedClsCaseDate);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime, objEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseTime, strComparisonOp_EduMSTRGiftedClsCaseTime);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn, objEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseDateIn, strComparisonOp_EduMSTRGiftedClsCaseDateIn);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.id_StudyLevel, objEduMSTRGiftedClsCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.id_TeachingPlan, objEduMSTRGiftedClsCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn, objEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseTimeIn, strComparisonOp_EduMSTRGiftedClsCaseTimeIn);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType) == true)
{
string strComparisonOp_id_EduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType, objEduMSTRGiftedClsCase_Cond.id_EduMSTRGiftedClsCaseType, strComparisonOp_id_EduMSTRGiftedClsCaseType);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.Id_CaseType, objEduMSTRGiftedClsCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.id_Discipline, objEduMSTRGiftedClsCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conEduMSTRGiftedClsCase.BrowseCount, objEduMSTRGiftedClsCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.id_SenateGaugeVersion, objEduMSTRGiftedClsCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.id_TeachSkill, objEduMSTRGiftedClsCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.CaseLevelId, objEduMSTRGiftedClsCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.DocFile) == true)
{
string strComparisonOp_DocFile = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.DocFile, objEduMSTRGiftedClsCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.IsNeedGeneWord) == true)
{
if (objEduMSTRGiftedClsCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conEduMSTRGiftedClsCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conEduMSTRGiftedClsCase.IsNeedGeneWord);
}
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.WordCreateDate, objEduMSTRGiftedClsCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.IsVisible) == true)
{
if (objEduMSTRGiftedClsCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conEduMSTRGiftedClsCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conEduMSTRGiftedClsCase.IsVisible);
}
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText, objEduMSTRGiftedClsCase_Cond.EduMSTRGiftedClsCaseText, strComparisonOp_EduMSTRGiftedClsCaseText);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.OwnerId, objEduMSTRGiftedClsCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.IsDualVideo) == true)
{
if (objEduMSTRGiftedClsCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conEduMSTRGiftedClsCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conEduMSTRGiftedClsCase.IsDualVideo);
}
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.UserKindId) == true)
{
string strComparisonOp_UserKindId = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.UserKindId, objEduMSTRGiftedClsCase_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.UserTypeId, objEduMSTRGiftedClsCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.RecommendedDegreeId, objEduMSTRGiftedClsCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.ftpFileType, objEduMSTRGiftedClsCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.VideoUrl, objEduMSTRGiftedClsCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.VideoPath, objEduMSTRGiftedClsCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.ResErrMsg, objEduMSTRGiftedClsCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.ResourceNum) == true)
{
string strComparisonOp_ResourceNum = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.ResourceNum];
strWhereCond += string.Format(" And {0} {2} {1}", conEduMSTRGiftedClsCase.ResourceNum, objEduMSTRGiftedClsCase_Cond.ResourceNum, strComparisonOp_ResourceNum);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.UpdDate, objEduMSTRGiftedClsCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.UpdUserId, objEduMSTRGiftedClsCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objEduMSTRGiftedClsCase_Cond.IsUpdated(conEduMSTRGiftedClsCase.Memo) == true)
{
string strComparisonOp_Memo = objEduMSTRGiftedClsCase_Cond.dicFldComparisonOp[conEduMSTRGiftedClsCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEduMSTRGiftedClsCase.Memo, objEduMSTRGiftedClsCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
 if (string.IsNullOrEmpty(objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objEduMSTRGiftedClsCaseEN.sf_UpdFldSetStr = objEduMSTRGiftedClsCaseEN.getsf_UpdFldSetStr();
clsEduMSTRGiftedClsCaseWApi.CheckPropertyNew(objEduMSTRGiftedClsCaseEN); 
bool bolResult = clsEduMSTRGiftedClsCaseWApi.UpdateRecord(objEduMSTRGiftedClsCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEduMSTRGiftedClsCaseWApi.ReFreshCache();
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
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
 if (string.IsNullOrEmpty(objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsEduMSTRGiftedClsCaseWApi.IsExist(objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsEduMSTRGiftedClsCaseWApi.CheckPropertyNew(objEduMSTRGiftedClsCaseEN); 
bool bolResult = clsEduMSTRGiftedClsCaseWApi.AddNewRecord(objEduMSTRGiftedClsCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEduMSTRGiftedClsCaseWApi.ReFreshCache();
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
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
try
{
clsEduMSTRGiftedClsCaseWApi.CheckPropertyNew(objEduMSTRGiftedClsCaseEN); 
string strid_EduMSTRGiftedClsCase = clsEduMSTRGiftedClsCaseWApi.AddNewRecordWithMaxId(objEduMSTRGiftedClsCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEduMSTRGiftedClsCaseWApi.ReFreshCache();
return strid_EduMSTRGiftedClsCase;
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
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strWhereCond)
{
try
{
clsEduMSTRGiftedClsCaseWApi.CheckPropertyNew(objEduMSTRGiftedClsCaseEN); 
bool bolResult = clsEduMSTRGiftedClsCaseWApi.UpdateWithCondition(objEduMSTRGiftedClsCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEduMSTRGiftedClsCaseWApi.ReFreshCache();
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
 /// 教育硕士优课案例(EduMSTRGiftedClsCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsEduMSTRGiftedClsCaseWApi
{
private static readonly string mstrApiControllerName = "EduMSTRGiftedClsCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsEduMSTRGiftedClsCaseWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase) && GetStrLen(objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase) > 8)
{
 throw new Exception("字段[教育硕士优课案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID) && GetStrLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID) > 8)
{
 throw new Exception("字段[教育硕士优课案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName) && GetStrLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName) > 100)
{
 throw new Exception("字段[教育硕士优课案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme) && GetStrLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme) > 200)
{
 throw new Exception("字段[教育硕士优课案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate) && GetStrLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate) > 8)
{
 throw new Exception("字段[教育硕士优课案例日期]的长度不能超过8!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime) && GetStrLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime) > 6)
{
 throw new Exception("字段[教育硕士优课案例时间]的长度不能超过6!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn) && GetStrLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.id_StudyLevel) && GetStrLen(objEduMSTRGiftedClsCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.id_TeachingPlan) && GetStrLen(objEduMSTRGiftedClsCaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn) && GetStrLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCaseType) && GetStrLen(objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCaseType) > 4)
{
 throw new Exception("字段[教育硕士优课案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.Id_CaseType) && GetStrLen(objEduMSTRGiftedClsCaseEN.Id_CaseType) > 4)
{
 throw new Exception("字段[案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.id_Discipline) && GetStrLen(objEduMSTRGiftedClsCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.id_SenateGaugeVersion) && GetStrLen(objEduMSTRGiftedClsCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.id_TeachSkill) && GetStrLen(objEduMSTRGiftedClsCaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.CaseLevelId) && GetStrLen(objEduMSTRGiftedClsCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.DocFile) && GetStrLen(objEduMSTRGiftedClsCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.WordCreateDate) && GetStrLen(objEduMSTRGiftedClsCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText) && GetStrLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText) > 8000)
{
 throw new Exception("字段[教育硕士优课案例文本]的长度不能超过8000!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.OwnerId) && GetStrLen(objEduMSTRGiftedClsCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.UserKindId) && GetStrLen(objEduMSTRGiftedClsCaseEN.UserKindId) > 2)
{
 throw new Exception("字段[用户类别Id]的长度不能超过2!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.UserTypeId) && GetStrLen(objEduMSTRGiftedClsCaseEN.UserTypeId) > 2)
{
 throw new Exception("字段[用户类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.RecommendedDegreeId) && GetStrLen(objEduMSTRGiftedClsCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.ftpFileType) && GetStrLen(objEduMSTRGiftedClsCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.VideoUrl) && GetStrLen(objEduMSTRGiftedClsCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.VideoPath) && GetStrLen(objEduMSTRGiftedClsCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.ResErrMsg) && GetStrLen(objEduMSTRGiftedClsCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.UpdDate) && GetStrLen(objEduMSTRGiftedClsCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.UpdUserId) && GetStrLen(objEduMSTRGiftedClsCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objEduMSTRGiftedClsCaseEN.Memo) && GetStrLen(objEduMSTRGiftedClsCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objEduMSTRGiftedClsCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_EduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsEduMSTRGiftedClsCaseEN GetObjByid_EduMSTRGiftedClsCase(string strid_EduMSTRGiftedClsCase)
{
string strAction = "GetObjByid_EduMSTRGiftedClsCase";
string strErrMsg = string.Empty;
string strResult = "";
clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN = null;
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
objEduMSTRGiftedClsCaseEN = JsonConvert.DeserializeObject<clsEduMSTRGiftedClsCaseEN>((string)jobjReturn["ReturnObj"]);
return objEduMSTRGiftedClsCaseEN;
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
public static clsEduMSTRGiftedClsCaseEN GetObjByid_EduMSTRGiftedClsCase_WA_Cache(string strid_EduMSTRGiftedClsCase)
{
string strAction = "GetObjByid_EduMSTRGiftedClsCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN = null;
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
objEduMSTRGiftedClsCaseEN = JsonConvert.DeserializeObject<clsEduMSTRGiftedClsCaseEN>((string)jobjReturn["ReturnObj"]);
return objEduMSTRGiftedClsCaseEN;
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
public static clsEduMSTRGiftedClsCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN = null;
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
objEduMSTRGiftedClsCaseEN = JsonConvert.DeserializeObject<clsEduMSTRGiftedClsCaseEN>((string)jobjReturn["ReturnObj"]);
return objEduMSTRGiftedClsCaseEN;
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
public static clsEduMSTRGiftedClsCaseEN GetObjByid_EduMSTRGiftedClsCase_Cache(string strid_EduMSTRGiftedClsCase)
{
if (string.IsNullOrEmpty(strid_EduMSTRGiftedClsCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsEduMSTRGiftedClsCaseEN._CurrTabName_S);
List<clsEduMSTRGiftedClsCaseEN> arrEduMSTRGiftedClsCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsEduMSTRGiftedClsCaseEN> arrEduMSTRGiftedClsCaseObjLst_Sel =
from objEduMSTRGiftedClsCaseEN in arrEduMSTRGiftedClsCaseObjLst_Cache
where objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase == strid_EduMSTRGiftedClsCase
select objEduMSTRGiftedClsCaseEN;
if (arrEduMSTRGiftedClsCaseObjLst_Sel.Count() == 0)
{
   clsEduMSTRGiftedClsCaseEN obj = clsEduMSTRGiftedClsCaseWApi.GetObjByid_EduMSTRGiftedClsCase(strid_EduMSTRGiftedClsCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrEduMSTRGiftedClsCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsEduMSTRGiftedClsCaseEN> GetObjLst(string strWhereCond)
{
 List<clsEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsEduMSTRGiftedClsCaseEN> GetObjLstById_EduMSTRGiftedClsCaseLst(List<string> arrId_EduMSTRGiftedClsCase)
{
 List<clsEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsEduMSTRGiftedClsCaseEN> GetObjLstById_EduMSTRGiftedClsCaseLst_Cache(List<string> arrId_EduMSTRGiftedClsCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsEduMSTRGiftedClsCaseEN._CurrTabName_S);
List<clsEduMSTRGiftedClsCaseEN> arrEduMSTRGiftedClsCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsEduMSTRGiftedClsCaseEN> arrEduMSTRGiftedClsCaseObjLst_Sel =
from objEduMSTRGiftedClsCaseEN in arrEduMSTRGiftedClsCaseObjLst_Cache
where arrId_EduMSTRGiftedClsCase.Contains(objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase)
select objEduMSTRGiftedClsCaseEN;
return arrEduMSTRGiftedClsCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsEduMSTRGiftedClsCaseEN> GetObjLstById_EduMSTRGiftedClsCaseLst_WA_Cache(List<string> arrId_EduMSTRGiftedClsCase)
{
 List<clsEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsEduMSTRGiftedClsCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsEduMSTRGiftedClsCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsEduMSTRGiftedClsCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsEduMSTRGiftedClsCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsEduMSTRGiftedClsCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEduMSTRGiftedClsCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_EduMSTRGiftedClsCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN = clsEduMSTRGiftedClsCaseWApi.GetObjByid_EduMSTRGiftedClsCase(strid_EduMSTRGiftedClsCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_EduMSTRGiftedClsCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsEduMSTRGiftedClsCaseWApi.ReFreshCache();
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
public static int DelEduMSTRGiftedClsCases(List<string> arrid_EduMSTRGiftedClsCase)
{
string strAction = "DelEduMSTRGiftedClsCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_EduMSTRGiftedClsCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsEduMSTRGiftedClsCaseWApi.ReFreshCache();
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
public static int DelEduMSTRGiftedClsCasesByCond(string strWhereCond)
{
string strAction = "DelEduMSTRGiftedClsCasesByCond";
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
public static bool AddNewRecord(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEduMSTRGiftedClsCaseEN>(objEduMSTRGiftedClsCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEduMSTRGiftedClsCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEduMSTRGiftedClsCaseEN>(objEduMSTRGiftedClsCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEduMSTRGiftedClsCaseWApi.ReFreshCache();
var strid_EduMSTRGiftedClsCase = (string)jobjReturn["ReturnStr"];
return strid_EduMSTRGiftedClsCase;
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
public static bool UpdateRecord(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
if (string.IsNullOrEmpty(objEduMSTRGiftedClsCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEduMSTRGiftedClsCaseEN>(objEduMSTRGiftedClsCaseEN);
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
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objEduMSTRGiftedClsCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objEduMSTRGiftedClsCaseEN.id_EduMSTRGiftedClsCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEduMSTRGiftedClsCaseEN>(objEduMSTRGiftedClsCaseEN);
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
 /// <param name = "objEduMSTRGiftedClsCaseENS">源对象</param>
 /// <param name = "objEduMSTRGiftedClsCaseENT">目标对象</param>
 public static void CopyTo(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseENS, clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseENT)
{
try
{
objEduMSTRGiftedClsCaseENT.id_EduMSTRGiftedClsCase = objEduMSTRGiftedClsCaseENS.id_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objEduMSTRGiftedClsCaseENT.id_StudyLevel = objEduMSTRGiftedClsCaseENS.id_StudyLevel; //id_StudyLevel
objEduMSTRGiftedClsCaseENT.id_TeachingPlan = objEduMSTRGiftedClsCaseENS.id_TeachingPlan; //教案流水号
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objEduMSTRGiftedClsCaseENT.id_EduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCaseENS.id_EduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objEduMSTRGiftedClsCaseENT.Id_CaseType = objEduMSTRGiftedClsCaseENS.Id_CaseType; //案例类型流水号
objEduMSTRGiftedClsCaseENT.id_Discipline = objEduMSTRGiftedClsCaseENS.id_Discipline; //学科流水号
objEduMSTRGiftedClsCaseENT.BrowseCount = objEduMSTRGiftedClsCaseENS.BrowseCount; //浏览次数
objEduMSTRGiftedClsCaseENT.id_SenateGaugeVersion = objEduMSTRGiftedClsCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objEduMSTRGiftedClsCaseENT.id_TeachSkill = objEduMSTRGiftedClsCaseENS.id_TeachSkill; //教学技能流水号
objEduMSTRGiftedClsCaseENT.CaseLevelId = objEduMSTRGiftedClsCaseENS.CaseLevelId; //课例等级Id
objEduMSTRGiftedClsCaseENT.DocFile = objEduMSTRGiftedClsCaseENS.DocFile; //生成的Word文件名
objEduMSTRGiftedClsCaseENT.IsNeedGeneWord = objEduMSTRGiftedClsCaseENS.IsNeedGeneWord; //是否需要生成Word
objEduMSTRGiftedClsCaseENT.WordCreateDate = objEduMSTRGiftedClsCaseENS.WordCreateDate; //Word生成日期
objEduMSTRGiftedClsCaseENT.IsVisible = objEduMSTRGiftedClsCaseENS.IsVisible; //是否显示
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
objEduMSTRGiftedClsCaseENT.OwnerId = objEduMSTRGiftedClsCaseENS.OwnerId; //拥有者Id
objEduMSTRGiftedClsCaseENT.IsDualVideo = objEduMSTRGiftedClsCaseENS.IsDualVideo; //是否双视频
objEduMSTRGiftedClsCaseENT.UserKindId = objEduMSTRGiftedClsCaseENS.UserKindId; //用户类别Id
objEduMSTRGiftedClsCaseENT.UserTypeId = objEduMSTRGiftedClsCaseENS.UserTypeId; //用户类型Id
objEduMSTRGiftedClsCaseENT.RecommendedDegreeId = objEduMSTRGiftedClsCaseENS.RecommendedDegreeId; //推荐度Id
objEduMSTRGiftedClsCaseENT.ftpFileType = objEduMSTRGiftedClsCaseENS.ftpFileType; //ftp文件类型
objEduMSTRGiftedClsCaseENT.VideoUrl = objEduMSTRGiftedClsCaseENS.VideoUrl; //视频Url
objEduMSTRGiftedClsCaseENT.VideoPath = objEduMSTRGiftedClsCaseENS.VideoPath; //视频目录
objEduMSTRGiftedClsCaseENT.ResErrMsg = objEduMSTRGiftedClsCaseENS.ResErrMsg; //资源错误信息
objEduMSTRGiftedClsCaseENT.ResourceNum = objEduMSTRGiftedClsCaseENS.ResourceNum; //资源数
objEduMSTRGiftedClsCaseENT.UpdDate = objEduMSTRGiftedClsCaseENS.UpdDate; //修改日期
objEduMSTRGiftedClsCaseENT.UpdUserId = objEduMSTRGiftedClsCaseENS.UpdUserId; //修改用户Id
objEduMSTRGiftedClsCaseENT.Memo = objEduMSTRGiftedClsCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsEduMSTRGiftedClsCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsEduMSTRGiftedClsCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsEduMSTRGiftedClsCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsEduMSTRGiftedClsCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsEduMSTRGiftedClsCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsEduMSTRGiftedClsCaseEN.AttributeName)
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
if (clsEduMSTRGiftedClsCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsEduMSTRGiftedClsCaseWApi没有刷新缓存机制(clsEduMSTRGiftedClsCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_EduMSTRGiftedClsCase");
//if (arrEduMSTRGiftedClsCaseObjLst_Cache == null)
//{
//arrEduMSTRGiftedClsCaseObjLst_Cache = await clsEduMSTRGiftedClsCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsEduMSTRGiftedClsCaseEN._CurrTabName_S);
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
if (clsEduMSTRGiftedClsCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsEduMSTRGiftedClsCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsEduMSTRGiftedClsCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsEduMSTRGiftedClsCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsEduMSTRGiftedClsCaseEN._CurrTabName_S);
List<clsEduMSTRGiftedClsCaseEN> arrEduMSTRGiftedClsCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrEduMSTRGiftedClsCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsEduMSTRGiftedClsCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.ResourceNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conEduMSTRGiftedClsCase.Memo, Type.GetType("System.String"));
foreach (clsEduMSTRGiftedClsCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase] = objInFor[conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCase];
objDR[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID] = objInFor[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID];
objDR[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName] = objInFor[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName];
objDR[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] = objInFor[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme];
objDR[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] = objInFor[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate];
objDR[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] = objInFor[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime];
objDR[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] = objInFor[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn];
objDR[conEduMSTRGiftedClsCase.id_StudyLevel] = objInFor[conEduMSTRGiftedClsCase.id_StudyLevel];
objDR[conEduMSTRGiftedClsCase.id_TeachingPlan] = objInFor[conEduMSTRGiftedClsCase.id_TeachingPlan];
objDR[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] = objInFor[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn];
objDR[conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType] = objInFor[conEduMSTRGiftedClsCase.id_EduMSTRGiftedClsCaseType];
objDR[conEduMSTRGiftedClsCase.Id_CaseType] = objInFor[conEduMSTRGiftedClsCase.Id_CaseType];
objDR[conEduMSTRGiftedClsCase.id_Discipline] = objInFor[conEduMSTRGiftedClsCase.id_Discipline];
objDR[conEduMSTRGiftedClsCase.BrowseCount] = objInFor[conEduMSTRGiftedClsCase.BrowseCount];
objDR[conEduMSTRGiftedClsCase.id_SenateGaugeVersion] = objInFor[conEduMSTRGiftedClsCase.id_SenateGaugeVersion];
objDR[conEduMSTRGiftedClsCase.id_TeachSkill] = objInFor[conEduMSTRGiftedClsCase.id_TeachSkill];
objDR[conEduMSTRGiftedClsCase.CaseLevelId] = objInFor[conEduMSTRGiftedClsCase.CaseLevelId];
objDR[conEduMSTRGiftedClsCase.DocFile] = objInFor[conEduMSTRGiftedClsCase.DocFile];
objDR[conEduMSTRGiftedClsCase.IsNeedGeneWord] = objInFor[conEduMSTRGiftedClsCase.IsNeedGeneWord];
objDR[conEduMSTRGiftedClsCase.WordCreateDate] = objInFor[conEduMSTRGiftedClsCase.WordCreateDate];
objDR[conEduMSTRGiftedClsCase.IsVisible] = objInFor[conEduMSTRGiftedClsCase.IsVisible];
objDR[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] = objInFor[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText];
objDR[conEduMSTRGiftedClsCase.OwnerId] = objInFor[conEduMSTRGiftedClsCase.OwnerId];
objDR[conEduMSTRGiftedClsCase.IsDualVideo] = objInFor[conEduMSTRGiftedClsCase.IsDualVideo];
objDR[conEduMSTRGiftedClsCase.UserKindId] = objInFor[conEduMSTRGiftedClsCase.UserKindId];
objDR[conEduMSTRGiftedClsCase.UserTypeId] = objInFor[conEduMSTRGiftedClsCase.UserTypeId];
objDR[conEduMSTRGiftedClsCase.RecommendedDegreeId] = objInFor[conEduMSTRGiftedClsCase.RecommendedDegreeId];
objDR[conEduMSTRGiftedClsCase.ftpFileType] = objInFor[conEduMSTRGiftedClsCase.ftpFileType];
objDR[conEduMSTRGiftedClsCase.VideoUrl] = objInFor[conEduMSTRGiftedClsCase.VideoUrl];
objDR[conEduMSTRGiftedClsCase.VideoPath] = objInFor[conEduMSTRGiftedClsCase.VideoPath];
objDR[conEduMSTRGiftedClsCase.ResErrMsg] = objInFor[conEduMSTRGiftedClsCase.ResErrMsg];
objDR[conEduMSTRGiftedClsCase.ResourceNum] = objInFor[conEduMSTRGiftedClsCase.ResourceNum];
objDR[conEduMSTRGiftedClsCase.UpdDate] = objInFor[conEduMSTRGiftedClsCase.UpdDate];
objDR[conEduMSTRGiftedClsCase.UpdUserId] = objInFor[conEduMSTRGiftedClsCase.UpdUserId];
objDR[conEduMSTRGiftedClsCase.Memo] = objInFor[conEduMSTRGiftedClsCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 教育硕士优课案例(EduMSTRGiftedClsCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4EduMSTRGiftedClsCase : clsCommFun4BL
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
clsEduMSTRGiftedClsCaseWApi.ReFreshThisCache();
}
}

}