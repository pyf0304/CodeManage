
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWritingOnBBCaseWApi
 表名:WritingOnBBCase(01120467)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:44
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
public static class clsWritingOnBBCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN Setid_WritingOnBBCase(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strid_WritingOnBBCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_WritingOnBBCase, 8, conWritingOnBBCase.id_WritingOnBBCase);
clsCheckSql.CheckFieldForeignKey(strid_WritingOnBBCase, 8, conWritingOnBBCase.id_WritingOnBBCase);
objWritingOnBBCaseEN.id_WritingOnBBCase = strid_WritingOnBBCase; //板书案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.id_WritingOnBBCase) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.id_WritingOnBBCase, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.id_WritingOnBBCase] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetWritingOnBBCaseID(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strWritingOnBBCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseID, conWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseID, 8, conWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseID, 8, conWritingOnBBCase.WritingOnBBCaseID);
objWritingOnBBCaseEN.WritingOnBBCaseID = strWritingOnBBCaseID; //板书教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.WritingOnBBCaseID) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.WritingOnBBCaseID, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseID] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetWritingOnBBCaseName(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strWritingOnBBCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseName, conWritingOnBBCase.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseName, 100, conWritingOnBBCase.WritingOnBBCaseName);
objWritingOnBBCaseEN.WritingOnBBCaseName = strWritingOnBBCaseName; //板书教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.WritingOnBBCaseName) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.WritingOnBBCaseName, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseName] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetWritingOnBBCaseTheme(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strWritingOnBBCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTheme, 200, conWritingOnBBCase.WritingOnBBCaseTheme);
objWritingOnBBCaseEN.WritingOnBBCaseTheme = strWritingOnBBCaseTheme; //板书教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.WritingOnBBCaseTheme) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.WritingOnBBCaseTheme, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseTheme] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN Setid_Discipline(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, conWritingOnBBCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conWritingOnBBCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conWritingOnBBCase.id_Discipline);
objWritingOnBBCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.id_Discipline) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.id_Discipline, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.id_Discipline] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetWritingOnBBCaseDate(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strWritingOnBBCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseDate, 8, conWritingOnBBCase.WritingOnBBCaseDate);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseDate, 8, conWritingOnBBCase.WritingOnBBCaseDate);
objWritingOnBBCaseEN.WritingOnBBCaseDate = strWritingOnBBCaseDate; //板书教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.WritingOnBBCaseDate) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.WritingOnBBCaseDate, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseDate] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetWritingOnBBCaseTime(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strWritingOnBBCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTime, 6, conWritingOnBBCase.WritingOnBBCaseTime);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseTime, 6, conWritingOnBBCase.WritingOnBBCaseTime);
objWritingOnBBCaseEN.WritingOnBBCaseTime = strWritingOnBBCaseTime; //板书教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.WritingOnBBCaseTime) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.WritingOnBBCaseTime, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseTime] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetWritingOnBBCaseDateIn(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strWritingOnBBCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseDateIn, 8, conWritingOnBBCase.WritingOnBBCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseDateIn, 8, conWritingOnBBCase.WritingOnBBCaseDateIn);
objWritingOnBBCaseEN.WritingOnBBCaseDateIn = strWritingOnBBCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.WritingOnBBCaseDateIn) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.WritingOnBBCaseDateIn, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseDateIn] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetWritingOnBBCaseTimeIn(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strWritingOnBBCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTimeIn, 6, conWritingOnBBCase.WritingOnBBCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseTimeIn, 6, conWritingOnBBCase.WritingOnBBCaseTimeIn);
objWritingOnBBCaseEN.WritingOnBBCaseTimeIn = strWritingOnBBCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.WritingOnBBCaseTimeIn) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.WritingOnBBCaseTimeIn, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseTimeIn] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetBrowseCount(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, int intBrowseCount, string strComparisonOp="")
	{
objWritingOnBBCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.BrowseCount) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.BrowseCount, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.BrowseCount] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN Setid_StudyLevel(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, conWritingOnBBCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conWritingOnBBCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conWritingOnBBCase.id_StudyLevel);
objWritingOnBBCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.id_StudyLevel) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.id_StudyLevel, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.id_StudyLevel] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetIsNeedGeneWord(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objWritingOnBBCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.IsNeedGeneWord) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetWordCreateDate(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conWritingOnBBCase.WordCreateDate);
objWritingOnBBCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.WordCreateDate) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.WordCreateDate, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.WordCreateDate] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetDocFile(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conWritingOnBBCase.DocFile);
objWritingOnBBCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.DocFile) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.DocFile, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.DocFile] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetCaseLevelId(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conWritingOnBBCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conWritingOnBBCase.CaseLevelId);
objWritingOnBBCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.CaseLevelId) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.CaseLevelId, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.CaseLevelId] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN Setid_SenateGaugeVersion(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, conWritingOnBBCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conWritingOnBBCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conWritingOnBBCase.id_SenateGaugeVersion);
objWritingOnBBCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.id_SenateGaugeVersion) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetIsVisible(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objWritingOnBBCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.IsVisible) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.IsVisible, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.IsVisible] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetOwnerId(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conWritingOnBBCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conWritingOnBBCase.OwnerId);
objWritingOnBBCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.OwnerId) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.OwnerId, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.OwnerId] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetIsDualVideo(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, conWritingOnBBCase.IsDualVideo);
objWritingOnBBCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.IsDualVideo) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.IsDualVideo, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.IsDualVideo] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN Setid_WritingOnBBCaseType(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strid_WritingOnBBCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_WritingOnBBCaseType, 4, conWritingOnBBCase.id_WritingOnBBCaseType);
clsCheckSql.CheckFieldForeignKey(strid_WritingOnBBCaseType, 4, conWritingOnBBCase.id_WritingOnBBCaseType);
objWritingOnBBCaseEN.id_WritingOnBBCaseType = strid_WritingOnBBCaseType; //板书案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.id_WritingOnBBCaseType) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.id_WritingOnBBCaseType, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.id_WritingOnBBCaseType] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetUserTypeId(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conWritingOnBBCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conWritingOnBBCase.UserTypeId);
objWritingOnBBCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.UserTypeId) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.UserTypeId, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.UserTypeId] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetRecommendedDegreeId(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conWritingOnBBCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conWritingOnBBCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conWritingOnBBCase.RecommendedDegreeId);
objWritingOnBBCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.RecommendedDegreeId) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetftpFileType(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conWritingOnBBCase.ftpFileType);
objWritingOnBBCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.ftpFileType) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.ftpFileType, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.ftpFileType] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetVideoUrl(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conWritingOnBBCase.VideoUrl);
objWritingOnBBCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.VideoUrl) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.VideoUrl, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.VideoUrl] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetVideoPath(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conWritingOnBBCase.VideoPath);
objWritingOnBBCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.VideoPath) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.VideoPath, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.VideoPath] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetResErrMsg(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conWritingOnBBCase.ResErrMsg);
objWritingOnBBCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.ResErrMsg) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.ResErrMsg, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.ResErrMsg] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetUpdUserId(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conWritingOnBBCase.UpdUserId);
objWritingOnBBCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.UpdUserId) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.UpdUserId, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.UpdUserId] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetUpdDate(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conWritingOnBBCase.UpdDate);
objWritingOnBBCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.UpdDate) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.UpdDate, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.UpdDate] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseEN SetMemo(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conWritingOnBBCase.Memo);
objWritingOnBBCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCase.Memo) == false)
{
objWritingOnBBCaseEN.dicFldComparisonOp.Add(conWritingOnBBCase.Memo, strComparisonOp);
}
else
{
objWritingOnBBCaseEN.dicFldComparisonOp[conWritingOnBBCase.Memo] = strComparisonOp;
}
}
return objWritingOnBBCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsWritingOnBBCaseEN objWritingOnBBCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.id_WritingOnBBCase) == true)
{
string strComparisonOp_id_WritingOnBBCase = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.id_WritingOnBBCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.id_WritingOnBBCase, objWritingOnBBCase_Cond.id_WritingOnBBCase, strComparisonOp_id_WritingOnBBCase);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.WritingOnBBCaseID) == true)
{
string strComparisonOp_WritingOnBBCaseID = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.WritingOnBBCaseID, objWritingOnBBCase_Cond.WritingOnBBCaseID, strComparisonOp_WritingOnBBCaseID);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.WritingOnBBCaseName) == true)
{
string strComparisonOp_WritingOnBBCaseName = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.WritingOnBBCaseName, objWritingOnBBCase_Cond.WritingOnBBCaseName, strComparisonOp_WritingOnBBCaseName);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTheme) == true)
{
string strComparisonOp_WritingOnBBCaseTheme = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.WritingOnBBCaseTheme, objWritingOnBBCase_Cond.WritingOnBBCaseTheme, strComparisonOp_WritingOnBBCaseTheme);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.id_Discipline, objWritingOnBBCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDate) == true)
{
string strComparisonOp_WritingOnBBCaseDate = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.WritingOnBBCaseDate, objWritingOnBBCase_Cond.WritingOnBBCaseDate, strComparisonOp_WritingOnBBCaseDate);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTime) == true)
{
string strComparisonOp_WritingOnBBCaseTime = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.WritingOnBBCaseTime, objWritingOnBBCase_Cond.WritingOnBBCaseTime, strComparisonOp_WritingOnBBCaseTime);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDateIn) == true)
{
string strComparisonOp_WritingOnBBCaseDateIn = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.WritingOnBBCaseDateIn, objWritingOnBBCase_Cond.WritingOnBBCaseDateIn, strComparisonOp_WritingOnBBCaseDateIn);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTimeIn) == true)
{
string strComparisonOp_WritingOnBBCaseTimeIn = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.WritingOnBBCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.WritingOnBBCaseTimeIn, objWritingOnBBCase_Cond.WritingOnBBCaseTimeIn, strComparisonOp_WritingOnBBCaseTimeIn);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conWritingOnBBCase.BrowseCount, objWritingOnBBCase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.id_StudyLevel, objWritingOnBBCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.IsNeedGeneWord) == true)
{
if (objWritingOnBBCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWritingOnBBCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWritingOnBBCase.IsNeedGeneWord);
}
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.WordCreateDate, objWritingOnBBCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.DocFile) == true)
{
string strComparisonOp_DocFile = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.DocFile, objWritingOnBBCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.CaseLevelId, objWritingOnBBCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.id_SenateGaugeVersion, objWritingOnBBCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.IsVisible) == true)
{
if (objWritingOnBBCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWritingOnBBCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWritingOnBBCase.IsVisible);
}
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.OwnerId, objWritingOnBBCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.IsDualVideo) == true)
{
if (objWritingOnBBCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWritingOnBBCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWritingOnBBCase.IsDualVideo);
}
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.id_WritingOnBBCaseType) == true)
{
string strComparisonOp_id_WritingOnBBCaseType = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.id_WritingOnBBCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.id_WritingOnBBCaseType, objWritingOnBBCase_Cond.id_WritingOnBBCaseType, strComparisonOp_id_WritingOnBBCaseType);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.UserTypeId, objWritingOnBBCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.RecommendedDegreeId, objWritingOnBBCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.ftpFileType, objWritingOnBBCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.VideoUrl, objWritingOnBBCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.VideoPath, objWritingOnBBCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.ResErrMsg, objWritingOnBBCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.UpdUserId, objWritingOnBBCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.UpdDate, objWritingOnBBCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objWritingOnBBCase_Cond.IsUpdated(conWritingOnBBCase.Memo) == true)
{
string strComparisonOp_Memo = objWritingOnBBCase_Cond.dicFldComparisonOp[conWritingOnBBCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCase.Memo, objWritingOnBBCase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
 if (string.IsNullOrEmpty(objWritingOnBBCaseEN.id_WritingOnBBCase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objWritingOnBBCaseEN.sf_UpdFldSetStr = objWritingOnBBCaseEN.getsf_UpdFldSetStr();
clsWritingOnBBCaseWApi.CheckPropertyNew(objWritingOnBBCaseEN); 
bool bolResult = clsWritingOnBBCaseWApi.UpdateRecord(objWritingOnBBCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseWApi.ReFreshCache();
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
 /// <param name = "objWritingOnBBCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
 if (string.IsNullOrEmpty(objWritingOnBBCaseEN.id_WritingOnBBCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsWritingOnBBCaseWApi.IsExist(objWritingOnBBCaseEN.id_WritingOnBBCase) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objWritingOnBBCaseEN.id_WritingOnBBCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsWritingOnBBCaseWApi.CheckPropertyNew(objWritingOnBBCaseEN); 
bool bolResult = clsWritingOnBBCaseWApi.AddNewRecord(objWritingOnBBCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseWApi.ReFreshCache();
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
 /// <param name = "objWritingOnBBCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
try
{
clsWritingOnBBCaseWApi.CheckPropertyNew(objWritingOnBBCaseEN); 
string strid_WritingOnBBCase = clsWritingOnBBCaseWApi.AddNewRecordWithMaxId(objWritingOnBBCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseWApi.ReFreshCache();
return strid_WritingOnBBCase;
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
 /// <param name = "objWritingOnBBCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strWhereCond)
{
try
{
clsWritingOnBBCaseWApi.CheckPropertyNew(objWritingOnBBCaseEN); 
bool bolResult = clsWritingOnBBCaseWApi.UpdateWithCondition(objWritingOnBBCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseWApi.ReFreshCache();
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
 /// 板书教学案例(WritingOnBBCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsWritingOnBBCaseWApi
{
private static readonly string mstrApiControllerName = "WritingOnBBCaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsWritingOnBBCaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_WritingOnBBCase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[板书教学案例]...","0");
List<clsWritingOnBBCaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_WritingOnBBCase";
objDDL.DataTextField="WritingOnBBCaseName";
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
public static void BindCbo_id_WritingOnBBCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conWritingOnBBCase.id_WritingOnBBCase); 
List<clsWritingOnBBCaseEN> arrObjLst = clsWritingOnBBCaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsWritingOnBBCaseEN objWritingOnBBCaseEN = new clsWritingOnBBCaseEN()
{
id_WritingOnBBCase = "0",
WritingOnBBCaseName = "选[板书教学案例]..."
};
arrObjLst.Insert(0, objWritingOnBBCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conWritingOnBBCase.id_WritingOnBBCase;
objComboBox.DisplayMember = conWritingOnBBCase.WritingOnBBCaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
if (!Object.Equals(null, objWritingOnBBCaseEN.id_WritingOnBBCase) && GetStrLen(objWritingOnBBCaseEN.id_WritingOnBBCase) > 8)
{
 throw new Exception("字段[板书案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.WritingOnBBCaseID) && GetStrLen(objWritingOnBBCaseEN.WritingOnBBCaseID) > 8)
{
 throw new Exception("字段[板书教学案例ID]的长度不能超过8!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.WritingOnBBCaseName) && GetStrLen(objWritingOnBBCaseEN.WritingOnBBCaseName) > 100)
{
 throw new Exception("字段[板书教学案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.WritingOnBBCaseTheme) && GetStrLen(objWritingOnBBCaseEN.WritingOnBBCaseTheme) > 200)
{
 throw new Exception("字段[板书教学案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.id_Discipline) && GetStrLen(objWritingOnBBCaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.WritingOnBBCaseDate) && GetStrLen(objWritingOnBBCaseEN.WritingOnBBCaseDate) > 8)
{
 throw new Exception("字段[板书教学日期]的长度不能超过8!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.WritingOnBBCaseTime) && GetStrLen(objWritingOnBBCaseEN.WritingOnBBCaseTime) > 6)
{
 throw new Exception("字段[板书教学时间]的长度不能超过6!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.WritingOnBBCaseDateIn) && GetStrLen(objWritingOnBBCaseEN.WritingOnBBCaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.WritingOnBBCaseTimeIn) && GetStrLen(objWritingOnBBCaseEN.WritingOnBBCaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.id_StudyLevel) && GetStrLen(objWritingOnBBCaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.WordCreateDate) && GetStrLen(objWritingOnBBCaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.DocFile) && GetStrLen(objWritingOnBBCaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.CaseLevelId) && GetStrLen(objWritingOnBBCaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.id_SenateGaugeVersion) && GetStrLen(objWritingOnBBCaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.OwnerId) && GetStrLen(objWritingOnBBCaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.id_WritingOnBBCaseType) && GetStrLen(objWritingOnBBCaseEN.id_WritingOnBBCaseType) > 4)
{
 throw new Exception("字段[板书案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.UserTypeId) && GetStrLen(objWritingOnBBCaseEN.UserTypeId) > 2)
{
 throw new Exception("字段[用户类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.RecommendedDegreeId) && GetStrLen(objWritingOnBBCaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.ftpFileType) && GetStrLen(objWritingOnBBCaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.VideoUrl) && GetStrLen(objWritingOnBBCaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.VideoPath) && GetStrLen(objWritingOnBBCaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.ResErrMsg) && GetStrLen(objWritingOnBBCaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.UpdUserId) && GetStrLen(objWritingOnBBCaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.UpdDate) && GetStrLen(objWritingOnBBCaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objWritingOnBBCaseEN.Memo) && GetStrLen(objWritingOnBBCaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objWritingOnBBCaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_WritingOnBBCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsWritingOnBBCaseEN GetObjByid_WritingOnBBCase(string strid_WritingOnBBCase)
{
string strAction = "GetObjByid_WritingOnBBCase";
string strErrMsg = string.Empty;
string strResult = "";
clsWritingOnBBCaseEN objWritingOnBBCaseEN = null;
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
objWritingOnBBCaseEN = JsonConvert.DeserializeObject<clsWritingOnBBCaseEN>((string)jobjReturn["ReturnObj"]);
return objWritingOnBBCaseEN;
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
public static clsWritingOnBBCaseEN GetObjByid_WritingOnBBCase_WA_Cache(string strid_WritingOnBBCase)
{
string strAction = "GetObjByid_WritingOnBBCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsWritingOnBBCaseEN objWritingOnBBCaseEN = null;
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
objWritingOnBBCaseEN = JsonConvert.DeserializeObject<clsWritingOnBBCaseEN>((string)jobjReturn["ReturnObj"]);
return objWritingOnBBCaseEN;
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
public static clsWritingOnBBCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsWritingOnBBCaseEN objWritingOnBBCaseEN = null;
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
objWritingOnBBCaseEN = JsonConvert.DeserializeObject<clsWritingOnBBCaseEN>((string)jobjReturn["ReturnObj"]);
return objWritingOnBBCaseEN;
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
public static clsWritingOnBBCaseEN GetObjByid_WritingOnBBCase_Cache(string strid_WritingOnBBCase)
{
if (string.IsNullOrEmpty(strid_WritingOnBBCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsWritingOnBBCaseEN._CurrTabName_S);
List<clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Sel =
from objWritingOnBBCaseEN in arrWritingOnBBCaseObjLst_Cache
where objWritingOnBBCaseEN.id_WritingOnBBCase == strid_WritingOnBBCase
select objWritingOnBBCaseEN;
if (arrWritingOnBBCaseObjLst_Sel.Count() == 0)
{
   clsWritingOnBBCaseEN obj = clsWritingOnBBCaseWApi.GetObjByid_WritingOnBBCase(strid_WritingOnBBCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrWritingOnBBCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_WritingOnBBCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetWritingOnBBCaseNameByid_WritingOnBBCase_Cache(string strid_WritingOnBBCase)
{
if (string.IsNullOrEmpty(strid_WritingOnBBCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsWritingOnBBCaseEN._CurrTabName_S);
List<clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Sel1 =
from objWritingOnBBCaseEN in arrWritingOnBBCaseObjLst_Cache
where objWritingOnBBCaseEN.id_WritingOnBBCase == strid_WritingOnBBCase
select objWritingOnBBCaseEN;
List <clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Sel = new List<clsWritingOnBBCaseEN>();
foreach (clsWritingOnBBCaseEN obj in arrWritingOnBBCaseObjLst_Sel1)
{
arrWritingOnBBCaseObjLst_Sel.Add(obj);
}
if (arrWritingOnBBCaseObjLst_Sel.Count > 0)
{
return arrWritingOnBBCaseObjLst_Sel[0].WritingOnBBCaseName;
}
string strErrMsgForGetObjById = string.Format("在WritingOnBBCase对象缓存列表中,找不到记录[id_WritingOnBBCase = {0}](函数:{1})", strid_WritingOnBBCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsWritingOnBBCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_WritingOnBBCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_WritingOnBBCase_Cache(string strid_WritingOnBBCase)
{
if (string.IsNullOrEmpty(strid_WritingOnBBCase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsWritingOnBBCaseEN._CurrTabName_S);
List<clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Sel1 =
from objWritingOnBBCaseEN in arrWritingOnBBCaseObjLst_Cache
where objWritingOnBBCaseEN.id_WritingOnBBCase == strid_WritingOnBBCase
select objWritingOnBBCaseEN;
List <clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Sel = new List<clsWritingOnBBCaseEN>();
foreach (clsWritingOnBBCaseEN obj in arrWritingOnBBCaseObjLst_Sel1)
{
arrWritingOnBBCaseObjLst_Sel.Add(obj);
}
if (arrWritingOnBBCaseObjLst_Sel.Count > 0)
{
return arrWritingOnBBCaseObjLst_Sel[0].WritingOnBBCaseName;
}
string strErrMsgForGetObjById = string.Format("在WritingOnBBCase对象缓存列表中,找不到记录的相关名称[id_WritingOnBBCase = {0}](函数:{1})", strid_WritingOnBBCase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsWritingOnBBCaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsWritingOnBBCaseEN> GetObjLst(string strWhereCond)
{
 List<clsWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsWritingOnBBCaseEN> GetObjLstById_WritingOnBBCaseLst(List<string> arrId_WritingOnBBCase)
{
 List<clsWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsWritingOnBBCaseEN> GetObjLstById_WritingOnBBCaseLst_Cache(List<string> arrId_WritingOnBBCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsWritingOnBBCaseEN._CurrTabName_S);
List<clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Sel =
from objWritingOnBBCaseEN in arrWritingOnBBCaseObjLst_Cache
where arrId_WritingOnBBCase.Contains(objWritingOnBBCaseEN.id_WritingOnBBCase)
select objWritingOnBBCaseEN;
return arrWritingOnBBCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsWritingOnBBCaseEN> GetObjLstById_WritingOnBBCaseLst_WA_Cache(List<string> arrId_WritingOnBBCase)
{
 List<clsWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsWritingOnBBCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsWritingOnBBCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsWritingOnBBCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsWritingOnBBCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsWritingOnBBCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_WritingOnBBCase)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsWritingOnBBCaseEN objWritingOnBBCaseEN = clsWritingOnBBCaseWApi.GetObjByid_WritingOnBBCase(strid_WritingOnBBCase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_WritingOnBBCase.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsWritingOnBBCaseWApi.ReFreshCache();
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
public static int DelWritingOnBBCases(List<string> arrid_WritingOnBBCase)
{
string strAction = "DelWritingOnBBCases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_WritingOnBBCase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsWritingOnBBCaseWApi.ReFreshCache();
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
public static int DelWritingOnBBCasesByCond(string strWhereCond)
{
string strAction = "DelWritingOnBBCasesByCond";
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
public static bool AddNewRecord(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWritingOnBBCaseEN>(objWritingOnBBCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWritingOnBBCaseEN>(objWritingOnBBCaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseWApi.ReFreshCache();
var strid_WritingOnBBCase = (string)jobjReturn["ReturnStr"];
return strid_WritingOnBBCase;
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
public static bool UpdateRecord(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
if (string.IsNullOrEmpty(objWritingOnBBCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objWritingOnBBCaseEN.id_WritingOnBBCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWritingOnBBCaseEN>(objWritingOnBBCaseEN);
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
 /// <param name = "objWritingOnBBCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objWritingOnBBCaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objWritingOnBBCaseEN.id_WritingOnBBCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objWritingOnBBCaseEN.id_WritingOnBBCase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWritingOnBBCaseEN>(objWritingOnBBCaseEN);
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
 /// <param name = "objWritingOnBBCaseENS">源对象</param>
 /// <param name = "objWritingOnBBCaseENT">目标对象</param>
 public static void CopyTo(clsWritingOnBBCaseEN objWritingOnBBCaseENS, clsWritingOnBBCaseEN objWritingOnBBCaseENT)
{
try
{
objWritingOnBBCaseENT.id_WritingOnBBCase = objWritingOnBBCaseENS.id_WritingOnBBCase; //板书案例流水号
objWritingOnBBCaseENT.WritingOnBBCaseID = objWritingOnBBCaseENS.WritingOnBBCaseID; //板书教学案例ID
objWritingOnBBCaseENT.WritingOnBBCaseName = objWritingOnBBCaseENS.WritingOnBBCaseName; //板书教学案例名称
objWritingOnBBCaseENT.WritingOnBBCaseTheme = objWritingOnBBCaseENS.WritingOnBBCaseTheme; //板书教学案例主题词
objWritingOnBBCaseENT.id_Discipline = objWritingOnBBCaseENS.id_Discipline; //学科流水号
objWritingOnBBCaseENT.WritingOnBBCaseDate = objWritingOnBBCaseENS.WritingOnBBCaseDate; //板书教学日期
objWritingOnBBCaseENT.WritingOnBBCaseTime = objWritingOnBBCaseENS.WritingOnBBCaseTime; //板书教学时间
objWritingOnBBCaseENT.WritingOnBBCaseDateIn = objWritingOnBBCaseENS.WritingOnBBCaseDateIn; //案例入库日期
objWritingOnBBCaseENT.WritingOnBBCaseTimeIn = objWritingOnBBCaseENS.WritingOnBBCaseTimeIn; //案例入库时间
objWritingOnBBCaseENT.BrowseCount = objWritingOnBBCaseENS.BrowseCount; //浏览次数
objWritingOnBBCaseENT.id_StudyLevel = objWritingOnBBCaseENS.id_StudyLevel; //id_StudyLevel
objWritingOnBBCaseENT.IsNeedGeneWord = objWritingOnBBCaseENS.IsNeedGeneWord; //是否需要生成Word
objWritingOnBBCaseENT.WordCreateDate = objWritingOnBBCaseENS.WordCreateDate; //Word生成日期
objWritingOnBBCaseENT.DocFile = objWritingOnBBCaseENS.DocFile; //生成的Word文件名
objWritingOnBBCaseENT.CaseLevelId = objWritingOnBBCaseENS.CaseLevelId; //课例等级Id
objWritingOnBBCaseENT.id_SenateGaugeVersion = objWritingOnBBCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objWritingOnBBCaseENT.IsVisible = objWritingOnBBCaseENS.IsVisible; //是否显示
objWritingOnBBCaseENT.OwnerId = objWritingOnBBCaseENS.OwnerId; //拥有者Id
objWritingOnBBCaseENT.IsDualVideo = objWritingOnBBCaseENS.IsDualVideo; //是否双视频
objWritingOnBBCaseENT.id_WritingOnBBCaseType = objWritingOnBBCaseENS.id_WritingOnBBCaseType; //板书案例类型流水号
objWritingOnBBCaseENT.UserTypeId = objWritingOnBBCaseENS.UserTypeId; //用户类型Id
objWritingOnBBCaseENT.RecommendedDegreeId = objWritingOnBBCaseENS.RecommendedDegreeId; //推荐度Id
objWritingOnBBCaseENT.ftpFileType = objWritingOnBBCaseENS.ftpFileType; //ftp文件类型
objWritingOnBBCaseENT.VideoUrl = objWritingOnBBCaseENS.VideoUrl; //视频Url
objWritingOnBBCaseENT.VideoPath = objWritingOnBBCaseENS.VideoPath; //视频目录
objWritingOnBBCaseENT.ResErrMsg = objWritingOnBBCaseENS.ResErrMsg; //资源错误信息
objWritingOnBBCaseENT.UpdUserId = objWritingOnBBCaseENS.UpdUserId; //修改用户Id
objWritingOnBBCaseENT.UpdDate = objWritingOnBBCaseENS.UpdDate; //修改日期
objWritingOnBBCaseENT.Memo = objWritingOnBBCaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsWritingOnBBCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsWritingOnBBCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsWritingOnBBCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsWritingOnBBCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsWritingOnBBCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsWritingOnBBCaseEN.AttributeName)
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
if (clsWritingOnBBCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWritingOnBBCaseWApi没有刷新缓存机制(clsWritingOnBBCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_WritingOnBBCase");
//if (arrWritingOnBBCaseObjLst_Cache == null)
//{
//arrWritingOnBBCaseObjLst_Cache = await clsWritingOnBBCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsWritingOnBBCaseEN._CurrTabName_S);
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
if (clsWritingOnBBCaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsWritingOnBBCaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsWritingOnBBCaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsWritingOnBBCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsWritingOnBBCaseEN._CurrTabName_S);
List<clsWritingOnBBCaseEN> arrWritingOnBBCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrWritingOnBBCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsWritingOnBBCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conWritingOnBBCase.id_WritingOnBBCase, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.WritingOnBBCaseID, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.WritingOnBBCaseName, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.WritingOnBBCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.WritingOnBBCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.WritingOnBBCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.WritingOnBBCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.WritingOnBBCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conWritingOnBBCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conWritingOnBBCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conWritingOnBBCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conWritingOnBBCase.id_WritingOnBBCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCase.Memo, Type.GetType("System.String"));
foreach (clsWritingOnBBCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conWritingOnBBCase.id_WritingOnBBCase] = objInFor[conWritingOnBBCase.id_WritingOnBBCase];
objDR[conWritingOnBBCase.WritingOnBBCaseID] = objInFor[conWritingOnBBCase.WritingOnBBCaseID];
objDR[conWritingOnBBCase.WritingOnBBCaseName] = objInFor[conWritingOnBBCase.WritingOnBBCaseName];
objDR[conWritingOnBBCase.WritingOnBBCaseTheme] = objInFor[conWritingOnBBCase.WritingOnBBCaseTheme];
objDR[conWritingOnBBCase.id_Discipline] = objInFor[conWritingOnBBCase.id_Discipline];
objDR[conWritingOnBBCase.WritingOnBBCaseDate] = objInFor[conWritingOnBBCase.WritingOnBBCaseDate];
objDR[conWritingOnBBCase.WritingOnBBCaseTime] = objInFor[conWritingOnBBCase.WritingOnBBCaseTime];
objDR[conWritingOnBBCase.WritingOnBBCaseDateIn] = objInFor[conWritingOnBBCase.WritingOnBBCaseDateIn];
objDR[conWritingOnBBCase.WritingOnBBCaseTimeIn] = objInFor[conWritingOnBBCase.WritingOnBBCaseTimeIn];
objDR[conWritingOnBBCase.BrowseCount] = objInFor[conWritingOnBBCase.BrowseCount];
objDR[conWritingOnBBCase.id_StudyLevel] = objInFor[conWritingOnBBCase.id_StudyLevel];
objDR[conWritingOnBBCase.IsNeedGeneWord] = objInFor[conWritingOnBBCase.IsNeedGeneWord];
objDR[conWritingOnBBCase.WordCreateDate] = objInFor[conWritingOnBBCase.WordCreateDate];
objDR[conWritingOnBBCase.DocFile] = objInFor[conWritingOnBBCase.DocFile];
objDR[conWritingOnBBCase.CaseLevelId] = objInFor[conWritingOnBBCase.CaseLevelId];
objDR[conWritingOnBBCase.id_SenateGaugeVersion] = objInFor[conWritingOnBBCase.id_SenateGaugeVersion];
objDR[conWritingOnBBCase.IsVisible] = objInFor[conWritingOnBBCase.IsVisible];
objDR[conWritingOnBBCase.OwnerId] = objInFor[conWritingOnBBCase.OwnerId];
objDR[conWritingOnBBCase.IsDualVideo] = objInFor[conWritingOnBBCase.IsDualVideo];
objDR[conWritingOnBBCase.id_WritingOnBBCaseType] = objInFor[conWritingOnBBCase.id_WritingOnBBCaseType];
objDR[conWritingOnBBCase.UserTypeId] = objInFor[conWritingOnBBCase.UserTypeId];
objDR[conWritingOnBBCase.RecommendedDegreeId] = objInFor[conWritingOnBBCase.RecommendedDegreeId];
objDR[conWritingOnBBCase.ftpFileType] = objInFor[conWritingOnBBCase.ftpFileType];
objDR[conWritingOnBBCase.VideoUrl] = objInFor[conWritingOnBBCase.VideoUrl];
objDR[conWritingOnBBCase.VideoPath] = objInFor[conWritingOnBBCase.VideoPath];
objDR[conWritingOnBBCase.ResErrMsg] = objInFor[conWritingOnBBCase.ResErrMsg];
objDR[conWritingOnBBCase.UpdUserId] = objInFor[conWritingOnBBCase.UpdUserId];
objDR[conWritingOnBBCase.UpdDate] = objInFor[conWritingOnBBCase.UpdDate];
objDR[conWritingOnBBCase.Memo] = objInFor[conWritingOnBBCase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 板书教学案例(WritingOnBBCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4WritingOnBBCase : clsCommFun4BL
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
clsWritingOnBBCaseWApi.ReFreshThisCache();
}
}

}