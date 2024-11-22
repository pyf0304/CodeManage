
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzSchoolWApi
 表名:vXzSchool(01120028)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:05
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
public static class clsvXzSchoolWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolEN Setid_School(this clsvXzSchoolEN objvXzSchoolEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convXzSchool.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convXzSchool.id_School);
objvXzSchoolEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolEN.dicFldComparisonOp.ContainsKey(convXzSchool.id_School) == false)
{
objvXzSchoolEN.dicFldComparisonOp.Add(convXzSchool.id_School, strComparisonOp);
}
else
{
objvXzSchoolEN.dicFldComparisonOp[convXzSchool.id_School] = strComparisonOp;
}
}
return objvXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolEN SetSchoolId(this clsvXzSchoolEN objvXzSchoolEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convXzSchool.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convXzSchool.SchoolId);
objvXzSchoolEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolEN.dicFldComparisonOp.ContainsKey(convXzSchool.SchoolId) == false)
{
objvXzSchoolEN.dicFldComparisonOp.Add(convXzSchool.SchoolId, strComparisonOp);
}
else
{
objvXzSchoolEN.dicFldComparisonOp[convXzSchool.SchoolId] = strComparisonOp;
}
}
return objvXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolEN SetSchoolName(this clsvXzSchoolEN objvXzSchoolEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convXzSchool.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convXzSchool.SchoolName);
objvXzSchoolEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolEN.dicFldComparisonOp.ContainsKey(convXzSchool.SchoolName) == false)
{
objvXzSchoolEN.dicFldComparisonOp.Add(convXzSchool.SchoolName, strComparisonOp);
}
else
{
objvXzSchoolEN.dicFldComparisonOp[convXzSchool.SchoolName] = strComparisonOp;
}
}
return objvXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolEN SetSchoolNameA(this clsvXzSchoolEN objvXzSchoolEN, string strSchoolNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, convXzSchool.SchoolNameA);
objvXzSchoolEN.SchoolNameA = strSchoolNameA; //学校简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolEN.dicFldComparisonOp.ContainsKey(convXzSchool.SchoolNameA) == false)
{
objvXzSchoolEN.dicFldComparisonOp.Add(convXzSchool.SchoolNameA, strComparisonOp);
}
else
{
objvXzSchoolEN.dicFldComparisonOp[convXzSchool.SchoolNameA] = strComparisonOp;
}
}
return objvXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolEN SetSchoolTypeId(this clsvXzSchoolEN objvXzSchoolEN, string strSchoolTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTypeId, 2, convXzSchool.SchoolTypeId);
clsCheckSql.CheckFieldForeignKey(strSchoolTypeId, 2, convXzSchool.SchoolTypeId);
objvXzSchoolEN.SchoolTypeId = strSchoolTypeId; //学校类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolEN.dicFldComparisonOp.ContainsKey(convXzSchool.SchoolTypeId) == false)
{
objvXzSchoolEN.dicFldComparisonOp.Add(convXzSchool.SchoolTypeId, strComparisonOp);
}
else
{
objvXzSchoolEN.dicFldComparisonOp[convXzSchool.SchoolTypeId] = strComparisonOp;
}
}
return objvXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolEN SetSchoolTypeName(this clsvXzSchoolEN objvXzSchoolEN, string strSchoolTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTypeName, 30, convXzSchool.SchoolTypeName);
objvXzSchoolEN.SchoolTypeName = strSchoolTypeName; //学校类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolEN.dicFldComparisonOp.ContainsKey(convXzSchool.SchoolTypeName) == false)
{
objvXzSchoolEN.dicFldComparisonOp.Add(convXzSchool.SchoolTypeName, strComparisonOp);
}
else
{
objvXzSchoolEN.dicFldComparisonOp[convXzSchool.SchoolTypeName] = strComparisonOp;
}
}
return objvXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolEN SetIsCurrentUse(this clsvXzSchoolEN objvXzSchoolEN, bool bolIsCurrentUse, string strComparisonOp="")
	{
objvXzSchoolEN.IsCurrentUse = bolIsCurrentUse; //是否当前使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolEN.dicFldComparisonOp.ContainsKey(convXzSchool.IsCurrentUse) == false)
{
objvXzSchoolEN.dicFldComparisonOp.Add(convXzSchool.IsCurrentUse, strComparisonOp);
}
else
{
objvXzSchoolEN.dicFldComparisonOp[convXzSchool.IsCurrentUse] = strComparisonOp;
}
}
return objvXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolEN SetUpdDate(this clsvXzSchoolEN objvXzSchoolEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convXzSchool.UpdDate);
objvXzSchoolEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolEN.dicFldComparisonOp.ContainsKey(convXzSchool.UpdDate) == false)
{
objvXzSchoolEN.dicFldComparisonOp.Add(convXzSchool.UpdDate, strComparisonOp);
}
else
{
objvXzSchoolEN.dicFldComparisonOp[convXzSchool.UpdDate] = strComparisonOp;
}
}
return objvXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolEN SetUpdUserId(this clsvXzSchoolEN objvXzSchoolEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convXzSchool.UpdUserId);
objvXzSchoolEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolEN.dicFldComparisonOp.ContainsKey(convXzSchool.UpdUserId) == false)
{
objvXzSchoolEN.dicFldComparisonOp.Add(convXzSchool.UpdUserId, strComparisonOp);
}
else
{
objvXzSchoolEN.dicFldComparisonOp[convXzSchool.UpdUserId] = strComparisonOp;
}
}
return objvXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolEN SetMemo(this clsvXzSchoolEN objvXzSchoolEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzSchool.Memo);
objvXzSchoolEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolEN.dicFldComparisonOp.ContainsKey(convXzSchool.Memo) == false)
{
objvXzSchoolEN.dicFldComparisonOp.Add(convXzSchool.Memo, strComparisonOp);
}
else
{
objvXzSchoolEN.dicFldComparisonOp[convXzSchool.Memo] = strComparisonOp;
}
}
return objvXzSchoolEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzSchoolEN objvXzSchool_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzSchool_Cond.IsUpdated(convXzSchool.id_School) == true)
{
string strComparisonOp_id_School = objvXzSchool_Cond.dicFldComparisonOp[convXzSchool.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchool.id_School, objvXzSchool_Cond.id_School, strComparisonOp_id_School);
}
if (objvXzSchool_Cond.IsUpdated(convXzSchool.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvXzSchool_Cond.dicFldComparisonOp[convXzSchool.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchool.SchoolId, objvXzSchool_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvXzSchool_Cond.IsUpdated(convXzSchool.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvXzSchool_Cond.dicFldComparisonOp[convXzSchool.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchool.SchoolName, objvXzSchool_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvXzSchool_Cond.IsUpdated(convXzSchool.SchoolNameA) == true)
{
string strComparisonOp_SchoolNameA = objvXzSchool_Cond.dicFldComparisonOp[convXzSchool.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchool.SchoolNameA, objvXzSchool_Cond.SchoolNameA, strComparisonOp_SchoolNameA);
}
if (objvXzSchool_Cond.IsUpdated(convXzSchool.SchoolTypeId) == true)
{
string strComparisonOp_SchoolTypeId = objvXzSchool_Cond.dicFldComparisonOp[convXzSchool.SchoolTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchool.SchoolTypeId, objvXzSchool_Cond.SchoolTypeId, strComparisonOp_SchoolTypeId);
}
if (objvXzSchool_Cond.IsUpdated(convXzSchool.SchoolTypeName) == true)
{
string strComparisonOp_SchoolTypeName = objvXzSchool_Cond.dicFldComparisonOp[convXzSchool.SchoolTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchool.SchoolTypeName, objvXzSchool_Cond.SchoolTypeName, strComparisonOp_SchoolTypeName);
}
if (objvXzSchool_Cond.IsUpdated(convXzSchool.IsCurrentUse) == true)
{
if (objvXzSchool_Cond.IsCurrentUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzSchool.IsCurrentUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzSchool.IsCurrentUse);
}
}
if (objvXzSchool_Cond.IsUpdated(convXzSchool.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvXzSchool_Cond.dicFldComparisonOp[convXzSchool.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchool.UpdDate, objvXzSchool_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvXzSchool_Cond.IsUpdated(convXzSchool.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvXzSchool_Cond.dicFldComparisonOp[convXzSchool.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchool.UpdUserId, objvXzSchool_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvXzSchool_Cond.IsUpdated(convXzSchool.Memo) == true)
{
string strComparisonOp_Memo = objvXzSchool_Cond.dicFldComparisonOp[convXzSchool.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchool.Memo, objvXzSchool_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学校(vXzSchool)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvXzSchoolWApi
{
private static readonly string mstrApiControllerName = "vXzSchoolApi";

 public clsvXzSchoolWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_School(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v学校]...","0");
List<clsvXzSchoolEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_School";
objDDL.DataTextField="SchoolName";
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
public static void BindCbo_id_School(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzSchool.id_School); 
List<clsvXzSchoolEN> arrObjLst = clsvXzSchoolWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzSchoolEN objvXzSchoolEN = new clsvXzSchoolEN()
{
id_School = "0",
SchoolName = "选[v学校]..."
};
arrObjLst.Insert(0, objvXzSchoolEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzSchool.id_School;
objComboBox.DisplayMember = convXzSchool.SchoolName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_School">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzSchoolEN GetObjByid_School(string strid_School)
{
string strAction = "GetObjByid_School";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzSchoolEN objvXzSchoolEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_School"] = strid_School
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzSchoolEN = JsonConvert.DeserializeObject<clsvXzSchoolEN>((string)jobjReturn["ReturnObj"]);
return objvXzSchoolEN;
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
 /// <param name = "strid_School">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzSchoolEN GetObjByid_School_WA_Cache(string strid_School)
{
string strAction = "GetObjByid_School_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzSchoolEN objvXzSchoolEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_School"] = strid_School
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzSchoolEN = JsonConvert.DeserializeObject<clsvXzSchoolEN>((string)jobjReturn["ReturnObj"]);
return objvXzSchoolEN;
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
public static clsvXzSchoolEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzSchoolEN objvXzSchoolEN = null;
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
objvXzSchoolEN = JsonConvert.DeserializeObject<clsvXzSchoolEN>((string)jobjReturn["ReturnObj"]);
return objvXzSchoolEN;
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
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzSchoolEN GetObjByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzSchoolEN._CurrTabName_S);
List<clsvXzSchoolEN> arrvXzSchoolObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzSchoolEN> arrvXzSchoolObjLst_Sel =
from objvXzSchoolEN in arrvXzSchoolObjLst_Cache
where objvXzSchoolEN.id_School == strid_School
select objvXzSchoolEN;
if (arrvXzSchoolObjLst_Sel.Count() == 0)
{
   clsvXzSchoolEN obj = clsvXzSchoolWApi.GetObjByid_School(strid_School);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvXzSchoolObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSchoolNameByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzSchoolEN._CurrTabName_S);
List<clsvXzSchoolEN> arrvXzSchoolObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzSchoolEN> arrvXzSchoolObjLst_Sel1 =
from objvXzSchoolEN in arrvXzSchoolObjLst_Cache
where objvXzSchoolEN.id_School == strid_School
select objvXzSchoolEN;
List <clsvXzSchoolEN> arrvXzSchoolObjLst_Sel = new List<clsvXzSchoolEN>();
foreach (clsvXzSchoolEN obj in arrvXzSchoolObjLst_Sel1)
{
arrvXzSchoolObjLst_Sel.Add(obj);
}
if (arrvXzSchoolObjLst_Sel.Count > 0)
{
return arrvXzSchoolObjLst_Sel[0].SchoolName;
}
string strErrMsgForGetObjById = string.Format("在vXzSchool对象缓存列表中,找不到记录[id_School = {0}](函数:{1})", strid_School, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzSchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzSchoolEN._CurrTabName_S);
List<clsvXzSchoolEN> arrvXzSchoolObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzSchoolEN> arrvXzSchoolObjLst_Sel1 =
from objvXzSchoolEN in arrvXzSchoolObjLst_Cache
where objvXzSchoolEN.id_School == strid_School
select objvXzSchoolEN;
List <clsvXzSchoolEN> arrvXzSchoolObjLst_Sel = new List<clsvXzSchoolEN>();
foreach (clsvXzSchoolEN obj in arrvXzSchoolObjLst_Sel1)
{
arrvXzSchoolObjLst_Sel.Add(obj);
}
if (arrvXzSchoolObjLst_Sel.Count > 0)
{
return arrvXzSchoolObjLst_Sel[0].SchoolName;
}
string strErrMsgForGetObjById = string.Format("在vXzSchool对象缓存列表中,找不到记录的相关名称[id_School = {0}](函数:{1})", strid_School, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzSchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzSchoolEN> GetObjLst(string strWhereCond)
{
 List<clsvXzSchoolEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzSchoolEN> GetObjLstById_SchoolLst(List<string> arrId_School)
{
 List<clsvXzSchoolEN> arrObjLst = null; 
string strAction = "GetObjLstById_SchoolLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_School);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvXzSchoolEN> GetObjLstById_SchoolLst_Cache(List<string> arrId_School)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzSchoolEN._CurrTabName_S);
List<clsvXzSchoolEN> arrvXzSchoolObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzSchoolEN> arrvXzSchoolObjLst_Sel =
from objvXzSchoolEN in arrvXzSchoolObjLst_Cache
where arrId_School.Contains(objvXzSchoolEN.id_School)
select objvXzSchoolEN;
return arrvXzSchoolObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzSchoolEN> GetObjLstById_SchoolLst_WA_Cache(List<string> arrId_School)
{
 List<clsvXzSchoolEN> arrObjLst = null; 
string strAction = "GetObjLstById_SchoolLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_School);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzSchoolEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvXzSchoolEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzSchoolEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvXzSchoolEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzSchoolEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvXzSchoolEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzSchoolEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvXzSchoolEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_School)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_School"] = strid_School
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
 /// <param name = "objvXzSchoolENS">源对象</param>
 /// <param name = "objvXzSchoolENT">目标对象</param>
 public static void CopyTo(clsvXzSchoolEN objvXzSchoolENS, clsvXzSchoolEN objvXzSchoolENT)
{
try
{
objvXzSchoolENT.id_School = objvXzSchoolENS.id_School; //学校流水号
objvXzSchoolENT.SchoolId = objvXzSchoolENS.SchoolId; //学校编号
objvXzSchoolENT.SchoolName = objvXzSchoolENS.SchoolName; //学校名称
objvXzSchoolENT.SchoolNameA = objvXzSchoolENS.SchoolNameA; //学校简称
objvXzSchoolENT.SchoolTypeId = objvXzSchoolENS.SchoolTypeId; //学校类型Id
objvXzSchoolENT.SchoolTypeName = objvXzSchoolENS.SchoolTypeName; //学校类型名
objvXzSchoolENT.IsCurrentUse = objvXzSchoolENS.IsCurrentUse; //是否当前使用
objvXzSchoolENT.UpdDate = objvXzSchoolENS.UpdDate; //修改日期
objvXzSchoolENT.UpdUserId = objvXzSchoolENS.UpdUserId; //修改用户Id
objvXzSchoolENT.Memo = objvXzSchoolENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvXzSchoolEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvXzSchoolEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvXzSchoolEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvXzSchoolEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvXzSchoolEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvXzSchoolEN.AttributeName)
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
if (clsSchoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSchoolTypeWApi没有刷新缓存机制(clsSchoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_School");
//if (arrvXzSchoolObjLst_Cache == null)
//{
//arrvXzSchoolObjLst_Cache = await clsvXzSchoolWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvXzSchoolEN._CurrTabName_S);
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
public static List<clsvXzSchoolEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvXzSchoolEN._CurrTabName_S);
List<clsvXzSchoolEN> arrvXzSchoolObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzSchoolObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvXzSchoolEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convXzSchool.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchool.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchool.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchool.SchoolNameA, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchool.SchoolTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchool.SchoolTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchool.IsCurrentUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzSchool.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchool.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchool.Memo, Type.GetType("System.String"));
foreach (clsvXzSchoolEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convXzSchool.id_School] = objInFor[convXzSchool.id_School];
objDR[convXzSchool.SchoolId] = objInFor[convXzSchool.SchoolId];
objDR[convXzSchool.SchoolName] = objInFor[convXzSchool.SchoolName];
objDR[convXzSchool.SchoolNameA] = objInFor[convXzSchool.SchoolNameA];
objDR[convXzSchool.SchoolTypeId] = objInFor[convXzSchool.SchoolTypeId];
objDR[convXzSchool.SchoolTypeName] = objInFor[convXzSchool.SchoolTypeName];
objDR[convXzSchool.IsCurrentUse] = objInFor[convXzSchool.IsCurrentUse];
objDR[convXzSchool.UpdDate] = objInFor[convXzSchool.UpdDate];
objDR[convXzSchool.UpdUserId] = objInFor[convXzSchool.UpdUserId];
objDR[convXzSchool.Memo] = objInFor[convXzSchool.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}