
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeWApi
 表名:SenateGauge(01120529)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:10
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
public static class clsSenateGaugeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeEN Setid_senateGauge(this clsSenateGaugeEN objSenateGaugeEN, string strid_senateGauge, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_senateGauge, 4, conSenateGauge.id_senateGauge);
clsCheckSql.CheckFieldForeignKey(strid_senateGauge, 4, conSenateGauge.id_senateGauge);
objSenateGaugeEN.id_senateGauge = strid_senateGauge; //评价量规流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.id_senateGauge) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.id_senateGauge, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.id_senateGauge] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeEN SetsenateGaugeID(this clsSenateGaugeEN objSenateGaugeEN, string strsenateGaugeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeID, conSenateGauge.senateGaugeID);
clsCheckSql.CheckFieldLen(strsenateGaugeID, 4, conSenateGauge.senateGaugeID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeID, 4, conSenateGauge.senateGaugeID);
objSenateGaugeEN.senateGaugeID = strsenateGaugeID; //评价量规ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.senateGaugeID) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.senateGaugeID, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.senateGaugeID] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeEN SetsenateGaugeName(this clsSenateGaugeEN objSenateGaugeEN, string strsenateGaugeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeName, conSenateGauge.senateGaugeName);
clsCheckSql.CheckFieldLen(strsenateGaugeName, 200, conSenateGauge.senateGaugeName);
objSenateGaugeEN.senateGaugeName = strsenateGaugeName; //评价量规名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.senateGaugeName) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.senateGaugeName, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.senateGaugeName] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeEN SetsenateGaugeScore(this clsSenateGaugeEN objSenateGaugeEN, float fltsenateGaugeScore, string strComparisonOp="")
	{
objSenateGaugeEN.senateGaugeScore = fltsenateGaugeScore; //评价量规分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.senateGaugeScore) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.senateGaugeScore, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.senateGaugeScore] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeEN SetSenateGaugeWeight(this clsSenateGaugeEN objSenateGaugeEN, float fltSenateGaugeWeight, string strComparisonOp="")
	{
objSenateGaugeEN.SenateGaugeWeight = fltSenateGaugeWeight; //评价量规权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.SenateGaugeWeight) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.SenateGaugeWeight, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.SenateGaugeWeight] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeEN SetsenateGaugeMemo(this clsSenateGaugeEN objSenateGaugeEN, string strsenateGaugeMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeMemo, 1000, conSenateGauge.senateGaugeMemo);
objSenateGaugeEN.senateGaugeMemo = strsenateGaugeMemo; //评价量规指标与说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.senateGaugeMemo) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.senateGaugeMemo, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.senateGaugeMemo] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeEN Setid_PubClassCaseSenateGaugeVersion(this clsSenateGaugeEN objSenateGaugeEN, string strid_PubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCaseSenateGaugeVersion, conSenateGauge.id_PubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_PubClassCaseSenateGaugeVersion, 4, conSenateGauge.id_PubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCaseSenateGaugeVersion, 4, conSenateGauge.id_PubClassCaseSenateGaugeVersion);
objSenateGaugeEN.id_PubClassCaseSenateGaugeVersion = strid_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.id_PubClassCaseSenateGaugeVersion) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.id_PubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.id_PubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeEN SetOrderNum(this clsSenateGaugeEN objSenateGaugeEN, int intOrderNum, string strComparisonOp="")
	{
objSenateGaugeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.OrderNum) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.OrderNum, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.OrderNum] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeEN SetUpdDate(this clsSenateGaugeEN objSenateGaugeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSenateGauge.UpdDate);
objSenateGaugeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.UpdDate) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.UpdDate, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.UpdDate] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeEN SetUpdUserId(this clsSenateGaugeEN objSenateGaugeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSenateGauge.UpdUserId);
objSenateGaugeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeEN.dicFldComparisonOp.ContainsKey(conSenateGauge.UpdUserId) == false)
{
objSenateGaugeEN.dicFldComparisonOp.Add(conSenateGauge.UpdUserId, strComparisonOp);
}
else
{
objSenateGaugeEN.dicFldComparisonOp[conSenateGauge.UpdUserId] = strComparisonOp;
}
}
return objSenateGaugeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSenateGaugeEN objSenateGauge_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSenateGauge_Cond.IsUpdated(conSenateGauge.id_senateGauge) == true)
{
string strComparisonOp_id_senateGauge = objSenateGauge_Cond.dicFldComparisonOp[conSenateGauge.id_senateGauge];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.id_senateGauge, objSenateGauge_Cond.id_senateGauge, strComparisonOp_id_senateGauge);
}
if (objSenateGauge_Cond.IsUpdated(conSenateGauge.senateGaugeID) == true)
{
string strComparisonOp_senateGaugeID = objSenateGauge_Cond.dicFldComparisonOp[conSenateGauge.senateGaugeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.senateGaugeID, objSenateGauge_Cond.senateGaugeID, strComparisonOp_senateGaugeID);
}
if (objSenateGauge_Cond.IsUpdated(conSenateGauge.senateGaugeName) == true)
{
string strComparisonOp_senateGaugeName = objSenateGauge_Cond.dicFldComparisonOp[conSenateGauge.senateGaugeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.senateGaugeName, objSenateGauge_Cond.senateGaugeName, strComparisonOp_senateGaugeName);
}
if (objSenateGauge_Cond.IsUpdated(conSenateGauge.senateGaugeScore) == true)
{
string strComparisonOp_senateGaugeScore = objSenateGauge_Cond.dicFldComparisonOp[conSenateGauge.senateGaugeScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGauge.senateGaugeScore, objSenateGauge_Cond.senateGaugeScore, strComparisonOp_senateGaugeScore);
}
if (objSenateGauge_Cond.IsUpdated(conSenateGauge.SenateGaugeWeight) == true)
{
string strComparisonOp_SenateGaugeWeight = objSenateGauge_Cond.dicFldComparisonOp[conSenateGauge.SenateGaugeWeight];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGauge.SenateGaugeWeight, objSenateGauge_Cond.SenateGaugeWeight, strComparisonOp_SenateGaugeWeight);
}
if (objSenateGauge_Cond.IsUpdated(conSenateGauge.senateGaugeMemo) == true)
{
string strComparisonOp_senateGaugeMemo = objSenateGauge_Cond.dicFldComparisonOp[conSenateGauge.senateGaugeMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.senateGaugeMemo, objSenateGauge_Cond.senateGaugeMemo, strComparisonOp_senateGaugeMemo);
}
if (objSenateGauge_Cond.IsUpdated(conSenateGauge.id_PubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOp_id_PubClassCaseSenateGaugeVersion = objSenateGauge_Cond.dicFldComparisonOp[conSenateGauge.id_PubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.id_PubClassCaseSenateGaugeVersion, objSenateGauge_Cond.id_PubClassCaseSenateGaugeVersion, strComparisonOp_id_PubClassCaseSenateGaugeVersion);
}
if (objSenateGauge_Cond.IsUpdated(conSenateGauge.OrderNum) == true)
{
string strComparisonOp_OrderNum = objSenateGauge_Cond.dicFldComparisonOp[conSenateGauge.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGauge.OrderNum, objSenateGauge_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objSenateGauge_Cond.IsUpdated(conSenateGauge.UpdDate) == true)
{
string strComparisonOp_UpdDate = objSenateGauge_Cond.dicFldComparisonOp[conSenateGauge.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.UpdDate, objSenateGauge_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objSenateGauge_Cond.IsUpdated(conSenateGauge.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objSenateGauge_Cond.dicFldComparisonOp[conSenateGauge.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGauge.UpdUserId, objSenateGauge_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeEN objSenateGaugeEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeEN.id_senateGauge) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSenateGaugeEN.sf_UpdFldSetStr = objSenateGaugeEN.getsf_UpdFldSetStr();
clsSenateGaugeWApi.CheckPropertyNew(objSenateGaugeEN); 
bool bolResult = clsSenateGaugeWApi.UpdateRecord(objSenateGaugeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSenateGaugeEN objSenateGaugeEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeEN.id_senateGauge) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeWApi.IsExist(objSenateGaugeEN.id_senateGauge) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeEN.id_senateGauge, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsSenateGaugeWApi.CheckPropertyNew(objSenateGaugeEN); 
bool bolResult = clsSenateGaugeWApi.AddNewRecord(objSenateGaugeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSenateGaugeEN objSenateGaugeEN)
{
try
{
clsSenateGaugeWApi.CheckPropertyNew(objSenateGaugeEN); 
string strid_senateGauge = clsSenateGaugeWApi.AddNewRecordWithMaxId(objSenateGaugeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeWApi.ReFreshCache();
return strid_senateGauge;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objSenateGaugeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeEN objSenateGaugeEN, string strWhereCond)
{
try
{
clsSenateGaugeWApi.CheckPropertyNew(objSenateGaugeEN); 
bool bolResult = clsSenateGaugeWApi.UpdateWithCondition(objSenateGaugeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeWApi.ReFreshCache();
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
 /// 评价量规(SenateGauge)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSenateGaugeWApi
{
private static readonly string mstrApiControllerName = "SenateGaugeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsSenateGaugeWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[评价量规]...","0");
List<clsSenateGaugeEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", conSenateGauge.id_senateGauge); 
List<clsSenateGaugeEN> arrObjLst = clsSenateGaugeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN()
{
id_senateGauge = "0",
senateGaugeName = "选[评价量规]..."
};
arrObjLst.Insert(0, objSenateGaugeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSenateGauge.id_senateGauge;
objComboBox.DisplayMember = conSenateGauge.senateGaugeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSenateGaugeEN objSenateGaugeEN)
{
if (!Object.Equals(null, objSenateGaugeEN.id_senateGauge) && GetStrLen(objSenateGaugeEN.id_senateGauge) > 4)
{
 throw new Exception("字段[评价量规流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeEN.senateGaugeID) && GetStrLen(objSenateGaugeEN.senateGaugeID) > 4)
{
 throw new Exception("字段[评价量规ID]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeEN.senateGaugeName) && GetStrLen(objSenateGaugeEN.senateGaugeName) > 200)
{
 throw new Exception("字段[评价量规名称]的长度不能超过200!");
}
if (!Object.Equals(null, objSenateGaugeEN.senateGaugeMemo) && GetStrLen(objSenateGaugeEN.senateGaugeMemo) > 1000)
{
 throw new Exception("字段[评价量规指标与说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objSenateGaugeEN.id_PubClassCaseSenateGaugeVersion) && GetStrLen(objSenateGaugeEN.id_PubClassCaseSenateGaugeVersion) > 4)
{
 throw new Exception("字段[公开课量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeEN.UpdDate) && GetStrLen(objSenateGaugeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSenateGaugeEN.UpdUserId) && GetStrLen(objSenateGaugeEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
 objSenateGaugeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_senateGauge">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeEN GetObjByid_senateGauge(string strid_senateGauge)
{
string strAction = "GetObjByid_senateGauge";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeEN objSenateGaugeEN = null;
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
objSenateGaugeEN = JsonConvert.DeserializeObject<clsSenateGaugeEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeEN;
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
public static clsSenateGaugeEN GetObjByid_senateGauge_WA_Cache(string strid_senateGauge)
{
string strAction = "GetObjByid_senateGauge_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeEN objSenateGaugeEN = null;
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
objSenateGaugeEN = JsonConvert.DeserializeObject<clsSenateGaugeEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeEN;
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
public static clsSenateGaugeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeEN objSenateGaugeEN = null;
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
objSenateGaugeEN = JsonConvert.DeserializeObject<clsSenateGaugeEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeEN;
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
public static clsSenateGaugeEN GetObjByid_senateGauge_Cache(string strid_senateGauge)
{
if (string.IsNullOrEmpty(strid_senateGauge) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName_S);
List<clsSenateGaugeEN> arrSenateGaugeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeEN> arrSenateGaugeObjLst_Sel =
from objSenateGaugeEN in arrSenateGaugeObjLst_Cache
where objSenateGaugeEN.id_senateGauge == strid_senateGauge
select objSenateGaugeEN;
if (arrSenateGaugeObjLst_Sel.Count() == 0)
{
   clsSenateGaugeEN obj = clsSenateGaugeWApi.GetObjByid_senateGauge(strid_senateGauge);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrSenateGaugeObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName_S);
List<clsSenateGaugeEN> arrSenateGaugeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeEN> arrSenateGaugeObjLst_Sel1 =
from objSenateGaugeEN in arrSenateGaugeObjLst_Cache
where objSenateGaugeEN.id_senateGauge == strid_senateGauge
select objSenateGaugeEN;
List <clsSenateGaugeEN> arrSenateGaugeObjLst_Sel = new List<clsSenateGaugeEN>();
foreach (clsSenateGaugeEN obj in arrSenateGaugeObjLst_Sel1)
{
arrSenateGaugeObjLst_Sel.Add(obj);
}
if (arrSenateGaugeObjLst_Sel.Count > 0)
{
return arrSenateGaugeObjLst_Sel[0].senateGaugeName;
}
string strErrMsgForGetObjById = string.Format("在SenateGauge对象缓存列表中,找不到记录[id_senateGauge = {0}](函数:{1})", strid_senateGauge, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSenateGaugeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName_S);
List<clsSenateGaugeEN> arrSenateGaugeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeEN> arrSenateGaugeObjLst_Sel1 =
from objSenateGaugeEN in arrSenateGaugeObjLst_Cache
where objSenateGaugeEN.id_senateGauge == strid_senateGauge
select objSenateGaugeEN;
List <clsSenateGaugeEN> arrSenateGaugeObjLst_Sel = new List<clsSenateGaugeEN>();
foreach (clsSenateGaugeEN obj in arrSenateGaugeObjLst_Sel1)
{
arrSenateGaugeObjLst_Sel.Add(obj);
}
if (arrSenateGaugeObjLst_Sel.Count > 0)
{
return arrSenateGaugeObjLst_Sel[0].senateGaugeName;
}
string strErrMsgForGetObjById = string.Format("在SenateGauge对象缓存列表中,找不到记录的相关名称[id_senateGauge = {0}](函数:{1})", strid_senateGauge, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSenateGaugeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeEN> GetObjLst(string strWhereCond)
{
 List<clsSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeEN> GetObjLstById_senateGaugeLst(List<string> arrId_senateGauge)
{
 List<clsSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsSenateGaugeEN> GetObjLstById_senateGaugeLst_Cache(List<string> arrId_senateGauge)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName_S);
List<clsSenateGaugeEN> arrSenateGaugeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeEN> arrSenateGaugeObjLst_Sel =
from objSenateGaugeEN in arrSenateGaugeObjLst_Cache
where arrId_senateGauge.Contains(objSenateGaugeEN.id_senateGauge)
select objSenateGaugeEN;
return arrSenateGaugeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeEN> GetObjLstById_senateGaugeLst_WA_Cache(List<string> arrId_senateGauge)
{
 List<clsSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsSenateGaugeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_senateGauge)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsSenateGaugeEN objSenateGaugeEN = clsSenateGaugeWApi.GetObjByid_senateGauge(strid_senateGauge);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_senateGauge.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsSenateGaugeWApi.ReFreshCache();
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
public static int DelSenateGauges(List<string> arrid_senateGauge)
{
string strAction = "DelSenateGauges";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_senateGauge);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsSenateGaugeWApi.ReFreshCache();
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
public static int DelSenateGaugesByCond(string strWhereCond)
{
string strAction = "DelSenateGaugesByCond";
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
public static bool AddNewRecord(clsSenateGaugeEN objSenateGaugeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeEN>(objSenateGaugeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeWApi.ReFreshCache();
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsSenateGaugeEN objSenateGaugeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeEN>(objSenateGaugeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeWApi.ReFreshCache();
var strid_senateGauge = (string)jobjReturn["ReturnStr"];
return strid_senateGauge;
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
public static bool UpdateRecord(clsSenateGaugeEN objSenateGaugeEN)
{
if (string.IsNullOrEmpty(objSenateGaugeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeEN.id_senateGauge, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeEN>(objSenateGaugeEN);
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
 /// <param name = "objSenateGaugeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSenateGaugeEN objSenateGaugeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSenateGaugeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeEN.id_senateGauge, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeEN.id_senateGauge, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeEN>(objSenateGaugeEN);
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSenateGaugeENS">源对象</param>
 /// <param name = "objSenateGaugeENT">目标对象</param>
 public static void CopyTo(clsSenateGaugeEN objSenateGaugeENS, clsSenateGaugeEN objSenateGaugeENT)
{
try
{
objSenateGaugeENT.id_senateGauge = objSenateGaugeENS.id_senateGauge; //评价量规流水号
objSenateGaugeENT.senateGaugeID = objSenateGaugeENS.senateGaugeID; //评价量规ID
objSenateGaugeENT.senateGaugeName = objSenateGaugeENS.senateGaugeName; //评价量规名称
objSenateGaugeENT.senateGaugeScore = objSenateGaugeENS.senateGaugeScore; //评价量规分值
objSenateGaugeENT.SenateGaugeWeight = objSenateGaugeENS.SenateGaugeWeight; //评价量规权重
objSenateGaugeENT.senateGaugeMemo = objSenateGaugeENS.senateGaugeMemo; //评价量规指标与说明
objSenateGaugeENT.id_PubClassCaseSenateGaugeVersion = objSenateGaugeENS.id_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objSenateGaugeENT.OrderNum = objSenateGaugeENS.OrderNum; //序号
objSenateGaugeENT.UpdDate = objSenateGaugeENS.UpdDate; //修改日期
objSenateGaugeENT.UpdUserId = objSenateGaugeENS.UpdUserId; //修改用户Id
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
public static DataTable ToDataTable(List<clsSenateGaugeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSenateGaugeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSenateGaugeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSenateGaugeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSenateGaugeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSenateGaugeEN.AttributeName)
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
if (clsSenateGaugeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeWApi没有刷新缓存机制(clsSenateGaugeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_senateGauge");
//if (arrSenateGaugeObjLst_Cache == null)
//{
//arrSenateGaugeObjLst_Cache = await clsSenateGaugeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName_S);
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
if (clsSenateGaugeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsSenateGaugeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsSenateGaugeEN._CurrTabName_S);
List<clsSenateGaugeEN> arrSenateGaugeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSenateGaugeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsSenateGaugeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSenateGauge.id_senateGauge, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGauge.senateGaugeID, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGauge.senateGaugeName, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGauge.senateGaugeScore, Type.GetType("System.Single"));
objDT.Columns.Add(conSenateGauge.SenateGaugeWeight, Type.GetType("System.Single"));
objDT.Columns.Add(conSenateGauge.senateGaugeMemo, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGauge.id_PubClassCaseSenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGauge.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conSenateGauge.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGauge.UpdUserId, Type.GetType("System.String"));
foreach (clsSenateGaugeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSenateGauge.id_senateGauge] = objInFor[conSenateGauge.id_senateGauge];
objDR[conSenateGauge.senateGaugeID] = objInFor[conSenateGauge.senateGaugeID];
objDR[conSenateGauge.senateGaugeName] = objInFor[conSenateGauge.senateGaugeName];
objDR[conSenateGauge.senateGaugeScore] = objInFor[conSenateGauge.senateGaugeScore];
objDR[conSenateGauge.SenateGaugeWeight] = objInFor[conSenateGauge.SenateGaugeWeight];
objDR[conSenateGauge.senateGaugeMemo] = objInFor[conSenateGauge.senateGaugeMemo];
objDR[conSenateGauge.id_PubClassCaseSenateGaugeVersion] = objInFor[conSenateGauge.id_PubClassCaseSenateGaugeVersion];
objDR[conSenateGauge.OrderNum] = objInFor[conSenateGauge.OrderNum];
objDR[conSenateGauge.UpdDate] = objInFor[conSenateGauge.UpdDate];
objDR[conSenateGauge.UpdUserId] = objInFor[conSenateGauge.UpdUserId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 评价量规(SenateGauge)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4SenateGauge : clsCommFun4BL
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
clsSenateGaugeWApi.ReFreshThisCache();
}
}

}