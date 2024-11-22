
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSetFieldVisibilityWApi
 表名:SetFieldVisibility(01120119)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:14
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
public static class clsSetFieldVisibilityWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetmId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, long lngmId, string strComparisonOp="")
	{
objSetFieldVisibilityEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.mId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.mId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.mId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN Setid_School(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, conSetFieldVisibility.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, conSetFieldVisibility.id_School);
objSetFieldVisibilityEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.id_School) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.id_School, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.id_School] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetFuncModuleId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conSetFieldVisibility.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conSetFieldVisibility.FuncModuleId);
objSetFieldVisibilityEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.FuncModuleId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.FuncModuleId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.FuncModuleId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetUserId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, conSetFieldVisibility.UserId);
objSetFieldVisibilityEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.UserId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.UserId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.UserId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetViewName(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewName, 50, conSetFieldVisibility.ViewName);
objSetFieldVisibilityEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.ViewName) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.ViewName, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.ViewName] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetFieldName(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldName, conSetFieldVisibility.FieldName);
clsCheckSql.CheckFieldLen(strFieldName, 50, conSetFieldVisibility.FieldName);
objSetFieldVisibilityEN.FieldName = strFieldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.FieldName) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.FieldName, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.FieldName] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetCaption(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaption, 200, conSetFieldVisibility.Caption);
objSetFieldVisibilityEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.Caption) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.Caption, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.Caption] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetCtrlType(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strCtrlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtrlType, conSetFieldVisibility.CtrlType);
clsCheckSql.CheckFieldLen(strCtrlType, 50, conSetFieldVisibility.CtrlType);
objSetFieldVisibilityEN.CtrlType = strCtrlType; //控件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.CtrlType) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.CtrlType, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.CtrlType] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetIsVisible(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, bool bolIsVisible, string strComparisonOp="")
	{
objSetFieldVisibilityEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.IsVisible) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.IsVisible, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.IsVisible] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetUpdDate(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSetFieldVisibility.UpdDate);
objSetFieldVisibilityEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.UpdDate) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.UpdDate, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.UpdDate] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetUpdUserId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSetFieldVisibility.UpdUserId);
objSetFieldVisibilityEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.UpdUserId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.UpdUserId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.UpdUserId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSetFieldVisibilityEN SetMemo(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSetFieldVisibility.Memo);
objSetFieldVisibilityEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.Memo) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.Memo, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.Memo] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSetFieldVisibilityEN objSetFieldVisibility_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.mId) == true)
{
string strComparisonOp_mId = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conSetFieldVisibility.mId, objSetFieldVisibility_Cond.mId, strComparisonOp_mId);
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.id_School) == true)
{
string strComparisonOp_id_School = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.id_School, objSetFieldVisibility_Cond.id_School, strComparisonOp_id_School);
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.FuncModuleId, objSetFieldVisibility_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.UserId) == true)
{
string strComparisonOp_UserId = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.UserId, objSetFieldVisibility_Cond.UserId, strComparisonOp_UserId);
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.ViewName) == true)
{
string strComparisonOp_ViewName = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.ViewName, objSetFieldVisibility_Cond.ViewName, strComparisonOp_ViewName);
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.FieldName) == true)
{
string strComparisonOp_FieldName = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.FieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.FieldName, objSetFieldVisibility_Cond.FieldName, strComparisonOp_FieldName);
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.Caption) == true)
{
string strComparisonOp_Caption = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.Caption, objSetFieldVisibility_Cond.Caption, strComparisonOp_Caption);
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.CtrlType) == true)
{
string strComparisonOp_CtrlType = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.CtrlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.CtrlType, objSetFieldVisibility_Cond.CtrlType, strComparisonOp_CtrlType);
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.IsVisible) == true)
{
if (objSetFieldVisibility_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSetFieldVisibility.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSetFieldVisibility.IsVisible);
}
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.UpdDate) == true)
{
string strComparisonOp_UpdDate = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.UpdDate, objSetFieldVisibility_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.UpdUserId, objSetFieldVisibility_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objSetFieldVisibility_Cond.IsUpdated(conSetFieldVisibility.Memo) == true)
{
string strComparisonOp_Memo = objSetFieldVisibility_Cond.dicFldComparisonOp[conSetFieldVisibility.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.Memo, objSetFieldVisibility_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 if (objSetFieldVisibilityEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSetFieldVisibilityEN.sf_UpdFldSetStr = objSetFieldVisibilityEN.getsf_UpdFldSetStr();
clsSetFieldVisibilityWApi.CheckPropertyNew(objSetFieldVisibilityEN); 
bool bolResult = clsSetFieldVisibilityWApi.UpdateRecord(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityWApi.ReFreshCache();
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
try
{
clsSetFieldVisibilityWApi.CheckPropertyNew(objSetFieldVisibilityEN); 
bool bolResult = clsSetFieldVisibilityWApi.AddNewRecord(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityWApi.ReFreshCache();
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
 /// <param name = "objSetFieldVisibilityEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strWhereCond)
{
try
{
clsSetFieldVisibilityWApi.CheckPropertyNew(objSetFieldVisibilityEN); 
bool bolResult = clsSetFieldVisibilityWApi.UpdateWithCondition(objSetFieldVisibilityEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityWApi.ReFreshCache();
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
 /// 设置字段可视性(SetFieldVisibility)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSetFieldVisibilityWApi
{
private static readonly string mstrApiControllerName = "SetFieldVisibilityApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsSetFieldVisibilityWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
if (!Object.Equals(null, objSetFieldVisibilityEN.id_School) && GetStrLen(objSetFieldVisibilityEN.id_School) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.FuncModuleId) && GetStrLen(objSetFieldVisibilityEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.UserId) && GetStrLen(objSetFieldVisibilityEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.ViewName) && GetStrLen(objSetFieldVisibilityEN.ViewName) > 50)
{
 throw new Exception("字段[界面名称]的长度不能超过50!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.FieldName) && GetStrLen(objSetFieldVisibilityEN.FieldName) > 50)
{
 throw new Exception("字段[字段名]的长度不能超过50!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.Caption) && GetStrLen(objSetFieldVisibilityEN.Caption) > 200)
{
 throw new Exception("字段[标题]的长度不能超过200!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.CtrlType) && GetStrLen(objSetFieldVisibilityEN.CtrlType) > 50)
{
 throw new Exception("字段[控件类型]的长度不能超过50!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.UpdDate) && GetStrLen(objSetFieldVisibilityEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.UpdUserId) && GetStrLen(objSetFieldVisibilityEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.Memo) && GetStrLen(objSetFieldVisibilityEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objSetFieldVisibilityEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSetFieldVisibilityEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsSetFieldVisibilityEN objSetFieldVisibilityEN = null;
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
objSetFieldVisibilityEN = JsonConvert.DeserializeObject<clsSetFieldVisibilityEN>((string)jobjReturn["ReturnObj"]);
return objSetFieldVisibilityEN;
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
public static clsSetFieldVisibilityEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsSetFieldVisibilityEN objSetFieldVisibilityEN = null;
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
objSetFieldVisibilityEN = JsonConvert.DeserializeObject<clsSetFieldVisibilityEN>((string)jobjReturn["ReturnObj"]);
return objSetFieldVisibilityEN;
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
public static clsSetFieldVisibilityEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsSetFieldVisibilityEN objSetFieldVisibilityEN = null;
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
objSetFieldVisibilityEN = JsonConvert.DeserializeObject<clsSetFieldVisibilityEN>((string)jobjReturn["ReturnObj"]);
return objSetFieldVisibilityEN;
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
public static clsSetFieldVisibilityEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName_S);
List<clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLst_Sel =
from objSetFieldVisibilityEN in arrSetFieldVisibilityObjLst_Cache
where objSetFieldVisibilityEN.mId == lngmId
select objSetFieldVisibilityEN;
if (arrSetFieldVisibilityObjLst_Sel.Count() == 0)
{
   clsSetFieldVisibilityEN obj = clsSetFieldVisibilityWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrSetFieldVisibilityObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSetFieldVisibilityEN> GetObjLst(string strWhereCond)
{
 List<clsSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsSetFieldVisibilityEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName_S);
List<clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLst_Sel =
from objSetFieldVisibilityEN in arrSetFieldVisibilityObjLst_Cache
where arrMId.Contains(objSetFieldVisibilityEN.mId)
select objSetFieldVisibilityEN;
return arrSetFieldVisibilityObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSetFieldVisibilityEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSetFieldVisibilityEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clsSetFieldVisibilityEN objSetFieldVisibilityEN = clsSetFieldVisibilityWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsSetFieldVisibilityWApi.ReFreshCache();
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
public static int DelSetFieldVisibilitys(List<string> arrmId)
{
string strAction = "DelSetFieldVisibilitys";
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
clsSetFieldVisibilityWApi.ReFreshCache();
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
public static int DelSetFieldVisibilitysByCond(string strWhereCond)
{
string strAction = "DelSetFieldVisibilitysByCond";
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
public static bool AddNewRecord(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSetFieldVisibilityEN>(objSetFieldVisibilityEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityWApi.ReFreshCache();
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSetFieldVisibilityEN>(objSetFieldVisibilityEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityWApi.ReFreshCache();
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
public static bool UpdateRecord(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
if (string.IsNullOrEmpty(objSetFieldVisibilityEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSetFieldVisibilityEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSetFieldVisibilityEN>(objSetFieldVisibilityEN);
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
 /// <param name = "objSetFieldVisibilityEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSetFieldVisibilityEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSetFieldVisibilityEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSetFieldVisibilityEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSetFieldVisibilityEN>(objSetFieldVisibilityEN);
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
 /// <param name = "objSetFieldVisibilityENS">源对象</param>
 /// <param name = "objSetFieldVisibilityENT">目标对象</param>
 public static void CopyTo(clsSetFieldVisibilityEN objSetFieldVisibilityENS, clsSetFieldVisibilityEN objSetFieldVisibilityENT)
{
try
{
objSetFieldVisibilityENT.mId = objSetFieldVisibilityENS.mId; //mId
objSetFieldVisibilityENT.id_School = objSetFieldVisibilityENS.id_School; //学校流水号
objSetFieldVisibilityENT.FuncModuleId = objSetFieldVisibilityENS.FuncModuleId; //功能模块Id
objSetFieldVisibilityENT.UserId = objSetFieldVisibilityENS.UserId; //用户ID
objSetFieldVisibilityENT.ViewName = objSetFieldVisibilityENS.ViewName; //界面名称
objSetFieldVisibilityENT.FieldName = objSetFieldVisibilityENS.FieldName; //字段名
objSetFieldVisibilityENT.Caption = objSetFieldVisibilityENS.Caption; //标题
objSetFieldVisibilityENT.CtrlType = objSetFieldVisibilityENS.CtrlType; //控件类型
objSetFieldVisibilityENT.IsVisible = objSetFieldVisibilityENS.IsVisible; //是否显示
objSetFieldVisibilityENT.UpdDate = objSetFieldVisibilityENS.UpdDate; //修改日期
objSetFieldVisibilityENT.UpdUserId = objSetFieldVisibilityENS.UpdUserId; //修改用户Id
objSetFieldVisibilityENT.Memo = objSetFieldVisibilityENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsSetFieldVisibilityEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSetFieldVisibilityEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSetFieldVisibilityEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSetFieldVisibilityEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSetFieldVisibilityEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSetFieldVisibilityEN.AttributeName)
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
if (clsSetFieldVisibilityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSetFieldVisibilityWApi没有刷新缓存机制(clsSetFieldVisibilityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrSetFieldVisibilityObjLst_Cache == null)
//{
//arrSetFieldVisibilityObjLst_Cache = await clsSetFieldVisibilityWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName_S);
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
if (clsSetFieldVisibilityWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsSetFieldVisibilityWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSetFieldVisibilityEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName_S);
List<clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSetFieldVisibilityObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsSetFieldVisibilityEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSetFieldVisibility.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conSetFieldVisibility.id_School, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.FieldName, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.Caption, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.CtrlType, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conSetFieldVisibility.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.Memo, Type.GetType("System.String"));
foreach (clsSetFieldVisibilityEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSetFieldVisibility.mId] = objInFor[conSetFieldVisibility.mId];
objDR[conSetFieldVisibility.id_School] = objInFor[conSetFieldVisibility.id_School];
objDR[conSetFieldVisibility.FuncModuleId] = objInFor[conSetFieldVisibility.FuncModuleId];
objDR[conSetFieldVisibility.UserId] = objInFor[conSetFieldVisibility.UserId];
objDR[conSetFieldVisibility.ViewName] = objInFor[conSetFieldVisibility.ViewName];
objDR[conSetFieldVisibility.FieldName] = objInFor[conSetFieldVisibility.FieldName];
objDR[conSetFieldVisibility.Caption] = objInFor[conSetFieldVisibility.Caption];
objDR[conSetFieldVisibility.CtrlType] = objInFor[conSetFieldVisibility.CtrlType];
objDR[conSetFieldVisibility.IsVisible] = objInFor[conSetFieldVisibility.IsVisible];
objDR[conSetFieldVisibility.UpdDate] = objInFor[conSetFieldVisibility.UpdDate];
objDR[conSetFieldVisibility.UpdUserId] = objInFor[conSetFieldVisibility.UpdUserId];
objDR[conSetFieldVisibility.Memo] = objInFor[conSetFieldVisibility.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 设置字段可视性(SetFieldVisibility)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4SetFieldVisibility : clsCommFun4BL
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
clsSetFieldVisibilityWApi.ReFreshThisCache();
clsvSetFieldVisibilityWApi.ReFreshThisCache();
}
}

}