
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSkillTypeWApi
 表名:vSkillType(01120311)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:01
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范
 模块英文名:SkillDemo
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
public static class clsvSkillTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSkillTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSkillTypeEN Setid_SkillType(this clsvSkillTypeEN objvSkillTypeEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convSkillType.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convSkillType.id_SkillType);
objvSkillTypeEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSkillTypeEN.dicFldComparisonOp.ContainsKey(convSkillType.id_SkillType) == false)
{
objvSkillTypeEN.dicFldComparisonOp.Add(convSkillType.id_SkillType, strComparisonOp);
}
else
{
objvSkillTypeEN.dicFldComparisonOp[convSkillType.id_SkillType] = strComparisonOp;
}
}
return objvSkillTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSkillTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSkillTypeEN SetSkillTypeID(this clsvSkillTypeEN objvSkillTypeEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeID, convSkillType.SkillTypeID);
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convSkillType.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convSkillType.SkillTypeID);
objvSkillTypeEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSkillTypeEN.dicFldComparisonOp.ContainsKey(convSkillType.SkillTypeID) == false)
{
objvSkillTypeEN.dicFldComparisonOp.Add(convSkillType.SkillTypeID, strComparisonOp);
}
else
{
objvSkillTypeEN.dicFldComparisonOp[convSkillType.SkillTypeID] = strComparisonOp;
}
}
return objvSkillTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSkillTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSkillTypeEN SetSkillTypeName(this clsvSkillTypeEN objvSkillTypeEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeName, convSkillType.SkillTypeName);
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convSkillType.SkillTypeName);
objvSkillTypeEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSkillTypeEN.dicFldComparisonOp.ContainsKey(convSkillType.SkillTypeName) == false)
{
objvSkillTypeEN.dicFldComparisonOp.Add(convSkillType.SkillTypeName, strComparisonOp);
}
else
{
objvSkillTypeEN.dicFldComparisonOp[convSkillType.SkillTypeName] = strComparisonOp;
}
}
return objvSkillTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSkillTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSkillTypeEN SetVersionNum01(this clsvSkillTypeEN objvSkillTypeEN, int intVersionNum01, string strComparisonOp="")
	{
objvSkillTypeEN.VersionNum01 = intVersionNum01; //VersionNum01
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSkillTypeEN.dicFldComparisonOp.ContainsKey(convSkillType.VersionNum01) == false)
{
objvSkillTypeEN.dicFldComparisonOp.Add(convSkillType.VersionNum01, strComparisonOp);
}
else
{
objvSkillTypeEN.dicFldComparisonOp[convSkillType.VersionNum01] = strComparisonOp;
}
}
return objvSkillTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSkillTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSkillTypeEN SetVersionNum02(this clsvSkillTypeEN objvSkillTypeEN, int intVersionNum02, string strComparisonOp="")
	{
objvSkillTypeEN.VersionNum02 = intVersionNum02; //VersionNum02
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSkillTypeEN.dicFldComparisonOp.ContainsKey(convSkillType.VersionNum02) == false)
{
objvSkillTypeEN.dicFldComparisonOp.Add(convSkillType.VersionNum02, strComparisonOp);
}
else
{
objvSkillTypeEN.dicFldComparisonOp[convSkillType.VersionNum02] = strComparisonOp;
}
}
return objvSkillTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSkillTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSkillTypeEN SetVersionNum03(this clsvSkillTypeEN objvSkillTypeEN, int intVersionNum03, string strComparisonOp="")
	{
objvSkillTypeEN.VersionNum03 = intVersionNum03; //VersionNum03
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSkillTypeEN.dicFldComparisonOp.ContainsKey(convSkillType.VersionNum03) == false)
{
objvSkillTypeEN.dicFldComparisonOp.Add(convSkillType.VersionNum03, strComparisonOp);
}
else
{
objvSkillTypeEN.dicFldComparisonOp[convSkillType.VersionNum03] = strComparisonOp;
}
}
return objvSkillTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSkillTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSkillTypeEN SetMemo(this clsvSkillTypeEN objvSkillTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSkillType.Memo);
objvSkillTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSkillTypeEN.dicFldComparisonOp.ContainsKey(convSkillType.Memo) == false)
{
objvSkillTypeEN.dicFldComparisonOp.Add(convSkillType.Memo, strComparisonOp);
}
else
{
objvSkillTypeEN.dicFldComparisonOp[convSkillType.Memo] = strComparisonOp;
}
}
return objvSkillTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSkillTypeEN objvSkillType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSkillType_Cond.IsUpdated(convSkillType.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvSkillType_Cond.dicFldComparisonOp[convSkillType.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSkillType.id_SkillType, objvSkillType_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvSkillType_Cond.IsUpdated(convSkillType.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvSkillType_Cond.dicFldComparisonOp[convSkillType.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSkillType.SkillTypeID, objvSkillType_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvSkillType_Cond.IsUpdated(convSkillType.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvSkillType_Cond.dicFldComparisonOp[convSkillType.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSkillType.SkillTypeName, objvSkillType_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvSkillType_Cond.IsUpdated(convSkillType.VersionNum01) == true)
{
string strComparisonOp_VersionNum01 = objvSkillType_Cond.dicFldComparisonOp[convSkillType.VersionNum01];
strWhereCond += string.Format(" And {0} {2} {1}", convSkillType.VersionNum01, objvSkillType_Cond.VersionNum01, strComparisonOp_VersionNum01);
}
if (objvSkillType_Cond.IsUpdated(convSkillType.VersionNum02) == true)
{
string strComparisonOp_VersionNum02 = objvSkillType_Cond.dicFldComparisonOp[convSkillType.VersionNum02];
strWhereCond += string.Format(" And {0} {2} {1}", convSkillType.VersionNum02, objvSkillType_Cond.VersionNum02, strComparisonOp_VersionNum02);
}
if (objvSkillType_Cond.IsUpdated(convSkillType.VersionNum03) == true)
{
string strComparisonOp_VersionNum03 = objvSkillType_Cond.dicFldComparisonOp[convSkillType.VersionNum03];
strWhereCond += string.Format(" And {0} {2} {1}", convSkillType.VersionNum03, objvSkillType_Cond.VersionNum03, strComparisonOp_VersionNum03);
}
if (objvSkillType_Cond.IsUpdated(convSkillType.Memo) == true)
{
string strComparisonOp_Memo = objvSkillType_Cond.dicFldComparisonOp[convSkillType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSkillType.Memo, objvSkillType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v技能类型(vSkillType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSkillTypeWApi
{
private static readonly string mstrApiControllerName = "vSkillTypeApi";

 public clsvSkillTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_SkillType(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v技能类型]...","0");
List<clsvSkillTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_SkillType";
objDDL.DataTextField="SkillTypeName";
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
public static void BindCbo_id_SkillType(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convSkillType.id_SkillType); 
List<clsvSkillTypeEN> arrObjLst = clsvSkillTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvSkillTypeEN objvSkillTypeEN = new clsvSkillTypeEN()
{
id_SkillType = "0",
SkillTypeName = "选[v技能类型]..."
};
arrObjLst.Insert(0, objvSkillTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convSkillType.id_SkillType;
objComboBox.DisplayMember = convSkillType.SkillTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_SkillType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSkillTypeEN GetObjByid_SkillType(string strid_SkillType)
{
string strAction = "GetObjByid_SkillType";
string strErrMsg = string.Empty;
string strResult = "";
clsvSkillTypeEN objvSkillTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SkillType"] = strid_SkillType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSkillTypeEN = JsonConvert.DeserializeObject<clsvSkillTypeEN>((string)jobjReturn["ReturnObj"]);
return objvSkillTypeEN;
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
 /// <param name = "strid_SkillType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSkillTypeEN GetObjByid_SkillType_WA_Cache(string strid_SkillType)
{
string strAction = "GetObjByid_SkillType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvSkillTypeEN objvSkillTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SkillType"] = strid_SkillType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSkillTypeEN = JsonConvert.DeserializeObject<clsvSkillTypeEN>((string)jobjReturn["ReturnObj"]);
return objvSkillTypeEN;
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
public static clsvSkillTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvSkillTypeEN objvSkillTypeEN = null;
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
objvSkillTypeEN = JsonConvert.DeserializeObject<clsvSkillTypeEN>((string)jobjReturn["ReturnObj"]);
return objvSkillTypeEN;
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
 /// <param name = "strid_SkillType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSkillTypeEN GetObjByid_SkillType_Cache(string strid_SkillType)
{
if (string.IsNullOrEmpty(strid_SkillType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvSkillTypeEN._CurrTabName_S);
List<clsvSkillTypeEN> arrvSkillTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSkillTypeEN> arrvSkillTypeObjLst_Sel =
from objvSkillTypeEN in arrvSkillTypeObjLst_Cache
where objvSkillTypeEN.id_SkillType == strid_SkillType
select objvSkillTypeEN;
if (arrvSkillTypeObjLst_Sel.Count() == 0)
{
   clsvSkillTypeEN obj = clsvSkillTypeWApi.GetObjByid_SkillType(strid_SkillType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvSkillTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_SkillType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSkillTypeNameByid_SkillType_Cache(string strid_SkillType)
{
if (string.IsNullOrEmpty(strid_SkillType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvSkillTypeEN._CurrTabName_S);
List<clsvSkillTypeEN> arrvSkillTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSkillTypeEN> arrvSkillTypeObjLst_Sel1 =
from objvSkillTypeEN in arrvSkillTypeObjLst_Cache
where objvSkillTypeEN.id_SkillType == strid_SkillType
select objvSkillTypeEN;
List <clsvSkillTypeEN> arrvSkillTypeObjLst_Sel = new List<clsvSkillTypeEN>();
foreach (clsvSkillTypeEN obj in arrvSkillTypeObjLst_Sel1)
{
arrvSkillTypeObjLst_Sel.Add(obj);
}
if (arrvSkillTypeObjLst_Sel.Count > 0)
{
return arrvSkillTypeObjLst_Sel[0].SkillTypeName;
}
string strErrMsgForGetObjById = string.Format("在vSkillType对象缓存列表中,找不到记录[id_SkillType = {0}](函数:{1})", strid_SkillType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvSkillTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_SkillType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_SkillType_Cache(string strid_SkillType)
{
if (string.IsNullOrEmpty(strid_SkillType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvSkillTypeEN._CurrTabName_S);
List<clsvSkillTypeEN> arrvSkillTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSkillTypeEN> arrvSkillTypeObjLst_Sel1 =
from objvSkillTypeEN in arrvSkillTypeObjLst_Cache
where objvSkillTypeEN.id_SkillType == strid_SkillType
select objvSkillTypeEN;
List <clsvSkillTypeEN> arrvSkillTypeObjLst_Sel = new List<clsvSkillTypeEN>();
foreach (clsvSkillTypeEN obj in arrvSkillTypeObjLst_Sel1)
{
arrvSkillTypeObjLst_Sel.Add(obj);
}
if (arrvSkillTypeObjLst_Sel.Count > 0)
{
return arrvSkillTypeObjLst_Sel[0].SkillTypeName;
}
string strErrMsgForGetObjById = string.Format("在vSkillType对象缓存列表中,找不到记录的相关名称[id_SkillType = {0}](函数:{1})", strid_SkillType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvSkillTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSkillTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvSkillTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSkillTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSkillTypeEN> GetObjLstById_SkillTypeLst(List<string> arrId_SkillType)
{
 List<clsvSkillTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_SkillTypeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_SkillType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSkillTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_SkillType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvSkillTypeEN> GetObjLstById_SkillTypeLst_Cache(List<string> arrId_SkillType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSkillTypeEN._CurrTabName_S);
List<clsvSkillTypeEN> arrvSkillTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSkillTypeEN> arrvSkillTypeObjLst_Sel =
from objvSkillTypeEN in arrvSkillTypeObjLst_Cache
where arrId_SkillType.Contains(objvSkillTypeEN.id_SkillType)
select objvSkillTypeEN;
return arrvSkillTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSkillTypeEN> GetObjLstById_SkillTypeLst_WA_Cache(List<string> arrId_SkillType)
{
 List<clsvSkillTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_SkillTypeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_SkillType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSkillTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSkillTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSkillTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSkillTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSkillTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSkillTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSkillTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSkillTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSkillTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSkillTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSkillTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvSkillTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSkillTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_SkillType)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SkillType"] = strid_SkillType
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
 /// <param name = "objvSkillTypeENS">源对象</param>
 /// <param name = "objvSkillTypeENT">目标对象</param>
 public static void CopyTo(clsvSkillTypeEN objvSkillTypeENS, clsvSkillTypeEN objvSkillTypeENT)
{
try
{
objvSkillTypeENT.id_SkillType = objvSkillTypeENS.id_SkillType; //技能类型流水号
objvSkillTypeENT.SkillTypeID = objvSkillTypeENS.SkillTypeID; //技能类型ID
objvSkillTypeENT.SkillTypeName = objvSkillTypeENS.SkillTypeName; //技能类型名称
objvSkillTypeENT.VersionNum01 = objvSkillTypeENS.VersionNum01; //VersionNum01
objvSkillTypeENT.VersionNum02 = objvSkillTypeENS.VersionNum02; //VersionNum02
objvSkillTypeENT.VersionNum03 = objvSkillTypeENS.VersionNum03; //VersionNum03
objvSkillTypeENT.Memo = objvSkillTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvSkillTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSkillTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSkillTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSkillTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSkillTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSkillTypeEN.AttributeName)
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
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_SkillType");
//if (arrvSkillTypeObjLst_Cache == null)
//{
//arrvSkillTypeObjLst_Cache = await clsvSkillTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvSkillTypeEN._CurrTabName_S);
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
public static List<clsvSkillTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvSkillTypeEN._CurrTabName_S);
List<clsvSkillTypeEN> arrvSkillTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSkillTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSkillTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSkillType.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convSkillType.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convSkillType.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSkillType.VersionNum01, Type.GetType("System.Int32"));
objDT.Columns.Add(convSkillType.VersionNum02, Type.GetType("System.Int32"));
objDT.Columns.Add(convSkillType.VersionNum03, Type.GetType("System.Int32"));
objDT.Columns.Add(convSkillType.Memo, Type.GetType("System.String"));
foreach (clsvSkillTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSkillType.id_SkillType] = objInFor[convSkillType.id_SkillType];
objDR[convSkillType.SkillTypeID] = objInFor[convSkillType.SkillTypeID];
objDR[convSkillType.SkillTypeName] = objInFor[convSkillType.SkillTypeName];
objDR[convSkillType.VersionNum01] = objInFor[convSkillType.VersionNum01];
objDR[convSkillType.VersionNum02] = objInFor[convSkillType.VersionNum02];
objDR[convSkillType.VersionNum03] = objInFor[convSkillType.VersionNum03];
objDR[convSkillType.Memo] = objInFor[convSkillType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}