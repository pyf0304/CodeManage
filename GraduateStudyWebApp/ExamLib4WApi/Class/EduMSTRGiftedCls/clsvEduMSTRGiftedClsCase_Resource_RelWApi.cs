
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCase_Resource_RelWApi
 表名:vEduMSTRGiftedClsCase_Resource_Rel(01120431)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:52
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
public static class clsvEduMSTRGiftedClsCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFuncModuleId(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId);
objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFuncModuleName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName);
objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_MicroteachCase(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_EduMSTRGiftedClsCase(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_EduMSTRGiftedClsCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase);
clsCheckSql.CheckFieldForeignKey(strid_EduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_EduMSTRGiftedClsCase = strid_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetEduMSTRGiftedClsCaseID(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strEduMSTRGiftedClsCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID);
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseID = strEduMSTRGiftedClsCaseID; //教育硕士优课案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetEduMSTRGiftedClsCaseName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strEduMSTRGiftedClsCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName);
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseName = strEduMSTRGiftedClsCaseName; //教育硕士优课案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetEduMSTRGiftedClsCaseTheme(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strEduMSTRGiftedClsCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTheme, 200, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme);
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTheme = strEduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetEduMSTRGiftedClsCaseDate(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strEduMSTRGiftedClsCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate);
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDate = strEduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetEduMSTRGiftedClsCaseTime(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strEduMSTRGiftedClsCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime);
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTime = strEduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetEduMSTRGiftedClsCaseDateIn(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strEduMSTRGiftedClsCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn);
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDateIn = strEduMSTRGiftedClsCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_StudyLevel(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetStudyLevelName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName);
objvEduMSTRGiftedClsCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_TeachingPlan(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetEduMSTRGiftedClsCaseTimeIn(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strEduMSTRGiftedClsCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn);
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTimeIn = strEduMSTRGiftedClsCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_EduMSTRGiftedClsCaseType(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_EduMSTRGiftedClsCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType);
clsCheckSql.CheckFieldForeignKey(strid_EduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_EduMSTRGiftedClsCaseType = strid_EduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetEduMSTRGiftedClsCaseTypeName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strEduMSTRGiftedClsCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTypeName, 50, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName);
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTypeName = strEduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetId_CaseType(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_CaseType, convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType);
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType);
objvEduMSTRGiftedClsCase_Resource_RelEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_Discipline(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetDisciplineID(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID);
objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetDisciplineName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName);
objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetsenateGaugeVersionID(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID);
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetsenateGaugeVersionName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName);
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetVersionNo(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.VersionNo) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_TeachSkill(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetTeachSkillID(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID);
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetSkillTypeName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName);
objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetTeachSkillName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName);
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetTeachSkillTheory(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory);
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetTeachSkillOperMethod(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod);
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_SkillType(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetSkillTypeID(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID);
objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetCaseLevelId(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId);
objvEduMSTRGiftedClsCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetEduMSTRGiftedClsCaseText(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strEduMSTRGiftedClsCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseText, 8000, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText);
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseText = strEduMSTRGiftedClsCaseText; //教育硕士优课案例文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetOwnerId(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convEduMSTRGiftedClsCase_Resource_Rel.OwnerId);
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.OwnerId) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetStuName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convEduMSTRGiftedClsCase_Resource_Rel.StuName);
objvEduMSTRGiftedClsCase_Resource_RelEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.StuName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.StuName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StuName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetStuID(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convEduMSTRGiftedClsCase_Resource_Rel.StuID);
objvEduMSTRGiftedClsCase_Resource_RelEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.StuID) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.StuID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StuID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetSexDesc(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convEduMSTRGiftedClsCase_Resource_Rel.SexDesc);
objvEduMSTRGiftedClsCase_Resource_RelEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.SexDesc) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.SexDesc, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetStuTypeID(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strStuTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeID, 4, convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID);
clsCheckSql.CheckFieldForeignKey(strStuTypeID, 4, convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID);
objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeID = strStuTypeID; //学生类别ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetStuTypeDesc(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc);
objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_XzCollege(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetCollegeName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convEduMSTRGiftedClsCase_Resource_Rel.CollegeName);
objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.CollegeName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetCollegeNameA(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA);
objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_XzMajor(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetMajorName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convEduMSTRGiftedClsCase_Resource_Rel.MajorName);
objvEduMSTRGiftedClsCase_Resource_RelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.MajorName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.MajorName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.MajorName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_GradeBase(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetGradeBaseName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName);
objvEduMSTRGiftedClsCase_Resource_RelEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetStuCardNo(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo);
objvEduMSTRGiftedClsCase_Resource_RelEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetEnrollmentDate(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate);
objvEduMSTRGiftedClsCase_Resource_RelEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetIsDualVideo(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetUserTypeId(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId);
objvEduMSTRGiftedClsCase_Resource_RelEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetRecommendedDegreeId(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId);
objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetRecommendedDegreeName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName);
objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetOwnerName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convEduMSTRGiftedClsCase_Resource_Rel.OwnerName);
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.OwnerName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.OwnerName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetOwnerNameWithId(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId);
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetBrowseCount4Case(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_Resource(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convEduMSTRGiftedClsCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_Resource);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_Resource) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetResourceID(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convEduMSTRGiftedClsCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convEduMSTRGiftedClsCase_Resource_Rel.ResourceID);
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.ResourceID) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetResourceName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convEduMSTRGiftedClsCase_Resource_Rel.ResourceName);
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.ResourceName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_FtpResource(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_File(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convEduMSTRGiftedClsCase_Resource_Rel.id_File);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_File) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convEduMSTRGiftedClsCase_Resource_Rel.FileName);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileType(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convEduMSTRGiftedClsCase_Resource_Rel.FileType);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileType) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetSaveDate(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.SaveDate);
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.SaveDate) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileSize(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convEduMSTRGiftedClsCase_Resource_Rel.FileSize);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileSize) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetSaveTime(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convEduMSTRGiftedClsCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convEduMSTRGiftedClsCase_Resource_Rel.SaveTime);
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.SaveTime) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFtpResourceID(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID);
objvEduMSTRGiftedClsCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileOriginalName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileDirName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convEduMSTRGiftedClsCase_Resource_Rel.FileDirName);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileDirName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileRename(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convEduMSTRGiftedClsCase_Resource_Rel.FileRename);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileRename) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileUpDate(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileUpTime(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetSaveMode(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.SaveMode) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_ResourceType(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetResourceTypeID(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID);
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetResourceTypeName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName);
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetResourceOwner(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner);
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetftpFileType(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType);
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetftpFileSize(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize);
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetftpResourceOwner(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner);
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileOriginName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetIsExistFile(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileNewName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convEduMSTRGiftedClsCase_Resource_Rel.FileNewName);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileNewName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetFileOldName(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convEduMSTRGiftedClsCase_Resource_Rel.FileOldName);
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.FileOldName) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetIsMain(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.IsMain) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN Setid_UsingMode(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode);
objvEduMSTRGiftedClsCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetIsVisible(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.IsVisible) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetIndexNO(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.IndexNO) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetBrowseCount(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetUpdDate(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convEduMSTRGiftedClsCase_Resource_Rel.UpdDate);
objvEduMSTRGiftedClsCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.UpdDate) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetUpdUser(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convEduMSTRGiftedClsCase_Resource_Rel.UpdUser);
objvEduMSTRGiftedClsCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.UpdUser) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN SetMemo(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convEduMSTRGiftedClsCase_Resource_Rel.Memo);
objvEduMSTRGiftedClsCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCase_Resource_Rel.Memo) == false)
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCase_Resource_RelEN.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase) == true)
{
string strComparisonOp_id_EduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_EduMSTRGiftedClsCase, strComparisonOp_id_EduMSTRGiftedClsCase);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.EduMSTRGiftedClsCaseID, strComparisonOp_EduMSTRGiftedClsCaseID);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.EduMSTRGiftedClsCaseName, strComparisonOp_EduMSTRGiftedClsCaseName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.EduMSTRGiftedClsCaseTheme, strComparisonOp_EduMSTRGiftedClsCaseTheme);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.EduMSTRGiftedClsCaseDate, strComparisonOp_EduMSTRGiftedClsCaseDate);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.EduMSTRGiftedClsCaseTime, strComparisonOp_EduMSTRGiftedClsCaseTime);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.EduMSTRGiftedClsCaseDateIn, strComparisonOp_EduMSTRGiftedClsCaseDateIn);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.EduMSTRGiftedClsCaseTimeIn, strComparisonOp_EduMSTRGiftedClsCaseTimeIn);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType) == true)
{
string strComparisonOp_id_EduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_EduMSTRGiftedClsCaseType, strComparisonOp_id_EduMSTRGiftedClsCaseType);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.EduMSTRGiftedClsCaseTypeName, strComparisonOp_EduMSTRGiftedClsCaseTypeName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Resource_Rel.VersionNo, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.EduMSTRGiftedClsCaseText, strComparisonOp_EduMSTRGiftedClsCaseText);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.OwnerId, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.StuName) == true)
{
string strComparisonOp_StuName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.StuName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.StuName, strComparisonOp_StuName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.StuID) == true)
{
string strComparisonOp_StuID = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.StuID, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.StuID, strComparisonOp_StuID);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.SexDesc, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID) == true)
{
string strComparisonOp_StuTypeID = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.StuTypeID, strComparisonOp_StuTypeID);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.CollegeName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.MajorName) == true)
{
string strComparisonOp_MajorName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.MajorName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo) == true)
{
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo);
}
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.OwnerName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_Resource, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.ResourceID, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.ResourceName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_File, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileType, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.SaveDate, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileSize, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.SaveTime, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileDirName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileRename, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.SaveMode) == true)
{
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Resource_Rel.SaveMode);
}
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile) == true)
{
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile);
}
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileNewName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.FileOldName, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.IsMain) == true)
{
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Resource_Rel.IsMain);
}
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.IsVisible) == true)
{
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCase_Resource_Rel.IsVisible);
}
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Resource_Rel.IndexNO, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.UpdDate, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.UpdUser, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvEduMSTRGiftedClsCase_Resource_Rel_Cond.IsUpdated(convEduMSTRGiftedClsCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvEduMSTRGiftedClsCase_Resource_Rel_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCase_Resource_Rel.Memo, objvEduMSTRGiftedClsCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教育硕士优课案例与资源关系(vEduMSTRGiftedClsCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvEduMSTRGiftedClsCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vEduMSTRGiftedClsCase_Resource_RelApi";

 public clsvEduMSTRGiftedClsCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN = null;
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
objvEduMSTRGiftedClsCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCase_Resource_RelEN;
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
public static clsvEduMSTRGiftedClsCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN = null;
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
objvEduMSTRGiftedClsCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCase_Resource_RelEN;
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
public static clsvEduMSTRGiftedClsCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN = null;
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
objvEduMSTRGiftedClsCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCase_Resource_RelEN;
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
public static clsvEduMSTRGiftedClsCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_Resource_RelEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCase_Resource_RelEN> arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Sel =
from objvEduMSTRGiftedClsCase_Resource_RelEN in arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Cache
where objvEduMSTRGiftedClsCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvEduMSTRGiftedClsCase_Resource_RelEN;
if (arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvEduMSTRGiftedClsCase_Resource_RelEN obj = clsvEduMSTRGiftedClsCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_Resource_RelEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCase_Resource_RelEN> arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Sel =
from objvEduMSTRGiftedClsCase_Resource_RelEN in arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvEduMSTRGiftedClsCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvEduMSTRGiftedClsCase_Resource_RelEN;
return arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelENS, clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelENT)
{
try
{
objvEduMSTRGiftedClsCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvEduMSTRGiftedClsCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.FuncModuleId = objvEduMSTRGiftedClsCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvEduMSTRGiftedClsCase_Resource_RelENT.FuncModuleName = objvEduMSTRGiftedClsCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvEduMSTRGiftedClsCase_Resource_RelENT.id_MicroteachCase = objvEduMSTRGiftedClsCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.id_EduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_Resource_RelENS.id_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objvEduMSTRGiftedClsCase_Resource_RelENT.id_StudyLevel = objvEduMSTRGiftedClsCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvEduMSTRGiftedClsCase_Resource_RelENT.StudyLevelName = objvEduMSTRGiftedClsCase_Resource_RelENS.StudyLevelName; //学段名称
objvEduMSTRGiftedClsCase_Resource_RelENT.id_TeachingPlan = objvEduMSTRGiftedClsCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objvEduMSTRGiftedClsCase_Resource_RelENT.id_EduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_Resource_RelENS.id_EduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_Resource_RelENT.Id_CaseType = objvEduMSTRGiftedClsCase_Resource_RelENS.Id_CaseType; //案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.id_Discipline = objvEduMSTRGiftedClsCase_Resource_RelENS.id_Discipline; //学科流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.DisciplineID = objvEduMSTRGiftedClsCase_Resource_RelENS.DisciplineID; //学科ID
objvEduMSTRGiftedClsCase_Resource_RelENT.DisciplineName = objvEduMSTRGiftedClsCase_Resource_RelENS.DisciplineName; //学科名称
objvEduMSTRGiftedClsCase_Resource_RelENT.senateGaugeVersionID = objvEduMSTRGiftedClsCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCase_Resource_RelENT.senateGaugeVersionName = objvEduMSTRGiftedClsCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCase_Resource_RelENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCase_Resource_RelENT.VersionNo = objvEduMSTRGiftedClsCase_Resource_RelENS.VersionNo; //版本号
objvEduMSTRGiftedClsCase_Resource_RelENT.id_TeachSkill = objvEduMSTRGiftedClsCase_Resource_RelENS.id_TeachSkill; //教学技能流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.TeachSkillID = objvEduMSTRGiftedClsCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvEduMSTRGiftedClsCase_Resource_RelENT.SkillTypeName = objvEduMSTRGiftedClsCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvEduMSTRGiftedClsCase_Resource_RelENT.TeachSkillName = objvEduMSTRGiftedClsCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvEduMSTRGiftedClsCase_Resource_RelENT.TeachSkillTheory = objvEduMSTRGiftedClsCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvEduMSTRGiftedClsCase_Resource_RelENT.TeachSkillOperMethod = objvEduMSTRGiftedClsCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvEduMSTRGiftedClsCase_Resource_RelENT.id_SkillType = objvEduMSTRGiftedClsCase_Resource_RelENS.id_SkillType; //技能类型流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.SkillTypeID = objvEduMSTRGiftedClsCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvEduMSTRGiftedClsCase_Resource_RelENT.CaseLevelId = objvEduMSTRGiftedClsCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_Resource_RelENT.OwnerId = objvEduMSTRGiftedClsCase_Resource_RelENS.OwnerId; //拥有者Id
objvEduMSTRGiftedClsCase_Resource_RelENT.StuName = objvEduMSTRGiftedClsCase_Resource_RelENS.StuName; //姓名
objvEduMSTRGiftedClsCase_Resource_RelENT.StuID = objvEduMSTRGiftedClsCase_Resource_RelENS.StuID; //学号
objvEduMSTRGiftedClsCase_Resource_RelENT.SexDesc = objvEduMSTRGiftedClsCase_Resource_RelENS.SexDesc; //性别名称
objvEduMSTRGiftedClsCase_Resource_RelENT.StuTypeID = objvEduMSTRGiftedClsCase_Resource_RelENS.StuTypeID; //学生类别ID
objvEduMSTRGiftedClsCase_Resource_RelENT.StuTypeDesc = objvEduMSTRGiftedClsCase_Resource_RelENS.StuTypeDesc; //学生类别名称
objvEduMSTRGiftedClsCase_Resource_RelENT.id_XzCollege = objvEduMSTRGiftedClsCase_Resource_RelENS.id_XzCollege; //学院流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.CollegeName = objvEduMSTRGiftedClsCase_Resource_RelENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCase_Resource_RelENT.CollegeNameA = objvEduMSTRGiftedClsCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCase_Resource_RelENT.id_XzMajor = objvEduMSTRGiftedClsCase_Resource_RelENS.id_XzMajor; //专业流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.MajorName = objvEduMSTRGiftedClsCase_Resource_RelENS.MajorName; //专业名称
objvEduMSTRGiftedClsCase_Resource_RelENT.id_GradeBase = objvEduMSTRGiftedClsCase_Resource_RelENS.id_GradeBase; //年级流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.GradeBaseName = objvEduMSTRGiftedClsCase_Resource_RelENS.GradeBaseName; //年级名称
objvEduMSTRGiftedClsCase_Resource_RelENT.StuCardNo = objvEduMSTRGiftedClsCase_Resource_RelENS.StuCardNo; //学生证号
objvEduMSTRGiftedClsCase_Resource_RelENT.EnrollmentDate = objvEduMSTRGiftedClsCase_Resource_RelENS.EnrollmentDate; //入校日期
objvEduMSTRGiftedClsCase_Resource_RelENT.IsDualVideo = objvEduMSTRGiftedClsCase_Resource_RelENS.IsDualVideo; //是否双视频
objvEduMSTRGiftedClsCase_Resource_RelENT.UserTypeId = objvEduMSTRGiftedClsCase_Resource_RelENS.UserTypeId; //用户类型Id
objvEduMSTRGiftedClsCase_Resource_RelENT.RecommendedDegreeId = objvEduMSTRGiftedClsCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvEduMSTRGiftedClsCase_Resource_RelENT.RecommendedDegreeName = objvEduMSTRGiftedClsCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvEduMSTRGiftedClsCase_Resource_RelENT.OwnerName = objvEduMSTRGiftedClsCase_Resource_RelENS.OwnerName; //拥有者姓名
objvEduMSTRGiftedClsCase_Resource_RelENT.OwnerNameWithId = objvEduMSTRGiftedClsCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvEduMSTRGiftedClsCase_Resource_RelENT.BrowseCount4Case = objvEduMSTRGiftedClsCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvEduMSTRGiftedClsCase_Resource_RelENT.id_Resource = objvEduMSTRGiftedClsCase_Resource_RelENS.id_Resource; //资源流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.ResourceID = objvEduMSTRGiftedClsCase_Resource_RelENS.ResourceID; //资源ID
objvEduMSTRGiftedClsCase_Resource_RelENT.ResourceName = objvEduMSTRGiftedClsCase_Resource_RelENS.ResourceName; //资源名称
objvEduMSTRGiftedClsCase_Resource_RelENT.id_FtpResource = objvEduMSTRGiftedClsCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.id_File = objvEduMSTRGiftedClsCase_Resource_RelENS.id_File; //文件流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.FileName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileName; //文件名称
objvEduMSTRGiftedClsCase_Resource_RelENT.FileType = objvEduMSTRGiftedClsCase_Resource_RelENS.FileType; //文件类型
objvEduMSTRGiftedClsCase_Resource_RelENT.SaveDate = objvEduMSTRGiftedClsCase_Resource_RelENS.SaveDate; //创建日期
objvEduMSTRGiftedClsCase_Resource_RelENT.FileSize = objvEduMSTRGiftedClsCase_Resource_RelENS.FileSize; //文件大小
objvEduMSTRGiftedClsCase_Resource_RelENT.SaveTime = objvEduMSTRGiftedClsCase_Resource_RelENS.SaveTime; //创建时间
objvEduMSTRGiftedClsCase_Resource_RelENT.FtpResourceID = objvEduMSTRGiftedClsCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvEduMSTRGiftedClsCase_Resource_RelENT.FileOriginalName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileOriginalName; //文件原名
objvEduMSTRGiftedClsCase_Resource_RelENT.FileDirName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileDirName; //文件目录名
objvEduMSTRGiftedClsCase_Resource_RelENT.FileRename = objvEduMSTRGiftedClsCase_Resource_RelENS.FileRename; //文件新名
objvEduMSTRGiftedClsCase_Resource_RelENT.FileUpDate = objvEduMSTRGiftedClsCase_Resource_RelENS.FileUpDate; //创建日期
objvEduMSTRGiftedClsCase_Resource_RelENT.FileUpTime = objvEduMSTRGiftedClsCase_Resource_RelENS.FileUpTime; //创建时间
objvEduMSTRGiftedClsCase_Resource_RelENT.SaveMode = objvEduMSTRGiftedClsCase_Resource_RelENS.SaveMode; //文件存放方式
objvEduMSTRGiftedClsCase_Resource_RelENT.id_ResourceType = objvEduMSTRGiftedClsCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.ResourceTypeID = objvEduMSTRGiftedClsCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvEduMSTRGiftedClsCase_Resource_RelENT.ResourceTypeName = objvEduMSTRGiftedClsCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvEduMSTRGiftedClsCase_Resource_RelENT.ResourceOwner = objvEduMSTRGiftedClsCase_Resource_RelENS.ResourceOwner; //上传者
objvEduMSTRGiftedClsCase_Resource_RelENT.ftpFileType = objvEduMSTRGiftedClsCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvEduMSTRGiftedClsCase_Resource_RelENT.ftpFileSize = objvEduMSTRGiftedClsCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvEduMSTRGiftedClsCase_Resource_RelENT.ftpResourceOwner = objvEduMSTRGiftedClsCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvEduMSTRGiftedClsCase_Resource_RelENT.FileOriginName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileOriginName; //原文件名
objvEduMSTRGiftedClsCase_Resource_RelENT.IsExistFile = objvEduMSTRGiftedClsCase_Resource_RelENS.IsExistFile; //是否存在文件
objvEduMSTRGiftedClsCase_Resource_RelENT.FileNewName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileNewName; //新文件名
objvEduMSTRGiftedClsCase_Resource_RelENT.FileOldName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileOldName; //旧文件名
objvEduMSTRGiftedClsCase_Resource_RelENT.IsMain = objvEduMSTRGiftedClsCase_Resource_RelENS.IsMain; //是否主资源
objvEduMSTRGiftedClsCase_Resource_RelENT.id_UsingMode = objvEduMSTRGiftedClsCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.IsVisible = objvEduMSTRGiftedClsCase_Resource_RelENS.IsVisible; //是否显示
objvEduMSTRGiftedClsCase_Resource_RelENT.IndexNO = objvEduMSTRGiftedClsCase_Resource_RelENS.IndexNO; //序号
objvEduMSTRGiftedClsCase_Resource_RelENT.BrowseCount = objvEduMSTRGiftedClsCase_Resource_RelENS.BrowseCount; //浏览次数
objvEduMSTRGiftedClsCase_Resource_RelENT.UpdDate = objvEduMSTRGiftedClsCase_Resource_RelENS.UpdDate; //修改日期
objvEduMSTRGiftedClsCase_Resource_RelENT.UpdUser = objvEduMSTRGiftedClsCase_Resource_RelENS.UpdUser; //修改人
objvEduMSTRGiftedClsCase_Resource_RelENT.Memo = objvEduMSTRGiftedClsCase_Resource_RelENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvEduMSTRGiftedClsCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvEduMSTRGiftedClsCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvEduMSTRGiftedClsCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvEduMSTRGiftedClsCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvEduMSTRGiftedClsCase_Resource_RelEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Cache == null)
//{
//arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Cache = await clsvEduMSTRGiftedClsCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCase_Resource_RelEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvEduMSTRGiftedClsCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCase_Resource_Rel.Memo, Type.GetType("System.String"));
foreach (clsvEduMSTRGiftedClsCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_MicroteachCase];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCase];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_StudyLevel];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_TeachingPlan];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_EduMSTRGiftedClsCaseType];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.Id_CaseType];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_Discipline];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_TeachSkill];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_SkillType];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.StuName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.StuName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.StuID] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.StuID];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_XzCollege];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_XzMajor];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.MajorName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.MajorName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_GradeBase];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_Resource] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_Resource];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_FtpResource];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_File] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_File];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileType] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileType];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileSize] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileSize];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileRename] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileRename];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.SaveMode] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.SaveMode];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_ResourceType];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.IsMain] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.IsMain];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.id_UsingMode];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.IsVisible] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.IsVisible];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser];
objDR[convEduMSTRGiftedClsCase_Resource_Rel.Memo] = objInFor[convEduMSTRGiftedClsCase_Resource_Rel.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}