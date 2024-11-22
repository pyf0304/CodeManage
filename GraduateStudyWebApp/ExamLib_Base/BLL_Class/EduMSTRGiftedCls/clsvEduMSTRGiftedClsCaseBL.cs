
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCaseBL
 表名:vEduMSTRGiftedClsCase(01120380)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评(EduMSTRGiftedCls)
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
public static class  clsvEduMSTRGiftedClsCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCaseEN GetObj(this K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase myKey)
{
clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = clsvEduMSTRGiftedClsCaseBL.vEduMSTRGiftedClsCaseDA.GetObjByIdEduMSTRGiftedClsCase(myKey.Value);
return objvEduMSTRGiftedClsCaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdEduMSTRGiftedClsCase(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdEduMSTRGiftedClsCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
}
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = strIdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduMSTRGiftedClsCaseID, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduMSTRGiftedClsCaseName, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTheme(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTheme, 200, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseDate(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTime(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseDateIn(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdStudyLevel(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convEduMSTRGiftedClsCase.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convEduMSTRGiftedClsCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convEduMSTRGiftedClsCase.IdStudyLevel);
}
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdStudyLevel) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdStudyLevel, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdStudyLevel] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetStudyLevelName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convEduMSTRGiftedClsCase.StudyLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convEduMSTRGiftedClsCase.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdTeachingPlan(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convEduMSTRGiftedClsCase.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convEduMSTRGiftedClsCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convEduMSTRGiftedClsCase.IdTeachingPlan);
}
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdTeachingPlan) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdTeachingPlan, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdTeachingPlan] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTimeIn(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdEduMSTRGiftedClsCaseType(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdEduMSTRGiftedClsCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
}
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = strIdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTypeID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTypeID, 4, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTypeID, 4, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseTypeName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTypeName, 50, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdCaseType(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseType, convEduMSTRGiftedClsCase.IdCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convEduMSTRGiftedClsCase.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convEduMSTRGiftedClsCase.IdCaseType);
}
objvEduMSTRGiftedClsCaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdCaseType) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdCaseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdCaseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdDiscipline(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convEduMSTRGiftedClsCase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convEduMSTRGiftedClsCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convEduMSTRGiftedClsCase.IdDiscipline);
}
objvEduMSTRGiftedClsCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdDiscipline) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdDiscipline, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdDiscipline] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetDisciplineID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convEduMSTRGiftedClsCase.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convEduMSTRGiftedClsCase.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetDisciplineName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convEduMSTRGiftedClsCase.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdSenateGaugeVersion(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convEduMSTRGiftedClsCase.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convEduMSTRGiftedClsCase.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convEduMSTRGiftedClsCase.IdSenateGaugeVersion);
}
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdSenateGaugeVersion) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetsenateGaugeVersionID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convEduMSTRGiftedClsCase.senateGaugeVersionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCase.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCase.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetsenateGaugeVersionName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convEduMSTRGiftedClsCase.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetVersionNo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, int? intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdTeachSkill(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convEduMSTRGiftedClsCase.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convEduMSTRGiftedClsCase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convEduMSTRGiftedClsCase.IdTeachSkill);
}
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdTeachSkill) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdTeachSkill, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdTeachSkill] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetTeachSkillID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convEduMSTRGiftedClsCase.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convEduMSTRGiftedClsCase.TeachSkillID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetSkillTypeName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convEduMSTRGiftedClsCase.SkillTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetTeachSkillName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convEduMSTRGiftedClsCase.TeachSkillName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetTeachSkillTheory(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convEduMSTRGiftedClsCase.TeachSkillTheory);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetTeachSkillOperMethod(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convEduMSTRGiftedClsCase.TeachSkillOperMethod);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdSkillType(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convEduMSTRGiftedClsCase.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convEduMSTRGiftedClsCase.IdSkillType);
}
objvEduMSTRGiftedClsCaseEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdSkillType) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdSkillType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdSkillType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetSkillTypeID(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convEduMSTRGiftedClsCase.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convEduMSTRGiftedClsCase.SkillTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetCaseLevelId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convEduMSTRGiftedClsCase.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convEduMSTRGiftedClsCase.CaseLevelId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetCaseLevelName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convEduMSTRGiftedClsCase.CaseLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetDocFile(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convEduMSTRGiftedClsCase.DocFile);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetWordCreateDate(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convEduMSTRGiftedClsCase.WordCreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEduMSTRGiftedClsCaseText(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEduMSTRGiftedClsCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseText, 8000, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetOwnerId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convEduMSTRGiftedClsCase.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convEduMSTRGiftedClsCase.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdStudentInfo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdStudentInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convEduMSTRGiftedClsCase.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convEduMSTRGiftedClsCase.IdStudentInfo);
}
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdStudentInfo) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdStudentInfo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdStudentInfo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetStuName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convEduMSTRGiftedClsCase.StuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convEduMSTRGiftedClsCase.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetStuId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strStuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuId, 20, convEduMSTRGiftedClsCase.StuId);
}
objvEduMSTRGiftedClsCaseEN.StuId = strStuId; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.StuId) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.StuId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetPoliticsName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strPoliticsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convEduMSTRGiftedClsCase.PoliticsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetSexDesc(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convEduMSTRGiftedClsCase.SexDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEthnicName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEthnicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convEduMSTRGiftedClsCase.EthnicName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetUniZoneDesc(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strUniZoneDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convEduMSTRGiftedClsCase.UniZoneDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetStuTypeDesc(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convEduMSTRGiftedClsCase.StuTypeDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdXzCollege(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convEduMSTRGiftedClsCase.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convEduMSTRGiftedClsCase.IdXzCollege);
}
objvEduMSTRGiftedClsCaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdXzCollege) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdXzCollege, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdXzCollege] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetCollegeId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convEduMSTRGiftedClsCase.CollegeId);
}
objvEduMSTRGiftedClsCaseEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.CollegeId) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.CollegeId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.CollegeId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetCollegeName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convEduMSTRGiftedClsCase.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convEduMSTRGiftedClsCase.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetCollegeNameA(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convEduMSTRGiftedClsCase.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdXzMajor(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convEduMSTRGiftedClsCase.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convEduMSTRGiftedClsCase.IdXzMajor);
}
objvEduMSTRGiftedClsCaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdXzMajor) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdXzMajor, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdXzMajor] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetMajorName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convEduMSTRGiftedClsCase.MajorName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convEduMSTRGiftedClsCase.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdGradeBase(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdGradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdGradeBase, convEduMSTRGiftedClsCase.IdGradeBase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convEduMSTRGiftedClsCase.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convEduMSTRGiftedClsCase.IdGradeBase);
}
objvEduMSTRGiftedClsCaseEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdGradeBase) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdGradeBase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdGradeBase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetGradeBaseName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convEduMSTRGiftedClsCase.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdAdminCls(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, convEduMSTRGiftedClsCase.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, convEduMSTRGiftedClsCase.IdAdminCls);
}
objvEduMSTRGiftedClsCaseEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdAdminCls) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdAdminCls, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdAdminCls] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetAdminClsId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strAdminClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convEduMSTRGiftedClsCase.AdminClsId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetAdminClsName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strAdminClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convEduMSTRGiftedClsCase.AdminClsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetBirthday(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, convEduMSTRGiftedClsCase.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convEduMSTRGiftedClsCase.Birthday);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetNativePlace(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strNativePlace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convEduMSTRGiftedClsCase.NativePlace);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetDuty(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strDuty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDuty, 30, convEduMSTRGiftedClsCase.Duty);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIdCardNo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIdCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCardNo, 20, convEduMSTRGiftedClsCase.IdCardNo);
}
objvEduMSTRGiftedClsCaseEN.IdCardNo = strIdCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase.IdCardNo) == false)
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase.IdCardNo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdCardNo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetStuCardNo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strStuCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convEduMSTRGiftedClsCase.StuCardNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetLiveAddress(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strLiveAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convEduMSTRGiftedClsCase.LiveAddress);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetHomePhone(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strHomePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convEduMSTRGiftedClsCase.HomePhone);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetEnrollmentDate(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convEduMSTRGiftedClsCase.EnrollmentDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetPostCode(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strPostCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPostCode, 6, convEduMSTRGiftedClsCase.PostCode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convEduMSTRGiftedClsCase.PostCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetUserKindId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convEduMSTRGiftedClsCase.UserKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convEduMSTRGiftedClsCase.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convEduMSTRGiftedClsCase.UserKindId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetUserKindName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convEduMSTRGiftedClsCase.UserKindName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetUserTypeId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convEduMSTRGiftedClsCase.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convEduMSTRGiftedClsCase.UserTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetUserTypeName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convEduMSTRGiftedClsCase.UserTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetRecommendedDegreeId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convEduMSTRGiftedClsCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convEduMSTRGiftedClsCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convEduMSTRGiftedClsCase.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetRecommendedDegreeName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convEduMSTRGiftedClsCase.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetftpFileType(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convEduMSTRGiftedClsCase.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetVideoUrl(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convEduMSTRGiftedClsCase.VideoUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetVideoPath(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convEduMSTRGiftedClsCase.VideoPath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetResErrMsg(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convEduMSTRGiftedClsCase.ResErrMsg);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetResourceNum(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, int? intResourceNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetMemo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convEduMSTRGiftedClsCase.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetBrowseCount4Case(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetOwnerName(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convEduMSTRGiftedClsCase.OwnerName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetOwnerNameWithId(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convEduMSTRGiftedClsCase.OwnerNameWithId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseEN SetIsHaveVideo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIsHaveVideo, convEduMSTRGiftedClsCase.IsHaveVideo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convEduMSTRGiftedClsCase.IsHaveVideo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCaseENT">目标对象</param>
 public static void CopyTo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseENS, clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseENT)
{
try
{
objvEduMSTRGiftedClsCaseENT.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseENS.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objvEduMSTRGiftedClsCaseENT.IdStudyLevel = objvEduMSTRGiftedClsCaseENS.IdStudyLevel; //id_StudyLevel
objvEduMSTRGiftedClsCaseENT.StudyLevelName = objvEduMSTRGiftedClsCaseENS.StudyLevelName; //学段名称
objvEduMSTRGiftedClsCaseENT.IdTeachingPlan = objvEduMSTRGiftedClsCaseENS.IdTeachingPlan; //教案流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objvEduMSTRGiftedClsCaseENT.IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCaseENS.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTypeID = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTypeID; //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseENT.IdCaseType = objvEduMSTRGiftedClsCaseENS.IdCaseType; //案例类型流水号
objvEduMSTRGiftedClsCaseENT.IdDiscipline = objvEduMSTRGiftedClsCaseENS.IdDiscipline; //学科流水号
objvEduMSTRGiftedClsCaseENT.DisciplineID = objvEduMSTRGiftedClsCaseENS.DisciplineID; //学科ID
objvEduMSTRGiftedClsCaseENT.DisciplineName = objvEduMSTRGiftedClsCaseENS.DisciplineName; //学科名称
objvEduMSTRGiftedClsCaseENT.IdSenateGaugeVersion = objvEduMSTRGiftedClsCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionID = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionName = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCaseENT.VersionNo = objvEduMSTRGiftedClsCaseENS.VersionNo; //版本号
objvEduMSTRGiftedClsCaseENT.IdTeachSkill = objvEduMSTRGiftedClsCaseENS.IdTeachSkill; //教学技能流水号
objvEduMSTRGiftedClsCaseENT.TeachSkillID = objvEduMSTRGiftedClsCaseENS.TeachSkillID; //教学技能ID
objvEduMSTRGiftedClsCaseENT.SkillTypeName = objvEduMSTRGiftedClsCaseENS.SkillTypeName; //技能类型名称
objvEduMSTRGiftedClsCaseENT.TeachSkillName = objvEduMSTRGiftedClsCaseENS.TeachSkillName; //教学技能名称
objvEduMSTRGiftedClsCaseENT.TeachSkillTheory = objvEduMSTRGiftedClsCaseENS.TeachSkillTheory; //教学技能理论阐述
objvEduMSTRGiftedClsCaseENT.TeachSkillOperMethod = objvEduMSTRGiftedClsCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvEduMSTRGiftedClsCaseENT.IdSkillType = objvEduMSTRGiftedClsCaseENS.IdSkillType; //技能类型流水号
objvEduMSTRGiftedClsCaseENT.SkillTypeID = objvEduMSTRGiftedClsCaseENS.SkillTypeID; //技能类型ID
objvEduMSTRGiftedClsCaseENT.CaseLevelId = objvEduMSTRGiftedClsCaseENS.CaseLevelId; //课例等级Id
objvEduMSTRGiftedClsCaseENT.CaseLevelName = objvEduMSTRGiftedClsCaseENS.CaseLevelName; //案例等级名称
objvEduMSTRGiftedClsCaseENT.DocFile = objvEduMSTRGiftedClsCaseENS.DocFile; //生成的Word文件名
objvEduMSTRGiftedClsCaseENT.IsNeedGeneWord = objvEduMSTRGiftedClsCaseENS.IsNeedGeneWord; //是否需要生成Word
objvEduMSTRGiftedClsCaseENT.WordCreateDate = objvEduMSTRGiftedClsCaseENS.WordCreateDate; //Word生成日期
objvEduMSTRGiftedClsCaseENT.IsVisible = objvEduMSTRGiftedClsCaseENS.IsVisible; //是否显示
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseENT.OwnerId = objvEduMSTRGiftedClsCaseENS.OwnerId; //拥有者Id
objvEduMSTRGiftedClsCaseENT.IdStudentInfo = objvEduMSTRGiftedClsCaseENS.IdStudentInfo; //学生流水号
objvEduMSTRGiftedClsCaseENT.StuName = objvEduMSTRGiftedClsCaseENS.StuName; //姓名
objvEduMSTRGiftedClsCaseENT.StuId = objvEduMSTRGiftedClsCaseENS.StuId; //学号
objvEduMSTRGiftedClsCaseENT.PoliticsName = objvEduMSTRGiftedClsCaseENS.PoliticsName; //政治面貌
objvEduMSTRGiftedClsCaseENT.SexDesc = objvEduMSTRGiftedClsCaseENS.SexDesc; //性别名称
objvEduMSTRGiftedClsCaseENT.EthnicName = objvEduMSTRGiftedClsCaseENS.EthnicName; //民族名称
objvEduMSTRGiftedClsCaseENT.UniZoneDesc = objvEduMSTRGiftedClsCaseENS.UniZoneDesc; //校区名称
objvEduMSTRGiftedClsCaseENT.StuTypeDesc = objvEduMSTRGiftedClsCaseENS.StuTypeDesc; //学生类别名称
objvEduMSTRGiftedClsCaseENT.IdXzCollege = objvEduMSTRGiftedClsCaseENS.IdXzCollege; //学院流水号
objvEduMSTRGiftedClsCaseENT.CollegeId = objvEduMSTRGiftedClsCaseENS.CollegeId; //学院ID
objvEduMSTRGiftedClsCaseENT.CollegeName = objvEduMSTRGiftedClsCaseENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCaseENT.CollegeNameA = objvEduMSTRGiftedClsCaseENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCaseENT.IdXzMajor = objvEduMSTRGiftedClsCaseENS.IdXzMajor; //专业流水号
objvEduMSTRGiftedClsCaseENT.MajorName = objvEduMSTRGiftedClsCaseENS.MajorName; //专业名称
objvEduMSTRGiftedClsCaseENT.IdGradeBase = objvEduMSTRGiftedClsCaseENS.IdGradeBase; //年级流水号
objvEduMSTRGiftedClsCaseENT.GradeBaseName = objvEduMSTRGiftedClsCaseENS.GradeBaseName; //年级名称
objvEduMSTRGiftedClsCaseENT.IdAdminCls = objvEduMSTRGiftedClsCaseENS.IdAdminCls; //行政班流水号
objvEduMSTRGiftedClsCaseENT.AdminClsId = objvEduMSTRGiftedClsCaseENS.AdminClsId; //行政班代号
objvEduMSTRGiftedClsCaseENT.AdminClsName = objvEduMSTRGiftedClsCaseENS.AdminClsName; //行政班名称
objvEduMSTRGiftedClsCaseENT.Birthday = objvEduMSTRGiftedClsCaseENS.Birthday; //出生日期
objvEduMSTRGiftedClsCaseENT.NativePlace = objvEduMSTRGiftedClsCaseENS.NativePlace; //籍贯
objvEduMSTRGiftedClsCaseENT.Duty = objvEduMSTRGiftedClsCaseENS.Duty; //职位
objvEduMSTRGiftedClsCaseENT.IdCardNo = objvEduMSTRGiftedClsCaseENS.IdCardNo; //身份证号
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
 /// <param name = "objvEduMSTRGiftedClsCaseENS">源对象</param>
 /// <returns>目标对象=>clsvEduMSTRGiftedClsCaseEN:objvEduMSTRGiftedClsCaseENT</returns>
 public static clsvEduMSTRGiftedClsCaseEN CopyTo(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseENS)
{
try
{
 clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseENT = new clsvEduMSTRGiftedClsCaseEN()
{
IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseENS.IdEduMSTRGiftedClsCase, //教育硕士优课案例流水号
EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseID, //教育硕士优课案例ID
EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseName, //教育硕士优课案例名称
EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTheme, //教育硕士优课案例主题词
EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDate, //教育硕士优课案例日期
EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTime, //教育硕士优课案例时间
EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDateIn, //案例入库日期
IdStudyLevel = objvEduMSTRGiftedClsCaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvEduMSTRGiftedClsCaseENS.StudyLevelName, //学段名称
IdTeachingPlan = objvEduMSTRGiftedClsCaseENS.IdTeachingPlan, //教案流水号
EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTimeIn, //案例入库时间
IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCaseENS.IdEduMSTRGiftedClsCaseType, //教育硕士优课案例类型流水号
EduMSTRGiftedClsCaseTypeID = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTypeID, //教育硕士优课案例类型Id
EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTypeName, //教育硕士优课案例类型名称
IdCaseType = objvEduMSTRGiftedClsCaseENS.IdCaseType, //案例类型流水号
IdDiscipline = objvEduMSTRGiftedClsCaseENS.IdDiscipline, //学科流水号
DisciplineID = objvEduMSTRGiftedClsCaseENS.DisciplineID, //学科ID
DisciplineName = objvEduMSTRGiftedClsCaseENS.DisciplineName, //学科名称
IdSenateGaugeVersion = objvEduMSTRGiftedClsCaseENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvEduMSTRGiftedClsCaseENS.VersionNo, //版本号
IdTeachSkill = objvEduMSTRGiftedClsCaseENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvEduMSTRGiftedClsCaseENS.TeachSkillID, //教学技能ID
SkillTypeName = objvEduMSTRGiftedClsCaseENS.SkillTypeName, //技能类型名称
TeachSkillName = objvEduMSTRGiftedClsCaseENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvEduMSTRGiftedClsCaseENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvEduMSTRGiftedClsCaseENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvEduMSTRGiftedClsCaseENS.IdSkillType, //技能类型流水号
SkillTypeID = objvEduMSTRGiftedClsCaseENS.SkillTypeID, //技能类型ID
CaseLevelId = objvEduMSTRGiftedClsCaseENS.CaseLevelId, //课例等级Id
CaseLevelName = objvEduMSTRGiftedClsCaseENS.CaseLevelName, //案例等级名称
DocFile = objvEduMSTRGiftedClsCaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvEduMSTRGiftedClsCaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvEduMSTRGiftedClsCaseENS.WordCreateDate, //Word生成日期
IsVisible = objvEduMSTRGiftedClsCaseENS.IsVisible, //是否显示
EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseText, //教育硕士优课案例文本
OwnerId = objvEduMSTRGiftedClsCaseENS.OwnerId, //拥有者Id
IdStudentInfo = objvEduMSTRGiftedClsCaseENS.IdStudentInfo, //学生流水号
StuName = objvEduMSTRGiftedClsCaseENS.StuName, //姓名
StuId = objvEduMSTRGiftedClsCaseENS.StuId, //学号
PoliticsName = objvEduMSTRGiftedClsCaseENS.PoliticsName, //政治面貌
SexDesc = objvEduMSTRGiftedClsCaseENS.SexDesc, //性别名称
EthnicName = objvEduMSTRGiftedClsCaseENS.EthnicName, //民族名称
UniZoneDesc = objvEduMSTRGiftedClsCaseENS.UniZoneDesc, //校区名称
StuTypeDesc = objvEduMSTRGiftedClsCaseENS.StuTypeDesc, //学生类别名称
IdXzCollege = objvEduMSTRGiftedClsCaseENS.IdXzCollege, //学院流水号
CollegeId = objvEduMSTRGiftedClsCaseENS.CollegeId, //学院ID
CollegeName = objvEduMSTRGiftedClsCaseENS.CollegeName, //学院名称
CollegeNameA = objvEduMSTRGiftedClsCaseENS.CollegeNameA, //学院名称简写
IdXzMajor = objvEduMSTRGiftedClsCaseENS.IdXzMajor, //专业流水号
MajorName = objvEduMSTRGiftedClsCaseENS.MajorName, //专业名称
IdGradeBase = objvEduMSTRGiftedClsCaseENS.IdGradeBase, //年级流水号
GradeBaseName = objvEduMSTRGiftedClsCaseENS.GradeBaseName, //年级名称
IdAdminCls = objvEduMSTRGiftedClsCaseENS.IdAdminCls, //行政班流水号
AdminClsId = objvEduMSTRGiftedClsCaseENS.AdminClsId, //行政班代号
AdminClsName = objvEduMSTRGiftedClsCaseENS.AdminClsName, //行政班名称
Birthday = objvEduMSTRGiftedClsCaseENS.Birthday, //出生日期
NativePlace = objvEduMSTRGiftedClsCaseENS.NativePlace, //籍贯
Duty = objvEduMSTRGiftedClsCaseENS.Duty, //职位
IdCardNo = objvEduMSTRGiftedClsCaseENS.IdCardNo, //身份证号
StuCardNo = objvEduMSTRGiftedClsCaseENS.StuCardNo, //学生证号
LiveAddress = objvEduMSTRGiftedClsCaseENS.LiveAddress, //居住地址
HomePhone = objvEduMSTRGiftedClsCaseENS.HomePhone, //住宅电话
EnrollmentDate = objvEduMSTRGiftedClsCaseENS.EnrollmentDate, //入校日期
PostCode = objvEduMSTRGiftedClsCaseENS.PostCode, //邮编
IsDualVideo = objvEduMSTRGiftedClsCaseENS.IsDualVideo, //是否双视频
UserKindId = objvEduMSTRGiftedClsCaseENS.UserKindId, //用户类别Id
UserKindName = objvEduMSTRGiftedClsCaseENS.UserKindName, //用户类别名
UserTypeId = objvEduMSTRGiftedClsCaseENS.UserTypeId, //用户类型Id
UserTypeName = objvEduMSTRGiftedClsCaseENS.UserTypeName, //用户类型名称
RecommendedDegreeId = objvEduMSTRGiftedClsCaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvEduMSTRGiftedClsCaseENS.RecommendedDegreeName, //推荐度名称
ftpFileType = objvEduMSTRGiftedClsCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objvEduMSTRGiftedClsCaseENS.VideoUrl, //视频Url
VideoPath = objvEduMSTRGiftedClsCaseENS.VideoPath, //视频目录
ResErrMsg = objvEduMSTRGiftedClsCaseENS.ResErrMsg, //资源错误信息
ResourceNum = objvEduMSTRGiftedClsCaseENS.ResourceNum, //资源数
Memo = objvEduMSTRGiftedClsCaseENS.Memo, //备注
BrowseCount4Case = objvEduMSTRGiftedClsCaseENS.BrowseCount4Case, //课例浏览次数
OwnerName = objvEduMSTRGiftedClsCaseENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvEduMSTRGiftedClsCaseENS.OwnerNameWithId, //拥有者名称附Id
IsHaveVideo = objvEduMSTRGiftedClsCaseENS.IsHaveVideo, //IsHaveVideo
};
 return objvEduMSTRGiftedClsCaseENT;
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
public static void CheckProperty4Condition(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN)
{
 clsvEduMSTRGiftedClsCaseBL.vEduMSTRGiftedClsCaseDA.CheckProperty4Condition(objvEduMSTRGiftedClsCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase) == true)
{
string strComparisonOpIdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase, objvEduMSTRGiftedClsCaseCond.IdEduMSTRGiftedClsCase, strComparisonOpIdEduMSTRGiftedClsCase);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID, objvEduMSTRGiftedClsCaseCond.EduMSTRGiftedClsCaseID, strComparisonOpEduMSTRGiftedClsCaseID);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName, objvEduMSTRGiftedClsCaseCond.EduMSTRGiftedClsCaseName, strComparisonOpEduMSTRGiftedClsCaseName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme, objvEduMSTRGiftedClsCaseCond.EduMSTRGiftedClsCaseTheme, strComparisonOpEduMSTRGiftedClsCaseTheme);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate, objvEduMSTRGiftedClsCaseCond.EduMSTRGiftedClsCaseDate, strComparisonOpEduMSTRGiftedClsCaseDate);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime, objvEduMSTRGiftedClsCaseCond.EduMSTRGiftedClsCaseTime, strComparisonOpEduMSTRGiftedClsCaseTime);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn, objvEduMSTRGiftedClsCaseCond.EduMSTRGiftedClsCaseDateIn, strComparisonOpEduMSTRGiftedClsCaseDateIn);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdStudyLevel, objvEduMSTRGiftedClsCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.StudyLevelName, objvEduMSTRGiftedClsCaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdTeachingPlan, objvEduMSTRGiftedClsCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn, objvEduMSTRGiftedClsCaseCond.EduMSTRGiftedClsCaseTimeIn, strComparisonOpEduMSTRGiftedClsCaseTimeIn);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType) == true)
{
string strComparisonOpIdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType, objvEduMSTRGiftedClsCaseCond.IdEduMSTRGiftedClsCaseType, strComparisonOpIdEduMSTRGiftedClsCaseType);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseTypeID = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID, objvEduMSTRGiftedClsCaseCond.EduMSTRGiftedClsCaseTypeID, strComparisonOpEduMSTRGiftedClsCaseTypeID);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName, objvEduMSTRGiftedClsCaseCond.EduMSTRGiftedClsCaseTypeName, strComparisonOpEduMSTRGiftedClsCaseTypeName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdCaseType, objvEduMSTRGiftedClsCaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdDiscipline, objvEduMSTRGiftedClsCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.DisciplineID, objvEduMSTRGiftedClsCaseCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.DisciplineName, objvEduMSTRGiftedClsCaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdSenateGaugeVersion, objvEduMSTRGiftedClsCaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.senateGaugeVersionID, objvEduMSTRGiftedClsCaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.senateGaugeVersionName, objvEduMSTRGiftedClsCaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore, objvEduMSTRGiftedClsCaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.VersionNo) == true)
{
string strComparisonOpVersionNo = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase.VersionNo, objvEduMSTRGiftedClsCaseCond.VersionNo, strComparisonOpVersionNo);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdTeachSkill, objvEduMSTRGiftedClsCaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.TeachSkillID, objvEduMSTRGiftedClsCaseCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.SkillTypeName, objvEduMSTRGiftedClsCaseCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.TeachSkillName, objvEduMSTRGiftedClsCaseCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.TeachSkillTheory, objvEduMSTRGiftedClsCaseCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.TeachSkillOperMethod, objvEduMSTRGiftedClsCaseCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdSkillType, objvEduMSTRGiftedClsCaseCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.SkillTypeID, objvEduMSTRGiftedClsCaseCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.CaseLevelId, objvEduMSTRGiftedClsCaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.CaseLevelName, objvEduMSTRGiftedClsCaseCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.DocFile) == true)
{
string strComparisonOpDocFile = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.DocFile, objvEduMSTRGiftedClsCaseCond.DocFile, strComparisonOpDocFile);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IsNeedGeneWord) == true)
{
if (objvEduMSTRGiftedClsCaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase.IsNeedGeneWord);
}
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.WordCreateDate, objvEduMSTRGiftedClsCaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IsVisible) == true)
{
if (objvEduMSTRGiftedClsCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase.IsVisible);
}
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText, objvEduMSTRGiftedClsCaseCond.EduMSTRGiftedClsCaseText, strComparisonOpEduMSTRGiftedClsCaseText);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.OwnerId) == true)
{
string strComparisonOpOwnerId = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.OwnerId, objvEduMSTRGiftedClsCaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdStudentInfo, objvEduMSTRGiftedClsCaseCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.StuName) == true)
{
string strComparisonOpStuName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.StuName, objvEduMSTRGiftedClsCaseCond.StuName, strComparisonOpStuName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.StuId) == true)
{
string strComparisonOpStuId = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.StuId, objvEduMSTRGiftedClsCaseCond.StuId, strComparisonOpStuId);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.PoliticsName) == true)
{
string strComparisonOpPoliticsName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.PoliticsName, objvEduMSTRGiftedClsCaseCond.PoliticsName, strComparisonOpPoliticsName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.SexDesc) == true)
{
string strComparisonOpSexDesc = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.SexDesc, objvEduMSTRGiftedClsCaseCond.SexDesc, strComparisonOpSexDesc);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EthnicName) == true)
{
string strComparisonOpEthnicName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EthnicName, objvEduMSTRGiftedClsCaseCond.EthnicName, strComparisonOpEthnicName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.UniZoneDesc, objvEduMSTRGiftedClsCaseCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.StuTypeDesc) == true)
{
string strComparisonOpStuTypeDesc = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.StuTypeDesc, objvEduMSTRGiftedClsCaseCond.StuTypeDesc, strComparisonOpStuTypeDesc);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdXzCollege, objvEduMSTRGiftedClsCaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.CollegeId) == true)
{
string strComparisonOpCollegeId = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.CollegeId, objvEduMSTRGiftedClsCaseCond.CollegeId, strComparisonOpCollegeId);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.CollegeName) == true)
{
string strComparisonOpCollegeName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.CollegeName, objvEduMSTRGiftedClsCaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.CollegeNameA, objvEduMSTRGiftedClsCaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdXzMajor, objvEduMSTRGiftedClsCaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.MajorName) == true)
{
string strComparisonOpMajorName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.MajorName, objvEduMSTRGiftedClsCaseCond.MajorName, strComparisonOpMajorName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdGradeBase, objvEduMSTRGiftedClsCaseCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.GradeBaseName, objvEduMSTRGiftedClsCaseCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdAdminCls, objvEduMSTRGiftedClsCaseCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.AdminClsId) == true)
{
string strComparisonOpAdminClsId = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.AdminClsId, objvEduMSTRGiftedClsCaseCond.AdminClsId, strComparisonOpAdminClsId);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.AdminClsName) == true)
{
string strComparisonOpAdminClsName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.AdminClsName, objvEduMSTRGiftedClsCaseCond.AdminClsName, strComparisonOpAdminClsName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.Birthday) == true)
{
string strComparisonOpBirthday = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.Birthday, objvEduMSTRGiftedClsCaseCond.Birthday, strComparisonOpBirthday);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.NativePlace) == true)
{
string strComparisonOpNativePlace = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.NativePlace, objvEduMSTRGiftedClsCaseCond.NativePlace, strComparisonOpNativePlace);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.Duty) == true)
{
string strComparisonOpDuty = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.Duty, objvEduMSTRGiftedClsCaseCond.Duty, strComparisonOpDuty);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IdCardNo) == true)
{
string strComparisonOpIdCardNo = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IdCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IdCardNo, objvEduMSTRGiftedClsCaseCond.IdCardNo, strComparisonOpIdCardNo);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.StuCardNo) == true)
{
string strComparisonOpStuCardNo = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.StuCardNo, objvEduMSTRGiftedClsCaseCond.StuCardNo, strComparisonOpStuCardNo);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.LiveAddress) == true)
{
string strComparisonOpLiveAddress = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.LiveAddress, objvEduMSTRGiftedClsCaseCond.LiveAddress, strComparisonOpLiveAddress);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.HomePhone) == true)
{
string strComparisonOpHomePhone = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.HomePhone, objvEduMSTRGiftedClsCaseCond.HomePhone, strComparisonOpHomePhone);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.EnrollmentDate) == true)
{
string strComparisonOpEnrollmentDate = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.EnrollmentDate, objvEduMSTRGiftedClsCaseCond.EnrollmentDate, strComparisonOpEnrollmentDate);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.PostCode) == true)
{
string strComparisonOpPostCode = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.PostCode, objvEduMSTRGiftedClsCaseCond.PostCode, strComparisonOpPostCode);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IsDualVideo) == true)
{
if (objvEduMSTRGiftedClsCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase.IsDualVideo);
}
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.UserKindId) == true)
{
string strComparisonOpUserKindId = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.UserKindId, objvEduMSTRGiftedClsCaseCond.UserKindId, strComparisonOpUserKindId);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.UserKindName) == true)
{
string strComparisonOpUserKindName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.UserKindName, objvEduMSTRGiftedClsCaseCond.UserKindName, strComparisonOpUserKindName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.UserTypeId, objvEduMSTRGiftedClsCaseCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.UserTypeName, objvEduMSTRGiftedClsCaseCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.RecommendedDegreeId, objvEduMSTRGiftedClsCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.RecommendedDegreeName, objvEduMSTRGiftedClsCaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.ftpFileType, objvEduMSTRGiftedClsCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.VideoUrl, objvEduMSTRGiftedClsCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.VideoPath, objvEduMSTRGiftedClsCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.ResErrMsg, objvEduMSTRGiftedClsCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.ResourceNum) == true)
{
string strComparisonOpResourceNum = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.ResourceNum];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase.ResourceNum, objvEduMSTRGiftedClsCaseCond.ResourceNum, strComparisonOpResourceNum);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.Memo) == true)
{
string strComparisonOpMemo = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.Memo, objvEduMSTRGiftedClsCaseCond.Memo, strComparisonOpMemo);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase.BrowseCount4Case, objvEduMSTRGiftedClsCaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.OwnerName) == true)
{
string strComparisonOpOwnerName = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.OwnerName, objvEduMSTRGiftedClsCaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.OwnerNameWithId, objvEduMSTRGiftedClsCaseCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(convEduMSTRGiftedClsCase.IsHaveVideo) == true)
{
string strComparisonOpIsHaveVideo = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase.IsHaveVideo, objvEduMSTRGiftedClsCaseCond.IsHaveVideo, strComparisonOpIsHaveVideo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vEduMSTRGiftedClsCase
{
public virtual bool UpdRelaTabDate(string strIdEduMSTRGiftedClsCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教育硕士优课案例(vEduMSTRGiftedClsCase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvEduMSTRGiftedClsCaseBL
{
public static RelatedActions_vEduMSTRGiftedClsCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvEduMSTRGiftedClsCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvEduMSTRGiftedClsCaseDA vEduMSTRGiftedClsCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvEduMSTRGiftedClsCaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvEduMSTRGiftedClsCaseBL()
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
if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCaseEN._ConnectString);
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
public static DataTable GetDataTable_vEduMSTRGiftedClsCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vEduMSTRGiftedClsCaseDA.GetDataTable_vEduMSTRGiftedClsCase(strWhereCond);
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
objDT = vEduMSTRGiftedClsCaseDA.GetDataTable(strWhereCond);
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
objDT = vEduMSTRGiftedClsCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vEduMSTRGiftedClsCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vEduMSTRGiftedClsCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vEduMSTRGiftedClsCaseDA.GetDataTable_Top(objTopPara);
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
objDT = vEduMSTRGiftedClsCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vEduMSTRGiftedClsCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vEduMSTRGiftedClsCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdEduMSTRGiftedClsCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstByIdEduMSTRGiftedClsCaseLst(List<string> arrIdEduMSTRGiftedClsCaseLst)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdEduMSTRGiftedClsCaseLst, true);
 string strWhereCond = string.Format("IdEduMSTRGiftedClsCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdEduMSTRGiftedClsCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvEduMSTRGiftedClsCaseEN> GetObjLstByIdEduMSTRGiftedClsCaseLstCache(List<string> arrIdEduMSTRGiftedClsCaseLst)
{
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseEN._CurrTabName);
List<clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Sel =
arrvEduMSTRGiftedClsCaseObjLstCache
.Where(x => arrIdEduMSTRGiftedClsCaseLst.Contains(x.IdEduMSTRGiftedClsCase));
return arrvEduMSTRGiftedClsCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLst(string strWhereCond)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvEduMSTRGiftedClsCaseEN> GetSubObjLstCache(clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseCond)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvEduMSTRGiftedClsCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convEduMSTRGiftedClsCase.AttributeName)
{
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(strFldName) == false) continue;
if (objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEduMSTRGiftedClsCaseCond[strFldName].ToString());
}
else
{
if (objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEduMSTRGiftedClsCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvEduMSTRGiftedClsCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvEduMSTRGiftedClsCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvEduMSTRGiftedClsCaseCond[strFldName]));
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
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
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
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
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
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
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvEduMSTRGiftedClsCase(ref clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN)
{
bool bolResult = vEduMSTRGiftedClsCaseDA.GetvEduMSTRGiftedClsCase(ref objvEduMSTRGiftedClsCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCaseEN GetObjByIdEduMSTRGiftedClsCase(string strIdEduMSTRGiftedClsCase)
{
if (strIdEduMSTRGiftedClsCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdEduMSTRGiftedClsCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdEduMSTRGiftedClsCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = vEduMSTRGiftedClsCaseDA.GetObjByIdEduMSTRGiftedClsCase(strIdEduMSTRGiftedClsCase);
return objvEduMSTRGiftedClsCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvEduMSTRGiftedClsCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = vEduMSTRGiftedClsCaseDA.GetFirstObj(strWhereCond);
 return objvEduMSTRGiftedClsCaseEN;
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
public static clsvEduMSTRGiftedClsCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = vEduMSTRGiftedClsCaseDA.GetObjByDataRow(objRow);
 return objvEduMSTRGiftedClsCaseEN;
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
public static clsvEduMSTRGiftedClsCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = vEduMSTRGiftedClsCaseDA.GetObjByDataRow(objRow);
 return objvEduMSTRGiftedClsCaseEN;
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
 /// <param name = "strIdEduMSTRGiftedClsCase">所给的关键字</param>
 /// <param name = "lstvEduMSTRGiftedClsCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvEduMSTRGiftedClsCaseEN GetObjByIdEduMSTRGiftedClsCaseFromList(string strIdEduMSTRGiftedClsCase, List<clsvEduMSTRGiftedClsCaseEN> lstvEduMSTRGiftedClsCaseObjLst)
{
foreach (clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN in lstvEduMSTRGiftedClsCaseObjLst)
{
if (objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase == strIdEduMSTRGiftedClsCase)
{
return objvEduMSTRGiftedClsCaseEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdEduMSTRGiftedClsCase;
 try
 {
 strIdEduMSTRGiftedClsCase = new clsvEduMSTRGiftedClsCaseDA().GetFirstID(strWhereCond);
 return strIdEduMSTRGiftedClsCase;
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
 arrList = vEduMSTRGiftedClsCaseDA.GetID(strWhereCond);
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
bool bolIsExist = vEduMSTRGiftedClsCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdEduMSTRGiftedClsCase)
{
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdEduMSTRGiftedClsCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vEduMSTRGiftedClsCaseDA.IsExist(strIdEduMSTRGiftedClsCase);
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
 bolIsExist = clsvEduMSTRGiftedClsCaseDA.IsExistTable();
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
 bolIsExist = vEduMSTRGiftedClsCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvEduMSTRGiftedClsCaseENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCaseENT">目标对象</param>
 public static void CopyTo(clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseENS, clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseENT)
{
try
{
objvEduMSTRGiftedClsCaseENT.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseENS.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objvEduMSTRGiftedClsCaseENT.IdStudyLevel = objvEduMSTRGiftedClsCaseENS.IdStudyLevel; //id_StudyLevel
objvEduMSTRGiftedClsCaseENT.StudyLevelName = objvEduMSTRGiftedClsCaseENS.StudyLevelName; //学段名称
objvEduMSTRGiftedClsCaseENT.IdTeachingPlan = objvEduMSTRGiftedClsCaseENS.IdTeachingPlan; //教案流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objvEduMSTRGiftedClsCaseENT.IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCaseENS.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTypeID = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTypeID; //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseENT.IdCaseType = objvEduMSTRGiftedClsCaseENS.IdCaseType; //案例类型流水号
objvEduMSTRGiftedClsCaseENT.IdDiscipline = objvEduMSTRGiftedClsCaseENS.IdDiscipline; //学科流水号
objvEduMSTRGiftedClsCaseENT.DisciplineID = objvEduMSTRGiftedClsCaseENS.DisciplineID; //学科ID
objvEduMSTRGiftedClsCaseENT.DisciplineName = objvEduMSTRGiftedClsCaseENS.DisciplineName; //学科名称
objvEduMSTRGiftedClsCaseENT.IdSenateGaugeVersion = objvEduMSTRGiftedClsCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionID = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionName = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCaseENT.VersionNo = objvEduMSTRGiftedClsCaseENS.VersionNo; //版本号
objvEduMSTRGiftedClsCaseENT.IdTeachSkill = objvEduMSTRGiftedClsCaseENS.IdTeachSkill; //教学技能流水号
objvEduMSTRGiftedClsCaseENT.TeachSkillID = objvEduMSTRGiftedClsCaseENS.TeachSkillID; //教学技能ID
objvEduMSTRGiftedClsCaseENT.SkillTypeName = objvEduMSTRGiftedClsCaseENS.SkillTypeName; //技能类型名称
objvEduMSTRGiftedClsCaseENT.TeachSkillName = objvEduMSTRGiftedClsCaseENS.TeachSkillName; //教学技能名称
objvEduMSTRGiftedClsCaseENT.TeachSkillTheory = objvEduMSTRGiftedClsCaseENS.TeachSkillTheory; //教学技能理论阐述
objvEduMSTRGiftedClsCaseENT.TeachSkillOperMethod = objvEduMSTRGiftedClsCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvEduMSTRGiftedClsCaseENT.IdSkillType = objvEduMSTRGiftedClsCaseENS.IdSkillType; //技能类型流水号
objvEduMSTRGiftedClsCaseENT.SkillTypeID = objvEduMSTRGiftedClsCaseENS.SkillTypeID; //技能类型ID
objvEduMSTRGiftedClsCaseENT.CaseLevelId = objvEduMSTRGiftedClsCaseENS.CaseLevelId; //课例等级Id
objvEduMSTRGiftedClsCaseENT.CaseLevelName = objvEduMSTRGiftedClsCaseENS.CaseLevelName; //案例等级名称
objvEduMSTRGiftedClsCaseENT.DocFile = objvEduMSTRGiftedClsCaseENS.DocFile; //生成的Word文件名
objvEduMSTRGiftedClsCaseENT.IsNeedGeneWord = objvEduMSTRGiftedClsCaseENS.IsNeedGeneWord; //是否需要生成Word
objvEduMSTRGiftedClsCaseENT.WordCreateDate = objvEduMSTRGiftedClsCaseENS.WordCreateDate; //Word生成日期
objvEduMSTRGiftedClsCaseENT.IsVisible = objvEduMSTRGiftedClsCaseENS.IsVisible; //是否显示
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseENT.OwnerId = objvEduMSTRGiftedClsCaseENS.OwnerId; //拥有者Id
objvEduMSTRGiftedClsCaseENT.IdStudentInfo = objvEduMSTRGiftedClsCaseENS.IdStudentInfo; //学生流水号
objvEduMSTRGiftedClsCaseENT.StuName = objvEduMSTRGiftedClsCaseENS.StuName; //姓名
objvEduMSTRGiftedClsCaseENT.StuId = objvEduMSTRGiftedClsCaseENS.StuId; //学号
objvEduMSTRGiftedClsCaseENT.PoliticsName = objvEduMSTRGiftedClsCaseENS.PoliticsName; //政治面貌
objvEduMSTRGiftedClsCaseENT.SexDesc = objvEduMSTRGiftedClsCaseENS.SexDesc; //性别名称
objvEduMSTRGiftedClsCaseENT.EthnicName = objvEduMSTRGiftedClsCaseENS.EthnicName; //民族名称
objvEduMSTRGiftedClsCaseENT.UniZoneDesc = objvEduMSTRGiftedClsCaseENS.UniZoneDesc; //校区名称
objvEduMSTRGiftedClsCaseENT.StuTypeDesc = objvEduMSTRGiftedClsCaseENS.StuTypeDesc; //学生类别名称
objvEduMSTRGiftedClsCaseENT.IdXzCollege = objvEduMSTRGiftedClsCaseENS.IdXzCollege; //学院流水号
objvEduMSTRGiftedClsCaseENT.CollegeId = objvEduMSTRGiftedClsCaseENS.CollegeId; //学院ID
objvEduMSTRGiftedClsCaseENT.CollegeName = objvEduMSTRGiftedClsCaseENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCaseENT.CollegeNameA = objvEduMSTRGiftedClsCaseENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCaseENT.IdXzMajor = objvEduMSTRGiftedClsCaseENS.IdXzMajor; //专业流水号
objvEduMSTRGiftedClsCaseENT.MajorName = objvEduMSTRGiftedClsCaseENS.MajorName; //专业名称
objvEduMSTRGiftedClsCaseENT.IdGradeBase = objvEduMSTRGiftedClsCaseENS.IdGradeBase; //年级流水号
objvEduMSTRGiftedClsCaseENT.GradeBaseName = objvEduMSTRGiftedClsCaseENS.GradeBaseName; //年级名称
objvEduMSTRGiftedClsCaseENT.IdAdminCls = objvEduMSTRGiftedClsCaseENS.IdAdminCls; //行政班流水号
objvEduMSTRGiftedClsCaseENT.AdminClsId = objvEduMSTRGiftedClsCaseENS.AdminClsId; //行政班代号
objvEduMSTRGiftedClsCaseENT.AdminClsName = objvEduMSTRGiftedClsCaseENS.AdminClsName; //行政班名称
objvEduMSTRGiftedClsCaseENT.Birthday = objvEduMSTRGiftedClsCaseENS.Birthday; //出生日期
objvEduMSTRGiftedClsCaseENT.NativePlace = objvEduMSTRGiftedClsCaseENS.NativePlace; //籍贯
objvEduMSTRGiftedClsCaseENT.Duty = objvEduMSTRGiftedClsCaseENS.Duty; //职位
objvEduMSTRGiftedClsCaseENT.IdCardNo = objvEduMSTRGiftedClsCaseENS.IdCardNo; //身份证号
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
 /// <param name = "objvEduMSTRGiftedClsCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN)
{
try
{
objvEduMSTRGiftedClsCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvEduMSTRGiftedClsCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objvEduMSTRGiftedClsCaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objvEduMSTRGiftedClsCaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objvEduMSTRGiftedClsCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID; //教育硕士优课案例类型Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdCaseType = objvEduMSTRGiftedClsCaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objvEduMSTRGiftedClsCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.DisciplineID = objvEduMSTRGiftedClsCaseEN.DisciplineID == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.DisciplineName = objvEduMSTRGiftedClsCaseEN.DisciplineName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.VersionNo = objvEduMSTRGiftedClsCaseEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objvEduMSTRGiftedClsCaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objvEduMSTRGiftedClsCaseEN.TeachSkillID == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objvEduMSTRGiftedClsCaseEN.SkillTypeName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objvEduMSTRGiftedClsCaseEN.TeachSkillName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objvEduMSTRGiftedClsCaseEN.TeachSkillTheory == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdSkillType = objvEduMSTRGiftedClsCaseEN.IdSkillType == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objvEduMSTRGiftedClsCaseEN.SkillTypeID == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objvEduMSTRGiftedClsCaseEN.CaseLevelId == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objvEduMSTRGiftedClsCaseEN.CaseLevelName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.DocFile = objvEduMSTRGiftedClsCaseEN.DocFile == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objvEduMSTRGiftedClsCaseEN.WordCreateDate == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IsVisible = objvEduMSTRGiftedClsCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.OwnerId = objvEduMSTRGiftedClsCaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objvEduMSTRGiftedClsCaseEN.IdStudentInfo == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.StuName = objvEduMSTRGiftedClsCaseEN.StuName; //姓名
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.StuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.StuId = objvEduMSTRGiftedClsCaseEN.StuId == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.StuId; //学号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.PoliticsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.PoliticsName = objvEduMSTRGiftedClsCaseEN.PoliticsName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.PoliticsName; //政治面貌
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.SexDesc = objvEduMSTRGiftedClsCaseEN.SexDesc == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EthnicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EthnicName = objvEduMSTRGiftedClsCaseEN.EthnicName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.EthnicName; //民族名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objvEduMSTRGiftedClsCaseEN.UniZoneDesc == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.StuTypeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objvEduMSTRGiftedClsCaseEN.StuTypeDesc == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.StuTypeDesc; //学生类别名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objvEduMSTRGiftedClsCaseEN.IdXzCollege == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.CollegeId = objvEduMSTRGiftedClsCaseEN.CollegeId == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.CollegeName = objvEduMSTRGiftedClsCaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objvEduMSTRGiftedClsCaseEN.CollegeNameA == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objvEduMSTRGiftedClsCaseEN.IdXzMajor == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.MajorName = objvEduMSTRGiftedClsCaseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objvEduMSTRGiftedClsCaseEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objvEduMSTRGiftedClsCaseEN.GradeBaseName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objvEduMSTRGiftedClsCaseEN.IdAdminCls == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.AdminClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.AdminClsId = objvEduMSTRGiftedClsCaseEN.AdminClsId == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.AdminClsId; //行政班代号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.AdminClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.AdminClsName = objvEduMSTRGiftedClsCaseEN.AdminClsName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.AdminClsName; //行政班名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.Birthday = objvEduMSTRGiftedClsCaseEN.Birthday == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.Birthday; //出生日期
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.NativePlace, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.NativePlace = objvEduMSTRGiftedClsCaseEN.NativePlace == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.NativePlace; //籍贯
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.Duty, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.Duty = objvEduMSTRGiftedClsCaseEN.Duty == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.Duty; //职位
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IdCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IdCardNo = objvEduMSTRGiftedClsCaseEN.IdCardNo == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.IdCardNo; //身份证号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.StuCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.StuCardNo = objvEduMSTRGiftedClsCaseEN.StuCardNo == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.StuCardNo; //学生证号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.LiveAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.LiveAddress = objvEduMSTRGiftedClsCaseEN.LiveAddress == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.LiveAddress; //居住地址
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.HomePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.HomePhone = objvEduMSTRGiftedClsCaseEN.HomePhone == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.HomePhone; //住宅电话
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.EnrollmentDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objvEduMSTRGiftedClsCaseEN.EnrollmentDate == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.EnrollmentDate; //入校日期
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.PostCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.PostCode = objvEduMSTRGiftedClsCaseEN.PostCode == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.PostCode; //邮编
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IsDualVideo = objvEduMSTRGiftedClsCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.UserKindId = objvEduMSTRGiftedClsCaseEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.UserKindName = objvEduMSTRGiftedClsCaseEN.UserKindName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.UserTypeId = objvEduMSTRGiftedClsCaseEN.UserTypeId == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.UserTypeName = objvEduMSTRGiftedClsCaseEN.UserTypeName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.ftpFileType = objvEduMSTRGiftedClsCaseEN.ftpFileType == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.VideoUrl = objvEduMSTRGiftedClsCaseEN.VideoUrl == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.VideoPath = objvEduMSTRGiftedClsCaseEN.VideoPath == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objvEduMSTRGiftedClsCaseEN.ResErrMsg == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.ResourceNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.ResourceNum = objvEduMSTRGiftedClsCaseEN.ResourceNum; //资源数
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.Memo = objvEduMSTRGiftedClsCaseEN.Memo == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.Memo; //备注
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objvEduMSTRGiftedClsCaseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.OwnerName = objvEduMSTRGiftedClsCaseEN.OwnerName == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objvEduMSTRGiftedClsCaseEN.OwnerNameWithId == "[null]" ? null :  objvEduMSTRGiftedClsCaseEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase.IsHaveVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objvEduMSTRGiftedClsCaseEN.IsHaveVideo; //IsHaveVideo
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
 /// <param name = "objvEduMSTRGiftedClsCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN)
{
try
{
if (objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme == "[null]") objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = null; //教育硕士优课案例主题词
if (objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate == "[null]") objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = null; //教育硕士优课案例日期
if (objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime == "[null]") objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = null; //教育硕士优课案例时间
if (objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn == "[null]") objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = null; //案例入库日期
if (objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn == "[null]") objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = null; //案例入库时间
if (objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType == "[null]") objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = null; //教育硕士优课案例类型流水号
if (objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID == "[null]") objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = null; //教育硕士优课案例类型Id
if (objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName == "[null]") objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = null; //教育硕士优课案例类型名称
if (objvEduMSTRGiftedClsCaseEN.DisciplineID == "[null]") objvEduMSTRGiftedClsCaseEN.DisciplineID = null; //学科ID
if (objvEduMSTRGiftedClsCaseEN.DisciplineName == "[null]") objvEduMSTRGiftedClsCaseEN.DisciplineName = null; //学科名称
if (objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName == "[null]") objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvEduMSTRGiftedClsCaseEN.TeachSkillID == "[null]") objvEduMSTRGiftedClsCaseEN.TeachSkillID = null; //教学技能ID
if (objvEduMSTRGiftedClsCaseEN.SkillTypeName == "[null]") objvEduMSTRGiftedClsCaseEN.SkillTypeName = null; //技能类型名称
if (objvEduMSTRGiftedClsCaseEN.TeachSkillName == "[null]") objvEduMSTRGiftedClsCaseEN.TeachSkillName = null; //教学技能名称
if (objvEduMSTRGiftedClsCaseEN.TeachSkillTheory == "[null]") objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod == "[null]") objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvEduMSTRGiftedClsCaseEN.IdSkillType == "[null]") objvEduMSTRGiftedClsCaseEN.IdSkillType = null; //技能类型流水号
if (objvEduMSTRGiftedClsCaseEN.SkillTypeID == "[null]") objvEduMSTRGiftedClsCaseEN.SkillTypeID = null; //技能类型ID
if (objvEduMSTRGiftedClsCaseEN.CaseLevelId == "[null]") objvEduMSTRGiftedClsCaseEN.CaseLevelId = null; //课例等级Id
if (objvEduMSTRGiftedClsCaseEN.CaseLevelName == "[null]") objvEduMSTRGiftedClsCaseEN.CaseLevelName = null; //案例等级名称
if (objvEduMSTRGiftedClsCaseEN.DocFile == "[null]") objvEduMSTRGiftedClsCaseEN.DocFile = null; //生成的Word文件名
if (objvEduMSTRGiftedClsCaseEN.WordCreateDate == "[null]") objvEduMSTRGiftedClsCaseEN.WordCreateDate = null; //Word生成日期
if (objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText == "[null]") objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = null; //教育硕士优课案例文本
if (objvEduMSTRGiftedClsCaseEN.IdStudentInfo == "[null]") objvEduMSTRGiftedClsCaseEN.IdStudentInfo = null; //学生流水号
if (objvEduMSTRGiftedClsCaseEN.StuId == "[null]") objvEduMSTRGiftedClsCaseEN.StuId = null; //学号
if (objvEduMSTRGiftedClsCaseEN.PoliticsName == "[null]") objvEduMSTRGiftedClsCaseEN.PoliticsName = null; //政治面貌
if (objvEduMSTRGiftedClsCaseEN.SexDesc == "[null]") objvEduMSTRGiftedClsCaseEN.SexDesc = null; //性别名称
if (objvEduMSTRGiftedClsCaseEN.EthnicName == "[null]") objvEduMSTRGiftedClsCaseEN.EthnicName = null; //民族名称
if (objvEduMSTRGiftedClsCaseEN.UniZoneDesc == "[null]") objvEduMSTRGiftedClsCaseEN.UniZoneDesc = null; //校区名称
if (objvEduMSTRGiftedClsCaseEN.StuTypeDesc == "[null]") objvEduMSTRGiftedClsCaseEN.StuTypeDesc = null; //学生类别名称
if (objvEduMSTRGiftedClsCaseEN.IdXzCollege == "[null]") objvEduMSTRGiftedClsCaseEN.IdXzCollege = null; //学院流水号
if (objvEduMSTRGiftedClsCaseEN.CollegeId == "[null]") objvEduMSTRGiftedClsCaseEN.CollegeId = null; //学院ID
if (objvEduMSTRGiftedClsCaseEN.CollegeNameA == "[null]") objvEduMSTRGiftedClsCaseEN.CollegeNameA = null; //学院名称简写
if (objvEduMSTRGiftedClsCaseEN.IdXzMajor == "[null]") objvEduMSTRGiftedClsCaseEN.IdXzMajor = null; //专业流水号
if (objvEduMSTRGiftedClsCaseEN.GradeBaseName == "[null]") objvEduMSTRGiftedClsCaseEN.GradeBaseName = null; //年级名称
if (objvEduMSTRGiftedClsCaseEN.IdAdminCls == "[null]") objvEduMSTRGiftedClsCaseEN.IdAdminCls = null; //行政班流水号
if (objvEduMSTRGiftedClsCaseEN.AdminClsId == "[null]") objvEduMSTRGiftedClsCaseEN.AdminClsId = null; //行政班代号
if (objvEduMSTRGiftedClsCaseEN.AdminClsName == "[null]") objvEduMSTRGiftedClsCaseEN.AdminClsName = null; //行政班名称
if (objvEduMSTRGiftedClsCaseEN.Birthday == "[null]") objvEduMSTRGiftedClsCaseEN.Birthday = null; //出生日期
if (objvEduMSTRGiftedClsCaseEN.NativePlace == "[null]") objvEduMSTRGiftedClsCaseEN.NativePlace = null; //籍贯
if (objvEduMSTRGiftedClsCaseEN.Duty == "[null]") objvEduMSTRGiftedClsCaseEN.Duty = null; //职位
if (objvEduMSTRGiftedClsCaseEN.IdCardNo == "[null]") objvEduMSTRGiftedClsCaseEN.IdCardNo = null; //身份证号
if (objvEduMSTRGiftedClsCaseEN.StuCardNo == "[null]") objvEduMSTRGiftedClsCaseEN.StuCardNo = null; //学生证号
if (objvEduMSTRGiftedClsCaseEN.LiveAddress == "[null]") objvEduMSTRGiftedClsCaseEN.LiveAddress = null; //居住地址
if (objvEduMSTRGiftedClsCaseEN.HomePhone == "[null]") objvEduMSTRGiftedClsCaseEN.HomePhone = null; //住宅电话
if (objvEduMSTRGiftedClsCaseEN.EnrollmentDate == "[null]") objvEduMSTRGiftedClsCaseEN.EnrollmentDate = null; //入校日期
if (objvEduMSTRGiftedClsCaseEN.PostCode == "[null]") objvEduMSTRGiftedClsCaseEN.PostCode = null; //邮编
if (objvEduMSTRGiftedClsCaseEN.UserKindName == "[null]") objvEduMSTRGiftedClsCaseEN.UserKindName = null; //用户类别名
if (objvEduMSTRGiftedClsCaseEN.UserTypeId == "[null]") objvEduMSTRGiftedClsCaseEN.UserTypeId = null; //用户类型Id
if (objvEduMSTRGiftedClsCaseEN.UserTypeName == "[null]") objvEduMSTRGiftedClsCaseEN.UserTypeName = null; //用户类型名称
if (objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName == "[null]") objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvEduMSTRGiftedClsCaseEN.ftpFileType == "[null]") objvEduMSTRGiftedClsCaseEN.ftpFileType = null; //ftp文件类型
if (objvEduMSTRGiftedClsCaseEN.VideoUrl == "[null]") objvEduMSTRGiftedClsCaseEN.VideoUrl = null; //视频Url
if (objvEduMSTRGiftedClsCaseEN.VideoPath == "[null]") objvEduMSTRGiftedClsCaseEN.VideoPath = null; //视频目录
if (objvEduMSTRGiftedClsCaseEN.ResErrMsg == "[null]") objvEduMSTRGiftedClsCaseEN.ResErrMsg = null; //资源错误信息
if (objvEduMSTRGiftedClsCaseEN.Memo == "[null]") objvEduMSTRGiftedClsCaseEN.Memo = null; //备注
if (objvEduMSTRGiftedClsCaseEN.OwnerName == "[null]") objvEduMSTRGiftedClsCaseEN.OwnerName = null; //拥有者姓名
if (objvEduMSTRGiftedClsCaseEN.OwnerNameWithId == "[null]") objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = null; //拥有者名称附Id
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
public static void CheckProperty4Condition(clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN)
{
 vEduMSTRGiftedClsCaseDA.CheckProperty4Condition(objvEduMSTRGiftedClsCaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdEduMSTRGiftedClsCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase); 
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = clsvEduMSTRGiftedClsCaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN()
{
IdEduMSTRGiftedClsCase = "0",
EduMSTRGiftedClsCaseName = "选[v教育硕士优课案例]..."
};
arrObjLst.Insert(0, objvEduMSTRGiftedClsCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase;
objComboBox.DisplayMember = convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdEduMSTRGiftedClsCase(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教育硕士优课案例]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase); 
IEnumerable<clsvEduMSTRGiftedClsCaseEN> arrObjLst = clsvEduMSTRGiftedClsCaseBL.GetObjLst(strCondition);
objDDL.DataValueField = convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase;
objDDL.DataTextField = convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdEduMSTRGiftedClsCaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教育硕士优课案例]...","0");
List<clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst = GetAllvEduMSTRGiftedClsCaseObjLstCache(); 
objDDL.DataValueField = convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase;
objDDL.DataTextField = convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName;
objDDL.DataSource = arrvEduMSTRGiftedClsCaseObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelBL没有刷新缓存机制(clsCaseLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindBL没有刷新缓存机制(clsUserKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsEduMSTRGiftedClsCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsEduMSTRGiftedClsCaseBL没有刷新缓存机制(clsEduMSTRGiftedClsCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsEduMSTRGiftedClsCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsEduMSTRGiftedClsCaseTypeBL没有刷新缓存机制(clsEduMSTRGiftedClsCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdEduMSTRGiftedClsCase");
//if (arrvEduMSTRGiftedClsCaseObjLstCache == null)
//{
//arrvEduMSTRGiftedClsCaseObjLstCache = vEduMSTRGiftedClsCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvEduMSTRGiftedClsCaseEN GetObjByIdEduMSTRGiftedClsCaseCache(string strIdEduMSTRGiftedClsCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseEN._CurrTabName);
List<clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLst_Sel =
arrvEduMSTRGiftedClsCaseObjLstCache
.Where(x=> x.IdEduMSTRGiftedClsCase == strIdEduMSTRGiftedClsCase 
);
if (arrvEduMSTRGiftedClsCaseObjLst_Sel.Count() == 0)
{
   clsvEduMSTRGiftedClsCaseEN obj = clsvEduMSTRGiftedClsCaseBL.GetObjByIdEduMSTRGiftedClsCase(strIdEduMSTRGiftedClsCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvEduMSTRGiftedClsCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEduMSTRGiftedClsCaseNameByIdEduMSTRGiftedClsCaseCache(string strIdEduMSTRGiftedClsCase)
{
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase) == true) return "";
//获取缓存中的对象列表
clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCase = GetObjByIdEduMSTRGiftedClsCaseCache(strIdEduMSTRGiftedClsCase);
if (objvEduMSTRGiftedClsCase == null) return "";
return objvEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdEduMSTRGiftedClsCaseCache(string strIdEduMSTRGiftedClsCase)
{
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase) == true) return "";
//获取缓存中的对象列表
clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCase = GetObjByIdEduMSTRGiftedClsCaseCache(strIdEduMSTRGiftedClsCase);
if (objvEduMSTRGiftedClsCase == null) return "";
return objvEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseEN> GetAllvEduMSTRGiftedClsCaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLstCache = GetObjLstCache(); 
return arrvEduMSTRGiftedClsCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseEN._CurrTabName);
List<clsvEduMSTRGiftedClsCaseEN> arrvEduMSTRGiftedClsCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvEduMSTRGiftedClsCaseObjLstCache;
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
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseEN._CurrTabName);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdEduMSTRGiftedClsCase)
{
if (strInFldName != convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convEduMSTRGiftedClsCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convEduMSTRGiftedClsCase.AttributeName));
throw new Exception(strMsg);
}
var objvEduMSTRGiftedClsCase = clsvEduMSTRGiftedClsCaseBL.GetObjByIdEduMSTRGiftedClsCaseCache(strIdEduMSTRGiftedClsCase);
if (objvEduMSTRGiftedClsCase == null) return "";
return objvEduMSTRGiftedClsCase[strOutFldName].ToString();
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
int intRecCount = clsvEduMSTRGiftedClsCaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvEduMSTRGiftedClsCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvEduMSTRGiftedClsCaseDA.GetRecCount();
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
int intRecCount = clsvEduMSTRGiftedClsCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseCond)
{
List<clsvEduMSTRGiftedClsCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvEduMSTRGiftedClsCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convEduMSTRGiftedClsCase.AttributeName)
{
if (objvEduMSTRGiftedClsCaseCond.IsUpdated(strFldName) == false) continue;
if (objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEduMSTRGiftedClsCaseCond[strFldName].ToString());
}
else
{
if (objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvEduMSTRGiftedClsCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEduMSTRGiftedClsCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvEduMSTRGiftedClsCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvEduMSTRGiftedClsCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvEduMSTRGiftedClsCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvEduMSTRGiftedClsCaseCond[strFldName]));
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
 List<string> arrList = clsvEduMSTRGiftedClsCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vEduMSTRGiftedClsCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vEduMSTRGiftedClsCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}