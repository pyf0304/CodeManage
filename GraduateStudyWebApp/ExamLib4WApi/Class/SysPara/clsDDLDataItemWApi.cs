﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDDLDataItemWApi
 表名:DDLDataItem(01120050)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:12
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
public static class clsDDLDataItemWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDDLDataItemEN SetDDLDataItemId(this clsDDLDataItemEN objDDLDataItemEN, long lngDDLDataItemId, string strComparisonOp="")
	{
objDDLDataItemEN.DDLDataItemId = lngDDLDataItemId; //下拉框数据项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.DDLDataItemId) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.DDLDataItemId, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.DDLDataItemId] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDDLDataItemEN SetDDLTabId(this clsDDLDataItemEN objDDLDataItemEN, string strDDLTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDDLTabId, conDDLDataItem.DDLTabId);
clsCheckSql.CheckFieldLen(strDDLTabId, 4, conDDLDataItem.DDLTabId);
clsCheckSql.CheckFieldForeignKey(strDDLTabId, 4, conDDLDataItem.DDLTabId);
objDDLDataItemEN.DDLTabId = strDDLTabId; //下拉框表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.DDLTabId) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.DDLTabId, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.DDLTabId] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDDLDataItemEN SetDataItemNo(this clsDDLDataItemEN objDDLDataItemEN, string strDataItemNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataItemNo, conDDLDataItem.DataItemNo);
clsCheckSql.CheckFieldLen(strDataItemNo, 20, conDDLDataItem.DataItemNo);
objDDLDataItemEN.DataItemNo = strDataItemNo; //数据项编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.DataItemNo) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.DataItemNo, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.DataItemNo] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDDLDataItemEN SetDataItemText(this clsDDLDataItemEN objDDLDataItemEN, string strDataItemText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataItemText, conDDLDataItem.DataItemText);
clsCheckSql.CheckFieldLen(strDataItemText, 30, conDDLDataItem.DataItemText);
objDDLDataItemEN.DataItemText = strDataItemText; //数据项文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.DataItemText) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.DataItemText, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.DataItemText] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDDLDataItemEN SetDataItemMemo(this clsDDLDataItemEN objDDLDataItemEN, string strDataItemMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataItemMemo, 500, conDDLDataItem.DataItemMemo);
objDDLDataItemEN.DataItemMemo = strDataItemMemo; //数据项备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.DataItemMemo) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.DataItemMemo, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.DataItemMemo] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDDLDataItemEN SetUpdDate(this clsDDLDataItemEN objDDLDataItemEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conDDLDataItem.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDDLDataItem.UpdDate);
objDDLDataItemEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.UpdDate) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.UpdDate, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.UpdDate] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDDLDataItemEN SetUpdUser(this clsDDLDataItemEN objDDLDataItemEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDDLDataItem.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDDLDataItem.UpdUser);
objDDLDataItemEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.UpdUser) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.UpdUser, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.UpdUser] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDDLDataItemEN SetOrderNum(this clsDDLDataItemEN objDDLDataItemEN, int intOrderNum, string strComparisonOp="")
	{
objDDLDataItemEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.OrderNum) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.OrderNum, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.OrderNum] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDDLDataItemEN objDDLDataItem_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDDLDataItem_Cond.IsUpdated(conDDLDataItem.DDLDataItemId) == true)
{
string strComparisonOp_DDLDataItemId = objDDLDataItem_Cond.dicFldComparisonOp[conDDLDataItem.DDLDataItemId];
strWhereCond += string.Format(" And {0} {2} {1}", conDDLDataItem.DDLDataItemId, objDDLDataItem_Cond.DDLDataItemId, strComparisonOp_DDLDataItemId);
}
if (objDDLDataItem_Cond.IsUpdated(conDDLDataItem.DDLTabId) == true)
{
string strComparisonOp_DDLTabId = objDDLDataItem_Cond.dicFldComparisonOp[conDDLDataItem.DDLTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.DDLTabId, objDDLDataItem_Cond.DDLTabId, strComparisonOp_DDLTabId);
}
if (objDDLDataItem_Cond.IsUpdated(conDDLDataItem.DataItemNo) == true)
{
string strComparisonOp_DataItemNo = objDDLDataItem_Cond.dicFldComparisonOp[conDDLDataItem.DataItemNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.DataItemNo, objDDLDataItem_Cond.DataItemNo, strComparisonOp_DataItemNo);
}
if (objDDLDataItem_Cond.IsUpdated(conDDLDataItem.DataItemText) == true)
{
string strComparisonOp_DataItemText = objDDLDataItem_Cond.dicFldComparisonOp[conDDLDataItem.DataItemText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.DataItemText, objDDLDataItem_Cond.DataItemText, strComparisonOp_DataItemText);
}
if (objDDLDataItem_Cond.IsUpdated(conDDLDataItem.DataItemMemo) == true)
{
string strComparisonOp_DataItemMemo = objDDLDataItem_Cond.dicFldComparisonOp[conDDLDataItem.DataItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.DataItemMemo, objDDLDataItem_Cond.DataItemMemo, strComparisonOp_DataItemMemo);
}
if (objDDLDataItem_Cond.IsUpdated(conDDLDataItem.UpdDate) == true)
{
string strComparisonOp_UpdDate = objDDLDataItem_Cond.dicFldComparisonOp[conDDLDataItem.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.UpdDate, objDDLDataItem_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objDDLDataItem_Cond.IsUpdated(conDDLDataItem.UpdUser) == true)
{
string strComparisonOp_UpdUser = objDDLDataItem_Cond.dicFldComparisonOp[conDDLDataItem.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.UpdUser, objDDLDataItem_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objDDLDataItem_Cond.IsUpdated(conDDLDataItem.OrderNum) == true)
{
string strComparisonOp_OrderNum = objDDLDataItem_Cond.dicFldComparisonOp[conDDLDataItem.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conDDLDataItem.OrderNum, objDDLDataItem_Cond.OrderNum, strComparisonOp_OrderNum);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDDLDataItemEN objDDLDataItemEN)
{
 if (objDDLDataItemEN.DDLDataItemId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDDLDataItemEN.sf_UpdFldSetStr = objDDLDataItemEN.getsf_UpdFldSetStr();
clsDDLDataItemWApi.CheckPropertyNew(objDDLDataItemEN); 
bool bolResult = clsDDLDataItemWApi.UpdateRecord(objDDLDataItemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--DDLDataItem(下拉框数据项), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDDLDataItemEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_DDLTabId_DataItemText(this clsDDLDataItemEN objDDLDataItemEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDDLDataItemEN == null) return "";
if (objDDLDataItemEN.DDLDataItemId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DDLTabId = '{0}'", objDDLDataItemEN.DDLTabId);
 sbCondition.AppendFormat(" and DataItemText = '{0}'", objDDLDataItemEN.DataItemText);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DDLDataItemId !=  {0}", objDDLDataItemEN.DDLDataItemId);
 sbCondition.AppendFormat(" and DDLTabId = '{0}'", objDDLDataItemEN.DDLTabId);
 sbCondition.AppendFormat(" and DataItemText = '{0}'", objDDLDataItemEN.DataItemText);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDDLDataItemEN objDDLDataItemEN)
{
try
{
clsDDLDataItemWApi.CheckPropertyNew(objDDLDataItemEN); 
bool bolResult = clsDDLDataItemWApi.AddNewRecord(objDDLDataItemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemWApi.ReFreshCache();
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
 /// <param name = "objDDLDataItemEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDDLDataItemEN objDDLDataItemEN, string strWhereCond)
{
try
{
clsDDLDataItemWApi.CheckPropertyNew(objDDLDataItemEN); 
bool bolResult = clsDDLDataItemWApi.UpdateWithCondition(objDDLDataItemEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemWApi.ReFreshCache();
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
 /// 下拉框数据项(DDLDataItem)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDDLDataItemWApi
{
private static readonly string mstrApiControllerName = "DDLDataItemApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsDDLDataItemWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDDLDataItemEN objDDLDataItemEN)
{
if (!Object.Equals(null, objDDLDataItemEN.DDLTabId) && GetStrLen(objDDLDataItemEN.DDLTabId) > 4)
{
 throw new Exception("字段[下拉框表Id]的长度不能超过4!");
}
if (!Object.Equals(null, objDDLDataItemEN.DataItemNo) && GetStrLen(objDDLDataItemEN.DataItemNo) > 20)
{
 throw new Exception("字段[数据项编号]的长度不能超过20!");
}
if (!Object.Equals(null, objDDLDataItemEN.DataItemText) && GetStrLen(objDDLDataItemEN.DataItemText) > 30)
{
 throw new Exception("字段[数据项文本]的长度不能超过30!");
}
if (!Object.Equals(null, objDDLDataItemEN.DataItemMemo) && GetStrLen(objDDLDataItemEN.DataItemMemo) > 500)
{
 throw new Exception("字段[数据项备注]的长度不能超过500!");
}
if (!Object.Equals(null, objDDLDataItemEN.UpdDate) && GetStrLen(objDDLDataItemEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDDLDataItemEN.UpdUser) && GetStrLen(objDDLDataItemEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
 objDDLDataItemEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngDDLDataItemId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDDLDataItemEN GetObjByDDLDataItemId(long lngDDLDataItemId)
{
string strAction = "GetObjByDDLDataItemId";
string strErrMsg = string.Empty;
string strResult = "";
clsDDLDataItemEN objDDLDataItemEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["DDLDataItemId"] = lngDDLDataItemId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objDDLDataItemEN = JsonConvert.DeserializeObject<clsDDLDataItemEN>((string)jobjReturn["ReturnObj"]);
return objDDLDataItemEN;
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
 /// <param name = "lngDDLDataItemId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDDLDataItemEN GetObjByDDLDataItemId_WA_Cache(long lngDDLDataItemId)
{
string strAction = "GetObjByDDLDataItemId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsDDLDataItemEN objDDLDataItemEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["DDLDataItemId"] = lngDDLDataItemId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objDDLDataItemEN = JsonConvert.DeserializeObject<clsDDLDataItemEN>((string)jobjReturn["ReturnObj"]);
return objDDLDataItemEN;
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
public static clsDDLDataItemEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsDDLDataItemEN objDDLDataItemEN = null;
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
objDDLDataItemEN = JsonConvert.DeserializeObject<clsDDLDataItemEN>((string)jobjReturn["ReturnObj"]);
return objDDLDataItemEN;
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
 /// <param name = "lngDDLDataItemId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDDLDataItemEN GetObjByDDLDataItemId_Cache(long lngDDLDataItemId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDDLDataItemEN._CurrTabName_S);
List<clsDDLDataItemEN> arrDDLDataItemObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsDDLDataItemEN> arrDDLDataItemObjLst_Sel =
from objDDLDataItemEN in arrDDLDataItemObjLst_Cache
where objDDLDataItemEN.DDLDataItemId == lngDDLDataItemId
select objDDLDataItemEN;
if (arrDDLDataItemObjLst_Sel.Count() == 0)
{
   clsDDLDataItemEN obj = clsDDLDataItemWApi.GetObjByDDLDataItemId(lngDDLDataItemId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDDLDataItemObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLDataItemEN> GetObjLst(string strWhereCond)
{
 List<clsDDLDataItemEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDDLDataItemEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsDDLDataItemEN> GetObjLstByDDLDataItemIdLst(List<long> arrDDLDataItemId)
{
 List<clsDDLDataItemEN> arrObjLst = null; 
string strAction = "GetObjLstByDDLDataItemIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDDLDataItemId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDDLDataItemEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngDDLDataItemId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsDDLDataItemEN> GetObjLstByDDLDataItemIdLst_Cache(List<long> arrDDLDataItemId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDDLDataItemEN._CurrTabName_S);
List<clsDDLDataItemEN> arrDDLDataItemObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsDDLDataItemEN> arrDDLDataItemObjLst_Sel =
from objDDLDataItemEN in arrDDLDataItemObjLst_Cache
where arrDDLDataItemId.Contains(objDDLDataItemEN.DDLDataItemId)
select objDDLDataItemEN;
return arrDDLDataItemObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLDataItemEN> GetObjLstByDDLDataItemIdLst_WA_Cache(List<long> arrDDLDataItemId)
{
 List<clsDDLDataItemEN> arrObjLst = null; 
string strAction = "GetObjLstByDDLDataItemIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDDLDataItemId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDDLDataItemEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsDDLDataItemEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDDLDataItemEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDDLDataItemEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsDDLDataItemEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDDLDataItemEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDDLDataItemEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsDDLDataItemEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDDLDataItemEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDDLDataItemEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsDDLDataItemEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsDDLDataItemEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDDLDataItemEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngDDLDataItemId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsDDLDataItemEN objDDLDataItemEN = clsDDLDataItemWApi.GetObjByDDLDataItemId(lngDDLDataItemId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngDDLDataItemId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsDDLDataItemWApi.ReFreshCache();
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
public static int DelDDLDataItems(List<string> arrDDLDataItemId)
{
string strAction = "DelDDLDataItems";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDDLDataItemId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsDDLDataItemWApi.ReFreshCache();
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
public static int DelDDLDataItemsByCond(string strWhereCond)
{
string strAction = "DelDDLDataItemsByCond";
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
public static bool AddNewRecord(clsDDLDataItemEN objDDLDataItemEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDDLDataItemEN>(objDDLDataItemEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemWApi.ReFreshCache();
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
 /// <param name = "objDDLDataItemEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsDDLDataItemEN objDDLDataItemEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDDLDataItemEN>(objDDLDataItemEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemWApi.ReFreshCache();
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
public static bool UpdateRecord(clsDDLDataItemEN objDDLDataItemEN)
{
if (string.IsNullOrEmpty(objDDLDataItemEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDDLDataItemEN.DDLDataItemId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDDLDataItemEN>(objDDLDataItemEN);
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
 /// <param name = "objDDLDataItemEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDDLDataItemEN objDDLDataItemEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDDLDataItemEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDDLDataItemEN.DDLDataItemId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDDLDataItemEN.DDLDataItemId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDDLDataItemEN>(objDDLDataItemEN);
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
public static bool IsExist(long lngDDLDataItemId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["DDLDataItemId"] = lngDDLDataItemId.ToString()
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
 /// <param name = "objDDLDataItemENS">源对象</param>
 /// <param name = "objDDLDataItemENT">目标对象</param>
 public static void CopyTo(clsDDLDataItemEN objDDLDataItemENS, clsDDLDataItemEN objDDLDataItemENT)
{
try
{
objDDLDataItemENT.DDLDataItemId = objDDLDataItemENS.DDLDataItemId; //下拉框数据项Id
objDDLDataItemENT.DDLTabId = objDDLDataItemENS.DDLTabId; //下拉框表Id
objDDLDataItemENT.DataItemNo = objDDLDataItemENS.DataItemNo; //数据项编号
objDDLDataItemENT.DataItemText = objDDLDataItemENS.DataItemText; //数据项文本
objDDLDataItemENT.DataItemMemo = objDDLDataItemENS.DataItemMemo; //数据项备注
objDDLDataItemENT.UpdDate = objDDLDataItemENS.UpdDate; //修改日期
objDDLDataItemENT.UpdUser = objDDLDataItemENS.UpdUser; //修改人
objDDLDataItemENT.OrderNum = objDDLDataItemENS.OrderNum; //序号
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
public static DataTable ToDataTable(List<clsDDLDataItemEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDDLDataItemEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDDLDataItemEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDDLDataItemEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDDLDataItemEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDDLDataItemEN.AttributeName)
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
if (clsDDLDataItemWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDDLDataItemWApi没有刷新缓存机制(clsDDLDataItemWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DDLDataItemId");
//if (arrDDLDataItemObjLst_Cache == null)
//{
//arrDDLDataItemObjLst_Cache = await clsDDLDataItemWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsDDLDataItemEN._CurrTabName_S);
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
if (clsDDLDataItemWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDDLDataItemEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsDDLDataItemWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDDLDataItemEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsDDLDataItemEN._CurrTabName_S);
List<clsDDLDataItemEN> arrDDLDataItemObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDDLDataItemObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDDLDataItemEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDDLDataItem.DDLDataItemId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDDLDataItem.DDLTabId, Type.GetType("System.String"));
objDT.Columns.Add(conDDLDataItem.DataItemNo, Type.GetType("System.String"));
objDT.Columns.Add(conDDLDataItem.DataItemText, Type.GetType("System.String"));
objDT.Columns.Add(conDDLDataItem.DataItemMemo, Type.GetType("System.String"));
objDT.Columns.Add(conDDLDataItem.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDDLDataItem.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDDLDataItem.OrderNum, Type.GetType("System.Int32"));
foreach (clsDDLDataItemEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDDLDataItem.DDLDataItemId] = objInFor[conDDLDataItem.DDLDataItemId];
objDR[conDDLDataItem.DDLTabId] = objInFor[conDDLDataItem.DDLTabId];
objDR[conDDLDataItem.DataItemNo] = objInFor[conDDLDataItem.DataItemNo];
objDR[conDDLDataItem.DataItemText] = objInFor[conDDLDataItem.DataItemText];
objDR[conDDLDataItem.DataItemMemo] = objInFor[conDDLDataItem.DataItemMemo];
objDR[conDDLDataItem.UpdDate] = objInFor[conDDLDataItem.UpdDate];
objDR[conDDLDataItem.UpdUser] = objInFor[conDDLDataItem.UpdUser];
objDR[conDDLDataItem.OrderNum] = objInFor[conDDLDataItem.OrderNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 下拉框数据项(DDLDataItem)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4DDLDataItem : clsCommFun4BL
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
clsDDLDataItemWApi.ReFreshThisCache();
}
}

}