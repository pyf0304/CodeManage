
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExcellentTypeWApi
 表名:vcc_ExcellentType(01120063)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:19
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvcc_ExcellentTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetExcellentTypeId(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strExcellentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTypeId, 4, convcc_ExcellentType.ExcellentTypeId);
clsCheckSql.CheckFieldForeignKey(strExcellentTypeId, 4, convcc_ExcellentType.ExcellentTypeId);
objvcc_ExcellentTypeEN.ExcellentTypeId = strExcellentTypeId; //精品课程类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.ExcellentTypeId) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.ExcellentTypeId, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.ExcellentTypeId] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetExcellentTypeName(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strExcellentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTypeName, 30, convcc_ExcellentType.ExcellentTypeName);
objvcc_ExcellentTypeEN.ExcellentTypeName = strExcellentTypeName; //精品课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.ExcellentTypeName) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.ExcellentTypeName, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.ExcellentTypeName] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExcellentTypeEN Setid_School(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convcc_ExcellentType.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convcc_ExcellentType.id_School);
objvcc_ExcellentTypeEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.id_School) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.id_School, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.id_School] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetSchoolId(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convcc_ExcellentType.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convcc_ExcellentType.SchoolId);
objvcc_ExcellentTypeEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.SchoolId) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.SchoolId, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.SchoolId] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetSchoolName(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convcc_ExcellentType.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convcc_ExcellentType.SchoolName);
objvcc_ExcellentTypeEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.SchoolName) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.SchoolName, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.SchoolName] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetIsUse(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objvcc_ExcellentTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.IsUse) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.IsUse, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.IsUse] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetUpdDate(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExcellentType.UpdDate);
objvcc_ExcellentTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.UpdDate) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.UpdDate, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.UpdDate] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetUpdUserId(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExcellentType.UpdUserId);
objvcc_ExcellentTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.UpdUserId) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.UpdUserId, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.UpdUserId] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetMemo(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExcellentType.Memo);
objvcc_ExcellentTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.Memo) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.Memo, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.Memo] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExcellentTypeEN objvcc_ExcellentType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExcellentType_Cond.IsUpdated(convcc_ExcellentType.ExcellentTypeId) == true)
{
string strComparisonOp_ExcellentTypeId = objvcc_ExcellentType_Cond.dicFldComparisonOp[convcc_ExcellentType.ExcellentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.ExcellentTypeId, objvcc_ExcellentType_Cond.ExcellentTypeId, strComparisonOp_ExcellentTypeId);
}
if (objvcc_ExcellentType_Cond.IsUpdated(convcc_ExcellentType.ExcellentTypeName) == true)
{
string strComparisonOp_ExcellentTypeName = objvcc_ExcellentType_Cond.dicFldComparisonOp[convcc_ExcellentType.ExcellentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.ExcellentTypeName, objvcc_ExcellentType_Cond.ExcellentTypeName, strComparisonOp_ExcellentTypeName);
}
if (objvcc_ExcellentType_Cond.IsUpdated(convcc_ExcellentType.id_School) == true)
{
string strComparisonOp_id_School = objvcc_ExcellentType_Cond.dicFldComparisonOp[convcc_ExcellentType.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.id_School, objvcc_ExcellentType_Cond.id_School, strComparisonOp_id_School);
}
if (objvcc_ExcellentType_Cond.IsUpdated(convcc_ExcellentType.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvcc_ExcellentType_Cond.dicFldComparisonOp[convcc_ExcellentType.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.SchoolId, objvcc_ExcellentType_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvcc_ExcellentType_Cond.IsUpdated(convcc_ExcellentType.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvcc_ExcellentType_Cond.dicFldComparisonOp[convcc_ExcellentType.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.SchoolName, objvcc_ExcellentType_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvcc_ExcellentType_Cond.IsUpdated(convcc_ExcellentType.IsUse) == true)
{
if (objvcc_ExcellentType_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExcellentType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExcellentType.IsUse);
}
}
if (objvcc_ExcellentType_Cond.IsUpdated(convcc_ExcellentType.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_ExcellentType_Cond.dicFldComparisonOp[convcc_ExcellentType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.UpdDate, objvcc_ExcellentType_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_ExcellentType_Cond.IsUpdated(convcc_ExcellentType.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_ExcellentType_Cond.dicFldComparisonOp[convcc_ExcellentType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.UpdUserId, objvcc_ExcellentType_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_ExcellentType_Cond.IsUpdated(convcc_ExcellentType.Memo) == true)
{
string strComparisonOp_Memo = objvcc_ExcellentType_Cond.dicFldComparisonOp[convcc_ExcellentType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.Memo, objvcc_ExcellentType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v精品课程类型(vcc_ExcellentType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExcellentTypeWApi
{
private static readonly string mstrApiControllerName = "vcc_ExcellentTypeApi";

 public clsvcc_ExcellentTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ExcellentTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v精品课程类型]...","0");
List<clsvcc_ExcellentTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ExcellentTypeId";
objDDL.DataTextField="ExcellentTypeName";
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
public static void BindCbo_ExcellentTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convcc_ExcellentType.ExcellentTypeId); 
List<clsvcc_ExcellentTypeEN> arrObjLst = clsvcc_ExcellentTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN()
{
ExcellentTypeId = "0",
ExcellentTypeName = "选[v精品课程类型]..."
};
arrObjLst.Insert(0, objvcc_ExcellentTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convcc_ExcellentType.ExcellentTypeId;
objComboBox.DisplayMember = convcc_ExcellentType.ExcellentTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strExcellentTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExcellentTypeEN GetObjByExcellentTypeId(string strExcellentTypeId)
{
string strAction = "GetObjByExcellentTypeId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ExcellentTypeId"] = strExcellentTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_ExcellentTypeEN = JsonConvert.DeserializeObject<clsvcc_ExcellentTypeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExcellentTypeEN;
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
 /// <param name = "strExcellentTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExcellentTypeEN GetObjByExcellentTypeId_WA_Cache(string strExcellentTypeId)
{
string strAction = "GetObjByExcellentTypeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ExcellentTypeId"] = strExcellentTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_ExcellentTypeEN = JsonConvert.DeserializeObject<clsvcc_ExcellentTypeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExcellentTypeEN;
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
public static clsvcc_ExcellentTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = null;
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
objvcc_ExcellentTypeEN = JsonConvert.DeserializeObject<clsvcc_ExcellentTypeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExcellentTypeEN;
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
 /// <param name = "strExcellentTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExcellentTypeEN GetObjByExcellentTypeId_Cache(string strExcellentTypeId)
{
if (string.IsNullOrEmpty(strExcellentTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_ExcellentTypeEN._CurrTabName_S);
List<clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Sel =
from objvcc_ExcellentTypeEN in arrvcc_ExcellentTypeObjLst_Cache
where objvcc_ExcellentTypeEN.ExcellentTypeId == strExcellentTypeId
select objvcc_ExcellentTypeEN;
if (arrvcc_ExcellentTypeObjLst_Sel.Count() == 0)
{
   clsvcc_ExcellentTypeEN obj = clsvcc_ExcellentTypeWApi.GetObjByExcellentTypeId(strExcellentTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_ExcellentTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strExcellentTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetExcellentTypeNameByExcellentTypeId_Cache(string strExcellentTypeId)
{
if (string.IsNullOrEmpty(strExcellentTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_ExcellentTypeEN._CurrTabName_S);
List<clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Sel1 =
from objvcc_ExcellentTypeEN in arrvcc_ExcellentTypeObjLst_Cache
where objvcc_ExcellentTypeEN.ExcellentTypeId == strExcellentTypeId
select objvcc_ExcellentTypeEN;
List <clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Sel = new List<clsvcc_ExcellentTypeEN>();
foreach (clsvcc_ExcellentTypeEN obj in arrvcc_ExcellentTypeObjLst_Sel1)
{
arrvcc_ExcellentTypeObjLst_Sel.Add(obj);
}
if (arrvcc_ExcellentTypeObjLst_Sel.Count > 0)
{
return arrvcc_ExcellentTypeObjLst_Sel[0].ExcellentTypeName;
}
string strErrMsgForGetObjById = string.Format("在vcc_ExcellentType对象缓存列表中,找不到记录[ExcellentTypeId = {0}](函数:{1})", strExcellentTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvcc_ExcellentTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strExcellentTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByExcellentTypeId_Cache(string strExcellentTypeId)
{
if (string.IsNullOrEmpty(strExcellentTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_ExcellentTypeEN._CurrTabName_S);
List<clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Sel1 =
from objvcc_ExcellentTypeEN in arrvcc_ExcellentTypeObjLst_Cache
where objvcc_ExcellentTypeEN.ExcellentTypeId == strExcellentTypeId
select objvcc_ExcellentTypeEN;
List <clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Sel = new List<clsvcc_ExcellentTypeEN>();
foreach (clsvcc_ExcellentTypeEN obj in arrvcc_ExcellentTypeObjLst_Sel1)
{
arrvcc_ExcellentTypeObjLst_Sel.Add(obj);
}
if (arrvcc_ExcellentTypeObjLst_Sel.Count > 0)
{
return arrvcc_ExcellentTypeObjLst_Sel[0].ExcellentTypeName;
}
string strErrMsgForGetObjById = string.Format("在vcc_ExcellentType对象缓存列表中,找不到记录的相关名称[ExcellentTypeId = {0}](函数:{1})", strExcellentTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvcc_ExcellentTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExcellentTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_ExcellentTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExcellentTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExcellentTypeEN> GetObjLstByExcellentTypeIdLst(List<string> arrExcellentTypeId)
{
 List<clsvcc_ExcellentTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByExcellentTypeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrExcellentTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExcellentTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strExcellentTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_ExcellentTypeEN> GetObjLstByExcellentTypeIdLst_Cache(List<string> arrExcellentTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_ExcellentTypeEN._CurrTabName_S);
List<clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Sel =
from objvcc_ExcellentTypeEN in arrvcc_ExcellentTypeObjLst_Cache
where arrExcellentTypeId.Contains(objvcc_ExcellentTypeEN.ExcellentTypeId)
select objvcc_ExcellentTypeEN;
return arrvcc_ExcellentTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExcellentTypeEN> GetObjLstByExcellentTypeIdLst_WA_Cache(List<string> arrExcellentTypeId)
{
 List<clsvcc_ExcellentTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByExcellentTypeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrExcellentTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExcellentTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExcellentTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_ExcellentTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExcellentTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExcellentTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_ExcellentTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExcellentTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExcellentTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_ExcellentTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExcellentTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExcellentTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_ExcellentTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExcellentTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strExcellentTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ExcellentTypeId"] = strExcellentTypeId
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
 /// <param name = "objvcc_ExcellentTypeENS">源对象</param>
 /// <param name = "objvcc_ExcellentTypeENT">目标对象</param>
 public static void CopyTo(clsvcc_ExcellentTypeEN objvcc_ExcellentTypeENS, clsvcc_ExcellentTypeEN objvcc_ExcellentTypeENT)
{
try
{
objvcc_ExcellentTypeENT.ExcellentTypeId = objvcc_ExcellentTypeENS.ExcellentTypeId; //精品课程类型Id
objvcc_ExcellentTypeENT.ExcellentTypeName = objvcc_ExcellentTypeENS.ExcellentTypeName; //精品课程类型名称
objvcc_ExcellentTypeENT.id_School = objvcc_ExcellentTypeENS.id_School; //学校流水号
objvcc_ExcellentTypeENT.SchoolId = objvcc_ExcellentTypeENS.SchoolId; //学校编号
objvcc_ExcellentTypeENT.SchoolName = objvcc_ExcellentTypeENS.SchoolName; //学校名称
objvcc_ExcellentTypeENT.IsUse = objvcc_ExcellentTypeENS.IsUse; //是否使用
objvcc_ExcellentTypeENT.UpdDate = objvcc_ExcellentTypeENS.UpdDate; //修改日期
objvcc_ExcellentTypeENT.UpdUserId = objvcc_ExcellentTypeENS.UpdUserId; //修改用户Id
objvcc_ExcellentTypeENT.Memo = objvcc_ExcellentTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_ExcellentTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_ExcellentTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_ExcellentTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_ExcellentTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_ExcellentTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_ExcellentTypeEN.AttributeName)
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
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ExcellentTypeId");
//if (arrvcc_ExcellentTypeObjLst_Cache == null)
//{
//arrvcc_ExcellentTypeObjLst_Cache = await clsvcc_ExcellentTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_ExcellentTypeEN._CurrTabName_S);
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
public static List<clsvcc_ExcellentTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_ExcellentTypeEN._CurrTabName_S);
List<clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_ExcellentTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_ExcellentTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_ExcellentType.ExcellentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExcellentType.ExcellentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExcellentType.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExcellentType.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExcellentType.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExcellentType.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExcellentType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExcellentType.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExcellentType.Memo, Type.GetType("System.String"));
foreach (clsvcc_ExcellentTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_ExcellentType.ExcellentTypeId] = objInFor[convcc_ExcellentType.ExcellentTypeId];
objDR[convcc_ExcellentType.ExcellentTypeName] = objInFor[convcc_ExcellentType.ExcellentTypeName];
objDR[convcc_ExcellentType.id_School] = objInFor[convcc_ExcellentType.id_School];
objDR[convcc_ExcellentType.SchoolId] = objInFor[convcc_ExcellentType.SchoolId];
objDR[convcc_ExcellentType.SchoolName] = objInFor[convcc_ExcellentType.SchoolName];
objDR[convcc_ExcellentType.IsUse] = objInFor[convcc_ExcellentType.IsUse];
objDR[convcc_ExcellentType.UpdDate] = objInFor[convcc_ExcellentType.UpdDate];
objDR[convcc_ExcellentType.UpdUserId] = objInFor[convcc_ExcellentType.UpdUserId];
objDR[convcc_ExcellentType.Memo] = objInFor[convcc_ExcellentType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}