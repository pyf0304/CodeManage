
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserRolesWApi
 表名:vUserRoles(01120026)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:29
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
public static class clsvUserRolesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserRolesEN SetRoleId(this clsvUserRolesEN objvUserRolesEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convUserRoles.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convUserRoles.RoleId);
objvUserRolesEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.RoleId) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.RoleId, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.RoleId] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserRolesEN SetRoleName(this clsvUserRolesEN objvUserRolesEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleName, 100, convUserRoles.RoleName);
objvUserRolesEN.RoleName = strRoleName; //角色名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.RoleName) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.RoleName, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.RoleName] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserRolesEN SetQuestionnaireSetId(this clsvUserRolesEN objvUserRolesEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convUserRoles.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convUserRoles.QuestionnaireSetId);
objvUserRolesEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.QuestionnaireSetId) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.QuestionnaireSetId, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.QuestionnaireSetId] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserRolesEN SetQuestionnaireSetName(this clsvUserRolesEN objvUserRolesEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, convUserRoles.QuestionnaireSetName);
objvUserRolesEN.QuestionnaireSetName = strQuestionnaireSetName; //问卷集名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.QuestionnaireSetName) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.QuestionnaireSetName, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.QuestionnaireSetName] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserRolesEN SetPrjId(this clsvUserRolesEN objvUserRolesEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convUserRoles.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convUserRoles.PrjId);
objvUserRolesEN.PrjId = strPrjId; //PrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.PrjId) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.PrjId, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.PrjId] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserRolesEN SetMemo(this clsvUserRolesEN objvUserRolesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserRoles.Memo);
objvUserRolesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.Memo) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.Memo, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.Memo] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserRolesEN SetIsInUse(this clsvUserRolesEN objvUserRolesEN, bool bolIsInUse, string strComparisonOp="")
	{
objvUserRolesEN.IsInUse = bolIsInUse; //IsInUse
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.IsInUse) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.IsInUse, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.IsInUse] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserRolesEN SetUpdDate(this clsvUserRolesEN objvUserRolesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserRoles.UpdDate);
objvUserRolesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.UpdDate) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.UpdDate, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.UpdDate] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserRolesEN SetUpdUserId(this clsvUserRolesEN objvUserRolesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convUserRoles.UpdUserId);
objvUserRolesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.UpdUserId) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.UpdUserId, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.UpdUserId] = strComparisonOp;
}
}
return objvUserRolesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserRolesEN objvUserRoles_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserRoles_Cond.IsUpdated(convUserRoles.RoleId) == true)
{
string strComparisonOp_RoleId = objvUserRoles_Cond.dicFldComparisonOp[convUserRoles.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.RoleId, objvUserRoles_Cond.RoleId, strComparisonOp_RoleId);
}
if (objvUserRoles_Cond.IsUpdated(convUserRoles.RoleName) == true)
{
string strComparisonOp_RoleName = objvUserRoles_Cond.dicFldComparisonOp[convUserRoles.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.RoleName, objvUserRoles_Cond.RoleName, strComparisonOp_RoleName);
}
if (objvUserRoles_Cond.IsUpdated(convUserRoles.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objvUserRoles_Cond.dicFldComparisonOp[convUserRoles.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.QuestionnaireSetId, objvUserRoles_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objvUserRoles_Cond.IsUpdated(convUserRoles.QuestionnaireSetName) == true)
{
string strComparisonOp_QuestionnaireSetName = objvUserRoles_Cond.dicFldComparisonOp[convUserRoles.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.QuestionnaireSetName, objvUserRoles_Cond.QuestionnaireSetName, strComparisonOp_QuestionnaireSetName);
}
if (objvUserRoles_Cond.IsUpdated(convUserRoles.PrjId) == true)
{
string strComparisonOp_PrjId = objvUserRoles_Cond.dicFldComparisonOp[convUserRoles.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.PrjId, objvUserRoles_Cond.PrjId, strComparisonOp_PrjId);
}
if (objvUserRoles_Cond.IsUpdated(convUserRoles.Memo) == true)
{
string strComparisonOp_Memo = objvUserRoles_Cond.dicFldComparisonOp[convUserRoles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.Memo, objvUserRoles_Cond.Memo, strComparisonOp_Memo);
}
if (objvUserRoles_Cond.IsUpdated(convUserRoles.IsInUse) == true)
{
if (objvUserRoles_Cond.IsInUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserRoles.IsInUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserRoles.IsInUse);
}
}
if (objvUserRoles_Cond.IsUpdated(convUserRoles.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvUserRoles_Cond.dicFldComparisonOp[convUserRoles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.UpdDate, objvUserRoles_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvUserRoles_Cond.IsUpdated(convUserRoles.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvUserRoles_Cond.dicFldComparisonOp[convUserRoles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.UpdUserId, objvUserRoles_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v角色(vUserRoles)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUserRolesWApi
{
private static readonly string mstrApiControllerName = "vUserRolesApi";

 public clsvUserRolesWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色]...","0");
List<clsvUserRolesEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convUserRoles.RoleId); 
List<clsvUserRolesEN> arrObjLst = clsvUserRolesWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN()
{
RoleId = "0",
RoleName = "选[v角色]..."
};
arrObjLst.Insert(0, objvUserRolesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convUserRoles.RoleId;
objComboBox.DisplayMember = convUserRoles.RoleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserRolesEN GetObjByRoleId(string strRoleId)
{
string strAction = "GetObjByRoleId";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserRolesEN objvUserRolesEN = null;
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
objvUserRolesEN = JsonConvert.DeserializeObject<clsvUserRolesEN>((string)jobjReturn["ReturnObj"]);
return objvUserRolesEN;
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
public static clsvUserRolesEN GetObjByRoleId_WA_Cache(string strRoleId)
{
string strAction = "GetObjByRoleId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserRolesEN objvUserRolesEN = null;
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
objvUserRolesEN = JsonConvert.DeserializeObject<clsvUserRolesEN>((string)jobjReturn["ReturnObj"]);
return objvUserRolesEN;
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
public static clsvUserRolesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserRolesEN objvUserRolesEN = null;
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
objvUserRolesEN = JsonConvert.DeserializeObject<clsvUserRolesEN>((string)jobjReturn["ReturnObj"]);
return objvUserRolesEN;
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
public static clsvUserRolesEN GetObjByRoleId_Cache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvUserRolesEN._CurrTabName_S);
List<clsvUserRolesEN> arrvUserRolesObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUserRolesEN> arrvUserRolesObjLst_Sel =
from objvUserRolesEN in arrvUserRolesObjLst_Cache
where objvUserRolesEN.RoleId == strRoleId
select objvUserRolesEN;
if (arrvUserRolesObjLst_Sel.Count() == 0)
{
   clsvUserRolesEN obj = clsvUserRolesWApi.GetObjByRoleId(strRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvUserRolesObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsvUserRolesEN._CurrTabName_S);
List<clsvUserRolesEN> arrvUserRolesObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUserRolesEN> arrvUserRolesObjLst_Sel1 =
from objvUserRolesEN in arrvUserRolesObjLst_Cache
where objvUserRolesEN.RoleId == strRoleId
select objvUserRolesEN;
List <clsvUserRolesEN> arrvUserRolesObjLst_Sel = new List<clsvUserRolesEN>();
foreach (clsvUserRolesEN obj in arrvUserRolesObjLst_Sel1)
{
arrvUserRolesObjLst_Sel.Add(obj);
}
if (arrvUserRolesObjLst_Sel.Count > 0)
{
return arrvUserRolesObjLst_Sel[0].RoleName;
}
string strErrMsgForGetObjById = string.Format("在vUserRoles对象缓存列表中,找不到记录[RoleId = {0}](函数:{1})", strRoleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvUserRolesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsvUserRolesEN._CurrTabName_S);
List<clsvUserRolesEN> arrvUserRolesObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUserRolesEN> arrvUserRolesObjLst_Sel1 =
from objvUserRolesEN in arrvUserRolesObjLst_Cache
where objvUserRolesEN.RoleId == strRoleId
select objvUserRolesEN;
List <clsvUserRolesEN> arrvUserRolesObjLst_Sel = new List<clsvUserRolesEN>();
foreach (clsvUserRolesEN obj in arrvUserRolesObjLst_Sel1)
{
arrvUserRolesObjLst_Sel.Add(obj);
}
if (arrvUserRolesObjLst_Sel.Count > 0)
{
return arrvUserRolesObjLst_Sel[0].RoleName;
}
string strErrMsgForGetObjById = string.Format("在vUserRoles对象缓存列表中,找不到记录的相关名称[RoleId = {0}](函数:{1})", strRoleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvUserRolesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserRolesEN> GetObjLst(string strWhereCond)
{
 List<clsvUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserRolesEN> GetObjLstByRoleIdLst(List<string> arrRoleId)
{
 List<clsvUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvUserRolesEN> GetObjLstByRoleIdLst_Cache(List<string> arrRoleId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvUserRolesEN._CurrTabName_S);
List<clsvUserRolesEN> arrvUserRolesObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUserRolesEN> arrvUserRolesObjLst_Sel =
from objvUserRolesEN in arrvUserRolesObjLst_Cache
where arrRoleId.Contains(objvUserRolesEN.RoleId)
select objvUserRolesEN;
return arrvUserRolesObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserRolesEN> GetObjLstByRoleIdLst_WA_Cache(List<string> arrRoleId)
{
 List<clsvUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserRolesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserRolesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserRolesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserRolesEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvUserRolesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserRolesEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvUserRolesENS">源对象</param>
 /// <param name = "objvUserRolesENT">目标对象</param>
 public static void CopyTo(clsvUserRolesEN objvUserRolesENS, clsvUserRolesEN objvUserRolesENT)
{
try
{
objvUserRolesENT.RoleId = objvUserRolesENS.RoleId; //角色Id
objvUserRolesENT.RoleName = objvUserRolesENS.RoleName; //角色名
objvUserRolesENT.QuestionnaireSetId = objvUserRolesENS.QuestionnaireSetId; //问卷集ID
objvUserRolesENT.QuestionnaireSetName = objvUserRolesENS.QuestionnaireSetName; //问卷集名
objvUserRolesENT.PrjId = objvUserRolesENS.PrjId; //PrjId
objvUserRolesENT.Memo = objvUserRolesENS.Memo; //备注
objvUserRolesENT.IsInUse = objvUserRolesENS.IsInUse; //IsInUse
objvUserRolesENT.UpdDate = objvUserRolesENS.UpdDate; //修改日期
objvUserRolesENT.UpdUserId = objvUserRolesENS.UpdUserId; //修改用户Id
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
public static DataTable ToDataTable(List<clsvUserRolesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUserRolesEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUserRolesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUserRolesEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUserRolesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUserRolesEN.AttributeName)
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
if (clsQuestionnaireSetWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetWApi没有刷新缓存机制(clsQuestionnaireSetWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserRolesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserRolesWApi没有刷新缓存机制(clsUserRolesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RoleId");
//if (arrvUserRolesObjLst_Cache == null)
//{
//arrvUserRolesObjLst_Cache = await clsvUserRolesWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvUserRolesEN._CurrTabName_S);
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
public static List<clsvUserRolesEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvUserRolesEN._CurrTabName_S);
List<clsvUserRolesEN> arrvUserRolesObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUserRolesObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvUserRolesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUserRoles.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convUserRoles.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convUserRoles.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(convUserRoles.QuestionnaireSetName, Type.GetType("System.String"));
objDT.Columns.Add(convUserRoles.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convUserRoles.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convUserRoles.IsInUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserRoles.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convUserRoles.UpdUserId, Type.GetType("System.String"));
foreach (clsvUserRolesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUserRoles.RoleId] = objInFor[convUserRoles.RoleId];
objDR[convUserRoles.RoleName] = objInFor[convUserRoles.RoleName];
objDR[convUserRoles.QuestionnaireSetId] = objInFor[convUserRoles.QuestionnaireSetId];
objDR[convUserRoles.QuestionnaireSetName] = objInFor[convUserRoles.QuestionnaireSetName];
objDR[convUserRoles.PrjId] = objInFor[convUserRoles.PrjId];
objDR[convUserRoles.Memo] = objInFor[convUserRoles.Memo];
objDR[convUserRoles.IsInUse] = objInFor[convUserRoles.IsInUse];
objDR[convUserRoles.UpdDate] = objInFor[convUserRoles.UpdDate];
objDR[convUserRoles.UpdUserId] = objInFor[convUserRoles.UpdUserId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}