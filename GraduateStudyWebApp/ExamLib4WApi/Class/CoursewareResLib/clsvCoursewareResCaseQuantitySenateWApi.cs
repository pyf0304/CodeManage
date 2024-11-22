
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCaseQuantitySenateWApi
 表名:vCoursewareResCaseQuantitySenate(01120453)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:20
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库
 模块英文名:CoursewareResLib
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
public static class clsvCoursewareResCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvCoursewareResCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetFuncModuleId(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCoursewareResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCoursewareResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCoursewareResCaseQuantitySenate.FuncModuleId);
objvCoursewareResCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.FuncModuleId) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetFuncModuleName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCoursewareResCaseQuantitySenate.FuncModuleName);
objvCoursewareResCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.FuncModuleName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetId_CoursewareResCase(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strId_CoursewareResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CoursewareResCase, 8, convCoursewareResCaseQuantitySenate.Id_CoursewareResCase);
clsCheckSql.CheckFieldForeignKey(strId_CoursewareResCase, 8, convCoursewareResCaseQuantitySenate.Id_CoursewareResCase);
objvCoursewareResCaseQuantitySenateEN.Id_CoursewareResCase = strId_CoursewareResCase; //课件资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.Id_CoursewareResCase) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.Id_CoursewareResCase, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.Id_CoursewareResCase] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN Setid_MicroteachCase(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convCoursewareResCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCoursewareResCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCoursewareResCaseQuantitySenate.id_MicroteachCase);
objvCoursewareResCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.id_MicroteachCase) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCoursewareResCaseID(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCoursewareResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseID, 8, convCoursewareResCaseQuantitySenate.CoursewareResCaseID);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseID, 8, convCoursewareResCaseQuantitySenate.CoursewareResCaseID);
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseID = strCoursewareResCaseID; //课件资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CoursewareResCaseID) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseID, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseID] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCoursewareResCaseName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCoursewareResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseName, 100, convCoursewareResCaseQuantitySenate.CoursewareResCaseName);
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseName = strCoursewareResCaseName; //课件资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CoursewareResCaseName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCoursewareResCaseTheme(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCoursewareResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTheme, 200, convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme);
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTheme = strCoursewareResCaseTheme; //课件资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCoursewareResCaseDate(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCoursewareResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseDate, 8, convCoursewareResCaseQuantitySenate.CoursewareResCaseDate);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseDate, 8, convCoursewareResCaseQuantitySenate.CoursewareResCaseDate);
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDate = strCoursewareResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CoursewareResCaseDate) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseDate, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCoursewareResCaseTime(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCoursewareResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTime, 6, convCoursewareResCaseQuantitySenate.CoursewareResCaseTime);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTime, 6, convCoursewareResCaseQuantitySenate.CoursewareResCaseTime);
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTime = strCoursewareResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CoursewareResCaseTime) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseTime, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCoursewareResCaseDateIn(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCoursewareResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseDateIn, 8, convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseDateIn, 8, convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn);
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDateIn = strCoursewareResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCoursewareResCaseTimeIn(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCoursewareResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTimeIn, 6, convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTimeIn, 6, convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn);
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTimeIn = strCoursewareResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN Setid_CoursewareResCaseType(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strid_CoursewareResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CoursewareResCaseType, 4, convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareResCaseType, 4, convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType);
objvCoursewareResCaseQuantitySenateEN.id_CoursewareResCaseType = strid_CoursewareResCaseType; //课件资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCoursewareResCaseTypeName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCoursewareResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTypeName, 30, convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName);
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTypeName = strCoursewareResCaseTypeName; //课件资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetUserId(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCoursewareResCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convCoursewareResCaseQuantitySenate.UserId);
objvCoursewareResCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.UserId) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetMajorID(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCoursewareResCaseQuantitySenate.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCoursewareResCaseQuantitySenate.MajorID);
objvCoursewareResCaseQuantitySenateEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.MajorID) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.MajorID, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.MajorID] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetMajorName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCoursewareResCaseQuantitySenate.MajorName);
objvCoursewareResCaseQuantitySenateEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.MajorName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.MajorName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.MajorName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN Setid_AppraiseType(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convCoursewareResCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convCoursewareResCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convCoursewareResCaseQuantitySenate.id_AppraiseType);
objvCoursewareResCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.id_AppraiseType) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetAppraiseTypeName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convCoursewareResCaseQuantitySenate.AppraiseTypeName);
objvCoursewareResCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.AppraiseTypeName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCollegeID(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCoursewareResCaseQuantitySenate.CollegeID);
objvCoursewareResCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CollegeID) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCollegeName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCoursewareResCaseQuantitySenate.CollegeName);
objvCoursewareResCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CollegeName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCourseId(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCoursewareResCaseQuantitySenate.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCoursewareResCaseQuantitySenate.CourseId);
objvCoursewareResCaseQuantitySenateEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CourseId) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CourseId, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CourseId] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCourseCode(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCoursewareResCaseQuantitySenate.CourseCode);
objvCoursewareResCaseQuantitySenateEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CourseCode) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CourseCode, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CourseCode] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCourseName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCoursewareResCaseQuantitySenate.CourseName);
objvCoursewareResCaseQuantitySenateEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CourseName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CourseName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CourseName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetBrowseCount(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
	{
objvCoursewareResCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.BrowseCount) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetSenateTheme(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convCoursewareResCaseQuantitySenate.SenateTheme);
objvCoursewareResCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.SenateTheme) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetSenateContent(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convCoursewareResCaseQuantitySenate.SenateContent);
objvCoursewareResCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.SenateContent) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetSenateTotalScore(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convCoursewareResCaseQuantitySenate.SenateTotalScore);
objvCoursewareResCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.SenateTotalScore) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetSenateDate(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convCoursewareResCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convCoursewareResCaseQuantitySenate.SenateDate);
objvCoursewareResCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.SenateDate) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetSenateTime(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convCoursewareResCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convCoursewareResCaseQuantitySenate.SenateTime);
objvCoursewareResCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.SenateTime) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion);
objvCoursewareResCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCoursewareResCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCoursewareResCaseQuantitySenate.senateGaugeVersionID);
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCoursewareResCaseQuantitySenate.senateGaugeVersionName);
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetUpdUserName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convCoursewareResCaseQuantitySenate.UpdUserName);
objvCoursewareResCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.UpdUserName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetSenateIp(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, convCoursewareResCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(strSenateIp, 50, convCoursewareResCaseQuantitySenate.SenateIp);
objvCoursewareResCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.SenateIp) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetUserTypeName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convCoursewareResCaseQuantitySenate.UserTypeName);
objvCoursewareResCaseQuantitySenateEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.UserTypeName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.UserTypeName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserTypeName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetUserName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convCoursewareResCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convCoursewareResCaseQuantitySenate.UserName);
objvCoursewareResCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.UserName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetUserNameWithUserId(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convCoursewareResCaseQuantitySenate.UserNameWithUserId);
objvCoursewareResCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.UserNameWithUserId) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetIsDualVideo(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCoursewareResCaseQuantitySenateEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.IsDualVideo) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.IsDualVideo, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.IsDualVideo] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetUserKindId(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convCoursewareResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convCoursewareResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convCoursewareResCaseQuantitySenate.UserKindId);
objvCoursewareResCaseQuantitySenateEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.UserKindId) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.UserKindId, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserKindId] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetUserKindName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convCoursewareResCaseQuantitySenate.UserKindName);
objvCoursewareResCaseQuantitySenateEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.UserKindName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.UserKindName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserKindName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetViewCount(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, int intViewCount, string strComparisonOp="")
	{
objvCoursewareResCaseQuantitySenateEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.ViewCount) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.ViewCount, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.ViewCount] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetIsShow(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, bool bolIsShow, string strComparisonOp="")
	{
objvCoursewareResCaseQuantitySenateEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.IsShow) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.IsShow, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.IsShow] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetDownloadNumber(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, int intDownloadNumber, string strComparisonOp="")
	{
objvCoursewareResCaseQuantitySenateEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.DownloadNumber) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.DownloadNumber, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.DownloadNumber] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetFileIntegration(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, int intFileIntegration, string strComparisonOp="")
	{
objvCoursewareResCaseQuantitySenateEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.FileIntegration) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.FileIntegration, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.FileIntegration] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetLikeCount(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, long lngLikeCount, string strComparisonOp="")
	{
objvCoursewareResCaseQuantitySenateEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.LikeCount) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.LikeCount, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.LikeCount] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCollectionCount(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, long lngCollectionCount, string strComparisonOp="")
	{
objvCoursewareResCaseQuantitySenateEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CollectionCount) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CollectionCount, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CollectionCount] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetUpdUser(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCoursewareResCaseQuantitySenate.UpdUser);
objvCoursewareResCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.UpdUser) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetMemo(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCoursewareResCaseQuantitySenate.Memo);
objvCoursewareResCaseQuantitySenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.Memo) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.Memo, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.Memo] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetOwnerId(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCoursewareResCaseQuantitySenate.OwnerId);
objvCoursewareResCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.OwnerId) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetOwnerName(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCoursewareResCaseQuantitySenate.OwnerName);
objvCoursewareResCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.OwnerName) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetOwnerNameWithId(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCoursewareResCaseQuantitySenate.OwnerNameWithId);
objvCoursewareResCaseQuantitySenateEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.OwnerNameWithId) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.OwnerNameWithId, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.OwnerNameWithId] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN Setid_XzCollege(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCoursewareResCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCoursewareResCaseQuantitySenate.id_XzCollege);
objvCoursewareResCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.id_XzCollege) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN Setid_XzMajor(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCoursewareResCaseQuantitySenate.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCoursewareResCaseQuantitySenate.id_XzMajor);
objvCoursewareResCaseQuantitySenateEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.id_XzMajor) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.id_XzMajor, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_XzMajor] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseQuantitySenateEN SetCollegeNameA(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCoursewareResCaseQuantitySenate.CollegeNameA);
objvCoursewareResCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseQuantitySenate.CollegeNameA) == false)
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareResCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvCoursewareResCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvCoursewareResCaseQuantitySenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseQuantitySenate.id_microteachCaseQuantitySenate, objvCoursewareResCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.FuncModuleId, objvCoursewareResCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.FuncModuleName, objvCoursewareResCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.Id_CoursewareResCase) == true)
{
string strComparisonOp_Id_CoursewareResCase = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.Id_CoursewareResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.Id_CoursewareResCase, objvCoursewareResCaseQuantitySenate_Cond.Id_CoursewareResCase, strComparisonOp_Id_CoursewareResCase);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.id_MicroteachCase, objvCoursewareResCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CoursewareResCaseID) == true)
{
string strComparisonOp_CoursewareResCaseID = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CoursewareResCaseID, objvCoursewareResCaseQuantitySenate_Cond.CoursewareResCaseID, strComparisonOp_CoursewareResCaseID);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CoursewareResCaseName) == true)
{
string strComparisonOp_CoursewareResCaseName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CoursewareResCaseName, objvCoursewareResCaseQuantitySenate_Cond.CoursewareResCaseName, strComparisonOp_CoursewareResCaseName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme) == true)
{
string strComparisonOp_CoursewareResCaseTheme = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme, objvCoursewareResCaseQuantitySenate_Cond.CoursewareResCaseTheme, strComparisonOp_CoursewareResCaseTheme);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CoursewareResCaseDate) == true)
{
string strComparisonOp_CoursewareResCaseDate = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CoursewareResCaseDate, objvCoursewareResCaseQuantitySenate_Cond.CoursewareResCaseDate, strComparisonOp_CoursewareResCaseDate);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CoursewareResCaseTime) == true)
{
string strComparisonOp_CoursewareResCaseTime = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CoursewareResCaseTime, objvCoursewareResCaseQuantitySenate_Cond.CoursewareResCaseTime, strComparisonOp_CoursewareResCaseTime);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn) == true)
{
string strComparisonOp_CoursewareResCaseDateIn = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn, objvCoursewareResCaseQuantitySenate_Cond.CoursewareResCaseDateIn, strComparisonOp_CoursewareResCaseDateIn);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn) == true)
{
string strComparisonOp_CoursewareResCaseTimeIn = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn, objvCoursewareResCaseQuantitySenate_Cond.CoursewareResCaseTimeIn, strComparisonOp_CoursewareResCaseTimeIn);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType) == true)
{
string strComparisonOp_id_CoursewareResCaseType = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType, objvCoursewareResCaseQuantitySenate_Cond.id_CoursewareResCaseType, strComparisonOp_id_CoursewareResCaseType);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName) == true)
{
string strComparisonOp_CoursewareResCaseTypeName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName, objvCoursewareResCaseQuantitySenate_Cond.CoursewareResCaseTypeName, strComparisonOp_CoursewareResCaseTypeName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.UserId, objvCoursewareResCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.MajorID) == true)
{
string strComparisonOp_MajorID = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.MajorID, objvCoursewareResCaseQuantitySenate_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.MajorName) == true)
{
string strComparisonOp_MajorName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.MajorName, objvCoursewareResCaseQuantitySenate_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.id_AppraiseType, objvCoursewareResCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.AppraiseTypeName, objvCoursewareResCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CollegeID, objvCoursewareResCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CollegeName, objvCoursewareResCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CourseId) == true)
{
string strComparisonOp_CourseId = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CourseId, objvCoursewareResCaseQuantitySenate_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CourseCode, objvCoursewareResCaseQuantitySenate_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CourseName) == true)
{
string strComparisonOp_CourseName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CourseName, objvCoursewareResCaseQuantitySenate_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseQuantitySenate.BrowseCount, objvCoursewareResCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.SenateTheme, objvCoursewareResCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.SenateContent, objvCoursewareResCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseQuantitySenate.SenateTotalScore, objvCoursewareResCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.SenateDate, objvCoursewareResCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.SenateTime, objvCoursewareResCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion, objvCoursewareResCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.senateGaugeVersionID, objvCoursewareResCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.senateGaugeVersionName, objvCoursewareResCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore, objvCoursewareResCaseQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.UpdUserName, objvCoursewareResCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.SenateIp, objvCoursewareResCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.UserTypeName, objvCoursewareResCaseQuantitySenate_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.UserName, objvCoursewareResCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.UserNameWithUserId, objvCoursewareResCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.IsDualVideo) == true)
{
if (objvCoursewareResCaseQuantitySenate_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCaseQuantitySenate.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCaseQuantitySenate.IsDualVideo);
}
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.UserKindId, objvCoursewareResCaseQuantitySenate_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.UserKindName, objvCoursewareResCaseQuantitySenate_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseQuantitySenate.ViewCount, objvCoursewareResCaseQuantitySenate_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.IsShow) == true)
{
if (objvCoursewareResCaseQuantitySenate_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCaseQuantitySenate.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCaseQuantitySenate.IsShow);
}
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseQuantitySenate.DownloadNumber, objvCoursewareResCaseQuantitySenate_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseQuantitySenate.FileIntegration, objvCoursewareResCaseQuantitySenate_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseQuantitySenate.LikeCount, objvCoursewareResCaseQuantitySenate_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseQuantitySenate.CollectionCount, objvCoursewareResCaseQuantitySenate_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.UpdUser, objvCoursewareResCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.Memo) == true)
{
string strComparisonOp_Memo = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.Memo, objvCoursewareResCaseQuantitySenate_Cond.Memo, strComparisonOp_Memo);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.OwnerId, objvCoursewareResCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.OwnerName, objvCoursewareResCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.OwnerNameWithId, objvCoursewareResCaseQuantitySenate_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.id_XzCollege, objvCoursewareResCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.id_XzMajor, objvCoursewareResCaseQuantitySenate_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCoursewareResCaseQuantitySenate_Cond.IsUpdated(convCoursewareResCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCoursewareResCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareResCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseQuantitySenate.CollegeNameA, objvCoursewareResCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课件资源量化评议(vCoursewareResCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareResCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vCoursewareResCaseQuantitySenateApi";

 public clsvCoursewareResCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareResCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCoursewareResCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvCoursewareResCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCaseQuantitySenateEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareResCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCoursewareResCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvCoursewareResCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCaseQuantitySenateEN;
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
public static clsvCoursewareResCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN = null;
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
objvCoursewareResCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvCoursewareResCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCaseQuantitySenateEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCoursewareResCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareResCaseQuantitySenateEN._CurrTabName_S);
List<clsvCoursewareResCaseQuantitySenateEN> arrvCoursewareResCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareResCaseQuantitySenateEN> arrvCoursewareResCaseQuantitySenateObjLst_Sel =
from objvCoursewareResCaseQuantitySenateEN in arrvCoursewareResCaseQuantitySenateObjLst_Cache
where objvCoursewareResCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvCoursewareResCaseQuantitySenateEN;
if (arrvCoursewareResCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvCoursewareResCaseQuantitySenateEN obj = clsvCoursewareResCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCoursewareResCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareResCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvCoursewareResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvCoursewareResCaseQuantitySenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_microteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCoursewareResCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareResCaseQuantitySenateEN._CurrTabName_S);
List<clsvCoursewareResCaseQuantitySenateEN> arrvCoursewareResCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareResCaseQuantitySenateEN> arrvCoursewareResCaseQuantitySenateObjLst_Sel =
from objvCoursewareResCaseQuantitySenateEN in arrvCoursewareResCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvCoursewareResCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvCoursewareResCaseQuantitySenateEN;
return arrvCoursewareResCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareResCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvCoursewareResCaseQuantitySenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCoursewareResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCoursewareResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCoursewareResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCoursewareResCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_microteachCaseQuantitySenate)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
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
 /// <param name = "objvCoursewareResCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvCoursewareResCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateENS, clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateENT)
{
try
{
objvCoursewareResCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvCoursewareResCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvCoursewareResCaseQuantitySenateENT.FuncModuleId = objvCoursewareResCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvCoursewareResCaseQuantitySenateENT.FuncModuleName = objvCoursewareResCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvCoursewareResCaseQuantitySenateENT.Id_CoursewareResCase = objvCoursewareResCaseQuantitySenateENS.Id_CoursewareResCase; //课件资源案例流水号
objvCoursewareResCaseQuantitySenateENT.id_MicroteachCase = objvCoursewareResCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseID = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseID; //课件资源案例ID
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseName = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseName; //课件资源案例名称
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseTheme = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseTheme; //课件资源案例主题词
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseDate = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseDate; //视频资源日期
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseTime = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseTime; //视频资源时间
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseDateIn = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseDateIn; //案例入库日期
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseTimeIn = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseTimeIn; //案例入库时间
objvCoursewareResCaseQuantitySenateENT.id_CoursewareResCaseType = objvCoursewareResCaseQuantitySenateENS.id_CoursewareResCaseType; //课件资源类型流水号
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseTypeName = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseTypeName; //课件资源案例类型名称
objvCoursewareResCaseQuantitySenateENT.UserId = objvCoursewareResCaseQuantitySenateENS.UserId; //用户ID
objvCoursewareResCaseQuantitySenateENT.MajorID = objvCoursewareResCaseQuantitySenateENS.MajorID; //专业ID
objvCoursewareResCaseQuantitySenateENT.MajorName = objvCoursewareResCaseQuantitySenateENS.MajorName; //专业名称
objvCoursewareResCaseQuantitySenateENT.id_AppraiseType = objvCoursewareResCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvCoursewareResCaseQuantitySenateENT.AppraiseTypeName = objvCoursewareResCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvCoursewareResCaseQuantitySenateENT.CollegeID = objvCoursewareResCaseQuantitySenateENS.CollegeID; //学院ID
objvCoursewareResCaseQuantitySenateENT.CollegeName = objvCoursewareResCaseQuantitySenateENS.CollegeName; //学院名称
objvCoursewareResCaseQuantitySenateENT.CourseId = objvCoursewareResCaseQuantitySenateENS.CourseId; //课程Id
objvCoursewareResCaseQuantitySenateENT.CourseCode = objvCoursewareResCaseQuantitySenateENS.CourseCode; //课程代码
objvCoursewareResCaseQuantitySenateENT.CourseName = objvCoursewareResCaseQuantitySenateENS.CourseName; //课程名称
objvCoursewareResCaseQuantitySenateENT.BrowseCount = objvCoursewareResCaseQuantitySenateENS.BrowseCount; //浏览次数
objvCoursewareResCaseQuantitySenateENT.SenateTheme = objvCoursewareResCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvCoursewareResCaseQuantitySenateENT.SenateContent = objvCoursewareResCaseQuantitySenateENS.SenateContent; //评价内容
objvCoursewareResCaseQuantitySenateENT.SenateTotalScore = objvCoursewareResCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvCoursewareResCaseQuantitySenateENT.SenateDate = objvCoursewareResCaseQuantitySenateENS.SenateDate; //评价日期
objvCoursewareResCaseQuantitySenateENT.SenateTime = objvCoursewareResCaseQuantitySenateENS.SenateTime; //评价时间
objvCoursewareResCaseQuantitySenateENT.id_SenateGaugeVersion = objvCoursewareResCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
objvCoursewareResCaseQuantitySenateENT.senateGaugeVersionID = objvCoursewareResCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareResCaseQuantitySenateENT.senateGaugeVersionName = objvCoursewareResCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareResCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvCoursewareResCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareResCaseQuantitySenateENT.UpdUserName = objvCoursewareResCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvCoursewareResCaseQuantitySenateENT.SenateIp = objvCoursewareResCaseQuantitySenateENS.SenateIp; //评议Ip
objvCoursewareResCaseQuantitySenateENT.UserTypeName = objvCoursewareResCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvCoursewareResCaseQuantitySenateENT.UserName = objvCoursewareResCaseQuantitySenateENS.UserName; //用户名
objvCoursewareResCaseQuantitySenateENT.UserNameWithUserId = objvCoursewareResCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvCoursewareResCaseQuantitySenateENT.IsDualVideo = objvCoursewareResCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvCoursewareResCaseQuantitySenateENT.UserKindId = objvCoursewareResCaseQuantitySenateENS.UserKindId; //用户类别Id
objvCoursewareResCaseQuantitySenateENT.UserKindName = objvCoursewareResCaseQuantitySenateENS.UserKindName; //用户类别名
objvCoursewareResCaseQuantitySenateENT.ViewCount = objvCoursewareResCaseQuantitySenateENS.ViewCount; //浏览量
objvCoursewareResCaseQuantitySenateENT.IsShow = objvCoursewareResCaseQuantitySenateENS.IsShow; //是否启用
objvCoursewareResCaseQuantitySenateENT.DownloadNumber = objvCoursewareResCaseQuantitySenateENS.DownloadNumber; //下载数目
objvCoursewareResCaseQuantitySenateENT.FileIntegration = objvCoursewareResCaseQuantitySenateENS.FileIntegration; //文件积分
objvCoursewareResCaseQuantitySenateENT.LikeCount = objvCoursewareResCaseQuantitySenateENS.LikeCount; //资源喜欢数量
objvCoursewareResCaseQuantitySenateENT.CollectionCount = objvCoursewareResCaseQuantitySenateENS.CollectionCount; //收藏数量
objvCoursewareResCaseQuantitySenateENT.UpdUser = objvCoursewareResCaseQuantitySenateENS.UpdUser; //修改人
objvCoursewareResCaseQuantitySenateENT.Memo = objvCoursewareResCaseQuantitySenateENS.Memo; //备注
objvCoursewareResCaseQuantitySenateENT.OwnerId = objvCoursewareResCaseQuantitySenateENS.OwnerId; //拥有者Id
objvCoursewareResCaseQuantitySenateENT.OwnerName = objvCoursewareResCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvCoursewareResCaseQuantitySenateENT.OwnerNameWithId = objvCoursewareResCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareResCaseQuantitySenateENT.id_XzCollege = objvCoursewareResCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvCoursewareResCaseQuantitySenateENT.id_XzMajor = objvCoursewareResCaseQuantitySenateENS.id_XzMajor; //专业流水号
objvCoursewareResCaseQuantitySenateENT.CollegeNameA = objvCoursewareResCaseQuantitySenateENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvCoursewareResCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCoursewareResCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCoursewareResCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCoursewareResCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCoursewareResCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCoursewareResCaseQuantitySenateEN.AttributeName)
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
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCoursewareResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareResCaseWApi没有刷新缓存机制(clsCoursewareResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareResCaseTypeWApi没有刷新缓存机制(clsCoursewareResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvCoursewareResCaseQuantitySenateObjLst_Cache == null)
//{
//arrvCoursewareResCaseQuantitySenateObjLst_Cache = await clsvCoursewareResCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCoursewareResCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvCoursewareResCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCoursewareResCaseQuantitySenateEN._CurrTabName_S);
List<clsvCoursewareResCaseQuantitySenateEN> arrvCoursewareResCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCoursewareResCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCoursewareResCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.Id_CoursewareResCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
foreach (clsvCoursewareResCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCoursewareResCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convCoursewareResCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convCoursewareResCaseQuantitySenate.FuncModuleId] = objInFor[convCoursewareResCaseQuantitySenate.FuncModuleId];
objDR[convCoursewareResCaseQuantitySenate.FuncModuleName] = objInFor[convCoursewareResCaseQuantitySenate.FuncModuleName];
objDR[convCoursewareResCaseQuantitySenate.Id_CoursewareResCase] = objInFor[convCoursewareResCaseQuantitySenate.Id_CoursewareResCase];
objDR[convCoursewareResCaseQuantitySenate.id_MicroteachCase] = objInFor[convCoursewareResCaseQuantitySenate.id_MicroteachCase];
objDR[convCoursewareResCaseQuantitySenate.CoursewareResCaseID] = objInFor[convCoursewareResCaseQuantitySenate.CoursewareResCaseID];
objDR[convCoursewareResCaseQuantitySenate.CoursewareResCaseName] = objInFor[convCoursewareResCaseQuantitySenate.CoursewareResCaseName];
objDR[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme] = objInFor[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme];
objDR[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate] = objInFor[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate];
objDR[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime] = objInFor[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime];
objDR[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn] = objInFor[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn];
objDR[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn] = objInFor[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn];
objDR[convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType] = objInFor[convCoursewareResCaseQuantitySenate.id_CoursewareResCaseType];
objDR[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName] = objInFor[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName];
objDR[convCoursewareResCaseQuantitySenate.UserId] = objInFor[convCoursewareResCaseQuantitySenate.UserId];
objDR[convCoursewareResCaseQuantitySenate.MajorID] = objInFor[convCoursewareResCaseQuantitySenate.MajorID];
objDR[convCoursewareResCaseQuantitySenate.MajorName] = objInFor[convCoursewareResCaseQuantitySenate.MajorName];
objDR[convCoursewareResCaseQuantitySenate.id_AppraiseType] = objInFor[convCoursewareResCaseQuantitySenate.id_AppraiseType];
objDR[convCoursewareResCaseQuantitySenate.AppraiseTypeName] = objInFor[convCoursewareResCaseQuantitySenate.AppraiseTypeName];
objDR[convCoursewareResCaseQuantitySenate.CollegeID] = objInFor[convCoursewareResCaseQuantitySenate.CollegeID];
objDR[convCoursewareResCaseQuantitySenate.CollegeName] = objInFor[convCoursewareResCaseQuantitySenate.CollegeName];
objDR[convCoursewareResCaseQuantitySenate.CourseId] = objInFor[convCoursewareResCaseQuantitySenate.CourseId];
objDR[convCoursewareResCaseQuantitySenate.CourseCode] = objInFor[convCoursewareResCaseQuantitySenate.CourseCode];
objDR[convCoursewareResCaseQuantitySenate.CourseName] = objInFor[convCoursewareResCaseQuantitySenate.CourseName];
objDR[convCoursewareResCaseQuantitySenate.BrowseCount] = objInFor[convCoursewareResCaseQuantitySenate.BrowseCount];
objDR[convCoursewareResCaseQuantitySenate.SenateTheme] = objInFor[convCoursewareResCaseQuantitySenate.SenateTheme];
objDR[convCoursewareResCaseQuantitySenate.SenateContent] = objInFor[convCoursewareResCaseQuantitySenate.SenateContent];
objDR[convCoursewareResCaseQuantitySenate.SenateTotalScore] = objInFor[convCoursewareResCaseQuantitySenate.SenateTotalScore];
objDR[convCoursewareResCaseQuantitySenate.SenateDate] = objInFor[convCoursewareResCaseQuantitySenate.SenateDate];
objDR[convCoursewareResCaseQuantitySenate.SenateTime] = objInFor[convCoursewareResCaseQuantitySenate.SenateTime];
objDR[convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convCoursewareResCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convCoursewareResCaseQuantitySenate.senateGaugeVersionID] = objInFor[convCoursewareResCaseQuantitySenate.senateGaugeVersionID];
objDR[convCoursewareResCaseQuantitySenate.senateGaugeVersionName] = objInFor[convCoursewareResCaseQuantitySenate.senateGaugeVersionName];
objDR[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore];
objDR[convCoursewareResCaseQuantitySenate.UpdUserName] = objInFor[convCoursewareResCaseQuantitySenate.UpdUserName];
objDR[convCoursewareResCaseQuantitySenate.SenateIp] = objInFor[convCoursewareResCaseQuantitySenate.SenateIp];
objDR[convCoursewareResCaseQuantitySenate.UserTypeName] = objInFor[convCoursewareResCaseQuantitySenate.UserTypeName];
objDR[convCoursewareResCaseQuantitySenate.UserName] = objInFor[convCoursewareResCaseQuantitySenate.UserName];
objDR[convCoursewareResCaseQuantitySenate.UserNameWithUserId] = objInFor[convCoursewareResCaseQuantitySenate.UserNameWithUserId];
objDR[convCoursewareResCaseQuantitySenate.IsDualVideo] = objInFor[convCoursewareResCaseQuantitySenate.IsDualVideo];
objDR[convCoursewareResCaseQuantitySenate.UserKindId] = objInFor[convCoursewareResCaseQuantitySenate.UserKindId];
objDR[convCoursewareResCaseQuantitySenate.UserKindName] = objInFor[convCoursewareResCaseQuantitySenate.UserKindName];
objDR[convCoursewareResCaseQuantitySenate.ViewCount] = objInFor[convCoursewareResCaseQuantitySenate.ViewCount];
objDR[convCoursewareResCaseQuantitySenate.IsShow] = objInFor[convCoursewareResCaseQuantitySenate.IsShow];
objDR[convCoursewareResCaseQuantitySenate.DownloadNumber] = objInFor[convCoursewareResCaseQuantitySenate.DownloadNumber];
objDR[convCoursewareResCaseQuantitySenate.FileIntegration] = objInFor[convCoursewareResCaseQuantitySenate.FileIntegration];
objDR[convCoursewareResCaseQuantitySenate.LikeCount] = objInFor[convCoursewareResCaseQuantitySenate.LikeCount];
objDR[convCoursewareResCaseQuantitySenate.CollectionCount] = objInFor[convCoursewareResCaseQuantitySenate.CollectionCount];
objDR[convCoursewareResCaseQuantitySenate.UpdUser] = objInFor[convCoursewareResCaseQuantitySenate.UpdUser];
objDR[convCoursewareResCaseQuantitySenate.Memo] = objInFor[convCoursewareResCaseQuantitySenate.Memo];
objDR[convCoursewareResCaseQuantitySenate.OwnerId] = objInFor[convCoursewareResCaseQuantitySenate.OwnerId];
objDR[convCoursewareResCaseQuantitySenate.OwnerName] = objInFor[convCoursewareResCaseQuantitySenate.OwnerName];
objDR[convCoursewareResCaseQuantitySenate.OwnerNameWithId] = objInFor[convCoursewareResCaseQuantitySenate.OwnerNameWithId];
objDR[convCoursewareResCaseQuantitySenate.id_XzCollege] = objInFor[convCoursewareResCaseQuantitySenate.id_XzCollege];
objDR[convCoursewareResCaseQuantitySenate.id_XzMajor] = objInFor[convCoursewareResCaseQuantitySenate.id_XzMajor];
objDR[convCoursewareResCaseQuantitySenate.CollegeNameA] = objInFor[convCoursewareResCaseQuantitySenate.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}