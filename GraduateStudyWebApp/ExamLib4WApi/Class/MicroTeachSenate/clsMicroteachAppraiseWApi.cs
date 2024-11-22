
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachAppraiseWApi
 表名:MicroteachAppraise(01120264)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:21
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
public static class clsMicroteachAppraiseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN Setid_MicroteachAppraise(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, long lngid_MicroteachAppraise, string strComparisonOp="")
	{
objMicroteachAppraiseEN.id_MicroteachAppraise = lngid_MicroteachAppraise; //评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.id_MicroteachAppraise) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.id_MicroteachAppraise, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.id_MicroteachAppraise] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetFuncModuleId(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conMicroteachAppraise.FuncModuleId);
objMicroteachAppraiseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.FuncModuleId) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.FuncModuleId, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.FuncModuleId] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN Setid_MicroteachCase(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, conMicroteachAppraise.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, conMicroteachAppraise.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, conMicroteachAppraise.id_MicroteachCase);
objMicroteachAppraiseEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.id_MicroteachCase) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.id_MicroteachCase, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.id_MicroteachCase] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN Setid_AppraiseType(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, conMicroteachAppraise.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, conMicroteachAppraise.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, conMicroteachAppraise.id_AppraiseType);
objMicroteachAppraiseEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.id_AppraiseType) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.id_AppraiseType, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.id_AppraiseType] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetAppraiseTheme(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strAppraiseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, conMicroteachAppraise.AppraiseTheme);
objMicroteachAppraiseEN.AppraiseTheme = strAppraiseTheme; //评议主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.AppraiseTheme) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.AppraiseTheme, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.AppraiseTheme] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetAppraiseContent(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, conMicroteachAppraise.AppraiseContent);
objMicroteachAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.AppraiseContent) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.AppraiseContent, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.AppraiseContent] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetAppraiseDate(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strAppraiseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseDate, 8, conMicroteachAppraise.AppraiseDate);
clsCheckSql.CheckFieldForeignKey(strAppraiseDate, 8, conMicroteachAppraise.AppraiseDate);
objMicroteachAppraiseEN.AppraiseDate = strAppraiseDate; //评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.AppraiseDate) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.AppraiseDate, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.AppraiseDate] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetAppraiseTime(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strAppraiseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTime, 6, conMicroteachAppraise.AppraiseTime);
clsCheckSql.CheckFieldForeignKey(strAppraiseTime, 6, conMicroteachAppraise.AppraiseTime);
objMicroteachAppraiseEN.AppraiseTime = strAppraiseTime; //评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.AppraiseTime) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.AppraiseTime, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.AppraiseTime] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetIsVisual(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, bool bolIsVisual, string strComparisonOp="")
	{
objMicroteachAppraiseEN.IsVisual = bolIsVisual; //隐藏标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.IsVisual) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.IsVisual, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.IsVisual] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetIsElite(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, bool bolIsElite, string strComparisonOp="")
	{
objMicroteachAppraiseEN.IsElite = bolIsElite; //精华标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.IsElite) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.IsElite, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.IsElite] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetExcellentOne(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strExcellentOne, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentOne, 1000, conMicroteachAppraise.ExcellentOne);
objMicroteachAppraiseEN.ExcellentOne = strExcellentOne; //优点1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.ExcellentOne) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.ExcellentOne, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.ExcellentOne] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetExcellentTwo(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strExcellentTwo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTwo, 1000, conMicroteachAppraise.ExcellentTwo);
objMicroteachAppraiseEN.ExcellentTwo = strExcellentTwo; //优点2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.ExcellentTwo) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.ExcellentTwo, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.ExcellentTwo] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetSuggestOne(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strSuggestOne, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSuggestOne, 1000, conMicroteachAppraise.SuggestOne);
objMicroteachAppraiseEN.SuggestOne = strSuggestOne; //建议1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.SuggestOne) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.SuggestOne, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.SuggestOne] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetSuggestTwo(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strSuggestTwo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSuggestTwo, 1000, conMicroteachAppraise.SuggestTwo);
objMicroteachAppraiseEN.SuggestTwo = strSuggestTwo; //建议2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.SuggestTwo) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.SuggestTwo, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.SuggestTwo] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetMicroteachAppriseScore(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, float fltMicroteachAppriseScore, string strComparisonOp="")
	{
objMicroteachAppraiseEN.MicroteachAppriseScore = fltMicroteachAppriseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.MicroteachAppriseScore) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.MicroteachAppriseScore, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.MicroteachAppriseScore] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetVideoStopTime(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strVideoStopTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, conMicroteachAppraise.VideoStopTime);
objMicroteachAppraiseEN.VideoStopTime = strVideoStopTime; //公开课案例视频暂停时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.VideoStopTime) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.VideoStopTime, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.VideoStopTime] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetBrowseCount(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, int intBrowseCount, string strComparisonOp="")
	{
objMicroteachAppraiseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.BrowseCount) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.BrowseCount, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.BrowseCount] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachAppraiseEN SetUserId(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conMicroteachAppraise.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, conMicroteachAppraise.UserId);
objMicroteachAppraiseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.UserId) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.UserId, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.UserId] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachAppraiseEN objMicroteachAppraise_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.id_MicroteachAppraise) == true)
{
string strComparisonOp_id_MicroteachAppraise = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.id_MicroteachAppraise];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachAppraise.id_MicroteachAppraise, objMicroteachAppraise_Cond.id_MicroteachAppraise, strComparisonOp_id_MicroteachAppraise);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.FuncModuleId, objMicroteachAppraise_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.id_MicroteachCase, objMicroteachAppraise_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.id_AppraiseType, objMicroteachAppraise_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.AppraiseTheme) == true)
{
string strComparisonOp_AppraiseTheme = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.AppraiseTheme, objMicroteachAppraise_Cond.AppraiseTheme, strComparisonOp_AppraiseTheme);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.AppraiseContent) == true)
{
string strComparisonOp_AppraiseContent = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.AppraiseContent, objMicroteachAppraise_Cond.AppraiseContent, strComparisonOp_AppraiseContent);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.AppraiseDate) == true)
{
string strComparisonOp_AppraiseDate = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.AppraiseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.AppraiseDate, objMicroteachAppraise_Cond.AppraiseDate, strComparisonOp_AppraiseDate);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.AppraiseTime) == true)
{
string strComparisonOp_AppraiseTime = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.AppraiseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.AppraiseTime, objMicroteachAppraise_Cond.AppraiseTime, strComparisonOp_AppraiseTime);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.IsVisual) == true)
{
if (objMicroteachAppraise_Cond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachAppraise.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachAppraise.IsVisual);
}
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.IsElite) == true)
{
if (objMicroteachAppraise_Cond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachAppraise.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachAppraise.IsElite);
}
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.ExcellentOne) == true)
{
string strComparisonOp_ExcellentOne = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.ExcellentOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.ExcellentOne, objMicroteachAppraise_Cond.ExcellentOne, strComparisonOp_ExcellentOne);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.ExcellentTwo) == true)
{
string strComparisonOp_ExcellentTwo = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.ExcellentTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.ExcellentTwo, objMicroteachAppraise_Cond.ExcellentTwo, strComparisonOp_ExcellentTwo);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.SuggestOne) == true)
{
string strComparisonOp_SuggestOne = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.SuggestOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.SuggestOne, objMicroteachAppraise_Cond.SuggestOne, strComparisonOp_SuggestOne);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.SuggestTwo) == true)
{
string strComparisonOp_SuggestTwo = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.SuggestTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.SuggestTwo, objMicroteachAppraise_Cond.SuggestTwo, strComparisonOp_SuggestTwo);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.MicroteachAppriseScore) == true)
{
string strComparisonOp_MicroteachAppriseScore = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.MicroteachAppriseScore];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachAppraise.MicroteachAppriseScore, objMicroteachAppraise_Cond.MicroteachAppriseScore, strComparisonOp_MicroteachAppriseScore);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.VideoStopTime) == true)
{
string strComparisonOp_VideoStopTime = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.VideoStopTime, objMicroteachAppraise_Cond.VideoStopTime, strComparisonOp_VideoStopTime);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachAppraise.BrowseCount, objMicroteachAppraise_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objMicroteachAppraise_Cond.IsUpdated(conMicroteachAppraise.UserId) == true)
{
string strComparisonOp_UserId = objMicroteachAppraise_Cond.dicFldComparisonOp[conMicroteachAppraise.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.UserId, objMicroteachAppraise_Cond.UserId, strComparisonOp_UserId);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 if (objMicroteachAppraiseEN.id_MicroteachAppraise == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objMicroteachAppraiseEN.sf_UpdFldSetStr = objMicroteachAppraiseEN.getsf_UpdFldSetStr();
clsMicroteachAppraiseWApi.CheckPropertyNew(objMicroteachAppraiseEN); 
bool bolResult = clsMicroteachAppraiseWApi.UpdateRecord(objMicroteachAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--MicroteachAppraise(微格案例定性评议), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_MicroteachCase_UserId(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachAppraiseEN == null) return "";
if (objMicroteachAppraiseEN.id_MicroteachAppraise == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_MicroteachCase = '{0}'", objMicroteachAppraiseEN.id_MicroteachCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objMicroteachAppraiseEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_MicroteachAppraise !=  {0}", objMicroteachAppraiseEN.id_MicroteachAppraise);
 sbCondition.AppendFormat(" and id_MicroteachCase = '{0}'", objMicroteachAppraiseEN.id_MicroteachCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objMicroteachAppraiseEN.UserId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
try
{
clsMicroteachAppraiseWApi.CheckPropertyNew(objMicroteachAppraiseEN); 
bool bolResult = clsMicroteachAppraiseWApi.AddNewRecord(objMicroteachAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseWApi.ReFreshCache();
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
 /// <param name = "objMicroteachAppraiseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strWhereCond)
{
try
{
clsMicroteachAppraiseWApi.CheckPropertyNew(objMicroteachAppraiseEN); 
bool bolResult = clsMicroteachAppraiseWApi.UpdateWithCondition(objMicroteachAppraiseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseWApi.ReFreshCache();
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
 /// 微格案例定性评议(MicroteachAppraise)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachAppraiseWApi
{
private static readonly string mstrApiControllerName = "MicroteachAppraiseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsMicroteachAppraiseWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
if (!Object.Equals(null, objMicroteachAppraiseEN.FuncModuleId) && GetStrLen(objMicroteachAppraiseEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.id_MicroteachCase) && GetStrLen(objMicroteachAppraiseEN.id_MicroteachCase) > 8)
{
 throw new Exception("字段[微格教学案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.id_AppraiseType) && GetStrLen(objMicroteachAppraiseEN.id_AppraiseType) > 4)
{
 throw new Exception("字段[评议类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.AppraiseTheme) && GetStrLen(objMicroteachAppraiseEN.AppraiseTheme) > 200)
{
 throw new Exception("字段[评议主题]的长度不能超过200!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.AppraiseContent) && GetStrLen(objMicroteachAppraiseEN.AppraiseContent) > 2000)
{
 throw new Exception("字段[评议内容]的长度不能超过2000!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.AppraiseDate) && GetStrLen(objMicroteachAppraiseEN.AppraiseDate) > 8)
{
 throw new Exception("字段[评议日期]的长度不能超过8!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.AppraiseTime) && GetStrLen(objMicroteachAppraiseEN.AppraiseTime) > 6)
{
 throw new Exception("字段[评议时间]的长度不能超过6!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.ExcellentOne) && GetStrLen(objMicroteachAppraiseEN.ExcellentOne) > 1000)
{
 throw new Exception("字段[优点1]的长度不能超过1000!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.ExcellentTwo) && GetStrLen(objMicroteachAppraiseEN.ExcellentTwo) > 1000)
{
 throw new Exception("字段[优点2]的长度不能超过1000!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.SuggestOne) && GetStrLen(objMicroteachAppraiseEN.SuggestOne) > 1000)
{
 throw new Exception("字段[建议1]的长度不能超过1000!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.SuggestTwo) && GetStrLen(objMicroteachAppraiseEN.SuggestTwo) > 1000)
{
 throw new Exception("字段[建议2]的长度不能超过1000!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.VideoStopTime) && GetStrLen(objMicroteachAppraiseEN.VideoStopTime) > 48)
{
 throw new Exception("字段[公开课案例视频暂停时间]的长度不能超过48!");
}
if (!Object.Equals(null, objMicroteachAppraiseEN.UserId) && GetStrLen(objMicroteachAppraiseEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
 objMicroteachAppraiseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachAppraiseEN GetObjByid_MicroteachAppraise(long lngid_MicroteachAppraise)
{
string strAction = "GetObjByid_MicroteachAppraise";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachAppraiseEN objMicroteachAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objMicroteachAppraiseEN = JsonConvert.DeserializeObject<clsMicroteachAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachAppraiseEN;
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
 /// <param name = "lngid_MicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachAppraiseEN GetObjByid_MicroteachAppraise_WA_Cache(long lngid_MicroteachAppraise)
{
string strAction = "GetObjByid_MicroteachAppraise_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachAppraiseEN objMicroteachAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objMicroteachAppraiseEN = JsonConvert.DeserializeObject<clsMicroteachAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachAppraiseEN;
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
public static clsMicroteachAppraiseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachAppraiseEN objMicroteachAppraiseEN = null;
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
objMicroteachAppraiseEN = JsonConvert.DeserializeObject<clsMicroteachAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachAppraiseEN;
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
 /// <param name = "lngid_MicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachAppraiseEN GetObjByid_MicroteachAppraise_Cache(long lngid_MicroteachAppraise)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachAppraiseEN._CurrTabName_S);
List<clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLst_Sel =
from objMicroteachAppraiseEN in arrMicroteachAppraiseObjLst_Cache
where objMicroteachAppraiseEN.id_MicroteachAppraise == lngid_MicroteachAppraise
select objMicroteachAppraiseEN;
if (arrMicroteachAppraiseObjLst_Sel.Count() == 0)
{
   clsMicroteachAppraiseEN obj = clsMicroteachAppraiseWApi.GetObjByid_MicroteachAppraise(lngid_MicroteachAppraise);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrMicroteachAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachAppraiseEN> GetObjLst(string strWhereCond)
{
 List<clsMicroteachAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachAppraiseEN> GetObjLstById_MicroteachAppraiseLst(List<long> arrId_MicroteachAppraise)
{
 List<clsMicroteachAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachAppraiseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachAppraise);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsMicroteachAppraiseEN> GetObjLstById_MicroteachAppraiseLst_Cache(List<long> arrId_MicroteachAppraise)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachAppraiseEN._CurrTabName_S);
List<clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLst_Sel =
from objMicroteachAppraiseEN in arrMicroteachAppraiseObjLst_Cache
where arrId_MicroteachAppraise.Contains(objMicroteachAppraiseEN.id_MicroteachAppraise)
select objMicroteachAppraiseEN;
return arrMicroteachAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachAppraiseEN> GetObjLstById_MicroteachAppraiseLst_WA_Cache(List<long> arrId_MicroteachAppraise)
{
 List<clsMicroteachAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachAppraiseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachAppraise);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsMicroteachAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachAppraiseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsMicroteachAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsMicroteachAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachAppraiseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsMicroteachAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_MicroteachAppraise)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsMicroteachAppraiseEN objMicroteachAppraiseEN = clsMicroteachAppraiseWApi.GetObjByid_MicroteachAppraise(lngid_MicroteachAppraise);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_MicroteachAppraise.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMicroteachAppraiseWApi.ReFreshCache();
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
public static int DelMicroteachAppraises(List<string> arrid_MicroteachAppraise)
{
string strAction = "DelMicroteachAppraises";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_MicroteachAppraise);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMicroteachAppraiseWApi.ReFreshCache();
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
public static int DelMicroteachAppraisesByCond(string strWhereCond)
{
string strAction = "DelMicroteachAppraisesByCond";
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
public static bool AddNewRecord(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachAppraiseEN>(objMicroteachAppraiseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseWApi.ReFreshCache();
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
 /// <param name = "objMicroteachAppraiseEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachAppraiseEN>(objMicroteachAppraiseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseWApi.ReFreshCache();
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
public static bool UpdateRecord(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
if (string.IsNullOrEmpty(objMicroteachAppraiseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachAppraiseEN.id_MicroteachAppraise, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachAppraiseEN>(objMicroteachAppraiseEN);
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
 /// <param name = "objMicroteachAppraiseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objMicroteachAppraiseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachAppraiseEN.id_MicroteachAppraise, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachAppraiseEN.id_MicroteachAppraise, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachAppraiseEN>(objMicroteachAppraiseEN);
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
public static bool IsExist(long lngid_MicroteachAppraise)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
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
 /// <param name = "objMicroteachAppraiseENS">源对象</param>
 /// <param name = "objMicroteachAppraiseENT">目标对象</param>
 public static void CopyTo(clsMicroteachAppraiseEN objMicroteachAppraiseENS, clsMicroteachAppraiseEN objMicroteachAppraiseENT)
{
try
{
objMicroteachAppraiseENT.id_MicroteachAppraise = objMicroteachAppraiseENS.id_MicroteachAppraise; //评议流水号
objMicroteachAppraiseENT.FuncModuleId = objMicroteachAppraiseENS.FuncModuleId; //功能模块Id
objMicroteachAppraiseENT.id_MicroteachCase = objMicroteachAppraiseENS.id_MicroteachCase; //微格教学案例流水号
objMicroteachAppraiseENT.id_AppraiseType = objMicroteachAppraiseENS.id_AppraiseType; //评议类型流水号
objMicroteachAppraiseENT.AppraiseTheme = objMicroteachAppraiseENS.AppraiseTheme; //评议主题
objMicroteachAppraiseENT.AppraiseContent = objMicroteachAppraiseENS.AppraiseContent; //评议内容
objMicroteachAppraiseENT.AppraiseDate = objMicroteachAppraiseENS.AppraiseDate; //评议日期
objMicroteachAppraiseENT.AppraiseTime = objMicroteachAppraiseENS.AppraiseTime; //评议时间
objMicroteachAppraiseENT.IsVisual = objMicroteachAppraiseENS.IsVisual; //隐藏标志
objMicroteachAppraiseENT.IsElite = objMicroteachAppraiseENS.IsElite; //精华标志
objMicroteachAppraiseENT.ExcellentOne = objMicroteachAppraiseENS.ExcellentOne; //优点1
objMicroteachAppraiseENT.ExcellentTwo = objMicroteachAppraiseENS.ExcellentTwo; //优点2
objMicroteachAppraiseENT.SuggestOne = objMicroteachAppraiseENS.SuggestOne; //建议1
objMicroteachAppraiseENT.SuggestTwo = objMicroteachAppraiseENS.SuggestTwo; //建议2
objMicroteachAppraiseENT.MicroteachAppriseScore = objMicroteachAppraiseENS.MicroteachAppriseScore; //打分
objMicroteachAppraiseENT.VideoStopTime = objMicroteachAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objMicroteachAppraiseENT.BrowseCount = objMicroteachAppraiseENS.BrowseCount; //浏览次数
objMicroteachAppraiseENT.UserId = objMicroteachAppraiseENS.UserId; //用户ID
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
public static DataTable ToDataTable(List<clsMicroteachAppraiseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsMicroteachAppraiseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsMicroteachAppraiseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsMicroteachAppraiseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsMicroteachAppraiseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsMicroteachAppraiseEN.AttributeName)
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
if (clsMicroteachAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseWApi没有刷新缓存机制(clsMicroteachAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachAppraise");
//if (arrMicroteachAppraiseObjLst_Cache == null)
//{
//arrMicroteachAppraiseObjLst_Cache = await clsMicroteachAppraiseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsMicroteachAppraiseEN._CurrTabName_S);
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
if (clsMicroteachAppraiseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachAppraiseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsMicroteachAppraiseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachAppraiseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachAppraiseEN._CurrTabName_S);
List<clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachAppraiseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsMicroteachAppraiseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conMicroteachAppraise.id_MicroteachAppraise, Type.GetType("System.Int64"));
objDT.Columns.Add(conMicroteachAppraise.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.AppraiseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.AppraiseContent, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.AppraiseDate, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.AppraiseTime, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.IsVisual, Type.GetType("System.Boolean"));
objDT.Columns.Add(conMicroteachAppraise.IsElite, Type.GetType("System.Boolean"));
objDT.Columns.Add(conMicroteachAppraise.ExcellentOne, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.ExcellentTwo, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.SuggestOne, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.SuggestTwo, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.MicroteachAppriseScore, Type.GetType("System.Single"));
objDT.Columns.Add(conMicroteachAppraise.VideoStopTime, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachAppraise.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conMicroteachAppraise.UserId, Type.GetType("System.String"));
foreach (clsMicroteachAppraiseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conMicroteachAppraise.id_MicroteachAppraise] = objInFor[conMicroteachAppraise.id_MicroteachAppraise];
objDR[conMicroteachAppraise.FuncModuleId] = objInFor[conMicroteachAppraise.FuncModuleId];
objDR[conMicroteachAppraise.id_MicroteachCase] = objInFor[conMicroteachAppraise.id_MicroteachCase];
objDR[conMicroteachAppraise.id_AppraiseType] = objInFor[conMicroteachAppraise.id_AppraiseType];
objDR[conMicroteachAppraise.AppraiseTheme] = objInFor[conMicroteachAppraise.AppraiseTheme];
objDR[conMicroteachAppraise.AppraiseContent] = objInFor[conMicroteachAppraise.AppraiseContent];
objDR[conMicroteachAppraise.AppraiseDate] = objInFor[conMicroteachAppraise.AppraiseDate];
objDR[conMicroteachAppraise.AppraiseTime] = objInFor[conMicroteachAppraise.AppraiseTime];
objDR[conMicroteachAppraise.IsVisual] = objInFor[conMicroteachAppraise.IsVisual];
objDR[conMicroteachAppraise.IsElite] = objInFor[conMicroteachAppraise.IsElite];
objDR[conMicroteachAppraise.ExcellentOne] = objInFor[conMicroteachAppraise.ExcellentOne];
objDR[conMicroteachAppraise.ExcellentTwo] = objInFor[conMicroteachAppraise.ExcellentTwo];
objDR[conMicroteachAppraise.SuggestOne] = objInFor[conMicroteachAppraise.SuggestOne];
objDR[conMicroteachAppraise.SuggestTwo] = objInFor[conMicroteachAppraise.SuggestTwo];
objDR[conMicroteachAppraise.MicroteachAppriseScore] = objInFor[conMicroteachAppraise.MicroteachAppriseScore];
objDR[conMicroteachAppraise.VideoStopTime] = objInFor[conMicroteachAppraise.VideoStopTime];
objDR[conMicroteachAppraise.BrowseCount] = objInFor[conMicroteachAppraise.BrowseCount];
objDR[conMicroteachAppraise.UserId] = objInFor[conMicroteachAppraise.UserId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 微格案例定性评议(MicroteachAppraise)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4MicroteachAppraise : clsCommFun4BL
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
clsMicroteachAppraiseWApi.ReFreshThisCache();
}
}

}