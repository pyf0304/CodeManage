
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppraiseTypeKindSetWApi
 表名:AppraiseTypeKindSet(01120460)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:17
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数
 模块英文名:SenateGaugePara
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
public static class clsAppraiseTypeKindSetWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetmId(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, long lngmId, string strComparisonOp="")
	{
objAppraiseTypeKindSetEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.mId) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.mId, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.mId] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeKindSetEN Setid_School(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_School, conAppraiseTypeKindSet.id_School);
clsCheckSql.CheckFieldLen(strid_School, 4, conAppraiseTypeKindSet.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, conAppraiseTypeKindSet.id_School);
objAppraiseTypeKindSetEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.id_School) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.id_School, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.id_School] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetFuncModuleId(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conAppraiseTypeKindSet.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conAppraiseTypeKindSet.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conAppraiseTypeKindSet.FuncModuleId);
objAppraiseTypeKindSetEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.FuncModuleId) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.FuncModuleId, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.FuncModuleId] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeKindSetEN Setid_AppraiseType(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, conAppraiseTypeKindSet.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, conAppraiseTypeKindSet.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, conAppraiseTypeKindSet.id_AppraiseType);
objAppraiseTypeKindSetEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.id_AppraiseType) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.id_AppraiseType, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.id_AppraiseType] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetAppraiseKindId(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strAppraiseKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseKindId, conAppraiseTypeKindSet.AppraiseKindId);
clsCheckSql.CheckFieldLen(strAppraiseKindId, 2, conAppraiseTypeKindSet.AppraiseKindId);
clsCheckSql.CheckFieldForeignKey(strAppraiseKindId, 2, conAppraiseTypeKindSet.AppraiseKindId);
objAppraiseTypeKindSetEN.AppraiseKindId = strAppraiseKindId; //评议种类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.AppraiseKindId) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.AppraiseKindId, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.AppraiseKindId] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetInEffect(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, bool bolInEffect, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInEffect, conAppraiseTypeKindSet.InEffect);
objAppraiseTypeKindSetEN.InEffect = bolInEffect; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.InEffect) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.InEffect, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.InEffect] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetUpdDate(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conAppraiseTypeKindSet.UpdDate);
objAppraiseTypeKindSetEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.UpdDate) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.UpdDate, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.UpdDate] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetUpdUserId(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conAppraiseTypeKindSet.UpdUserId);
objAppraiseTypeKindSetEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.UpdUserId) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.UpdUserId, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.UpdUserId] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetMemo(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAppraiseTypeKindSet.Memo);
objAppraiseTypeKindSetEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.Memo) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.Memo, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.Memo] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSet_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAppraiseTypeKindSet_Cond.IsUpdated(conAppraiseTypeKindSet.mId) == true)
{
string strComparisonOp_mId = objAppraiseTypeKindSet_Cond.dicFldComparisonOp[conAppraiseTypeKindSet.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conAppraiseTypeKindSet.mId, objAppraiseTypeKindSet_Cond.mId, strComparisonOp_mId);
}
if (objAppraiseTypeKindSet_Cond.IsUpdated(conAppraiseTypeKindSet.id_School) == true)
{
string strComparisonOp_id_School = objAppraiseTypeKindSet_Cond.dicFldComparisonOp[conAppraiseTypeKindSet.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.id_School, objAppraiseTypeKindSet_Cond.id_School, strComparisonOp_id_School);
}
if (objAppraiseTypeKindSet_Cond.IsUpdated(conAppraiseTypeKindSet.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objAppraiseTypeKindSet_Cond.dicFldComparisonOp[conAppraiseTypeKindSet.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.FuncModuleId, objAppraiseTypeKindSet_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objAppraiseTypeKindSet_Cond.IsUpdated(conAppraiseTypeKindSet.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objAppraiseTypeKindSet_Cond.dicFldComparisonOp[conAppraiseTypeKindSet.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.id_AppraiseType, objAppraiseTypeKindSet_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objAppraiseTypeKindSet_Cond.IsUpdated(conAppraiseTypeKindSet.AppraiseKindId) == true)
{
string strComparisonOp_AppraiseKindId = objAppraiseTypeKindSet_Cond.dicFldComparisonOp[conAppraiseTypeKindSet.AppraiseKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.AppraiseKindId, objAppraiseTypeKindSet_Cond.AppraiseKindId, strComparisonOp_AppraiseKindId);
}
if (objAppraiseTypeKindSet_Cond.IsUpdated(conAppraiseTypeKindSet.InEffect) == true)
{
if (objAppraiseTypeKindSet_Cond.InEffect == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAppraiseTypeKindSet.InEffect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAppraiseTypeKindSet.InEffect);
}
}
if (objAppraiseTypeKindSet_Cond.IsUpdated(conAppraiseTypeKindSet.UpdDate) == true)
{
string strComparisonOp_UpdDate = objAppraiseTypeKindSet_Cond.dicFldComparisonOp[conAppraiseTypeKindSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.UpdDate, objAppraiseTypeKindSet_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objAppraiseTypeKindSet_Cond.IsUpdated(conAppraiseTypeKindSet.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objAppraiseTypeKindSet_Cond.dicFldComparisonOp[conAppraiseTypeKindSet.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.UpdUserId, objAppraiseTypeKindSet_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objAppraiseTypeKindSet_Cond.IsUpdated(conAppraiseTypeKindSet.Memo) == true)
{
string strComparisonOp_Memo = objAppraiseTypeKindSet_Cond.dicFldComparisonOp[conAppraiseTypeKindSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.Memo, objAppraiseTypeKindSet_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 if (objAppraiseTypeKindSetEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objAppraiseTypeKindSetEN.sf_UpdFldSetStr = objAppraiseTypeKindSetEN.getsf_UpdFldSetStr();
clsAppraiseTypeKindSetWApi.CheckPropertyNew(objAppraiseTypeKindSetEN); 
bool bolResult = clsAppraiseTypeKindSetWApi.UpdateRecord(objAppraiseTypeKindSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--AppraiseTypeKindSet(评议类型种类设置), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_School_FuncModuleId_id_AppraiseType_AppraiseKindId(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objAppraiseTypeKindSetEN == null) return "";
if (objAppraiseTypeKindSetEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_School = '{0}'", objAppraiseTypeKindSetEN.id_School);
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objAppraiseTypeKindSetEN.FuncModuleId);
 sbCondition.AppendFormat(" and id_AppraiseType = '{0}'", objAppraiseTypeKindSetEN.id_AppraiseType);
 sbCondition.AppendFormat(" and AppraiseKindId = '{0}'", objAppraiseTypeKindSetEN.AppraiseKindId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objAppraiseTypeKindSetEN.mId);
 sbCondition.AppendFormat(" and id_School = '{0}'", objAppraiseTypeKindSetEN.id_School);
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objAppraiseTypeKindSetEN.FuncModuleId);
 sbCondition.AppendFormat(" and id_AppraiseType = '{0}'", objAppraiseTypeKindSetEN.id_AppraiseType);
 sbCondition.AppendFormat(" and AppraiseKindId = '{0}'", objAppraiseTypeKindSetEN.AppraiseKindId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
try
{
clsAppraiseTypeKindSetWApi.CheckPropertyNew(objAppraiseTypeKindSetEN); 
bool bolResult = clsAppraiseTypeKindSetWApi.AddNewRecord(objAppraiseTypeKindSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetWApi.ReFreshCache();
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
 /// <param name = "objAppraiseTypeKindSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strWhereCond)
{
try
{
clsAppraiseTypeKindSetWApi.CheckPropertyNew(objAppraiseTypeKindSetEN); 
bool bolResult = clsAppraiseTypeKindSetWApi.UpdateWithCondition(objAppraiseTypeKindSetEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetWApi.ReFreshCache();
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
 /// 评议类型种类设置(AppraiseTypeKindSet)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsAppraiseTypeKindSetWApi
{
private static readonly string mstrApiControllerName = "AppraiseTypeKindSetApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsAppraiseTypeKindSetWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
if (!Object.Equals(null, objAppraiseTypeKindSetEN.id_School) && GetStrLen(objAppraiseTypeKindSetEN.id_School) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objAppraiseTypeKindSetEN.FuncModuleId) && GetStrLen(objAppraiseTypeKindSetEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objAppraiseTypeKindSetEN.id_AppraiseType) && GetStrLen(objAppraiseTypeKindSetEN.id_AppraiseType) > 4)
{
 throw new Exception("字段[评议类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objAppraiseTypeKindSetEN.AppraiseKindId) && GetStrLen(objAppraiseTypeKindSetEN.AppraiseKindId) > 2)
{
 throw new Exception("字段[评议种类Id]的长度不能超过2!");
}
if (!Object.Equals(null, objAppraiseTypeKindSetEN.UpdDate) && GetStrLen(objAppraiseTypeKindSetEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objAppraiseTypeKindSetEN.UpdUserId) && GetStrLen(objAppraiseTypeKindSetEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objAppraiseTypeKindSetEN.Memo) && GetStrLen(objAppraiseTypeKindSetEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objAppraiseTypeKindSetEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAppraiseTypeKindSetEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = null;
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
objAppraiseTypeKindSetEN = JsonConvert.DeserializeObject<clsAppraiseTypeKindSetEN>((string)jobjReturn["ReturnObj"]);
return objAppraiseTypeKindSetEN;
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
public static clsAppraiseTypeKindSetEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = null;
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
objAppraiseTypeKindSetEN = JsonConvert.DeserializeObject<clsAppraiseTypeKindSetEN>((string)jobjReturn["ReturnObj"]);
return objAppraiseTypeKindSetEN;
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
public static clsAppraiseTypeKindSetEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = null;
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
objAppraiseTypeKindSetEN = JsonConvert.DeserializeObject<clsAppraiseTypeKindSetEN>((string)jobjReturn["ReturnObj"]);
return objAppraiseTypeKindSetEN;
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
public static clsAppraiseTypeKindSetEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsAppraiseTypeKindSetEN._CurrTabName_S);
List<clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLst_Sel =
from objAppraiseTypeKindSetEN in arrAppraiseTypeKindSetObjLst_Cache
where objAppraiseTypeKindSetEN.mId == lngmId
select objAppraiseTypeKindSetEN;
if (arrAppraiseTypeKindSetObjLst_Sel.Count() == 0)
{
   clsAppraiseTypeKindSetEN obj = clsAppraiseTypeKindSetWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrAppraiseTypeKindSetObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppraiseTypeKindSetEN> GetObjLst(string strWhereCond)
{
 List<clsAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAppraiseTypeKindSetEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsAppraiseTypeKindSetEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsAppraiseTypeKindSetEN._CurrTabName_S);
List<clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLst_Sel =
from objAppraiseTypeKindSetEN in arrAppraiseTypeKindSetObjLst_Cache
where arrMId.Contains(objAppraiseTypeKindSetEN.mId)
select objAppraiseTypeKindSetEN;
return arrAppraiseTypeKindSetObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppraiseTypeKindSetEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAppraiseTypeKindSetEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAppraiseTypeKindSetEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAppraiseTypeKindSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAppraiseTypeKindSetEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = clsAppraiseTypeKindSetWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsAppraiseTypeKindSetWApi.ReFreshCache();
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
public static int DelAppraiseTypeKindSets(List<string> arrmId)
{
string strAction = "DelAppraiseTypeKindSets";
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
clsAppraiseTypeKindSetWApi.ReFreshCache();
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
public static int DelAppraiseTypeKindSetsByCond(string strWhereCond)
{
string strAction = "DelAppraiseTypeKindSetsByCond";
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
public static bool AddNewRecord(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppraiseTypeKindSetEN>(objAppraiseTypeKindSetEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetWApi.ReFreshCache();
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
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppraiseTypeKindSetEN>(objAppraiseTypeKindSetEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetWApi.ReFreshCache();
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
public static bool UpdateRecord(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
if (string.IsNullOrEmpty(objAppraiseTypeKindSetEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAppraiseTypeKindSetEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppraiseTypeKindSetEN>(objAppraiseTypeKindSetEN);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objAppraiseTypeKindSetEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAppraiseTypeKindSetEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAppraiseTypeKindSetEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppraiseTypeKindSetEN>(objAppraiseTypeKindSetEN);
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
 /// <param name = "objAppraiseTypeKindSetENS">源对象</param>
 /// <param name = "objAppraiseTypeKindSetENT">目标对象</param>
 public static void CopyTo(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetENS, clsAppraiseTypeKindSetEN objAppraiseTypeKindSetENT)
{
try
{
objAppraiseTypeKindSetENT.mId = objAppraiseTypeKindSetENS.mId; //mId
objAppraiseTypeKindSetENT.id_School = objAppraiseTypeKindSetENS.id_School; //学校流水号
objAppraiseTypeKindSetENT.FuncModuleId = objAppraiseTypeKindSetENS.FuncModuleId; //功能模块Id
objAppraiseTypeKindSetENT.id_AppraiseType = objAppraiseTypeKindSetENS.id_AppraiseType; //评议类型流水号
objAppraiseTypeKindSetENT.AppraiseKindId = objAppraiseTypeKindSetENS.AppraiseKindId; //评议种类Id
objAppraiseTypeKindSetENT.InEffect = objAppraiseTypeKindSetENS.InEffect; //是否有效
objAppraiseTypeKindSetENT.UpdDate = objAppraiseTypeKindSetENS.UpdDate; //修改日期
objAppraiseTypeKindSetENT.UpdUserId = objAppraiseTypeKindSetENS.UpdUserId; //修改用户Id
objAppraiseTypeKindSetENT.Memo = objAppraiseTypeKindSetENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsAppraiseTypeKindSetEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsAppraiseTypeKindSetEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsAppraiseTypeKindSetEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsAppraiseTypeKindSetEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsAppraiseTypeKindSetEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsAppraiseTypeKindSetEN.AttributeName)
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
if (clsAppraiseTypeKindSetWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeKindSetWApi没有刷新缓存机制(clsAppraiseTypeKindSetWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrAppraiseTypeKindSetObjLst_Cache == null)
//{
//arrAppraiseTypeKindSetObjLst_Cache = await clsAppraiseTypeKindSetWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsAppraiseTypeKindSetEN._CurrTabName_S);
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
if (clsAppraiseTypeKindSetWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAppraiseTypeKindSetEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsAppraiseTypeKindSetWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAppraiseTypeKindSetEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsAppraiseTypeKindSetEN._CurrTabName_S);
List<clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrAppraiseTypeKindSetObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsAppraiseTypeKindSetEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conAppraiseTypeKindSet.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conAppraiseTypeKindSet.id_School, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseTypeKindSet.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseTypeKindSet.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseTypeKindSet.AppraiseKindId, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseTypeKindSet.InEffect, Type.GetType("System.Boolean"));
objDT.Columns.Add(conAppraiseTypeKindSet.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseTypeKindSet.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseTypeKindSet.Memo, Type.GetType("System.String"));
foreach (clsAppraiseTypeKindSetEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conAppraiseTypeKindSet.mId] = objInFor[conAppraiseTypeKindSet.mId];
objDR[conAppraiseTypeKindSet.id_School] = objInFor[conAppraiseTypeKindSet.id_School];
objDR[conAppraiseTypeKindSet.FuncModuleId] = objInFor[conAppraiseTypeKindSet.FuncModuleId];
objDR[conAppraiseTypeKindSet.id_AppraiseType] = objInFor[conAppraiseTypeKindSet.id_AppraiseType];
objDR[conAppraiseTypeKindSet.AppraiseKindId] = objInFor[conAppraiseTypeKindSet.AppraiseKindId];
objDR[conAppraiseTypeKindSet.InEffect] = objInFor[conAppraiseTypeKindSet.InEffect];
objDR[conAppraiseTypeKindSet.UpdDate] = objInFor[conAppraiseTypeKindSet.UpdDate];
objDR[conAppraiseTypeKindSet.UpdUserId] = objInFor[conAppraiseTypeKindSet.UpdUserId];
objDR[conAppraiseTypeKindSet.Memo] = objInFor[conAppraiseTypeKindSet.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 评议类型种类设置(AppraiseTypeKindSet)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4AppraiseTypeKindSet : clsCommFun4BL
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
clsAppraiseTypeKindSetWApi.ReFreshThisCache();
}
}

}