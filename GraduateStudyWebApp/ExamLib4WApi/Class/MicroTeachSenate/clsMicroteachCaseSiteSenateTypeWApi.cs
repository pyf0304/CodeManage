
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseSiteSenateTypeWApi
 表名:MicroteachCaseSiteSenateType(01120502)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:49
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
public static class clsMicroteachCaseSiteSenateTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseSiteSenateTypeEN Setid_MicroteachCaseSiteSenateType(this clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN, string strid_MicroteachCaseSiteSenateType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCaseSiteSenateType, 4, conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCaseSiteSenateType, 4, conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType);
objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType = strid_MicroteachCaseSiteSenateType; //微格现场评价类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateTypeEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType) == false)
{
objMicroteachCaseSiteSenateTypeEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateTypeEN.dicFldComparisonOp[conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseSiteSenateTypeEN SetMicroteachCaseSiteSenateTypeID(this clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN, string strMicroteachCaseSiteSenateTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseSiteSenateTypeID, conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID);
clsCheckSql.CheckFieldLen(strMicroteachCaseSiteSenateTypeID, 4, conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseSiteSenateTypeID, 4, conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID);
objMicroteachCaseSiteSenateTypeEN.MicroteachCaseSiteSenateTypeID = strMicroteachCaseSiteSenateTypeID; //微格现场评价类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateTypeEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID) == false)
{
objMicroteachCaseSiteSenateTypeEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateTypeEN.dicFldComparisonOp[conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseSiteSenateTypeEN SetMicroteachCaseSiteSenateTypeName(this clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN, string strMicroteachCaseSiteSenateTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseSiteSenateTypeName, conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName);
clsCheckSql.CheckFieldLen(strMicroteachCaseSiteSenateTypeName, 50, conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName);
objMicroteachCaseSiteSenateTypeEN.MicroteachCaseSiteSenateTypeName = strMicroteachCaseSiteSenateTypeName; //微格现场评价类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateTypeEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName) == false)
{
objMicroteachCaseSiteSenateTypeEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateTypeEN.dicFldComparisonOp[conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachCaseSiteSenateType_Cond.IsUpdated(conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType) == true)
{
string strComparisonOp_id_MicroteachCaseSiteSenateType = objMicroteachCaseSiteSenateType_Cond.dicFldComparisonOp[conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType, objMicroteachCaseSiteSenateType_Cond.id_MicroteachCaseSiteSenateType, strComparisonOp_id_MicroteachCaseSiteSenateType);
}
if (objMicroteachCaseSiteSenateType_Cond.IsUpdated(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID) == true)
{
string strComparisonOp_MicroteachCaseSiteSenateTypeID = objMicroteachCaseSiteSenateType_Cond.dicFldComparisonOp[conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID, objMicroteachCaseSiteSenateType_Cond.MicroteachCaseSiteSenateTypeID, strComparisonOp_MicroteachCaseSiteSenateTypeID);
}
if (objMicroteachCaseSiteSenateType_Cond.IsUpdated(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName) == true)
{
string strComparisonOp_MicroteachCaseSiteSenateTypeName = objMicroteachCaseSiteSenateType_Cond.dicFldComparisonOp[conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName, objMicroteachCaseSiteSenateType_Cond.MicroteachCaseSiteSenateTypeName, strComparisonOp_MicroteachCaseSiteSenateTypeName);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objMicroteachCaseSiteSenateTypeEN.sf_UpdFldSetStr = objMicroteachCaseSiteSenateTypeEN.getsf_UpdFldSetStr();
clsMicroteachCaseSiteSenateTypeWApi.CheckPropertyNew(objMicroteachCaseSiteSenateTypeEN); 
bool bolResult = clsMicroteachCaseSiteSenateTypeWApi.UpdateRecord(objMicroteachCaseSiteSenateTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateTypeWApi.ReFreshCache();
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
 /// <param name = "objMicroteachCaseSiteSenateTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroteachCaseSiteSenateTypeWApi.IsExist(objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsMicroteachCaseSiteSenateTypeWApi.CheckPropertyNew(objMicroteachCaseSiteSenateTypeEN); 
bool bolResult = clsMicroteachCaseSiteSenateTypeWApi.AddNewRecord(objMicroteachCaseSiteSenateTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateTypeWApi.ReFreshCache();
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
 /// <param name = "objMicroteachCaseSiteSenateTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN)
{
try
{
clsMicroteachCaseSiteSenateTypeWApi.CheckPropertyNew(objMicroteachCaseSiteSenateTypeEN); 
string strid_MicroteachCaseSiteSenateType = clsMicroteachCaseSiteSenateTypeWApi.AddNewRecordWithMaxId(objMicroteachCaseSiteSenateTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateTypeWApi.ReFreshCache();
return strid_MicroteachCaseSiteSenateType;
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
 /// <param name = "objMicroteachCaseSiteSenateTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN, string strWhereCond)
{
try
{
clsMicroteachCaseSiteSenateTypeWApi.CheckPropertyNew(objMicroteachCaseSiteSenateTypeEN); 
bool bolResult = clsMicroteachCaseSiteSenateTypeWApi.UpdateWithCondition(objMicroteachCaseSiteSenateTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateTypeWApi.ReFreshCache();
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
 /// 微格现场评价类型(MicroteachCaseSiteSenateType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachCaseSiteSenateTypeWApi
{
private static readonly string mstrApiControllerName = "MicroteachCaseSiteSenateTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsMicroteachCaseSiteSenateTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_MicroteachCaseSiteSenateType(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[微格现场评价类型]...","0");
List<clsMicroteachCaseSiteSenateTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_MicroteachCaseSiteSenateType";
objDDL.DataTextField="MicroteachCaseSiteSenateTypeName";
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
public static void BindCbo_id_MicroteachCaseSiteSenateType(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType); 
List<clsMicroteachCaseSiteSenateTypeEN> arrObjLst = clsMicroteachCaseSiteSenateTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN = new clsMicroteachCaseSiteSenateTypeEN()
{
id_MicroteachCaseSiteSenateType = "0",
MicroteachCaseSiteSenateTypeName = "选[微格现场评价类型]..."
};
arrObjLst.Insert(0, objMicroteachCaseSiteSenateTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType;
objComboBox.DisplayMember = conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN)
{
if (!Object.Equals(null, objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType) && GetStrLen(objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType) > 4)
{
 throw new Exception("字段[微格现场评价类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseSiteSenateTypeEN.MicroteachCaseSiteSenateTypeID) && GetStrLen(objMicroteachCaseSiteSenateTypeEN.MicroteachCaseSiteSenateTypeID) > 4)
{
 throw new Exception("字段[微格现场评价类型ID]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseSiteSenateTypeEN.MicroteachCaseSiteSenateTypeName) && GetStrLen(objMicroteachCaseSiteSenateTypeEN.MicroteachCaseSiteSenateTypeName) > 50)
{
 throw new Exception("字段[微格现场评价类型名称]的长度不能超过50!");
}
 objMicroteachCaseSiteSenateTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_MicroteachCaseSiteSenateType">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseSiteSenateTypeEN GetObjByid_MicroteachCaseSiteSenateType(string strid_MicroteachCaseSiteSenateType)
{
string strAction = "GetObjByid_MicroteachCaseSiteSenateType";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCaseSiteSenateType"] = strid_MicroteachCaseSiteSenateType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objMicroteachCaseSiteSenateTypeEN = JsonConvert.DeserializeObject<clsMicroteachCaseSiteSenateTypeEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseSiteSenateTypeEN;
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
 /// <param name = "strid_MicroteachCaseSiteSenateType">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseSiteSenateTypeEN GetObjByid_MicroteachCaseSiteSenateType_WA_Cache(string strid_MicroteachCaseSiteSenateType)
{
string strAction = "GetObjByid_MicroteachCaseSiteSenateType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCaseSiteSenateType"] = strid_MicroteachCaseSiteSenateType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objMicroteachCaseSiteSenateTypeEN = JsonConvert.DeserializeObject<clsMicroteachCaseSiteSenateTypeEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseSiteSenateTypeEN;
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
public static clsMicroteachCaseSiteSenateTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN = null;
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
objMicroteachCaseSiteSenateTypeEN = JsonConvert.DeserializeObject<clsMicroteachCaseSiteSenateTypeEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseSiteSenateTypeEN;
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
 /// <param name = "strid_MicroteachCaseSiteSenateType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCaseSiteSenateTypeEN GetObjByid_MicroteachCaseSiteSenateType_Cache(string strid_MicroteachCaseSiteSenateType)
{
if (string.IsNullOrEmpty(strid_MicroteachCaseSiteSenateType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateTypeEN._CurrTabName_S);
List<clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Sel =
from objMicroteachCaseSiteSenateTypeEN in arrMicroteachCaseSiteSenateTypeObjLst_Cache
where objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType == strid_MicroteachCaseSiteSenateType
select objMicroteachCaseSiteSenateTypeEN;
if (arrMicroteachCaseSiteSenateTypeObjLst_Sel.Count() == 0)
{
   clsMicroteachCaseSiteSenateTypeEN obj = clsMicroteachCaseSiteSenateTypeWApi.GetObjByid_MicroteachCaseSiteSenateType(strid_MicroteachCaseSiteSenateType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrMicroteachCaseSiteSenateTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_MicroteachCaseSiteSenateType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMicroteachCaseSiteSenateTypeNameByid_MicroteachCaseSiteSenateType_Cache(string strid_MicroteachCaseSiteSenateType)
{
if (string.IsNullOrEmpty(strid_MicroteachCaseSiteSenateType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateTypeEN._CurrTabName_S);
List<clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Sel1 =
from objMicroteachCaseSiteSenateTypeEN in arrMicroteachCaseSiteSenateTypeObjLst_Cache
where objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType == strid_MicroteachCaseSiteSenateType
select objMicroteachCaseSiteSenateTypeEN;
List <clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Sel = new List<clsMicroteachCaseSiteSenateTypeEN>();
foreach (clsMicroteachCaseSiteSenateTypeEN obj in arrMicroteachCaseSiteSenateTypeObjLst_Sel1)
{
arrMicroteachCaseSiteSenateTypeObjLst_Sel.Add(obj);
}
if (arrMicroteachCaseSiteSenateTypeObjLst_Sel.Count > 0)
{
return arrMicroteachCaseSiteSenateTypeObjLst_Sel[0].MicroteachCaseSiteSenateTypeName;
}
string strErrMsgForGetObjById = string.Format("在MicroteachCaseSiteSenateType对象缓存列表中,找不到记录[id_MicroteachCaseSiteSenateType = {0}](函数:{1})", strid_MicroteachCaseSiteSenateType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsMicroteachCaseSiteSenateTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_MicroteachCaseSiteSenateType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_MicroteachCaseSiteSenateType_Cache(string strid_MicroteachCaseSiteSenateType)
{
if (string.IsNullOrEmpty(strid_MicroteachCaseSiteSenateType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateTypeEN._CurrTabName_S);
List<clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Sel1 =
from objMicroteachCaseSiteSenateTypeEN in arrMicroteachCaseSiteSenateTypeObjLst_Cache
where objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType == strid_MicroteachCaseSiteSenateType
select objMicroteachCaseSiteSenateTypeEN;
List <clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Sel = new List<clsMicroteachCaseSiteSenateTypeEN>();
foreach (clsMicroteachCaseSiteSenateTypeEN obj in arrMicroteachCaseSiteSenateTypeObjLst_Sel1)
{
arrMicroteachCaseSiteSenateTypeObjLst_Sel.Add(obj);
}
if (arrMicroteachCaseSiteSenateTypeObjLst_Sel.Count > 0)
{
return arrMicroteachCaseSiteSenateTypeObjLst_Sel[0].MicroteachCaseSiteSenateTypeName;
}
string strErrMsgForGetObjById = string.Format("在MicroteachCaseSiteSenateType对象缓存列表中,找不到记录的相关名称[id_MicroteachCaseSiteSenateType = {0}](函数:{1})", strid_MicroteachCaseSiteSenateType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsMicroteachCaseSiteSenateTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseSiteSenateTypeEN> GetObjLst(string strWhereCond)
{
 List<clsMicroteachCaseSiteSenateTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseSiteSenateTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseSiteSenateTypeEN> GetObjLstById_MicroteachCaseSiteSenateTypeLst(List<string> arrId_MicroteachCaseSiteSenateType)
{
 List<clsMicroteachCaseSiteSenateTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCaseSiteSenateTypeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCaseSiteSenateType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseSiteSenateTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_MicroteachCaseSiteSenateType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsMicroteachCaseSiteSenateTypeEN> GetObjLstById_MicroteachCaseSiteSenateTypeLst_Cache(List<string> arrId_MicroteachCaseSiteSenateType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateTypeEN._CurrTabName_S);
List<clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Sel =
from objMicroteachCaseSiteSenateTypeEN in arrMicroteachCaseSiteSenateTypeObjLst_Cache
where arrId_MicroteachCaseSiteSenateType.Contains(objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType)
select objMicroteachCaseSiteSenateTypeEN;
return arrMicroteachCaseSiteSenateTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseSiteSenateTypeEN> GetObjLstById_MicroteachCaseSiteSenateTypeLst_WA_Cache(List<string> arrId_MicroteachCaseSiteSenateType)
{
 List<clsMicroteachCaseSiteSenateTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCaseSiteSenateTypeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCaseSiteSenateType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseSiteSenateTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseSiteSenateTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsMicroteachCaseSiteSenateTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseSiteSenateTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseSiteSenateTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsMicroteachCaseSiteSenateTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseSiteSenateTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseSiteSenateTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsMicroteachCaseSiteSenateTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseSiteSenateTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseSiteSenateTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsMicroteachCaseSiteSenateTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseSiteSenateTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_MicroteachCaseSiteSenateType)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN = clsMicroteachCaseSiteSenateTypeWApi.GetObjByid_MicroteachCaseSiteSenateType(strid_MicroteachCaseSiteSenateType);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_MicroteachCaseSiteSenateType.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMicroteachCaseSiteSenateTypeWApi.ReFreshCache();
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
public static int DelMicroteachCaseSiteSenateTypes(List<string> arrid_MicroteachCaseSiteSenateType)
{
string strAction = "DelMicroteachCaseSiteSenateTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_MicroteachCaseSiteSenateType);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMicroteachCaseSiteSenateTypeWApi.ReFreshCache();
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
public static int DelMicroteachCaseSiteSenateTypesByCond(string strWhereCond)
{
string strAction = "DelMicroteachCaseSiteSenateTypesByCond";
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
public static bool AddNewRecord(clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseSiteSenateTypeEN>(objMicroteachCaseSiteSenateTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseSiteSenateTypeEN>(objMicroteachCaseSiteSenateTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateTypeWApi.ReFreshCache();
var strid_MicroteachCaseSiteSenateType = (string)jobjReturn["ReturnStr"];
return strid_MicroteachCaseSiteSenateType;
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
public static bool UpdateRecord(clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN)
{
if (string.IsNullOrEmpty(objMicroteachCaseSiteSenateTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseSiteSenateTypeEN>(objMicroteachCaseSiteSenateTypeEN);
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
 /// <param name = "objMicroteachCaseSiteSenateTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objMicroteachCaseSiteSenateTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseSiteSenateTypeEN.id_MicroteachCaseSiteSenateType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseSiteSenateTypeEN>(objMicroteachCaseSiteSenateTypeEN);
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
public static bool IsExist(string strid_MicroteachCaseSiteSenateType)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCaseSiteSenateType"] = strid_MicroteachCaseSiteSenateType
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
 /// <param name = "objMicroteachCaseSiteSenateTypeENS">源对象</param>
 /// <param name = "objMicroteachCaseSiteSenateTypeENT">目标对象</param>
 public static void CopyTo(clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeENS, clsMicroteachCaseSiteSenateTypeEN objMicroteachCaseSiteSenateTypeENT)
{
try
{
objMicroteachCaseSiteSenateTypeENT.id_MicroteachCaseSiteSenateType = objMicroteachCaseSiteSenateTypeENS.id_MicroteachCaseSiteSenateType; //微格现场评价类型流水号
objMicroteachCaseSiteSenateTypeENT.MicroteachCaseSiteSenateTypeID = objMicroteachCaseSiteSenateTypeENS.MicroteachCaseSiteSenateTypeID; //微格现场评价类型ID
objMicroteachCaseSiteSenateTypeENT.MicroteachCaseSiteSenateTypeName = objMicroteachCaseSiteSenateTypeENS.MicroteachCaseSiteSenateTypeName; //微格现场评价类型名称
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
public static DataTable ToDataTable(List<clsMicroteachCaseSiteSenateTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsMicroteachCaseSiteSenateTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsMicroteachCaseSiteSenateTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsMicroteachCaseSiteSenateTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsMicroteachCaseSiteSenateTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsMicroteachCaseSiteSenateTypeEN.AttributeName)
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
if (clsMicroteachCaseSiteSenateTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseSiteSenateTypeWApi没有刷新缓存机制(clsMicroteachCaseSiteSenateTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCaseSiteSenateType");
//if (arrMicroteachCaseSiteSenateTypeObjLst_Cache == null)
//{
//arrMicroteachCaseSiteSenateTypeObjLst_Cache = await clsMicroteachCaseSiteSenateTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateTypeEN._CurrTabName_S);
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
if (clsMicroteachCaseSiteSenateTypeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsMicroteachCaseSiteSenateTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseSiteSenateTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateTypeEN._CurrTabName_S);
List<clsMicroteachCaseSiteSenateTypeEN> arrMicroteachCaseSiteSenateTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachCaseSiteSenateTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsMicroteachCaseSiteSenateTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName, Type.GetType("System.String"));
foreach (clsMicroteachCaseSiteSenateTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType] = objInFor[conMicroteachCaseSiteSenateType.id_MicroteachCaseSiteSenateType];
objDR[conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID] = objInFor[conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID];
objDR[conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName] = objInFor[conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 微格现场评价类型(MicroteachCaseSiteSenateType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4MicroteachCaseSiteSenateType : clsCommFun4BL
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
clsMicroteachCaseSiteSenateTypeWApi.ReFreshThisCache();
}
}

}