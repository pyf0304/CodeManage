
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRolesWApi
 表名:QxUserRoles(01120920)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:51
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
public static class clsQxUserRolesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRolesEN SetRoleId(this clsQxUserRolesEN objQxUserRolesEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxUserRoles.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxUserRoles.RoleId);
objQxUserRolesEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRolesEN.dicFldComparisonOp.ContainsKey(conQxUserRoles.RoleId) == false)
{
objQxUserRolesEN.dicFldComparisonOp.Add(conQxUserRoles.RoleId, strComparisonOp);
}
else
{
objQxUserRolesEN.dicFldComparisonOp[conQxUserRoles.RoleId] = strComparisonOp;
}
}
return objQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRolesEN SetRoleName(this clsQxUserRolesEN objQxUserRolesEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, conQxUserRoles.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 100, conQxUserRoles.RoleName);
objQxUserRolesEN.RoleName = strRoleName; //角色名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRolesEN.dicFldComparisonOp.ContainsKey(conQxUserRoles.RoleName) == false)
{
objQxUserRolesEN.dicFldComparisonOp.Add(conQxUserRoles.RoleName, strComparisonOp);
}
else
{
objQxUserRolesEN.dicFldComparisonOp[conQxUserRoles.RoleName] = strComparisonOp;
}
}
return objQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRolesEN SetRoleENName(this clsQxUserRolesEN objQxUserRolesEN, string strRoleENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleENName, 50, conQxUserRoles.RoleENName);
objQxUserRolesEN.RoleENName = strRoleENName; //角色英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRolesEN.dicFldComparisonOp.ContainsKey(conQxUserRoles.RoleENName) == false)
{
objQxUserRolesEN.dicFldComparisonOp.Add(conQxUserRoles.RoleENName, strComparisonOp);
}
else
{
objQxUserRolesEN.dicFldComparisonOp[conQxUserRoles.RoleENName] = strComparisonOp;
}
}
return objQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRolesEN SetRoleIndex(this clsQxUserRolesEN objQxUserRolesEN, int intRoleIndex, string strComparisonOp="")
	{
objQxUserRolesEN.RoleIndex = intRoleIndex; //角色序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRolesEN.dicFldComparisonOp.ContainsKey(conQxUserRoles.RoleIndex) == false)
{
objQxUserRolesEN.dicFldComparisonOp.Add(conQxUserRoles.RoleIndex, strComparisonOp);
}
else
{
objQxUserRolesEN.dicFldComparisonOp[conQxUserRoles.RoleIndex] = strComparisonOp;
}
}
return objQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRolesEN SetQxPrjId(this clsQxUserRolesEN objQxUserRolesEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxUserRoles.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxUserRoles.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxUserRoles.QxPrjId);
objQxUserRolesEN.QxPrjId = strQxPrjId; //QxPrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRolesEN.dicFldComparisonOp.ContainsKey(conQxUserRoles.QxPrjId) == false)
{
objQxUserRolesEN.dicFldComparisonOp.Add(conQxUserRoles.QxPrjId, strComparisonOp);
}
else
{
objQxUserRolesEN.dicFldComparisonOp[conQxUserRoles.QxPrjId] = strComparisonOp;
}
}
return objQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRolesEN SetIsInUse(this clsQxUserRolesEN objQxUserRolesEN, bool bolIsInUse, string strComparisonOp="")
	{
objQxUserRolesEN.IsInUse = bolIsInUse; //IsInUse
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRolesEN.dicFldComparisonOp.ContainsKey(conQxUserRoles.IsInUse) == false)
{
objQxUserRolesEN.dicFldComparisonOp.Add(conQxUserRoles.IsInUse, strComparisonOp);
}
else
{
objQxUserRolesEN.dicFldComparisonOp[conQxUserRoles.IsInUse] = strComparisonOp;
}
}
return objQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRolesEN SetUpdDate(this clsQxUserRolesEN objQxUserRolesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUserRoles.UpdDate);
objQxUserRolesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRolesEN.dicFldComparisonOp.ContainsKey(conQxUserRoles.UpdDate) == false)
{
objQxUserRolesEN.dicFldComparisonOp.Add(conQxUserRoles.UpdDate, strComparisonOp);
}
else
{
objQxUserRolesEN.dicFldComparisonOp[conQxUserRoles.UpdDate] = strComparisonOp;
}
}
return objQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRolesEN SetUpdUserId(this clsQxUserRolesEN objQxUserRolesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxUserRoles.UpdUserId);
objQxUserRolesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRolesEN.dicFldComparisonOp.ContainsKey(conQxUserRoles.UpdUserId) == false)
{
objQxUserRolesEN.dicFldComparisonOp.Add(conQxUserRoles.UpdUserId, strComparisonOp);
}
else
{
objQxUserRolesEN.dicFldComparisonOp[conQxUserRoles.UpdUserId] = strComparisonOp;
}
}
return objQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQxUserRolesEN SetMemo(this clsQxUserRolesEN objQxUserRolesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserRoles.Memo);
objQxUserRolesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRolesEN.dicFldComparisonOp.ContainsKey(conQxUserRoles.Memo) == false)
{
objQxUserRolesEN.dicFldComparisonOp.Add(conQxUserRoles.Memo, strComparisonOp);
}
else
{
objQxUserRolesEN.dicFldComparisonOp[conQxUserRoles.Memo] = strComparisonOp;
}
}
return objQxUserRolesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUserRolesEN objQxUserRoles_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUserRoles_Cond.IsUpdated(conQxUserRoles.RoleId) == true)
{
string strComparisonOp_RoleId = objQxUserRoles_Cond.dicFldComparisonOp[conQxUserRoles.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoles.RoleId, objQxUserRoles_Cond.RoleId, strComparisonOp_RoleId);
}
if (objQxUserRoles_Cond.IsUpdated(conQxUserRoles.RoleName) == true)
{
string strComparisonOp_RoleName = objQxUserRoles_Cond.dicFldComparisonOp[conQxUserRoles.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoles.RoleName, objQxUserRoles_Cond.RoleName, strComparisonOp_RoleName);
}
if (objQxUserRoles_Cond.IsUpdated(conQxUserRoles.RoleENName) == true)
{
string strComparisonOp_RoleENName = objQxUserRoles_Cond.dicFldComparisonOp[conQxUserRoles.RoleENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoles.RoleENName, objQxUserRoles_Cond.RoleENName, strComparisonOp_RoleENName);
}
if (objQxUserRoles_Cond.IsUpdated(conQxUserRoles.RoleIndex) == true)
{
string strComparisonOp_RoleIndex = objQxUserRoles_Cond.dicFldComparisonOp[conQxUserRoles.RoleIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserRoles.RoleIndex, objQxUserRoles_Cond.RoleIndex, strComparisonOp_RoleIndex);
}
if (objQxUserRoles_Cond.IsUpdated(conQxUserRoles.QxPrjId) == true)
{
string strComparisonOp_QxPrjId = objQxUserRoles_Cond.dicFldComparisonOp[conQxUserRoles.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoles.QxPrjId, objQxUserRoles_Cond.QxPrjId, strComparisonOp_QxPrjId);
}
if (objQxUserRoles_Cond.IsUpdated(conQxUserRoles.IsInUse) == true)
{
if (objQxUserRoles_Cond.IsInUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUserRoles.IsInUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUserRoles.IsInUse);
}
}
if (objQxUserRoles_Cond.IsUpdated(conQxUserRoles.UpdDate) == true)
{
string strComparisonOp_UpdDate = objQxUserRoles_Cond.dicFldComparisonOp[conQxUserRoles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoles.UpdDate, objQxUserRoles_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objQxUserRoles_Cond.IsUpdated(conQxUserRoles.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objQxUserRoles_Cond.dicFldComparisonOp[conQxUserRoles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoles.UpdUserId, objQxUserRoles_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objQxUserRoles_Cond.IsUpdated(conQxUserRoles.Memo) == true)
{
string strComparisonOp_Memo = objQxUserRoles_Cond.dicFldComparisonOp[conQxUserRoles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoles.Memo, objQxUserRoles_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserRolesEN objQxUserRolesEN)
{
 if (string.IsNullOrEmpty(objQxUserRolesEN.RoleId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxUserRolesEN.sf_UpdFldSetStr = objQxUserRolesEN.getsf_UpdFldSetStr();
clsQxUserRolesWApi.CheckPropertyNew(objQxUserRolesEN); 
bool bolResult = clsQxUserRolesWApi.UpdateRecord(objQxUserRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRolesWApi.ReFreshCache();
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
 /// <param name = "objQxUserRolesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserRolesEN objQxUserRolesEN)
{
 if (string.IsNullOrEmpty(objQxUserRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUserRolesWApi.IsExist(objQxUserRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objQxUserRolesEN.RoleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQxUserRolesWApi.CheckPropertyNew(objQxUserRolesEN); 
bool bolResult = clsQxUserRolesWApi.AddNewRecord(objQxUserRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRolesWApi.ReFreshCache();
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
 /// <param name = "objQxUserRolesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxUserRolesEN objQxUserRolesEN)
{
try
{
clsQxUserRolesWApi.CheckPropertyNew(objQxUserRolesEN); 
string strRoleId = clsQxUserRolesWApi.AddNewRecordWithMaxId(objQxUserRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRolesWApi.ReFreshCache();
return strRoleId;
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
 /// <param name = "objQxUserRolesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserRolesEN objQxUserRolesEN, string strWhereCond)
{
try
{
clsQxUserRolesWApi.CheckPropertyNew(objQxUserRolesEN); 
bool bolResult = clsQxUserRolesWApi.UpdateWithCondition(objQxUserRolesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRolesWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumQxUserRolesWA
{
 /// <summary>
 /// 统一平台总管理员
 /// </summary>
public const string _00010001 = "00010001";
 /// <summary>
 /// 项目管理员
 /// </summary>
public const string _00010002 = "00010002";
 /// <summary>
 /// 高级用户
 /// </summary>
public const string _00010003 = "00010003";
 /// <summary>
 /// 普通用户
 /// </summary>
public const string _00010004 = "00010004";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _00620001 = "00620001";
 /// <summary>
 /// 普通教师
 /// </summary>
public const string _00620002 = "00620002";
 /// <summary>
 /// 普通学生
 /// </summary>
public const string _00620003 = "00620003";
 /// <summary>
 /// 小组长(微格)
 /// </summary>
public const string _00620005 = "00620005";
 /// <summary>
 /// 中小学实习指导老师
 /// </summary>
public const string _00620006 = "00620006";
 /// <summary>
 /// 学工办辅导员
 /// </summary>
public const string _00620007 = "00620007";
 /// <summary>
 /// 实习指导老师
 /// </summary>
public const string _00620008 = "00620008";
 /// <summary>
 /// 指导老师（微格）
 /// </summary>
public const string _00620009 = "00620009";
 /// <summary>
 /// 评审专家
 /// </summary>
public const string _00620010 = "00620010";
 /// <summary>
 /// 教务处
 /// </summary>
public const string _00620011 = "00620011";
 /// <summary>
 /// 案例维护
 /// </summary>
public const string _00620012 = "00620012";
 /// <summary>
 /// 中小学教师
 /// </summary>
public const string _00620013 = "00620013";
 /// <summary>
 /// 教师(交建)
 /// </summary>
public const string _00620014 = "00620014";
 /// <summary>
 /// 交建答题学生
 /// </summary>
public const string _00620015 = "00620015";
 /// <summary>
 /// 语音学生
 /// </summary>
public const string _00620016 = "00620016";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _01030001 = "01030001";
}
 /// <summary>
 /// 角色(QxUserRoles)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserRolesWApi
{
private static readonly string mstrApiControllerName = "QxUserRolesApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsQxUserRolesWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[角色]...","0");
List<clsQxUserRolesEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="RoleId";
objDDL.DataTextField="RoleName";
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
public static void BindCbo_RoleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxUserRoles.RoleId); 
List<clsQxUserRolesEN> arrObjLst = clsQxUserRolesWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxUserRolesEN objQxUserRolesEN = new clsQxUserRolesEN()
{
RoleId = "0",
RoleName = "选[角色]..."
};
arrObjLst.Insert(0, objQxUserRolesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxUserRoles.RoleId;
objComboBox.DisplayMember = conQxUserRoles.RoleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxUserRolesEN objQxUserRolesEN)
{
if (!Object.Equals(null, objQxUserRolesEN.RoleId) && GetStrLen(objQxUserRolesEN.RoleId) > 8)
{
 throw new Exception("字段[角色Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserRolesEN.RoleName) && GetStrLen(objQxUserRolesEN.RoleName) > 100)
{
 throw new Exception("字段[角色名]的长度不能超过100!");
}
if (!Object.Equals(null, objQxUserRolesEN.RoleENName) && GetStrLen(objQxUserRolesEN.RoleENName) > 50)
{
 throw new Exception("字段[角色英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUserRolesEN.QxPrjId) && GetStrLen(objQxUserRolesEN.QxPrjId) > 4)
{
 throw new Exception("字段[QxPrjId]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUserRolesEN.UpdDate) && GetStrLen(objQxUserRolesEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUserRolesEN.UpdUserId) && GetStrLen(objQxUserRolesEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUserRolesEN.Memo) && GetStrLen(objQxUserRolesEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxUserRolesEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRolesEN GetObjByRoleId(string strRoleId)
{
string strAction = "GetObjByRoleId";
string strErrMsg = string.Empty;
string strResult = "";
clsQxUserRolesEN objQxUserRolesEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RoleId"] = strRoleId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQxUserRolesEN = JsonConvert.DeserializeObject<clsQxUserRolesEN>((string)jobjReturn["ReturnObj"]);
return objQxUserRolesEN;
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
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRolesEN GetObjByRoleId_WA_Cache(string strRoleId)
{
string strAction = "GetObjByRoleId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQxUserRolesEN objQxUserRolesEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RoleId"] = strRoleId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQxUserRolesEN = JsonConvert.DeserializeObject<clsQxUserRolesEN>((string)jobjReturn["ReturnObj"]);
return objQxUserRolesEN;
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
public static clsQxUserRolesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQxUserRolesEN objQxUserRolesEN = null;
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
objQxUserRolesEN = JsonConvert.DeserializeObject<clsQxUserRolesEN>((string)jobjReturn["ReturnObj"]);
return objQxUserRolesEN;
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
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRolesEN GetObjByRoleId_Cache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsQxUserRolesEN._CurrTabName_S);
List<clsQxUserRolesEN> arrQxUserRolesObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQxUserRolesEN> arrQxUserRolesObjLst_Sel =
from objQxUserRolesEN in arrQxUserRolesObjLst_Cache
where objQxUserRolesEN.RoleId == strRoleId
select objQxUserRolesEN;
if (arrQxUserRolesObjLst_Sel.Count() == 0)
{
   clsQxUserRolesEN obj = clsQxUserRolesWApi.GetObjByRoleId(strRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQxUserRolesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRoleNameByRoleId_Cache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQxUserRolesEN._CurrTabName_S);
List<clsQxUserRolesEN> arrQxUserRolesObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQxUserRolesEN> arrQxUserRolesObjLst_Sel1 =
from objQxUserRolesEN in arrQxUserRolesObjLst_Cache
where objQxUserRolesEN.RoleId == strRoleId
select objQxUserRolesEN;
List <clsQxUserRolesEN> arrQxUserRolesObjLst_Sel = new List<clsQxUserRolesEN>();
foreach (clsQxUserRolesEN obj in arrQxUserRolesObjLst_Sel1)
{
arrQxUserRolesObjLst_Sel.Add(obj);
}
if (arrQxUserRolesObjLst_Sel.Count > 0)
{
return arrQxUserRolesObjLst_Sel[0].RoleName;
}
string strErrMsgForGetObjById = string.Format("在QxUserRoles对象缓存列表中,找不到记录[RoleId = {0}](函数:{1})", strRoleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxUserRolesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRoleId_Cache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQxUserRolesEN._CurrTabName_S);
List<clsQxUserRolesEN> arrQxUserRolesObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQxUserRolesEN> arrQxUserRolesObjLst_Sel1 =
from objQxUserRolesEN in arrQxUserRolesObjLst_Cache
where objQxUserRolesEN.RoleId == strRoleId
select objQxUserRolesEN;
List <clsQxUserRolesEN> arrQxUserRolesObjLst_Sel = new List<clsQxUserRolesEN>();
foreach (clsQxUserRolesEN obj in arrQxUserRolesObjLst_Sel1)
{
arrQxUserRolesObjLst_Sel.Add(obj);
}
if (arrQxUserRolesObjLst_Sel.Count > 0)
{
return arrQxUserRolesObjLst_Sel[0].RoleName;
}
string strErrMsgForGetObjById = string.Format("在QxUserRoles对象缓存列表中,找不到记录的相关名称[RoleId = {0}](函数:{1})", strRoleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxUserRolesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRolesEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUserRolesEN> GetObjLstByRoleIdLst(List<string> arrRoleId)
{
 List<clsQxUserRolesEN> arrObjLst = null; 
string strAction = "GetObjLstByRoleIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRoleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsQxUserRolesEN> GetObjLstByRoleIdLst_Cache(List<string> arrRoleId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxUserRolesEN._CurrTabName_S);
List<clsQxUserRolesEN> arrQxUserRolesObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQxUserRolesEN> arrQxUserRolesObjLst_Sel =
from objQxUserRolesEN in arrQxUserRolesObjLst_Cache
where arrRoleId.Contains(objQxUserRolesEN.RoleId)
select objQxUserRolesEN;
return arrQxUserRolesObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRolesEN> GetObjLstByRoleIdLst_WA_Cache(List<string> arrRoleId)
{
 List<clsQxUserRolesEN> arrObjLst = null; 
string strAction = "GetObjLstByRoleIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRoleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUserRolesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUserRolesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUserRolesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQxUserRolesEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQxUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strRoleId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsQxUserRolesEN objQxUserRolesEN = clsQxUserRolesWApi.GetObjByRoleId(strRoleId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strRoleId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQxUserRolesWApi.ReFreshCache();
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
public static int DelQxUserRoless(List<string> arrRoleId)
{
string strAction = "DelQxUserRoless";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRoleId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQxUserRolesWApi.ReFreshCache();
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
public static int DelQxUserRolessByCond(string strWhereCond)
{
string strAction = "DelQxUserRolessByCond";
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
public static bool AddNewRecord(clsQxUserRolesEN objQxUserRolesEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserRolesEN>(objQxUserRolesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRolesWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsQxUserRolesEN objQxUserRolesEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserRolesEN>(objQxUserRolesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRolesWApi.ReFreshCache();
var strRoleId = (string)jobjReturn["ReturnStr"];
return strRoleId;
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
public static bool UpdateRecord(clsQxUserRolesEN objQxUserRolesEN)
{
if (string.IsNullOrEmpty(objQxUserRolesEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserRolesEN.RoleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserRolesEN>(objQxUserRolesEN);
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
 /// <param name = "objQxUserRolesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxUserRolesEN objQxUserRolesEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxUserRolesEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserRolesEN.RoleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserRolesEN.RoleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserRolesEN>(objQxUserRolesEN);
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
public static bool IsExist(string strRoleId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RoleId"] = strRoleId
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
 /// <param name = "objQxUserRolesENS">源对象</param>
 /// <param name = "objQxUserRolesENT">目标对象</param>
 public static void CopyTo(clsQxUserRolesEN objQxUserRolesENS, clsQxUserRolesEN objQxUserRolesENT)
{
try
{
objQxUserRolesENT.RoleId = objQxUserRolesENS.RoleId; //角色Id
objQxUserRolesENT.RoleName = objQxUserRolesENS.RoleName; //角色名
objQxUserRolesENT.RoleENName = objQxUserRolesENS.RoleENName; //角色英文名
objQxUserRolesENT.RoleIndex = objQxUserRolesENS.RoleIndex; //角色序号
objQxUserRolesENT.QxPrjId = objQxUserRolesENS.QxPrjId; //QxPrjId
objQxUserRolesENT.IsInUse = objQxUserRolesENS.IsInUse; //IsInUse
objQxUserRolesENT.UpdDate = objQxUserRolesENS.UpdDate; //修改日期
objQxUserRolesENT.UpdUserId = objQxUserRolesENS.UpdUserId; //修改用户Id
objQxUserRolesENT.Memo = objQxUserRolesENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxUserRolesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxUserRolesEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxUserRolesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxUserRolesEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxUserRolesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxUserRolesEN.AttributeName)
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
if (clsQxUserRolesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRolesWApi没有刷新缓存机制(clsQxUserRolesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RoleId");
//if (arrQxUserRolesObjLst_Cache == null)
//{
//arrQxUserRolesObjLst_Cache = await clsQxUserRolesWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsQxUserRolesEN._CurrTabName_S);
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
if (clsQxUserRolesWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserRolesEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsQxUserRolesWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserRolesEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsQxUserRolesEN._CurrTabName_S);
List<clsQxUserRolesEN> arrQxUserRolesObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUserRolesObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxUserRolesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxUserRoles.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoles.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoles.RoleENName, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoles.RoleIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxUserRoles.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoles.IsInUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUserRoles.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoles.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserRoles.Memo, Type.GetType("System.String"));
foreach (clsQxUserRolesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxUserRoles.RoleId] = objInFor[conQxUserRoles.RoleId];
objDR[conQxUserRoles.RoleName] = objInFor[conQxUserRoles.RoleName];
objDR[conQxUserRoles.RoleENName] = objInFor[conQxUserRoles.RoleENName];
objDR[conQxUserRoles.RoleIndex] = objInFor[conQxUserRoles.RoleIndex];
objDR[conQxUserRoles.QxPrjId] = objInFor[conQxUserRoles.QxPrjId];
objDR[conQxUserRoles.IsInUse] = objInFor[conQxUserRoles.IsInUse];
objDR[conQxUserRoles.UpdDate] = objInFor[conQxUserRoles.UpdDate];
objDR[conQxUserRoles.UpdUserId] = objInFor[conQxUserRoles.UpdUserId];
objDR[conQxUserRoles.Memo] = objInFor[conQxUserRoles.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 角色(QxUserRoles)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4QxUserRoles : clsCommFun4BL
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
clsQxUserRolesWApi.ReFreshThisCache();
}
}

}