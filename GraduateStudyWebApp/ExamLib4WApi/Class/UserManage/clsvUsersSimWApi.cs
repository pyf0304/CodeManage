
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersSimWApi
 表名:vUsersSim(01120699)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:43
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
public static class clsvUsersSimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersSimEN SetUserId(this clsvUsersSimEN objvUsersSimEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convUsersSim.UserId);
objvUsersSimEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.UserId) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.UserId, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.UserId] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersSimEN SetUserName(this clsvUsersSimEN objvUsersSimEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convUsersSim.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convUsersSim.UserName);
objvUsersSimEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.UserName) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.UserName, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.UserName] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersSimEN SetIsGSuser(this clsvUsersSimEN objvUsersSimEN, bool bolIsGSuser, string strComparisonOp="")
	{
objvUsersSimEN.IsGSuser = bolIsGSuser; //是否GS用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.IsGSuser) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.IsGSuser, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.IsGSuser] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersSimEN SetCollegeName(this clsvUsersSimEN objvUsersSimEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convUsersSim.CollegeName);
objvUsersSimEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.CollegeName) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.CollegeName, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.CollegeName] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersSimEN Setid_XzCollege(this clsvUsersSimEN objvUsersSimEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convUsersSim.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convUsersSim.id_XzCollege);
objvUsersSimEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.id_XzCollege) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.id_XzCollege, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.id_XzCollege] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersSimEN Setid_XzMajor(this clsvUsersSimEN objvUsersSimEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convUsersSim.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convUsersSim.id_XzMajor);
objvUsersSimEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.id_XzMajor) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.id_XzMajor, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.id_XzMajor] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersSimEN SetMajorName(this clsvUsersSimEN objvUsersSimEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convUsersSim.MajorName);
objvUsersSimEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.MajorName) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.MajorName, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.MajorName] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUsersSimEN SetHeadPic(this clsvUsersSimEN objvUsersSimEN, string strHeadPic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHeadPic, 500, convUsersSim.HeadPic);
objvUsersSimEN.HeadPic = strHeadPic; //头像
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.HeadPic) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.HeadPic, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.HeadPic] = strComparisonOp;
}
}
return objvUsersSimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUsersSimEN objvUsersSim_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUsersSim_Cond.IsUpdated(convUsersSim.UserId) == true)
{
string strComparisonOp_UserId = objvUsersSim_Cond.dicFldComparisonOp[convUsersSim.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.UserId, objvUsersSim_Cond.UserId, strComparisonOp_UserId);
}
if (objvUsersSim_Cond.IsUpdated(convUsersSim.UserName) == true)
{
string strComparisonOp_UserName = objvUsersSim_Cond.dicFldComparisonOp[convUsersSim.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.UserName, objvUsersSim_Cond.UserName, strComparisonOp_UserName);
}
if (objvUsersSim_Cond.IsUpdated(convUsersSim.IsGSuser) == true)
{
if (objvUsersSim_Cond.IsGSuser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsersSim.IsGSuser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsersSim.IsGSuser);
}
}
if (objvUsersSim_Cond.IsUpdated(convUsersSim.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvUsersSim_Cond.dicFldComparisonOp[convUsersSim.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.CollegeName, objvUsersSim_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvUsersSim_Cond.IsUpdated(convUsersSim.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvUsersSim_Cond.dicFldComparisonOp[convUsersSim.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.id_XzCollege, objvUsersSim_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvUsersSim_Cond.IsUpdated(convUsersSim.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvUsersSim_Cond.dicFldComparisonOp[convUsersSim.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.id_XzMajor, objvUsersSim_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvUsersSim_Cond.IsUpdated(convUsersSim.MajorName) == true)
{
string strComparisonOp_MajorName = objvUsersSim_Cond.dicFldComparisonOp[convUsersSim.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.MajorName, objvUsersSim_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvUsersSim_Cond.IsUpdated(convUsersSim.HeadPic) == true)
{
string strComparisonOp_HeadPic = objvUsersSim_Cond.dicFldComparisonOp[convUsersSim.HeadPic];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.HeadPic, objvUsersSim_Cond.HeadPic, strComparisonOp_HeadPic);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vUsersSim(vUsersSim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUsersSimWApi
{
private static readonly string mstrApiControllerName = "vUsersSimApi";

 public clsvUsersSimWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vUsersSim]...","0");
List<clsvUsersSimEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="UserId";
objDDL.DataTextField="UserName";
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
public static void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convUsersSim.UserId); 
List<clsvUsersSimEN> arrObjLst = clsvUsersSimWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN()
{
UserId = "0",
UserName = "选[vUsersSim]..."
};
arrObjLst.Insert(0, objvUsersSimEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convUsersSim.UserId;
objComboBox.DisplayMember = convUsersSim.UserName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsersSimEN GetObjByUserId(string strUserId)
{
string strAction = "GetObjByUserId";
string strErrMsg = string.Empty;
string strResult = "";
clsvUsersSimEN objvUsersSimEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["UserId"] = strUserId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvUsersSimEN = JsonConvert.DeserializeObject<clsvUsersSimEN>((string)jobjReturn["ReturnObj"]);
return objvUsersSimEN;
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
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsersSimEN GetObjByUserId_WA_Cache(string strUserId)
{
string strAction = "GetObjByUserId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvUsersSimEN objvUsersSimEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["UserId"] = strUserId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvUsersSimEN = JsonConvert.DeserializeObject<clsvUsersSimEN>((string)jobjReturn["ReturnObj"]);
return objvUsersSimEN;
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
public static clsvUsersSimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvUsersSimEN objvUsersSimEN = null;
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
objvUsersSimEN = JsonConvert.DeserializeObject<clsvUsersSimEN>((string)jobjReturn["ReturnObj"]);
return objvUsersSimEN;
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
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUsersSimEN GetObjByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvUsersSimEN._CurrTabName_S);
List<clsvUsersSimEN> arrvUsersSimObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersSimEN> arrvUsersSimObjLst_Sel =
from objvUsersSimEN in arrvUsersSimObjLst_Cache
where objvUsersSimEN.UserId == strUserId
select objvUsersSimEN;
if (arrvUsersSimObjLst_Sel.Count() == 0)
{
   clsvUsersSimEN obj = clsvUsersSimWApi.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvUsersSimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserNameByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvUsersSimEN._CurrTabName_S);
List<clsvUsersSimEN> arrvUsersSimObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersSimEN> arrvUsersSimObjLst_Sel1 =
from objvUsersSimEN in arrvUsersSimObjLst_Cache
where objvUsersSimEN.UserId == strUserId
select objvUsersSimEN;
List <clsvUsersSimEN> arrvUsersSimObjLst_Sel = new List<clsvUsersSimEN>();
foreach (clsvUsersSimEN obj in arrvUsersSimObjLst_Sel1)
{
arrvUsersSimObjLst_Sel.Add(obj);
}
if (arrvUsersSimObjLst_Sel.Count > 0)
{
return arrvUsersSimObjLst_Sel[0].UserName;
}
string strErrMsgForGetObjById = string.Format("在vUsersSim对象缓存列表中,找不到记录[UserId = {0}](函数:{1})", strUserId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvUsersSimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvUsersSimEN._CurrTabName_S);
List<clsvUsersSimEN> arrvUsersSimObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersSimEN> arrvUsersSimObjLst_Sel1 =
from objvUsersSimEN in arrvUsersSimObjLst_Cache
where objvUsersSimEN.UserId == strUserId
select objvUsersSimEN;
List <clsvUsersSimEN> arrvUsersSimObjLst_Sel = new List<clsvUsersSimEN>();
foreach (clsvUsersSimEN obj in arrvUsersSimObjLst_Sel1)
{
arrvUsersSimObjLst_Sel.Add(obj);
}
if (arrvUsersSimObjLst_Sel.Count > 0)
{
return arrvUsersSimObjLst_Sel[0].UserName;
}
string strErrMsgForGetObjById = string.Format("在vUsersSim对象缓存列表中,找不到记录的相关名称[UserId = {0}](函数:{1})", strUserId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvUsersSimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersSimEN> GetObjLst(string strWhereCond)
{
 List<clsvUsersSimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUsersSimEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsvUsersSimEN> arrObjLst = null; 
string strAction = "GetObjLstByUserIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvUsersSimEN> GetObjLstByUserIdLst_Cache(List<string> arrUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvUsersSimEN._CurrTabName_S);
List<clsvUsersSimEN> arrvUsersSimObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUsersSimEN> arrvUsersSimObjLst_Sel =
from objvUsersSimEN in arrvUsersSimObjLst_Cache
where arrUserId.Contains(objvUsersSimEN.UserId)
select objvUsersSimEN;
return arrvUsersSimObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersSimEN> GetObjLstByUserIdLst_WA_Cache(List<string> arrUserId)
{
 List<clsvUsersSimEN> arrObjLst = null; 
string strAction = "GetObjLstByUserIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUsersSimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUsersSimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUsersSimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUsersSimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUsersSimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUsersSimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUsersSimEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvUsersSimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strUserId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["UserId"] = strUserId
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
 /// <param name = "objvUsersSimENS">源对象</param>
 /// <param name = "objvUsersSimENT">目标对象</param>
 public static void CopyTo(clsvUsersSimEN objvUsersSimENS, clsvUsersSimEN objvUsersSimENT)
{
try
{
objvUsersSimENT.UserId = objvUsersSimENS.UserId; //用户ID
objvUsersSimENT.UserName = objvUsersSimENS.UserName; //用户名
objvUsersSimENT.IsGSuser = objvUsersSimENS.IsGSuser; //是否GS用户
objvUsersSimENT.CollegeName = objvUsersSimENS.CollegeName; //学院名称
objvUsersSimENT.id_XzCollege = objvUsersSimENS.id_XzCollege; //学院流水号
objvUsersSimENT.id_XzMajor = objvUsersSimENS.id_XzMajor; //专业流水号
objvUsersSimENT.MajorName = objvUsersSimENS.MajorName; //专业名称
objvUsersSimENT.HeadPic = objvUsersSimENS.HeadPic; //头像
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
public static DataTable ToDataTable(List<clsvUsersSimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUsersSimEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUsersSimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUsersSimEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUsersSimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUsersSimEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrvUsersSimObjLst_Cache == null)
//{
//arrvUsersSimObjLst_Cache = await clsvUsersSimWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvUsersSimEN._CurrTabName_S);
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
public static List<clsvUsersSimEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvUsersSimEN._CurrTabName_S);
List<clsvUsersSimEN> arrvUsersSimObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUsersSimObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvUsersSimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUsersSim.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUsersSim.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convUsersSim.IsGSuser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUsersSim.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convUsersSim.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convUsersSim.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convUsersSim.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convUsersSim.HeadPic, Type.GetType("System.String"));
foreach (clsvUsersSimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUsersSim.UserId] = objInFor[convUsersSim.UserId];
objDR[convUsersSim.UserName] = objInFor[convUsersSim.UserName];
objDR[convUsersSim.IsGSuser] = objInFor[convUsersSim.IsGSuser];
objDR[convUsersSim.CollegeName] = objInFor[convUsersSim.CollegeName];
objDR[convUsersSim.id_XzCollege] = objInFor[convUsersSim.id_XzCollege];
objDR[convUsersSim.id_XzMajor] = objInFor[convUsersSim.id_XzMajor];
objDR[convUsersSim.MajorName] = objInFor[convUsersSim.MajorName];
objDR[convUsersSim.HeadPic] = objInFor[convUsersSim.HeadPic];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}