
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppraiseTypeWApi
 表名:vAppraiseType(01120308)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:26
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
public static class clsvAppraiseTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeEN Setid_AppraiseType(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convAppraiseType.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convAppraiseType.id_AppraiseType);
objvAppraiseTypeEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.id_AppraiseType) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.id_AppraiseType, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.id_AppraiseType] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeEN SetAppraiseTypeID(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strAppraiseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeID, convAppraiseType.AppraiseTypeID);
clsCheckSql.CheckFieldLen(strAppraiseTypeID, 4, convAppraiseType.AppraiseTypeID);
clsCheckSql.CheckFieldForeignKey(strAppraiseTypeID, 4, convAppraiseType.AppraiseTypeID);
objvAppraiseTypeEN.AppraiseTypeID = strAppraiseTypeID; //评议类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.AppraiseTypeID) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.AppraiseTypeID, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.AppraiseTypeID] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeEN SetAppraiseTypeName(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeName, convAppraiseType.AppraiseTypeName);
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convAppraiseType.AppraiseTypeName);
objvAppraiseTypeEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.AppraiseTypeName) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.AppraiseTypeName, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.AppraiseTypeName] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeEN SetUserTypeId(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convAppraiseType.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convAppraiseType.UserTypeId);
objvAppraiseTypeEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.UserTypeId) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.UserTypeId, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.UserTypeId] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeEN SetUserTypeName(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convAppraiseType.UserTypeName);
objvAppraiseTypeEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.UserTypeName) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.UserTypeName, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.UserTypeName] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeEN SetMemo(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convAppraiseType.Memo);
objvAppraiseTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.Memo) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.Memo, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.Memo] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvAppraiseTypeEN objvAppraiseType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvAppraiseType_Cond.IsUpdated(convAppraiseType.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvAppraiseType_Cond.dicFldComparisonOp[convAppraiseType.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.id_AppraiseType, objvAppraiseType_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvAppraiseType_Cond.IsUpdated(convAppraiseType.AppraiseTypeID) == true)
{
string strComparisonOp_AppraiseTypeID = objvAppraiseType_Cond.dicFldComparisonOp[convAppraiseType.AppraiseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.AppraiseTypeID, objvAppraiseType_Cond.AppraiseTypeID, strComparisonOp_AppraiseTypeID);
}
if (objvAppraiseType_Cond.IsUpdated(convAppraiseType.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvAppraiseType_Cond.dicFldComparisonOp[convAppraiseType.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.AppraiseTypeName, objvAppraiseType_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvAppraiseType_Cond.IsUpdated(convAppraiseType.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvAppraiseType_Cond.dicFldComparisonOp[convAppraiseType.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.UserTypeId, objvAppraiseType_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvAppraiseType_Cond.IsUpdated(convAppraiseType.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvAppraiseType_Cond.dicFldComparisonOp[convAppraiseType.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.UserTypeName, objvAppraiseType_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvAppraiseType_Cond.IsUpdated(convAppraiseType.Memo) == true)
{
string strComparisonOp_Memo = objvAppraiseType_Cond.dicFldComparisonOp[convAppraiseType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.Memo, objvAppraiseType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v评议类型(vAppraiseType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvAppraiseTypeWApi
{
private static readonly string mstrApiControllerName = "vAppraiseTypeApi";

 public clsvAppraiseTypeWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v评议类型]...","0");
List<clsvAppraiseTypeEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convAppraiseType.id_AppraiseType); 
List<clsvAppraiseTypeEN> arrObjLst = clsvAppraiseTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN()
{
id_AppraiseType = "0",
AppraiseTypeName = "选[v评议类型]..."
};
arrObjLst.Insert(0, objvAppraiseTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convAppraiseType.id_AppraiseType;
objComboBox.DisplayMember = convAppraiseType.AppraiseTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_AppraiseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAppraiseTypeEN GetObjByid_AppraiseType(string strid_AppraiseType)
{
string strAction = "GetObjByid_AppraiseType";
string strErrMsg = string.Empty;
string strResult = "";
clsvAppraiseTypeEN objvAppraiseTypeEN = null;
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
objvAppraiseTypeEN = JsonConvert.DeserializeObject<clsvAppraiseTypeEN>((string)jobjReturn["ReturnObj"]);
return objvAppraiseTypeEN;
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
public static clsvAppraiseTypeEN GetObjByid_AppraiseType_WA_Cache(string strid_AppraiseType)
{
string strAction = "GetObjByid_AppraiseType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvAppraiseTypeEN objvAppraiseTypeEN = null;
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
objvAppraiseTypeEN = JsonConvert.DeserializeObject<clsvAppraiseTypeEN>((string)jobjReturn["ReturnObj"]);
return objvAppraiseTypeEN;
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
public static clsvAppraiseTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvAppraiseTypeEN objvAppraiseTypeEN = null;
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
objvAppraiseTypeEN = JsonConvert.DeserializeObject<clsvAppraiseTypeEN>((string)jobjReturn["ReturnObj"]);
return objvAppraiseTypeEN;
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
public static clsvAppraiseTypeEN GetObjByid_AppraiseType_Cache(string strid_AppraiseType)
{
if (string.IsNullOrEmpty(strid_AppraiseType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvAppraiseTypeEN._CurrTabName_S);
List<clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Sel =
from objvAppraiseTypeEN in arrvAppraiseTypeObjLst_Cache
where objvAppraiseTypeEN.id_AppraiseType == strid_AppraiseType
select objvAppraiseTypeEN;
if (arrvAppraiseTypeObjLst_Sel.Count() == 0)
{
   clsvAppraiseTypeEN obj = clsvAppraiseTypeWApi.GetObjByid_AppraiseType(strid_AppraiseType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvAppraiseTypeObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsvAppraiseTypeEN._CurrTabName_S);
List<clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Sel1 =
from objvAppraiseTypeEN in arrvAppraiseTypeObjLst_Cache
where objvAppraiseTypeEN.id_AppraiseType == strid_AppraiseType
select objvAppraiseTypeEN;
List <clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Sel = new List<clsvAppraiseTypeEN>();
foreach (clsvAppraiseTypeEN obj in arrvAppraiseTypeObjLst_Sel1)
{
arrvAppraiseTypeObjLst_Sel.Add(obj);
}
if (arrvAppraiseTypeObjLst_Sel.Count > 0)
{
return arrvAppraiseTypeObjLst_Sel[0].AppraiseTypeName;
}
string strErrMsgForGetObjById = string.Format("在vAppraiseType对象缓存列表中,找不到记录[id_AppraiseType = {0}](函数:{1})", strid_AppraiseType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvAppraiseTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsvAppraiseTypeEN._CurrTabName_S);
List<clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Sel1 =
from objvAppraiseTypeEN in arrvAppraiseTypeObjLst_Cache
where objvAppraiseTypeEN.id_AppraiseType == strid_AppraiseType
select objvAppraiseTypeEN;
List <clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Sel = new List<clsvAppraiseTypeEN>();
foreach (clsvAppraiseTypeEN obj in arrvAppraiseTypeObjLst_Sel1)
{
arrvAppraiseTypeObjLst_Sel.Add(obj);
}
if (arrvAppraiseTypeObjLst_Sel.Count > 0)
{
return arrvAppraiseTypeObjLst_Sel[0].AppraiseTypeName;
}
string strErrMsgForGetObjById = string.Format("在vAppraiseType对象缓存列表中,找不到记录的相关名称[id_AppraiseType = {0}](函数:{1})", strid_AppraiseType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvAppraiseTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppraiseTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAppraiseTypeEN> GetObjLstById_AppraiseTypeLst(List<string> arrId_AppraiseType)
{
 List<clsvAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvAppraiseTypeEN> GetObjLstById_AppraiseTypeLst_Cache(List<string> arrId_AppraiseType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvAppraiseTypeEN._CurrTabName_S);
List<clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Sel =
from objvAppraiseTypeEN in arrvAppraiseTypeObjLst_Cache
where arrId_AppraiseType.Contains(objvAppraiseTypeEN.id_AppraiseType)
select objvAppraiseTypeEN;
return arrvAppraiseTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppraiseTypeEN> GetObjLstById_AppraiseTypeLst_WA_Cache(List<string> arrId_AppraiseType)
{
 List<clsvAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAppraiseTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAppraiseTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAppraiseTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAppraiseTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvAppraiseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvAppraiseTypeENS">源对象</param>
 /// <param name = "objvAppraiseTypeENT">目标对象</param>
 public static void CopyTo(clsvAppraiseTypeEN objvAppraiseTypeENS, clsvAppraiseTypeEN objvAppraiseTypeENT)
{
try
{
objvAppraiseTypeENT.id_AppraiseType = objvAppraiseTypeENS.id_AppraiseType; //评议类型流水号
objvAppraiseTypeENT.AppraiseTypeID = objvAppraiseTypeENS.AppraiseTypeID; //评议类型ID
objvAppraiseTypeENT.AppraiseTypeName = objvAppraiseTypeENS.AppraiseTypeName; //评议类型名称
objvAppraiseTypeENT.UserTypeId = objvAppraiseTypeENS.UserTypeId; //用户类型Id
objvAppraiseTypeENT.UserTypeName = objvAppraiseTypeENS.UserTypeName; //用户类型名称
objvAppraiseTypeENT.Memo = objvAppraiseTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvAppraiseTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvAppraiseTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvAppraiseTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvAppraiseTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvAppraiseTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvAppraiseTypeEN.AttributeName)
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
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_AppraiseType");
//if (arrvAppraiseTypeObjLst_Cache == null)
//{
//arrvAppraiseTypeObjLst_Cache = await clsvAppraiseTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvAppraiseTypeEN._CurrTabName_S);
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
public static List<clsvAppraiseTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvAppraiseTypeEN._CurrTabName_S);
List<clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvAppraiseTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvAppraiseTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convAppraiseType.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseType.AppraiseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseType.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseType.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseType.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseType.Memo, Type.GetType("System.String"));
foreach (clsvAppraiseTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convAppraiseType.id_AppraiseType] = objInFor[convAppraiseType.id_AppraiseType];
objDR[convAppraiseType.AppraiseTypeID] = objInFor[convAppraiseType.AppraiseTypeID];
objDR[convAppraiseType.AppraiseTypeName] = objInFor[convAppraiseType.AppraiseTypeName];
objDR[convAppraiseType.UserTypeId] = objInFor[convAppraiseType.UserTypeId];
objDR[convAppraiseType.UserTypeName] = objInFor[convAppraiseType.UserTypeName];
objDR[convAppraiseType.Memo] = objInFor[convAppraiseType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}