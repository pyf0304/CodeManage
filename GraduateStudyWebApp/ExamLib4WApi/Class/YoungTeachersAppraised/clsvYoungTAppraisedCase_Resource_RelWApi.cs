
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCase_Resource_RelWApi
 表名:vYoungTAppraisedCase_Resource_Rel(01120422)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:49
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优
 模块英文名:YoungTeachersAppraised
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
public static class clsvYoungTAppraisedCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvYoungTAppraisedCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFuncModuleId(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convYoungTAppraisedCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convYoungTAppraisedCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convYoungTAppraisedCase_Resource_Rel.FuncModuleId);
objvYoungTAppraisedCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FuncModuleId) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFuncModuleName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convYoungTAppraisedCase_Resource_Rel.FuncModuleName);
objvYoungTAppraisedCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FuncModuleName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_MicroteachCase(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase);
objvYoungTAppraisedCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_YoungTAppraisedCase(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_YoungTAppraisedCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_YoungTAppraisedCase, convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase);
clsCheckSql.CheckFieldLen(strid_YoungTAppraisedCase, 8, convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase);
clsCheckSql.CheckFieldForeignKey(strid_YoungTAppraisedCase, 8, convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase);
objvYoungTAppraisedCase_Resource_RelEN.id_YoungTAppraisedCase = strid_YoungTAppraisedCase; //青教评优案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetYoungTAppraisedCaseID(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strYoungTAppraisedCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseID, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseID, 8, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseID, 8, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID);
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseID = strYoungTAppraisedCaseID; //青教评优案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetYoungTAppraisedCaseName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strYoungTAppraisedCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseName, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseName, 100, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName);
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseName = strYoungTAppraisedCaseName; //青教评优案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetYoungTAppraisedCaseText(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strYoungTAppraisedCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseText, 8000, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText);
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseText = strYoungTAppraisedCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetYoungTAppraisedCaseDate(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strYoungTAppraisedCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseDate, 8, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseDate, 8, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate);
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDate = strYoungTAppraisedCaseDate; //青教评优教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetYoungTAppraisedCaseTime(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strYoungTAppraisedCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTime, 6, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseTime, 6, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime);
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTime = strYoungTAppraisedCaseTime; //青教评优教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetYoungTAppraisedCaseTheme(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strYoungTAppraisedCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTheme, 200, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme);
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTheme = strYoungTAppraisedCaseTheme; //青教评优案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetYoungTAppraisedCaseDateIn(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strYoungTAppraisedCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseDateIn, 8, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseDateIn, 8, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn);
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDateIn = strYoungTAppraisedCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetYoungTAppraisedCaseTimeIn(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strYoungTAppraisedCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTimeIn, 6, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseTimeIn, 6, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn);
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTimeIn = strYoungTAppraisedCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_StudyLevel(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convYoungTAppraisedCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convYoungTAppraisedCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convYoungTAppraisedCase_Resource_Rel.id_StudyLevel);
objvYoungTAppraisedCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_StudyLevel) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetStudyLevelName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convYoungTAppraisedCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convYoungTAppraisedCase_Resource_Rel.StudyLevelName);
objvYoungTAppraisedCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.StudyLevelName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_TeachingPlan(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan);
objvYoungTAppraisedCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_Discipline(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convYoungTAppraisedCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convYoungTAppraisedCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convYoungTAppraisedCase_Resource_Rel.id_Discipline);
objvYoungTAppraisedCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_Discipline) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetDisciplineID(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convYoungTAppraisedCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convYoungTAppraisedCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convYoungTAppraisedCase_Resource_Rel.DisciplineID);
objvYoungTAppraisedCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.DisciplineID) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetDisciplineName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convYoungTAppraisedCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convYoungTAppraisedCase_Resource_Rel.DisciplineName);
objvYoungTAppraisedCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.DisciplineName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetsenateGaugeVersionID(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID);
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetsenateGaugeVersionName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName);
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore);
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetVersionNo(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvYoungTAppraisedCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.VersionNo) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_TeachSkill(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convYoungTAppraisedCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convYoungTAppraisedCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convYoungTAppraisedCase_Resource_Rel.id_TeachSkill);
objvYoungTAppraisedCase_Resource_RelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_TeachSkill) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_TeachSkill, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_TeachSkill] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetTeachSkillID(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillID, convYoungTAppraisedCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convYoungTAppraisedCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convYoungTAppraisedCase_Resource_Rel.TeachSkillID);
objvYoungTAppraisedCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.TeachSkillID) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetSkillTypeName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeName, convYoungTAppraisedCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convYoungTAppraisedCase_Resource_Rel.SkillTypeName);
objvYoungTAppraisedCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.SkillTypeName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetTeachSkillName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillName, convYoungTAppraisedCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convYoungTAppraisedCase_Resource_Rel.TeachSkillName);
objvYoungTAppraisedCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.TeachSkillName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_SkillType(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SkillType, convYoungTAppraisedCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convYoungTAppraisedCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convYoungTAppraisedCase_Resource_Rel.id_SkillType);
objvYoungTAppraisedCase_Resource_RelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_SkillType) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_SkillType, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_SkillType] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetCaseLevelId(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convYoungTAppraisedCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convYoungTAppraisedCase_Resource_Rel.CaseLevelId);
objvYoungTAppraisedCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.CaseLevelId) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetOwnerId(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convYoungTAppraisedCase_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convYoungTAppraisedCase_Resource_Rel.OwnerId);
objvYoungTAppraisedCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.OwnerId) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetTeacherID(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convYoungTAppraisedCase_Resource_Rel.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convYoungTAppraisedCase_Resource_Rel.TeacherID);
objvYoungTAppraisedCase_Resource_RelEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.TeacherID) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.TeacherID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.TeacherID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetTeacherName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, convYoungTAppraisedCase_Resource_Rel.TeacherName);
clsCheckSql.CheckFieldLen(strTeacherName, 50, convYoungTAppraisedCase_Resource_Rel.TeacherName);
objvYoungTAppraisedCase_Resource_RelEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.TeacherName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.TeacherName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.TeacherName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetCollegeID(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeID, convYoungTAppraisedCase_Resource_Rel.CollegeID);
clsCheckSql.CheckFieldLen(strCollegeID, 4, convYoungTAppraisedCase_Resource_Rel.CollegeID);
objvYoungTAppraisedCase_Resource_RelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.CollegeID) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.CollegeID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.CollegeID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetCollegeName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convYoungTAppraisedCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convYoungTAppraisedCase_Resource_Rel.CollegeName);
objvYoungTAppraisedCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.CollegeName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_XzCollege(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convYoungTAppraisedCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convYoungTAppraisedCase_Resource_Rel.id_XzCollege);
objvYoungTAppraisedCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_XzCollege) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetEntryDate(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strEntryDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryDate, 8, convYoungTAppraisedCase_Resource_Rel.EntryDate);
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, convYoungTAppraisedCase_Resource_Rel.EntryDate);
objvYoungTAppraisedCase_Resource_RelEN.EntryDate = strEntryDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.EntryDate) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.EntryDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.EntryDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetIsDualVideo(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convYoungTAppraisedCase_Resource_Rel.IsDualVideo);
objvYoungTAppraisedCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.IsDualVideo) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetUserTypeId(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convYoungTAppraisedCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convYoungTAppraisedCase_Resource_Rel.UserTypeId);
objvYoungTAppraisedCase_Resource_RelEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.UserTypeId) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.UserTypeId, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.UserTypeId] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetUserTypeName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convYoungTAppraisedCase_Resource_Rel.UserTypeName);
objvYoungTAppraisedCase_Resource_RelEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.UserTypeName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.UserTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.UserTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetRecommendedDegreeId(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId);
objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetRecommendedDegreeName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName);
objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetBrowseCount4Case(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvYoungTAppraisedCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetEntryYear(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strEntryYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryYear, 8, convYoungTAppraisedCase_Resource_Rel.EntryYear);
objvYoungTAppraisedCase_Resource_RelEN.EntryYear = strEntryYear; //EntryYear
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.EntryYear) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.EntryYear, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.EntryYear] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_Resource(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convYoungTAppraisedCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convYoungTAppraisedCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convYoungTAppraisedCase_Resource_Rel.id_Resource);
objvYoungTAppraisedCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_Resource) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetResourceID(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convYoungTAppraisedCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convYoungTAppraisedCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convYoungTAppraisedCase_Resource_Rel.ResourceID);
objvYoungTAppraisedCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.ResourceID) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_FtpResource(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convYoungTAppraisedCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convYoungTAppraisedCase_Resource_Rel.id_FtpResource);
objvYoungTAppraisedCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_FtpResource) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_File(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convYoungTAppraisedCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convYoungTAppraisedCase_Resource_Rel.id_File);
objvYoungTAppraisedCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_File) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convYoungTAppraisedCase_Resource_Rel.FileName);
objvYoungTAppraisedCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileType(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convYoungTAppraisedCase_Resource_Rel.FileType);
objvYoungTAppraisedCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileType) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetSaveDate(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convYoungTAppraisedCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convYoungTAppraisedCase_Resource_Rel.SaveDate);
objvYoungTAppraisedCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.SaveDate) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileSize(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convYoungTAppraisedCase_Resource_Rel.FileSize);
objvYoungTAppraisedCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileSize) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetSaveTime(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convYoungTAppraisedCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convYoungTAppraisedCase_Resource_Rel.SaveTime);
objvYoungTAppraisedCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.SaveTime) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFtpResourceID(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convYoungTAppraisedCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convYoungTAppraisedCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convYoungTAppraisedCase_Resource_Rel.FtpResourceID);
objvYoungTAppraisedCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FtpResourceID) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileOriginalName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convYoungTAppraisedCase_Resource_Rel.FileOriginalName);
objvYoungTAppraisedCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileOriginalName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileDirName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convYoungTAppraisedCase_Resource_Rel.FileDirName);
objvYoungTAppraisedCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileDirName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileRename(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convYoungTAppraisedCase_Resource_Rel.FileRename);
objvYoungTAppraisedCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileRename) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileUpDate(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convYoungTAppraisedCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convYoungTAppraisedCase_Resource_Rel.FileUpDate);
objvYoungTAppraisedCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileUpDate) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileUpTime(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convYoungTAppraisedCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convYoungTAppraisedCase_Resource_Rel.FileUpTime);
objvYoungTAppraisedCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileUpTime) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetSaveMode(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvYoungTAppraisedCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.SaveMode) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_ResourceType(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convYoungTAppraisedCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convYoungTAppraisedCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convYoungTAppraisedCase_Resource_Rel.id_ResourceType);
objvYoungTAppraisedCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_ResourceType) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetResourceTypeID(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convYoungTAppraisedCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convYoungTAppraisedCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convYoungTAppraisedCase_Resource_Rel.ResourceTypeID);
objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.ResourceTypeID) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetResourceTypeName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convYoungTAppraisedCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convYoungTAppraisedCase_Resource_Rel.ResourceTypeName);
objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.ResourceTypeName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetResourceOwner(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convYoungTAppraisedCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convYoungTAppraisedCase_Resource_Rel.ResourceOwner);
objvYoungTAppraisedCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.ResourceOwner) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetftpFileType(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convYoungTAppraisedCase_Resource_Rel.ftpFileType);
objvYoungTAppraisedCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.ftpFileType) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetftpFileSize(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convYoungTAppraisedCase_Resource_Rel.ftpFileSize);
objvYoungTAppraisedCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.ftpFileSize) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetftpResourceOwner(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner);
objvYoungTAppraisedCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileOriginName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convYoungTAppraisedCase_Resource_Rel.FileOriginName);
objvYoungTAppraisedCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileOriginName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetIsExistFile(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvYoungTAppraisedCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.IsExistFile) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileNewName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convYoungTAppraisedCase_Resource_Rel.FileNewName);
objvYoungTAppraisedCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileNewName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetFileOldName(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convYoungTAppraisedCase_Resource_Rel.FileOldName);
objvYoungTAppraisedCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.FileOldName) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetIsMain(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvYoungTAppraisedCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.IsMain) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN Setid_UsingMode(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_UsingMode, convYoungTAppraisedCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convYoungTAppraisedCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convYoungTAppraisedCase_Resource_Rel.id_UsingMode);
objvYoungTAppraisedCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.id_UsingMode) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetIsVisible(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvYoungTAppraisedCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.IsVisible) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetIndexNO(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvYoungTAppraisedCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.IndexNO) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetBrowseCount(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvYoungTAppraisedCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.BrowseCount) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetUpdDate(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convYoungTAppraisedCase_Resource_Rel.UpdDate);
objvYoungTAppraisedCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.UpdDate) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetUpdUser(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convYoungTAppraisedCase_Resource_Rel.UpdUser);
objvYoungTAppraisedCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.UpdUser) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN SetMemo(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convYoungTAppraisedCase_Resource_Rel.Memo);
objvYoungTAppraisedCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase_Resource_Rel.Memo) == false)
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp.Add(convYoungTAppraisedCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvYoungTAppraisedCase_Resource_RelEN.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvYoungTAppraisedCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvYoungTAppraisedCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FuncModuleId, objvYoungTAppraisedCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FuncModuleName, objvYoungTAppraisedCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase, objvYoungTAppraisedCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase) == true)
{
string strComparisonOp_id_YoungTAppraisedCase = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase, objvYoungTAppraisedCase_Resource_Rel_Cond.id_YoungTAppraisedCase, strComparisonOp_id_YoungTAppraisedCase);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID) == true)
{
string strComparisonOp_YoungTAppraisedCaseID = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID, objvYoungTAppraisedCase_Resource_Rel_Cond.YoungTAppraisedCaseID, strComparisonOp_YoungTAppraisedCaseID);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName) == true)
{
string strComparisonOp_YoungTAppraisedCaseName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName, objvYoungTAppraisedCase_Resource_Rel_Cond.YoungTAppraisedCaseName, strComparisonOp_YoungTAppraisedCaseName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText) == true)
{
string strComparisonOp_YoungTAppraisedCaseText = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText, objvYoungTAppraisedCase_Resource_Rel_Cond.YoungTAppraisedCaseText, strComparisonOp_YoungTAppraisedCaseText);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate) == true)
{
string strComparisonOp_YoungTAppraisedCaseDate = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate, objvYoungTAppraisedCase_Resource_Rel_Cond.YoungTAppraisedCaseDate, strComparisonOp_YoungTAppraisedCaseDate);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime) == true)
{
string strComparisonOp_YoungTAppraisedCaseTime = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime, objvYoungTAppraisedCase_Resource_Rel_Cond.YoungTAppraisedCaseTime, strComparisonOp_YoungTAppraisedCaseTime);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme) == true)
{
string strComparisonOp_YoungTAppraisedCaseTheme = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme, objvYoungTAppraisedCase_Resource_Rel_Cond.YoungTAppraisedCaseTheme, strComparisonOp_YoungTAppraisedCaseTheme);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn) == true)
{
string strComparisonOp_YoungTAppraisedCaseDateIn = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn, objvYoungTAppraisedCase_Resource_Rel_Cond.YoungTAppraisedCaseDateIn, strComparisonOp_YoungTAppraisedCaseDateIn);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn) == true)
{
string strComparisonOp_YoungTAppraisedCaseTimeIn = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn, objvYoungTAppraisedCase_Resource_Rel_Cond.YoungTAppraisedCaseTimeIn, strComparisonOp_YoungTAppraisedCaseTimeIn);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_StudyLevel, objvYoungTAppraisedCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.StudyLevelName, objvYoungTAppraisedCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan, objvYoungTAppraisedCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_Discipline, objvYoungTAppraisedCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.DisciplineID, objvYoungTAppraisedCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.DisciplineName, objvYoungTAppraisedCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID, objvYoungTAppraisedCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName, objvYoungTAppraisedCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore, objvYoungTAppraisedCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase_Resource_Rel.VersionNo, objvYoungTAppraisedCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_TeachSkill, objvYoungTAppraisedCase_Resource_Rel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.TeachSkillID, objvYoungTAppraisedCase_Resource_Rel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.SkillTypeName, objvYoungTAppraisedCase_Resource_Rel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.TeachSkillName, objvYoungTAppraisedCase_Resource_Rel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_SkillType, objvYoungTAppraisedCase_Resource_Rel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.CaseLevelId, objvYoungTAppraisedCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.OwnerId, objvYoungTAppraisedCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.TeacherID, objvYoungTAppraisedCase_Resource_Rel_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.TeacherName, objvYoungTAppraisedCase_Resource_Rel_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.CollegeID, objvYoungTAppraisedCase_Resource_Rel_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.CollegeName, objvYoungTAppraisedCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_XzCollege, objvYoungTAppraisedCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.EntryDate) == true)
{
string strComparisonOp_EntryDate = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.EntryDate, objvYoungTAppraisedCase_Resource_Rel_Cond.EntryDate, strComparisonOp_EntryDate);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.IsDualVideo) == true)
{
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase_Resource_Rel.IsDualVideo);
}
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.UserTypeId, objvYoungTAppraisedCase_Resource_Rel_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.UserTypeName, objvYoungTAppraisedCase_Resource_Rel_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId, objvYoungTAppraisedCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName, objvYoungTAppraisedCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case, objvYoungTAppraisedCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.EntryYear) == true)
{
string strComparisonOp_EntryYear = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.EntryYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.EntryYear, objvYoungTAppraisedCase_Resource_Rel_Cond.EntryYear, strComparisonOp_EntryYear);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_Resource, objvYoungTAppraisedCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.ResourceID, objvYoungTAppraisedCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_FtpResource, objvYoungTAppraisedCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_File, objvYoungTAppraisedCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileName, objvYoungTAppraisedCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileType, objvYoungTAppraisedCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.SaveDate, objvYoungTAppraisedCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileSize, objvYoungTAppraisedCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.SaveTime, objvYoungTAppraisedCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FtpResourceID, objvYoungTAppraisedCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileOriginalName, objvYoungTAppraisedCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileDirName, objvYoungTAppraisedCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileRename, objvYoungTAppraisedCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileUpDate, objvYoungTAppraisedCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileUpTime, objvYoungTAppraisedCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.SaveMode) == true)
{
if (objvYoungTAppraisedCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase_Resource_Rel.SaveMode);
}
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_ResourceType, objvYoungTAppraisedCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.ResourceTypeID, objvYoungTAppraisedCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.ResourceTypeName, objvYoungTAppraisedCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.ResourceOwner, objvYoungTAppraisedCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.ftpFileType, objvYoungTAppraisedCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.ftpFileSize, objvYoungTAppraisedCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner, objvYoungTAppraisedCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileOriginName, objvYoungTAppraisedCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.IsExistFile) == true)
{
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase_Resource_Rel.IsExistFile);
}
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileNewName, objvYoungTAppraisedCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.FileOldName, objvYoungTAppraisedCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.IsMain) == true)
{
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase_Resource_Rel.IsMain);
}
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.id_UsingMode, objvYoungTAppraisedCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.IsVisible) == true)
{
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase_Resource_Rel.IsVisible);
}
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase_Resource_Rel.IndexNO, objvYoungTAppraisedCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase_Resource_Rel.BrowseCount, objvYoungTAppraisedCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.UpdDate, objvYoungTAppraisedCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.UpdUser, objvYoungTAppraisedCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvYoungTAppraisedCase_Resource_Rel_Cond.IsUpdated(convYoungTAppraisedCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvYoungTAppraisedCase_Resource_Rel_Cond.dicFldComparisonOp[convYoungTAppraisedCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase_Resource_Rel.Memo, objvYoungTAppraisedCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vYoungTAppraisedCase_Resource_Rel(vYoungTAppraisedCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvYoungTAppraisedCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vYoungTAppraisedCase_Resource_RelApi";

 public clsvYoungTAppraisedCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvYoungTAppraisedCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN = null;
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
objvYoungTAppraisedCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCase_Resource_RelEN;
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
public static clsvYoungTAppraisedCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN = null;
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
objvYoungTAppraisedCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCase_Resource_RelEN;
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
public static clsvYoungTAppraisedCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN = null;
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
objvYoungTAppraisedCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCase_Resource_RelEN;
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
public static clsvYoungTAppraisedCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvYoungTAppraisedCase_Resource_RelEN._CurrTabName_S);
List<clsvYoungTAppraisedCase_Resource_RelEN> arrvYoungTAppraisedCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvYoungTAppraisedCase_Resource_RelEN> arrvYoungTAppraisedCase_Resource_RelObjLst_Sel =
from objvYoungTAppraisedCase_Resource_RelEN in arrvYoungTAppraisedCase_Resource_RelObjLst_Cache
where objvYoungTAppraisedCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvYoungTAppraisedCase_Resource_RelEN;
if (arrvYoungTAppraisedCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvYoungTAppraisedCase_Resource_RelEN obj = clsvYoungTAppraisedCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvYoungTAppraisedCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvYoungTAppraisedCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvYoungTAppraisedCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvYoungTAppraisedCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvYoungTAppraisedCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvYoungTAppraisedCase_Resource_RelEN._CurrTabName_S);
List<clsvYoungTAppraisedCase_Resource_RelEN> arrvYoungTAppraisedCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvYoungTAppraisedCase_Resource_RelEN> arrvYoungTAppraisedCase_Resource_RelObjLst_Sel =
from objvYoungTAppraisedCase_Resource_RelEN in arrvYoungTAppraisedCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvYoungTAppraisedCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvYoungTAppraisedCase_Resource_RelEN;
return arrvYoungTAppraisedCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvYoungTAppraisedCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvYoungTAppraisedCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvYoungTAppraisedCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvYoungTAppraisedCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvYoungTAppraisedCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvYoungTAppraisedCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvYoungTAppraisedCase_Resource_RelENS">源对象</param>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelENS, clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelENT)
{
try
{
objvYoungTAppraisedCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvYoungTAppraisedCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvYoungTAppraisedCase_Resource_RelENT.FuncModuleId = objvYoungTAppraisedCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvYoungTAppraisedCase_Resource_RelENT.FuncModuleName = objvYoungTAppraisedCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvYoungTAppraisedCase_Resource_RelENT.id_MicroteachCase = objvYoungTAppraisedCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvYoungTAppraisedCase_Resource_RelENT.id_YoungTAppraisedCase = objvYoungTAppraisedCase_Resource_RelENS.id_YoungTAppraisedCase; //青教评优案例流水号
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseID = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseID; //青教评优案例ID
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseName = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseName; //青教评优案例名称
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseText = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseText; //案例文本内容
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseDate = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseDate; //青教评优教学日期
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseTime = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseTime; //青教评优教学时间
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseTheme = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseTheme; //青教评优案例主题词
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseDateIn = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseDateIn; //案例入库日期
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseTimeIn = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseTimeIn; //案例入库时间
objvYoungTAppraisedCase_Resource_RelENT.id_StudyLevel = objvYoungTAppraisedCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvYoungTAppraisedCase_Resource_RelENT.StudyLevelName = objvYoungTAppraisedCase_Resource_RelENS.StudyLevelName; //学段名称
objvYoungTAppraisedCase_Resource_RelENT.id_TeachingPlan = objvYoungTAppraisedCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvYoungTAppraisedCase_Resource_RelENT.id_Discipline = objvYoungTAppraisedCase_Resource_RelENS.id_Discipline; //学科流水号
objvYoungTAppraisedCase_Resource_RelENT.DisciplineID = objvYoungTAppraisedCase_Resource_RelENS.DisciplineID; //学科ID
objvYoungTAppraisedCase_Resource_RelENT.DisciplineName = objvYoungTAppraisedCase_Resource_RelENS.DisciplineName; //学科名称
objvYoungTAppraisedCase_Resource_RelENT.senateGaugeVersionID = objvYoungTAppraisedCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvYoungTAppraisedCase_Resource_RelENT.senateGaugeVersionName = objvYoungTAppraisedCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvYoungTAppraisedCase_Resource_RelENT.senateGaugeVersionTtlScore = objvYoungTAppraisedCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvYoungTAppraisedCase_Resource_RelENT.VersionNo = objvYoungTAppraisedCase_Resource_RelENS.VersionNo; //版本号
objvYoungTAppraisedCase_Resource_RelENT.id_TeachSkill = objvYoungTAppraisedCase_Resource_RelENS.id_TeachSkill; //教学技能流水号
objvYoungTAppraisedCase_Resource_RelENT.TeachSkillID = objvYoungTAppraisedCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvYoungTAppraisedCase_Resource_RelENT.SkillTypeName = objvYoungTAppraisedCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvYoungTAppraisedCase_Resource_RelENT.TeachSkillName = objvYoungTAppraisedCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvYoungTAppraisedCase_Resource_RelENT.id_SkillType = objvYoungTAppraisedCase_Resource_RelENS.id_SkillType; //技能类型流水号
objvYoungTAppraisedCase_Resource_RelENT.CaseLevelId = objvYoungTAppraisedCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvYoungTAppraisedCase_Resource_RelENT.OwnerId = objvYoungTAppraisedCase_Resource_RelENS.OwnerId; //拥有者Id
objvYoungTAppraisedCase_Resource_RelENT.TeacherID = objvYoungTAppraisedCase_Resource_RelENS.TeacherID; //教师工号
objvYoungTAppraisedCase_Resource_RelENT.TeacherName = objvYoungTAppraisedCase_Resource_RelENS.TeacherName; //教师姓名
objvYoungTAppraisedCase_Resource_RelENT.CollegeID = objvYoungTAppraisedCase_Resource_RelENS.CollegeID; //学院ID
objvYoungTAppraisedCase_Resource_RelENT.CollegeName = objvYoungTAppraisedCase_Resource_RelENS.CollegeName; //学院名称
objvYoungTAppraisedCase_Resource_RelENT.id_XzCollege = objvYoungTAppraisedCase_Resource_RelENS.id_XzCollege; //学院流水号
objvYoungTAppraisedCase_Resource_RelENT.EntryDate = objvYoungTAppraisedCase_Resource_RelENS.EntryDate; //进校日期
objvYoungTAppraisedCase_Resource_RelENT.IsDualVideo = objvYoungTAppraisedCase_Resource_RelENS.IsDualVideo; //是否双视频
objvYoungTAppraisedCase_Resource_RelENT.UserTypeId = objvYoungTAppraisedCase_Resource_RelENS.UserTypeId; //用户类型Id
objvYoungTAppraisedCase_Resource_RelENT.UserTypeName = objvYoungTAppraisedCase_Resource_RelENS.UserTypeName; //用户类型名称
objvYoungTAppraisedCase_Resource_RelENT.RecommendedDegreeId = objvYoungTAppraisedCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvYoungTAppraisedCase_Resource_RelENT.RecommendedDegreeName = objvYoungTAppraisedCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvYoungTAppraisedCase_Resource_RelENT.BrowseCount4Case = objvYoungTAppraisedCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvYoungTAppraisedCase_Resource_RelENT.EntryYear = objvYoungTAppraisedCase_Resource_RelENS.EntryYear; //EntryYear
objvYoungTAppraisedCase_Resource_RelENT.id_Resource = objvYoungTAppraisedCase_Resource_RelENS.id_Resource; //资源流水号
objvYoungTAppraisedCase_Resource_RelENT.ResourceID = objvYoungTAppraisedCase_Resource_RelENS.ResourceID; //资源ID
objvYoungTAppraisedCase_Resource_RelENT.id_FtpResource = objvYoungTAppraisedCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvYoungTAppraisedCase_Resource_RelENT.id_File = objvYoungTAppraisedCase_Resource_RelENS.id_File; //文件流水号
objvYoungTAppraisedCase_Resource_RelENT.FileName = objvYoungTAppraisedCase_Resource_RelENS.FileName; //文件名称
objvYoungTAppraisedCase_Resource_RelENT.FileType = objvYoungTAppraisedCase_Resource_RelENS.FileType; //文件类型
objvYoungTAppraisedCase_Resource_RelENT.SaveDate = objvYoungTAppraisedCase_Resource_RelENS.SaveDate; //创建日期
objvYoungTAppraisedCase_Resource_RelENT.FileSize = objvYoungTAppraisedCase_Resource_RelENS.FileSize; //文件大小
objvYoungTAppraisedCase_Resource_RelENT.SaveTime = objvYoungTAppraisedCase_Resource_RelENS.SaveTime; //创建时间
objvYoungTAppraisedCase_Resource_RelENT.FtpResourceID = objvYoungTAppraisedCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvYoungTAppraisedCase_Resource_RelENT.FileOriginalName = objvYoungTAppraisedCase_Resource_RelENS.FileOriginalName; //文件原名
objvYoungTAppraisedCase_Resource_RelENT.FileDirName = objvYoungTAppraisedCase_Resource_RelENS.FileDirName; //文件目录名
objvYoungTAppraisedCase_Resource_RelENT.FileRename = objvYoungTAppraisedCase_Resource_RelENS.FileRename; //文件新名
objvYoungTAppraisedCase_Resource_RelENT.FileUpDate = objvYoungTAppraisedCase_Resource_RelENS.FileUpDate; //创建日期
objvYoungTAppraisedCase_Resource_RelENT.FileUpTime = objvYoungTAppraisedCase_Resource_RelENS.FileUpTime; //创建时间
objvYoungTAppraisedCase_Resource_RelENT.SaveMode = objvYoungTAppraisedCase_Resource_RelENS.SaveMode; //文件存放方式
objvYoungTAppraisedCase_Resource_RelENT.id_ResourceType = objvYoungTAppraisedCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvYoungTAppraisedCase_Resource_RelENT.ResourceTypeID = objvYoungTAppraisedCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvYoungTAppraisedCase_Resource_RelENT.ResourceTypeName = objvYoungTAppraisedCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvYoungTAppraisedCase_Resource_RelENT.ResourceOwner = objvYoungTAppraisedCase_Resource_RelENS.ResourceOwner; //上传者
objvYoungTAppraisedCase_Resource_RelENT.ftpFileType = objvYoungTAppraisedCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvYoungTAppraisedCase_Resource_RelENT.ftpFileSize = objvYoungTAppraisedCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvYoungTAppraisedCase_Resource_RelENT.ftpResourceOwner = objvYoungTAppraisedCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvYoungTAppraisedCase_Resource_RelENT.FileOriginName = objvYoungTAppraisedCase_Resource_RelENS.FileOriginName; //原文件名
objvYoungTAppraisedCase_Resource_RelENT.IsExistFile = objvYoungTAppraisedCase_Resource_RelENS.IsExistFile; //是否存在文件
objvYoungTAppraisedCase_Resource_RelENT.FileNewName = objvYoungTAppraisedCase_Resource_RelENS.FileNewName; //新文件名
objvYoungTAppraisedCase_Resource_RelENT.FileOldName = objvYoungTAppraisedCase_Resource_RelENS.FileOldName; //旧文件名
objvYoungTAppraisedCase_Resource_RelENT.IsMain = objvYoungTAppraisedCase_Resource_RelENS.IsMain; //是否主资源
objvYoungTAppraisedCase_Resource_RelENT.id_UsingMode = objvYoungTAppraisedCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvYoungTAppraisedCase_Resource_RelENT.IsVisible = objvYoungTAppraisedCase_Resource_RelENS.IsVisible; //是否显示
objvYoungTAppraisedCase_Resource_RelENT.IndexNO = objvYoungTAppraisedCase_Resource_RelENS.IndexNO; //序号
objvYoungTAppraisedCase_Resource_RelENT.BrowseCount = objvYoungTAppraisedCase_Resource_RelENS.BrowseCount; //浏览次数
objvYoungTAppraisedCase_Resource_RelENT.UpdDate = objvYoungTAppraisedCase_Resource_RelENS.UpdDate; //修改日期
objvYoungTAppraisedCase_Resource_RelENT.UpdUser = objvYoungTAppraisedCase_Resource_RelENS.UpdUser; //修改人
objvYoungTAppraisedCase_Resource_RelENT.Memo = objvYoungTAppraisedCase_Resource_RelENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvYoungTAppraisedCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvYoungTAppraisedCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvYoungTAppraisedCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvYoungTAppraisedCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvYoungTAppraisedCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvYoungTAppraisedCase_Resource_RelEN.AttributeName)
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
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsYoungTAppraisedCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsYoungTAppraisedCaseWApi没有刷新缓存机制(clsYoungTAppraisedCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsYoungTAppraisedCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsYoungTAppraisedCaseTypeWApi没有刷新缓存机制(clsYoungTAppraisedCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline4TeaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline4TeaWApi没有刷新缓存机制(clsDiscipline4TeaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseAddiSiteRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseAddiSiteRelaWApi没有刷新缓存机制(clsCaseAddiSiteRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDecompressionFileWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDecompressionFileWApi没有刷新缓存机制(clsDecompressionFileWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeWApi没有刷新缓存机制(clsRsStaffTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeWApi没有刷新缓存机制(clsRsProfGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeWApi没有刷新缓存机制(clsRsDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceWApi没有刷新缓存机制(clsRsProvinceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionWApi没有刷新缓存机制(clsRsReligionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifWApi没有刷新缓存机制(clsRsQualifWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeWApi没有刷新缓存机制(clsRsAdminGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvYoungTAppraisedCase_Resource_RelObjLst_Cache == null)
//{
//arrvYoungTAppraisedCase_Resource_RelObjLst_Cache = await clsvYoungTAppraisedCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvYoungTAppraisedCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvYoungTAppraisedCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvYoungTAppraisedCase_Resource_RelEN._CurrTabName_S);
List<clsvYoungTAppraisedCase_Resource_RelEN> arrvYoungTAppraisedCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvYoungTAppraisedCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvYoungTAppraisedCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.EntryDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.EntryYear, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase_Resource_Rel.Memo, Type.GetType("System.String"));
foreach (clsvYoungTAppraisedCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convYoungTAppraisedCase_Resource_Rel.FuncModuleId] = objInFor[convYoungTAppraisedCase_Resource_Rel.FuncModuleId];
objDR[convYoungTAppraisedCase_Resource_Rel.FuncModuleName] = objInFor[convYoungTAppraisedCase_Resource_Rel.FuncModuleName];
objDR[convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_MicroteachCase];
objDR[convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_YoungTAppraisedCase];
objDR[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID] = objInFor[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID];
objDR[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName] = objInFor[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName];
objDR[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText] = objInFor[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText];
objDR[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate] = objInFor[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate];
objDR[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime] = objInFor[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime];
objDR[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme] = objInFor[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme];
objDR[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn] = objInFor[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn];
objDR[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn] = objInFor[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn];
objDR[convYoungTAppraisedCase_Resource_Rel.id_StudyLevel] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_StudyLevel];
objDR[convYoungTAppraisedCase_Resource_Rel.StudyLevelName] = objInFor[convYoungTAppraisedCase_Resource_Rel.StudyLevelName];
objDR[convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_TeachingPlan];
objDR[convYoungTAppraisedCase_Resource_Rel.id_Discipline] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_Discipline];
objDR[convYoungTAppraisedCase_Resource_Rel.DisciplineID] = objInFor[convYoungTAppraisedCase_Resource_Rel.DisciplineID];
objDR[convYoungTAppraisedCase_Resource_Rel.DisciplineName] = objInFor[convYoungTAppraisedCase_Resource_Rel.DisciplineName];
objDR[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID] = objInFor[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID];
objDR[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName] = objInFor[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName];
objDR[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convYoungTAppraisedCase_Resource_Rel.VersionNo] = objInFor[convYoungTAppraisedCase_Resource_Rel.VersionNo];
objDR[convYoungTAppraisedCase_Resource_Rel.id_TeachSkill] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_TeachSkill];
objDR[convYoungTAppraisedCase_Resource_Rel.TeachSkillID] = objInFor[convYoungTAppraisedCase_Resource_Rel.TeachSkillID];
objDR[convYoungTAppraisedCase_Resource_Rel.SkillTypeName] = objInFor[convYoungTAppraisedCase_Resource_Rel.SkillTypeName];
objDR[convYoungTAppraisedCase_Resource_Rel.TeachSkillName] = objInFor[convYoungTAppraisedCase_Resource_Rel.TeachSkillName];
objDR[convYoungTAppraisedCase_Resource_Rel.id_SkillType] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_SkillType];
objDR[convYoungTAppraisedCase_Resource_Rel.CaseLevelId] = objInFor[convYoungTAppraisedCase_Resource_Rel.CaseLevelId];
objDR[convYoungTAppraisedCase_Resource_Rel.OwnerId] = objInFor[convYoungTAppraisedCase_Resource_Rel.OwnerId];
objDR[convYoungTAppraisedCase_Resource_Rel.TeacherID] = objInFor[convYoungTAppraisedCase_Resource_Rel.TeacherID];
objDR[convYoungTAppraisedCase_Resource_Rel.TeacherName] = objInFor[convYoungTAppraisedCase_Resource_Rel.TeacherName];
objDR[convYoungTAppraisedCase_Resource_Rel.CollegeID] = objInFor[convYoungTAppraisedCase_Resource_Rel.CollegeID];
objDR[convYoungTAppraisedCase_Resource_Rel.CollegeName] = objInFor[convYoungTAppraisedCase_Resource_Rel.CollegeName];
objDR[convYoungTAppraisedCase_Resource_Rel.id_XzCollege] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_XzCollege];
objDR[convYoungTAppraisedCase_Resource_Rel.EntryDate] = objInFor[convYoungTAppraisedCase_Resource_Rel.EntryDate];
objDR[convYoungTAppraisedCase_Resource_Rel.IsDualVideo] = objInFor[convYoungTAppraisedCase_Resource_Rel.IsDualVideo];
objDR[convYoungTAppraisedCase_Resource_Rel.UserTypeId] = objInFor[convYoungTAppraisedCase_Resource_Rel.UserTypeId];
objDR[convYoungTAppraisedCase_Resource_Rel.UserTypeName] = objInFor[convYoungTAppraisedCase_Resource_Rel.UserTypeName];
objDR[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId] = objInFor[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId];
objDR[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName] = objInFor[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName];
objDR[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case] = objInFor[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case];
objDR[convYoungTAppraisedCase_Resource_Rel.EntryYear] = objInFor[convYoungTAppraisedCase_Resource_Rel.EntryYear];
objDR[convYoungTAppraisedCase_Resource_Rel.id_Resource] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_Resource];
objDR[convYoungTAppraisedCase_Resource_Rel.ResourceID] = objInFor[convYoungTAppraisedCase_Resource_Rel.ResourceID];
objDR[convYoungTAppraisedCase_Resource_Rel.id_FtpResource] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_FtpResource];
objDR[convYoungTAppraisedCase_Resource_Rel.id_File] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_File];
objDR[convYoungTAppraisedCase_Resource_Rel.FileName] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileName];
objDR[convYoungTAppraisedCase_Resource_Rel.FileType] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileType];
objDR[convYoungTAppraisedCase_Resource_Rel.SaveDate] = objInFor[convYoungTAppraisedCase_Resource_Rel.SaveDate];
objDR[convYoungTAppraisedCase_Resource_Rel.FileSize] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileSize];
objDR[convYoungTAppraisedCase_Resource_Rel.SaveTime] = objInFor[convYoungTAppraisedCase_Resource_Rel.SaveTime];
objDR[convYoungTAppraisedCase_Resource_Rel.FtpResourceID] = objInFor[convYoungTAppraisedCase_Resource_Rel.FtpResourceID];
objDR[convYoungTAppraisedCase_Resource_Rel.FileOriginalName] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileOriginalName];
objDR[convYoungTAppraisedCase_Resource_Rel.FileDirName] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileDirName];
objDR[convYoungTAppraisedCase_Resource_Rel.FileRename] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileRename];
objDR[convYoungTAppraisedCase_Resource_Rel.FileUpDate] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileUpDate];
objDR[convYoungTAppraisedCase_Resource_Rel.FileUpTime] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileUpTime];
objDR[convYoungTAppraisedCase_Resource_Rel.SaveMode] = objInFor[convYoungTAppraisedCase_Resource_Rel.SaveMode];
objDR[convYoungTAppraisedCase_Resource_Rel.id_ResourceType] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_ResourceType];
objDR[convYoungTAppraisedCase_Resource_Rel.ResourceTypeID] = objInFor[convYoungTAppraisedCase_Resource_Rel.ResourceTypeID];
objDR[convYoungTAppraisedCase_Resource_Rel.ResourceTypeName] = objInFor[convYoungTAppraisedCase_Resource_Rel.ResourceTypeName];
objDR[convYoungTAppraisedCase_Resource_Rel.ResourceOwner] = objInFor[convYoungTAppraisedCase_Resource_Rel.ResourceOwner];
objDR[convYoungTAppraisedCase_Resource_Rel.ftpFileType] = objInFor[convYoungTAppraisedCase_Resource_Rel.ftpFileType];
objDR[convYoungTAppraisedCase_Resource_Rel.ftpFileSize] = objInFor[convYoungTAppraisedCase_Resource_Rel.ftpFileSize];
objDR[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner] = objInFor[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner];
objDR[convYoungTAppraisedCase_Resource_Rel.FileOriginName] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileOriginName];
objDR[convYoungTAppraisedCase_Resource_Rel.IsExistFile] = objInFor[convYoungTAppraisedCase_Resource_Rel.IsExistFile];
objDR[convYoungTAppraisedCase_Resource_Rel.FileNewName] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileNewName];
objDR[convYoungTAppraisedCase_Resource_Rel.FileOldName] = objInFor[convYoungTAppraisedCase_Resource_Rel.FileOldName];
objDR[convYoungTAppraisedCase_Resource_Rel.IsMain] = objInFor[convYoungTAppraisedCase_Resource_Rel.IsMain];
objDR[convYoungTAppraisedCase_Resource_Rel.id_UsingMode] = objInFor[convYoungTAppraisedCase_Resource_Rel.id_UsingMode];
objDR[convYoungTAppraisedCase_Resource_Rel.IsVisible] = objInFor[convYoungTAppraisedCase_Resource_Rel.IsVisible];
objDR[convYoungTAppraisedCase_Resource_Rel.IndexNO] = objInFor[convYoungTAppraisedCase_Resource_Rel.IndexNO];
objDR[convYoungTAppraisedCase_Resource_Rel.BrowseCount] = objInFor[convYoungTAppraisedCase_Resource_Rel.BrowseCount];
objDR[convYoungTAppraisedCase_Resource_Rel.UpdDate] = objInFor[convYoungTAppraisedCase_Resource_Rel.UpdDate];
objDR[convYoungTAppraisedCase_Resource_Rel.UpdUser] = objInFor[convYoungTAppraisedCase_Resource_Rel.UpdUser];
objDR[convYoungTAppraisedCase_Resource_Rel.Memo] = objInFor[convYoungTAppraisedCase_Resource_Rel.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}