
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzGrade_psWApi
 表名:vXzGrade_ps(01120368)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:36
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中小学教学
 模块英文名:PrimaryAndSecondaryEducation
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
public static class clsvXzGrade_psWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGrade_psEN Setid_GradeBase(this clsvXzGrade_psEN objvXzGrade_psEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convXzGrade_ps.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convXzGrade_ps.id_GradeBase);
objvXzGrade_psEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.id_GradeBase) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.id_GradeBase, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.id_GradeBase] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGrade_psEN SetGradeBaseID(this clsvXzGrade_psEN objvXzGrade_psEN, string strGradeBaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseID, convXzGrade_ps.GradeBaseID);
clsCheckSql.CheckFieldLen(strGradeBaseID, 4, convXzGrade_ps.GradeBaseID);
clsCheckSql.CheckFieldForeignKey(strGradeBaseID, 4, convXzGrade_ps.GradeBaseID);
objvXzGrade_psEN.GradeBaseID = strGradeBaseID; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.GradeBaseID) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.GradeBaseID, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.GradeBaseID] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGrade_psEN SetGradeBaseName(this clsvXzGrade_psEN objvXzGrade_psEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convXzGrade_ps.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convXzGrade_ps.GradeBaseName);
objvXzGrade_psEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.GradeBaseName) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.GradeBaseName, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.GradeBaseName] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGrade_psEN SetIsVisible(this clsvXzGrade_psEN objvXzGrade_psEN, bool bolIsVisible, string strComparisonOp="")
	{
objvXzGrade_psEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.IsVisible) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.IsVisible, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.IsVisible] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGrade_psEN SetOrderNum(this clsvXzGrade_psEN objvXzGrade_psEN, int intOrderNum, string strComparisonOp="")
	{
objvXzGrade_psEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.OrderNum) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.OrderNum, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.OrderNum] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGrade_psEN SetSchoolId(this clsvXzGrade_psEN objvXzGrade_psEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convXzGrade_ps.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convXzGrade_ps.SchoolId);
objvXzGrade_psEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.SchoolId) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.SchoolId, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.SchoolId] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGrade_psEN SetSchoolName(this clsvXzGrade_psEN objvXzGrade_psEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convXzGrade_ps.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convXzGrade_ps.SchoolName);
objvXzGrade_psEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.SchoolName) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.SchoolName, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.SchoolName] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGrade_psEN Setid_School(this clsvXzGrade_psEN objvXzGrade_psEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convXzGrade_ps.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convXzGrade_ps.id_School);
objvXzGrade_psEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.id_School) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.id_School, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.id_School] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGrade_psEN SetMemo(this clsvXzGrade_psEN objvXzGrade_psEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzGrade_ps.Memo);
objvXzGrade_psEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.Memo) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.Memo, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.Memo] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzGrade_psEN objvXzGrade_ps_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzGrade_ps_Cond.IsUpdated(convXzGrade_ps.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvXzGrade_ps_Cond.dicFldComparisonOp[convXzGrade_ps.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.id_GradeBase, objvXzGrade_ps_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvXzGrade_ps_Cond.IsUpdated(convXzGrade_ps.GradeBaseID) == true)
{
string strComparisonOp_GradeBaseID = objvXzGrade_ps_Cond.dicFldComparisonOp[convXzGrade_ps.GradeBaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.GradeBaseID, objvXzGrade_ps_Cond.GradeBaseID, strComparisonOp_GradeBaseID);
}
if (objvXzGrade_ps_Cond.IsUpdated(convXzGrade_ps.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvXzGrade_ps_Cond.dicFldComparisonOp[convXzGrade_ps.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.GradeBaseName, objvXzGrade_ps_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvXzGrade_ps_Cond.IsUpdated(convXzGrade_ps.IsVisible) == true)
{
if (objvXzGrade_ps_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzGrade_ps.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzGrade_ps.IsVisible);
}
}
if (objvXzGrade_ps_Cond.IsUpdated(convXzGrade_ps.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvXzGrade_ps_Cond.dicFldComparisonOp[convXzGrade_ps.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convXzGrade_ps.OrderNum, objvXzGrade_ps_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvXzGrade_ps_Cond.IsUpdated(convXzGrade_ps.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvXzGrade_ps_Cond.dicFldComparisonOp[convXzGrade_ps.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.SchoolId, objvXzGrade_ps_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvXzGrade_ps_Cond.IsUpdated(convXzGrade_ps.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvXzGrade_ps_Cond.dicFldComparisonOp[convXzGrade_ps.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.SchoolName, objvXzGrade_ps_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvXzGrade_ps_Cond.IsUpdated(convXzGrade_ps.id_School) == true)
{
string strComparisonOp_id_School = objvXzGrade_ps_Cond.dicFldComparisonOp[convXzGrade_ps.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.id_School, objvXzGrade_ps_Cond.id_School, strComparisonOp_id_School);
}
if (objvXzGrade_ps_Cond.IsUpdated(convXzGrade_ps.Memo) == true)
{
string strComparisonOp_Memo = objvXzGrade_ps_Cond.dicFldComparisonOp[convXzGrade_ps.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.Memo, objvXzGrade_ps_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v年级表_ps(vXzGrade_ps)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvXzGrade_psWApi
{
private static readonly string mstrApiControllerName = "vXzGrade_psApi";

 public clsvXzGrade_psWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_GradeBase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v年级表_ps]...","0");
List<clsvXzGrade_psEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_GradeBase";
objDDL.DataTextField="GradeBaseName";
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
public static void BindCbo_id_GradeBase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzGrade_ps.id_GradeBase); 
List<clsvXzGrade_psEN> arrObjLst = clsvXzGrade_psWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN()
{
id_GradeBase = "0",
GradeBaseName = "选[v年级表_ps]..."
};
arrObjLst.Insert(0, objvXzGrade_psEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzGrade_ps.id_GradeBase;
objComboBox.DisplayMember = convXzGrade_ps.GradeBaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_GradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzGrade_psEN GetObjByid_GradeBase(string strid_GradeBase)
{
string strAction = "GetObjByid_GradeBase";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzGrade_psEN objvXzGrade_psEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_GradeBase"] = strid_GradeBase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzGrade_psEN = JsonConvert.DeserializeObject<clsvXzGrade_psEN>((string)jobjReturn["ReturnObj"]);
return objvXzGrade_psEN;
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
 /// <param name = "strid_GradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzGrade_psEN GetObjByid_GradeBase_WA_Cache(string strid_GradeBase)
{
string strAction = "GetObjByid_GradeBase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzGrade_psEN objvXzGrade_psEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_GradeBase"] = strid_GradeBase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzGrade_psEN = JsonConvert.DeserializeObject<clsvXzGrade_psEN>((string)jobjReturn["ReturnObj"]);
return objvXzGrade_psEN;
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
public static clsvXzGrade_psEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzGrade_psEN objvXzGrade_psEN = null;
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
objvXzGrade_psEN = JsonConvert.DeserializeObject<clsvXzGrade_psEN>((string)jobjReturn["ReturnObj"]);
return objvXzGrade_psEN;
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
 /// <param name = "strid_GradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzGrade_psEN GetObjByid_GradeBase_Cache(string strid_GradeBase)
{
if (string.IsNullOrEmpty(strid_GradeBase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzGrade_psEN._CurrTabName_S);
List<clsvXzGrade_psEN> arrvXzGrade_psObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzGrade_psEN> arrvXzGrade_psObjLst_Sel =
from objvXzGrade_psEN in arrvXzGrade_psObjLst_Cache
where objvXzGrade_psEN.id_GradeBase == strid_GradeBase
select objvXzGrade_psEN;
if (arrvXzGrade_psObjLst_Sel.Count() == 0)
{
   clsvXzGrade_psEN obj = clsvXzGrade_psWApi.GetObjByid_GradeBase(strid_GradeBase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvXzGrade_psObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_GradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGradeBaseNameByid_GradeBase_Cache(string strid_GradeBase)
{
if (string.IsNullOrEmpty(strid_GradeBase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzGrade_psEN._CurrTabName_S);
List<clsvXzGrade_psEN> arrvXzGrade_psObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzGrade_psEN> arrvXzGrade_psObjLst_Sel1 =
from objvXzGrade_psEN in arrvXzGrade_psObjLst_Cache
where objvXzGrade_psEN.id_GradeBase == strid_GradeBase
select objvXzGrade_psEN;
List <clsvXzGrade_psEN> arrvXzGrade_psObjLst_Sel = new List<clsvXzGrade_psEN>();
foreach (clsvXzGrade_psEN obj in arrvXzGrade_psObjLst_Sel1)
{
arrvXzGrade_psObjLst_Sel.Add(obj);
}
if (arrvXzGrade_psObjLst_Sel.Count > 0)
{
return arrvXzGrade_psObjLst_Sel[0].GradeBaseName;
}
string strErrMsgForGetObjById = string.Format("在vXzGrade_ps对象缓存列表中,找不到记录[id_GradeBase = {0}](函数:{1})", strid_GradeBase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzGrade_psBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_GradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_GradeBase_Cache(string strid_GradeBase)
{
if (string.IsNullOrEmpty(strid_GradeBase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzGrade_psEN._CurrTabName_S);
List<clsvXzGrade_psEN> arrvXzGrade_psObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzGrade_psEN> arrvXzGrade_psObjLst_Sel1 =
from objvXzGrade_psEN in arrvXzGrade_psObjLst_Cache
where objvXzGrade_psEN.id_GradeBase == strid_GradeBase
select objvXzGrade_psEN;
List <clsvXzGrade_psEN> arrvXzGrade_psObjLst_Sel = new List<clsvXzGrade_psEN>();
foreach (clsvXzGrade_psEN obj in arrvXzGrade_psObjLst_Sel1)
{
arrvXzGrade_psObjLst_Sel.Add(obj);
}
if (arrvXzGrade_psObjLst_Sel.Count > 0)
{
return arrvXzGrade_psObjLst_Sel[0].GradeBaseName;
}
string strErrMsgForGetObjById = string.Format("在vXzGrade_ps对象缓存列表中,找不到记录的相关名称[id_GradeBase = {0}](函数:{1})", strid_GradeBase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzGrade_psBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzGrade_psEN> GetObjLst(string strWhereCond)
{
 List<clsvXzGrade_psEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGrade_psEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzGrade_psEN> GetObjLstById_GradeBaseLst(List<string> arrId_GradeBase)
{
 List<clsvXzGrade_psEN> arrObjLst = null; 
string strAction = "GetObjLstById_GradeBaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_GradeBase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGrade_psEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_GradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvXzGrade_psEN> GetObjLstById_GradeBaseLst_Cache(List<string> arrId_GradeBase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzGrade_psEN._CurrTabName_S);
List<clsvXzGrade_psEN> arrvXzGrade_psObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzGrade_psEN> arrvXzGrade_psObjLst_Sel =
from objvXzGrade_psEN in arrvXzGrade_psObjLst_Cache
where arrId_GradeBase.Contains(objvXzGrade_psEN.id_GradeBase)
select objvXzGrade_psEN;
return arrvXzGrade_psObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzGrade_psEN> GetObjLstById_GradeBaseLst_WA_Cache(List<string> arrId_GradeBase)
{
 List<clsvXzGrade_psEN> arrObjLst = null; 
string strAction = "GetObjLstById_GradeBaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_GradeBase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGrade_psEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzGrade_psEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvXzGrade_psEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGrade_psEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzGrade_psEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvXzGrade_psEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGrade_psEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzGrade_psEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvXzGrade_psEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGrade_psEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzGrade_psEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvXzGrade_psEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGrade_psEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_GradeBase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_GradeBase"] = strid_GradeBase
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
 /// <param name = "objvXzGrade_psENS">源对象</param>
 /// <param name = "objvXzGrade_psENT">目标对象</param>
 public static void CopyTo(clsvXzGrade_psEN objvXzGrade_psENS, clsvXzGrade_psEN objvXzGrade_psENT)
{
try
{
objvXzGrade_psENT.id_GradeBase = objvXzGrade_psENS.id_GradeBase; //年级流水号
objvXzGrade_psENT.GradeBaseID = objvXzGrade_psENS.GradeBaseID; //年级代号
objvXzGrade_psENT.GradeBaseName = objvXzGrade_psENS.GradeBaseName; //年级名称
objvXzGrade_psENT.IsVisible = objvXzGrade_psENS.IsVisible; //是否显示
objvXzGrade_psENT.OrderNum = objvXzGrade_psENS.OrderNum; //序号
objvXzGrade_psENT.SchoolId = objvXzGrade_psENS.SchoolId; //学校编号
objvXzGrade_psENT.SchoolName = objvXzGrade_psENS.SchoolName; //学校名称
objvXzGrade_psENT.id_School = objvXzGrade_psENS.id_School; //学校流水号
objvXzGrade_psENT.Memo = objvXzGrade_psENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvXzGrade_psEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvXzGrade_psEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvXzGrade_psEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvXzGrade_psEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvXzGrade_psEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvXzGrade_psEN.AttributeName)
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
if (clsXzSchoolWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolWApi没有刷新缓存机制(clsXzSchoolWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGrade_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGrade_psWApi没有刷新缓存机制(clsXzGrade_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_GradeBase");
//if (arrvXzGrade_psObjLst_Cache == null)
//{
//arrvXzGrade_psObjLst_Cache = await clsvXzGrade_psWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvXzGrade_psEN._CurrTabName_S);
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
public static List<clsvXzGrade_psEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvXzGrade_psEN._CurrTabName_S);
List<clsvXzGrade_psEN> arrvXzGrade_psObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzGrade_psObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvXzGrade_psEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convXzGrade_ps.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convXzGrade_ps.GradeBaseID, Type.GetType("System.String"));
objDT.Columns.Add(convXzGrade_ps.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convXzGrade_ps.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzGrade_ps.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convXzGrade_ps.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convXzGrade_ps.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convXzGrade_ps.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convXzGrade_ps.Memo, Type.GetType("System.String"));
foreach (clsvXzGrade_psEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convXzGrade_ps.id_GradeBase] = objInFor[convXzGrade_ps.id_GradeBase];
objDR[convXzGrade_ps.GradeBaseID] = objInFor[convXzGrade_ps.GradeBaseID];
objDR[convXzGrade_ps.GradeBaseName] = objInFor[convXzGrade_ps.GradeBaseName];
objDR[convXzGrade_ps.IsVisible] = objInFor[convXzGrade_ps.IsVisible];
objDR[convXzGrade_ps.OrderNum] = objInFor[convXzGrade_ps.OrderNum];
objDR[convXzGrade_ps.SchoolId] = objInFor[convXzGrade_ps.SchoolId];
objDR[convXzGrade_ps.SchoolName] = objInFor[convXzGrade_ps.SchoolName];
objDR[convXzGrade_ps.id_School] = objInFor[convXzGrade_ps.id_School];
objDR[convXzGrade_ps.Memo] = objInFor[convXzGrade_ps.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}