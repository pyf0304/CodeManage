
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWritingOnBBCaseTypeWApi
 表名:WritingOnBBCaseType(01120526)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:38
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播
 模块英文名:WritingOnBlackboard
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
public static class clsWritingOnBBCaseTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseTypeEN Setid_WritingOnBBCaseType(this clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN, string strid_WritingOnBBCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_WritingOnBBCaseType, 4, conWritingOnBBCaseType.id_WritingOnBBCaseType);
clsCheckSql.CheckFieldForeignKey(strid_WritingOnBBCaseType, 4, conWritingOnBBCaseType.id_WritingOnBBCaseType);
objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType = strid_WritingOnBBCaseType; //板书案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseTypeEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCaseType.id_WritingOnBBCaseType) == false)
{
objWritingOnBBCaseTypeEN.dicFldComparisonOp.Add(conWritingOnBBCaseType.id_WritingOnBBCaseType, strComparisonOp);
}
else
{
objWritingOnBBCaseTypeEN.dicFldComparisonOp[conWritingOnBBCaseType.id_WritingOnBBCaseType] = strComparisonOp;
}
}
return objWritingOnBBCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseTypeEN SetWritingOnBBCaseTypeID(this clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN, string strWritingOnBBCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseTypeID, conWritingOnBBCaseType.WritingOnBBCaseTypeID);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTypeID, 4, conWritingOnBBCaseType.WritingOnBBCaseTypeID);
clsCheckSql.CheckFieldForeignKey(strWritingOnBBCaseTypeID, 4, conWritingOnBBCaseType.WritingOnBBCaseTypeID);
objWritingOnBBCaseTypeEN.WritingOnBBCaseTypeID = strWritingOnBBCaseTypeID; //板书案例类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseTypeEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCaseType.WritingOnBBCaseTypeID) == false)
{
objWritingOnBBCaseTypeEN.dicFldComparisonOp.Add(conWritingOnBBCaseType.WritingOnBBCaseTypeID, strComparisonOp);
}
else
{
objWritingOnBBCaseTypeEN.dicFldComparisonOp[conWritingOnBBCaseType.WritingOnBBCaseTypeID] = strComparisonOp;
}
}
return objWritingOnBBCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseTypeEN SetWritingOnBBCaseTypeName(this clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN, string strWritingOnBBCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseTypeName, conWritingOnBBCaseType.WritingOnBBCaseTypeName);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseTypeName, 50, conWritingOnBBCaseType.WritingOnBBCaseTypeName);
objWritingOnBBCaseTypeEN.WritingOnBBCaseTypeName = strWritingOnBBCaseTypeName; //板书案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseTypeEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCaseType.WritingOnBBCaseTypeName) == false)
{
objWritingOnBBCaseTypeEN.dicFldComparisonOp.Add(conWritingOnBBCaseType.WritingOnBBCaseTypeName, strComparisonOp);
}
else
{
objWritingOnBBCaseTypeEN.dicFldComparisonOp[conWritingOnBBCaseType.WritingOnBBCaseTypeName] = strComparisonOp;
}
}
return objWritingOnBBCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWritingOnBBCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsWritingOnBBCaseTypeEN SetMemo(this clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conWritingOnBBCaseType.Memo);
objWritingOnBBCaseTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWritingOnBBCaseTypeEN.dicFldComparisonOp.ContainsKey(conWritingOnBBCaseType.Memo) == false)
{
objWritingOnBBCaseTypeEN.dicFldComparisonOp.Add(conWritingOnBBCaseType.Memo, strComparisonOp);
}
else
{
objWritingOnBBCaseTypeEN.dicFldComparisonOp[conWritingOnBBCaseType.Memo] = strComparisonOp;
}
}
return objWritingOnBBCaseTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsWritingOnBBCaseTypeEN objWritingOnBBCaseType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objWritingOnBBCaseType_Cond.IsUpdated(conWritingOnBBCaseType.id_WritingOnBBCaseType) == true)
{
string strComparisonOp_id_WritingOnBBCaseType = objWritingOnBBCaseType_Cond.dicFldComparisonOp[conWritingOnBBCaseType.id_WritingOnBBCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCaseType.id_WritingOnBBCaseType, objWritingOnBBCaseType_Cond.id_WritingOnBBCaseType, strComparisonOp_id_WritingOnBBCaseType);
}
if (objWritingOnBBCaseType_Cond.IsUpdated(conWritingOnBBCaseType.WritingOnBBCaseTypeID) == true)
{
string strComparisonOp_WritingOnBBCaseTypeID = objWritingOnBBCaseType_Cond.dicFldComparisonOp[conWritingOnBBCaseType.WritingOnBBCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCaseType.WritingOnBBCaseTypeID, objWritingOnBBCaseType_Cond.WritingOnBBCaseTypeID, strComparisonOp_WritingOnBBCaseTypeID);
}
if (objWritingOnBBCaseType_Cond.IsUpdated(conWritingOnBBCaseType.WritingOnBBCaseTypeName) == true)
{
string strComparisonOp_WritingOnBBCaseTypeName = objWritingOnBBCaseType_Cond.dicFldComparisonOp[conWritingOnBBCaseType.WritingOnBBCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCaseType.WritingOnBBCaseTypeName, objWritingOnBBCaseType_Cond.WritingOnBBCaseTypeName, strComparisonOp_WritingOnBBCaseTypeName);
}
if (objWritingOnBBCaseType_Cond.IsUpdated(conWritingOnBBCaseType.Memo) == true)
{
string strComparisonOp_Memo = objWritingOnBBCaseType_Cond.dicFldComparisonOp[conWritingOnBBCaseType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWritingOnBBCaseType.Memo, objWritingOnBBCaseType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objWritingOnBBCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN)
{
 if (string.IsNullOrEmpty(objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objWritingOnBBCaseTypeEN.sf_UpdFldSetStr = objWritingOnBBCaseTypeEN.getsf_UpdFldSetStr();
clsWritingOnBBCaseTypeWApi.CheckPropertyNew(objWritingOnBBCaseTypeEN); 
bool bolResult = clsWritingOnBBCaseTypeWApi.UpdateRecord(objWritingOnBBCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseTypeWApi.ReFreshCache();
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
 /// <param name = "objWritingOnBBCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN)
{
 if (string.IsNullOrEmpty(objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsWritingOnBBCaseTypeWApi.IsExist(objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsWritingOnBBCaseTypeWApi.CheckPropertyNew(objWritingOnBBCaseTypeEN); 
bool bolResult = clsWritingOnBBCaseTypeWApi.AddNewRecord(objWritingOnBBCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseTypeWApi.ReFreshCache();
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
 /// <param name = "objWritingOnBBCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN)
{
try
{
clsWritingOnBBCaseTypeWApi.CheckPropertyNew(objWritingOnBBCaseTypeEN); 
string strid_WritingOnBBCaseType = clsWritingOnBBCaseTypeWApi.AddNewRecordWithMaxId(objWritingOnBBCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseTypeWApi.ReFreshCache();
return strid_WritingOnBBCaseType;
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
 /// <param name = "objWritingOnBBCaseTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN, string strWhereCond)
{
try
{
clsWritingOnBBCaseTypeWApi.CheckPropertyNew(objWritingOnBBCaseTypeEN); 
bool bolResult = clsWritingOnBBCaseTypeWApi.UpdateWithCondition(objWritingOnBBCaseTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseTypeWApi.ReFreshCache();
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
 /// 板书案例类型(WritingOnBBCaseType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsWritingOnBBCaseTypeWApi
{
private static readonly string mstrApiControllerName = "WritingOnBBCaseTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsWritingOnBBCaseTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_WritingOnBBCaseType(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[板书案例类型]...","0");
List<clsWritingOnBBCaseTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_WritingOnBBCaseType";
objDDL.DataTextField="WritingOnBBCaseTypeName";
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
public static void BindCbo_id_WritingOnBBCaseType(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conWritingOnBBCaseType.id_WritingOnBBCaseType); 
List<clsWritingOnBBCaseTypeEN> arrObjLst = clsWritingOnBBCaseTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN = new clsWritingOnBBCaseTypeEN()
{
id_WritingOnBBCaseType = "0",
WritingOnBBCaseTypeName = "选[板书案例类型]..."
};
arrObjLst.Insert(0, objWritingOnBBCaseTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conWritingOnBBCaseType.id_WritingOnBBCaseType;
objComboBox.DisplayMember = conWritingOnBBCaseType.WritingOnBBCaseTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN)
{
if (!Object.Equals(null, objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType) && GetStrLen(objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType) > 4)
{
 throw new Exception("字段[板书案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objWritingOnBBCaseTypeEN.WritingOnBBCaseTypeID) && GetStrLen(objWritingOnBBCaseTypeEN.WritingOnBBCaseTypeID) > 4)
{
 throw new Exception("字段[板书案例类型ID]的长度不能超过4!");
}
if (!Object.Equals(null, objWritingOnBBCaseTypeEN.WritingOnBBCaseTypeName) && GetStrLen(objWritingOnBBCaseTypeEN.WritingOnBBCaseTypeName) > 50)
{
 throw new Exception("字段[板书案例类型名称]的长度不能超过50!");
}
if (!Object.Equals(null, objWritingOnBBCaseTypeEN.Memo) && GetStrLen(objWritingOnBBCaseTypeEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objWritingOnBBCaseTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_WritingOnBBCaseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsWritingOnBBCaseTypeEN GetObjByid_WritingOnBBCaseType(string strid_WritingOnBBCaseType)
{
string strAction = "GetObjByid_WritingOnBBCaseType";
string strErrMsg = string.Empty;
string strResult = "";
clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_WritingOnBBCaseType"] = strid_WritingOnBBCaseType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objWritingOnBBCaseTypeEN = JsonConvert.DeserializeObject<clsWritingOnBBCaseTypeEN>((string)jobjReturn["ReturnObj"]);
return objWritingOnBBCaseTypeEN;
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
 /// <param name = "strid_WritingOnBBCaseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsWritingOnBBCaseTypeEN GetObjByid_WritingOnBBCaseType_WA_Cache(string strid_WritingOnBBCaseType)
{
string strAction = "GetObjByid_WritingOnBBCaseType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_WritingOnBBCaseType"] = strid_WritingOnBBCaseType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objWritingOnBBCaseTypeEN = JsonConvert.DeserializeObject<clsWritingOnBBCaseTypeEN>((string)jobjReturn["ReturnObj"]);
return objWritingOnBBCaseTypeEN;
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
public static clsWritingOnBBCaseTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN = null;
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
objWritingOnBBCaseTypeEN = JsonConvert.DeserializeObject<clsWritingOnBBCaseTypeEN>((string)jobjReturn["ReturnObj"]);
return objWritingOnBBCaseTypeEN;
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
 /// <param name = "strid_WritingOnBBCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsWritingOnBBCaseTypeEN GetObjByid_WritingOnBBCaseType_Cache(string strid_WritingOnBBCaseType)
{
if (string.IsNullOrEmpty(strid_WritingOnBBCaseType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsWritingOnBBCaseTypeEN._CurrTabName_S);
List<clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Sel =
from objWritingOnBBCaseTypeEN in arrWritingOnBBCaseTypeObjLst_Cache
where objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType == strid_WritingOnBBCaseType
select objWritingOnBBCaseTypeEN;
if (arrWritingOnBBCaseTypeObjLst_Sel.Count() == 0)
{
   clsWritingOnBBCaseTypeEN obj = clsWritingOnBBCaseTypeWApi.GetObjByid_WritingOnBBCaseType(strid_WritingOnBBCaseType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrWritingOnBBCaseTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_WritingOnBBCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetWritingOnBBCaseTypeNameByid_WritingOnBBCaseType_Cache(string strid_WritingOnBBCaseType)
{
if (string.IsNullOrEmpty(strid_WritingOnBBCaseType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsWritingOnBBCaseTypeEN._CurrTabName_S);
List<clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Sel1 =
from objWritingOnBBCaseTypeEN in arrWritingOnBBCaseTypeObjLst_Cache
where objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType == strid_WritingOnBBCaseType
select objWritingOnBBCaseTypeEN;
List <clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Sel = new List<clsWritingOnBBCaseTypeEN>();
foreach (clsWritingOnBBCaseTypeEN obj in arrWritingOnBBCaseTypeObjLst_Sel1)
{
arrWritingOnBBCaseTypeObjLst_Sel.Add(obj);
}
if (arrWritingOnBBCaseTypeObjLst_Sel.Count > 0)
{
return arrWritingOnBBCaseTypeObjLst_Sel[0].WritingOnBBCaseTypeName;
}
string strErrMsgForGetObjById = string.Format("在WritingOnBBCaseType对象缓存列表中,找不到记录[id_WritingOnBBCaseType = {0}](函数:{1})", strid_WritingOnBBCaseType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsWritingOnBBCaseTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_WritingOnBBCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_WritingOnBBCaseType_Cache(string strid_WritingOnBBCaseType)
{
if (string.IsNullOrEmpty(strid_WritingOnBBCaseType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsWritingOnBBCaseTypeEN._CurrTabName_S);
List<clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Sel1 =
from objWritingOnBBCaseTypeEN in arrWritingOnBBCaseTypeObjLst_Cache
where objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType == strid_WritingOnBBCaseType
select objWritingOnBBCaseTypeEN;
List <clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Sel = new List<clsWritingOnBBCaseTypeEN>();
foreach (clsWritingOnBBCaseTypeEN obj in arrWritingOnBBCaseTypeObjLst_Sel1)
{
arrWritingOnBBCaseTypeObjLst_Sel.Add(obj);
}
if (arrWritingOnBBCaseTypeObjLst_Sel.Count > 0)
{
return arrWritingOnBBCaseTypeObjLst_Sel[0].WritingOnBBCaseTypeName;
}
string strErrMsgForGetObjById = string.Format("在WritingOnBBCaseType对象缓存列表中,找不到记录的相关名称[id_WritingOnBBCaseType = {0}](函数:{1})", strid_WritingOnBBCaseType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsWritingOnBBCaseTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsWritingOnBBCaseTypeEN> GetObjLst(string strWhereCond)
{
 List<clsWritingOnBBCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsWritingOnBBCaseTypeEN> GetObjLstById_WritingOnBBCaseTypeLst(List<string> arrId_WritingOnBBCaseType)
{
 List<clsWritingOnBBCaseTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_WritingOnBBCaseTypeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WritingOnBBCaseType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_WritingOnBBCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsWritingOnBBCaseTypeEN> GetObjLstById_WritingOnBBCaseTypeLst_Cache(List<string> arrId_WritingOnBBCaseType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsWritingOnBBCaseTypeEN._CurrTabName_S);
List<clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Sel =
from objWritingOnBBCaseTypeEN in arrWritingOnBBCaseTypeObjLst_Cache
where arrId_WritingOnBBCaseType.Contains(objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType)
select objWritingOnBBCaseTypeEN;
return arrWritingOnBBCaseTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsWritingOnBBCaseTypeEN> GetObjLstById_WritingOnBBCaseTypeLst_WA_Cache(List<string> arrId_WritingOnBBCaseType)
{
 List<clsWritingOnBBCaseTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_WritingOnBBCaseTypeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WritingOnBBCaseType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsWritingOnBBCaseTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsWritingOnBBCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsWritingOnBBCaseTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsWritingOnBBCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsWritingOnBBCaseTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsWritingOnBBCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsWritingOnBBCaseTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsWritingOnBBCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWritingOnBBCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_WritingOnBBCaseType)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN = clsWritingOnBBCaseTypeWApi.GetObjByid_WritingOnBBCaseType(strid_WritingOnBBCaseType);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_WritingOnBBCaseType.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsWritingOnBBCaseTypeWApi.ReFreshCache();
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
public static int DelWritingOnBBCaseTypes(List<string> arrid_WritingOnBBCaseType)
{
string strAction = "DelWritingOnBBCaseTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_WritingOnBBCaseType);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsWritingOnBBCaseTypeWApi.ReFreshCache();
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
public static int DelWritingOnBBCaseTypesByCond(string strWhereCond)
{
string strAction = "DelWritingOnBBCaseTypesByCond";
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
public static bool AddNewRecord(clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWritingOnBBCaseTypeEN>(objWritingOnBBCaseTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWritingOnBBCaseTypeEN>(objWritingOnBBCaseTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWritingOnBBCaseTypeWApi.ReFreshCache();
var strid_WritingOnBBCaseType = (string)jobjReturn["ReturnStr"];
return strid_WritingOnBBCaseType;
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
public static bool UpdateRecord(clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN)
{
if (string.IsNullOrEmpty(objWritingOnBBCaseTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWritingOnBBCaseTypeEN>(objWritingOnBBCaseTypeEN);
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
 /// <param name = "objWritingOnBBCaseTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objWritingOnBBCaseTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objWritingOnBBCaseTypeEN.id_WritingOnBBCaseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWritingOnBBCaseTypeEN>(objWritingOnBBCaseTypeEN);
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
public static bool IsExist(string strid_WritingOnBBCaseType)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_WritingOnBBCaseType"] = strid_WritingOnBBCaseType
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
 /// <param name = "objWritingOnBBCaseTypeENS">源对象</param>
 /// <param name = "objWritingOnBBCaseTypeENT">目标对象</param>
 public static void CopyTo(clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeENS, clsWritingOnBBCaseTypeEN objWritingOnBBCaseTypeENT)
{
try
{
objWritingOnBBCaseTypeENT.id_WritingOnBBCaseType = objWritingOnBBCaseTypeENS.id_WritingOnBBCaseType; //板书案例类型流水号
objWritingOnBBCaseTypeENT.WritingOnBBCaseTypeID = objWritingOnBBCaseTypeENS.WritingOnBBCaseTypeID; //板书案例类型ID
objWritingOnBBCaseTypeENT.WritingOnBBCaseTypeName = objWritingOnBBCaseTypeENS.WritingOnBBCaseTypeName; //板书案例类型名称
objWritingOnBBCaseTypeENT.Memo = objWritingOnBBCaseTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsWritingOnBBCaseTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsWritingOnBBCaseTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsWritingOnBBCaseTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsWritingOnBBCaseTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsWritingOnBBCaseTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsWritingOnBBCaseTypeEN.AttributeName)
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
if (clsWritingOnBBCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWritingOnBBCaseTypeWApi没有刷新缓存机制(clsWritingOnBBCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_WritingOnBBCaseType");
//if (arrWritingOnBBCaseTypeObjLst_Cache == null)
//{
//arrWritingOnBBCaseTypeObjLst_Cache = await clsWritingOnBBCaseTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsWritingOnBBCaseTypeEN._CurrTabName_S);
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
if (clsWritingOnBBCaseTypeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsWritingOnBBCaseTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsWritingOnBBCaseTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsWritingOnBBCaseTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsWritingOnBBCaseTypeEN._CurrTabName_S);
List<clsWritingOnBBCaseTypeEN> arrWritingOnBBCaseTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrWritingOnBBCaseTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsWritingOnBBCaseTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conWritingOnBBCaseType.id_WritingOnBBCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCaseType.WritingOnBBCaseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCaseType.WritingOnBBCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conWritingOnBBCaseType.Memo, Type.GetType("System.String"));
foreach (clsWritingOnBBCaseTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conWritingOnBBCaseType.id_WritingOnBBCaseType] = objInFor[conWritingOnBBCaseType.id_WritingOnBBCaseType];
objDR[conWritingOnBBCaseType.WritingOnBBCaseTypeID] = objInFor[conWritingOnBBCaseType.WritingOnBBCaseTypeID];
objDR[conWritingOnBBCaseType.WritingOnBBCaseTypeName] = objInFor[conWritingOnBBCaseType.WritingOnBBCaseTypeName];
objDR[conWritingOnBBCaseType.Memo] = objInFor[conWritingOnBBCaseType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 板书案例类型(WritingOnBBCaseType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4WritingOnBBCaseType : clsCommFun4BL
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
clsWritingOnBBCaseTypeWApi.ReFreshThisCache();
}
}

}