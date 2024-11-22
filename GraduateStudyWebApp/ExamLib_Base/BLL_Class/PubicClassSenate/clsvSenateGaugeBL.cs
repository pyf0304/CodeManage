
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeBL
 表名:vSenateGauge(01120508)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsvSenateGaugeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdsenateGauge">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeEN GetObj(this K_IdsenateGauge_vSenateGauge myKey)
{
clsvSenateGaugeEN objvSenateGaugeEN = clsvSenateGaugeBL.vSenateGaugeDA.GetObjByIdsenateGauge(myKey.Value);
return objvSenateGaugeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetIdsenateGauge(this clsvSenateGaugeEN objvSenateGaugeEN, string strIdsenateGauge, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdsenateGauge, 4, convSenateGauge.IdsenateGauge);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdsenateGauge, 4, convSenateGauge.IdsenateGauge);
}
objvSenateGaugeEN.IdsenateGauge = strIdsenateGauge; //评价量规流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.IdsenateGauge) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.IdsenateGauge, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.IdsenateGauge] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeID(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeID, convSenateGauge.senateGaugeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeID, 4, convSenateGauge.senateGaugeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeID, 4, convSenateGauge.senateGaugeID);
}
objvSenateGaugeEN.senateGaugeID = strsenateGaugeID; //评价量规ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.senateGaugeID) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.senateGaugeID, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.senateGaugeID] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeName(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeName, convSenateGauge.senateGaugeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeName, 200, convSenateGauge.senateGaugeName);
}
objvSenateGaugeEN.senateGaugeName = strsenateGaugeName; //评价量规名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.senateGaugeName) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.senateGaugeName, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.senateGaugeName] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeScore(this clsvSenateGaugeEN objvSenateGaugeEN, float? fltsenateGaugeScore, string strComparisonOp="")
	{
objvSenateGaugeEN.senateGaugeScore = fltsenateGaugeScore; //评价量规分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.senateGaugeScore) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.senateGaugeScore, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.senateGaugeScore] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeMemo(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeMemo, 1000, convSenateGauge.senateGaugeMemo);
}
objvSenateGaugeEN.senateGaugeMemo = strsenateGaugeMemo; //评价量规指标与说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.senateGaugeMemo) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.senateGaugeMemo, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.senateGaugeMemo] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetSenateGaugeWeight(this clsvSenateGaugeEN objvSenateGaugeEN, float? fltSenateGaugeWeight, string strComparisonOp="")
	{
objvSenateGaugeEN.SenateGaugeWeight = fltSenateGaugeWeight; //评价量规权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.SenateGaugeWeight) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.SenateGaugeWeight, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.SenateGaugeWeight] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetIdPubClassCaseSenateGaugeVersion(this clsvSenateGaugeEN objvSenateGaugeEN, string strIdPubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCaseSenateGaugeVersion, convSenateGauge.IdPubClassCaseSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCaseSenateGaugeVersion, 4, convSenateGauge.IdPubClassCaseSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCaseSenateGaugeVersion, 4, convSenateGauge.IdPubClassCaseSenateGaugeVersion);
}
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.IdPubClassCaseSenateGaugeVersion) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.IdPubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.IdPubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeVersionID(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convSenateGauge.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convSenateGauge.senateGaugeVersionID);
}
objvSenateGaugeEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.senateGaugeVersionID) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.senateGaugeVersionID, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.senateGaugeVersionID] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeVersionName(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convSenateGauge.senateGaugeVersionName);
}
objvSenateGaugeEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.senateGaugeVersionName) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.senateGaugeVersionName, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.senateGaugeVersionName] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeVersionTtlScore(this clsvSenateGaugeEN objvSenateGaugeEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvSenateGaugeEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.senateGaugeVersionTtlScore) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeVersionMemo(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, convSenateGauge.senateGaugeVersionMemo);
}
objvSenateGaugeEN.senateGaugeVersionMemo = strsenateGaugeVersionMemo; //评价量表版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.senateGaugeVersionMemo) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.senateGaugeVersionMemo, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.senateGaugeVersionMemo] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetIsUse(this clsvSenateGaugeEN objvSenateGaugeEN, bool bolIsUse, string strComparisonOp="")
	{
objvSenateGaugeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.IsUse) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.IsUse, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.IsUse] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetOrderNum(this clsvSenateGaugeEN objvSenateGaugeEN, int? intOrderNum, string strComparisonOp="")
	{
objvSenateGaugeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.OrderNum) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.OrderNum, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.OrderNum] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetUpdDate(this clsvSenateGaugeEN objvSenateGaugeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSenateGauge.UpdDate);
}
objvSenateGaugeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.UpdDate) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.UpdDate, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.UpdDate] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetUpdUserId(this clsvSenateGaugeEN objvSenateGaugeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSenateGauge.UpdUserId);
}
objvSenateGaugeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.UpdUserId) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.UpdUserId, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.UpdUserId] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetVersionNo(this clsvSenateGaugeEN objvSenateGaugeEN, int? intVersionNo, string strComparisonOp="")
	{
objvSenateGaugeEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.VersionNo) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.VersionNo, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.VersionNo] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeNameWithOrder(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeNameWithOrder, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeNameWithOrder, 204, convSenateGauge.senateGaugeNameWithOrder);
}
objvSenateGaugeEN.senateGaugeNameWithOrder = strsenateGaugeNameWithOrder; //senateGaugeNameWithOrder
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.senateGaugeNameWithOrder) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.senateGaugeNameWithOrder, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.senateGaugeNameWithOrder] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSenateGaugeENS">源对象</param>
 /// <param name = "objvSenateGaugeENT">目标对象</param>
 public static void CopyTo(this clsvSenateGaugeEN objvSenateGaugeENS, clsvSenateGaugeEN objvSenateGaugeENT)
{
try
{
objvSenateGaugeENT.IdsenateGauge = objvSenateGaugeENS.IdsenateGauge; //评价量规流水号
objvSenateGaugeENT.senateGaugeID = objvSenateGaugeENS.senateGaugeID; //评价量规ID
objvSenateGaugeENT.senateGaugeName = objvSenateGaugeENS.senateGaugeName; //评价量规名称
objvSenateGaugeENT.senateGaugeScore = objvSenateGaugeENS.senateGaugeScore; //评价量规分值
objvSenateGaugeENT.senateGaugeMemo = objvSenateGaugeENS.senateGaugeMemo; //评价量规指标与说明
objvSenateGaugeENT.SenateGaugeWeight = objvSenateGaugeENS.SenateGaugeWeight; //评价量规权重
objvSenateGaugeENT.IdPubClassCaseSenateGaugeVersion = objvSenateGaugeENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvSenateGaugeENT.senateGaugeVersionID = objvSenateGaugeENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeENT.senateGaugeVersionName = objvSenateGaugeENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeENT.senateGaugeVersionTtlScore = objvSenateGaugeENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeENT.senateGaugeVersionMemo = objvSenateGaugeENS.senateGaugeVersionMemo; //评价量表版本说明
objvSenateGaugeENT.IsUse = objvSenateGaugeENS.IsUse; //是否使用
objvSenateGaugeENT.OrderNum = objvSenateGaugeENS.OrderNum; //序号
objvSenateGaugeENT.UpdDate = objvSenateGaugeENS.UpdDate; //修改日期
objvSenateGaugeENT.UpdUserId = objvSenateGaugeENS.UpdUserId; //修改用户Id
objvSenateGaugeENT.VersionNo = objvSenateGaugeENS.VersionNo; //版本号
objvSenateGaugeENT.senateGaugeNameWithOrder = objvSenateGaugeENS.senateGaugeNameWithOrder; //senateGaugeNameWithOrder
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
 /// <param name = "objvSenateGaugeENS">源对象</param>
 /// <returns>目标对象=>clsvSenateGaugeEN:objvSenateGaugeENT</returns>
 public static clsvSenateGaugeEN CopyTo(this clsvSenateGaugeEN objvSenateGaugeENS)
{
try
{
 clsvSenateGaugeEN objvSenateGaugeENT = new clsvSenateGaugeEN()
{
IdsenateGauge = objvSenateGaugeENS.IdsenateGauge, //评价量规流水号
senateGaugeID = objvSenateGaugeENS.senateGaugeID, //评价量规ID
senateGaugeName = objvSenateGaugeENS.senateGaugeName, //评价量规名称
senateGaugeScore = objvSenateGaugeENS.senateGaugeScore, //评价量规分值
senateGaugeMemo = objvSenateGaugeENS.senateGaugeMemo, //评价量规指标与说明
SenateGaugeWeight = objvSenateGaugeENS.SenateGaugeWeight, //评价量规权重
IdPubClassCaseSenateGaugeVersion = objvSenateGaugeENS.IdPubClassCaseSenateGaugeVersion, //公开课量表版本流水号
senateGaugeVersionID = objvSenateGaugeENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvSenateGaugeENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvSenateGaugeENS.senateGaugeVersionTtlScore, //评价量表版本总分
senateGaugeVersionMemo = objvSenateGaugeENS.senateGaugeVersionMemo, //评价量表版本说明
IsUse = objvSenateGaugeENS.IsUse, //是否使用
OrderNum = objvSenateGaugeENS.OrderNum, //序号
UpdDate = objvSenateGaugeENS.UpdDate, //修改日期
UpdUserId = objvSenateGaugeENS.UpdUserId, //修改用户Id
VersionNo = objvSenateGaugeENS.VersionNo, //版本号
senateGaugeNameWithOrder = objvSenateGaugeENS.senateGaugeNameWithOrder, //senateGaugeNameWithOrder
};
 return objvSenateGaugeENT;
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
public static void CheckProperty4Condition(this clsvSenateGaugeEN objvSenateGaugeEN)
{
 clsvSenateGaugeBL.vSenateGaugeDA.CheckProperty4Condition(objvSenateGaugeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSenateGaugeEN objvSenateGaugeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.IdsenateGauge) == true)
{
string strComparisonOpIdsenateGauge = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.IdsenateGauge];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.IdsenateGauge, objvSenateGaugeCond.IdsenateGauge, strComparisonOpIdsenateGauge);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.senateGaugeID) == true)
{
string strComparisonOpsenateGaugeID = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.senateGaugeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeID, objvSenateGaugeCond.senateGaugeID, strComparisonOpsenateGaugeID);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.senateGaugeName) == true)
{
string strComparisonOpsenateGaugeName = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.senateGaugeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeName, objvSenateGaugeCond.senateGaugeName, strComparisonOpsenateGaugeName);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.senateGaugeScore) == true)
{
string strComparisonOpsenateGaugeScore = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.senateGaugeScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGauge.senateGaugeScore, objvSenateGaugeCond.senateGaugeScore, strComparisonOpsenateGaugeScore);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.senateGaugeMemo) == true)
{
string strComparisonOpsenateGaugeMemo = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.senateGaugeMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeMemo, objvSenateGaugeCond.senateGaugeMemo, strComparisonOpsenateGaugeMemo);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.SenateGaugeWeight) == true)
{
string strComparisonOpSenateGaugeWeight = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.SenateGaugeWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGauge.SenateGaugeWeight, objvSenateGaugeCond.SenateGaugeWeight, strComparisonOpSenateGaugeWeight);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.IdPubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOpIdPubClassCaseSenateGaugeVersion = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.IdPubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.IdPubClassCaseSenateGaugeVersion, objvSenateGaugeCond.IdPubClassCaseSenateGaugeVersion, strComparisonOpIdPubClassCaseSenateGaugeVersion);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeVersionID, objvSenateGaugeCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeVersionName, objvSenateGaugeCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGauge.senateGaugeVersionTtlScore, objvSenateGaugeCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.senateGaugeVersionMemo) == true)
{
string strComparisonOpsenateGaugeVersionMemo = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeVersionMemo, objvSenateGaugeCond.senateGaugeVersionMemo, strComparisonOpsenateGaugeVersionMemo);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.IsUse) == true)
{
if (objvSenateGaugeCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGauge.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGauge.IsUse);
}
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.OrderNum) == true)
{
string strComparisonOpOrderNum = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGauge.OrderNum, objvSenateGaugeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.UpdDate, objvSenateGaugeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.UpdUserId, objvSenateGaugeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.VersionNo) == true)
{
string strComparisonOpVersionNo = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGauge.VersionNo, objvSenateGaugeCond.VersionNo, strComparisonOpVersionNo);
}
if (objvSenateGaugeCond.IsUpdated(convSenateGauge.senateGaugeNameWithOrder) == true)
{
string strComparisonOpsenateGaugeNameWithOrder = objvSenateGaugeCond.dicFldComparisonOp[convSenateGauge.senateGaugeNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeNameWithOrder, objvSenateGaugeCond.senateGaugeNameWithOrder, strComparisonOpsenateGaugeNameWithOrder);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSenateGauge
{
public virtual bool UpdRelaTabDate(string strIdsenateGauge, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v公开课评价量规(vSenateGauge)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSenateGaugeBL
{
public static RelatedActions_vSenateGauge relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSenateGaugeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSenateGaugeDA vSenateGaugeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSenateGaugeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSenateGaugeBL()
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
if (string.IsNullOrEmpty(clsvSenateGaugeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSenateGaugeEN._ConnectString);
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
public static DataTable GetDataTable_vSenateGauge(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSenateGaugeDA.GetDataTable_vSenateGauge(strWhereCond);
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
objDT = vSenateGaugeDA.GetDataTable(strWhereCond);
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
objDT = vSenateGaugeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSenateGaugeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSenateGaugeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSenateGaugeDA.GetDataTable_Top(objTopPara);
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
objDT = vSenateGaugeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSenateGaugeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSenateGaugeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdsenateGaugeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSenateGaugeEN> GetObjLstByIdsenateGaugeLst(List<string> arrIdsenateGaugeLst)
{
List<clsvSenateGaugeEN> arrObjLst = new List<clsvSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdsenateGaugeLst, true);
 string strWhereCond = string.Format("IdsenateGauge in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN();
try
{
objvSenateGaugeEN.IdsenateGauge = objRow[convSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvSenateGaugeEN.senateGaugeID = objRow[convSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objvSenateGaugeEN.senateGaugeName = objRow[convSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objvSenateGaugeEN.senateGaugeScore = objRow[convSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objvSenateGaugeEN.senateGaugeMemo = objRow[convSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvSenateGaugeEN.SenateGaugeWeight = objRow[convSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[convSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvSenateGaugeEN.senateGaugeVersionID = objRow[convSenateGauge.senateGaugeVersionID] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeEN.senateGaugeVersionName = objRow[convSenateGauge.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeEN.senateGaugeVersionTtlScore = objRow[convSenateGauge.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeEN.senateGaugeVersionMemo = objRow[convSenateGauge.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGauge.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeEN.OrderNum = objRow[convSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.OrderNum].ToString().Trim()); //序号
objvSenateGaugeEN.UpdDate = objRow[convSenateGauge.UpdDate] == DBNull.Value ? null : objRow[convSenateGauge.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeEN.UpdUserId = objRow[convSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[convSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeEN.VersionNo = objRow[convSenateGauge.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeEN.senateGaugeNameWithOrder = objRow[convSenateGauge.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdsenateGaugeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSenateGaugeEN> GetObjLstByIdsenateGaugeLstCache(List<string> arrIdsenateGaugeLst)
{
string strKey = string.Format("{0}", clsvSenateGaugeEN._CurrTabName);
List<clsvSenateGaugeEN> arrvSenateGaugeObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeEN> arrvSenateGaugeObjLst_Sel =
arrvSenateGaugeObjLstCache
.Where(x => arrIdsenateGaugeLst.Contains(x.IdsenateGauge));
return arrvSenateGaugeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeEN> GetObjLst(string strWhereCond)
{
List<clsvSenateGaugeEN> arrObjLst = new List<clsvSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN();
try
{
objvSenateGaugeEN.IdsenateGauge = objRow[convSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvSenateGaugeEN.senateGaugeID = objRow[convSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objvSenateGaugeEN.senateGaugeName = objRow[convSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objvSenateGaugeEN.senateGaugeScore = objRow[convSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objvSenateGaugeEN.senateGaugeMemo = objRow[convSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvSenateGaugeEN.SenateGaugeWeight = objRow[convSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[convSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvSenateGaugeEN.senateGaugeVersionID = objRow[convSenateGauge.senateGaugeVersionID] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeEN.senateGaugeVersionName = objRow[convSenateGauge.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeEN.senateGaugeVersionTtlScore = objRow[convSenateGauge.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeEN.senateGaugeVersionMemo = objRow[convSenateGauge.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGauge.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeEN.OrderNum = objRow[convSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.OrderNum].ToString().Trim()); //序号
objvSenateGaugeEN.UpdDate = objRow[convSenateGauge.UpdDate] == DBNull.Value ? null : objRow[convSenateGauge.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeEN.UpdUserId = objRow[convSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[convSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeEN.VersionNo = objRow[convSenateGauge.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeEN.senateGaugeNameWithOrder = objRow[convSenateGauge.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeEN);
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
public static List<clsvSenateGaugeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSenateGaugeEN> arrObjLst = new List<clsvSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN();
try
{
objvSenateGaugeEN.IdsenateGauge = objRow[convSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvSenateGaugeEN.senateGaugeID = objRow[convSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objvSenateGaugeEN.senateGaugeName = objRow[convSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objvSenateGaugeEN.senateGaugeScore = objRow[convSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objvSenateGaugeEN.senateGaugeMemo = objRow[convSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvSenateGaugeEN.SenateGaugeWeight = objRow[convSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[convSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvSenateGaugeEN.senateGaugeVersionID = objRow[convSenateGauge.senateGaugeVersionID] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeEN.senateGaugeVersionName = objRow[convSenateGauge.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeEN.senateGaugeVersionTtlScore = objRow[convSenateGauge.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeEN.senateGaugeVersionMemo = objRow[convSenateGauge.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGauge.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeEN.OrderNum = objRow[convSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.OrderNum].ToString().Trim()); //序号
objvSenateGaugeEN.UpdDate = objRow[convSenateGauge.UpdDate] == DBNull.Value ? null : objRow[convSenateGauge.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeEN.UpdUserId = objRow[convSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[convSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeEN.VersionNo = objRow[convSenateGauge.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeEN.senateGaugeNameWithOrder = objRow[convSenateGauge.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSenateGaugeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSenateGaugeEN> GetSubObjLstCache(clsvSenateGaugeEN objvSenateGaugeCond)
{
List<clsvSenateGaugeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSenateGauge.AttributeName)
{
if (objvSenateGaugeCond.IsUpdated(strFldName) == false) continue;
if (objvSenateGaugeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeCond[strFldName].ToString());
}
else
{
if (objvSenateGaugeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSenateGaugeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSenateGaugeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeCond[strFldName]));
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
public static List<clsvSenateGaugeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSenateGaugeEN> arrObjLst = new List<clsvSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN();
try
{
objvSenateGaugeEN.IdsenateGauge = objRow[convSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvSenateGaugeEN.senateGaugeID = objRow[convSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objvSenateGaugeEN.senateGaugeName = objRow[convSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objvSenateGaugeEN.senateGaugeScore = objRow[convSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objvSenateGaugeEN.senateGaugeMemo = objRow[convSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvSenateGaugeEN.SenateGaugeWeight = objRow[convSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[convSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvSenateGaugeEN.senateGaugeVersionID = objRow[convSenateGauge.senateGaugeVersionID] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeEN.senateGaugeVersionName = objRow[convSenateGauge.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeEN.senateGaugeVersionTtlScore = objRow[convSenateGauge.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeEN.senateGaugeVersionMemo = objRow[convSenateGauge.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGauge.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeEN.OrderNum = objRow[convSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.OrderNum].ToString().Trim()); //序号
objvSenateGaugeEN.UpdDate = objRow[convSenateGauge.UpdDate] == DBNull.Value ? null : objRow[convSenateGauge.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeEN.UpdUserId = objRow[convSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[convSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeEN.VersionNo = objRow[convSenateGauge.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeEN.senateGaugeNameWithOrder = objRow[convSenateGauge.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeEN);
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
public static List<clsvSenateGaugeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSenateGaugeEN> arrObjLst = new List<clsvSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN();
try
{
objvSenateGaugeEN.IdsenateGauge = objRow[convSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvSenateGaugeEN.senateGaugeID = objRow[convSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objvSenateGaugeEN.senateGaugeName = objRow[convSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objvSenateGaugeEN.senateGaugeScore = objRow[convSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objvSenateGaugeEN.senateGaugeMemo = objRow[convSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvSenateGaugeEN.SenateGaugeWeight = objRow[convSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[convSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvSenateGaugeEN.senateGaugeVersionID = objRow[convSenateGauge.senateGaugeVersionID] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeEN.senateGaugeVersionName = objRow[convSenateGauge.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeEN.senateGaugeVersionTtlScore = objRow[convSenateGauge.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeEN.senateGaugeVersionMemo = objRow[convSenateGauge.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGauge.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeEN.OrderNum = objRow[convSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.OrderNum].ToString().Trim()); //序号
objvSenateGaugeEN.UpdDate = objRow[convSenateGauge.UpdDate] == DBNull.Value ? null : objRow[convSenateGauge.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeEN.UpdUserId = objRow[convSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[convSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeEN.VersionNo = objRow[convSenateGauge.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeEN.senateGaugeNameWithOrder = objRow[convSenateGauge.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeEN);
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
List<clsvSenateGaugeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSenateGaugeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSenateGaugeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSenateGaugeEN> arrObjLst = new List<clsvSenateGaugeEN>(); 
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
	clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN();
try
{
objvSenateGaugeEN.IdsenateGauge = objRow[convSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvSenateGaugeEN.senateGaugeID = objRow[convSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objvSenateGaugeEN.senateGaugeName = objRow[convSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objvSenateGaugeEN.senateGaugeScore = objRow[convSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objvSenateGaugeEN.senateGaugeMemo = objRow[convSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvSenateGaugeEN.SenateGaugeWeight = objRow[convSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[convSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvSenateGaugeEN.senateGaugeVersionID = objRow[convSenateGauge.senateGaugeVersionID] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeEN.senateGaugeVersionName = objRow[convSenateGauge.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeEN.senateGaugeVersionTtlScore = objRow[convSenateGauge.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeEN.senateGaugeVersionMemo = objRow[convSenateGauge.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGauge.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeEN.OrderNum = objRow[convSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.OrderNum].ToString().Trim()); //序号
objvSenateGaugeEN.UpdDate = objRow[convSenateGauge.UpdDate] == DBNull.Value ? null : objRow[convSenateGauge.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeEN.UpdUserId = objRow[convSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[convSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeEN.VersionNo = objRow[convSenateGauge.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeEN.senateGaugeNameWithOrder = objRow[convSenateGauge.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeEN);
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
public static List<clsvSenateGaugeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSenateGaugeEN> arrObjLst = new List<clsvSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN();
try
{
objvSenateGaugeEN.IdsenateGauge = objRow[convSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvSenateGaugeEN.senateGaugeID = objRow[convSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objvSenateGaugeEN.senateGaugeName = objRow[convSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objvSenateGaugeEN.senateGaugeScore = objRow[convSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objvSenateGaugeEN.senateGaugeMemo = objRow[convSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvSenateGaugeEN.SenateGaugeWeight = objRow[convSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[convSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvSenateGaugeEN.senateGaugeVersionID = objRow[convSenateGauge.senateGaugeVersionID] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeEN.senateGaugeVersionName = objRow[convSenateGauge.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeEN.senateGaugeVersionTtlScore = objRow[convSenateGauge.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeEN.senateGaugeVersionMemo = objRow[convSenateGauge.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGauge.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeEN.OrderNum = objRow[convSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.OrderNum].ToString().Trim()); //序号
objvSenateGaugeEN.UpdDate = objRow[convSenateGauge.UpdDate] == DBNull.Value ? null : objRow[convSenateGauge.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeEN.UpdUserId = objRow[convSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[convSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeEN.VersionNo = objRow[convSenateGauge.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeEN.senateGaugeNameWithOrder = objRow[convSenateGauge.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSenateGaugeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSenateGaugeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSenateGaugeEN> arrObjLst = new List<clsvSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN();
try
{
objvSenateGaugeEN.IdsenateGauge = objRow[convSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvSenateGaugeEN.senateGaugeID = objRow[convSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objvSenateGaugeEN.senateGaugeName = objRow[convSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objvSenateGaugeEN.senateGaugeScore = objRow[convSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objvSenateGaugeEN.senateGaugeMemo = objRow[convSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvSenateGaugeEN.SenateGaugeWeight = objRow[convSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[convSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvSenateGaugeEN.senateGaugeVersionID = objRow[convSenateGauge.senateGaugeVersionID] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeEN.senateGaugeVersionName = objRow[convSenateGauge.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeEN.senateGaugeVersionTtlScore = objRow[convSenateGauge.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeEN.senateGaugeVersionMemo = objRow[convSenateGauge.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGauge.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeEN.OrderNum = objRow[convSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.OrderNum].ToString().Trim()); //序号
objvSenateGaugeEN.UpdDate = objRow[convSenateGauge.UpdDate] == DBNull.Value ? null : objRow[convSenateGauge.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeEN.UpdUserId = objRow[convSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[convSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeEN.VersionNo = objRow[convSenateGauge.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeEN.senateGaugeNameWithOrder = objRow[convSenateGauge.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeEN);
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
public static List<clsvSenateGaugeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSenateGaugeEN> arrObjLst = new List<clsvSenateGaugeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN();
try
{
objvSenateGaugeEN.IdsenateGauge = objRow[convSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvSenateGaugeEN.senateGaugeID = objRow[convSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objvSenateGaugeEN.senateGaugeName = objRow[convSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objvSenateGaugeEN.senateGaugeScore = objRow[convSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objvSenateGaugeEN.senateGaugeMemo = objRow[convSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvSenateGaugeEN.SenateGaugeWeight = objRow[convSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[convSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvSenateGaugeEN.senateGaugeVersionID = objRow[convSenateGauge.senateGaugeVersionID] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeEN.senateGaugeVersionName = objRow[convSenateGauge.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeEN.senateGaugeVersionTtlScore = objRow[convSenateGauge.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeEN.senateGaugeVersionMemo = objRow[convSenateGauge.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGauge.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeEN.OrderNum = objRow[convSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.OrderNum].ToString().Trim()); //序号
objvSenateGaugeEN.UpdDate = objRow[convSenateGauge.UpdDate] == DBNull.Value ? null : objRow[convSenateGauge.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeEN.UpdUserId = objRow[convSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[convSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeEN.VersionNo = objRow[convSenateGauge.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeEN.senateGaugeNameWithOrder = objRow[convSenateGauge.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSenateGaugeEN> arrObjLst = new List<clsvSenateGaugeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN();
try
{
objvSenateGaugeEN.IdsenateGauge = objRow[convSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvSenateGaugeEN.senateGaugeID = objRow[convSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objvSenateGaugeEN.senateGaugeName = objRow[convSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objvSenateGaugeEN.senateGaugeScore = objRow[convSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objvSenateGaugeEN.senateGaugeMemo = objRow[convSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvSenateGaugeEN.SenateGaugeWeight = objRow[convSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[convSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvSenateGaugeEN.senateGaugeVersionID = objRow[convSenateGauge.senateGaugeVersionID] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeEN.senateGaugeVersionName = objRow[convSenateGauge.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeEN.senateGaugeVersionTtlScore = objRow[convSenateGauge.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGauge.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeEN.senateGaugeVersionMemo = objRow[convSenateGauge.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGauge.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeEN.OrderNum = objRow[convSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.OrderNum].ToString().Trim()); //序号
objvSenateGaugeEN.UpdDate = objRow[convSenateGauge.UpdDate] == DBNull.Value ? null : objRow[convSenateGauge.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeEN.UpdUserId = objRow[convSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[convSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeEN.VersionNo = objRow[convSenateGauge.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGauge.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeEN.senateGaugeNameWithOrder = objRow[convSenateGauge.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convSenateGauge.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeEN.IdsenateGauge, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSenateGauge(ref clsvSenateGaugeEN objvSenateGaugeEN)
{
bool bolResult = vSenateGaugeDA.GetvSenateGauge(ref objvSenateGaugeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdsenateGauge">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeEN GetObjByIdsenateGauge(string strIdsenateGauge)
{
if (strIdsenateGauge.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdsenateGauge]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdsenateGauge) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdsenateGauge]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSenateGaugeEN objvSenateGaugeEN = vSenateGaugeDA.GetObjByIdsenateGauge(strIdsenateGauge);
return objvSenateGaugeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSenateGaugeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSenateGaugeEN objvSenateGaugeEN = vSenateGaugeDA.GetFirstObj(strWhereCond);
 return objvSenateGaugeEN;
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
public static clsvSenateGaugeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSenateGaugeEN objvSenateGaugeEN = vSenateGaugeDA.GetObjByDataRow(objRow);
 return objvSenateGaugeEN;
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
public static clsvSenateGaugeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSenateGaugeEN objvSenateGaugeEN = vSenateGaugeDA.GetObjByDataRow(objRow);
 return objvSenateGaugeEN;
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
 /// <param name = "strIdsenateGauge">所给的关键字</param>
 /// <param name = "lstvSenateGaugeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeEN GetObjByIdsenateGaugeFromList(string strIdsenateGauge, List<clsvSenateGaugeEN> lstvSenateGaugeObjLst)
{
foreach (clsvSenateGaugeEN objvSenateGaugeEN in lstvSenateGaugeObjLst)
{
if (objvSenateGaugeEN.IdsenateGauge == strIdsenateGauge)
{
return objvSenateGaugeEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdsenateGauge;
 try
 {
 strIdsenateGauge = new clsvSenateGaugeDA().GetFirstID(strWhereCond);
 return strIdsenateGauge;
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
 arrList = vSenateGaugeDA.GetID(strWhereCond);
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
bool bolIsExist = vSenateGaugeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdsenateGauge">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdsenateGauge)
{
if (string.IsNullOrEmpty(strIdsenateGauge) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdsenateGauge]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSenateGaugeDA.IsExist(strIdsenateGauge);
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
 bolIsExist = clsvSenateGaugeDA.IsExistTable();
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
 bolIsExist = vSenateGaugeDA.IsExistTable(strTabName);
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
 /// <param name = "objvSenateGaugeENS">源对象</param>
 /// <param name = "objvSenateGaugeENT">目标对象</param>
 public static void CopyTo(clsvSenateGaugeEN objvSenateGaugeENS, clsvSenateGaugeEN objvSenateGaugeENT)
{
try
{
objvSenateGaugeENT.IdsenateGauge = objvSenateGaugeENS.IdsenateGauge; //评价量规流水号
objvSenateGaugeENT.senateGaugeID = objvSenateGaugeENS.senateGaugeID; //评价量规ID
objvSenateGaugeENT.senateGaugeName = objvSenateGaugeENS.senateGaugeName; //评价量规名称
objvSenateGaugeENT.senateGaugeScore = objvSenateGaugeENS.senateGaugeScore; //评价量规分值
objvSenateGaugeENT.senateGaugeMemo = objvSenateGaugeENS.senateGaugeMemo; //评价量规指标与说明
objvSenateGaugeENT.SenateGaugeWeight = objvSenateGaugeENS.SenateGaugeWeight; //评价量规权重
objvSenateGaugeENT.IdPubClassCaseSenateGaugeVersion = objvSenateGaugeENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvSenateGaugeENT.senateGaugeVersionID = objvSenateGaugeENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeENT.senateGaugeVersionName = objvSenateGaugeENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeENT.senateGaugeVersionTtlScore = objvSenateGaugeENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeENT.senateGaugeVersionMemo = objvSenateGaugeENS.senateGaugeVersionMemo; //评价量表版本说明
objvSenateGaugeENT.IsUse = objvSenateGaugeENS.IsUse; //是否使用
objvSenateGaugeENT.OrderNum = objvSenateGaugeENS.OrderNum; //序号
objvSenateGaugeENT.UpdDate = objvSenateGaugeENS.UpdDate; //修改日期
objvSenateGaugeENT.UpdUserId = objvSenateGaugeENS.UpdUserId; //修改用户Id
objvSenateGaugeENT.VersionNo = objvSenateGaugeENS.VersionNo; //版本号
objvSenateGaugeENT.senateGaugeNameWithOrder = objvSenateGaugeENS.senateGaugeNameWithOrder; //senateGaugeNameWithOrder
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
 /// <param name = "objvSenateGaugeEN">源简化对象</param>
 public static void SetUpdFlag(clsvSenateGaugeEN objvSenateGaugeEN)
{
try
{
objvSenateGaugeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSenateGaugeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSenateGauge.IdsenateGauge, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.IdsenateGauge = objvSenateGaugeEN.IdsenateGauge; //评价量规流水号
}
if (arrFldSet.Contains(convSenateGauge.senateGaugeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.senateGaugeID = objvSenateGaugeEN.senateGaugeID; //评价量规ID
}
if (arrFldSet.Contains(convSenateGauge.senateGaugeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.senateGaugeName = objvSenateGaugeEN.senateGaugeName; //评价量规名称
}
if (arrFldSet.Contains(convSenateGauge.senateGaugeScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.senateGaugeScore = objvSenateGaugeEN.senateGaugeScore; //评价量规分值
}
if (arrFldSet.Contains(convSenateGauge.senateGaugeMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.senateGaugeMemo = objvSenateGaugeEN.senateGaugeMemo == "[null]" ? null :  objvSenateGaugeEN.senateGaugeMemo; //评价量规指标与说明
}
if (arrFldSet.Contains(convSenateGauge.SenateGaugeWeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.SenateGaugeWeight = objvSenateGaugeEN.SenateGaugeWeight; //评价量规权重
}
if (arrFldSet.Contains(convSenateGauge.IdPubClassCaseSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objvSenateGaugeEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
}
if (arrFldSet.Contains(convSenateGauge.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.senateGaugeVersionID = objvSenateGaugeEN.senateGaugeVersionID == "[null]" ? null :  objvSenateGaugeEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convSenateGauge.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.senateGaugeVersionName = objvSenateGaugeEN.senateGaugeVersionName == "[null]" ? null :  objvSenateGaugeEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convSenateGauge.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.senateGaugeVersionTtlScore = objvSenateGaugeEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convSenateGauge.senateGaugeVersionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.senateGaugeVersionMemo = objvSenateGaugeEN.senateGaugeVersionMemo == "[null]" ? null :  objvSenateGaugeEN.senateGaugeVersionMemo; //评价量表版本说明
}
if (arrFldSet.Contains(convSenateGauge.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.IsUse = objvSenateGaugeEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convSenateGauge.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.OrderNum = objvSenateGaugeEN.OrderNum; //序号
}
if (arrFldSet.Contains(convSenateGauge.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.UpdDate = objvSenateGaugeEN.UpdDate == "[null]" ? null :  objvSenateGaugeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSenateGauge.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.UpdUserId = objvSenateGaugeEN.UpdUserId == "[null]" ? null :  objvSenateGaugeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convSenateGauge.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.VersionNo = objvSenateGaugeEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convSenateGauge.senateGaugeNameWithOrder, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeEN.senateGaugeNameWithOrder = objvSenateGaugeEN.senateGaugeNameWithOrder == "[null]" ? null :  objvSenateGaugeEN.senateGaugeNameWithOrder; //senateGaugeNameWithOrder
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
 /// <param name = "objvSenateGaugeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSenateGaugeEN objvSenateGaugeEN)
{
try
{
if (objvSenateGaugeEN.senateGaugeMemo == "[null]") objvSenateGaugeEN.senateGaugeMemo = null; //评价量规指标与说明
if (objvSenateGaugeEN.senateGaugeVersionID == "[null]") objvSenateGaugeEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvSenateGaugeEN.senateGaugeVersionName == "[null]") objvSenateGaugeEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvSenateGaugeEN.senateGaugeVersionMemo == "[null]") objvSenateGaugeEN.senateGaugeVersionMemo = null; //评价量表版本说明
if (objvSenateGaugeEN.UpdDate == "[null]") objvSenateGaugeEN.UpdDate = null; //修改日期
if (objvSenateGaugeEN.UpdUserId == "[null]") objvSenateGaugeEN.UpdUserId = null; //修改用户Id
if (objvSenateGaugeEN.senateGaugeNameWithOrder == "[null]") objvSenateGaugeEN.senateGaugeNameWithOrder = null; //senateGaugeNameWithOrder
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
public static void CheckProperty4Condition(clsvSenateGaugeEN objvSenateGaugeEN)
{
 vSenateGaugeDA.CheckProperty4Condition(objvSenateGaugeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdsenateGauge(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convSenateGauge.IdsenateGauge); 
List<clsvSenateGaugeEN> arrObjLst = clsvSenateGaugeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN()
{
IdsenateGauge = "0",
senateGaugeName = "选[v公开课评价量规]..."
};
arrObjLst.Insert(0, objvSenateGaugeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convSenateGauge.IdsenateGauge;
objComboBox.DisplayMember = convSenateGauge.senateGaugeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdsenateGauge(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v公开课评价量规]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convSenateGauge.IdsenateGauge); 
IEnumerable<clsvSenateGaugeEN> arrObjLst = clsvSenateGaugeBL.GetObjLst(strCondition);
objDDL.DataValueField = convSenateGauge.IdsenateGauge;
objDDL.DataTextField = convSenateGauge.senateGaugeName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdsenateGaugeCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v公开课评价量规]...","0");
List<clsvSenateGaugeEN> arrvSenateGaugeObjLst = GetAllvSenateGaugeObjLstCache(); 
objDDL.DataValueField = convSenateGauge.IdsenateGauge;
objDDL.DataTextField = convSenateGauge.senateGaugeName;
objDDL.DataSource = arrvSenateGaugeObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionBL没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeBL没有刷新缓存机制(clsSenateGaugeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdsenateGauge");
//if (arrvSenateGaugeObjLstCache == null)
//{
//arrvSenateGaugeObjLstCache = vSenateGaugeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdsenateGauge">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeEN GetObjByIdsenateGaugeCache(string strIdsenateGauge)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSenateGaugeEN._CurrTabName);
List<clsvSenateGaugeEN> arrvSenateGaugeObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeEN> arrvSenateGaugeObjLst_Sel =
arrvSenateGaugeObjLstCache
.Where(x=> x.IdsenateGauge == strIdsenateGauge 
);
if (arrvSenateGaugeObjLst_Sel.Count() == 0)
{
   clsvSenateGaugeEN obj = clsvSenateGaugeBL.GetObjByIdsenateGauge(strIdsenateGauge);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSenateGaugeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdsenateGauge">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeNameByIdsenateGaugeCache(string strIdsenateGauge)
{
if (string.IsNullOrEmpty(strIdsenateGauge) == true) return "";
//获取缓存中的对象列表
clsvSenateGaugeEN objvSenateGauge = GetObjByIdsenateGaugeCache(strIdsenateGauge);
if (objvSenateGauge == null) return "";
return objvSenateGauge.senateGaugeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdsenateGauge">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdsenateGaugeCache(string strIdsenateGauge)
{
if (string.IsNullOrEmpty(strIdsenateGauge) == true) return "";
//获取缓存中的对象列表
clsvSenateGaugeEN objvSenateGauge = GetObjByIdsenateGaugeCache(strIdsenateGauge);
if (objvSenateGauge == null) return "";
return objvSenateGauge.senateGaugeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSenateGaugeEN> GetAllvSenateGaugeObjLstCache()
{
//获取缓存中的对象列表
List<clsvSenateGaugeEN> arrvSenateGaugeObjLstCache = GetObjLstCache(); 
return arrvSenateGaugeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSenateGaugeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSenateGaugeEN._CurrTabName);
List<clsvSenateGaugeEN> arrvSenateGaugeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSenateGaugeObjLstCache;
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
string strKey = string.Format("{0}", clsvSenateGaugeEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdsenateGauge)
{
if (strInFldName != convSenateGauge.IdsenateGauge)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSenateGauge.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSenateGauge.AttributeName));
throw new Exception(strMsg);
}
var objvSenateGauge = clsvSenateGaugeBL.GetObjByIdsenateGaugeCache(strIdsenateGauge);
if (objvSenateGauge == null) return "";
return objvSenateGauge[strOutFldName].ToString();
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
int intRecCount = clsvSenateGaugeDA.GetRecCount(strTabName);
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
int intRecCount = clsvSenateGaugeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSenateGaugeDA.GetRecCount();
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
int intRecCount = clsvSenateGaugeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSenateGaugeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSenateGaugeEN objvSenateGaugeCond)
{
List<clsvSenateGaugeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSenateGauge.AttributeName)
{
if (objvSenateGaugeCond.IsUpdated(strFldName) == false) continue;
if (objvSenateGaugeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeCond[strFldName].ToString());
}
else
{
if (objvSenateGaugeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSenateGaugeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSenateGaugeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSenateGaugeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeCond[strFldName]));
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
 List<string> arrList = clsvSenateGaugeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSenateGaugeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSenateGaugeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}