
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCase_Resource_RelBL
 表名:vTeachingCaseResCase_Resource_Rel(01120425)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源(TeachingCaseResLib)
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
public static class  clsvTeachingCaseResCase_Resource_RelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCase_Resource_RelEN GetObj(this K_IdMicroteachCaseResourceRel_vTeachingCaseResCase_Resource_Rel myKey)
{
clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = clsvTeachingCaseResCase_Resource_RelBL.vTeachingCaseResCase_Resource_RelDA.GetObjByIdMicroteachCaseResourceRel(myKey.Value);
return objvTeachingCaseResCase_Resource_RelEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdMicroteachCaseResourceRel(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, long lngIdMicroteachCaseResourceRel, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFuncModuleId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convTeachingCaseResCase_Resource_Rel.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convTeachingCaseResCase_Resource_Rel.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convTeachingCaseResCase_Resource_Rel.FuncModuleId);
}
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FuncModuleId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFuncModuleName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTeachingCaseResCase_Resource_Rel.FuncModuleName);
}
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FuncModuleName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdMicroteachCase(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convTeachingCaseResCase_Resource_Rel.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convTeachingCaseResCase_Resource_Rel.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convTeachingCaseResCase_Resource_Rel.IdMicroteachCase);
}
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdMicroteachCase) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdMicroteachCase, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseID, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseID, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID);
}
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = strTeachingCaseResCaseID; //教学案例资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName);
}
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = strTeachingCaseResCaseName; //教学案例资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseTheme(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTheme, 200, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme);
}
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = strTeachingCaseResCaseTheme; //教学案例资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseText(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseText, 8000, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText);
}
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = strTeachingCaseResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseDate(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDate, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate);
}
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = strTeachingCaseResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseTime(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTime, 6, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime);
}
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = strTeachingCaseResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseDateIn(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDateIn, 8, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn);
}
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = strTeachingCaseResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseTimeIn(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn);
}
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = strTeachingCaseResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdTeachingCaseResCaseType(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdTeachingCaseResCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingCaseResCaseType, 4, convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingCaseResCaseType, 4, convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType);
}
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = strIdTeachingCaseResCaseType; //教学案例资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachingCaseResCaseTypeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachingCaseResCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTypeName, 30, convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName);
}
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = strTeachingCaseResCaseTypeName; //教学案例资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetOwnerId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convTeachingCaseResCase_Resource_Rel.OwnerId);
}
objvTeachingCaseResCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.OwnerId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetOwnerName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convTeachingCaseResCase_Resource_Rel.OwnerName);
}
objvTeachingCaseResCase_Resource_RelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.OwnerName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.OwnerName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetOwnerNameWithId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convTeachingCaseResCase_Resource_Rel.OwnerNameWithId);
}
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.OwnerNameWithId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.OwnerNameWithId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdStudyLevel(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convTeachingCaseResCase_Resource_Rel.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convTeachingCaseResCase_Resource_Rel.IdStudyLevel);
}
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdStudyLevel) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdStudyLevel, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetStudyLevelName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convTeachingCaseResCase_Resource_Rel.StudyLevelName);
}
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.StudyLevelName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdTeachingPlan(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convTeachingCaseResCase_Resource_Rel.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convTeachingCaseResCase_Resource_Rel.IdTeachingPlan);
}
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdTeachingPlan) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdTeachingPlan, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdDiscipline(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdDiscipline, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convTeachingCaseResCase_Resource_Rel.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convTeachingCaseResCase_Resource_Rel.IdDiscipline);
}
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdDiscipline) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdDiscipline, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdDiscipline] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetDisciplineID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convTeachingCaseResCase_Resource_Rel.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convTeachingCaseResCase_Resource_Rel.DisciplineID);
}
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.DisciplineID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetDisciplineName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convTeachingCaseResCase_Resource_Rel.DisciplineName);
}
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.DisciplineName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetsenateGaugeVersionID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID);
}
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetsenateGaugeVersionName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName);
}
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetVersionNo(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int? intVersionNo, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.VersionNo) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdTeachSkill(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdTeachSkill, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convTeachingCaseResCase_Resource_Rel.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convTeachingCaseResCase_Resource_Rel.IdTeachSkill);
}
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdTeachSkill) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdTeachSkill, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachSkillID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachingCaseResCase_Resource_Rel.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachingCaseResCase_Resource_Rel.TeachSkillID);
}
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachSkillID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetSkillTypeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachingCaseResCase_Resource_Rel.SkillTypeName);
}
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.SkillTypeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachSkillName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachingCaseResCase_Resource_Rel.TeachSkillName);
}
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachSkillName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachSkillTheory(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachingCaseResCase_Resource_Rel.TeachSkillTheory);
}
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachSkillTheory) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetTeachSkillOperMethod(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod);
}
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdSkillType(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convTeachingCaseResCase_Resource_Rel.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convTeachingCaseResCase_Resource_Rel.IdSkillType);
}
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdSkillType) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdSkillType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdSkillType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetSkillTypeID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachingCaseResCase_Resource_Rel.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachingCaseResCase_Resource_Rel.SkillTypeID);
}
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.SkillTypeID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCaseLevelId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convTeachingCaseResCase_Resource_Rel.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convTeachingCaseResCase_Resource_Rel.CaseLevelId);
}
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CaseLevelId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIsDualVideo(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IsDualVideo) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdXzCollege(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convTeachingCaseResCase_Resource_Rel.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convTeachingCaseResCase_Resource_Rel.IdXzCollege);
}
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdXzCollege) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdXzCollege, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdXzCollege] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCollegeID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachingCaseResCase_Resource_Rel.CollegeID);
}
objvTeachingCaseResCase_Resource_RelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CollegeID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CollegeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCollegeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingCaseResCase_Resource_Rel.CollegeName);
}
objvTeachingCaseResCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CollegeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdXzMajor(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convTeachingCaseResCase_Resource_Rel.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convTeachingCaseResCase_Resource_Rel.IdXzMajor);
}
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdXzMajor) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdXzMajor, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdXzMajor] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetMajorID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convTeachingCaseResCase_Resource_Rel.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convTeachingCaseResCase_Resource_Rel.MajorID);
}
objvTeachingCaseResCase_Resource_RelEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.MajorID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.MajorID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.MajorID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetMajorName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convTeachingCaseResCase_Resource_Rel.MajorName);
}
objvTeachingCaseResCase_Resource_RelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.MajorName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.MajorName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.MajorName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingCaseResCase_Resource_Rel.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingCaseResCase_Resource_Rel.CourseId);
}
objvTeachingCaseResCase_Resource_RelEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseCode(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingCaseResCase_Resource_Rel.CourseCode);
}
objvTeachingCaseResCase_Resource_RelEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseCode) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseCode, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseCode] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convTeachingCaseResCase_Resource_Rel.CourseName);
}
objvTeachingCaseResCase_Resource_RelEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseChapterId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convTeachingCaseResCase_Resource_Rel.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convTeachingCaseResCase_Resource_Rel.CourseChapterId);
}
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseChapterId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseChapterId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseChapterName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convTeachingCaseResCase_Resource_Rel.CourseChapterName);
}
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseChapterName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseChapterName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetParentNodeID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strParentNodeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convTeachingCaseResCase_Resource_Rel.ParentNodeID);
}
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ParentNodeID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ParentNodeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetParentNodeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convTeachingCaseResCase_Resource_Rel.ParentNodeName);
}
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ParentNodeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ParentNodeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetViewCount(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int? intViewCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ViewCount) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ViewCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ViewCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIsShow(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolIsShow, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IsShow) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IsShow, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IsShow] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetDownloadNumber(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.DownloadNumber) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.DownloadNumber, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DownloadNumber] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileIntegration(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int? intFileIntegration, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileIntegration) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileIntegration, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileIntegration] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetLikeCount(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, long? lngLikeCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.LikeCount) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.LikeCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.LikeCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCollectionCount(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CollectionCount) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CollectionCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollectionCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetRecommendedDegreeId(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId);
}
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetRecommendedDegreeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName);
}
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetBrowseCount4Case(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.BrowseCount4Case) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdResource(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convTeachingCaseResCase_Resource_Rel.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convTeachingCaseResCase_Resource_Rel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convTeachingCaseResCase_Resource_Rel.IdResource);
}
objvTeachingCaseResCase_Resource_RelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdResource) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdResource, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdResource] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetResourceID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convTeachingCaseResCase_Resource_Rel.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convTeachingCaseResCase_Resource_Rel.ResourceID);
}
objvTeachingCaseResCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ResourceID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetResourceName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convTeachingCaseResCase_Resource_Rel.ResourceName);
}
objvTeachingCaseResCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ResourceName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdFtpResource(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convTeachingCaseResCase_Resource_Rel.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convTeachingCaseResCase_Resource_Rel.IdFtpResource);
}
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdFtpResource) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdFtpResource, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdFtpResource] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdFile(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convTeachingCaseResCase_Resource_Rel.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convTeachingCaseResCase_Resource_Rel.IdFile);
}
objvTeachingCaseResCase_Resource_RelEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdFile) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdFile, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdFile] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convTeachingCaseResCase_Resource_Rel.FileName);
}
objvTeachingCaseResCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileType(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convTeachingCaseResCase_Resource_Rel.FileType);
}
objvTeachingCaseResCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileType) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetSaveDate(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convTeachingCaseResCase_Resource_Rel.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convTeachingCaseResCase_Resource_Rel.SaveDate);
}
objvTeachingCaseResCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.SaveDate) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileSize(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convTeachingCaseResCase_Resource_Rel.FileSize);
}
objvTeachingCaseResCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileSize) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetSaveTime(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convTeachingCaseResCase_Resource_Rel.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convTeachingCaseResCase_Resource_Rel.SaveTime);
}
objvTeachingCaseResCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.SaveTime) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFtpResourceID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convTeachingCaseResCase_Resource_Rel.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convTeachingCaseResCase_Resource_Rel.FtpResourceID);
}
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FtpResourceID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileOriginalName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convTeachingCaseResCase_Resource_Rel.FileOriginalName);
}
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileOriginalName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileDirName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convTeachingCaseResCase_Resource_Rel.FileDirName);
}
objvTeachingCaseResCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileDirName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileRename(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convTeachingCaseResCase_Resource_Rel.FileRename);
}
objvTeachingCaseResCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileRename) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileUpDate(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convTeachingCaseResCase_Resource_Rel.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convTeachingCaseResCase_Resource_Rel.FileUpDate);
}
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileUpDate) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileUpTime(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convTeachingCaseResCase_Resource_Rel.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convTeachingCaseResCase_Resource_Rel.FileUpTime);
}
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileUpTime) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetSaveMode(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.SaveMode) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdResourceType(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convTeachingCaseResCase_Resource_Rel.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convTeachingCaseResCase_Resource_Rel.IdResourceType);
}
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdResourceType) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdResourceType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdResourceType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetResourceTypeID(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convTeachingCaseResCase_Resource_Rel.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convTeachingCaseResCase_Resource_Rel.ResourceTypeID);
}
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ResourceTypeID) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetResourceTypeName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convTeachingCaseResCase_Resource_Rel.ResourceTypeName);
}
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ResourceTypeName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetResourceOwner(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convTeachingCaseResCase_Resource_Rel.ResourceOwner);
}
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ResourceOwner) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetftpFileType(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachingCaseResCase_Resource_Rel.ftpFileType);
}
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ftpFileType) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetftpFileSize(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convTeachingCaseResCase_Resource_Rel.ftpFileSize);
}
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ftpFileSize) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetftpResourceOwner(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convTeachingCaseResCase_Resource_Rel.ftpResourceOwner);
}
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ftpResourceOwner) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileOriginName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convTeachingCaseResCase_Resource_Rel.FileOriginName);
}
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileOriginName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIsExistFile(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IsExistFile) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileNewName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convTeachingCaseResCase_Resource_Rel.FileNewName);
}
objvTeachingCaseResCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileNewName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetFileOldName(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convTeachingCaseResCase_Resource_Rel.FileOldName);
}
objvTeachingCaseResCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.FileOldName) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIsMain(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IsMain) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIdUsingMode(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strIdUsingMode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUsingMode, 4, convTeachingCaseResCase_Resource_Rel.IdUsingMode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUsingMode, 4, convTeachingCaseResCase_Resource_Rel.IdUsingMode);
}
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = strIdUsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IdUsingMode) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IdUsingMode, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdUsingMode] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIsVisible(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IsVisible) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetIndexNO(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int? intIndexNO, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.IndexNO) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetBrowseCount(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, int? intBrowseCount, string strComparisonOp="")
	{
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.BrowseCount) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetUpdDate(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTeachingCaseResCase_Resource_Rel.UpdDate);
}
objvTeachingCaseResCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.UpdDate) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetUpdUser(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTeachingCaseResCase_Resource_Rel.UpdUser);
}
objvTeachingCaseResCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.UpdUser) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetMemo(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingCaseResCase_Resource_Rel.Memo);
}
objvTeachingCaseResCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.Memo) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCollegeNameA(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachingCaseResCase_Resource_Rel.CollegeNameA);
}
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CollegeNameA) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetCourseChapterReferred(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convTeachingCaseResCase_Resource_Rel.CourseChapterReferred);
}
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.CourseChapterReferred) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.CourseChapterReferred, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCase_Resource_RelEN SetParentNodeReferred(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convTeachingCaseResCase_Resource_Rel.ParentNodeReferred);
}
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCase_Resource_Rel.ParentNodeReferred) == false)
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachingCaseResCase_Resource_Rel.ParentNodeReferred, strComparisonOp);
}
else
{
objvTeachingCaseResCase_Resource_RelEN.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] = strComparisonOp;
}
}
return objvTeachingCaseResCase_Resource_RelEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelENS">源对象</param>
 /// <param name = "objvTeachingCaseResCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelENS, clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelENT)
{
try
{
objvTeachingCaseResCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvTeachingCaseResCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelENT.FuncModuleId = objvTeachingCaseResCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCase_Resource_RelENT.FuncModuleName = objvTeachingCaseResCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCase_Resource_RelENT.IdMicroteachCase = objvTeachingCaseResCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseID = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseName = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTheme = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseText = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseDate = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTime = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCase_Resource_RelENT.IdTeachingCaseResCaseType = objvTeachingCaseResCase_Resource_RelENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelENT.OwnerId = objvTeachingCaseResCase_Resource_RelENS.OwnerId; //拥有者Id
objvTeachingCaseResCase_Resource_RelENT.OwnerName = objvTeachingCaseResCase_Resource_RelENS.OwnerName; //拥有者姓名
objvTeachingCaseResCase_Resource_RelENT.OwnerNameWithId = objvTeachingCaseResCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelENT.IdStudyLevel = objvTeachingCaseResCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvTeachingCaseResCase_Resource_RelENT.StudyLevelName = objvTeachingCaseResCase_Resource_RelENS.StudyLevelName; //学段名称
objvTeachingCaseResCase_Resource_RelENT.IdTeachingPlan = objvTeachingCaseResCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvTeachingCaseResCase_Resource_RelENT.IdDiscipline = objvTeachingCaseResCase_Resource_RelENS.IdDiscipline; //学科流水号
objvTeachingCaseResCase_Resource_RelENT.DisciplineID = objvTeachingCaseResCase_Resource_RelENS.DisciplineID; //学科ID
objvTeachingCaseResCase_Resource_RelENT.DisciplineName = objvTeachingCaseResCase_Resource_RelENS.DisciplineName; //学科名称
objvTeachingCaseResCase_Resource_RelENT.senateGaugeVersionID = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCase_Resource_RelENT.senateGaugeVersionName = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCase_Resource_RelENT.senateGaugeVersionTtlScore = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCase_Resource_RelENT.VersionNo = objvTeachingCaseResCase_Resource_RelENS.VersionNo; //版本号
objvTeachingCaseResCase_Resource_RelENT.IdTeachSkill = objvTeachingCaseResCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvTeachingCaseResCase_Resource_RelENT.TeachSkillID = objvTeachingCaseResCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCase_Resource_RelENT.SkillTypeName = objvTeachingCaseResCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCase_Resource_RelENT.TeachSkillName = objvTeachingCaseResCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCase_Resource_RelENT.TeachSkillTheory = objvTeachingCaseResCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelENT.TeachSkillOperMethod = objvTeachingCaseResCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelENT.IdSkillType = objvTeachingCaseResCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvTeachingCaseResCase_Resource_RelENT.SkillTypeID = objvTeachingCaseResCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCase_Resource_RelENT.CaseLevelId = objvTeachingCaseResCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCase_Resource_RelENT.IsDualVideo = objvTeachingCaseResCase_Resource_RelENS.IsDualVideo; //是否双视频
objvTeachingCaseResCase_Resource_RelENT.IdXzCollege = objvTeachingCaseResCase_Resource_RelENS.IdXzCollege; //学院流水号
objvTeachingCaseResCase_Resource_RelENT.CollegeID = objvTeachingCaseResCase_Resource_RelENS.CollegeID; //学院ID
objvTeachingCaseResCase_Resource_RelENT.CollegeName = objvTeachingCaseResCase_Resource_RelENS.CollegeName; //学院名称
objvTeachingCaseResCase_Resource_RelENT.IdXzMajor = objvTeachingCaseResCase_Resource_RelENS.IdXzMajor; //专业流水号
objvTeachingCaseResCase_Resource_RelENT.MajorID = objvTeachingCaseResCase_Resource_RelENS.MajorID; //专业ID
objvTeachingCaseResCase_Resource_RelENT.MajorName = objvTeachingCaseResCase_Resource_RelENS.MajorName; //专业名称
objvTeachingCaseResCase_Resource_RelENT.CourseId = objvTeachingCaseResCase_Resource_RelENS.CourseId; //课程Id
objvTeachingCaseResCase_Resource_RelENT.CourseCode = objvTeachingCaseResCase_Resource_RelENS.CourseCode; //课程代码
objvTeachingCaseResCase_Resource_RelENT.CourseName = objvTeachingCaseResCase_Resource_RelENS.CourseName; //课程名称
objvTeachingCaseResCase_Resource_RelENT.CourseChapterId = objvTeachingCaseResCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvTeachingCaseResCase_Resource_RelENT.CourseChapterName = objvTeachingCaseResCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvTeachingCaseResCase_Resource_RelENT.ParentNodeID = objvTeachingCaseResCase_Resource_RelENS.ParentNodeID; //父节点编号
objvTeachingCaseResCase_Resource_RelENT.ParentNodeName = objvTeachingCaseResCase_Resource_RelENS.ParentNodeName; //父节点名称
objvTeachingCaseResCase_Resource_RelENT.ViewCount = objvTeachingCaseResCase_Resource_RelENS.ViewCount; //浏览量
objvTeachingCaseResCase_Resource_RelENT.IsShow = objvTeachingCaseResCase_Resource_RelENS.IsShow; //是否启用
objvTeachingCaseResCase_Resource_RelENT.DownloadNumber = objvTeachingCaseResCase_Resource_RelENS.DownloadNumber; //下载数目
objvTeachingCaseResCase_Resource_RelENT.FileIntegration = objvTeachingCaseResCase_Resource_RelENS.FileIntegration; //文件积分
objvTeachingCaseResCase_Resource_RelENT.LikeCount = objvTeachingCaseResCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvTeachingCaseResCase_Resource_RelENT.CollectionCount = objvTeachingCaseResCase_Resource_RelENS.CollectionCount; //收藏数量
objvTeachingCaseResCase_Resource_RelENT.RecommendedDegreeId = objvTeachingCaseResCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvTeachingCaseResCase_Resource_RelENT.RecommendedDegreeName = objvTeachingCaseResCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvTeachingCaseResCase_Resource_RelENT.BrowseCount4Case = objvTeachingCaseResCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvTeachingCaseResCase_Resource_RelENT.IdResource = objvTeachingCaseResCase_Resource_RelENS.IdResource; //资源流水号
objvTeachingCaseResCase_Resource_RelENT.ResourceID = objvTeachingCaseResCase_Resource_RelENS.ResourceID; //资源ID
objvTeachingCaseResCase_Resource_RelENT.ResourceName = objvTeachingCaseResCase_Resource_RelENS.ResourceName; //资源名称
objvTeachingCaseResCase_Resource_RelENT.IdFtpResource = objvTeachingCaseResCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvTeachingCaseResCase_Resource_RelENT.IdFile = objvTeachingCaseResCase_Resource_RelENS.IdFile; //文件流水号
objvTeachingCaseResCase_Resource_RelENT.FileName = objvTeachingCaseResCase_Resource_RelENS.FileName; //文件名称
objvTeachingCaseResCase_Resource_RelENT.FileType = objvTeachingCaseResCase_Resource_RelENS.FileType; //文件类型
objvTeachingCaseResCase_Resource_RelENT.SaveDate = objvTeachingCaseResCase_Resource_RelENS.SaveDate; //创建日期
objvTeachingCaseResCase_Resource_RelENT.FileSize = objvTeachingCaseResCase_Resource_RelENS.FileSize; //文件大小
objvTeachingCaseResCase_Resource_RelENT.SaveTime = objvTeachingCaseResCase_Resource_RelENS.SaveTime; //创建时间
objvTeachingCaseResCase_Resource_RelENT.FtpResourceID = objvTeachingCaseResCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvTeachingCaseResCase_Resource_RelENT.FileOriginalName = objvTeachingCaseResCase_Resource_RelENS.FileOriginalName; //文件原名
objvTeachingCaseResCase_Resource_RelENT.FileDirName = objvTeachingCaseResCase_Resource_RelENS.FileDirName; //文件目录名
objvTeachingCaseResCase_Resource_RelENT.FileRename = objvTeachingCaseResCase_Resource_RelENS.FileRename; //文件新名
objvTeachingCaseResCase_Resource_RelENT.FileUpDate = objvTeachingCaseResCase_Resource_RelENS.FileUpDate; //创建日期
objvTeachingCaseResCase_Resource_RelENT.FileUpTime = objvTeachingCaseResCase_Resource_RelENS.FileUpTime; //创建时间
objvTeachingCaseResCase_Resource_RelENT.SaveMode = objvTeachingCaseResCase_Resource_RelENS.SaveMode; //文件存放方式
objvTeachingCaseResCase_Resource_RelENT.IdResourceType = objvTeachingCaseResCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvTeachingCaseResCase_Resource_RelENT.ResourceTypeID = objvTeachingCaseResCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvTeachingCaseResCase_Resource_RelENT.ResourceTypeName = objvTeachingCaseResCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvTeachingCaseResCase_Resource_RelENT.ResourceOwner = objvTeachingCaseResCase_Resource_RelENS.ResourceOwner; //上传者
objvTeachingCaseResCase_Resource_RelENT.ftpFileType = objvTeachingCaseResCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvTeachingCaseResCase_Resource_RelENT.ftpFileSize = objvTeachingCaseResCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvTeachingCaseResCase_Resource_RelENT.ftpResourceOwner = objvTeachingCaseResCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelENT.FileOriginName = objvTeachingCaseResCase_Resource_RelENS.FileOriginName; //原文件名
objvTeachingCaseResCase_Resource_RelENT.IsExistFile = objvTeachingCaseResCase_Resource_RelENS.IsExistFile; //是否存在文件
objvTeachingCaseResCase_Resource_RelENT.FileNewName = objvTeachingCaseResCase_Resource_RelENS.FileNewName; //新文件名
objvTeachingCaseResCase_Resource_RelENT.FileOldName = objvTeachingCaseResCase_Resource_RelENS.FileOldName; //旧文件名
objvTeachingCaseResCase_Resource_RelENT.IsMain = objvTeachingCaseResCase_Resource_RelENS.IsMain; //是否主资源
objvTeachingCaseResCase_Resource_RelENT.IdUsingMode = objvTeachingCaseResCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelENT.IsVisible = objvTeachingCaseResCase_Resource_RelENS.IsVisible; //是否显示
objvTeachingCaseResCase_Resource_RelENT.IndexNO = objvTeachingCaseResCase_Resource_RelENS.IndexNO; //序号
objvTeachingCaseResCase_Resource_RelENT.BrowseCount = objvTeachingCaseResCase_Resource_RelENS.BrowseCount; //浏览次数
objvTeachingCaseResCase_Resource_RelENT.UpdDate = objvTeachingCaseResCase_Resource_RelENS.UpdDate; //修改日期
objvTeachingCaseResCase_Resource_RelENT.UpdUser = objvTeachingCaseResCase_Resource_RelENS.UpdUser; //修改人
objvTeachingCaseResCase_Resource_RelENT.Memo = objvTeachingCaseResCase_Resource_RelENS.Memo; //备注
objvTeachingCaseResCase_Resource_RelENT.CollegeNameA = objvTeachingCaseResCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCase_Resource_RelENT.CourseChapterReferred = objvTeachingCaseResCase_Resource_RelENS.CourseChapterReferred; //节简称
objvTeachingCaseResCase_Resource_RelENT.ParentNodeReferred = objvTeachingCaseResCase_Resource_RelENS.ParentNodeReferred; //章简称
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
 /// <param name = "objvTeachingCaseResCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsvTeachingCaseResCase_Resource_RelEN:objvTeachingCaseResCase_Resource_RelENT</returns>
 public static clsvTeachingCaseResCase_Resource_RelEN CopyTo(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelENS)
{
try
{
 clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelENT = new clsvTeachingCaseResCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = objvTeachingCaseResCase_Resource_RelENS.IdMicroteachCaseResourceRel, //微格案例资源关系流水号
FuncModuleId = objvTeachingCaseResCase_Resource_RelENS.FuncModuleId, //功能模块Id
FuncModuleName = objvTeachingCaseResCase_Resource_RelENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvTeachingCaseResCase_Resource_RelENS.IdMicroteachCase, //微格教学案例流水号
TeachingCaseResCaseID = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseID, //教学案例资源案例ID
TeachingCaseResCaseName = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseName, //教学案例资源案例名称
TeachingCaseResCaseTheme = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTheme, //教学案例资源案例主题词
TeachingCaseResCaseText = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseText, //案例文本内容
TeachingCaseResCaseDate = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseDate, //视频资源日期
TeachingCaseResCaseTime = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTime, //视频资源时间
TeachingCaseResCaseDateIn = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseDateIn, //案例入库日期
TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTimeIn, //案例入库时间
IdTeachingCaseResCaseType = objvTeachingCaseResCase_Resource_RelENS.IdTeachingCaseResCaseType, //教学案例资源类型流水号
TeachingCaseResCaseTypeName = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTypeName, //教学案例资源案例类型名称
OwnerId = objvTeachingCaseResCase_Resource_RelENS.OwnerId, //拥有者Id
OwnerName = objvTeachingCaseResCase_Resource_RelENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvTeachingCaseResCase_Resource_RelENS.OwnerNameWithId, //拥有者名称附Id
IdStudyLevel = objvTeachingCaseResCase_Resource_RelENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvTeachingCaseResCase_Resource_RelENS.StudyLevelName, //学段名称
IdTeachingPlan = objvTeachingCaseResCase_Resource_RelENS.IdTeachingPlan, //教案流水号
IdDiscipline = objvTeachingCaseResCase_Resource_RelENS.IdDiscipline, //学科流水号
DisciplineID = objvTeachingCaseResCase_Resource_RelENS.DisciplineID, //学科ID
DisciplineName = objvTeachingCaseResCase_Resource_RelENS.DisciplineName, //学科名称
senateGaugeVersionID = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvTeachingCaseResCase_Resource_RelENS.VersionNo, //版本号
IdTeachSkill = objvTeachingCaseResCase_Resource_RelENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvTeachingCaseResCase_Resource_RelENS.TeachSkillID, //教学技能ID
SkillTypeName = objvTeachingCaseResCase_Resource_RelENS.SkillTypeName, //技能类型名称
TeachSkillName = objvTeachingCaseResCase_Resource_RelENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvTeachingCaseResCase_Resource_RelENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvTeachingCaseResCase_Resource_RelENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvTeachingCaseResCase_Resource_RelENS.IdSkillType, //技能类型流水号
SkillTypeID = objvTeachingCaseResCase_Resource_RelENS.SkillTypeID, //技能类型ID
CaseLevelId = objvTeachingCaseResCase_Resource_RelENS.CaseLevelId, //课例等级Id
IsDualVideo = objvTeachingCaseResCase_Resource_RelENS.IsDualVideo, //是否双视频
IdXzCollege = objvTeachingCaseResCase_Resource_RelENS.IdXzCollege, //学院流水号
CollegeID = objvTeachingCaseResCase_Resource_RelENS.CollegeID, //学院ID
CollegeName = objvTeachingCaseResCase_Resource_RelENS.CollegeName, //学院名称
IdXzMajor = objvTeachingCaseResCase_Resource_RelENS.IdXzMajor, //专业流水号
MajorID = objvTeachingCaseResCase_Resource_RelENS.MajorID, //专业ID
MajorName = objvTeachingCaseResCase_Resource_RelENS.MajorName, //专业名称
CourseId = objvTeachingCaseResCase_Resource_RelENS.CourseId, //课程Id
CourseCode = objvTeachingCaseResCase_Resource_RelENS.CourseCode, //课程代码
CourseName = objvTeachingCaseResCase_Resource_RelENS.CourseName, //课程名称
CourseChapterId = objvTeachingCaseResCase_Resource_RelENS.CourseChapterId, //课程章节ID
CourseChapterName = objvTeachingCaseResCase_Resource_RelENS.CourseChapterName, //课程章节名称
ParentNodeID = objvTeachingCaseResCase_Resource_RelENS.ParentNodeID, //父节点编号
ParentNodeName = objvTeachingCaseResCase_Resource_RelENS.ParentNodeName, //父节点名称
ViewCount = objvTeachingCaseResCase_Resource_RelENS.ViewCount, //浏览量
IsShow = objvTeachingCaseResCase_Resource_RelENS.IsShow, //是否启用
DownloadNumber = objvTeachingCaseResCase_Resource_RelENS.DownloadNumber, //下载数目
FileIntegration = objvTeachingCaseResCase_Resource_RelENS.FileIntegration, //文件积分
LikeCount = objvTeachingCaseResCase_Resource_RelENS.LikeCount, //资源喜欢数量
CollectionCount = objvTeachingCaseResCase_Resource_RelENS.CollectionCount, //收藏数量
RecommendedDegreeId = objvTeachingCaseResCase_Resource_RelENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvTeachingCaseResCase_Resource_RelENS.RecommendedDegreeName, //推荐度名称
BrowseCount4Case = objvTeachingCaseResCase_Resource_RelENS.BrowseCount4Case, //课例浏览次数
IdResource = objvTeachingCaseResCase_Resource_RelENS.IdResource, //资源流水号
ResourceID = objvTeachingCaseResCase_Resource_RelENS.ResourceID, //资源ID
ResourceName = objvTeachingCaseResCase_Resource_RelENS.ResourceName, //资源名称
IdFtpResource = objvTeachingCaseResCase_Resource_RelENS.IdFtpResource, //FTP资源流水号
IdFile = objvTeachingCaseResCase_Resource_RelENS.IdFile, //文件流水号
FileName = objvTeachingCaseResCase_Resource_RelENS.FileName, //文件名称
FileType = objvTeachingCaseResCase_Resource_RelENS.FileType, //文件类型
SaveDate = objvTeachingCaseResCase_Resource_RelENS.SaveDate, //创建日期
FileSize = objvTeachingCaseResCase_Resource_RelENS.FileSize, //文件大小
SaveTime = objvTeachingCaseResCase_Resource_RelENS.SaveTime, //创建时间
FtpResourceID = objvTeachingCaseResCase_Resource_RelENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvTeachingCaseResCase_Resource_RelENS.FileOriginalName, //文件原名
FileDirName = objvTeachingCaseResCase_Resource_RelENS.FileDirName, //文件目录名
FileRename = objvTeachingCaseResCase_Resource_RelENS.FileRename, //文件新名
FileUpDate = objvTeachingCaseResCase_Resource_RelENS.FileUpDate, //创建日期
FileUpTime = objvTeachingCaseResCase_Resource_RelENS.FileUpTime, //创建时间
SaveMode = objvTeachingCaseResCase_Resource_RelENS.SaveMode, //文件存放方式
IdResourceType = objvTeachingCaseResCase_Resource_RelENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvTeachingCaseResCase_Resource_RelENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvTeachingCaseResCase_Resource_RelENS.ResourceTypeName, //资源类型名称
ResourceOwner = objvTeachingCaseResCase_Resource_RelENS.ResourceOwner, //上传者
ftpFileType = objvTeachingCaseResCase_Resource_RelENS.ftpFileType, //ftp文件类型
ftpFileSize = objvTeachingCaseResCase_Resource_RelENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvTeachingCaseResCase_Resource_RelENS.ftpResourceOwner, //Ftp资源拥有者
FileOriginName = objvTeachingCaseResCase_Resource_RelENS.FileOriginName, //原文件名
IsExistFile = objvTeachingCaseResCase_Resource_RelENS.IsExistFile, //是否存在文件
FileNewName = objvTeachingCaseResCase_Resource_RelENS.FileNewName, //新文件名
FileOldName = objvTeachingCaseResCase_Resource_RelENS.FileOldName, //旧文件名
IsMain = objvTeachingCaseResCase_Resource_RelENS.IsMain, //是否主资源
IdUsingMode = objvTeachingCaseResCase_Resource_RelENS.IdUsingMode, //资源使用模式流水号
IsVisible = objvTeachingCaseResCase_Resource_RelENS.IsVisible, //是否显示
IndexNO = objvTeachingCaseResCase_Resource_RelENS.IndexNO, //序号
BrowseCount = objvTeachingCaseResCase_Resource_RelENS.BrowseCount, //浏览次数
UpdDate = objvTeachingCaseResCase_Resource_RelENS.UpdDate, //修改日期
UpdUser = objvTeachingCaseResCase_Resource_RelENS.UpdUser, //修改人
Memo = objvTeachingCaseResCase_Resource_RelENS.Memo, //备注
CollegeNameA = objvTeachingCaseResCase_Resource_RelENS.CollegeNameA, //学院名称简写
CourseChapterReferred = objvTeachingCaseResCase_Resource_RelENS.CourseChapterReferred, //节简称
ParentNodeReferred = objvTeachingCaseResCase_Resource_RelENS.ParentNodeReferred, //章简称
};
 return objvTeachingCaseResCase_Resource_RelENT;
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
public static void CheckProperty4Condition(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN)
{
 clsvTeachingCaseResCase_Resource_RelBL.vTeachingCaseResCase_Resource_RelDA.CheckProperty4Condition(objvTeachingCaseResCase_Resource_RelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel) == true)
{
string strComparisonOpIdMicroteachCaseResourceRel = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel, objvTeachingCaseResCase_Resource_RelCond.IdMicroteachCaseResourceRel, strComparisonOpIdMicroteachCaseResourceRel);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FuncModuleId, objvTeachingCaseResCase_Resource_RelCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FuncModuleName, objvTeachingCaseResCase_Resource_RelCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdMicroteachCase, objvTeachingCaseResCase_Resource_RelCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID) == true)
{
string strComparisonOpTeachingCaseResCaseID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID, objvTeachingCaseResCase_Resource_RelCond.TeachingCaseResCaseID, strComparisonOpTeachingCaseResCaseID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName) == true)
{
string strComparisonOpTeachingCaseResCaseName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName, objvTeachingCaseResCase_Resource_RelCond.TeachingCaseResCaseName, strComparisonOpTeachingCaseResCaseName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme) == true)
{
string strComparisonOpTeachingCaseResCaseTheme = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme, objvTeachingCaseResCase_Resource_RelCond.TeachingCaseResCaseTheme, strComparisonOpTeachingCaseResCaseTheme);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText) == true)
{
string strComparisonOpTeachingCaseResCaseText = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText, objvTeachingCaseResCase_Resource_RelCond.TeachingCaseResCaseText, strComparisonOpTeachingCaseResCaseText);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate) == true)
{
string strComparisonOpTeachingCaseResCaseDate = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate, objvTeachingCaseResCase_Resource_RelCond.TeachingCaseResCaseDate, strComparisonOpTeachingCaseResCaseDate);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime) == true)
{
string strComparisonOpTeachingCaseResCaseTime = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime, objvTeachingCaseResCase_Resource_RelCond.TeachingCaseResCaseTime, strComparisonOpTeachingCaseResCaseTime);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn) == true)
{
string strComparisonOpTeachingCaseResCaseDateIn = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn, objvTeachingCaseResCase_Resource_RelCond.TeachingCaseResCaseDateIn, strComparisonOpTeachingCaseResCaseDateIn);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn) == true)
{
string strComparisonOpTeachingCaseResCaseTimeIn = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn, objvTeachingCaseResCase_Resource_RelCond.TeachingCaseResCaseTimeIn, strComparisonOpTeachingCaseResCaseTimeIn);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType) == true)
{
string strComparisonOpIdTeachingCaseResCaseType = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType, objvTeachingCaseResCase_Resource_RelCond.IdTeachingCaseResCaseType, strComparisonOpIdTeachingCaseResCaseType);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName) == true)
{
string strComparisonOpTeachingCaseResCaseTypeName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName, objvTeachingCaseResCase_Resource_RelCond.TeachingCaseResCaseTypeName, strComparisonOpTeachingCaseResCaseTypeName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOpOwnerId = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.OwnerId, objvTeachingCaseResCase_Resource_RelCond.OwnerId, strComparisonOpOwnerId);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.OwnerName) == true)
{
string strComparisonOpOwnerName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.OwnerName, objvTeachingCaseResCase_Resource_RelCond.OwnerName, strComparisonOpOwnerName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.OwnerNameWithId, objvTeachingCaseResCase_Resource_RelCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdStudyLevel, objvTeachingCaseResCase_Resource_RelCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.StudyLevelName, objvTeachingCaseResCase_Resource_RelCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdTeachingPlan, objvTeachingCaseResCase_Resource_RelCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdDiscipline, objvTeachingCaseResCase_Resource_RelCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.DisciplineID, objvTeachingCaseResCase_Resource_RelCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.DisciplineName, objvTeachingCaseResCase_Resource_RelCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID, objvTeachingCaseResCase_Resource_RelCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName, objvTeachingCaseResCase_Resource_RelCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore, objvTeachingCaseResCase_Resource_RelCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOpVersionNo = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.VersionNo, objvTeachingCaseResCase_Resource_RelCond.VersionNo, strComparisonOpVersionNo);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdTeachSkill, objvTeachingCaseResCase_Resource_RelCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachSkillID, objvTeachingCaseResCase_Resource_RelCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.SkillTypeName, objvTeachingCaseResCase_Resource_RelCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachSkillName, objvTeachingCaseResCase_Resource_RelCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachSkillTheory, objvTeachingCaseResCase_Resource_RelCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod, objvTeachingCaseResCase_Resource_RelCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdSkillType, objvTeachingCaseResCase_Resource_RelCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.SkillTypeID, objvTeachingCaseResCase_Resource_RelCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CaseLevelId, objvTeachingCaseResCase_Resource_RelCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IsDualVideo) == true)
{
if (objvTeachingCaseResCase_Resource_RelCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.IsDualVideo);
}
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdXzCollege, objvTeachingCaseResCase_Resource_RelCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CollegeID) == true)
{
string strComparisonOpCollegeID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CollegeID, objvTeachingCaseResCase_Resource_RelCond.CollegeID, strComparisonOpCollegeID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOpCollegeName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CollegeName, objvTeachingCaseResCase_Resource_RelCond.CollegeName, strComparisonOpCollegeName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdXzMajor, objvTeachingCaseResCase_Resource_RelCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.MajorID) == true)
{
string strComparisonOpMajorID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.MajorID, objvTeachingCaseResCase_Resource_RelCond.MajorID, strComparisonOpMajorID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.MajorName) == true)
{
string strComparisonOpMajorName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.MajorName, objvTeachingCaseResCase_Resource_RelCond.MajorName, strComparisonOpMajorName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseId) == true)
{
string strComparisonOpCourseId = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseId, objvTeachingCaseResCase_Resource_RelCond.CourseId, strComparisonOpCourseId);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseCode) == true)
{
string strComparisonOpCourseCode = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseCode, objvTeachingCaseResCase_Resource_RelCond.CourseCode, strComparisonOpCourseCode);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseName) == true)
{
string strComparisonOpCourseName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseName, objvTeachingCaseResCase_Resource_RelCond.CourseName, strComparisonOpCourseName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseChapterId, objvTeachingCaseResCase_Resource_RelCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseChapterName, objvTeachingCaseResCase_Resource_RelCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ParentNodeID) == true)
{
string strComparisonOpParentNodeID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ParentNodeID, objvTeachingCaseResCase_Resource_RelCond.ParentNodeID, strComparisonOpParentNodeID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ParentNodeName, objvTeachingCaseResCase_Resource_RelCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ViewCount) == true)
{
string strComparisonOpViewCount = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.ViewCount, objvTeachingCaseResCase_Resource_RelCond.ViewCount, strComparisonOpViewCount);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IsShow) == true)
{
if (objvTeachingCaseResCase_Resource_RelCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.IsShow);
}
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.DownloadNumber, objvTeachingCaseResCase_Resource_RelCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.FileIntegration, objvTeachingCaseResCase_Resource_RelCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.LikeCount) == true)
{
string strComparisonOpLikeCount = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.LikeCount, objvTeachingCaseResCase_Resource_RelCond.LikeCount, strComparisonOpLikeCount);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.CollectionCount, objvTeachingCaseResCase_Resource_RelCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId, objvTeachingCaseResCase_Resource_RelCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName, objvTeachingCaseResCase_Resource_RelCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.BrowseCount4Case, objvTeachingCaseResCase_Resource_RelCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdResource) == true)
{
string strComparisonOpIdResource = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdResource, objvTeachingCaseResCase_Resource_RelCond.IdResource, strComparisonOpIdResource);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOpResourceID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ResourceID, objvTeachingCaseResCase_Resource_RelCond.ResourceID, strComparisonOpResourceID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOpResourceName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ResourceName, objvTeachingCaseResCase_Resource_RelCond.ResourceName, strComparisonOpResourceName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdFtpResource, objvTeachingCaseResCase_Resource_RelCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdFile) == true)
{
string strComparisonOpIdFile = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdFile, objvTeachingCaseResCase_Resource_RelCond.IdFile, strComparisonOpIdFile);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileName) == true)
{
string strComparisonOpFileName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileName, objvTeachingCaseResCase_Resource_RelCond.FileName, strComparisonOpFileName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileType) == true)
{
string strComparisonOpFileType = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileType, objvTeachingCaseResCase_Resource_RelCond.FileType, strComparisonOpFileType);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOpSaveDate = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.SaveDate, objvTeachingCaseResCase_Resource_RelCond.SaveDate, strComparisonOpSaveDate);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileSize) == true)
{
string strComparisonOpFileSize = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileSize, objvTeachingCaseResCase_Resource_RelCond.FileSize, strComparisonOpFileSize);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOpSaveTime = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.SaveTime, objvTeachingCaseResCase_Resource_RelCond.SaveTime, strComparisonOpSaveTime);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FtpResourceID, objvTeachingCaseResCase_Resource_RelCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileOriginalName, objvTeachingCaseResCase_Resource_RelCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOpFileDirName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileDirName, objvTeachingCaseResCase_Resource_RelCond.FileDirName, strComparisonOpFileDirName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileRename) == true)
{
string strComparisonOpFileRename = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileRename, objvTeachingCaseResCase_Resource_RelCond.FileRename, strComparisonOpFileRename);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileUpDate, objvTeachingCaseResCase_Resource_RelCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileUpTime, objvTeachingCaseResCase_Resource_RelCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.SaveMode) == true)
{
if (objvTeachingCaseResCase_Resource_RelCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.SaveMode);
}
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdResourceType, objvTeachingCaseResCase_Resource_RelCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ResourceTypeID, objvTeachingCaseResCase_Resource_RelCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ResourceTypeName, objvTeachingCaseResCase_Resource_RelCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ResourceOwner, objvTeachingCaseResCase_Resource_RelCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ftpFileType, objvTeachingCaseResCase_Resource_RelCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ftpFileSize, objvTeachingCaseResCase_Resource_RelCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ftpResourceOwner, objvTeachingCaseResCase_Resource_RelCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileOriginName, objvTeachingCaseResCase_Resource_RelCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IsExistFile) == true)
{
if (objvTeachingCaseResCase_Resource_RelCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.IsExistFile);
}
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOpFileNewName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileNewName, objvTeachingCaseResCase_Resource_RelCond.FileNewName, strComparisonOpFileNewName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOpFileOldName = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.FileOldName, objvTeachingCaseResCase_Resource_RelCond.FileOldName, strComparisonOpFileOldName);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IsMain) == true)
{
if (objvTeachingCaseResCase_Resource_RelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.IsMain);
}
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IdUsingMode) == true)
{
string strComparisonOpIdUsingMode = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IdUsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.IdUsingMode, objvTeachingCaseResCase_Resource_RelCond.IdUsingMode, strComparisonOpIdUsingMode);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IsVisible) == true)
{
if (objvTeachingCaseResCase_Resource_RelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCase_Resource_Rel.IsVisible);
}
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOpIndexNO = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.IndexNO, objvTeachingCaseResCase_Resource_RelCond.IndexNO, strComparisonOpIndexNO);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCase_Resource_Rel.BrowseCount, objvTeachingCaseResCase_Resource_RelCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOpUpdDate = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.UpdDate, objvTeachingCaseResCase_Resource_RelCond.UpdDate, strComparisonOpUpdDate);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOpUpdUser = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.UpdUser, objvTeachingCaseResCase_Resource_RelCond.UpdUser, strComparisonOpUpdUser);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.Memo) == true)
{
string strComparisonOpMemo = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.Memo, objvTeachingCaseResCase_Resource_RelCond.Memo, strComparisonOpMemo);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CollegeNameA, objvTeachingCaseResCase_Resource_RelCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.CourseChapterReferred, objvTeachingCaseResCase_Resource_RelCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(convTeachingCaseResCase_Resource_Rel.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCase_Resource_Rel.ParentNodeReferred, objvTeachingCaseResCase_Resource_RelCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachingCaseResCase_Resource_Rel
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教学案例资源案例资源关系(vTeachingCaseResCase_Resource_Rel)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingCaseResCase_Resource_RelBL
{
public static RelatedActions_vTeachingCaseResCase_Resource_Rel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachingCaseResCase_Resource_RelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachingCaseResCase_Resource_RelDA vTeachingCaseResCase_Resource_RelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachingCaseResCase_Resource_RelDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachingCaseResCase_Resource_RelBL()
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
if (string.IsNullOrEmpty(clsvTeachingCaseResCase_Resource_RelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCase_Resource_RelEN._ConnectString);
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
public static DataTable GetDataTable_vTeachingCaseResCase_Resource_Rel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCase_Resource_RelDA.GetDataTable_vTeachingCaseResCase_Resource_Rel(strWhereCond);
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
objDT = vTeachingCaseResCase_Resource_RelDA.GetDataTable(strWhereCond);
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
objDT = vTeachingCaseResCase_Resource_RelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeachingCaseResCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeachingCaseResCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeachingCaseResCase_Resource_RelDA.GetDataTable_Top(objTopPara);
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
objDT = vTeachingCaseResCase_Resource_RelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeachingCaseResCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeachingCaseResCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstByIdMicroteachCaseResourceRelLst(List<long> arrIdMicroteachCaseResourceRelLst)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = new List<clsvTeachingCaseResCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseResourceRelLst);
 string strWhereCond = string.Format("IdMicroteachCaseResourceRel in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = new clsvTeachingCaseResCase_Resource_RelEN();
try
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objRow[convTeachingCaseResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objRow[convTeachingCaseResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objRow[convTeachingCaseResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objRow[convTeachingCaseResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_Resource_RelEN.MajorID = objRow[convTeachingCaseResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_Resource_RelEN.MajorName = objRow[convTeachingCaseResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_Resource_RelEN.CourseId = objRow[convTeachingCaseResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objRow[convTeachingCaseResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_Resource_RelEN.CourseName = objRow[convTeachingCaseResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objRow[convTeachingCaseResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objRow[convTeachingCaseResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCase_Resource_RelEN.IdResource = objRow[convTeachingCaseResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCase_Resource_RelEN.IdFile = objRow[convTeachingCaseResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCase_Resource_RelEN.FileName = objRow[convTeachingCaseResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCase_Resource_RelEN.FileType = objRow[convTeachingCaseResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objRow[convTeachingCaseResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileSize = objRow[convTeachingCaseResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objRow[convTeachingCaseResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objRow[convTeachingCaseResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCase_Resource_RelEN.FileRename = objRow[convTeachingCaseResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objRow[convTeachingCaseResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objRow[convTeachingCaseResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objRow[convTeachingCaseResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objRow[convTeachingCaseResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objRow[convTeachingCaseResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCase_Resource_RelEN.Memo = objRow[convTeachingCaseResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstByIdMicroteachCaseResourceRelLstCache(List<long> arrIdMicroteachCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsvTeachingCaseResCase_Resource_RelEN._CurrTabName);
List<clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLst_Sel =
arrvTeachingCaseResCase_Resource_RelObjLstCache
.Where(x => arrIdMicroteachCaseResourceRelLst.Contains(x.IdMicroteachCaseResourceRel));
return arrvTeachingCaseResCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = new List<clsvTeachingCaseResCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = new clsvTeachingCaseResCase_Resource_RelEN();
try
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objRow[convTeachingCaseResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objRow[convTeachingCaseResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objRow[convTeachingCaseResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objRow[convTeachingCaseResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_Resource_RelEN.MajorID = objRow[convTeachingCaseResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_Resource_RelEN.MajorName = objRow[convTeachingCaseResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_Resource_RelEN.CourseId = objRow[convTeachingCaseResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objRow[convTeachingCaseResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_Resource_RelEN.CourseName = objRow[convTeachingCaseResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objRow[convTeachingCaseResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objRow[convTeachingCaseResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCase_Resource_RelEN.IdResource = objRow[convTeachingCaseResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCase_Resource_RelEN.IdFile = objRow[convTeachingCaseResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCase_Resource_RelEN.FileName = objRow[convTeachingCaseResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCase_Resource_RelEN.FileType = objRow[convTeachingCaseResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objRow[convTeachingCaseResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileSize = objRow[convTeachingCaseResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objRow[convTeachingCaseResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objRow[convTeachingCaseResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCase_Resource_RelEN.FileRename = objRow[convTeachingCaseResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objRow[convTeachingCaseResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objRow[convTeachingCaseResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objRow[convTeachingCaseResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objRow[convTeachingCaseResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objRow[convTeachingCaseResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCase_Resource_RelEN.Memo = objRow[convTeachingCaseResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_Resource_RelEN);
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = new List<clsvTeachingCaseResCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = new clsvTeachingCaseResCase_Resource_RelEN();
try
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objRow[convTeachingCaseResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objRow[convTeachingCaseResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objRow[convTeachingCaseResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objRow[convTeachingCaseResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_Resource_RelEN.MajorID = objRow[convTeachingCaseResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_Resource_RelEN.MajorName = objRow[convTeachingCaseResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_Resource_RelEN.CourseId = objRow[convTeachingCaseResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objRow[convTeachingCaseResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_Resource_RelEN.CourseName = objRow[convTeachingCaseResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objRow[convTeachingCaseResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objRow[convTeachingCaseResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCase_Resource_RelEN.IdResource = objRow[convTeachingCaseResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCase_Resource_RelEN.IdFile = objRow[convTeachingCaseResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCase_Resource_RelEN.FileName = objRow[convTeachingCaseResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCase_Resource_RelEN.FileType = objRow[convTeachingCaseResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objRow[convTeachingCaseResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileSize = objRow[convTeachingCaseResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objRow[convTeachingCaseResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objRow[convTeachingCaseResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCase_Resource_RelEN.FileRename = objRow[convTeachingCaseResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objRow[convTeachingCaseResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objRow[convTeachingCaseResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objRow[convTeachingCaseResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objRow[convTeachingCaseResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objRow[convTeachingCaseResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCase_Resource_RelEN.Memo = objRow[convTeachingCaseResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachingCaseResCase_Resource_RelEN> GetSubObjLstCache(clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelCond)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingCaseResCase_Resource_Rel.AttributeName)
{
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCase_Resource_RelCond[strFldName]));
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = new List<clsvTeachingCaseResCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = new clsvTeachingCaseResCase_Resource_RelEN();
try
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objRow[convTeachingCaseResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objRow[convTeachingCaseResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objRow[convTeachingCaseResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objRow[convTeachingCaseResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_Resource_RelEN.MajorID = objRow[convTeachingCaseResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_Resource_RelEN.MajorName = objRow[convTeachingCaseResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_Resource_RelEN.CourseId = objRow[convTeachingCaseResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objRow[convTeachingCaseResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_Resource_RelEN.CourseName = objRow[convTeachingCaseResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objRow[convTeachingCaseResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objRow[convTeachingCaseResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCase_Resource_RelEN.IdResource = objRow[convTeachingCaseResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCase_Resource_RelEN.IdFile = objRow[convTeachingCaseResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCase_Resource_RelEN.FileName = objRow[convTeachingCaseResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCase_Resource_RelEN.FileType = objRow[convTeachingCaseResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objRow[convTeachingCaseResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileSize = objRow[convTeachingCaseResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objRow[convTeachingCaseResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objRow[convTeachingCaseResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCase_Resource_RelEN.FileRename = objRow[convTeachingCaseResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objRow[convTeachingCaseResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objRow[convTeachingCaseResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objRow[convTeachingCaseResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objRow[convTeachingCaseResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objRow[convTeachingCaseResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCase_Resource_RelEN.Memo = objRow[convTeachingCaseResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_Resource_RelEN);
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = new List<clsvTeachingCaseResCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = new clsvTeachingCaseResCase_Resource_RelEN();
try
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objRow[convTeachingCaseResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objRow[convTeachingCaseResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objRow[convTeachingCaseResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objRow[convTeachingCaseResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_Resource_RelEN.MajorID = objRow[convTeachingCaseResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_Resource_RelEN.MajorName = objRow[convTeachingCaseResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_Resource_RelEN.CourseId = objRow[convTeachingCaseResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objRow[convTeachingCaseResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_Resource_RelEN.CourseName = objRow[convTeachingCaseResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objRow[convTeachingCaseResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objRow[convTeachingCaseResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCase_Resource_RelEN.IdResource = objRow[convTeachingCaseResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCase_Resource_RelEN.IdFile = objRow[convTeachingCaseResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCase_Resource_RelEN.FileName = objRow[convTeachingCaseResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCase_Resource_RelEN.FileType = objRow[convTeachingCaseResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objRow[convTeachingCaseResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileSize = objRow[convTeachingCaseResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objRow[convTeachingCaseResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objRow[convTeachingCaseResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCase_Resource_RelEN.FileRename = objRow[convTeachingCaseResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objRow[convTeachingCaseResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objRow[convTeachingCaseResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objRow[convTeachingCaseResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objRow[convTeachingCaseResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objRow[convTeachingCaseResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCase_Resource_RelEN.Memo = objRow[convTeachingCaseResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_Resource_RelEN);
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
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = new List<clsvTeachingCaseResCase_Resource_RelEN>(); 
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
	clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = new clsvTeachingCaseResCase_Resource_RelEN();
try
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objRow[convTeachingCaseResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objRow[convTeachingCaseResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objRow[convTeachingCaseResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objRow[convTeachingCaseResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_Resource_RelEN.MajorID = objRow[convTeachingCaseResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_Resource_RelEN.MajorName = objRow[convTeachingCaseResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_Resource_RelEN.CourseId = objRow[convTeachingCaseResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objRow[convTeachingCaseResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_Resource_RelEN.CourseName = objRow[convTeachingCaseResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objRow[convTeachingCaseResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objRow[convTeachingCaseResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCase_Resource_RelEN.IdResource = objRow[convTeachingCaseResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCase_Resource_RelEN.IdFile = objRow[convTeachingCaseResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCase_Resource_RelEN.FileName = objRow[convTeachingCaseResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCase_Resource_RelEN.FileType = objRow[convTeachingCaseResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objRow[convTeachingCaseResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileSize = objRow[convTeachingCaseResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objRow[convTeachingCaseResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objRow[convTeachingCaseResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCase_Resource_RelEN.FileRename = objRow[convTeachingCaseResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objRow[convTeachingCaseResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objRow[convTeachingCaseResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objRow[convTeachingCaseResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objRow[convTeachingCaseResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objRow[convTeachingCaseResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCase_Resource_RelEN.Memo = objRow[convTeachingCaseResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_Resource_RelEN);
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = new List<clsvTeachingCaseResCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = new clsvTeachingCaseResCase_Resource_RelEN();
try
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objRow[convTeachingCaseResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objRow[convTeachingCaseResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objRow[convTeachingCaseResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objRow[convTeachingCaseResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_Resource_RelEN.MajorID = objRow[convTeachingCaseResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_Resource_RelEN.MajorName = objRow[convTeachingCaseResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_Resource_RelEN.CourseId = objRow[convTeachingCaseResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objRow[convTeachingCaseResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_Resource_RelEN.CourseName = objRow[convTeachingCaseResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objRow[convTeachingCaseResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objRow[convTeachingCaseResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCase_Resource_RelEN.IdResource = objRow[convTeachingCaseResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCase_Resource_RelEN.IdFile = objRow[convTeachingCaseResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCase_Resource_RelEN.FileName = objRow[convTeachingCaseResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCase_Resource_RelEN.FileType = objRow[convTeachingCaseResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objRow[convTeachingCaseResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileSize = objRow[convTeachingCaseResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objRow[convTeachingCaseResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objRow[convTeachingCaseResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCase_Resource_RelEN.FileRename = objRow[convTeachingCaseResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objRow[convTeachingCaseResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objRow[convTeachingCaseResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objRow[convTeachingCaseResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objRow[convTeachingCaseResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objRow[convTeachingCaseResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCase_Resource_RelEN.Memo = objRow[convTeachingCaseResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = new List<clsvTeachingCaseResCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = new clsvTeachingCaseResCase_Resource_RelEN();
try
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objRow[convTeachingCaseResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objRow[convTeachingCaseResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objRow[convTeachingCaseResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objRow[convTeachingCaseResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_Resource_RelEN.MajorID = objRow[convTeachingCaseResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_Resource_RelEN.MajorName = objRow[convTeachingCaseResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_Resource_RelEN.CourseId = objRow[convTeachingCaseResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objRow[convTeachingCaseResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_Resource_RelEN.CourseName = objRow[convTeachingCaseResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objRow[convTeachingCaseResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objRow[convTeachingCaseResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCase_Resource_RelEN.IdResource = objRow[convTeachingCaseResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCase_Resource_RelEN.IdFile = objRow[convTeachingCaseResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCase_Resource_RelEN.FileName = objRow[convTeachingCaseResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCase_Resource_RelEN.FileType = objRow[convTeachingCaseResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objRow[convTeachingCaseResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileSize = objRow[convTeachingCaseResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objRow[convTeachingCaseResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objRow[convTeachingCaseResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCase_Resource_RelEN.FileRename = objRow[convTeachingCaseResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objRow[convTeachingCaseResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objRow[convTeachingCaseResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objRow[convTeachingCaseResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objRow[convTeachingCaseResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objRow[convTeachingCaseResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCase_Resource_RelEN.Memo = objRow[convTeachingCaseResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_Resource_RelEN);
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
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = new List<clsvTeachingCaseResCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = new clsvTeachingCaseResCase_Resource_RelEN();
try
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objRow[convTeachingCaseResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objRow[convTeachingCaseResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objRow[convTeachingCaseResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objRow[convTeachingCaseResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_Resource_RelEN.MajorID = objRow[convTeachingCaseResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_Resource_RelEN.MajorName = objRow[convTeachingCaseResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_Resource_RelEN.CourseId = objRow[convTeachingCaseResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objRow[convTeachingCaseResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_Resource_RelEN.CourseName = objRow[convTeachingCaseResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objRow[convTeachingCaseResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objRow[convTeachingCaseResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCase_Resource_RelEN.IdResource = objRow[convTeachingCaseResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCase_Resource_RelEN.IdFile = objRow[convTeachingCaseResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCase_Resource_RelEN.FileName = objRow[convTeachingCaseResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCase_Resource_RelEN.FileType = objRow[convTeachingCaseResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objRow[convTeachingCaseResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileSize = objRow[convTeachingCaseResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objRow[convTeachingCaseResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objRow[convTeachingCaseResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCase_Resource_RelEN.FileRename = objRow[convTeachingCaseResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objRow[convTeachingCaseResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objRow[convTeachingCaseResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objRow[convTeachingCaseResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objRow[convTeachingCaseResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objRow[convTeachingCaseResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCase_Resource_RelEN.Memo = objRow[convTeachingCaseResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLst = new List<clsvTeachingCaseResCase_Resource_RelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = new clsvTeachingCaseResCase_Resource_RelEN();
try
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objRow[convTeachingCaseResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objRow[convTeachingCaseResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objRow[convTeachingCaseResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objRow[convTeachingCaseResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objRow[convTeachingCaseResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_Resource_RelEN.MajorID = objRow[convTeachingCaseResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_Resource_RelEN.MajorName = objRow[convTeachingCaseResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_Resource_RelEN.CourseId = objRow[convTeachingCaseResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objRow[convTeachingCaseResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_Resource_RelEN.CourseName = objRow[convTeachingCaseResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objRow[convTeachingCaseResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objRow[convTeachingCaseResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCase_Resource_RelEN.IdResource = objRow[convTeachingCaseResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCase_Resource_RelEN.IdFile = objRow[convTeachingCaseResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCase_Resource_RelEN.FileName = objRow[convTeachingCaseResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCase_Resource_RelEN.FileType = objRow[convTeachingCaseResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objRow[convTeachingCaseResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileSize = objRow[convTeachingCaseResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objRow[convTeachingCaseResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objRow[convTeachingCaseResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCase_Resource_RelEN.FileRename = objRow[convTeachingCaseResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objRow[convTeachingCaseResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objRow[convTeachingCaseResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objRow[convTeachingCaseResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objRow[convTeachingCaseResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objRow[convTeachingCaseResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCase_Resource_RelEN.Memo = objRow[convTeachingCaseResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCase_Resource_RelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachingCaseResCase_Resource_Rel(ref clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN)
{
bool bolResult = vTeachingCaseResCase_Resource_RelDA.GetvTeachingCaseResCase_Resource_Rel(ref objvTeachingCaseResCase_Resource_RelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = vTeachingCaseResCase_Resource_RelDA.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
return objvTeachingCaseResCase_Resource_RelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachingCaseResCase_Resource_RelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = vTeachingCaseResCase_Resource_RelDA.GetFirstObj(strWhereCond);
 return objvTeachingCaseResCase_Resource_RelEN;
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
public static clsvTeachingCaseResCase_Resource_RelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = vTeachingCaseResCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objvTeachingCaseResCase_Resource_RelEN;
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
public static clsvTeachingCaseResCase_Resource_RelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN = vTeachingCaseResCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objvTeachingCaseResCase_Resource_RelEN;
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
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <param name = "lstvTeachingCaseResCase_Resource_RelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRelFromList(long lngIdMicroteachCaseResourceRel, List<clsvTeachingCaseResCase_Resource_RelEN> lstvTeachingCaseResCase_Resource_RelObjLst)
{
foreach (clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN in lstvTeachingCaseResCase_Resource_RelObjLst)
{
if (objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel)
{
return objvTeachingCaseResCase_Resource_RelEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngIdMicroteachCaseResourceRel;
 try
 {
 lngIdMicroteachCaseResourceRel = new clsvTeachingCaseResCase_Resource_RelDA().GetFirstID(strWhereCond);
 return lngIdMicroteachCaseResourceRel;
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
 arrList = vTeachingCaseResCase_Resource_RelDA.GetID(strWhereCond);
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
bool bolIsExist = vTeachingCaseResCase_Resource_RelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachCaseResourceRel)
{
//检测记录是否存在
bool bolIsExist = vTeachingCaseResCase_Resource_RelDA.IsExist(lngIdMicroteachCaseResourceRel);
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
 bolIsExist = clsvTeachingCaseResCase_Resource_RelDA.IsExistTable();
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
 bolIsExist = vTeachingCaseResCase_Resource_RelDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeachingCaseResCase_Resource_RelENS">源对象</param>
 /// <param name = "objvTeachingCaseResCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelENS, clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelENT)
{
try
{
objvTeachingCaseResCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvTeachingCaseResCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvTeachingCaseResCase_Resource_RelENT.FuncModuleId = objvTeachingCaseResCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCase_Resource_RelENT.FuncModuleName = objvTeachingCaseResCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCase_Resource_RelENT.IdMicroteachCase = objvTeachingCaseResCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseID = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseName = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTheme = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseText = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseDate = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTime = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCase_Resource_RelENT.IdTeachingCaseResCaseType = objvTeachingCaseResCase_Resource_RelENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCase_Resource_RelENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCase_Resource_RelENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCase_Resource_RelENT.OwnerId = objvTeachingCaseResCase_Resource_RelENS.OwnerId; //拥有者Id
objvTeachingCaseResCase_Resource_RelENT.OwnerName = objvTeachingCaseResCase_Resource_RelENS.OwnerName; //拥有者姓名
objvTeachingCaseResCase_Resource_RelENT.OwnerNameWithId = objvTeachingCaseResCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvTeachingCaseResCase_Resource_RelENT.IdStudyLevel = objvTeachingCaseResCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvTeachingCaseResCase_Resource_RelENT.StudyLevelName = objvTeachingCaseResCase_Resource_RelENS.StudyLevelName; //学段名称
objvTeachingCaseResCase_Resource_RelENT.IdTeachingPlan = objvTeachingCaseResCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvTeachingCaseResCase_Resource_RelENT.IdDiscipline = objvTeachingCaseResCase_Resource_RelENS.IdDiscipline; //学科流水号
objvTeachingCaseResCase_Resource_RelENT.DisciplineID = objvTeachingCaseResCase_Resource_RelENS.DisciplineID; //学科ID
objvTeachingCaseResCase_Resource_RelENT.DisciplineName = objvTeachingCaseResCase_Resource_RelENS.DisciplineName; //学科名称
objvTeachingCaseResCase_Resource_RelENT.senateGaugeVersionID = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCase_Resource_RelENT.senateGaugeVersionName = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCase_Resource_RelENT.senateGaugeVersionTtlScore = objvTeachingCaseResCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCase_Resource_RelENT.VersionNo = objvTeachingCaseResCase_Resource_RelENS.VersionNo; //版本号
objvTeachingCaseResCase_Resource_RelENT.IdTeachSkill = objvTeachingCaseResCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvTeachingCaseResCase_Resource_RelENT.TeachSkillID = objvTeachingCaseResCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCase_Resource_RelENT.SkillTypeName = objvTeachingCaseResCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCase_Resource_RelENT.TeachSkillName = objvTeachingCaseResCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCase_Resource_RelENT.TeachSkillTheory = objvTeachingCaseResCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCase_Resource_RelENT.TeachSkillOperMethod = objvTeachingCaseResCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCase_Resource_RelENT.IdSkillType = objvTeachingCaseResCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvTeachingCaseResCase_Resource_RelENT.SkillTypeID = objvTeachingCaseResCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCase_Resource_RelENT.CaseLevelId = objvTeachingCaseResCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCase_Resource_RelENT.IsDualVideo = objvTeachingCaseResCase_Resource_RelENS.IsDualVideo; //是否双视频
objvTeachingCaseResCase_Resource_RelENT.IdXzCollege = objvTeachingCaseResCase_Resource_RelENS.IdXzCollege; //学院流水号
objvTeachingCaseResCase_Resource_RelENT.CollegeID = objvTeachingCaseResCase_Resource_RelENS.CollegeID; //学院ID
objvTeachingCaseResCase_Resource_RelENT.CollegeName = objvTeachingCaseResCase_Resource_RelENS.CollegeName; //学院名称
objvTeachingCaseResCase_Resource_RelENT.IdXzMajor = objvTeachingCaseResCase_Resource_RelENS.IdXzMajor; //专业流水号
objvTeachingCaseResCase_Resource_RelENT.MajorID = objvTeachingCaseResCase_Resource_RelENS.MajorID; //专业ID
objvTeachingCaseResCase_Resource_RelENT.MajorName = objvTeachingCaseResCase_Resource_RelENS.MajorName; //专业名称
objvTeachingCaseResCase_Resource_RelENT.CourseId = objvTeachingCaseResCase_Resource_RelENS.CourseId; //课程Id
objvTeachingCaseResCase_Resource_RelENT.CourseCode = objvTeachingCaseResCase_Resource_RelENS.CourseCode; //课程代码
objvTeachingCaseResCase_Resource_RelENT.CourseName = objvTeachingCaseResCase_Resource_RelENS.CourseName; //课程名称
objvTeachingCaseResCase_Resource_RelENT.CourseChapterId = objvTeachingCaseResCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvTeachingCaseResCase_Resource_RelENT.CourseChapterName = objvTeachingCaseResCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvTeachingCaseResCase_Resource_RelENT.ParentNodeID = objvTeachingCaseResCase_Resource_RelENS.ParentNodeID; //父节点编号
objvTeachingCaseResCase_Resource_RelENT.ParentNodeName = objvTeachingCaseResCase_Resource_RelENS.ParentNodeName; //父节点名称
objvTeachingCaseResCase_Resource_RelENT.ViewCount = objvTeachingCaseResCase_Resource_RelENS.ViewCount; //浏览量
objvTeachingCaseResCase_Resource_RelENT.IsShow = objvTeachingCaseResCase_Resource_RelENS.IsShow; //是否启用
objvTeachingCaseResCase_Resource_RelENT.DownloadNumber = objvTeachingCaseResCase_Resource_RelENS.DownloadNumber; //下载数目
objvTeachingCaseResCase_Resource_RelENT.FileIntegration = objvTeachingCaseResCase_Resource_RelENS.FileIntegration; //文件积分
objvTeachingCaseResCase_Resource_RelENT.LikeCount = objvTeachingCaseResCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvTeachingCaseResCase_Resource_RelENT.CollectionCount = objvTeachingCaseResCase_Resource_RelENS.CollectionCount; //收藏数量
objvTeachingCaseResCase_Resource_RelENT.RecommendedDegreeId = objvTeachingCaseResCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvTeachingCaseResCase_Resource_RelENT.RecommendedDegreeName = objvTeachingCaseResCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvTeachingCaseResCase_Resource_RelENT.BrowseCount4Case = objvTeachingCaseResCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvTeachingCaseResCase_Resource_RelENT.IdResource = objvTeachingCaseResCase_Resource_RelENS.IdResource; //资源流水号
objvTeachingCaseResCase_Resource_RelENT.ResourceID = objvTeachingCaseResCase_Resource_RelENS.ResourceID; //资源ID
objvTeachingCaseResCase_Resource_RelENT.ResourceName = objvTeachingCaseResCase_Resource_RelENS.ResourceName; //资源名称
objvTeachingCaseResCase_Resource_RelENT.IdFtpResource = objvTeachingCaseResCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvTeachingCaseResCase_Resource_RelENT.IdFile = objvTeachingCaseResCase_Resource_RelENS.IdFile; //文件流水号
objvTeachingCaseResCase_Resource_RelENT.FileName = objvTeachingCaseResCase_Resource_RelENS.FileName; //文件名称
objvTeachingCaseResCase_Resource_RelENT.FileType = objvTeachingCaseResCase_Resource_RelENS.FileType; //文件类型
objvTeachingCaseResCase_Resource_RelENT.SaveDate = objvTeachingCaseResCase_Resource_RelENS.SaveDate; //创建日期
objvTeachingCaseResCase_Resource_RelENT.FileSize = objvTeachingCaseResCase_Resource_RelENS.FileSize; //文件大小
objvTeachingCaseResCase_Resource_RelENT.SaveTime = objvTeachingCaseResCase_Resource_RelENS.SaveTime; //创建时间
objvTeachingCaseResCase_Resource_RelENT.FtpResourceID = objvTeachingCaseResCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvTeachingCaseResCase_Resource_RelENT.FileOriginalName = objvTeachingCaseResCase_Resource_RelENS.FileOriginalName; //文件原名
objvTeachingCaseResCase_Resource_RelENT.FileDirName = objvTeachingCaseResCase_Resource_RelENS.FileDirName; //文件目录名
objvTeachingCaseResCase_Resource_RelENT.FileRename = objvTeachingCaseResCase_Resource_RelENS.FileRename; //文件新名
objvTeachingCaseResCase_Resource_RelENT.FileUpDate = objvTeachingCaseResCase_Resource_RelENS.FileUpDate; //创建日期
objvTeachingCaseResCase_Resource_RelENT.FileUpTime = objvTeachingCaseResCase_Resource_RelENS.FileUpTime; //创建时间
objvTeachingCaseResCase_Resource_RelENT.SaveMode = objvTeachingCaseResCase_Resource_RelENS.SaveMode; //文件存放方式
objvTeachingCaseResCase_Resource_RelENT.IdResourceType = objvTeachingCaseResCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvTeachingCaseResCase_Resource_RelENT.ResourceTypeID = objvTeachingCaseResCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvTeachingCaseResCase_Resource_RelENT.ResourceTypeName = objvTeachingCaseResCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvTeachingCaseResCase_Resource_RelENT.ResourceOwner = objvTeachingCaseResCase_Resource_RelENS.ResourceOwner; //上传者
objvTeachingCaseResCase_Resource_RelENT.ftpFileType = objvTeachingCaseResCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvTeachingCaseResCase_Resource_RelENT.ftpFileSize = objvTeachingCaseResCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvTeachingCaseResCase_Resource_RelENT.ftpResourceOwner = objvTeachingCaseResCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachingCaseResCase_Resource_RelENT.FileOriginName = objvTeachingCaseResCase_Resource_RelENS.FileOriginName; //原文件名
objvTeachingCaseResCase_Resource_RelENT.IsExistFile = objvTeachingCaseResCase_Resource_RelENS.IsExistFile; //是否存在文件
objvTeachingCaseResCase_Resource_RelENT.FileNewName = objvTeachingCaseResCase_Resource_RelENS.FileNewName; //新文件名
objvTeachingCaseResCase_Resource_RelENT.FileOldName = objvTeachingCaseResCase_Resource_RelENS.FileOldName; //旧文件名
objvTeachingCaseResCase_Resource_RelENT.IsMain = objvTeachingCaseResCase_Resource_RelENS.IsMain; //是否主资源
objvTeachingCaseResCase_Resource_RelENT.IdUsingMode = objvTeachingCaseResCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvTeachingCaseResCase_Resource_RelENT.IsVisible = objvTeachingCaseResCase_Resource_RelENS.IsVisible; //是否显示
objvTeachingCaseResCase_Resource_RelENT.IndexNO = objvTeachingCaseResCase_Resource_RelENS.IndexNO; //序号
objvTeachingCaseResCase_Resource_RelENT.BrowseCount = objvTeachingCaseResCase_Resource_RelENS.BrowseCount; //浏览次数
objvTeachingCaseResCase_Resource_RelENT.UpdDate = objvTeachingCaseResCase_Resource_RelENS.UpdDate; //修改日期
objvTeachingCaseResCase_Resource_RelENT.UpdUser = objvTeachingCaseResCase_Resource_RelENS.UpdUser; //修改人
objvTeachingCaseResCase_Resource_RelENT.Memo = objvTeachingCaseResCase_Resource_RelENS.Memo; //备注
objvTeachingCaseResCase_Resource_RelENT.CollegeNameA = objvTeachingCaseResCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCase_Resource_RelENT.CourseChapterReferred = objvTeachingCaseResCase_Resource_RelENS.CourseChapterReferred; //节简称
objvTeachingCaseResCase_Resource_RelENT.ParentNodeReferred = objvTeachingCaseResCase_Resource_RelENS.ParentNodeReferred; //章简称
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
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN)
{
try
{
objvTeachingCaseResCase_Resource_RelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachingCaseResCase_Resource_RelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel = objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FuncModuleId = objvTeachingCaseResCase_Resource_RelEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = objvTeachingCaseResCase_Resource_RelEN.FuncModuleName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase = objvTeachingCaseResCase_Resource_RelEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID; //教学案例资源案例ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName; //教学案例资源案例名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme; //教学案例资源案例主题词
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText; //案例文本内容
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate; //视频资源日期
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime; //视频资源时间
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdTeachingCaseResCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType; //教学案例资源类型流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachingCaseResCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.OwnerId = objvTeachingCaseResCase_Resource_RelEN.OwnerId == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.OwnerName = objvTeachingCaseResCase_Resource_RelEN.OwnerName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = objvTeachingCaseResCase_Resource_RelEN.StudyLevelName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = objvTeachingCaseResCase_Resource_RelEN.IdDiscipline == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.DisciplineID = objvTeachingCaseResCase_Resource_RelEN.DisciplineID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.DisciplineName = objvTeachingCaseResCase_Resource_RelEN.DisciplineName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore = objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.VersionNo = objvTeachingCaseResCase_Resource_RelEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = objvTeachingCaseResCase_Resource_RelEN.TeachSkillID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = objvTeachingCaseResCase_Resource_RelEN.SkillTypeName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = objvTeachingCaseResCase_Resource_RelEN.TeachSkillName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdSkillType = objvTeachingCaseResCase_Resource_RelEN.IdSkillType == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = objvTeachingCaseResCase_Resource_RelEN.SkillTypeID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = objvTeachingCaseResCase_Resource_RelEN.CaseLevelId == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IsDualVideo = objvTeachingCaseResCase_Resource_RelEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = objvTeachingCaseResCase_Resource_RelEN.IdXzCollege == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CollegeID = objvTeachingCaseResCase_Resource_RelEN.CollegeID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CollegeName = objvTeachingCaseResCase_Resource_RelEN.CollegeName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = objvTeachingCaseResCase_Resource_RelEN.IdXzMajor == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.MajorID = objvTeachingCaseResCase_Resource_RelEN.MajorID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.MajorName = objvTeachingCaseResCase_Resource_RelEN.MajorName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CourseId = objvTeachingCaseResCase_Resource_RelEN.CourseId == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CourseCode = objvTeachingCaseResCase_Resource_RelEN.CourseCode == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CourseName = objvTeachingCaseResCase_Resource_RelEN.CourseName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = objvTeachingCaseResCase_Resource_RelEN.CourseChapterId == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = objvTeachingCaseResCase_Resource_RelEN.CourseChapterName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ParentNodeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = objvTeachingCaseResCase_Resource_RelEN.ParentNodeID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ParentNodeID; //父节点编号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = objvTeachingCaseResCase_Resource_RelEN.ParentNodeName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ViewCount = objvTeachingCaseResCase_Resource_RelEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IsShow = objvTeachingCaseResCase_Resource_RelEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.DownloadNumber = objvTeachingCaseResCase_Resource_RelEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileIntegration = objvTeachingCaseResCase_Resource_RelEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.LikeCount = objvTeachingCaseResCase_Resource_RelEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CollectionCount = objvTeachingCaseResCase_Resource_RelEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case = objvTeachingCaseResCase_Resource_RelEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdResource = objvTeachingCaseResCase_Resource_RelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ResourceID = objvTeachingCaseResCase_Resource_RelEN.ResourceID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ResourceName = objvTeachingCaseResCase_Resource_RelEN.ResourceName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = objvTeachingCaseResCase_Resource_RelEN.IdFtpResource == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdFile = objvTeachingCaseResCase_Resource_RelEN.IdFile == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileName = objvTeachingCaseResCase_Resource_RelEN.FileName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileName; //文件名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileType = objvTeachingCaseResCase_Resource_RelEN.FileType == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileType; //文件类型
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.SaveDate = objvTeachingCaseResCase_Resource_RelEN.SaveDate == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileSize = objvTeachingCaseResCase_Resource_RelEN.FileSize == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.SaveTime = objvTeachingCaseResCase_Resource_RelEN.SaveTime == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = objvTeachingCaseResCase_Resource_RelEN.FtpResourceID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = objvTeachingCaseResCase_Resource_RelEN.FileOriginalName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileDirName = objvTeachingCaseResCase_Resource_RelEN.FileDirName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileRename = objvTeachingCaseResCase_Resource_RelEN.FileRename == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileUpDate = objvTeachingCaseResCase_Resource_RelEN.FileUpDate == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileUpTime = objvTeachingCaseResCase_Resource_RelEN.FileUpTime == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.SaveMode = objvTeachingCaseResCase_Resource_RelEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdResourceType = objvTeachingCaseResCase_Resource_RelEN.IdResourceType == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = objvTeachingCaseResCase_Resource_RelEN.ResourceOwner == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ftpFileType = objvTeachingCaseResCase_Resource_RelEN.ftpFileType == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = objvTeachingCaseResCase_Resource_RelEN.ftpFileSize == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileOriginName = objvTeachingCaseResCase_Resource_RelEN.FileOriginName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IsExistFile = objvTeachingCaseResCase_Resource_RelEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileNewName = objvTeachingCaseResCase_Resource_RelEN.FileNewName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.FileOldName = objvTeachingCaseResCase_Resource_RelEN.FileOldName == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IsMain = objvTeachingCaseResCase_Resource_RelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IdUsingMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = objvTeachingCaseResCase_Resource_RelEN.IdUsingMode == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.IdUsingMode; //资源使用模式流水号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IsVisible = objvTeachingCaseResCase_Resource_RelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.IndexNO = objvTeachingCaseResCase_Resource_RelEN.IndexNO; //序号
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.BrowseCount = objvTeachingCaseResCase_Resource_RelEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.UpdDate = objvTeachingCaseResCase_Resource_RelEN.UpdDate == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.UpdUser = objvTeachingCaseResCase_Resource_RelEN.UpdUser == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.Memo = objvTeachingCaseResCase_Resource_RelEN.Memo == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.Memo; //备注
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = objvTeachingCaseResCase_Resource_RelEN.CollegeNameA == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convTeachingCaseResCase_Resource_Rel.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred == "[null]" ? null :  objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred; //章简称
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
 /// <param name = "objvTeachingCaseResCase_Resource_RelEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN)
{
try
{
if (objvTeachingCaseResCase_Resource_RelEN.FuncModuleName == "[null]") objvTeachingCaseResCase_Resource_RelEN.FuncModuleName = null; //功能模块名称
if (objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseID = null; //教学案例资源案例ID
if (objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseName = null; //教学案例资源案例名称
if (objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTheme = null; //教学案例资源案例主题词
if (objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseText = null; //案例文本内容
if (objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDate = null; //视频资源日期
if (objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTime = null; //视频资源时间
if (objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseDateIn = null; //案例入库日期
if (objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTimeIn = null; //案例入库时间
if (objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdTeachingCaseResCaseType = null; //教学案例资源类型流水号
if (objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachingCaseResCaseTypeName = null; //教学案例资源案例类型名称
if (objvTeachingCaseResCase_Resource_RelEN.OwnerId == "[null]") objvTeachingCaseResCase_Resource_RelEN.OwnerId = null; //拥有者Id
if (objvTeachingCaseResCase_Resource_RelEN.OwnerName == "[null]") objvTeachingCaseResCase_Resource_RelEN.OwnerName = null; //拥有者姓名
if (objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId == "[null]") objvTeachingCaseResCase_Resource_RelEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdStudyLevel = null; //id_StudyLevel
if (objvTeachingCaseResCase_Resource_RelEN.StudyLevelName == "[null]") objvTeachingCaseResCase_Resource_RelEN.StudyLevelName = null; //学段名称
if (objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdTeachingPlan = null; //教案流水号
if (objvTeachingCaseResCase_Resource_RelEN.IdDiscipline == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdDiscipline = null; //学科流水号
if (objvTeachingCaseResCase_Resource_RelEN.DisciplineID == "[null]") objvTeachingCaseResCase_Resource_RelEN.DisciplineID = null; //学科ID
if (objvTeachingCaseResCase_Resource_RelEN.DisciplineName == "[null]") objvTeachingCaseResCase_Resource_RelEN.DisciplineName = null; //学科名称
if (objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID == "[null]") objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName == "[null]") objvTeachingCaseResCase_Resource_RelEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdTeachSkill = null; //教学技能流水号
if (objvTeachingCaseResCase_Resource_RelEN.TeachSkillID == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachSkillID = null; //教学技能ID
if (objvTeachingCaseResCase_Resource_RelEN.SkillTypeName == "[null]") objvTeachingCaseResCase_Resource_RelEN.SkillTypeName = null; //技能类型名称
if (objvTeachingCaseResCase_Resource_RelEN.TeachSkillName == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachSkillName = null; //教学技能名称
if (objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod == "[null]") objvTeachingCaseResCase_Resource_RelEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvTeachingCaseResCase_Resource_RelEN.IdSkillType == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdSkillType = null; //技能类型流水号
if (objvTeachingCaseResCase_Resource_RelEN.SkillTypeID == "[null]") objvTeachingCaseResCase_Resource_RelEN.SkillTypeID = null; //技能类型ID
if (objvTeachingCaseResCase_Resource_RelEN.CaseLevelId == "[null]") objvTeachingCaseResCase_Resource_RelEN.CaseLevelId = null; //课例等级Id
if (objvTeachingCaseResCase_Resource_RelEN.IdXzCollege == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdXzCollege = null; //学院流水号
if (objvTeachingCaseResCase_Resource_RelEN.CollegeID == "[null]") objvTeachingCaseResCase_Resource_RelEN.CollegeID = null; //学院ID
if (objvTeachingCaseResCase_Resource_RelEN.CollegeName == "[null]") objvTeachingCaseResCase_Resource_RelEN.CollegeName = null; //学院名称
if (objvTeachingCaseResCase_Resource_RelEN.IdXzMajor == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdXzMajor = null; //专业流水号
if (objvTeachingCaseResCase_Resource_RelEN.MajorID == "[null]") objvTeachingCaseResCase_Resource_RelEN.MajorID = null; //专业ID
if (objvTeachingCaseResCase_Resource_RelEN.MajorName == "[null]") objvTeachingCaseResCase_Resource_RelEN.MajorName = null; //专业名称
if (objvTeachingCaseResCase_Resource_RelEN.CourseId == "[null]") objvTeachingCaseResCase_Resource_RelEN.CourseId = null; //课程Id
if (objvTeachingCaseResCase_Resource_RelEN.CourseCode == "[null]") objvTeachingCaseResCase_Resource_RelEN.CourseCode = null; //课程代码
if (objvTeachingCaseResCase_Resource_RelEN.CourseName == "[null]") objvTeachingCaseResCase_Resource_RelEN.CourseName = null; //课程名称
if (objvTeachingCaseResCase_Resource_RelEN.CourseChapterId == "[null]") objvTeachingCaseResCase_Resource_RelEN.CourseChapterId = null; //课程章节ID
if (objvTeachingCaseResCase_Resource_RelEN.CourseChapterName == "[null]") objvTeachingCaseResCase_Resource_RelEN.CourseChapterName = null; //课程章节名称
if (objvTeachingCaseResCase_Resource_RelEN.ParentNodeID == "[null]") objvTeachingCaseResCase_Resource_RelEN.ParentNodeID = null; //父节点编号
if (objvTeachingCaseResCase_Resource_RelEN.ParentNodeName == "[null]") objvTeachingCaseResCase_Resource_RelEN.ParentNodeName = null; //父节点名称
if (objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId == "[null]") objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeId = null; //推荐度Id
if (objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName == "[null]") objvTeachingCaseResCase_Resource_RelEN.RecommendedDegreeName = null; //推荐度名称
if (objvTeachingCaseResCase_Resource_RelEN.ResourceID == "[null]") objvTeachingCaseResCase_Resource_RelEN.ResourceID = null; //资源ID
if (objvTeachingCaseResCase_Resource_RelEN.ResourceName == "[null]") objvTeachingCaseResCase_Resource_RelEN.ResourceName = null; //资源名称
if (objvTeachingCaseResCase_Resource_RelEN.IdFtpResource == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdFtpResource = null; //FTP资源流水号
if (objvTeachingCaseResCase_Resource_RelEN.IdFile == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdFile = null; //文件流水号
if (objvTeachingCaseResCase_Resource_RelEN.FileName == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileName = null; //文件名称
if (objvTeachingCaseResCase_Resource_RelEN.FileType == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileType = null; //文件类型
if (objvTeachingCaseResCase_Resource_RelEN.SaveDate == "[null]") objvTeachingCaseResCase_Resource_RelEN.SaveDate = null; //创建日期
if (objvTeachingCaseResCase_Resource_RelEN.FileSize == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileSize = null; //文件大小
if (objvTeachingCaseResCase_Resource_RelEN.SaveTime == "[null]") objvTeachingCaseResCase_Resource_RelEN.SaveTime = null; //创建时间
if (objvTeachingCaseResCase_Resource_RelEN.FtpResourceID == "[null]") objvTeachingCaseResCase_Resource_RelEN.FtpResourceID = null; //FTP资源ID
if (objvTeachingCaseResCase_Resource_RelEN.FileOriginalName == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileOriginalName = null; //文件原名
if (objvTeachingCaseResCase_Resource_RelEN.FileDirName == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileDirName = null; //文件目录名
if (objvTeachingCaseResCase_Resource_RelEN.FileRename == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileRename = null; //文件新名
if (objvTeachingCaseResCase_Resource_RelEN.FileUpDate == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileUpDate = null; //创建日期
if (objvTeachingCaseResCase_Resource_RelEN.FileUpTime == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileUpTime = null; //创建时间
if (objvTeachingCaseResCase_Resource_RelEN.IdResourceType == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdResourceType = null; //资源类型流水号
if (objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID == "[null]") objvTeachingCaseResCase_Resource_RelEN.ResourceTypeID = null; //资源类型ID
if (objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName == "[null]") objvTeachingCaseResCase_Resource_RelEN.ResourceTypeName = null; //资源类型名称
if (objvTeachingCaseResCase_Resource_RelEN.ResourceOwner == "[null]") objvTeachingCaseResCase_Resource_RelEN.ResourceOwner = null; //上传者
if (objvTeachingCaseResCase_Resource_RelEN.ftpFileType == "[null]") objvTeachingCaseResCase_Resource_RelEN.ftpFileType = null; //ftp文件类型
if (objvTeachingCaseResCase_Resource_RelEN.ftpFileSize == "[null]") objvTeachingCaseResCase_Resource_RelEN.ftpFileSize = null; //ftp文件大小
if (objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner == "[null]") objvTeachingCaseResCase_Resource_RelEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvTeachingCaseResCase_Resource_RelEN.FileOriginName == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileOriginName = null; //原文件名
if (objvTeachingCaseResCase_Resource_RelEN.FileNewName == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileNewName = null; //新文件名
if (objvTeachingCaseResCase_Resource_RelEN.FileOldName == "[null]") objvTeachingCaseResCase_Resource_RelEN.FileOldName = null; //旧文件名
if (objvTeachingCaseResCase_Resource_RelEN.IdUsingMode == "[null]") objvTeachingCaseResCase_Resource_RelEN.IdUsingMode = null; //资源使用模式流水号
if (objvTeachingCaseResCase_Resource_RelEN.UpdDate == "[null]") objvTeachingCaseResCase_Resource_RelEN.UpdDate = null; //修改日期
if (objvTeachingCaseResCase_Resource_RelEN.UpdUser == "[null]") objvTeachingCaseResCase_Resource_RelEN.UpdUser = null; //修改人
if (objvTeachingCaseResCase_Resource_RelEN.Memo == "[null]") objvTeachingCaseResCase_Resource_RelEN.Memo = null; //备注
if (objvTeachingCaseResCase_Resource_RelEN.CollegeNameA == "[null]") objvTeachingCaseResCase_Resource_RelEN.CollegeNameA = null; //学院名称简写
if (objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred == "[null]") objvTeachingCaseResCase_Resource_RelEN.CourseChapterReferred = null; //节简称
if (objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred == "[null]") objvTeachingCaseResCase_Resource_RelEN.ParentNodeReferred = null; //章简称
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
public static void CheckProperty4Condition(clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelEN)
{
 vTeachingCaseResCase_Resource_RelDA.CheckProperty4Condition(objvTeachingCaseResCase_Resource_RelEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelBL没有刷新缓存机制(clsMicroteachCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceBL没有刷新缓存机制(clsResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsTeachingCaseResCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseBL没有刷新缓存机制(clsTeachingCaseResCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseTypeBL没有刷新缓存机制(clsTeachingCaseResCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeBL没有刷新缓存机制(clsXzDegreeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeBL没有刷新缓存机制(clsXzMajorTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeBL没有刷新缓存机制(clsXzMajorShoolTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseResourceRel");
//if (arrvTeachingCaseResCase_Resource_RelObjLstCache == null)
//{
//arrvTeachingCaseResCase_Resource_RelObjLstCache = vTeachingCaseResCase_Resource_RelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRelCache(long lngIdMicroteachCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeachingCaseResCase_Resource_RelEN._CurrTabName);
List<clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLst_Sel =
arrvTeachingCaseResCase_Resource_RelObjLstCache
.Where(x=> x.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel 
);
if (arrvTeachingCaseResCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvTeachingCaseResCase_Resource_RelEN obj = clsvTeachingCaseResCase_Resource_RelBL.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeachingCaseResCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetAllvTeachingCaseResCase_Resource_RelObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLstCache = GetObjLstCache(); 
return arrvTeachingCaseResCase_Resource_RelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingCaseResCase_Resource_RelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingCaseResCase_Resource_RelEN._CurrTabName);
List<clsvTeachingCaseResCase_Resource_RelEN> arrvTeachingCaseResCase_Resource_RelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingCaseResCase_Resource_RelObjLstCache;
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
string strKey = string.Format("{0}", clsvTeachingCaseResCase_Resource_RelEN._CurrTabName);
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
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachCaseResourceRel)
{
if (strInFldName != convTeachingCaseResCase_Resource_Rel.IdMicroteachCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachingCaseResCase_Resource_Rel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachingCaseResCase_Resource_Rel.AttributeName));
throw new Exception(strMsg);
}
var objvTeachingCaseResCase_Resource_Rel = clsvTeachingCaseResCase_Resource_RelBL.GetObjByIdMicroteachCaseResourceRelCache(lngIdMicroteachCaseResourceRel);
if (objvTeachingCaseResCase_Resource_Rel == null) return "";
return objvTeachingCaseResCase_Resource_Rel[strOutFldName].ToString();
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
int intRecCount = clsvTeachingCaseResCase_Resource_RelDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeachingCaseResCase_Resource_RelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachingCaseResCase_Resource_RelDA.GetRecCount();
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
int intRecCount = clsvTeachingCaseResCase_Resource_RelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachingCaseResCase_Resource_RelEN objvTeachingCaseResCase_Resource_RelCond)
{
List<clsvTeachingCaseResCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingCaseResCase_Resource_Rel.AttributeName)
{
if (objvTeachingCaseResCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingCaseResCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingCaseResCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCase_Resource_RelCond[strFldName]));
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
 List<string> arrList = clsvTeachingCaseResCase_Resource_RelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeachingCaseResCase_Resource_RelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeachingCaseResCase_Resource_RelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}