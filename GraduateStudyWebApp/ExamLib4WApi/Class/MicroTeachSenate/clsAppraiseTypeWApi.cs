
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppraiseTypeWApi
 表名:AppraiseType(01120307)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:58
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
public static class clsAppraiseTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeEN Setid_AppraiseType(this clsAppraiseTypeEN objAppraiseTypeEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, conAppraiseType.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, conAppraiseType.id_AppraiseType);
objAppraiseTypeEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.id_AppraiseType) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.id_AppraiseType, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.id_AppraiseType] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeEN SetAppraiseTypeID(this clsAppraiseTypeEN objAppraiseTypeEN, string strAppraiseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeID, conAppraiseType.AppraiseTypeID);
clsCheckSql.CheckFieldLen(strAppraiseTypeID, 4, conAppraiseType.AppraiseTypeID);
clsCheckSql.CheckFieldForeignKey(strAppraiseTypeID, 4, conAppraiseType.AppraiseTypeID);
objAppraiseTypeEN.AppraiseTypeID = strAppraiseTypeID; //评议类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.AppraiseTypeID) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.AppraiseTypeID, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.AppraiseTypeID] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeEN SetAppraiseTypeName(this clsAppraiseTypeEN objAppraiseTypeEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeName, conAppraiseType.AppraiseTypeName);
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, conAppraiseType.AppraiseTypeName);
objAppraiseTypeEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.AppraiseTypeName) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.AppraiseTypeName, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.AppraiseTypeName] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeEN SetAppraiseTypeName4CW(this clsAppraiseTypeEN objAppraiseTypeEN, string strAppraiseTypeName4CW, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName4CW, 50, conAppraiseType.AppraiseTypeName4CW);
objAppraiseTypeEN.AppraiseTypeName4CW = strAppraiseTypeName4CW; //评议类型名称4课件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.AppraiseTypeName4CW) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.AppraiseTypeName4CW, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.AppraiseTypeName4CW] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeEN SetUserTypeId(this clsAppraiseTypeEN objAppraiseTypeEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserTypeId, conAppraiseType.UserTypeId);
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conAppraiseType.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conAppraiseType.UserTypeId);
objAppraiseTypeEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.UserTypeId) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.UserTypeId, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.UserTypeId] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeEN SetMemo(this clsAppraiseTypeEN objAppraiseTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAppraiseType.Memo);
objAppraiseTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.Memo) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.Memo, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.Memo] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeEN SetAppraiseTypeName_Sim(this clsAppraiseTypeEN objAppraiseTypeEN, string strAppraiseTypeName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName_Sim, 20, conAppraiseType.AppraiseTypeName_Sim);
objAppraiseTypeEN.AppraiseTypeName_Sim = strAppraiseTypeName_Sim; //评议类型名称_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.AppraiseTypeName_Sim) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.AppraiseTypeName_Sim, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.AppraiseTypeName_Sim] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAppraiseTypeEN SetOrderNum(this clsAppraiseTypeEN objAppraiseTypeEN, int intOrderNum, string strComparisonOp="")
	{
objAppraiseTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.OrderNum) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.OrderNum, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.OrderNum] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAppraiseTypeEN objAppraiseType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAppraiseType_Cond.IsUpdated(conAppraiseType.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objAppraiseType_Cond.dicFldComparisonOp[conAppraiseType.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.id_AppraiseType, objAppraiseType_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objAppraiseType_Cond.IsUpdated(conAppraiseType.AppraiseTypeID) == true)
{
string strComparisonOp_AppraiseTypeID = objAppraiseType_Cond.dicFldComparisonOp[conAppraiseType.AppraiseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.AppraiseTypeID, objAppraiseType_Cond.AppraiseTypeID, strComparisonOp_AppraiseTypeID);
}
if (objAppraiseType_Cond.IsUpdated(conAppraiseType.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objAppraiseType_Cond.dicFldComparisonOp[conAppraiseType.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.AppraiseTypeName, objAppraiseType_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objAppraiseType_Cond.IsUpdated(conAppraiseType.AppraiseTypeName4CW) == true)
{
string strComparisonOp_AppraiseTypeName4CW = objAppraiseType_Cond.dicFldComparisonOp[conAppraiseType.AppraiseTypeName4CW];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.AppraiseTypeName4CW, objAppraiseType_Cond.AppraiseTypeName4CW, strComparisonOp_AppraiseTypeName4CW);
}
if (objAppraiseType_Cond.IsUpdated(conAppraiseType.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objAppraiseType_Cond.dicFldComparisonOp[conAppraiseType.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.UserTypeId, objAppraiseType_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objAppraiseType_Cond.IsUpdated(conAppraiseType.Memo) == true)
{
string strComparisonOp_Memo = objAppraiseType_Cond.dicFldComparisonOp[conAppraiseType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.Memo, objAppraiseType_Cond.Memo, strComparisonOp_Memo);
}
if (objAppraiseType_Cond.IsUpdated(conAppraiseType.AppraiseTypeName_Sim) == true)
{
string strComparisonOp_AppraiseTypeName_Sim = objAppraiseType_Cond.dicFldComparisonOp[conAppraiseType.AppraiseTypeName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.AppraiseTypeName_Sim, objAppraiseType_Cond.AppraiseTypeName_Sim, strComparisonOp_AppraiseTypeName_Sim);
}
if (objAppraiseType_Cond.IsUpdated(conAppraiseType.OrderNum) == true)
{
string strComparisonOp_OrderNum = objAppraiseType_Cond.dicFldComparisonOp[conAppraiseType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conAppraiseType.OrderNum, objAppraiseType_Cond.OrderNum, strComparisonOp_OrderNum);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAppraiseTypeEN objAppraiseTypeEN)
{
 if (string.IsNullOrEmpty(objAppraiseTypeEN.id_AppraiseType) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objAppraiseTypeEN.sf_UpdFldSetStr = objAppraiseTypeEN.getsf_UpdFldSetStr();
clsAppraiseTypeWApi.CheckPropertyNew(objAppraiseTypeEN); 
bool bolResult = clsAppraiseTypeWApi.UpdateRecord(objAppraiseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeWApi.ReFreshCache();
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
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAppraiseTypeEN objAppraiseTypeEN)
{
 if (string.IsNullOrEmpty(objAppraiseTypeEN.id_AppraiseType) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAppraiseTypeWApi.IsExist(objAppraiseTypeEN.id_AppraiseType) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objAppraiseTypeEN.id_AppraiseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsAppraiseTypeWApi.CheckPropertyNew(objAppraiseTypeEN); 
bool bolResult = clsAppraiseTypeWApi.AddNewRecord(objAppraiseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeWApi.ReFreshCache();
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
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsAppraiseTypeEN objAppraiseTypeEN)
{
try
{
clsAppraiseTypeWApi.CheckPropertyNew(objAppraiseTypeEN); 
string strid_AppraiseType = clsAppraiseTypeWApi.AddNewRecordWithMaxId(objAppraiseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeWApi.ReFreshCache();
return strid_AppraiseType;
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
 /// <param name = "objAppraiseTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAppraiseTypeEN objAppraiseTypeEN, string strWhereCond)
{
try
{
clsAppraiseTypeWApi.CheckPropertyNew(objAppraiseTypeEN); 
bool bolResult = clsAppraiseTypeWApi.UpdateWithCondition(objAppraiseTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeWApi.ReFreshCache();
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
 /// 评价类型(AppraiseType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsAppraiseTypeWApi
{
private static readonly string mstrApiControllerName = "AppraiseTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsAppraiseTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_AppraiseType(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[评价类型]...","0");
List<clsAppraiseTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_AppraiseType";
objDDL.DataTextField="AppraiseTypeName";
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
public static void BindCbo_id_AppraiseType(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conAppraiseType.id_AppraiseType); 
List<clsAppraiseTypeEN> arrObjLst = clsAppraiseTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN()
{
id_AppraiseType = "0",
AppraiseTypeName = "选[评价类型]..."
};
arrObjLst.Insert(0, objAppraiseTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conAppraiseType.id_AppraiseType;
objComboBox.DisplayMember = conAppraiseType.AppraiseTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsAppraiseTypeEN objAppraiseTypeEN)
{
if (!Object.Equals(null, objAppraiseTypeEN.id_AppraiseType) && GetStrLen(objAppraiseTypeEN.id_AppraiseType) > 4)
{
 throw new Exception("字段[评议类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objAppraiseTypeEN.AppraiseTypeID) && GetStrLen(objAppraiseTypeEN.AppraiseTypeID) > 4)
{
 throw new Exception("字段[评议类型ID]的长度不能超过4!");
}
if (!Object.Equals(null, objAppraiseTypeEN.AppraiseTypeName) && GetStrLen(objAppraiseTypeEN.AppraiseTypeName) > 50)
{
 throw new Exception("字段[评议类型名称]的长度不能超过50!");
}
if (!Object.Equals(null, objAppraiseTypeEN.AppraiseTypeName4CW) && GetStrLen(objAppraiseTypeEN.AppraiseTypeName4CW) > 50)
{
 throw new Exception("字段[评议类型名称4课件]的长度不能超过50!");
}
if (!Object.Equals(null, objAppraiseTypeEN.UserTypeId) && GetStrLen(objAppraiseTypeEN.UserTypeId) > 2)
{
 throw new Exception("字段[用户类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objAppraiseTypeEN.Memo) && GetStrLen(objAppraiseTypeEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objAppraiseTypeEN.AppraiseTypeName_Sim) && GetStrLen(objAppraiseTypeEN.AppraiseTypeName_Sim) > 20)
{
 throw new Exception("字段[评议类型名称_Sim]的长度不能超过20!");
}
 objAppraiseTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_AppraiseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsAppraiseTypeEN GetObjByid_AppraiseType(string strid_AppraiseType)
{
string strAction = "GetObjByid_AppraiseType";
string strErrMsg = string.Empty;
string strResult = "";
clsAppraiseTypeEN objAppraiseTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_AppraiseType"] = strid_AppraiseType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objAppraiseTypeEN = JsonConvert.DeserializeObject<clsAppraiseTypeEN>((string)jobjReturn["ReturnObj"]);
return objAppraiseTypeEN;
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
 /// <param name = "strid_AppraiseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsAppraiseTypeEN GetObjByid_AppraiseType_WA_Cache(string strid_AppraiseType)
{
string strAction = "GetObjByid_AppraiseType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsAppraiseTypeEN objAppraiseTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_AppraiseType"] = strid_AppraiseType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objAppraiseTypeEN = JsonConvert.DeserializeObject<clsAppraiseTypeEN>((string)jobjReturn["ReturnObj"]);
return objAppraiseTypeEN;
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
public static clsAppraiseTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsAppraiseTypeEN objAppraiseTypeEN = null;
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
objAppraiseTypeEN = JsonConvert.DeserializeObject<clsAppraiseTypeEN>((string)jobjReturn["ReturnObj"]);
return objAppraiseTypeEN;
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
 /// <param name = "strid_AppraiseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAppraiseTypeEN GetObjByid_AppraiseType_Cache(string strid_AppraiseType)
{
if (string.IsNullOrEmpty(strid_AppraiseType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName_S);
List<clsAppraiseTypeEN> arrAppraiseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAppraiseTypeEN> arrAppraiseTypeObjLst_Sel =
from objAppraiseTypeEN in arrAppraiseTypeObjLst_Cache
where objAppraiseTypeEN.id_AppraiseType == strid_AppraiseType
select objAppraiseTypeEN;
if (arrAppraiseTypeObjLst_Sel.Count() == 0)
{
   clsAppraiseTypeEN obj = clsAppraiseTypeWApi.GetObjByid_AppraiseType(strid_AppraiseType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrAppraiseTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_AppraiseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetAppraiseTypeNameByid_AppraiseType_Cache(string strid_AppraiseType)
{
if (string.IsNullOrEmpty(strid_AppraiseType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName_S);
List<clsAppraiseTypeEN> arrAppraiseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAppraiseTypeEN> arrAppraiseTypeObjLst_Sel1 =
from objAppraiseTypeEN in arrAppraiseTypeObjLst_Cache
where objAppraiseTypeEN.id_AppraiseType == strid_AppraiseType
select objAppraiseTypeEN;
List <clsAppraiseTypeEN> arrAppraiseTypeObjLst_Sel = new List<clsAppraiseTypeEN>();
foreach (clsAppraiseTypeEN obj in arrAppraiseTypeObjLst_Sel1)
{
arrAppraiseTypeObjLst_Sel.Add(obj);
}
if (arrAppraiseTypeObjLst_Sel.Count > 0)
{
return arrAppraiseTypeObjLst_Sel[0].AppraiseTypeName;
}
string strErrMsgForGetObjById = string.Format("在AppraiseType对象缓存列表中,找不到记录[id_AppraiseType = {0}](函数:{1})", strid_AppraiseType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsAppraiseTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_AppraiseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_AppraiseType_Cache(string strid_AppraiseType)
{
if (string.IsNullOrEmpty(strid_AppraiseType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName_S);
List<clsAppraiseTypeEN> arrAppraiseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAppraiseTypeEN> arrAppraiseTypeObjLst_Sel1 =
from objAppraiseTypeEN in arrAppraiseTypeObjLst_Cache
where objAppraiseTypeEN.id_AppraiseType == strid_AppraiseType
select objAppraiseTypeEN;
List <clsAppraiseTypeEN> arrAppraiseTypeObjLst_Sel = new List<clsAppraiseTypeEN>();
foreach (clsAppraiseTypeEN obj in arrAppraiseTypeObjLst_Sel1)
{
arrAppraiseTypeObjLst_Sel.Add(obj);
}
if (arrAppraiseTypeObjLst_Sel.Count > 0)
{
return arrAppraiseTypeObjLst_Sel[0].AppraiseTypeName;
}
string strErrMsgForGetObjById = string.Format("在AppraiseType对象缓存列表中,找不到记录的相关名称[id_AppraiseType = {0}](函数:{1})", strid_AppraiseType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsAppraiseTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppraiseTypeEN> GetObjLst(string strWhereCond)
{
 List<clsAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAppraiseTypeEN> GetObjLstById_AppraiseTypeLst(List<string> arrId_AppraiseType)
{
 List<clsAppraiseTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_AppraiseTypeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_AppraiseType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_AppraiseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsAppraiseTypeEN> GetObjLstById_AppraiseTypeLst_Cache(List<string> arrId_AppraiseType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName_S);
List<clsAppraiseTypeEN> arrAppraiseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAppraiseTypeEN> arrAppraiseTypeObjLst_Sel =
from objAppraiseTypeEN in arrAppraiseTypeObjLst_Cache
where arrId_AppraiseType.Contains(objAppraiseTypeEN.id_AppraiseType)
select objAppraiseTypeEN;
return arrAppraiseTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppraiseTypeEN> GetObjLstById_AppraiseTypeLst_WA_Cache(List<string> arrId_AppraiseType)
{
 List<clsAppraiseTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_AppraiseTypeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_AppraiseType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAppraiseTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAppraiseTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAppraiseTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAppraiseTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_AppraiseType)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsAppraiseTypeEN objAppraiseTypeEN = clsAppraiseTypeWApi.GetObjByid_AppraiseType(strid_AppraiseType);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_AppraiseType.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsAppraiseTypeWApi.ReFreshCache();
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
public static int DelAppraiseTypes(List<string> arrid_AppraiseType)
{
string strAction = "DelAppraiseTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_AppraiseType);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsAppraiseTypeWApi.ReFreshCache();
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
public static int DelAppraiseTypesByCond(string strWhereCond)
{
string strAction = "DelAppraiseTypesByCond";
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
public static bool AddNewRecord(clsAppraiseTypeEN objAppraiseTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppraiseTypeEN>(objAppraiseTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsAppraiseTypeEN objAppraiseTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppraiseTypeEN>(objAppraiseTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeWApi.ReFreshCache();
var strid_AppraiseType = (string)jobjReturn["ReturnStr"];
return strid_AppraiseType;
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
public static bool UpdateRecord(clsAppraiseTypeEN objAppraiseTypeEN)
{
if (string.IsNullOrEmpty(objAppraiseTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAppraiseTypeEN.id_AppraiseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppraiseTypeEN>(objAppraiseTypeEN);
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
 /// <param name = "objAppraiseTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsAppraiseTypeEN objAppraiseTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objAppraiseTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAppraiseTypeEN.id_AppraiseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAppraiseTypeEN.id_AppraiseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppraiseTypeEN>(objAppraiseTypeEN);
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
public static bool IsExist(string strid_AppraiseType)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_AppraiseType"] = strid_AppraiseType
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
 /// <param name = "objAppraiseTypeENS">源对象</param>
 /// <param name = "objAppraiseTypeENT">目标对象</param>
 public static void CopyTo(clsAppraiseTypeEN objAppraiseTypeENS, clsAppraiseTypeEN objAppraiseTypeENT)
{
try
{
objAppraiseTypeENT.id_AppraiseType = objAppraiseTypeENS.id_AppraiseType; //评议类型流水号
objAppraiseTypeENT.AppraiseTypeID = objAppraiseTypeENS.AppraiseTypeID; //评议类型ID
objAppraiseTypeENT.AppraiseTypeName = objAppraiseTypeENS.AppraiseTypeName; //评议类型名称
objAppraiseTypeENT.AppraiseTypeName4CW = objAppraiseTypeENS.AppraiseTypeName4CW; //评议类型名称4课件
objAppraiseTypeENT.UserTypeId = objAppraiseTypeENS.UserTypeId; //用户类型Id
objAppraiseTypeENT.Memo = objAppraiseTypeENS.Memo; //备注
objAppraiseTypeENT.AppraiseTypeName_Sim = objAppraiseTypeENS.AppraiseTypeName_Sim; //评议类型名称_Sim
objAppraiseTypeENT.OrderNum = objAppraiseTypeENS.OrderNum; //序号
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
public static DataTable ToDataTable(List<clsAppraiseTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsAppraiseTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsAppraiseTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsAppraiseTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsAppraiseTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsAppraiseTypeEN.AttributeName)
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
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_AppraiseType");
//if (arrAppraiseTypeObjLst_Cache == null)
//{
//arrAppraiseTypeObjLst_Cache = await clsAppraiseTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName_S);
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
if (clsAppraiseTypeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsAppraiseTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAppraiseTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName_S);
List<clsAppraiseTypeEN> arrAppraiseTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrAppraiseTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsAppraiseTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conAppraiseType.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseType.AppraiseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseType.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseType.AppraiseTypeName4CW, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseType.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseType.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseType.AppraiseTypeName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(conAppraiseType.OrderNum, Type.GetType("System.Int32"));
foreach (clsAppraiseTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conAppraiseType.id_AppraiseType] = objInFor[conAppraiseType.id_AppraiseType];
objDR[conAppraiseType.AppraiseTypeID] = objInFor[conAppraiseType.AppraiseTypeID];
objDR[conAppraiseType.AppraiseTypeName] = objInFor[conAppraiseType.AppraiseTypeName];
objDR[conAppraiseType.AppraiseTypeName4CW] = objInFor[conAppraiseType.AppraiseTypeName4CW];
objDR[conAppraiseType.UserTypeId] = objInFor[conAppraiseType.UserTypeId];
objDR[conAppraiseType.Memo] = objInFor[conAppraiseType.Memo];
objDR[conAppraiseType.AppraiseTypeName_Sim] = objInFor[conAppraiseType.AppraiseTypeName_Sim];
objDR[conAppraiseType.OrderNum] = objInFor[conAppraiseType.OrderNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 评价类型(AppraiseType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4AppraiseType : clsCommFun4BL
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
clsAppraiseTypeWApi.ReFreshThisCache();
}
}

}