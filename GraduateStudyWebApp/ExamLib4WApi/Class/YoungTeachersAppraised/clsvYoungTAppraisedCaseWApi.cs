
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCaseWApi
 表名:vYoungTAppraisedCase(01120464)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:25
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
public static class clsvYoungTAppraisedCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN Setid_YoungTAppraisedCase(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strid_YoungTAppraisedCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_YoungTAppraisedCase, 8, convYoungTAppraisedCase.id_YoungTAppraisedCase);
clsCheckSql.CheckFieldForeignKey(strid_YoungTAppraisedCase, 8, convYoungTAppraisedCase.id_YoungTAppraisedCase);
objvYoungTAppraisedCaseEN.id_YoungTAppraisedCase = strid_YoungTAppraisedCase; //青教评优案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.id_YoungTAppraisedCase) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.id_YoungTAppraisedCase, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.id_YoungTAppraisedCase] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetId_DecompressionFile(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, long lngId_DecompressionFile, string strComparisonOp="")
	{
objvYoungTAppraisedCaseEN.Id_DecompressionFile = lngId_DecompressionFile; //解压缩文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.Id_DecompressionFile) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.Id_DecompressionFile, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.Id_DecompressionFile] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetFuncModuleName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convYoungTAppraisedCase.FuncModuleName);
objvYoungTAppraisedCaseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.FuncModuleName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.FuncModuleName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.FuncModuleName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetYoungTAppraisedCaseID(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strYoungTAppraisedCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseID, convYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseID, 8, convYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseID, 8, convYoungTAppraisedCase.YoungTAppraisedCaseID);
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseID = strYoungTAppraisedCaseID; //青教评优案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.YoungTAppraisedCaseID) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.YoungTAppraisedCaseID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetYoungTAppraisedCaseName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strYoungTAppraisedCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseName, convYoungTAppraisedCase.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseName, 100, convYoungTAppraisedCase.YoungTAppraisedCaseName);
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseName = strYoungTAppraisedCaseName; //青教评优案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.YoungTAppraisedCaseName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.YoungTAppraisedCaseName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetYoungTAppraisedCaseText(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strYoungTAppraisedCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseText, 8000, convYoungTAppraisedCase.YoungTAppraisedCaseText);
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseText = strYoungTAppraisedCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.YoungTAppraisedCaseText) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.YoungTAppraisedCaseText, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseText] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetYoungTAppraisedCaseDate(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strYoungTAppraisedCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseDate, 8, convYoungTAppraisedCase.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseDate, 8, convYoungTAppraisedCase.YoungTAppraisedCaseDate);
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = strYoungTAppraisedCaseDate; //青教评优教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.YoungTAppraisedCaseDate) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.YoungTAppraisedCaseDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetYoungTAppraisedCaseTime(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strYoungTAppraisedCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTime, 6, convYoungTAppraisedCase.YoungTAppraisedCaseTime);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseTime, 6, convYoungTAppraisedCase.YoungTAppraisedCaseTime);
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = strYoungTAppraisedCaseTime; //青教评优教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.YoungTAppraisedCaseTime) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.YoungTAppraisedCaseTime, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseTime] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetYoungTAppraisedCaseTheme(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strYoungTAppraisedCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTheme, 200, convYoungTAppraisedCase.YoungTAppraisedCaseTheme);
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = strYoungTAppraisedCaseTheme; //青教评优案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.YoungTAppraisedCaseTheme) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.YoungTAppraisedCaseTheme, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseTheme] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetYoungTAppraisedCaseDateIn(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strYoungTAppraisedCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseDateIn, 8, convYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseDateIn, 8, convYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = strYoungTAppraisedCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.YoungTAppraisedCaseDateIn) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.YoungTAppraisedCaseDateIn, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetYoungTAppraisedCaseTimeIn(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strYoungTAppraisedCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTimeIn, 6, convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseTimeIn, 6, convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = strYoungTAppraisedCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN Setid_StudyLevel(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convYoungTAppraisedCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convYoungTAppraisedCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convYoungTAppraisedCase.id_StudyLevel);
objvYoungTAppraisedCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.id_StudyLevel) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.id_StudyLevel, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.id_StudyLevel] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetStudyLevelName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convYoungTAppraisedCase.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convYoungTAppraisedCase.StudyLevelName);
objvYoungTAppraisedCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.StudyLevelName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.StudyLevelName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.StudyLevelName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN Setid_TeachingPlan(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convYoungTAppraisedCase.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convYoungTAppraisedCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convYoungTAppraisedCase.id_TeachingPlan);
objvYoungTAppraisedCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.id_TeachingPlan) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetId_CaseType(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_CaseType, convYoungTAppraisedCase.Id_CaseType);
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convYoungTAppraisedCase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convYoungTAppraisedCase.Id_CaseType);
objvYoungTAppraisedCaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.Id_CaseType) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.Id_CaseType, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.Id_CaseType] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN Setid_Discipline(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convYoungTAppraisedCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convYoungTAppraisedCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convYoungTAppraisedCase.id_Discipline);
objvYoungTAppraisedCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.id_Discipline) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.id_Discipline, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.id_Discipline] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetDisciplineID(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convYoungTAppraisedCase.DisciplineID);
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convYoungTAppraisedCase.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convYoungTAppraisedCase.DisciplineID);
objvYoungTAppraisedCaseEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.DisciplineID) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.DisciplineID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.DisciplineID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetDisciplineName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convYoungTAppraisedCase.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convYoungTAppraisedCase.DisciplineName);
objvYoungTAppraisedCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.DisciplineName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.DisciplineName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.DisciplineName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN Setid_SenateGaugeVersion(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convYoungTAppraisedCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convYoungTAppraisedCase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convYoungTAppraisedCase.id_SenateGaugeVersion);
objvYoungTAppraisedCaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.id_SenateGaugeVersion) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetsenateGaugeVersionID(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convYoungTAppraisedCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convYoungTAppraisedCase.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convYoungTAppraisedCase.senateGaugeVersionID);
objvYoungTAppraisedCaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.senateGaugeVersionID) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.senateGaugeVersionID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.senateGaugeVersionID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetsenateGaugeVersionName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convYoungTAppraisedCase.senateGaugeVersionName);
objvYoungTAppraisedCaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.senateGaugeVersionName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.senateGaugeVersionName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.senateGaugeVersionName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetsenateGaugeVersionTtlScore(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convYoungTAppraisedCase.senateGaugeVersionTtlScore);
objvYoungTAppraisedCaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.senateGaugeVersionTtlScore) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetVersionNo(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, int intVersionNo, string strComparisonOp="")
	{
objvYoungTAppraisedCaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.VersionNo) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.VersionNo, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.VersionNo] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN Setid_TeachSkill(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convYoungTAppraisedCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convYoungTAppraisedCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convYoungTAppraisedCase.id_TeachSkill);
objvYoungTAppraisedCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.id_TeachSkill) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.id_TeachSkill, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.id_TeachSkill] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetTeachSkillID(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillID, convYoungTAppraisedCase.TeachSkillID);
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convYoungTAppraisedCase.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convYoungTAppraisedCase.TeachSkillID);
objvYoungTAppraisedCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.TeachSkillID) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.TeachSkillID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.TeachSkillID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetSkillTypeName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeName, convYoungTAppraisedCase.SkillTypeName);
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convYoungTAppraisedCase.SkillTypeName);
objvYoungTAppraisedCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.SkillTypeName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.SkillTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.SkillTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetTeachSkillName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillName, convYoungTAppraisedCase.TeachSkillName);
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convYoungTAppraisedCase.TeachSkillName);
objvYoungTAppraisedCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.TeachSkillName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.TeachSkillName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.TeachSkillName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetTeachSkillTheory(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convYoungTAppraisedCase.TeachSkillTheory);
objvYoungTAppraisedCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.TeachSkillTheory) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetTeachSkillOperMethod(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convYoungTAppraisedCase.TeachSkillOperMethod);
objvYoungTAppraisedCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.TeachSkillOperMethod) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN Setid_SkillType(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SkillType, convYoungTAppraisedCase.id_SkillType);
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convYoungTAppraisedCase.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convYoungTAppraisedCase.id_SkillType);
objvYoungTAppraisedCaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.id_SkillType) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.id_SkillType, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.id_SkillType] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetSkillTypeID(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeID, convYoungTAppraisedCase.SkillTypeID);
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convYoungTAppraisedCase.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convYoungTAppraisedCase.SkillTypeID);
objvYoungTAppraisedCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.SkillTypeID) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.SkillTypeID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.SkillTypeID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetCaseLevelId(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convYoungTAppraisedCase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convYoungTAppraisedCase.CaseLevelId);
objvYoungTAppraisedCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.CaseLevelId) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.CaseLevelId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.CaseLevelId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetDocFile(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convYoungTAppraisedCase.DocFile);
objvYoungTAppraisedCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.DocFile) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.DocFile, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.DocFile] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetIsNeedGeneWord(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvYoungTAppraisedCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.IsNeedGeneWord) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetWordCreateDate(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convYoungTAppraisedCase.WordCreateDate);
objvYoungTAppraisedCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.WordCreateDate) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.WordCreateDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.WordCreateDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetIsVisible(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvYoungTAppraisedCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.IsVisible) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.IsVisible, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.IsVisible] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetOwnerId(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convYoungTAppraisedCase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convYoungTAppraisedCase.OwnerId);
objvYoungTAppraisedCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.OwnerId) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.OwnerId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.OwnerId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetTeacherID(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convYoungTAppraisedCase.TeacherID);
objvYoungTAppraisedCaseEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.TeacherID) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.TeacherID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.TeacherID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetTeacherName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convYoungTAppraisedCase.TeacherName);
objvYoungTAppraisedCaseEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.TeacherName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.TeacherName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.TeacherName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN Setid_XzCollege(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convYoungTAppraisedCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convYoungTAppraisedCase.id_XzCollege);
objvYoungTAppraisedCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.id_XzCollege) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.id_XzCollege, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.id_XzCollege] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetCollegeID(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeID, convYoungTAppraisedCase.CollegeID);
clsCheckSql.CheckFieldLen(strCollegeID, 4, convYoungTAppraisedCase.CollegeID);
objvYoungTAppraisedCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.CollegeID) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.CollegeID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.CollegeID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetCollegeName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convYoungTAppraisedCase.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convYoungTAppraisedCase.CollegeName);
objvYoungTAppraisedCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.CollegeName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.CollegeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.CollegeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetCollegeNameA(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convYoungTAppraisedCase.CollegeNameA);
objvYoungTAppraisedCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.CollegeNameA) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.CollegeNameA, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.CollegeNameA] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetEntryDate(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strEntryDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryDate, 8, convYoungTAppraisedCase.EntryDate);
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, convYoungTAppraisedCase.EntryDate);
objvYoungTAppraisedCaseEN.EntryDate = strEntryDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.EntryDate) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.EntryDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.EntryDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetIsDualVideo(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convYoungTAppraisedCase.IsDualVideo);
objvYoungTAppraisedCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.IsDualVideo) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.IsDualVideo, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.IsDualVideo] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN Setid_YoungTAppraisedCaseType(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strid_YoungTAppraisedCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_YoungTAppraisedCaseType, 4, convYoungTAppraisedCase.id_YoungTAppraisedCaseType);
clsCheckSql.CheckFieldForeignKey(strid_YoungTAppraisedCaseType, 4, convYoungTAppraisedCase.id_YoungTAppraisedCaseType);
objvYoungTAppraisedCaseEN.id_YoungTAppraisedCaseType = strid_YoungTAppraisedCaseType; //青教案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.id_YoungTAppraisedCaseType) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.id_YoungTAppraisedCaseType, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.id_YoungTAppraisedCaseType] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetYoungTAppraisedCaseTypeName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strYoungTAppraisedCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTypeName, 50, convYoungTAppraisedCase.YoungTAppraisedCaseTypeName);
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTypeName = strYoungTAppraisedCaseTypeName; //青教案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.YoungTAppraisedCaseTypeName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.YoungTAppraisedCaseTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetUserTypeId(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convYoungTAppraisedCase.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convYoungTAppraisedCase.UserTypeId);
objvYoungTAppraisedCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.UserTypeId) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.UserTypeId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.UserTypeId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetUserTypeName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convYoungTAppraisedCase.UserTypeName);
objvYoungTAppraisedCaseEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.UserTypeName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.UserTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.UserTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetRecommendedDegreeId(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convYoungTAppraisedCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convYoungTAppraisedCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convYoungTAppraisedCase.RecommendedDegreeId);
objvYoungTAppraisedCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.RecommendedDegreeId) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetRecommendedDegreeName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convYoungTAppraisedCase.RecommendedDegreeName);
objvYoungTAppraisedCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.RecommendedDegreeName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetftpFileType(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convYoungTAppraisedCase.ftpFileType);
objvYoungTAppraisedCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.ftpFileType) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.ftpFileType, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.ftpFileType] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetVideoUrl(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convYoungTAppraisedCase.VideoUrl);
objvYoungTAppraisedCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.VideoUrl) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.VideoUrl, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.VideoUrl] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetVideoPath(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convYoungTAppraisedCase.VideoPath);
objvYoungTAppraisedCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.VideoPath) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.VideoPath, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.VideoPath] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetResErrMsg(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convYoungTAppraisedCase.ResErrMsg);
objvYoungTAppraisedCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.ResErrMsg) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.ResErrMsg, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.ResErrMsg] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetUpdUserId(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convYoungTAppraisedCase.UpdUserId);
objvYoungTAppraisedCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.UpdUserId) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.UpdUserId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.UpdUserId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetUpdDate(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convYoungTAppraisedCase.UpdDate);
objvYoungTAppraisedCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.UpdDate) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.UpdDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.UpdDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetMemo(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convYoungTAppraisedCase.Memo);
objvYoungTAppraisedCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.Memo) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.Memo, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.Memo] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetOwnerNameWithId(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convYoungTAppraisedCase.OwnerNameWithId);
objvYoungTAppraisedCaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.OwnerNameWithId) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.OwnerNameWithId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.OwnerNameWithId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetOwnerName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convYoungTAppraisedCase.OwnerName);
objvYoungTAppraisedCaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.OwnerName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.OwnerName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.OwnerName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetAddiSiteName(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strAddiSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAddiSiteName, 500, convYoungTAppraisedCase.AddiSiteName);
objvYoungTAppraisedCaseEN.AddiSiteName = strAddiSiteName; //AddiSiteName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.AddiSiteName) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.AddiSiteName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.AddiSiteName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetBrowseCount4Case(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvYoungTAppraisedCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.BrowseCount4Case) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseEN SetEntryYear(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN, string strEntryYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryYear, 8, convYoungTAppraisedCase.EntryYear);
objvYoungTAppraisedCaseEN.EntryYear = strEntryYear; //EntryYear
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCase.EntryYear) == false)
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp.Add(convYoungTAppraisedCase.EntryYear, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseEN.dicFldComparisonOp[convYoungTAppraisedCase.EntryYear] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvYoungTAppraisedCaseEN objvYoungTAppraisedCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.id_YoungTAppraisedCase) == true)
{
string strComparisonOp_id_YoungTAppraisedCase = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.id_YoungTAppraisedCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.id_YoungTAppraisedCase, objvYoungTAppraisedCase_Cond.id_YoungTAppraisedCase, strComparisonOp_id_YoungTAppraisedCase);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.Id_DecompressionFile) == true)
{
string strComparisonOp_Id_DecompressionFile = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.Id_DecompressionFile];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase.Id_DecompressionFile, objvYoungTAppraisedCase_Cond.Id_DecompressionFile, strComparisonOp_Id_DecompressionFile);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.FuncModuleName, objvYoungTAppraisedCase_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.YoungTAppraisedCaseID) == true)
{
string strComparisonOp_YoungTAppraisedCaseID = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.YoungTAppraisedCaseID, objvYoungTAppraisedCase_Cond.YoungTAppraisedCaseID, strComparisonOp_YoungTAppraisedCaseID);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.YoungTAppraisedCaseName) == true)
{
string strComparisonOp_YoungTAppraisedCaseName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.YoungTAppraisedCaseName, objvYoungTAppraisedCase_Cond.YoungTAppraisedCaseName, strComparisonOp_YoungTAppraisedCaseName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.YoungTAppraisedCaseText) == true)
{
string strComparisonOp_YoungTAppraisedCaseText = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.YoungTAppraisedCaseText, objvYoungTAppraisedCase_Cond.YoungTAppraisedCaseText, strComparisonOp_YoungTAppraisedCaseText);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.YoungTAppraisedCaseDate) == true)
{
string strComparisonOp_YoungTAppraisedCaseDate = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.YoungTAppraisedCaseDate, objvYoungTAppraisedCase_Cond.YoungTAppraisedCaseDate, strComparisonOp_YoungTAppraisedCaseDate);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.YoungTAppraisedCaseTime) == true)
{
string strComparisonOp_YoungTAppraisedCaseTime = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.YoungTAppraisedCaseTime, objvYoungTAppraisedCase_Cond.YoungTAppraisedCaseTime, strComparisonOp_YoungTAppraisedCaseTime);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.YoungTAppraisedCaseTheme) == true)
{
string strComparisonOp_YoungTAppraisedCaseTheme = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.YoungTAppraisedCaseTheme, objvYoungTAppraisedCase_Cond.YoungTAppraisedCaseTheme, strComparisonOp_YoungTAppraisedCaseTheme);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.YoungTAppraisedCaseDateIn) == true)
{
string strComparisonOp_YoungTAppraisedCaseDateIn = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.YoungTAppraisedCaseDateIn, objvYoungTAppraisedCase_Cond.YoungTAppraisedCaseDateIn, strComparisonOp_YoungTAppraisedCaseDateIn);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn) == true)
{
string strComparisonOp_YoungTAppraisedCaseTimeIn = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn, objvYoungTAppraisedCase_Cond.YoungTAppraisedCaseTimeIn, strComparisonOp_YoungTAppraisedCaseTimeIn);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.id_StudyLevel, objvYoungTAppraisedCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.StudyLevelName, objvYoungTAppraisedCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.id_TeachingPlan, objvYoungTAppraisedCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.Id_CaseType, objvYoungTAppraisedCase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.id_Discipline, objvYoungTAppraisedCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.DisciplineID, objvYoungTAppraisedCase_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.DisciplineName, objvYoungTAppraisedCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.id_SenateGaugeVersion, objvYoungTAppraisedCase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.senateGaugeVersionID, objvYoungTAppraisedCase_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.senateGaugeVersionName, objvYoungTAppraisedCase_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase.senateGaugeVersionTtlScore, objvYoungTAppraisedCase_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase.VersionNo, objvYoungTAppraisedCase_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.id_TeachSkill, objvYoungTAppraisedCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.TeachSkillID, objvYoungTAppraisedCase_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.SkillTypeName, objvYoungTAppraisedCase_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.TeachSkillName, objvYoungTAppraisedCase_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.TeachSkillTheory, objvYoungTAppraisedCase_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.TeachSkillOperMethod, objvYoungTAppraisedCase_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.id_SkillType, objvYoungTAppraisedCase_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.SkillTypeID, objvYoungTAppraisedCase_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.CaseLevelId, objvYoungTAppraisedCase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.DocFile) == true)
{
string strComparisonOp_DocFile = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.DocFile, objvYoungTAppraisedCase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.IsNeedGeneWord) == true)
{
if (objvYoungTAppraisedCase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase.IsNeedGeneWord);
}
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.WordCreateDate, objvYoungTAppraisedCase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.IsVisible) == true)
{
if (objvYoungTAppraisedCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase.IsVisible);
}
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.OwnerId, objvYoungTAppraisedCase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.TeacherID, objvYoungTAppraisedCase_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.TeacherName, objvYoungTAppraisedCase_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.id_XzCollege, objvYoungTAppraisedCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.CollegeID, objvYoungTAppraisedCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.CollegeName, objvYoungTAppraisedCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.CollegeNameA, objvYoungTAppraisedCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.EntryDate) == true)
{
string strComparisonOp_EntryDate = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.EntryDate, objvYoungTAppraisedCase_Cond.EntryDate, strComparisonOp_EntryDate);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.IsDualVideo) == true)
{
if (objvYoungTAppraisedCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCase.IsDualVideo);
}
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.id_YoungTAppraisedCaseType) == true)
{
string strComparisonOp_id_YoungTAppraisedCaseType = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.id_YoungTAppraisedCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.id_YoungTAppraisedCaseType, objvYoungTAppraisedCase_Cond.id_YoungTAppraisedCaseType, strComparisonOp_id_YoungTAppraisedCaseType);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.YoungTAppraisedCaseTypeName) == true)
{
string strComparisonOp_YoungTAppraisedCaseTypeName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.YoungTAppraisedCaseTypeName, objvYoungTAppraisedCase_Cond.YoungTAppraisedCaseTypeName, strComparisonOp_YoungTAppraisedCaseTypeName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.UserTypeId, objvYoungTAppraisedCase_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.UserTypeName, objvYoungTAppraisedCase_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.RecommendedDegreeId, objvYoungTAppraisedCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.RecommendedDegreeName, objvYoungTAppraisedCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.ftpFileType, objvYoungTAppraisedCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.VideoUrl, objvYoungTAppraisedCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.VideoPath, objvYoungTAppraisedCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.ResErrMsg, objvYoungTAppraisedCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.UpdUserId, objvYoungTAppraisedCase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.UpdDate, objvYoungTAppraisedCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.Memo) == true)
{
string strComparisonOp_Memo = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.Memo, objvYoungTAppraisedCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.OwnerNameWithId, objvYoungTAppraisedCase_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.OwnerName, objvYoungTAppraisedCase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.AddiSiteName) == true)
{
string strComparisonOp_AddiSiteName = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.AddiSiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.AddiSiteName, objvYoungTAppraisedCase_Cond.AddiSiteName, strComparisonOp_AddiSiteName);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCase.BrowseCount4Case, objvYoungTAppraisedCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvYoungTAppraisedCase_Cond.IsUpdated(convYoungTAppraisedCase.EntryYear) == true)
{
string strComparisonOp_EntryYear = objvYoungTAppraisedCase_Cond.dicFldComparisonOp[convYoungTAppraisedCase.EntryYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCase.EntryYear, objvYoungTAppraisedCase_Cond.EntryYear, strComparisonOp_EntryYear);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v青教评优案例(vYoungTAppraisedCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvYoungTAppraisedCaseWApi
{
private static readonly string mstrApiControllerName = "vYoungTAppraisedCaseApi";

 public clsvYoungTAppraisedCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_YoungTAppraisedCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvYoungTAppraisedCaseEN GetObjByid_YoungTAppraisedCase(string strid_YoungTAppraisedCase)
{
string strAction = "GetObjByid_YoungTAppraisedCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_YoungTAppraisedCase"] = strid_YoungTAppraisedCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvYoungTAppraisedCaseEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCaseEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCaseEN;
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
 /// <param name = "strid_YoungTAppraisedCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvYoungTAppraisedCaseEN GetObjByid_YoungTAppraisedCase_WA_Cache(string strid_YoungTAppraisedCase)
{
string strAction = "GetObjByid_YoungTAppraisedCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_YoungTAppraisedCase"] = strid_YoungTAppraisedCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvYoungTAppraisedCaseEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCaseEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCaseEN;
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
public static clsvYoungTAppraisedCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN = null;
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
objvYoungTAppraisedCaseEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCaseEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCaseEN;
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
 /// <param name = "strid_YoungTAppraisedCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvYoungTAppraisedCaseEN GetObjByid_YoungTAppraisedCase_Cache(string strid_YoungTAppraisedCase)
{
if (string.IsNullOrEmpty(strid_YoungTAppraisedCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseEN._CurrTabName_S);
List<clsvYoungTAppraisedCaseEN> arrvYoungTAppraisedCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvYoungTAppraisedCaseEN> arrvYoungTAppraisedCaseObjLst_Sel =
from objvYoungTAppraisedCaseEN in arrvYoungTAppraisedCaseObjLst_Cache
where objvYoungTAppraisedCaseEN.id_YoungTAppraisedCase == strid_YoungTAppraisedCase
select objvYoungTAppraisedCaseEN;
if (arrvYoungTAppraisedCaseObjLst_Sel.Count() == 0)
{
   clsvYoungTAppraisedCaseEN obj = clsvYoungTAppraisedCaseWApi.GetObjByid_YoungTAppraisedCase(strid_YoungTAppraisedCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvYoungTAppraisedCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvYoungTAppraisedCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvYoungTAppraisedCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseEN> GetObjLstById_YoungTAppraisedCaseLst(List<string> arrId_YoungTAppraisedCase)
{
 List<clsvYoungTAppraisedCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_YoungTAppraisedCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_YoungTAppraisedCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_YoungTAppraisedCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvYoungTAppraisedCaseEN> GetObjLstById_YoungTAppraisedCaseLst_Cache(List<string> arrId_YoungTAppraisedCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseEN._CurrTabName_S);
List<clsvYoungTAppraisedCaseEN> arrvYoungTAppraisedCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvYoungTAppraisedCaseEN> arrvYoungTAppraisedCaseObjLst_Sel =
from objvYoungTAppraisedCaseEN in arrvYoungTAppraisedCaseObjLst_Cache
where arrId_YoungTAppraisedCase.Contains(objvYoungTAppraisedCaseEN.id_YoungTAppraisedCase)
select objvYoungTAppraisedCaseEN;
return arrvYoungTAppraisedCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvYoungTAppraisedCaseEN> GetObjLstById_YoungTAppraisedCaseLst_WA_Cache(List<string> arrId_YoungTAppraisedCase)
{
 List<clsvYoungTAppraisedCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_YoungTAppraisedCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_YoungTAppraisedCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvYoungTAppraisedCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvYoungTAppraisedCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvYoungTAppraisedCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvYoungTAppraisedCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_YoungTAppraisedCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_YoungTAppraisedCase"] = strid_YoungTAppraisedCase
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
 /// <param name = "objvYoungTAppraisedCaseENS">源对象</param>
 /// <param name = "objvYoungTAppraisedCaseENT">目标对象</param>
 public static void CopyTo(clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseENS, clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseENT)
{
try
{
objvYoungTAppraisedCaseENT.id_YoungTAppraisedCase = objvYoungTAppraisedCaseENS.id_YoungTAppraisedCase; //青教评优案例流水号
objvYoungTAppraisedCaseENT.Id_DecompressionFile = objvYoungTAppraisedCaseENS.Id_DecompressionFile; //解压缩文件流水号
objvYoungTAppraisedCaseENT.FuncModuleName = objvYoungTAppraisedCaseENS.FuncModuleName; //功能模块名称
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseID = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseID; //青教评优案例ID
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseName = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseName; //青教评优案例名称
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseText = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseText; //案例文本内容
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseDate = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseDate; //青教评优教学日期
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseTime = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseTime; //青教评优教学时间
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseTheme = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseTheme; //青教评优案例主题词
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseDateIn = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseDateIn; //案例入库日期
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseTimeIn = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseTimeIn; //案例入库时间
objvYoungTAppraisedCaseENT.id_StudyLevel = objvYoungTAppraisedCaseENS.id_StudyLevel; //id_StudyLevel
objvYoungTAppraisedCaseENT.StudyLevelName = objvYoungTAppraisedCaseENS.StudyLevelName; //学段名称
objvYoungTAppraisedCaseENT.id_TeachingPlan = objvYoungTAppraisedCaseENS.id_TeachingPlan; //教案流水号
objvYoungTAppraisedCaseENT.Id_CaseType = objvYoungTAppraisedCaseENS.Id_CaseType; //案例类型流水号
objvYoungTAppraisedCaseENT.id_Discipline = objvYoungTAppraisedCaseENS.id_Discipline; //学科流水号
objvYoungTAppraisedCaseENT.DisciplineID = objvYoungTAppraisedCaseENS.DisciplineID; //学科ID
objvYoungTAppraisedCaseENT.DisciplineName = objvYoungTAppraisedCaseENS.DisciplineName; //学科名称
objvYoungTAppraisedCaseENT.id_SenateGaugeVersion = objvYoungTAppraisedCaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvYoungTAppraisedCaseENT.senateGaugeVersionID = objvYoungTAppraisedCaseENS.senateGaugeVersionID; //评价量表版本ID
objvYoungTAppraisedCaseENT.senateGaugeVersionName = objvYoungTAppraisedCaseENS.senateGaugeVersionName; //评价量表版本名称
objvYoungTAppraisedCaseENT.senateGaugeVersionTtlScore = objvYoungTAppraisedCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvYoungTAppraisedCaseENT.VersionNo = objvYoungTAppraisedCaseENS.VersionNo; //版本号
objvYoungTAppraisedCaseENT.id_TeachSkill = objvYoungTAppraisedCaseENS.id_TeachSkill; //教学技能流水号
objvYoungTAppraisedCaseENT.TeachSkillID = objvYoungTAppraisedCaseENS.TeachSkillID; //教学技能ID
objvYoungTAppraisedCaseENT.SkillTypeName = objvYoungTAppraisedCaseENS.SkillTypeName; //技能类型名称
objvYoungTAppraisedCaseENT.TeachSkillName = objvYoungTAppraisedCaseENS.TeachSkillName; //教学技能名称
objvYoungTAppraisedCaseENT.TeachSkillTheory = objvYoungTAppraisedCaseENS.TeachSkillTheory; //教学技能理论阐述
objvYoungTAppraisedCaseENT.TeachSkillOperMethod = objvYoungTAppraisedCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvYoungTAppraisedCaseENT.id_SkillType = objvYoungTAppraisedCaseENS.id_SkillType; //技能类型流水号
objvYoungTAppraisedCaseENT.SkillTypeID = objvYoungTAppraisedCaseENS.SkillTypeID; //技能类型ID
objvYoungTAppraisedCaseENT.CaseLevelId = objvYoungTAppraisedCaseENS.CaseLevelId; //课例等级Id
objvYoungTAppraisedCaseENT.DocFile = objvYoungTAppraisedCaseENS.DocFile; //生成的Word文件名
objvYoungTAppraisedCaseENT.IsNeedGeneWord = objvYoungTAppraisedCaseENS.IsNeedGeneWord; //是否需要生成Word
objvYoungTAppraisedCaseENT.WordCreateDate = objvYoungTAppraisedCaseENS.WordCreateDate; //Word生成日期
objvYoungTAppraisedCaseENT.IsVisible = objvYoungTAppraisedCaseENS.IsVisible; //是否显示
objvYoungTAppraisedCaseENT.OwnerId = objvYoungTAppraisedCaseENS.OwnerId; //拥有者Id
objvYoungTAppraisedCaseENT.TeacherID = objvYoungTAppraisedCaseENS.TeacherID; //教师工号
objvYoungTAppraisedCaseENT.TeacherName = objvYoungTAppraisedCaseENS.TeacherName; //教师姓名
objvYoungTAppraisedCaseENT.id_XzCollege = objvYoungTAppraisedCaseENS.id_XzCollege; //学院流水号
objvYoungTAppraisedCaseENT.CollegeID = objvYoungTAppraisedCaseENS.CollegeID; //学院ID
objvYoungTAppraisedCaseENT.CollegeName = objvYoungTAppraisedCaseENS.CollegeName; //学院名称
objvYoungTAppraisedCaseENT.CollegeNameA = objvYoungTAppraisedCaseENS.CollegeNameA; //学院名称简写
objvYoungTAppraisedCaseENT.EntryDate = objvYoungTAppraisedCaseENS.EntryDate; //进校日期
objvYoungTAppraisedCaseENT.IsDualVideo = objvYoungTAppraisedCaseENS.IsDualVideo; //是否双视频
objvYoungTAppraisedCaseENT.id_YoungTAppraisedCaseType = objvYoungTAppraisedCaseENS.id_YoungTAppraisedCaseType; //青教案例类型流水号
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseTypeName = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseTypeName; //青教案例类型名称
objvYoungTAppraisedCaseENT.UserTypeId = objvYoungTAppraisedCaseENS.UserTypeId; //用户类型Id
objvYoungTAppraisedCaseENT.UserTypeName = objvYoungTAppraisedCaseENS.UserTypeName; //用户类型名称
objvYoungTAppraisedCaseENT.RecommendedDegreeId = objvYoungTAppraisedCaseENS.RecommendedDegreeId; //推荐度Id
objvYoungTAppraisedCaseENT.RecommendedDegreeName = objvYoungTAppraisedCaseENS.RecommendedDegreeName; //推荐度名称
objvYoungTAppraisedCaseENT.ftpFileType = objvYoungTAppraisedCaseENS.ftpFileType; //ftp文件类型
objvYoungTAppraisedCaseENT.VideoUrl = objvYoungTAppraisedCaseENS.VideoUrl; //视频Url
objvYoungTAppraisedCaseENT.VideoPath = objvYoungTAppraisedCaseENS.VideoPath; //视频目录
objvYoungTAppraisedCaseENT.ResErrMsg = objvYoungTAppraisedCaseENS.ResErrMsg; //资源错误信息
objvYoungTAppraisedCaseENT.UpdUserId = objvYoungTAppraisedCaseENS.UpdUserId; //修改用户Id
objvYoungTAppraisedCaseENT.UpdDate = objvYoungTAppraisedCaseENS.UpdDate; //修改日期
objvYoungTAppraisedCaseENT.Memo = objvYoungTAppraisedCaseENS.Memo; //备注
objvYoungTAppraisedCaseENT.OwnerNameWithId = objvYoungTAppraisedCaseENS.OwnerNameWithId; //拥有者名称附Id
objvYoungTAppraisedCaseENT.OwnerName = objvYoungTAppraisedCaseENS.OwnerName; //拥有者姓名
objvYoungTAppraisedCaseENT.AddiSiteName = objvYoungTAppraisedCaseENS.AddiSiteName; //AddiSiteName
objvYoungTAppraisedCaseENT.BrowseCount4Case = objvYoungTAppraisedCaseENS.BrowseCount4Case; //课例浏览次数
objvYoungTAppraisedCaseENT.EntryYear = objvYoungTAppraisedCaseENS.EntryYear; //EntryYear
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
public static DataTable ToDataTable(List<clsvYoungTAppraisedCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvYoungTAppraisedCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvYoungTAppraisedCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvYoungTAppraisedCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvYoungTAppraisedCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvYoungTAppraisedCaseEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_YoungTAppraisedCase");
//if (arrvYoungTAppraisedCaseObjLst_Cache == null)
//{
//arrvYoungTAppraisedCaseObjLst_Cache = await clsvYoungTAppraisedCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseEN._CurrTabName_S);
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
public static List<clsvYoungTAppraisedCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseEN._CurrTabName_S);
List<clsvYoungTAppraisedCaseEN> arrvYoungTAppraisedCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvYoungTAppraisedCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvYoungTAppraisedCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convYoungTAppraisedCase.id_YoungTAppraisedCase, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.Id_DecompressionFile, Type.GetType("System.Int64"));
objDT.Columns.Add(convYoungTAppraisedCase.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.YoungTAppraisedCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.YoungTAppraisedCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.YoungTAppraisedCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.YoungTAppraisedCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.YoungTAppraisedCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.YoungTAppraisedCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.YoungTAppraisedCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convYoungTAppraisedCase.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convYoungTAppraisedCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.EntryDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCase.id_YoungTAppraisedCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.YoungTAppraisedCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.AddiSiteName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCase.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convYoungTAppraisedCase.EntryYear, Type.GetType("System.String"));
foreach (clsvYoungTAppraisedCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convYoungTAppraisedCase.id_YoungTAppraisedCase] = objInFor[convYoungTAppraisedCase.id_YoungTAppraisedCase];
objDR[convYoungTAppraisedCase.Id_DecompressionFile] = objInFor[convYoungTAppraisedCase.Id_DecompressionFile];
objDR[convYoungTAppraisedCase.FuncModuleName] = objInFor[convYoungTAppraisedCase.FuncModuleName];
objDR[convYoungTAppraisedCase.YoungTAppraisedCaseID] = objInFor[convYoungTAppraisedCase.YoungTAppraisedCaseID];
objDR[convYoungTAppraisedCase.YoungTAppraisedCaseName] = objInFor[convYoungTAppraisedCase.YoungTAppraisedCaseName];
objDR[convYoungTAppraisedCase.YoungTAppraisedCaseText] = objInFor[convYoungTAppraisedCase.YoungTAppraisedCaseText];
objDR[convYoungTAppraisedCase.YoungTAppraisedCaseDate] = objInFor[convYoungTAppraisedCase.YoungTAppraisedCaseDate];
objDR[convYoungTAppraisedCase.YoungTAppraisedCaseTime] = objInFor[convYoungTAppraisedCase.YoungTAppraisedCaseTime];
objDR[convYoungTAppraisedCase.YoungTAppraisedCaseTheme] = objInFor[convYoungTAppraisedCase.YoungTAppraisedCaseTheme];
objDR[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn] = objInFor[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn];
objDR[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] = objInFor[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn];
objDR[convYoungTAppraisedCase.id_StudyLevel] = objInFor[convYoungTAppraisedCase.id_StudyLevel];
objDR[convYoungTAppraisedCase.StudyLevelName] = objInFor[convYoungTAppraisedCase.StudyLevelName];
objDR[convYoungTAppraisedCase.id_TeachingPlan] = objInFor[convYoungTAppraisedCase.id_TeachingPlan];
objDR[convYoungTAppraisedCase.Id_CaseType] = objInFor[convYoungTAppraisedCase.Id_CaseType];
objDR[convYoungTAppraisedCase.id_Discipline] = objInFor[convYoungTAppraisedCase.id_Discipline];
objDR[convYoungTAppraisedCase.DisciplineID] = objInFor[convYoungTAppraisedCase.DisciplineID];
objDR[convYoungTAppraisedCase.DisciplineName] = objInFor[convYoungTAppraisedCase.DisciplineName];
objDR[convYoungTAppraisedCase.id_SenateGaugeVersion] = objInFor[convYoungTAppraisedCase.id_SenateGaugeVersion];
objDR[convYoungTAppraisedCase.senateGaugeVersionID] = objInFor[convYoungTAppraisedCase.senateGaugeVersionID];
objDR[convYoungTAppraisedCase.senateGaugeVersionName] = objInFor[convYoungTAppraisedCase.senateGaugeVersionName];
objDR[convYoungTAppraisedCase.senateGaugeVersionTtlScore] = objInFor[convYoungTAppraisedCase.senateGaugeVersionTtlScore];
objDR[convYoungTAppraisedCase.VersionNo] = objInFor[convYoungTAppraisedCase.VersionNo];
objDR[convYoungTAppraisedCase.id_TeachSkill] = objInFor[convYoungTAppraisedCase.id_TeachSkill];
objDR[convYoungTAppraisedCase.TeachSkillID] = objInFor[convYoungTAppraisedCase.TeachSkillID];
objDR[convYoungTAppraisedCase.SkillTypeName] = objInFor[convYoungTAppraisedCase.SkillTypeName];
objDR[convYoungTAppraisedCase.TeachSkillName] = objInFor[convYoungTAppraisedCase.TeachSkillName];
objDR[convYoungTAppraisedCase.TeachSkillTheory] = objInFor[convYoungTAppraisedCase.TeachSkillTheory];
objDR[convYoungTAppraisedCase.TeachSkillOperMethod] = objInFor[convYoungTAppraisedCase.TeachSkillOperMethod];
objDR[convYoungTAppraisedCase.id_SkillType] = objInFor[convYoungTAppraisedCase.id_SkillType];
objDR[convYoungTAppraisedCase.SkillTypeID] = objInFor[convYoungTAppraisedCase.SkillTypeID];
objDR[convYoungTAppraisedCase.CaseLevelId] = objInFor[convYoungTAppraisedCase.CaseLevelId];
objDR[convYoungTAppraisedCase.DocFile] = objInFor[convYoungTAppraisedCase.DocFile];
objDR[convYoungTAppraisedCase.IsNeedGeneWord] = objInFor[convYoungTAppraisedCase.IsNeedGeneWord];
objDR[convYoungTAppraisedCase.WordCreateDate] = objInFor[convYoungTAppraisedCase.WordCreateDate];
objDR[convYoungTAppraisedCase.IsVisible] = objInFor[convYoungTAppraisedCase.IsVisible];
objDR[convYoungTAppraisedCase.OwnerId] = objInFor[convYoungTAppraisedCase.OwnerId];
objDR[convYoungTAppraisedCase.TeacherID] = objInFor[convYoungTAppraisedCase.TeacherID];
objDR[convYoungTAppraisedCase.TeacherName] = objInFor[convYoungTAppraisedCase.TeacherName];
objDR[convYoungTAppraisedCase.id_XzCollege] = objInFor[convYoungTAppraisedCase.id_XzCollege];
objDR[convYoungTAppraisedCase.CollegeID] = objInFor[convYoungTAppraisedCase.CollegeID];
objDR[convYoungTAppraisedCase.CollegeName] = objInFor[convYoungTAppraisedCase.CollegeName];
objDR[convYoungTAppraisedCase.CollegeNameA] = objInFor[convYoungTAppraisedCase.CollegeNameA];
objDR[convYoungTAppraisedCase.EntryDate] = objInFor[convYoungTAppraisedCase.EntryDate];
objDR[convYoungTAppraisedCase.IsDualVideo] = objInFor[convYoungTAppraisedCase.IsDualVideo];
objDR[convYoungTAppraisedCase.id_YoungTAppraisedCaseType] = objInFor[convYoungTAppraisedCase.id_YoungTAppraisedCaseType];
objDR[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName] = objInFor[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName];
objDR[convYoungTAppraisedCase.UserTypeId] = objInFor[convYoungTAppraisedCase.UserTypeId];
objDR[convYoungTAppraisedCase.UserTypeName] = objInFor[convYoungTAppraisedCase.UserTypeName];
objDR[convYoungTAppraisedCase.RecommendedDegreeId] = objInFor[convYoungTAppraisedCase.RecommendedDegreeId];
objDR[convYoungTAppraisedCase.RecommendedDegreeName] = objInFor[convYoungTAppraisedCase.RecommendedDegreeName];
objDR[convYoungTAppraisedCase.ftpFileType] = objInFor[convYoungTAppraisedCase.ftpFileType];
objDR[convYoungTAppraisedCase.VideoUrl] = objInFor[convYoungTAppraisedCase.VideoUrl];
objDR[convYoungTAppraisedCase.VideoPath] = objInFor[convYoungTAppraisedCase.VideoPath];
objDR[convYoungTAppraisedCase.ResErrMsg] = objInFor[convYoungTAppraisedCase.ResErrMsg];
objDR[convYoungTAppraisedCase.UpdUserId] = objInFor[convYoungTAppraisedCase.UpdUserId];
objDR[convYoungTAppraisedCase.UpdDate] = objInFor[convYoungTAppraisedCase.UpdDate];
objDR[convYoungTAppraisedCase.Memo] = objInFor[convYoungTAppraisedCase.Memo];
objDR[convYoungTAppraisedCase.OwnerNameWithId] = objInFor[convYoungTAppraisedCase.OwnerNameWithId];
objDR[convYoungTAppraisedCase.OwnerName] = objInFor[convYoungTAppraisedCase.OwnerName];
objDR[convYoungTAppraisedCase.AddiSiteName] = objInFor[convYoungTAppraisedCase.AddiSiteName];
objDR[convYoungTAppraisedCase.BrowseCount4Case] = objInFor[convYoungTAppraisedCase.BrowseCount4Case];
objDR[convYoungTAppraisedCase.EntryYear] = objInFor[convYoungTAppraisedCase.EntryYear];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}