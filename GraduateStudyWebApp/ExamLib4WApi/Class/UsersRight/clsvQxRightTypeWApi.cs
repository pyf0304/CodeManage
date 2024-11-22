
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRightTypeWApi
 表名:vQxRightType(01120171)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:55
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
public static class clsvQxRightTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightTypeEN SetRightTypeId(this clsvQxRightTypeEN objvQxRightTypeEN, string strRightTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRightTypeId, 4, convQxRightType.RightTypeId);
clsCheckSql.CheckFieldForeignKey(strRightTypeId, 4, convQxRightType.RightTypeId);
objvQxRightTypeEN.RightTypeId = strRightTypeId; //权限类型编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.RightTypeId) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.RightTypeId, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.RightTypeId] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightTypeEN SetRightTypeName(this clsvQxRightTypeEN objvQxRightTypeEN, string strRightTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightTypeName, convQxRightType.RightTypeName);
clsCheckSql.CheckFieldLen(strRightTypeName, 50, convQxRightType.RightTypeName);
objvQxRightTypeEN.RightTypeName = strRightTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.RightTypeName) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.RightTypeName, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.RightTypeName] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightTypeEN SetFuncModuleId(this clsvQxRightTypeEN objvQxRightTypeEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convQxRightType.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxRightType.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxRightType.FuncModuleId);
objvQxRightTypeEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.FuncModuleId) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.FuncModuleId, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.FuncModuleId] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightTypeEN SetFuncModuleName(this clsvQxRightTypeEN objvQxRightTypeEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxRightType.FuncModuleName);
objvQxRightTypeEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.FuncModuleName) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.FuncModuleName, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.FuncModuleName] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightTypeEN SetFuncModuleName_Sim(this clsvQxRightTypeEN objvQxRightTypeEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convQxRightType.FuncModuleName_Sim);
objvQxRightTypeEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.FuncModuleName_Sim) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightTypeEN SetMenuId(this clsvQxRightTypeEN objvQxRightTypeEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuId, convQxRightType.MenuId);
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxRightType.MenuId);
objvQxRightTypeEN.MenuId = strMenuId; //菜单编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.MenuId) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.MenuId, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.MenuId] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightTypeEN SetViewId(this clsvQxRightTypeEN objvQxRightTypeEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewId, convQxRightType.ViewId);
clsCheckSql.CheckFieldLen(strViewId, 8, convQxRightType.ViewId);
objvQxRightTypeEN.ViewId = strViewId; //界面编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.ViewId) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.ViewId, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.ViewId] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightTypeEN SetUpdDate(this clsvQxRightTypeEN objvQxRightTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxRightType.UpdDate);
objvQxRightTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.UpdDate) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.UpdDate, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.UpdDate] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightTypeEN SetUpdUser(this clsvQxRightTypeEN objvQxRightTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxRightType.UpdUser);
objvQxRightTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.UpdUser) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.UpdUser, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.UpdUser] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightTypeEN SetMemo(this clsvQxRightTypeEN objvQxRightTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxRightType.Memo);
objvQxRightTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.Memo) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.Memo, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.Memo] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxRightTypeEN objvQxRightType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxRightType_Cond.IsUpdated(convQxRightType.RightTypeId) == true)
{
string strComparisonOp_RightTypeId = objvQxRightType_Cond.dicFldComparisonOp[convQxRightType.RightTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.RightTypeId, objvQxRightType_Cond.RightTypeId, strComparisonOp_RightTypeId);
}
if (objvQxRightType_Cond.IsUpdated(convQxRightType.RightTypeName) == true)
{
string strComparisonOp_RightTypeName = objvQxRightType_Cond.dicFldComparisonOp[convQxRightType.RightTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.RightTypeName, objvQxRightType_Cond.RightTypeName, strComparisonOp_RightTypeName);
}
if (objvQxRightType_Cond.IsUpdated(convQxRightType.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvQxRightType_Cond.dicFldComparisonOp[convQxRightType.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.FuncModuleId, objvQxRightType_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvQxRightType_Cond.IsUpdated(convQxRightType.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvQxRightType_Cond.dicFldComparisonOp[convQxRightType.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.FuncModuleName, objvQxRightType_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvQxRightType_Cond.IsUpdated(convQxRightType.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvQxRightType_Cond.dicFldComparisonOp[convQxRightType.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.FuncModuleName_Sim, objvQxRightType_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvQxRightType_Cond.IsUpdated(convQxRightType.MenuId) == true)
{
string strComparisonOp_MenuId = objvQxRightType_Cond.dicFldComparisonOp[convQxRightType.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.MenuId, objvQxRightType_Cond.MenuId, strComparisonOp_MenuId);
}
if (objvQxRightType_Cond.IsUpdated(convQxRightType.ViewId) == true)
{
string strComparisonOp_ViewId = objvQxRightType_Cond.dicFldComparisonOp[convQxRightType.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.ViewId, objvQxRightType_Cond.ViewId, strComparisonOp_ViewId);
}
if (objvQxRightType_Cond.IsUpdated(convQxRightType.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvQxRightType_Cond.dicFldComparisonOp[convQxRightType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.UpdDate, objvQxRightType_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvQxRightType_Cond.IsUpdated(convQxRightType.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvQxRightType_Cond.dicFldComparisonOp[convQxRightType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.UpdUser, objvQxRightType_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvQxRightType_Cond.IsUpdated(convQxRightType.Memo) == true)
{
string strComparisonOp_Memo = objvQxRightType_Cond.dicFldComparisonOp[convQxRightType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.Memo, objvQxRightType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v权限类型(vQxRightType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxRightTypeWApi
{
private static readonly string mstrApiControllerName = "vQxRightTypeApi";

 public clsvQxRightTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RightTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v权限类型]...","0");
List<clsvQxRightTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="RightTypeId";
objDDL.DataTextField="RightTypeName";
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
public static void BindCbo_RightTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxRightType.RightTypeId); 
List<clsvQxRightTypeEN> arrObjLst = clsvQxRightTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN()
{
RightTypeId = "0",
RightTypeName = "选[v权限类型]..."
};
arrObjLst.Insert(0, objvQxRightTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxRightType.RightTypeId;
objComboBox.DisplayMember = convQxRightType.RightTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRightTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRightTypeEN GetObjByRightTypeId(string strRightTypeId)
{
string strAction = "GetObjByRightTypeId";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxRightTypeEN objvQxRightTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RightTypeId"] = strRightTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQxRightTypeEN = JsonConvert.DeserializeObject<clsvQxRightTypeEN>((string)jobjReturn["ReturnObj"]);
return objvQxRightTypeEN;
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
 /// <param name = "strRightTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRightTypeEN GetObjByRightTypeId_WA_Cache(string strRightTypeId)
{
string strAction = "GetObjByRightTypeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxRightTypeEN objvQxRightTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RightTypeId"] = strRightTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQxRightTypeEN = JsonConvert.DeserializeObject<clsvQxRightTypeEN>((string)jobjReturn["ReturnObj"]);
return objvQxRightTypeEN;
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
public static clsvQxRightTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxRightTypeEN objvQxRightTypeEN = null;
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
objvQxRightTypeEN = JsonConvert.DeserializeObject<clsvQxRightTypeEN>((string)jobjReturn["ReturnObj"]);
return objvQxRightTypeEN;
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
 /// <param name = "strRightTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRightTypeEN GetObjByRightTypeId_Cache(string strRightTypeId)
{
if (string.IsNullOrEmpty(strRightTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxRightTypeEN._CurrTabName_S);
List<clsvQxRightTypeEN> arrvQxRightTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxRightTypeEN> arrvQxRightTypeObjLst_Sel =
from objvQxRightTypeEN in arrvQxRightTypeObjLst_Cache
where objvQxRightTypeEN.RightTypeId == strRightTypeId
select objvQxRightTypeEN;
if (arrvQxRightTypeObjLst_Sel.Count() == 0)
{
   clsvQxRightTypeEN obj = clsvQxRightTypeWApi.GetObjByRightTypeId(strRightTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQxRightTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strRightTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRightTypeNameByRightTypeId_Cache(string strRightTypeId)
{
if (string.IsNullOrEmpty(strRightTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxRightTypeEN._CurrTabName_S);
List<clsvQxRightTypeEN> arrvQxRightTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxRightTypeEN> arrvQxRightTypeObjLst_Sel1 =
from objvQxRightTypeEN in arrvQxRightTypeObjLst_Cache
where objvQxRightTypeEN.RightTypeId == strRightTypeId
select objvQxRightTypeEN;
List <clsvQxRightTypeEN> arrvQxRightTypeObjLst_Sel = new List<clsvQxRightTypeEN>();
foreach (clsvQxRightTypeEN obj in arrvQxRightTypeObjLst_Sel1)
{
arrvQxRightTypeObjLst_Sel.Add(obj);
}
if (arrvQxRightTypeObjLst_Sel.Count > 0)
{
return arrvQxRightTypeObjLst_Sel[0].RightTypeName;
}
string strErrMsgForGetObjById = string.Format("在vQxRightType对象缓存列表中,找不到记录[RightTypeId = {0}](函数:{1})", strRightTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQxRightTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strRightTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRightTypeId_Cache(string strRightTypeId)
{
if (string.IsNullOrEmpty(strRightTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxRightTypeEN._CurrTabName_S);
List<clsvQxRightTypeEN> arrvQxRightTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxRightTypeEN> arrvQxRightTypeObjLst_Sel1 =
from objvQxRightTypeEN in arrvQxRightTypeObjLst_Cache
where objvQxRightTypeEN.RightTypeId == strRightTypeId
select objvQxRightTypeEN;
List <clsvQxRightTypeEN> arrvQxRightTypeObjLst_Sel = new List<clsvQxRightTypeEN>();
foreach (clsvQxRightTypeEN obj in arrvQxRightTypeObjLst_Sel1)
{
arrvQxRightTypeObjLst_Sel.Add(obj);
}
if (arrvQxRightTypeObjLst_Sel.Count > 0)
{
return arrvQxRightTypeObjLst_Sel[0].RightTypeName;
}
string strErrMsgForGetObjById = string.Format("在vQxRightType对象缓存列表中,找不到记录的相关名称[RightTypeId = {0}](函数:{1})", strRightTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQxRightTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvQxRightTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxRightTypeEN> GetObjLstByRightTypeIdLst(List<string> arrRightTypeId)
{
 List<clsvQxRightTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByRightTypeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRightTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strRightTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQxRightTypeEN> GetObjLstByRightTypeIdLst_Cache(List<string> arrRightTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxRightTypeEN._CurrTabName_S);
List<clsvQxRightTypeEN> arrvQxRightTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxRightTypeEN> arrvQxRightTypeObjLst_Sel =
from objvQxRightTypeEN in arrvQxRightTypeObjLst_Cache
where arrRightTypeId.Contains(objvQxRightTypeEN.RightTypeId)
select objvQxRightTypeEN;
return arrvQxRightTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLstByRightTypeIdLst_WA_Cache(List<string> arrRightTypeId)
{
 List<clsvQxRightTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByRightTypeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRightTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxRightTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxRightTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxRightTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxRightTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxRightTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxRightTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxRightTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQxRightTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strRightTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RightTypeId"] = strRightTypeId
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
 /// <param name = "objvQxRightTypeENS">源对象</param>
 /// <param name = "objvQxRightTypeENT">目标对象</param>
 public static void CopyTo(clsvQxRightTypeEN objvQxRightTypeENS, clsvQxRightTypeEN objvQxRightTypeENT)
{
try
{
objvQxRightTypeENT.RightTypeId = objvQxRightTypeENS.RightTypeId; //权限类型编号
objvQxRightTypeENT.RightTypeName = objvQxRightTypeENS.RightTypeName; //权限类型名
objvQxRightTypeENT.FuncModuleId = objvQxRightTypeENS.FuncModuleId; //功能模块Id
objvQxRightTypeENT.FuncModuleName = objvQxRightTypeENS.FuncModuleName; //功能模块名称
objvQxRightTypeENT.FuncModuleName_Sim = objvQxRightTypeENS.FuncModuleName_Sim; //功能模块简称
objvQxRightTypeENT.MenuId = objvQxRightTypeENS.MenuId; //菜单编号
objvQxRightTypeENT.ViewId = objvQxRightTypeENS.ViewId; //界面编号
objvQxRightTypeENT.UpdDate = objvQxRightTypeENS.UpdDate; //修改日期
objvQxRightTypeENT.UpdUser = objvQxRightTypeENS.UpdUser; //修改人
objvQxRightTypeENT.Memo = objvQxRightTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxRightTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxRightTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxRightTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxRightTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxRightTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxRightTypeEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightTypeWApi没有刷新缓存机制(clsQxRightTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RightTypeId");
//if (arrvQxRightTypeObjLst_Cache == null)
//{
//arrvQxRightTypeObjLst_Cache = await clsvQxRightTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvQxRightTypeEN._CurrTabName_S);
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
public static List<clsvQxRightTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQxRightTypeEN._CurrTabName_S);
List<clsvQxRightTypeEN> arrvQxRightTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxRightTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxRightTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxRightType.RightTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRightType.RightTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRightType.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRightType.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRightType.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQxRightType.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRightType.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRightType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxRightType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQxRightType.Memo, Type.GetType("System.String"));
foreach (clsvQxRightTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxRightType.RightTypeId] = objInFor[convQxRightType.RightTypeId];
objDR[convQxRightType.RightTypeName] = objInFor[convQxRightType.RightTypeName];
objDR[convQxRightType.FuncModuleId] = objInFor[convQxRightType.FuncModuleId];
objDR[convQxRightType.FuncModuleName] = objInFor[convQxRightType.FuncModuleName];
objDR[convQxRightType.FuncModuleName_Sim] = objInFor[convQxRightType.FuncModuleName_Sim];
objDR[convQxRightType.MenuId] = objInFor[convQxRightType.MenuId];
objDR[convQxRightType.ViewId] = objInFor[convQxRightType.ViewId];
objDR[convQxRightType.UpdDate] = objInFor[convQxRightType.UpdDate];
objDR[convQxRightType.UpdUser] = objInFor[convQxRightType.UpdUser];
objDR[convQxRightType.Memo] = objInFor[convQxRightType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}