
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeWApi
 表名:vSenateGauge(01120508)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:25
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩
 模块英文名:PubicClassSenate
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
public static class clsvSenateGaugeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN Setid_senateGauge(this clsvSenateGaugeEN objvSenateGaugeEN, string strid_senateGauge, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_senateGauge, 4, convSenateGauge.id_senateGauge);
clsCheckSql.CheckFieldForeignKey(strid_senateGauge, 4, convSenateGauge.id_senateGauge);
objvSenateGaugeEN.id_senateGauge = strid_senateGauge; //评价量规流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.id_senateGauge) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.id_senateGauge, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.id_senateGauge] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeID(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeID, convSenateGauge.senateGaugeID);
clsCheckSql.CheckFieldLen(strsenateGaugeID, 4, convSenateGauge.senateGaugeID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeID, 4, convSenateGauge.senateGaugeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeName(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeName, convSenateGauge.senateGaugeName);
clsCheckSql.CheckFieldLen(strsenateGaugeName, 200, convSenateGauge.senateGaugeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeScore(this clsvSenateGaugeEN objvSenateGaugeEN, float fltsenateGaugeScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeMemo(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeMemo, 1000, convSenateGauge.senateGaugeMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetSenateGaugeWeight(this clsvSenateGaugeEN objvSenateGaugeEN, float fltSenateGaugeWeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN Setid_PubClassCaseSenateGaugeVersion(this clsvSenateGaugeEN objvSenateGaugeEN, string strid_PubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCaseSenateGaugeVersion, convSenateGauge.id_PubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_PubClassCaseSenateGaugeVersion, 4, convSenateGauge.id_PubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCaseSenateGaugeVersion, 4, convSenateGauge.id_PubClassCaseSenateGaugeVersion);
objvSenateGaugeEN.id_PubClassCaseSenateGaugeVersion = strid_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeEN.dicFldComparisonOp.ContainsKey(convSenateGauge.id_PubClassCaseSenateGaugeVersion) == false)
{
objvSenateGaugeEN.dicFldComparisonOp.Add(convSenateGauge.id_PubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objvSenateGaugeEN.dicFldComparisonOp[convSenateGauge.id_PubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objvSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeVersionID(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convSenateGauge.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convSenateGauge.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeVersionName(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convSenateGauge.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeVersionTtlScore(this clsvSenateGaugeEN objvSenateGaugeEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeVersionMemo(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, convSenateGauge.senateGaugeVersionMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetOrderNum(this clsvSenateGaugeEN objvSenateGaugeEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetUpdDate(this clsvSenateGaugeEN objvSenateGaugeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSenateGauge.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetUpdUserId(this clsvSenateGaugeEN objvSenateGaugeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSenateGauge.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetVersionNo(this clsvSenateGaugeEN objvSenateGaugeEN, int intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeEN SetsenateGaugeNameWithOrder(this clsvSenateGaugeEN objvSenateGaugeEN, string strsenateGaugeNameWithOrder, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeNameWithOrder, 204, convSenateGauge.senateGaugeNameWithOrder);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSenateGaugeEN objvSenateGauge_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.id_senateGauge) == true)
{
string strComparisonOp_id_senateGauge = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.id_senateGauge];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.id_senateGauge, objvSenateGauge_Cond.id_senateGauge, strComparisonOp_id_senateGauge);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.senateGaugeID) == true)
{
string strComparisonOp_senateGaugeID = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.senateGaugeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeID, objvSenateGauge_Cond.senateGaugeID, strComparisonOp_senateGaugeID);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.senateGaugeName) == true)
{
string strComparisonOp_senateGaugeName = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.senateGaugeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeName, objvSenateGauge_Cond.senateGaugeName, strComparisonOp_senateGaugeName);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.senateGaugeScore) == true)
{
string strComparisonOp_senateGaugeScore = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.senateGaugeScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGauge.senateGaugeScore, objvSenateGauge_Cond.senateGaugeScore, strComparisonOp_senateGaugeScore);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.senateGaugeMemo) == true)
{
string strComparisonOp_senateGaugeMemo = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.senateGaugeMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeMemo, objvSenateGauge_Cond.senateGaugeMemo, strComparisonOp_senateGaugeMemo);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.SenateGaugeWeight) == true)
{
string strComparisonOp_SenateGaugeWeight = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.SenateGaugeWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGauge.SenateGaugeWeight, objvSenateGauge_Cond.SenateGaugeWeight, strComparisonOp_SenateGaugeWeight);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.id_PubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOp_id_PubClassCaseSenateGaugeVersion = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.id_PubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.id_PubClassCaseSenateGaugeVersion, objvSenateGauge_Cond.id_PubClassCaseSenateGaugeVersion, strComparisonOp_id_PubClassCaseSenateGaugeVersion);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeVersionID, objvSenateGauge_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeVersionName, objvSenateGauge_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGauge.senateGaugeVersionTtlScore, objvSenateGauge_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.senateGaugeVersionMemo) == true)
{
string strComparisonOp_senateGaugeVersionMemo = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeVersionMemo, objvSenateGauge_Cond.senateGaugeVersionMemo, strComparisonOp_senateGaugeVersionMemo);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.IsUse) == true)
{
if (objvSenateGauge_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGauge.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGauge.IsUse);
}
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGauge.OrderNum, objvSenateGauge_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.UpdDate, objvSenateGauge_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.UpdUserId, objvSenateGauge_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGauge.VersionNo, objvSenateGauge_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvSenateGauge_Cond.IsUpdated(convSenateGauge.senateGaugeNameWithOrder) == true)
{
string strComparisonOp_senateGaugeNameWithOrder = objvSenateGauge_Cond.dicFldComparisonOp[convSenateGauge.senateGaugeNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGauge.senateGaugeNameWithOrder, objvSenateGauge_Cond.senateGaugeNameWithOrder, strComparisonOp_senateGaugeNameWithOrder);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v公开课评价量规(vSenateGauge)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSenateGaugeWApi
{
private static readonly string mstrApiControllerName = "vSenateGaugeApi";

 public clsvSenateGaugeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_senateGauge(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v公开课评价量规]...","0");
List<clsvSenateGaugeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_senateGauge";
objDDL.DataTextField="senateGaugeName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_senateGauge(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convSenateGauge.id_senateGauge); 
List<clsvSenateGaugeEN> arrObjLst = clsvSenateGaugeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvSenateGaugeEN objvSenateGaugeEN = new clsvSenateGaugeEN()
{
id_senateGauge = "0",
senateGaugeName = "选[v公开课评价量规]..."
};
arrObjLst.Insert(0, objvSenateGaugeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convSenateGauge.id_senateGauge;
objComboBox.DisplayMember = convSenateGauge.senateGaugeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_senateGauge">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeEN GetObjByid_senateGauge(string strid_senateGauge)
{
string strAction = "GetObjByid_senateGauge";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeEN objvSenateGaugeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_senateGauge"] = strid_senateGauge
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSenateGaugeEN = JsonConvert.DeserializeObject<clsvSenateGaugeEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeEN;
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
 /// <param name = "strid_senateGauge">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeEN GetObjByid_senateGauge_WA_Cache(string strid_senateGauge)
{
string strAction = "GetObjByid_senateGauge_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeEN objvSenateGaugeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_senateGauge"] = strid_senateGauge
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSenateGaugeEN = JsonConvert.DeserializeObject<clsvSenateGaugeEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeEN;
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
public static clsvSenateGaugeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeEN objvSenateGaugeEN = null;
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
objvSenateGaugeEN = JsonConvert.DeserializeObject<clsvSenateGaugeEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeEN;
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
 /// <param name = "strid_senateGauge">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeEN GetObjByid_senateGauge_Cache(string strid_senateGauge)
{
if (string.IsNullOrEmpty(strid_senateGauge) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeEN._CurrTabName_S);
List<clsvSenateGaugeEN> arrvSenateGaugeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeEN> arrvSenateGaugeObjLst_Sel =
from objvSenateGaugeEN in arrvSenateGaugeObjLst_Cache
where objvSenateGaugeEN.id_senateGauge == strid_senateGauge
select objvSenateGaugeEN;
if (arrvSenateGaugeObjLst_Sel.Count() == 0)
{
   clsvSenateGaugeEN obj = clsvSenateGaugeWApi.GetObjByid_senateGauge(strid_senateGauge);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvSenateGaugeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_senateGauge">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeNameByid_senateGauge_Cache(string strid_senateGauge)
{
if (string.IsNullOrEmpty(strid_senateGauge) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeEN._CurrTabName_S);
List<clsvSenateGaugeEN> arrvSenateGaugeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeEN> arrvSenateGaugeObjLst_Sel1 =
from objvSenateGaugeEN in arrvSenateGaugeObjLst_Cache
where objvSenateGaugeEN.id_senateGauge == strid_senateGauge
select objvSenateGaugeEN;
List <clsvSenateGaugeEN> arrvSenateGaugeObjLst_Sel = new List<clsvSenateGaugeEN>();
foreach (clsvSenateGaugeEN obj in arrvSenateGaugeObjLst_Sel1)
{
arrvSenateGaugeObjLst_Sel.Add(obj);
}
if (arrvSenateGaugeObjLst_Sel.Count > 0)
{
return arrvSenateGaugeObjLst_Sel[0].senateGaugeName;
}
string strErrMsgForGetObjById = string.Format("在vSenateGauge对象缓存列表中,找不到记录[id_senateGauge = {0}](函数:{1})", strid_senateGauge, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvSenateGaugeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_senateGauge">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_senateGauge_Cache(string strid_senateGauge)
{
if (string.IsNullOrEmpty(strid_senateGauge) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeEN._CurrTabName_S);
List<clsvSenateGaugeEN> arrvSenateGaugeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeEN> arrvSenateGaugeObjLst_Sel1 =
from objvSenateGaugeEN in arrvSenateGaugeObjLst_Cache
where objvSenateGaugeEN.id_senateGauge == strid_senateGauge
select objvSenateGaugeEN;
List <clsvSenateGaugeEN> arrvSenateGaugeObjLst_Sel = new List<clsvSenateGaugeEN>();
foreach (clsvSenateGaugeEN obj in arrvSenateGaugeObjLst_Sel1)
{
arrvSenateGaugeObjLst_Sel.Add(obj);
}
if (arrvSenateGaugeObjLst_Sel.Count > 0)
{
return arrvSenateGaugeObjLst_Sel[0].senateGaugeName;
}
string strErrMsgForGetObjById = string.Format("在vSenateGauge对象缓存列表中,找不到记录的相关名称[id_senateGauge = {0}](函数:{1})", strid_senateGauge, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvSenateGaugeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeEN> GetObjLst(string strWhereCond)
{
 List<clsvSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSenateGaugeEN> GetObjLstById_senateGaugeLst(List<string> arrId_senateGauge)
{
 List<clsvSenateGaugeEN> arrObjLst = null; 
string strAction = "GetObjLstById_senateGaugeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_senateGauge);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_senateGauge">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvSenateGaugeEN> GetObjLstById_senateGaugeLst_Cache(List<string> arrId_senateGauge)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeEN._CurrTabName_S);
List<clsvSenateGaugeEN> arrvSenateGaugeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeEN> arrvSenateGaugeObjLst_Sel =
from objvSenateGaugeEN in arrvSenateGaugeObjLst_Cache
where arrId_senateGauge.Contains(objvSenateGaugeEN.id_senateGauge)
select objvSenateGaugeEN;
return arrvSenateGaugeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeEN> GetObjLstById_senateGaugeLst_WA_Cache(List<string> arrId_senateGauge)
{
 List<clsvSenateGaugeEN> arrObjLst = null; 
string strAction = "GetObjLstById_senateGaugeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_senateGauge);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSenateGaugeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSenateGaugeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSenateGaugeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSenateGaugeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_senateGauge)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_senateGauge"] = strid_senateGauge
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
 /// <param name = "objvSenateGaugeENS">源对象</param>
 /// <param name = "objvSenateGaugeENT">目标对象</param>
 public static void CopyTo(clsvSenateGaugeEN objvSenateGaugeENS, clsvSenateGaugeEN objvSenateGaugeENT)
{
try
{
objvSenateGaugeENT.id_senateGauge = objvSenateGaugeENS.id_senateGauge; //评价量规流水号
objvSenateGaugeENT.senateGaugeID = objvSenateGaugeENS.senateGaugeID; //评价量规ID
objvSenateGaugeENT.senateGaugeName = objvSenateGaugeENS.senateGaugeName; //评价量规名称
objvSenateGaugeENT.senateGaugeScore = objvSenateGaugeENS.senateGaugeScore; //评价量规分值
objvSenateGaugeENT.senateGaugeMemo = objvSenateGaugeENS.senateGaugeMemo; //评价量规指标与说明
objvSenateGaugeENT.SenateGaugeWeight = objvSenateGaugeENS.SenateGaugeWeight; //评价量规权重
objvSenateGaugeENT.id_PubClassCaseSenateGaugeVersion = objvSenateGaugeENS.id_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
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
public static DataTable ToDataTable(List<clsvSenateGaugeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSenateGaugeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSenateGaugeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSenateGaugeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSenateGaugeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSenateGaugeEN.AttributeName)
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
if (clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionWApi没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeWApi没有刷新缓存机制(clsSenateGaugeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_senateGauge");
//if (arrvSenateGaugeObjLst_Cache == null)
//{
//arrvSenateGaugeObjLst_Cache = await clsvSenateGaugeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvSenateGaugeEN._CurrTabName_S);
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
public static List<clsvSenateGaugeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvSenateGaugeEN._CurrTabName_S);
List<clsvSenateGaugeEN> arrvSenateGaugeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSenateGaugeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSenateGaugeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSenateGauge.id_senateGauge, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGauge.senateGaugeID, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGauge.senateGaugeName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGauge.senateGaugeScore, Type.GetType("System.Single"));
objDT.Columns.Add(convSenateGauge.senateGaugeMemo, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGauge.SenateGaugeWeight, Type.GetType("System.Single"));
objDT.Columns.Add(convSenateGauge.id_PubClassCaseSenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGauge.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGauge.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGauge.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convSenateGauge.senateGaugeVersionMemo, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGauge.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convSenateGauge.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGauge.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGauge.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGauge.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGauge.senateGaugeNameWithOrder, Type.GetType("System.String"));
foreach (clsvSenateGaugeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSenateGauge.id_senateGauge] = objInFor[convSenateGauge.id_senateGauge];
objDR[convSenateGauge.senateGaugeID] = objInFor[convSenateGauge.senateGaugeID];
objDR[convSenateGauge.senateGaugeName] = objInFor[convSenateGauge.senateGaugeName];
objDR[convSenateGauge.senateGaugeScore] = objInFor[convSenateGauge.senateGaugeScore];
objDR[convSenateGauge.senateGaugeMemo] = objInFor[convSenateGauge.senateGaugeMemo];
objDR[convSenateGauge.SenateGaugeWeight] = objInFor[convSenateGauge.SenateGaugeWeight];
objDR[convSenateGauge.id_PubClassCaseSenateGaugeVersion] = objInFor[convSenateGauge.id_PubClassCaseSenateGaugeVersion];
objDR[convSenateGauge.senateGaugeVersionID] = objInFor[convSenateGauge.senateGaugeVersionID];
objDR[convSenateGauge.senateGaugeVersionName] = objInFor[convSenateGauge.senateGaugeVersionName];
objDR[convSenateGauge.senateGaugeVersionTtlScore] = objInFor[convSenateGauge.senateGaugeVersionTtlScore];
objDR[convSenateGauge.senateGaugeVersionMemo] = objInFor[convSenateGauge.senateGaugeVersionMemo];
objDR[convSenateGauge.IsUse] = objInFor[convSenateGauge.IsUse];
objDR[convSenateGauge.OrderNum] = objInFor[convSenateGauge.OrderNum];
objDR[convSenateGauge.UpdDate] = objInFor[convSenateGauge.UpdDate];
objDR[convSenateGauge.UpdUserId] = objInFor[convSenateGauge.UpdUserId];
objDR[convSenateGauge.VersionNo] = objInFor[convSenateGauge.VersionNo];
objDR[convSenateGauge.senateGaugeNameWithOrder] = objInFor[convSenateGauge.senateGaugeNameWithOrder];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}