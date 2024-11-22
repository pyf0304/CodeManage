
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCaseQuantitySenateWApi
 表名:vCoursewareCaseQuantitySenate(01120454)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:37:43
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件
 模块英文名:Courseware
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
public static class clsvCoursewareCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvCoursewareCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetUserId(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCoursewareCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convCoursewareCaseQuantitySenate.UserId);
objvCoursewareCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.UserId) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN Setid_MicroteachCase(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convCoursewareCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCoursewareCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCoursewareCaseQuantitySenate.id_MicroteachCase);
objvCoursewareCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.id_MicroteachCase) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN Setid_AppraiseType(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convCoursewareCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convCoursewareCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convCoursewareCaseQuantitySenate.id_AppraiseType);
objvCoursewareCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.id_AppraiseType) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetAppraiseTypeName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convCoursewareCaseQuantitySenate.AppraiseTypeName);
objvCoursewareCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.AppraiseTypeName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCollegeID(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCoursewareCaseQuantitySenate.CollegeID);
objvCoursewareCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CollegeID) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCollegeName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCoursewareCaseQuantitySenate.CollegeName);
objvCoursewareCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CollegeName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetBrowseCount(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
	{
objvCoursewareCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.BrowseCount) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetSenateTheme(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convCoursewareCaseQuantitySenate.SenateTheme);
objvCoursewareCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.SenateTheme) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetSenateContent(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convCoursewareCaseQuantitySenate.SenateContent);
objvCoursewareCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.SenateContent) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetSenateTotalScore(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convCoursewareCaseQuantitySenate.SenateTotalScore);
objvCoursewareCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.SenateTotalScore) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetSenateDate(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convCoursewareCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convCoursewareCaseQuantitySenate.SenateDate);
objvCoursewareCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.SenateDate) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetSenateTime(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convCoursewareCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convCoursewareCaseQuantitySenate.SenateTime);
objvCoursewareCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.SenateTime) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convCoursewareCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCoursewareCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCoursewareCaseQuantitySenate.id_SenateGaugeVersion);
objvCoursewareCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCoursewareCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCoursewareCaseQuantitySenate.senateGaugeVersionID);
objvCoursewareCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCoursewareCaseQuantitySenate.senateGaugeVersionName);
objvCoursewareCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetUpdUser(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCoursewareCaseQuantitySenate.UpdUser);
objvCoursewareCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.UpdUser) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetUpdUserName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convCoursewareCaseQuantitySenate.UpdUserName);
objvCoursewareCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.UpdUserName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetFuncModuleName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCoursewareCaseQuantitySenate.FuncModuleName);
objvCoursewareCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.FuncModuleName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetFuncModuleId(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCoursewareCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCoursewareCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCoursewareCaseQuantitySenate.FuncModuleId);
objvCoursewareCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.FuncModuleId) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetUserTypeId(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convCoursewareCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convCoursewareCaseQuantitySenate.UserTypeId);
objvCoursewareCaseQuantitySenateEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.UserTypeId) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.UserTypeId, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserTypeId] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetSenateIp(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, convCoursewareCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(strSenateIp, 50, convCoursewareCaseQuantitySenate.SenateIp);
objvCoursewareCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.SenateIp) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetUserTypeName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convCoursewareCaseQuantitySenate.UserTypeName);
objvCoursewareCaseQuantitySenateEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.UserTypeName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.UserTypeName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserTypeName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetUserName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convCoursewareCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convCoursewareCaseQuantitySenate.UserName);
objvCoursewareCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.UserName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetOwnerId(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCoursewareCaseQuantitySenate.OwnerId);
objvCoursewareCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.OwnerId) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetOwnerName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCoursewareCaseQuantitySenate.OwnerName);
objvCoursewareCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.OwnerName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetUserNameWithUserId(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convCoursewareCaseQuantitySenate.UserNameWithUserId);
objvCoursewareCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.UserNameWithUserId) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetIsDualVideo(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCoursewareCaseQuantitySenateEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.IsDualVideo) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.IsDualVideo, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.IsDualVideo] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCoursewareCaseDate(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCoursewareCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseDate, 8, convCoursewareCaseQuantitySenate.CoursewareCaseDate);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseDate, 8, convCoursewareCaseQuantitySenate.CoursewareCaseDate);
objvCoursewareCaseQuantitySenateEN.CoursewareCaseDate = strCoursewareCaseDate; //课件教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CoursewareCaseDate) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CoursewareCaseDate, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseDate] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCoursewareCaseDateIn(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCoursewareCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseDateIn, 8, convCoursewareCaseQuantitySenate.CoursewareCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseDateIn, 8, convCoursewareCaseQuantitySenate.CoursewareCaseDateIn);
objvCoursewareCaseQuantitySenateEN.CoursewareCaseDateIn = strCoursewareCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CoursewareCaseDateIn) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CoursewareCaseDateIn, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCoursewareCaseID(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCoursewareCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseID, 8, convCoursewareCaseQuantitySenate.CoursewareCaseID);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseID, 8, convCoursewareCaseQuantitySenate.CoursewareCaseID);
objvCoursewareCaseQuantitySenateEN.CoursewareCaseID = strCoursewareCaseID; //课件教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CoursewareCaseID) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CoursewareCaseID, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseID] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCoursewareCaseName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCoursewareCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseName, 100, convCoursewareCaseQuantitySenate.CoursewareCaseName);
objvCoursewareCaseQuantitySenateEN.CoursewareCaseName = strCoursewareCaseName; //课件教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CoursewareCaseName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CoursewareCaseName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCoursewareCaseTheme(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCoursewareCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTheme, 200, convCoursewareCaseQuantitySenate.CoursewareCaseTheme);
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTheme = strCoursewareCaseTheme; //课件教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CoursewareCaseTheme) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CoursewareCaseTheme, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseTheme] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCoursewareCaseTime(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCoursewareCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTime, 6, convCoursewareCaseQuantitySenate.CoursewareCaseTime);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseTime, 6, convCoursewareCaseQuantitySenate.CoursewareCaseTime);
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTime = strCoursewareCaseTime; //课件教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CoursewareCaseTime) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CoursewareCaseTime, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseTime] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCoursewareCaseTimeIn(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCoursewareCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTimeIn, 6, convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseTimeIn, 6, convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn);
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTimeIn = strCoursewareCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetId_CoursewareCase(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strId_CoursewareCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CoursewareCase, 8, convCoursewareCaseQuantitySenate.Id_CoursewareCase);
clsCheckSql.CheckFieldForeignKey(strId_CoursewareCase, 8, convCoursewareCaseQuantitySenate.Id_CoursewareCase);
objvCoursewareCaseQuantitySenateEN.Id_CoursewareCase = strId_CoursewareCase; //课件教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.Id_CoursewareCase) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.Id_CoursewareCase, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.Id_CoursewareCase] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN Setid_CoursewareCaseType(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strid_CoursewareCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CoursewareCaseType, 4, convCoursewareCaseQuantitySenate.id_CoursewareCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareCaseType, 4, convCoursewareCaseQuantitySenate.id_CoursewareCaseType);
objvCoursewareCaseQuantitySenateEN.id_CoursewareCaseType = strid_CoursewareCaseType; //课件案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.id_CoursewareCaseType) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.id_CoursewareCaseType, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_CoursewareCaseType] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCoursewareCaseTypeName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCoursewareCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTypeName, 50, convCoursewareCaseQuantitySenate.CoursewareCaseTypeName);
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTypeName = strCoursewareCaseTypeName; //课件案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CoursewareCaseTypeName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CoursewareCaseTypeName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetUserKindId(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convCoursewareCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convCoursewareCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convCoursewareCaseQuantitySenate.UserKindId);
objvCoursewareCaseQuantitySenateEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.UserKindId) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.UserKindId, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserKindId] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetUserKindName(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convCoursewareCaseQuantitySenate.UserKindName);
objvCoursewareCaseQuantitySenateEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.UserKindName) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.UserKindName, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserKindName] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetMemo(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCoursewareCaseQuantitySenate.Memo);
objvCoursewareCaseQuantitySenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.Memo) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.Memo, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.Memo] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetOwnerNameWithId(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCoursewareCaseQuantitySenate.OwnerNameWithId);
objvCoursewareCaseQuantitySenateEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.OwnerNameWithId) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.OwnerNameWithId, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.OwnerNameWithId] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN Setid_XzCollege(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCoursewareCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCoursewareCaseQuantitySenate.id_XzCollege);
objvCoursewareCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.id_XzCollege) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseQuantitySenateEN SetCollegeNameA(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCoursewareCaseQuantitySenate.CollegeNameA);
objvCoursewareCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseQuantitySenate.CollegeNameA) == false)
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp.Add(convCoursewareCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvCoursewareCaseQuantitySenateEN.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvCoursewareCaseQuantitySenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCaseQuantitySenate.id_microteachCaseQuantitySenate, objvCoursewareCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.UserId, objvCoursewareCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.id_MicroteachCase, objvCoursewareCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.id_AppraiseType, objvCoursewareCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.AppraiseTypeName, objvCoursewareCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CollegeID, objvCoursewareCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CollegeName, objvCoursewareCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCaseQuantitySenate.BrowseCount, objvCoursewareCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.SenateTheme, objvCoursewareCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.SenateContent, objvCoursewareCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCaseQuantitySenate.SenateTotalScore, objvCoursewareCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.SenateDate, objvCoursewareCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.SenateTime, objvCoursewareCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.id_SenateGaugeVersion, objvCoursewareCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.senateGaugeVersionID, objvCoursewareCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.senateGaugeVersionName, objvCoursewareCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.UpdUser, objvCoursewareCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.UpdUserName, objvCoursewareCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.FuncModuleName, objvCoursewareCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.FuncModuleId, objvCoursewareCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.UserTypeId, objvCoursewareCaseQuantitySenate_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.SenateIp, objvCoursewareCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.UserTypeName, objvCoursewareCaseQuantitySenate_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.UserName, objvCoursewareCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.OwnerId, objvCoursewareCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.OwnerName, objvCoursewareCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.UserNameWithUserId, objvCoursewareCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.IsDualVideo) == true)
{
if (objvCoursewareCaseQuantitySenate_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCaseQuantitySenate.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCaseQuantitySenate.IsDualVideo);
}
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CoursewareCaseDate) == true)
{
string strComparisonOp_CoursewareCaseDate = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CoursewareCaseDate, objvCoursewareCaseQuantitySenate_Cond.CoursewareCaseDate, strComparisonOp_CoursewareCaseDate);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CoursewareCaseDateIn) == true)
{
string strComparisonOp_CoursewareCaseDateIn = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CoursewareCaseDateIn, objvCoursewareCaseQuantitySenate_Cond.CoursewareCaseDateIn, strComparisonOp_CoursewareCaseDateIn);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CoursewareCaseID) == true)
{
string strComparisonOp_CoursewareCaseID = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CoursewareCaseID, objvCoursewareCaseQuantitySenate_Cond.CoursewareCaseID, strComparisonOp_CoursewareCaseID);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CoursewareCaseName) == true)
{
string strComparisonOp_CoursewareCaseName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CoursewareCaseName, objvCoursewareCaseQuantitySenate_Cond.CoursewareCaseName, strComparisonOp_CoursewareCaseName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CoursewareCaseTheme) == true)
{
string strComparisonOp_CoursewareCaseTheme = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CoursewareCaseTheme, objvCoursewareCaseQuantitySenate_Cond.CoursewareCaseTheme, strComparisonOp_CoursewareCaseTheme);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CoursewareCaseTime) == true)
{
string strComparisonOp_CoursewareCaseTime = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CoursewareCaseTime, objvCoursewareCaseQuantitySenate_Cond.CoursewareCaseTime, strComparisonOp_CoursewareCaseTime);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn) == true)
{
string strComparisonOp_CoursewareCaseTimeIn = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn, objvCoursewareCaseQuantitySenate_Cond.CoursewareCaseTimeIn, strComparisonOp_CoursewareCaseTimeIn);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.Id_CoursewareCase) == true)
{
string strComparisonOp_Id_CoursewareCase = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.Id_CoursewareCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.Id_CoursewareCase, objvCoursewareCaseQuantitySenate_Cond.Id_CoursewareCase, strComparisonOp_Id_CoursewareCase);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.id_CoursewareCaseType) == true)
{
string strComparisonOp_id_CoursewareCaseType = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_CoursewareCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.id_CoursewareCaseType, objvCoursewareCaseQuantitySenate_Cond.id_CoursewareCaseType, strComparisonOp_id_CoursewareCaseType);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CoursewareCaseTypeName) == true)
{
string strComparisonOp_CoursewareCaseTypeName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CoursewareCaseTypeName, objvCoursewareCaseQuantitySenate_Cond.CoursewareCaseTypeName, strComparisonOp_CoursewareCaseTypeName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.UserKindId, objvCoursewareCaseQuantitySenate_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.UserKindName, objvCoursewareCaseQuantitySenate_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.Memo) == true)
{
string strComparisonOp_Memo = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.Memo, objvCoursewareCaseQuantitySenate_Cond.Memo, strComparisonOp_Memo);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.OwnerNameWithId, objvCoursewareCaseQuantitySenate_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.id_XzCollege, objvCoursewareCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCoursewareCaseQuantitySenate_Cond.IsUpdated(convCoursewareCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCoursewareCaseQuantitySenate_Cond.dicFldComparisonOp[convCoursewareCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseQuantitySenate.CollegeNameA, objvCoursewareCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课件量化评议(vCoursewareCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vCoursewareCaseQuantitySenateApi";

 public clsvCoursewareCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN = null;
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
objvCoursewareCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvCoursewareCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCaseQuantitySenateEN;
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
public static clsvCoursewareCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN = null;
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
objvCoursewareCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvCoursewareCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCaseQuantitySenateEN;
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
public static clsvCoursewareCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN = null;
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
objvCoursewareCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvCoursewareCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCaseQuantitySenateEN;
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
public static clsvCoursewareCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareCaseQuantitySenateEN._CurrTabName_S);
List<clsvCoursewareCaseQuantitySenateEN> arrvCoursewareCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareCaseQuantitySenateEN> arrvCoursewareCaseQuantitySenateObjLst_Sel =
from objvCoursewareCaseQuantitySenateEN in arrvCoursewareCaseQuantitySenateObjLst_Cache
where objvCoursewareCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvCoursewareCaseQuantitySenateEN;
if (arrvCoursewareCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvCoursewareCaseQuantitySenateEN obj = clsvCoursewareCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCoursewareCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvCoursewareCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvCoursewareCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCoursewareCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareCaseQuantitySenateEN._CurrTabName_S);
List<clsvCoursewareCaseQuantitySenateEN> arrvCoursewareCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareCaseQuantitySenateEN> arrvCoursewareCaseQuantitySenateObjLst_Sel =
from objvCoursewareCaseQuantitySenateEN in arrvCoursewareCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvCoursewareCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvCoursewareCaseQuantitySenateEN;
return arrvCoursewareCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvCoursewareCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCoursewareCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCoursewareCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCoursewareCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCoursewareCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCoursewareCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvCoursewareCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateENS, clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateENT)
{
try
{
objvCoursewareCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvCoursewareCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvCoursewareCaseQuantitySenateENT.UserId = objvCoursewareCaseQuantitySenateENS.UserId; //用户ID
objvCoursewareCaseQuantitySenateENT.id_MicroteachCase = objvCoursewareCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvCoursewareCaseQuantitySenateENT.id_AppraiseType = objvCoursewareCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvCoursewareCaseQuantitySenateENT.AppraiseTypeName = objvCoursewareCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvCoursewareCaseQuantitySenateENT.CollegeID = objvCoursewareCaseQuantitySenateENS.CollegeID; //学院ID
objvCoursewareCaseQuantitySenateENT.CollegeName = objvCoursewareCaseQuantitySenateENS.CollegeName; //学院名称
objvCoursewareCaseQuantitySenateENT.BrowseCount = objvCoursewareCaseQuantitySenateENS.BrowseCount; //浏览次数
objvCoursewareCaseQuantitySenateENT.SenateTheme = objvCoursewareCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvCoursewareCaseQuantitySenateENT.SenateContent = objvCoursewareCaseQuantitySenateENS.SenateContent; //评价内容
objvCoursewareCaseQuantitySenateENT.SenateTotalScore = objvCoursewareCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvCoursewareCaseQuantitySenateENT.SenateDate = objvCoursewareCaseQuantitySenateENS.SenateDate; //评价日期
objvCoursewareCaseQuantitySenateENT.SenateTime = objvCoursewareCaseQuantitySenateENS.SenateTime; //评价时间
objvCoursewareCaseQuantitySenateENT.id_SenateGaugeVersion = objvCoursewareCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
objvCoursewareCaseQuantitySenateENT.senateGaugeVersionID = objvCoursewareCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareCaseQuantitySenateENT.senateGaugeVersionName = objvCoursewareCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareCaseQuantitySenateENT.UpdUser = objvCoursewareCaseQuantitySenateENS.UpdUser; //修改人
objvCoursewareCaseQuantitySenateENT.UpdUserName = objvCoursewareCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvCoursewareCaseQuantitySenateENT.FuncModuleName = objvCoursewareCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvCoursewareCaseQuantitySenateENT.FuncModuleId = objvCoursewareCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvCoursewareCaseQuantitySenateENT.UserTypeId = objvCoursewareCaseQuantitySenateENS.UserTypeId; //用户类型Id
objvCoursewareCaseQuantitySenateENT.SenateIp = objvCoursewareCaseQuantitySenateENS.SenateIp; //评议Ip
objvCoursewareCaseQuantitySenateENT.UserTypeName = objvCoursewareCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvCoursewareCaseQuantitySenateENT.UserName = objvCoursewareCaseQuantitySenateENS.UserName; //用户名
objvCoursewareCaseQuantitySenateENT.OwnerId = objvCoursewareCaseQuantitySenateENS.OwnerId; //拥有者Id
objvCoursewareCaseQuantitySenateENT.OwnerName = objvCoursewareCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvCoursewareCaseQuantitySenateENT.UserNameWithUserId = objvCoursewareCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvCoursewareCaseQuantitySenateENT.IsDualVideo = objvCoursewareCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvCoursewareCaseQuantitySenateENT.CoursewareCaseDate = objvCoursewareCaseQuantitySenateENS.CoursewareCaseDate; //课件教学日期
objvCoursewareCaseQuantitySenateENT.CoursewareCaseDateIn = objvCoursewareCaseQuantitySenateENS.CoursewareCaseDateIn; //案例入库日期
objvCoursewareCaseQuantitySenateENT.CoursewareCaseID = objvCoursewareCaseQuantitySenateENS.CoursewareCaseID; //课件教学案例ID
objvCoursewareCaseQuantitySenateENT.CoursewareCaseName = objvCoursewareCaseQuantitySenateENS.CoursewareCaseName; //课件教学案例名称
objvCoursewareCaseQuantitySenateENT.CoursewareCaseTheme = objvCoursewareCaseQuantitySenateENS.CoursewareCaseTheme; //课件教学案例主题词
objvCoursewareCaseQuantitySenateENT.CoursewareCaseTime = objvCoursewareCaseQuantitySenateENS.CoursewareCaseTime; //课件教学时间
objvCoursewareCaseQuantitySenateENT.CoursewareCaseTimeIn = objvCoursewareCaseQuantitySenateENS.CoursewareCaseTimeIn; //案例入库时间
objvCoursewareCaseQuantitySenateENT.Id_CoursewareCase = objvCoursewareCaseQuantitySenateENS.Id_CoursewareCase; //课件教学案例流水号
objvCoursewareCaseQuantitySenateENT.id_CoursewareCaseType = objvCoursewareCaseQuantitySenateENS.id_CoursewareCaseType; //课件案例类型流水号
objvCoursewareCaseQuantitySenateENT.CoursewareCaseTypeName = objvCoursewareCaseQuantitySenateENS.CoursewareCaseTypeName; //课件案例类型名称
objvCoursewareCaseQuantitySenateENT.UserKindId = objvCoursewareCaseQuantitySenateENS.UserKindId; //用户类别Id
objvCoursewareCaseQuantitySenateENT.UserKindName = objvCoursewareCaseQuantitySenateENS.UserKindName; //用户类别名
objvCoursewareCaseQuantitySenateENT.Memo = objvCoursewareCaseQuantitySenateENS.Memo; //备注
objvCoursewareCaseQuantitySenateENT.OwnerNameWithId = objvCoursewareCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareCaseQuantitySenateENT.id_XzCollege = objvCoursewareCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvCoursewareCaseQuantitySenateENT.CollegeNameA = objvCoursewareCaseQuantitySenateENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvCoursewareCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCoursewareCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCoursewareCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCoursewareCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCoursewareCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCoursewareCaseQuantitySenateEN.AttributeName)
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
if (clsCoursewareCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareCaseWApi没有刷新缓存机制(clsCoursewareCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareCaseTypeWApi没有刷新缓存机制(clsCoursewareCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvCoursewareCaseQuantitySenateObjLst_Cache == null)
//{
//arrvCoursewareCaseQuantitySenateObjLst_Cache = await clsvCoursewareCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCoursewareCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvCoursewareCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCoursewareCaseQuantitySenateEN._CurrTabName_S);
List<clsvCoursewareCaseQuantitySenateEN> arrvCoursewareCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCoursewareCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCoursewareCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCoursewareCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CoursewareCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CoursewareCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CoursewareCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CoursewareCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CoursewareCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CoursewareCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.Id_CoursewareCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.id_CoursewareCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CoursewareCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
foreach (clsvCoursewareCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCoursewareCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convCoursewareCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convCoursewareCaseQuantitySenate.UserId] = objInFor[convCoursewareCaseQuantitySenate.UserId];
objDR[convCoursewareCaseQuantitySenate.id_MicroteachCase] = objInFor[convCoursewareCaseQuantitySenate.id_MicroteachCase];
objDR[convCoursewareCaseQuantitySenate.id_AppraiseType] = objInFor[convCoursewareCaseQuantitySenate.id_AppraiseType];
objDR[convCoursewareCaseQuantitySenate.AppraiseTypeName] = objInFor[convCoursewareCaseQuantitySenate.AppraiseTypeName];
objDR[convCoursewareCaseQuantitySenate.CollegeID] = objInFor[convCoursewareCaseQuantitySenate.CollegeID];
objDR[convCoursewareCaseQuantitySenate.CollegeName] = objInFor[convCoursewareCaseQuantitySenate.CollegeName];
objDR[convCoursewareCaseQuantitySenate.BrowseCount] = objInFor[convCoursewareCaseQuantitySenate.BrowseCount];
objDR[convCoursewareCaseQuantitySenate.SenateTheme] = objInFor[convCoursewareCaseQuantitySenate.SenateTheme];
objDR[convCoursewareCaseQuantitySenate.SenateContent] = objInFor[convCoursewareCaseQuantitySenate.SenateContent];
objDR[convCoursewareCaseQuantitySenate.SenateTotalScore] = objInFor[convCoursewareCaseQuantitySenate.SenateTotalScore];
objDR[convCoursewareCaseQuantitySenate.SenateDate] = objInFor[convCoursewareCaseQuantitySenate.SenateDate];
objDR[convCoursewareCaseQuantitySenate.SenateTime] = objInFor[convCoursewareCaseQuantitySenate.SenateTime];
objDR[convCoursewareCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convCoursewareCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convCoursewareCaseQuantitySenate.senateGaugeVersionID] = objInFor[convCoursewareCaseQuantitySenate.senateGaugeVersionID];
objDR[convCoursewareCaseQuantitySenate.senateGaugeVersionName] = objInFor[convCoursewareCaseQuantitySenate.senateGaugeVersionName];
objDR[convCoursewareCaseQuantitySenate.UpdUser] = objInFor[convCoursewareCaseQuantitySenate.UpdUser];
objDR[convCoursewareCaseQuantitySenate.UpdUserName] = objInFor[convCoursewareCaseQuantitySenate.UpdUserName];
objDR[convCoursewareCaseQuantitySenate.FuncModuleName] = objInFor[convCoursewareCaseQuantitySenate.FuncModuleName];
objDR[convCoursewareCaseQuantitySenate.FuncModuleId] = objInFor[convCoursewareCaseQuantitySenate.FuncModuleId];
objDR[convCoursewareCaseQuantitySenate.UserTypeId] = objInFor[convCoursewareCaseQuantitySenate.UserTypeId];
objDR[convCoursewareCaseQuantitySenate.SenateIp] = objInFor[convCoursewareCaseQuantitySenate.SenateIp];
objDR[convCoursewareCaseQuantitySenate.UserTypeName] = objInFor[convCoursewareCaseQuantitySenate.UserTypeName];
objDR[convCoursewareCaseQuantitySenate.UserName] = objInFor[convCoursewareCaseQuantitySenate.UserName];
objDR[convCoursewareCaseQuantitySenate.OwnerId] = objInFor[convCoursewareCaseQuantitySenate.OwnerId];
objDR[convCoursewareCaseQuantitySenate.OwnerName] = objInFor[convCoursewareCaseQuantitySenate.OwnerName];
objDR[convCoursewareCaseQuantitySenate.UserNameWithUserId] = objInFor[convCoursewareCaseQuantitySenate.UserNameWithUserId];
objDR[convCoursewareCaseQuantitySenate.IsDualVideo] = objInFor[convCoursewareCaseQuantitySenate.IsDualVideo];
objDR[convCoursewareCaseQuantitySenate.CoursewareCaseDate] = objInFor[convCoursewareCaseQuantitySenate.CoursewareCaseDate];
objDR[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn] = objInFor[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn];
objDR[convCoursewareCaseQuantitySenate.CoursewareCaseID] = objInFor[convCoursewareCaseQuantitySenate.CoursewareCaseID];
objDR[convCoursewareCaseQuantitySenate.CoursewareCaseName] = objInFor[convCoursewareCaseQuantitySenate.CoursewareCaseName];
objDR[convCoursewareCaseQuantitySenate.CoursewareCaseTheme] = objInFor[convCoursewareCaseQuantitySenate.CoursewareCaseTheme];
objDR[convCoursewareCaseQuantitySenate.CoursewareCaseTime] = objInFor[convCoursewareCaseQuantitySenate.CoursewareCaseTime];
objDR[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn] = objInFor[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn];
objDR[convCoursewareCaseQuantitySenate.Id_CoursewareCase] = objInFor[convCoursewareCaseQuantitySenate.Id_CoursewareCase];
objDR[convCoursewareCaseQuantitySenate.id_CoursewareCaseType] = objInFor[convCoursewareCaseQuantitySenate.id_CoursewareCaseType];
objDR[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName] = objInFor[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName];
objDR[convCoursewareCaseQuantitySenate.UserKindId] = objInFor[convCoursewareCaseQuantitySenate.UserKindId];
objDR[convCoursewareCaseQuantitySenate.UserKindName] = objInFor[convCoursewareCaseQuantitySenate.UserKindName];
objDR[convCoursewareCaseQuantitySenate.Memo] = objInFor[convCoursewareCaseQuantitySenate.Memo];
objDR[convCoursewareCaseQuantitySenate.OwnerNameWithId] = objInFor[convCoursewareCaseQuantitySenate.OwnerNameWithId];
objDR[convCoursewareCaseQuantitySenate.id_XzCollege] = objInFor[convCoursewareCaseQuantitySenate.id_XzCollege];
objDR[convCoursewareCaseQuantitySenate.CollegeNameA] = objInFor[convCoursewareCaseQuantitySenate.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}