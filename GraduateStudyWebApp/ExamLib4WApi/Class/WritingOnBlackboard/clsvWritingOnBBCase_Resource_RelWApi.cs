
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWritingOnBBCase_Resource_RelWApi
 表名:vWritingOnBBCase_Resource_Rel(01120423)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:47
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
public static class clsvWritingOnBBCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvWritingOnBBCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFuncModuleId(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convWritingOnBBCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convWritingOnBBCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convWritingOnBBCase_Resource_Rel.FuncModuleId);
objvWritingOnBBCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FuncModuleId) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFuncModuleName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convWritingOnBBCase_Resource_Rel.FuncModuleName);
objvWritingOnBBCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FuncModuleName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_MicroteachCase(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convWritingOnBBCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convWritingOnBBCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convWritingOnBBCase_Resource_Rel.id_MicroteachCase);
objvWritingOnBBCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_MicroteachCase) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_WritingOnBBCase(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_WritingOnBBCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_WritingOnBBCase, convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase);
clsCheckSql.CheckFieldLen(strid_WritingOnBBCase, 8, convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase);
clsCheckSql.CheckFieldForeignKey(strid_WritingOnBBCase, 8, convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase);
objvWritingOnBBCase_Resource_RelEN.id_WritingOnBBCase = strid_WritingOnBBCase; //板书案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetWritingOnBBCaseID(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strWritingOnBBCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseID, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseID, 8, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseID, 8, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID);
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseID = strWritingOnBBCaseID; //板书教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetWritingOnBBCaseName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strWritingOnBBCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseName, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseName, 100, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName);
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseName = strWritingOnBBCaseName; //板书教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetWritingOnBBCaseTheme(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strWritingOnBBCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTheme, 200, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme);
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTheme = strWritingOnBBCaseTheme; //板书教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_Discipline(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convWritingOnBBCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convWritingOnBBCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convWritingOnBBCase_Resource_Rel.id_Discipline);
objvWritingOnBBCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_Discipline) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetDisciplineID(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convWritingOnBBCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convWritingOnBBCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convWritingOnBBCase_Resource_Rel.DisciplineID);
objvWritingOnBBCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.DisciplineID) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetDisciplineName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convWritingOnBBCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convWritingOnBBCase_Resource_Rel.DisciplineName);
objvWritingOnBBCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.DisciplineName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetWritingOnBBCaseDate(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strWritingOnBBCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseDate, 8, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseDate, 8, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate);
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDate = strWritingOnBBCaseDate; //板书教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetWritingOnBBCaseTime(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strWritingOnBBCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTime, 6, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseTime, 6, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime);
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTime = strWritingOnBBCaseTime; //板书教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetWritingOnBBCaseDateIn(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strWritingOnBBCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseDateIn, 8, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseDateIn, 8, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn);
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDateIn = strWritingOnBBCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetWritingOnBBCaseTimeIn(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strWritingOnBBCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTimeIn, 6, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseTimeIn, 6, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn);
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTimeIn = strWritingOnBBCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_StudyLevel(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convWritingOnBBCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convWritingOnBBCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convWritingOnBBCase_Resource_Rel.id_StudyLevel);
objvWritingOnBBCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_StudyLevel) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetStudyLevelName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convWritingOnBBCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convWritingOnBBCase_Resource_Rel.StudyLevelName);
objvWritingOnBBCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.StudyLevelName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetCaseLevelId(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convWritingOnBBCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convWritingOnBBCase_Resource_Rel.CaseLevelId);
objvWritingOnBBCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.CaseLevelId) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetsenateGaugeVersionID(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convWritingOnBBCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convWritingOnBBCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convWritingOnBBCase_Resource_Rel.senateGaugeVersionID);
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetsenateGaugeVersionName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convWritingOnBBCase_Resource_Rel.senateGaugeVersionName);
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore);
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetVersionNo(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvWritingOnBBCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.VersionNo) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetOwnerId(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convWritingOnBBCase_Resource_Rel.OwnerId);
objvWritingOnBBCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.OwnerId) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetStuName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convWritingOnBBCase_Resource_Rel.StuName);
clsCheckSql.CheckFieldLen(strStuName, 50, convWritingOnBBCase_Resource_Rel.StuName);
objvWritingOnBBCase_Resource_RelEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.StuName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.StuName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.StuName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetStuID(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuID, convWritingOnBBCase_Resource_Rel.StuID);
clsCheckSql.CheckFieldLen(strStuID, 20, convWritingOnBBCase_Resource_Rel.StuID);
objvWritingOnBBCase_Resource_RelEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.StuID) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.StuID, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.StuID] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetCollegeName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convWritingOnBBCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convWritingOnBBCase_Resource_Rel.CollegeName);
objvWritingOnBBCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.CollegeName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_XzCollege(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convWritingOnBBCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convWritingOnBBCase_Resource_Rel.id_XzCollege);
objvWritingOnBBCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_XzCollege) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_XzMajor(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convWritingOnBBCase_Resource_Rel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convWritingOnBBCase_Resource_Rel.id_XzMajor);
objvWritingOnBBCase_Resource_RelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_XzMajor) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_XzMajor, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_XzMajor] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_GradeBase(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convWritingOnBBCase_Resource_Rel.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convWritingOnBBCase_Resource_Rel.id_GradeBase);
objvWritingOnBBCase_Resource_RelEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_GradeBase) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_GradeBase, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_GradeBase] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_AdminCls(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convWritingOnBBCase_Resource_Rel.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convWritingOnBBCase_Resource_Rel.id_AdminCls);
objvWritingOnBBCase_Resource_RelEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_AdminCls) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_AdminCls, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_AdminCls] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetCollegeNameA(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convWritingOnBBCase_Resource_Rel.CollegeNameA);
objvWritingOnBBCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.CollegeNameA) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetIsDualVideo(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvWritingOnBBCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.IsDualVideo) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetRecommendedDegreeId(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convWritingOnBBCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convWritingOnBBCase_Resource_Rel.RecommendedDegreeId);
objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetRecommendedDegreeName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convWritingOnBBCase_Resource_Rel.RecommendedDegreeName);
objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetBrowseCount4Case(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvWritingOnBBCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.BrowseCount4Case) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_Resource(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convWritingOnBBCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convWritingOnBBCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convWritingOnBBCase_Resource_Rel.id_Resource);
objvWritingOnBBCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_Resource) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetResourceID(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convWritingOnBBCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convWritingOnBBCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convWritingOnBBCase_Resource_Rel.ResourceID);
objvWritingOnBBCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.ResourceID) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_FtpResource(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convWritingOnBBCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convWritingOnBBCase_Resource_Rel.id_FtpResource);
objvWritingOnBBCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_FtpResource) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_File(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convWritingOnBBCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convWritingOnBBCase_Resource_Rel.id_File);
objvWritingOnBBCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_File) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convWritingOnBBCase_Resource_Rel.FileName);
objvWritingOnBBCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileType(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convWritingOnBBCase_Resource_Rel.FileType);
objvWritingOnBBCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileType) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetSaveDate(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convWritingOnBBCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convWritingOnBBCase_Resource_Rel.SaveDate);
objvWritingOnBBCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.SaveDate) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileSize(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convWritingOnBBCase_Resource_Rel.FileSize);
objvWritingOnBBCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileSize) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetSaveTime(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convWritingOnBBCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convWritingOnBBCase_Resource_Rel.SaveTime);
objvWritingOnBBCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.SaveTime) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFtpResourceID(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convWritingOnBBCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convWritingOnBBCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convWritingOnBBCase_Resource_Rel.FtpResourceID);
objvWritingOnBBCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FtpResourceID) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileOriginalName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convWritingOnBBCase_Resource_Rel.FileOriginalName);
objvWritingOnBBCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileOriginalName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileDirName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convWritingOnBBCase_Resource_Rel.FileDirName);
objvWritingOnBBCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileDirName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileRename(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convWritingOnBBCase_Resource_Rel.FileRename);
objvWritingOnBBCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileRename) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileUpDate(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convWritingOnBBCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convWritingOnBBCase_Resource_Rel.FileUpDate);
objvWritingOnBBCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileUpDate) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileUpTime(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convWritingOnBBCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convWritingOnBBCase_Resource_Rel.FileUpTime);
objvWritingOnBBCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileUpTime) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetSaveMode(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvWritingOnBBCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.SaveMode) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_ResourceType(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convWritingOnBBCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convWritingOnBBCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convWritingOnBBCase_Resource_Rel.id_ResourceType);
objvWritingOnBBCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_ResourceType) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetResourceTypeID(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convWritingOnBBCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convWritingOnBBCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convWritingOnBBCase_Resource_Rel.ResourceTypeID);
objvWritingOnBBCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.ResourceTypeID) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetResourceTypeName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convWritingOnBBCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convWritingOnBBCase_Resource_Rel.ResourceTypeName);
objvWritingOnBBCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.ResourceTypeName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetResourceOwner(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convWritingOnBBCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convWritingOnBBCase_Resource_Rel.ResourceOwner);
objvWritingOnBBCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.ResourceOwner) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetftpFileType(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convWritingOnBBCase_Resource_Rel.ftpFileType);
objvWritingOnBBCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.ftpFileType) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetftpFileSize(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convWritingOnBBCase_Resource_Rel.ftpFileSize);
objvWritingOnBBCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.ftpFileSize) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetftpResourceOwner(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convWritingOnBBCase_Resource_Rel.ftpResourceOwner);
objvWritingOnBBCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.ftpResourceOwner) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileOriginName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convWritingOnBBCase_Resource_Rel.FileOriginName);
objvWritingOnBBCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileOriginName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetIsExistFile(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvWritingOnBBCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.IsExistFile) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileNewName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convWritingOnBBCase_Resource_Rel.FileNewName);
objvWritingOnBBCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileNewName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetFileOldName(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convWritingOnBBCase_Resource_Rel.FileOldName);
objvWritingOnBBCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.FileOldName) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetIsMain(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvWritingOnBBCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.IsMain) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN Setid_UsingMode(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_UsingMode, convWritingOnBBCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convWritingOnBBCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convWritingOnBBCase_Resource_Rel.id_UsingMode);
objvWritingOnBBCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.id_UsingMode) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetIsVisible(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvWritingOnBBCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.IsVisible) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetIndexNO(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvWritingOnBBCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.IndexNO) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetBrowseCount(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvWritingOnBBCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.BrowseCount) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetUpdDate(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWritingOnBBCase_Resource_Rel.UpdDate);
objvWritingOnBBCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.UpdDate) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetUpdUser(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convWritingOnBBCase_Resource_Rel.UpdUser);
objvWritingOnBBCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.UpdUser) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCase_Resource_RelEN SetMemo(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWritingOnBBCase_Resource_Rel.Memo);
objvWritingOnBBCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCase_Resource_Rel.Memo) == false)
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp.Add(convWritingOnBBCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvWritingOnBBCase_Resource_RelEN.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvWritingOnBBCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvWritingOnBBCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FuncModuleId, objvWritingOnBBCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FuncModuleName, objvWritingOnBBCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_MicroteachCase, objvWritingOnBBCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase) == true)
{
string strComparisonOp_id_WritingOnBBCase = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase, objvWritingOnBBCase_Resource_Rel_Cond.id_WritingOnBBCase, strComparisonOp_id_WritingOnBBCase);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID) == true)
{
string strComparisonOp_WritingOnBBCaseID = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID, objvWritingOnBBCase_Resource_Rel_Cond.WritingOnBBCaseID, strComparisonOp_WritingOnBBCaseID);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName) == true)
{
string strComparisonOp_WritingOnBBCaseName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName, objvWritingOnBBCase_Resource_Rel_Cond.WritingOnBBCaseName, strComparisonOp_WritingOnBBCaseName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme) == true)
{
string strComparisonOp_WritingOnBBCaseTheme = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme, objvWritingOnBBCase_Resource_Rel_Cond.WritingOnBBCaseTheme, strComparisonOp_WritingOnBBCaseTheme);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_Discipline, objvWritingOnBBCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.DisciplineID, objvWritingOnBBCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.DisciplineName, objvWritingOnBBCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate) == true)
{
string strComparisonOp_WritingOnBBCaseDate = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate, objvWritingOnBBCase_Resource_Rel_Cond.WritingOnBBCaseDate, strComparisonOp_WritingOnBBCaseDate);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime) == true)
{
string strComparisonOp_WritingOnBBCaseTime = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime, objvWritingOnBBCase_Resource_Rel_Cond.WritingOnBBCaseTime, strComparisonOp_WritingOnBBCaseTime);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn) == true)
{
string strComparisonOp_WritingOnBBCaseDateIn = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn, objvWritingOnBBCase_Resource_Rel_Cond.WritingOnBBCaseDateIn, strComparisonOp_WritingOnBBCaseDateIn);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn) == true)
{
string strComparisonOp_WritingOnBBCaseTimeIn = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn, objvWritingOnBBCase_Resource_Rel_Cond.WritingOnBBCaseTimeIn, strComparisonOp_WritingOnBBCaseTimeIn);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_StudyLevel, objvWritingOnBBCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.StudyLevelName, objvWritingOnBBCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.CaseLevelId, objvWritingOnBBCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.senateGaugeVersionID, objvWritingOnBBCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.senateGaugeVersionName, objvWritingOnBBCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore, objvWritingOnBBCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCase_Resource_Rel.VersionNo, objvWritingOnBBCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.OwnerId, objvWritingOnBBCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.StuName) == true)
{
string strComparisonOp_StuName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.StuName, objvWritingOnBBCase_Resource_Rel_Cond.StuName, strComparisonOp_StuName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.StuID) == true)
{
string strComparisonOp_StuID = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.StuID, objvWritingOnBBCase_Resource_Rel_Cond.StuID, strComparisonOp_StuID);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.CollegeName, objvWritingOnBBCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_XzCollege, objvWritingOnBBCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_XzMajor, objvWritingOnBBCase_Resource_Rel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_GradeBase, objvWritingOnBBCase_Resource_Rel_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_AdminCls, objvWritingOnBBCase_Resource_Rel_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.CollegeNameA, objvWritingOnBBCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.IsDualVideo) == true)
{
if (objvWritingOnBBCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCase_Resource_Rel.IsDualVideo);
}
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.RecommendedDegreeId, objvWritingOnBBCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.RecommendedDegreeName, objvWritingOnBBCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCase_Resource_Rel.BrowseCount4Case, objvWritingOnBBCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_Resource, objvWritingOnBBCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.ResourceID, objvWritingOnBBCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_FtpResource, objvWritingOnBBCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_File, objvWritingOnBBCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileName, objvWritingOnBBCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileType, objvWritingOnBBCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.SaveDate, objvWritingOnBBCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileSize, objvWritingOnBBCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.SaveTime, objvWritingOnBBCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FtpResourceID, objvWritingOnBBCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileOriginalName, objvWritingOnBBCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileDirName, objvWritingOnBBCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileRename, objvWritingOnBBCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileUpDate, objvWritingOnBBCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileUpTime, objvWritingOnBBCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.SaveMode) == true)
{
if (objvWritingOnBBCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCase_Resource_Rel.SaveMode);
}
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_ResourceType, objvWritingOnBBCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.ResourceTypeID, objvWritingOnBBCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.ResourceTypeName, objvWritingOnBBCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.ResourceOwner, objvWritingOnBBCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.ftpFileType, objvWritingOnBBCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.ftpFileSize, objvWritingOnBBCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.ftpResourceOwner, objvWritingOnBBCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileOriginName, objvWritingOnBBCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.IsExistFile) == true)
{
if (objvWritingOnBBCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCase_Resource_Rel.IsExistFile);
}
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileNewName, objvWritingOnBBCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.FileOldName, objvWritingOnBBCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.IsMain) == true)
{
if (objvWritingOnBBCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCase_Resource_Rel.IsMain);
}
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.id_UsingMode, objvWritingOnBBCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.IsVisible) == true)
{
if (objvWritingOnBBCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCase_Resource_Rel.IsVisible);
}
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCase_Resource_Rel.IndexNO, objvWritingOnBBCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCase_Resource_Rel.BrowseCount, objvWritingOnBBCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.UpdDate, objvWritingOnBBCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.UpdUser, objvWritingOnBBCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvWritingOnBBCase_Resource_Rel_Cond.IsUpdated(convWritingOnBBCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvWritingOnBBCase_Resource_Rel_Cond.dicFldComparisonOp[convWritingOnBBCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCase_Resource_Rel.Memo, objvWritingOnBBCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vWritingOnBBCase_Resource_Rel(vWritingOnBBCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvWritingOnBBCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vWritingOnBBCase_Resource_RelApi";

 public clsvWritingOnBBCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWritingOnBBCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvWritingOnBBCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvWritingOnBBCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCase_Resource_RelEN;
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWritingOnBBCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvWritingOnBBCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvWritingOnBBCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCase_Resource_RelEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvWritingOnBBCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN = null;
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
objvWritingOnBBCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvWritingOnBBCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCase_Resource_RelEN;
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWritingOnBBCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWritingOnBBCase_Resource_RelEN._CurrTabName_S);
List<clsvWritingOnBBCase_Resource_RelEN> arrvWritingOnBBCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvWritingOnBBCase_Resource_RelEN> arrvWritingOnBBCase_Resource_RelObjLst_Sel =
from objvWritingOnBBCase_Resource_RelEN in arrvWritingOnBBCase_Resource_RelObjLst_Cache
where objvWritingOnBBCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvWritingOnBBCase_Resource_RelEN;
if (arrvWritingOnBBCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvWritingOnBBCase_Resource_RelEN obj = clsvWritingOnBBCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvWritingOnBBCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWritingOnBBCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvWritingOnBBCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvWritingOnBBCase_Resource_RelEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCase_Resource_RelLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvWritingOnBBCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWritingOnBBCase_Resource_RelEN._CurrTabName_S);
List<clsvWritingOnBBCase_Resource_RelEN> arrvWritingOnBBCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvWritingOnBBCase_Resource_RelEN> arrvWritingOnBBCase_Resource_RelObjLst_Sel =
from objvWritingOnBBCase_Resource_RelEN in arrvWritingOnBBCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvWritingOnBBCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvWritingOnBBCase_Resource_RelEN;
return arrvWritingOnBBCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWritingOnBBCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvWritingOnBBCase_Resource_RelEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCase_Resource_RelLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvWritingOnBBCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvWritingOnBBCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvWritingOnBBCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvWritingOnBBCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroteachCase_Resource_Rel)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
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
 /// <param name = "objvWritingOnBBCase_Resource_RelENS">源对象</param>
 /// <param name = "objvWritingOnBBCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelENS, clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelENT)
{
try
{
objvWritingOnBBCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvWritingOnBBCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvWritingOnBBCase_Resource_RelENT.FuncModuleId = objvWritingOnBBCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvWritingOnBBCase_Resource_RelENT.FuncModuleName = objvWritingOnBBCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvWritingOnBBCase_Resource_RelENT.id_MicroteachCase = objvWritingOnBBCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvWritingOnBBCase_Resource_RelENT.id_WritingOnBBCase = objvWritingOnBBCase_Resource_RelENS.id_WritingOnBBCase; //板书案例流水号
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseID = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseID; //板书教学案例ID
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseName = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseName; //板书教学案例名称
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseTheme = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseTheme; //板书教学案例主题词
objvWritingOnBBCase_Resource_RelENT.id_Discipline = objvWritingOnBBCase_Resource_RelENS.id_Discipline; //学科流水号
objvWritingOnBBCase_Resource_RelENT.DisciplineID = objvWritingOnBBCase_Resource_RelENS.DisciplineID; //学科ID
objvWritingOnBBCase_Resource_RelENT.DisciplineName = objvWritingOnBBCase_Resource_RelENS.DisciplineName; //学科名称
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseDate = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseDate; //板书教学日期
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseTime = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseTime; //板书教学时间
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseDateIn = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseDateIn; //案例入库日期
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseTimeIn = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseTimeIn; //案例入库时间
objvWritingOnBBCase_Resource_RelENT.id_StudyLevel = objvWritingOnBBCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvWritingOnBBCase_Resource_RelENT.StudyLevelName = objvWritingOnBBCase_Resource_RelENS.StudyLevelName; //学段名称
objvWritingOnBBCase_Resource_RelENT.CaseLevelId = objvWritingOnBBCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvWritingOnBBCase_Resource_RelENT.senateGaugeVersionID = objvWritingOnBBCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvWritingOnBBCase_Resource_RelENT.senateGaugeVersionName = objvWritingOnBBCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvWritingOnBBCase_Resource_RelENT.senateGaugeVersionTtlScore = objvWritingOnBBCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvWritingOnBBCase_Resource_RelENT.VersionNo = objvWritingOnBBCase_Resource_RelENS.VersionNo; //版本号
objvWritingOnBBCase_Resource_RelENT.OwnerId = objvWritingOnBBCase_Resource_RelENS.OwnerId; //拥有者Id
objvWritingOnBBCase_Resource_RelENT.StuName = objvWritingOnBBCase_Resource_RelENS.StuName; //姓名
objvWritingOnBBCase_Resource_RelENT.StuID = objvWritingOnBBCase_Resource_RelENS.StuID; //学号
objvWritingOnBBCase_Resource_RelENT.CollegeName = objvWritingOnBBCase_Resource_RelENS.CollegeName; //学院名称
objvWritingOnBBCase_Resource_RelENT.id_XzCollege = objvWritingOnBBCase_Resource_RelENS.id_XzCollege; //学院流水号
objvWritingOnBBCase_Resource_RelENT.id_XzMajor = objvWritingOnBBCase_Resource_RelENS.id_XzMajor; //专业流水号
objvWritingOnBBCase_Resource_RelENT.id_GradeBase = objvWritingOnBBCase_Resource_RelENS.id_GradeBase; //年级流水号
objvWritingOnBBCase_Resource_RelENT.id_AdminCls = objvWritingOnBBCase_Resource_RelENS.id_AdminCls; //行政班流水号
objvWritingOnBBCase_Resource_RelENT.CollegeNameA = objvWritingOnBBCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvWritingOnBBCase_Resource_RelENT.IsDualVideo = objvWritingOnBBCase_Resource_RelENS.IsDualVideo; //是否双视频
objvWritingOnBBCase_Resource_RelENT.RecommendedDegreeId = objvWritingOnBBCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvWritingOnBBCase_Resource_RelENT.RecommendedDegreeName = objvWritingOnBBCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvWritingOnBBCase_Resource_RelENT.BrowseCount4Case = objvWritingOnBBCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvWritingOnBBCase_Resource_RelENT.id_Resource = objvWritingOnBBCase_Resource_RelENS.id_Resource; //资源流水号
objvWritingOnBBCase_Resource_RelENT.ResourceID = objvWritingOnBBCase_Resource_RelENS.ResourceID; //资源ID
objvWritingOnBBCase_Resource_RelENT.id_FtpResource = objvWritingOnBBCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvWritingOnBBCase_Resource_RelENT.id_File = objvWritingOnBBCase_Resource_RelENS.id_File; //文件流水号
objvWritingOnBBCase_Resource_RelENT.FileName = objvWritingOnBBCase_Resource_RelENS.FileName; //文件名称
objvWritingOnBBCase_Resource_RelENT.FileType = objvWritingOnBBCase_Resource_RelENS.FileType; //文件类型
objvWritingOnBBCase_Resource_RelENT.SaveDate = objvWritingOnBBCase_Resource_RelENS.SaveDate; //创建日期
objvWritingOnBBCase_Resource_RelENT.FileSize = objvWritingOnBBCase_Resource_RelENS.FileSize; //文件大小
objvWritingOnBBCase_Resource_RelENT.SaveTime = objvWritingOnBBCase_Resource_RelENS.SaveTime; //创建时间
objvWritingOnBBCase_Resource_RelENT.FtpResourceID = objvWritingOnBBCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvWritingOnBBCase_Resource_RelENT.FileOriginalName = objvWritingOnBBCase_Resource_RelENS.FileOriginalName; //文件原名
objvWritingOnBBCase_Resource_RelENT.FileDirName = objvWritingOnBBCase_Resource_RelENS.FileDirName; //文件目录名
objvWritingOnBBCase_Resource_RelENT.FileRename = objvWritingOnBBCase_Resource_RelENS.FileRename; //文件新名
objvWritingOnBBCase_Resource_RelENT.FileUpDate = objvWritingOnBBCase_Resource_RelENS.FileUpDate; //创建日期
objvWritingOnBBCase_Resource_RelENT.FileUpTime = objvWritingOnBBCase_Resource_RelENS.FileUpTime; //创建时间
objvWritingOnBBCase_Resource_RelENT.SaveMode = objvWritingOnBBCase_Resource_RelENS.SaveMode; //文件存放方式
objvWritingOnBBCase_Resource_RelENT.id_ResourceType = objvWritingOnBBCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvWritingOnBBCase_Resource_RelENT.ResourceTypeID = objvWritingOnBBCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvWritingOnBBCase_Resource_RelENT.ResourceTypeName = objvWritingOnBBCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvWritingOnBBCase_Resource_RelENT.ResourceOwner = objvWritingOnBBCase_Resource_RelENS.ResourceOwner; //上传者
objvWritingOnBBCase_Resource_RelENT.ftpFileType = objvWritingOnBBCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvWritingOnBBCase_Resource_RelENT.ftpFileSize = objvWritingOnBBCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvWritingOnBBCase_Resource_RelENT.ftpResourceOwner = objvWritingOnBBCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvWritingOnBBCase_Resource_RelENT.FileOriginName = objvWritingOnBBCase_Resource_RelENS.FileOriginName; //原文件名
objvWritingOnBBCase_Resource_RelENT.IsExistFile = objvWritingOnBBCase_Resource_RelENS.IsExistFile; //是否存在文件
objvWritingOnBBCase_Resource_RelENT.FileNewName = objvWritingOnBBCase_Resource_RelENS.FileNewName; //新文件名
objvWritingOnBBCase_Resource_RelENT.FileOldName = objvWritingOnBBCase_Resource_RelENS.FileOldName; //旧文件名
objvWritingOnBBCase_Resource_RelENT.IsMain = objvWritingOnBBCase_Resource_RelENS.IsMain; //是否主资源
objvWritingOnBBCase_Resource_RelENT.id_UsingMode = objvWritingOnBBCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvWritingOnBBCase_Resource_RelENT.IsVisible = objvWritingOnBBCase_Resource_RelENS.IsVisible; //是否显示
objvWritingOnBBCase_Resource_RelENT.IndexNO = objvWritingOnBBCase_Resource_RelENS.IndexNO; //序号
objvWritingOnBBCase_Resource_RelENT.BrowseCount = objvWritingOnBBCase_Resource_RelENS.BrowseCount; //浏览次数
objvWritingOnBBCase_Resource_RelENT.UpdDate = objvWritingOnBBCase_Resource_RelENS.UpdDate; //修改日期
objvWritingOnBBCase_Resource_RelENT.UpdUser = objvWritingOnBBCase_Resource_RelENS.UpdUser; //修改人
objvWritingOnBBCase_Resource_RelENT.Memo = objvWritingOnBBCase_Resource_RelENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvWritingOnBBCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvWritingOnBBCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvWritingOnBBCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvWritingOnBBCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvWritingOnBBCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvWritingOnBBCase_Resource_RelEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCase_Resource_RelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelWApi没有刷新缓存机制(clsMicroteachCase_Resource_RelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceWApi没有刷新缓存机制(clsResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerWApi没有刷新缓存机制(clsFileServerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvWritingOnBBCase_Resource_RelObjLst_Cache == null)
//{
//arrvWritingOnBBCase_Resource_RelObjLst_Cache = await clsvWritingOnBBCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvWritingOnBBCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvWritingOnBBCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvWritingOnBBCase_Resource_RelEN._CurrTabName_S);
List<clsvWritingOnBBCase_Resource_RelEN> arrvWritingOnBBCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvWritingOnBBCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvWritingOnBBCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCase_Resource_Rel.Memo, Type.GetType("System.String"));
foreach (clsvWritingOnBBCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convWritingOnBBCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convWritingOnBBCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convWritingOnBBCase_Resource_Rel.FuncModuleId] = objInFor[convWritingOnBBCase_Resource_Rel.FuncModuleId];
objDR[convWritingOnBBCase_Resource_Rel.FuncModuleName] = objInFor[convWritingOnBBCase_Resource_Rel.FuncModuleName];
objDR[convWritingOnBBCase_Resource_Rel.id_MicroteachCase] = objInFor[convWritingOnBBCase_Resource_Rel.id_MicroteachCase];
objDR[convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase] = objInFor[convWritingOnBBCase_Resource_Rel.id_WritingOnBBCase];
objDR[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID] = objInFor[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID];
objDR[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName] = objInFor[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName];
objDR[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme] = objInFor[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme];
objDR[convWritingOnBBCase_Resource_Rel.id_Discipline] = objInFor[convWritingOnBBCase_Resource_Rel.id_Discipline];
objDR[convWritingOnBBCase_Resource_Rel.DisciplineID] = objInFor[convWritingOnBBCase_Resource_Rel.DisciplineID];
objDR[convWritingOnBBCase_Resource_Rel.DisciplineName] = objInFor[convWritingOnBBCase_Resource_Rel.DisciplineName];
objDR[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate] = objInFor[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate];
objDR[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime] = objInFor[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime];
objDR[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn] = objInFor[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn];
objDR[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn] = objInFor[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn];
objDR[convWritingOnBBCase_Resource_Rel.id_StudyLevel] = objInFor[convWritingOnBBCase_Resource_Rel.id_StudyLevel];
objDR[convWritingOnBBCase_Resource_Rel.StudyLevelName] = objInFor[convWritingOnBBCase_Resource_Rel.StudyLevelName];
objDR[convWritingOnBBCase_Resource_Rel.CaseLevelId] = objInFor[convWritingOnBBCase_Resource_Rel.CaseLevelId];
objDR[convWritingOnBBCase_Resource_Rel.senateGaugeVersionID] = objInFor[convWritingOnBBCase_Resource_Rel.senateGaugeVersionID];
objDR[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName] = objInFor[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName];
objDR[convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convWritingOnBBCase_Resource_Rel.VersionNo] = objInFor[convWritingOnBBCase_Resource_Rel.VersionNo];
objDR[convWritingOnBBCase_Resource_Rel.OwnerId] = objInFor[convWritingOnBBCase_Resource_Rel.OwnerId];
objDR[convWritingOnBBCase_Resource_Rel.StuName] = objInFor[convWritingOnBBCase_Resource_Rel.StuName];
objDR[convWritingOnBBCase_Resource_Rel.StuID] = objInFor[convWritingOnBBCase_Resource_Rel.StuID];
objDR[convWritingOnBBCase_Resource_Rel.CollegeName] = objInFor[convWritingOnBBCase_Resource_Rel.CollegeName];
objDR[convWritingOnBBCase_Resource_Rel.id_XzCollege] = objInFor[convWritingOnBBCase_Resource_Rel.id_XzCollege];
objDR[convWritingOnBBCase_Resource_Rel.id_XzMajor] = objInFor[convWritingOnBBCase_Resource_Rel.id_XzMajor];
objDR[convWritingOnBBCase_Resource_Rel.id_GradeBase] = objInFor[convWritingOnBBCase_Resource_Rel.id_GradeBase];
objDR[convWritingOnBBCase_Resource_Rel.id_AdminCls] = objInFor[convWritingOnBBCase_Resource_Rel.id_AdminCls];
objDR[convWritingOnBBCase_Resource_Rel.CollegeNameA] = objInFor[convWritingOnBBCase_Resource_Rel.CollegeNameA];
objDR[convWritingOnBBCase_Resource_Rel.IsDualVideo] = objInFor[convWritingOnBBCase_Resource_Rel.IsDualVideo];
objDR[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId] = objInFor[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId];
objDR[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName] = objInFor[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName];
objDR[convWritingOnBBCase_Resource_Rel.BrowseCount4Case] = objInFor[convWritingOnBBCase_Resource_Rel.BrowseCount4Case];
objDR[convWritingOnBBCase_Resource_Rel.id_Resource] = objInFor[convWritingOnBBCase_Resource_Rel.id_Resource];
objDR[convWritingOnBBCase_Resource_Rel.ResourceID] = objInFor[convWritingOnBBCase_Resource_Rel.ResourceID];
objDR[convWritingOnBBCase_Resource_Rel.id_FtpResource] = objInFor[convWritingOnBBCase_Resource_Rel.id_FtpResource];
objDR[convWritingOnBBCase_Resource_Rel.id_File] = objInFor[convWritingOnBBCase_Resource_Rel.id_File];
objDR[convWritingOnBBCase_Resource_Rel.FileName] = objInFor[convWritingOnBBCase_Resource_Rel.FileName];
objDR[convWritingOnBBCase_Resource_Rel.FileType] = objInFor[convWritingOnBBCase_Resource_Rel.FileType];
objDR[convWritingOnBBCase_Resource_Rel.SaveDate] = objInFor[convWritingOnBBCase_Resource_Rel.SaveDate];
objDR[convWritingOnBBCase_Resource_Rel.FileSize] = objInFor[convWritingOnBBCase_Resource_Rel.FileSize];
objDR[convWritingOnBBCase_Resource_Rel.SaveTime] = objInFor[convWritingOnBBCase_Resource_Rel.SaveTime];
objDR[convWritingOnBBCase_Resource_Rel.FtpResourceID] = objInFor[convWritingOnBBCase_Resource_Rel.FtpResourceID];
objDR[convWritingOnBBCase_Resource_Rel.FileOriginalName] = objInFor[convWritingOnBBCase_Resource_Rel.FileOriginalName];
objDR[convWritingOnBBCase_Resource_Rel.FileDirName] = objInFor[convWritingOnBBCase_Resource_Rel.FileDirName];
objDR[convWritingOnBBCase_Resource_Rel.FileRename] = objInFor[convWritingOnBBCase_Resource_Rel.FileRename];
objDR[convWritingOnBBCase_Resource_Rel.FileUpDate] = objInFor[convWritingOnBBCase_Resource_Rel.FileUpDate];
objDR[convWritingOnBBCase_Resource_Rel.FileUpTime] = objInFor[convWritingOnBBCase_Resource_Rel.FileUpTime];
objDR[convWritingOnBBCase_Resource_Rel.SaveMode] = objInFor[convWritingOnBBCase_Resource_Rel.SaveMode];
objDR[convWritingOnBBCase_Resource_Rel.id_ResourceType] = objInFor[convWritingOnBBCase_Resource_Rel.id_ResourceType];
objDR[convWritingOnBBCase_Resource_Rel.ResourceTypeID] = objInFor[convWritingOnBBCase_Resource_Rel.ResourceTypeID];
objDR[convWritingOnBBCase_Resource_Rel.ResourceTypeName] = objInFor[convWritingOnBBCase_Resource_Rel.ResourceTypeName];
objDR[convWritingOnBBCase_Resource_Rel.ResourceOwner] = objInFor[convWritingOnBBCase_Resource_Rel.ResourceOwner];
objDR[convWritingOnBBCase_Resource_Rel.ftpFileType] = objInFor[convWritingOnBBCase_Resource_Rel.ftpFileType];
objDR[convWritingOnBBCase_Resource_Rel.ftpFileSize] = objInFor[convWritingOnBBCase_Resource_Rel.ftpFileSize];
objDR[convWritingOnBBCase_Resource_Rel.ftpResourceOwner] = objInFor[convWritingOnBBCase_Resource_Rel.ftpResourceOwner];
objDR[convWritingOnBBCase_Resource_Rel.FileOriginName] = objInFor[convWritingOnBBCase_Resource_Rel.FileOriginName];
objDR[convWritingOnBBCase_Resource_Rel.IsExistFile] = objInFor[convWritingOnBBCase_Resource_Rel.IsExistFile];
objDR[convWritingOnBBCase_Resource_Rel.FileNewName] = objInFor[convWritingOnBBCase_Resource_Rel.FileNewName];
objDR[convWritingOnBBCase_Resource_Rel.FileOldName] = objInFor[convWritingOnBBCase_Resource_Rel.FileOldName];
objDR[convWritingOnBBCase_Resource_Rel.IsMain] = objInFor[convWritingOnBBCase_Resource_Rel.IsMain];
objDR[convWritingOnBBCase_Resource_Rel.id_UsingMode] = objInFor[convWritingOnBBCase_Resource_Rel.id_UsingMode];
objDR[convWritingOnBBCase_Resource_Rel.IsVisible] = objInFor[convWritingOnBBCase_Resource_Rel.IsVisible];
objDR[convWritingOnBBCase_Resource_Rel.IndexNO] = objInFor[convWritingOnBBCase_Resource_Rel.IndexNO];
objDR[convWritingOnBBCase_Resource_Rel.BrowseCount] = objInFor[convWritingOnBBCase_Resource_Rel.BrowseCount];
objDR[convWritingOnBBCase_Resource_Rel.UpdDate] = objInFor[convWritingOnBBCase_Resource_Rel.UpdDate];
objDR[convWritingOnBBCase_Resource_Rel.UpdUser] = objInFor[convWritingOnBBCase_Resource_Rel.UpdUser];
objDR[convWritingOnBBCase_Resource_Rel.Memo] = objInFor[convWritingOnBBCase_Resource_Rel.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}