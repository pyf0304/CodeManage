
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTypeWApi
 表名:vcc_CourseType(01120059)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:30
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
public static class clsvcc_CourseTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTypeEN SetCourseTypeID(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convcc_CourseType.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convcc_CourseType.CourseTypeID);
objvcc_CourseTypeEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.CourseTypeID) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.CourseTypeID, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.CourseTypeID] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTypeEN SetCourseTypeName(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeName, convcc_CourseType.CourseTypeName);
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convcc_CourseType.CourseTypeName);
objvcc_CourseTypeEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.CourseTypeName) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.CourseTypeName, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.CourseTypeName] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTypeEN Setid_School(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convcc_CourseType.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convcc_CourseType.id_School);
objvcc_CourseTypeEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.id_School) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.id_School, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.id_School] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTypeEN SetSchoolId(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convcc_CourseType.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convcc_CourseType.SchoolId);
objvcc_CourseTypeEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.SchoolId) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.SchoolId, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.SchoolId] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTypeEN SetSchoolName(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convcc_CourseType.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convcc_CourseType.SchoolName);
objvcc_CourseTypeEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.SchoolName) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.SchoolName, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.SchoolName] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTypeEN SetIsUse(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objvcc_CourseTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.IsUse) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.IsUse, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.IsUse] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTypeEN SetUpdDate(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseType.UpdDate);
objvcc_CourseTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.UpdDate) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTypeEN SetUpdUserId(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_CourseType.UpdUserId);
objvcc_CourseTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.UpdUserId) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.UpdUserId, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.UpdUserId] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTypeEN SetMemo(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseType.Memo);
objvcc_CourseTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.Memo) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.Memo, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.Memo] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseTypeEN objvcc_CourseType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseType_Cond.IsUpdated(convcc_CourseType.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvcc_CourseType_Cond.dicFldComparisonOp[convcc_CourseType.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.CourseTypeID, objvcc_CourseType_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvcc_CourseType_Cond.IsUpdated(convcc_CourseType.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvcc_CourseType_Cond.dicFldComparisonOp[convcc_CourseType.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.CourseTypeName, objvcc_CourseType_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvcc_CourseType_Cond.IsUpdated(convcc_CourseType.id_School) == true)
{
string strComparisonOp_id_School = objvcc_CourseType_Cond.dicFldComparisonOp[convcc_CourseType.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.id_School, objvcc_CourseType_Cond.id_School, strComparisonOp_id_School);
}
if (objvcc_CourseType_Cond.IsUpdated(convcc_CourseType.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvcc_CourseType_Cond.dicFldComparisonOp[convcc_CourseType.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.SchoolId, objvcc_CourseType_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvcc_CourseType_Cond.IsUpdated(convcc_CourseType.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvcc_CourseType_Cond.dicFldComparisonOp[convcc_CourseType.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.SchoolName, objvcc_CourseType_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvcc_CourseType_Cond.IsUpdated(convcc_CourseType.IsUse) == true)
{
if (objvcc_CourseType_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseType.IsUse);
}
}
if (objvcc_CourseType_Cond.IsUpdated(convcc_CourseType.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseType_Cond.dicFldComparisonOp[convcc_CourseType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.UpdDate, objvcc_CourseType_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseType_Cond.IsUpdated(convcc_CourseType.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_CourseType_Cond.dicFldComparisonOp[convcc_CourseType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.UpdUserId, objvcc_CourseType_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_CourseType_Cond.IsUpdated(convcc_CourseType.Memo) == true)
{
string strComparisonOp_Memo = objvcc_CourseType_Cond.dicFldComparisonOp[convcc_CourseType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.Memo, objvcc_CourseType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程类型(vcc_CourseType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseTypeWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseTypeApi";

 public clsvcc_CourseTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CourseTypeID(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程类型]...","0");
List<clsvcc_CourseTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CourseTypeID";
objDDL.DataTextField="CourseTypeName";
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
public static void BindCbo_CourseTypeID(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convcc_CourseType.CourseTypeID); 
List<clsvcc_CourseTypeEN> arrObjLst = clsvcc_CourseTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN()
{
CourseTypeID = "0",
CourseTypeName = "选[v课程类型]..."
};
arrObjLst.Insert(0, objvcc_CourseTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convcc_CourseType.CourseTypeID;
objComboBox.DisplayMember = convcc_CourseType.CourseTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseTypeID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTypeEN GetObjByCourseTypeID(string strCourseTypeID)
{
string strAction = "GetObjByCourseTypeID";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseTypeEN objvcc_CourseTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseTypeID"] = strCourseTypeID
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseTypeEN = JsonConvert.DeserializeObject<clsvcc_CourseTypeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseTypeEN;
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
 /// <param name = "strCourseTypeID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTypeEN GetObjByCourseTypeID_WA_Cache(string strCourseTypeID)
{
string strAction = "GetObjByCourseTypeID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseTypeEN objvcc_CourseTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseTypeID"] = strCourseTypeID
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseTypeEN = JsonConvert.DeserializeObject<clsvcc_CourseTypeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseTypeEN;
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
public static clsvcc_CourseTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseTypeEN objvcc_CourseTypeEN = null;
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
objvcc_CourseTypeEN = JsonConvert.DeserializeObject<clsvcc_CourseTypeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseTypeEN;
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
 /// <param name = "strCourseTypeID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseTypeEN GetObjByCourseTypeID_Cache(string strCourseTypeID)
{
if (string.IsNullOrEmpty(strCourseTypeID) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_CourseTypeEN._CurrTabName_S);
List<clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Sel =
from objvcc_CourseTypeEN in arrvcc_CourseTypeObjLst_Cache
where objvcc_CourseTypeEN.CourseTypeID == strCourseTypeID
select objvcc_CourseTypeEN;
if (arrvcc_CourseTypeObjLst_Sel.Count() == 0)
{
   clsvcc_CourseTypeEN obj = clsvcc_CourseTypeWApi.GetObjByCourseTypeID(strCourseTypeID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCourseTypeID">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseTypeNameByCourseTypeID_Cache(string strCourseTypeID)
{
if (string.IsNullOrEmpty(strCourseTypeID) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_CourseTypeEN._CurrTabName_S);
List<clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Sel1 =
from objvcc_CourseTypeEN in arrvcc_CourseTypeObjLst_Cache
where objvcc_CourseTypeEN.CourseTypeID == strCourseTypeID
select objvcc_CourseTypeEN;
List <clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Sel = new List<clsvcc_CourseTypeEN>();
foreach (clsvcc_CourseTypeEN obj in arrvcc_CourseTypeObjLst_Sel1)
{
arrvcc_CourseTypeObjLst_Sel.Add(obj);
}
if (arrvcc_CourseTypeObjLst_Sel.Count > 0)
{
return arrvcc_CourseTypeObjLst_Sel[0].CourseTypeName;
}
string strErrMsgForGetObjById = string.Format("在vcc_CourseType对象缓存列表中,找不到记录[CourseTypeID = {0}](函数:{1})", strCourseTypeID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvcc_CourseTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCourseTypeID">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseTypeID_Cache(string strCourseTypeID)
{
if (string.IsNullOrEmpty(strCourseTypeID) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_CourseTypeEN._CurrTabName_S);
List<clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Sel1 =
from objvcc_CourseTypeEN in arrvcc_CourseTypeObjLst_Cache
where objvcc_CourseTypeEN.CourseTypeID == strCourseTypeID
select objvcc_CourseTypeEN;
List <clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Sel = new List<clsvcc_CourseTypeEN>();
foreach (clsvcc_CourseTypeEN obj in arrvcc_CourseTypeObjLst_Sel1)
{
arrvcc_CourseTypeObjLst_Sel.Add(obj);
}
if (arrvcc_CourseTypeObjLst_Sel.Count > 0)
{
return arrvcc_CourseTypeObjLst_Sel[0].CourseTypeName;
}
string strErrMsgForGetObjById = string.Format("在vcc_CourseType对象缓存列表中,找不到记录的相关名称[CourseTypeID = {0}](函数:{1})", strCourseTypeID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvcc_CourseTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTypeEN> GetObjLstByCourseTypeIDLst(List<string> arrCourseTypeID)
{
 List<clsvcc_CourseTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseTypeIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseTypeID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strCourseTypeID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_CourseTypeEN> GetObjLstByCourseTypeIDLst_Cache(List<string> arrCourseTypeID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_CourseTypeEN._CurrTabName_S);
List<clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Sel =
from objvcc_CourseTypeEN in arrvcc_CourseTypeObjLst_Cache
where arrCourseTypeID.Contains(objvcc_CourseTypeEN.CourseTypeID)
select objvcc_CourseTypeEN;
return arrvcc_CourseTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTypeEN> GetObjLstByCourseTypeIDLst_WA_Cache(List<string> arrCourseTypeID)
{
 List<clsvcc_CourseTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseTypeIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseTypeID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strCourseTypeID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseTypeID"] = strCourseTypeID
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
 /// <param name = "objvcc_CourseTypeENS">源对象</param>
 /// <param name = "objvcc_CourseTypeENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseTypeEN objvcc_CourseTypeENS, clsvcc_CourseTypeEN objvcc_CourseTypeENT)
{
try
{
objvcc_CourseTypeENT.CourseTypeID = objvcc_CourseTypeENS.CourseTypeID; //课程类型ID
objvcc_CourseTypeENT.CourseTypeName = objvcc_CourseTypeENS.CourseTypeName; //课程类型名称
objvcc_CourseTypeENT.id_School = objvcc_CourseTypeENS.id_School; //学校流水号
objvcc_CourseTypeENT.SchoolId = objvcc_CourseTypeENS.SchoolId; //学校编号
objvcc_CourseTypeENT.SchoolName = objvcc_CourseTypeENS.SchoolName; //学校名称
objvcc_CourseTypeENT.IsUse = objvcc_CourseTypeENS.IsUse; //是否使用
objvcc_CourseTypeENT.UpdDate = objvcc_CourseTypeENS.UpdDate; //修改日期
objvcc_CourseTypeENT.UpdUserId = objvcc_CourseTypeENS.UpdUserId; //修改用户Id
objvcc_CourseTypeENT.Memo = objvcc_CourseTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_CourseTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseTypeEN.AttributeName)
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
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseTypeID");
//if (arrvcc_CourseTypeObjLst_Cache == null)
//{
//arrvcc_CourseTypeObjLst_Cache = await clsvcc_CourseTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_CourseTypeEN._CurrTabName_S);
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
public static List<clsvcc_CourseTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_CourseTypeEN._CurrTabName_S);
List<clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_CourseTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseType.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseType.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseType.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseType.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseType.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseType.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseType.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseType.Memo, Type.GetType("System.String"));
foreach (clsvcc_CourseTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseType.CourseTypeID] = objInFor[convcc_CourseType.CourseTypeID];
objDR[convcc_CourseType.CourseTypeName] = objInFor[convcc_CourseType.CourseTypeName];
objDR[convcc_CourseType.id_School] = objInFor[convcc_CourseType.id_School];
objDR[convcc_CourseType.SchoolId] = objInFor[convcc_CourseType.SchoolId];
objDR[convcc_CourseType.SchoolName] = objInFor[convcc_CourseType.SchoolName];
objDR[convcc_CourseType.IsUse] = objInFor[convcc_CourseType.IsUse];
objDR[convcc_CourseType.UpdDate] = objInFor[convcc_CourseType.UpdDate];
objDR[convcc_CourseType.UpdUserId] = objInFor[convcc_CourseType.UpdUserId];
objDR[convcc_CourseType.Memo] = objInFor[convcc_CourseType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}