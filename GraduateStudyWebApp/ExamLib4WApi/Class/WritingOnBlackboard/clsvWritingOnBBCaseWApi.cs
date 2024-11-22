
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWritingOnBBCaseWApi
 表名:vWritingOnBBCase(01120468)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:31
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播
 模块英文名:WritingOnBlackboard
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
public static class clsvWritingOnBBCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN Setid_WritingOnBBCase(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strid_WritingOnBBCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_WritingOnBBCase, 8, convWritingOnBBCase.id_WritingOnBBCase);
clsCheckSql.CheckFieldForeignKey(strid_WritingOnBBCase, 8, convWritingOnBBCase.id_WritingOnBBCase);
objvWritingOnBBCaseEN.id_WritingOnBBCase = strid_WritingOnBBCase; //板书案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.id_WritingOnBBCase) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.id_WritingOnBBCase, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.id_WritingOnBBCase] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetWritingOnBBCaseID(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strWritingOnBBCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseID, convWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseID, 8, convWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseID, 8, convWritingOnBBCase.WritingOnBBCaseID);
objvWritingOnBBCaseEN.WritingOnBBCaseID = strWritingOnBBCaseID; //板书教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.WritingOnBBCaseID) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.WritingOnBBCaseID, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseID] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetWritingOnBBCaseName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strWritingOnBBCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseName, convWritingOnBBCase.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseName, 100, convWritingOnBBCase.WritingOnBBCaseName);
objvWritingOnBBCaseEN.WritingOnBBCaseName = strWritingOnBBCaseName; //板书教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.WritingOnBBCaseName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.WritingOnBBCaseName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetWritingOnBBCaseTheme(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strWritingOnBBCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTheme, 200, convWritingOnBBCase.WritingOnBBCaseTheme);
objvWritingOnBBCaseEN.WritingOnBBCaseTheme = strWritingOnBBCaseTheme; //板书教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.WritingOnBBCaseTheme) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.WritingOnBBCaseTheme, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseTheme] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN Setid_Discipline(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convWritingOnBBCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convWritingOnBBCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convWritingOnBBCase.id_Discipline);
objvWritingOnBBCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.id_Discipline) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.id_Discipline, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.id_Discipline] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetDisciplineID(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convWritingOnBBCase.DisciplineID);
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convWritingOnBBCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convWritingOnBBCase.DisciplineID);
objvWritingOnBBCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.DisciplineID) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.DisciplineID, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.DisciplineID] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetDisciplineName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convWritingOnBBCase.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convWritingOnBBCase.DisciplineName);
objvWritingOnBBCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.DisciplineName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.DisciplineName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.DisciplineName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetWritingOnBBCaseDate(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strWritingOnBBCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseDate, 8, convWritingOnBBCase.WritingOnBBCaseDate);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseDate, 8, convWritingOnBBCase.WritingOnBBCaseDate);
objvWritingOnBBCaseEN.WritingOnBBCaseDate = strWritingOnBBCaseDate; //板书教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.WritingOnBBCaseDate) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.WritingOnBBCaseDate, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseDate] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetWritingOnBBCaseTime(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strWritingOnBBCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTime, 6, convWritingOnBBCase.WritingOnBBCaseTime);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseTime, 6, convWritingOnBBCase.WritingOnBBCaseTime);
objvWritingOnBBCaseEN.WritingOnBBCaseTime = strWritingOnBBCaseTime; //板书教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.WritingOnBBCaseTime) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.WritingOnBBCaseTime, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseTime] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetWritingOnBBCaseDateIn(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strWritingOnBBCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseDateIn, 8, convWritingOnBBCase.WritingOnBBCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseDateIn, 8, convWritingOnBBCase.WritingOnBBCaseDateIn);
objvWritingOnBBCaseEN.WritingOnBBCaseDateIn = strWritingOnBBCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.WritingOnBBCaseDateIn) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.WritingOnBBCaseDateIn, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseDateIn] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetWritingOnBBCaseTimeIn(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strWritingOnBBCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTimeIn, 6, convWritingOnBBCase.WritingOnBBCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseTimeIn, 6, convWritingOnBBCase.WritingOnBBCaseTimeIn);
objvWritingOnBBCaseEN.WritingOnBBCaseTimeIn = strWritingOnBBCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.WritingOnBBCaseTimeIn) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.WritingOnBBCaseTimeIn, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseTimeIn] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN Setid_StudyLevel(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convWritingOnBBCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convWritingOnBBCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convWritingOnBBCase.id_StudyLevel);
objvWritingOnBBCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.id_StudyLevel) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.id_StudyLevel, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.id_StudyLevel] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetStudyLevelName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convWritingOnBBCase.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convWritingOnBBCase.StudyLevelName);
objvWritingOnBBCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.StudyLevelName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.StudyLevelName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.StudyLevelName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetIsNeedGeneWord(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvWritingOnBBCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.IsNeedGeneWord) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetWordCreateDate(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convWritingOnBBCase.WordCreateDate);
objvWritingOnBBCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.WordCreateDate) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.WordCreateDate, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.WordCreateDate] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetDocFile(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convWritingOnBBCase.DocFile);
objvWritingOnBBCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.DocFile) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.DocFile, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.DocFile] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetCaseLevelId(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convWritingOnBBCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convWritingOnBBCase.CaseLevelId);
objvWritingOnBBCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.CaseLevelId) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.CaseLevelId, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.CaseLevelId] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN Setid_SenateGaugeVersion(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convWritingOnBBCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convWritingOnBBCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convWritingOnBBCase.id_SenateGaugeVersion);
objvWritingOnBBCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.id_SenateGaugeVersion) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetsenateGaugeVersionID(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convWritingOnBBCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convWritingOnBBCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convWritingOnBBCase.senateGaugeVersionID);
objvWritingOnBBCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.senateGaugeVersionID) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetsenateGaugeVersionName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convWritingOnBBCase.senateGaugeVersionName);
objvWritingOnBBCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.senateGaugeVersionName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetsenateGaugeVersionTtlScore(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convWritingOnBBCase.senateGaugeVersionTtlScore);
objvWritingOnBBCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.senateGaugeVersionTtlScore) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetVersionNo(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, int intVersionNo, string strComparisonOp="")
	{
objvWritingOnBBCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.VersionNo) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.VersionNo, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.VersionNo] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetIsVisible(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvWritingOnBBCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.IsVisible) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.IsVisible, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.IsVisible] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetOwnerId(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convWritingOnBBCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convWritingOnBBCase.OwnerId);
objvWritingOnBBCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.OwnerId) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.OwnerId, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.OwnerId] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetStuName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convWritingOnBBCase.StuName);
objvWritingOnBBCaseEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.StuName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.StuName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.StuName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetStuID(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convWritingOnBBCase.StuID);
objvWritingOnBBCaseEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.StuID) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.StuID, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.StuID] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetCollegeID(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convWritingOnBBCase.CollegeID);
objvWritingOnBBCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.CollegeID) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.CollegeID, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.CollegeID] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetCollegeName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convWritingOnBBCase.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convWritingOnBBCase.CollegeName);
objvWritingOnBBCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.CollegeName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.CollegeName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.CollegeName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetCollegeNameA(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convWritingOnBBCase.CollegeNameA);
objvWritingOnBBCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.CollegeNameA) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.CollegeNameA, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.CollegeNameA] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN Setid_XzCollege(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convWritingOnBBCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convWritingOnBBCase.id_XzCollege);
objvWritingOnBBCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.id_XzCollege) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.id_XzCollege, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.id_XzCollege] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN Setid_XzMajor(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convWritingOnBBCase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convWritingOnBBCase.id_XzMajor);
objvWritingOnBBCaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.id_XzMajor) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.id_XzMajor, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.id_XzMajor] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetMajorName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convWritingOnBBCase.MajorName);
objvWritingOnBBCaseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.MajorName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.MajorName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.MajorName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN Setid_GradeBase(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convWritingOnBBCase.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convWritingOnBBCase.id_GradeBase);
objvWritingOnBBCaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.id_GradeBase) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.id_GradeBase, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.id_GradeBase] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetGradeBaseName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convWritingOnBBCase.GradeBaseName);
objvWritingOnBBCaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.GradeBaseName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.GradeBaseName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.GradeBaseName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN Setid_AdminCls(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convWritingOnBBCase.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convWritingOnBBCase.id_AdminCls);
objvWritingOnBBCaseEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.id_AdminCls) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.id_AdminCls, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.id_AdminCls] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetIsDualVideo(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convWritingOnBBCase.IsDualVideo);
objvWritingOnBBCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.IsDualVideo) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.IsDualVideo, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.IsDualVideo] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN Setid_WritingOnBBCaseType(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strid_WritingOnBBCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_WritingOnBBCaseType, convWritingOnBBCase.id_WritingOnBBCaseType);
clsCheckSql.CheckFieldLen(strid_WritingOnBBCaseType, 4, convWritingOnBBCase.id_WritingOnBBCaseType);
clsCheckSql.CheckFieldForeignKey(strid_WritingOnBBCaseType, 4, convWritingOnBBCase.id_WritingOnBBCaseType);
objvWritingOnBBCaseEN.id_WritingOnBBCaseType = strid_WritingOnBBCaseType; //板书案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.id_WritingOnBBCaseType) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.id_WritingOnBBCaseType, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.id_WritingOnBBCaseType] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetWritingOnBBCaseTypeName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strWritingOnBBCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTypeName, 50, convWritingOnBBCase.WritingOnBBCaseTypeName);
objvWritingOnBBCaseEN.WritingOnBBCaseTypeName = strWritingOnBBCaseTypeName; //板书案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.WritingOnBBCaseTypeName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.WritingOnBBCaseTypeName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseTypeName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetUserTypeId(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convWritingOnBBCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convWritingOnBBCase.UserTypeId);
objvWritingOnBBCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.UserTypeId) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.UserTypeId, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.UserTypeId] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetUserTypeName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convWritingOnBBCase.UserTypeName);
objvWritingOnBBCaseEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.UserTypeName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.UserTypeName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.UserTypeName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetRecommendedDegreeId(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convWritingOnBBCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convWritingOnBBCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convWritingOnBBCase.RecommendedDegreeId);
objvWritingOnBBCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.RecommendedDegreeId) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetRecommendedDegreeName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convWritingOnBBCase.RecommendedDegreeName);
objvWritingOnBBCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.RecommendedDegreeName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetftpFileType(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convWritingOnBBCase.ftpFileType);
objvWritingOnBBCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.ftpFileType) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.ftpFileType, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.ftpFileType] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetVideoUrl(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convWritingOnBBCase.VideoUrl);
objvWritingOnBBCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.VideoUrl) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.VideoUrl, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.VideoUrl] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetVideoPath(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convWritingOnBBCase.VideoPath);
objvWritingOnBBCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.VideoPath) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.VideoPath, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.VideoPath] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetResErrMsg(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convWritingOnBBCase.ResErrMsg);
objvWritingOnBBCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.ResErrMsg) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.ResErrMsg, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.ResErrMsg] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetUpdUserId(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convWritingOnBBCase.UpdUserId);
objvWritingOnBBCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.UpdUserId) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.UpdUserId, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.UpdUserId] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetUpdDate(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWritingOnBBCase.UpdDate);
objvWritingOnBBCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.UpdDate) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.UpdDate, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.UpdDate] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetMemo(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWritingOnBBCase.Memo);
objvWritingOnBBCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.Memo) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.Memo, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.Memo] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetOwnerNameWithId(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convWritingOnBBCase.OwnerNameWithId);
objvWritingOnBBCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.OwnerNameWithId) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetOwnerName(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convWritingOnBBCase.OwnerName);
objvWritingOnBBCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.OwnerName) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.OwnerName, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.OwnerName] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetBrowseCount4Case(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvWritingOnBBCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.BrowseCount4Case) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseEN SetIsHaveVideo(this clsvWritingOnBBCaseEN objvWritingOnBBCaseEN, string strIsHaveVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convWritingOnBBCase.IsHaveVideo);
objvWritingOnBBCaseEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase.IsHaveVideo) == false)
{
objvWritingOnBBCaseEN.dicFldComparisonOp.Add(convWritingOnBBCase.IsHaveVideo, strComparisonOp);
}
else
{
objvWritingOnBBCaseEN.dicFldComparisonOp[convWritingOnBBCase.IsHaveVideo] = strComparisonOp;
}
}
return objvWritingOnBBCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvWritingOnBBCaseEN objvWritingOnBBCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.id_WritingOnBBCase) == true)
{
string strComparisonOp_id_WritingOnBBCase = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.id_WritingOnBBCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.id_WritingOnBBCase, objvWritingOnBBCase_Cond.id_WritingOnBBCase, strComparisonOp_id_WritingOnBBCase);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.WritingOnBBCaseID) == true)
{
string strComparisonOp_WritingOnBBCaseID = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.WritingOnBBCaseID, objvWritingOnBBCase_Cond.WritingOnBBCaseID, strComparisonOp_WritingOnBBCaseID);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.WritingOnBBCaseName) == true)
{
string strComparisonOp_WritingOnBBCaseName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.WritingOnBBCaseName, objvWritingOnBBCase_Cond.WritingOnBBCaseName, strComparisonOp_WritingOnBBCaseName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.WritingOnBBCaseTheme) == true)
{
string strComparisonOp_WritingOnBBCaseTheme = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.WritingOnBBCaseTheme, objvWritingOnBBCase_Cond.WritingOnBBCaseTheme, strComparisonOp_WritingOnBBCaseTheme);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.id_Discipline, objvWritingOnBBCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.DisciplineID, objvWritingOnBBCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.DisciplineName, objvWritingOnBBCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.WritingOnBBCaseDate) == true)
{
string strComparisonOp_WritingOnBBCaseDate = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.WritingOnBBCaseDate, objvWritingOnBBCase_Cond.WritingOnBBCaseDate, strComparisonOp_WritingOnBBCaseDate);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.WritingOnBBCaseTime) == true)
{
string strComparisonOp_WritingOnBBCaseTime = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.WritingOnBBCaseTime, objvWritingOnBBCase_Cond.WritingOnBBCaseTime, strComparisonOp_WritingOnBBCaseTime);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.WritingOnBBCaseDateIn) == true)
{
string strComparisonOp_WritingOnBBCaseDateIn = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.WritingOnBBCaseDateIn, objvWritingOnBBCase_Cond.WritingOnBBCaseDateIn, strComparisonOp_WritingOnBBCaseDateIn);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.WritingOnBBCaseTimeIn) == true)
{
string strComparisonOp_WritingOnBBCaseTimeIn = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.WritingOnBBCaseTimeIn, objvWritingOnBBCase_Cond.WritingOnBBCaseTimeIn, strComparisonOp_WritingOnBBCaseTimeIn);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.id_StudyLevel, objvWritingOnBBCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.StudyLevelName, objvWritingOnBBCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.IsNeedGeneWord) == true)
{
if (objvWritingOnBBCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCase.IsNeedGeneWord);
}
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.WordCreateDate, objvWritingOnBBCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.DocFile, objvWritingOnBBCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.CaseLevelId, objvWritingOnBBCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.id_SenateGaugeVersion, objvWritingOnBBCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.senateGaugeVersionID, objvWritingOnBBCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.senateGaugeVersionName, objvWritingOnBBCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCase.senateGaugeVersionTtlScore, objvWritingOnBBCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCase.VersionNo, objvWritingOnBBCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.IsVisible) == true)
{
if (objvWritingOnBBCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCase.IsVisible);
}
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.OwnerId, objvWritingOnBBCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.StuName) == true)
{
string strComparisonOp_StuName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.StuName, objvWritingOnBBCase_Cond.StuName, strComparisonOp_StuName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.StuID) == true)
{
string strComparisonOp_StuID = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.StuID, objvWritingOnBBCase_Cond.StuID, strComparisonOp_StuID);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.CollegeID, objvWritingOnBBCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.CollegeName, objvWritingOnBBCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.CollegeNameA, objvWritingOnBBCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.id_XzCollege, objvWritingOnBBCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.id_XzMajor, objvWritingOnBBCase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.MajorName) == true)
{
string strComparisonOp_MajorName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.MajorName, objvWritingOnBBCase_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.id_GradeBase, objvWritingOnBBCase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.GradeBaseName, objvWritingOnBBCase_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.id_AdminCls, objvWritingOnBBCase_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.IsDualVideo) == true)
{
if (objvWritingOnBBCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCase.IsDualVideo);
}
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.id_WritingOnBBCaseType) == true)
{
string strComparisonOp_id_WritingOnBBCaseType = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.id_WritingOnBBCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.id_WritingOnBBCaseType, objvWritingOnBBCase_Cond.id_WritingOnBBCaseType, strComparisonOp_id_WritingOnBBCaseType);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.WritingOnBBCaseTypeName) == true)
{
string strComparisonOp_WritingOnBBCaseTypeName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.WritingOnBBCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.WritingOnBBCaseTypeName, objvWritingOnBBCase_Cond.WritingOnBBCaseTypeName, strComparisonOp_WritingOnBBCaseTypeName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.UserTypeId, objvWritingOnBBCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.UserTypeName, objvWritingOnBBCase_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.RecommendedDegreeId, objvWritingOnBBCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.RecommendedDegreeName, objvWritingOnBBCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.ftpFileType, objvWritingOnBBCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.VideoUrl, objvWritingOnBBCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.VideoPath, objvWritingOnBBCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.ResErrMsg, objvWritingOnBBCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.UpdUserId, objvWritingOnBBCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.UpdDate, objvWritingOnBBCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.Memo) == true)
{
string strComparisonOp_Memo = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.Memo, objvWritingOnBBCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.OwnerNameWithId, objvWritingOnBBCase_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.OwnerName, objvWritingOnBBCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCase.BrowseCount4Case, objvWritingOnBBCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvWritingOnBBCase_Cond.IsUpdated(convWritingOnBBCase.IsHaveVideo) == true)
{
string strComparisonOp_IsHaveVideo = objvWritingOnBBCase_Cond.dicFldComparisonOp[convWritingOnBBCase.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase.IsHaveVideo, objvWritingOnBBCase_Cond.IsHaveVideo, strComparisonOp_IsHaveVideo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v板书教学案例(vWritingOnBBCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvWritingOnBBCaseWApi
{
private static readonly string mstrApiControllerName = "vWritingOnBBCaseApi";

 public clsvWritingOnBBCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_WritingOnBBCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWritingOnBBCaseEN GetObjByid_WritingOnBBCase(string strid_WritingOnBBCase)
{
string strAction = "GetObjByid_WritingOnBBCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCaseEN objvWritingOnBBCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_WritingOnBBCase"] = strid_WritingOnBBCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvWritingOnBBCaseEN = JsonConvert.DeserializeObject<clsvWritingOnBBCaseEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCaseEN;
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
 /// <param name = "strid_WritingOnBBCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWritingOnBBCaseEN GetObjByid_WritingOnBBCase_WA_Cache(string strid_WritingOnBBCase)
{
string strAction = "GetObjByid_WritingOnBBCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCaseEN objvWritingOnBBCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_WritingOnBBCase"] = strid_WritingOnBBCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvWritingOnBBCaseEN = JsonConvert.DeserializeObject<clsvWritingOnBBCaseEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCaseEN;
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
public static clsvWritingOnBBCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCaseEN objvWritingOnBBCaseEN = null;
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
objvWritingOnBBCaseEN = JsonConvert.DeserializeObject<clsvWritingOnBBCaseEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCaseEN;
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
 /// <param name = "strid_WritingOnBBCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWritingOnBBCaseEN GetObjByid_WritingOnBBCase_Cache(string strid_WritingOnBBCase)
{
if (string.IsNullOrEmpty(strid_WritingOnBBCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvWritingOnBBCaseEN._CurrTabName_S);
List<clsvWritingOnBBCaseEN> arrvWritingOnBBCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvWritingOnBBCaseEN> arrvWritingOnBBCaseObjLst_Sel =
from objvWritingOnBBCaseEN in arrvWritingOnBBCaseObjLst_Cache
where objvWritingOnBBCaseEN.id_WritingOnBBCase == strid_WritingOnBBCase
select objvWritingOnBBCaseEN;
if (arrvWritingOnBBCaseObjLst_Sel.Count() == 0)
{
   clsvWritingOnBBCaseEN obj = clsvWritingOnBBCaseWApi.GetObjByid_WritingOnBBCase(strid_WritingOnBBCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvWritingOnBBCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWritingOnBBCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseEN> GetObjLstById_WritingOnBBCaseLst(List<string> arrId_WritingOnBBCase)
{
 List<clsvWritingOnBBCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_WritingOnBBCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WritingOnBBCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_WritingOnBBCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvWritingOnBBCaseEN> GetObjLstById_WritingOnBBCaseLst_Cache(List<string> arrId_WritingOnBBCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWritingOnBBCaseEN._CurrTabName_S);
List<clsvWritingOnBBCaseEN> arrvWritingOnBBCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvWritingOnBBCaseEN> arrvWritingOnBBCaseObjLst_Sel =
from objvWritingOnBBCaseEN in arrvWritingOnBBCaseObjLst_Cache
where arrId_WritingOnBBCase.Contains(objvWritingOnBBCaseEN.id_WritingOnBBCase)
select objvWritingOnBBCaseEN;
return arrvWritingOnBBCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWritingOnBBCaseEN> GetObjLstById_WritingOnBBCaseLst_WA_Cache(List<string> arrId_WritingOnBBCase)
{
 List<clsvWritingOnBBCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_WritingOnBBCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WritingOnBBCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_WritingOnBBCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_WritingOnBBCase"] = strid_WritingOnBBCase
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
 /// <param name = "objvWritingOnBBCaseENS">源对象</param>
 /// <param name = "objvWritingOnBBCaseENT">目标对象</param>
 public static void CopyTo(clsvWritingOnBBCaseEN objvWritingOnBBCaseENS, clsvWritingOnBBCaseEN objvWritingOnBBCaseENT)
{
try
{
objvWritingOnBBCaseENT.id_WritingOnBBCase = objvWritingOnBBCaseENS.id_WritingOnBBCase; //板书案例流水号
objvWritingOnBBCaseENT.WritingOnBBCaseID = objvWritingOnBBCaseENS.WritingOnBBCaseID; //板书教学案例ID
objvWritingOnBBCaseENT.WritingOnBBCaseName = objvWritingOnBBCaseENS.WritingOnBBCaseName; //板书教学案例名称
objvWritingOnBBCaseENT.WritingOnBBCaseTheme = objvWritingOnBBCaseENS.WritingOnBBCaseTheme; //板书教学案例主题词
objvWritingOnBBCaseENT.id_Discipline = objvWritingOnBBCaseENS.id_Discipline; //学科流水号
objvWritingOnBBCaseENT.DisciplineID = objvWritingOnBBCaseENS.DisciplineID; //学科ID
objvWritingOnBBCaseENT.DisciplineName = objvWritingOnBBCaseENS.DisciplineName; //学科名称
objvWritingOnBBCaseENT.WritingOnBBCaseDate = objvWritingOnBBCaseENS.WritingOnBBCaseDate; //板书教学日期
objvWritingOnBBCaseENT.WritingOnBBCaseTime = objvWritingOnBBCaseENS.WritingOnBBCaseTime; //板书教学时间
objvWritingOnBBCaseENT.WritingOnBBCaseDateIn = objvWritingOnBBCaseENS.WritingOnBBCaseDateIn; //案例入库日期
objvWritingOnBBCaseENT.WritingOnBBCaseTimeIn = objvWritingOnBBCaseENS.WritingOnBBCaseTimeIn; //案例入库时间
objvWritingOnBBCaseENT.id_StudyLevel = objvWritingOnBBCaseENS.id_StudyLevel; //id_StudyLevel
objvWritingOnBBCaseENT.StudyLevelName = objvWritingOnBBCaseENS.StudyLevelName; //学段名称
objvWritingOnBBCaseENT.IsNeedGeneWord = objvWritingOnBBCaseENS.IsNeedGeneWord; //是否需要生成Word
objvWritingOnBBCaseENT.WordCreateDate = objvWritingOnBBCaseENS.WordCreateDate; //Word生成日期
objvWritingOnBBCaseENT.DocFile = objvWritingOnBBCaseENS.DocFile; //生成的Word文件名
objvWritingOnBBCaseENT.CaseLevelId = objvWritingOnBBCaseENS.CaseLevelId; //课例等级Id
objvWritingOnBBCaseENT.id_SenateGaugeVersion = objvWritingOnBBCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvWritingOnBBCaseENT.senateGaugeVersionID = objvWritingOnBBCaseENS.senateGaugeVersionID; //评价量表版本ID
objvWritingOnBBCaseENT.senateGaugeVersionName = objvWritingOnBBCaseENS.senateGaugeVersionName; //评价量表版本名称
objvWritingOnBBCaseENT.senateGaugeVersionTtlScore = objvWritingOnBBCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvWritingOnBBCaseENT.VersionNo = objvWritingOnBBCaseENS.VersionNo; //版本号
objvWritingOnBBCaseENT.IsVisible = objvWritingOnBBCaseENS.IsVisible; //是否显示
objvWritingOnBBCaseENT.OwnerId = objvWritingOnBBCaseENS.OwnerId; //拥有者Id
objvWritingOnBBCaseENT.StuName = objvWritingOnBBCaseENS.StuName; //姓名
objvWritingOnBBCaseENT.StuID = objvWritingOnBBCaseENS.StuID; //学号
objvWritingOnBBCaseENT.CollegeID = objvWritingOnBBCaseENS.CollegeID; //学院ID
objvWritingOnBBCaseENT.CollegeName = objvWritingOnBBCaseENS.CollegeName; //学院名称
objvWritingOnBBCaseENT.CollegeNameA = objvWritingOnBBCaseENS.CollegeNameA; //学院名称简写
objvWritingOnBBCaseENT.id_XzCollege = objvWritingOnBBCaseENS.id_XzCollege; //学院流水号
objvWritingOnBBCaseENT.id_XzMajor = objvWritingOnBBCaseENS.id_XzMajor; //专业流水号
objvWritingOnBBCaseENT.MajorName = objvWritingOnBBCaseENS.MajorName; //专业名称
objvWritingOnBBCaseENT.id_GradeBase = objvWritingOnBBCaseENS.id_GradeBase; //年级流水号
objvWritingOnBBCaseENT.GradeBaseName = objvWritingOnBBCaseENS.GradeBaseName; //年级名称
objvWritingOnBBCaseENT.id_AdminCls = objvWritingOnBBCaseENS.id_AdminCls; //行政班流水号
objvWritingOnBBCaseENT.IsDualVideo = objvWritingOnBBCaseENS.IsDualVideo; //是否双视频
objvWritingOnBBCaseENT.id_WritingOnBBCaseType = objvWritingOnBBCaseENS.id_WritingOnBBCaseType; //板书案例类型流水号
objvWritingOnBBCaseENT.WritingOnBBCaseTypeName = objvWritingOnBBCaseENS.WritingOnBBCaseTypeName; //板书案例类型名称
objvWritingOnBBCaseENT.UserTypeId = objvWritingOnBBCaseENS.UserTypeId; //用户类型Id
objvWritingOnBBCaseENT.UserTypeName = objvWritingOnBBCaseENS.UserTypeName; //用户类型名称
objvWritingOnBBCaseENT.RecommendedDegreeId = objvWritingOnBBCaseENS.RecommendedDegreeId; //推荐度Id
objvWritingOnBBCaseENT.RecommendedDegreeName = objvWritingOnBBCaseENS.RecommendedDegreeName; //推荐度名称
objvWritingOnBBCaseENT.ftpFileType = objvWritingOnBBCaseENS.ftpFileType; //ftp文件类型
objvWritingOnBBCaseENT.VideoUrl = objvWritingOnBBCaseENS.VideoUrl; //视频Url
objvWritingOnBBCaseENT.VideoPath = objvWritingOnBBCaseENS.VideoPath; //视频目录
objvWritingOnBBCaseENT.ResErrMsg = objvWritingOnBBCaseENS.ResErrMsg; //资源错误信息
objvWritingOnBBCaseENT.UpdUserId = objvWritingOnBBCaseENS.UpdUserId; //修改用户Id
objvWritingOnBBCaseENT.UpdDate = objvWritingOnBBCaseENS.UpdDate; //修改日期
objvWritingOnBBCaseENT.Memo = objvWritingOnBBCaseENS.Memo; //备注
objvWritingOnBBCaseENT.OwnerNameWithId = objvWritingOnBBCaseENS.OwnerNameWithId; //拥有者名称附Id
objvWritingOnBBCaseENT.OwnerName = objvWritingOnBBCaseENS.OwnerName; //拥有者姓名
objvWritingOnBBCaseENT.BrowseCount4Case = objvWritingOnBBCaseENS.BrowseCount4Case; //课例浏览次数
objvWritingOnBBCaseENT.IsHaveVideo = objvWritingOnBBCaseENS.IsHaveVideo; //IsHaveVideo
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
public static DataTable ToDataTable(List<clsvWritingOnBBCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvWritingOnBBCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvWritingOnBBCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvWritingOnBBCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvWritingOnBBCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvWritingOnBBCaseEN.AttributeName)
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
if (clsWritingOnBBCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWritingOnBBCaseWApi没有刷新缓存机制(clsWritingOnBBCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWritingOnBBCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWritingOnBBCaseTypeWApi没有刷新缓存机制(clsWritingOnBBCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_WritingOnBBCase");
//if (arrvWritingOnBBCaseObjLst_Cache == null)
//{
//arrvWritingOnBBCaseObjLst_Cache = await clsvWritingOnBBCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvWritingOnBBCaseEN._CurrTabName_S);
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
public static List<clsvWritingOnBBCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvWritingOnBBCaseEN._CurrTabName_S);
List<clsvWritingOnBBCaseEN> arrvWritingOnBBCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvWritingOnBBCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvWritingOnBBCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convWritingOnBBCase.id_WritingOnBBCase, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.WritingOnBBCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.WritingOnBBCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.WritingOnBBCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.WritingOnBBCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.WritingOnBBCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.WritingOnBBCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.WritingOnBBCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convWritingOnBBCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convWritingOnBBCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCase.id_WritingOnBBCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.WritingOnBBCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convWritingOnBBCase.IsHaveVideo, Type.GetType("System.String"));
foreach (clsvWritingOnBBCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convWritingOnBBCase.id_WritingOnBBCase] = objInFor[convWritingOnBBCase.id_WritingOnBBCase];
objDR[convWritingOnBBCase.WritingOnBBCaseID] = objInFor[convWritingOnBBCase.WritingOnBBCaseID];
objDR[convWritingOnBBCase.WritingOnBBCaseName] = objInFor[convWritingOnBBCase.WritingOnBBCaseName];
objDR[convWritingOnBBCase.WritingOnBBCaseTheme] = objInFor[convWritingOnBBCase.WritingOnBBCaseTheme];
objDR[convWritingOnBBCase.id_Discipline] = objInFor[convWritingOnBBCase.id_Discipline];
objDR[convWritingOnBBCase.DisciplineID] = objInFor[convWritingOnBBCase.DisciplineID];
objDR[convWritingOnBBCase.DisciplineName] = objInFor[convWritingOnBBCase.DisciplineName];
objDR[convWritingOnBBCase.WritingOnBBCaseDate] = objInFor[convWritingOnBBCase.WritingOnBBCaseDate];
objDR[convWritingOnBBCase.WritingOnBBCaseTime] = objInFor[convWritingOnBBCase.WritingOnBBCaseTime];
objDR[convWritingOnBBCase.WritingOnBBCaseDateIn] = objInFor[convWritingOnBBCase.WritingOnBBCaseDateIn];
objDR[convWritingOnBBCase.WritingOnBBCaseTimeIn] = objInFor[convWritingOnBBCase.WritingOnBBCaseTimeIn];
objDR[convWritingOnBBCase.id_StudyLevel] = objInFor[convWritingOnBBCase.id_StudyLevel];
objDR[convWritingOnBBCase.StudyLevelName] = objInFor[convWritingOnBBCase.StudyLevelName];
objDR[convWritingOnBBCase.IsNeedGeneWord] = objInFor[convWritingOnBBCase.IsNeedGeneWord];
objDR[convWritingOnBBCase.WordCreateDate] = objInFor[convWritingOnBBCase.WordCreateDate];
objDR[convWritingOnBBCase.DocFile] = objInFor[convWritingOnBBCase.DocFile];
objDR[convWritingOnBBCase.CaseLevelId] = objInFor[convWritingOnBBCase.CaseLevelId];
objDR[convWritingOnBBCase.id_SenateGaugeVersion] = objInFor[convWritingOnBBCase.id_SenateGaugeVersion];
objDR[convWritingOnBBCase.senateGaugeVersionID] = objInFor[convWritingOnBBCase.senateGaugeVersionID];
objDR[convWritingOnBBCase.senateGaugeVersionName] = objInFor[convWritingOnBBCase.senateGaugeVersionName];
objDR[convWritingOnBBCase.senateGaugeVersionTtlScore] = objInFor[convWritingOnBBCase.senateGaugeVersionTtlScore];
objDR[convWritingOnBBCase.VersionNo] = objInFor[convWritingOnBBCase.VersionNo];
objDR[convWritingOnBBCase.IsVisible] = objInFor[convWritingOnBBCase.IsVisible];
objDR[convWritingOnBBCase.OwnerId] = objInFor[convWritingOnBBCase.OwnerId];
objDR[convWritingOnBBCase.StuName] = objInFor[convWritingOnBBCase.StuName];
objDR[convWritingOnBBCase.StuID] = objInFor[convWritingOnBBCase.StuID];
objDR[convWritingOnBBCase.CollegeID] = objInFor[convWritingOnBBCase.CollegeID];
objDR[convWritingOnBBCase.CollegeName] = objInFor[convWritingOnBBCase.CollegeName];
objDR[convWritingOnBBCase.CollegeNameA] = objInFor[convWritingOnBBCase.CollegeNameA];
objDR[convWritingOnBBCase.id_XzCollege] = objInFor[convWritingOnBBCase.id_XzCollege];
objDR[convWritingOnBBCase.id_XzMajor] = objInFor[convWritingOnBBCase.id_XzMajor];
objDR[convWritingOnBBCase.MajorName] = objInFor[convWritingOnBBCase.MajorName];
objDR[convWritingOnBBCase.id_GradeBase] = objInFor[convWritingOnBBCase.id_GradeBase];
objDR[convWritingOnBBCase.GradeBaseName] = objInFor[convWritingOnBBCase.GradeBaseName];
objDR[convWritingOnBBCase.id_AdminCls] = objInFor[convWritingOnBBCase.id_AdminCls];
objDR[convWritingOnBBCase.IsDualVideo] = objInFor[convWritingOnBBCase.IsDualVideo];
objDR[convWritingOnBBCase.id_WritingOnBBCaseType] = objInFor[convWritingOnBBCase.id_WritingOnBBCaseType];
objDR[convWritingOnBBCase.WritingOnBBCaseTypeName] = objInFor[convWritingOnBBCase.WritingOnBBCaseTypeName];
objDR[convWritingOnBBCase.UserTypeId] = objInFor[convWritingOnBBCase.UserTypeId];
objDR[convWritingOnBBCase.UserTypeName] = objInFor[convWritingOnBBCase.UserTypeName];
objDR[convWritingOnBBCase.RecommendedDegreeId] = objInFor[convWritingOnBBCase.RecommendedDegreeId];
objDR[convWritingOnBBCase.RecommendedDegreeName] = objInFor[convWritingOnBBCase.RecommendedDegreeName];
objDR[convWritingOnBBCase.ftpFileType] = objInFor[convWritingOnBBCase.ftpFileType];
objDR[convWritingOnBBCase.VideoUrl] = objInFor[convWritingOnBBCase.VideoUrl];
objDR[convWritingOnBBCase.VideoPath] = objInFor[convWritingOnBBCase.VideoPath];
objDR[convWritingOnBBCase.ResErrMsg] = objInFor[convWritingOnBBCase.ResErrMsg];
objDR[convWritingOnBBCase.UpdUserId] = objInFor[convWritingOnBBCase.UpdUserId];
objDR[convWritingOnBBCase.UpdDate] = objInFor[convWritingOnBBCase.UpdDate];
objDR[convWritingOnBBCase.Memo] = objInFor[convWritingOnBBCase.Memo];
objDR[convWritingOnBBCase.OwnerNameWithId] = objInFor[convWritingOnBBCase.OwnerNameWithId];
objDR[convWritingOnBBCase.OwnerName] = objInFor[convWritingOnBBCase.OwnerName];
objDR[convWritingOnBBCase.BrowseCount4Case] = objInFor[convWritingOnBBCase.BrowseCount4Case];
objDR[convWritingOnBBCase.IsHaveVideo] = objInFor[convWritingOnBBCase.IsHaveVideo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}