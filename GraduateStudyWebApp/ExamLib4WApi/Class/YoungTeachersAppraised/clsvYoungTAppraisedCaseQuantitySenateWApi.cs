
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCaseQuantitySenateWApi
 表名:vYoungTAppraisedCaseQuantitySenate(01120445)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:42
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
public static class clsvYoungTAppraisedCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvYoungTAppraisedCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN Setid_YoungTAppraisedCase(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strid_YoungTAppraisedCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_YoungTAppraisedCase, convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase);
clsCheckSql.CheckFieldLen(strid_YoungTAppraisedCase, 8, convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase);
clsCheckSql.CheckFieldForeignKey(strid_YoungTAppraisedCase, 8, convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase);
objvYoungTAppraisedCaseQuantitySenateEN.id_YoungTAppraisedCase = strid_YoungTAppraisedCase; //青教评优案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetYoungTAppraisedCaseID(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strYoungTAppraisedCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseID, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseID, 8, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseID, 8, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID);
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseID = strYoungTAppraisedCaseID; //青教评优案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetYoungTAppraisedCaseName(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strYoungTAppraisedCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseName, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseName, 100, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName);
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseName = strYoungTAppraisedCaseName; //青教评优案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetTeacherID(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convYoungTAppraisedCaseQuantitySenate.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convYoungTAppraisedCaseQuantitySenate.TeacherID);
objvYoungTAppraisedCaseQuantitySenateEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.TeacherID) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.TeacherID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.TeacherID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetTeacherName(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, convYoungTAppraisedCaseQuantitySenate.TeacherName);
clsCheckSql.CheckFieldLen(strTeacherName, 50, convYoungTAppraisedCaseQuantitySenate.TeacherName);
objvYoungTAppraisedCaseQuantitySenateEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.TeacherName) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.TeacherName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.TeacherName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetBrowseCount(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
	{
objvYoungTAppraisedCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.BrowseCount) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetSenateTheme(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convYoungTAppraisedCaseQuantitySenate.SenateTheme);
objvYoungTAppraisedCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.SenateTheme) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetSenateContent(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convYoungTAppraisedCaseQuantitySenate.SenateContent);
objvYoungTAppraisedCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.SenateContent) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetSenateTotalScore(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convYoungTAppraisedCaseQuantitySenate.SenateTotalScore);
objvYoungTAppraisedCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.SenateTotalScore) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetSenateDate(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convYoungTAppraisedCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convYoungTAppraisedCaseQuantitySenate.SenateDate);
objvYoungTAppraisedCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.SenateDate) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetSenateTime(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convYoungTAppraisedCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convYoungTAppraisedCaseQuantitySenate.SenateTime);
objvYoungTAppraisedCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.SenateTime) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion);
objvYoungTAppraisedCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID);
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName);
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetUpdUser(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convYoungTAppraisedCaseQuantitySenate.UpdUser);
objvYoungTAppraisedCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.UpdUser) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetUpdUserName(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convYoungTAppraisedCaseQuantitySenate.UpdUserName);
objvYoungTAppraisedCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.UpdUserName) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetCollegeID(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convYoungTAppraisedCaseQuantitySenate.CollegeID);
objvYoungTAppraisedCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.CollegeID) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetCollegeName(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convYoungTAppraisedCaseQuantitySenate.CollegeName);
objvYoungTAppraisedCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.CollegeName) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetSenateIp(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convYoungTAppraisedCaseQuantitySenate.SenateIp);
objvYoungTAppraisedCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.SenateIp) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetCollegeID_Mark(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strCollegeID_Mark, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID_Mark, 4, convYoungTAppraisedCaseQuantitySenate.CollegeID_Mark);
objvYoungTAppraisedCaseQuantitySenateEN.CollegeID_Mark = strCollegeID_Mark; //CollegeID_Mark
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.CollegeID_Mark) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.CollegeID_Mark, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.CollegeID_Mark] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetCollegeName_Mark(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strCollegeName_Mark, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName_Mark, 100, convYoungTAppraisedCaseQuantitySenate.CollegeName_Mark);
objvYoungTAppraisedCaseQuantitySenateEN.CollegeName_Mark = strCollegeName_Mark; //CollegeName_Mark
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.CollegeName_Mark) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.CollegeName_Mark, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.CollegeName_Mark] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN Setid_College_Mark(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strid_College_Mark, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_College_Mark, 4, convYoungTAppraisedCaseQuantitySenate.id_College_Mark);
clsCheckSql.CheckFieldForeignKey(strid_College_Mark, 4, convYoungTAppraisedCaseQuantitySenate.id_College_Mark);
objvYoungTAppraisedCaseQuantitySenateEN.id_College_Mark = strid_College_Mark; //id_College_Mark
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.id_College_Mark) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.id_College_Mark, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_College_Mark] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetStuIdTeacherId(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strStuIdTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId);
objvYoungTAppraisedCaseQuantitySenateEN.StuIdTeacherId = strStuIdTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetUserId(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convYoungTAppraisedCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convYoungTAppraisedCaseQuantitySenate.UserId);
objvYoungTAppraisedCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.UserId) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetUserName(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convYoungTAppraisedCaseQuantitySenate.UserName);
objvYoungTAppraisedCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.UserName) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetOwnerId(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convYoungTAppraisedCaseQuantitySenate.OwnerId);
objvYoungTAppraisedCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.OwnerId) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetAppraiseTypeName(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName);
objvYoungTAppraisedCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetFuncModuleId(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convYoungTAppraisedCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convYoungTAppraisedCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convYoungTAppraisedCaseQuantitySenate.FuncModuleId);
objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.FuncModuleId) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetFuncModuleName(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convYoungTAppraisedCaseQuantitySenate.FuncModuleName);
objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.FuncModuleName) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN Setid_AppraiseType(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convYoungTAppraisedCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convYoungTAppraisedCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convYoungTAppraisedCaseQuantitySenate.id_AppraiseType);
objvYoungTAppraisedCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.id_AppraiseType) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN Setid_MicroteachCase(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase);
objvYoungTAppraisedCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetOwnerName(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convYoungTAppraisedCaseQuantitySenate.OwnerName);
objvYoungTAppraisedCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.OwnerName) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetYoungTAppraisedCaseDate(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strYoungTAppraisedCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseDate, 8, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldForeignKey(strYoungTAppraisedCaseDate, 8, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate);
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseDate = strYoungTAppraisedCaseDate; //青教评优教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetYoungTAppraisedCaseTypeName(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strYoungTAppraisedCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseTypeName, 50, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName);
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseTypeName = strYoungTAppraisedCaseTypeName; //青教案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetUserNameWithUserId(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId);
objvYoungTAppraisedCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN Setid_XzCollege(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convYoungTAppraisedCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convYoungTAppraisedCaseQuantitySenate.id_XzCollege);
objvYoungTAppraisedCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.id_XzCollege) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN SetCollegeNameA(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convYoungTAppraisedCaseQuantitySenate.CollegeNameA);
objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseQuantitySenate.CollegeNameA) == false)
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseQuantitySenateEN.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseQuantitySenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCaseQuantitySenate.id_microteachCaseQuantitySenate, objvYoungTAppraisedCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase) == true)
{
string strComparisonOp_id_YoungTAppraisedCase = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase, objvYoungTAppraisedCaseQuantitySenate_Cond.id_YoungTAppraisedCase, strComparisonOp_id_YoungTAppraisedCase);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID) == true)
{
string strComparisonOp_YoungTAppraisedCaseID = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID, objvYoungTAppraisedCaseQuantitySenate_Cond.YoungTAppraisedCaseID, strComparisonOp_YoungTAppraisedCaseID);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName) == true)
{
string strComparisonOp_YoungTAppraisedCaseName = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName, objvYoungTAppraisedCaseQuantitySenate_Cond.YoungTAppraisedCaseName, strComparisonOp_YoungTAppraisedCaseName);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.TeacherID, objvYoungTAppraisedCaseQuantitySenate_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.TeacherName, objvYoungTAppraisedCaseQuantitySenate_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCaseQuantitySenate.BrowseCount, objvYoungTAppraisedCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.SenateTheme, objvYoungTAppraisedCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.SenateContent, objvYoungTAppraisedCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCaseQuantitySenate.SenateTotalScore, objvYoungTAppraisedCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.SenateDate, objvYoungTAppraisedCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.SenateTime, objvYoungTAppraisedCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion, objvYoungTAppraisedCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID, objvYoungTAppraisedCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName, objvYoungTAppraisedCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.UpdUser, objvYoungTAppraisedCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.UpdUserName, objvYoungTAppraisedCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.CollegeID, objvYoungTAppraisedCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.CollegeName, objvYoungTAppraisedCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.SenateIp, objvYoungTAppraisedCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.CollegeID_Mark) == true)
{
string strComparisonOp_CollegeID_Mark = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.CollegeID_Mark];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.CollegeID_Mark, objvYoungTAppraisedCaseQuantitySenate_Cond.CollegeID_Mark, strComparisonOp_CollegeID_Mark);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.CollegeName_Mark) == true)
{
string strComparisonOp_CollegeName_Mark = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.CollegeName_Mark];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.CollegeName_Mark, objvYoungTAppraisedCaseQuantitySenate_Cond.CollegeName_Mark, strComparisonOp_CollegeName_Mark);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.id_College_Mark) == true)
{
string strComparisonOp_id_College_Mark = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_College_Mark];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.id_College_Mark, objvYoungTAppraisedCaseQuantitySenate_Cond.id_College_Mark, strComparisonOp_id_College_Mark);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId) == true)
{
string strComparisonOp_StuIdTeacherId = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId, objvYoungTAppraisedCaseQuantitySenate_Cond.StuIdTeacherId, strComparisonOp_StuIdTeacherId);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.UserId, objvYoungTAppraisedCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.UserName, objvYoungTAppraisedCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.OwnerId, objvYoungTAppraisedCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName, objvYoungTAppraisedCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.FuncModuleId, objvYoungTAppraisedCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.FuncModuleName, objvYoungTAppraisedCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.id_AppraiseType, objvYoungTAppraisedCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase, objvYoungTAppraisedCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.OwnerName, objvYoungTAppraisedCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore, objvYoungTAppraisedCaseQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate) == true)
{
string strComparisonOp_YoungTAppraisedCaseDate = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate, objvYoungTAppraisedCaseQuantitySenate_Cond.YoungTAppraisedCaseDate, strComparisonOp_YoungTAppraisedCaseDate);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName) == true)
{
string strComparisonOp_YoungTAppraisedCaseTypeName = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName, objvYoungTAppraisedCaseQuantitySenate_Cond.YoungTAppraisedCaseTypeName, strComparisonOp_YoungTAppraisedCaseTypeName);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId, objvYoungTAppraisedCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.id_XzCollege, objvYoungTAppraisedCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvYoungTAppraisedCaseQuantitySenate_Cond.IsUpdated(convYoungTAppraisedCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvYoungTAppraisedCaseQuantitySenate_Cond.dicFldComparisonOp[convYoungTAppraisedCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseQuantitySenate.CollegeNameA, objvYoungTAppraisedCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v青教评优专家量化评价(vYoungTAppraisedCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvYoungTAppraisedCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vYoungTAppraisedCaseQuantitySenateApi";

 public clsvYoungTAppraisedCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvYoungTAppraisedCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN = null;
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
objvYoungTAppraisedCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCaseQuantitySenateEN;
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
public static clsvYoungTAppraisedCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN = null;
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
objvYoungTAppraisedCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCaseQuantitySenateEN;
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
public static clsvYoungTAppraisedCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN = null;
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
objvYoungTAppraisedCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCaseQuantitySenateEN;
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
public static clsvYoungTAppraisedCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseQuantitySenateEN._CurrTabName_S);
List<clsvYoungTAppraisedCaseQuantitySenateEN> arrvYoungTAppraisedCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvYoungTAppraisedCaseQuantitySenateEN> arrvYoungTAppraisedCaseQuantitySenateObjLst_Sel =
from objvYoungTAppraisedCaseQuantitySenateEN in arrvYoungTAppraisedCaseQuantitySenateObjLst_Cache
where objvYoungTAppraisedCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvYoungTAppraisedCaseQuantitySenateEN;
if (arrvYoungTAppraisedCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvYoungTAppraisedCaseQuantitySenateEN obj = clsvYoungTAppraisedCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvYoungTAppraisedCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvYoungTAppraisedCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvYoungTAppraisedCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseQuantitySenateEN._CurrTabName_S);
List<clsvYoungTAppraisedCaseQuantitySenateEN> arrvYoungTAppraisedCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvYoungTAppraisedCaseQuantitySenateEN> arrvYoungTAppraisedCaseQuantitySenateObjLst_Sel =
from objvYoungTAppraisedCaseQuantitySenateEN in arrvYoungTAppraisedCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvYoungTAppraisedCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvYoungTAppraisedCaseQuantitySenateEN;
return arrvYoungTAppraisedCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvYoungTAppraisedCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateENS, clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateENT)
{
try
{
objvYoungTAppraisedCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvYoungTAppraisedCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvYoungTAppraisedCaseQuantitySenateENT.id_YoungTAppraisedCase = objvYoungTAppraisedCaseQuantitySenateENS.id_YoungTAppraisedCase; //青教评优案例流水号
objvYoungTAppraisedCaseQuantitySenateENT.YoungTAppraisedCaseID = objvYoungTAppraisedCaseQuantitySenateENS.YoungTAppraisedCaseID; //青教评优案例ID
objvYoungTAppraisedCaseQuantitySenateENT.YoungTAppraisedCaseName = objvYoungTAppraisedCaseQuantitySenateENS.YoungTAppraisedCaseName; //青教评优案例名称
objvYoungTAppraisedCaseQuantitySenateENT.TeacherID = objvYoungTAppraisedCaseQuantitySenateENS.TeacherID; //教师工号
objvYoungTAppraisedCaseQuantitySenateENT.TeacherName = objvYoungTAppraisedCaseQuantitySenateENS.TeacherName; //教师姓名
objvYoungTAppraisedCaseQuantitySenateENT.BrowseCount = objvYoungTAppraisedCaseQuantitySenateENS.BrowseCount; //浏览次数
objvYoungTAppraisedCaseQuantitySenateENT.SenateTheme = objvYoungTAppraisedCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvYoungTAppraisedCaseQuantitySenateENT.SenateContent = objvYoungTAppraisedCaseQuantitySenateENS.SenateContent; //评价内容
objvYoungTAppraisedCaseQuantitySenateENT.SenateTotalScore = objvYoungTAppraisedCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvYoungTAppraisedCaseQuantitySenateENT.SenateDate = objvYoungTAppraisedCaseQuantitySenateENS.SenateDate; //评价日期
objvYoungTAppraisedCaseQuantitySenateENT.SenateTime = objvYoungTAppraisedCaseQuantitySenateENS.SenateTime; //评价时间
objvYoungTAppraisedCaseQuantitySenateENT.id_SenateGaugeVersion = objvYoungTAppraisedCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
objvYoungTAppraisedCaseQuantitySenateENT.senateGaugeVersionID = objvYoungTAppraisedCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvYoungTAppraisedCaseQuantitySenateENT.senateGaugeVersionName = objvYoungTAppraisedCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvYoungTAppraisedCaseQuantitySenateENT.UpdUser = objvYoungTAppraisedCaseQuantitySenateENS.UpdUser; //修改人
objvYoungTAppraisedCaseQuantitySenateENT.UpdUserName = objvYoungTAppraisedCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvYoungTAppraisedCaseQuantitySenateENT.CollegeID = objvYoungTAppraisedCaseQuantitySenateENS.CollegeID; //学院ID
objvYoungTAppraisedCaseQuantitySenateENT.CollegeName = objvYoungTAppraisedCaseQuantitySenateENS.CollegeName; //学院名称
objvYoungTAppraisedCaseQuantitySenateENT.SenateIp = objvYoungTAppraisedCaseQuantitySenateENS.SenateIp; //评议Ip
objvYoungTAppraisedCaseQuantitySenateENT.CollegeID_Mark = objvYoungTAppraisedCaseQuantitySenateENS.CollegeID_Mark; //CollegeID_Mark
objvYoungTAppraisedCaseQuantitySenateENT.CollegeName_Mark = objvYoungTAppraisedCaseQuantitySenateENS.CollegeName_Mark; //CollegeName_Mark
objvYoungTAppraisedCaseQuantitySenateENT.id_College_Mark = objvYoungTAppraisedCaseQuantitySenateENS.id_College_Mark; //id_College_Mark
objvYoungTAppraisedCaseQuantitySenateENT.StuIdTeacherId = objvYoungTAppraisedCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvYoungTAppraisedCaseQuantitySenateENT.UserId = objvYoungTAppraisedCaseQuantitySenateENS.UserId; //用户ID
objvYoungTAppraisedCaseQuantitySenateENT.UserName = objvYoungTAppraisedCaseQuantitySenateENS.UserName; //用户名
objvYoungTAppraisedCaseQuantitySenateENT.OwnerId = objvYoungTAppraisedCaseQuantitySenateENS.OwnerId; //拥有者Id
objvYoungTAppraisedCaseQuantitySenateENT.AppraiseTypeName = objvYoungTAppraisedCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvYoungTAppraisedCaseQuantitySenateENT.FuncModuleId = objvYoungTAppraisedCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvYoungTAppraisedCaseQuantitySenateENT.FuncModuleName = objvYoungTAppraisedCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvYoungTAppraisedCaseQuantitySenateENT.id_AppraiseType = objvYoungTAppraisedCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvYoungTAppraisedCaseQuantitySenateENT.id_MicroteachCase = objvYoungTAppraisedCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvYoungTAppraisedCaseQuantitySenateENT.OwnerName = objvYoungTAppraisedCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvYoungTAppraisedCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvYoungTAppraisedCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvYoungTAppraisedCaseQuantitySenateENT.YoungTAppraisedCaseDate = objvYoungTAppraisedCaseQuantitySenateENS.YoungTAppraisedCaseDate; //青教评优教学日期
objvYoungTAppraisedCaseQuantitySenateENT.YoungTAppraisedCaseTypeName = objvYoungTAppraisedCaseQuantitySenateENS.YoungTAppraisedCaseTypeName; //青教案例类型名称
objvYoungTAppraisedCaseQuantitySenateENT.UserNameWithUserId = objvYoungTAppraisedCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvYoungTAppraisedCaseQuantitySenateENT.id_XzCollege = objvYoungTAppraisedCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvYoungTAppraisedCaseQuantitySenateENT.CollegeNameA = objvYoungTAppraisedCaseQuantitySenateENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvYoungTAppraisedCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvYoungTAppraisedCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvYoungTAppraisedCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvYoungTAppraisedCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvYoungTAppraisedCaseQuantitySenateEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvYoungTAppraisedCaseQuantitySenateObjLst_Cache == null)
//{
//arrvYoungTAppraisedCaseQuantitySenateObjLst_Cache = await clsvYoungTAppraisedCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvYoungTAppraisedCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseQuantitySenateEN._CurrTabName_S);
List<clsvYoungTAppraisedCaseQuantitySenateEN> arrvYoungTAppraisedCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvYoungTAppraisedCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.CollegeID_Mark, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.CollegeName_Mark, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.id_College_Mark, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
foreach (clsvYoungTAppraisedCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convYoungTAppraisedCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convYoungTAppraisedCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase] = objInFor[convYoungTAppraisedCaseQuantitySenate.id_YoungTAppraisedCase];
objDR[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID] = objInFor[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID];
objDR[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName] = objInFor[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName];
objDR[convYoungTAppraisedCaseQuantitySenate.TeacherID] = objInFor[convYoungTAppraisedCaseQuantitySenate.TeacherID];
objDR[convYoungTAppraisedCaseQuantitySenate.TeacherName] = objInFor[convYoungTAppraisedCaseQuantitySenate.TeacherName];
objDR[convYoungTAppraisedCaseQuantitySenate.BrowseCount] = objInFor[convYoungTAppraisedCaseQuantitySenate.BrowseCount];
objDR[convYoungTAppraisedCaseQuantitySenate.SenateTheme] = objInFor[convYoungTAppraisedCaseQuantitySenate.SenateTheme];
objDR[convYoungTAppraisedCaseQuantitySenate.SenateContent] = objInFor[convYoungTAppraisedCaseQuantitySenate.SenateContent];
objDR[convYoungTAppraisedCaseQuantitySenate.SenateTotalScore] = objInFor[convYoungTAppraisedCaseQuantitySenate.SenateTotalScore];
objDR[convYoungTAppraisedCaseQuantitySenate.SenateDate] = objInFor[convYoungTAppraisedCaseQuantitySenate.SenateDate];
objDR[convYoungTAppraisedCaseQuantitySenate.SenateTime] = objInFor[convYoungTAppraisedCaseQuantitySenate.SenateTime];
objDR[convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convYoungTAppraisedCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID] = objInFor[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID];
objDR[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName] = objInFor[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName];
objDR[convYoungTAppraisedCaseQuantitySenate.UpdUser] = objInFor[convYoungTAppraisedCaseQuantitySenate.UpdUser];
objDR[convYoungTAppraisedCaseQuantitySenate.UpdUserName] = objInFor[convYoungTAppraisedCaseQuantitySenate.UpdUserName];
objDR[convYoungTAppraisedCaseQuantitySenate.CollegeID] = objInFor[convYoungTAppraisedCaseQuantitySenate.CollegeID];
objDR[convYoungTAppraisedCaseQuantitySenate.CollegeName] = objInFor[convYoungTAppraisedCaseQuantitySenate.CollegeName];
objDR[convYoungTAppraisedCaseQuantitySenate.SenateIp] = objInFor[convYoungTAppraisedCaseQuantitySenate.SenateIp];
objDR[convYoungTAppraisedCaseQuantitySenate.CollegeID_Mark] = objInFor[convYoungTAppraisedCaseQuantitySenate.CollegeID_Mark];
objDR[convYoungTAppraisedCaseQuantitySenate.CollegeName_Mark] = objInFor[convYoungTAppraisedCaseQuantitySenate.CollegeName_Mark];
objDR[convYoungTAppraisedCaseQuantitySenate.id_College_Mark] = objInFor[convYoungTAppraisedCaseQuantitySenate.id_College_Mark];
objDR[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId] = objInFor[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId];
objDR[convYoungTAppraisedCaseQuantitySenate.UserId] = objInFor[convYoungTAppraisedCaseQuantitySenate.UserId];
objDR[convYoungTAppraisedCaseQuantitySenate.UserName] = objInFor[convYoungTAppraisedCaseQuantitySenate.UserName];
objDR[convYoungTAppraisedCaseQuantitySenate.OwnerId] = objInFor[convYoungTAppraisedCaseQuantitySenate.OwnerId];
objDR[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName] = objInFor[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName];
objDR[convYoungTAppraisedCaseQuantitySenate.FuncModuleId] = objInFor[convYoungTAppraisedCaseQuantitySenate.FuncModuleId];
objDR[convYoungTAppraisedCaseQuantitySenate.FuncModuleName] = objInFor[convYoungTAppraisedCaseQuantitySenate.FuncModuleName];
objDR[convYoungTAppraisedCaseQuantitySenate.id_AppraiseType] = objInFor[convYoungTAppraisedCaseQuantitySenate.id_AppraiseType];
objDR[convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase] = objInFor[convYoungTAppraisedCaseQuantitySenate.id_MicroteachCase];
objDR[convYoungTAppraisedCaseQuantitySenate.OwnerName] = objInFor[convYoungTAppraisedCaseQuantitySenate.OwnerName];
objDR[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore];
objDR[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate] = objInFor[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate];
objDR[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName] = objInFor[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName];
objDR[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId] = objInFor[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId];
objDR[convYoungTAppraisedCaseQuantitySenate.id_XzCollege] = objInFor[convYoungTAppraisedCaseQuantitySenate.id_XzCollege];
objDR[convYoungTAppraisedCaseQuantitySenate.CollegeNameA] = objInFor[convYoungTAppraisedCaseQuantitySenate.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}