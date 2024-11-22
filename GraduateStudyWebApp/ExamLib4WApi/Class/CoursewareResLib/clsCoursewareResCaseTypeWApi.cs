
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCoursewareResCaseTypeWApi
 表名:CoursewareResCaseType(01120495)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:16
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库
 模块英文名:CoursewareResLib
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
public static class clsCoursewareResCaseTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseTypeEN Setid_CoursewareResCaseType(this clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN, string strid_CoursewareResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CoursewareResCaseType, 4, conCoursewareResCaseType.id_CoursewareResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareResCaseType, 4, conCoursewareResCaseType.id_CoursewareResCaseType);
objCoursewareResCaseTypeEN.id_CoursewareResCaseType = strid_CoursewareResCaseType; //课件资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseTypeEN.dicFldComparisonOp.ContainsKey(conCoursewareResCaseType.id_CoursewareResCaseType) == false)
{
objCoursewareResCaseTypeEN.dicFldComparisonOp.Add(conCoursewareResCaseType.id_CoursewareResCaseType, strComparisonOp);
}
else
{
objCoursewareResCaseTypeEN.dicFldComparisonOp[conCoursewareResCaseType.id_CoursewareResCaseType] = strComparisonOp;
}
}
return objCoursewareResCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseTypeEN SetCoursewareResCaseTypeId(this clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN, string strCoursewareResCaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareResCaseTypeId, conCoursewareResCaseType.CoursewareResCaseTypeId);
clsCheckSql.CheckFieldLen(strCoursewareResCaseTypeId, 4, conCoursewareResCaseType.CoursewareResCaseTypeId);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTypeId, 4, conCoursewareResCaseType.CoursewareResCaseTypeId);
objCoursewareResCaseTypeEN.CoursewareResCaseTypeId = strCoursewareResCaseTypeId; //课件资源案例类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseTypeEN.dicFldComparisonOp.ContainsKey(conCoursewareResCaseType.CoursewareResCaseTypeId) == false)
{
objCoursewareResCaseTypeEN.dicFldComparisonOp.Add(conCoursewareResCaseType.CoursewareResCaseTypeId, strComparisonOp);
}
else
{
objCoursewareResCaseTypeEN.dicFldComparisonOp[conCoursewareResCaseType.CoursewareResCaseTypeId] = strComparisonOp;
}
}
return objCoursewareResCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseTypeEN SetCoursewareResCaseTypeName(this clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN, string strCoursewareResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCoursewareResCaseTypeName, conCoursewareResCaseType.CoursewareResCaseTypeName);
clsCheckSql.CheckFieldLen(strCoursewareResCaseTypeName, 30, conCoursewareResCaseType.CoursewareResCaseTypeName);
objCoursewareResCaseTypeEN.CoursewareResCaseTypeName = strCoursewareResCaseTypeName; //课件资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseTypeEN.dicFldComparisonOp.ContainsKey(conCoursewareResCaseType.CoursewareResCaseTypeName) == false)
{
objCoursewareResCaseTypeEN.dicFldComparisonOp.Add(conCoursewareResCaseType.CoursewareResCaseTypeName, strComparisonOp);
}
else
{
objCoursewareResCaseTypeEN.dicFldComparisonOp[conCoursewareResCaseType.CoursewareResCaseTypeName] = strComparisonOp;
}
}
return objCoursewareResCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCoursewareResCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCoursewareResCaseTypeEN SetMemo(this clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCoursewareResCaseType.Memo);
objCoursewareResCaseTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCoursewareResCaseTypeEN.dicFldComparisonOp.ContainsKey(conCoursewareResCaseType.Memo) == false)
{
objCoursewareResCaseTypeEN.dicFldComparisonOp.Add(conCoursewareResCaseType.Memo, strComparisonOp);
}
else
{
objCoursewareResCaseTypeEN.dicFldComparisonOp[conCoursewareResCaseType.Memo] = strComparisonOp;
}
}
return objCoursewareResCaseTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCoursewareResCaseTypeEN objCoursewareResCaseType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCoursewareResCaseType_Cond.IsUpdated(conCoursewareResCaseType.id_CoursewareResCaseType) == true)
{
string strComparisonOp_id_CoursewareResCaseType = objCoursewareResCaseType_Cond.dicFldComparisonOp[conCoursewareResCaseType.id_CoursewareResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCaseType.id_CoursewareResCaseType, objCoursewareResCaseType_Cond.id_CoursewareResCaseType, strComparisonOp_id_CoursewareResCaseType);
}
if (objCoursewareResCaseType_Cond.IsUpdated(conCoursewareResCaseType.CoursewareResCaseTypeId) == true)
{
string strComparisonOp_CoursewareResCaseTypeId = objCoursewareResCaseType_Cond.dicFldComparisonOp[conCoursewareResCaseType.CoursewareResCaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCaseType.CoursewareResCaseTypeId, objCoursewareResCaseType_Cond.CoursewareResCaseTypeId, strComparisonOp_CoursewareResCaseTypeId);
}
if (objCoursewareResCaseType_Cond.IsUpdated(conCoursewareResCaseType.CoursewareResCaseTypeName) == true)
{
string strComparisonOp_CoursewareResCaseTypeName = objCoursewareResCaseType_Cond.dicFldComparisonOp[conCoursewareResCaseType.CoursewareResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCaseType.CoursewareResCaseTypeName, objCoursewareResCaseType_Cond.CoursewareResCaseTypeName, strComparisonOp_CoursewareResCaseTypeName);
}
if (objCoursewareResCaseType_Cond.IsUpdated(conCoursewareResCaseType.Memo) == true)
{
string strComparisonOp_Memo = objCoursewareResCaseType_Cond.dicFldComparisonOp[conCoursewareResCaseType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCoursewareResCaseType.Memo, objCoursewareResCaseType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCoursewareResCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN)
{
 if (string.IsNullOrEmpty(objCoursewareResCaseTypeEN.id_CoursewareResCaseType) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCoursewareResCaseTypeEN.sf_UpdFldSetStr = objCoursewareResCaseTypeEN.getsf_UpdFldSetStr();
clsCoursewareResCaseTypeWApi.CheckPropertyNew(objCoursewareResCaseTypeEN); 
bool bolResult = clsCoursewareResCaseTypeWApi.UpdateRecord(objCoursewareResCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseTypeWApi.ReFreshCache();
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
 /// <param name = "objCoursewareResCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN)
{
 if (string.IsNullOrEmpty(objCoursewareResCaseTypeEN.id_CoursewareResCaseType) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCoursewareResCaseTypeWApi.IsExist(objCoursewareResCaseTypeEN.id_CoursewareResCaseType) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objCoursewareResCaseTypeEN.id_CoursewareResCaseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsCoursewareResCaseTypeWApi.CheckPropertyNew(objCoursewareResCaseTypeEN); 
bool bolResult = clsCoursewareResCaseTypeWApi.AddNewRecord(objCoursewareResCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseTypeWApi.ReFreshCache();
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
 /// <param name = "objCoursewareResCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN)
{
try
{
clsCoursewareResCaseTypeWApi.CheckPropertyNew(objCoursewareResCaseTypeEN); 
string strid_CoursewareResCaseType = clsCoursewareResCaseTypeWApi.AddNewRecordWithMaxId(objCoursewareResCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseTypeWApi.ReFreshCache();
return strid_CoursewareResCaseType;
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
 /// <param name = "objCoursewareResCaseTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN, string strWhereCond)
{
try
{
clsCoursewareResCaseTypeWApi.CheckPropertyNew(objCoursewareResCaseTypeEN); 
bool bolResult = clsCoursewareResCaseTypeWApi.UpdateWithCondition(objCoursewareResCaseTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseTypeWApi.ReFreshCache();
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
 /// 课件资源案例类型(CoursewareResCaseType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCoursewareResCaseTypeWApi
{
private static readonly string mstrApiControllerName = "CoursewareResCaseTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCoursewareResCaseTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_CoursewareResCaseType(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课件资源案例类型]...","0");
List<clsCoursewareResCaseTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_CoursewareResCaseType";
objDDL.DataTextField="CoursewareResCaseTypeName";
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
public static void BindCbo_id_CoursewareResCaseType(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCoursewareResCaseType.id_CoursewareResCaseType); 
List<clsCoursewareResCaseTypeEN> arrObjLst = clsCoursewareResCaseTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN = new clsCoursewareResCaseTypeEN()
{
id_CoursewareResCaseType = "0",
CoursewareResCaseTypeName = "选[课件资源案例类型]..."
};
arrObjLst.Insert(0, objCoursewareResCaseTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCoursewareResCaseType.id_CoursewareResCaseType;
objComboBox.DisplayMember = conCoursewareResCaseType.CoursewareResCaseTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN)
{
if (!Object.Equals(null, objCoursewareResCaseTypeEN.id_CoursewareResCaseType) && GetStrLen(objCoursewareResCaseTypeEN.id_CoursewareResCaseType) > 4)
{
 throw new Exception("字段[课件资源类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareResCaseTypeEN.CoursewareResCaseTypeId) && GetStrLen(objCoursewareResCaseTypeEN.CoursewareResCaseTypeId) > 4)
{
 throw new Exception("字段[课件资源案例类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCoursewareResCaseTypeEN.CoursewareResCaseTypeName) && GetStrLen(objCoursewareResCaseTypeEN.CoursewareResCaseTypeName) > 30)
{
 throw new Exception("字段[课件资源案例类型名称]的长度不能超过30!");
}
if (!Object.Equals(null, objCoursewareResCaseTypeEN.Memo) && GetStrLen(objCoursewareResCaseTypeEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCoursewareResCaseTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_CoursewareResCaseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsCoursewareResCaseTypeEN GetObjByid_CoursewareResCaseType(string strid_CoursewareResCaseType)
{
string strAction = "GetObjByid_CoursewareResCaseType";
string strErrMsg = string.Empty;
string strResult = "";
clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CoursewareResCaseType"] = strid_CoursewareResCaseType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCoursewareResCaseTypeEN = JsonConvert.DeserializeObject<clsCoursewareResCaseTypeEN>((string)jobjReturn["ReturnObj"]);
return objCoursewareResCaseTypeEN;
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
 /// <param name = "strid_CoursewareResCaseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsCoursewareResCaseTypeEN GetObjByid_CoursewareResCaseType_WA_Cache(string strid_CoursewareResCaseType)
{
string strAction = "GetObjByid_CoursewareResCaseType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CoursewareResCaseType"] = strid_CoursewareResCaseType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCoursewareResCaseTypeEN = JsonConvert.DeserializeObject<clsCoursewareResCaseTypeEN>((string)jobjReturn["ReturnObj"]);
return objCoursewareResCaseTypeEN;
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
public static clsCoursewareResCaseTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN = null;
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
objCoursewareResCaseTypeEN = JsonConvert.DeserializeObject<clsCoursewareResCaseTypeEN>((string)jobjReturn["ReturnObj"]);
return objCoursewareResCaseTypeEN;
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
 /// <param name = "strid_CoursewareResCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCoursewareResCaseTypeEN GetObjByid_CoursewareResCaseType_Cache(string strid_CoursewareResCaseType)
{
if (string.IsNullOrEmpty(strid_CoursewareResCaseType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareResCaseTypeEN._CurrTabName_S);
List<clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Sel =
from objCoursewareResCaseTypeEN in arrCoursewareResCaseTypeObjLst_Cache
where objCoursewareResCaseTypeEN.id_CoursewareResCaseType == strid_CoursewareResCaseType
select objCoursewareResCaseTypeEN;
if (arrCoursewareResCaseTypeObjLst_Sel.Count() == 0)
{
   clsCoursewareResCaseTypeEN obj = clsCoursewareResCaseTypeWApi.GetObjByid_CoursewareResCaseType(strid_CoursewareResCaseType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCoursewareResCaseTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CoursewareResCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCoursewareResCaseTypeNameByid_CoursewareResCaseType_Cache(string strid_CoursewareResCaseType)
{
if (string.IsNullOrEmpty(strid_CoursewareResCaseType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareResCaseTypeEN._CurrTabName_S);
List<clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Sel1 =
from objCoursewareResCaseTypeEN in arrCoursewareResCaseTypeObjLst_Cache
where objCoursewareResCaseTypeEN.id_CoursewareResCaseType == strid_CoursewareResCaseType
select objCoursewareResCaseTypeEN;
List <clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Sel = new List<clsCoursewareResCaseTypeEN>();
foreach (clsCoursewareResCaseTypeEN obj in arrCoursewareResCaseTypeObjLst_Sel1)
{
arrCoursewareResCaseTypeObjLst_Sel.Add(obj);
}
if (arrCoursewareResCaseTypeObjLst_Sel.Count > 0)
{
return arrCoursewareResCaseTypeObjLst_Sel[0].CoursewareResCaseTypeName;
}
string strErrMsgForGetObjById = string.Format("在CoursewareResCaseType对象缓存列表中,找不到记录[id_CoursewareResCaseType = {0}](函数:{1})", strid_CoursewareResCaseType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCoursewareResCaseTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CoursewareResCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_CoursewareResCaseType_Cache(string strid_CoursewareResCaseType)
{
if (string.IsNullOrEmpty(strid_CoursewareResCaseType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareResCaseTypeEN._CurrTabName_S);
List<clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Sel1 =
from objCoursewareResCaseTypeEN in arrCoursewareResCaseTypeObjLst_Cache
where objCoursewareResCaseTypeEN.id_CoursewareResCaseType == strid_CoursewareResCaseType
select objCoursewareResCaseTypeEN;
List <clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Sel = new List<clsCoursewareResCaseTypeEN>();
foreach (clsCoursewareResCaseTypeEN obj in arrCoursewareResCaseTypeObjLst_Sel1)
{
arrCoursewareResCaseTypeObjLst_Sel.Add(obj);
}
if (arrCoursewareResCaseTypeObjLst_Sel.Count > 0)
{
return arrCoursewareResCaseTypeObjLst_Sel[0].CoursewareResCaseTypeName;
}
string strErrMsgForGetObjById = string.Format("在CoursewareResCaseType对象缓存列表中,找不到记录的相关名称[id_CoursewareResCaseType = {0}](函数:{1})", strid_CoursewareResCaseType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCoursewareResCaseTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCoursewareResCaseTypeEN> GetObjLst(string strWhereCond)
{
 List<clsCoursewareResCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareResCaseTypeEN> GetObjLstById_CoursewareResCaseTypeLst(List<string> arrId_CoursewareResCaseType)
{
 List<clsCoursewareResCaseTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_CoursewareResCaseTypeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CoursewareResCaseType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_CoursewareResCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCoursewareResCaseTypeEN> GetObjLstById_CoursewareResCaseTypeLst_Cache(List<string> arrId_CoursewareResCaseType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCoursewareResCaseTypeEN._CurrTabName_S);
List<clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Sel =
from objCoursewareResCaseTypeEN in arrCoursewareResCaseTypeObjLst_Cache
where arrId_CoursewareResCaseType.Contains(objCoursewareResCaseTypeEN.id_CoursewareResCaseType)
select objCoursewareResCaseTypeEN;
return arrCoursewareResCaseTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCoursewareResCaseTypeEN> GetObjLstById_CoursewareResCaseTypeLst_WA_Cache(List<string> arrId_CoursewareResCaseType)
{
 List<clsCoursewareResCaseTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_CoursewareResCaseTypeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CoursewareResCaseType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareResCaseTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCoursewareResCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareResCaseTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCoursewareResCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareResCaseTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCoursewareResCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCoursewareResCaseTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCoursewareResCaseTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCoursewareResCaseTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_CoursewareResCaseType)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN = clsCoursewareResCaseTypeWApi.GetObjByid_CoursewareResCaseType(strid_CoursewareResCaseType);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_CoursewareResCaseType.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCoursewareResCaseTypeWApi.ReFreshCache();
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
public static int DelCoursewareResCaseTypes(List<string> arrid_CoursewareResCaseType)
{
string strAction = "DelCoursewareResCaseTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_CoursewareResCaseType);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCoursewareResCaseTypeWApi.ReFreshCache();
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
public static int DelCoursewareResCaseTypesByCond(string strWhereCond)
{
string strAction = "DelCoursewareResCaseTypesByCond";
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
public static bool AddNewRecord(clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareResCaseTypeEN>(objCoursewareResCaseTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareResCaseTypeEN>(objCoursewareResCaseTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCoursewareResCaseTypeWApi.ReFreshCache();
var strid_CoursewareResCaseType = (string)jobjReturn["ReturnStr"];
return strid_CoursewareResCaseType;
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
public static bool UpdateRecord(clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN)
{
if (string.IsNullOrEmpty(objCoursewareResCaseTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCoursewareResCaseTypeEN.id_CoursewareResCaseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareResCaseTypeEN>(objCoursewareResCaseTypeEN);
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
 /// <param name = "objCoursewareResCaseTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCoursewareResCaseTypeEN objCoursewareResCaseTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCoursewareResCaseTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCoursewareResCaseTypeEN.id_CoursewareResCaseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCoursewareResCaseTypeEN.id_CoursewareResCaseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCoursewareResCaseTypeEN>(objCoursewareResCaseTypeEN);
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
public static bool IsExist(string strid_CoursewareResCaseType)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CoursewareResCaseType"] = strid_CoursewareResCaseType
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
 /// <param name = "objCoursewareResCaseTypeENS">源对象</param>
 /// <param name = "objCoursewareResCaseTypeENT">目标对象</param>
 public static void CopyTo(clsCoursewareResCaseTypeEN objCoursewareResCaseTypeENS, clsCoursewareResCaseTypeEN objCoursewareResCaseTypeENT)
{
try
{
objCoursewareResCaseTypeENT.id_CoursewareResCaseType = objCoursewareResCaseTypeENS.id_CoursewareResCaseType; //课件资源类型流水号
objCoursewareResCaseTypeENT.CoursewareResCaseTypeId = objCoursewareResCaseTypeENS.CoursewareResCaseTypeId; //课件资源案例类型Id
objCoursewareResCaseTypeENT.CoursewareResCaseTypeName = objCoursewareResCaseTypeENS.CoursewareResCaseTypeName; //课件资源案例类型名称
objCoursewareResCaseTypeENT.Memo = objCoursewareResCaseTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCoursewareResCaseTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCoursewareResCaseTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCoursewareResCaseTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCoursewareResCaseTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCoursewareResCaseTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCoursewareResCaseTypeEN.AttributeName)
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
if (clsCoursewareResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareResCaseTypeWApi没有刷新缓存机制(clsCoursewareResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CoursewareResCaseType");
//if (arrCoursewareResCaseTypeObjLst_Cache == null)
//{
//arrCoursewareResCaseTypeObjLst_Cache = await clsCoursewareResCaseTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCoursewareResCaseTypeEN._CurrTabName_S);
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
if (clsCoursewareResCaseTypeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCoursewareResCaseTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCoursewareResCaseTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCoursewareResCaseTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCoursewareResCaseTypeEN._CurrTabName_S);
List<clsCoursewareResCaseTypeEN> arrCoursewareResCaseTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCoursewareResCaseTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCoursewareResCaseTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCoursewareResCaseType.id_CoursewareResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCaseType.CoursewareResCaseTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCaseType.CoursewareResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conCoursewareResCaseType.Memo, Type.GetType("System.String"));
foreach (clsCoursewareResCaseTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCoursewareResCaseType.id_CoursewareResCaseType] = objInFor[conCoursewareResCaseType.id_CoursewareResCaseType];
objDR[conCoursewareResCaseType.CoursewareResCaseTypeId] = objInFor[conCoursewareResCaseType.CoursewareResCaseTypeId];
objDR[conCoursewareResCaseType.CoursewareResCaseTypeName] = objInFor[conCoursewareResCaseType.CoursewareResCaseTypeName];
objDR[conCoursewareResCaseType.Memo] = objInFor[conCoursewareResCaseType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 课件资源案例类型(CoursewareResCaseType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CoursewareResCaseType : clsCommFun4BL
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
clsCoursewareResCaseTypeWApi.ReFreshThisCache();
}
}

}