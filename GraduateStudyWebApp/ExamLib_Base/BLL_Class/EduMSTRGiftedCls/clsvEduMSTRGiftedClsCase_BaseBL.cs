
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCase_BaseBL
 表名:vEduMSTRGiftedClsCase_Base(01120498)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:03
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
public static class  clsvEduMSTRGiftedClsCase_BaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN GetObj(this K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase_Base myKey)
{
clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = clsvEduMSTRGiftedClsCase_BaseBL.vEduMSTRGiftedClsCase_BaseDA.GetObjByIdEduMSTRGiftedClsCase(myKey.Value);
return objvEduMSTRGiftedClsCase_BaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdEduMSTRGiftedClsCase(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdEduMSTRGiftedClsCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase);
}
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = strIdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduMSTRGiftedClsCaseID, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduMSTRGiftedClsCaseName, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseTheme(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTheme, 200, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseDate(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseTime(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseDateIn(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdStudyLevel(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convEduMSTRGiftedClsCase_Base.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convEduMSTRGiftedClsCase_Base.IdStudyLevel);
}
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdStudyLevel) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdStudyLevel, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdStudyLevel] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStudyLevelName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convEduMSTRGiftedClsCase_Base.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdTeachingPlan(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convEduMSTRGiftedClsCase_Base.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convEduMSTRGiftedClsCase_Base.IdTeachingPlan);
}
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdTeachingPlan) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdTeachingPlan, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseTimeIn(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdEduMSTRGiftedClsCaseType(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdEduMSTRGiftedClsCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType);
}
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = strIdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseTypeName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTypeName, 50, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdCaseType(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convEduMSTRGiftedClsCase_Base.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convEduMSTRGiftedClsCase_Base.IdCaseType);
}
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdCaseType) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdCaseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdCaseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdDiscipline(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convEduMSTRGiftedClsCase_Base.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convEduMSTRGiftedClsCase_Base.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convEduMSTRGiftedClsCase_Base.IdDiscipline);
}
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdDiscipline) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdDiscipline, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdDiscipline] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetDisciplineID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convEduMSTRGiftedClsCase_Base.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convEduMSTRGiftedClsCase_Base.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetDisciplineName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convEduMSTRGiftedClsCase_Base.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdSenateGaugeVersion(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion);
}
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetsenateGaugeVersionID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCase_Base.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCase_Base.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetsenateGaugeVersionName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convEduMSTRGiftedClsCase_Base.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetsenateGaugeVersionTtlScore(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetVersionNo(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, int? intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdTeachSkill(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convEduMSTRGiftedClsCase_Base.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convEduMSTRGiftedClsCase_Base.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convEduMSTRGiftedClsCase_Base.IdTeachSkill);
}
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdTeachSkill) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdTeachSkill, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdTeachSkill] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetTeachSkillID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convEduMSTRGiftedClsCase_Base.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convEduMSTRGiftedClsCase_Base.TeachSkillID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetSkillTypeName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convEduMSTRGiftedClsCase_Base.SkillTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetTeachSkillName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convEduMSTRGiftedClsCase_Base.TeachSkillName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetTeachSkillTheory(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convEduMSTRGiftedClsCase_Base.TeachSkillTheory);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetTeachSkillOperMethod(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdSkillType(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convEduMSTRGiftedClsCase_Base.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convEduMSTRGiftedClsCase_Base.IdSkillType);
}
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdSkillType) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdSkillType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdSkillType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetSkillTypeID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convEduMSTRGiftedClsCase_Base.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convEduMSTRGiftedClsCase_Base.SkillTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetCaseLevelId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convEduMSTRGiftedClsCase_Base.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convEduMSTRGiftedClsCase_Base.CaseLevelId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetCaseLevelName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convEduMSTRGiftedClsCase_Base.CaseLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetDocFile(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convEduMSTRGiftedClsCase_Base.DocFile);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetWordCreateDate(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convEduMSTRGiftedClsCase_Base.WordCreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEduMSTRGiftedClsCaseText(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEduMSTRGiftedClsCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseText, 8000, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetOwnerId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convEduMSTRGiftedClsCase_Base.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convEduMSTRGiftedClsCase_Base.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStuName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convEduMSTRGiftedClsCase_Base.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStuId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuId, 20, convEduMSTRGiftedClsCase_Base.StuId);
}
objvEduMSTRGiftedClsCase_BaseEN.StuId = strStuId; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.StuId) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.StuId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetSexDesc(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convEduMSTRGiftedClsCase_Base.SexDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStuTypeID(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStuTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTypeID, 4, convEduMSTRGiftedClsCase_Base.StuTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStuTypeID, 4, convEduMSTRGiftedClsCase_Base.StuTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStuTypeDesc(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStuTypeDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convEduMSTRGiftedClsCase_Base.StuTypeDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdXzCollege(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convEduMSTRGiftedClsCase_Base.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convEduMSTRGiftedClsCase_Base.IdXzCollege);
}
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdXzCollege) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdXzCollege, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdXzCollege] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetCollegeId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convEduMSTRGiftedClsCase_Base.CollegeId);
}
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.CollegeId) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.CollegeId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CollegeId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetCollegeName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convEduMSTRGiftedClsCase_Base.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetCollegeNameA(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convEduMSTRGiftedClsCase_Base.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdXzMajor(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convEduMSTRGiftedClsCase_Base.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convEduMSTRGiftedClsCase_Base.IdXzMajor);
}
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdXzMajor) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdXzMajor, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdXzMajor] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetMajorName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convEduMSTRGiftedClsCase_Base.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetIdGradeBase(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convEduMSTRGiftedClsCase_Base.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convEduMSTRGiftedClsCase_Base.IdGradeBase);
}
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Base.IdGradeBase) == false)
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Base.IdGradeBase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_BaseEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdGradeBase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetGradeBaseName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convEduMSTRGiftedClsCase_Base.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetStuCardNo(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strStuCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convEduMSTRGiftedClsCase_Base.StuCardNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetEnrollmentDate(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strEnrollmentDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convEduMSTRGiftedClsCase_Base.EnrollmentDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetUserTypeId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convEduMSTRGiftedClsCase_Base.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convEduMSTRGiftedClsCase_Base.UserTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetRecommendedDegreeId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetRecommendedDegreeName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convEduMSTRGiftedClsCase_Base.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetftpFileType(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convEduMSTRGiftedClsCase_Base.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetVideoUrl(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convEduMSTRGiftedClsCase_Base.VideoUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetVideoPath(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convEduMSTRGiftedClsCase_Base.VideoPath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetResErrMsg(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convEduMSTRGiftedClsCase_Base.ResErrMsg);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetResourceNum(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, int? intResourceNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetMemo(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convEduMSTRGiftedClsCase_Base.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetBrowseCount4Case(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetOwnerName(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convEduMSTRGiftedClsCase_Base.OwnerName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN SetOwnerNameWithId(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convEduMSTRGiftedClsCase_Base.OwnerNameWithId);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseENT">目标对象</param>
 public static void CopyTo(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseENS, clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseENT)
{
try
{
objvEduMSTRGiftedClsCase_BaseENT.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_BaseENS.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objvEduMSTRGiftedClsCase_BaseENT.IdStudyLevel = objvEduMSTRGiftedClsCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseENT.StudyLevelName = objvEduMSTRGiftedClsCase_BaseENS.StudyLevelName; //学段名称
objvEduMSTRGiftedClsCase_BaseENT.IdTeachingPlan = objvEduMSTRGiftedClsCase_BaseENS.IdTeachingPlan; //教案流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objvEduMSTRGiftedClsCase_BaseENT.IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_BaseENS.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseENT.IdCaseType = objvEduMSTRGiftedClsCase_BaseENS.IdCaseType; //案例类型流水号
objvEduMSTRGiftedClsCase_BaseENT.IdDiscipline = objvEduMSTRGiftedClsCase_BaseENS.IdDiscipline; //学科流水号
objvEduMSTRGiftedClsCase_BaseENT.DisciplineID = objvEduMSTRGiftedClsCase_BaseENS.DisciplineID; //学科ID
objvEduMSTRGiftedClsCase_BaseENT.DisciplineName = objvEduMSTRGiftedClsCase_BaseENS.DisciplineName; //学科名称
objvEduMSTRGiftedClsCase_BaseENT.IdSenateGaugeVersion = objvEduMSTRGiftedClsCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionID = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionName = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseENT.VersionNo = objvEduMSTRGiftedClsCase_BaseENS.VersionNo; //版本号
objvEduMSTRGiftedClsCase_BaseENT.IdTeachSkill = objvEduMSTRGiftedClsCase_BaseENS.IdTeachSkill; //教学技能流水号
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillID = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillID; //教学技能ID
objvEduMSTRGiftedClsCase_BaseENT.SkillTypeName = objvEduMSTRGiftedClsCase_BaseENS.SkillTypeName; //技能类型名称
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillName = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillName; //教学技能名称
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillTheory = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillOperMethod = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseENT.IdSkillType = objvEduMSTRGiftedClsCase_BaseENS.IdSkillType; //技能类型流水号
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
objvEduMSTRGiftedClsCase_BaseENT.StuId = objvEduMSTRGiftedClsCase_BaseENS.StuId; //学号
objvEduMSTRGiftedClsCase_BaseENT.SexDesc = objvEduMSTRGiftedClsCase_BaseENS.SexDesc; //性别名称
objvEduMSTRGiftedClsCase_BaseENT.StuTypeID = objvEduMSTRGiftedClsCase_BaseENS.StuTypeID; //学生类别ID
objvEduMSTRGiftedClsCase_BaseENT.StuTypeDesc = objvEduMSTRGiftedClsCase_BaseENS.StuTypeDesc; //学生类别名称
objvEduMSTRGiftedClsCase_BaseENT.IdXzCollege = objvEduMSTRGiftedClsCase_BaseENS.IdXzCollege; //学院流水号
objvEduMSTRGiftedClsCase_BaseENT.CollegeId = objvEduMSTRGiftedClsCase_BaseENS.CollegeId; //学院ID
objvEduMSTRGiftedClsCase_BaseENT.CollegeName = objvEduMSTRGiftedClsCase_BaseENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCase_BaseENT.CollegeNameA = objvEduMSTRGiftedClsCase_BaseENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCase_BaseENT.IdXzMajor = objvEduMSTRGiftedClsCase_BaseENS.IdXzMajor; //专业流水号
objvEduMSTRGiftedClsCase_BaseENT.MajorName = objvEduMSTRGiftedClsCase_BaseENS.MajorName; //专业名称
objvEduMSTRGiftedClsCase_BaseENT.IdGradeBase = objvEduMSTRGiftedClsCase_BaseENS.IdGradeBase; //年级流水号
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
 /// <param name = "objvEduMSTRGiftedClsCase_BaseENS">源对象</param>
 /// <returns>目标对象=>clsvEduMSTRGiftedClsCase_BaseEN:objvEduMSTRGiftedClsCase_BaseENT</returns>
 public static clsvEduMSTRGiftedClsCase_BaseEN CopyTo(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseENS)
{
try
{
 clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseENT = new clsvEduMSTRGiftedClsCase_BaseEN()
{
IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_BaseENS.IdEduMSTRGiftedClsCase, //教育硕士优课案例流水号
EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseID, //教育硕士优课案例ID
EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseName, //教育硕士优课案例名称
EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTheme, //教育硕士优课案例主题词
EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseDate, //教育硕士优课案例日期
EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTime, //教育硕士优课案例时间
EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseDateIn, //案例入库日期
IdStudyLevel = objvEduMSTRGiftedClsCase_BaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvEduMSTRGiftedClsCase_BaseENS.StudyLevelName, //学段名称
IdTeachingPlan = objvEduMSTRGiftedClsCase_BaseENS.IdTeachingPlan, //教案流水号
EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTimeIn, //案例入库时间
IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_BaseENS.IdEduMSTRGiftedClsCaseType, //教育硕士优课案例类型流水号
EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTypeName, //教育硕士优课案例类型名称
IdCaseType = objvEduMSTRGiftedClsCase_BaseENS.IdCaseType, //案例类型流水号
IdDiscipline = objvEduMSTRGiftedClsCase_BaseENS.IdDiscipline, //学科流水号
DisciplineID = objvEduMSTRGiftedClsCase_BaseENS.DisciplineID, //学科ID
DisciplineName = objvEduMSTRGiftedClsCase_BaseENS.DisciplineName, //学科名称
IdSenateGaugeVersion = objvEduMSTRGiftedClsCase_BaseENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvEduMSTRGiftedClsCase_BaseENS.VersionNo, //版本号
IdTeachSkill = objvEduMSTRGiftedClsCase_BaseENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillID, //教学技能ID
SkillTypeName = objvEduMSTRGiftedClsCase_BaseENS.SkillTypeName, //技能类型名称
TeachSkillName = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvEduMSTRGiftedClsCase_BaseENS.IdSkillType, //技能类型流水号
SkillTypeID = objvEduMSTRGiftedClsCase_BaseENS.SkillTypeID, //技能类型ID
CaseLevelId = objvEduMSTRGiftedClsCase_BaseENS.CaseLevelId, //课例等级Id
CaseLevelName = objvEduMSTRGiftedClsCase_BaseENS.CaseLevelName, //案例等级名称
DocFile = objvEduMSTRGiftedClsCase_BaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvEduMSTRGiftedClsCase_BaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvEduMSTRGiftedClsCase_BaseENS.WordCreateDate, //Word生成日期
IsVisible = objvEduMSTRGiftedClsCase_BaseENS.IsVisible, //是否显示
EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseText, //教育硕士优课案例文本
OwnerId = objvEduMSTRGiftedClsCase_BaseENS.OwnerId, //拥有者Id
StuName = objvEduMSTRGiftedClsCase_BaseENS.StuName, //姓名
StuId = objvEduMSTRGiftedClsCase_BaseENS.StuId, //学号
SexDesc = objvEduMSTRGiftedClsCase_BaseENS.SexDesc, //性别名称
StuTypeID = objvEduMSTRGiftedClsCase_BaseENS.StuTypeID, //学生类别ID
StuTypeDesc = objvEduMSTRGiftedClsCase_BaseENS.StuTypeDesc, //学生类别名称
IdXzCollege = objvEduMSTRGiftedClsCase_BaseENS.IdXzCollege, //学院流水号
CollegeId = objvEduMSTRGiftedClsCase_BaseENS.CollegeId, //学院ID
CollegeName = objvEduMSTRGiftedClsCase_BaseENS.CollegeName, //学院名称
CollegeNameA = objvEduMSTRGiftedClsCase_BaseENS.CollegeNameA, //学院名称简写
IdXzMajor = objvEduMSTRGiftedClsCase_BaseENS.IdXzMajor, //专业流水号
MajorName = objvEduMSTRGiftedClsCase_BaseENS.MajorName, //专业名称
IdGradeBase = objvEduMSTRGiftedClsCase_BaseENS.IdGradeBase, //年级流水号
GradeBaseName = objvEduMSTRGiftedClsCase_BaseENS.GradeBaseName, //年级名称
StuCardNo = objvEduMSTRGiftedClsCase_BaseENS.StuCardNo, //学生证号
EnrollmentDate = objvEduMSTRGiftedClsCase_BaseENS.EnrollmentDate, //入校日期
IsDualVideo = objvEduMSTRGiftedClsCase_BaseENS.IsDualVideo, //是否双视频
UserTypeId = objvEduMSTRGiftedClsCase_BaseENS.UserTypeId, //用户类型Id
RecommendedDegreeId = objvEduMSTRGiftedClsCase_BaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvEduMSTRGiftedClsCase_BaseENS.RecommendedDegreeName, //推荐度名称
ftpFileType = objvEduMSTRGiftedClsCase_BaseENS.ftpFileType, //ftp文件类型
VideoUrl = objvEduMSTRGiftedClsCase_BaseENS.VideoUrl, //视频Url
VideoPath = objvEduMSTRGiftedClsCase_BaseENS.VideoPath, //视频目录
ResErrMsg = objvEduMSTRGiftedClsCase_BaseENS.ResErrMsg, //资源错误信息
ResourceNum = objvEduMSTRGiftedClsCase_BaseENS.ResourceNum, //资源数
Memo = objvEduMSTRGiftedClsCase_BaseENS.Memo, //备注
BrowseCount4Case = objvEduMSTRGiftedClsCase_BaseENS.BrowseCount4Case, //课例浏览次数
OwnerName = objvEduMSTRGiftedClsCase_BaseENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvEduMSTRGiftedClsCase_BaseENS.OwnerNameWithId, //拥有者名称附Id
};
 return objvEduMSTRGiftedClsCase_BaseENT;
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
public static void CheckProperty4Condition(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN)
{
 clsvEduMSTRGiftedClsCase_BaseBL.vEduMSTRGiftedClsCase_BaseDA.CheckProperty4Condition(objvEduMSTRGiftedClsCase_BaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase) == true)
{
string strComparisonOpIdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase, objvEduMSTRGiftedClsCase_BaseCond.IdEduMSTRGiftedClsCase, strComparisonOpIdEduMSTRGiftedClsCase);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID, objvEduMSTRGiftedClsCase_BaseCond.EduMSTRGiftedClsCaseID, strComparisonOpEduMSTRGiftedClsCaseID);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName, objvEduMSTRGiftedClsCase_BaseCond.EduMSTRGiftedClsCaseName, strComparisonOpEduMSTRGiftedClsCaseName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme, objvEduMSTRGiftedClsCase_BaseCond.EduMSTRGiftedClsCaseTheme, strComparisonOpEduMSTRGiftedClsCaseTheme);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate, objvEduMSTRGiftedClsCase_BaseCond.EduMSTRGiftedClsCaseDate, strComparisonOpEduMSTRGiftedClsCaseDate);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime, objvEduMSTRGiftedClsCase_BaseCond.EduMSTRGiftedClsCaseTime, strComparisonOpEduMSTRGiftedClsCaseTime);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn, objvEduMSTRGiftedClsCase_BaseCond.EduMSTRGiftedClsCaseDateIn, strComparisonOpEduMSTRGiftedClsCaseDateIn);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdStudyLevel, objvEduMSTRGiftedClsCase_BaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StudyLevelName, objvEduMSTRGiftedClsCase_BaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdTeachingPlan, objvEduMSTRGiftedClsCase_BaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn, objvEduMSTRGiftedClsCase_BaseCond.EduMSTRGiftedClsCaseTimeIn, strComparisonOpEduMSTRGiftedClsCaseTimeIn);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType) == true)
{
string strComparisonOpIdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType, objvEduMSTRGiftedClsCase_BaseCond.IdEduMSTRGiftedClsCaseType, strComparisonOpIdEduMSTRGiftedClsCaseType);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName, objvEduMSTRGiftedClsCase_BaseCond.EduMSTRGiftedClsCaseTypeName, strComparisonOpEduMSTRGiftedClsCaseTypeName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdCaseType, objvEduMSTRGiftedClsCase_BaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdDiscipline, objvEduMSTRGiftedClsCase_BaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.DisciplineID, objvEduMSTRGiftedClsCase_BaseCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.DisciplineName, objvEduMSTRGiftedClsCase_BaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion, objvEduMSTRGiftedClsCase_BaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.senateGaugeVersionID, objvEduMSTRGiftedClsCase_BaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.senateGaugeVersionName, objvEduMSTRGiftedClsCase_BaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore, objvEduMSTRGiftedClsCase_BaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.VersionNo) == true)
{
string strComparisonOpVersionNo = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Base.VersionNo, objvEduMSTRGiftedClsCase_BaseCond.VersionNo, strComparisonOpVersionNo);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdTeachSkill, objvEduMSTRGiftedClsCase_BaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.TeachSkillID, objvEduMSTRGiftedClsCase_BaseCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.SkillTypeName, objvEduMSTRGiftedClsCase_BaseCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.TeachSkillName, objvEduMSTRGiftedClsCase_BaseCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.TeachSkillTheory, objvEduMSTRGiftedClsCase_BaseCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod, objvEduMSTRGiftedClsCase_BaseCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdSkillType, objvEduMSTRGiftedClsCase_BaseCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.SkillTypeID, objvEduMSTRGiftedClsCase_BaseCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.CaseLevelId, objvEduMSTRGiftedClsCase_BaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.CaseLevelName, objvEduMSTRGiftedClsCase_BaseCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.DocFile) == true)
{
string strComparisonOpDocFile = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.DocFile, objvEduMSTRGiftedClsCase_BaseCond.DocFile, strComparisonOpDocFile);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IsNeedGeneWord) == true)
{
if (objvEduMSTRGiftedClsCase_BaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Base.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Base.IsNeedGeneWord);
}
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.WordCreateDate, objvEduMSTRGiftedClsCase_BaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IsVisible) == true)
{
if (objvEduMSTRGiftedClsCase_BaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Base.IsVisible);
}
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText) == true)
{
string strComparisonOpEduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText, objvEduMSTRGiftedClsCase_BaseCond.EduMSTRGiftedClsCaseText, strComparisonOpEduMSTRGiftedClsCaseText);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.OwnerId) == true)
{
string strComparisonOpOwnerId = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.OwnerId, objvEduMSTRGiftedClsCase_BaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.StuName) == true)
{
string strComparisonOpStuName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StuName, objvEduMSTRGiftedClsCase_BaseCond.StuName, strComparisonOpStuName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.StuId) == true)
{
string strComparisonOpStuId = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StuId, objvEduMSTRGiftedClsCase_BaseCond.StuId, strComparisonOpStuId);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.SexDesc) == true)
{
string strComparisonOpSexDesc = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.SexDesc, objvEduMSTRGiftedClsCase_BaseCond.SexDesc, strComparisonOpSexDesc);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.StuTypeID) == true)
{
string strComparisonOpStuTypeID = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StuTypeID, objvEduMSTRGiftedClsCase_BaseCond.StuTypeID, strComparisonOpStuTypeID);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.StuTypeDesc) == true)
{
string strComparisonOpStuTypeDesc = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StuTypeDesc, objvEduMSTRGiftedClsCase_BaseCond.StuTypeDesc, strComparisonOpStuTypeDesc);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdXzCollege, objvEduMSTRGiftedClsCase_BaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.CollegeId) == true)
{
string strComparisonOpCollegeId = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.CollegeId, objvEduMSTRGiftedClsCase_BaseCond.CollegeId, strComparisonOpCollegeId);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.CollegeName) == true)
{
string strComparisonOpCollegeName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.CollegeName, objvEduMSTRGiftedClsCase_BaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.CollegeNameA, objvEduMSTRGiftedClsCase_BaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdXzMajor, objvEduMSTRGiftedClsCase_BaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.MajorName) == true)
{
string strComparisonOpMajorName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.MajorName, objvEduMSTRGiftedClsCase_BaseCond.MajorName, strComparisonOpMajorName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.IdGradeBase, objvEduMSTRGiftedClsCase_BaseCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.GradeBaseName, objvEduMSTRGiftedClsCase_BaseCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.StuCardNo) == true)
{
string strComparisonOpStuCardNo = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.StuCardNo, objvEduMSTRGiftedClsCase_BaseCond.StuCardNo, strComparisonOpStuCardNo);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.EnrollmentDate) == true)
{
string strComparisonOpEnrollmentDate = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.EnrollmentDate, objvEduMSTRGiftedClsCase_BaseCond.EnrollmentDate, strComparisonOpEnrollmentDate);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.IsDualVideo) == true)
{
if (objvEduMSTRGiftedClsCase_BaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Base.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Base.IsDualVideo);
}
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.UserTypeId, objvEduMSTRGiftedClsCase_BaseCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.RecommendedDegreeId, objvEduMSTRGiftedClsCase_BaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.RecommendedDegreeName, objvEduMSTRGiftedClsCase_BaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.ftpFileType, objvEduMSTRGiftedClsCase_BaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.VideoUrl, objvEduMSTRGiftedClsCase_BaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.VideoPath) == true)
{
string strComparisonOpVideoPath = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.VideoPath, objvEduMSTRGiftedClsCase_BaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.ResErrMsg, objvEduMSTRGiftedClsCase_BaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.ResourceNum) == true)
{
string strComparisonOpResourceNum = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.ResourceNum];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Base.ResourceNum, objvEduMSTRGiftedClsCase_BaseCond.ResourceNum, strComparisonOpResourceNum);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.Memo) == true)
{
string strComparisonOpMemo = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.Memo, objvEduMSTRGiftedClsCase_BaseCond.Memo, strComparisonOpMemo);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Base.BrowseCount4Case, objvEduMSTRGiftedClsCase_BaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.OwnerName) == true)
{
string strComparisonOpOwnerName = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.OwnerName, objvEduMSTRGiftedClsCase_BaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(convEduMSTRGiftedClsCase_Base.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Base.OwnerNameWithId, objvEduMSTRGiftedClsCase_BaseCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vEduMSTRGiftedClsCase_Base
{
public virtual bool UpdRelaTabDate(string strIdEduMSTRGiftedClsCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教育硕士优课案例_Base(vEduMSTRGiftedClsCase_Base)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvEduMSTRGiftedClsCase_BaseBL
{
public static RelatedActions_vEduMSTRGiftedClsCase_Base relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvEduMSTRGiftedClsCase_BaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvEduMSTRGiftedClsCase_BaseDA vEduMSTRGiftedClsCase_BaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvEduMSTRGiftedClsCase_BaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvEduMSTRGiftedClsCase_BaseBL()
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
if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCase_BaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCase_BaseEN._ConnectString);
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
public static DataTable GetDataTable_vEduMSTRGiftedClsCase_Base(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vEduMSTRGiftedClsCase_BaseDA.GetDataTable_vEduMSTRGiftedClsCase_Base(strWhereCond);
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
objDT = vEduMSTRGiftedClsCase_BaseDA.GetDataTable(strWhereCond);
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
objDT = vEduMSTRGiftedClsCase_BaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vEduMSTRGiftedClsCase_BaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vEduMSTRGiftedClsCase_BaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vEduMSTRGiftedClsCase_BaseDA.GetDataTable_Top(objTopPara);
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
objDT = vEduMSTRGiftedClsCase_BaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vEduMSTRGiftedClsCase_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vEduMSTRGiftedClsCase_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByIdEduMSTRGiftedClsCaseLst(List<string> arrIdEduMSTRGiftedClsCaseLst)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
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
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdEduMSTRGiftedClsCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByIdEduMSTRGiftedClsCaseLstCache(List<string> arrIdEduMSTRGiftedClsCaseLst)
{
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName);
List<clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Sel =
arrvEduMSTRGiftedClsCase_BaseObjLstCache
.Where(x => arrIdEduMSTRGiftedClsCaseLst.Contains(x.IdEduMSTRGiftedClsCase));
return arrvEduMSTRGiftedClsCase_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLst(string strWhereCond)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvEduMSTRGiftedClsCase_BaseEN> GetSubObjLstCache(clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseCond)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvEduMSTRGiftedClsCase_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convEduMSTRGiftedClsCase_Base.AttributeName)
{
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString());
}
else
{
if (objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvEduMSTRGiftedClsCase_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvEduMSTRGiftedClsCase_BaseCond[strFldName]));
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
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
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
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
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
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
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvEduMSTRGiftedClsCase_Base(ref clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN)
{
bool bolResult = vEduMSTRGiftedClsCase_BaseDA.GetvEduMSTRGiftedClsCase_Base(ref objvEduMSTRGiftedClsCase_BaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN GetObjByIdEduMSTRGiftedClsCase(string strIdEduMSTRGiftedClsCase)
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
clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = vEduMSTRGiftedClsCase_BaseDA.GetObjByIdEduMSTRGiftedClsCase(strIdEduMSTRGiftedClsCase);
return objvEduMSTRGiftedClsCase_BaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = vEduMSTRGiftedClsCase_BaseDA.GetFirstObj(strWhereCond);
 return objvEduMSTRGiftedClsCase_BaseEN;
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
public static clsvEduMSTRGiftedClsCase_BaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = vEduMSTRGiftedClsCase_BaseDA.GetObjByDataRow(objRow);
 return objvEduMSTRGiftedClsCase_BaseEN;
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
public static clsvEduMSTRGiftedClsCase_BaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = vEduMSTRGiftedClsCase_BaseDA.GetObjByDataRow(objRow);
 return objvEduMSTRGiftedClsCase_BaseEN;
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
 /// <param name = "lstvEduMSTRGiftedClsCase_BaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN GetObjByIdEduMSTRGiftedClsCaseFromList(string strIdEduMSTRGiftedClsCase, List<clsvEduMSTRGiftedClsCase_BaseEN> lstvEduMSTRGiftedClsCase_BaseObjLst)
{
foreach (clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN in lstvEduMSTRGiftedClsCase_BaseObjLst)
{
if (objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase == strIdEduMSTRGiftedClsCase)
{
return objvEduMSTRGiftedClsCase_BaseEN;
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
 strIdEduMSTRGiftedClsCase = new clsvEduMSTRGiftedClsCase_BaseDA().GetFirstID(strWhereCond);
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
 arrList = vEduMSTRGiftedClsCase_BaseDA.GetID(strWhereCond);
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
bool bolIsExist = vEduMSTRGiftedClsCase_BaseDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vEduMSTRGiftedClsCase_BaseDA.IsExist(strIdEduMSTRGiftedClsCase);
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
 bolIsExist = clsvEduMSTRGiftedClsCase_BaseDA.IsExistTable();
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
 bolIsExist = vEduMSTRGiftedClsCase_BaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvEduMSTRGiftedClsCase_BaseENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseENT">目标对象</param>
 public static void CopyTo(clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseENS, clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseENT)
{
try
{
objvEduMSTRGiftedClsCase_BaseENT.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_BaseENS.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objvEduMSTRGiftedClsCase_BaseENT.IdStudyLevel = objvEduMSTRGiftedClsCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseENT.StudyLevelName = objvEduMSTRGiftedClsCase_BaseENS.StudyLevelName; //学段名称
objvEduMSTRGiftedClsCase_BaseENT.IdTeachingPlan = objvEduMSTRGiftedClsCase_BaseENS.IdTeachingPlan; //教案流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objvEduMSTRGiftedClsCase_BaseENT.IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_BaseENS.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseENT.IdCaseType = objvEduMSTRGiftedClsCase_BaseENS.IdCaseType; //案例类型流水号
objvEduMSTRGiftedClsCase_BaseENT.IdDiscipline = objvEduMSTRGiftedClsCase_BaseENS.IdDiscipline; //学科流水号
objvEduMSTRGiftedClsCase_BaseENT.DisciplineID = objvEduMSTRGiftedClsCase_BaseENS.DisciplineID; //学科ID
objvEduMSTRGiftedClsCase_BaseENT.DisciplineName = objvEduMSTRGiftedClsCase_BaseENS.DisciplineName; //学科名称
objvEduMSTRGiftedClsCase_BaseENT.IdSenateGaugeVersion = objvEduMSTRGiftedClsCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionID = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionName = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseENT.VersionNo = objvEduMSTRGiftedClsCase_BaseENS.VersionNo; //版本号
objvEduMSTRGiftedClsCase_BaseENT.IdTeachSkill = objvEduMSTRGiftedClsCase_BaseENS.IdTeachSkill; //教学技能流水号
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillID = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillID; //教学技能ID
objvEduMSTRGiftedClsCase_BaseENT.SkillTypeName = objvEduMSTRGiftedClsCase_BaseENS.SkillTypeName; //技能类型名称
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillName = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillName; //教学技能名称
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillTheory = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillOperMethod = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseENT.IdSkillType = objvEduMSTRGiftedClsCase_BaseENS.IdSkillType; //技能类型流水号
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
objvEduMSTRGiftedClsCase_BaseENT.StuId = objvEduMSTRGiftedClsCase_BaseENS.StuId; //学号
objvEduMSTRGiftedClsCase_BaseENT.SexDesc = objvEduMSTRGiftedClsCase_BaseENS.SexDesc; //性别名称
objvEduMSTRGiftedClsCase_BaseENT.StuTypeID = objvEduMSTRGiftedClsCase_BaseENS.StuTypeID; //学生类别ID
objvEduMSTRGiftedClsCase_BaseENT.StuTypeDesc = objvEduMSTRGiftedClsCase_BaseENS.StuTypeDesc; //学生类别名称
objvEduMSTRGiftedClsCase_BaseENT.IdXzCollege = objvEduMSTRGiftedClsCase_BaseENS.IdXzCollege; //学院流水号
objvEduMSTRGiftedClsCase_BaseENT.CollegeId = objvEduMSTRGiftedClsCase_BaseENS.CollegeId; //学院ID
objvEduMSTRGiftedClsCase_BaseENT.CollegeName = objvEduMSTRGiftedClsCase_BaseENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCase_BaseENT.CollegeNameA = objvEduMSTRGiftedClsCase_BaseENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCase_BaseENT.IdXzMajor = objvEduMSTRGiftedClsCase_BaseENS.IdXzMajor; //专业流水号
objvEduMSTRGiftedClsCase_BaseENT.MajorName = objvEduMSTRGiftedClsCase_BaseENS.MajorName; //专业名称
objvEduMSTRGiftedClsCase_BaseENT.IdGradeBase = objvEduMSTRGiftedClsCase_BaseENS.IdGradeBase; //年级流水号
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
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN)
{
try
{
objvEduMSTRGiftedClsCase_BaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvEduMSTRGiftedClsCase_BaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objvEduMSTRGiftedClsCase_BaseEN.IdCaseType == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objvEduMSTRGiftedClsCase_BaseEN.DisciplineID == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objvEduMSTRGiftedClsCase_BaseEN.DisciplineName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objvEduMSTRGiftedClsCase_BaseEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objvEduMSTRGiftedClsCase_BaseEN.IdSkillType == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objvEduMSTRGiftedClsCase_BaseEN.DocFile == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = objvEduMSTRGiftedClsCase_BaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objvEduMSTRGiftedClsCase_BaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.StuName = objvEduMSTRGiftedClsCase_BaseEN.StuName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.StuName; //姓名
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.StuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.StuId = objvEduMSTRGiftedClsCase_BaseEN.StuId == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.StuId; //学号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objvEduMSTRGiftedClsCase_BaseEN.SexDesc == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.StuTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objvEduMSTRGiftedClsCase_BaseEN.StuTypeID == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.StuTypeID; //学生类别ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.StuTypeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc; //学生类别名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objvEduMSTRGiftedClsCase_BaseEN.CollegeId == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objvEduMSTRGiftedClsCase_BaseEN.CollegeName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objvEduMSTRGiftedClsCase_BaseEN.MajorName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.StuCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objvEduMSTRGiftedClsCase_BaseEN.StuCardNo == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.StuCardNo; //学生证号
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.EnrollmentDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate; //入校日期
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objvEduMSTRGiftedClsCase_BaseEN.UserTypeId == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objvEduMSTRGiftedClsCase_BaseEN.ftpFileType == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objvEduMSTRGiftedClsCase_BaseEN.VideoUrl == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objvEduMSTRGiftedClsCase_BaseEN.VideoPath == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.ResourceNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objvEduMSTRGiftedClsCase_BaseEN.ResourceNum; //资源数
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.Memo = objvEduMSTRGiftedClsCase_BaseEN.Memo == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.Memo; //备注
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objvEduMSTRGiftedClsCase_BaseEN.OwnerName == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convEduMSTRGiftedClsCase_Base.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId == "[null]" ? null :  objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId; //拥有者名称附Id
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
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN)
{
try
{
if (objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme == "[null]") objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = null; //教育硕士优课案例主题词
if (objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate == "[null]") objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = null; //教育硕士优课案例日期
if (objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime == "[null]") objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = null; //教育硕士优课案例时间
if (objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn == "[null]") objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = null; //案例入库日期
if (objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel == "[null]") objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = null; //id_StudyLevel
if (objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = null; //学段名称
if (objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan == "[null]") objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = null; //教案流水号
if (objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn == "[null]") objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = null; //案例入库时间
if (objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType == "[null]") objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = null; //教育硕士优课案例类型流水号
if (objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = null; //教育硕士优课案例类型名称
if (objvEduMSTRGiftedClsCase_BaseEN.IdCaseType == "[null]") objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = null; //案例类型流水号
if (objvEduMSTRGiftedClsCase_BaseEN.DisciplineID == "[null]") objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = null; //学科ID
if (objvEduMSTRGiftedClsCase_BaseEN.DisciplineName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = null; //学科名称
if (objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion == "[null]") objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID == "[null]") objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID == "[null]") objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = null; //教学技能ID
if (objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = null; //技能类型名称
if (objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = null; //教学技能名称
if (objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory == "[null]") objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod == "[null]") objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvEduMSTRGiftedClsCase_BaseEN.IdSkillType == "[null]") objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = null; //技能类型流水号
if (objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID == "[null]") objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = null; //技能类型ID
if (objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId == "[null]") objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = null; //课例等级Id
if (objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = null; //案例等级名称
if (objvEduMSTRGiftedClsCase_BaseEN.DocFile == "[null]") objvEduMSTRGiftedClsCase_BaseEN.DocFile = null; //生成的Word文件名
if (objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate == "[null]") objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = null; //Word生成日期
if (objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText == "[null]") objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = null; //教育硕士优课案例文本
if (objvEduMSTRGiftedClsCase_BaseEN.StuName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.StuName = null; //姓名
if (objvEduMSTRGiftedClsCase_BaseEN.StuId == "[null]") objvEduMSTRGiftedClsCase_BaseEN.StuId = null; //学号
if (objvEduMSTRGiftedClsCase_BaseEN.SexDesc == "[null]") objvEduMSTRGiftedClsCase_BaseEN.SexDesc = null; //性别名称
if (objvEduMSTRGiftedClsCase_BaseEN.StuTypeID == "[null]") objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = null; //学生类别ID
if (objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc == "[null]") objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = null; //学生类别名称
if (objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege == "[null]") objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = null; //学院流水号
if (objvEduMSTRGiftedClsCase_BaseEN.CollegeId == "[null]") objvEduMSTRGiftedClsCase_BaseEN.CollegeId = null; //学院ID
if (objvEduMSTRGiftedClsCase_BaseEN.CollegeName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.CollegeName = null; //学院名称
if (objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA == "[null]") objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = null; //学院名称简写
if (objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor == "[null]") objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = null; //专业流水号
if (objvEduMSTRGiftedClsCase_BaseEN.MajorName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.MajorName = null; //专业名称
if (objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase == "[null]") objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = null; //年级流水号
if (objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = null; //年级名称
if (objvEduMSTRGiftedClsCase_BaseEN.StuCardNo == "[null]") objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = null; //学生证号
if (objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate == "[null]") objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = null; //入校日期
if (objvEduMSTRGiftedClsCase_BaseEN.UserTypeId == "[null]") objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = null; //用户类型Id
if (objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvEduMSTRGiftedClsCase_BaseEN.ftpFileType == "[null]") objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = null; //ftp文件类型
if (objvEduMSTRGiftedClsCase_BaseEN.VideoUrl == "[null]") objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = null; //视频Url
if (objvEduMSTRGiftedClsCase_BaseEN.VideoPath == "[null]") objvEduMSTRGiftedClsCase_BaseEN.VideoPath = null; //视频目录
if (objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg == "[null]") objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = null; //资源错误信息
if (objvEduMSTRGiftedClsCase_BaseEN.Memo == "[null]") objvEduMSTRGiftedClsCase_BaseEN.Memo = null; //备注
if (objvEduMSTRGiftedClsCase_BaseEN.OwnerName == "[null]") objvEduMSTRGiftedClsCase_BaseEN.OwnerName = null; //拥有者姓名
if (objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId == "[null]") objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = null; //拥有者名称附Id
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
public static void CheckProperty4Condition(clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN)
{
 vEduMSTRGiftedClsCase_BaseDA.CheckProperty4Condition(objvEduMSTRGiftedClsCase_BaseEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase); 
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = clsvEduMSTRGiftedClsCase_BaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN()
{
IdEduMSTRGiftedClsCase = "0",
EduMSTRGiftedClsCaseName = "选[v教育硕士优课案例_Base]..."
};
arrObjLst.Insert(0, objvEduMSTRGiftedClsCase_BaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase;
objComboBox.DisplayMember = convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教育硕士优课案例_Base]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase); 
IEnumerable<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = clsvEduMSTRGiftedClsCase_BaseBL.GetObjLst(strCondition);
objDDL.DataValueField = convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase;
objDDL.DataTextField = convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教育硕士优课案例_Base]...","0");
List<clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst = GetAllvEduMSTRGiftedClsCase_BaseObjLstCache(); 
objDDL.DataValueField = convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase;
objDDL.DataTextField = convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName;
objDDL.DataSource = arrvEduMSTRGiftedClsCase_BaseObjLst;
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
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvEduMSTRGiftedClsCase_BaseObjLstCache == null)
//{
//arrvEduMSTRGiftedClsCase_BaseObjLstCache = vEduMSTRGiftedClsCase_BaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvEduMSTRGiftedClsCase_BaseEN GetObjByIdEduMSTRGiftedClsCaseCache(string strIdEduMSTRGiftedClsCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName);
List<clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLst_Sel =
arrvEduMSTRGiftedClsCase_BaseObjLstCache
.Where(x=> x.IdEduMSTRGiftedClsCase == strIdEduMSTRGiftedClsCase 
);
if (arrvEduMSTRGiftedClsCase_BaseObjLst_Sel.Count() == 0)
{
   clsvEduMSTRGiftedClsCase_BaseEN obj = clsvEduMSTRGiftedClsCase_BaseBL.GetObjByIdEduMSTRGiftedClsCase(strIdEduMSTRGiftedClsCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvEduMSTRGiftedClsCase_BaseObjLst_Sel.First();
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
clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_Base = GetObjByIdEduMSTRGiftedClsCaseCache(strIdEduMSTRGiftedClsCase);
if (objvEduMSTRGiftedClsCase_Base == null) return "";
return objvEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName;
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
clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_Base = GetObjByIdEduMSTRGiftedClsCaseCache(strIdEduMSTRGiftedClsCase);
if (objvEduMSTRGiftedClsCase_Base == null) return "";
return objvEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetAllvEduMSTRGiftedClsCase_BaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLstCache = GetObjLstCache(); 
return arrvEduMSTRGiftedClsCase_BaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName);
List<clsvEduMSTRGiftedClsCase_BaseEN> arrvEduMSTRGiftedClsCase_BaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvEduMSTRGiftedClsCase_BaseObjLstCache;
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
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName);
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
if (strInFldName != convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convEduMSTRGiftedClsCase_Base.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convEduMSTRGiftedClsCase_Base.AttributeName));
throw new Exception(strMsg);
}
var objvEduMSTRGiftedClsCase_Base = clsvEduMSTRGiftedClsCase_BaseBL.GetObjByIdEduMSTRGiftedClsCaseCache(strIdEduMSTRGiftedClsCase);
if (objvEduMSTRGiftedClsCase_Base == null) return "";
return objvEduMSTRGiftedClsCase_Base[strOutFldName].ToString();
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
int intRecCount = clsvEduMSTRGiftedClsCase_BaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvEduMSTRGiftedClsCase_BaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvEduMSTRGiftedClsCase_BaseDA.GetRecCount();
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
int intRecCount = clsvEduMSTRGiftedClsCase_BaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseCond)
{
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvEduMSTRGiftedClsCase_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convEduMSTRGiftedClsCase_Base.AttributeName)
{
if (objvEduMSTRGiftedClsCase_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString());
}
else
{
if (objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvEduMSTRGiftedClsCase_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvEduMSTRGiftedClsCase_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvEduMSTRGiftedClsCase_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvEduMSTRGiftedClsCase_BaseCond[strFldName]));
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
 List<string> arrList = clsvEduMSTRGiftedClsCase_BaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vEduMSTRGiftedClsCase_BaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vEduMSTRGiftedClsCase_BaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}