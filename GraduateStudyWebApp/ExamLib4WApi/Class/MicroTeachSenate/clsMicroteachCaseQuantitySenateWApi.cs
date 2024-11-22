
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseQuantitySenateWApi
 表名:MicroteachCaseQuantitySenate(01120443)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:18
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
public static class clsMicroteachCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetFuncModuleId(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conMicroteachCaseQuantitySenate.FuncModuleId);
objMicroteachCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.FuncModuleId) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN Setid_MicroteachCase(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, conMicroteachCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, conMicroteachCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, conMicroteachCaseQuantitySenate.id_MicroteachCase);
objMicroteachCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.id_MicroteachCase) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN Setid_AppraiseType(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, conMicroteachCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, conMicroteachCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, conMicroteachCaseQuantitySenate.id_AppraiseType);
objMicroteachCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.id_AppraiseType) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetSenateTheme(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, conMicroteachCaseQuantitySenate.SenateTheme);
objMicroteachCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.SenateTheme) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetSenateContent(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, conMicroteachCaseQuantitySenate.SenateContent);
objMicroteachCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.SenateContent) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetSenateTotalScore(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, conMicroteachCaseQuantitySenate.SenateTotalScore);
objMicroteachCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.SenateTotalScore) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetSenateDate(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, conMicroteachCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, conMicroteachCaseQuantitySenate.SenateDate);
objMicroteachCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.SenateDate) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetSenateTime(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, conMicroteachCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, conMicroteachCaseQuantitySenate.SenateTime);
objMicroteachCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.SenateTime) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetSenateIp(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSenateIp, conMicroteachCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(strSenateIp, 50, conMicroteachCaseQuantitySenate.SenateIp);
objMicroteachCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.SenateIp) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetBrowseCount(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
	{
objMicroteachCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.BrowseCount) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, conMicroteachCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conMicroteachCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conMicroteachCaseQuantitySenate.id_SenateGaugeVersion);
objMicroteachCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetUserId(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conMicroteachCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, conMicroteachCaseQuantitySenate.UserId);
objMicroteachCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.UserId) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetUserName(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conMicroteachCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, conMicroteachCaseQuantitySenate.UserName);
objMicroteachCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.UserName) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetUserKindId(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, conMicroteachCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, conMicroteachCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, conMicroteachCaseQuantitySenate.UserKindId);
objMicroteachCaseQuantitySenateEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.UserKindId) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.UserKindId, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.UserKindId] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetUserTypeId(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conMicroteachCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conMicroteachCaseQuantitySenate.UserTypeId);
objMicroteachCaseQuantitySenateEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.UserTypeId) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.UserTypeId, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.UserTypeId] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetUpdUser(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conMicroteachCaseQuantitySenate.UpdUser);
objMicroteachCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.UpdUser) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateEN SetMemo(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conMicroteachCaseQuantitySenate.Memo);
objMicroteachCaseQuantitySenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenate.Memo) == false)
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenate.Memo, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateEN.dicFldComparisonOp[conMicroteachCaseQuantitySenate.Memo] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate, objMicroteachCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.FuncModuleId, objMicroteachCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.id_MicroteachCase, objMicroteachCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.id_AppraiseType, objMicroteachCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.SenateTheme, objMicroteachCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.SenateContent, objMicroteachCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseQuantitySenate.SenateTotalScore, objMicroteachCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.SenateDate, objMicroteachCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.SenateTime, objMicroteachCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.SenateIp, objMicroteachCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseQuantitySenate.BrowseCount, objMicroteachCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.id_SenateGaugeVersion, objMicroteachCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.UserId, objMicroteachCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.UserName, objMicroteachCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOp_UserKindId = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.UserKindId, objMicroteachCaseQuantitySenate_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.UserTypeId, objMicroteachCaseQuantitySenate_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.UpdUser, objMicroteachCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objMicroteachCaseQuantitySenate_Cond.IsUpdated(conMicroteachCaseQuantitySenate.Memo) == true)
{
string strComparisonOp_Memo = objMicroteachCaseQuantitySenate_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenate.Memo, objMicroteachCaseQuantitySenate_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
 if (objMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objMicroteachCaseQuantitySenateEN.sf_UpdFldSetStr = objMicroteachCaseQuantitySenateEN.getsf_UpdFldSetStr();
clsMicroteachCaseQuantitySenateWApi.CheckPropertyNew(objMicroteachCaseQuantitySenateEN); 
bool bolResult = clsMicroteachCaseQuantitySenateWApi.UpdateRecord(objMicroteachCaseQuantitySenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--MicroteachCaseQuantitySenate(微格教学教师量化评价), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_FuncModuleId_id_MicroteachCase_id_AppraiseType_UserId(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachCaseQuantitySenateEN == null) return "";
if (objMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objMicroteachCaseQuantitySenateEN.FuncModuleId);
 sbCondition.AppendFormat(" and id_MicroteachCase = '{0}'", objMicroteachCaseQuantitySenateEN.id_MicroteachCase);
 sbCondition.AppendFormat(" and id_AppraiseType = '{0}'", objMicroteachCaseQuantitySenateEN.id_AppraiseType);
 sbCondition.AppendFormat(" and UserId = '{0}'", objMicroteachCaseQuantitySenateEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_microteachCaseQuantitySenate !=  {0}", objMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate);
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objMicroteachCaseQuantitySenateEN.FuncModuleId);
 sbCondition.AppendFormat(" and id_MicroteachCase = '{0}'", objMicroteachCaseQuantitySenateEN.id_MicroteachCase);
 sbCondition.AppendFormat(" and id_AppraiseType = '{0}'", objMicroteachCaseQuantitySenateEN.id_AppraiseType);
 sbCondition.AppendFormat(" and UserId = '{0}'", objMicroteachCaseQuantitySenateEN.UserId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
try
{
clsMicroteachCaseQuantitySenateWApi.CheckPropertyNew(objMicroteachCaseQuantitySenateEN); 
bool bolResult = clsMicroteachCaseQuantitySenateWApi.AddNewRecord(objMicroteachCaseQuantitySenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strWhereCond)
{
try
{
clsMicroteachCaseQuantitySenateWApi.CheckPropertyNew(objMicroteachCaseQuantitySenateEN); 
bool bolResult = clsMicroteachCaseQuantitySenateWApi.UpdateWithCondition(objMicroteachCaseQuantitySenateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateWApi.ReFreshCache();
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
 /// 微格教学教师量化评价(MicroteachCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "MicroteachCaseQuantitySenateApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsMicroteachCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.FuncModuleId) && GetStrLen(objMicroteachCaseQuantitySenateEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.id_MicroteachCase) && GetStrLen(objMicroteachCaseQuantitySenateEN.id_MicroteachCase) > 8)
{
 throw new Exception("字段[微格教学案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.id_AppraiseType) && GetStrLen(objMicroteachCaseQuantitySenateEN.id_AppraiseType) > 4)
{
 throw new Exception("字段[评议类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.SenateTheme) && GetStrLen(objMicroteachCaseQuantitySenateEN.SenateTheme) > 200)
{
 throw new Exception("字段[量化评价主题]的长度不能超过200!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.SenateContent) && GetStrLen(objMicroteachCaseQuantitySenateEN.SenateContent) > 2000)
{
 throw new Exception("字段[评价内容]的长度不能超过2000!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.SenateDate) && GetStrLen(objMicroteachCaseQuantitySenateEN.SenateDate) > 8)
{
 throw new Exception("字段[评价日期]的长度不能超过8!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.SenateTime) && GetStrLen(objMicroteachCaseQuantitySenateEN.SenateTime) > 6)
{
 throw new Exception("字段[评价时间]的长度不能超过6!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.SenateIp) && GetStrLen(objMicroteachCaseQuantitySenateEN.SenateIp) > 50)
{
 throw new Exception("字段[评议Ip]的长度不能超过50!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.id_SenateGaugeVersion) && GetStrLen(objMicroteachCaseQuantitySenateEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.UserId) && GetStrLen(objMicroteachCaseQuantitySenateEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.UserName) && GetStrLen(objMicroteachCaseQuantitySenateEN.UserName) > 50)
{
 throw new Exception("字段[用户名]的长度不能超过50!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.UserKindId) && GetStrLen(objMicroteachCaseQuantitySenateEN.UserKindId) > 2)
{
 throw new Exception("字段[用户类别Id]的长度不能超过2!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.UserTypeId) && GetStrLen(objMicroteachCaseQuantitySenateEN.UserTypeId) > 2)
{
 throw new Exception("字段[用户类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.UpdUser) && GetStrLen(objMicroteachCaseQuantitySenateEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateEN.Memo) && GetStrLen(objMicroteachCaseQuantitySenateEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objMicroteachCaseQuantitySenateEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN = null;
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
objMicroteachCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsMicroteachCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseQuantitySenateEN;
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
public static clsMicroteachCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN = null;
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
objMicroteachCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsMicroteachCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseQuantitySenateEN;
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
public static clsMicroteachCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN = null;
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
objMicroteachCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsMicroteachCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseQuantitySenateEN;
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
public static clsMicroteachCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateEN._CurrTabName_S);
List<clsMicroteachCaseQuantitySenateEN> arrMicroteachCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseQuantitySenateEN> arrMicroteachCaseQuantitySenateObjLst_Sel =
from objMicroteachCaseQuantitySenateEN in arrMicroteachCaseQuantitySenateObjLst_Cache
where objMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objMicroteachCaseQuantitySenateEN;
if (arrMicroteachCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsMicroteachCaseQuantitySenateEN obj = clsMicroteachCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrMicroteachCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsMicroteachCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateEN._CurrTabName_S);
List<clsMicroteachCaseQuantitySenateEN> arrMicroteachCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseQuantitySenateEN> arrMicroteachCaseQuantitySenateObjLst_Sel =
from objMicroteachCaseQuantitySenateEN in arrMicroteachCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objMicroteachCaseQuantitySenateEN;
return arrMicroteachCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsMicroteachCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_microteachCaseQuantitySenate)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN = clsMicroteachCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_microteachCaseQuantitySenate.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMicroteachCaseQuantitySenateWApi.ReFreshCache();
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
public static int DelMicroteachCaseQuantitySenates(List<string> arrid_microteachCaseQuantitySenate)
{
string strAction = "DelMicroteachCaseQuantitySenates";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_microteachCaseQuantitySenate);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMicroteachCaseQuantitySenateWApi.ReFreshCache();
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
public static int DelMicroteachCaseQuantitySenatesByCond(string strWhereCond)
{
string strAction = "DelMicroteachCaseQuantitySenatesByCond";
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
public static bool AddNewRecord(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseQuantitySenateEN>(objMicroteachCaseQuantitySenateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseQuantitySenateEN>(objMicroteachCaseQuantitySenateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
if (string.IsNullOrEmpty(objMicroteachCaseQuantitySenateEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseQuantitySenateEN>(objMicroteachCaseQuantitySenateEN);
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
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objMicroteachCaseQuantitySenateEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseQuantitySenateEN.id_microteachCaseQuantitySenate, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseQuantitySenateEN>(objMicroteachCaseQuantitySenateEN);
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
 /// <param name = "objMicroteachCaseQuantitySenateENS">源对象</param>
 /// <param name = "objMicroteachCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateENS, clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateENT)
{
try
{
objMicroteachCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objMicroteachCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objMicroteachCaseQuantitySenateENT.FuncModuleId = objMicroteachCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objMicroteachCaseQuantitySenateENT.id_MicroteachCase = objMicroteachCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objMicroteachCaseQuantitySenateENT.id_AppraiseType = objMicroteachCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objMicroteachCaseQuantitySenateENT.SenateTheme = objMicroteachCaseQuantitySenateENS.SenateTheme; //量化评价主题
objMicroteachCaseQuantitySenateENT.SenateContent = objMicroteachCaseQuantitySenateENS.SenateContent; //评价内容
objMicroteachCaseQuantitySenateENT.SenateTotalScore = objMicroteachCaseQuantitySenateENS.SenateTotalScore; //评价分数
objMicroteachCaseQuantitySenateENT.SenateDate = objMicroteachCaseQuantitySenateENS.SenateDate; //评价日期
objMicroteachCaseQuantitySenateENT.SenateTime = objMicroteachCaseQuantitySenateENS.SenateTime; //评价时间
objMicroteachCaseQuantitySenateENT.SenateIp = objMicroteachCaseQuantitySenateENS.SenateIp; //评议Ip
objMicroteachCaseQuantitySenateENT.BrowseCount = objMicroteachCaseQuantitySenateENS.BrowseCount; //浏览次数
objMicroteachCaseQuantitySenateENT.id_SenateGaugeVersion = objMicroteachCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
objMicroteachCaseQuantitySenateENT.UserId = objMicroteachCaseQuantitySenateENS.UserId; //用户ID
objMicroteachCaseQuantitySenateENT.UserName = objMicroteachCaseQuantitySenateENS.UserName; //用户名
objMicroteachCaseQuantitySenateENT.UserKindId = objMicroteachCaseQuantitySenateENS.UserKindId; //用户类别Id
objMicroteachCaseQuantitySenateENT.UserTypeId = objMicroteachCaseQuantitySenateENS.UserTypeId; //用户类型Id
objMicroteachCaseQuantitySenateENT.UpdUser = objMicroteachCaseQuantitySenateENS.UpdUser; //修改人
objMicroteachCaseQuantitySenateENT.Memo = objMicroteachCaseQuantitySenateENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsMicroteachCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsMicroteachCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsMicroteachCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsMicroteachCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsMicroteachCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsMicroteachCaseQuantitySenateEN.AttributeName)
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
if (clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrMicroteachCaseQuantitySenateObjLst_Cache == null)
//{
//arrMicroteachCaseQuantitySenateObjLst_Cache = await clsMicroteachCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateEN._CurrTabName_S);
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
if (clsMicroteachCaseQuantitySenateWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsMicroteachCaseQuantitySenateWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateEN._CurrTabName_S);
List<clsMicroteachCaseQuantitySenateEN> arrMicroteachCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsMicroteachCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenate.Memo, Type.GetType("System.String"));
foreach (clsMicroteachCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[conMicroteachCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[conMicroteachCaseQuantitySenate.FuncModuleId] = objInFor[conMicroteachCaseQuantitySenate.FuncModuleId];
objDR[conMicroteachCaseQuantitySenate.id_MicroteachCase] = objInFor[conMicroteachCaseQuantitySenate.id_MicroteachCase];
objDR[conMicroteachCaseQuantitySenate.id_AppraiseType] = objInFor[conMicroteachCaseQuantitySenate.id_AppraiseType];
objDR[conMicroteachCaseQuantitySenate.SenateTheme] = objInFor[conMicroteachCaseQuantitySenate.SenateTheme];
objDR[conMicroteachCaseQuantitySenate.SenateContent] = objInFor[conMicroteachCaseQuantitySenate.SenateContent];
objDR[conMicroteachCaseQuantitySenate.SenateTotalScore] = objInFor[conMicroteachCaseQuantitySenate.SenateTotalScore];
objDR[conMicroteachCaseQuantitySenate.SenateDate] = objInFor[conMicroteachCaseQuantitySenate.SenateDate];
objDR[conMicroteachCaseQuantitySenate.SenateTime] = objInFor[conMicroteachCaseQuantitySenate.SenateTime];
objDR[conMicroteachCaseQuantitySenate.SenateIp] = objInFor[conMicroteachCaseQuantitySenate.SenateIp];
objDR[conMicroteachCaseQuantitySenate.BrowseCount] = objInFor[conMicroteachCaseQuantitySenate.BrowseCount];
objDR[conMicroteachCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[conMicroteachCaseQuantitySenate.id_SenateGaugeVersion];
objDR[conMicroteachCaseQuantitySenate.UserId] = objInFor[conMicroteachCaseQuantitySenate.UserId];
objDR[conMicroteachCaseQuantitySenate.UserName] = objInFor[conMicroteachCaseQuantitySenate.UserName];
objDR[conMicroteachCaseQuantitySenate.UserKindId] = objInFor[conMicroteachCaseQuantitySenate.UserKindId];
objDR[conMicroteachCaseQuantitySenate.UserTypeId] = objInFor[conMicroteachCaseQuantitySenate.UserTypeId];
objDR[conMicroteachCaseQuantitySenate.UpdUser] = objInFor[conMicroteachCaseQuantitySenate.UpdUser];
objDR[conMicroteachCaseQuantitySenate.Memo] = objInFor[conMicroteachCaseQuantitySenate.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 微格教学教师量化评价(MicroteachCaseQuantitySenate)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4MicroteachCaseQuantitySenate : clsCommFun4BL
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
clsMicroteachCaseQuantitySenateWApi.ReFreshThisCache();
}
}

}