﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncInOutRelaWApi
 表名:FuncInOutRela(00050407)
 * 版本:2024.09.08.1(服务器:WIN-SRV103-116)
 日期:2024/09/08 10:34:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
 框架-层名:WA_访问层(CS)(WA_Access,0045)
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
using AGC.Entity;

namespace AGC4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsFuncInOutRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetmId(this clsFuncInOutRelaEN objFuncInOutRelaEN, long lngmId, string strComparisonOp="")
	{
objFuncInOutRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.mId) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.mId, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.mId] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTabId">功能表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetFuncTabId(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strFuncTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTabId, 8, conFuncInOutRela.FuncTabId);
clsCheckSql.CheckFieldForeignKey(strFuncTabId, 8, conFuncInOutRela.FuncTabId);
objFuncInOutRelaEN.FuncTabId = strFuncTabId; //功能表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.FuncTabId) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.FuncTabId, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.FuncTabId] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strInFldIds">输入字段Ids</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetInFldIds(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strInFldIds, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInFldIds, 1000, conFuncInOutRela.InFldIds);
objFuncInOutRelaEN.InFldIds = strInFldIds; //输入字段Ids
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.InFldIds) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.InFldIds, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.InFldIds] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strInFldNames">输入字段名s</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetInFldNames(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strInFldNames, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInFldNames, 1000, conFuncInOutRela.InFldNames);
objFuncInOutRelaEN.InFldNames = strInFldNames; //输入字段名s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.InFldNames) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.InFldNames, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.InFldNames] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutFldIds">输出字段Ids</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetOutFldIds(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strOutFldIds, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutFldIds, 1000, conFuncInOutRela.OutFldIds);
objFuncInOutRelaEN.OutFldIds = strOutFldIds; //输出字段Ids
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.OutFldIds) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.OutFldIds, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.OutFldIds] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutFldNames">输出字段名s</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetOutFldNames(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strOutFldNames, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutFldNames, 1000, conFuncInOutRela.OutFldNames);
objFuncInOutRelaEN.OutFldNames = strOutFldNames; //输出字段名s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.OutFldNames) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.OutFldNames, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.OutFldNames] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strGcFuncName">GC函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetGcFuncName(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strGcFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGcFuncName, 50, conFuncInOutRela.GcFuncName);
objFuncInOutRelaEN.GcFuncName = strGcFuncName; //GC函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.GcFuncName) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.GcFuncName, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.GcFuncName] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetUpdDate(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFuncInOutRela.UpdDate);
objFuncInOutRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.UpdDate) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.UpdDate, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.UpdDate] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetUpdUser(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFuncInOutRela.UpdUser);
objFuncInOutRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.UpdUser) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.UpdUser, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.UpdUser] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncInOutRelaEN SetMemo(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFuncInOutRela.Memo);
objFuncInOutRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(conFuncInOutRela.Memo) == false)
{
objFuncInOutRelaEN.dicFldComparisonOp.Add(conFuncInOutRela.Memo, strComparisonOp);
}
else
{
objFuncInOutRelaEN.dicFldComparisonOp[conFuncInOutRela.Memo] = strComparisonOp;
}
}
return objFuncInOutRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFuncInOutRelaEN objFuncInOutRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.mId) == true)
{
string strComparisonOpmId = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFuncInOutRela.mId, objFuncInOutRelaCond.mId, strComparisonOpmId);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.FuncTabId) == true)
{
string strComparisonOpFuncTabId = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.FuncTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.FuncTabId, objFuncInOutRelaCond.FuncTabId, strComparisonOpFuncTabId);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.InFldIds) == true)
{
string strComparisonOpInFldIds = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.InFldIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.InFldIds, objFuncInOutRelaCond.InFldIds, strComparisonOpInFldIds);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.InFldNames) == true)
{
string strComparisonOpInFldNames = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.InFldNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.InFldNames, objFuncInOutRelaCond.InFldNames, strComparisonOpInFldNames);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.OutFldIds) == true)
{
string strComparisonOpOutFldIds = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.OutFldIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.OutFldIds, objFuncInOutRelaCond.OutFldIds, strComparisonOpOutFldIds);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.OutFldNames) == true)
{
string strComparisonOpOutFldNames = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.OutFldNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.OutFldNames, objFuncInOutRelaCond.OutFldNames, strComparisonOpOutFldNames);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.GcFuncName) == true)
{
string strComparisonOpGcFuncName = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.GcFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.GcFuncName, objFuncInOutRelaCond.GcFuncName, strComparisonOpGcFuncName);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.UpdDate, objFuncInOutRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.UpdUser, objFuncInOutRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objFuncInOutRelaCond.IsUpdated(conFuncInOutRela.Memo) == true)
{
string strComparisonOpMemo = objFuncInOutRelaCond.dicFldComparisonOp[conFuncInOutRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncInOutRela.Memo, objFuncInOutRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 if (objFuncInOutRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFuncInOutRelaEN.sfUpdFldSetStr = objFuncInOutRelaEN.getsfUpdFldSetStr();
clsFuncInOutRelaWApi.CheckPropertyNew(objFuncInOutRelaEN); 
bool bolResult = clsFuncInOutRelaWApi.UpdateRecord(objFuncInOutRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--FuncInOutRela(函数输入输出关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncTabId_GCFuncName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFuncInOutRelaEN objFuncInOutRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFuncInOutRelaEN == null) return "";
if (objFuncInOutRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncTabId = '{0}'", objFuncInOutRelaEN.FuncTabId);
 sbCondition.AppendFormat(" and GcFuncName = '{0}'", objFuncInOutRelaEN.GcFuncName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFuncInOutRelaEN.mId);
 sbCondition.AppendFormat(" and FuncTabId = '{0}'", objFuncInOutRelaEN.FuncTabId);
 sbCondition.AppendFormat(" and GcFuncName = '{0}'", objFuncInOutRelaEN.GcFuncName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFuncInOutRelaEN objFuncInOutRelaEN)
{
try
{
clsFuncInOutRelaWApi.CheckPropertyNew(objFuncInOutRelaEN); 
bool bolResult = clsFuncInOutRelaWApi.AddNewRecord(objFuncInOutRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objFuncInOutRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncInOutRelaEN objFuncInOutRelaEN, string strWhereCond)
{
try
{
clsFuncInOutRelaWApi.CheckPropertyNew(objFuncInOutRelaEN); 
bool bolResult = clsFuncInOutRelaWApi.UpdateWithCondition(objFuncInOutRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 函数输入输出关系(FuncInOutRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFuncInOutRelaWApi
{
private static readonly string mstrApiControllerName = "FuncInOutRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsFuncInOutRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
if (!Object.Equals(null, objFuncInOutRelaEN.FuncTabId) && GetStrLen(objFuncInOutRelaEN.FuncTabId) > 8)
{
 throw new Exception("字段[功能表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFuncInOutRelaEN.InFldIds) && GetStrLen(objFuncInOutRelaEN.InFldIds) > 1000)
{
 throw new Exception("字段[输入字段Ids]的长度不能超过1000!");
}
if (!Object.Equals(null, objFuncInOutRelaEN.InFldNames) && GetStrLen(objFuncInOutRelaEN.InFldNames) > 1000)
{
 throw new Exception("字段[输入字段名s]的长度不能超过1000!");
}
if (!Object.Equals(null, objFuncInOutRelaEN.OutFldIds) && GetStrLen(objFuncInOutRelaEN.OutFldIds) > 1000)
{
 throw new Exception("字段[输出字段Ids]的长度不能超过1000!");
}
if (!Object.Equals(null, objFuncInOutRelaEN.OutFldNames) && GetStrLen(objFuncInOutRelaEN.OutFldNames) > 1000)
{
 throw new Exception("字段[输出字段名s]的长度不能超过1000!");
}
if (!Object.Equals(null, objFuncInOutRelaEN.GcFuncName) && GetStrLen(objFuncInOutRelaEN.GcFuncName) > 50)
{
 throw new Exception("字段[GC函数名]的长度不能超过50!");
}
if (!Object.Equals(null, objFuncInOutRelaEN.UpdDate) && GetStrLen(objFuncInOutRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFuncInOutRelaEN.UpdUser) && GetStrLen(objFuncInOutRelaEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFuncInOutRelaEN.Memo) && GetStrLen(objFuncInOutRelaEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFuncInOutRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncInOutRelaEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsFuncInOutRelaEN objFuncInOutRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objFuncInOutRelaEN = JsonConvert.DeserializeObject<clsFuncInOutRelaEN>(strJson);
return objFuncInOutRelaEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static clsFuncInOutRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFuncInOutRelaEN objFuncInOutRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objFuncInOutRelaEN = JsonConvert.DeserializeObject<clsFuncInOutRelaEN>(strJson);
return objFuncInOutRelaEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncInOutRelaEN> GetObjLst(string strWhereCond)
{
 List<clsFuncInOutRelaEN> arrObjLst; 
string strAction = "GetObjLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncInOutRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncInOutRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsFuncInOutRelaEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncInOutRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncInOutRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFuncInOutRelaEN> arrObjLst; 
string strAction = "GetTopObjLst";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncInOutRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static List<clsFuncInOutRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFuncInOutRelaEN> arrObjLst; 
string strAction = "GetObjLstByRange";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncInOutRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static List<clsFuncInOutRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFuncInOutRelaEN> arrObjLst; 
string strAction = "GetObjLstByPager";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncInOutRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsFuncInOutRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFuncInOutRelaEN> arrObjLst; 
string strAction = "GetObjLstByPagerCache";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncInOutRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsFuncInOutRelaEN objFuncInOutRelaEN = clsFuncInOutRelaWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static int DelFuncInOutRelas(List<string> arrmId)
{
string strAction = "DelFuncInOutRelas";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static int DelFuncInOutRelasByCond(string strWhereCond)
{
string strAction = "DelFuncInOutRelasByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static bool AddNewRecord(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncInOutRelaEN>(objFuncInOutRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// <param name = "objFuncInOutRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncInOutRelaEN>(objFuncInOutRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static bool UpdateRecord(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
if (string.IsNullOrEmpty(objFuncInOutRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncInOutRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncInOutRelaEN>(objFuncInOutRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// <param name = "objFuncInOutRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFuncInOutRelaEN objFuncInOutRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFuncInOutRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncInOutRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncInOutRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncInOutRelaEN>(objFuncInOutRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn0["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// <param name = "objFuncInOutRelaENS">源对象</param>
 /// <param name = "objFuncInOutRelaENT">目标对象</param>
 public static void CopyTo(clsFuncInOutRelaEN objFuncInOutRelaENS, clsFuncInOutRelaEN objFuncInOutRelaENT)
{
try
{
objFuncInOutRelaENT.mId = objFuncInOutRelaENS.mId; //mId
objFuncInOutRelaENT.FuncTabId = objFuncInOutRelaENS.FuncTabId; //功能表Id
objFuncInOutRelaENT.InFldIds = objFuncInOutRelaENS.InFldIds; //输入字段Ids
objFuncInOutRelaENT.InFldNames = objFuncInOutRelaENS.InFldNames; //输入字段名s
objFuncInOutRelaENT.OutFldIds = objFuncInOutRelaENS.OutFldIds; //输出字段Ids
objFuncInOutRelaENT.OutFldNames = objFuncInOutRelaENS.OutFldNames; //输出字段名s
objFuncInOutRelaENT.GcFuncName = objFuncInOutRelaENS.GcFuncName; //GC函数名
objFuncInOutRelaENT.UpdDate = objFuncInOutRelaENS.UpdDate; //修改日期
objFuncInOutRelaENT.UpdUser = objFuncInOutRelaENS.UpdUser; //修改者
objFuncInOutRelaENT.Memo = objFuncInOutRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFuncInOutRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFuncInOutRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFuncInOutRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFuncInOutRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFuncInOutRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFuncInOutRelaEN.AttributeName)
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
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsFuncInOutRelaEN._CurrTabName);
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
if (clsFuncInOutRelaWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFuncInOutRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFuncInOutRelaWApi.objCommFun4WApi.ReFreshCache();
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFuncInOutRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFuncInOutRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conFuncInOutRela.FuncTabId, Type.GetType("System.String"));
objDT.Columns.Add(conFuncInOutRela.InFldIds, Type.GetType("System.String"));
objDT.Columns.Add(conFuncInOutRela.InFldNames, Type.GetType("System.String"));
objDT.Columns.Add(conFuncInOutRela.OutFldIds, Type.GetType("System.String"));
objDT.Columns.Add(conFuncInOutRela.OutFldNames, Type.GetType("System.String"));
objDT.Columns.Add(conFuncInOutRela.GcFuncName, Type.GetType("System.String"));
objDT.Columns.Add(conFuncInOutRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFuncInOutRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFuncInOutRela.Memo, Type.GetType("System.String"));
foreach (clsFuncInOutRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFuncInOutRela.mId] = objInFor[conFuncInOutRela.mId];
objDR[conFuncInOutRela.FuncTabId] = objInFor[conFuncInOutRela.FuncTabId];
objDR[conFuncInOutRela.InFldIds] = objInFor[conFuncInOutRela.InFldIds];
objDR[conFuncInOutRela.InFldNames] = objInFor[conFuncInOutRela.InFldNames];
objDR[conFuncInOutRela.OutFldIds] = objInFor[conFuncInOutRela.OutFldIds];
objDR[conFuncInOutRela.OutFldNames] = objInFor[conFuncInOutRela.OutFldNames];
objDR[conFuncInOutRela.GcFuncName] = objInFor[conFuncInOutRela.GcFuncName];
objDR[conFuncInOutRela.UpdDate] = objInFor[conFuncInOutRela.UpdDate];
objDR[conFuncInOutRela.UpdUser] = objInFor[conFuncInOutRela.UpdUser];
objDR[conFuncInOutRela.Memo] = objInFor[conFuncInOutRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 函数输入输出关系(FuncInOutRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FuncInOutRela : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
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
clsFuncInOutRelaWApi.ReFreshThisCache();
}
}

}