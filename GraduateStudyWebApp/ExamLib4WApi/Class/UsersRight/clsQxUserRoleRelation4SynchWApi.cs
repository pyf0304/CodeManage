
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRoleRelation4SynchWApi
 表名:QxUserRoleRelation4Synch(01120556)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:37
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:UsersRight
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
public static class clsQxUserRoleRelation4SynchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetmId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, long lngmId, string strComparisonOp="")
	{
objQxUserRoleRelation4SynchEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.mId) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.mId, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.mId] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetIpAddress(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIpAddress, conQxUserRoleRelation4Synch.IpAddress);
clsCheckSql.CheckFieldLen(strIpAddress, 50, conQxUserRoleRelation4Synch.IpAddress);
objQxUserRoleRelation4SynchEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.IpAddress) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.IpAddress, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.IpAddress] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetUserId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxUserRoleRelation4Synch.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, conQxUserRoleRelation4Synch.UserId);
objQxUserRoleRelation4SynchEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.UserId) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.UserId, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.UserId] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetRoleId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, conQxUserRoleRelation4Synch.RoleId);
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxUserRoleRelation4Synch.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxUserRoleRelation4Synch.RoleId);
objQxUserRoleRelation4SynchEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.RoleId) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.RoleId, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.RoleId] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetQxPrjId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxUserRoleRelation4Synch.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxUserRoleRelation4Synch.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxUserRoleRelation4Synch.QxPrjId);
objQxUserRoleRelation4SynchEN.QxPrjId = strQxPrjId; //QxPrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.QxPrjId) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.QxPrjId, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.QxPrjId] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetUpdDate(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUserRoleRelation4Synch.UpdDate);
objQxUserRoleRelation4SynchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.UpdDate) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.UpdDate, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.UpdDate] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetUpdUserId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxUserRoleRelation4Synch.UpdUserId);
objQxUserRoleRelation4SynchEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.UpdUserId) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.UpdUserId, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.UpdUserId] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRoleRelation4SynchEN SetMemo(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserRoleRelation4Synch.Memo);
objQxUserRoleRelation4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelation4Synch.Memo) == false)
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(conQxUserRoleRelation4Synch.Memo, strComparisonOp);
}
else
{
objQxUserRoleRelation4SynchEN.dicFldComparisonOp[conQxUserRoleRelation4Synch.Memo] = strComparisonOp;
}
}
return objQxUserRoleRelation4SynchEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4Synch_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUserRoleRelation4Synch_Cond.IsUpdated(conQxUserRoleRelation4Synch.mId) == true)
{
string strComparisonOp_mId = objQxUserRoleRelation4Synch_Cond.dicFldComparisonOp[conQxUserRoleRelation4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserRoleRelation4Synch.mId, objQxUserRoleRelation4Synch_Cond.mId, strComparisonOp_mId);
}
if (objQxUserRoleRelation4Synch_Cond.IsUpdated(conQxUserRoleRelation4Synch.IpAddress) == true)
{
string strComparisonOp_IpAddress = objQxUserRoleRelation4Synch_Cond.dicFldComparisonOp[conQxUserRoleRelation4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.IpAddress, objQxUserRoleRelation4Synch_Cond.IpAddress, strComparisonOp_IpAddress);
}
if (objQxUserRoleRelation4Synch_Cond.IsUpdated(conQxUserRoleRelation4Synch.UserId) == true)
{
string strComparisonOp_UserId = objQxUserRoleRelation4Synch_Cond.dicFldComparisonOp[conQxUserRoleRelation4Synch.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.UserId, objQxUserRoleRelation4Synch_Cond.UserId, strComparisonOp_UserId);
}
if (objQxUserRoleRelation4Synch_Cond.IsUpdated(conQxUserRoleRelation4Synch.RoleId) == true)
{
string strComparisonOp_RoleId = objQxUserRoleRelation4Synch_Cond.dicFldComparisonOp[conQxUserRoleRelation4Synch.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.RoleId, objQxUserRoleRelation4Synch_Cond.RoleId, strComparisonOp_RoleId);
}
if (objQxUserRoleRelation4Synch_Cond.IsUpdated(conQxUserRoleRelation4Synch.QxPrjId) == true)
{
string strComparisonOp_QxPrjId = objQxUserRoleRelation4Synch_Cond.dicFldComparisonOp[conQxUserRoleRelation4Synch.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.QxPrjId, objQxUserRoleRelation4Synch_Cond.QxPrjId, strComparisonOp_QxPrjId);
}
if (objQxUserRoleRelation4Synch_Cond.IsUpdated(conQxUserRoleRelation4Synch.UpdDate) == true)
{
string strComparisonOp_UpdDate = objQxUserRoleRelation4Synch_Cond.dicFldComparisonOp[conQxUserRoleRelation4Synch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.UpdDate, objQxUserRoleRelation4Synch_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objQxUserRoleRelation4Synch_Cond.IsUpdated(conQxUserRoleRelation4Synch.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objQxUserRoleRelation4Synch_Cond.dicFldComparisonOp[conQxUserRoleRelation4Synch.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.UpdUserId, objQxUserRoleRelation4Synch_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objQxUserRoleRelation4Synch_Cond.IsUpdated(conQxUserRoleRelation4Synch.Memo) == true)
{
string strComparisonOp_Memo = objQxUserRoleRelation4Synch_Cond.dicFldComparisonOp[conQxUserRoleRelation4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelation4Synch.Memo, objQxUserRoleRelation4Synch_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
 if (objQxUserRoleRelation4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxUserRoleRelation4SynchEN.sf_UpdFldSetStr = objQxUserRoleRelation4SynchEN.getsf_UpdFldSetStr();
clsQxUserRoleRelation4SynchWApi.CheckPropertyNew(objQxUserRoleRelation4SynchEN); 
bool bolResult = clsQxUserRoleRelation4SynchWApi.UpdateRecord(objQxUserRoleRelation4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--QxUserRoleRelation4Synch(QxUserRoleRelation4Synch), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_IpAddress_QxPrjId_RoleId_UserId(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxUserRoleRelation4SynchEN == null) return "";
if (objQxUserRoleRelation4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUserRoleRelation4SynchEN.IpAddress);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxUserRoleRelation4SynchEN.QxPrjId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxUserRoleRelation4SynchEN.RoleId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRoleRelation4SynchEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserRoleRelation4SynchEN.mId);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUserRoleRelation4SynchEN.IpAddress);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxUserRoleRelation4SynchEN.QxPrjId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxUserRoleRelation4SynchEN.RoleId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRoleRelation4SynchEN.UserId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
try
{
clsQxUserRoleRelation4SynchWApi.CheckPropertyNew(objQxUserRoleRelation4SynchEN); 
bool bolResult = clsQxUserRoleRelation4SynchWApi.AddNewRecord(objQxUserRoleRelation4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchWApi.ReFreshCache();
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strWhereCond)
{
try
{
clsQxUserRoleRelation4SynchWApi.CheckPropertyNew(objQxUserRoleRelation4SynchEN); 
bool bolResult = clsQxUserRoleRelation4SynchWApi.UpdateWithCondition(objQxUserRoleRelation4SynchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchWApi.ReFreshCache();
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
 /// QxUserRoleRelation4Synch(QxUserRoleRelation4Synch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserRoleRelation4SynchWApi
{
private static readonly string mstrApiControllerName = "QxUserRoleRelation4SynchApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsQxUserRoleRelation4SynchWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
if (!Object.Equals(null, objQxUserRoleRelation4SynchEN.IpAddress) && GetStrLen(objQxUserRoleRelation4SynchEN.IpAddress) > 50)
{
 throw new Exception("字段[Ip地址]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUserRoleRelation4SynchEN.UserId) && GetStrLen(objQxUserRoleRelation4SynchEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUserRoleRelation4SynchEN.RoleId) && GetStrLen(objQxUserRoleRelation4SynchEN.RoleId) > 8)
{
 throw new Exception("字段[角色Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserRoleRelation4SynchEN.QxPrjId) && GetStrLen(objQxUserRoleRelation4SynchEN.QxPrjId) > 4)
{
 throw new Exception("字段[QxPrjId]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUserRoleRelation4SynchEN.UpdDate) && GetStrLen(objQxUserRoleRelation4SynchEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUserRoleRelation4SynchEN.UpdUserId) && GetStrLen(objQxUserRoleRelation4SynchEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUserRoleRelation4SynchEN.Memo) && GetStrLen(objQxUserRoleRelation4SynchEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxUserRoleRelation4SynchEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRoleRelation4SynchEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQxUserRoleRelation4SynchEN = JsonConvert.DeserializeObject<clsQxUserRoleRelation4SynchEN>((string)jobjReturn["ReturnObj"]);
return objQxUserRoleRelation4SynchEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRoleRelation4SynchEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQxUserRoleRelation4SynchEN = JsonConvert.DeserializeObject<clsQxUserRoleRelation4SynchEN>((string)jobjReturn["ReturnObj"]);
return objQxUserRoleRelation4SynchEN;
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
public static clsQxUserRoleRelation4SynchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = null;
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
objQxUserRoleRelation4SynchEN = JsonConvert.DeserializeObject<clsQxUserRoleRelation4SynchEN>((string)jobjReturn["ReturnObj"]);
return objQxUserRoleRelation4SynchEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRoleRelation4SynchEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxUserRoleRelation4SynchEN._CurrTabName_S);
List<clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLst_Sel =
from objQxUserRoleRelation4SynchEN in arrQxUserRoleRelation4SynchObjLst_Cache
where objQxUserRoleRelation4SynchEN.mId == lngmId
select objQxUserRoleRelation4SynchEN;
if (arrQxUserRoleRelation4SynchObjLst_Sel.Count() == 0)
{
   clsQxUserRoleRelation4SynchEN obj = clsQxUserRoleRelation4SynchWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQxUserRoleRelation4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRoleRelation4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserRoleRelation4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRoleRelation4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsQxUserRoleRelation4SynchEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRoleRelation4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsQxUserRoleRelation4SynchEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxUserRoleRelation4SynchEN._CurrTabName_S);
List<clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLst_Sel =
from objQxUserRoleRelation4SynchEN in arrQxUserRoleRelation4SynchObjLst_Cache
where arrMId.Contains(objQxUserRoleRelation4SynchEN.mId)
select objQxUserRoleRelation4SynchEN;
return arrQxUserRoleRelation4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsQxUserRoleRelation4SynchEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRoleRelation4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUserRoleRelation4SynchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxUserRoleRelation4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRoleRelation4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxUserRoleRelation4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRoleRelation4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxUserRoleRelation4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRoleRelation4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUserRoleRelation4SynchEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQxUserRoleRelation4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRoleRelation4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = clsQxUserRoleRelation4SynchWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQxUserRoleRelation4SynchWApi.ReFreshCache();
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
public static int DelQxUserRoleRelation4Synchs(List<string> arrmId)
{
string strAction = "DelQxUserRoleRelation4Synchs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQxUserRoleRelation4SynchWApi.ReFreshCache();
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
public static int DelQxUserRoleRelation4SynchsByCond(string strWhereCond)
{
string strAction = "DelQxUserRoleRelation4SynchsByCond";
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
public static bool AddNewRecord(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserRoleRelation4SynchEN>(objQxUserRoleRelation4SynchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchWApi.ReFreshCache();
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserRoleRelation4SynchEN>(objQxUserRoleRelation4SynchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelation4SynchWApi.ReFreshCache();
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
public static bool UpdateRecord(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN)
{
if (string.IsNullOrEmpty(objQxUserRoleRelation4SynchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserRoleRelation4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserRoleRelation4SynchEN>(objQxUserRoleRelation4SynchEN);
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
 /// <param name = "objQxUserRoleRelation4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxUserRoleRelation4SynchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserRoleRelation4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserRoleRelation4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserRoleRelation4SynchEN>(objQxUserRoleRelation4SynchEN);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objQxUserRoleRelation4SynchENS">源对象</param>
 /// <param name = "objQxUserRoleRelation4SynchENT">目标对象</param>
 public static void CopyTo(clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchENS, clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchENT)
{
try
{
objQxUserRoleRelation4SynchENT.mId = objQxUserRoleRelation4SynchENS.mId; //mId
objQxUserRoleRelation4SynchENT.IpAddress = objQxUserRoleRelation4SynchENS.IpAddress; //Ip地址
objQxUserRoleRelation4SynchENT.UserId = objQxUserRoleRelation4SynchENS.UserId; //用户ID
objQxUserRoleRelation4SynchENT.RoleId = objQxUserRoleRelation4SynchENS.RoleId; //角色Id
objQxUserRoleRelation4SynchENT.QxPrjId = objQxUserRoleRelation4SynchENS.QxPrjId; //QxPrjId
objQxUserRoleRelation4SynchENT.UpdDate = objQxUserRoleRelation4SynchENS.UpdDate; //修改日期
objQxUserRoleRelation4SynchENT.UpdUserId = objQxUserRoleRelation4SynchENS.UpdUserId; //修改用户Id
objQxUserRoleRelation4SynchENT.Memo = objQxUserRoleRelation4SynchENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxUserRoleRelation4SynchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxUserRoleRelation4SynchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxUserRoleRelation4SynchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxUserRoleRelation4SynchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxUserRoleRelation4SynchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxUserRoleRelation4SynchEN.AttributeName)
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
if (clsQxUserRoleRelation4SynchWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRoleRelation4SynchWApi没有刷新缓存机制(clsQxUserRoleRelation4SynchWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQxUserRoleRelation4SynchObjLst_Cache == null)
//{
//arrQxUserRoleRelation4SynchObjLst_Cache = await clsQxUserRoleRelation4SynchWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsQxUserRoleRelation4SynchEN._CurrTabName_S);
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
if (clsQxUserRoleRelation4SynchWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserRoleRelation4SynchEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsQxUserRoleRelation4SynchWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserRoleRelation4SynchEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsQxUserRoleRelation4SynchEN._CurrTabName_S);
List<clsQxUserRoleRelation4SynchEN> arrQxUserRoleRelation4SynchObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUserRoleRelation4SynchObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxUserRoleRelation4SynchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxUserRoleRelation4Synch.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conQxUserRoleRelation4Synch.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoleRelation4Synch.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoleRelation4Synch.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoleRelation4Synch.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoleRelation4Synch.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoleRelation4Synch.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoleRelation4Synch.Memo, Type.GetType("System.String"));
foreach (clsQxUserRoleRelation4SynchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxUserRoleRelation4Synch.mId] = objInFor[conQxUserRoleRelation4Synch.mId];
objDR[conQxUserRoleRelation4Synch.IpAddress] = objInFor[conQxUserRoleRelation4Synch.IpAddress];
objDR[conQxUserRoleRelation4Synch.UserId] = objInFor[conQxUserRoleRelation4Synch.UserId];
objDR[conQxUserRoleRelation4Synch.RoleId] = objInFor[conQxUserRoleRelation4Synch.RoleId];
objDR[conQxUserRoleRelation4Synch.QxPrjId] = objInFor[conQxUserRoleRelation4Synch.QxPrjId];
objDR[conQxUserRoleRelation4Synch.UpdDate] = objInFor[conQxUserRoleRelation4Synch.UpdDate];
objDR[conQxUserRoleRelation4Synch.UpdUserId] = objInFor[conQxUserRoleRelation4Synch.UpdUserId];
objDR[conQxUserRoleRelation4Synch.Memo] = objInFor[conQxUserRoleRelation4Synch.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// QxUserRoleRelation4Synch(QxUserRoleRelation4Synch)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4QxUserRoleRelation4Synch : clsCommFun4BL
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
clsQxUserRoleRelation4SynchWApi.ReFreshThisCache();
}
}

}