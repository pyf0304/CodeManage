
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingActivityTypeWApi
 表名:TeachingActivityType(01120523)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:11
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学
 模块英文名:ClsRmTeaching
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
public static class clsTeachingActivityTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetTeachingActivityTypeId(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strTeachingActivityTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingActivityTypeId, 2, conTeachingActivityType.TeachingActivityTypeId);
clsCheckSql.CheckFieldForeignKey(strTeachingActivityTypeId, 2, conTeachingActivityType.TeachingActivityTypeId);
objTeachingActivityTypeEN.TeachingActivityTypeId = strTeachingActivityTypeId; //教学活动类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.TeachingActivityTypeId) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.TeachingActivityTypeId, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.TeachingActivityTypeId] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetTeachingActivityTypeName(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strTeachingActivityTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingActivityTypeName, conTeachingActivityType.TeachingActivityTypeName);
clsCheckSql.CheckFieldLen(strTeachingActivityTypeName, 30, conTeachingActivityType.TeachingActivityTypeName);
objTeachingActivityTypeEN.TeachingActivityTypeName = strTeachingActivityTypeName; //教学活动类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.TeachingActivityTypeName) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.TeachingActivityTypeName, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.TeachingActivityTypeName] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetIsSummaryField(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, bool bolIsSummaryField, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSummaryField, conTeachingActivityType.IsSummaryField);
objTeachingActivityTypeEN.IsSummaryField = bolIsSummaryField; //是否汇总字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.IsSummaryField) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.IsSummaryField, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.IsSummaryField] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetUseMedia(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strUseMedia, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseMedia, conTeachingActivityType.UseMedia);
clsCheckSql.CheckFieldLen(strUseMedia, 30, conTeachingActivityType.UseMedia);
objTeachingActivityTypeEN.UseMedia = strUseMedia; //使用媒体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.UseMedia) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.UseMedia, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.UseMedia] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetFuncModuleId(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conTeachingActivityType.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conTeachingActivityType.FuncModuleId);
objTeachingActivityTypeEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.FuncModuleId) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.FuncModuleId, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.FuncModuleId] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN Setid_MicroteachCase(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, conTeachingActivityType.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, conTeachingActivityType.id_MicroteachCase);
objTeachingActivityTypeEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.id_MicroteachCase) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.id_MicroteachCase, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.id_MicroteachCase] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetCaseName(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, conTeachingActivityType.CaseName);
objTeachingActivityTypeEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.CaseName) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.CaseName, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.CaseName] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetOwnerId(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conTeachingActivityType.OwnerId);
objTeachingActivityTypeEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.OwnerId) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.OwnerId, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.OwnerId] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN Setid_School(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, conTeachingActivityType.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, conTeachingActivityType.id_School);
objTeachingActivityTypeEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.id_School) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.id_School, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.id_School] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetOrderNum(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, int intOrderNum, string strComparisonOp="")
	{
objTeachingActivityTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.OrderNum) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.OrderNum, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.OrderNum] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetUpdDate(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTeachingActivityType.UpdDate);
objTeachingActivityTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.UpdDate) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.UpdDate, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.UpdDate] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetUpdUserId(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conTeachingActivityType.UpdUserId);
objTeachingActivityTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.UpdUserId) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.UpdUserId, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.UpdUserId] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingActivityTypeEN SetMemo(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeachingActivityType.Memo);
objTeachingActivityTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(conTeachingActivityType.Memo) == false)
{
objTeachingActivityTypeEN.dicFldComparisonOp.Add(conTeachingActivityType.Memo, strComparisonOp);
}
else
{
objTeachingActivityTypeEN.dicFldComparisonOp[conTeachingActivityType.Memo] = strComparisonOp;
}
}
return objTeachingActivityTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeachingActivityTypeEN objTeachingActivityType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.TeachingActivityTypeId) == true)
{
string strComparisonOp_TeachingActivityTypeId = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.TeachingActivityTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.TeachingActivityTypeId, objTeachingActivityType_Cond.TeachingActivityTypeId, strComparisonOp_TeachingActivityTypeId);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.TeachingActivityTypeName) == true)
{
string strComparisonOp_TeachingActivityTypeName = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.TeachingActivityTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.TeachingActivityTypeName, objTeachingActivityType_Cond.TeachingActivityTypeName, strComparisonOp_TeachingActivityTypeName);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.IsSummaryField) == true)
{
if (objTeachingActivityType_Cond.IsSummaryField == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachingActivityType.IsSummaryField);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachingActivityType.IsSummaryField);
}
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.UseMedia) == true)
{
string strComparisonOp_UseMedia = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.UseMedia];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.UseMedia, objTeachingActivityType_Cond.UseMedia, strComparisonOp_UseMedia);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.FuncModuleId, objTeachingActivityType_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.id_MicroteachCase, objTeachingActivityType_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.CaseName) == true)
{
string strComparisonOp_CaseName = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.CaseName, objTeachingActivityType_Cond.CaseName, strComparisonOp_CaseName);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.OwnerId) == true)
{
string strComparisonOp_OwnerId = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.OwnerId, objTeachingActivityType_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.id_School) == true)
{
string strComparisonOp_id_School = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.id_School, objTeachingActivityType_Cond.id_School, strComparisonOp_id_School);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.OrderNum) == true)
{
string strComparisonOp_OrderNum = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingActivityType.OrderNum, objTeachingActivityType_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.UpdDate) == true)
{
string strComparisonOp_UpdDate = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.UpdDate, objTeachingActivityType_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.UpdUserId, objTeachingActivityType_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objTeachingActivityType_Cond.IsUpdated(conTeachingActivityType.Memo) == true)
{
string strComparisonOp_Memo = objTeachingActivityType_Cond.dicFldComparisonOp[conTeachingActivityType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingActivityType.Memo, objTeachingActivityType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
 if (string.IsNullOrEmpty(objTeachingActivityTypeEN.TeachingActivityTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTeachingActivityTypeEN.sf_UpdFldSetStr = objTeachingActivityTypeEN.getsf_UpdFldSetStr();
clsTeachingActivityTypeWApi.CheckPropertyNew(objTeachingActivityTypeEN); 
bool bolResult = clsTeachingActivityTypeWApi.UpdateRecord(objTeachingActivityTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingActivityTypeWApi.ReFreshCache();
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
 /// <param name = "objTeachingActivityTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
 if (string.IsNullOrEmpty(objTeachingActivityTypeEN.TeachingActivityTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTeachingActivityTypeWApi.IsExist(objTeachingActivityTypeEN.TeachingActivityTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objTeachingActivityTypeEN.TeachingActivityTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsTeachingActivityTypeWApi.CheckPropertyNew(objTeachingActivityTypeEN); 
bool bolResult = clsTeachingActivityTypeWApi.AddNewRecord(objTeachingActivityTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingActivityTypeWApi.ReFreshCache();
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
 /// <param name = "objTeachingActivityTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
try
{
clsTeachingActivityTypeWApi.CheckPropertyNew(objTeachingActivityTypeEN); 
string strTeachingActivityTypeId = clsTeachingActivityTypeWApi.AddNewRecordWithMaxId(objTeachingActivityTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingActivityTypeWApi.ReFreshCache();
return strTeachingActivityTypeId;
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
 /// <param name = "objTeachingActivityTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strWhereCond)
{
try
{
clsTeachingActivityTypeWApi.CheckPropertyNew(objTeachingActivityTypeEN); 
bool bolResult = clsTeachingActivityTypeWApi.UpdateWithCondition(objTeachingActivityTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingActivityTypeWApi.ReFreshCache();
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
 /// 教学活动类型(TeachingActivityType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTeachingActivityTypeWApi
{
private static readonly string mstrApiControllerName = "TeachingActivityTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsTeachingActivityTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TeachingActivityTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[教学活动类型]...","0");
List<clsTeachingActivityTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TeachingActivityTypeId";
objDDL.DataTextField="TeachingActivityTypeName";
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
public static void BindCbo_TeachingActivityTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conTeachingActivityType.TeachingActivityTypeId); 
List<clsTeachingActivityTypeEN> arrObjLst = clsTeachingActivityTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsTeachingActivityTypeEN objTeachingActivityTypeEN = new clsTeachingActivityTypeEN()
{
TeachingActivityTypeId = "0",
TeachingActivityTypeName = "选[教学活动类型]..."
};
arrObjLst.Insert(0, objTeachingActivityTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conTeachingActivityType.TeachingActivityTypeId;
objComboBox.DisplayMember = conTeachingActivityType.TeachingActivityTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
if (!Object.Equals(null, objTeachingActivityTypeEN.TeachingActivityTypeId) && GetStrLen(objTeachingActivityTypeEN.TeachingActivityTypeId) > 2)
{
 throw new Exception("字段[教学活动类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTeachingActivityTypeEN.TeachingActivityTypeName) && GetStrLen(objTeachingActivityTypeEN.TeachingActivityTypeName) > 30)
{
 throw new Exception("字段[教学活动类型名称]的长度不能超过30!");
}
if (!Object.Equals(null, objTeachingActivityTypeEN.UseMedia) && GetStrLen(objTeachingActivityTypeEN.UseMedia) > 30)
{
 throw new Exception("字段[使用媒体]的长度不能超过30!");
}
if (!Object.Equals(null, objTeachingActivityTypeEN.FuncModuleId) && GetStrLen(objTeachingActivityTypeEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachingActivityTypeEN.id_MicroteachCase) && GetStrLen(objTeachingActivityTypeEN.id_MicroteachCase) > 8)
{
 throw new Exception("字段[微格教学案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingActivityTypeEN.CaseName) && GetStrLen(objTeachingActivityTypeEN.CaseName) > 100)
{
 throw new Exception("字段[案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objTeachingActivityTypeEN.OwnerId) && GetStrLen(objTeachingActivityTypeEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingActivityTypeEN.id_School) && GetStrLen(objTeachingActivityTypeEN.id_School) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachingActivityTypeEN.UpdDate) && GetStrLen(objTeachingActivityTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingActivityTypeEN.UpdUserId) && GetStrLen(objTeachingActivityTypeEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingActivityTypeEN.Memo) && GetStrLen(objTeachingActivityTypeEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objTeachingActivityTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingActivityTypeEN GetObjByTeachingActivityTypeId(string strTeachingActivityTypeId)
{
string strAction = "GetObjByTeachingActivityTypeId";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingActivityTypeEN objTeachingActivityTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingActivityTypeId"] = strTeachingActivityTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objTeachingActivityTypeEN = JsonConvert.DeserializeObject<clsTeachingActivityTypeEN>((string)jobjReturn["ReturnObj"]);
return objTeachingActivityTypeEN;
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
 /// <param name = "strTeachingActivityTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingActivityTypeEN GetObjByTeachingActivityTypeId_WA_Cache(string strTeachingActivityTypeId)
{
string strAction = "GetObjByTeachingActivityTypeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingActivityTypeEN objTeachingActivityTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingActivityTypeId"] = strTeachingActivityTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objTeachingActivityTypeEN = JsonConvert.DeserializeObject<clsTeachingActivityTypeEN>((string)jobjReturn["ReturnObj"]);
return objTeachingActivityTypeEN;
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
public static clsTeachingActivityTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingActivityTypeEN objTeachingActivityTypeEN = null;
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
objTeachingActivityTypeEN = JsonConvert.DeserializeObject<clsTeachingActivityTypeEN>((string)jobjReturn["ReturnObj"]);
return objTeachingActivityTypeEN;
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
 /// <param name = "strTeachingActivityTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachingActivityTypeEN GetObjByTeachingActivityTypeId_Cache(string strTeachingActivityTypeId)
{
if (string.IsNullOrEmpty(strTeachingActivityTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachingActivityTypeEN._CurrTabName_S);
List<clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Sel =
from objTeachingActivityTypeEN in arrTeachingActivityTypeObjLst_Cache
where objTeachingActivityTypeEN.TeachingActivityTypeId == strTeachingActivityTypeId
select objTeachingActivityTypeEN;
if (arrTeachingActivityTypeObjLst_Sel.Count() == 0)
{
   clsTeachingActivityTypeEN obj = clsTeachingActivityTypeWApi.GetObjByTeachingActivityTypeId(strTeachingActivityTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTeachingActivityTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeachingActivityTypeNameByTeachingActivityTypeId_Cache(string strTeachingActivityTypeId)
{
if (string.IsNullOrEmpty(strTeachingActivityTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachingActivityTypeEN._CurrTabName_S);
List<clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Sel1 =
from objTeachingActivityTypeEN in arrTeachingActivityTypeObjLst_Cache
where objTeachingActivityTypeEN.TeachingActivityTypeId == strTeachingActivityTypeId
select objTeachingActivityTypeEN;
List <clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Sel = new List<clsTeachingActivityTypeEN>();
foreach (clsTeachingActivityTypeEN obj in arrTeachingActivityTypeObjLst_Sel1)
{
arrTeachingActivityTypeObjLst_Sel.Add(obj);
}
if (arrTeachingActivityTypeObjLst_Sel.Count > 0)
{
return arrTeachingActivityTypeObjLst_Sel[0].TeachingActivityTypeName;
}
string strErrMsgForGetObjById = string.Format("在TeachingActivityType对象缓存列表中,找不到记录[TeachingActivityTypeId = {0}](函数:{1})", strTeachingActivityTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTeachingActivityTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTeachingActivityTypeId_Cache(string strTeachingActivityTypeId)
{
if (string.IsNullOrEmpty(strTeachingActivityTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachingActivityTypeEN._CurrTabName_S);
List<clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Sel1 =
from objTeachingActivityTypeEN in arrTeachingActivityTypeObjLst_Cache
where objTeachingActivityTypeEN.TeachingActivityTypeId == strTeachingActivityTypeId
select objTeachingActivityTypeEN;
List <clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Sel = new List<clsTeachingActivityTypeEN>();
foreach (clsTeachingActivityTypeEN obj in arrTeachingActivityTypeObjLst_Sel1)
{
arrTeachingActivityTypeObjLst_Sel.Add(obj);
}
if (arrTeachingActivityTypeObjLst_Sel.Count > 0)
{
return arrTeachingActivityTypeObjLst_Sel[0].TeachingActivityTypeName;
}
string strErrMsgForGetObjById = string.Format("在TeachingActivityType对象缓存列表中,找不到记录的相关名称[TeachingActivityTypeId = {0}](函数:{1})", strTeachingActivityTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTeachingActivityTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingActivityTypeEN> GetObjLst(string strWhereCond)
{
 List<clsTeachingActivityTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingActivityTypeEN> GetObjLstByTeachingActivityTypeIdLst(List<string> arrTeachingActivityTypeId)
{
 List<clsTeachingActivityTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByTeachingActivityTypeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTeachingActivityTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strTeachingActivityTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsTeachingActivityTypeEN> GetObjLstByTeachingActivityTypeIdLst_Cache(List<string> arrTeachingActivityTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachingActivityTypeEN._CurrTabName_S);
List<clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Sel =
from objTeachingActivityTypeEN in arrTeachingActivityTypeObjLst_Cache
where arrTeachingActivityTypeId.Contains(objTeachingActivityTypeEN.TeachingActivityTypeId)
select objTeachingActivityTypeEN;
return arrTeachingActivityTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingActivityTypeEN> GetObjLstByTeachingActivityTypeIdLst_WA_Cache(List<string> arrTeachingActivityTypeId)
{
 List<clsTeachingActivityTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByTeachingActivityTypeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTeachingActivityTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingActivityTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTeachingActivityTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingActivityTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTeachingActivityTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingActivityTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTeachingActivityTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingActivityTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsTeachingActivityTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strTeachingActivityTypeId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsTeachingActivityTypeEN objTeachingActivityTypeEN = clsTeachingActivityTypeWApi.GetObjByTeachingActivityTypeId(strTeachingActivityTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strTeachingActivityTypeId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeachingActivityTypeWApi.ReFreshCache();
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
public static int DelTeachingActivityTypes(List<string> arrTeachingActivityTypeId)
{
string strAction = "DelTeachingActivityTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTeachingActivityTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeachingActivityTypeWApi.ReFreshCache();
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
public static int DelTeachingActivityTypesByCond(string strWhereCond)
{
string strAction = "DelTeachingActivityTypesByCond";
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
public static bool AddNewRecord(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingActivityTypeEN>(objTeachingActivityTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingActivityTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingActivityTypeEN>(objTeachingActivityTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingActivityTypeWApi.ReFreshCache();
var strTeachingActivityTypeId = (string)jobjReturn["ReturnStr"];
return strTeachingActivityTypeId;
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
public static bool UpdateRecord(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
if (string.IsNullOrEmpty(objTeachingActivityTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingActivityTypeEN.TeachingActivityTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingActivityTypeEN>(objTeachingActivityTypeEN);
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
 /// <param name = "objTeachingActivityTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTeachingActivityTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingActivityTypeEN.TeachingActivityTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingActivityTypeEN.TeachingActivityTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingActivityTypeEN>(objTeachingActivityTypeEN);
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
public static bool IsExist(string strTeachingActivityTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingActivityTypeId"] = strTeachingActivityTypeId
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
 /// <param name = "objTeachingActivityTypeENS">源对象</param>
 /// <param name = "objTeachingActivityTypeENT">目标对象</param>
 public static void CopyTo(clsTeachingActivityTypeEN objTeachingActivityTypeENS, clsTeachingActivityTypeEN objTeachingActivityTypeENT)
{
try
{
objTeachingActivityTypeENT.TeachingActivityTypeId = objTeachingActivityTypeENS.TeachingActivityTypeId; //教学活动类型Id
objTeachingActivityTypeENT.TeachingActivityTypeName = objTeachingActivityTypeENS.TeachingActivityTypeName; //教学活动类型名称
objTeachingActivityTypeENT.IsSummaryField = objTeachingActivityTypeENS.IsSummaryField; //是否汇总字段
objTeachingActivityTypeENT.UseMedia = objTeachingActivityTypeENS.UseMedia; //使用媒体
objTeachingActivityTypeENT.FuncModuleId = objTeachingActivityTypeENS.FuncModuleId; //功能模块Id
objTeachingActivityTypeENT.id_MicroteachCase = objTeachingActivityTypeENS.id_MicroteachCase; //微格教学案例流水号
objTeachingActivityTypeENT.CaseName = objTeachingActivityTypeENS.CaseName; //案例名称
objTeachingActivityTypeENT.OwnerId = objTeachingActivityTypeENS.OwnerId; //拥有者Id
objTeachingActivityTypeENT.id_School = objTeachingActivityTypeENS.id_School; //学校流水号
objTeachingActivityTypeENT.OrderNum = objTeachingActivityTypeENS.OrderNum; //序号
objTeachingActivityTypeENT.UpdDate = objTeachingActivityTypeENS.UpdDate; //修改日期
objTeachingActivityTypeENT.UpdUserId = objTeachingActivityTypeENS.UpdUserId; //修改用户Id
objTeachingActivityTypeENT.Memo = objTeachingActivityTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsTeachingActivityTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTeachingActivityTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTeachingActivityTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTeachingActivityTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTeachingActivityTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTeachingActivityTypeEN.AttributeName)
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
if (clsTeachingActivityTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingActivityTypeWApi没有刷新缓存机制(clsTeachingActivityTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TeachingActivityTypeId");
//if (arrTeachingActivityTypeObjLst_Cache == null)
//{
//arrTeachingActivityTypeObjLst_Cache = await clsTeachingActivityTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsTeachingActivityTypeEN._CurrTabName_S);
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
if (clsTeachingActivityTypeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTeachingActivityTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsTeachingActivityTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachingActivityTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsTeachingActivityTypeEN._CurrTabName_S);
List<clsTeachingActivityTypeEN> arrTeachingActivityTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTeachingActivityTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTeachingActivityTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTeachingActivityType.TeachingActivityTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingActivityType.TeachingActivityTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingActivityType.IsSummaryField, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeachingActivityType.UseMedia, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingActivityType.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingActivityType.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingActivityType.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingActivityType.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingActivityType.id_School, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingActivityType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conTeachingActivityType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingActivityType.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingActivityType.Memo, Type.GetType("System.String"));
foreach (clsTeachingActivityTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTeachingActivityType.TeachingActivityTypeId] = objInFor[conTeachingActivityType.TeachingActivityTypeId];
objDR[conTeachingActivityType.TeachingActivityTypeName] = objInFor[conTeachingActivityType.TeachingActivityTypeName];
objDR[conTeachingActivityType.IsSummaryField] = objInFor[conTeachingActivityType.IsSummaryField];
objDR[conTeachingActivityType.UseMedia] = objInFor[conTeachingActivityType.UseMedia];
objDR[conTeachingActivityType.FuncModuleId] = objInFor[conTeachingActivityType.FuncModuleId];
objDR[conTeachingActivityType.id_MicroteachCase] = objInFor[conTeachingActivityType.id_MicroteachCase];
objDR[conTeachingActivityType.CaseName] = objInFor[conTeachingActivityType.CaseName];
objDR[conTeachingActivityType.OwnerId] = objInFor[conTeachingActivityType.OwnerId];
objDR[conTeachingActivityType.id_School] = objInFor[conTeachingActivityType.id_School];
objDR[conTeachingActivityType.OrderNum] = objInFor[conTeachingActivityType.OrderNum];
objDR[conTeachingActivityType.UpdDate] = objInFor[conTeachingActivityType.UpdDate];
objDR[conTeachingActivityType.UpdUserId] = objInFor[conTeachingActivityType.UpdUserId];
objDR[conTeachingActivityType.Memo] = objInFor[conTeachingActivityType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 教学活动类型(TeachingActivityType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4TeachingActivityType : clsCommFun4BL
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
clsTeachingActivityTypeWApi.ReFreshThisCache();
}
}

}